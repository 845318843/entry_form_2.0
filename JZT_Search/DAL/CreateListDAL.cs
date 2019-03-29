using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Aspose.Cells;

namespace DAL
{
    public class CreateListDAL
    {

        SqlDb db = new SqlDb();

        /// <summary>
        /// 导出数据
        /// </summary>
        /// <param name="dt">要导出的表</param>
        /// <param name="ColumnWidth">列宽</param>
        /// <param name="Title">标题</param>
        /// <returns>是否导出成功</returns>
        public bool createlist(DataTable dt, int ColumnWidth, string Title,string path)
        {
            //一个工作文件有许多个表，就如打开一个.xls问价，里面会自带三个表sheet1,sheet2,sheet3
            //工作文件就是workbook，工作表是sheet是worksheet
            Workbook wb = new Workbook();//工作文件，即.xls文件
            Worksheet ws = wb.Worksheets[0];//工作表，所有工作表均是workbook的内容
            Cells cell = ws.Cells;
            //定义并获取导出的数据源
            string[,] _report = new string[dt.Rows.Count, dt.Columns.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 1; j < dt.Columns.Count; j++)
                {
                    _report[i, j] = dt.Rows[i][j].ToString();
                }
            }
            //合并第一行单元格  Ranger【范围】
            Range range = cell.CreateRange(0, 0, 1, dt.Columns.Count-1);//参数分别为开始行，开始列，总行数，总列数
            range.Merge();//合并  还有另一种用法，表一Table1，表二Table2，合并两个表可以用Table1.Merge(Table2)
            cell["A1"].PutValue(Title);

            //设置行高
            cell.SetRowHeight(0, 20);

            //设置字体样式
            Style style = wb.Styles[wb.Styles.Add()];
            style.HorizontalAlignment = TextAlignmentType.Center;
            style.Font.Name = "宋体";
            style.Font.IsBold = true;
            style.Font.Size = 12;

            //设置样式
            Style style2 = wb.Styles[wb.Styles.Add()];
            style2.HorizontalAlignment = TextAlignmentType.Center;
            style2.Font.Size = 10;

            //给单元格关联样式
            cell["A1"].SetStyle(style);//运用样式一

            //设置excel列名
            //for (int i = 0; i < dt.Columns.Count; i++)
            //{
                //cell[1, i].PutValue(dt.Columns[i].ToString());
                //cell[1, i].SetStyle(style2);//运用样式二
            cell[1, 0].PutValue("姓名");
            cell[1, 0].SetStyle(style2);
            cell[1, 1].PutValue("性别");
            cell[1, 1].SetStyle(style2);
            cell[1, 2].PutValue("手机号");
            cell[1, 2].SetStyle(style2);
            cell[1, 3].PutValue("QQ");
            cell[1, 3].SetStyle(style2);
            cell[1, 4].PutValue("班级");
            cell[1, 4].SetStyle(style2);
            cell[1, 5].PutValue("学号");
            cell[1, 5].SetStyle(style2);
            cell[1, 6].PutValue("个人描述");
            cell[1, 6].SetStyle(style2);
            cell[1, 7].PutValue("报名时间");
            cell[1, 7].SetStyle(style2);
            cell[1, 8].PutValue("是否参加集训");
            cell[1, 8].SetStyle(style2);
            //}

            //设置单元格内容
            int posstart = 2;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count-1; j++)
                {
                    cell[i + posstart, j].PutValue(_report[i, j+1].ToString());
                    cell[i + posstart, j].SetStyle(style2);
                }
            }

            //设置列宽
            for (int i = 0; i < dt.Columns.Count-1; i++)
            {
                cell.SetColumnWidth(i, Convert.ToDouble(ColumnWidth.ToString()));
            }

            //保存
            wb.Save(path);
            return true;
        }


        public DataTable GetTable()
        {
            string strsql = "select * from Student";
            SqlParameter[] paras = null;
            DataTable dt = db.FillDt(strsql,paras);
            return dt;
        }
    }
}
