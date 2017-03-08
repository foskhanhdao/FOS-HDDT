namespace FOS_Einvoice
{
    partial class FrmTestPDF
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.invoiceGTGT1 = new FOS_Einvoice.Invoices.invoiceGTGT();
            this.btnMau = new FOS_Utils.FButton();
            this.btnPreview = new FOS_Utils.FButton();
            this.btnPDF = new FOS_Utils.FButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.invoiceGTGT1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 509);
            this.panel1.TabIndex = 0;
            // 
            // invoiceGTGT1
            // 
            this.invoiceGTGT1.Location = new System.Drawing.Point(0, 0);
            this.invoiceGTGT1.Name = "invoiceGTGT1";
            this.invoiceGTGT1.Size = new System.Drawing.Size(750, 1120);
            this.invoiceGTGT1.TabIndex = 0;
            // 
            // btnMau
            // 
            this.btnMau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMau.Location = new System.Drawing.Point(346, 527);
            this.btnMau.Name = "btnMau";
            this.btnMau.Size = new System.Drawing.Size(161, 34);
            this.btnMau.TabIndex = 3;
            this.btnMau.Text = "Mẫu phát hành";
            this.btnMau.UseVisualStyleBackColor = true;
            this.btnMau.Click += new System.EventHandler(this.btnMau_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreview.Location = new System.Drawing.Point(179, 527);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(161, 34);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPDF.Location = new System.Drawing.Point(12, 527);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(161, 34);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.Text = "Xuất hóa đơn";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(594, 528);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // FrmTestPDF
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnMau);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTestPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTestPDF";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FOS_Utils.FButton btnPDF;
        private FOS_Utils.FButton btnPreview;
        private FOS_Utils.FButton btnMau;
        private FOS_Einvoice.Invoices.invoiceGTGT invoiceGTGT1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}