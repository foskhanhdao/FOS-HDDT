using System;
using System.Windows.Forms;

namespace FOS_Einvoice
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (this.ActiveControl is Button)
                    {
                        (this.ActiveControl as Button).PerformClick();
                    }
                    else {
                        this.SelectNextControl(this.ActiveControl, true, true, true, true);
                        if (this.ActiveControl is TextBox)
                        {
                            (this.ActiveControl as TextBox).SelectAll();
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
