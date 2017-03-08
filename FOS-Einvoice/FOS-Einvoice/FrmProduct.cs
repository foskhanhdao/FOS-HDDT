using System;
using System.Windows.Forms;
using System.Collections;
using System.Data;

namespace FOS_Einvoice
{
    public partial class FrmProduct : FOS_Einvoice.FrmBaseMaster
    {
        public FrmProduct()
        {
            InitializeComponent();            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //Primary key controls
            ctrlPrimaryKey = new ArrayList(new Control[] { productcode });
            //Not primary key controls
            InitDataControls(this.groupBox1);
            //Table Name
            TableName = TableInfo.TableNames.PRODUCT;
            getdateColumnNamesInsert = new string[] { "productdatecreate" };
            getdateColumnNamesUpdate = new string[] { "productdateupdate" };
            GetProducttype();
            GetUnit();
        }

        private void GetProducttype()
        {
            try
            {
                string sql = " select producttypecode,producttypename from producttype order by producttypecode ";
                DataTable dt = DataBase.GetData(sql).Tables[0];

                DataRow dr = dt.NewRow();
                dt.Rows.InsertAt(dr, 0);
                producttype1.DataSource = dt;
                producttype2.DataSource = dt.Copy();
                producttype3.DataSource = dt.Copy();

                producttype1.DisplayMember = "producttypename";
                producttype1.ValueMember = "producttypecode";
                producttype2.DisplayMember = "producttypename";
                producttype2.ValueMember = "producttypecode";
                producttype3.DisplayMember = "producttypename";
                producttype3.ValueMember = "producttypecode";
            }
            catch (Exception ex)
            {
            }
        }

        private void GetUnit()
        {
            try
            {
                DataTable dt = TableInfo.TableUnit.Get();
                DataRow dr = dt.NewRow();
                dt.Rows.InsertAt(dr, 0);

                productunitcode.DataSource = dt;
                productunitcode.DisplayMember = TableInfo.TableUnit.COL_NAME_UNIT_NAME;
                productunitcode.ValueMember = TableInfo.TableUnit.COL_NAME_UNIT_CODE;
            }
            catch (Exception ex)
            {
            }
        }

        public override void SetDefaultFocus()
        {
            if (productcode.Enabled) productcode.Focus();
            else productname1.Focus();
        }

        public override void SetEnableControls(bool en, bool isNew)
        {
            base.SetEnableControls(en, isNew);
            btnCompanycode.Enabled = !en;
            btnDelete.Enabled = !isNew;
            if (isNew) lblStatus.Text = "Tạo mới";
            else lblStatus.Text = "Chỉnh sửa";
        }

        private void btnCompanycode_Click(object sender, EventArgs e)
        {
            FrmSearchProduct frm = new FrmSearchProduct();
            frm.ShowDialog();
            if (frm.result != null)
            {
                productcode.Text = frm.result.Cells[TableInfo.TableProduct.COL_NAME_PRODUCT_CODE].Value.ToString();
                GetData();
            }
           
        }
    }
}
