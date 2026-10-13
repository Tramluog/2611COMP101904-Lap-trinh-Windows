using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    internal class Program
    {
        private static ProductService service = new ProductService();

        static void Main(string[] args)
        {
            // Hỗ trợ nhập và xuất tiếng Việt
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            // Đăng ký nhận event khi thêm hoặc xóa sản phẩm
            service.ProductChanged += HienThiThongBao;

            int luaChon;

            do
            {
                Console.WriteLine();
                HienThiMenu();

                luaChon = NhapSoNguyen("Chọn: ");

                Console.WriteLine();

                try
                {
                    switch (luaChon)
                    {
                        case 1:
                            ThemSanPham();
                            break;

                        case 2:
                            XuatDanhSach();
                            break;

                        case 3:
                            TimTheoMa();
                            break;

                        case 4:
                            TimTheoTen();
                            break;

                        case 5:
                            LocTheoKhoangGia();
                            break;

                        case 6:
                            XoaSanPham();
                            break;

                        case 7:
                            TinhTongGiaTriKho();
                            break;

                        case 0:
                            Console.WriteLine(
                                "Đã thoát chương trình."
                            );
                            break;

                        default:
                            Console.WriteLine(
                                "Chức năng không hợp lệ. Vui lòng chọn từ 0 đến 7."
                            );
                            break;
                    }
                }
                catch (DuplicateProductException ex)
                {
                    Console.WriteLine(
                        $"Lỗi: {ex.Message}"
                    );
                }
                catch (ProductNotFoundException ex)
                {
                    Console.WriteLine(
                        $"Lỗi: {ex.Message}"
                    );
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(
                        $"Dữ liệu không hợp lệ: {ex.Message}"
                    );
                }
                catch (Exception ex)
                {
                    Console.WriteLine(
                        $"Có lỗi xảy ra: {ex.Message}"
                    );
                }

            } while (luaChon != 0);
        }

        // =========================================
        // MENU
        // =========================================

        static void HienThiMenu()
        {
            Console.WriteLine(
                "===== PRODUCT MANAGER ====="
            );

            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Xuất danh sách");
            Console.WriteLine("3. Tìm theo mã");
            Console.WriteLine("4. Tìm theo tên");
            Console.WriteLine("5. Lọc theo khoảng giá");
            Console.WriteLine("6. Xóa sản phẩm");
            Console.WriteLine("7. Tính tổng giá trị kho");
            Console.WriteLine("0. Thoát");
        }

        // =========================================
        // 1. THÊM SẢN PHẨM
        // =========================================

        static void ThemSanPham()
        {
            Console.WriteLine(
                "===== THÊM SẢN PHẨM ====="
            );

            string maSP =
                NhapChuoiKhongRong(
                    "Mã sản phẩm: "
                );

            string tenSP =
                NhapChuoiKhongRong(
                    "Tên sản phẩm: "
                );

            double price =
                NhapSoKhongAm(
                    "Đơn giá: "
                );

            int quantity =
                NhapSoNguyenKhongAm(
                    "Số lượng: "
                );

            Product product =
                new Product(
                    maSP,
                    tenSP,
                    price,
                    quantity
                );

            service.AddProduct(product);
        }

        // =========================================
        // 2. XUẤT DANH SÁCH
        // =========================================

        static void XuatDanhSach()
        {
            List<Product> danhSach =
                service.GetAll();

            InDanhSach(danhSach);
        }

        // =========================================
        // 3. TÌM THEO MÃ
        // =========================================

        static void TimTheoMa()
        {
            string maSP =
                NhapChuoiKhongRong(
                    "Nhập mã sản phẩm: "
                );

            Product product =
                service.FindById(maSP);

            Console.WriteLine(
                "===== SẢN PHẨM TÌM THẤY ====="
            );

            Console.WriteLine(product);
        }

        // =========================================
        // 4. TÌM THEO TÊN
        // =========================================

        static void TimTheoTen()
        {
            string tuKhoa =
                NhapChuoiKhongRong(
                    "Nhập từ khóa tên: "
                );

            List<Product> ketQua =
                service.Search(tuKhoa);

            InDanhSach(ketQua);
        }

        // =========================================
        // 5. LỌC THEO KHOẢNG GIÁ
        // =========================================

        static void LocTheoKhoangGia()
        {
            double giaMin =
                NhapSoKhongAm(
                    "Giá nhỏ nhất: "
                );

            double giaMax;

            while (true)
            {
                giaMax =
                    NhapSoKhongAm(
                        "Giá lớn nhất: "
                    );

                if (giaMax >= giaMin)
                {
                    break;
                }

                Console.WriteLine(
                    "Giá lớn nhất phải lớn hơn hoặc bằng giá nhỏ nhất."
                );
            }

            // Sử dụng Func<Product, bool>
            Func<Product, bool> dieuKien =
                product =>
                    product.Price >= giaMin
                    &&
                    product.Price <= giaMax;

            List<Product> ketQua =
                service.Filter(dieuKien);

            InDanhSach(ketQua);
        }

        // =========================================
        // 6. XÓA SẢN PHẨM
        // =========================================

        static void XoaSanPham()
        {
            string maSP =
                NhapChuoiKhongRong(
                    "Nhập mã sản phẩm cần xóa: "
                );

            service.RemoveProduct(maSP);
        }

        // =========================================
        // 7. TÍNH TỔNG GIÁ TRỊ KHO
        // =========================================

        static void TinhTongGiaTriKho()
        {
            double tongGiaTri =
                service.GetTotalInventoryValue();

            Console.WriteLine(
                $"Tổng giá trị kho: {tongGiaTri:N0} VNĐ"
            );
        }

        // =========================================
        // EVENT
        // =========================================

        static void HienThiThongBao(
            string thongBao)
        {
            Console.WriteLine(
                $"[EVENT] {thongBao}"
            );
        }

        // =========================================
        // IN DANH SÁCH
        // =========================================

        static void InDanhSach(
            List<Product> danhSach)
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine(
                    "Không có sản phẩm phù hợp."
                );

                return;
            }

            Console.WriteLine(
                "===== DANH SÁCH SẢN PHẨM ====="
            );

            foreach (Product product in danhSach)
            {
                Console.WriteLine(product);
            }
        }

        // =========================================
        // NHẬP CHUỖI KHÔNG RỖNG
        // =========================================

        static string NhapChuoiKhongRong(
            string thongBao)
        {
            while (true)
            {
                Console.Write(thongBao);

                string giaTri =
                    Console.ReadLine()?.Trim()
                    ?? "";

                if (!string.IsNullOrWhiteSpace(
                        giaTri))
                {
                    return giaTri;
                }

                Console.WriteLine(
                    "Thông tin không được để trống."
                );
            }
        }

        // =========================================
        // NHẬP SỐ NGUYÊN
        // =========================================

        static int NhapSoNguyen(
            string thongBao)
        {
            while (true)
            {
                Console.Write(thongBao);

                if (int.TryParse(
                        Console.ReadLine(),
                        out int giaTri))
                {
                    return giaTri;
                }

                Console.WriteLine(
                    "Dữ liệu không hợp lệ. Vui lòng nhập số nguyên."
                );
            }
        }

        // =========================================
        // NHẬP SỐ NGUYÊN >= 0
        // =========================================

        static int NhapSoNguyenKhongAm(
            string thongBao)
        {
            while (true)
            {
                int giaTri =
                    NhapSoNguyen(thongBao);

                if (giaTri >= 0)
                {
                    return giaTri;
                }

                Console.WriteLine(
                    "Giá trị không được âm."
                );
            }
        }

        // =========================================
        // NHẬP SỐ >= 0
        // =========================================

        static double NhapSoKhongAm(
            string thongBao)
        {
            while (true)
            {
                Console.Write(thongBao);

                if (double.TryParse(
                        Console.ReadLine(),
                        out double giaTri)
                    &&
                    giaTri >= 0)
                {
                    return giaTri;
                }

                Console.WriteLine(
                    "Giá trị phải là số lớn hơn hoặc bằng 0."
                );
            }
        }
    }
}