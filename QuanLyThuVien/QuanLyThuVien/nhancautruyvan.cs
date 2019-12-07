using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyThuVien
{
    class nhancautruyvan
    {
        connectDB cn;
        public  nhancautruyvan()
        {
            cn = new connectDB();
        }
       public object getquery(string t)
        {
            SqlConnection ketnoi_SQL = new SqlConnection();

            ketnoi_SQL = (SqlConnection)cn.Fun_connectDB();
            SqlCommand myCommand = new SqlCommand(t, ketnoi_SQL);
            // Mark the Command as a Text
            myCommand.CommandType = CommandType.Text;
           
            return myCommand;
        }
       public void dong()
       {
           cn.closeconnect();
 
       }
    }

}
