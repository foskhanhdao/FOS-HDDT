using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace FOS_Utils
{
    public class FCheckBoxColumn : DataGridViewColumn
    {
        public FCheckBoxColumn()
            : base(new FCheckBoxCell())
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
                    !value.GetType().IsAssignableFrom(typeof(FCheckBoxCell)))
                {
                    throw new InvalidCastException("Must be a TextBoxCell");
                }
                base.CellTemplate = value;
            }
        }
    }
}
