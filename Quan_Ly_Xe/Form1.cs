using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Xe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void thongTinXe_0993_Click(object sender, EventArgs e)
        {
            ThongTinXe ttx = new ThongTinXe();
            ttx.Show();
            this.Hide();
        }

        private void thongTinBD_0993_Click(object sender, EventArgs e)
        {
            ThongTinBD ttbd = new ThongTinBD();
            ttbd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sốĐiệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Họ tên: Quang \nSố điện thoại: 0946042795", "Thông tin liên hệ", MessageBoxButtons.OK);
        }
    }
}
