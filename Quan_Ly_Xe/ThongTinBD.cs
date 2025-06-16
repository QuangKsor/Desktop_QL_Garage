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

namespace Quan_Ly_Xe
{
    public partial class ThongTinBD : Form
    {
        public ThongTinBD()
        {
            InitializeComponent();
            loadBienSo();
            loadData();
            goiBD();
        }

        private void btnThoat_0993_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDong_0993_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        //Hiển thị dữ liệu biển số
        private void loadBienSo()
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QuanLy_Gara; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string sql = "SELECT DISTINCT x.BienSo FROM XE x " +
                    "LEFT JOIN CHITIET c ON x.BienSo = c.BienSo";
                    
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                cmboxBienSo_0993.DataSource = tb;
                cmboxBienSo_0993.DisplayMember = "BienSo";
                cmboxBienSo_0993.ValueMember = "BienSo";
            }catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Hiển thị gói bảo dưỡng
        private void goiBD()
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QuanLy_Gara; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string sql = "SELECT MaGoi FROM GOI_BAO_DUONG";
                var adapter =  new SqlDataAdapter(sql, conn);
                var tb = new DataTable();
                adapter.Fill(tb);

                cmboxGoiBD_0993.DataSource = tb;
                cmboxGoiBD_0993.DisplayMember = "TenGoi";
                cmboxGoiBD_0993.ValueMember = "MaGoi";
            }catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Hiển thị dữ liệu bảng chi tiết
        private void loadData()
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QuanLy_Gara; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM CHITIET";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);

                dataGridHienThi_0993.DataSource = tb;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLoc_0993_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QuanLy_Gara; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string bienSo = cmboxBienSo_0993.Text;
                string sql = "SELECT x.HoTenKhachHang, x.NhanHieu, c.* FROM XE x " +
                    "JOIN CHITIET c ON x.BienSo = c.BienSo " +
                    "JOIN GOI_BAO_DUONG g ON c.MaGoi = g.MaGoi WHERE x.BienSo = '" + bienSo + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dataGridHienThi_0993.DataSource = tb;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThen_0993_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QuanLy_Gara; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string bienSo = cmboxBienSo_0993.Text;
                string maGoi = cmboxGoiBD_0993.Text.Trim();
                int soKm = int.Parse(txtSoKm_0993.Text);
                string giaTien = txtGiaTien_0993.Text;
                DateTime ngayBD = DateTime.Now;

                string sql = "INSERT INTO CHITIET(BienSo, MaGoi, SoKmBaoDuong, GiaTien, ThoiGianBaoDuong) " +
                    "VALUES(@BienSo, @MaGoi, @SoKmBaoDuong, @GiaTien, @ThoiGianBaoDuong)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@BienSo", bienSo);
                cmd.Parameters.AddWithValue("@MaGoi", maGoi);
                cmd.Parameters.AddWithValue("@SoKmBaoDuong", soKm);
                cmd.Parameters.AddWithValue("@GiaTien", giaTien);
                cmd.Parameters.AddWithValue("@ThoiGianBaoDuong", ngayBD);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData();
            }catch(SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnLamLai_0993_Click(object sender, EventArgs e)
        {
            loadData();
        }

        //Hiển thị giá tiền theo biển số
        private void btnHienThi_0993_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QuanLy_Gara; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string bienSo = cmboxBienSo_0993.Text;

                string sql = "SELECT BienSo, GiaTien FROM CHITIET WHERE BienSo = '"+ bienSo + "'";
                var adp = new SqlDataAdapter(sql, conn);
                var table = new DataTable();
                adp.Fill(table);
                dataGridGiaTien_0993.DataSource = table;
                
                
            }catch(SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close ();
        }

        private void btnXoa_0993_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QuanLy_Gara; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string bienSo = cmboxBienSo_0993.Text;
                if(MessageBox.Show("Bạn có chắc muốn xoá lịch sử bảo dưỡng này không?", "Xác nhận", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "DELETE FROM CHITIET WHERE BienSo = '" + bienSo + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int rows = cmd.ExecuteNonQuery();
                    if(rows > 0)
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnTinhTongTien_0993_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QuanLy_Gara; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string sql = "SELECT SUM(GiaTien) AS TongTien FROM CHITIET ";
                var adp = new SqlDataAdapter(sql, conn);
                var table = new DataTable();
                adp.Fill(table);
                dataGridGiaTien_0993.DataSource = table;
            } catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
