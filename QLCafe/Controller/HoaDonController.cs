using QLCafe.Model;
using QLCafe.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QLCafe.Controller
{
    internal class HoaDonController
    {
        List<HoaDon> dsHoaDon;
        List<DoAn> dsDoAn;
        HoaDonController HDController;

        public HoaDonController()
        {
            dsHoaDon = new List<HoaDon>();
            dsDoAn = new List<DoAn>();
        }


        //Hàm lấy dữ liệu và add vào combobox
        public List<DoAn> Combobox()
        {
            dsDoAn.Clear();
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MaDoAn FROM DoAn", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string MaDoAn = reader["MaDoAn"].ToString();
                    DoAn DoAn = new DoAn(MaDoAn);
                    dsDoAn.Add(DoAn);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hiển thị không thành công", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return dsDoAn;
        }

        //Hàm chức năng thêm dữ liệu
        public bool Insert(System.Windows.Forms.TextBox txtMaHoaDon, DataGridView dgvHoaDon)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ChiTietHD(MaHoaDon, MaDoAn, SoLuong, GiaTien) " +
                "VALUES (" +
                "(SELECT MaHoaDon FROM HoaDon WHERE MaHoaDon = '" + txtMaHoaDon.Text + "'), " +
                "(SELECT MaDoAn FROM DoAn WHERE MaDoAn = '" + dgvHoaDon.Rows[i].Cells[0].Value + "'), " +
                "'" + dgvHoaDon.Rows[i].Cells[4].Value + "', " +
                "'" + dgvHoaDon.Rows[i].Cells[5].Value + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin bị trùng hoặc không đúng", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        //Hàm hiển thị các dữ liệu còn lại khi chọn dữ liệu của Combobox
        public static void HienThiCombobox(DataGridView dgvHoaDon)
        {
            SqlConnection conn = DataHelper.getConnection();

            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT *, ('" + dgvHoaDon.Rows[i].Cells[4].Value + "' * GiaTien) AS 'ThanhTien' FROM DoAn WHERE MaDoAn = N'" + dgvHoaDon.Rows[i].Cells[0].Value + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    dgvHoaDon.Rows[i].Cells[1].Value = reader["TenDoAn"].ToString();
                    dgvHoaDon.Rows[i].Cells[2].Value = reader["MaDanhMuc"].ToString();
                    dgvHoaDon.Rows[i].Cells[3].Value = reader["TenDanhMuc"].ToString();
                    dgvHoaDon.Rows[i].Cells[5].Value = reader["GiaTien"].ToString();
                    dgvHoaDon.Rows[i].Cells[6].Value = reader["ThanhTien"].ToString();
                }
                conn.Close();
            }
        }

        // Hàm hiển thị thông tin hóa đơn
        public static void HienThiPhieuNhap(TextBox txtMaHoaDon,TextBox txtTenNguoiNhap, TextBox txtMaTaiKhoan, 
            TextBox txtTenTaiKhoan,TextBox txtNgayHoaDon)
        {
            SqlConnection conn = DataHelper.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon WHERE MaHoaDon = N'" + txtMaHoaDon.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaHoaDon.Text = reader["MaHoaDon"].ToString();
                txtTenNguoiNhap.Text = reader["TenNguoiNhap"].ToString();
                txtMaTaiKhoan.Text = reader["MaTaiKhoan"].ToString();
                txtTenTaiKhoan.Text = reader["TenTaiKhoan"].ToString();
                txtNgayHoaDon.Text = Convert.ToDateTime(reader["NgayHoaDon"]).ToString("dd/MM/yyyy");
            }
            else
            {
                txtTenNguoiNhap.Text = "";
                txtMaTaiKhoan.Text = "";
                txtTenTaiKhoan.Text = "";
                txtNgayHoaDon.Text = "";
            }
            conn.Close();
        }

        //Hàm chức năng xuất txt 
        public async Task Export(System.Windows.Forms.TextBox txtMaHoaDon, DataGridView dgvHoaDon)
        {
            using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (sdf.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter(new FileStream(sdf.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        foreach (DataGridViewRow row in dgvHoaDon.Rows)
                        {
                            if (row.Cells[0].Value == null)
                            {
                                break;
                            }
                            await tw.WriteLineAsync($"Mã Hóa đơn: {txtMaHoaDon.Text}" +
                                $"\nMã đồ ăn: {row.Cells[0].Value}" +
                                $"\nSố lượng: {row.Cells[4].Value}" +
                                $"\nGiá tiền: {row.Cells[5].Value}" +
                                $"\n----------------------------------------");
                        }
                        MessageBox.Show("Xuất thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
