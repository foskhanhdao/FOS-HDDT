using System;
using System.Windows.Forms;
namespace FOS_Utils
{
    public class FCalendarColumn : DataGridViewColumn
    {
        public FCalendarColumn(String format)
            : base(new FCalendarCell(format))
        {
        }
        public FCalendarColumn()
            : base(new FCalendarCell())
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
                !value.GetType().IsAssignableFrom(typeof(FCalendarCell)))
            {
                throw new InvalidCastException("Must be a FCalendarCell");
            }
            base.CellTemplate = value;
        }
    }
        }

}

