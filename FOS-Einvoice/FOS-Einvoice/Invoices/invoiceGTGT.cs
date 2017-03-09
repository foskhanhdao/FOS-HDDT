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
            lblDateCreate.Text = "Ngày " + DateTime.Now.Day.ToString("00")
                + " tháng " + DateTime.Now.Month.ToString("00")
                + " năm " + DateTime.Now.Year;
        }

        public void SetValue(DataTable dt,int idx)
        {
            SetValue(dt, idx, pnlContents);
        }
        public void SetValue(DataTable dt,int idx,FPdfPanel pnl)
        {
            try
            {
                FPdfLabel lbl = null;
                FPdfText txt = null;
                foreach (Control ctrl in pnl.Controls)
                {
                    if (ctrl is FPdfLabel)
                    {
                        lbl = ctrl as FPdfLabel;
                        if (dt.Columns.Contains(lbl.FPdfProperties.TableColumn))
                        {
                            lbl.Text = dt.Rows[0][lbl.FPdfProperties.TableColumn].ToString();
                        }
                    }
                    else if (ctrl is FPdfText)
                    {
                        txt = ctrl as FPdfText;
                        if (dt.Columns.Contains(txt.FPdfProperties.TableColumn))
                        {
                            txt.Text = dt.Rows[0][txt.FPdfProperties.TableColumn].ToString();
                        }
                    }
                    else if (ctrl is FPdfPanel)
                    {
                        SetValue(dt, idx,ctrl as FPdfPanel);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }      
    }
}
