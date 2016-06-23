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
    public partial class DataDeleteForm : Form
    {
        private string deleteTable;
        private DbHelper db = null;
        private SqlConnection conn = null;
        private string startTime = null;
        private string endTime = null;
        public DataDeleteForm(string _deleteTable)
        {
            InitializeComponent();
            deleteTable = _deleteTable;
            db = DbHelper.getInstance();
            conn = db.getConn(db.getConnStr(NameUnit.selectDbName));

        }
        private void getTime()
        {
            startTime = dateTimePicker_startTime.Text.ToString();
            endTime = dateTimePicker_endTime.Text.ToString();
            startTime += " 0:0:0";
            endTime += " 23:59:59";
        }
        private void button_inquire_Click(object sender, EventArgs e)
        {
            getTime();
            string sql = "select * from " + deleteTable + " where StartTime >='" + startTime + "' and StartTime <= '" + endTime + "'";
            dataGridView_deleteData.DataSource = db.getTable(sql, conn);
            dataGridView_deleteData.Show();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            getTime();
            string sql = "delete from " + deleteTable + " where StartTime >='" + startTime + "' and StartTime <= '" + endTime + "'";
            db.execSql(sql,conn);
            MessageBox.Show("数据删除成功");

            //更新datagridView
            string sql1 = "select * from " + deleteTable + " where StartTime >='" + startTime + "' and StartTime <= '" + endTime + "'";
            dataGridView_deleteData.DataSource = db.getTable(sql1, conn);
            dataGridView_deleteData.Show();
            
        }

        private void DataDeleteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

    }
}
