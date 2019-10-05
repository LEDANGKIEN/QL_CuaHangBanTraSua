using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBCon
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=HOANGTHIEN\SQLEXPRESS;Initial Catalog=DSQLTRASUA;Persist Security Info=True;User ID=sa;Password=123456");
        public SqlConnection open()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }
    }
}
