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
        public  static string guradDb = "GUARD";
        public  static string baseName="TDLTE_";
        public static string projectTable = "tbProjectManagement";
        public static string tbProjectManagement = @"CREATE TABLE [dbo].[tbProjectManagement] (
    [PROJECT_ID] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NOT NULL,
    [VERSION_DATE] [datetime] NOT NULL,
    [DB_NAME] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL,
    [CITY] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL,
    [PRINCIPAL] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL ) ON [PRIMARY]

";
        public static string tbInterferenceType = @"CREATE TABLE [dbo].[tbInterferenceType] (
    [InterferenceID] [int] NOT NULL,
    [InterferenceName] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NOT NULL) ON [PRIMARY]
";
        //程序中添加字段
        public  static string tbPRBSample_Modeling = @"CREATE TABLE [dbo].[tbPRBSample_Modeling] (
    [CellID] [int] NOT NULL,
    [StartTime] [datetime] NOT NULL,
    [CellName] [nvarchar](255) COLLATE Chinese_PRC_CI_AS NULL,
    [Period] [int] NULL,
";
        //程序中添加
        public static string tbPRBSample_Recognition = @"CREATE TABLE [dbo].[tbPRBSample_Recognition] (
    [CellID] [int] NOT NULL,
    [StartTime] [datetime] NOT NULL,
     [CellName] [datetime]  NOT NULL,
    [Period] [int] NULL,
";
        //*
        public  static string tbFeartureSampleModeling = @"CREATE TABLE [dbo].[tbFeartureSampleModeling] (
    [ModelID] [int] NOT NULL,
    [CellID] [int] NOT NULL,
    [StartTime] [datetime] NOT NULL ,
    [RBOrder1] [int] NOT NULL,
    [RBOrder2] [int] NOT NULL,
    [RBOrder3] [int] NOT NULL,
    [RBOrder4] [int] NOt NULL,
    [RBOrder5] [int] NOT NULL,
    [InterferenceCoefficient] [NUMERIC](10,2) NOT NULL,
    [AverageOfPRB0_99] [NUMERIC](10,2) NOT NULL,
    [AverageOfPRB60_99] [NUMERIC](10,2) NOT NULL,
    [Slope0_49] [NUMERIC](10,2) NOT NULL,
    [Slope50_99] [NUMERIC](10,2) NOT NULL,
    [Slope0_99] [NUMERIC](10,2) NOT NULL,
    [Variance0_99] [NUMERIC](10,2) NOT NULL,
    [BurstNumPRB0_99] [int] NOT NULL,
    [InterferenceID] [int] NOT NULL,
     [SampleType] [int] NOT NULL) ON [PRIMARY]
";
        //*
        public  static string tbFeartureSampleRecognition = @"CREATE TABLE [dbo].[tbFeartureSampleRecognition] (
    [CellID] [int] NOT NULL,
    [StartTime] [datetime] NOT NULL,
    [RBOrder1] [int] NOT NULL,
    [RBOrder2] [int] NOT NULL,
    [RBOrder3] [int] NOT NULL,
    [RBOrder4] [int] NOt NULL,
    [RBOrder5] [int] NOT NULL,
    [InterferenceCoefficient] [NUMERIC](10,2) NOT NULL,
    [AverageOfPRB0_99] [NUMERIC](10,2) NOT NULL,
    [AverageOfPRB60_99] [NUMERIC](10,2) NOT NULL,
    [Slope0_49] [NUMERIC](10,2) NOT NULL,
    [Slope50_99] [NUMERIC](10,2) NOT NULL,
    [Slope0_99] [NUMERIC](10,2) NOT NULL,
    [Variance0_99] [NUMERIC](10,2) NOT NULL,
    [BurstNumPRB0_99] [int] NOT NULL,
    [InterferenceID] [int] NOT NULL,
     [SampleType] [int] NOT NULL) ON [PRIMARY]
";
        //程序中添加
        public  static string tbPRBSmoothedSample_Modeling = @"CREATE TABLE [dbo].[tbPRBSmoothedSample_Modeling] (
    [CellID] [int] NOT NULL,
    [StartTime] [datetime]  NOT NULL,
";
        //程序中添加
        public  static string tbPRBSmoothedSample_Recognition = @"CREATE TABLE [dbo].[tbPRBSmoothedSample_Recognition] (
    [CellID] [int] NOT NULL,
    [StartTime] [datetime] NOT NULL,
";
        public  static string tbBurstInfo = @"CREATE TABLE [dbo].[tbBurstInfo] (
    [CellID] [int] NOT NULL,
    [StartTime] [datetime] NOT NULL,
    [BurstPRB] [int] NOT NULL,
    [BurstValue] [NUMERIC](10,2) NOT NULL) ON [PRIMARY]
";
       public  static string tbModelInfo = @"CREATE TABLE [dbo].[tbModelInfo] (
    [ModelID] [int] NOT NULL,
    [ModelStartTime] [datetime] NOT NULL,
    [ModelEndTime] [datetime] NOT NULL,
[ModelAddress] [nvarchar](255) NOT NULL,
[TrainSampleNum] [int]  NULL,
[TestSampleNum] [int]  NULL,
[TreeNum] [int]  NULL) ON [PRIMARY]
";
        public  static string tbModelTreeInfo = @"CREATE TABLE [dbo].[tbModelTreeInfo] (
    [ModelID] [int] NULL,
[TreeID] [int] NULL,
[InteriorNodeNum] [int] NULL,
[LeafNodeNum] [int] NULL,
[AttibuteNum] [int] NULL,
[Depth] [int] NULL,
[Rules] [text] NULL) ON [PRIMARY]
";
        private static void getFullSql()
        {
            //tbPRBSample_Modeling
            for (int i = 0; i <= 99; i++)
            {
                tbPRBSample_Modeling = tbPRBSample_Modeling + "[PRB" + i + "] [float] NOT NULL,";
            }
            tbPRBSample_Modeling += "[InterferenceID][int] NOT NULL) ON [PRIMARY]";

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
        public static void  initParams()
        {
            getFullSql();
        }
        public static string getName(string name)
        {
            return baseName + name;
        }
        //判断项目是否存在
        public static bool existProject(string proName)
        {
            string sql = "select * from "+projectTable+" where PROJECT_ID = '" + proName + "'";
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
