using System;
using System.Text;

namespace Lab02
{
    class Program
    {
        // ==============================
        // HÀM NHẬP SỐ NGUYÊN DƯƠNG
        // ==============================
        static int NhapSoNguyen(string message)
        {
            int n;

            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    return n;
                }

                Console.WriteLine("Lỗi! Vui lòng nhập một số nguyên dương.");
            }
        }

        // ==============================
        // HÀM NHẬP SỐ NGUYÊN
        // ==============================
        static int NhapSoNguyenDuong(string message)
        {
            int n;

            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out n))
                {
                    return n;
                }

                Console.WriteLine("Lỗi! Vui lòng nhập số nguyên.");
            }
        }

        // ==============================
        // HÀM NHẬP MẢNG
        // ==============================
        static int[] NhapMang()
        {
            int n = NhapSoNguyen("Nhập số lượng phần tử n: ");

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = NhapSoNguyenDuong(
                    "Nhập a[" + i + "]: "
                );
            }

            Console.WriteLine("Đã nhập mảng thành công!");

            return a;
        }

        // ==============================
        // HÀM XUẤT MẢNG
        // ==============================
        static void XuatMang(int[] a)
        {
            if (a == null || a.Length == 0)
            {
                Console.WriteLine("Mảng chưa được nhập.");
                return;
            }

            Console.Write("Mảng: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);

                if (i < a.Length - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }

        // ==============================
        // HÀM TÍNH TỔNG
        // ==============================
        static int TinhTong(int[] a)
        {
            int tong = 0;

            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i];
            }

            return tong;
        }

        // ==============================
        // HÀM TÌM MAX
        // ==============================
        static int TimMax(int[] a)
        {
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }

        // ==============================
        // HÀM TÌM MIN
        // ==============================
        static int TimMin(int[] a)
        {
            int min = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            return min;
        }

        // ==============================
        // HÀM ĐẾM SỐ CHẴN
        // ==============================
        static int DemChan(int[] a)
        {
            int dem = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    dem++;
                }
            }

            return dem;
        }

        // ==============================
        // HÀM ĐẾM SỐ LẺ
        // ==============================
        static int DemLe(int[] a)
        {
            int dem = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    dem++;
                }
            }

            return dem;
        }

        // ==============================
        // HÀM SẮP XẾP TĂNG DẦN
        // ==============================
        static void SapXepTangDan(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        // ==============================
        // HÀM TÌM KIẾM
        // ==============================
        static int TimKiem(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }

        // ==============================
        // HÀM HIỂN THỊ MENU
        // ==============================
        static void HienThiMenu()
        {
            Console.WriteLine();
            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1. Nhập mảng");
            Console.WriteLine("2. Xuất mảng");
            Console.WriteLine("3. Tính tổng");
            Console.WriteLine("4. Tìm max/min");
            Console.WriteLine("5. Đếm chẵn/lẻ");
            Console.WriteLine("6. Sắp xếp tăng dần");
            Console.WriteLine("7. Tìm kiếm");
            Console.WriteLine("0. Thoát");
            Console.WriteLine("==========================");
        }

        // ==============================
        // CHƯƠNG TRÌNH CHÍNH
        // ==============================
        static void Main(string[] args)
        {
            // Sửa lỗi tiếng Việt trong Console
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int[] a = null;
            int luaChon;

            do
            {
                HienThiMenu();

                Console.Write("Chọn chức năng: ");

                // Kiểm tra lựa chọn menu
                if (!int.TryParse(Console.ReadLine(), out luaChon))
                {
                    Console.WriteLine("Lỗi! Vui lòng nhập số từ 0 đến 7.");
                    continue;
                }

                switch (luaChon)
                {
                    // ==========================
                    // 1. NHẬP MẢNG
                    // ==========================
                    case 1:
                        a = NhapMang();
                        break;

                    // ==========================
                    // 2. XUẤT MẢNG
                    // ==========================
                    case 2:
                        if (a == null)
                        {
                            Console.WriteLine("Vui lòng nhập mảng trước!");
                        }
                        else
                        {
                            XuatMang(a);
                        }
                        break;

                    // ==========================
                    // 3. TÍNH TỔNG
                    // ==========================
                    case 3:
                        if (a == null)
                        {
                            Console.WriteLine("Vui lòng nhập mảng trước!");
                        }
                        else
                        {
                            Console.WriteLine(
                                "Tổng các phần tử = " + TinhTong(a)
                            );
                        }
                        break;

                    // ==========================
                    // 4. TÌM MAX / MIN
                    // ==========================
                    case 4:
                        if (a == null)
                        {
                            Console.WriteLine("Vui lòng nhập mảng trước!");
                        }
                        else
                        {
                            Console.WriteLine(
                                "Giá trị lớn nhất = " + TimMax(a)
                            );

                            Console.WriteLine(
                                "Giá trị nhỏ nhất = " + TimMin(a)
                            );
                        }
                        break;

                    // ==========================
                    // 5. ĐẾM CHẴN / LẺ
                    // ==========================
                    case 5:
                        if (a == null)
                        {
                            Console.WriteLine("Vui lòng nhập mảng trước!");
                        }
                        else
                        {
                            Console.WriteLine(
                                "Số phần tử chẵn = " + DemChan(a)
                            );

                            Console.WriteLine(
                                "Số phần tử lẻ = " + DemLe(a)
                            );
                        }
                        break;

                    // ==========================
                    // 6. SẮP XẾP TĂNG DẦN
                    // ==========================
                    case 6:
                        if (a == null)
                        {
                            Console.WriteLine("Vui lòng nhập mảng trước!");
                        }
                        else
                        {
                            SapXepTangDan(a);

                            Console.WriteLine("Mảng sau khi sắp xếp:");

                            XuatMang(a);
                        }
                        break;

                    // ==========================
                    // 7. TÌM KIẾM
                    // ==========================
                    case 7:
                        if (a == null)
                        {
                            Console.WriteLine("Vui lòng nhập mảng trước!");
                        }
                        else
                        {
                            int x = NhapSoNguyenDuong(
                                "Nhập giá trị cần tìm: "
                            );

                            int viTri = TimKiem(a, x);

                            if (viTri == -1)
                            {
                                Console.WriteLine(
                                    "Không tìm thấy " + x + " trong mảng."
                                );
                            }
                            else
                            {
                                Console.WriteLine(
                                    "Tìm thấy " + x +
                                    " tại vị trí đầu tiên: " + viTri
                                );
                            }
                        }
                        break;

                    // ==========================
                    // 0. THOÁT
                    // ==========================
                    case 0:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;

                    // ==========================
                    // LỰA CHỌN SAI
                    // ==========================
                    default:
                        Console.WriteLine(
                            "Lỗi! Vui lòng chọn từ 0 đến 7."
                        );
                        break;
                }

            } while (luaChon != 0);
        }
    }
}