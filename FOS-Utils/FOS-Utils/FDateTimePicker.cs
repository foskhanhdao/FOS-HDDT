using System;


namespace FOS_Utils
{
    public class FDateTimePicker:System.Windows.Forms.DateTimePicker,IControl
    {
        private string _columnName = "";
        public string ColumnName
        {
            get { return _columnName; }
            set { _columnName = value; }
        }

        public object DBValue
        {
            get {
                if (this.ShowCheckBox && !this.Checked) return DBNull.Value;
                return this.Value; 
            }
            set { if (value is DateTime) this.Value = Convert.ToDateTime( value); }
        }
    }
}
