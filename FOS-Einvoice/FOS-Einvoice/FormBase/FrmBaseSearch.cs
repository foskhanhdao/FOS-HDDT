using System;
using System.Windows.Forms;
using System.Data;

namespace FOS_Einvoice
{
    public partial class FrmBaseSearch : FrmBase
    {
        public DataGridViewRow result = null;
        public string[] columnHeaderText = new string[] {};
        public FrmBaseSearch()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            GetSelectedValue();
        }

        public void GetSelectedValue()
        {
            try
            {
                if (dgvData.CurrentRow != null && dgvData.CurrentRow.Index >= 0)
                {
                    result = dgvData.CurrentRow;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvData.DataSource = GetData();
                if (dgvData.ColumnCount >= columnHeaderText.Length)
                {
                    for (int i = 0; i < columnHeaderText.Length; i++)
                    {
                        dgvData.Columns[i].HeaderText = columnHeaderText[i];
                    }
                }

                AdjustAfterGetData();
            }
            catch (Exception ex)
            {
            }
        }

        public virtual DataTable GetData()
        {
            return null;
        }

        public virtual void Clear()
        {
        }

        public virtual void AdjustAfterGetData()
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GetSelectedValue();
        }
    }
}
