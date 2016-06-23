using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TD_LTE上行干扰分析系统
{
    /// <summary>
    /// 使用无参数的ThreadStart开启多线程
    /// </summary>
    public partial class progress : Form
    {
        private DataTable table = null;
        private string path = "";
        private int txtOrExcel = 0;//0表示txt 1表示excel
        private Thread thread;
        private ExportFile file;
        private int finished = -2;

        public progress(DataTable _table,string _path,int _t)
        {
            InitializeComponent();
            table = _table;
            path = _path;
            txtOrExcel = _t;
            file = new ExportFile();
        }
        //主要作为线程 传递无参数函数
        public void export()
        {
            if (txtOrExcel == 0)
                finished = file.exportToTxt(table, path);
            else
                finished = file.exportToExcel(table,path);
        }
        //取消按钮
        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (thread != null)
            {
                if (thread.IsAlive)
                {
                    thread.Abort();
                    timer1.Stop();
                   // timer1.Enabled = false;
                }
            }
        }

        private void progress_Load(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            thread = new Thread(new ThreadStart(export));
            thread.Start();

            //开始计时
            this.timer1.Start();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //导出完成
            if (finished > -1)
            {
                this.progressBar.Increment(progressBar.Maximum-progressBar.Value);
                this.label1.Text = "数据导出完成";
                this.timer1.Stop();
                this.timer1.Enabled = false;

                this.Close();
                MessageBox.Show("导出完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //数据导出错误
            if (finished == -1)
            {
                this.progressBar.Increment(progressBar.Maximum - progressBar.Value);
                this.label1.Text = "数据导出错误";
                this.timer1.Stop();
                this.timer1.Enabled = false;
                MessageBox.Show("导出失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if (this.progressBar.Value == this.progressBar.Maximum)
            {
                this.progressBar.Value = 0;
            
            }
            this.progressBar.PerformStep();
            this.label1.Text = "";
            this.label1.Text += "处理进度:"+file.currentNum/(file.totalNum+1)*100+"%";
        }
    }
}
