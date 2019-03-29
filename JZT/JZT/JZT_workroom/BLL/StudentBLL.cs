using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JZT.JZT_workroom.DAL;

namespace JZT.JZT_workroom.BLL
{
    public class StudentBLL
    {
        StudentDAL dal = new StudentDAL();

        public bool Insert(string name, string gender, string banji, string studentid, string phone, string qq, string describe,string time)
        {
            return dal.Insert(name, gender, banji, studentid, phone, qq, describe,time);
        }

        public bool IsRepeat(string name, string phone)
        {
            return dal.IsRepeat(name, phone);
        }


        public int GetCount()
        {
            return dal.GetCount();
        }
    }
}