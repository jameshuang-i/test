using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace PurchaseSellStock.Data
{
    public class User
    {
        private static string _UserName = "";
        private static int _Role = -1;
        private static string _ErrMsg = "";

        public static string GetLastErr
        {
            get { return _ErrMsg; }
        }

        public static string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
                string sql = "SELECT role FROM User WHERE name=@Name;";
                List<SQLiteParameter> cmdParams = new List<SQLiteParameter>()
                {
                    new SQLiteParameter("Name",value),
                };
                DataTable dt = DBAdapter.Select(sql, cmdParams);
                if (dt != null && dt.Rows.Count>0)
                {
                    _Role=Convert.ToInt32(dt.Rows[0]["role"]);
                }
            }
        }
        
        public static bool Vaild(string strName,string strPwd)
        {
            string sql="SELECT role FROM User WHERE name=@Name AND password=@Password;";
            List<SQLiteParameter> cmdParams=new List<SQLiteParameter>()
            {
                new SQLiteParameter("Name",strName),
                new SQLiteParameter("Password",strPwd)
            };
            DataTable dt = DBAdapter.Select(sql, cmdParams);
            if (dt == null)
            {
                _ErrMsg = DBAdapter.GetLastErr;
                return false;
            }

            if (dt.Rows.Count <= 0)
            {
                _ErrMsg = "用户密码错误！";
                return false;
            }

            _UserName = strName;
            _Role = Convert.ToInt32(dt.Rows[0]["role"]);
            return true;
        }

        public static List<string> GetUserList()
        {
            List<string> ret = new List<string>();
            string sql = "SELECT name FROM User;";
            DataTable dt = DBAdapter.Select(sql);
            if (dt == null)
                return ret;

            for (int i = 0; i < dt.Rows.Count; i++)
                ret.Add(dt.Rows[i][0].ToString());

            return ret;
        }
    }
}
