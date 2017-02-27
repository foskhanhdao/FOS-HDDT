using System;
using System.Windows.Forms;
using FOS_Utils.PDF.PDFLib;

namespace FOS_Einvoice
{
    public partial class FrmTestPDF : Form
    {
        public FrmTestPDF()
        {
            InitializeComponent();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            PrintHelper.BeginPrint(invoiceGTGT1.pnlMain);
            PrintHelper.ViewBeforPrint();
            PrintHelper.EndPrint();
        }
    }
}
