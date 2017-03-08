using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FOS_Einvoice.TableInfo
{
    public class TableProducttype
    {
        public const string COL_NAME_PRODUCT_TYPE_CODE = "producttypecode";
        public const string COL_NAME_PRODUCT_TYPE_NAME = "producttypename";
        public static DataTable Get()
        {
            DataTable dt = null;
            try
            {
                string sql = " select producttypecode,producttypename from producttype order by producttypecode ";
                dt = DataBase.GetData(sql).Tables[0];
            }
            catch (Exception ex)
            {
            }
            return dt;
        }
    }
}
