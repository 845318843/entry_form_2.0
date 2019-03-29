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
    public class CountDAL
    {
        SqlDb db = new SqlDb();
        //每次显示10条信息
        public DataTable ShowInfo(int count)
        {
            string strsql = "select top 10 * from Student where Time not in(select top "+(count-1)*10+" Time from Student  order by Time desc) order by Time desc";
            SqlParameter[] paras = {  };
            DataTable dt = db.FillDt(strsql,paras);
            return dt;
        }


        //获取总人数
        public int GetCount()
        {
            int  i = 0;
            string strsql = "select COUNT(ID) as col from Student";
            SqlDataReader sr=db.GetDataReader(strsql);
            while(sr.Read())
            {
            i=Convert.ToInt32(sr["col"].ToString());
                break;
            }
            return i;
        }
    }
}
