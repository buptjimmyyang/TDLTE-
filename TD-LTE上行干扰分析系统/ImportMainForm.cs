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
using System.Collections;

namespace TD_LTE上行干扰分析系统
{
    public partial class ImportMainForm : Form
    {
        
        //数据库属性列表
        private ArrayList attributeName=null;
        //Excel中数据
        private DataTable excelData=new DataTable();

        private DbHelper db = null;
        private SqlConnection conn = null;

        //判断文件是否读取完毕
        private bool finish = false;
        private int type = 0;
        public ImportMainForm()
        {
            //初始化组件
            InitializeComponent();
            LoadDatabaseFields();
        }

        /*
         * 加载数据库字段至列表
         */
        public void LoadDatabaseFields()
        {
            db = DbHelper.getInstance();
            conn = db.getConn(db.getConnStr(NameUnit.selectDbName));
            string sql = @"select a.name from sys.columns a where a.object_id=object_id('" + NameUnit.importTableName + "')";
            //获取指定数据库的列名
            attributeName = db.getResult(sql,conn);
            //将attributeName写入databaseFieldName
            foreach (String field in this.attributeName)
                this.databaseFieldList.Items.Add(field);
        }


        private void browserButton_Click(object sender, EventArgs e)
        {
            //新建打开文件窗口对象
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //设置过滤器
            openFileDialog.Filter = "(*." + NameUnit.fileType + ")|*." + NameUnit.fileType;
            //设置txtFile的内容
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog.FileName;
            }
        }


        /*
         *  获取excel表格字段或者txt数据
         */
        private void obtainFieldButton_Click(object sender, EventArgs e)
        {
            if (this.txtFile.Text.Equals("") || this.txtFile.Text.Equals(String.Empty))
                return;
            if (NameUnit.fileType.Equals("txt")||NameUnit.fileType.Equals("csv"))
                finish=ImportFile.readFile(ref this.excelData, this.txtFile.Text, NameUnit.fileType,type=1);
            else
                finish = ImportFile.readFile(ref this.excelData, this.txtFile.Text, NameUnit.fileType,type=0);
            //if (this.excelData.Rows.Count == 0)
            //    return;
            //写入列表
            this.excelFieldList.Items.Clear();
            for (int i = 0; i < this.excelData.Columns.Count; i++)
                this.excelFieldList.Items.Add(this.excelData.Columns[i].ColumnName);
        }


        #region 移动操作
        /*
         * 向上移动操作
         */
        private void upButton_Click(object sender, EventArgs e)
        {
            if (this.databaseFieldList.SelectedIndex > 0)
                up_Event(this.databaseFieldList);
            else if (this.excelFieldList.SelectedIndex > 0)
                up_Event(this.excelFieldList);   
        }

        private void up_Event(ListBox listBox)
        {
            string temp = listBox.SelectedItem.ToString();
            listBox.Items[listBox.SelectedIndex] = listBox.Items[listBox.SelectedIndex - 1].ToString();
            listBox.SelectedIndex = listBox.SelectedIndex - 1;
            listBox.Items[listBox.SelectedIndex] = temp;
        }


        /*
         * 向下移动操作
         */
        private void downButton_Click(object sender, EventArgs e)
        {
            if ((databaseFieldList.SelectedIndex < databaseFieldList.Items.Count - 1) && (databaseFieldList.SelectedIndex != -1))
                down_Event(databaseFieldList);
            else if ((excelFieldList.SelectedIndex < excelFieldList.Items.Count - 1) && (excelFieldList.SelectedIndex != -1))
                down_Event(excelFieldList);
        }

        private void down_Event(ListBox listBox)
        {
            string temp = listBox.SelectedItem.ToString();
            listBox.Items[listBox.SelectedIndex] = listBox.Items[listBox.SelectedIndex + 1].ToString();
            listBox.SelectedIndex = listBox.SelectedIndex + 1;
            listBox.Items[listBox.SelectedIndex] = temp;
        }

        private void databaseFieldList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.databaseFieldList.SelectedIndex != -1)
                this.excelFieldList.SelectedIndex = -1;

        }

        private void excelFieldList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.excelFieldList.SelectedIndex != -1)
                this.databaseFieldList.SelectedIndex = -1;

        }


        /*
         * 移除操作
         */
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (this.excelFieldList.SelectedIndex != -1)
                this.excelFieldList.Items.Remove(this.excelFieldList.SelectedItem);
        }

        #endregion

        private bool checkAttribute()
        {
            if (this.databaseFieldList.Items.Count < this.excelFieldList.Items.Count)
            {
                MessageBox.Show("属性设置不合理，请重新设计", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

           
            return true;
        }
        //删除其中无效数据以及PRB范围不合理的数据
        private void validateData(DataTable table)
        {
            List<int> deleteRow = new List<int>();

            for (int i = 0; i < table.Rows.Count;i++ )
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    if (table.Columns[j].ColumnName == "CellName" || table.Columns[j].ColumnName == "Period")
                    {
                        continue;
                    }
                    if(table.Rows[i][j].ToString()=="")
                    {
                        String text = "不合理数据:";
                    for (int k = 0; k < this.excelData.Columns.Count; k++)
                        text += this.excelData.Rows[i][k].ToString();
                    LogHelper.instance().write(text, 0);
                        //删除改行
                    deleteRow.Add(i);
                        break; ;
                    }
                    if (table.Columns[j].ColumnName.Contains("PRB"))
                    {

                        if (float.Parse(table.Rows[i][j].ToString()) > -400 && float.Parse(table.Rows[i][j].ToString()) < 0)
                            continue;
                        String text = "不合理数据:";
                        for (int k = 0; k < this.excelData.Columns.Count; k++)
                            text += this.excelData.Rows[i][j].ToString();
                        LogHelper.instance().write(text, 0);
                        //删除改行
                        deleteRow.Add(i);
                        break;
                    }
                }

                //删除行
                for (int m = deleteRow.Count-1; m>=0; m--)
                    table.Rows.RemoveAt(deleteRow[m]);
            }
        }
        /*
         * 导入数据库
         */
       private void importButton_Click(object sender, EventArgs e)
        {
            if (checkAttribute() == false)
                return;

            //写日志
            LogHelper.instance().write("Start Import " + NameUnit.importTableName+" Data...\nInvalid Data:",0);


            ////将table的列名置为数据库的列名
            for (int i = 0; i < this.excelFieldList.Items.Count; i++)
                this.excelData.Columns[this.excelFieldList.Items[i].ToString()].ColumnName
                    = this.databaseFieldList.Items[i].ToString();


            //在数据库表上建立触发器
            createTrigger();
           //创建索引
            createIndex();
            //选择覆盖模式-->清空数据库
            if (NameUnit.importModel.Equals("OverWriteModel"))
            {
                string deleteSql = "delete from"+NameUnit.importTableName;
                db.execSql(deleteSql,conn);
            }
            
            //批量插入数据·
          //  importDataTable();
            importData(type);
        }

       

        /*
         * 在数据库表上建立触发器
         */
       private void createTrigger()
        {
          
            //检查触发器
            String checkCommand = String.Empty;
            if (!XMLHelper.instatnce().getSqlCommand("Configuration/DataImport/SqlCheckTrigger", ref checkCommand))
                return;
            checkCommand = checkCommand.Replace(":tableName", NameUnit.importTableName);
            db.execSql(checkCommand,conn);


            //定义触发器
            String CreateString = String.Empty;
            String nodePath = "Configuration/DataImport/SqlCreateTrigger_" + NameUnit.importTableName;
            if(!XMLHelper.instatnce().getSqlCommand(nodePath, ref CreateString))
                return;
            db.execSql(CreateString,conn);
        }

        //创建索引
        private void createIndex()
       {
           //检查索引存在则删除该索引
           String checkCommand = String.Empty;
           if (!XMLHelper.instatnce().getSqlCommand("Configuration/checkData/createIndex/checkIndex", ref checkCommand))
               return;

           checkCommand = checkCommand.Replace(":tableName", NameUnit.importTableName);
           db.execSql(checkCommand, conn);


           //定义索引
           String CreateString = String.Empty;
           String nodePath = "Configuration/checkData/createIndex/indexSql" + NameUnit.importTableName;
           if (!XMLHelper.instatnce().getSqlCommand(nodePath, ref CreateString))
               return;
           CreateString = CreateString.Replace(":tableName", NameUnit.importTableName);
           db.execSql(CreateString, conn);
       }
        void importData(int type)
       {
            int i=0;
           if (!importDataTable())
           {

               MessageBox.Show("数据库插入失败，请重试", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }
           if (!this.finish)
           {
               MessageBox.Show("导入数据成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
               return;
           }
               //
            Console.WriteLine("第" + ++i + "次导入");
            while (this.finish)
            {
                this.finish = ImportFile.readFile(ref this.excelData, this.txtFile.Text, NameUnit.fileType,type);
                if (!importDataTable())
                {
                    MessageBox.Show("数据库插入失败，请重试", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Console.WriteLine("第" + ++i + "次导入");
            }
                
            if (!importDataTable())
                MessageBox.Show("数据库插入失败，请重试", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("导入数据成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        /*
         * 批量插入数据
         */
      private bool importDataTable()
        {
            

            List<String> databaseField = new List<string>();
            //将table的列名置为数据库的列名
            for (int i = 0; i < this.excelFieldList.Items.Count; i++)
                databaseField.Add(this.databaseFieldList.Items[i].ToString());
          //删除其中无效数据以及PRB范围不合理的数据
            validateData(excelData);
            //批量插入
            if (db.BatchInsert(NameUnit.importTableName, ref excelData,ref  databaseField,db.getConnStr(NameUnit.selectDbName)))
            {
                return true;
            }
            else
            {
                
                return false;
            }
        }



     

     

     
                                                             
    }
}
