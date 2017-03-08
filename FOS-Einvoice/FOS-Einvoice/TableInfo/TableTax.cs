using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FOS_Einvoice.TableInfo
{
    public class TableTax
    {
        public TableTax()
        {
        }

        public static decimal GetTaxRate(DateTime d,int taxtype)
        {
            try
            {
                string sql = " select (case when @nen >= taxdatefrom and @nen <= taxdateto then taxrate end) as 'taxrate' ";
                sql += " from tax ";
                sql += " where taxtypecode = " + taxtype;
                object val = DataBase.GetColumnValue(sql
                    , new string[] { "@nen" }
                    , new object[] { new DateTime(d.Year,d.Month,d.Day,0,0,0)});

                return CommonFunctions.TryParseDecimal(val, 0);
            }
            catch (Exception ex)
            {
            }
            return 0;
        }
    }
}
