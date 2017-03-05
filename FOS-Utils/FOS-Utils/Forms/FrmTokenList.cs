using System;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using FOS_Utils.PDF.PDFLib;

namespace FOS_Utils.Forms
{
    public partial class FrmTokenList : Form
    {
        public int SelectedIndex = -1;

        public FrmTokenList(X509Certificate2Collection ser)
        {
            InitializeComponent();
            dgvData.RowTemplate.Height = 25;
            SetDataForGrid(ser);
        }

        private void SetDataForGrid(X509Certificate2Collection ser)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Issued to", typeof(string));
                dt.Columns.Add("Issued by", typeof(string));
                dt.Columns.Add("Valid from", typeof(DateTime));
                dt.Columns.Add("Valid to", typeof(DateTime));
                dt.Columns.Add("Serial Number", typeof(string));
                dt.Columns.Add("index", typeof(int));
                DataRow dr;
                for (int i = 0; i < ser.Count; i++)
                {
                    dr = dt.NewRow();
                    dr["Issued to"] = DigitalSignature.GetPartOfSubject(ser[i].Subject, "CN=");
                    dr["Issued by"] = DigitalSignature.GetPartOfSubject(ser[i].Issuer, "CN=");
                    dr["Valid from"] = ser[i].NotBefore;
                    dr["Valid to"] = ser[i].NotBefore;
                    dr["Serial Number"] = ser[i].SerialNumber;
                    dr["index"] = i;
                    dt.Rows.Add(dr);
                }               

                dgvData.DataSource = dt;

                dgvData.Columns["Issued to"].Width = 250;
                dgvData.Columns["Serial Number"].Width = 180;
                dgvData.Columns["Valid from"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvData.Columns["Valid to"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvData.Columns["index"].Visible = false;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvData.CurrentRow != null && dgvData.CurrentRow.Index >= 0)
                {
                    SelectedIndex = Convert.ToInt32(dgvData.CurrentRow.Cells["index"].Value);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
