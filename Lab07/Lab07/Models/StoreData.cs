using System.ComponentModel;

namespace ShopManagerMini.Models
{
    public static class StoreData
    {
        public static BindingList<Product> Products { get; } =
            new BindingList<Product>
            {
                new Product
                {
                    MaSP = "SP01",
                    TenSP = "Chuột không dây",
                    LoaiSP = "Điện tử",
                    DonGia = 150000m,
                    SoLuong = 20
                },
                new Product
                {
                    MaSP = "SP02",
                    TenSP = "Sổ ghi chép",
                    LoaiSP = "Văn phòng",
                    DonGia = 25000m,
                    SoLuong = 50
                },
                new Product
                {
                    MaSP = "SP03",
                    TenSP = "Bình giữ nhiệt",
                    LoaiSP = "Gia dụng",
                    DonGia = 180000m,
                    SoLuong = 15
                }
            };

        public static BindingList<Customer> Customers { get; } =
            new BindingList<Customer>
            {
                new Customer
                {
                    MaKH = "KH01",
                    HoTen = "Nguyễn Văn An",
                    SoDienThoai = "0901234567",
                    LoaiKH = "Thường"
                }
            };
    }
}