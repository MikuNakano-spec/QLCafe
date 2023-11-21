using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using QLCafe.Model;
using QLCafe.Util;

namespace QLCafe.Controller
{
    internal class DoAnController
    {
        List<DoAn> dsDoAn;

        public DoAnController()
        {
            dsDoAn = new List<DoAn>();
        }

        //Hàm hiển thị danh sách lên DataGridView
        public List<DoAn> Load()
        {
            dsDoAn.Clear();
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DoAn", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string MaDoAn = reader["MaDoAn"].ToString();
                    string TenDoAn = reader["TenDoAn"].ToString();
                    int SoLuong = (int)reader["SoLuong"];
                    float GiaTien = float.Parse(reader["GiaTien"].ToString());
                    DoAn DoAn = new DoAn(MaDoAn, TenDoAn, SoLuong, GiaTien);
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
        public bool Insert(DoAn DoAn)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO DoAn( MaDoAn, TenDoAn, SoLuong, GiaTien) " +
                    "VALUES('" + DoAn.getMaDoAn() + "',N'" + DoAn.getTenDoAn() +
                    "','" + DoAn.getSoLuong() + "','" + DoAn.getGiaTien() + "');", conn);
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
        public bool Edit(DoAn DoAn)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE DoAn SET TenDoAn = N'" + DoAn.getTenDoAn() + "', SoLuong = " + DoAn.getSoLuong() + 
                    ", GiaTien = '" + DoAn.getGiaTien() + "' WHERE MaDoAn = '" + DoAn.getMaDoAn() + "';", conn);
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
        public bool Delete(DoAn DoAn)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM DoAn WHERE MaDoAn = '" + DoAn.getMaDoAn() + "';", conn);
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
        public List<DoAn> Find(DoAn DoAn)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                dsDoAn.Clear();
                int count = 0;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DoAn WHERE MaDoAn = '" + DoAn.getMaDoAn() + "';", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string MaDoAn = reader["MaDoAn"].ToString();
                    string TenDoAn = reader["TenDoAn"].ToString();
                    int SoLuong = (int)reader["SoLuong"];
                    float GiaTien = float.Parse(reader["GiaTien"].ToString());
                    DoAn = new DoAn(MaDoAn, TenDoAn, SoLuong, GiaTien);
                    dsDoAn.Add(DoAn);
                    count++;
                }

                if (count > 0)
                {
                    return dsDoAn;
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
            return dsDoAn;
        }
    }
}

