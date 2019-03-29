using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentDAL
    {

        SqlDb db = new SqlDb();
        //public bool Insert(string name, string gender, string banji, string studentid, string phone, string qq, string describe,string time)
        //{
        //    string strsql = "insert into Student(Name,Gender,Banji,Student_ID,Phone,QQ,Describe,Time) values ('" + name + "','" + gender + "','" + banji + "','" + studentid + "','" + phone + "','" + qq + "','" + describe + "','"+time+"')";
        //    if (db.ExecSql(strsql))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public bool IsRepeat(string name, string phone)
        //{
        //    string strsql = "select Name,Phone from Student where Name='" + name + "' and Phone='" + phone + "'";
        //    DataTable dt = db.FillDt(strsql);
        //    if (dt.Rows.Count > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //查询报名信息
        public SqlDataReader Search(string name, string phone)
        {
            string strsql = "select * from Student where Name=@Name and Phone=@Phone ";
            SqlParameter[] paras ={new SqlParameter("@Name",name),
                                 new SqlParameter("@Phone",phone)
                                 };
            SqlDataReader dr = db.GetDataReader_ZUO(strsql,paras);
            return dr;
        }


        //修改报名信息
        public bool Modify(int id, string name, string gender, string student_ID, string phone, string qq, string banji, string describe, string istrain)
        {
            string strsql = "update Student set Name=@Name,Gender=@Gender,Student_ID=@Student_ID,Phone=@Phone,QQ=@QQ,Banji=@Banji,Describe=@Describe,IsTrain=@IsTrain where ID=@ID" ;
            SqlParameter[] paras ={new SqlParameter("@Name",name),
                                 new SqlParameter("@Gender",gender),
                                 new SqlParameter("@Student_ID",student_ID),
                                 new SqlParameter("@Phone",phone),
                                 new SqlParameter("@QQ",qq),
                                 new SqlParameter("@Banji",banji),
                                 new SqlParameter("@Describe",describe),
                                 new SqlParameter("@IsTrain",istrain),
                                 new SqlParameter("@ID",id)
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

        //是否存在
        public DataTable IsExist(string name, string phone)
        {
            string strsql = "select * from Student where Name=@Name and Phone=@Phone ";
            SqlParameter[] paras ={new SqlParameter("@Name",name),
                                 new SqlParameter("Phone",phone)
                                 };
            DataTable dt = db.FillDt(strsql,paras);
            return dt;
        }
    }
}