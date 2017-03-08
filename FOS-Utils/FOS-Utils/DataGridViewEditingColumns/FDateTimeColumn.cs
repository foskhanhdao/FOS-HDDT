using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace FOS_Utils
{
    public class FDateTimeColumn : DataGridViewColumn
    {
        public FDateTimeColumn()
            : base(new FDateTimeCell())
        {
            
        }

        public FDateTimeColumn(string format)
            : base(new FDateTimeCell(format))
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
                    !value.GetType().IsAssignableFrom(typeof(FDateTimeCell)))
                {
                    throw new InvalidCastException("Must be a TextBoxCell");
                }
                base.CellTemplate = value;
            }
        }
    }
}
