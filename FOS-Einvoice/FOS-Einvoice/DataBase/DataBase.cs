using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using FOS_Utils;
namespace FOS_Einvoice
{
    class DataBase
    {
        public System.Data.SqlClient.SqlConnection connection = null;
        public static ConnectionInfo connectionInfo = new ConnectionInfo();
        
        public DataBase()
        {
            connection = new System.Data.SqlClient.SqlConnection();
            connection.ConnectionString = "Data Source=" + connectionInfo.Server + "," + connectionInfo.Port
                + ";Network Library=DBMSSOCN;Initial Catalog=" + connectionInfo.DatabaseName
                + ";User ID=" + connectionInfo.User + ";Password=" + connectionInfo.Password;// +";Connection Timeout=1";
        }

        public static void SetConnectionInfo(string[] info) {
            connectionInfo.Server = info[0];
            connectionInfo.Port = info[1];
            connectionInfo.User = info[2];
            connectionInfo.Password = info[3];
            connectionInfo.DatabaseName = info[4];
        }
                
        public static SqlConnection GetConnection() 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=" + connectionInfo.Server + "," + connectionInfo.Port
                + ";Network Library=DBMSSOCN;Initial Catalog=" + connectionInfo.DatabaseName
                + ";User ID=" + connectionInfo.User + ";Password=" + connectionInfo.Password + ";";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "set lock_timeout 8000";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            return con;
        }
        public static string getIncrementBangouAndUpdateKaisya(String bangouMei, String tableName)
        {
            string result = "";
            try
            {                
                StringBuilder sql = new StringBuilder();
                sql.Append("  UPDATE ‰ïŽÐ SET " + bangouMei + " = ISNULL(" + bangouMei + ",0) + 1 WHERE ‰ïŽÐ”Ô† = 1");
                sql.Append(" ; ");
                sql.Append("  IF (SELECT ISNULL(MAX(" + bangouMei + "),0) AS '" + bangouMei + "' FROM " + tableName + " ) >=  ");
                sql.Append("  (SELECT ISNULL(" + bangouMei + ",0) FROM ‰ïŽÐ WHERE ‰ïŽÐ”Ô† = 1)  ");
                sql.Append("  BEGIN ");
                sql.Append("  	GOTO LOP ");
                sql.Append("  END ");
                sql.Append("  ELSE ");
                sql.Append("  BEGIN ");
                sql.Append("  	SELECT ISNULL(" + bangouMei + ",0) AS '" + bangouMei + "' ");
                sql.Append("  	FROM ‰ïŽÐ  WHERE ‰ïŽÐ”Ô† = 1");
                sql.Append(" 	GOTO FINISH ");
                sql.Append("  END  ");
                sql.Append("  LOP: ");
                sql.Append("  UPDATE ‰ïŽÐ SET " + bangouMei + " = ISNULL(" + bangouMei + ",0) + 1  WHERE ‰ïŽÐ”Ô† = 1");
                sql.Append(" IF (SELECT ISNULL(MAX(" + bangouMei + "),0) AS '" + bangouMei + "'  FROM " + tableName + " ) >=  ");
                sql.Append(" (SELECT ISNULL(" + bangouMei + ",0) FROM ‰ïŽÐ WHERE ‰ïŽÐ”Ô† = 1)  ");
                sql.Append("  BEGIN ");
                sql.Append("  	GOTO LOP ");
                sql.Append("  END  ");
                sql.Append("  ELSE ");
                sql.Append("  BEGIN ");
                sql.Append("  	SELECT ISNULL(" + bangouMei + ",0) AS '" + bangouMei + "' ");
                sql.Append("  	FROM ‰ïŽÐ  WHERE ‰ïŽÐ”Ô† = 1");
                sql.Append(" 	GOTO FINISH ");
                sql.Append("  END ");
                sql.Append(" FINISH: ");

                DataBase database = new DataBase();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                SqlCommand sqlCommand = database.connection.CreateCommand();
                sqlCommand.CommandText = sql.ToString();                
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    result = ds.Tables[0].Rows[0][0].ToString();
                }
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return result;
        }
        public static string getIncrementBangouAndUpdateKaisya(String bangouMei, String tableName, SqlConnection con,SqlTransaction tran)
        {
            string result = "";
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("  UPDATE ‰ïŽÐ SET " + bangouMei + " = ISNULL(" + bangouMei + ",0) + 1 WHERE ‰ïŽÐ”Ô† = 1");
                sql.Append(" ; ");
                sql.Append("  IF (SELECT ISNULL(MAX(" + bangouMei + "),0) AS '" + bangouMei + "' FROM " + tableName + " ) >=  ");
                sql.Append("  (SELECT ISNULL(" + bangouMei + ",0) FROM ‰ïŽÐ WHERE ‰ïŽÐ”Ô† = 1)  ");
                sql.Append("  BEGIN ");
                sql.Append("  	GOTO LOP ");
                sql.Append("  END ");
                sql.Append("  ELSE ");
                sql.Append("  BEGIN ");
                sql.Append("  	SELECT ISNULL(" + bangouMei + ",0) AS '" + bangouMei + "' ");
                sql.Append("  	FROM ‰ïŽÐ  WHERE ‰ïŽÐ”Ô† = 1");
                sql.Append(" 	GOTO FINISH ");
                sql.Append("  END  ");
                sql.Append("  LOP: ");
                sql.Append("  UPDATE ‰ïŽÐ SET " + bangouMei + " = ISNULL(" + bangouMei + ",0) + 1  WHERE ‰ïŽÐ”Ô† = 1");
                sql.Append(" IF (SELECT ISNULL(MAX(" + bangouMei + "),0) AS '" + bangouMei + "'  FROM " + tableName + " ) >=  ");
                sql.Append(" (SELECT ISNULL(" + bangouMei + ",0) FROM ‰ïŽÐ WHERE ‰ïŽÐ”Ô† = 1)  ");
                sql.Append("  BEGIN ");
                sql.Append("  	GOTO LOP ");
                sql.Append("  END  ");
                sql.Append("  ELSE ");
                sql.Append("  BEGIN ");
                sql.Append("  	SELECT ISNULL(" + bangouMei + ",0) AS '" + bangouMei + "' ");
                sql.Append("  	FROM ‰ïŽÐ  WHERE ‰ïŽÐ”Ô† = 1");
                sql.Append(" 	GOTO FINISH ");
                sql.Append("  END ");
                sql.Append(" FINISH: ");

                DataBase database = new DataBase();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();               
                SqlCommand sqlCommand = con.CreateCommand();
                sqlCommand.CommandText = sql.ToString();
                sqlCommand.Transaction = tran;
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    result = ds.Tables[0].Rows[0][0].ToString();
                }
                sqlCommand.Dispose();               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return result;
        }         
        public static System.Data.DataSet GetData(String sql)
        {
            DataSet ds = new DataSet();
            try
            {
                DataBase database = new DataBase();
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                SqlCommand sqlCommand = database.connection.CreateCommand();
                sqlCommand.CommandText = sql;
                //sqlCommand.CommandTimeout = 

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ds;
        }
        public static System.Data.DataSet GetData(String sql, SqlConnection con, SqlTransaction tran)
        {
            DataSet ds = new DataSet();
            try
            {                
                SqlCommand sqlCommand = con.CreateCommand();
                sqlCommand.CommandText = sql;
                sqlCommand.Transaction = tran;
                //sqlCommand.CommandTimeout = 

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
       
        public static DataRow GetRow(String sql)
        {
            DataSet ds = new DataSet();
            try
            {
                DataBase database = new DataBase();
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                SqlCommand sqlCommand = database.connection.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    return ds.Tables[0].Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }
        public static DataRow GetRow(String sql, SqlConnection con, SqlTransaction tran)
        {
            DataSet ds = new DataSet();
            try
            {                
                SqlCommand sqlCommand = con.CreateCommand();
                //sqlCommand.CommandTimeout =
                sqlCommand.CommandText = sql;
                sqlCommand.Transaction = tran;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();         
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    return ds.Tables[0].Rows[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
        public static object GetColumnValue(String sql, bool DbValueNull_ObjectNull)
        {            
            DataSet ds = new DataSet();
            try
            {
                DataBase database = new DataBase();
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                SqlCommand sqlCommand = database.connection.CreateCommand();
                //sqlCommand.CommandTimeout =
                sqlCommand.CommandText = sql;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    return ds.Tables[0].Rows[0][0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (DbValueNull_ObjectNull)
                return DBNull.Value;
            return null;
        }
        public static object[] GetColumnValues(String sql, bool DbValueNull_ObjectNull)
        {
            DataSet ds = new DataSet();
            object[] result = null;
            try
            {
                DataBase database = new DataBase();
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                SqlCommand sqlCommand = database.connection.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    result = new object[ds.Tables[0].Columns.Count];
                    for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                        result[i] = ds.Tables[0].Rows[0][i];
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (DbValueNull_ObjectNull)
                return result;
            return null;
        }
        public static object GetColumnValue(String sql, SqlConnection con, SqlTransaction tran)
        {
            DataSet ds = new DataSet();
            try
            {
                DataBase database = new DataBase();                
                SqlCommand sqlCommand = con.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                sqlCommand.Transaction = tran;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();                
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    return ds.Tables[0].Rows[0][0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return DBNull.Value;
        }
        public static object GetColumnValue(String sql, System.Collections.ArrayList paramName, System.Collections.ArrayList values)
        {
            DataBase database = new DataBase();
            DataSet ds = new DataSet();
            try
            {
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                SqlCommand sqlCommand = database.connection.CreateCommand();
                //sqlCommand.CommandTimeout =
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Count; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    return ds.Tables[0].Rows[0][0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }
        public static object GetColumnValue(String sql, string[] paramName, object[] values)
        {
            DataBase database = new DataBase();
            DataSet ds = new DataSet();
            try
            {
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                SqlCommand sqlCommand = database.connection.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Length; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    return ds.Tables[0].Rows[0][0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }
        public static System.Data.DataSet GetData(String sql, System.Collections.ArrayList paramName, System.Collections.ArrayList values)
        {
            DataBase database = new DataBase();
            DataSet ds = new DataSet();
            try
            {
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }                
                SqlCommand sqlCommand = database.connection.CreateCommand();
                //sqlCommand.CommandTimeout = 

                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Count; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ds;
        }
        public static System.Data.DataSet GetData(String sql, System.Collections.ArrayList paramName
            , System.Collections.ArrayList values
            , SqlConnection con, SqlTransaction tran)
        {
            DataBase database = new DataBase();
            DataSet ds = new DataSet();
            try
            {
                SqlCommand sqlCommand = con.CreateCommand();
                //sqlCommand.CommandTimeout =
                sqlCommand.CommandText = sql;
                sqlCommand.Transaction = tran;
                for (int i = 0; i < paramName.Count; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public static System.Data.DataSet GetData(String sql, object[] paramName, object[] values)
        {
            DataBase database = new DataBase();
            DataSet ds = new DataSet();
            try
            {
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }               
                SqlCommand sqlCommand = database.connection.CreateCommand();
                //sqlCommand.CommandTimeout =
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Length; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();
                adapter.Dispose();
                database.connection.Close();
                database.connection.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public static System.Data.DataSet GetData(String sql, string[] paramName, object[] values
            , SqlConnection con, SqlTransaction tran)
        {            
            DataSet ds = new DataSet();
            try
            {
                SqlCommand sqlCommand = con.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                sqlCommand.Transaction = tran;
                for (int i = 0; i < paramName.Length; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();
                adapter.Dispose();                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        
        public static System.Data.DataSet GetData(String sql, string[] paramName, object[] values
            , SqlDbType[] paramValueTypes
            , SqlConnection con, SqlTransaction tran)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand sqlCommand = con.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                sqlCommand.Transaction = tran;
                for (int i = 0; i < paramName.Length; i++)
                {
                    SqlParameter sqlParam = new SqlParameter();
                    sqlParam.SqlDbType = paramValueTypes[i];
                    sqlParam.ParameterName = paramName[i].ToString();
                    sqlParam.Value = values[i];
                    sqlCommand.Parameters.Add(sqlParam);                    
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();
                adapter.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }    
              
        public static void ExecuteSQL(String sql)
        {
            try
            {
                DataBase database = new DataBase();
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                SqlCommand sqlCommand = database.connection.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void ExecuteSQL(String sql, SqlConnection con, SqlTransaction tran)
        {
            try
            {
                DataBase database = new DataBase();               
                SqlCommand sqlCommand = con.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                sqlCommand.Transaction = tran;
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void ExecuteSQL(String sql, bool createTransaction)
        {
            SqlTransaction tran = null;
            try
            {
                DataBase database = new DataBase();
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                if (createTransaction)
                    tran = database.connection.BeginTransaction();
                SqlCommand sqlCommand = database.connection.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                sqlCommand.Transaction = tran;
                sqlCommand.ExecuteNonQuery();
                tran.Commit();
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                    tran.Dispose();
                }
                MessageBox.Show(ex.ToString());
            }
        }
        public static void ExecuteSQL(String sql, System.Collections.ArrayList paramName, System.Collections.ArrayList values)
        {
            try
            {
                DataBase database = new DataBase();
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                SqlCommand sqlCommand = database.connection.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Count; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else if (values[i] == null || values[i].ToString().Length == 0)
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", DBNull.Value);
                    else
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);  
                }
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        public static void ExecuteSQL(String sql, System.Collections.ArrayList paramName
            , System.Collections.ArrayList values
            , SqlDbType[] paramDbType
            , System.Data.SqlClient.SqlConnection con, System.Data.SqlClient.SqlTransaction tran)
        {
            try
            {
                SqlCommand sqlCommand = con.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Count; i++)
                {
                    SqlParameter sqlParam = new SqlParameter();
                    sqlParam.ParameterName = paramName[i].ToString();
                    sqlParam.SqlDbType = paramDbType[i];
                    if (values[i] == null || values[i].ToString().Length == 0)
                        sqlParam.Value = DBNull.Value;
                    else
                        sqlParam.Value = values[i];
                    sqlCommand.Parameters.Add(sqlParam);
                }
                sqlCommand.Transaction = tran;
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int ExecuteSQL(String sql, System.Collections.ArrayList paramName
            , System.Collections.ArrayList values
            , System.Data.SqlClient.SqlConnection con, System.Data.SqlClient.SqlTransaction tran)
        {
            int result = 0;
            try
            {
                SqlCommand sqlCommand = con.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Count; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else if (values[i] == null || values[i].ToString().Length == 0)
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", DBNull.Value);
                    else
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);  
                }
                sqlCommand.Transaction = tran;
                result =  sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();                
            }
            catch (Exception ex)
            {
                throw ex;
                result = -1;
            }
            return result;
        }
        public static void ExecuteSQL(String sql, System.Collections.ArrayList paramName, System.Collections.ArrayList values, bool createTransaction)
        {
            SqlTransaction tran = null;
            try
            {
                DataBase database = new DataBase();                
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                if (createTransaction)
                    tran = database.connection.BeginTransaction();

                SqlCommand sqlCommand = database.connection.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Count; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else if (values[i] == null || values[i].ToString().Length == 0)
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", DBNull.Value);
                    else
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);  
                }
                sqlCommand.Transaction = tran;
                sqlCommand.ExecuteNonQuery();
                tran.Commit();
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ExecuteSQL(String sql, string[] paramName, object[] values)
        {
            try
            {
                DataBase database = new DataBase();
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                SqlCommand sqlCommand = database.connection.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Length; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else if (values[i] == null || values[i].ToString().Length == 0)
                            sqlCommand.Parameters.AddWithValue(paramName[i] + "", DBNull.Value);
                        else
                            sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);                    
                }
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ExecuteSQL(String sql, string[] paramName, ArrayList values)
        {
            try
            {
                DataBase database = new DataBase();
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                SqlCommand sqlCommand = database.connection.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Length; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else if (values[i] == null || values[i].ToString().Length == 0)
                            sqlCommand.Parameters.AddWithValue(paramName[i] + "", DBNull.Value);
                        else
                            sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);
                }
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ExecuteSQL(String sql, string[] paramName, object[] values, bool createTransaction)
        {
            SqlTransaction tran = null;
            try
            {
                DataBase database = new DataBase();
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                if (createTransaction)
                    tran = database.connection.BeginTransaction();
                SqlCommand sqlCommand = database.connection.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Length; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else if (values[i] == null || values[i].ToString().Length == 0)
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", DBNull.Value);
                    else
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);   
                }
                sqlCommand.Transaction = tran;
                sqlCommand.ExecuteNonQuery();
                tran.Commit();
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                    tran.Dispose();
                }
                throw ex;
            }
        }
        public static int ExecuteSQL(string sql, string[] paramName, object[] values
            , System.Data.SqlClient.SqlConnection con, System.Data.SqlClient.SqlTransaction tran )
        {
            int result = 0;
            try
            {
                SqlCommand sqlCommand = con.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Length; i++)
                {
                    if (values[i] == null || values[i].ToString().Length == 0)
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", DBNull.Value);
                    else if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);                         
                }
                sqlCommand.Transaction = tran;
                result = sqlCommand.ExecuteNonQuery();                
                sqlCommand.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
                result = -1;
            }
            return result;
        }
        public static bool ExecuteSQL(string sql, string[] paramName, ArrayList values
            , System.Data.SqlClient.SqlConnection con, System.Data.SqlClient.SqlTransaction tran)
        {
            try
            {
                SqlCommand sqlCommand = con.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Length; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else if (values[i] == null || values[i].ToString().Length == 0)
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", DBNull.Value);
                    else
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);   
                }
                sqlCommand.Transaction = tran;
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool ExecuteSQL(string sql, string[] paramNames, object[] values, SqlDbType [] paramDbTypes
           , System.Data.SqlClient.SqlConnection con, System.Data.SqlClient.SqlTransaction tran)
        {
            try
            {
                SqlCommand sqlCommand = con.CreateCommand();
                //sqlCommand.CommandTimeout = 
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramNames.Length; i++)
                {
                    SqlParameter sqlParam = new SqlParameter();
                    sqlParam.SqlDbType = paramDbTypes[i];
                    sqlParam.ParameterName = paramNames[i];
                    if (values[i] == null || values[i].ToString().Length == 0)
                        sqlParam.Value = DBNull.Value;                    
                    else
                        sqlParam.Value = values[i];                    
                    sqlCommand.Parameters.Add(sqlParam);
                }
                sqlCommand.Transaction = tran;
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public static bool TestConnection()
        {
            try
            {
                DataBase database = new DataBase();                                
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                database.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối với cơ sở dữ liệu.");  
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public static bool CheckHaveData(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                DataBase database = new DataBase();
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                SqlCommand sqlCommand = database.connection.CreateCommand();
                sqlCommand.CommandText = sql;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();
                database.connection.Close();
                database.connection.Dispose();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return false;
        }
        public static bool CheckHaveData(String sql, object[] paramName, object[] values)
        {
            DataBase database = new DataBase();
            DataSet ds = new DataSet();
            try
            {
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                SqlCommand sqlCommand = database.connection.CreateCommand();
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Length; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);
                }

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();
                adapter.Dispose();
                database.connection.Close();
                database.connection.Dispose();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return false;
        }
        public static bool CheckHaveData(String sql, ArrayList paramName, ArrayList values)
        {
            DataBase database = new DataBase();
            DataSet ds = new DataSet();
            try
            {
                if (database.connection.State == System.Data.ConnectionState.Closed)
                {
                    database.connection.Open();
                }
                SqlCommand sqlCommand = database.connection.CreateCommand();
                sqlCommand.CommandText = sql;
                for (int i = 0; i < paramName.Count; i++)
                {
                    if (values[i].GetType().Name.ToUpper().Equals("BYTE[]") || paramName[i].ToString().Contains("IMAGE"))
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]).SqlDbType = SqlDbType.Image;
                    else
                        sqlCommand.Parameters.AddWithValue(paramName[i] + "", values[i]);
                }

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(ds);
                sqlCommand.Dispose();
                adapter.Dispose();
                database.connection.Close();
                database.connection.Dispose();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        #region Data_insert_update_delete       

        public static int Insert(string TableName, string[] colnames, object[] values, SqlConnection con, SqlTransaction tran)
        {
            int result = 0;
            try
            {
                string sql = " insert into " + TableName + " ( ";
                string sqlValues = " values ( ";
                for (int i = 0; i < colnames.Length; i++)
                {
                    if (i > 0)
                    {
                        sql += " , ";
                        sqlValues += " , ";
                    }
                    sql += colnames[i];
                    sqlValues += "@" + colnames[i];
                    colnames[i] = "@" + colnames[i];
                }
                sql += " ) " + sqlValues + " ) ";
                result = DataBase.ExecuteSQL(sql, colnames, values, con, tran);
            }
            catch (Exception ex)
            {
                result = -1;
            }
            return result;
        }

        public static int Update(string TableName, string[] primayColNames,object[] primaryValues,
            string[] colnames, object[] values, SqlConnection con, SqlTransaction tran)
        {
            int result = 0;
            try
            {
                ArrayList paramNames = new ArrayList();
                ArrayList paramValues = new ArrayList();
                string sql = " update " + TableName + " set ";
                for (int i = 1; i < colnames.Length; i++)
                {
                    if (i > 0)
                    {
                        sql += " , ";
                    }
                    sql += colnames[i] + " = @" + colnames[i];
                    colnames[i] = "@" + colnames[i];
                }
                //Primary key
                sql += " where ";
                for (int i = 0; i < primayColNames.Length; i++)
                {
                    if (i > 0) sql += " and ";
                    sql += primayColNames[i] + " = @" + primayColNames[i];
                    primayColNames[i] = "@" + primayColNames[i];
                }

                paramNames.AddRange(colnames);
                paramValues.AddRange(values);
                paramNames.AddRange(primayColNames);
                paramValues.AddRange(primaryValues);
                result = DataBase.ExecuteSQL(sql, paramNames, paramValues, con, tran);
            }
            catch (Exception ex)
            {
                result = -1;
            }
            return result;
        }

        public int Delete(string TableName,string[] primaryColNames,object[] primaryValues
            , SqlConnection con, SqlTransaction tran)
        {
            int result = 0;
            try
            {
                string sql = " delete from " + TableName;
                sql += " where ";

                for (int i = 0; i < primaryColNames.Length; i++)
                {
                    if (i > 0) sql += " and ";
                    sql += primaryColNames[i] + " = @" + primaryColNames[i];
                    primaryColNames[i] = "@" + primaryColNames[i];
                }

                result = DataBase.ExecuteSQL(sql,primaryColNames,primaryValues, con, tran);
            }
            catch (Exception ex)
            {
                result = -1;
            }
            return result;
        }

        public static int Insert(string TableName, ArrayList ctrlPrimary, ArrayList ctrlData
            ,string[] otherColNames,object[] otherValues
            ,string[] getdateColNames
            , SqlConnection con, SqlTransaction tran)
        {
            int result = 0;
            try
            {
                ArrayList paramNames = new ArrayList();
                ArrayList paramValues = new ArrayList();
                IControl c = null;
                string sql = " insert into " + TableName + " ( ";
                string sqlValues = " values ( ";
                for (int i = 0; i < ctrlData.Count; i++)
                {
                    if (i > 0)
                    {
                        sql += " , ";
                        sqlValues += " , ";
                    }
                    c = ctrlData[i] as IControl;
                    sql += c.ColumnName;
                    sqlValues += "@" + c.ColumnName;
                    paramNames.Add("@" + c.ColumnName);
                    paramValues.Add(c.DBValue);
                }
                for (int i = 0; i < ctrlPrimary.Count; i++)
                {
                    sql += " , ";
                    sqlValues += " , ";
                    c = ctrlPrimary[i] as IControl;
                    sql += c.ColumnName;
                    sqlValues += "@" + c.ColumnName;
                    paramNames.Add("@" + c.ColumnName);
                    paramValues.Add(c.DBValue);
                }

                if (otherColNames != null && otherValues != null)
                {
                    for (int i = 0; i < otherColNames.Length; i++)
                    {
                        sql += " , ";
                        sqlValues += " , ";

                        sql += otherColNames[i];
                        sqlValues += "@" + otherColNames[i];
                        paramNames.Add("@" + otherColNames[i]);
                        paramValues.Add(otherValues[i]);
                    }
                }

                if (getdateColNames != null)
                {
                    for (int i = 0; i < getdateColNames.Length; i++)
                    {
                        sql += " , " + getdateColNames[i];
                        sqlValues += " , getdate() ";
                    }
                }

                sql += " ) " + sqlValues + " ) ";
                result = DataBase.ExecuteSQL(sql, paramNames, paramValues, con, tran);
            }
            catch (Exception ex)
            {
                result = -1;
            }
            return result;
        }

        public static int Update(string TableName, ArrayList ctrlPrimary, ArrayList ctrlData
            , string[] otherColNames, object[] otherValues
            , string[] getdateColNames
            , SqlConnection con, SqlTransaction tran)
        {
            int result = 0;
            try
            {
                ArrayList paramNames = new ArrayList();
                ArrayList paramValues = new ArrayList();
                string sql = " update " + TableName + " set ";
                IControl c = null;
                for (int i = 0; i < ctrlData.Count; i++)
                {
                    if (i > 0)
                    {
                        sql += " , ";
                    }
                    c = ctrlData[i] as IControl;
                    sql += c.ColumnName + " = @" + c.ColumnName;
                    paramNames.Add("@" + c.ColumnName);
                    paramValues.Add(c.DBValue);
                }
                if (otherColNames != null && otherValues != null)
                {
                    for (int i = 0; i < otherColNames.Length; i++)
                    {
                        sql += "," + otherColNames[i] + " = @" + otherColNames[i];
                        paramNames.Add("@" + otherColNames[i]);
                        paramValues.Add(otherValues[i]);
                    }
                }
                if (getdateColNames != null)
                {
                    for (int i = 0; i < getdateColNames.Length; i++)
                    {
                        sql += "," + getdateColNames[i] + " = getdate() ";
                    }
                }
                //Primary key
                sql += " where ";
                for (int i = 0; i < ctrlPrimary.Count; i++)
                {
                    if (i > 0) sql += " and ";
                    c = ctrlPrimary[i] as IControl;
                    sql += c.ColumnName + " = @" + c.ColumnName;
                    paramNames.Add("@" + c.ColumnName);
                    paramValues.Add(c.DBValue);
                }               
                result = DataBase.ExecuteSQL(sql, paramNames, paramValues, con, tran);
            }
            catch (Exception ex)
            {
                result = -1;
            }
            return result;
        }
        #endregion
    }
}
