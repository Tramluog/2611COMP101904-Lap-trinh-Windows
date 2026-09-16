using System;

namespace _16092026
{
    public class NhanVien
    {
        private string maNhanVien;
        private string hoTen;
        private double luongCoBan;

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public double LuongCoBan
        {
            get { return luongCoBan; }
            set
            {
                if (value > 0)
                    luongCoBan = value;
                else
                    throw new ArgumentException("Luong co ban phai > 0!");
            }
        }

        public NhanVien(string maNhanVien, string hoTen, double luongCoBan)
        {
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            LuongCoBan = luongCoBan;
        }

        public virtual double TinhLuong()
        {
            return LuongCoBan;
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Ma NV: {MaNhanVien}");
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Luong co ban: {LuongCoBan:N0} VND");
            Console.WriteLine($"Luong: {TinhLuong():N0} VND");
        }
    }
}