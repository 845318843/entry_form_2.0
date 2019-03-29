using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
   public  class BackUpBLL
    {
       BackUpDAL dal = new BackUpDAL();

        //备份数据库
        public bool BackUp()
        {
            return dal.BackUp();
        }



        //还原数据库
        public bool RoolBack()
        {
            return dal.RoolBack();
        }
    }
}
