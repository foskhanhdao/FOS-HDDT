namespace FOS_Einvoice
{
    partial class FrmTax
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fTextBox9 = new FOS_Utils.FTextBox();
            this.fLabel11 = new FOS_Utils.FLabel();
            this.fNumber1 = new FOS_Utils.FNumber();
            this.fComboBox1 = new FOS_Utils.FComboBox();
            this.fLabel3 = new FOS_Utils.FLabel();
            this.fLabel2 = new FOS_Utils.FLabel();
            this.fDateTimePicker2 = new FOS_Utils.FDateTimePicker();
            this.fLabel1 = new FOS_Utils.FLabel();
            this.fLabel7 = new FOS_Utils.FLabel();
            this.fDateTimePicker1 = new FOS_Utils.FDateTimePicker();
            this.fLabel5 = new FOS_Utils.FLabel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fTextBox9);
            this.groupBox1.Controls.Add(this.fLabel11);
            this.groupBox1.Controls.Add(this.fNumber1);
            this.groupBox1.Controls.Add(this.fComboBox1);
            this.groupBox1.Controls.Add(this.fLabel3);
            this.groupBox1.Controls.Add(this.fLabel2);
            this.groupBox1.Controls.Add(this.fDateTimePicker2);
            this.groupBox1.Controls.Add(this.fLabel1);
            this.groupBox1.Controls.Add(this.fLabel7);
            this.groupBox1.Controls.Add(this.fDateTimePicker1);
            this.groupBox1.Controls.Add(this.fLabel5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 462);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết về tỉ lệ thuế suất";
            // 
            // fTextBox9
            // 
            this.fTextBox9.CheckMinMaxChar = false;
            this.fTextBox9.ColumnName = "taxnote";
            this.fTextBox9.DBNullValueWhenBlank = false;
            this.fTextBox9.DBValue = "";
            this.fTextBox9.Enabled = false;
            this.fTextBox9.FillZeroWhenHavingText = false;
            this.fTextBox9.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.fTextBox9.Location = new System.Drawing.Point(159, 155);
            this.fTextBox9.MaxChar = '9';
            this.fTextBox9.MaxLength = 200;
            this.fTextBox9.MaxLengthFromByte = false;
            this.fTextBox9.MinChar = '0';
            this.fTextBox9.Name = "fTextBox9";
            this.fTextBox9.OldText = "";
            this.fTextBox9.OutputControl = null;
            this.fTextBox9.Size = new System.Drawing.Size(602, 25);
            this.fTextBox9.TabIndex = 34;
            // 
            // fLabel11
            // 
            this.fLabel11.ColumnName = "";
            this.fLabel11.ForeColor = System.Drawing.Color.Black;
            this.fLabel11.Location = new System.Drawing.Point(10, 155);
            this.fLabel11.Name = "fLabel11";
            this.fLabel11.OldText = "";
            this.fLabel11.OutputControl = null;
            this.fLabel11.Size = new System.Drawing.Size(143, 25);
            this.fLabel11.TabIndex = 33;
            this.fLabel11.Text = "Ghi chú:";
            this.fLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fNumber1
            // 
            this.fNumber1.AutoResize = true;
            this.fNumber1.ColumnName = "taxrate";
            this.fNumber1.DecimalLength = 2;
            this.fNumber1.DecimalShowZero = false;
            this.fNumber1.Enabled = false;
            this.fNumber1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.fNumber1.Location = new System.Drawing.Point(159, 125);
            this.fNumber1.MaxLength = 5;
            this.fNumber1.Name = "fNumber1";
            this.fNumber1.OldValue = 0;
            this.fNumber1.Size = new System.Drawing.Size(55, 24);
            this.fNumber1.TabIndex = 30;
            this.fNumber1.Text = "0";
            this.fNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fNumber1.ThousandsSeparator = true;
            this.fNumber1.Value = 0;
            this.fNumber1.ValueMax = 99.999;
            this.fNumber1.ValueMin = 0;
            // 
            // fComboBox1
            // 
            this.fComboBox1.ColumnName = "taxtypecode";
            this.fComboBox1.DBValue = "";
            this.fComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fComboBox1.FormattingEnabled = true;
            this.fComboBox1.Location = new System.Drawing.Point(159, 93);
            this.fComboBox1.Name = "fComboBox1";
            this.fComboBox1.Size = new System.Drawing.Size(79, 25);
            this.fComboBox1.TabIndex = 29;
            // 
            // fLabel3
            // 
            this.fLabel3.ColumnName = "";
            this.fLabel3.ForeColor = System.Drawing.Color.Black;
            this.fLabel3.Location = new System.Drawing.Point(10, 93);
            this.fLabel3.Name = "fLabel3";
            this.fLabel3.OldText = "";
            this.fLabel3.OutputControl = null;
            this.fLabel3.Size = new System.Drawing.Size(143, 24);
            this.fLabel3.TabIndex = 28;
            this.fLabel3.Text = "Loại thuế:";
            this.fLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel2
            // 
            this.fLabel2.ColumnName = "";
            this.fLabel2.ForeColor = System.Drawing.Color.Black;
            this.fLabel2.Location = new System.Drawing.Point(220, 124);
            this.fLabel2.Name = "fLabel2";
            this.fLabel2.OldText = "";
            this.fLabel2.OutputControl = null;
            this.fLabel2.Size = new System.Drawing.Size(143, 25);
            this.fLabel2.TabIndex = 27;
            this.fLabel2.Text = "%";
            this.fLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fDateTimePicker2
            // 
            this.fDateTimePicker2.ColumnName = "";
            this.fDateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.fDateTimePicker2.DBValue = new System.DateTime(2017, 2, 26, 19, 46, 13, 328);
            this.fDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fDateTimePicker2.Location = new System.Drawing.Point(159, 63);
            this.fDateTimePicker2.Name = "fDateTimePicker2";
            this.fDateTimePicker2.Size = new System.Drawing.Size(111, 24);
            this.fDateTimePicker2.TabIndex = 26;
            this.fDateTimePicker2.Value = new System.DateTime(2017, 2, 26, 19, 46, 13, 328);
            // 
            // fLabel1
            // 
            this.fLabel1.ColumnName = "";
            this.fLabel1.ForeColor = System.Drawing.Color.Black;
            this.fLabel1.Location = new System.Drawing.Point(10, 63);
            this.fLabel1.Name = "fLabel1";
            this.fLabel1.OldText = "";
            this.fLabel1.OutputControl = null;
            this.fLabel1.Size = new System.Drawing.Size(143, 24);
            this.fLabel1.TabIndex = 25;
            this.fLabel1.Text = "Ngày kết thúc:";
            this.fLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel7
            // 
            this.fLabel7.ColumnName = "";
            this.fLabel7.ForeColor = System.Drawing.Color.Black;
            this.fLabel7.Location = new System.Drawing.Point(10, 124);
            this.fLabel7.Name = "fLabel7";
            this.fLabel7.OldText = "";
            this.fLabel7.OutputControl = null;
            this.fLabel7.Size = new System.Drawing.Size(143, 25);
            this.fLabel7.TabIndex = 23;
            this.fLabel7.Text = "Tỉ lệ thuế suất:";
            this.fLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fDateTimePicker1
            // 
            this.fDateTimePicker1.ColumnName = "";
            this.fDateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.fDateTimePicker1.DBValue = new System.DateTime(2017, 2, 26, 19, 46, 13, 328);
            this.fDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fDateTimePicker1.Location = new System.Drawing.Point(159, 33);
            this.fDateTimePicker1.Name = "fDateTimePicker1";
            this.fDateTimePicker1.Size = new System.Drawing.Size(111, 24);
            this.fDateTimePicker1.TabIndex = 20;
            this.fDateTimePicker1.Value = new System.DateTime(2017, 2, 26, 19, 46, 13, 328);
            // 
            // fLabel5
            // 
            this.fLabel5.ColumnName = "";
            this.fLabel5.ForeColor = System.Drawing.Color.Black;
            this.fLabel5.Location = new System.Drawing.Point(10, 33);
            this.fLabel5.Name = "fLabel5";
            this.fLabel5.OldText = "";
            this.fLabel5.OutputControl = null;
            this.fLabel5.Size = new System.Drawing.Size(143, 24);
            this.fLabel5.TabIndex = 19;
            this.fLabel5.Text = "Ngày bắt đầu:";
            this.fLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTax";
            this.Text = "Cài đặt tỉ lệ thuế xuất";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FOS_Utils.FLabel fLabel7;
        private FOS_Utils.FDateTimePicker fDateTimePicker1;
        private FOS_Utils.FLabel fLabel5;
        private FOS_Utils.FLabel fLabel2;
        private FOS_Utils.FDateTimePicker fDateTimePicker2;
        private FOS_Utils.FLabel fLabel1;
        private FOS_Utils.FLabel fLabel3;
        private FOS_Utils.FComboBox fComboBox1;
        private FOS_Utils.FNumber fNumber1;
        private FOS_Utils.FTextBox fTextBox9;
        private FOS_Utils.FLabel fLabel11;
    }
}
