using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BLL
{
    public class StudentBLL
    {
        StudentDAL dal = new StudentDAL();

        //查询报名信息
        public SqlDataReader Search(string name, string phone)
        {
            return dal.Search(name, phone);
        }


        //修改报名信息
        public bool Modify(int id, string name, string gender, string student_ID, string phone, string qq, string banji, string describe, string istrain)
        {
            return dal.Modify(id, name, gender, student_ID, phone, qq, banji, describe,istrain);
        }

        //是否存在
        public DataTable IsExist(string name, string phone)
        {
            return dal.IsExist(name, phone);
        }
    }
}