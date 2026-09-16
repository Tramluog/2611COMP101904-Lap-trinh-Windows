using System;
using System.Collections.Generic;

namespace _16092026
{
    internal class Program
    {
        static List<NhanVien> danhSach = new List<NhanVien>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            KhoiTaoDuLieu();

            int luaChon;

            do
            {
                HienThiMenu();

                Console.Write("Nhap lua chon: ");
                int.TryParse(Console.ReadLine(), out luaChon);

                Console.WriteLine();

                switch (luaChon)
                {
                    case 1:
                        XuatDanhSach();
                        break;

                    case 2:
                        TimNhanVienTheoMa();
                        break;

                    case 3:
                        TimNhanVienLuongCaoNhat();
                        break;

                    case 4:
                        TinhTongLuong();
                        break;

                    case 0:
                        Console.WriteLine("Da thoat chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

                if (luaChon != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nhan Enter de tiep tuc...");
                    Console.ReadLine();
                }

            } while (luaChon != 0);
        }

        static void KhoiTaoDuLieu()
        {
            danhSach.Add(new NhanVienVanPhong(
                "VP01",
                "Nguyen Van An",
                8000000,
                22));

            danhSach.Add(new NhanVienVanPhong(
                "VP02",
                "Tran Thi Binh",
                7500000,
                25));

            danhSach.Add(new NhanVienKinhDoanh(
                "KD01",
                "Le Van Cuong",
                7000000,
                30000000));

            danhSach.Add(new NhanVienKinhDoanh(
                "KD02",
                "Pham Thi Dung",
                9000000,
                40000000));

            danhSach.Add(new NhanVienThoiVu(
                "TV01",
                "Hoang Van Em",
                1,
                80,
                50000));
        }

        static void HienThiMenu()
        {
            Console.Clear();

            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1. Xuat danh sach nhan vien");
            Console.WriteLine("2. Tim nhan vien theo ma");
            Console.WriteLine("3. Tim nhan vien co luong cao nhat");
            Console.WriteLine("4. Tinh tong luong cong ty phai tra");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("==========================");
        }

        static void XuatDanhSach()
        {
            Console.WriteLine("===== DANH SACH NHAN VIEN =====");

            foreach (NhanVien nv in danhSach)
            {
                nv.HienThiThongTin();
                Console.WriteLine("------------------------------");
            }
        }

        static void TimNhanVienTheoMa()
        {
            Console.Write("Nhap ma nhan vien can tim: ");
            string ma = Console.ReadLine();

            NhanVien timThay = null;

            foreach (NhanVien nv in danhSach)
            {
                if (nv.MaNhanVien.Equals(
                    ma,
                    StringComparison.OrdinalIgnoreCase))
                {
                    timThay = nv;
                    break;
                }
            }

            if (timThay != null)
            {
                Console.WriteLine("===== NHAN VIEN TIM THAY =====");
                timThay.HienThiThongTin();
            }
            else
            {
                Console.WriteLine("Khong tim thay nhan vien!");
            }
        }

        static void TimNhanVienLuongCaoNhat()
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sach rong!");
                return;
            }

            NhanVien nvMax = danhSach[0];

            foreach (NhanVien nv in danhSach)
            {
                if (nv.TinhLuong() > nvMax.TinhLuong())
                {
                    nvMax = nv;
                }
            }

            Console.WriteLine("===== NHAN VIEN LUONG CAO NHAT =====");
            nvMax.HienThiThongTin();
        }

        static void TinhTongLuong()
        {
            double tongLuong = 0;

            foreach (NhanVien nv in danhSach)
            {
                tongLuong += nv.TinhLuong();
            }

            Console.WriteLine(
                $"Tong luong cong ty phai tra: {tongLuong:N0} VND");
        }
    }
}