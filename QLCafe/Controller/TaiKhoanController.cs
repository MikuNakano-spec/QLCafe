using QLCafe.Model;
using QLCafe.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.Controller
{
    internal class TaiKhoanController
    {
        List<TaiKhoan> dsTaiKhoan;

        public TaiKhoanController()
        {
            dsTaiKhoan = new List<TaiKhoan>();
        }

        //Hàm hiển thị danh sách lên DataGridView
        public List<TaiKhoan> Load()
        {
            dsTaiKhoan.Clear();
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string MaTaiKhoan = reader["MaTaiKhoan"].ToString();
                    string TenTaiKhoan = reader["TenTaiKhoan"].ToString();
                    string MatKhau = reader["MatKhau"].ToString();
                    TaiKhoan TaiKhoan = new TaiKhoan(MaTaiKhoan, TenTaiKhoan, MatKhau);
                    dsTaiKhoan.Add(TaiKhoan);
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
            return dsTaiKhoan;
        }

        //Hàm chức năng thêm dữ liệu
        public bool Insert(TaiKhoan TaiKhoan)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TaiKhoan( MaTaiKhoan, TenTaiKhoan, MatKhau) " +
                    "VALUES('" + TaiKhoan.getMaTaiKhoan() + "',N'" + TaiKhoan.getTenTaiKhoan() +
                    "','" + TaiKhoan.getMatKhau() + "');", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin không chính xác vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        //Hàm hức năng chỉnh sửa 
        public bool Edit(TaiKhoan TaiKhoan)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TaiKhoan SET TenTaiKhoan = N'" + TaiKhoan.getTenTaiKhoan() + 
                    "', MatKhau = '" + TaiKhoan.getMatKhau() + "' WHERE MaTaiKhoan = '" + TaiKhoan.getMaTaiKhoan() + "';", conn);
                if (MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        //Hàm chức năng xóa
        public bool Delete(TaiKhoan TaiKhoan)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM TaiKhoan WHERE MaTaiKhoan = '" + TaiKhoan.getMaTaiKhoan() + "';", conn);
                if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);

                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        //Hàm chức năng tìm kiếm
        public List<TaiKhoan> Find(TaiKhoan TaiKhoan)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                dsTaiKhoan.Clear();
                int count = 0;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE MaTaiKhoan = '" + TaiKhoan.getMaTaiKhoan() + "';", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string MaTaiKhoan = reader["MaTaiKhoan"].ToString();
                    string TenTaiKhoan = reader["TenTaiKhoan"].ToString();
                    string MatKhau = reader["MatKhau"].ToString();
                    TaiKhoan = new TaiKhoan(MaTaiKhoan, TenTaiKhoan, MatKhau);
                    dsTaiKhoan.Add(TaiKhoan);
                    count++;
                }

                if (count > 0)
                {
                    return dsTaiKhoan;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!", "Thông báo!", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return dsTaiKhoan;
        }
    }
}
