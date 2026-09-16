using System;

namespace _16092026
{
    public class NhanVienVanPhong : NhanVien
    {
        private int soNgayLamViec;

        public int SoNgayLamViec
        {
            get { return soNgayLamViec; }
            set
            {
                if (value >= 0 && value <= 31)
                    soNgayLamViec = value;
                else
                    throw new ArgumentException(
                        "So ngay lam viec phai tu 0 den 31!");
            }
        }

        public NhanVienVanPhong(
            string maNhanVien,
            string hoTen,
            double luongCoBan,
            int soNgayLamViec)
            : base(maNhanVien, hoTen, luongCoBan)
        {
            SoNgayLamViec = soNgayLamViec;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + SoNgayLamViec * 200000;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine("Loai: Nhan vien van phong");
            Console.WriteLine($"Ma NV: {MaNhanVien}");
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Luong co ban: {LuongCoBan:N0} VND");
            Console.WriteLine($"So ngay lam viec: {SoNgayLamViec}");
            Console.WriteLine($"Luong: {TinhLuong():N0} VND");
        }
    }
}