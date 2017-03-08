namespace FOS_Einvoice
{
    partial class FrmSearchProduct
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
            this.productcode = new FOS_Utils.FTextBox();
            this.fLabel1 = new FOS_Utils.FLabel();
            this.fLabel2 = new FOS_Utils.FLabel();
            this.productname1 = new FOS_Utils.FTextBox();
            this.fLabel3 = new FOS_Utils.FLabel();
            this.producttype1 = new FOS_Utils.FComboBox();
            this.producttype2 = new FOS_Utils.FComboBox();
            this.producttype3 = new FOS_Utils.FComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(659, 93);
            this.btnClear.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(659, 39);
            this.btnSearch.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.producttype3);
            this.groupBox1.Controls.Add(this.producttype2);
            this.groupBox1.Controls.Add(this.producttype1);
            this.groupBox1.Controls.Add(this.productname1);
            this.groupBox1.Controls.Add(this.fLabel3);
            this.groupBox1.Controls.Add(this.fLabel2);
            this.groupBox1.Controls.Add(this.productcode);
            this.groupBox1.Controls.Add(this.fLabel1);
            this.groupBox1.Controls.SetChildIndex(this.btnClear, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnSearch, 0);
            this.groupBox1.Controls.SetChildIndex(this.fLabel1, 0);
            this.groupBox1.Controls.SetChildIndex(this.productcode, 0);
            this.groupBox1.Controls.SetChildIndex(this.fLabel2, 0);
            this.groupBox1.Controls.SetChildIndex(this.fLabel3, 0);
            this.groupBox1.Controls.SetChildIndex(this.productname1, 0);
            this.groupBox1.Controls.SetChildIndex(this.producttype1, 0);
            this.groupBox1.Controls.SetChildIndex(this.producttype2, 0);
            this.groupBox1.Controls.SetChildIndex(this.producttype3, 0);
            // 
            // productcode
            // 
            this.productcode.CheckMinMaxChar = false;
            this.productcode.ColumnName = "productcode";
            this.productcode.DBNullValueWhenBlank = false;
            this.productcode.DBValue = "";
            this.productcode.FillZeroWhenHavingText = false;
            this.productcode.Location = new System.Drawing.Point(117, 39);
            this.productcode.MaxChar = '9';
            this.productcode.MaxLength = 20;
            this.productcode.MaxLengthFromByte = false;
            this.productcode.MinChar = '0';
            this.productcode.Name = "productcode";
            this.productcode.OldText = "";
            this.productcode.OutputControl = null;
            this.productcode.Size = new System.Drawing.Size(151, 25);
            this.productcode.TabIndex = 1;
            // 
            // fLabel1
            // 
            this.fLabel1.ColumnName = "";
            this.fLabel1.Location = new System.Drawing.Point(8, 39);
            this.fLabel1.Name = "fLabel1";
            this.fLabel1.OldText = "";
            this.fLabel1.OutputControl = null;
            this.fLabel1.Size = new System.Drawing.Size(103, 25);
            this.fLabel1.TabIndex = 0;
            this.fLabel1.Text = "Mã sản phẩm:";
            this.fLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel2
            // 
            this.fLabel2.ColumnName = "";
            this.fLabel2.Location = new System.Drawing.Point(8, 92);
            this.fLabel2.Name = "fLabel2";
            this.fLabel2.OldText = "";
            this.fLabel2.OutputControl = null;
            this.fLabel2.Size = new System.Drawing.Size(103, 25);
            this.fLabel2.TabIndex = 4;
            this.fLabel2.Text = "Loại sản phẩm:";
            this.fLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productname1
            // 
            this.productname1.CheckMinMaxChar = false;
            this.productname1.ColumnName = "productname1";
            this.productname1.DBNullValueWhenBlank = false;
            this.productname1.DBValue = "";
            this.productname1.FillZeroWhenHavingText = false;
            this.productname1.Location = new System.Drawing.Point(117, 66);
            this.productname1.MaxChar = '9';
            this.productname1.MaxLength = 200;
            this.productname1.MaxLengthFromByte = false;
            this.productname1.MinChar = '0';
            this.productname1.Name = "productname1";
            this.productname1.OldText = "";
            this.productname1.OutputControl = null;
            this.productname1.Size = new System.Drawing.Size(536, 25);
            this.productname1.TabIndex = 3;
            // 
            // fLabel3
            // 
            this.fLabel3.ColumnName = "";
            this.fLabel3.Location = new System.Drawing.Point(8, 65);
            this.fLabel3.Name = "fLabel3";
            this.fLabel3.OldText = "";
            this.fLabel3.OutputControl = null;
            this.fLabel3.Size = new System.Drawing.Size(103, 25);
            this.fLabel3.TabIndex = 2;
            this.fLabel3.Text = "Tên sản phẩm:";
            this.fLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // producttype1
            // 
            this.producttype1.ColumnName = "producttype1";
            this.producttype1.DBValue = "";
            this.producttype1.FormattingEnabled = true;
            this.producttype1.Location = new System.Drawing.Point(117, 93);
            this.producttype1.Name = "producttype1";
            this.producttype1.Size = new System.Drawing.Size(167, 25);
            this.producttype1.TabIndex = 5;
            // 
            // producttype2
            // 
            this.producttype2.ColumnName = "producttype2";
            this.producttype2.DBValue = "";
            this.producttype2.FormattingEnabled = true;
            this.producttype2.Location = new System.Drawing.Point(301, 93);
            this.producttype2.Name = "producttype2";
            this.producttype2.Size = new System.Drawing.Size(167, 25);
            this.producttype2.TabIndex = 6;
            // 
            // producttype3
            // 
            this.producttype3.ColumnName = "producttype3";
            this.producttype3.DBValue = "";
            this.producttype3.FormattingEnabled = true;
            this.producttype3.Location = new System.Drawing.Point(486, 93);
            this.producttype3.Name = "producttype3";
            this.producttype3.Size = new System.Drawing.Size(167, 25);
            this.producttype3.TabIndex = 7;
            // 
            // FrmSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "FrmSearchProduct";
            this.Text = "Tìm kiếm sản phẩm";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FOS_Utils.FTextBox productcode;
        private FOS_Utils.FLabel fLabel1;
        private FOS_Utils.FTextBox productname1;
        private FOS_Utils.FLabel fLabel3;
        private FOS_Utils.FLabel fLabel2;
        private FOS_Utils.FComboBox producttype3;
        private FOS_Utils.FComboBox producttype2;
        private FOS_Utils.FComboBox producttype1;
    }
}