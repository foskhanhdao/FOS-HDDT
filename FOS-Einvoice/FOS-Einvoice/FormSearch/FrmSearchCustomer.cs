
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
                string sql = " select customercode,customertaxcode,customername,customerbirthday ";
                sql += " ,(case when customersex = '1' then 'Nam' when customersex = '0' then 'Nữ' else '' end) as 'customersex' ";
                sql += " ,customercompanyname,customeraddress,customeremail,customerphone,customerfax,customernote from customer ";
                sql += " where isnull(customerstate,'0') = 0 ";
                if (txtCuscode.Text != "")
                {
                    sql += " and customercode like '%' + @customercode + '%' ";
                }
                if (txtCusname.Text != "")
                {
                    sql += " and customername like '%' + @customername + '%' ";
                }
                if (txtTaxcode.Text != "")
                {
                    sql += " and customertaxcode like '%' + @customertaxcode + '%' ";
                }
                if (txtAddress.Text != "")
                {
                    sql += " and customeraddress like '%' + @customeraddress + '%' ";
                }

                return DataBase.GetData(sql
                    , new object[] { "@customercode", "@customername", "@customertaxcode", "@customeraddress" }
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
                    dgvData.Columns["customerbirthday"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvData.Columns["customerbirthday"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                    dgvData.Columns["customercode"].Width = 150;
                    dgvData.Columns["customername"].Width = 150;
                    dgvData.Columns["customercompanyname"].Width = 150;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
