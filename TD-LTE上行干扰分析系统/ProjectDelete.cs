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
    /// <summary>
    /// 项目删除
    /// 6.27
    /// yang
    /// </summary>
    public partial class ProjectDelete : Form
    {
        private DbHelper db = null;
        private SqlConnection conn = null;
        private SqlConnection connDb = null;
        //根据项目名填充相应的textbox
        void initOther(string projectArea)
        {
            string sql = "select PROJECT_ID from " + NameUnit.projectTable + " where CITY = '" + projectArea+ "'";
            DataTable res = db.getTable(sql, conn);

            if (res.Rows.Count <= 0)
                return;
            this.comboBox_projectName.DataSource = res;
            this.comboBox_projectName.ValueMember = "PROJECT_ID";
            this.comboBox_projectName.DisplayMember = "PROJECT_ID";

            
            
        }
        //初始化地区
        void initArea()
        {
            string sql = "select CITY from " + NameUnit.projectTable;
            DataTable table = db.getTable(sql, conn);
            this.comboBox_projectArea.DataSource = table;
            if (table.Rows.Count == 0)
            {
                this.comboBox_projectArea.Text = "";
                this.comboBox_projectName.Text = "";
                this.textBox_projectDate.Text = "";
                this.textBox_projectDb.Text = "";
                this.textBox_projectPerson.Text = "";
                return;
            }
            this.comboBox_projectArea.ValueMember = "CITY";
            this.comboBox_projectArea.DisplayMember = "CITY";

        }
        //项目删除
        void delete(string projectName,string projectArea)
        {
            //删除表项
            string deleteSql = "delete from "+NameUnit.projectTable +" where PROJECT_ID = '"+projectName+"' and CITY='"+projectArea+"'";
            db.execSql(deleteSql,conn);
            //删除数据库

            string dropSql = "ALTER DATABASE "+this.textBox_projectDb.Text+" SET SINGLE_USER with ROLLBACK IMMEDIATE; drop database " + this.textBox_projectDb.Text;
            db.execSql(dropSql,connDb);

              
           
        }
        public ProjectDelete()
        {
            InitializeComponent();
            db = DbHelper.getInstance();
            conn = db.getConn(db.getConnStr(NameUnit.getName(NameUnit.guradDb)));

            connDb = db.getConn();
            connDb.Open();

            initArea();
            
        }


        private void button_create_Click(object sender, EventArgs e)
        {
            if (this.comboBox_projectArea.Text == "" || this.comboBox_projectName.Text == "")
            {
                MessageBox.Show("项目名和地区名不能为空");
                return;
            }
           if (MessageBox.Show("是否删除项目","询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                return;
            delete(this.comboBox_projectName.Text,this.comboBox_projectArea.Text);
            MessageBox.Show("项目删除成功");


            initArea();
        }

        private void ProjectDelete_Load(object sender, EventArgs e)
        {
            if (this.comboBox_projectArea.Text=="")
                return;
            initOther(this.comboBox_projectArea.Text);
        }

        private void comboBox_projectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_projectName.Text == "")
                return;
            string sql = "select VERSION_DATE,DB_NAME,PRINCIPAL from " + NameUnit.projectTable + " where PROJECT_ID = '" + this.comboBox_projectName.Text+"' and CITY='"+this.comboBox_projectArea.Text+"'";
            DataTable res = db.getTable(sql, conn);

            if (res.Rows.Count <= 0)
                return;
            this.textBox_projectDate.Text = res.Rows[0]["VERSION_DATE"].ToString();
            this.textBox_projectDb.Text = res.Rows[0]["DB_NAME"].ToString();
            this.textBox_projectPerson.Text = res.Rows[0]["PRINCIPAL"].ToString();
        }

        private void ProjectDelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            if(connDb!=null)
                 connDb.Close();
        }

        private void comboBox_projectArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select PROJECT_ID from " + NameUnit.projectTable + " where CITY = '" + this.comboBox_projectArea.Text+ "'";
            DataTable res = db.getTable(sql, conn);

            if (res.Rows.Count <= 0)
                return;
            this.comboBox_projectName.DataSource = res;
            this.comboBox_projectName.ValueMember = "PROJECT_ID";
            this.comboBox_projectName.DisplayMember = "PROJECT_ID";
        }
        
    }
}
