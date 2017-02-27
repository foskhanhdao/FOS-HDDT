namespace FOS_Einvoice
{
    partial class FrmUnit
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
            this.fTextBox3 = new FOS_Utils.FTextBox();
            this.fLabel2 = new FOS_Utils.FLabel();
            this.fTextBox1 = new FOS_Utils.FTextBox();
            this.fLabel3 = new FOS_Utils.FLabel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fTextBox3);
            this.groupBox1.Controls.Add(this.fLabel2);
            this.groupBox1.Controls.Add(this.fTextBox1);
            this.groupBox1.Controls.Add(this.fLabel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 462);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết về đơn vị tính";
            // 
            // fTextBox3
            // 
            this.fTextBox3.CheckMinMaxChar = false;
            this.fTextBox3.ColumnName = "unitname";
            this.fTextBox3.DBNullValueWhenBlank = false;
            this.fTextBox3.DBValue = "";
            this.fTextBox3.Enabled = false;
            this.fTextBox3.FillZeroWhenHavingText = false;
            this.fTextBox3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.fTextBox3.Location = new System.Drawing.Point(157, 62);
            this.fTextBox3.MaxChar = '9';
            this.fTextBox3.MaxLength = 50;
            this.fTextBox3.MaxLengthFromByte = false;
            this.fTextBox3.MinChar = '0';
            this.fTextBox3.Name = "fTextBox3";
            this.fTextBox3.OldText = "";
            this.fTextBox3.OutputControl = null;
            this.fTextBox3.Size = new System.Drawing.Size(360, 25);
            this.fTextBox3.TabIndex = 16;
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
            this.fLabel2.TabIndex = 15;
            this.fLabel2.Text = "Tên đơn vị tính:";
            this.fLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fTextBox1
            // 
            this.fTextBox1.CheckMinMaxChar = true;
            this.fTextBox1.ColumnName = "unitcode";
            this.fTextBox1.DBNullValueWhenBlank = false;
            this.fTextBox1.DBValue = "";
            this.fTextBox1.FillZeroWhenHavingText = false;
            this.fTextBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.fTextBox1.Location = new System.Drawing.Point(157, 31);
            this.fTextBox1.MaxChar = '9';
            this.fTextBox1.MaxLength = 20;
            this.fTextBox1.MaxLengthFromByte = false;
            this.fTextBox1.MinChar = '0';
            this.fTextBox1.Name = "fTextBox1";
            this.fTextBox1.OldText = "";
            this.fTextBox1.OutputControl = null;
            this.fTextBox1.Size = new System.Drawing.Size(45, 25);
            this.fTextBox1.TabIndex = 12;
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
            this.fLabel3.TabIndex = 3;
            this.fLabel3.Text = "Mã đơn vị tính:";
            this.fLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUnit";
            this.Text = "Đơn vị tính";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FOS_Utils.FLabel fLabel3;
        private FOS_Utils.FTextBox fTextBox3;
        private FOS_Utils.FLabel fLabel2;
        private FOS_Utils.FTextBox fTextBox1;
    }
}
