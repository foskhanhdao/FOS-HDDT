using System;
using System.Windows.Forms;
using System.Collections;
using FOS_Utils;
using System.Data;
using System.Data.SqlClient;

namespace FOS_Einvoice
{
    public partial class FrmBaseMaster : FrmBase
    {
        public ArrayList ctrlPrimaryKey = null;
        public ArrayList ctrlData = null;
        public string TableName = "";
        public string[] getdateColumnNamesInsert = null;
        public string[] getdateColumnNamesUpdate = null;
        SqlConnection con = null;
        SqlTransaction tran = null;



        public FrmBaseMaster()
        {
            InitializeComponent();
        }

        public bool OpenConnection()
        {
            try
            {
                if (con == null) con = DataBase.GetConnection();
                if (con.State == ConnectionState.Closed) con.Open();
                if (tran != null) tran = con.BeginTransaction();
                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        public void CloseConnection(bool isCommit)
        {
            try
            {
                if (tran != null)
                {
                    if (isCommit) tran.Commit();
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
            catch (Exception ex)
            {
            }
        }

        public virtual void Clear()
        {
            CommonFunctions.ClearControls(ctrlData);
            CommonFunctions.ClearControls(ctrlPrimaryKey);
            SetEnableControls(false, true);
            CloseConnection(false);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SetDefaultFocus();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            CloseConnection(false);
        }

        public virtual void InitDataControls(Control main) {
            try
            {
                ctrlData = new ArrayList();
                IControl cr = null;
                foreach (Control ctrl in main.Controls)
                {
                    if (ctrl is Panel || ctrl is GroupBox) InitDataControlsFromContainer(ctrl);
                    else
                    {
                        cr = ctrl as IControl;
                        if (cr != null && cr.ColumnName != ""
                            && !ctrlData.Contains(cr)
                            && !ctrlPrimaryKey.Contains(cr)) ctrlData.Add(cr);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void InitDataControlsFromContainer(Control list)
        {
            try
            {
                IControl cr = null;
                if (list is Panel)
                {
                    foreach (Control ctrl in this.Controls)
                    {
                        cr = ctrl as IControl;
                        if (cr != null && cr.ColumnName != "" 
                            && !ctrlData.Contains(cr)
                            && !ctrlPrimaryKey.Contains(cr)) ctrlData.Add(cr);        
                    }
                }
                else if (list is GroupBox)
                {
                    foreach (Control ctrl in this.Controls)
                    {
                        cr = ctrl as IControl;
                        if (cr != null && cr.ColumnName != "" 
                            && !ctrlData.Contains(cr)
                            && !ctrlPrimaryKey.Contains(cr)) ctrlData.Add(cr);
                    }
                }                
            }
            catch (Exception ex)
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu trên màn hình sẽ bị xóa ?","Xác nhận",MessageBoxButtons.YesNo) == DialogResult.Yes)
                Clear();
        }

        

        public virtual void GetData()
        {
            try
            {
                if (!OpenConnection()) {
                    MessageBox.Show("Không thể kết nối với cơ sỡ dữ liệu!");
                    return;
                }
                string sql = " select * from " + TableName + " WITH (ROWLOCK, UPDLOCK) where ";
                IControl ctrl = null;
                ArrayList paramNames = new ArrayList();
                ArrayList paramValues = new ArrayList();
                for (int i = 0; i < ctrlPrimaryKey.Count; i++)
                {
                    if (i > 0) sql += " and ";
                    ctrl = ctrlPrimaryKey[i] as IControl;
                    sql += ctrl.ColumnName + " = @" + ctrl.ColumnName;

                    paramNames.Add("@" + ctrl.ColumnName);
                    paramValues.Add(ctrl.DBValue);
                }
                DataTable dt = DataBase.GetData(sql, paramNames, paramValues, con, tran).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < ctrlData.Count; i++)
                    {
                        ctrl = ctrlData[i] as IControl;
                        if (ctrl != null)
                        {
                            ctrl.DBValue = dt.Rows[0][ctrl.ColumnName];
                        }
                    }
                    SetEnableControls(true, false);
                }
                else
                {
                    SetEnableControls(true, true);
                }
            }
            catch (Exception ex)
            {
            }
        }

        public virtual void SetEnableControls(bool en,bool isNew) {
            try
            {
                CommonFunctions.SetEnableControls(ctrlPrimaryKey, !en);
                CommonFunctions.SetEnableControls(ctrlData, en);
                btnSave.Enabled = en;
                btnDelete.Enabled = en && !isNew;
                SetDefaultFocus();
            }
            catch (Exception ex)
            {
            }
        }

        public virtual void SetDefaultFocus()
        {
           
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            try
            {
                
                if (e.KeyCode == Keys.Enter)
                {
                    if (ctrlPrimaryKey != null && ctrlPrimaryKey.Count > 0
                        && ctrlPrimaryKey[ctrlPrimaryKey.Count - 1] == this.ActiveControl)
                    {
                        if (this.ActiveControl.Text == "")
                        {
                            MessageBox.Show("Hãy nhập mã vào để tiếp tục !");
                            this.ActiveControl.Focus();
                        } else 
                        GetData();
                    }
                    else base.OnKeyDown(e);
                }
                else base.OnKeyDown(e);
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu trữ dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Save())
                {
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật dữ liệu!");
                }
            }
        }

        public virtual bool Save()
        {
            try
            {
                if (btnDelete.Enabled)
                {
                    if (DataBase.Update(TableName, ctrlPrimaryKey, ctrlData
                        , null, null, getdateColumnNamesUpdate
                        , con, tran) > 0)
                    {
                        CloseConnection(true);
                        Clear();
                        return true;
                    }
                }
                else
                {
                    if (DataBase.Insert(TableName, ctrlPrimaryKey, ctrlData
                        , null, null, getdateColumnNamesInsert
                        , con, tran) > 0)
                    {
                        CloseConnection(true);
                        Clear();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa bỏ thông tin hiện tại?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Delete()) Clear();
            }
        }

        public virtual bool Delete()
        {
            try
            {
                string sql = " delete from " + TableName + " where 1 = 1 ";
                IControl c = null;

                ArrayList paramNames = new ArrayList();
                ArrayList paramValues = new ArrayList();
                for (int i = 0; i < ctrlPrimaryKey.Count; i++)
                {
                    c = ctrlPrimaryKey[i] as IControl;
                    if (c != null) {
                        sql += " and ";
                        sql += c.ColumnName + " = @" + c.ColumnName;
                        paramNames.Add("@" + c.ColumnName);
                        paramValues.Add(c.DBValue);
                    }                    
                }

                return DataBase.ExecuteSQL(sql, paramNames, paramValues, con, tran) > 0;
            }
            catch (Exception ex)
            {
            }
            return false;
        }
    }
}
