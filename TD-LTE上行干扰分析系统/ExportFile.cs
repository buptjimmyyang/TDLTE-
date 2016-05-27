using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_LTE上行干扰分析系统
{
    /// <summary>
    /// 数据导出文件
    /// yang
    /// 16. 5.26
    /// </summary>
    class ExportFile
    {
        //总行数
        public int totalNum = 0;
        //已经完成的行数
        public int currentNum = 0;
        
        //导出到txt
       public  int exportToTxt(DataTable dv, string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding("gb2312"));
            try
            {
                for (int i = 0; i < dv.Columns.Count - 1; i++)
                    sw.Write(dv.Columns[i].ColumnName + "\t");
                sw.WriteLine(dv.Columns[dv.Columns.Count - 1].ColumnName);

                totalNum = dv.Rows.Count;

                foreach (DataRow row in dv.Rows)
                {
                    currentNum++;


                    int colIndex = 0;
                    foreach (DataColumn col in dv.Columns)
                    {
                        if (colIndex != dv.Columns.Count - 1)
                        {
                            if (col.DataType == System.Type.GetType("System.DateTime"))
                            {
                                sw.Write(Convert.ToDateTime(row[col.ColumnName]).ToShortDateString() + "\t");
                            }
                            else
                            {
                                sw.Write(row[col.ColumnName].ToString() + "\t");
                            }
                        }
                        else
                        {
                            sw.WriteLine(row[col.ColumnName].ToString());
                        }
                        colIndex++;
                    }
                }
                sw.Close();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        //多sheet导出到excel
       public int exportToExcel(DataTable dv, string fileName)
       {

           totalNum = dv.Rows.Count;

               int sheetRows = 65535;//设置Sheet的行数,此为最大上限,本来是65536,因表头要占去一行
               int sheetCount = (dv.Rows.Count - 1) / sheetRows + 1;//计算Sheet数
           //必须加上垃圾回收机制
              GC.Collect();//垃圾回收

               Excel.Application excel;
               Excel.Workbook xBk;
               Excel.Worksheet xSt = null;
               excel = new Excel.Application();
               xBk = excel.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);

               //定义循环中要使用的变量
               int dvRowStart;
               int dvRowEnd;
               int rowIndex = 0;
               int colIndex = 0;
               //对全部Sheet进行操作
               for (int sheetIndex = 0; sheetIndex < sheetCount; sheetIndex++)
               {
                   //初始化Sheet中的变量
                   rowIndex = 1;
                   colIndex = 1;
                   //计算起始行
                   dvRowStart = sheetIndex * sheetRows;
                   dvRowEnd = dvRowStart + sheetRows - 1;
                   if (dvRowEnd > dv.Rows.Count - 1)
                   {
                       dvRowEnd = dv.Rows.Count - 1;
                   }
                   //创建一个Sheet
                   if (null == xSt)
                   {
                       xSt = (Excel.Worksheet)xBk.Worksheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
                   }
                   else
                   {
                       xSt = (Excel.Worksheet)xBk.Worksheets.Add(Type.Missing, xSt, 1, Type.Missing);
                   }
                   //设置Sheet的名称
                   xSt.Name = "Expdata";
                   if (sheetCount > 1)
                   {
                       xSt.Name += ((int)(sheetIndex + 1)).ToString();
                   }
                   //取得标题
                   foreach (DataColumn col in dv.Columns)
                   {
                       //设置标题格式
                      // xSt.get_Range(excel.Cells[rowIndex, colIndex], excel.Cells[rowIndex, colIndex]).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter; //设置标题居中对齐
                       //xSt.get_Range(excel.Cells[rowIndex, colIndex], excel.Cells[rowIndex, colIndex]).Font.Bold = true;//设置标题为粗体
                       //填值，并进行下一列
                       excel.Cells[rowIndex, colIndex++] = col.ColumnName;
                   }
                   //取得表格中数量
                   int drvIndex;
                   for (drvIndex = dvRowStart; drvIndex <= dvRowEnd; drvIndex++)
                   {
                       currentNum++;

                       DataRow row = dv.Rows[drvIndex];
                       //新起一行，当前单元格移至行首
                       rowIndex++;
                       colIndex = 1;
                       foreach (DataColumn col in dv.Columns)
                       {
                           if (col.DataType == System.Type.GetType("System.DateTime"))
                           {
                               excel.Cells[rowIndex, colIndex] = (Convert.ToDateTime(row[col.ColumnName].ToString())).ToString("yyyy-MM-dd");
                           }
                           else if (col.DataType == System.Type.GetType("System.String"))
                           {
                               excel.Cells[rowIndex, colIndex] = row[col.ColumnName].ToString();
                           }
                           else
                           {
                               excel.Cells[rowIndex, colIndex] = row[col.ColumnName].ToString();
                           }
                           colIndex++;
                       }
                   }
                   //使用最佳宽度
                   //Excel.Range allDataWithTitleRange = xSt.get_Range(excel.Cells[1, 1], excel.Cells[rowIndex, colIndex - 1]);
                   //allDataWithTitleRange.Select();
                   //allDataWithTitleRange.Columns.AutoFit();
                   //allDataWithTitleRange.Borders.LineStyle = 1;//将导出Excel加上边框
               }
               //设置导出文件在服务器上的文件夹
               //string exportDir="~/ExcelFile/";//注意:该文件夹您须事先在服务器上建好才行
               //设置文件在服务器上的路径
               //string absFileName = System.AppDomain.CurrentDomain.BaseDirectory + "tbAngle.xls";
               xBk.SaveCopyAs(fileName);
               xBk.Close(false, null, null);
               excel.Quit();

               System.Runtime.InteropServices.Marshal.ReleaseComObject(xBk);
               System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
               System.Runtime.InteropServices.Marshal.ReleaseComObject(xSt);

               xBk = null;
               excel = null;
               xSt = null;
              GC.Collect();
               //返回写入服务器Excel文件的路径
               return 1;
       }
       }
    }

