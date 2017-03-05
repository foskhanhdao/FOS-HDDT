using System;
using System.Security.Cryptography.X509Certificates;
using iTextSharp.text.pdf.security;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
using Org.BouncyCastle.X509;
using iTextSharp.text;
using FOS_Utils.Forms;
using System.Xml;
using FOS_Utils.PDF.PDFControl;

namespace FOS_Utils.PDF.PDFLib
{
    public class DigitalSignature
    {
        private X509Store store = null;
        private X509Certificate2Collection sel = null;
        X509Certificate2 cert = null;
        public DigitalSignature()
        {
        }

        public void Close()
        {
            try
            {
                cert = null;
                sel = null;
                if (store != null) store.Close();
                store = null;
            }
            catch (Exception ex)
            {
            }
        }
       
        public bool IsUSBTokenExists()
        {
            try
            {
                if (store == null)
                {
                    store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                    store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
                }
                sel = store.Certificates;

                for (int i = sel.Count - 1; i >= 0; i--)
                {
                    if (!sel[i].HasPrivateKey) sel.RemoveAt(i);
                }                

                return sel.Count > 0;
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        public bool IsUSBTokenSelected()
        {
            try
            {
                FrmTokenList frm = new FrmTokenList(sel);
                frm.ShowDialog();
                if (frm.SelectedIndex >= 0)
                {
                    cert = sel[frm.SelectedIndex];
                    return true;
                }
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        //public bool IsValidUSBToken(string taxcode,string companyname) {
        //    try
        //    {
        //        if (store == null)
        //        {
        //            store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
        //            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
        //        }

        //        sel = store.Certificates;

        //        for (int i = 0; i < sel.Count; i++)
        //        {
        //            cert = sel[i];
        //            if (cert.Subject.Contains(taxcode)
        //                || cert.Subject.ToUpper().Contains(companyname.ToUpper())) return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }            
        //    return false;
        //}

        public bool SignPdf(string pathToBasePdf, string pathToBasePdfDest, string pathToSignatureImage
            , int numberOfPage, FosPoint pointAdd, int witdh, int height
            )
        {
            bool result = false;
            try
            {
                Org.BouncyCastle.X509.X509CertificateParser cp = new Org.BouncyCastle.X509.X509CertificateParser();
                Org.BouncyCastle.X509.X509Certificate[] chain = new Org.BouncyCastle.X509.X509Certificate[] {
                cp.ReadCertificate(cert.RawData)};
                IExternalSignature externalSignature = new X509Certificate2Signature(cert, "SHA-1");
                PdfReader pdfReader = new PdfReader(pathToBasePdf);
                FileStream signedPdf = new FileStream(pathToBasePdfDest, FileMode.Create);
                PdfStamper pdfStamper = PdfStamper.CreateSignature(pdfReader, signedPdf, '\0');
                PdfSignatureAppearance signatureAppearance = pdfStamper.SignatureAppearance;

                string text = "";
                if (File.Exists(pathToSignatureImage))
                {
                    signatureAppearance.SignatureGraphic = iTextSharp.text.Image.GetInstance(pathToSignatureImage);
                    signatureAppearance.SignatureRenderingMode = PdfSignatureAppearance.RenderingMode.GRAPHIC;
                }
                else
                {                        
                    signatureAppearance.SignatureRenderingMode = PdfSignatureAppearance.RenderingMode.DESCRIPTION;
                    
                    DateTime curDate = DateTime.Now;

                    text = "Được ký bởi: " + GetPartOfSubject(cert.Subject, "CN=") + "\n"
                    + "Ngày ký: Ngày " + curDate.Day.ToString("00")
                    + " tháng " + curDate.Month.ToString("00")
                    + " năm " + curDate.Year
                    + "  " + curDate.ToString("HH:mm:ss")
                    ;
                    signatureAppearance.Layer2Text = text;
                }
                

                var sigX = pointAdd.XPoint;
                var sigY = pointAdd.YPoint;
                var sigW = witdh;
                var sigH = height;

                string FONT = Application.StartupPath + "\\Fonts\\arial.ttf";

                //PdfTemplate tm = signatureAppearance.GetLayer(2);
                BaseFont bf = BaseFont.CreateFont(FONT, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                //tm.SetFontAndSize(bf,11);
                //tm.SetColorStroke(BaseColor.BLACK);

                iTextSharp.text.Rectangle rec = new iTextSharp.text.Rectangle(sigX, sigY, sigX + sigW, sigY + sigH);

                signatureAppearance.SetVisibleSignature(rec, numberOfPage, "Signature");

                signatureAppearance.Layer2Font = new Font(bf,12) ;

                MakeSignature.SignDetached(signatureAppearance, externalSignature, chain, null, null, null, 0, CryptoStandard.CMS);
                
                //VerifyPdfSignature(pathToBasePdfDest, cert.RawData);
                
                signatureAppearance = null;
                 
                pdfStamper.Close();
                pdfReader.Close();
                signedPdf.Close();
                chain = null;
                cp = null;
                result = File.Exists(pathToBasePdfDest);
            }
            catch (Exception ex)
            {                
            }
            return result;
        }

        /// <summary>
        /// Verifies the signature of a prevously signed PDF document using the specified public key
        /// </summary>
        /// <param name="pdfFile">a Previously signed pdf document</param>
        /// <param name="publicKeyStream">Public key to be used to verify the signature in .cer format</param>
        /// <exception cref="System.InvalidOperationException">Throw System.InvalidOperationException if the document is not signed or the signature could not be verified</exception>
        private bool VerifyPdfSignature(string pdfFile, byte[] publicKeyStream)
        {
            try
            {
                var parser = new X509CertificateParser();
                var certificate = parser.ReadCertificate(publicKeyStream);

                PdfReader reader = new PdfReader(pdfFile);
                AcroFields af = reader.AcroFields;
                var names = af.GetSignatureNames();

                if (names.Count == 0)
                {
                    throw new InvalidOperationException("No Signature present in pdf file.");
                }

                foreach (string name in names)
                {
                    if (!af.SignatureCoversWholeDocument(name))
                    {
                        throw new InvalidOperationException(string.Format("The signature: {0} does not covers the whole document.", name));
                    }

                    PdfPKCS7 pk = af.VerifySignature(name);
                                        
                    var cal = pk.SignDate;
                    var pkc = pk.Certificates;

                    if (!pk.Verify())
                    {
                        //throw new InvalidOperationException("The signature could not be verified.");
                    }
                    if (!pk.VerifyTimestampImprint())
                    {
                        //throw new InvalidOperationException("The signature timestamp could not be verified.");
                    }

                    CertificateVerification.VerifyCertificates(pkc, new Org.BouncyCastle.X509.X509Certificate[] { certificate }, null, cal);
                    

                    //IList<VerificationException>[] fails = CertificateVerification.VerifyCertificates(pkc, new Org.BouncyCastle.X509.X509Certificate[] { certificate }, null, cal);
                    //if (fails != null)
                    //{
                    //    throw new InvalidOperationException("The file is not signed using the specified key-pair.");
                    //}
                }
                reader.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region "static function"
        public static string GetPartOfSubject(string sub, string alias)
        {
            try
            {
                string[] spl = sub.Split(new char[] { ',' });
                string tmp = "";
                for (int i = 0; i < spl.Length; i++)
                {
                    tmp = spl[i].Trim();
                    if (tmp.ToUpper().StartsWith(alias.ToUpper()))
                    {
                        return tmp.Substring(alias.Length);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return "";
        }
        #endregion
        #region Test
        public bool SignPdf(string pathToBasePdf, string pathToBasePdfDest, string pathToSignatureImage
            , int numberOfPage, FPdfLabel ctPrint, FPdfPanel panelMain
            )
        {
            bool result = false;
            try
            {
                Org.BouncyCastle.X509.X509CertificateParser cp = new Org.BouncyCastle.X509.X509CertificateParser();
                Org.BouncyCastle.X509.X509Certificate[] chain = new Org.BouncyCastle.X509.X509Certificate[] {
                cp.ReadCertificate(cert.RawData)};
                IExternalSignature externalSignature = new X509Certificate2Signature(cert, "SHA-1");
                PdfReader pdfReader = new PdfReader(pathToBasePdf);
                FileStream signedPdf = new FileStream(pathToBasePdfDest, FileMode.Create);
                PdfStamper pdfStamper = PdfStamper.CreateSignature(pdfReader, signedPdf, '\0');
                PdfSignatureAppearance signatureAppearance = pdfStamper.SignatureAppearance;

                string text = "";
                if (File.Exists(pathToSignatureImage))
                {
                    signatureAppearance.SignatureGraphic = iTextSharp.text.Image.GetInstance(pathToSignatureImage);
                    signatureAppearance.SignatureRenderingMode = PdfSignatureAppearance.RenderingMode.GRAPHIC;
                }
                else
                {
                    signatureAppearance.SignatureRenderingMode = PdfSignatureAppearance.RenderingMode.DESCRIPTION;

                    DateTime curDate = DateTime.Now;

                    text = "Được ký bởi: " + GetPartOfSubject(cert.Subject, "CN=") + "\n"
                    + "Ngày ký: Ngày " + curDate.Day.ToString("00")
                    + " tháng " + curDate.Month.ToString("00")
                    + " năm " + curDate.Year
                    + "  " + curDate.ToString("HH:mm:ss")
                    ;
                    signatureAppearance.Layer2Text = text;
                }

                FosPoint point = new FosPoint(ctPrint.Location.X,ctPrint.Location.Y);
                var sigX = point.XPoint;
                var sigY = point.YPoint;
                var sigW = ctPrint.Size.Width;
                var sigH = ctPrint.Size.Height;
                // Lay font

                string fullPatch = Path.GetPathRoot(Environment.SystemDirectory) + @"WINDOWS\Fonts";
                string fontName = PdfHelper.GetSystemFontFileName(ctPrint.Font);
                BaseFont bf = BaseFont.CreateFont(fullPatch + @"\" + fontName, BaseFont.IDENTITY_H, true);
                //tm.SetFontAndSize(bf,11);
                //tm.SetColorStroke(BaseColor.BLACK);

                iTextSharp.text.Rectangle rec = new iTextSharp.text.Rectangle(sigX, sigY, sigX + sigW, sigY + sigH);

                signatureAppearance.SetVisibleSignature(rec, numberOfPage, "Signature");

                signatureAppearance.Layer2Font = new Font(bf, 12);

                MakeSignature.SignDetached(signatureAppearance, externalSignature, chain, null, null, null, 0, CryptoStandard.CMS);

                //VerifyPdfSignature(pathToBasePdfDest, cert.RawData);

                signatureAppearance = null;

                pdfStamper.Close();
                pdfReader.Close();
                signedPdf.Close();
                chain = null;
                cp = null;
                result = File.Exists(pathToBasePdfDest);
            }
            catch (Exception ex)
            {
            }
            return result;
        }
        #endregion
    }
}
