using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace JZT.JZT_workroom.DAL
{
    public class StudentDAL
    {

        SqlDb db = new SqlDb();
        public bool Insert(string name, string gender, string banji, string studentid, string phone, string qq, string describe,string time)
        {
            string strsql = "insert into Student(Name,Gender,Banji,Student_ID,Phone,QQ,Describe,Time) values (@Name,@Gender,@Banji,@Student_ID,@Phone,@QQ,@Describe,@Time)";
            SqlParameter[] paras = { new SqlParameter("@Name",name),
                                      new SqlParameter("@Gender",gender),
                                  new SqlParameter("@Banji",banji),
                                  new SqlParameter("@Student_ID",studentid),
                                  new SqlParameter("@Phone",phone),
                                  new SqlParameter("@QQ",qq),
                                  new SqlParameter("@Describe",describe),
                                  new SqlParameter("@Time",time)
                                  };
            if (db.executeSql(strsql,paras))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsRepeat(string name, string phone)
        {
            string strsql = "select Name,Phone from Student where Name=@Name and Phone=@Phone";
            SqlParameter[] paras = { new SqlParameter("@Name", name), new SqlParameter("@Phone", phone) };
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

        //获取总人数
        public int GetCount()
        {
            int i = 0;
            string strsql = "select COUNT(ID) as col from Student";
            SqlDataReader sr = db.GetDataReader(strsql);
            while (sr.Read())
            {
                i = Convert.ToInt32(sr["col"].ToString());
                break;
            }
            return i+26;
        }
    }
}