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
    public partial class ImportModelSelectForm : Form
    {
        //导入主窗口
        private ImportMainForm importMain = null;

        public ImportModelSelectForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            //获取导入数据库的模式
            if (this.OverwriteModelButton.Checked)
               NameUnit.importModel = "OverWriteModel";
            else
                NameUnit.importModel = "AppendModel";

            if (importMain == null || importMain.IsDisposed)
            {
                importMain = new ImportMainForm();
                importMain.Show();
            }
            //关闭当前窗口
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
         
            //关闭当前窗口
            this.Close();
            
        }

    }
}
