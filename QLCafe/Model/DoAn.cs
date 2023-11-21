using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.Model
{
    internal class DoAn
    {
        private string MaDoAn;
        private string TenDoAn;
        private DanhMuc MaDanhMuc;
        private DanhMuc TenDanhMuc;
        private int SoLuong;
        private float GiaTien;

        public DoAn (string MaDoAn, string TenDoAn, DanhMuc MaDanhMuc, DanhMuc TenDanhMuc, int SoLuong, float GiaTien)
        {
            this.MaDoAn = MaDoAn;
            this.TenDoAn = TenDoAn;
            this.MaDanhMuc = MaDanhMuc;
            this.TenDanhMuc = TenDanhMuc;
            this.SoLuong = SoLuong;
            this.GiaTien = GiaTien;
        }

        public DoAn(string MaDoAn)
        {
            this.MaDoAn = MaDoAn;
        }
        public DoAn() { }

        public DoAn(string maDoAn, string tenDoAn, int soLuong, float giaTien)
        {
            MaDoAn = maDoAn;
            TenDoAn = tenDoAn;
            SoLuong = soLuong;
            GiaTien = giaTien;
        }


        public string getMaDoAn() {  return MaDoAn; }
        public string getTenDoAn() { return TenDoAn;}
        public DanhMuc getMaDanhMuc() {  return MaDanhMuc; }
        public DanhMuc getTenDanhMuc() { return TenDanhMuc;}
        public int getSoLuong() {  return SoLuong; }
        public float getGiaTien() {  return GiaTien; }

        public void setMaDoAn(string MaDoAn) { this.MaDoAn=MaDoAn; }
        public void setTenDoAn(string TenDoAn) { this.TenDoAn=TenDoAn; }
        public void setMaDanhMuc(DanhMuc MaDanhMuc) { this.MaDanhMuc=MaDanhMuc; }
        public void setTenDanhMuc(DanhMuc TenDanhMuc) { this.TenDanhMuc = TenDanhMuc;  }
        public void setSoLuong(int SoLuong) { this.SoLuong=SoLuong; }
        public void setGiaTien(float GiaTien) { this.GiaTien=GiaTien; }
    }
}
