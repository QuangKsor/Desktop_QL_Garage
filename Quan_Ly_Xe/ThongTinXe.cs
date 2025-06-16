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
    public partial class ThongTinXe : Form
    {
        public ThongTinXe()
        {
            InitializeComponent();
            loadDataBienSo();
        }
        private void loadData()
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QuanLy_Gara; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM XE";
                var adapter = new SqlDataAdapter(sql, conn);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView_0993.DataSource = table;
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadDataBienSo()
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QuanLy_Gara; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string sql = "SELECT BienSo FROM XE";
                var adapter = new SqlDataAdapter(sql, conn);
                var table = new DataTable();
                adapter.Fill(table);

                cmboxBienSo_0993.DataSource = table;
                cmboxBienSo_0993.DisplayMember = "BienSo";
                cmboxBienSo_0993.ValueMember = "BienSo";
                cmboxBienSo_0993.SelectedIndex = -1;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHienThi_0993_Click(object sender, EventArgs e)
        {
            loadData();
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

        private void btnThem_0993_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QuanLy_Gara; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string bienSo = cmboxBienSo_0993.Text;
                string hoTen = txtHoTen_0993.Text;
                string nhanHieu = txtNhanHieu_0993.Text;
                string loaiXe = txtLoaiXe_0993.Text;
                string soDT = txtSDT_0993.Text;
                string diaChi = txtDiaChi_0993.Text;

                string sql = "INSERT INTO XE(BienSo, HoTenKhachHang, NhanHieu, LoaiXe, SoDienThoai, DiaChi) " +
                    "VALUES(@BienSo, @HoTenKhachHang, @NhanHieu, @LoaiXe, @SoDienThoai, @DiaChi)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@BienSo", bienSo);
                cmd.Parameters.AddWithValue("@HoTenKhachHang", hoTen);
                cmd.Parameters.AddWithValue("@NhanHieu", nhanHieu);
                cmd.Parameters.AddWithValue("@LoaiXe", loaiXe);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDT);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataBienSo();
                loadData();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QuanLy_Gara; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string bienSo = cmboxBienSo_0993.Text;
                string hoTen = txtHoTen_0993.Text;
                string nhanHieu = txtNhanHieu_0993.Text;
                string loaiXe = txtLoaiXe_0993.Text;
                string soDT = txtSDT_0993.Text;
                string diaChi = txtDiaChi_0993.Text;

                if (bienSo.Equals(""))
                {
                    MessageBox.Show("Vui lòng chọn biển số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                else 
                {
                    string sql = "UPDATE XE SET BienSo = @BienSo, HoTenKhachHang = @HoTenKhachHang, NhanHieu = @NhanHieu, " +
                    "LoaiXe = @LoaiXe, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi WHERE BienSo = @BienSo";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@BienSo", bienSo);
                    cmd.Parameters.AddWithValue("@HoTenKhachHang", hoTen);
                    cmd.Parameters.AddWithValue("@NhanHieu", nhanHieu);
                    cmd.Parameters.AddWithValue("@LoaiXe", loaiXe);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDT);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnXoa_0993_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QuanLy_Gara; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string bienSo = cmboxBienSo_0993.Text;
                
                if(MessageBox.Show("Bạn có chắc muốn xoá thông tin xe này không?", "Xác nhận", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Xoá trong bảng chi tiết
                    string sqlChiTiet = "DELETE FROM CHITIET WHERE BienSo = @BienSo";

                    SqlCommand command = new SqlCommand(sqlChiTiet, conn);
                    command.Parameters.AddWithValue("@BienSo", bienSo);
                    command.ExecuteNonQuery();

                    //Xoá trong bảng xe
                    string sqlXe = "DELETE FROM XE WHERE BienSo = @BienSo";

                    SqlCommand command1 = new SqlCommand(sqlXe, conn);
                    command1.Parameters.AddWithValue("@BienSo", bienSo);
                    int rows = command1.ExecuteNonQuery();
                    
                    if(rows > 0)
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataBienSo();
                        loadData();
                        
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công!", "Lỗi");
                    }
                }
     
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}
