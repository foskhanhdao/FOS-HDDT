using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace FOS_Utils
{
    public class FCustomColumn : DataGridViewColumn
    {
        public String cellType = FCellTypes.STRING;
        public FCustomColumn()
            : base(new FCustomCell())
        {
        }
        
        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(FCustomCell)))
                {
                    throw new InvalidCastException("Must be a TextBoxCell");
                }
                base.CellTemplate = value;
            }
        }

        public void setCellType(String type)
        {
            this.cellType = type;
        }
    }
}
