using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TD_LTE上行干扰分析系统
{
    public partial class DbLogin : Form
    {
        //1.声明自适应类实例
        private AutomaticSize auto = new AutomaticSize();  
        public DbLogin()
        {
            InitializeComponent();
            

            //默认设置windows窗体登陆
            this.comboBox_validate.SelectedIndex = 0;
            this.label3.Enabled = false;
            this.label4.Enabled = false;
            this.textBox_userName.Enabled = false;
            this.textBox_passWd.Enabled = false;
        }

        private void DbLogin_Load(object sender, EventArgs e)
        {
            auto.GetInitialFormSize(this);
            auto.GetAllCrlLocation(this);
            auto.GetAllCrlSize(this); 
        }

        private void button_login_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DbLogin_SizeChanged(object sender, EventArgs e)
        {
            auto.sizechange(this);
        }

        private void comboBox_validate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mode = (string)this.comboBox_validate.SelectedItem;
            if (mode == "Windows 身份验证")
            {
                this.label3.Enabled = false;
                this.label4.Enabled = false;
                this.textBox_userName.Enabled = false;
                this.textBox_passWd.Enabled = false;
            }
            else
            {
                this.label3.Enabled = true;
                this.label4.Enabled = true;
                this.textBox_userName.Enabled = true;
                this.textBox_passWd.Enabled = true;
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string server = this.textBox_serverIp.Text.Trim();
            if (server == "")
            {
                MessageBox.Show("请输入服务器Ip");
                this.textBox_serverIp.Focus();
                return;
            }

            string mode = (string)this.comboBox_validate.SelectedItem;
            string userName, passWd;
            if (mode == "Windows 身份验证")
            {
                userName = "null";
                passWd = "null";
            }
            else
            {
                userName = this.textBox_userName.Text.Trim();
                if (userName == "")
                {
                    MessageBox.Show("请输入用户名");
                    this.textBox_userName.Focus();
                    return;
                }

                passWd = this.textBox_passWd.Text.Trim();
                if (passWd == "")
                {
                    MessageBox.Show("请输入数据库密码，然后重试");
                    this.textBox_passWd.Focus();
                    return;
                }
            }

            //判断是否登陆成功
            DbHelper db = DbHelper.getInstance();
            db.InitParams(server,userName,passWd);

            if (db.isLogin())
            {
                MessageBox.Show("数据库连接成功");
                //判断管理数据库是否存在不存在的话建立管理数据库TDLTE_GUARD
                if (!db.existGuard())
                {
                    TableHelper tb = new TableHelper();
                    tb.createGuardDb();
                }
                
                this.Close();
            }
        }
    }
}
