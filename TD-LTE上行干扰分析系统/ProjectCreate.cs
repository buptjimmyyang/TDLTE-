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
    public partial class ProjectCreate : Form
    {
        //1.声明自适应类实例
        private AutomaticSize auto = new AutomaticSize();
        private string projectName;
        private string projectPerson;
        private string projectArea;
        private string projectDate;
        private string dbName;


        private DbHelper db = null;
        private SqlConnection conn = null;
        private SqlConnection connDb = null;
        void initArea()
        {
            string sql = "select distinct CITY from " + NameUnit.projectTable;
            DataTable table = db.getTable(sql, conn);
            this.comboBox_projectArea.DataSource = table;
            if (table.Rows.Count == 0)
            {
                this.comboBox_projectArea.Text = "";
                this.comboBox_projectName.Text = "";

                return;
            }
            this.comboBox_projectArea.ValueMember = "CITY";
            this.comboBox_projectArea.DisplayMember = "CITY";
        }
        //初始化项目名
        void initProjectName(string projectArea)
        {
            string sql = "select PROJECT_ID from " + NameUnit.projectTable + " where CITY = '" + projectArea + "'";
            DataTable res = db.getTable(sql, conn);

            if (res.Rows.Count <= 0)
                return;
            this.comboBox_projectName.DataSource = res;
            this.comboBox_projectName.ValueMember = "PROJECT_ID";
            this.comboBox_projectName.DisplayMember = "PROJECT_ID";

        }
        public ProjectCreate()
        {
            InitializeComponent();

            db = DbHelper.getInstance();
            conn = db.getConn(db.getConnStr(NameUnit.getName(NameUnit.guradDb)));

            connDb = db.getConn();
            connDb.Open();

            initArea();
        }

        private void button_create_SizeChanged(object sender, EventArgs e)
        {

        }

        private void ProjectCreate_SizeChanged(object sender, EventArgs e)
        {
            //3
            auto.sizechange(this);
        }

        private void ProjectCreate_LocationChanged(object sender, EventArgs e)
        {

        }

        private void ProjectCreate_Load(object sender, EventArgs e)
        {
            //2
            auto.GetInitialFormSize(this);
            auto.GetAllCrlLocation(this);
            auto.GetAllCrlSize(this);

            initProjectName(this.comboBox_projectArea.Text);
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            projectName=this.comboBox_projectName.Text.Trim();
            projectArea=this.comboBox_projectArea.Text.Trim();
            projectPerson=this.textBox_person.Text.Trim();
            projectDate = DateTime.Now.ToString();
            if ( projectName== "")
            {
                this.comboBox_projectName.Focus();
                MessageBox.Show("项目名称不能为空");
                return;
            }
            if (projectArea == "")
            {
                this.comboBox_projectArea.Focus();
                MessageBox.Show("地区名称不能为空");
                return;
            }
            if (projectPerson == "")
            {
                this.textBox_person.Focus();
                MessageBox.Show("项目负责人不能为空");
                return;
            }
            

            
            if (NameUnit.existProject(projectName,projectArea))
            {
                MessageBox.Show("项目已经存在，不能重新创建");
                return;
            }

            dbName = projectArea + "_" + projectName;
           //项目不存在的话创建数据库
            TableHelper table = new TableHelper();
            string baseName=table.createDataBase(dbName);
            if (baseName != "")
            {
                //创建数据表
                table.createTable();
                
                //将项目信息添加进数据管理表
                string sql = "insert into " + NameUnit.projectTable + "(PROJECT_ID,VERSION_DATE,DB_NAME,CITY,PRINCIPAL)values('" + projectName + "','" + projectDate + "','" + baseName + "','"
                        + projectArea + "','" + projectPerson + "')";
                NameUnit.insertProject(sql);
                MessageBox.Show("项目创建成功");

                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox_projectArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select PROJECT_ID from " + NameUnit.projectTable + " where CITY = '" + this.comboBox_projectArea.Text + "'";
            DataTable res = db.getTable(sql, conn);

            if (res.Rows.Count <= 0)
                return;
            this.comboBox_projectName.DataSource = res;
        }

        private void ProjectCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            if (connDb != null)
                connDb.Close();
        }

    }
}
