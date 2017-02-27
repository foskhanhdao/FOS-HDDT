namespace FOS_Einvoice
{
    partial class FrmSearchCompany
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
            this.companycode = new FOS_Utils.FTextBox();
            this.fLabel1 = new FOS_Utils.FLabel();
            this.fLabel2 = new FOS_Utils.FLabel();
            this.companyname = new FOS_Utils.FTextBox();
            this.taxcode = new FOS_Utils.FTextBox();
            this.fLabel3 = new FOS_Utils.FLabel();
            this.companyaddress = new FOS_Utils.FTextBox();
            this.fLabel4 = new FOS_Utils.FLabel();
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
            this.groupBox1.Controls.Add(this.companyaddress);
            this.groupBox1.Controls.Add(this.fLabel4);
            this.groupBox1.Controls.Add(this.taxcode);
            this.groupBox1.Controls.Add(this.fLabel3);
            this.groupBox1.Controls.Add(this.companyname);
            this.groupBox1.Controls.Add(this.fLabel2);
            this.groupBox1.Controls.Add(this.companycode);
            this.groupBox1.Controls.Add(this.fLabel1);
            this.groupBox1.Controls.SetChildIndex(this.btnClear, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnSearch, 0);
            this.groupBox1.Controls.SetChildIndex(this.fLabel1, 0);
            this.groupBox1.Controls.SetChildIndex(this.companycode, 0);
            this.groupBox1.Controls.SetChildIndex(this.fLabel2, 0);
            this.groupBox1.Controls.SetChildIndex(this.companyname, 0);
            this.groupBox1.Controls.SetChildIndex(this.fLabel3, 0);
            this.groupBox1.Controls.SetChildIndex(this.taxcode, 0);
            this.groupBox1.Controls.SetChildIndex(this.fLabel4, 0);
            this.groupBox1.Controls.SetChildIndex(this.companyaddress, 0);
            // 
            // companycode
            // 
            this.companycode.CheckMinMaxChar = false;
            this.companycode.ColumnName = "companycode";
            this.companycode.DBNullValueWhenBlank = false;
            this.companycode.DBValue = "";
            this.companycode.FillZeroWhenHavingText = false;
            this.companycode.Location = new System.Drawing.Point(154, 27);
            this.companycode.MaxChar = '9';
            this.companycode.MaxLength = 20;
            this.companycode.MaxLengthFromByte = false;
            this.companycode.MinChar = '0';
            this.companycode.Name = "companycode";
            this.companycode.OldText = "";
            this.companycode.OutputControl = null;
            this.companycode.Size = new System.Drawing.Size(151, 25);
            this.companycode.TabIndex = 1;
            // 
            // fLabel1
            // 
            this.fLabel1.ColumnName = "";
            this.fLabel1.Location = new System.Drawing.Point(15, 27);
            this.fLabel1.Name = "fLabel1";
            this.fLabel1.OldText = "";
            this.fLabel1.OutputControl = null;
            this.fLabel1.Size = new System.Drawing.Size(133, 25);
            this.fLabel1.TabIndex = 0;
            this.fLabel1.Text = "Mã công ty:";
            this.fLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel2
            // 
            this.fLabel2.ColumnName = "";
            this.fLabel2.Location = new System.Drawing.Point(15, 80);
            this.fLabel2.Name = "fLabel2";
            this.fLabel2.OldText = "";
            this.fLabel2.OutputControl = null;
            this.fLabel2.Size = new System.Drawing.Size(133, 25);
            this.fLabel2.TabIndex = 2;
            this.fLabel2.Text = "Tên công ty:";
            this.fLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // companyname
            // 
            this.companyname.CheckMinMaxChar = false;
            this.companyname.ColumnName = "companyname";
            this.companyname.DBNullValueWhenBlank = false;
            this.companyname.DBValue = "";
            this.companyname.FillZeroWhenHavingText = false;
            this.companyname.Location = new System.Drawing.Point(154, 81);
            this.companyname.MaxChar = '9';
            this.companyname.MaxLength = 50;
            this.companyname.MaxLengthFromByte = false;
            this.companyname.MinChar = '0';
            this.companyname.Name = "companyname";
            this.companyname.OldText = "";
            this.companyname.OutputControl = null;
            this.companyname.Size = new System.Drawing.Size(499, 25);
            this.companyname.TabIndex = 3;
            // 
            // taxcode
            // 
            this.taxcode.CheckMinMaxChar = false;
            this.taxcode.ColumnName = "taxcode";
            this.taxcode.DBNullValueWhenBlank = false;
            this.taxcode.DBValue = "";
            this.taxcode.FillZeroWhenHavingText = false;
            this.taxcode.Location = new System.Drawing.Point(154, 54);
            this.taxcode.MaxChar = '9';
            this.taxcode.MaxLength = 15;
            this.taxcode.MaxLengthFromByte = false;
            this.taxcode.MinChar = '0';
            this.taxcode.Name = "taxcode";
            this.taxcode.OldText = "";
            this.taxcode.OutputControl = null;
            this.taxcode.Size = new System.Drawing.Size(117, 25);
            this.taxcode.TabIndex = 5;
            // 
            // fLabel3
            // 
            this.fLabel3.ColumnName = "";
            this.fLabel3.Location = new System.Drawing.Point(15, 53);
            this.fLabel3.Name = "fLabel3";
            this.fLabel3.OldText = "";
            this.fLabel3.OutputControl = null;
            this.fLabel3.Size = new System.Drawing.Size(133, 25);
            this.fLabel3.TabIndex = 4;
            this.fLabel3.Text = "Mã số thuế:";
            this.fLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // companyaddress
            // 
            this.companyaddress.CheckMinMaxChar = false;
            this.companyaddress.ColumnName = "companyaddress";
            this.companyaddress.DBNullValueWhenBlank = false;
            this.companyaddress.DBValue = "";
            this.companyaddress.FillZeroWhenHavingText = false;
            this.companyaddress.Location = new System.Drawing.Point(154, 108);
            this.companyaddress.MaxChar = '9';
            this.companyaddress.MaxLength = 100;
            this.companyaddress.MaxLengthFromByte = false;
            this.companyaddress.MinChar = '0';
            this.companyaddress.Name = "companyaddress";
            this.companyaddress.OldText = "";
            this.companyaddress.OutputControl = null;
            this.companyaddress.Size = new System.Drawing.Size(499, 25);
            this.companyaddress.TabIndex = 7;
            // 
            // fLabel4
            // 
            this.fLabel4.ColumnName = "";
            this.fLabel4.Location = new System.Drawing.Point(15, 107);
            this.fLabel4.Name = "fLabel4";
            this.fLabel4.OldText = "";
            this.fLabel4.OutputControl = null;
            this.fLabel4.Size = new System.Drawing.Size(133, 25);
            this.fLabel4.TabIndex = 6;
            this.fLabel4.Text = "Địa chỉ:";
            this.fLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmSearchCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "FrmSearchCompany";
            this.Text = "FrmSearchCustomer";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FOS_Utils.FTextBox companycode;
        private FOS_Utils.FLabel fLabel1;
        private FOS_Utils.FTextBox companyaddress;
        private FOS_Utils.FLabel fLabel4;
        private FOS_Utils.FTextBox taxcode;
        private FOS_Utils.FLabel fLabel3;
        private FOS_Utils.FTextBox companyname;
        private FOS_Utils.FLabel fLabel2;
    }
}