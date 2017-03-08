using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace FOS_Utils
{
    public class FNumberColumn : DataGridViewColumn
    {
        public FNumberColumn()
            : base(new FNumberCell())
        {
        }

        public FNumberColumn(string format)
            : base(new FNumberCell(format))
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
                    !value.GetType().IsAssignableFrom(typeof(FNumberCell)))
                {
                    throw new InvalidCastException("Must be a TextBoxCell");
                }
                base.CellTemplate = value;
            }
        }
    }
}
