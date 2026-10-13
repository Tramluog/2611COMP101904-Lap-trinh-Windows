using System;

namespace Lab04;

public class Product : IEntity
{
    public string MaSP { get; set; }

    public string TenSP { get; set; }

    public double Price { get; set; }

    public int Quantity { get; set; }

    public string Id => MaSP;

    public Product(
        string maSP,
        string tenSP,
        double price,
        int quantity)
    {
        if (string.IsNullOrWhiteSpace(maSP))
        {
            throw new ArgumentException(
                "Mã sản phẩm không được để trống."
            );
        }

        if (string.IsNullOrWhiteSpace(tenSP))
        {
            throw new ArgumentException(
                "Tên sản phẩm không được để trống."
            );
        }

        if (price < 0)
        {
            throw new ArgumentException(
                "Đơn giá không được âm."
            );
        }

        if (quantity < 0)
        {
            throw new ArgumentException(
                "Số lượng không được âm."
            );
        }

        MaSP = maSP;
        TenSP = tenSP;
        Price = price;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return
            $"Mã SP: {MaSP} | " +
            $"Tên SP: {TenSP} | " +
            $"Đơn giá: {Price:N0} VNĐ | " +
            $"Số lượng: {Quantity} | " +
            $"Thành tiền: {Price * Quantity:N0} VNĐ";
    }
}