using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FOS_Einvoice
{
    public partial class FrmConnection : Form
    {
        public bool result = false;
        public FrmConnection()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                string[] setuzoku = CommonFunctions.ReadConnectionFileInfo();
                txtServer.Text = setuzoku[0];
                txtPort.Text = setuzoku[1];
                txtUser.Text = setuzoku[2];
                txtPassword.Text = setuzoku[3];
                txtDatanbaseName.Text = setuzoku[4];
                if (!txtServer.Text.Equals("") || !txtPort.Text.Equals("")
                    || !txtUser.Text.Equals("") || !txtPassword.Text.Equals("") || !txtDatanbaseName.Text.Equals(""))
                    chkSaveInfo.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.connectionInfo.Server = txtServer.Text;
                DataBase.connectionInfo.Port = txtPort.Text;
                DataBase.connectionInfo.User = txtUser.Text;
                DataBase.connectionInfo.Password = txtPassword.Text;
                DataBase.connectionInfo.DatabaseName = txtDatanbaseName.Text;
                if (!DataBase.TestConnection())
                {
                    txtServer.Focus();
                    txtServer.SelectAll();
                    return;
                }
                result = true;
                if (chkSaveInfo.Checked)
                    CommonFunctions.SaveConnectionFileInfo(new String[] { txtServer.Text, txtPort.Text, txtUser.Text, txtPassword.Text, txtDatanbaseName.Text });
                else
                    CommonFunctions.SaveConnectionFileInfo(new string[] { "", "", "", "", "" });
                this.Dispose();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
