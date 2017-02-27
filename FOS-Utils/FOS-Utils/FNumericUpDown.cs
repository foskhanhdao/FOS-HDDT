using System.Windows.Forms;
using System;

namespace FOS_Utils
{
    public class FNumericUpDown:NumericUpDown,IControl
    {
        private string _columnName = "";
        public string ColumnName
        {
            get { return _columnName; }
            set { _columnName = value; }
        }

        public object DBValue
        {
            get { return this.Value; }
            set {
                try
                {
                    this.Value = Convert.ToDecimal(value);
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
