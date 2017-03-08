using System;

namespace FOS_SK
{
    public class InvoiceKeys:IDisposable
    {
        public string invoicecodefrom = "";
        public string invoicecodeto = "";
        public string symbol1 = "";
        public string symbol2 = "";
        public string symbol3 = "";
        public string cuscode = "";
        
        public void GetKeys(string serialnumber)
        {
            try
            {
                string val = EncodeDecode.Decode(serialnumber);
                if (val.Length > 19)
                {
                    val = val.Substring(1);
                    invoicecodefrom = val.Substring(0, 7);
                    invoicecodeto = val.Substring(7, 7);
                    symbol1 = val.Substring(14, 2);
                    symbol2 = val.Substring(16, 2);
                    symbol3 = val.Substring(18, 1);
                    cuscode = val.Substring(19);
                }
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param">
        /// [0]:invoicecodefrom
        /// [1]:invoicecodeto
        /// [2]:symbol1
        /// [3]:symbol2
        /// [4]:symbol3
        /// [5]:invoicecuscode
        /// </param>
        /// <returns></returns>
        public string Create(string[] param)
        {
            string result = "";
            try
            {
                string codefrom = param[0].Trim().PadLeft(7,'0');
                string codeto = param[1].Trim().PadLeft(7,'0');
                string sym1 = param[2].Trim();
                string sym2 = param[3].Trim();
                string sym3 = param[4].Trim();
                string cus = param[5].Trim();

                result = new Random().Next(0,9)
                    + codefrom
                    + codeto
                    + sym1
                    + sym2
                    + sym3
                    + cus;

                result = EncodeDecode.Encode(result);
            }
            catch (Exception ex)
            {
            }
            return result;
        }

        #region IDisposable Members

        public void Dispose()
        {
            
        }

        #endregion
    }       

}
