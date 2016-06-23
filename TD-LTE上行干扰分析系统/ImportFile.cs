using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Data.OleDb;

namespace TD_LTE上行干扰分析系统
{
    class ImportFile
    {
        /*
        * 文件读取器
         * txt按照块读取，其中配置参数在xml文件中
         * excel文件按照sheet读取
        */
        public static StreamReader sr = null;

        /*
         * 去掉引号函数
         */
        private static String RemoveQuote(String str)
        {
            return str.Replace("\"", "");
        }

        /*
         * 从平面文件源中读取数据(txt、csv)
         */
        private static bool ReadData(ref DataTable table, String filePath, char splitChar)
        {
            String line, temp;
            string r="";
            XMLHelper.instatnce().getSqlCommand("Configuration/checkData/ReadRowNum", ref r);
            int count = int.Parse(r);
            if (sr == null)
            {
                sr = new StreamReader(filePath, Encoding.Default);
                line = sr.ReadLine();//读取第一行
                String[] attrs = line.Split(splitChar);
                //将属性名添加到datatable中
                for (int i = 0; i < attrs.Count(); i++)
                    table.Columns.Add(RemoveQuote(attrs[i]), System.Type.GetType("System.String"));
            }

            //添加数据
            while ((--count != 0) && ((line = sr.ReadLine()) != null))
            {
                String[] values = line.Split(splitChar);
                DataRow row = table.NewRow();
                for (int i = 0; i < values.Count(); i++)
                {
                    temp = RemoveQuote(values[i]);
                    if (temp.Count() == 0)
                        temp = "0";
                    row[table.Columns[i].ColumnName] = temp;
                }
                table.Rows.Add(row);
            }

            if (count == 0)
                return true;

            //先将sr置为null
            sr.Dispose();
            sr = null;
            return false;
        }




        public static bool ReadTxt(ref DataTable table, String filePath, String fileType)
        {
            if (fileType.Equals("txt"))
                return ReadData(ref table, filePath, '\t');
            else
                return ReadData(ref table, filePath, ',');
        }
        //包装函数
        public static bool readFile(ref DataTable table, String filePath, String fileType,int type)
        {
            if (type == 1)
                return ReadTxt(ref table, filePath, fileType);
            else
                return ReadExcel(ref table,filePath,fileType);
        
        }

        /*
        * 从Excel文件中读入数据 
        */
        private static OleDbConnection conn = null;
        private static int count=0;
        public static bool ReadExcel(ref System.Data.DataTable table, String filePath, String fileType)
        {
            String connStr = String.Empty;
            System.Data.DataTable tables = new System.Data.DataTable();
            if (fileType.Equals("xls"))
                connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
            else
                connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + filePath + ";" + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";

            try
            {
                if (conn==null)
                {
                    //类似于获取数据库连接
                    conn = new OleDbConnection(connStr);
                    //打开连接
                    conn.Open();
                    //获取数据
                    tables = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new Object[] { });
                    //判断该文件中是否有sheet
                    if (tables.Rows.Count == 0)
                    {
                        Console.WriteLine("文件中没有可用表");
                        MessageBox.Show("文件中没有可用表", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                }
                
                //将读取到的数据存入DataTable
                String firstTableName = tables.Rows[count]["TABLE_NAME"].ToString();
                OleDbCommand cmd = new OleDbCommand("select * from [" + firstTableName + "]", conn);
                OleDbDataAdapter apt = new OleDbDataAdapter(cmd);
                table.Dispose();
                apt.Fill(table);


              
                count++;
                if (count > table.Rows.Count)
                {
                    conn.Close();
                    conn = null;
                    count = 0;
                    return false ;
                }
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false ;
            }
        }
    }
}
