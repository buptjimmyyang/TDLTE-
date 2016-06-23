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
    public partial class BusinessMain : Form
    {
        private FileTypeSelectForm fileType = null;

        private DataDeleteForm deleteModel = null;
        private DataDeleteForm deleteRecognition = null;
        public BusinessMain()
        {
            InitializeComponent();
        }

        private void BusinessMain_Load(object sender, EventArgs e)
        {

        }

        private void 建模样本导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileType == null || fileType.IsDisposed)
            {
                NameUnit.importTableName = "tbPRBSample_Modeling";
                fileType = new FileTypeSelectForm();
                fileType.Show();
            }
        }

        private void 识别数据导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileType == null || fileType.IsDisposed)
            {
                NameUnit.importTableName = "tbPRBSample_Recognition";
                fileType = new FileTypeSelectForm();
                fileType.Show();
            }
        }

        private void 建模样本删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deleteModel == null || deleteModel.IsDisposed)
            {

                deleteModel = new DataDeleteForm("tbPRBSample_Modeling");
                deleteModel.Show();
            }
        }

        private void 识别数据导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deleteModel == null || deleteModel.IsDisposed)
            {

                deleteModel = new DataDeleteForm("tbPRBSample_Recognition");
                deleteModel.Show();
            }
        }
    }
}
