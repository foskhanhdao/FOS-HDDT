using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace FOS_Einvoice
{
    public class CommonFunctions
    {
        public static string Encode(string str)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encbuff);
        }
        public static string Decode(string str)
        {
            byte[] decbuff = Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(decbuff);
        }

        public static void SaveConnectionFileInfo(string[] val)
        {
            TextWriter tw = null;
            try
            {
                string filename = Application.StartupPath + "\\" + Constants.FILE_NAME_CONNECTION;

                tw = new StreamWriter(filename, false, Encoding.BigEndianUnicode);
                for (int i = 0; i < val.Length; i++)
                {
                    tw.WriteLine(Encode(val[i]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (tw != null)
                {
                    tw.Flush();
                    tw.Close();
                }
            }
        }

        public static string[] ReadConnectionFileInfo()
        {
            string server = "";
            string port = "";
            string user = "";
            string password = "";
            string databaseName = "";
            string serverAddress = "";
            TextReader tr = null;
            try
            {
                string filename = Application.StartupPath + "\\" + Constants.FILE_NAME_CONNECTION;
                if (File.Exists(filename))
                {
                    tr = new StreamReader(filename, Encoding.BigEndianUnicode);
                    String line = "";

                    if ((line = tr.ReadLine()) != null)
                    {
                        server = Decode(line);
                    }
                    if ((line = tr.ReadLine()) != null)
                    {
                        port = Decode(line);
                    }
                    if ((line = tr.ReadLine()) != null)
                    {
                        user = Decode(line);
                    }
                    if ((line = tr.ReadLine()) != null)
                    {
                        password = Decode(line);
                    }
                    if ((line = tr.ReadLine()) != null)
                    {
                        databaseName = Decode(line);
                    }
                    if ((line = tr.ReadLine()) != null)
                    {
                        serverAddress = Decode(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (tr != null)
                {
                    tr.Close();
                    tr.Dispose();
                }
            }
            return new string[] { server, port, user, password, databaseName, serverAddress };
        }

        public static void SetEnableControls(ArrayList ctrlList,bool en )
        {
            try
            {
                Control c = null;
                for (int i = 0; i < ctrlList.Count; i++)
                {
                    c = ctrlList[i] as Control;
                    if (c != null) c.Enabled = en;
                }
            }
            catch (Exception ex)
            {
            }
        }
        public static void ClearControls(ArrayList ctrlList)
        {
            try
            {
                Control c = null;
                for (int i = 0; i < ctrlList.Count; i++)
                {
                    c = ctrlList[i] as Control;
                    if (c != null) c.Text = "";
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
