namespace FOS_Einvoice
{
    partial class FrmEinvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRowPaste = new FOS_Utils.FButton();
            this.btnRowCopy = new FOS_Utils.FButton();
            this.btnRowSearch = new FOS_Utils.FButton();
            this.btnRowDelete = new FOS_Utils.FButton();
            this.btnRowAdd = new FOS_Utils.FButton();
            this.dgvDetail = new FOS_Utils.FDataGridViewOverride();
            this.pnlSum = new System.Windows.Forms.Panel();
            this.nPaymoney = new FOS_Utils.FNumber();
            this.nTax = new FOS_Utils.FNumber();
            this.nTotal = new FOS_Utils.FNumber();
            this.txtSotienbangchu = new FOS_Utils.FTextBox();
            this.fLabel17 = new FOS_Utils.FLabel();
            this.cmbPaymenttype = new FOS_Utils.FComboBox();
            this.fLabel35 = new FOS_Utils.FLabel();
            this.fLabel34 = new FOS_Utils.FLabel();
            this.fLabel33 = new FOS_Utils.FLabel();
            this.fLabel7 = new FOS_Utils.FLabel();
            this.fLabel9 = new FOS_Utils.FLabel();
            this.numTaxrate = new FOS_Utils.FNumericUpDown();
            this.fLabel8 = new FOS_Utils.FLabel();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.fLabel16 = new FOS_Utils.FLabel();
            this.txtCusname = new FOS_Utils.FTextBox();
            this.btnCuscode = new FOS_Utils.FButton();
            this.txtFax = new FOS_Utils.FTextBox();
            this.fLabel1 = new FOS_Utils.FLabel();
            this.txtPhone = new FOS_Utils.FTextBox();
            this.fLabel4 = new FOS_Utils.FLabel();
            this.txtAddress = new FOS_Utils.FTextBox();
            this.fLabel2 = new FOS_Utils.FLabel();
            this.txtCompanyName = new FOS_Utils.FTextBox();
            this.fLabel5 = new FOS_Utils.FLabel();
            this.txtTaxcode = new FOS_Utils.FTextBox();
            this.fLabel3 = new FOS_Utils.FLabel();
            this.txtCuscode = new FOS_Utils.FTextBox();
            this.fLabel6 = new FOS_Utils.FLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSymbol = new FOS_Utils.FLabel();
            this.fLabel15 = new FOS_Utils.FLabel();
            this.fLabel14 = new FOS_Utils.FLabel();
            this.lblTemplate = new FOS_Utils.FLabel();
            this.fLabel10 = new FOS_Utils.FLabel();
            this.lblInvoiceCode = new FOS_Utils.FLabel();
            this.fLabel11 = new FOS_Utils.FLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fButton3 = new FOS_Utils.FButton();
            this.btnSaveTemp = new FOS_Utils.FButton();
            this.fButton2 = new FOS_Utils.FButton();
            this.btnPreview = new FOS_Utils.FButton();
            this.btnClose = new FOS_Utils.FButton();
            this.btnNew = new FOS_Utils.FButton();
            this.btnSaveAndInvoice = new FOS_Utils.FButton();
            this.footer1 = new FOS_Einvoice.UserControls.Footer();
            this.fButton1 = new FOS_Utils.FButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.pnlSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxrate)).BeginInit();
            this.gbCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnRowPaste);
            this.groupBox2.Controls.Add(this.btnRowCopy);
            this.groupBox2.Controls.Add(this.btnRowSearch);
            this.groupBox2.Controls.Add(this.btnRowDelete);
            this.groupBox2.Controls.Add(this.btnRowAdd);
            this.groupBox2.Controls.Add(this.dgvDetail);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(918, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết hàng hóa, dịch vụ";
            // 
            // btnRowPaste
            // 
            this.btnRowPaste.Enabled = false;
            this.btnRowPaste.Location = new System.Drawing.Point(6, 131);
            this.btnRowPaste.Name = "btnRowPaste";
            this.btnRowPaste.Size = new System.Drawing.Size(30, 30);
            this.btnRowPaste.TabIndex = 20;
            this.btnRowPaste.TabStop = false;
            this.btnRowPaste.Text = "P";
            this.btnRowPaste.UseVisualStyleBackColor = true;
            this.btnRowPaste.Click += new System.EventHandler(this.RowButton_Click);
            this.btnRowPaste.Leave += new System.EventHandler(this.RowButton_Leave);
            // 
            // btnRowCopy
            // 
            this.btnRowCopy.Enabled = false;
            this.btnRowCopy.Location = new System.Drawing.Point(6, 95);
            this.btnRowCopy.Name = "btnRowCopy";
            this.btnRowCopy.Size = new System.Drawing.Size(30, 30);
            this.btnRowCopy.TabIndex = 19;
            this.btnRowCopy.TabStop = false;
            this.btnRowCopy.Text = "C";
            this.btnRowCopy.UseVisualStyleBackColor = true;
            this.btnRowCopy.Click += new System.EventHandler(this.RowButton_Click);
            this.btnRowCopy.Leave += new System.EventHandler(this.RowButton_Leave);
            // 
            // btnRowSearch
            // 
            this.btnRowSearch.Enabled = false;
            this.btnRowSearch.Location = new System.Drawing.Point(6, 167);
            this.btnRowSearch.Name = "btnRowSearch";
            this.btnRowSearch.Size = new System.Drawing.Size(30, 30);
            this.btnRowSearch.TabIndex = 18;
            this.btnRowSearch.TabStop = false;
            this.btnRowSearch.Text = "...";
            this.btnRowSearch.UseVisualStyleBackColor = true;
            this.btnRowSearch.Click += new System.EventHandler(this.RowButton_Click);
            this.btnRowSearch.Leave += new System.EventHandler(this.RowButton_Leave);
            // 
            // btnRowDelete
            // 
            this.btnRowDelete.Enabled = false;
            this.btnRowDelete.Location = new System.Drawing.Point(6, 59);
            this.btnRowDelete.Name = "btnRowDelete";
            this.btnRowDelete.Size = new System.Drawing.Size(30, 30);
            this.btnRowDelete.TabIndex = 17;
            this.btnRowDelete.TabStop = false;
            this.btnRowDelete.Text = "-";
            this.btnRowDelete.UseVisualStyleBackColor = true;
            this.btnRowDelete.Click += new System.EventHandler(this.RowButton_Click);
            this.btnRowDelete.Leave += new System.EventHandler(this.RowButton_Leave);
            // 
            // btnRowAdd
            // 
            this.btnRowAdd.Enabled = false;
            this.btnRowAdd.Location = new System.Drawing.Point(6, 23);
            this.btnRowAdd.Name = "btnRowAdd";
            this.btnRowAdd.Size = new System.Drawing.Size(30, 30);
            this.btnRowAdd.TabIndex = 16;
            this.btnRowAdd.TabStop = false;
            this.btnRowAdd.Text = "+";
            this.btnRowAdd.UseVisualStyleBackColor = true;
            this.btnRowAdd.Click += new System.EventHandler(this.RowButton_Click);
            this.btnRowAdd.Leave += new System.EventHandler(this.RowButton_Leave);
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(42, 23);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowTemplate.Height = 21;
            this.dgvDetail.Size = new System.Drawing.Size(870, 176);
            this.dgvDetail.TabIndex = 0;
            this.dgvDetail.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellLeave);
            this.dgvDetail.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDetail_RowsAdded);
            this.dgvDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellEndEdit);
            this.dgvDetail.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDetail_EditingControlShowing);
            this.dgvDetail.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellEnter);
            this.dgvDetail.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDetail_RowsRemoved);
            // 
            // pnlSum
            // 
            this.pnlSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSum.Controls.Add(this.nPaymoney);
            this.pnlSum.Controls.Add(this.nTax);
            this.pnlSum.Controls.Add(this.nTotal);
            this.pnlSum.Controls.Add(this.txtSotienbangchu);
            this.pnlSum.Controls.Add(this.fLabel17);
            this.pnlSum.Controls.Add(this.cmbPaymenttype);
            this.pnlSum.Controls.Add(this.fLabel35);
            this.pnlSum.Controls.Add(this.fLabel34);
            this.pnlSum.Controls.Add(this.fLabel33);
            this.pnlSum.Controls.Add(this.fLabel7);
            this.pnlSum.Controls.Add(this.fLabel9);
            this.pnlSum.Controls.Add(this.numTaxrate);
            this.pnlSum.Controls.Add(this.fLabel8);
            this.pnlSum.Location = new System.Drawing.Point(12, 389);
            this.pnlSum.Name = "pnlSum";
            this.pnlSum.Size = new System.Drawing.Size(918, 85);
            this.pnlSum.TabIndex = 2;
            // 
            // nPaymoney
            // 
            this.nPaymoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nPaymoney.AutoResize = true;
            this.nPaymoney.ColumnName = "";
            this.nPaymoney.DBValue = 0;
            this.nPaymoney.DecimalLength = 3;
            this.nPaymoney.DecimalShowZero = false;
            this.nPaymoney.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.nPaymoney.Location = new System.Drawing.Point(764, 55);
            this.nPaymoney.MaxLength = 300;
            this.nPaymoney.Name = "nPaymoney";
            this.nPaymoney.OldValue = 0;
            this.nPaymoney.ReadOnly = true;
            this.nPaymoney.Size = new System.Drawing.Size(146, 24);
            this.nPaymoney.TabIndex = 15;
            this.nPaymoney.TabStop = false;
            this.nPaymoney.Text = "0";
            this.nPaymoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nPaymoney.ThousandsSeparator = true;
            this.nPaymoney.Value = 0;
            this.nPaymoney.ValueMax = 1E+297;
            this.nPaymoney.ValueMin = 0;
            this.nPaymoney.TextChanged += new System.EventHandler(this.txtPaymoney_TextChanged);
            // 
            // nTax
            // 
            this.nTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nTax.AutoResize = true;
            this.nTax.ColumnName = "";
            this.nTax.DBValue = 0;
            this.nTax.DecimalLength = 3;
            this.nTax.DecimalShowZero = false;
            this.nTax.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.nTax.Location = new System.Drawing.Point(764, 28);
            this.nTax.MaxLength = 300;
            this.nTax.Name = "nTax";
            this.nTax.OldValue = 0;
            this.nTax.ReadOnly = true;
            this.nTax.Size = new System.Drawing.Size(146, 24);
            this.nTax.TabIndex = 14;
            this.nTax.TabStop = false;
            this.nTax.Text = "0";
            this.nTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nTax.ThousandsSeparator = true;
            this.nTax.Value = 0;
            this.nTax.ValueMax = 1E+297;
            this.nTax.ValueMin = 0;
            // 
            // nTotal
            // 
            this.nTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nTotal.AutoResize = true;
            this.nTotal.ColumnName = "";
            this.nTotal.DBValue = 0;
            this.nTotal.DecimalLength = 3;
            this.nTotal.DecimalShowZero = false;
            this.nTotal.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.nTotal.Location = new System.Drawing.Point(764, 1);
            this.nTotal.MaxLength = 300;
            this.nTotal.Name = "nTotal";
            this.nTotal.OldValue = 0;
            this.nTotal.ReadOnly = true;
            this.nTotal.Size = new System.Drawing.Size(146, 24);
            this.nTotal.TabIndex = 13;
            this.nTotal.TabStop = false;
            this.nTotal.Text = "0";
            this.nTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nTotal.ThousandsSeparator = true;
            this.nTotal.Value = 0;
            this.nTotal.ValueMax = 1E+297;
            this.nTotal.ValueMin = 0;
            // 
            // txtSotienbangchu
            // 
            this.txtSotienbangchu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSotienbangchu.CheckMinMaxChar = false;
            this.txtSotienbangchu.ColumnName = "";
            this.txtSotienbangchu.DBNullValueWhenBlank = false;
            this.txtSotienbangchu.DBValue = "";
            this.txtSotienbangchu.FillZeroWhenHavingText = false;
            this.txtSotienbangchu.Location = new System.Drawing.Point(152, 55);
            this.txtSotienbangchu.MaxChar = '9';
            this.txtSotienbangchu.MaxLength = 200;
            this.txtSotienbangchu.MaxLengthFromByte = false;
            this.txtSotienbangchu.MinChar = '0';
            this.txtSotienbangchu.Name = "txtSotienbangchu";
            this.txtSotienbangchu.OldText = "";
            this.txtSotienbangchu.OutputControl = null;
            this.txtSotienbangchu.Size = new System.Drawing.Size(449, 25);
            this.txtSotienbangchu.TabIndex = 12;
            // 
            // fLabel17
            // 
            this.fLabel17.ColumnName = "";
            this.fLabel17.ForeColor = System.Drawing.Color.Black;
            this.fLabel17.Location = new System.Drawing.Point(4, 55);
            this.fLabel17.Name = "fLabel17";
            this.fLabel17.OldText = "";
            this.fLabel17.OutputControl = null;
            this.fLabel17.Size = new System.Drawing.Size(143, 25);
            this.fLabel17.TabIndex = 11;
            this.fLabel17.Text = "Số tiền viết bằng chữ:";
            this.fLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPaymenttype
            // 
            this.cmbPaymenttype.ColumnName = "";
            this.cmbPaymenttype.DBValue = "";
            this.cmbPaymenttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymenttype.FormattingEnabled = true;
            this.cmbPaymenttype.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản"});
            this.cmbPaymenttype.Location = new System.Drawing.Point(152, 28);
            this.cmbPaymenttype.Name = "cmbPaymenttype";
            this.cmbPaymenttype.Size = new System.Drawing.Size(131, 25);
            this.cmbPaymenttype.TabIndex = 4;
            // 
            // fLabel35
            // 
            this.fLabel35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fLabel35.ColumnName = "";
            this.fLabel35.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel35.Location = new System.Drawing.Point(595, 55);
            this.fLabel35.Name = "fLabel35";
            this.fLabel35.OldText = "";
            this.fLabel35.OutputControl = null;
            this.fLabel35.Size = new System.Drawing.Size(163, 26);
            this.fLabel35.TabIndex = 7;
            this.fLabel35.Text = "Tổng cộng tiền hàng:";
            this.fLabel35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel34
            // 
            this.fLabel34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fLabel34.ColumnName = "";
            this.fLabel34.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel34.Location = new System.Drawing.Point(556, 28);
            this.fLabel34.Name = "fLabel34";
            this.fLabel34.OldText = "";
            this.fLabel34.OutputControl = null;
            this.fLabel34.Size = new System.Drawing.Size(202, 26);
            this.fLabel34.TabIndex = 6;
            this.fLabel34.Text = "Tiền thuế GTGT:";
            this.fLabel34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel33
            // 
            this.fLabel33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fLabel33.ColumnName = "";
            this.fLabel33.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel33.Location = new System.Drawing.Point(556, 1);
            this.fLabel33.Name = "fLabel33";
            this.fLabel33.OldText = "";
            this.fLabel33.OutputControl = null;
            this.fLabel33.Size = new System.Drawing.Size(202, 26);
            this.fLabel33.TabIndex = 5;
            this.fLabel33.Text = "Cộng tiền hàng:";
            this.fLabel33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel7
            // 
            this.fLabel7.ColumnName = "";
            this.fLabel7.ForeColor = System.Drawing.Color.Black;
            this.fLabel7.Location = new System.Drawing.Point(3, 28);
            this.fLabel7.Name = "fLabel7";
            this.fLabel7.OldText = "";
            this.fLabel7.OutputControl = null;
            this.fLabel7.Size = new System.Drawing.Size(143, 25);
            this.fLabel7.TabIndex = 3;
            this.fLabel7.Text = "Hình thức thanh toán:";
            this.fLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fLabel9
            // 
            this.fLabel9.ColumnName = "";
            this.fLabel9.ForeColor = System.Drawing.Color.Black;
            this.fLabel9.Location = new System.Drawing.Point(202, 1);
            this.fLabel9.Name = "fLabel9";
            this.fLabel9.OldText = "";
            this.fLabel9.OutputControl = null;
            this.fLabel9.Size = new System.Drawing.Size(32, 24);
            this.fLabel9.TabIndex = 2;
            this.fLabel9.Text = "%";
            this.fLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numTaxrate
            // 
            this.numTaxrate.ColumnName = "";
            this.numTaxrate.DBValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numTaxrate.Location = new System.Drawing.Point(152, 1);
            this.numTaxrate.Name = "numTaxrate";
            this.numTaxrate.Size = new System.Drawing.Size(48, 24);
            this.numTaxrate.TabIndex = 1;
            // 
            // fLabel8
            // 
            this.fLabel8.ColumnName = "";
            this.fLabel8.ForeColor = System.Drawing.Color.Black;
            this.fLabel8.Location = new System.Drawing.Point(3, 1);
            this.fLabel8.Name = "fLabel8";
            this.fLabel8.OldText = "";
            this.fLabel8.OutputControl = null;
            this.fLabel8.Size = new System.Drawing.Size(143, 24);
            this.fLabel8.TabIndex = 0;
            this.fLabel8.Text = "Thuế suất GTGT:";
            this.fLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCustomer.Controls.Add(this.fLabel16);
            this.gbCustomer.Controls.Add(this.txtCusname);
            this.gbCustomer.Controls.Add(this.btnCuscode);
            this.gbCustomer.Controls.Add(this.txtFax);
            this.gbCustomer.Controls.Add(this.fLabel1);
            this.gbCustomer.Controls.Add(this.txtPhone);
            this.gbCustomer.Controls.Add(this.fLabel4);
            this.gbCustomer.Controls.Add(this.txtAddress);
            this.gbCustomer.Controls.Add(this.fLabel2);
            this.gbCustomer.Controls.Add(this.txtCompanyName);
            this.gbCustomer.Controls.Add(this.fLabel5);
            this.gbCustomer.Controls.Add(this.txtTaxcode);
            this.gbCustomer.Controls.Add(this.fLabel3);
            this.gbCustomer.Controls.Add(this.txtCuscode);
            this.gbCustomer.Controls.Add(this.fLabel6);
            this.gbCustomer.Location = new System.Drawing.Point(12, 12);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(714, 160);
            this.gbCustomer.TabIndex = 0;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Thông tin chi tiết người mua hàng";
            // 
            // fLabel16
            // 
            this.fLabel16.ColumnName = "";
            this.fLabel16.ForeColor = System.Drawing.Color.Black;
            this.fLabel16.Location = new System.Drawing.Point(6, 47);
            this.fLabel16.Name = "fLabel16";
            this.fLabel16.OldText = "";
            this.fLabel16.OutputControl = null;
            this.fLabel16.Size = new System.Drawing.Size(166, 25);
            this.fLabel16.TabIndex = 4;
            this.fLabel16.Text = "Tên khách hàng:";
            this.fLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCusname
            // 
            this.txtCusname.CheckMinMaxChar = false;
            this.txtCusname.ColumnName = "cusname";
            this.txtCusname.DBNullValueWhenBlank = false;
            this.txtCusname.DBValue = "";
            this.txtCusname.FillZeroWhenHavingText = false;
            this.txtCusname.Location = new System.Drawing.Point(178, 47);
            this.txtCusname.MaxChar = '9';
            this.txtCusname.MaxLength = 50;
            this.txtCusname.MaxLengthFromByte = false;
            this.txtCusname.MinChar = '0';
            this.txtCusname.Name = "txtCusname";
            this.txtCusname.OldText = "";
            this.txtCusname.OutputControl = null;
            this.txtCusname.Size = new System.Drawing.Size(361, 25);
            this.txtCusname.TabIndex = 5;
            // 
            // btnCuscode
            // 
            this.btnCuscode.Location = new System.Drawing.Point(542, 19);
            this.btnCuscode.Name = "btnCuscode";
            this.btnCuscode.Size = new System.Drawing.Size(120, 25);
            this.btnCuscode.TabIndex = 14;
            this.btnCuscode.Text = "Tìm khách hàng";
            this.btnCuscode.UseVisualStyleBackColor = true;
            this.btnCuscode.Click += new System.EventHandler(this.btnCuscode_Click);
            // 
            // txtFax
            // 
            this.txtFax.CheckMinMaxChar = false;
            this.txtFax.ColumnName = "";
            this.txtFax.DBNullValueWhenBlank = false;
            this.txtFax.DBValue = "";
            this.txtFax.FillZeroWhenHavingText = false;
            this.txtFax.Location = new System.Drawing.Point(388, 129);
            this.txtFax.MaxChar = '9';
            this.txtFax.MaxLength = 15;
            this.txtFax.MaxLengthFromByte = false;
            this.txtFax.MinChar = '0';
            this.txtFax.Name = "txtFax";
            this.txtFax.OldText = "";
            this.txtFax.OutputControl = null;
            this.txtFax.Size = new System.Drawing.Size(114, 25);
            this.txtFax.TabIndex = 13;
            // 
            // fLabel1
            // 
            this.fLabel1.ColumnName = "";
            this.fLabel1.ForeColor = System.Drawing.Color.Black;
            this.fLabel1.Location = new System.Drawing.Point(6, 20);
            this.fLabel1.Name = "fLabel1";
            this.fLabel1.OldText = "";
            this.fLabel1.OutputControl = null;
            this.fLabel1.Size = new System.Drawing.Size(166, 25);
            this.fLabel1.TabIndex = 0;
            this.fLabel1.Text = "Mã khách hàng (đơn vị):";
            this.fLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.CheckMinMaxChar = false;
            this.txtPhone.ColumnName = "";
            this.txtPhone.DBNullValueWhenBlank = false;
            this.txtPhone.DBValue = "";
            this.txtPhone.FillZeroWhenHavingText = false;
            this.txtPhone.Location = new System.Drawing.Point(178, 128);
            this.txtPhone.MaxChar = '9';
            this.txtPhone.MaxLength = 15;
            this.txtPhone.MaxLengthFromByte = false;
            this.txtPhone.MinChar = '0';
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.OldText = "";
            this.txtPhone.OutputControl = null;
            this.txtPhone.Size = new System.Drawing.Size(114, 25);
            this.txtPhone.TabIndex = 11;
            // 
            // fLabel4
            // 
            this.fLabel4.ColumnName = "";
            this.fLabel4.ForeColor = System.Drawing.Color.Black;
            this.fLabel4.Location = new System.Drawing.Point(6, 101);
            this.fLabel4.Name = "fLabel4";
            this.fLabel4.OldText = "";
            this.fLabel4.OutputControl = null;
            this.fLabel4.Size = new System.Drawing.Size(166, 25);
            this.fLabel4.TabIndex = 8;
            this.fLabel4.Text = "Địa chỉ:";
            this.fLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.CheckMinMaxChar = false;
            this.txtAddress.ColumnName = "";
            this.txtAddress.DBNullValueWhenBlank = false;
            this.txtAddress.DBValue = "";
            this.txtAddress.FillZeroWhenHavingText = false;
            this.txtAddress.Location = new System.Drawing.Point(178, 101);
            this.txtAddress.MaxChar = '9';
            this.txtAddress.MaxLength = 100;
            this.txtAddress.MaxLengthFromByte = false;
            this.txtAddress.MinChar = '0';
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.OldText = "";
            this.txtAddress.OutputControl = null;
            this.txtAddress.Size = new System.Drawing.Size(530, 25);
            this.txtAddress.TabIndex = 9;
            // 
            // fLabel2
            // 
            this.fLabel2.ColumnName = "";
            this.fLabel2.ForeColor = System.Drawing.Color.Black;
            this.fLabel2.Location = new System.Drawing.Point(6, 74);
            this.fLabel2.Name = "fLabel2";
            this.fLabel2.OldText = "";
            this.fLabel2.OutputControl = null;
            this.fLabel2.Size = new System.Drawing.Size(166, 25);
            this.fLabel2.TabIndex = 6;
            this.fLabel2.Text = "Tên đơn vị:";
            this.fLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.CheckMinMaxChar = false;
            this.txtCompanyName.ColumnName = "";
            this.txtCompanyName.DBNullValueWhenBlank = false;
            this.txtCompanyName.DBValue = "";
            this.txtCompanyName.FillZeroWhenHavingText = false;
            this.txtCompanyName.Location = new System.Drawing.Point(178, 74);
            this.txtCompanyName.MaxChar = '9';
            this.txtCompanyName.MaxLength = 50;
            this.txtCompanyName.MaxLengthFromByte = false;
            this.txtCompanyName.MinChar = '0';
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.OldText = "";
            this.txtCompanyName.OutputControl = null;
            this.txtCompanyName.Size = new System.Drawing.Size(361, 25);
            this.txtCompanyName.TabIndex = 7;
            // 
            // fLabel5
            // 
            this.fLabel5.ColumnName = "";
            this.fLabel5.ForeColor = System.Drawing.Color.Black;
            this.fLabel5.Location = new System.Drawing.Point(6, 128);
            this.fLabel5.Name = "fLabel5";
            this.fLabel5.OldText = "";
            this.fLabel5.OutputControl = null;
            this.fLabel5.Size = new System.Drawing.Size(166, 25);
            this.fLabel5.TabIndex = 10;
            this.fLabel5.Text = "Điện thoại:";
            this.fLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTaxcode
            // 
            this.txtTaxcode.CheckMinMaxChar = false;
            this.txtTaxcode.ColumnName = "taxcode";
            this.txtTaxcode.DBNullValueWhenBlank = false;
            this.txtTaxcode.DBValue = "";
            this.txtTaxcode.FillZeroWhenHavingText = false;
            this.txtTaxcode.Location = new System.Drawing.Point(388, 20);
            this.txtTaxcode.MaxChar = '9';
            this.txtTaxcode.MaxLengthFromByte = false;
            this.txtTaxcode.MinChar = '0';
            this.txtTaxcode.Name = "txtTaxcode";
            this.txtTaxcode.OldText = "";
            this.txtTaxcode.OutputControl = null;
            this.txtTaxcode.Size = new System.Drawing.Size(151, 25);
            this.txtTaxcode.TabIndex = 3;
            // 
            // fLabel3
            // 
            this.fLabel3.ColumnName = "";
            this.fLabel3.ForeColor = System.Drawing.Color.Black;
            this.fLabel3.Location = new System.Drawing.Point(338, 20);
            this.fLabel3.Name = "fLabel3";
            this.fLabel3.OldText = "";
            this.fLabel3.OutputControl = null;
            this.fLabel3.Size = new System.Drawing.Size(43, 25);
            this.fLabel3.TabIndex = 2;
            this.fLabel3.Text = "MST:";
            this.fLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCuscode
            // 
            this.txtCuscode.CheckMinMaxChar = false;
            this.txtCuscode.ColumnName = "cuscode";
            this.txtCuscode.DBNullValueWhenBlank = false;
            this.txtCuscode.DBValue = "";
            this.txtCuscode.FillZeroWhenHavingText = false;
            this.txtCuscode.Location = new System.Drawing.Point(178, 20);
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
            // fLabel6
            // 
            this.fLabel6.ColumnName = "";
            this.fLabel6.ForeColor = System.Drawing.Color.Black;
            this.fLabel6.Location = new System.Drawing.Point(338, 129);
            this.fLabel6.Name = "fLabel6";
            this.fLabel6.OldText = "";
            this.fLabel6.OutputControl = null;
            this.fLabel6.Size = new System.Drawing.Size(43, 25);
            this.fLabel6.TabIndex = 12;
            this.fLabel6.Text = "Fax:";
            this.fLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblSymbol);
            this.groupBox1.Controls.Add(this.fLabel15);
            this.groupBox1.Controls.Add(this.fLabel14);
            this.groupBox1.Controls.Add(this.lblTemplate);
            this.groupBox1.Controls.Add(this.fLabel10);
            this.groupBox1.Controls.Add(this.lblInvoiceCode);
            this.groupBox1.Controls.Add(this.fLabel11);
            this.groupBox1.Location = new System.Drawing.Point(732, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Hóa Đơn";
            // 
            // lblSymbol
            // 
            this.lblSymbol.ColumnName = "";
            this.lblSymbol.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.ForeColor = System.Drawing.Color.Red;
            this.lblSymbol.Location = new System.Drawing.Point(68, 71);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.OldText = "";
            this.lblSymbol.OutputControl = null;
            this.lblSymbol.Size = new System.Drawing.Size(124, 26);
            this.lblSymbol.TabIndex = 3;
            this.lblSymbol.Text = "TS/17E";
            this.lblSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fLabel15
            // 
            this.fLabel15.ColumnName = "";
            this.fLabel15.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel15.Location = new System.Drawing.Point(6, 44);
            this.fLabel15.Name = "fLabel15";
            this.fLabel15.OldText = "";
            this.fLabel15.OutputControl = null;
            this.fLabel15.Size = new System.Drawing.Size(62, 26);
            this.fLabel15.TabIndex = 0;
            this.fLabel15.Text = "Mẫu số:";
            this.fLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fLabel14
            // 
            this.fLabel14.ColumnName = "";
            this.fLabel14.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel14.Location = new System.Drawing.Point(6, 71);
            this.fLabel14.Name = "fLabel14";
            this.fLabel14.OldText = "";
            this.fLabel14.OutputControl = null;
            this.fLabel14.Size = new System.Drawing.Size(62, 26);
            this.fLabel14.TabIndex = 2;
            this.fLabel14.Text = "Ký hiệu:";
            this.fLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTemplate
            // 
            this.lblTemplate.ColumnName = "";
            this.lblTemplate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemplate.ForeColor = System.Drawing.Color.Red;
            this.lblTemplate.Location = new System.Drawing.Point(68, 44);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.OldText = "";
            this.lblTemplate.OutputControl = null;
            this.lblTemplate.Size = new System.Drawing.Size(124, 26);
            this.lblTemplate.TabIndex = 1;
            this.lblTemplate.Text = "01GTKT0/001";
            this.lblTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fLabel10
            // 
            this.fLabel10.ColumnName = "";
            this.fLabel10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel10.Location = new System.Drawing.Point(6, 98);
            this.fLabel10.Name = "fLabel10";
            this.fLabel10.OldText = "";
            this.fLabel10.OutputControl = null;
            this.fLabel10.Size = new System.Drawing.Size(62, 26);
            this.fLabel10.TabIndex = 4;
            this.fLabel10.Text = "Số:";
            this.fLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInvoiceCode
            // 
            this.lblInvoiceCode.ColumnName = "";
            this.lblInvoiceCode.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceCode.ForeColor = System.Drawing.Color.Red;
            this.lblInvoiceCode.Location = new System.Drawing.Point(68, 98);
            this.lblInvoiceCode.Name = "lblInvoiceCode";
            this.lblInvoiceCode.OldText = "";
            this.lblInvoiceCode.OutputControl = null;
            this.lblInvoiceCode.Size = new System.Drawing.Size(124, 26);
            this.lblInvoiceCode.TabIndex = 5;
            this.lblInvoiceCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fLabel11
            // 
            this.fLabel11.BackColor = System.Drawing.Color.LimeGreen;
            this.fLabel11.ColumnName = "";
            this.fLabel11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel11.Location = new System.Drawing.Point(9, 44);
            this.fLabel11.Name = "fLabel11";
            this.fLabel11.OldText = "";
            this.fLabel11.OutputControl = null;
            this.fLabel11.Size = new System.Drawing.Size(180, 81);
            this.fLabel11.TabIndex = 6;
            this.fLabel11.Text = "Mẫu số:";
            this.fLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.fButton3);
            this.panel1.Controls.Add(this.btnSaveTemp);
            this.panel1.Controls.Add(this.fButton2);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnSaveAndInvoice);
            this.panel1.Location = new System.Drawing.Point(12, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 60);
            this.panel1.TabIndex = 15;
            // 
            // fButton3
            // 
            this.fButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fButton3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fButton3.Location = new System.Drawing.Point(595, 9);
            this.fButton3.Name = "fButton3";
            this.fButton3.Size = new System.Drawing.Size(100, 40);
            this.fButton3.TabIndex = 8;
            this.fButton3.Text = "Tìm kiếm";
            this.fButton3.UseVisualStyleBackColor = true;
            // 
            // btnSaveTemp
            // 
            this.btnSaveTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveTemp.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTemp.Location = new System.Drawing.Point(113, 9);
            this.btnSaveTemp.Name = "btnSaveTemp";
            this.btnSaveTemp.Size = new System.Drawing.Size(100, 40);
            this.btnSaveTemp.TabIndex = 7;
            this.btnSaveTemp.Text = "Lưu";
            this.btnSaveTemp.UseVisualStyleBackColor = true;
            // 
            // fButton2
            // 
            this.fButton2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fButton2.Location = new System.Drawing.Point(345, 9);
            this.fButton2.Name = "fButton2";
            this.fButton2.Size = new System.Drawing.Size(130, 40);
            this.fButton2.TabIndex = 6;
            this.fButton2.Text = "Hóa Đơn Giấy";
            this.fButton2.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(7, 9);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 40);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "Xem trước";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(807, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(701, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 40);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSaveAndInvoice
            // 
            this.btnSaveAndInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveAndInvoice.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndInvoice.Location = new System.Drawing.Point(219, 9);
            this.btnSaveAndInvoice.Name = "btnSaveAndInvoice";
            this.btnSaveAndInvoice.Size = new System.Drawing.Size(120, 40);
            this.btnSaveAndInvoice.TabIndex = 1;
            this.btnSaveAndInvoice.Text = "Lưu và Xuất";
            this.btnSaveAndInvoice.UseVisualStyleBackColor = true;
            // 
            // footer1
            // 
            this.footer1.BackColor = System.Drawing.Color.SeaGreen;
            this.footer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer1.Location = new System.Drawing.Point(0, 547);
            this.footer1.Margin = new System.Windows.Forms.Padding(4);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(942, 26);
            this.footer1.TabIndex = 16;
            // 
            // fButton1
            // 
            this.fButton1.Location = new System.Drawing.Point(258, 9);
            this.fButton1.Name = "fButton1";
            this.fButton1.Size = new System.Drawing.Size(160, 40);
            this.fButton1.TabIndex = 2;
            this.fButton1.Text = "Lưu và Xuất Hóa Đơn";
            this.fButton1.UseVisualStyleBackColor = true;
            // 
            // FrmEinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(942, 573);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.pnlSum);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FrmEinvoice";
            this.Text = "Xuất hóa đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.pnlSum.ResumeLayout(false);
            this.pnlSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxrate)).EndInit();
            this.gbCustomer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FOS_Utils.FLabel fLabel1;
        private FOS_Utils.FLabel fLabel6;
        private FOS_Utils.FLabel fLabel3;
        private FOS_Utils.FLabel fLabel5;
        private FOS_Utils.FLabel fLabel2;
        private FOS_Utils.FLabel fLabel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private FOS_Utils.FDataGridViewOverride dgvDetail;
        private FOS_Utils.FTextBox txtFax;
        private FOS_Utils.FTextBox txtPhone;
        private FOS_Utils.FTextBox txtAddress;
        private FOS_Utils.FTextBox txtCompanyName;
        private FOS_Utils.FTextBox txtTaxcode;
        private FOS_Utils.FTextBox txtCuscode;
        private FOS_Utils.FComboBox cmbPaymenttype;
        private FOS_Utils.FLabel fLabel7;
        private System.Windows.Forms.Panel pnlSum;
        private FOS_Utils.FLabel fLabel8;
        private FOS_Utils.FLabel fLabel9;
        private FOS_Utils.FNumericUpDown numTaxrate;
        private FOS_Utils.FLabel fLabel35;
        private FOS_Utils.FLabel fLabel34;
        private FOS_Utils.FLabel fLabel33;
        private FOS_Utils.FButton fButton1;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private FOS_Utils.FLabel lblSymbol;
        private FOS_Utils.FLabel lblTemplate;
        private FOS_Utils.FLabel lblInvoiceCode;
        private FOS_Utils.FLabel fLabel10;
        private FOS_Utils.FLabel fLabel14;
        private FOS_Utils.FLabel fLabel15;
        private FOS_Utils.FButton btnCuscode;
        private FOS_Utils.FLabel fLabel16;
        private FOS_Utils.FLabel fLabel17;
        public System.Windows.Forms.Panel panel1;
        public FOS_Utils.FButton btnClose;
        public FOS_Utils.FButton btnNew;
        public FOS_Utils.FButton btnSaveAndInvoice;
        public FOS_Utils.FButton btnPreview;
        private FOS_Utils.FNumber nTotal;
        private FOS_Utils.FTextBox txtSotienbangchu;
        private FOS_Utils.FNumber nPaymoney;
        private FOS_Utils.FNumber nTax;
        private FOS_Utils.FTextBox txtCusname;
        private FOS_Einvoice.UserControls.Footer footer1;
        public FOS_Utils.FButton fButton2;
        public FOS_Utils.FButton btnSaveTemp;
        private FOS_Utils.FLabel fLabel11;
        public FOS_Utils.FButton fButton3;
        private FOS_Utils.FButton btnRowSearch;
        private FOS_Utils.FButton btnRowDelete;
        private FOS_Utils.FButton btnRowAdd;
        private FOS_Utils.FButton btnRowCopy;
        private FOS_Utils.FButton btnRowPaste;
    }
}
