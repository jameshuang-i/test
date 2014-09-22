using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace PurchaseSellStock.Data
{
    public class DBAdapter
    {
        private static SQLiteConnection _cnn = null;
        private static string _Err = "";
        private const int TIMEOUT = 180;
        private const string DATA_1 = "JamesHuang";

        public static string GetLastErr
        {
            get{ return _Err;}
        }

        public static SQLiteConnection Connect
        {
            get
            {
                if (_cnn == null)
                {
                    try
                    {
                        _cnn = new SQLiteConnection("Data Source=Data.s3db;Version=3;Password=" + DATA_1);
                        _cnn.Open();
                    }
                    catch (Exception e)
                    {
                        _Err = e.Message;
                        _cnn = null;
                    }
                }
                return _cnn;
            }
        }

        public static void Close()
        {
            if (_cnn != null)
                _cnn.Close();
            _cnn = null;
        }

        public static DataTable Select(string sql, IList<SQLiteParameter> cmdparams = null)
        {
            SQLiteConnection cnn = Connect;
            if (cnn == null)
                return null;
            DataTable dt = new DataTable();
            SQLiteCommand Comm = null;
            SQLiteDataReader Reader = null;
            try
            {
                Comm = new SQLiteCommand(cnn);
                Comm.CommandText = sql;
                if (cmdparams != null)
                    Comm.Parameters.AddRange(cmdparams.ToArray());
                Comm.CommandTimeout = TIMEOUT;
                Reader = Comm.ExecuteReader();
                dt.Load(Reader);
            }
            catch (Exception e)
            {
                _Err = e.Message;
                return null;
            }
            finally
            {
                if (Reader != null)
                    Reader.Close();
                if (Comm != null)
                    Comm.Dispose();
            }
            return dt;
        }

        public static int Execute(string sql, IList<SQLiteParameter> cmdparams = null)
        {
            int nRet = -1;

            SQLiteConnection cnn = Connect;
            if (cnn == null)
                return nRet;

            using (SQLiteTransaction Trans = cnn.BeginTransaction())
            {
                SQLiteCommand Comm = null;
                try
                {
                    Comm = new SQLiteCommand(sql, cnn, Trans);
                    if (cmdparams != null)
                        Comm.Parameters.AddRange(cmdparams.ToArray());
                    Comm.CommandTimeout = TIMEOUT;
                    nRet = Comm.ExecuteNonQuery();
                    Trans.Commit();
                }
                catch (Exception e)
                {
                    Trans.Rollback();
                    _Err = e.Message;
                    nRet = -1;
                }
                finally
                {
                    if (Comm != null)
                        Comm.Dispose();
                }
            }
            return nRet;
        }

        /*
        public static string StrEncode(string defaultString)
        {
            if (defaultString == null)
                return null;
            byte[] bytes = Encoding.Default.GetBytes(defaultString);
            return Encoding.UTF8.GetString(bytes);
        }

        public static string StrDecode(string defaultString)
        {
            if (defaultString == null)
                return null;
            byte[] bytes = Encoding.UTF8.GetBytes(defaultString);
            return Encoding.Default.GetString(bytes);
        }
        */
    }
}
