using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FOS_Einvoice.TableInfo
{
    public class TableUnit
    {
        public const string COL_NAME_UNIT_CODE = "unitcode";
        public const string COL_NAME_UNIT_NAME = "unitname";
        public static DataTable Get()
        {
            DataTable dt = null;
            try
            {
                string sql = " select unitcode,unitname from unit order by unitcode ";
                dt = DataBase.GetData(sql).Tables[0];                
            }
            catch (Exception ex)
            {
            }
            return dt;
        }
    }
}
