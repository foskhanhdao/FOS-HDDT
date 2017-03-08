namespace FOS_Einvoice
{
    partial class FrmLicenseConfirm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNumberTo = new FOS_Utils.FLabel();
            this.fLabel5 = new FOS_Utils.FLabel();
            this.lblNumberFrom = new FOS_Utils.FLabel();
            this.lblSymbol1 = new FOS_Utils.FLabel();
            this.lblTemplate = new FOS_Utils.FLabel();
            this.fLabel1 = new FOS_Utils.FLabel();
            this.fLabel15 = new FOS_Utils.FLabel();
            this.fLabel14 = new FOS_Utils.FLabel();
            this.txtSerialNumber = new FOS_Utils.FTextBox();
            this.btnConfirm = new FOS_Utils.FButton();
            this.btnClose = new FOS_Utils.FButton();
            this.lblSymbolSepa = new FOS_Utils.FLabel();
            this.lblSymbol2 = new FOS_Utils.FLabel();
            this.lblSymbol3 = new FOS_Utils.FLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtSerialNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 193);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hãy nhập Serial Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSymbol3);
            this.groupBox2.Controls.Add(this.lblSymbol2);
            this.groupBox2.Controls.Add(this.lblSymbolSepa);
            this.groupBox2.Controls.Add(this.lblNumberTo);
            this.groupBox2.Controls.Add(this.fLabel5);
            this.groupBox2.Controls.Add(this.lblNumberFrom);
            this.groupBox2.Controls.Add(this.lblSymbol1);
            this.groupBox2.Controls.Add(this.lblTemplate);
            this.groupBox2.Controls.Add(this.fLabel1);
            this.groupBox2.Controls.Add(this.fLabel15);
            this.groupBox2.Controls.Add(this.fLabel14);
            this.groupBox2.Location = new System.Drawing.Point(80, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 119);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // lblNumberTo
            // 
            this.lblNumberTo.ColumnName = "";
            this.lblNumberTo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberTo.ForeColor = System.Drawing.Color.Red;
            this.lblNumberTo.Location = new System.Drawing.Point(304, 85);
            this.lblNumberTo.Name = "lblNumberTo";
            this.lblNumberTo.OldText = "";
            this.lblNumberTo.OutputControl = null;
            this.lblNumberTo.Size = new System.Drawing.Size(69, 26);
            this.lblNumberTo.TabIndex = 10;
            this.lblNumberTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fLabel5
            // 
            this.fLabel5.ColumnName = "";
            this.fLabel5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel5.Location = new System.Drawing.Point(241, 85);
            this.fLabel5.Name = "fLabel5";
            this.fLabel5.OldText = "";
            this.fLabel5.OutputControl = null;
            this.fLabel5.Size = new System.Drawing.Size(57, 26);
            this.fLabel5.TabIndex = 9;
            this.fLabel5.Text = "đến số:";
            this.fLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumberFrom
            // 
            this.lblNumberFrom.ColumnName = "";
            this.lblNumberFrom.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberFrom.ForeColor = System.Drawing.Color.Red;
            this.lblNumberFrom.Location = new System.Drawing.Point(166, 84);
            this.lblNumberFrom.Name = "lblNumberFrom";
            this.lblNumberFrom.OldText = "";
            this.lblNumberFrom.OutputControl = null;
            this.lblNumberFrom.Size = new System.Drawing.Size(69, 26);
            this.lblNumberFrom.TabIndex = 8;
            this.lblNumberFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSymbol1
            // 
            this.lblSymbol1.ColumnName = "";
            this.lblSymbol1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol1.ForeColor = System.Drawing.Color.Red;
            this.lblSymbol1.Location = new System.Drawing.Point(166, 54);
            this.lblSymbol1.Name = "lblSymbol1";
            this.lblSymbol1.OldText = "";
            this.lblSymbol1.OutputControl = null;
            this.lblSymbol1.Size = new System.Drawing.Size(28, 26);
            this.lblSymbol1.TabIndex = 7;
            this.lblSymbol1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTemplate
            // 
            this.lblTemplate.ColumnName = "";
            this.lblTemplate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemplate.ForeColor = System.Drawing.Color.Red;
            this.lblTemplate.Location = new System.Drawing.Point(166, 23);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.OldText = "";
            this.lblTemplate.OutputControl = null;
            this.lblTemplate.Size = new System.Drawing.Size(223, 26);
            this.lblTemplate.TabIndex = 6;
            this.lblTemplate.Text = "01GTKT0/001";
            this.lblTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fLabel1
            // 
            this.fLabel1.ColumnName = "";
            this.fLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel1.Location = new System.Drawing.Point(44, 85);
            this.fLabel1.Name = "fLabel1";
            this.fLabel1.OldText = "";
            this.fLabel1.OutputControl = null;
            this.fLabel1.Size = new System.Drawing.Size(116, 26);
            this.fLabel1.TabIndex = 5;
            this.fLabel1.Text = "Từ số:";
            this.fLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel15
            // 
            this.fLabel15.ColumnName = "";
            this.fLabel15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel15.Location = new System.Drawing.Point(47, 23);
            this.fLabel15.Name = "fLabel15";
            this.fLabel15.OldText = "";
            this.fLabel15.OutputControl = null;
            this.fLabel15.Size = new System.Drawing.Size(113, 26);
            this.fLabel15.TabIndex = 3;
            this.fLabel15.Text = "Mẫu số:";
            this.fLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel14
            // 
            this.fLabel14.ColumnName = "";
            this.fLabel14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel14.Location = new System.Drawing.Point(47, 54);
            this.fLabel14.Name = "fLabel14";
            this.fLabel14.OldText = "";
            this.fLabel14.OutputControl = null;
            this.fLabel14.Size = new System.Drawing.Size(113, 26);
            this.fLabel14.TabIndex = 4;
            this.fLabel14.Text = "Ký hiệu:";
            this.fLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.CheckMinMaxChar = false;
            this.txtSerialNumber.ColumnName = "";
            this.txtSerialNumber.DBNullValueWhenBlank = false;
            this.txtSerialNumber.DBValue = "";
            this.txtSerialNumber.FillZeroWhenHavingText = false;
            this.txtSerialNumber.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumber.ForeColor = System.Drawing.Color.Red;
            this.txtSerialNumber.Location = new System.Drawing.Point(6, 29);
            this.txtSerialNumber.MaxChar = '9';
            this.txtSerialNumber.MaxLengthFromByte = false;
            this.txtSerialNumber.MinChar = '0';
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.OldText = "";
            this.txtSerialNumber.OutputControl = null;
            this.txtSerialNumber.Size = new System.Drawing.Size(556, 30);
            this.txtSerialNumber.TabIndex = 1;
            this.txtSerialNumber.TextChanged += new System.EventHandler(this.txtSerialNumber_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 211);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 50);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Đăng ký";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(480, 211);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Trở về";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSymbolSepa
            // 
            this.lblSymbolSepa.ColumnName = "";
            this.lblSymbolSepa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbolSepa.ForeColor = System.Drawing.Color.Red;
            this.lblSymbolSepa.Location = new System.Drawing.Point(192, 54);
            this.lblSymbolSepa.Name = "lblSymbolSepa";
            this.lblSymbolSepa.OldText = "";
            this.lblSymbolSepa.OutputControl = null;
            this.lblSymbolSepa.Size = new System.Drawing.Size(14, 26);
            this.lblSymbolSepa.TabIndex = 11;
            this.lblSymbolSepa.Text = "/";
            this.lblSymbolSepa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSymbolSepa.Visible = false;
            // 
            // lblSymbol2
            // 
            this.lblSymbol2.ColumnName = "";
            this.lblSymbol2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol2.ForeColor = System.Drawing.Color.Red;
            this.lblSymbol2.Location = new System.Drawing.Point(205, 54);
            this.lblSymbol2.Name = "lblSymbol2";
            this.lblSymbol2.OldText = "";
            this.lblSymbol2.OutputControl = null;
            this.lblSymbol2.Size = new System.Drawing.Size(28, 26);
            this.lblSymbol2.TabIndex = 12;
            this.lblSymbol2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSymbol3
            // 
            this.lblSymbol3.ColumnName = "";
            this.lblSymbol3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol3.ForeColor = System.Drawing.Color.Red;
            this.lblSymbol3.Location = new System.Drawing.Point(226, 54);
            this.lblSymbol3.Name = "lblSymbol3";
            this.lblSymbol3.OldText = "";
            this.lblSymbol3.OutputControl = null;
            this.lblSymbol3.Size = new System.Drawing.Size(28, 26);
            this.lblSymbol3.TabIndex = 13;
            this.lblSymbol3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmLicenseConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 275);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "FrmLicenseConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký sử dụng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FOS_Utils.FButton btnConfirm;
        private FOS_Utils.FButton btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private FOS_Utils.FLabel fLabel1;
        private FOS_Utils.FLabel fLabel15;
        private FOS_Utils.FLabel fLabel14;
        private FOS_Utils.FLabel lblTemplate;
        private FOS_Utils.FLabel lblNumberTo;
        private FOS_Utils.FLabel fLabel5;
        private FOS_Utils.FLabel lblNumberFrom;
        private FOS_Utils.FLabel lblSymbol1;
        private FOS_Utils.FTextBox txtSerialNumber;
        private FOS_Utils.FLabel lblSymbol3;
        private FOS_Utils.FLabel lblSymbol2;
        private FOS_Utils.FLabel lblSymbolSepa;
    }
}