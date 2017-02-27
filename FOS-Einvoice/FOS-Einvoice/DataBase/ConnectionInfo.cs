using System;
using System.Collections.Generic;
using System.Text;

namespace FOS_Einvoice
{
    public class ConnectionInfo
    {
        string server = "";
        string port = "";
        string user = "";
        string password = "";
        string databaseName = "";        
        public string Server
        {
            get { return server; }
            set { server = value; }
        }
        public string Port
        {
            get { return port; }
            set { port = value; }
        }
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }        
    }
}
