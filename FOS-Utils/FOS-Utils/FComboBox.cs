
namespace FOS_Utils
{
    public class FComboBox:System.Windows.Forms.ComboBox,IControl
    {
        private string columnName  = "";

        public string ColumnName
        {
            get { return columnName; }
            set { columnName = value; }
        }

        public object DBValue
        {
            get {
                if (DisplayMember != "") return SelectedValue;
                return this.Text; 
            }
            set
            {
                if (value != null)
                {
                    if (DisplayMember != "") SelectedValue = value;
                    else Text = value.ToString();
                }
            }
        }
    }
}
