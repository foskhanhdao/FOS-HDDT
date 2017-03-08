namespace FOS_Einvoice
{
    partial class FrmCompany
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
            this.lblStatus = new FOS_Utils.FLabel();
            this.btnCompanycode = new FOS_Utils.FButton();
            this.note = new FOS_Utils.FTextBox();
            this.fLabel6 = new FOS_Utils.FLabel();
            this.bankname = new FOS_Utils.FTextBox();
            this.fLabel5 = new FOS_Utils.FLabel();
            this.bankaccount = new FOS_Utils.FTextBox();
            this.fLabel11 = new FOS_Utils.FLabel();
            this.phone = new FOS_Utils.FTextBox();
            this.fLabel10 = new FOS_Utils.FLabel();
            this.email = new FOS_Utils.FTextBox();
            this.fLabel9 = new FOS_Utils.FLabel();
            this.website = new FOS_Utils.FTextBox();
            this.fLabel8 = new FOS_Utils.FLabel();
            this.fax = new FOS_Utils.FTextBox();
            this.fLabel7 = new FOS_Utils.FLabel();
            this.companyaddress = new FOS_Utils.FTextBox();
            this.fLabel4 = new FOS_Utils.FLabel();
            this.taxcode = new FOS_Utils.FTextBox();
            this.fLabel2 = new FOS_Utils.FLabel();
            this.companyname = new FOS_Utils.FTextBox();
            this.fLabel1 = new FOS_Utils.FLabel();
            this.companycode = new FOS_Utils.FTextBox();
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
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.btnCompanycode);
            this.groupBox1.Controls.Add(this.note);
            this.groupBox1.Controls.Add(this.fLabel6);
            this.groupBox1.Controls.Add(this.bankname);
            this.groupBox1.Controls.Add(this.fLabel5);
            this.groupBox1.Controls.Add(this.bankaccount);
            this.groupBox1.Controls.Add(this.fLabel11);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.fLabel10);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.fLabel9);
            this.groupBox1.Controls.Add(this.website);
            this.groupBox1.Controls.Add(this.fLabel8);
            this.groupBox1.Controls.Add(this.fax);
            this.groupBox1.Controls.Add(this.fLabel7);
            this.groupBox1.Controls.Add(this.companyaddress);
            this.groupBox1.Controls.Add(this.fLabel4);
            this.groupBox1.Controls.Add(this.taxcode);
            this.groupBox1.Controls.Add(this.fLabel2);
            this.groupBox1.Controls.Add(this.companyname);
            this.groupBox1.Controls.Add(this.fLabel1);
            this.groupBox1.Controls.Add(this.companycode);
            this.groupBox1.Controls.Add(this.fLabel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết về công ty";
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
            // btnCompanycode
            // 
            this.btnCompanycode.Location = new System.Drawing.Point(317, 31);
            this.btnCompanycode.Name = "btnCompanycode";
            this.btnCompanycode.Size = new System.Drawing.Size(38, 25);
            this.btnCompanycode.TabIndex = 22;
            this.btnCompanycode.TabStop = false;
            this.btnCompanycode.Text = "...";
            this.btnCompanycode.UseVisualStyleBackColor = true;
            this.btnCompanycode.Click += new System.EventHandler(this.btnCompanycode_Click);
            // 
            // note
            // 
            this.note.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.note.CheckMinMaxChar = false;
            this.note.ColumnName = "companynote";
            this.note.DBNullValueWhenBlank = false;
            this.note.DBValue = "";
            this.note.Enabled = false;
            this.note.FillZeroWhenHavingText = false;
            this.note.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.note.Location = new System.Drawing.Point(157, 341);
            this.note.MaxChar = '9';
            this.note.MaxLength = 200;
            this.note.MaxLengthFromByte = false;
            this.note.MinChar = '0';
            this.note.Name = "note";
            this.note.OldText = "";
            this.note.OutputControl = null;
            this.note.Size = new System.Drawing.Size(602, 25);
            this.note.TabIndex = 10;
            // 
            // fLabel6
            // 
            this.fLabel6.ColumnName = "";
            this.fLabel6.ForeColor = System.Drawing.Color.Black;
            this.fLabel6.Location = new System.Drawing.Point(8, 341);
            this.fLabel6.Name = "fLabel6";
            this.fLabel6.OldText = "";
            this.fLabel6.OutputControl = null;
            this.fLabel6.Size = new System.Drawing.Size(143, 25);
            this.fLabel6.TabIndex = 21;
            this.fLabel6.Text = "Ghi chú:";
            this.fLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bankname
            // 
            this.bankname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bankname.CheckMinMaxChar = false;
            this.bankname.ColumnName = "companybankname";
            this.bankname.DBNullValueWhenBlank = false;
            this.bankname.DBValue = "";
            this.bankname.Enabled = false;
            this.bankname.FillZeroWhenHavingText = false;
            this.bankname.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.bankname.Location = new System.Drawing.Point(157, 310);
            this.bankname.MaxChar = '9';
            this.bankname.MaxLength = 200;
            this.bankname.MaxLengthFromByte = false;
            this.bankname.MinChar = '0';
            this.bankname.Name = "bankname";
            this.bankname.OldText = "";
            this.bankname.OutputControl = null;
            this.bankname.Size = new System.Drawing.Size(602, 25);
            this.bankname.TabIndex = 9;
            // 
            // fLabel5
            // 
            this.fLabel5.ColumnName = "";
            this.fLabel5.ForeColor = System.Drawing.Color.Black;
            this.fLabel5.Location = new System.Drawing.Point(8, 310);
            this.fLabel5.Name = "fLabel5";
            this.fLabel5.OldText = "";
            this.fLabel5.OutputControl = null;
            this.fLabel5.Size = new System.Drawing.Size(143, 25);
            this.fLabel5.TabIndex = 20;
            this.fLabel5.Text = "Tên ngân hàng:";
            this.fLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bankaccount
            // 
            this.bankaccount.CheckMinMaxChar = false;
            this.bankaccount.ColumnName = "companybankaccount";
            this.bankaccount.DBNullValueWhenBlank = false;
            this.bankaccount.DBValue = "";
            this.bankaccount.Enabled = false;
            this.bankaccount.FillZeroWhenHavingText = false;
            this.bankaccount.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.bankaccount.Location = new System.Drawing.Point(157, 279);
            this.bankaccount.MaxChar = '9';
            this.bankaccount.MaxLength = 50;
            this.bankaccount.MaxLengthFromByte = false;
            this.bankaccount.MinChar = '0';
            this.bankaccount.Name = "bankaccount";
            this.bankaccount.OldText = "";
            this.bankaccount.OutputControl = null;
            this.bankaccount.Size = new System.Drawing.Size(364, 25);
            this.bankaccount.TabIndex = 8;
            // 
            // fLabel11
            // 
            this.fLabel11.ColumnName = "";
            this.fLabel11.ForeColor = System.Drawing.Color.Black;
            this.fLabel11.Location = new System.Drawing.Point(8, 279);
            this.fLabel11.Name = "fLabel11";
            this.fLabel11.OldText = "";
            this.fLabel11.OutputControl = null;
            this.fLabel11.Size = new System.Drawing.Size(143, 25);
            this.fLabel11.TabIndex = 19;
            this.fLabel11.Text = "Tài khoản ngân hàng:";
            this.fLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phone
            // 
            this.phone.CheckMinMaxChar = false;
            this.phone.ColumnName = "companyphone";
            this.phone.DBNullValueWhenBlank = false;
            this.phone.DBValue = "";
            this.phone.Enabled = false;
            this.phone.FillZeroWhenHavingText = false;
            this.phone.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.phone.Location = new System.Drawing.Point(157, 155);
            this.phone.MaxChar = '9';
            this.phone.MaxLength = 20;
            this.phone.MaxLengthFromByte = false;
            this.phone.MinChar = '0';
            this.phone.Name = "phone";
            this.phone.OldText = "";
            this.phone.OutputControl = null;
            this.phone.Size = new System.Drawing.Size(154, 25);
            this.phone.TabIndex = 4;
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
            this.fLabel10.TabIndex = 15;
            this.fLabel10.Text = "Điện thoại:";
            this.fLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // email
            // 
            this.email.CheckMinMaxChar = false;
            this.email.ColumnName = "companyemail";
            this.email.DBNullValueWhenBlank = false;
            this.email.DBValue = "";
            this.email.Enabled = false;
            this.email.FillZeroWhenHavingText = false;
            this.email.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.email.Location = new System.Drawing.Point(157, 248);
            this.email.MaxChar = '9';
            this.email.MaxLength = 50;
            this.email.MaxLengthFromByte = false;
            this.email.MinChar = '0';
            this.email.Name = "email";
            this.email.OldText = "";
            this.email.OutputControl = null;
            this.email.Size = new System.Drawing.Size(364, 25);
            this.email.TabIndex = 7;
            // 
            // fLabel9
            // 
            this.fLabel9.ColumnName = "";
            this.fLabel9.ForeColor = System.Drawing.Color.Black;
            this.fLabel9.Location = new System.Drawing.Point(8, 248);
            this.fLabel9.Name = "fLabel9";
            this.fLabel9.OldText = "";
            this.fLabel9.OutputControl = null;
            this.fLabel9.Size = new System.Drawing.Size(143, 25);
            this.fLabel9.TabIndex = 18;
            this.fLabel9.Text = "Email:";
            this.fLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // website
            // 
            this.website.CheckMinMaxChar = false;
            this.website.ColumnName = "companywebsite";
            this.website.DBNullValueWhenBlank = false;
            this.website.DBValue = "";
            this.website.Enabled = false;
            this.website.FillZeroWhenHavingText = false;
            this.website.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.website.Location = new System.Drawing.Point(157, 217);
            this.website.MaxChar = '9';
            this.website.MaxLength = 50;
            this.website.MaxLengthFromByte = false;
            this.website.MinChar = '0';
            this.website.Name = "website";
            this.website.OldText = "";
            this.website.OutputControl = null;
            this.website.Size = new System.Drawing.Size(364, 25);
            this.website.TabIndex = 6;
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
            this.fLabel8.TabIndex = 17;
            this.fLabel8.Text = "Website:";
            this.fLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fax
            // 
            this.fax.CheckMinMaxChar = false;
            this.fax.ColumnName = "companyfax";
            this.fax.DBNullValueWhenBlank = false;
            this.fax.DBValue = "";
            this.fax.Enabled = false;
            this.fax.FillZeroWhenHavingText = false;
            this.fax.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.fax.Location = new System.Drawing.Point(157, 186);
            this.fax.MaxChar = '9';
            this.fax.MaxLength = 20;
            this.fax.MaxLengthFromByte = false;
            this.fax.MinChar = '0';
            this.fax.Name = "fax";
            this.fax.OldText = "";
            this.fax.OutputControl = null;
            this.fax.Size = new System.Drawing.Size(154, 25);
            this.fax.TabIndex = 5;
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
            this.fLabel7.TabIndex = 16;
            this.fLabel7.Text = "Fax:";
            this.fLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // companyaddress
            // 
            this.companyaddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.companyaddress.CheckMinMaxChar = false;
            this.companyaddress.ColumnName = "companyaddress";
            this.companyaddress.DBNullValueWhenBlank = false;
            this.companyaddress.DBValue = "";
            this.companyaddress.Enabled = false;
            this.companyaddress.FillZeroWhenHavingText = false;
            this.companyaddress.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.companyaddress.Location = new System.Drawing.Point(157, 124);
            this.companyaddress.MaxChar = '9';
            this.companyaddress.MaxLength = 200;
            this.companyaddress.MaxLengthFromByte = false;
            this.companyaddress.MinChar = '0';
            this.companyaddress.Name = "companyaddress";
            this.companyaddress.OldText = "";
            this.companyaddress.OutputControl = null;
            this.companyaddress.Size = new System.Drawing.Size(602, 25);
            this.companyaddress.TabIndex = 3;
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
            this.fLabel4.TabIndex = 14;
            this.fLabel4.Text = "Địa chỉ:";
            this.fLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxcode
            // 
            this.taxcode.CheckMinMaxChar = false;
            this.taxcode.ColumnName = "companytaxcode";
            this.taxcode.DBNullValueWhenBlank = false;
            this.taxcode.DBValue = "";
            this.taxcode.Enabled = false;
            this.taxcode.FillZeroWhenHavingText = false;
            this.taxcode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.taxcode.Location = new System.Drawing.Point(157, 93);
            this.taxcode.MaxChar = '9';
            this.taxcode.MaxLength = 15;
            this.taxcode.MaxLengthFromByte = false;
            this.taxcode.MinChar = '0';
            this.taxcode.Name = "taxcode";
            this.taxcode.OldText = "";
            this.taxcode.OutputControl = null;
            this.taxcode.Size = new System.Drawing.Size(120, 25);
            this.taxcode.TabIndex = 2;
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
            this.fLabel2.TabIndex = 13;
            this.fLabel2.Text = "Mã số thuế:";
            this.fLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // companyname
            // 
            this.companyname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.companyname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.companyname.CheckMinMaxChar = false;
            this.companyname.ColumnName = "companyname";
            this.companyname.DBNullValueWhenBlank = false;
            this.companyname.DBValue = "";
            this.companyname.Enabled = false;
            this.companyname.FillZeroWhenHavingText = false;
            this.companyname.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.companyname.Location = new System.Drawing.Point(157, 62);
            this.companyname.MaxChar = '9';
            this.companyname.MaxLength = 200;
            this.companyname.MaxLengthFromByte = false;
            this.companyname.MinChar = '0';
            this.companyname.Name = "companyname";
            this.companyname.OldText = "";
            this.companyname.OutputControl = null;
            this.companyname.Size = new System.Drawing.Size(602, 25);
            this.companyname.TabIndex = 1;
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
            this.fLabel1.TabIndex = 12;
            this.fLabel1.Text = "Tên công ty:";
            this.fLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // companycode
            // 
            this.companycode.CheckMinMaxChar = true;
            this.companycode.ColumnName = "companycode";
            this.companycode.DBNullValueWhenBlank = false;
            this.companycode.DBValue = "";
            this.companycode.FillZeroWhenHavingText = false;
            this.companycode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.companycode.Location = new System.Drawing.Point(157, 31);
            this.companycode.MaxChar = '9';
            this.companycode.MaxLength = 20;
            this.companycode.MaxLengthFromByte = false;
            this.companycode.MinChar = '0';
            this.companycode.Name = "companycode";
            this.companycode.OldText = "";
            this.companycode.OutputControl = null;
            this.companycode.Size = new System.Drawing.Size(154, 25);
            this.companycode.TabIndex = 0;
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
            this.fLabel3.TabIndex = 11;
            this.fLabel3.Text = "Mã công ty:";
            this.fLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCompany";
            this.Text = "Công ty";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FOS_Utils.FTextBox phone;
        private FOS_Utils.FLabel fLabel10;
        private FOS_Utils.FTextBox email;
        private FOS_Utils.FLabel fLabel9;
        private FOS_Utils.FTextBox website;
        private FOS_Utils.FLabel fLabel8;
        private FOS_Utils.FTextBox fax;
        private FOS_Utils.FLabel fLabel7;
        private FOS_Utils.FTextBox companyaddress;
        private FOS_Utils.FLabel fLabel4;
        private FOS_Utils.FTextBox taxcode;
        private FOS_Utils.FLabel fLabel2;
        private FOS_Utils.FTextBox companyname;
        private FOS_Utils.FLabel fLabel1;
        private FOS_Utils.FTextBox companycode;
        private FOS_Utils.FLabel fLabel3;
        private FOS_Utils.FTextBox bankaccount;
        private FOS_Utils.FLabel fLabel11;
        private FOS_Utils.FTextBox bankname;
        private FOS_Utils.FLabel fLabel5;
        private FOS_Utils.FTextBox note;
        private FOS_Utils.FLabel fLabel6;
        private FOS_Utils.FButton btnCompanycode;
        private FOS_Utils.FLabel lblStatus;
    }
}
