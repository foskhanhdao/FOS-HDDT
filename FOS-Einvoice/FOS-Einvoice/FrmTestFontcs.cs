using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FOS_Utils.PDF.PDFLib;

namespace FOS_Einvoice
{
    public partial class FrmTestFontcs : Form
    {
        public FrmTestFontcs()
        {
            InitializeComponent();
        }

        private void fButton1_Click(object sender, EventArgs e)
        {
            PdfHelper.PrintPdfFile(@"F:/output.pdf", fPdfPanel1);
            
        }
    }
}
