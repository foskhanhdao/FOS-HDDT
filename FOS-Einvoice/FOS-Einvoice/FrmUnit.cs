using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FOS_Einvoice
{
    public partial class FrmUnit : FOS_Einvoice.FrmBaseMaster
    {
        public FrmUnit()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //Primary key controls
            ctrlPrimaryKey = new ArrayList(new Control[] { unitcode });
            //Not primary key controls
            InitDataControls(this.groupBox1);
            //Table Name
            TableName = TableInfo.TableNames.UNIT;
        }

        public override void SetDefaultFocus()
        {
            if (unitcode.Enabled) unitcode.Focus();
            else if (unitname.Enabled) unitname.Focus();
        }
    }
}
