using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FOS_Einvoice
{
    public partial class FrmLicenseConfirm : FrmBase
    {
        public FrmLicenseConfirm()
        {
            InitializeComponent();
            string sn = "";
            using (FOS_SK.InvoiceKeys k = new FOS_SK.InvoiceKeys()) {
                sn = k.Create(new string[] { 
                    "0000001"
                    ,"0001000"
                    ,"TS"
                    ,"17"
                    ,"E"
                    ,"KH0001"
                });
            }
            txtSerialNumber.Text = sn;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSerialNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {                
                using (FOS_SK.InvoiceKeys k = new FOS_SK.InvoiceKeys())
                {
                    k.GetKeys(txtSerialNumber.Text);
                    lblNumberFrom.Text = k.invoicecodefrom;
                    lblNumberTo.Text = k.invoicecodeto;
                    lblSymbol1.Text = k.symbol1;
                    lblSymbol2.Text = k.symbol2;
                    lblSymbol3.Text = k.symbol3;

                    lblSymbolSepa.Visible = lblSymbol1.Text != "";
                }
            }
            catch (Exception ex)
            {
            }
        }

        private bool IsValidSerialNumber()
        {
            try
            {
                if (lblSymbol1.Text.Length < 2) return false;
                if (lblSymbol2.Text.Length < 2) return false;
                if (lblSymbol3.Text.Length < 1) return false;
                if (lblNumberFrom.Text.Length < 7) return false;
                if (lblNumberTo.Text.Length < 7) return false;

                decimal from = CommonFunctions.TryParseDecimal(lblNumberFrom.Text, 0);
                decimal to = CommonFunctions.TryParseDecimal(lblNumberTo.Text, 0);

                if (from == 0 || to == 0 || from >= to) return false;
            }
            catch (Exception ex)
            {
            }
            return true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tiến hàng đăng ký sử dụng ?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                if (IsValidSerialNumber())
                {
                    bool isok = TableInfo.TableInvoice.Init(new object[] { 
                        lblNumberFrom.Text,lblNumberTo.Text
                        ,lblSymbol1.Text,lblSymbol2.Text,lblSymbol3.Text
                        ,lblTemplate.Text
                        ,"usercode"
                        ,"username"
                    });
                    if (isok) MessageBox.Show("Đăng ký sử dụng thành công!");
                    else MessageBox.Show("Có lỗi trong quá trình đăng ký sử dụng!");
                }
                else
                {
                    MessageBox.Show("Serial Number không chính xác !");
                    txtSerialNumber.Focus();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
