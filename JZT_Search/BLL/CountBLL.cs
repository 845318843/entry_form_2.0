using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class CountBLL
    {
        CountDAL dal = new CountDAL();
        //每次显示10条信息
        public DataTable ShowInfo(int count)
        {
                return dal.ShowInfo(count);
        }

        //判断是否有信息
        public bool IsHaveCount(int count)
        {
            if (dal.ShowInfo(count).Rows.Count > 0)
                return true;
            else
                return false;
        }


        //获取总人数
        public int GetCount()
        {
            return dal.GetCount();
        }
    }
}
