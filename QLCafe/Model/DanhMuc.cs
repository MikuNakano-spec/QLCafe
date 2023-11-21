using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.Model
{
    internal class DanhMuc
    {
        private string MaDanhMuc;
        private string TenDanhMuc;

        public DanhMuc() { }

        public DanhMuc(string MaDanhMuc, string TenDanhMuc)
        {
            this.MaDanhMuc = MaDanhMuc;
            this.TenDanhMuc = TenDanhMuc;
        }

        public string getMaDanhMuc() {  return MaDanhMuc; }
        public void setMaDanhMuc(string MaDanhMuc) { this.MaDanhMuc = MaDanhMuc; }

        public string getTenDanhMuc() { return TenDanhMuc; }
        public void setTenDanhMuc(string  TenDanhMuc) { this.TenDanhMuc = TenDanhMuc ; }
    }
}
