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

namespace TD_LTE上行干扰分析系统
{
    public partial class ProjectInquire : Form
    {
        private DbHelper db = null;
        private SqlConnection conn = null;
        //初始化控件
       private void InitCombox()
       {
           db=DbHelper.getInstance();

           conn = db.getConn(db.getConnStr(NameUnit.getName(NameUnit.guradDb)));

           string sql = "select distinct PROJECT_ID from  " + NameUnit.projectTable;
           this.comboBox_projectName.DataSource = db.getTable(sql,conn);
           this.comboBox_projectName.DisplayMember = "PROJECT_ID";
           this.comboBox_projectName.ValueMember = "PROJECT_ID";

           string sql1 = "select distinct CITY from " + NameUnit.projectTable;
           this.comboBox_projectArea.DataSource = db.getTable(sql1, conn);
           this.comboBox_projectArea.DisplayMember = "CITY";
           this.comboBox_projectArea.ValueMember = "CITY";
           
       }
        //获取查询结果
       private void getResult()
       {
           string projectName = "";
           string projectArea = "";
           string sql="";
           projectName=this.comboBox_projectName.Text.ToString();
           projectArea=this.comboBox_projectArea.Text.ToString();
           string startTime = dateTimePicker_startTime.Text.ToString();
           string endTime = dateTimePicker_endTime.Text.ToString();
           startTime += " 0:0:0";
           endTime += " 23:59:59";
           if(projectName=="" && projectArea!="")
               sql = "select PROJECT_ID as '项目名',VERSION_DATE as '创建时间',DB_NAME as '数据库名称',CITY as '地区',PRINCIPAL as '创建人' from " + NameUnit.projectTable + " where  CITY = '" + projectArea + "' and VERSION_DATE between  '" + startTime + "' and '" + endTime + "'";
           else if(projectName!="" && projectArea=="")
               sql = "select PROJECT_ID as '项目名',VERSION_DATE as '创建时间',DB_NAME as '数据库名称',CITY as '地区',PRINCIPAL as '创建人' from " + NameUnit.projectTable + " where PROJECT_ID = '" + projectName + "' " + " VERSION_DATE between  '" + startTime + "' and '" + endTime + "'";
           else if(projectName=="" && projectArea=="")
               sql="select PROJECT_ID as '项目名',VERSION_DATE as '创建时间',DB_NAME as '数据库名称',CITY as '地区',PRINCIPAL as '创建人' from " + NameUnit.projectTable + " where " +" VERSION_DATE between  '" + startTime + "' and '" + endTime + "'";
           //string sql = "select PROJECT_ID as '项目名',VERSION_DATE as '创建时间',DB_NAME as '数据库名称',CITY as '地区',PRINCIPAL as '创建人' from " + NameUnit.projectTable + " where VERSION_DATE between  '" + startTime + "' and '" + endTime + "'"; ;
           else
                 sql = "select PROJECT_ID as '项目名',VERSION_DATE as '创建时间',DB_NAME as '数据库名称',CITY as '地区',PRINCIPAL as '创建人' from " + NameUnit.projectTable + " where (PROJECT_ID = '" + projectName + "' or CITY = '" + projectArea + "') and VERSION_DATE between  '" + startTime + "' and '" + endTime + "'";
           //string sql = "select PROJECT_ID as '项目名',VERSION_DATE as '创建时间',DB_NAME as '数据库名称',CITY as '地区',PRINCIPAL as '创建人' from " + NameUnit.projectTable + " where VERSION_DATE between  '" + startTime + "' and '" + endTime + "'"; ;
           dataGridView_result.DataSource = db.getTable(sql,conn);
           dataGridView_result.Show();
       }

        public ProjectInquire()
        {
            InitializeComponent();
            //设置项目 地区控件中的值
            InitCombox();
        }

        private void button_inquire_Click(object sender, EventArgs e)
        {
            getResult();
        }

        private void ProjectInquire_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void button_txt_Click(object sender, EventArgs e)
        {
            if(this.dataGridView_result.DataSource==null)
                return;
            string saveFileName="";
            //设置保存对话框
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "txt";
            save.Filter = "Txt文件|*.txt";
            save.FileName = NameUnit.projectTable;
            save.ShowDialog();
            saveFileName = save.FileName;

            if (saveFileName.Length > 218)
            {
                MessageBox.Show("文件名过长请重新选择");
            }
            //导出文件
            //0表示导出txt文件
            progress process = new progress((DataTable)this.dataGridView_result.DataSource, saveFileName,0);
            process.Show();

        }

        private void button_excel_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_result.DataSource == null)
                return;
            string saveFileName = "";
            //设置保存对话框
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "xls";
            save.Filter = "Excel文件|*.xls";
            save.FileName = NameUnit.projectTable;
            save.ShowDialog();
            saveFileName = save.FileName;

            if (saveFileName.Length > 218)
            {
                MessageBox.Show("文件名过长请重新选择");
            }
            //导出文件
            //1表示导出excel文件

            progress process = new progress((DataTable)this.dataGridView_result.DataSource, saveFileName, 1);
            process.Show();
           
        }
    }
}
