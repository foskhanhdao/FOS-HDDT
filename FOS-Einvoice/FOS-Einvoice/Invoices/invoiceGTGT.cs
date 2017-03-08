using System.Windows.Forms;
using System.Data;
using FOS_Utils.PDF.PDFControl;
using System;

namespace FOS_Einvoice.Invoices
{
    public partial class invoiceGTGT : UserControl
    {
        public invoiceGTGT()
        {
            InitializeComponent();
        }

        public void SetValue(DataTable dt,int idx)
        {
            SetValue(dt, idx, pnlContents);
        }
        public void SetValue(DataTable dt,int idx,FPdfPanel pnl)
        {
            try
            {
                foreach (Control ctrl in pnl.Controls)
                {
                    if (ctrl is FPdfPanel) SetValue(dt, idx, ctrl as FPdfPanel);
                    else if (ctrl is FPdfLabel)
                    {
                        FPdfLabel lbl = ctrl as FPdfLabel;
                        if (dt.Columns.Contains(lbl.ColumnName))
                        {
                            lbl.Text = dt.Rows[idx][lbl.ColumnName].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }      
    }
}
