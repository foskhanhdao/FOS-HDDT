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
            this.unitname = new FOS_Utils.FTextBox();
            this.fLabel2 = new FOS_Utils.FLabel();
            this.unitcode = new FOS_Utils.FTextBox();
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
            this.groupBox1.Controls.Add(this.unitname);
            this.groupBox1.Controls.Add(this.fLabel2);
            this.groupBox1.Controls.Add(this.unitcode);
            this.groupBox1.Controls.Add(this.fLabel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 462);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết về đơn vị tính";
            // 
            // unitname
            // 
            this.unitname.CheckMinMaxChar = false;
            this.unitname.ColumnName = "unitname";
            this.unitname.DBNullValueWhenBlank = false;
            this.unitname.DBValue = "";
            this.unitname.Enabled = false;
            this.unitname.FillZeroWhenHavingText = false;
            this.unitname.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.unitname.Location = new System.Drawing.Point(157, 62);
            this.unitname.MaxChar = '9';
            this.unitname.MaxLength = 50;
            this.unitname.MaxLengthFromByte = false;
            this.unitname.MinChar = '0';
            this.unitname.Name = "unitname";
            this.unitname.OldText = "";
            this.unitname.OutputControl = null;
            this.unitname.Size = new System.Drawing.Size(360, 25);
            this.unitname.TabIndex = 16;
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
            // unitcode
            // 
            this.unitcode.CheckMinMaxChar = true;
            this.unitcode.ColumnName = "unitcode";
            this.unitcode.DBNullValueWhenBlank = false;
            this.unitcode.DBValue = "";
            this.unitcode.FillZeroWhenHavingText = false;
            this.unitcode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.unitcode.Location = new System.Drawing.Point(157, 31);
            this.unitcode.MaxChar = '9';
            this.unitcode.MaxLength = 20;
            this.unitcode.MaxLengthFromByte = false;
            this.unitcode.MinChar = '0';
            this.unitcode.Name = "unitcode";
            this.unitcode.OldText = "";
            this.unitcode.OutputControl = null;
            this.unitcode.Size = new System.Drawing.Size(45, 25);
            this.unitcode.TabIndex = 12;
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
        private FOS_Utils.FTextBox unitname;
        private FOS_Utils.FLabel fLabel2;
        private FOS_Utils.FTextBox unitcode;
    }
}
