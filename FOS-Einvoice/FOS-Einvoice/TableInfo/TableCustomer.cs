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
        public const string Col_cuscode = "cuscode";
        public const string Col_cuspass = "cuspass";
        public const string Col_cusname = "cusname";
        public const string Col_cusbirthday = "cusbirthday";
        public const string Col_cussex = "cussex";
        public const string Col_companyname = "companyname";
        public const string Col_taxcode = "taxcode";
        public const string Col_cusaddress = "cusaddress";
        public const string Col_email = "email";
        public const string Col_phone = "phone";
        public const string Col_fax = "fax";
        public const string Col_cusstate = "cusstate";
        public const string Col_datecreate = "datecreate";
        public const string Col_dateupdate = "dateupdate";

        public TableCustomer()
        {
        }
    }
}
