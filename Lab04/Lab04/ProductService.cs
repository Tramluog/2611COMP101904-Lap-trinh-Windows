using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab04
{
    public class ProductService
    {
        private readonly Repository<Product> repository;

        // Event dùng Action<string>
        public event Action<string>? ProductChanged;

        public ProductService()
        {
            repository = new Repository<Product>();
        }

        // THÊM SẢN PHẨM

        public void AddProduct(Product product)
        {
            Product? tonTai =
                repository.FindById(product.MaSP);

            if (tonTai != null)
            {
                throw new DuplicateProductException(
                    $"Mã sản phẩm '{product.MaSP}' đã tồn tại."
                );
            }

            repository.Add(product);

            ProductChanged?.Invoke(
                $"Đã thêm sản phẩm {product.MaSP} - {product.TenSP}."
            );
        }

        // ==============================
        // XÓA SẢN PHẨM
        // ==============================

        public void RemoveProduct(string maSP)
        {
            Product? product =
                repository.FindById(maSP);

            if (product == null)
            {
                throw new ProductNotFoundException(
                    $"Không tìm thấy sản phẩm có mã '{maSP}'."
                );
            }

            repository.Remove(maSP);

            ProductChanged?.Invoke(
                $"Đã xóa sản phẩm {product.MaSP} - {product.TenSP}."
            );
        }

        // TÌM THEO MÃ

        public Product FindById(string maSP)
        {
            Product? product =
                repository.FindById(maSP);

            if (product == null)
            {
                throw new ProductNotFoundException(
                    $"Không tìm thấy sản phẩm có mã '{maSP}'."
                );
            }

            return product;
        }

        // ==============================
        // TÌM THEO TÊN
        // ==============================

        public List<Product> Search(string tuKhoa)
        {
            return repository.Find(
                product =>
                    product.TenSP.Contains(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase
                    )
            );
        }

        // LỌC THEO ĐIỀU KIỆN

        public List<Product> Filter(
            Func<Product, bool> dieuKien)
        {
            return repository.Find(dieuKien);
        }

        // XUẤT DANH SÁCH

        public List<Product> GetAll()
        {
            return repository.GetAll();
        }

        // TỔNG GIÁ TRỊ KHO

        public double GetTotalInventoryValue()
        {
            return repository
                .GetAll()
                .Sum(product =>
                    product.Price *
                    product.Quantity);
        }
    }
}