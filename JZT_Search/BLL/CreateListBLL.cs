using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using DAL;

namespace BLL
{
    public class CreateListBLL
    {
        CreateListDAL dal = new CreateListDAL();
        public bool createlist(DataTable dt, int ColumnWidth, string Title, string path)
        {
            return dal.createlist(dt, ColumnWidth, Title, path);
        }

        public DataTable GetTable()
        {
            return dal.GetTable();
        }
    }
}
