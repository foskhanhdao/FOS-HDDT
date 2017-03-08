
using System;
using System.Data;
namespace FOS_Einvoice
{
    public partial class FrmSearchCompany : FrmBaseSearch
    {
        public FrmSearchCompany()
        {
            InitializeComponent();
        }                

        public override DataTable GetData()
        {
            try
            {
                columnHeaderText = new string[] {
                    "Mã công ty"
                    ,"Mã số thuế"
                    ,"Tên công ty"                    
                    ,"Địa chỉ"
                    ,"Điện thoại"
                    ,"Fax"                    
                    ,"Website"
                    ,"Email"
                    ,"Số tài khoản"
                    ,"Tên ngân hàng"
                    ,"Ghi chú"
                };
                string sql = " select companycode,companytaxcode,companyname,companyaddress,companyphone ";
                sql += " ,companyfax,companywebsite,companyemail,companybankaccount,companybankname,companynote from company ";
                sql += " where 1 = 1 ";
                if (companycode.Text != "")
                {
                    sql += " and companycode like '%' + @companycode + '%' ";
                }
                if (companyname.Text != "")
                {
                    sql += " and companyname like '%' + @companyname + '%' ";
                }
                if (taxcode.Text != "")
                {
                    sql += " and companytaxcode like '%' + @companytaxcode + '%' ";
                }
                if (companyaddress.Text != "")
                {
                    sql += " and companyaddress like '%' + @companyaddress + '%' ";
                }

                return DataBase.GetData(sql
                    , new object[] { "@companycode", "@companyname", "@companytaxcode", "@companyaddress" }
                    ,new object[] {companycode.Text,companyname.Text,taxcode.Text,companyaddress.Text}
                    ).Tables[0];
                
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        public override void Clear()
        {
            companycode.Text = "";
            companyname.Text = "";
            taxcode.Text = "";
            companyaddress.Text = "";
            dgvData.DataSource = null;
            companycode.Focus();
        }

        public override void AdjustAfterGetData()
        {
            try
            {
                //if (dgvData.ColumnCount > 0)
                //{
                //    dgvData.Columns["cusbirthday"].DefaultCellStyle.Format = "dd/MM/yyyy";
                //    dgvData.Columns["cusbirthday"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                //    dgvData.Columns["cuscode"].Width = 150;
                //    dgvData.Columns["cusname"].Width = 150;
                //    dgvData.Columns["companyname"].Width = 150;
                //}
            }
            catch (Exception ex)
            {
            }
        }
    }
}
