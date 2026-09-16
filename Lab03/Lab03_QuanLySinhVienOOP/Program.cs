using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab03_QuanLySinhVienOOP
{
    internal class Program
    {
        static QuanLySinhVien quanLy = new QuanLySinhVien();

        static void Main(string[] args)
        {
            int luaChon;

            do
            {
                HienThiMenu();
                luaChon = NhapSoNguyen("Chon chuc nang: ");

                Console.WriteLine();

                switch (luaChon)
                {
                    case 1:
                        ThemSinhVien();
                        break;

                    case 2:
                        XuatDanhSach(quanLy.LayDanhSach());
                        break;

                    case 3:
                        TimTheoMa();
                        break;

                    case 4:
                        TimTheoTen();
                        break;

                    case 5:
                        SuaDiem();
                        break;

                    case 6:
                        XoaSinhVien();
                        break;

                    case 7:
                        XuatDanhSach(quanLy.SapXepTheoDiem());
                        break;

                    case 8:
                        XuatDanhSach(quanLy.LocSinhVienDat());
                        break;

                    case 0:
                        Console.WriteLine("Da thoat chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Chuc nang khong hop le.");
                        break;
                }

                Console.WriteLine();

            } while (luaChon != 0);
        }

        static void HienThiMenu()
        {
            Console.WriteLine("===== QUAN LY SINH VIEN =====");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Xuat danh sach");
            Console.WriteLine("3. Tim sinh vien theo ma");
            Console.WriteLine("4. Tim sinh vien theo ten");
            Console.WriteLine("5. Sua diem trung binh");
            Console.WriteLine("6. Xoa sinh vien");
            Console.WriteLine("7. Sap xep theo diem giam dan");
            Console.WriteLine("8. Loc sinh vien dat");
            Console.WriteLine("0. Thoat");
        }

        static void ThemSinhVien()
        {
            Console.Write("Ma sinh vien: ");
            string ma = Console.ReadLine() ?? "";

            if (quanLy.TimTheoMa(ma) != null)
            {
                Console.WriteLine("Ma sinh vien da ton tai.");
                return;
            }

            Console.Write("Ho ten: ");
            string hoTen = Console.ReadLine() ?? "";

            DateTime ngaySinh = NhapNgaySinh();

            Console.Write("Ma lop: ");
            string maLop = Console.ReadLine() ?? "";

            double diem = NhapDiem();

            SinhVien sv = new SinhVien(
                ma,
                hoTen,
                ngaySinh,
                maLop,
                diem
            );

            if (quanLy.Them(sv))
                Console.WriteLine("Them sinh vien thanh cong.");
            else
                Console.WriteLine("Ma sinh vien da ton tai.");
        }

        static void TimTheoMa()
        {
            Console.Write("Nhap ma sinh vien: ");
            string ma = Console.ReadLine() ?? "";

            SinhVien? sv = quanLy.TimTheoMa(ma);

            if (sv == null)
            {
                Console.WriteLine("Khong tim thay sinh vien.");
                return;
            }

            Console.WriteLine(sv.LayThongTin());
        }

        static void TimTheoTen()
        {
            Console.Write("Nhap tu khoa ho ten: ");
            string tuKhoa = Console.ReadLine() ?? "";

            List<SinhVien> ketQua = quanLy.TimTheoTen(tuKhoa);

            XuatDanhSach(ketQua);
        }

        static void SuaDiem()
        {
            Console.Write("Nhap ma sinh vien: ");
            string ma = Console.ReadLine() ?? "";

            if (quanLy.TimTheoMa(ma) == null)
            {
                Console.WriteLine("Khong tim thay sinh vien.");
                return;
            }

            double diemMoi = NhapDiem();

            quanLy.Sua(ma, diemMoi);

            Console.WriteLine("Cap nhat diem thanh cong.");
        }

        static void XoaSinhVien()
        {
            Console.Write("Nhap ma sinh vien can xoa: ");
            string ma = Console.ReadLine() ?? "";

            if (quanLy.Xoa(ma))
                Console.WriteLine("Xoa sinh vien thanh cong.");
            else
                Console.WriteLine("Khong tim thay sinh vien.");
        }

        static void XuatDanhSach(List<SinhVien> danhSach)
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sach rong.");
                return;
            }

            Console.WriteLine("===== DANH SACH SINH VIEN =====");

            foreach (SinhVien sv in danhSach)
            {
                Console.WriteLine(sv.LayThongTin());
            }
        }

        static double NhapDiem()
        {
            while (true)
            {
                Console.Write("Diem trung binh (0-10): ");

                if (double.TryParse(Console.ReadLine(), out double diem)
                    && diem >= 0
                    && diem <= 10)
                {
                    return diem;
                }

                Console.WriteLine(
                    "Diem khong hop le. Vui long nhap tu 0 den 10."
                );
            }
        }

        static int NhapSoNguyen(string thongBao)
        {
            while (true)
            {
                Console.Write(thongBao);

                if (int.TryParse(Console.ReadLine(), out int so))
                    return so;

                Console.WriteLine(
                    "Du lieu khong hop le. Vui long nhap so."
                );
            }
        }

        static DateTime NhapNgaySinh()
        {
            while (true)
            {
                Console.Write("Ngay sinh (dd/MM/yyyy): ");

                string? input = Console.ReadLine();

                if (DateTime.TryParseExact(
                        input,
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime ngaySinh))
                {
                    return ngaySinh;
                }

                Console.WriteLine(
                    "Ngay sinh khong hop le. Vi du: 15/08/2006"
                );
            }
        }
    }
}