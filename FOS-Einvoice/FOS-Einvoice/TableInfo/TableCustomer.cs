using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FOS_Einvoice.TableInfo
{
    public class TableCustomer
    {
        public const string TableName = "customer";
        public const string Col_cuscode = "customercode";
        public const string Col_cuspass = "customerpass";
        public const string Col_cusname = "customername";
        public const string Col_cusbirthday = "customerbirthday";
        public const string Col_cussex = "customersex";
        public const string Col_companyname = "customercompanyname";
        public const string Col_taxcode = "customertaxcode";
        public const string Col_cusaddress = "customeraddress";
        public const string Col_email = "customeremail";
        public const string Col_phone = "customerphone";
        public const string Col_fax = "customerfax";
        public const string Col_cusstate = "customerstate";
        public const string Col_datecreate = "customerdatecreate";
        public const string Col_dateupdate = "customerdateupdate";

        public TableCustomer()
        {
        }
    }
}
