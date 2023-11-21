using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.Model
{
    internal class ChiTietHoaDon
    {
        private HoaDon MaHoaDon;
        private DoAn MaDoAn;
        private int SoLuong;
        private float GiaTien;

        public ChiTietHoaDon(HoaDon MaHoaDon, DoAn MaDoAn, int SoLuong, float GiaTien)
        {
            this.MaHoaDon = MaHoaDon;
            this.MaDoAn = MaDoAn;
            this.SoLuong = SoLuong;
            this.GiaTien = GiaTien;
        }

        public HoaDon getMaHoaDon() { return MaHoaDon; }
        public DoAn getMaDoAn() {  return MaDoAn; }
        public int getSoLuong() {  return SoLuong; }
        public float getGiaTien() {  return GiaTien; }

        public void setMaHoaDon(HoaDon MaHoaDon) { this.MaHoaDon=MaHoaDon; }
        public void setMaDoAn(DoAn MaDoAn) {  this.MaDoAn=MaDoAn;}
        public void setSoLuong(int SoLuong) { this.SoLuong=SoLuong; }
        public void setGiaTien(float GiaTien) { this.GiaTien=GiaTien; }
    }
}
