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

        public static decimal TryParseDecimal(object val, decimal defaultVal)
        {
            decimal result = defaultVal;
            try
            {
                decimal.TryParse(val.ToString(), out result);
            }
            catch (Exception ex)
            {
            }
            return result;
        }

        public static string NumberToTextVN(decimal total)
        {
            try
            {
                if (total <= 0) return "";

                string rs = "";
                total = Math.Round(total, 0);
                string[] ch = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                string[] rch = { "lẻ", "mốt", "", "", "", "lăm" };
                string[] u = { "", "mươi", "trăm", "ngàn", "", "", "triệu", "", "", "tỷ", "", "", "ngàn", "", "", "triệu" };
                string nstr = total.ToString();

                int[] n = new int[nstr.Length];
                int len = n.Length;
                for (int i = 0; i < len; i++)
                {
                    n[len - 1 - i] = Convert.ToInt32(nstr.Substring(i, 1));
                }

                for (int i = len - 1; i >= 0; i--)
                {
                    if (i % 3 == 2)// số 0 ở hàng trăm
                    {
                        if (n[i] == 0 && n[i - 1] == 0 && n[i - 2] == 0) continue;//nếu cả 3 số là 0 thì bỏ qua không đọc
                    }
                    else if (i % 3 == 1) // số ở hàng chục
                    {
                        if (n[i] == 0)
                        {
                            if (n[i - 1] == 0) { continue; }// nếu hàng chục và hàng đơn vị đều là 0 thì bỏ qua.
                            else
                            {
                                rs += " " + rch[n[i]]; continue;// hàng chục là 0 thì bỏ qua, đọc số hàng đơn vị
                            }
                        }
                        if (n[i] == 1)//nếu số hàng chục là 1 thì đọc là mười
                        {
                            rs += " mười"; continue;
                        }
                    }
                    else if (i != len - 1)// số ở hàng đơn vị (không phải là số đầu tiên)
                    {
                        if (n[i] == 0)// số hàng đơn vị là 0 thì chỉ đọc đơn vị
                        {
                            if (i + 2 <= len - 1 && n[i + 2] == 0 && n[i + 1] == 0) continue;
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        if (n[i] == 1)// nếu là 1 thì tùy vào số hàng chục mà đọc: 0,1: một / còn lại: mốt
                        {
                            rs += " " + ((n[i + 1] == 1 || n[i + 1] == 0) ? ch[n[i]] : rch[n[i]]);
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        if (n[i] == 5) // cách đọc số 5
                        {
                            if (n[i + 1] != 0) //nếu số hàng chục khác 0 thì đọc số 5 là lăm
                            {
                                rs += " " + rch[n[i]];// đọc số 
                                rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);// đọc đơn vị
                                continue;
                            }
                        }
                    }

                    rs += (rs == "" ? " " : ", ") + ch[n[i]];// đọc số
                    rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);// đọc đơn vị
                }
                if (rs[rs.Length - 1] != ' ')
                    rs += " đồng";
                else
                    rs += "đồng";

                if (rs.Length > 2)
                {
                    string rs1 = rs.Substring(0, 2);
                    rs1 = rs1.ToUpper();
                    rs = rs.Substring(2);
                    rs = rs1 + rs;
                }
                return rs.Trim().Replace("lẻ,", "lẻ").Replace("mươi,", "mươi").Replace("trăm,", "trăm").Replace("mười,", "mười");
            }
            catch
            {
                return "";
            }
        }
    }
}
