using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Query add = new Query(this);
            add.Show();
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int t1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string t2 = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            /*dataGridView1.CurrentRow.Cells[4].Value = t1 - t2;
            dataGridView1.CurrentRow.Cells[3].Value = t1;
            dataGridView1.CurrentRow.Cells[2].Value = "";*/
            QuanLyThuVien.Query u = new QuanLyThuVien.Query();
            u.update_inv_cat(t1, t2);
            MessageBox.Show("Update Thành Công");
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int t1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            QuanLyThuVien.Query del = new QuanLyThuVien.Query();
            del.Delete_InvCat(t1);
            MessageBox.Show("Đã Xoáa");
            load();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
