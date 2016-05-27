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
        public ProjectCreate()
        {
            InitializeComponent();
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
         
            
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            projectName=this.textBox_proName.Text.Trim();
            projectArea=this.textBox_areaName.Text.Trim();
            projectPerson=this.textBox_person.Text.Trim();
            projectDate = DateTime.Now.ToString();
            if ( projectName== "")
            {
                this.textBox_proName.Focus();
                MessageBox.Show("项目名称不能为空");
                return;
            }
            if (projectArea == "")
            {
                this.textBox_areaName.Focus();
                MessageBox.Show("地区名称不能为空");
                return;
            }
            if (projectPerson == "")
            {
                this.textBox_person.Focus();
                MessageBox.Show("项目负责人不能为空");
                return;
            }
            

            
            if (NameUnit.existProject(projectName))
            {
                MessageBox.Show("项目已经存在，不能重新创建");
                return;
            }
           
           //项目不存在的话创建数据库
            TableHelper table = new TableHelper();
            string baseName=table.createDataBase(projectName);
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

    }
}
