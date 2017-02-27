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
            this.fTextBox5 = new FOS_Utils.FTextBox();
            this.fLabel7 = new FOS_Utils.FLabel();
            this.fDateTimePicker1 = new FOS_Utils.FDateTimePicker();
            this.fLabel5 = new FOS_Utils.FLabel();
            this.fDateTimePicker2 = new FOS_Utils.FDateTimePicker();
            this.fLabel1 = new FOS_Utils.FLabel();
            this.fLabel2 = new FOS_Utils.FLabel();
            this.fLabel3 = new FOS_Utils.FLabel();
            this.fComboBox1 = new FOS_Utils.FComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fComboBox1);
            this.groupBox1.Controls.Add(this.fLabel3);
            this.groupBox1.Controls.Add(this.fLabel2);
            this.groupBox1.Controls.Add(this.fDateTimePicker2);
            this.groupBox1.Controls.Add(this.fLabel1);
            this.groupBox1.Controls.Add(this.fTextBox5);
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
            // fTextBox5
            // 
            this.fTextBox5.CheckMinMaxChar = false;
            this.fTextBox5.ColumnName = "";
            this.fTextBox5.DBNullValueWhenBlank = false;
            this.fTextBox5.FillZeroWhenHavingText = false;
            this.fTextBox5.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.fTextBox5.Location = new System.Drawing.Point(159, 124);
            this.fTextBox5.MaxChar = '9';
            this.fTextBox5.MaxLength = 20;
            this.fTextBox5.MaxLengthFromByte = false;
            this.fTextBox5.MinChar = '0';
            this.fTextBox5.Name = "fTextBox5";
            this.fTextBox5.OldText = "";
            this.fTextBox5.OutputControl = null;
            this.fTextBox5.Size = new System.Drawing.Size(55, 25);
            this.fTextBox5.TabIndex = 24;
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
            this.fDateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.fDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fDateTimePicker1.Location = new System.Drawing.Point(159, 33);
            this.fDateTimePicker1.Name = "fDateTimePicker1";
            this.fDateTimePicker1.Size = new System.Drawing.Size(111, 24);
            this.fDateTimePicker1.TabIndex = 20;
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
            // fDateTimePicker2
            // 
            this.fDateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.fDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fDateTimePicker2.Location = new System.Drawing.Point(159, 63);
            this.fDateTimePicker2.Name = "fDateTimePicker2";
            this.fDateTimePicker2.Size = new System.Drawing.Size(111, 24);
            this.fDateTimePicker2.TabIndex = 26;
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
            // fComboBox1
            // 
            this.fComboBox1.ColumnName = "";
            this.fComboBox1.FormattingEnabled = true;
            this.fComboBox1.Location = new System.Drawing.Point(159, 93);
            this.fComboBox1.Name = "fComboBox1";
            this.fComboBox1.Size = new System.Drawing.Size(79, 25);
            this.fComboBox1.TabIndex = 29;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FOS_Utils.FTextBox fTextBox5;
        private FOS_Utils.FLabel fLabel7;
        private FOS_Utils.FDateTimePicker fDateTimePicker1;
        private FOS_Utils.FLabel fLabel5;
        private FOS_Utils.FLabel fLabel2;
        private FOS_Utils.FDateTimePicker fDateTimePicker2;
        private FOS_Utils.FLabel fLabel1;
        private FOS_Utils.FLabel fLabel3;
        private FOS_Utils.FComboBox fComboBox1;
    }
}
