using System;
using System.Windows.Forms;
using FOS_Utils.PDF.PDFLib;
using System.Data;

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
            invoiceGTGT1.SetValue(CreateDataSource(), 0);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            PdfHelper.BeginPrint(@"D:/output.pdf", new PagePdf(PageType.A4));
            PdfHelper.PrintPdfFile(invoiceGTGT1.pnlMain,new PagePdf(PageType.A4));
            PdfHelper.EndPrint();

            PrintHelper.BeginPrint(invoiceGTGT1.pnlMain);
            PrintHelper.ViewBeforPrint();
            PrintHelper.EndPrint();
        }

        private DataTable CreateDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("cusname", typeof(string));

            dt.Rows.Add(new object[] {"Trần Văn Tý"});
            return dt;
        }
    }
}
