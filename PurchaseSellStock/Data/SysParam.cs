using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Management;
using System.Security.Cryptography;

namespace PurchaseSellStock.Data
{
    class SysParam
    {
        public static string GetValue(string strName, string strDefault="")
        {
            string sql = "SELECT value FROM Params WHERE name=@Name;";
            List<SQLiteParameter> cmdParams = new List<SQLiteParameter>()
            {
                new SQLiteParameter("Name",strName)
            };
            DataTable dt = DBAdapter.Select(sql, cmdParams);
            if (dt == null)
                return strDefault;

            if (dt.Rows.Count <= 0)
                return strDefault;

            return dt.Rows[0]["value"].ToString();
        }
        public static bool GetValueBool(string strName, bool bDefault = false)
        {
            string strRet = GetValue(strName);
            if (string.IsNullOrEmpty(strRet))
                return bDefault;
            bool ret;
            if (bool.TryParse(strRet, out ret))
                return ret;
            return bDefault;
        }
        public static int GetValueInt(string strName, int nDefault = 0)
        {
            string strRet = GetValue(strName);
            if (string.IsNullOrEmpty(strRet))
                return nDefault;
            int ret;
            if (int.TryParse(strRet, out ret))
                return ret;
            return nDefault;
        }

        public static int SetValue(string strName, string strValue)
        {
            string sql = "SELECT value FROM Params WHERE name=@Name;";
            List<SQLiteParameter> cmdParams = new List<SQLiteParameter>()
            {
                new SQLiteParameter("Name",strName),
            };
            DataTable dt = DBAdapter.Select(sql, cmdParams);
            if (dt == null)
                return -1;

            if (dt.Rows.Count <= 0)
            {
                sql = "INSERT INTO Params (name,value) VALUES (@Name,@Value);";
                cmdParams.Clear();
                cmdParams.Add(new SQLiteParameter("Name", strName));
                cmdParams.Add(new SQLiteParameter("Value", strValue));
                return DBAdapter.Execute(sql, cmdParams);
            }
            else
            {
                sql = "UPDATE Params SET value=@Value WHERE name=@Name;";
                cmdParams.Clear();
                cmdParams.Add(new SQLiteParameter("Name", strName));
                cmdParams.Add(new SQLiteParameter("Value", strValue));
                return DBAdapter.Execute(sql, cmdParams);
            }
              
        }

        public static int SetValueBool(string strName, bool Value)
        {
            return SetValue(strName,Value.ToString());
        }
        public static int SetValueInt(string strName, int Value)
        {
            return SetValue(strName, Value.ToString());
        }

        public static string GetMachineSerial(string ID)
        {
            string strRet = "";
            ManagementClass mcls = new ManagementClass("Win32_Processor");
            foreach (ManagementObject mo in mcls.GetInstances())
            {
                try
                {
                    strRet = mo.Properties["ProcessorId"].Value.ToString();
                }
                catch { }
            }
            if (string.IsNullOrEmpty(strRet))
                return "";

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytValue, bytHash;
            bytValue = System.Text.Encoding.UTF8.GetBytes(strRet+"%&2014");
            bytHash = md5.ComputeHash(bytValue);
            md5.Clear();

            string sTemp = "";
            for (int i = 0; i < bytHash.Length; i++)
            {
                sTemp += bytHash[i].ToString("X").PadLeft(2, '0').Substring(1);
                if (i == 3 || i == 7 || i == 11)
                    sTemp += "-";

            }
            sTemp += "-";
            sTemp += ID;
            return sTemp.ToUpper();
            
        }


    }
}
