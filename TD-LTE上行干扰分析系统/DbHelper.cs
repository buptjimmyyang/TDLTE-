using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Data;

namespace TD_LTE上行干扰分析系统
{
    /// <summary>
    /// DbHelper类为数据库连接类
    /// 需要在appconfig中读取数据库的配置文件
    /// </summary>
    class DbHelper
    {
        private static DbHelper instance;
        private static readonly object syncRoot = new object();
        private static string connStr;
        private static SqlConnection conn = null;
        private string userName;
        private string passWd;
        private string serverIp;
        private bool login = false;

        private DbHelper()
        {
            // connStr = @"Data Source=server;Initial Catalog=database;User ID=uid;Pwd=passwd;Connect Timeout=500000;Pooling=False;";
            //connStr = connStr.Replace("server", ConfigurationManager.AppSettings["server"]);
            //connStr = connStr.Replace("database", ConfigurationManager.AppSettings["database"]);
            //connStr = connStr.Replace("uid", ConfigurationManager.AppSettings["uid"]);
            //connStr = connStr.Replace("passwd", ConfigurationManager.AppSettings["pwd"]);
            //ConfigurationManager.AppSettings["pwd"] = "";
        }
        public static DbHelper getInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new DbHelper();
                    }
                }
            }
            return instance;
        }
        //登陆时使用
        public void InitParams(string Ip, string Name, string pwd)
        {
            serverIp = Ip;
            userName = Name;
            passWd = pwd;
        }
        //获取链接字符串
        public string getConnStr(string dbname)
        {
            if (serverIp == "localhost" && userName == "null" && passWd == "null")
                connStr = "data source=(local);integrated security=SSPI;initial catalog=" + dbname + ";Max Pool Size = 1024";

            if (serverIp != "localhost" && userName == "null" && passWd == "null")
                connStr = "data source=" + serverIp + ";integrated security=SSPI;initial catalog=" + dbname + ";Max Pool Size = 1024";

            if (serverIp == "localhost" && userName != "null" && passWd != "null")
                connStr = "data source=(local);user id=" + userName + ";password =" + passWd + ";initial catalog=" + dbname + ";Max Pool Size = 1024";

            if (serverIp != "localhost" && userName != "null" && passWd != "null")
                connStr = "data source=" + serverIp + ";user id=" + userName + ";password =" + passWd + ";initial catalog=" + dbname + ";Max Pool Size = 1024";
            return connStr;
        }
        //数据库连接判断
        public bool isLogin()
        {
            SqlConnection conn = getConn(getConnStr("master"));
            if (conn != null)
            {
                login = true;
                conn.Close();
            }
            else
                login = false;

            return login;

        }

        //其他位置判断是否连接
        public bool isLoginSql()
        {
            return login;
        }

        public SqlConnection getConn(string connstr)
        {
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                return conn;
            }
            catch (Exception e)
            {
                MessageBox.Show("数据库连接失败");
                conn = null;
                return conn;
            }


        }
        //建立数据库时使用
        public SqlConnection getConn()
        {
            string connStr;
            if (userName != "null")
                connStr = "server=" + serverIp + "; uid=" + userName + "; pwd=" + passWd;
            else
                connStr = "data source=" + serverIp + ";integrated security=SSPI;Max Pool Size = 1024";
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }

        //执行数据库创建插入语句
        public bool execSql(string sqlInsert, SqlConnection conn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlInsert;
                cmd.CommandTimeout = 5000000;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }
        //判断是否包含管理数据库
        public bool existGuard()
        {
            string sql = "select * from master..sysdatabases where name='" + NameUnit.getName(NameUnit.guradDb) + "'";
            SqlConnection conn = getConn();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
        //执行数据库查询
        public bool existSql(SqlConnection conn,string sql)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
        //返回sqlDataAdapter用于填充控件

        public DataTable getTable(string sql,SqlConnection conn)
        {
            DataTable table = new DataTable();
            try
            {
               
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.Fill(table);
                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { }
            return table;
        }

    }
}
