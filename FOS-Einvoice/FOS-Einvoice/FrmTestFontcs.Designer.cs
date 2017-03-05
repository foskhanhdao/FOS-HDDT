namespace FOS_Einvoice
{
    partial class FrmTestFontcs
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
            FOS_Utils.PDF.PDFControl.FPdfProperties fPdfProperties1 = new FOS_Utils.PDF.PDFControl.FPdfProperties();
            FOS_Utils.PDF.PDFControl.FPdfProperties fPdfProperties2 = new FOS_Utils.PDF.PDFControl.FPdfProperties();
            FOS_Utils.PDF.PDFControl.FPdfProperties fPdfProperties3 = new FOS_Utils.PDF.PDFControl.FPdfProperties();
            FOS_Utils.PDF.PDFControl.FPdfProperties fPdfProperties4 = new FOS_Utils.PDF.PDFControl.FPdfProperties();
            this.fButton1 = new FOS_Utils.FButton();
            this.fPdfPanel1 = new FOS_Utils.PDF.PDFControl.FPdfPanel();
            this.fPdfLabel4 = new FOS_Utils.PDF.PDFControl.FPdfLabel();
            this.fPdfLabel3 = new FOS_Utils.PDF.PDFControl.FPdfLabel();
            this.fPdfLabel2 = new FOS_Utils.PDF.PDFControl.FPdfLabel();
            this.fPdfLabel1 = new FOS_Utils.PDF.PDFControl.FPdfLabel();
            this.fPdfPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fButton1
            // 
            this.fButton1.Location = new System.Drawing.Point(237, 322);
            this.fButton1.Name = "fButton1";
            this.fButton1.Size = new System.Drawing.Size(75, 23);
            this.fButton1.TabIndex = 1;
            this.fButton1.Text = "fButton1";
            this.fButton1.UseVisualStyleBackColor = true;
            this.fButton1.Click += new System.EventHandler(this.fButton1_Click);
            // 
            // fPdfPanel1
            // 
            this.fPdfPanel1.BackColor = System.Drawing.Color.White;
            this.fPdfPanel1.Controls.Add(this.fPdfLabel4);
            this.fPdfPanel1.Controls.Add(this.fPdfLabel3);
            this.fPdfPanel1.Controls.Add(this.fPdfLabel2);
            this.fPdfPanel1.Controls.Add(this.fPdfLabel1);
            this.fPdfPanel1.Location = new System.Drawing.Point(79, 71);
            this.fPdfPanel1.MaxRow = 1;
            this.fPdfPanel1.Name = "fPdfPanel1";
            this.fPdfPanel1.PageType = FOS_Utils.PDF.PDFLib.PageType.Custom;
            this.fPdfPanel1.PnDetail = null;
            this.fPdfPanel1.Size = new System.Drawing.Size(324, 245);
            this.fPdfPanel1.TabIndex = 0;
            // 
            // fPdfLabel4
            // 
            this.fPdfLabel4.ColumnName = "";
            this.fPdfLabel4.DBValue = "Giá hàng hóa";
            this.fPdfLabel4.Font = new System.Drawing.Font("Microsoft MHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fPdfProperties1.Rotation = 0;
            fPdfProperties1.TableColumn = "";
            fPdfProperties1.TableRow = 0;
            this.fPdfLabel4.FPdfProperties = fPdfProperties1;
            this.fPdfLabel4.IsShowLineBottom = true;
            this.fPdfLabel4.IsShowLineLeft = true;
            this.fPdfLabel4.IsShowLineRight = true;
            this.fPdfLabel4.IsShowLineTop = true;
            this.fPdfLabel4.LineStyleBottom = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel4.LineStyleLeft = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel4.LineStyleRight = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel4.LineStyleTop = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel4.Location = new System.Drawing.Point(74, 136);
            this.fPdfLabel4.Name = "fPdfLabel4";
            this.fPdfLabel4.Size = new System.Drawing.Size(184, 23);
            this.fPdfLabel4.TabIndex = 0;
            this.fPdfLabel4.Text = "Giá hàng hóa";
            this.fPdfLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fPdfLabel3
            // 
            this.fPdfLabel3.ColumnName = "";
            this.fPdfLabel3.DBValue = "Giá hàng hóa";
            this.fPdfLabel3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fPdfProperties2.Rotation = 0;
            fPdfProperties2.TableColumn = "";
            fPdfProperties2.TableRow = 0;
            this.fPdfLabel3.FPdfProperties = fPdfProperties2;
            this.fPdfLabel3.IsShowLineBottom = true;
            this.fPdfLabel3.IsShowLineLeft = true;
            this.fPdfLabel3.IsShowLineRight = true;
            this.fPdfLabel3.IsShowLineTop = true;
            this.fPdfLabel3.LineStyleBottom = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel3.LineStyleLeft = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel3.LineStyleRight = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel3.LineStyleTop = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel3.Location = new System.Drawing.Point(74, 102);
            this.fPdfLabel3.Name = "fPdfLabel3";
            this.fPdfLabel3.Size = new System.Drawing.Size(184, 23);
            this.fPdfLabel3.TabIndex = 0;
            this.fPdfLabel3.Text = "Giá hàng hóa";
            this.fPdfLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fPdfLabel2
            // 
            this.fPdfLabel2.ColumnName = "";
            this.fPdfLabel2.DBValue = "Giá hàng hóa";
            this.fPdfLabel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fPdfProperties3.Rotation = 0;
            fPdfProperties3.TableColumn = "";
            fPdfProperties3.TableRow = 0;
            this.fPdfLabel2.FPdfProperties = fPdfProperties3;
            this.fPdfLabel2.IsShowLineBottom = true;
            this.fPdfLabel2.IsShowLineLeft = true;
            this.fPdfLabel2.IsShowLineRight = true;
            this.fPdfLabel2.IsShowLineTop = true;
            this.fPdfLabel2.LineStyleBottom = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel2.LineStyleLeft = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel2.LineStyleRight = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel2.LineStyleTop = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel2.Location = new System.Drawing.Point(74, 66);
            this.fPdfLabel2.Name = "fPdfLabel2";
            this.fPdfLabel2.Size = new System.Drawing.Size(184, 23);
            this.fPdfLabel2.TabIndex = 0;
            this.fPdfLabel2.Text = "Giá hàng hóa";
            this.fPdfLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fPdfLabel1
            // 
            this.fPdfLabel1.ColumnName = "";
            this.fPdfLabel1.DBValue = "Điện thoại:";
            this.fPdfLabel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPdfLabel1.ForeColor = System.Drawing.Color.Blue;
            fPdfProperties4.Rotation = 0;
            fPdfProperties4.TableColumn = "";
            fPdfProperties4.TableRow = 0;
            this.fPdfLabel1.FPdfProperties = fPdfProperties4;
            this.fPdfLabel1.IsShowLineBottom = true;
            this.fPdfLabel1.IsShowLineLeft = true;
            this.fPdfLabel1.IsShowLineRight = true;
            this.fPdfLabel1.IsShowLineTop = true;
            this.fPdfLabel1.LineStyleBottom = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel1.LineStyleLeft = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel1.LineStyleRight = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel1.LineStyleTop = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fPdfLabel1.Location = new System.Drawing.Point(74, 34);
            this.fPdfLabel1.Name = "fPdfLabel1";
            this.fPdfLabel1.Size = new System.Drawing.Size(184, 23);
            this.fPdfLabel1.TabIndex = 0;
            this.fPdfLabel1.Text = "Điện thoại:";
            this.fPdfLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTestFontcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 379);
            this.Controls.Add(this.fButton1);
            this.Controls.Add(this.fPdfPanel1);
            this.Name = "FrmTestFontcs";
            this.Text = "FrmTestFontcs";
            this.fPdfPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FOS_Utils.PDF.PDFControl.FPdfPanel fPdfPanel1;
        private FOS_Utils.PDF.PDFControl.FPdfLabel fPdfLabel2;
        private FOS_Utils.PDF.PDFControl.FPdfLabel fPdfLabel1;
        private FOS_Utils.FButton fButton1;
        private FOS_Utils.PDF.PDFControl.FPdfLabel fPdfLabel3;
        private FOS_Utils.PDF.PDFControl.FPdfLabel fPdfLabel4;
    }
}