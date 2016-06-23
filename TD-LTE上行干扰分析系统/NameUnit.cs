using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_LTE上行干扰分析系统
{
    /// <summary>
    /// 名称合成单元，以及文件管理
    /// 数据库表创建语句也在改文件
    /// yang
    /// 16.5.24
    /// </summary>
    class NameUnit
    {
        //**************
        //选择项目后保存数据库名称
        public static string selectDbName = "";
        public static string fileType = "";
        public static string importModel="";
        public static string importTableName = "";
        ///文件导入相关****************

        public  static string guradDb = "GUARD";
        public  static string baseName="TDLTE_";
        public static string projectTable = "tbProjectManagement";
        public static string tbProjectManagement = "";
        public static string tbInterferenceType = "";
        //程序中添加字段
        public  static string tbPRBSample_Modeling = "";
        //程序中添加
        public static string tbPRBSample_Recognition ="";
        //*
        public  static string tbFeartureSampleModeling = "";
        //*
        public  static string tbFeartureSampleRecognition ="";
        //程序中添加
        public  static string tbPRBSmoothedSample_Modeling = "";
        //程序中添加
        public  static string tbPRBSmoothedSample_Recognition = "";
        public  static string tbBurstInfo ="";
       public  static string tbModelInfo = "";
        public  static string tbModelTreeInfo ="";
       /* private static void getFullSql()
        {
            //tbPRBSample_Modeling
            for (int i = 0; i <= 99; i++)
            {
                tbPRBSample_Modeling = tbPRBSample_Modeling + "[PRB" + i + "] [float] NOT NULL,";
            }
            tbPRBSample_Modeling += "[InterferenceID][int] not NULL) ON [PRIMARY]";

            //tbPRBSample_Recognition
            for (int i = 1; i <= 98; i++)
            {
                tbPRBSample_Recognition += "[PRB" + i + "] [float] NOT NULL,";
            }
            tbPRBSample_Recognition += "[PRB99] [float] NOT NULL) ON [PRIMARY]";

            //tbPRBSmoothedSample_Modeling
            for (int i = 0; i <= 99; i++)
            {
                tbPRBSmoothedSample_Modeling += "[SmoothPRB" + i + "] [float] NOT NULL,";
            }
            tbPRBSmoothedSample_Modeling+="[BurstNumPRB0_99] [int] NOT NULL) ON [PRIMARY]";

            //tbPRBSmoothedSample_Recognition
            for (int i = 0; i <= 99; i++)
            {
                tbPRBSmoothedSample_Recognition += "[SmoothPRB" + i + "] [float] NOT NULL,";
            }
            tbPRBSmoothedSample_Recognition += "[BurstNumPRB0_99] [int] NOT NULL) ON [PRIMARY]";
        }
        * */
        public static void  initParams()
        {
            XMLHelper.instatnce().getSqlCommand("Configuration/createTable/tbModelTreeInfo", ref tbModelTreeInfo);
            XMLHelper.instatnce().getSqlCommand("Configuration/createTable/tbModelInfo", ref tbModelInfo);
            XMLHelper.instatnce().getSqlCommand("Configuration/createTable/tbBurstInfo", ref tbBurstInfo);

            XMLHelper.instatnce().getSqlCommand("Configuration/createTable/tbPRBSmoothedSample_Recognition", ref tbPRBSmoothedSample_Recognition);
            XMLHelper.instatnce().getSqlCommand("Configuration/createTable/tbPRBSmoothedSample_Modeling", ref tbPRBSmoothedSample_Modeling);
            XMLHelper.instatnce().getSqlCommand("Configuration/createTable/tbFeartureSampleRecognition", ref tbFeartureSampleRecognition);

            XMLHelper.instatnce().getSqlCommand("Configuration/createTable/tbFeartureSampleModeling", ref tbFeartureSampleModeling);
            XMLHelper.instatnce().getSqlCommand("Configuration/createTable/tbPRBSample_Recognition", ref tbPRBSample_Recognition);
            XMLHelper.instatnce().getSqlCommand("Configuration/createTable/tbPRBSample_Modeling", ref tbPRBSample_Modeling);

            XMLHelper.instatnce().getSqlCommand("Configuration/createTable/tbInterferenceType", ref tbInterferenceType);
            XMLHelper.instatnce().getSqlCommand("Configuration/createTable/tbProjectManagement", ref tbProjectManagement);
        }
        public static string getName(string name)
        {
            return baseName + name;
        }
        //判断项目是否存在
        public static bool existProject(string proName,string proArea)
        {
            string sql = "select * from "+projectTable+" where PROJECT_ID = '" + proName + "' and CITY='"+proArea+"'";
            DbHelper db = DbHelper.getInstance();
            SqlConnection conn = db.getConn(db.getConnStr(NameUnit.getName(NameUnit.guradDb)));
            if (db.existSql(conn, sql))
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
        //将项目添加到projectTable中
        public static void insertProject(string sql)
        {

            DbHelper db = DbHelper.getInstance();
            SqlConnection conn = db.getConn(db.getConnStr(NameUnit.getName(NameUnit.guradDb)));
            if (db.execSql(sql,conn))
            {
                conn.Close();
                return;
            }
            else
            {
                conn.Close();
                return;
            }
        
        }
    }

}
