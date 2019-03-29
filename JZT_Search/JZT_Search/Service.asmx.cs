using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BLL;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using Model;

namespace JZT_Search
{
    /// <summary>
    /// Service 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {
        StudentBLL bll = new StudentBLL();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string Search(string name, string phone)
        {
            Student student = new Student(); 
            DataTable dt = bll.IsExist(name, phone);
            if (dt.Rows.Count > 0)
            {
                SqlDataReader sr = bll.Search(name, phone);
                while (sr.Read())
                {
                    student.ID = Convert.ToInt32(sr["ID"].ToString());
                    student.Name = sr["Name"].ToString();
                    student.Gender = sr["Gender"].ToString();
                    student.StudentID = sr["Student_ID"].ToString();
                    student.Phone = sr["Phone"].ToString();
                    student.QQ = sr["QQ"].ToString();
                    student.Banji = sr["Banji"].ToString();
                    student.Describe = sr["Describe"].ToString();
                    student.IsTrain = sr["IsTrain"].ToString();
                    break;
                }
                string str1= "{\"ID\":" + student.ID + ",\"Name\":'" + student.Name + "',\"Gender\":'" + student.Gender + "',\"StudentID\":'" + student.StudentID + "',\"Phone\":'" + student.Phone + "',\"QQ\":'" + student.QQ + "',\"Banji\":'" + student.Banji + "',\"Describe\":'" + student.Describe + "',\"IsTrain\":'"+student.IsTrain+"'}";
                return str1;
            }
            else
            {
                return "该生未报名";
            }
        }

        [WebMethod]
        public string Modify(int id, string name, string gender, string student_ID, string phone, string qq, string banji, string describe,string istrain)
        {
            if (bll.Modify(id, name, gender, student_ID, phone, qq, banji, describe,istrain))
            {
                return "修改成功";
            }
            else
            {
                return "修改失败";
            }
        }
    }
}
