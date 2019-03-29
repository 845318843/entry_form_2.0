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


    public class BackUpDAL
    {

        public SqlConnection conn = null;
        //public SqlConnection connmaster = null;
        public SqlCommand cmd = null;
        //public SqlCommand cmdmaster = null;
        public BackUpDAL()
        {
            conn = new SqlConnection(@"server=.;DataBase=JZT_SignUp;uid=sa;pwd=123456");
            cmd = new SqlCommand();
            
            cmd.Connection = conn;
            

        }

        //备份数据库
        public bool BackUp()
        {
            try
            {
                conn.Close();
                conn.Open();
                string path = "D:\\Back\\JZT_SignUp.bak";
                string strsql = @"use master;backup database JZT_SignUp to disk =N" + "'" + path + "'" + "with format ";
                cmd = new SqlCommand(strsql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }



        //还原数据库
        public bool RoolBack()
        {
            //更换连接
            conn = new SqlConnection(@"server=.;database=master;uid=sa;pwd=123456");
            //关闭当前数据库
            string closestr = "alter database [JZT_SignUp] set offline with rollback immediate";//先关闭数据库
            cmd.Connection = conn;
            conn.Close();
            conn.Open();
            cmd = new SqlCommand(closestr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();



            string path = "D:\\Back\\JZT_SignUp.bak";//源路径
            string mdfsavepath = "D:\\Back1\\JZT_SignUp.mdf";
            string logsavepath = "D:\\Back1\\JZT_SignUp.log";
            //string strsql = "restore database JZT_SignUp from disk= N'D:\\Back\\JZT_SignUp.bak' WITH MOVE JZT_SignUp to N'D:\\Back1\\JZT_SignUp.mdf' MOVE JZT_SignUp_Log to N'D:\\Back1\\JZT_SignUp.log'";
            string strsql = @"restore database JZT_SignUp  from disk=N" + "'" + path + "'";
            strsql += "With Move 'JZT_SignUp' to N" + "'" + mdfsavepath + "'"+",";
            strsql += "MOVE 'JZT_SignUp_log' to N" + "'" + logsavepath + "',REPLACE,recovery";
            try
            {
                conn.Close();
                conn.Open();
                cmd = new SqlCommand(strsql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                //打开，继续使用
                string openstr = "alter database [JZT_SignUp] set online";//再打开数据库
                conn.Open();
                cmd = new SqlCommand(openstr, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                
            }
            catch(Exception e)
            {
            return false;
            }
            return true;
        }
    }
}
