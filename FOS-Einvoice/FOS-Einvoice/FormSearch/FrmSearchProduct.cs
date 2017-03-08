
using System;
using System.Data;
namespace FOS_Einvoice
{
    public partial class FrmSearchProduct : FrmBaseSearch
    {
        public FrmSearchProduct()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                DataTable dt = TableInfo.TableProducttype.Get();
                DataRow dr = dt.NewRow();
                dt.Rows.InsertAt(dr, 0);

                producttype1.DataSource = dt;
                producttype2.DataSource = dt.Copy();
                producttype3.DataSource = dt.Copy();

                producttype1.DisplayMember = TableInfo.TableProducttype.COL_NAME_PRODUCT_TYPE_NAME;
                producttype2.DisplayMember = TableInfo.TableProducttype.COL_NAME_PRODUCT_TYPE_NAME;
                producttype3.DisplayMember = TableInfo.TableProducttype.COL_NAME_PRODUCT_TYPE_NAME;

                producttype1.ValueMember = TableInfo.TableProducttype.COL_NAME_PRODUCT_TYPE_CODE;
                producttype2.ValueMember = TableInfo.TableProducttype.COL_NAME_PRODUCT_TYPE_CODE;
                producttype3.ValueMember = TableInfo.TableProducttype.COL_NAME_PRODUCT_TYPE_CODE;
            }
            catch (Exception ex)
            {
            }
        }

        public override DataTable GetData()
        {
            try
            {
                columnHeaderText = new string[] {
                    "Mã sản phẩm"
                    ,"Tên sản phẩm"
                    ,"Loại hàng hóa 1"
                    ,"Loại hàng hóa 2"
                    ,"Loại hàng hóa 3"
                    ,"Đơn vị tính"
                };
                string sql = " select productcode,productname1,t1.producttypename as 'producttypename1' ";
                sql += " ,t2.producttypename as 'producttypename2',t3.producttypename as 'producttypename3' ";
                sql += " ,u.unitname ";
                sql += " from product ";
                sql += " left join producttype t1 on t1.producttypecode = producttype1 ";
                sql += " left join producttype t2 on t2.producttypecode = producttype2 ";
                sql += " left join producttype t3 on t3.producttypecode = producttype3 ";
                sql += " left join unit u on u.unitcode = productunitcode ";
                sql += " where isnull(productstatus,0) = 0 ";
                if (productcode.Text != "")
                {
                    sql += " and productcode like '%' + @productcode + '%' ";
                }
                if (productname1.Text != "")
                {
                    sql += " and productname1 like '%' + @productname1 + '%' ";
                }

                if (producttype1.SelectedValue != null && producttype1.SelectedValue.ToString() != "")
                {
                    sql += " and producttype1 = " + producttype1.SelectedValue;
                }
                if (producttype2.SelectedValue != null && producttype2.SelectedValue.ToString() != "")
                {
                    sql += " and producttype2 = " + producttype2.SelectedValue;
                }
                if (producttype3.SelectedValue != null && producttype3.SelectedValue.ToString() != "")
                {
                    sql += " and producttype3 = " + producttype3.SelectedValue;
                }
                

                return DataBase.GetData(sql
                    , new object[] { "@productcode", "@productname1"}
                    , new object[] { productcode.Text, productname1.Text }
                    ).Tables[0];
                
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        public override void Clear()
        {
            productcode.Text = "";
            productname1.Text = "";
            producttype1.Text = "";
            producttype2.Text = "";
            producttype3.Text = "";
            dgvData.DataSource = null;
            productcode.Focus();
        }

        public override void AdjustAfterGetData()
        {
            try
            {
                for (int i = 0; i < dgvData.Columns.Count; i++)
                {
                    dgvData.Columns[i].Width = 125;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
