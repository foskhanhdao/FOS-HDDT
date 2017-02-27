using System;
using System.Windows.Forms;

namespace FOS_Einvoice
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //string[] info = CommonFunctions.ReadConnectionFileInfo();
            //DataBase.SetConnectionInfo(info);
            //if (!DataBase.TestConnection())
            //{
            //    MessageBox.Show("Không thể truy cập cơ sở dữ liệu. \nHãy kiểm tra lại thông số kết nối !");
            //}            
        }

        private void btnInvoiceCreate_Click(object sender, EventArgs e)
        {
            new FrmEinvoice().ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            new FrmCustomer().ShowDialog();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            new FrmConnection().ShowDialog();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            new FrmCompany().ShowDialog();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            new FrmTestPDF().ShowDialog();
        }
    }
}
