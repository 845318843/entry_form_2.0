using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LoginBLL
    {
        LoginDAL dal=new LoginDAL();

        //用户登录
        public bool Login(string name, string pwd)
        {
            return dal.Login(name, pwd);
        }
    }
}
