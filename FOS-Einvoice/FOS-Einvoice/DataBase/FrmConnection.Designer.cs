namespace FOS_Einvoice
{
    partial class FrmConnection
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
            this.fLabel1 = new FOS_Utils.FLabel();
            this.fLabel2 = new FOS_Utils.FLabel();
            this.fLabel3 = new FOS_Utils.FLabel();
            this.fLabel4 = new FOS_Utils.FLabel();
            this.fLabel5 = new FOS_Utils.FLabel();
            this.txtServer = new FOS_Utils.FTextBox();
            this.txtPort = new FOS_Utils.FTextBox();
            this.txtUser = new FOS_Utils.FTextBox();
            this.txtPassword = new FOS_Utils.FTextBox();
            this.txtDatanbaseName = new FOS_Utils.FTextBox();
            this.btnSave = new FOS_Utils.FButton();
            this.btnClose = new FOS_Utils.FButton();
            this.chkSaveInfo = new FOS_Utils.FCheckBox();
            this.SuspendLayout();
            // 
            // fLabel1
            // 
            this.fLabel1.ColumnName = "";
            this.fLabel1.Location = new System.Drawing.Point(12, 12);
            this.fLabel1.Name = "fLabel1";
            this.fLabel1.OldText = "";
            this.fLabel1.OutputControl = null;
            this.fLabel1.Size = new System.Drawing.Size(133, 25);
            this.fLabel1.TabIndex = 0;
            this.fLabel1.Text = "Máy chủ:";
            this.fLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel2
            // 
            this.fLabel2.ColumnName = "";
            this.fLabel2.Location = new System.Drawing.Point(12, 43);
            this.fLabel2.Name = "fLabel2";
            this.fLabel2.OldText = "";
            this.fLabel2.OutputControl = null;
            this.fLabel2.Size = new System.Drawing.Size(133, 25);
            this.fLabel2.TabIndex = 1;
            this.fLabel2.Text = "Cổng kết nối:";
            this.fLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel3
            // 
            this.fLabel3.ColumnName = "";
            this.fLabel3.Location = new System.Drawing.Point(12, 74);
            this.fLabel3.Name = "fLabel3";
            this.fLabel3.OldText = "";
            this.fLabel3.OutputControl = null;
            this.fLabel3.Size = new System.Drawing.Size(133, 25);
            this.fLabel3.TabIndex = 2;
            this.fLabel3.Text = "Tên đăng nhập:";
            this.fLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel4
            // 
            this.fLabel4.ColumnName = "";
            this.fLabel4.Location = new System.Drawing.Point(12, 105);
            this.fLabel4.Name = "fLabel4";
            this.fLabel4.OldText = "";
            this.fLabel4.OutputControl = null;
            this.fLabel4.Size = new System.Drawing.Size(133, 25);
            this.fLabel4.TabIndex = 3;
            this.fLabel4.Text = "Mật khẩu:";
            this.fLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel5
            // 
            this.fLabel5.ColumnName = "";
            this.fLabel5.Location = new System.Drawing.Point(12, 136);
            this.fLabel5.Name = "fLabel5";
            this.fLabel5.OldText = "";
            this.fLabel5.OutputControl = null;
            this.fLabel5.Size = new System.Drawing.Size(133, 25);
            this.fLabel5.TabIndex = 4;
            this.fLabel5.Text = "Tên cơ sở dữ liệu:";
            this.fLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServer
            // 
            this.txtServer.CheckMinMaxChar = false;
            this.txtServer.ColumnName = "";
            this.txtServer.DBNullValueWhenBlank = false;
            this.txtServer.DBValue = "";
            this.txtServer.FillZeroWhenHavingText = false;
            this.txtServer.Location = new System.Drawing.Point(151, 12);
            this.txtServer.MaxChar = '9';
            this.txtServer.MaxLengthFromByte = false;
            this.txtServer.MinChar = '0';
            this.txtServer.Name = "txtServer";
            this.txtServer.OldText = "";
            this.txtServer.OutputControl = null;
            this.txtServer.Size = new System.Drawing.Size(261, 25);
            this.txtServer.TabIndex = 5;
            // 
            // txtPort
            // 
            this.txtPort.CheckMinMaxChar = false;
            this.txtPort.ColumnName = "";
            this.txtPort.DBNullValueWhenBlank = false;
            this.txtPort.DBValue = "";
            this.txtPort.FillZeroWhenHavingText = false;
            this.txtPort.Location = new System.Drawing.Point(151, 43);
            this.txtPort.MaxChar = '9';
            this.txtPort.MaxLengthFromByte = false;
            this.txtPort.MinChar = '0';
            this.txtPort.Name = "txtPort";
            this.txtPort.OldText = "";
            this.txtPort.OutputControl = null;
            this.txtPort.Size = new System.Drawing.Size(261, 25);
            this.txtPort.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.CheckMinMaxChar = false;
            this.txtUser.ColumnName = "";
            this.txtUser.DBNullValueWhenBlank = false;
            this.txtUser.DBValue = "";
            this.txtUser.FillZeroWhenHavingText = false;
            this.txtUser.Location = new System.Drawing.Point(151, 74);
            this.txtUser.MaxChar = '9';
            this.txtUser.MaxLengthFromByte = false;
            this.txtUser.MinChar = '0';
            this.txtUser.Name = "txtUser";
            this.txtUser.OldText = "";
            this.txtUser.OutputControl = null;
            this.txtUser.Size = new System.Drawing.Size(261, 25);
            this.txtUser.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.CheckMinMaxChar = false;
            this.txtPassword.ColumnName = "";
            this.txtPassword.DBNullValueWhenBlank = false;
            this.txtPassword.DBValue = "";
            this.txtPassword.FillZeroWhenHavingText = false;
            this.txtPassword.Location = new System.Drawing.Point(151, 105);
            this.txtPassword.MaxChar = '9';
            this.txtPassword.MaxLengthFromByte = false;
            this.txtPassword.MinChar = '0';
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.OldText = "";
            this.txtPassword.OutputControl = null;
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(261, 25);
            this.txtPassword.TabIndex = 8;
            // 
            // txtDatanbaseName
            // 
            this.txtDatanbaseName.CheckMinMaxChar = false;
            this.txtDatanbaseName.ColumnName = "";
            this.txtDatanbaseName.DBNullValueWhenBlank = false;
            this.txtDatanbaseName.DBValue = "";
            this.txtDatanbaseName.FillZeroWhenHavingText = false;
            this.txtDatanbaseName.Location = new System.Drawing.Point(151, 136);
            this.txtDatanbaseName.MaxChar = '9';
            this.txtDatanbaseName.MaxLengthFromByte = false;
            this.txtDatanbaseName.MinChar = '0';
            this.txtDatanbaseName.Name = "txtDatanbaseName";
            this.txtDatanbaseName.OldText = "";
            this.txtDatanbaseName.OutputControl = null;
            this.txtDatanbaseName.Size = new System.Drawing.Size(261, 25);
            this.txtDatanbaseName.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::FOS_Einvoice.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Cài đặt";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(312, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkSaveInfo
            // 
            this.chkSaveInfo.AutoSize = true;
            this.chkSaveInfo.Checked = true;
            this.chkSaveInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveInfo.ColumnName = "";
            this.chkSaveInfo.DBValue = "1";
            this.chkSaveInfo.Location = new System.Drawing.Point(148, 167);
            this.chkSaveInfo.Name = "chkSaveInfo";
            this.chkSaveInfo.Size = new System.Drawing.Size(169, 21);
            this.chkSaveInfo.TabIndex = 12;
            this.chkSaveInfo.Text = "Lưu trữ thông số cài đặt";
            this.chkSaveInfo.UseVisualStyleBackColor = true;
            this.chkSaveInfo.ValueWhenFalse = 0;
            this.chkSaveInfo.ValueWhenTrue = 1;
            // 
            // FrmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 242);
            this.Controls.Add(this.chkSaveInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDatanbaseName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.fLabel5);
            this.Controls.Add(this.fLabel4);
            this.Controls.Add(this.fLabel3);
            this.Controls.Add(this.fLabel2);
            this.Controls.Add(this.fLabel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập thông số kết nối dữ liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FOS_Utils.FLabel fLabel1;
        private FOS_Utils.FLabel fLabel2;
        private FOS_Utils.FLabel fLabel3;
        private FOS_Utils.FLabel fLabel4;
        private FOS_Utils.FLabel fLabel5;
        private FOS_Utils.FTextBox txtServer;
        private FOS_Utils.FTextBox txtPort;
        private FOS_Utils.FTextBox txtUser;
        private FOS_Utils.FTextBox txtPassword;
        private FOS_Utils.FTextBox txtDatanbaseName;
        private FOS_Utils.FButton btnSave;
        private FOS_Utils.FButton btnClose;
        private FOS_Utils.FCheckBox chkSaveInfo;
    }
}