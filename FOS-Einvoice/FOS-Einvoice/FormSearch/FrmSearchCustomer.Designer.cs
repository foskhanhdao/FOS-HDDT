namespace FOS_Einvoice
{
    partial class FrmSearchCustomer
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
            this.txtCuscode = new FOS_Utils.FTextBox();
            this.fLabel1 = new FOS_Utils.FLabel();
            this.fLabel2 = new FOS_Utils.FLabel();
            this.txtCusname = new FOS_Utils.FTextBox();
            this.txtTaxcode = new FOS_Utils.FTextBox();
            this.fLabel3 = new FOS_Utils.FLabel();
            this.txtAddress = new FOS_Utils.FTextBox();
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
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.fLabel4);
            this.groupBox1.Controls.Add(this.txtTaxcode);
            this.groupBox1.Controls.Add(this.fLabel3);
            this.groupBox1.Controls.Add(this.txtCusname);
            this.groupBox1.Controls.Add(this.fLabel2);
            this.groupBox1.Controls.Add(this.txtCuscode);
            this.groupBox1.Controls.Add(this.fLabel1);
            this.groupBox1.Controls.SetChildIndex(this.btnClear, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnSearch, 0);
            this.groupBox1.Controls.SetChildIndex(this.fLabel1, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtCuscode, 0);
            this.groupBox1.Controls.SetChildIndex(this.fLabel2, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtCusname, 0);
            this.groupBox1.Controls.SetChildIndex(this.fLabel3, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtTaxcode, 0);
            this.groupBox1.Controls.SetChildIndex(this.fLabel4, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtAddress, 0);
            // 
            // txtCuscode
            // 
            this.txtCuscode.CheckMinMaxChar = false;
            this.txtCuscode.ColumnName = "";
            this.txtCuscode.DBNullValueWhenBlank = false;
            this.txtCuscode.DBValue = "";
            this.txtCuscode.FillZeroWhenHavingText = false;
            this.txtCuscode.Location = new System.Drawing.Point(154, 27);
            this.txtCuscode.MaxChar = '9';
            this.txtCuscode.MaxLength = 20;
            this.txtCuscode.MaxLengthFromByte = false;
            this.txtCuscode.MinChar = '0';
            this.txtCuscode.Name = "txtCuscode";
            this.txtCuscode.OldText = "";
            this.txtCuscode.OutputControl = null;
            this.txtCuscode.Size = new System.Drawing.Size(151, 25);
            this.txtCuscode.TabIndex = 1;
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
            this.fLabel1.Text = "Mã khách hàng:";
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
            this.fLabel2.Text = "Tên khách hàng:";
            this.fLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCusname
            // 
            this.txtCusname.CheckMinMaxChar = false;
            this.txtCusname.ColumnName = "";
            this.txtCusname.DBNullValueWhenBlank = false;
            this.txtCusname.DBValue = "";
            this.txtCusname.FillZeroWhenHavingText = false;
            this.txtCusname.Location = new System.Drawing.Point(154, 81);
            this.txtCusname.MaxChar = '9';
            this.txtCusname.MaxLength = 50;
            this.txtCusname.MaxLengthFromByte = false;
            this.txtCusname.MinChar = '0';
            this.txtCusname.Name = "txtCusname";
            this.txtCusname.OldText = "";
            this.txtCusname.OutputControl = null;
            this.txtCusname.Size = new System.Drawing.Size(499, 25);
            this.txtCusname.TabIndex = 3;
            // 
            // txtTaxcode
            // 
            this.txtTaxcode.CheckMinMaxChar = false;
            this.txtTaxcode.ColumnName = "";
            this.txtTaxcode.DBNullValueWhenBlank = false;
            this.txtTaxcode.DBValue = "";
            this.txtTaxcode.FillZeroWhenHavingText = false;
            this.txtTaxcode.Location = new System.Drawing.Point(154, 54);
            this.txtTaxcode.MaxChar = '9';
            this.txtTaxcode.MaxLength = 15;
            this.txtTaxcode.MaxLengthFromByte = false;
            this.txtTaxcode.MinChar = '0';
            this.txtTaxcode.Name = "txtTaxcode";
            this.txtTaxcode.OldText = "";
            this.txtTaxcode.OutputControl = null;
            this.txtTaxcode.Size = new System.Drawing.Size(117, 25);
            this.txtTaxcode.TabIndex = 5;
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
            // txtAddress
            // 
            this.txtAddress.CheckMinMaxChar = false;
            this.txtAddress.ColumnName = "";
            this.txtAddress.DBNullValueWhenBlank = false;
            this.txtAddress.DBValue = "";
            this.txtAddress.FillZeroWhenHavingText = false;
            this.txtAddress.Location = new System.Drawing.Point(154, 108);
            this.txtAddress.MaxChar = '9';
            this.txtAddress.MaxLength = 100;
            this.txtAddress.MaxLengthFromByte = false;
            this.txtAddress.MinChar = '0';
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.OldText = "";
            this.txtAddress.OutputControl = null;
            this.txtAddress.Size = new System.Drawing.Size(499, 25);
            this.txtAddress.TabIndex = 7;
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
            // FrmSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "FrmSearchCustomer";
            this.Text = "FrmSearchCustomer";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FOS_Utils.FTextBox txtCuscode;
        private FOS_Utils.FLabel fLabel1;
        private FOS_Utils.FTextBox txtAddress;
        private FOS_Utils.FLabel fLabel4;
        private FOS_Utils.FTextBox txtTaxcode;
        private FOS_Utils.FLabel fLabel3;
        private FOS_Utils.FTextBox txtCusname;
        private FOS_Utils.FLabel fLabel2;
    }
}