using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FOS_Einvoice
{
    public partial class FrmProducttype : FOS_Einvoice.FrmBaseMaster
    {
        public FrmProducttype()
        {
            InitializeComponent();           
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            TableName = TableInfo.TableNames.PRODUCTTYPE;
            ctrlPrimaryKey = new System.Collections.ArrayList(new Control[] { txtCode});
            //Not primary key controls
            InitDataControls(this.groupBox1);
        }
        

        public override void SetDefaultFocus()
        {
            if (txtCode.Enabled) txtCode.Focus();
            else if (txtName.Enabled) txtName.Focus();
        }
    }
}
