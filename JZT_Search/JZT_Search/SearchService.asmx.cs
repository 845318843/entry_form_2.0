using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using BLL;

namespace JZT_Search
{
    /// <summary>
    /// SearchService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class SearchService : System.Web.Services.WebService
    {
        CountBLL bll = new CountBLL();
        LoginBLL loginbll = new LoginBLL();
        CreateListBLL cbll = new CreateListBLL();
        BackUpBLL backbll=new BackUpBLL();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public string GetInfo(int count)
        {
            if (bll.IsHaveCount(count))
            {
                string result = "";
                DataTable dt = bll.ShowInfo(count);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    result += "<tr>" + "<td>" + dt.Rows[i]["Name"].ToString() + "</td><td>" + dt.Rows[i]["Gender"].ToString() + "</td><td>" + dt.Rows[i]["Banji"].ToString() + "</td><td>" + dt.Rows[i]["Phone"].ToString() + "</td><td>" + dt.Rows[i]["Student_ID"].ToString() + "</td><td>" + dt.Rows[i]["QQ"].ToString() + "</td><td>" + dt.Rows[i]["Describe"].ToString() + "</td><td>"+dt.Rows[i]["IsTrain"].ToString()+"</td><td>" + dt.Rows[i]["Time"].ToString() + "</td><tr>";
                }
                return result;
            }
            else
            {
                return "没有更多信息";
            }
        }


        //获取总人数
        [WebMethod]
        public string GetCount(string id)
        {
            return bll.GetCount().ToString();
        }

        //用户登录
        [WebMethod]
        public string Login(string name,string pwd)
        {
            if (loginbll.Login(name, pwd))
            {
                return "登录成功";
            }
            else
            {
                return "登录失败";
            }
        }


        [WebMethod]
        public string CreateList(int ColumnWidth)
        {
            DataTable dt=cbll.GetTable();
            ColumnWidth = 10;
            DateTime date=DateTime.Now;
            string Title = "九州通报名表单" + date.ToShortDateString();
            string path=Server.MapPath("./file//JZT_SignUp_List.xlsx");
            cbll.createlist(dt, ColumnWidth, Title, path);
            return "";
        }


        [WebMethod]
        public string BackUp()
        {
            if (backbll.BackUp())
            {
                return "备份成功";
            }
            else
            {
                return "备份失败";
            }
        }


        [WebMethod]
        public string RoolBack()
        {
            if (backbll.RoolBack())
            {
                return "还原成功";
            }
            else
            {
                return "还原失败";
            }
        }
    }
}
