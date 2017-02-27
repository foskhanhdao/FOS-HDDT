namespace FOS_Einvoice
{
    partial class FrmLogin
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
            this.fTextBox2 = new FOS_Utils.FTextBox();
            this.fTextBox1 = new FOS_Utils.FTextBox();
            this.fLabel2 = new FOS_Utils.FLabel();
            this.fLabel1 = new FOS_Utils.FLabel();
            this.btnLogin = new FOS_Utils.FButton();
            this.btnClose = new FOS_Utils.FButton();
            this.SuspendLayout();
            // 
            // fTextBox2
            // 
            this.fTextBox2.CheckMinMaxChar = false;
            this.fTextBox2.ColumnName = "";
            this.fTextBox2.DBNullValueWhenBlank = false;
            this.fTextBox2.FillZeroWhenHavingText = false;
            this.fTextBox2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.fTextBox2.Location = new System.Drawing.Point(149, 62);
            this.fTextBox2.MaxChar = '9';
            this.fTextBox2.MaxLength = 20;
            this.fTextBox2.MaxLengthFromByte = false;
            this.fTextBox2.MinChar = '0';
            this.fTextBox2.Name = "fTextBox2";
            this.fTextBox2.OldText = "";
            this.fTextBox2.OutputControl = null;
            this.fTextBox2.PasswordChar = '*';
            this.fTextBox2.Size = new System.Drawing.Size(231, 25);
            this.fTextBox2.TabIndex = 3;
            // 
            // fTextBox1
            // 
            this.fTextBox1.CheckMinMaxChar = false;
            this.fTextBox1.ColumnName = "";
            this.fTextBox1.DBNullValueWhenBlank = false;
            this.fTextBox1.FillZeroWhenHavingText = false;
            this.fTextBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.fTextBox1.Location = new System.Drawing.Point(149, 31);
            this.fTextBox1.MaxChar = '9';
            this.fTextBox1.MaxLength = 20;
            this.fTextBox1.MaxLengthFromByte = false;
            this.fTextBox1.MinChar = '0';
            this.fTextBox1.Name = "fTextBox1";
            this.fTextBox1.OldText = "";
            this.fTextBox1.OutputControl = null;
            this.fTextBox1.Size = new System.Drawing.Size(231, 25);
            this.fTextBox1.TabIndex = 2;
            // 
            // fLabel2
            // 
            this.fLabel2.ColumnName = "";
            this.fLabel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel2.Location = new System.Drawing.Point(12, 62);
            this.fLabel2.Name = "fLabel2";
            this.fLabel2.OldText = "";
            this.fLabel2.OutputControl = null;
            this.fLabel2.Size = new System.Drawing.Size(131, 25);
            this.fLabel2.TabIndex = 1;
            this.fLabel2.Text = "Mã đăng nhập:";
            this.fLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel1
            // 
            this.fLabel1.ColumnName = "";
            this.fLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel1.Location = new System.Drawing.Point(12, 30);
            this.fLabel1.Name = "fLabel1";
            this.fLabel1.OldText = "";
            this.fLabel1.OutputControl = null;
            this.fLabel1.Size = new System.Drawing.Size(131, 25);
            this.fLabel1.TabIndex = 0;
            this.fLabel1.Text = "Tên đăng nhập:";
            this.fLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(149, 118);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(280, 118);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Bỏ qua";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 173);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.fTextBox2);
            this.Controls.Add(this.fTextBox1);
            this.Controls.Add(this.fLabel2);
            this.Controls.Add(this.fLabel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);

        }

        #endregion

        private FOS_Utils.FLabel fLabel1;
        private FOS_Utils.FLabel fLabel2;
        private FOS_Utils.FTextBox fTextBox1;
        private FOS_Utils.FTextBox fTextBox2;
        private FOS_Utils.FButton btnLogin;
        private FOS_Utils.FButton btnClose;
    }
}