using System;
using System.Windows.Forms;
using FOS_Utils.PDF.PDFLib;
using System.Data;
using FOS_Einvoice.Invoices;

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
            //PdfHelper.BeginPrint(@"F:/output.pdf", invoiceGTGT1.pnlMain);
            //PdfHelper.PrintPdfFile();
            //PdfHelper.EndPrint();
            //invoiceGTGTExamp ex = new invoiceGTGTExamp();
            PrintHelper.BeginPrint(invoiceGTGT1.pnlMain);
            PrintHelper.ViewBeforPrint();
            PrintHelper.EndPrint();
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
