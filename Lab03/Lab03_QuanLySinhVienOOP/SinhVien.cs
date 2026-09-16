using System;

namespace Lab03_QuanLySinhVienOOP
{
    public class SinhVien : Nguoi
    {
        public string MaSinhVien { get; set; }
        public string MaLop { get; set; }

        private double diemTrungBinh;

        public double DiemTrungBinh
        {
            get => diemTrungBinh;

            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(DiemTrungBinh),
                        "Diem trung binh phai tu 0 den 10."
                    );
                }

                diemTrungBinh = value;
            }
        }

        public SinhVien(
            string maSinhVien,
            string hoTen,
            DateTime ngaySinh,
            string maLop,
            double diemTrungBinh)
            : base(hoTen, ngaySinh)
        {
            MaSinhVien = maSinhVien;
            MaLop = maLop;
            DiemTrungBinh = diemTrungBinh;
        }

        public string XepLoai()
        {
            if (DiemTrungBinh >= 8)
                return "Gioi";

            if (DiemTrungBinh >= 6.5)
                return "Kha";

            if (DiemTrungBinh >= 5)
                return "Dat";

            return "Chua dat";
        }

        public override string LayThongTin()
        {
            return $"Ma SV: {MaSinhVien} | " +
                   $"Ho ten: {HoTen} | " +
                   $"Ngay sinh: {NgaySinh:dd/MM/yyyy} | " +
                   $"Lop: {MaLop} | " +
                   $"Diem: {DiemTrungBinh:F2} | " +
                   $"Xep loai: {XepLoai()}";
        }
    }
}