using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace FOS_Utils
{
    public class FCustomCell : DataGridViewTextBoxCell
    {
        private String type = "";
        public FCustomCell()
            : base()
        {
            //this.Style.Format = "d";
        }
        public FCustomCell(String type)
            : base()
        {
            this.type = type;
            //this.Style.Format = "d";
        }

        public override void InitializeEditingControl(int rowIndex, object
            initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue,
                dataGridViewCellStyle);

            FCustomEditingControl ctl = 
                DataGridView.EditingControl as FCustomEditingControl;
            
            if (this.Value != null)
            {
            
                ctl.Text = this.Value.ToString();
            
            }
        }

        public override Type EditType
        {
            get
            {
                return typeof(FCustomEditingControl);
            }
        }

        public override Type ValueType
        {
            get
            {
                
                return typeof(String);
            }
        }

        public override object DefaultNewRowValue
        {
            get
            {
                
                return "";
            }
        }
    }
}
