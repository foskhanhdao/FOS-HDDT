using System;
using System.Windows.Forms;
using FOS_Utils.PDF.PDFLib;
using System.Data;
using System.IO;

namespace FOS_Einvoice
{
    public partial class FrmTestPDF : Form
    {
        public FrmTestPDF()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //invoiceGTGT1.pnlMain.DataSource = CreateDataSource();
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {


            invoiceGTGT1.pnlDetail.BackgroundImage = global::FOS_Einvoice.Properties.Resources.fos_invoice_logo_detail1;

           // PrintToPdf();
            string p1 = @"F:/HDGTGT_0000001_TEMP.pdf";
            PdfHelper.PrintPdfFile(p1, invoiceGTGT1.pnlMain);
            //invoiceGTGTExamp ex = new invoiceGTGTExamp();
            //PrintHelper.BeginPrint(invoiceGTGT1.pnlMain);
            //PrintHelper.ViewBeforPrint();
            //PrintHelper.EndPrint();
        }

        private void PrintToPdf()
        {
            string p1 = @"D:/HDGTGT_0000001_TEMP.pdf";
            string p2 = @"D:/HDGTGT_0000001.pdf";

            FOS_Utils.PDF.PDFLib.DigitalSignature sig = new DigitalSignature();
            if (sig.IsUSBTokenExists())
            {
                if (sig.IsUSBTokenSelected())
                {
                    //START:GOM LẠI THÀNH 1 HÀM
                    //PdfHelper.BeginPrint(p1, invoiceGTGT1.pnlMain);
                    PdfHelper.PrintPdfFile(p1,invoiceGTGT1.pnlMain);
                    //PdfHelper.EndPrint();
                    //END:GOM LAI THANH 1 HAM

                    string mst = Application.StartupPath + "\\img\\mst.png";

                    //if (!sig.SignPdf(p1, p2, "", 1, new FosPoint(380, 120), 350, 50))
                    if (!sig.SignPdf(p1,p2,1,invoiceGTGT1.pnlSignature,invoiceGTGT1.pnlMain))
                    {
                        MessageBox.Show("Xuất hóa đơn không thành công!");                        
                        if (File.Exists(p1)) File.Delete(p2);
                    }                    
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại USB Token");
            }
            sig.Close();
            if (File.Exists(p1)) File.Delete(p1);
        }

        private DataTable CreateDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("cusname", typeof(string));
            dt.Rows.Add(new object[] {"1"});
            dt.Rows.Add(new object[] { "2" });
            return dt;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            invoiceGTGT1.pnlDetail.BackgroundImage = global::FOS_Einvoice.Properties.Resources.fos_invoice_logo_detail1;

            //PrintHelper.BeginPrint(invoiceGTGT1.pnlMain);
            //PrintHelper.ViewBeforPrint();
            //PrintHelper.EndPrint();
            PrintHelper.Print(invoiceGTGT1.pnlMain, true);
        }

        private void btnMau_Click(object sender, EventArgs e)
        {
            invoiceGTGT1.pnlDetail.BackgroundImage = global::FOS_Einvoice.Properties.Resources.fos_invoice_logo_detail_mauphathanh;
            PrintToPdf();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
