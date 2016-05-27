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
        void initOther(string projectName)
        {
            string sql = "select * from " + NameUnit.projectTable + " where PROJECT_ID = '" + projectName + "'";
            DataTable res = db.getTable(sql,conn);

            if (res.Rows.Count <= 0)
                return;
            this.textBox_projectCity.Text=res.Rows[0]["CITY"].ToString();
            this.textBox_projectDate.Text = res.Rows[0]["VERSION_DATE"].ToString();
            this.textBox_projectDb.Text = res.Rows[0]["DB_NAME"].ToString();
            this.textBox_projectPerson.Text = res.Rows[0]["PRINCIPAL"].ToString();
            
        }
        //项目删除
        void delete(string projectName)
        {
            //删除表项
            string deleteSql = "delete from "+NameUnit.projectTable +" where PROJECT_ID = '"+projectName+"'";
            db.execSql(deleteSql,conn);
            //删除数据库

            string dropSql = "ALTER DATABASE "+NameUnit.getName(projectName)+" SET SINGLE_USER with ROLLBACK IMMEDIATE; drop database " + NameUnit.getName(projectName);
            db.execSql(dropSql,connDb);

              
           // this.comboBox_projectName.Items.Remove(projectName);
           // this.comboBox_projectName.SelectedIndex = 0;
        }
        public ProjectDelete()
        {
            InitializeComponent();
            db = DbHelper.getInstance();
            conn = db.getConn(db.getConnStr(NameUnit.getName(NameUnit.guradDb)));


            connDb = db.getConn();
            connDb.Open();

            string sql="select PROJECT_ID from "+NameUnit.projectTable;
            this.comboBox_projectName.DataSource = db.getTable(sql,conn);
            this.comboBox_projectName.ValueMember = "PROJECT_ID";
            this.comboBox_projectName.DisplayMember = "PROJECT_ID";
            
        }


        private void button_create_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("是否删除项目","询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                return;
            delete(this.comboBox_projectName.Text);
            MessageBox.Show("项目删除成功");
        }

        private void ProjectDelete_Load(object sender, EventArgs e)
        {
            if (this.comboBox_projectName.Text=="")
                return;
            initOther(this.comboBox_projectName.Text);
        }

        private void comboBox_projectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_projectName.Text == "")
                return;
            initOther(this.comboBox_projectName.Text);
        }

        private void ProjectDelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            if(connDb!=null)
                 connDb.Close();
        }
        
    }
}
