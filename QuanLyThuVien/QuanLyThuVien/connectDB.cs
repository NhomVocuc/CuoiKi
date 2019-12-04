using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt1910
{
    class ConnectDB_SQL
    {
        public static string StringconnerDB = null;
        private SqlConnection conn = null;
        public SqlCommand SQLcomand = null;
        public string[] x = new string[2];
        public string[] fail = new string[1];
        public ConnectDB_SQL()

        {
            conn = new SqlConnection();
        }





        public Boolean Fun_connectDB(string User, string Password)
        {
            fail[0] = "fail";
            string connectionString = @"server=PHONG\SQLEXPRESS; database=QuanLyThuVien; user id=sa; password=123";
            conn.ConnectionString = connectionString;
            conn.Open();
            StringconnerDB = String.Copy(connectionString);
            string query = "select workerid, isadmin from worker where login='" + User + "'and Password='" + Password + "'";
            SQLcomand = new SqlCommand(query, conn);
            SqlDataReader reader = SQLcomand.ExecuteReader();
            while (reader.Read())
            {
                x[0] = reader.GetValue(0).ToString();
                x[1] = reader.GetValue(1).ToString();
            }
            if(x[0] != null)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }


        public object Fun_connectDB()
        {
            string connectionString = @"server=PHONG\SQLEXPRESS; database=QuanLyThuVien; user id=sa; password=123";
            conn.ConnectionString = connectionString;
            conn.Open();
            return conn;
        }
        public void closeconnect()
        {
            conn.Close();
            conn.Dispose();
        }
    }
}
