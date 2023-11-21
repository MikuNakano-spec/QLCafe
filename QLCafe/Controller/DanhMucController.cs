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
    internal class DanhMucController
    {
        List<DanhMuc> dsDanhMuc;

        public DanhMucController()
        {
            dsDanhMuc = new List<DanhMuc>();
        }

        //Hàm hiển thị danh sách lên DataGridView
        public List<DanhMuc> Load()
        {
            dsDanhMuc.Clear();
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DanhMuc", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string MaDanhMuc = reader["MaDanhMuc"].ToString();
                    string TenDanhMuc = reader["TenDanhMuc"].ToString();
                    DanhMuc DanhMuc = new DanhMuc(MaDanhMuc, TenDanhMuc);
                    dsDanhMuc.Add(DanhMuc);
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
            return dsDanhMuc;
        }

        //Hàm chức năng thêm dữ liệu
        public bool Insert(DanhMuc DanhMuc)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO DanhMuc( MaDanhMuc, TenDanhMuc) " +
                    "VALUES('" + DanhMuc.getMaDanhMuc() + "',N'" + DanhMuc.getTenDanhMuc() + "');", conn);
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
        public bool Edit(DanhMuc DanhMuc)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE DanhMuc SET TenDanhMuc = N'" + DanhMuc.getTenDanhMuc() + 
                    "' WHERE MaDanhMuc = '" + DanhMuc.getMaDanhMuc() + "';", conn);
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
        public bool Delete(DanhMuc DanhMuc)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM DanhMuc WHERE MaDanhMuc = '" + DanhMuc.getMaDanhMuc() + "';", conn);
                if (MessageBox.Show("Bạn chắc rằng bạn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
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
        public List<DanhMuc> Find(DanhMuc DanhMuc)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                dsDanhMuc.Clear();
                int count = 0;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DanhMuc WHERE MaDanhMuc = '" + DanhMuc.getMaDanhMuc() + "';", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string MaDanhMuc = reader["MaDanhMuc"].ToString();
                    string TenDanhMuc = reader["TenDanhMuc"].ToString();
                    DanhMuc = new DanhMuc(MaDanhMuc, TenDanhMuc);
                    dsDanhMuc.Add(DanhMuc);
                    count++;
                }

                if (count > 0)
                {
                    return dsDanhMuc;
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
            return dsDanhMuc;
        }
    }
}
