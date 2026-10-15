# Lab07 - SDI, MDI và ứng dụng nhiều Form trong C# WinForms

## 1. Mô tả bài tập

Xây dựng ứng dụng ShopManagerMini để quản lý cửa hàng mini
bằng C# Windows Forms.

Ứng dụng gồm màn hình đăng nhập, màn hình chính MDI,
quản lý sản phẩm, quản lý khách hàng và giới thiệu.

Dữ liệu được lưu trong bộ nhớ bằng BindingList<T>,
chưa kết nối SQL Server và chưa lưu dữ liệu ra file.

## 2. Chức năng của ứng dụng

- Đăng nhập
- Màn hình chính MDI
- Quản lý sản phẩm 
- Quản lý khách hàng
- Giới thiệu
- Đăng xuất và thoát
- Kiểm tra sản phẩm
- Kiểm tra khách hàng 

## 3. Kết quả thực hiện

### 3.1. Màn hình đăng nhập

![Màn hình đăng nhập](images/DangNhap.png)

### 3.2. Kiểm tra thông tin đăng nhập trống

![Đăng nhập thiếu thông tin](images/DangNhapTrong.png)

### 3.3. Kiểm tra đăng nhập sai

![Đăng nhập sai](images/DangNhapSai.png)

### 3.4. Màn hình chính

![Màn hình chính](images/ManHinhChinh.png)

### 3.5. Mở Form sản phẩm dạng MDI

![Form sản phẩm MDI](images/SanPhamMDI.png)

### 3.6. Mở nhiều Form con

![Nhiều Form MDI](images/NhieuFormMDI.png)

### 3.7. Thêm sản phẩm

![Thêm sản phẩm](images/ThemSP.png)

### 3.8. Kiểm tra mã sản phẩm trùng

![Mã sản phẩm trùng](images/MaTrung.png)

### 3.9. Sửa sản phẩm

![Sửa sản phẩm](images/SuaSP.png)

### 3.10. Tìm kiếm sản phẩm

![Tìm kiếm sản phẩm](images/TimKiemSP.png)

### 3.11. Xác nhận xóa sản phẩm

![Xác nhận xóa](images/XoaSP.png)

### 3.12. Thêm khách hàng

![Thêm khách hàng](images/ThemKH.png)

### 3.13. Giới thiệu ứng dụng

![Giới thiệu](images/GioiThieu.png)

### 3.14. Đăng xuất

![Đăng xuất](images/DangXuat.png)

### 3.15. Đăng nhập bằng tài khoản User

![Tài khoản User](images/TaiKhoanUser.png)

### 3.16. Xác nhận thoát

![Xác nhận thoát](images/Thoat.png)

## 4. Trả lời câu hỏi

### Câu 1. SDI và MDI khác nhau như thế nào?

SDI là giao diện trong đó mỗi cửa sổ làm việc hoạt động độc lập.

MDI là giao diện có một cửa sổ cha chứa các cửa sổ con bên trong.
Người dùng có thể mở và chuyển đổi giữa nhiều màn hình con
trong cùng cửa sổ chính.

Trong bài này, FrmMain là MDI Parent. FrmProduct, FrmCustomer
và FrmAbout là các MDI Child.

### Câu 2. Vì sao Form đăng nhập nên dùng ShowDialog()?

ShowDialog() mở Form theo dạng modal và chờ người dùng hoàn tất
thao tác trước khi chương trình tiếp tục chạy đoạn code phía sau.

Nhờ đó, chương trình kiểm tra được DialogResult của FrmLogin.
Chỉ khi kết quả là DialogResult.OK thì màn hình chính mới được mở.

### Câu 3. Dữ liệu user được truyền từ FrmLogin sang FrmMain bằng cách nào?

FrmLogin cung cấp property LoggedInUser để lưu thông tin
người dùng khi đăng nhập thành công.

Program.cs đọc property này sau khi ShowDialog() trả về
DialogResult.OK, sau đó truyền đối tượng User vào constructor
của FrmMain.

```csharp
currentUser = login.LoggedInUser;
```

```csharp
FrmMain main = new FrmMain(currentUser);
```

FrmMain sử dụng thông tin nhận được để hiển thị họ tên
và vai trò trên StatusStrip.

### Câu 4. Làm thế nào để không mở trùng Form khi bấm menu nhiều lần?

Trước khi tạo Form mới, chương trình kiểm tra danh sách
MdiChildren của FrmMain để tìm Form cùng loại.

- Nếu đã có: khôi phục nếu đang thu nhỏ và gọi Activate().
- Nếu chưa có: tạo Form mới, gán MdiParent rồi gọi Show().

Ví dụ kiểm tra Form đang mở:

```csharp
T existing = MdiChildren.OfType<T>().FirstOrDefault();
```

### Câu 5. Khi nào nên dùng constructor, khi nào nên dùng property để truyền dữ liệu?

Dùng constructor khi đối tượng cần nhận dữ liệu ngay tại thời điểm
khởi tạo để có thể sử dụng đúng mục đích.

Trong bài này, FrmMain nhận thông tin người dùng bằng
constructor FrmMain(User user).

Dùng property khi cần cung cấp, đọc hoặc cập nhật dữ liệu thông qua
thuộc tính của đối tượng.

Trong bài này, Program.cs đọc kết quả đăng nhập thông qua
property LoggedInUser của FrmLogin. Property có private set
để chỉ FrmLogin được gán kết quả đăng nhập.
