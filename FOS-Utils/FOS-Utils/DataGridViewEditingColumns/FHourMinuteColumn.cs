using System;
using System.Windows.Forms;
namespace FOS_Utils
{
    public class FHourMinuteColumn : DataGridViewColumn
    {
        public FHourMinuteColumn(String format)
            : base(new FHourMinuteCell(format))
        {
        }
        public FHourMinuteColumn()
            : base(new FHourMinuteCell())
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
                !value.GetType().IsAssignableFrom(typeof(FHourMinuteCell)))
            {
                throw new InvalidCastException("Must be a CalendarCell");
            }
            base.CellTemplate = value;
        }
    }
        }

}

