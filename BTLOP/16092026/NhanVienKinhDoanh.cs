using System;

namespace _16092026
{
    public class NhanVienKinhDoanh : NhanVien
    {
        private double doanhSo;

        public double DoanhSo
        {
            get { return doanhSo; }
            set
            {
                if (value >= 0)
                    doanhSo = value;
                else
                    throw new ArgumentException(
                        "Doanh so phai >= 0!");
            }
        }

        public NhanVienKinhDoanh(
            string maNhanVien,
            string hoTen,
            double luongCoBan,
            double doanhSo)
            : base(maNhanVien, hoTen, luongCoBan)
        {
            DoanhSo = doanhSo;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + 0.05 * DoanhSo;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine("Loai: Nhan vien kinh doanh");
            Console.WriteLine($"Ma NV: {MaNhanVien}");
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Luong co ban: {LuongCoBan:N0} VND");
            Console.WriteLine($"Doanh so: {DoanhSo:N0} VND");
            Console.WriteLine($"Luong: {TinhLuong():N0} VND");
        }
    }
}