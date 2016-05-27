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
    public partial class main : Form
    {
        //获取数据库连接实例
        DbHelper db = DbHelper.getInstance();
        //声明登陆窗口
        private DbLogin login = null;
        //声明创建项目窗口
        private ProjectCreate proCreate = null;
        //声明项目查询窗口
        private ProjectInquire proInquire = null;
        private ProjectDelete proDelete = null;



        //1.声明自适应类实例
        private AutomaticSize auto = new AutomaticSize();  
        
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //2
            auto.GetInitialFormSize(this);
            auto.GetAllCrlLocation(this);
            auto.GetAllCrlSize(this);
            //初始化创建数据库参数
            NameUnit.initParams();
        }

        private void main_SizeChanged(object sender, EventArgs e)
        {
            //3
            auto.sizechange(this);
        }

        private void 数据库连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //默认close时窗口为disposed状态
            //显示sql登陆窗口
            if (login == null||login.IsDisposed)
            {
                login = new DbLogin();
                login.Show();
            }


        }

        private void 项目创建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!db.isLoginSql())
            {
                MessageBox.Show("数据库尚未连接，请重新连接数据库");
                return;
            }
            if (proCreate == null || proCreate.IsDisposed)
            {
                proCreate = new ProjectCreate();
                proCreate.Show();
            }

        }

        private void 项目查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!db.isLoginSql())
            {
                MessageBox.Show("数据库尚未连接，请重新连接数据库");
                return;
            }
            if (proInquire == null || proInquire.IsDisposed)
            {
                proInquire = new ProjectInquire();
                proInquire.Show();
            }
        }

        private void 项目删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!db.isLoginSql())
            {
                MessageBox.Show("数据库尚未连接，请重新连接数据库");
                return;
            }
            if (proDelete == null || proDelete.IsDisposed)
            {
                proDelete = new ProjectDelete();
                proDelete.Show();
            }
        }
        
    }
}
