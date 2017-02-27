
using System;
using System.Data;
namespace FOS_Einvoice
{
    public partial class FrmSearchCustomer : FrmBaseSearch
    {
        public FrmSearchCustomer()
        {
            InitializeComponent();
        }                

        public override DataTable GetData()
        {
            try
            {
                columnHeaderText = new string[] {
                    "Mã khách hàng"
                    ,"Mã số thuế"
                    ,"Tên khách hàng"
                    ,"Ngày sinh"
                    ,"Giới tính"
                    ,"Tên công ty"                    
                    ,"Địa chỉ"
                    ,"Email"
                    ,"Điện thoại"
                    ,"Fax"
                    ,"Ghi chú"
                };
                string sql = " select cuscode,taxcode,cusname,cusbirthday ";
                sql += " ,(case when cussex = '1' then 'Nam' when cussex = '0' then 'Nữ' else '' end) as 'cussex' ";
                sql += " ,companyname,cusaddress,email,phone,fax,note from customer ";
                sql += " where isnull(cusstate,'0') = 0 ";
                if (txtCuscode.Text != "")
                {
                    sql += " and cuscode like '%' + @cuscode + '%' ";
                }
                if (txtCusname.Text != "")
                {
                    sql += " and cusname like '%' + @cusname + '%' ";
                }
                if (txtTaxcode.Text != "")
                {
                    sql += " and taxcode like '%' + @taxcode + '%' ";
                }
                if (txtAddress.Text != "")
                {
                    sql += " and cusaddress like '%' + @cusaddress + '%' ";
                }

                return DataBase.GetData(sql
                    , new object[] { "@cuscode", "@cusname", "@taxcode", "@cusaddress" }
                    ,new object[] {txtCuscode.Text,txtCusname.Text,txtTaxcode.Text,txtAddress.Text}
                    ).Tables[0];
                
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        public override void Clear()
        {
            txtCuscode.Text = "";
            txtCusname.Text = "";
            txtTaxcode.Text = "";
            txtAddress.Text = "";
            dgvData.DataSource = null;
            txtCuscode.Focus();
        }

        public override void AdjustAfterGetData()
        {
            try
            {
                if (dgvData.ColumnCount > 0)
                {
                    dgvData.Columns["cusbirthday"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvData.Columns["cusbirthday"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                    dgvData.Columns["cuscode"].Width = 150;
                    dgvData.Columns["cusname"].Width = 150;
                    dgvData.Columns["companyname"].Width = 150;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
