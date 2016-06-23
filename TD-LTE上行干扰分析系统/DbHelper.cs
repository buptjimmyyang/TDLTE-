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
				reader.Close();
                conn.Close();
                return true;
            }
            else
            {
				reader.Close();
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
				reader.Close();
                conn.Close();
                return true;
            }
            else
            {
				reader.Close();
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


        //执行sql语句返回list
        public ArrayList getResult(string sql,SqlConnection conn)
        
        {
            ArrayList result = new ArrayList();
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandTimeout = 5000000;
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                //SqlDataReader用法
                while (reader.Read())
                    result.Add(reader.GetString(0));
                reader.Close();
            }
            catch (SqlException e)
            {
                reader.Close();
                return null;
            }
            return result;
        }

        //批量插入数据
        /*
        * 批量插入数据
        */
        public bool BatchInsert(String tableName,  DataTable dt,string connStr)
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    //指定大容量插入是否对表激发触发器。此属性的默认值为False
                   
                    
                    SqlBulkCopy bulkCopy;
                    bulkCopy = new SqlBulkCopy(connStr, SqlBulkCopyOptions.FireTriggers);

                    bulkCopy.DestinationTableName = tableName;

                    for (int ccc = 0; ccc < dt.Columns.Count; ccc++)
                    {
                        bulkCopy.ColumnMappings.Add(dt.Columns[ccc].ColumnName, dt.Columns[ccc].ColumnName);
                    }

                    bulkCopy.WriteToServer(dt);
                    bulkCopy.Close();
                    bulkCopy = null;

                    dt.Clear();
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
              //  MessageBox.Show(connStr+"----"+ex.Message);
                return false;
            }

            return true;
        }

        public bool BatchInsert(String tableName, ref DataTable dt, ref List<String> databaseFields,string connstr, bool needTrigger = false, bool clearDT = true)
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    //指定大容量插入是否对表激发触发器。此属性的默认值为False
                    //如果不需要触发触发器则
                    SqlBulkCopy bulkCopy;
                   
                    //如果需要触发器，则
                    
                        bulkCopy = new SqlBulkCopy(connstr, SqlBulkCopyOptions.FireTriggers);

                    bulkCopy.DestinationTableName = tableName;

                    for (int ccc = 0; ccc < databaseFields.Count; ccc++)
                    {
                        bulkCopy.ColumnMappings.Add(databaseFields[ccc], databaseFields[ccc]);
                    }

                    bulkCopy.WriteToServer(dt);
                    bulkCopy.Close();
                    bulkCopy = null;
                    if (clearDT)
                    {
                        dt.Clear();
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }
    }
}
