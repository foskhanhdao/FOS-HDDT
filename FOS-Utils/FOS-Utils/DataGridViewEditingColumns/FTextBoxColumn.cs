using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace FOS_Utils
{
    public class FTextBoxColumn : DataGridViewColumn
    {
        public FTextBoxColumn()
            : base(new FTextBoxCell())
        {
        }
        public FTextBoxColumn(int maxLength)
            : base(new FTextBoxCell(maxLength))
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
                    !value.GetType().IsAssignableFrom(typeof(FTextBoxCell)))
                {
                    throw new InvalidCastException("Must be a FTextBoxCell");
                }
                base.CellTemplate = value;
            }
        }
    }
}
