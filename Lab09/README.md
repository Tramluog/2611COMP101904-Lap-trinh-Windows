# Lab09 - Thiết kế và in thẻ sinh viên bằng WinForms

## 1. Mô tả bài tập

Xây dựng ứng dụng Windows Forms cho phép nhập thông tin sinh viên,
chọn ảnh đại diện, hiển thị bản xem trước và in thẻ sinh viên.

Thông tin được nhập trực tiếp trên Form, không sử dụng cơ sở dữ liệu.

Ứng dụng sử dụng PictureBox để hiển thị ảnh, GDI+ để vẽ thẻ,
PrintDocument để định nghĩa nội dung in, PrintPreviewDialog để
xem trước và PrintDialog để lựa chọn máy in.

## 2. Các chức năng

- Nhập thông tin Sinh Viên 
- Chọn ảnh đại diện 
- Xem trước thẻ trên Form
- Kiểm tra dữ liệu 
- Xem trước in và in thẻ
- Làm mới
- Chức năng mở rộng

## 3. Giao diện ứng dụng

![Giao diện ban đầu](images/GiaoDienBanDau.png)

### 3.1. Kiểm tra thiếu mã sinh viên

![Thiếu mã sinh viên](images/ThieuMaSV.png)

### 3.2. Kiểm tra thiếu họ tên

![Thiếu họ tên](images/ThieuHoTen.png)

### 3.3. Kiểm tra thiếu ảnh

![Thiếu ảnh đại diện](images/ThieuAnh.png)

### 3.4. Xem trước thẻ trên Form

![Xem trước thẻ](images/PreviewThe.png)

### 3.5. Cập nhật thông tin

Thẻ tự cập nhật khi người dùng thay đổi nội dung nhập.

![Cập nhật thông tin](images/CapNhatThongTin.png)

### 3.6. Thay đổi ảnh đại diện

![Đổi ảnh đại diện](images/DoiAnh.png)

### 3.7. Giữ đúng tỉ lệ ảnh

![Ảnh không bị méo](images/AnhKhongMeo.png)

### 3.8. Xem trước in

![Print Preview](images/PrintPreview.png)

### 3.9. Hộp thoại chọn máy in

![Print Dialog](images/PrintDialog.png)

### 3.10. Làm mới dữ liệu

![Làm mới](images/LamMoi.png)

### 3.11. Thẻ xuất ra PNG

![Thẻ sinh viên PNG](images/TheSinhVien.png)

