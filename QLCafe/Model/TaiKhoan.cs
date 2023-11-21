using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.Model
{
    internal class TaiKhoan
    {
        private string MaTaiKhoan;
        private string TenTaiKhoan;
        private string MatKhau;

        public TaiKhoan(string MaTaiKhoan, string TenTaiKhoan, string MatKhau)
        {
            this.MaTaiKhoan = MaTaiKhoan;
            this.TenTaiKhoan = TenTaiKhoan;
            this.MatKhau = MatKhau;
        }

        public TaiKhoan() { }

        public string getMaTaiKhoan() {  return MaTaiKhoan; }
        public string getTenTaiKhoan() { return TenTaiKhoan;}
        public string getMatKhau() {  return MatKhau; }

        public void setMaTaiKhoan(string MaTaiKhoan) { this.MaTaiKhoan= MaTaiKhoan; }
        public void setTenTaiKhoan(string TenTaiKhoan) { this.TenTaiKhoan = TenTaiKhoan; }
        public void setMatKhau(string MatKhau) { this.MatKhau= MatKhau; }

    }
}
