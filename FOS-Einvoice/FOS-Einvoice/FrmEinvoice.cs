using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FOS_Utils;
using System.Data.SqlClient;

namespace FOS_Einvoice
{
    public partial class FrmEinvoice : FrmBase, IDataGridViewKeyProcess
    {
        SqlConnection con = null;
        SqlTransaction tran = null;
        private const int IDX_STT = 0;
        private const int IDX_MA_HANG_HOA = 1;
        private const int IDX_TEN_HANG_HOA = 2;
        private const int IDX_DON_VI_TINH = 3;
        private const int IDX_SO_LUONG = 4;
        private const int IDX_DON_GIA = 5;
        private const int IDX_THANH_TIEN = 6;

        private DataGridViewRow rowCopy = null;

        DataTable dtUnit = null;

        public FrmEinvoice()
        {
            InitializeComponent();         
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                dgvDetail.InitKeyProcess(this);
                dgvDetail.RowTemplate.Height = 25;
                InitData();
                CreateColumns();
                dgvDetail.Rows.Add(1);

                dtUnit = TableInfo.TableUnit.Get();
                DataRow dr = dtUnit.NewRow();
                dtUnit.Rows.InsertAt(dr, 0);
            }
            catch (Exception ex)
            {
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            CloseConnection(false);
        }

        private void InitData()
        {
            cmbPaymenttype.SelectedIndex = 0;
            numTaxrate.Value = TableInfo.TableTax.GetTaxRate(DateTime.Now, TableInfo.TableTaxType.CODE_GTGT);
        }

        public void Clear()
        {
            InitData();
            Control ctrl = null;
            for (int i = 0; i < gbCustomer.Controls.Count; i++)
            {
                ctrl = gbCustomer.Controls[i];
                if (ctrl is FTextBox) ctrl.Text = "";
            }
            txtSotienbangchu.Text = "";
            nTax.Value = 0;
            nTotal.Value = 0;
            nPaymoney.Value = 0;
            CloseConnection(false);
            dgvDetail.Rows.Clear();
            dgvDetail.Rows.Add(1);
        }
        

        private void CreateColumns()
        {
            try
            {
                //STT
                FTextBoxColumn stt = new FTextBoxColumn(3);
                stt.HeaderText = "STT";
                stt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stt.ReadOnly = true;
                stt.Width = 40;
                stt.DefaultCellStyle.BackColor = SystemColors.Control;
                dgvDetail.Columns.Add(stt);
                //Ma hang hoa, dich vu
                FTextBoxColumn mahh = new FTextBoxColumn(20);
                mahh.HeaderText = "Mã hàng hóa, dịch vụ";
                mahh.Width = 150;
                dgvDetail.Columns.Add(mahh);
                //Ten hang hoa, dich vu
                FTextBoxColumn tenhh = new FTextBoxColumn(200);
                tenhh.HeaderText = "Tên hàng hóa, dịch vụ";
                tenhh.Width = 290;
                dgvDetail.Columns.Add(tenhh);
                //Don vi tinh
                FComboBoxColumn dvt = new FComboBoxColumn();
                dvt.HeaderText = "Đơn vị tính";
                dvt.Width = 90;
                dgvDetail.Columns.Add(dvt);
                //So luong
                FNumberColumn sl = new FNumberColumn();
                sl.HeaderText = "Số lượng";
                sl.Width = 70;
                sl.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetail.Columns.Add(sl);
                //Don gia
                FNumberColumn dg = new FNumberColumn();
                dg.HeaderText = "Đơn giá";
                dg.Width = 100;
                dg.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetail.Columns.Add(dg);
                //Thanh tien
                FNumberColumn tt = new FNumberColumn();
                tt.HeaderText = "Thành tiền";
                tt.Width = 100;
                tt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                tt.ReadOnly = true;
                tt.DefaultCellStyle.BackColor = SystemColors.Control;
                dgvDetail.Columns.Add(tt);
            }
            catch (Exception ex)
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        

        private void btnCuscode_Click(object sender, EventArgs e)
        {
            new FrmSearchCustomer().ShowDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }

        private void txtPaymoney_TextChanged(object sender, EventArgs e)
        {
            txtSotienbangchu.Text = CommonFunctions.NumberToTextVN(CommonFunctions.TryParseDecimal(nPaymoney.Text,0));
        }

        #region IDataGridViewKeyProcess Members

        public void OnEnterKeyProcess()
        {
            try
            {
                dgvDetail.EndEdit();
                int col = dgvDetail.CurrentCell.ColumnIndex + 1;
                int row = dgvDetail.CurrentCell.RowIndex;
                if (col >= IDX_THANH_TIEN)
                {
                    col = 1;
                    row++;
                }
                if (row < dgvDetail.RowCount)
                {
                    dgvDetail.CurrentCell = dgvDetail.Rows[row].Cells[col];
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void OnUpKeyProcess()
        {
            //throw new NotImplementedException();
        }

        public void OnDownKeyProcess()
        {
            //throw new NotImplementedException();
        }

        public void OnShiftTabKeyProcess()
        {
            //throw new NotImplementedException();
        }

        public void OnFunctionKeyProcess(Keys key)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private void dgvDetail_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                int colidx = dgvDetail.CurrentCell.ColumnIndex;
                Control ctrl = e.Control;

                if (colidx == IDX_SO_LUONG || colidx == IDX_DON_GIA)
                {
                    (ctrl as FNumberEditingControl).MaxLength = 12;
                }
                else if (colidx == IDX_MA_HANG_HOA)
                {
                    (ctrl as FTextBoxEditingControl).MaxLength = 20;
                }
                else if (colidx == IDX_TEN_HANG_HOA)
                {
                    (ctrl as FTextBoxEditingControl).MaxLength = 200;
                }
                else if (colidx == IDX_DON_VI_TINH)
                {
                    FComboBoxEditingControl cmb = ctrl as FComboBoxEditingControl;
                    cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmb.DataSource = dtUnit;
                    cmb.DisplayMember = TableInfo.TableUnit.COL_NAME_UNIT_NAME;
                    cmb.ValueMember = TableInfo.TableUnit.COL_NAME_UNIT_CODE;
                    cmb.MaxLength = 50;
                    cmb.SelectedValueChanged += new EventHandler(Unit_SelectedValueChanged);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn tạo hóa đơn mới?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            Clear();
            GetNewInvoice();
        }

        private void GetNewInvoice()
        {
            try
            {
                if (OpenConnection())
                {
                    string sql = " select top 1 * from invoice ";
                    sql += " with (ROWLOCK,UPDLOCK, READPAST) ";
                    sql += " where invoicedateupdate is null ";
                    sql += " and invoicedatecreate is null ";
                    sql += " and invoicedateprint is null ";
                    sql += " and invoicedatecancel is null ";
                    sql += " order by invoicecode asc ";         

                    DataTable dt = DataBase.GetData(sql, con, tran).Tables[0];
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Hóa đơn đã hết số, vui lòng liên hệ nhà cung cấp!");
                        CloseConnection(false);
                    }
                    else
                    {
                        lblInvoiceCode.Text = dt.Rows[0]["invoicecode"].ToString();

                        //decimal nummin = CommonFunctions.TryParseDecimal(dt.Rows[0]["nummin"], 0);
                        //decimal nummax = CommonFunctions.TryParseDecimal(dt.Rows[0]["nummax"], 0);
                        //string sym1 = dt.Rows[0]["invoicesymbol1"].ToString();
                        //string sym2 = dt.Rows[0]["invoicesymbol2"].ToString();
                        //string sym3 = dt.Rows[0]["invoicesymbol3"].ToString();

                        //sql = " select * from invoice ";
                        //sql += " with (ROWLOCK,UPDLOCK, READPAST) where ";
                        ////sql += " where invoicedateupdate is null ";
                        ////sql += " and invoicedatecreate is null ";
                        ////sql += " and invoicedateprint is null ";
                        ////sql += " and invoicedatecancel is null ";
                        //sql += " invoicecode =@invoicecode ";
                        //sql += " and invoicesymbol1 =@invoicesymbol1 ";
                        //sql += " and invoicesymbol2 =@invoicesymbol2 ";
                        //sql += " and invoicesymbol3 =@invoicesymbol3 ";
                        //sql += " and invoicetypecode = " + TableInfo.TableInvoice.TYPE_CODE;
                        //sql += " order by  ";

                        //for (int i = 0; i < dt.Rows.Count; i++)
                        //{
                        //    DataTable dt2 = DataBase.GetData(sql
                        //        , new string[] { "@invoicecode", "@invoicesymbol1", "@invoicesymbol2", "@invoicesymbol3" }
                        //        , new object[] { dt.Rows[i]["invoicecode"].ToString(), sym1, sym2, sym3 }
                        //        , con, tran).Tables[0];
                        //    if (dt2.Rows.Count > 0)
                        //    {
                        //        lblInvoiceCode.Text = dt.Rows[0]["invoicecode"].ToString();
                        //        lblSymbol.Text = sym1 + "/" + sym2 + sym3;
                        //        break;
                        //    }
                        //}
                    }
                }
                else 
                {
                    MessageBox.Show("Không thể kết nối với cơ sở dữ liệu!");
                }
            }
            catch (Exception ex)
            {
            }
        }

        private bool OpenConnection()
        {
            if (con == null)
            {
                con = DataBase.GetConnection();
            }
            if (tran == null)
            {
                tran = con.BeginTransaction();
            }
            return con != null && con.State == ConnectionState.Open;
        }

        private void CloseConnection(bool iscommit)
        {
            if (tran != null)
            {
                if (iscommit) tran.Commit();
                else tran.Rollback();
                tran.Dispose();
                tran = null;
            }
            if (con != null)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }

        private void dgvDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == IDX_SO_LUONG || e.ColumnIndex == IDX_DON_GIA)
                {
                    dgvDetail.CurrentRow.Cells[IDX_THANH_TIEN].Value =
                        CommonFunctions.TryParseDecimal(dgvDetail.CurrentRow.Cells[IDX_SO_LUONG].Value, 0)
                        * CommonFunctions.TryParseDecimal(dgvDetail.CurrentRow.Cells[IDX_DON_GIA].Value, 0)
                        ;
                }
                else if (e.ColumnIndex == IDX_DON_VI_TINH)
                {
                    
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void ResetSTT()
        {
            for (int i = 0; i < dgvDetail.Rows.Count; i++)
            {
                dgvDetail.Rows[i].Cells[IDX_STT].Value = i + 1;
            }
        }

        private void dgvDetail_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ResetSTT();
        }

        private void dgvDetail_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ResetSTT();
        }

        private void SetEnableRowButton(bool en)
        {
            try
            {
                if (!dgvDetail.Enabled) en = false;
                btnRowAdd.Enabled = en;
                btnRowDelete.Enabled = en;
                btnRowPaste.Enabled = en && rowCopy != null;
                btnRowCopy.Enabled = en;

                if (en && dgvDetail.CurrentCell.ColumnIndex != IDX_MA_HANG_HOA)
                {
                    en = false;
                }
                btnRowSearch.Enabled = en;
            }
            catch (Exception ex)
            {
            }
        }

        private void WhenDetailLeave()
        {
            if (this.ActiveControl != dgvDetail
                && this.ActiveControl != btnRowAdd
                && this.ActiveControl != btnRowCopy
                && this.ActiveControl != btnRowDelete
                && this.ActiveControl != btnRowPaste
                && this.ActiveControl != btnRowSearch)
                SetEnableRowButton(false);
        }

        private void dgvDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            SetEnableRowButton(true);
        }

        private void dgvDetail_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            WhenDetailLeave();
        }

        private void RowButton_Click(object sender, EventArgs e)
        {
            dgvDetail.Focus();
            if (sender == btnRowAdd) InsertRow();
            else if (sender == btnRowDelete) DeleteRow();
        }

        private void InsertRow()
        {
            try
            {
                dgvDetail.Rows.Add(1);
                ResetSTT();
            }
            catch (Exception ex)
            {
            }
        }

        private void DeleteRow()
        {
            try
            {
                int rowidx = dgvDetail.CurrentRow.Index;
                dgvDetail.Rows.RemoveAt(rowidx);
                if (dgvDetail.Rows.Count == 0) dgvDetail.Rows.Add(1);
            }
            catch (Exception ex)
            {
            }
        }

        private void RowButton_Leave(object sender, EventArgs e)
        {
            WhenDetailLeave();
        }

        private void Unit_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDetail.CurrentCell.Value = (sender as FComboBoxEditingControl).Text;
            }
            catch (Exception ex)
            {
            }
        }
    }
}
