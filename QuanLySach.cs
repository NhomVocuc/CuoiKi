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
    public partial class QuanLySach : Form
    {
        SqlConnection con;
        string userid = "", username = "", password = "", capnguoidung = "";

        public string Userid { get => userid; set => userid = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Capnguoidung { get => capnguoidung; set => capnguoidung = value; }

        public QuanLySach()
        {
            InitializeComponent();

        }
        public QuanLySach(string capnguoidung)
        {
            InitializeComponent();
            this.capnguoidung = capnguoidung;
        }
        private void QuanLySach_Load(object sender, EventArgs e)
        {   
            string conString = ConfigurationManager.ConnectionStrings["Sach"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            load();
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (capnguoidung == "Book")
            {
                string sql = "INSERT INTO Sach VALUES (@isbn,@title,@subject,@author,@publisher,@date,@pages,@copies)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("isbn", txtMS.Text);
                cmd.Parameters.AddWithValue("title", txtTS.Text);
                cmd.Parameters.AddWithValue("subject", txtCD.Text);
                cmd.Parameters.AddWithValue("author", txtTG.Text);
                cmd.Parameters.AddWithValue("publisher", txtNXB.Text);
                cmd.Parameters.AddWithValue("date", txtDate.Text);
                cmd.Parameters.AddWithValue("pages", txtPage.Text);
                cmd.Parameters.AddWithValue("copies", txtCopy.Text);
                cmd.ExecuteNonQuery();
                load();
            }
            else
            {
                MessageBox.Show("Không được sử dụng");
            }
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {

            if (capnguoidung == "Book")
            {
                string sql = "UPDATE Sach SET title=@title , subject=@subject , author=@author , publisher=@publisher , date=@date , pages=@pages , copies=@copies WHERE isbn=@isbn";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("isbn", txtMS.Text);
                cmd.Parameters.AddWithValue("title", txtTS.Text);
                cmd.Parameters.AddWithValue("subject", txtCD.Text);
                cmd.Parameters.AddWithValue("author", txtTG.Text);
                cmd.Parameters.AddWithValue("publisher", txtNXB.Text);
                cmd.Parameters.AddWithValue("date", txtDate.Text);
                cmd.Parameters.AddWithValue("pages", txtPage.Text);
                cmd.Parameters.AddWithValue("copies", txtCopy.Text);
                cmd.ExecuteNonQuery();
                load();
            }
            else
            {
                MessageBox.Show("Không được sử dụng");
            }
        }

        private void Btndel_Click(object sender, EventArgs e)
        {

            if (capnguoidung == "Book")
            {
                string sql = "DELETE FROM Sach  WHERE isbn=@isbn";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("isbn", txtMS.Text);
                cmd.Parameters.AddWithValue("title", txtTS.Text);
                cmd.Parameters.AddWithValue("subject", txtCD.Text);
                cmd.Parameters.AddWithValue("author", txtTG.Text);
                cmd.Parameters.AddWithValue("publisher", txtNXB.Text);
                cmd.Parameters.AddWithValue("date", txtDate.Text);
                cmd.Parameters.AddWithValue("pages", txtPage.Text);
                cmd.Parameters.AddWithValue("copies", txtCopy.Text);
                cmd.ExecuteNonQuery();
                load();
            }
            else
            {
                MessageBox.Show("Không được sử dụng");
            }
        }

        private void QuanLySach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ok;
            ok = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok == DialogResult.No)
            {
                e.Cancel = true;
            }
            Application.Exit();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtTS.Text.Length > 0)
            {
                string sql = "Select * FROM Sach WHERE title like @title";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("title", txtTS.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            if (txtCD.Text.Length > 0)
            {
                string sql = "Select * FROM Sach WHERE subject like @subject";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("subject", txtTS.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            if (txtTG.Text.Length > 0)
            {
                string sql = "Select * FROM Sach WHERE author like @author";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("author", txtTS.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            if (txtNXB.Text.Length > 0)
            {
                string sql = "Select * FROM Sach WHERE publisher like @publisher";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("publisher", txtNXB.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            if (txtDate.Text.Length > 0)
            {
                string sql = "Select * FROM Sach WHERE date like @date";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("date", txtDate.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtMS.Text = row.Cells[0].Value.ToString();
                txtTS.Text = row.Cells[1].Value.ToString();
                txtCD.Text = row.Cells[2].Value.ToString();
                txtTG.Text = row.Cells[3].Value.ToString();
                txtNXB.Text = row.Cells[4].Value.ToString();
                txtDate.Text = row.Cells[5].Value.ToString();
                txtPage.Text = row.Cells[6].Value.ToString();
                txtCopy.Text = row.Cells[7].Value.ToString();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            load();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if(capnguoidung == "User")
            {
                QuanLyNguoiDung fr = new QuanLyNguoiDung();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền vào đây");
            }
        }

        private void load()
        {
            String sql = "SELECT * FROM Sach";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
