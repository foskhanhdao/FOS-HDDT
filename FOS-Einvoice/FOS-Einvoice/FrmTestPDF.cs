using System;
using System.Windows.Forms;
using FOS_Utils.PDF.PDFLib;
using System.Data;
using FOS_Einvoice.Invoices;
using System.Security.Cryptography.X509Certificates;

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
          
            PdfHelper.PrintPdfFile(@"D:/output.pdf", invoiceGTGT1.pnlMain);
            DigitalSignature d = new DigitalSignature();
            if (d.IsUSBTokenExists()&& d.IsUSBTokenSelected())
            {
                d.SignPdf(@"D:/output.pdf", @"D:/outputSign.pdf", 1, invoiceGTGT1.panelSign, invoiceGTGT1.pnlMain);
            }
            
           
            //PdfHelper.DigitalSignaturePdf(@"D:/output.pdf", @"D:/outputSign.pdf", 1, new FosPoint(100,0), 300, 50);
            //invoiceGTGTExamp ex = new invoiceGTGTExamp();
            //PrintHelper.BeginPrint(invoiceGTGT1.pnlMain);
            //PrintHelper.ViewBeforPrint();
            //PrintHelper.EndPrint();
        }

        private DataTable CreateDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("cusname", typeof(string));
            dt.Rows.Add(new object[] {"1"});
            dt.Rows.Add(new object[] { "2" });
            return dt;
        }
    }
}
