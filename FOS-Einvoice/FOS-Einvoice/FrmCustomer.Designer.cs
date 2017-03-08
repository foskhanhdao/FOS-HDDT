namespace FOS_Einvoice
{
    partial class FrmCustomer
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
            this.fax = new FOS_Utils.FTextBox();
            this.phone = new FOS_Utils.FTextBox();
            this.email = new FOS_Utils.FTextBox();
            this.cusaddress = new FOS_Utils.FTextBox();
            this.taxcode = new FOS_Utils.FTextBox();
            this.companyname = new FOS_Utils.FTextBox();
            this.cussex = new FOS_Utils.FComboBox();
            this.cusbirthday = new FOS_Utils.FDateTimePicker();
            this.cusname = new FOS_Utils.FTextBox();
            this.cuspass = new FOS_Utils.FTextBox();
            this.cuscode = new FOS_Utils.FTextBox();
            this.fLabel7 = new FOS_Utils.FLabel();
            this.fLabel8 = new FOS_Utils.FLabel();
            this.fLabel11 = new FOS_Utils.FLabel();
            this.fLabel9 = new FOS_Utils.FLabel();
            this.fLabel10 = new FOS_Utils.FLabel();
            this.fLabel12 = new FOS_Utils.FLabel();
            this.fLabel13 = new FOS_Utils.FLabel();
            this.fLabel14 = new FOS_Utils.FLabel();
            this.fLabel15 = new FOS_Utils.FLabel();
            this.fLabel16 = new FOS_Utils.FLabel();
            this.fLabel17 = new FOS_Utils.FLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fTextBox1 = new FOS_Utils.FTextBox();
            this.fLabel1 = new FOS_Utils.FLabel();
            this.lblStatus = new FOS_Utils.FLabel();
            this.btnCuscode = new FOS_Utils.FButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.TabIndex = 1;
            // 
            // fax
            // 
            this.fax.CheckMinMaxChar = false;
            this.fax.ColumnName = "customerfax";
            this.fax.DBNullValueWhenBlank = false;
            this.fax.DBValue = "";
            this.fax.Enabled = false;
            this.fax.FillZeroWhenHavingText = false;
            this.fax.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.fax.Location = new System.Drawing.Point(134, 339);
            this.fax.MaxChar = '9';
            this.fax.MaxLength = 15;
            this.fax.MaxLengthFromByte = false;
            this.fax.MinChar = '0';
            this.fax.Name = "fax";
            this.fax.OldText = "";
            this.fax.OutputControl = null;
            this.fax.Size = new System.Drawing.Size(120, 25);
            this.fax.TabIndex = 21;
            // 
            // phone
            // 
            this.phone.CheckMinMaxChar = false;
            this.phone.ColumnName = "customerphone";
            this.phone.DBNullValueWhenBlank = false;
            this.phone.DBValue = "";
            this.phone.Enabled = false;
            this.phone.FillZeroWhenHavingText = false;
            this.phone.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.phone.Location = new System.Drawing.Point(134, 308);
            this.phone.MaxChar = '9';
            this.phone.MaxLength = 15;
            this.phone.MaxLengthFromByte = false;
            this.phone.MinChar = '0';
            this.phone.Name = "phone";
            this.phone.OldText = "";
            this.phone.OutputControl = null;
            this.phone.Size = new System.Drawing.Size(120, 25);
            this.phone.TabIndex = 19;
            // 
            // email
            // 
            this.email.CheckMinMaxChar = false;
            this.email.ColumnName = "customeremail";
            this.email.DBNullValueWhenBlank = false;
            this.email.DBValue = "";
            this.email.Enabled = false;
            this.email.FillZeroWhenHavingText = false;
            this.email.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.email.Location = new System.Drawing.Point(134, 277);
            this.email.MaxChar = '9';
            this.email.MaxLength = 50;
            this.email.MaxLengthFromByte = false;
            this.email.MinChar = '0';
            this.email.Name = "email";
            this.email.OldText = "";
            this.email.OutputControl = null;
            this.email.Size = new System.Drawing.Size(362, 25);
            this.email.TabIndex = 17;
            // 
            // cusaddress
            // 
            this.cusaddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cusaddress.CheckMinMaxChar = false;
            this.cusaddress.ColumnName = "customeraddress";
            this.cusaddress.DBNullValueWhenBlank = false;
            this.cusaddress.DBValue = "";
            this.cusaddress.Enabled = false;
            this.cusaddress.FillZeroWhenHavingText = false;
            this.cusaddress.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cusaddress.Location = new System.Drawing.Point(134, 246);
            this.cusaddress.MaxChar = '9';
            this.cusaddress.MaxLength = 200;
            this.cusaddress.MaxLengthFromByte = false;
            this.cusaddress.MinChar = '0';
            this.cusaddress.Name = "cusaddress";
            this.cusaddress.OldText = "";
            this.cusaddress.OutputControl = null;
            this.cusaddress.Size = new System.Drawing.Size(625, 25);
            this.cusaddress.TabIndex = 15;
            // 
            // taxcode
            // 
            this.taxcode.CheckMinMaxChar = false;
            this.taxcode.ColumnName = "customertaxcode";
            this.taxcode.DBNullValueWhenBlank = false;
            this.taxcode.DBValue = "";
            this.taxcode.Enabled = false;
            this.taxcode.FillZeroWhenHavingText = false;
            this.taxcode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.taxcode.Location = new System.Drawing.Point(134, 215);
            this.taxcode.MaxChar = '9';
            this.taxcode.MaxLength = 15;
            this.taxcode.MaxLengthFromByte = false;
            this.taxcode.MinChar = '0';
            this.taxcode.Name = "taxcode";
            this.taxcode.OldText = "";
            this.taxcode.OutputControl = null;
            this.taxcode.Size = new System.Drawing.Size(120, 25);
            this.taxcode.TabIndex = 13;
            // 
            // companyname
            // 
            this.companyname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.companyname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.companyname.CheckMinMaxChar = false;
            this.companyname.ColumnName = "customercompanyname";
            this.companyname.DBNullValueWhenBlank = false;
            this.companyname.DBValue = "";
            this.companyname.Enabled = false;
            this.companyname.FillZeroWhenHavingText = false;
            this.companyname.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.companyname.Location = new System.Drawing.Point(134, 184);
            this.companyname.MaxChar = '9';
            this.companyname.MaxLength = 200;
            this.companyname.MaxLengthFromByte = false;
            this.companyname.MinChar = '0';
            this.companyname.Name = "companyname";
            this.companyname.OldText = "";
            this.companyname.OutputControl = null;
            this.companyname.Size = new System.Drawing.Size(625, 25);
            this.companyname.TabIndex = 11;
            // 
            // cussex
            // 
            this.cussex.ColumnName = "customersex";
            this.cussex.DBValue = "";
            this.cussex.Enabled = false;
            this.cussex.FormattingEnabled = true;
            this.cussex.Location = new System.Drawing.Point(134, 153);
            this.cussex.Name = "cussex";
            this.cussex.Size = new System.Drawing.Size(79, 25);
            this.cussex.TabIndex = 9;
            // 
            // cusbirthday
            // 
            this.cusbirthday.ColumnName = "customerbirthday";
            this.cusbirthday.CustomFormat = "dd/MM/yyyy";
            this.cusbirthday.DBValue = new System.DateTime(2017, 2, 21, 11, 42, 43, 488);
            this.cusbirthday.Enabled = false;
            this.cusbirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cusbirthday.Location = new System.Drawing.Point(134, 122);
            this.cusbirthday.Name = "cusbirthday";
            this.cusbirthday.ShowCheckBox = true;
            this.cusbirthday.Size = new System.Drawing.Size(111, 24);
            this.cusbirthday.TabIndex = 7;
            this.cusbirthday.Value = new System.DateTime(2017, 2, 21, 11, 42, 43, 488);
            // 
            // cusname
            // 
            this.cusname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cusname.CheckMinMaxChar = false;
            this.cusname.ColumnName = "customername";
            this.cusname.DBNullValueWhenBlank = false;
            this.cusname.DBValue = "";
            this.cusname.Enabled = false;
            this.cusname.FillZeroWhenHavingText = false;
            this.cusname.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cusname.Location = new System.Drawing.Point(134, 92);
            this.cusname.MaxChar = '9';
            this.cusname.MaxLength = 200;
            this.cusname.MaxLengthFromByte = false;
            this.cusname.MinChar = '0';
            this.cusname.Name = "cusname";
            this.cusname.OldText = "";
            this.cusname.OutputControl = null;
            this.cusname.Size = new System.Drawing.Size(625, 25);
            this.cusname.TabIndex = 5;
            // 
            // cuspass
            // 
            this.cuspass.CheckMinMaxChar = false;
            this.cuspass.ColumnName = "customerpass";
            this.cuspass.DBNullValueWhenBlank = false;
            this.cuspass.DBValue = "";
            this.cuspass.Enabled = false;
            this.cuspass.FillZeroWhenHavingText = false;
            this.cuspass.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cuspass.Location = new System.Drawing.Point(134, 62);
            this.cuspass.MaxChar = '9';
            this.cuspass.MaxLength = 50;
            this.cuspass.MaxLengthFromByte = true;
            this.cuspass.MinChar = '0';
            this.cuspass.Name = "cuspass";
            this.cuspass.OldText = "";
            this.cuspass.OutputControl = null;
            this.cuspass.PasswordChar = '*';
            this.cuspass.Size = new System.Drawing.Size(362, 25);
            this.cuspass.TabIndex = 3;
            // 
            // cuscode
            // 
            this.cuscode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cuscode.CheckMinMaxChar = false;
            this.cuscode.ColumnName = "customercode";
            this.cuscode.DBNullValueWhenBlank = false;
            this.cuscode.DBValue = "";
            this.cuscode.FillZeroWhenHavingText = false;
            this.cuscode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cuscode.Location = new System.Drawing.Point(134, 32);
            this.cuscode.MaxChar = '9';
            this.cuscode.MaxLength = 20;
            this.cuscode.MaxLengthFromByte = false;
            this.cuscode.MinChar = '0';
            this.cuscode.Name = "cuscode";
            this.cuscode.OldText = "";
            this.cuscode.OutputControl = null;
            this.cuscode.Size = new System.Drawing.Size(154, 25);
            this.cuscode.TabIndex = 1;
            // 
            // fLabel7
            // 
            this.fLabel7.ColumnName = "";
            this.fLabel7.Location = new System.Drawing.Point(8, 32);
            this.fLabel7.Name = "fLabel7";
            this.fLabel7.OldText = "";
            this.fLabel7.OutputControl = null;
            this.fLabel7.Size = new System.Drawing.Size(120, 25);
            this.fLabel7.TabIndex = 0;
            this.fLabel7.Text = "Mã khách hàng:";
            this.fLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel8
            // 
            this.fLabel8.ColumnName = "";
            this.fLabel8.Location = new System.Drawing.Point(8, 62);
            this.fLabel8.Name = "fLabel8";
            this.fLabel8.OldText = "";
            this.fLabel8.OutputControl = null;
            this.fLabel8.Size = new System.Drawing.Size(120, 25);
            this.fLabel8.TabIndex = 2;
            this.fLabel8.Text = "Mật khẩu:";
            this.fLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel11
            // 
            this.fLabel11.ColumnName = "";
            this.fLabel11.Location = new System.Drawing.Point(8, 339);
            this.fLabel11.Name = "fLabel11";
            this.fLabel11.OldText = "";
            this.fLabel11.OutputControl = null;
            this.fLabel11.Size = new System.Drawing.Size(120, 25);
            this.fLabel11.TabIndex = 20;
            this.fLabel11.Text = "Fax:";
            this.fLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel9
            // 
            this.fLabel9.ColumnName = "";
            this.fLabel9.Location = new System.Drawing.Point(8, 92);
            this.fLabel9.Name = "fLabel9";
            this.fLabel9.OldText = "";
            this.fLabel9.OutputControl = null;
            this.fLabel9.Size = new System.Drawing.Size(120, 25);
            this.fLabel9.TabIndex = 4;
            this.fLabel9.Text = "Tên khách hàng:";
            this.fLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel10
            // 
            this.fLabel10.ColumnName = "";
            this.fLabel10.Location = new System.Drawing.Point(8, 308);
            this.fLabel10.Name = "fLabel10";
            this.fLabel10.OldText = "";
            this.fLabel10.OutputControl = null;
            this.fLabel10.Size = new System.Drawing.Size(120, 25);
            this.fLabel10.TabIndex = 18;
            this.fLabel10.Text = "Điện thoại:";
            this.fLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel12
            // 
            this.fLabel12.ColumnName = "";
            this.fLabel12.Location = new System.Drawing.Point(8, 122);
            this.fLabel12.Name = "fLabel12";
            this.fLabel12.OldText = "";
            this.fLabel12.OutputControl = null;
            this.fLabel12.Size = new System.Drawing.Size(120, 25);
            this.fLabel12.TabIndex = 6;
            this.fLabel12.Text = "Ngày sinh:";
            this.fLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel13
            // 
            this.fLabel13.ColumnName = "";
            this.fLabel13.Location = new System.Drawing.Point(8, 277);
            this.fLabel13.Name = "fLabel13";
            this.fLabel13.OldText = "";
            this.fLabel13.OutputControl = null;
            this.fLabel13.Size = new System.Drawing.Size(120, 25);
            this.fLabel13.TabIndex = 16;
            this.fLabel13.Text = "Email:";
            this.fLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel14
            // 
            this.fLabel14.ColumnName = "";
            this.fLabel14.Location = new System.Drawing.Point(8, 153);
            this.fLabel14.Name = "fLabel14";
            this.fLabel14.OldText = "";
            this.fLabel14.OutputControl = null;
            this.fLabel14.Size = new System.Drawing.Size(120, 25);
            this.fLabel14.TabIndex = 8;
            this.fLabel14.Text = "Giới tính:";
            this.fLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel15
            // 
            this.fLabel15.ColumnName = "";
            this.fLabel15.Location = new System.Drawing.Point(8, 246);
            this.fLabel15.Name = "fLabel15";
            this.fLabel15.OldText = "";
            this.fLabel15.OutputControl = null;
            this.fLabel15.Size = new System.Drawing.Size(120, 25);
            this.fLabel15.TabIndex = 14;
            this.fLabel15.Text = "Địa chỉ:";
            this.fLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel16
            // 
            this.fLabel16.ColumnName = "";
            this.fLabel16.Location = new System.Drawing.Point(8, 184);
            this.fLabel16.Name = "fLabel16";
            this.fLabel16.OldText = "";
            this.fLabel16.OutputControl = null;
            this.fLabel16.Size = new System.Drawing.Size(120, 25);
            this.fLabel16.TabIndex = 10;
            this.fLabel16.Text = "Tên công ty:";
            this.fLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel17
            // 
            this.fLabel17.ColumnName = "";
            this.fLabel17.Location = new System.Drawing.Point(8, 215);
            this.fLabel17.Name = "fLabel17";
            this.fLabel17.OldText = "";
            this.fLabel17.OutputControl = null;
            this.fLabel17.Size = new System.Drawing.Size(120, 25);
            this.fLabel17.TabIndex = 12;
            this.fLabel17.Text = "Mã số thuế:";
            this.fLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fTextBox1);
            this.groupBox1.Controls.Add(this.fLabel1);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.btnCuscode);
            this.groupBox1.Controls.Add(this.fax);
            this.groupBox1.Controls.Add(this.fLabel8);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.fLabel17);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.fLabel16);
            this.groupBox1.Controls.Add(this.cusaddress);
            this.groupBox1.Controls.Add(this.fLabel15);
            this.groupBox1.Controls.Add(this.taxcode);
            this.groupBox1.Controls.Add(this.fLabel14);
            this.groupBox1.Controls.Add(this.companyname);
            this.groupBox1.Controls.Add(this.fLabel13);
            this.groupBox1.Controls.Add(this.cussex);
            this.groupBox1.Controls.Add(this.fLabel12);
            this.groupBox1.Controls.Add(this.cusbirthday);
            this.groupBox1.Controls.Add(this.fLabel10);
            this.groupBox1.Controls.Add(this.cusname);
            this.groupBox1.Controls.Add(this.fLabel9);
            this.groupBox1.Controls.Add(this.cuspass);
            this.groupBox1.Controls.Add(this.fLabel11);
            this.groupBox1.Controls.Add(this.cuscode);
            this.groupBox1.Controls.Add(this.fLabel7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết về khách hàng";
            // 
            // fTextBox1
            // 
            this.fTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fTextBox1.CheckMinMaxChar = false;
            this.fTextBox1.ColumnName = "customernote";
            this.fTextBox1.DBNullValueWhenBlank = false;
            this.fTextBox1.DBValue = "";
            this.fTextBox1.Enabled = false;
            this.fTextBox1.FillZeroWhenHavingText = false;
            this.fTextBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.fTextBox1.Location = new System.Drawing.Point(134, 370);
            this.fTextBox1.MaxChar = '9';
            this.fTextBox1.MaxLength = 200;
            this.fTextBox1.MaxLengthFromByte = false;
            this.fTextBox1.MinChar = '0';
            this.fTextBox1.Name = "fTextBox1";
            this.fTextBox1.OldText = "";
            this.fTextBox1.OutputControl = null;
            this.fTextBox1.Size = new System.Drawing.Size(625, 25);
            this.fTextBox1.TabIndex = 25;
            // 
            // fLabel1
            // 
            this.fLabel1.ColumnName = "";
            this.fLabel1.Location = new System.Drawing.Point(8, 370);
            this.fLabel1.Name = "fLabel1";
            this.fLabel1.OldText = "";
            this.fLabel1.OutputControl = null;
            this.fLabel1.Size = new System.Drawing.Size(120, 25);
            this.fLabel1.TabIndex = 24;
            this.fLabel1.Text = "Ghi chú:";
            this.fLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Tạo mới";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCuscode
            // 
            this.btnCuscode.Location = new System.Drawing.Point(294, 32);
            this.btnCuscode.Name = "btnCuscode";
            this.btnCuscode.Size = new System.Drawing.Size(38, 25);
            this.btnCuscode.TabIndex = 22;
            this.btnCuscode.Text = "...";
            this.btnCuscode.UseVisualStyleBackColor = true;
            this.btnCuscode.Click += new System.EventHandler(this.btnCuscode_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCustomer";
            this.Text = "Khách hàng";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FOS_Utils.FTextBox fax;
        private FOS_Utils.FTextBox phone;
        private FOS_Utils.FTextBox email;
        private FOS_Utils.FTextBox cusaddress;
        private FOS_Utils.FTextBox taxcode;
        private FOS_Utils.FTextBox companyname;
        private FOS_Utils.FComboBox cussex;
        private FOS_Utils.FDateTimePicker cusbirthday;
        private FOS_Utils.FTextBox cusname;
        private FOS_Utils.FTextBox cuspass;
        private FOS_Utils.FTextBox cuscode;
        private FOS_Utils.FLabel fLabel7;
        private FOS_Utils.FLabel fLabel8;
        private FOS_Utils.FLabel fLabel11;
        private FOS_Utils.FLabel fLabel9;
        private FOS_Utils.FLabel fLabel10;
        private FOS_Utils.FLabel fLabel12;
        private FOS_Utils.FLabel fLabel13;
        private FOS_Utils.FLabel fLabel14;
        private FOS_Utils.FLabel fLabel15;
        private FOS_Utils.FLabel fLabel16;
        private FOS_Utils.FLabel fLabel17;
        private System.Windows.Forms.GroupBox groupBox1;
        private FOS_Utils.FButton btnCuscode;
        private FOS_Utils.FLabel lblStatus;
        private FOS_Utils.FTextBox fTextBox1;
        private FOS_Utils.FLabel fLabel1;
    }
}
