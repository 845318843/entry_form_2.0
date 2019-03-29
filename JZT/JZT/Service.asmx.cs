using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using JZT.JZT_workroom.BLL;

namespace JZT
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
        public string Insert(string name, string gender, string banji, string studentid, string phone, string qq, string describe,string time)
        {
            if (bll.Insert(name, gender, banji, studentid, phone, qq, describe,time))
            {
                return "报名成功";
            }
            else
            {
                return "报名失败";
            }
        }

        [WebMethod]
        public string IsRepeat(string name, string phone)
        {
            if (bll.IsRepeat(name, phone))
            {
                return "此生已报名，请勿重复";
            }
            else
            {
                return "成功";
            }
        }

        [WebMethod]
        public string GetCount(string id)
        {
            return bll.GetCount().ToString();
        }
    }
}
