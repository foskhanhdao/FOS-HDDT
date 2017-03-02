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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFax = new FOS_Utils.FTextBox();
            this.txtPhone = new FOS_Utils.FTextBox();
            this.txtAddress = new FOS_Utils.FTextBox();
            this.txtCompanyName = new FOS_Utils.FTextBox();
            this.txtTaxcode = new FOS_Utils.FTextBox();
            this.txtCuscode = new FOS_Utils.FTextBox();
            this.fLabel1 = new FOS_Utils.FLabel();
            this.fLabel6 = new FOS_Utils.FLabel();
            this.fLabel3 = new FOS_Utils.FLabel();
            this.fLabel5 = new FOS_Utils.FLabel();
            this.fLabel2 = new FOS_Utils.FLabel();
            this.fLabel4 = new FOS_Utils.FLabel();
            this.cmbPaymenttype = new FOS_Utils.FComboBox();
            this.fLabel7 = new FOS_Utils.FLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new FOS_Utils.FDataGridViewOverride();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanlity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPaymoney = new FOS_Utils.FTextBox();
            this.txtTax = new FOS_Utils.FTextBox();
            this.txtTotal = new FOS_Utils.FTextBox();
            this.txtSotienbangchu = new FOS_Utils.FTextBox();
            this.fLabel17 = new FOS_Utils.FLabel();
            this.fLabel35 = new FOS_Utils.FLabel();
            this.fLabel34 = new FOS_Utils.FLabel();
            this.fLabel33 = new FOS_Utils.FLabel();
            this.fLabel9 = new FOS_Utils.FLabel();
            this.numTaxrate = new FOS_Utils.FNumericUpDown();
            this.fLabel8 = new FOS_Utils.FLabel();
            this.fButton1 = new FOS_Utils.FButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fLabel16 = new FOS_Utils.FLabel();
            this.txtCusname = new FOS_Utils.FTextBox();
            this.btnCuscode = new FOS_Utils.FButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSymbol = new FOS_Utils.FLabel();
            this.lblTemplate = new FOS_Utils.FLabel();
            this.lblInvoiceCode = new FOS_Utils.FLabel();
            this.fLabel10 = new FOS_Utils.FLabel();
            this.fLabel14 = new FOS_Utils.FLabel();
            this.fLabel15 = new FOS_Utils.FLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fButton2 = new FOS_Utils.FButton();
            this.btnPreview = new FOS_Utils.FButton();
            this.btnClose = new FOS_Utils.FButton();
            this.btnNew = new FOS_Utils.FButton();
            this.btnSaveAndInvoice = new FOS_Utils.FButton();
            this.footer1 = new FOS_Einvoice.UserControls.Footer();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxrate)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.txtAddress.Size = new System.Drawing.Size(529, 25);
            this.txtAddress.TabIndex = 9;
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDetail);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(918, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết hàng hóa, dịch vụ";
            // 
            // dgvDetail
            // 
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
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.productcode,
            this.productname,
            this.unitname,
            this.quanlity,
            this.price,
            this.total});
            this.dgvDetail.Location = new System.Drawing.Point(6, 23);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowTemplate.Height = 21;
            this.dgvDetail.Size = new System.Drawing.Size(906, 176);
            this.dgvDetail.TabIndex = 0;
            // 
            // STT
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.STT.Width = 40;
            // 
            // productcode
            // 
            this.productcode.HeaderText = "Mã hàng hóa, dịch vụ";
            this.productcode.Name = "productcode";
            this.productcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productcode.Width = 150;
            // 
            // productname
            // 
            this.productname.HeaderText = "Tên hàng hóa, dịch vụ";
            this.productname.Name = "productname";
            this.productname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productname.Width = 290;
            // 
            // unitname
            // 
            this.unitname.HeaderText = "Đơn vị tính";
            this.unitname.Name = "unitname";
            this.unitname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.unitname.Width = 90;
            // 
            // quanlity
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0";
            this.quanlity.DefaultCellStyle = dataGridViewCellStyle3;
            this.quanlity.HeaderText = "Số lượng";
            this.quanlity.Name = "quanlity";
            this.quanlity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.quanlity.Width = 70;
            // 
            // price
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#,##0";
            this.price.DefaultCellStyle = dataGridViewCellStyle4;
            this.price.HeaderText = "Đơn giá";
            this.price.Name = "price";
            this.price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // total
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,##0";
            this.total.DefaultCellStyle = dataGridViewCellStyle5;
            this.total.HeaderText = "Thành tiền";
            this.total.Name = "total";
            this.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtPaymoney);
            this.panel3.Controls.Add(this.txtTax);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.txtSotienbangchu);
            this.panel3.Controls.Add(this.fLabel17);
            this.panel3.Controls.Add(this.cmbPaymenttype);
            this.panel3.Controls.Add(this.fLabel35);
            this.panel3.Controls.Add(this.fLabel34);
            this.panel3.Controls.Add(this.fLabel33);
            this.panel3.Controls.Add(this.fLabel7);
            this.panel3.Controls.Add(this.fLabel9);
            this.panel3.Controls.Add(this.numTaxrate);
            this.panel3.Controls.Add(this.fLabel8);
            this.panel3.Location = new System.Drawing.Point(12, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(918, 85);
            this.panel3.TabIndex = 2;
            // 
            // txtPaymoney
            // 
            this.txtPaymoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaymoney.CheckMinMaxChar = false;
            this.txtPaymoney.ColumnName = "";
            this.txtPaymoney.DBNullValueWhenBlank = false;
            this.txtPaymoney.DBValue = "";
            this.txtPaymoney.FillZeroWhenHavingText = false;
            this.txtPaymoney.Location = new System.Drawing.Point(764, 55);
            this.txtPaymoney.MaxChar = '9';
            this.txtPaymoney.MaxLength = 300;
            this.txtPaymoney.MaxLengthFromByte = false;
            this.txtPaymoney.MinChar = '0';
            this.txtPaymoney.Name = "txtPaymoney";
            this.txtPaymoney.OldText = "";
            this.txtPaymoney.OutputControl = null;
            this.txtPaymoney.ReadOnly = true;
            this.txtPaymoney.Size = new System.Drawing.Size(146, 25);
            this.txtPaymoney.TabIndex = 15;
            this.txtPaymoney.TabStop = false;
            this.txtPaymoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            this.txtTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTax.CheckMinMaxChar = false;
            this.txtTax.ColumnName = "";
            this.txtTax.DBNullValueWhenBlank = false;
            this.txtTax.DBValue = "";
            this.txtTax.FillZeroWhenHavingText = false;
            this.txtTax.Location = new System.Drawing.Point(764, 28);
            this.txtTax.MaxChar = '9';
            this.txtTax.MaxLength = 300;
            this.txtTax.MaxLengthFromByte = false;
            this.txtTax.MinChar = '0';
            this.txtTax.Name = "txtTax";
            this.txtTax.OldText = "";
            this.txtTax.OutputControl = null;
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(146, 25);
            this.txtTax.TabIndex = 14;
            this.txtTax.TabStop = false;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.CheckMinMaxChar = false;
            this.txtTotal.ColumnName = "";
            this.txtTotal.DBNullValueWhenBlank = false;
            this.txtTotal.DBValue = "";
            this.txtTotal.FillZeroWhenHavingText = false;
            this.txtTotal.Location = new System.Drawing.Point(764, 1);
            this.txtTotal.MaxChar = '9';
            this.txtTotal.MaxLength = 300;
            this.txtTotal.MaxLengthFromByte = false;
            this.txtTotal.MinChar = '0';
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.OldText = "";
            this.txtTotal.OutputControl = null;
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(146, 25);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            10,
            0,
            0,
            0});
            this.numTaxrate.Location = new System.Drawing.Point(152, 1);
            this.numTaxrate.Name = "numTaxrate";
            this.numTaxrate.Size = new System.Drawing.Size(48, 24);
            this.numTaxrate.TabIndex = 1;
            this.numTaxrate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
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
            // fButton1
            // 
            this.fButton1.Location = new System.Drawing.Point(258, 9);
            this.fButton1.Name = "fButton1";
            this.fButton1.Size = new System.Drawing.Size(160, 40);
            this.fButton1.TabIndex = 2;
            this.fButton1.Text = "Lưu và Xuất Hóa Đơn";
            this.fButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fLabel16);
            this.groupBox3.Controls.Add(this.txtCusname);
            this.groupBox3.Controls.Add(this.btnCuscode);
            this.groupBox3.Controls.Add(this.txtFax);
            this.groupBox3.Controls.Add(this.fLabel1);
            this.groupBox3.Controls.Add(this.txtPhone);
            this.groupBox3.Controls.Add(this.fLabel4);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.fLabel2);
            this.groupBox3.Controls.Add(this.txtCompanyName);
            this.groupBox3.Controls.Add(this.fLabel5);
            this.groupBox3.Controls.Add(this.txtTaxcode);
            this.groupBox3.Controls.Add(this.fLabel3);
            this.groupBox3.Controls.Add(this.txtCuscode);
            this.groupBox3.Controls.Add(this.fLabel6);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(714, 160);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết người mua hàng";
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
            this.btnCuscode.Size = new System.Drawing.Size(82, 25);
            this.btnCuscode.TabIndex = 14;
            this.btnCuscode.Text = "Tìm kiếm";
            this.btnCuscode.UseVisualStyleBackColor = true;
            this.btnCuscode.Click += new System.EventHandler(this.btnCuscode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblSymbol);
            this.groupBox1.Controls.Add(this.lblTemplate);
            this.groupBox1.Controls.Add(this.lblInvoiceCode);
            this.groupBox1.Controls.Add(this.fLabel10);
            this.groupBox1.Controls.Add(this.fLabel14);
            this.groupBox1.Controls.Add(this.fLabel15);
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
            this.lblSymbol.Location = new System.Drawing.Point(68, 74);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.OldText = "";
            this.lblSymbol.OutputControl = null;
            this.lblSymbol.Size = new System.Drawing.Size(124, 26);
            this.lblSymbol.TabIndex = 3;
            this.lblSymbol.Text = "TS/17E";
            this.lblSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTemplate
            // 
            this.lblTemplate.ColumnName = "";
            this.lblTemplate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemplate.Location = new System.Drawing.Point(68, 47);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.OldText = "";
            this.lblTemplate.OutputControl = null;
            this.lblTemplate.Size = new System.Drawing.Size(124, 26);
            this.lblTemplate.TabIndex = 1;
            this.lblTemplate.Text = "01GTKT0/001";
            this.lblTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInvoiceCode
            // 
            this.lblInvoiceCode.ColumnName = "";
            this.lblInvoiceCode.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceCode.Location = new System.Drawing.Point(68, 101);
            this.lblInvoiceCode.Name = "lblInvoiceCode";
            this.lblInvoiceCode.OldText = "";
            this.lblInvoiceCode.OutputControl = null;
            this.lblInvoiceCode.Size = new System.Drawing.Size(124, 26);
            this.lblInvoiceCode.TabIndex = 5;
            this.lblInvoiceCode.Text = "0000000";
            this.lblInvoiceCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fLabel10
            // 
            this.fLabel10.ColumnName = "";
            this.fLabel10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel10.Location = new System.Drawing.Point(6, 101);
            this.fLabel10.Name = "fLabel10";
            this.fLabel10.OldText = "";
            this.fLabel10.OutputControl = null;
            this.fLabel10.Size = new System.Drawing.Size(40, 26);
            this.fLabel10.TabIndex = 4;
            this.fLabel10.Text = "Số:";
            this.fLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fLabel14
            // 
            this.fLabel14.ColumnName = "";
            this.fLabel14.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel14.Location = new System.Drawing.Point(6, 74);
            this.fLabel14.Name = "fLabel14";
            this.fLabel14.OldText = "";
            this.fLabel14.OutputControl = null;
            this.fLabel14.Size = new System.Drawing.Size(72, 26);
            this.fLabel14.TabIndex = 2;
            this.fLabel14.Text = "Ký hiệu:";
            this.fLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fLabel15
            // 
            this.fLabel15.ColumnName = "";
            this.fLabel15.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel15.Location = new System.Drawing.Point(6, 47);
            this.fLabel15.Name = "fLabel15";
            this.fLabel15.OldText = "";
            this.fLabel15.OutputControl = null;
            this.fLabel15.Size = new System.Drawing.Size(72, 26);
            this.fLabel15.TabIndex = 0;
            this.fLabel15.Text = "Mẫu số:";
            this.fLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            // fButton2
            // 
            this.fButton2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fButton2.Location = new System.Drawing.Point(338, 9);
            this.fButton2.Name = "fButton2";
            this.fButton2.Size = new System.Drawing.Size(160, 40);
            this.fButton2.TabIndex = 6;
            this.fButton2.Text = "Chuyển đổi Hóa Đơn";
            this.fButton2.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(7, 9);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(163, 40);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "Xem trước Hóa Đơn";
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
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(504, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 40);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSaveAndInvoice
            // 
            this.btnSaveAndInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveAndInvoice.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndInvoice.Location = new System.Drawing.Point(172, 9);
            this.btnSaveAndInvoice.Name = "btnSaveAndInvoice";
            this.btnSaveAndInvoice.Size = new System.Drawing.Size(160, 40);
            this.btnSaveAndInvoice.TabIndex = 1;
            this.btnSaveAndInvoice.Text = "Lưu và Xuất Hóa Đơn";
            this.btnSaveAndInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // FrmEinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(942, 573);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FrmEinvoice";
            this.Text = "Xuất hóa đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTaxrate)).EndInit();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private FOS_Utils.FLabel fLabel8;
        private FOS_Utils.FLabel fLabel9;
        private FOS_Utils.FNumericUpDown numTaxrate;
        private FOS_Utils.FLabel fLabel35;
        private FOS_Utils.FLabel fLabel34;
        private FOS_Utils.FLabel fLabel33;
        private FOS_Utils.FButton fButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanlity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
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
        private FOS_Utils.FTextBox txtTotal;
        private FOS_Utils.FTextBox txtSotienbangchu;
        private FOS_Utils.FTextBox txtPaymoney;
        private FOS_Utils.FTextBox txtTax;
        private FOS_Utils.FTextBox txtCusname;
        private FOS_Einvoice.UserControls.Footer footer1;
        public FOS_Utils.FButton fButton2;
    }
}
