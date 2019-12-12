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
    public partial class Login : Form
    {
        ConnectSQL con = new ConnectSQL();
        public Login()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = con.GetData("select capnguoidung from quanly where username='"+txtName.Text+"'and password='"+txtPass.Text+"';");
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QuanLySach fr = new QuanLySach(dt.Rows[0][0].ToString());
                fr.ShowDialog();
                this.Hide();
            }
            else
            {
                this.lbstatus.ForeColor = Color.Red;
                this.lbstatus.Text = "Tài khoản sai tài khoản hoặc mật khẩu";
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            QuanLySach fr = new QuanLySach();
            fr.Show();
            this.Hide();
        }
    }
}
