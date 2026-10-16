/*
    LAB10 - EDUMANAGERDB
    File: 02_InsertSampleData.sql

    Du lieu mau:
    - 2 khoa.
    - 3 lop.
    - 6 sinh vien.
    - 4 mon hoc.
    - 8 ket qua hoc tap.
    - 2 tai khoan demo.
*/

USE EduManagerDB;
GO

SET XACT_ABORT ON;
GO

BEGIN TRY
    BEGIN TRANSACTION;

    -- Ngan nhap lap du lieu mau.
    IF EXISTS (SELECT 1 FROM dbo.KHOA)
       OR EXISTS (SELECT 1 FROM dbo.LOP)
       OR EXISTS (SELECT 1 FROM dbo.SINHVIEN)
       OR EXISTS (SELECT 1 FROM dbo.MONHOC)
       OR EXISTS (SELECT 1 FROM dbo.KETQUA)
       OR EXISTS (SELECT 1 FROM dbo.TAIKHOAN)
    BEGIN
        THROW 50001,
            N'Các bảng đã có dữ liệu. Không nhập lặp dữ liệu mẫu.',
            1;
    END;

    -- =================================================
    -- 1. THEM HAI KHOA
    -- =================================================

    INSERT INTO dbo.KHOA (MaKhoa, TenKhoa)
    VALUES
        ('CNTT', N'Công nghệ thông tin'),
        ('TOAN', N'Toán - Tin học');

    -- =================================================
    -- 2. THEM BA LOP
    -- =================================================

    INSERT INTO dbo.LOP (MaLop, TenLop, MaKhoa)
    VALUES
        ('CT01', N'Công nghệ thông tin 01', 'CNTT'),
        ('CT02', N'Công nghệ thông tin 02', 'CNTT'),
        ('T01', N'Sư phạm Toán 01', 'TOAN');

    -- =================================================
    -- 3. THEM SAU SINH VIEN
    -- Ngay sinh viet theo dinh dang YYYYMMDD.
    -- =================================================

    INSERT INTO dbo.SINHVIEN
    (
        MaSV,
        HoTen,
        NgaySinh,
        GioiTinh,
        MaLop
    )
    VALUES
        ('SV01', N'Nguyễn Văn An', '20050915', N'Nam', 'CT01'),
        ('SV02', N'Trần Thị Bình', '20050320', N'Nữ', 'CT01'),
        ('SV03', N'Lê Minh Cường', '20051108', N'Nam', 'CT01'),
        ('SV04', N'Nguyễn Thị Dung', '20060112', N'Nữ', 'CT02'),
        ('SV05', N'Phạm Quốc Huy', '20060725', N'Nam', 'CT02'),
        ('SV06', N'Võ Ngọc Lan', '20050530', N'Nữ', 'T01');

    -- =================================================
    -- 4. THEM BON MON HOC
    -- =================================================

    INSERT INTO dbo.MONHOC (MaMH, TenMH, SoTinChi)
    VALUES
        ('MH01', N'Lập trình C#', 3),
        ('MH02', N'SQL Server', 3),
        ('MH03', N'Cơ sở dữ liệu', 3),
        ('MH04', N'Lập trình Windows', 4);

    -- =================================================
    -- 5. THEM TAM KET QUA HOC TAP
    -- SV06 chua co diem de thu truy van xoa.
    -- =================================================

    INSERT INTO dbo.KETQUA (MaSV, MaMH, Diem)
    VALUES
        ('SV01', 'MH01', 8.50),
        ('SV01', 'MH02', 9.00),
        ('SV02', 'MH01', 7.00),
        ('SV02', 'MH02', 8.00),
        ('SV03', 'MH01', 6.50),
        ('SV04', 'MH03', 9.00),
        ('SV05', 'MH02', 8.00),
        ('SV05', 'MH04', 8.50);

    -- =================================================
    -- 6. THEM HAI TAI KHOAN DEMO
    -- =================================================

    INSERT INTO dbo.TAIKHOAN
    (
        TenDangNhap,
        MatKhau,
        HoTen,
        VaiTro
    )
    VALUES
        ('admin', '123', N'Quản trị viên', N'Admin'),
        ('user', '123', N'Nhân viên', N'User');

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION;
    END;

    THROW;
END CATCH;
GO

-- =====================================================
-- 7. KIEM TRA SO DONG TUNG BANG
-- =====================================================

SELECT N'KHOA' AS TenBang, COUNT(*) AS SoDong
FROM dbo.KHOA

UNION ALL

SELECT N'LOP', COUNT(*)
FROM dbo.LOP

UNION ALL

SELECT N'SINHVIEN', COUNT(*)
FROM dbo.SINHVIEN

UNION ALL

SELECT N'MONHOC', COUNT(*)
FROM dbo.MONHOC

UNION ALL

SELECT N'KETQUA', COUNT(*)
FROM dbo.KETQUA

UNION ALL

SELECT N'TAIKHOAN', COUNT(*)
FROM dbo.TAIKHOAN;
GO