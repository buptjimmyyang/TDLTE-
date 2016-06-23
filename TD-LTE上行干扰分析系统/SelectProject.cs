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
    /// yang
    /// 选择项目窗口
    /// 2016.6.6
    /// </summary>
    public partial class SelectProject : Form
    {
        private DbHelper db = null;
        private SqlConnection conn = null;
        private SqlConnection connDb = null;

        public SelectProject()
        {
            InitializeComponent();

            db = DbHelper.getInstance();
            conn = db.getConn(db.getConnStr(NameUnit.getName(NameUnit.guradDb)));

            connDb = db.getConn();
            connDb.Open();

            initArea();
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
        private void button_Ok_Click(object sender, EventArgs e)
        {
            if(this.comboBox_projectName.Text==""||this.comboBox_projectArea.Text=="")
            {
                MessageBox.Show("项目名或者地区名不能为空");
                return;
            }
            string sql = "select DB_NAME from " + NameUnit.projectTable + " where CITY = '" + this.comboBox_projectArea.Text + "' and PROJECT_ID='"+this.comboBox_projectName.Text+"'";
          
            DataTable res = db.getTable(sql, conn);
            if (res.Rows.Count <= 0)
            {
                MessageBox.Show("不存在所输入的项目请重新输入");
                return;
            }
            //保存所要操作的数据库名
            NameUnit.selectDbName = res.Rows[0]["DB_NAME"].ToString();

            BusinessMain business = new BusinessMain();
            business.Show();
            this.Close();
        }

        private void SelectProject_Load(object sender, EventArgs e)
        {
            if (this.comboBox_projectArea.Text == "")
                return;
            initProjectName(this.comboBox_projectArea.Text);
        }

        private void comboBox_projectArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select PROJECT_ID from " + NameUnit.projectTable + " where CITY = '" + this.comboBox_projectArea.Text + "'";
            DataTable res = db.getTable(sql, conn);

            if (res.Rows.Count <= 0)
                return;
            this.comboBox_projectName.DataSource = res;
        }

        private void SelectProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            if (connDb != null)
                connDb.Close();
        }
    }
}
