namespace FOS_Einvoice
{
    partial class FrmProducttype
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
            this.txtName = new FOS_Utils.FTextBox();
            this.fLabel2 = new FOS_Utils.FLabel();
            this.txtCode = new FOS_Utils.FTextBox();
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
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.fLabel2);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.fLabel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết về loại hàng hóa";
            // 
            // txtName
            // 
            this.txtName.CheckMinMaxChar = false;
            this.txtName.ColumnName = "producttypename";
            this.txtName.DBNullValueWhenBlank = false;
            this.txtName.DBValue = "";
            this.txtName.Enabled = false;
            this.txtName.FillZeroWhenHavingText = false;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtName.Location = new System.Drawing.Point(157, 62);
            this.txtName.MaxChar = '9';
            this.txtName.MaxLength = 100;
            this.txtName.MaxLengthFromByte = false;
            this.txtName.MinChar = '0';
            this.txtName.Name = "txtName";
            this.txtName.OldText = "";
            this.txtName.OutputControl = null;
            this.txtName.Size = new System.Drawing.Size(602, 25);
            this.txtName.TabIndex = 3;
            // 
            // fLabel2
            // 
            this.fLabel2.ColumnName = "";
            this.fLabel2.ForeColor = System.Drawing.Color.Black;
            this.fLabel2.Location = new System.Drawing.Point(8, 62);
            this.fLabel2.Name = "fLabel2";
            this.fLabel2.OldText = "";
            this.fLabel2.OutputControl = null;
            this.fLabel2.Size = new System.Drawing.Size(143, 25);
            this.fLabel2.TabIndex = 2;
            this.fLabel2.Text = "Tên loại hàng hóa:";
            this.fLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCode
            // 
            this.txtCode.CheckMinMaxChar = true;
            this.txtCode.ColumnName = "producttypecode";
            this.txtCode.DBNullValueWhenBlank = false;
            this.txtCode.DBValue = "";
            this.txtCode.FillZeroWhenHavingText = false;
            this.txtCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCode.Location = new System.Drawing.Point(157, 31);
            this.txtCode.MaxChar = '9';
            this.txtCode.MaxLength = 5;
            this.txtCode.MaxLengthFromByte = false;
            this.txtCode.MinChar = '0';
            this.txtCode.Name = "txtCode";
            this.txtCode.OldText = "";
            this.txtCode.OutputControl = null;
            this.txtCode.Size = new System.Drawing.Size(50, 25);
            this.txtCode.TabIndex = 1;
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
            this.fLabel3.Text = "Mã loại hàng hóa:";
            this.fLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmProducttype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProducttype";
            this.Text = "Loại hàng hóa";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FOS_Utils.FLabel fLabel3;
        private FOS_Utils.FTextBox txtName;
        private FOS_Utils.FLabel fLabel2;
        private FOS_Utils.FTextBox txtCode;
    }
}
