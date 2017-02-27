using System;
using System.Windows.Forms;
using System.Collections;

namespace FOS_Einvoice
{
    public partial class FrmCompany : FOS_Einvoice.FrmBaseMaster
    {
        public FrmCompany()
        {
            InitializeComponent();
            //Primary key controls
            ctrlPrimaryKey = new ArrayList(new Control[] { companycode });
            //Not primary key controls
            InitDataControls(this.groupBox1);
            //Table Name
            TableName = TableInfo.TableNames.COMPANY;
            getdateColumnNamesInsert = new string[] { "companydatecreate" };
            getdateColumnNamesUpdate = new string[] { "companydateupdate" };
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        public override void SetDefaultFocus()
        {
            if (companycode.Enabled) companycode.Focus();
            else companyname.Focus();
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
            FrmSearchCompany frm = new FrmSearchCompany();
            frm.ShowDialog();
            if (frm.result != null)
            {
                companycode.Text = frm.result.Cells["companycode"].Value.ToString();
                GetData();
            }
        }
    }
}
