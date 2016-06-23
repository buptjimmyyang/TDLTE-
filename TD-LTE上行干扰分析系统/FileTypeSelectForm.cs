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
    public partial class FileTypeSelectForm : Form
    {
        private ImportModelSelectForm importModel = null;

        public FileTypeSelectForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //关闭窗口释放资源
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
                NameUnit.fileType = "xls";
            else if (this.radioButton2.Checked)
                NameUnit.fileType = "xlsx";
            else if (this.radioButton3.Checked)
                NameUnit.fileType = "txt";
            else
                NameUnit.fileType = "csv";

            //打开模式窗口
            if (importModel == null || importModel.IsDisposed)
            {
                importModel = new ImportModelSelectForm();
                importModel.Show();
            }

            //关闭当前窗口
            this.Close();
        }

    }
}
