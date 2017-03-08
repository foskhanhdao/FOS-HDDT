namespace FOS_Einvoice
{
    partial class FrmProduct
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
            this.productunitcode = new FOS_Utils.FComboBox();
            this.productsellingprice = new FOS_Utils.FNumber();
            this.productcostprice = new FOS_Utils.FNumber();
            this.producttype3 = new FOS_Utils.FComboBox();
            this.producttype2 = new FOS_Utils.FComboBox();
            this.producttype1 = new FOS_Utils.FComboBox();
            this.lblStatus = new FOS_Utils.FLabel();
            this.btnCompanycode = new FOS_Utils.FButton();
            this.fLabel10 = new FOS_Utils.FLabel();
            this.productnote = new FOS_Utils.FTextBox();
            this.fLabel8 = new FOS_Utils.FLabel();
            this.fLabel7 = new FOS_Utils.FLabel();
            this.fLabel4 = new FOS_Utils.FLabel();
            this.fLabel2 = new FOS_Utils.FLabel();
            this.productname1 = new FOS_Utils.FTextBox();
            this.fLabel1 = new FOS_Utils.FLabel();
            this.productcode = new FOS_Utils.FTextBox();
            this.fLabel3 = new FOS_Utils.FLabel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.productunitcode);
            this.groupBox1.Controls.Add(this.productsellingprice);
            this.groupBox1.Controls.Add(this.productcostprice);
            this.groupBox1.Controls.Add(this.producttype3);
            this.groupBox1.Controls.Add(this.producttype2);
            this.groupBox1.Controls.Add(this.producttype1);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.btnCompanycode);
            this.groupBox1.Controls.Add(this.fLabel10);
            this.groupBox1.Controls.Add(this.productnote);
            this.groupBox1.Controls.Add(this.fLabel8);
            this.groupBox1.Controls.Add(this.fLabel7);
            this.groupBox1.Controls.Add(this.fLabel4);
            this.groupBox1.Controls.Add(this.fLabel2);
            this.groupBox1.Controls.Add(this.productname1);
            this.groupBox1.Controls.Add(this.fLabel1);
            this.groupBox1.Controls.Add(this.productcode);
            this.groupBox1.Controls.Add(this.fLabel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TThông tin chi tiết về sản phẩm";
            // 
            // productunitcode
            // 
            this.productunitcode.ColumnName = "productunitcode";
            this.productunitcode.DBValue = "";
            this.productunitcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productunitcode.Enabled = false;
            this.productunitcode.FormattingEnabled = true;
            this.productunitcode.Location = new System.Drawing.Point(157, 185);
            this.productunitcode.Name = "productunitcode";
            this.productunitcode.Size = new System.Drawing.Size(196, 25);
            this.productunitcode.TabIndex = 13;
            // 
            // productsellingprice
            // 
            this.productsellingprice.AutoResize = true;
            this.productsellingprice.ColumnName = "productsellingprice";
            this.productsellingprice.DBValue = 0;
            this.productsellingprice.DecimalLength = 0;
            this.productsellingprice.DecimalShowZero = false;
            this.productsellingprice.Enabled = false;
            this.productsellingprice.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.productsellingprice.Location = new System.Drawing.Point(157, 155);
            this.productsellingprice.MaxLength = 12;
            this.productsellingprice.Name = "productsellingprice";
            this.productsellingprice.OldValue = 0;
            this.productsellingprice.Size = new System.Drawing.Size(121, 24);
            this.productsellingprice.TabIndex = 11;
            this.productsellingprice.Text = "0";
            this.productsellingprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productsellingprice.ThousandsSeparator = true;
            this.productsellingprice.Value = 0;
            this.productsellingprice.ValueMax = 999999999999;
            this.productsellingprice.ValueMin = 0;
            // 
            // productcostprice
            // 
            this.productcostprice.AutoResize = true;
            this.productcostprice.ColumnName = "productcostprice";
            this.productcostprice.DBValue = 0;
            this.productcostprice.DecimalLength = 0;
            this.productcostprice.DecimalShowZero = false;
            this.productcostprice.Enabled = false;
            this.productcostprice.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.productcostprice.Location = new System.Drawing.Point(157, 125);
            this.productcostprice.MaxLength = 12;
            this.productcostprice.Name = "productcostprice";
            this.productcostprice.OldValue = 0;
            this.productcostprice.Size = new System.Drawing.Size(121, 24);
            this.productcostprice.TabIndex = 9;
            this.productcostprice.Text = "0";
            this.productcostprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productcostprice.ThousandsSeparator = true;
            this.productcostprice.Value = 0;
            this.productcostprice.ValueMax = 999999999.999;
            this.productcostprice.ValueMin = 0;
            // 
            // producttype3
            // 
            this.producttype3.ColumnName = "producttype3";
            this.producttype3.DBValue = "";
            this.producttype3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.producttype3.Enabled = false;
            this.producttype3.FormattingEnabled = true;
            this.producttype3.Location = new System.Drawing.Point(563, 93);
            this.producttype3.Name = "producttype3";
            this.producttype3.Size = new System.Drawing.Size(196, 25);
            this.producttype3.TabIndex = 7;
            // 
            // producttype2
            // 
            this.producttype2.ColumnName = "producttype2";
            this.producttype2.DBValue = "";
            this.producttype2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.producttype2.Enabled = false;
            this.producttype2.FormattingEnabled = true;
            this.producttype2.Location = new System.Drawing.Point(360, 93);
            this.producttype2.Name = "producttype2";
            this.producttype2.Size = new System.Drawing.Size(196, 25);
            this.producttype2.TabIndex = 6;
            // 
            // producttype1
            // 
            this.producttype1.ColumnName = "producttype1";
            this.producttype1.DBValue = "";
            this.producttype1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.producttype1.Enabled = false;
            this.producttype1.FormattingEnabled = true;
            this.producttype1.Location = new System.Drawing.Point(157, 93);
            this.producttype1.Name = "producttype1";
            this.producttype1.Size = new System.Drawing.Size(196, 25);
            this.producttype1.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.SeaGreen;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.ColumnName = "";
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(659, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.OldText = "";
            this.lblStatus.OutputControl = null;
            this.lblStatus.Size = new System.Drawing.Size(100, 30);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Tạo mới";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCompanycode
            // 
            this.btnCompanycode.Location = new System.Drawing.Point(317, 31);
            this.btnCompanycode.Name = "btnCompanycode";
            this.btnCompanycode.Size = new System.Drawing.Size(38, 25);
            this.btnCompanycode.TabIndex = 16;
            this.btnCompanycode.TabStop = false;
            this.btnCompanycode.Text = "...";
            this.btnCompanycode.UseVisualStyleBackColor = true;
            this.btnCompanycode.Click += new System.EventHandler(this.btnCompanycode_Click);
            // 
            // fLabel10
            // 
            this.fLabel10.ColumnName = "";
            this.fLabel10.ForeColor = System.Drawing.Color.Black;
            this.fLabel10.Location = new System.Drawing.Point(8, 155);
            this.fLabel10.Name = "fLabel10";
            this.fLabel10.OldText = "";
            this.fLabel10.OutputControl = null;
            this.fLabel10.Size = new System.Drawing.Size(143, 25);
            this.fLabel10.TabIndex = 10;
            this.fLabel10.Text = "Giá bán:";
            this.fLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productnote
            // 
            this.productnote.CheckMinMaxChar = false;
            this.productnote.ColumnName = "productnote";
            this.productnote.DBNullValueWhenBlank = false;
            this.productnote.DBValue = "";
            this.productnote.Enabled = false;
            this.productnote.FillZeroWhenHavingText = false;
            this.productnote.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.productnote.Location = new System.Drawing.Point(157, 217);
            this.productnote.MaxChar = '9';
            this.productnote.MaxLength = 200;
            this.productnote.MaxLengthFromByte = false;
            this.productnote.MinChar = '0';
            this.productnote.Name = "productnote";
            this.productnote.OldText = "";
            this.productnote.OutputControl = null;
            this.productnote.Size = new System.Drawing.Size(602, 25);
            this.productnote.TabIndex = 15;
            // 
            // fLabel8
            // 
            this.fLabel8.ColumnName = "";
            this.fLabel8.ForeColor = System.Drawing.Color.Black;
            this.fLabel8.Location = new System.Drawing.Point(8, 217);
            this.fLabel8.Name = "fLabel8";
            this.fLabel8.OldText = "";
            this.fLabel8.OutputControl = null;
            this.fLabel8.Size = new System.Drawing.Size(143, 25);
            this.fLabel8.TabIndex = 14;
            this.fLabel8.Text = "Ghi chú:";
            this.fLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel7
            // 
            this.fLabel7.ColumnName = "";
            this.fLabel7.ForeColor = System.Drawing.Color.Black;
            this.fLabel7.Location = new System.Drawing.Point(8, 186);
            this.fLabel7.Name = "fLabel7";
            this.fLabel7.OldText = "";
            this.fLabel7.OutputControl = null;
            this.fLabel7.Size = new System.Drawing.Size(143, 25);
            this.fLabel7.TabIndex = 12;
            this.fLabel7.Text = "Đơn vị tính:";
            this.fLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel4
            // 
            this.fLabel4.ColumnName = "";
            this.fLabel4.ForeColor = System.Drawing.Color.Black;
            this.fLabel4.Location = new System.Drawing.Point(8, 124);
            this.fLabel4.Name = "fLabel4";
            this.fLabel4.OldText = "";
            this.fLabel4.OutputControl = null;
            this.fLabel4.Size = new System.Drawing.Size(143, 25);
            this.fLabel4.TabIndex = 8;
            this.fLabel4.Text = "Giá mua:";
            this.fLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel2
            // 
            this.fLabel2.ColumnName = "";
            this.fLabel2.ForeColor = System.Drawing.Color.Black;
            this.fLabel2.Location = new System.Drawing.Point(8, 93);
            this.fLabel2.Name = "fLabel2";
            this.fLabel2.OldText = "";
            this.fLabel2.OutputControl = null;
            this.fLabel2.Size = new System.Drawing.Size(143, 25);
            this.fLabel2.TabIndex = 4;
            this.fLabel2.Text = "Loại sản phẩm:";
            this.fLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productname1
            // 
            this.productname1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.productname1.CheckMinMaxChar = false;
            this.productname1.ColumnName = "productname1";
            this.productname1.DBNullValueWhenBlank = false;
            this.productname1.DBValue = "";
            this.productname1.Enabled = false;
            this.productname1.FillZeroWhenHavingText = false;
            this.productname1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.productname1.Location = new System.Drawing.Point(157, 62);
            this.productname1.MaxChar = '9';
            this.productname1.MaxLength = 200;
            this.productname1.MaxLengthFromByte = false;
            this.productname1.MinChar = '0';
            this.productname1.Name = "productname1";
            this.productname1.OldText = "";
            this.productname1.OutputControl = null;
            this.productname1.Size = new System.Drawing.Size(602, 25);
            this.productname1.TabIndex = 3;
            // 
            // fLabel1
            // 
            this.fLabel1.ColumnName = "";
            this.fLabel1.ForeColor = System.Drawing.Color.Black;
            this.fLabel1.Location = new System.Drawing.Point(8, 62);
            this.fLabel1.Name = "fLabel1";
            this.fLabel1.OldText = "";
            this.fLabel1.OutputControl = null;
            this.fLabel1.Size = new System.Drawing.Size(143, 25);
            this.fLabel1.TabIndex = 2;
            this.fLabel1.Text = "Tên sản phẩm:";
            this.fLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productcode
            // 
            this.productcode.CheckMinMaxChar = true;
            this.productcode.ColumnName = "productcode";
            this.productcode.DBNullValueWhenBlank = false;
            this.productcode.DBValue = "";
            this.productcode.FillZeroWhenHavingText = false;
            this.productcode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.productcode.Location = new System.Drawing.Point(157, 31);
            this.productcode.MaxChar = '9';
            this.productcode.MaxLength = 20;
            this.productcode.MaxLengthFromByte = false;
            this.productcode.MinChar = '0';
            this.productcode.Name = "productcode";
            this.productcode.OldText = "";
            this.productcode.OutputControl = null;
            this.productcode.Size = new System.Drawing.Size(154, 25);
            this.productcode.TabIndex = 1;
            // 
            // fLabel3
            // 
            this.fLabel3.ColumnName = "";
            this.fLabel3.ForeColor = System.Drawing.Color.Black;
            this.fLabel3.Location = new System.Drawing.Point(8, 31);
            this.fLabel3.Name = "fLabel3";
            this.fLabel3.OldText = "";
            this.fLabel3.OutputControl = null;
            this.fLabel3.Size = new System.Drawing.Size(143, 25);
            this.fLabel3.TabIndex = 0;
            this.fLabel3.Text = "Mã sản phẩm:";
            this.fLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProduct";
            this.Text = "Sản phẩm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FOS_Utils.FLabel fLabel10;
        private FOS_Utils.FTextBox productnote;
        private FOS_Utils.FLabel fLabel8;
        private FOS_Utils.FLabel fLabel7;
        private FOS_Utils.FLabel fLabel4;
        private FOS_Utils.FLabel fLabel2;
        private FOS_Utils.FTextBox productname1;
        private FOS_Utils.FLabel fLabel1;
        private FOS_Utils.FTextBox productcode;
        private FOS_Utils.FLabel fLabel3;
        private FOS_Utils.FButton btnCompanycode;
        private FOS_Utils.FLabel lblStatus;
        private FOS_Utils.FComboBox producttype3;
        private FOS_Utils.FComboBox producttype2;
        private FOS_Utils.FComboBox producttype1;
        private FOS_Utils.FComboBox productunitcode;
        private FOS_Utils.FNumber productsellingprice;
        private FOS_Utils.FNumber productcostprice;
    }
}
