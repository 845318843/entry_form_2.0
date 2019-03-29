using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class LoginDAL
    {
        SqlDb db = new SqlDb();
        //用户登录
        public bool Login(string name, string pwd)
        {
            string strsql = "select UserName from Users where UserName=@UserName and Pwd=@Pwd";
            SqlParameter[] paras ={new SqlParameter("@UserName",name),
                                 new SqlParameter("@Pwd",pwd)
                                  };
            DataTable dt = db.FillDt(strsql,paras);
            if (dt.Rows.Count > 0)
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
