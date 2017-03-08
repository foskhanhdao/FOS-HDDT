using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FOS_Einvoice.TableInfo
{
    public class TableInvoice
    {
        public const decimal TYPE_CODE = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param">
        /// [0]:invoicecodefrom
        /// [1]:invoicecodeto
        /// [2]:invoicesymbol1
        /// [3]:invoicesymbol2
        /// [4]:invoicesymbol3
        /// [5]:invoicetemplate
        /// [6]:invoiceusercode
        /// [7]:invoiceusername
        /// </param>
        /// <returns></returns>
        public static bool Init(object[] param)
        {
            SqlConnection con = null;
            SqlTransaction tran = null;
            bool result = true;
            try
            {
                decimal codefrom = CommonFunctions.TryParseDecimal(param[0], 0);
                decimal codeto = CommonFunctions.TryParseDecimal(param[1], 0);
                string symbol1 = param[2].ToString();
                string symbol2 = param[3].ToString();
                string symbol3 = param[4].ToString();
                string temp = param[5].ToString();
                string usercode = param[6].ToString();
                string username = param[7].ToString();

                string sql = " insert into invoice (invoicecode,invoicesymbol1,invoicesymbol2,invoicesymbol3 ";
                sql += ",invoicetypecode,invoicetemplate,invoicedateinit,invoiceusercode,invoiceusername)";
                sql += " values (@invoicecode,@invoicesymbol1,@invoicesymbol2,@invoicesymbol3 ";
                sql += ",@invoicetypecode,@invoicetemplate,getdate(),@invoiceusercode,@invoiceusername)";

                con = DataBase.GetConnection();
                tran = con.BeginTransaction();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    cmd.Transaction = tran;
                    for (decimal i = codefrom; i <= codeto; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@invoicecode", i.ToString("0000000"));
                        cmd.Parameters.AddWithValue("@invoicesymbol1", symbol1);
                        cmd.Parameters.AddWithValue("@invoicesymbol2", symbol2);
                        cmd.Parameters.AddWithValue("@invoicesymbol3", symbol3);
                        cmd.Parameters.AddWithValue("@invoicetypecode", TYPE_CODE);
                        cmd.Parameters.AddWithValue("@invoicetemplate", temp);
                        cmd.Parameters.AddWithValue("@invoiceusercode", usercode);
                        cmd.Parameters.AddWithValue("@invoiceusername", username);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                    tran.Dispose();
                    tran = null;
                }
                result = false;
            }
            finally
            {
                if (tran != null)
                {
                    tran.Commit();
                    tran.Dispose();
                    tran = null;
                }
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                    con = null;
                }
            }
            return result;
        }
    }
}
