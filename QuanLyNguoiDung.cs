using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace CuoiKi
{
    public partial class QuanLyNguoiDung : Form
    {
        SqlConnection con;
        public QuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void load()
        {
            String sql = "SELECT * FROM quanly";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["quanly"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            load();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtuser.Text = row.Cells[1].Value.ToString();
                txtpass.Text = row.Cells[2].Value.ToString();
                txtcap.Text = row.Cells[3].Value.ToString();

            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO quanly VALUES (@userid,@username,@password,@capnguoidung)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("userid", txtid.Text);
            cmd.Parameters.AddWithValue("username", txtuser.Text);
            cmd.Parameters.AddWithValue("password", txtpass.Text);
            cmd.Parameters.AddWithValue("capnguoidung", txtcap.Text);
            cmd.ExecuteNonQuery();
            load();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE quanly SET username=@username, password=@password, capnguoidung=@capnguoidung where userid=@userid";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("userid", txtid.Text);
            cmd.Parameters.AddWithValue("username", txtuser.Text);
            cmd.Parameters.AddWithValue("password", txtpass.Text);
            cmd.Parameters.AddWithValue("capnguoidung", txtcap.Text);
            cmd.ExecuteNonQuery();
            load();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE from quanly where userid=@userid";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("userid", txtid.Text);
            cmd.Parameters.AddWithValue("username", txtuser.Text);
            cmd.Parameters.AddWithValue("password", txtpass.Text);
            cmd.Parameters.AddWithValue("capnguoidung", txtcap.Text);
            cmd.ExecuteNonQuery();
            load();
        }
    }
}
