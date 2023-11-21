using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.Model
{
    internal class HoaDon
    {
        private string MaHoaDon;
        private string TenNguoiNhap;
        private TaiKhoan MaTaiKhoan;
        private TaiKhoan TenTaiKhoan;
        private DateTime NgayHoaDon;
        
        public HoaDon(string MaHoaDon, string TenNguoiNhap, TaiKhoan MaTaiKhoan, TaiKhoan TenTaiKhoan, DateTime NgayHoaDon)
        {
            this.MaHoaDon = MaHoaDon;
            this.TenNguoiNhap = TenNguoiNhap;
            this.MaTaiKhoan = MaTaiKhoan;
            this.TenTaiKhoan = TenTaiKhoan;
            this.NgayHoaDon = NgayHoaDon;
        }

        public HoaDon() { }

        public string getMaHoaDon() {  return MaHoaDon; }
        public string getTenNguoiNhap() {  return TenNguoiNhap; }
        public TaiKhoan getMaTaiKhoan() {  return MaTaiKhoan; }
        public TaiKhoan getTenTaiKhoan() { return TenTaiKhoan;}
        public DateTime getNgayHoaDon() { return NgayHoaDon;}

        public void setMaHoaDon(string MaHoaDon) { this.MaHoaDon=MaHoaDon; }
        public void setTenNguoiNhap(string TenNguoiNhap) { this.TenNguoiNhap=TenNguoiNhap; }
        public void setMaTaiKhoan(TaiKhoan MaTaiKhoan) { this.MaTaiKhoan=MaTaiKhoan; }
        public void setTenTaiKhoan(TaiKhoan TenTaiKhoan) { this.TenTaiKhoan = TenTaiKhoan; }
        public void setNgayHoaDon(DateTime NgayHoaDon) { this.NgayHoaDon=NgayHoaDon; }
    }
}
