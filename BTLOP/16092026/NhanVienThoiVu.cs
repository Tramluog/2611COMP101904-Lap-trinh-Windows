using System;

namespace _16092026
{
    public class NhanVienThoiVu : NhanVien
    {
        private double soGioLam;
        private double luongTheoGio;

        public double SoGioLam
        {
            get { return soGioLam; }
            set
            {
                if (value >= 0)
                    soGioLam = value;
                else
                    throw new ArgumentException(
                        "So gio lam phai >= 0!");
            }
        }

        public double LuongTheoGio
        {
            get { return luongTheoGio; }
            set
            {
                if (value > 0)
                    luongTheoGio = value;
                else
                    throw new ArgumentException(
                        "Luong theo gio phai > 0!");
            }
        }

        public NhanVienThoiVu(
            string maNhanVien,
            string hoTen,
            double luongCoBan,
            double soGioLam,
            double luongTheoGio)
            : base(maNhanVien, hoTen, luongCoBan)
        {
            SoGioLam = soGioLam;
            LuongTheoGio = luongTheoGio;
        }

        public override double TinhLuong()
        {
            return SoGioLam * LuongTheoGio;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine("Loai: Nhan vien thoi vu");
            Console.WriteLine($"Ma NV: {MaNhanVien}");
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"So gio lam: {SoGioLam}");
            Console.WriteLine($"Luong theo gio: {LuongTheoGio:N0} VND");
            Console.WriteLine($"Luong: {TinhLuong():N0} VND");
        }
    }
}