using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace FOS_Einvoice
{
    public partial class FrmCustomer : FOS_Einvoice.FrmBaseMaster
    {
        public FrmCustomer()
        {
            InitializeComponent();
            //Primary key controls
            ctrlPrimaryKey = new ArrayList(new Control[] { cuscode });
            //Not primary key controls
            InitDataControls(this.groupBox1);
            //Table Name
            TableName = TableInfo.TableNames.CUSTOMER;
            getdateColumnNamesInsert = new string[] { "datecreate"};
            getdateColumnNamesUpdate = new string[] { "dateupdate" };
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //Init data for controls
            InitData();
        }

        private void InitData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("cussex", typeof(string));
            dt.Columns.Add("cussexname", typeof(string));
            dt.Rows.Add(new object[] {"0","Nữ"});
            dt.Rows.Add(new object[] { "1", "Nam" });
            cussex.DataSource = dt;
            cussex.DisplayMember = "cussexname";
            cussex.ValueMember = "cussex";
        }

        public override void SetEnableControls(bool en, bool isNew)
        {
            base.SetEnableControls(en,isNew);
            btnCuscode.Enabled = !en;
            btnDelete.Enabled = !isNew;
            if (isNew) lblStatus.Text = "Tạo mới";
            else lblStatus.Text = "Chỉnh sửa";
        }

        private void btnCuscode_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSearchCustomer frm = new FrmSearchCustomer();
                frm.ShowDialog();
                if (frm.result != null)
                {
                    cuscode.Text = frm.result.Cells[TableInfo.TableCustomer.Col_cuscode].Value.ToString();
                    GetData();
                }
            }
            catch (Exception ex)
            {
            }
        }
        public override void SetDefaultFocus()
        {
            if (cuscode.Enabled) cuscode.Focus();
            else cuspass.Focus();
        }

    }
}
