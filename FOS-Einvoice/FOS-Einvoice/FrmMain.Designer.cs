namespace FOS_Einvoice
{
    partial class FrmMain
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
            this.btnInvoiceCreate = new FOS_Utils.FButton();
            this.btnCustomer = new FOS_Utils.FButton();
            this.btnConnection = new FOS_Utils.FButton();
            this.btnCompany = new FOS_Utils.FButton();
            this.btnTest = new FOS_Utils.FButton();
            this.SuspendLayout();
            // 
            // btnInvoiceCreate
            // 
            this.btnInvoiceCreate.Location = new System.Drawing.Point(12, 168);
            this.btnInvoiceCreate.Name = "btnInvoiceCreate";
            this.btnInvoiceCreate.Size = new System.Drawing.Size(150, 150);
            this.btnInvoiceCreate.TabIndex = 0;
            this.btnInvoiceCreate.Text = "Xuất hóa đơn";
            this.btnInvoiceCreate.UseVisualStyleBackColor = true;
            this.btnInvoiceCreate.Click += new System.EventHandler(this.btnInvoiceCreate_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(168, 168);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(150, 150);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Khánh hàng";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(12, 12);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(150, 150);
            this.btnConnection.TabIndex = 2;
            this.btnConnection.Text = "Connection";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.Location = new System.Drawing.Point(324, 168);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(150, 150);
            this.btnCompany.TabIndex = 3;
            this.btnCompany.Text = "Công ty";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(168, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(150, 150);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test Print";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnInvoiceCreate);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOS-Einvoice";
            this.ResumeLayout(false);

        }

        #endregion

        private FOS_Utils.FButton btnInvoiceCreate;
        private FOS_Utils.FButton btnCustomer;
        private FOS_Utils.FButton btnConnection;
        private FOS_Utils.FButton btnCompany;
        private FOS_Utils.FButton btnTest;
    }
}

