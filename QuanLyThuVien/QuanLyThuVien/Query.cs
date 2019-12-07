using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyThuVien
{
    class Query
    {
        public int insert_sach(string isbn , string title , string subject , string author , string publisher , DateTime date , int pages , int copies)
        {
            nhancautruyvan qury = new nhancautruyvan();
            SqlCommand cmd = (SqlCommand)qury.getquery("INSERT INTO [Sach]([isbn],[tile],[subject],[author],[publisher],[date],[page],[copies])values('" + isbn + "'," + title + "'," + subject + "'," + author + "'," + publisher + "'," + date + "'," + pages + "'," + copies + "')");
            int t = (int)cmd.ExecuteNonQuery();
            qury.dong();
            return t;
        }

        public int delete_sach(string isbn)
        {
            nhancautruyvan qury = new nhancautruyvan();
            SqlCommand cmd = (SqlCommand)qury.getquery("DELETE form [Sach] where=" + isbn + "");
            int t = (int)cmd.ExecuteNonQuery();
            qury.dong();
            return t;
        }

        public int update_sach(string isbn, string title, string subject, string author, string publisher, DateTime date, int pages, int copies)
        {
            nhancautruyvan qury = new nhancautruyvan();
            SqlCommand cmd = (SqlCommand)qury.getquery("UPDATE [Sach] SET title='" + title + "',subject='" + subject + "',author='" + author + "',publisher='" + publisher + "',date='" + date + "',pages='" + pages + "',copies='" + copies + "' where isbn="+isbn+ " ");
            int t = (int)cmd.ExecuteNonQuery();
            qury.dong();
            return t;
        }
    }
}
