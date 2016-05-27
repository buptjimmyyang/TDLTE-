using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TD_LTE上行干扰分析系统
{
    /// <summary>
    /// 对数据库表操作类、
    /// yang
    /// 16.5.25
    /// </summary>
    class TableHelper
    {
        string projectName;
        //创建管理数据库并建立响应的表结构
        public void createGuardDb()
        {
            createDataBase(NameUnit.guradDb);
            //
            DbHelper db = DbHelper.getInstance();
            SqlConnection conn = db.getConn(db.getConnStr(NameUnit.getName(NameUnit.guradDb)));

            try
            {
                db.execSql(NameUnit.tbProjectManagement, conn);
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //创建项目数据库
        public string createDataBase(string proName)
        {
            projectName = NameUnit.getName(proName);
            string currentDirectory = System.Environment.CurrentDirectory;
            SqlConnection conn = DbHelper.getInstance().getConn();
            string dataBaseName = NameUnit.getName(proName);
            string mdfName = currentDirectory + "\\database\\" + dataBaseName + ".mdf";
            string ldfName = currentDirectory + "\\database\\" + dataBaseName + ".ldf";
            //创建数据库
            string sql = "CREATE DATABASE " + dataBaseName + " on primary" + "(name=" + dataBaseName + ",filename='" + mdfName + "' ,size=3, maxsize=5,filegrowth=10%)";
            sql += "log on" + "(name=" + dataBaseName + "_log,filename='" + ldfName + "',size=3,filegrowth=1)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            try
            {
                cmd.ExecuteNonQuery();
               
                conn.Close();
                return dataBaseName;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
                return "";
            }
        }
        
        //创建数据库表
        public bool createTable()
        {

           
            DbHelper db = DbHelper.getInstance();
            SqlConnection conn =db.getConn(db.getConnStr(projectName));
            try
            {
                db.execSql(NameUnit.tbBurstInfo, conn);
                db.execSql(NameUnit.tbFeartureSampleModeling, conn);
                db.execSql(NameUnit.tbFeartureSampleRecognition, conn);
                db.execSql(NameUnit.tbInterferenceType, conn);
                db.execSql(NameUnit.tbModelInfo, conn);
                db.execSql(NameUnit.tbModelTreeInfo, conn);
                db.execSql(NameUnit.tbPRBSample_Modeling, conn);
                db.execSql(NameUnit.tbPRBSample_Recognition, conn);
                db.execSql(NameUnit.tbPRBSmoothedSample_Modeling, conn);
                db.execSql(NameUnit.tbPRBSmoothedSample_Recognition, conn);
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show(e.Message);
                return false;
            }
            

        }
    }
}
