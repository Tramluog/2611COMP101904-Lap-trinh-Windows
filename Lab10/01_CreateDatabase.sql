/*
    LAB10 - THIET KE CO SO DU LIEU EDUMANAGERDB
    File: 01_CreateDatabase.sql

    Tao database va 6 bang:
    KHOA, LOP, SINHVIEN, MONHOC, KETQUA, TAIKHOAN.

    Chi tao doi tuong neu chua ton tai.
    Khong xoa database hoac du lieu dang co.
*/

USE master;
GO

-- =====================================================
-- 1. TAO DATABASE
-- =====================================================

IF DB_ID(N'EduManagerDB') IS NULL
BEGIN
    EXEC(N'CREATE DATABASE EduManagerDB');
END;
GO

USE EduManagerDB;
GO

-- =====================================================
-- 2. TAO BANG KHOA
-- =====================================================

IF OBJECT_ID(N'dbo.KHOA', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.KHOA
    (
        MaKhoa VARCHAR(10) NOT NULL,
        TenKhoa NVARCHAR(100) NOT NULL,

        CONSTRAINT PK_KHOA
            PRIMARY KEY (MaKhoa)
    );
END;
GO

-- =====================================================
-- 3. TAO BANG LOP
-- Moi lop thuoc mot khoa.
-- =====================================================

IF OBJECT_ID(N'dbo.LOP', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.LOP
    (
        MaLop VARCHAR(10) NOT NULL,
        TenLop NVARCHAR(100) NOT NULL,
        MaKhoa VARCHAR(10) NOT NULL,

        CONSTRAINT PK_LOP
            PRIMARY KEY (MaLop),

        CONSTRAINT FK_LOP_KHOA
            FOREIGN KEY (MaKhoa)
            REFERENCES dbo.KHOA(MaKhoa)
    );
END;
GO

-- =====================================================
-- 4. TAO BANG SINHVIEN
-- Moi sinh vien thuoc mot lop.
-- Gioi tinh chi nhan Nam hoac Nu.
-- =====================================================

IF OBJECT_ID(N'dbo.SINHVIEN', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.SINHVIEN
    (
        MaSV VARCHAR(10) NOT NULL,
        HoTen NVARCHAR(100) NOT NULL,
        NgaySinh DATE NOT NULL,
        GioiTinh NVARCHAR(3) NOT NULL,
        MaLop VARCHAR(10) NOT NULL,

        CONSTRAINT PK_SINHVIEN
            PRIMARY KEY (MaSV),

        CONSTRAINT FK_SINHVIEN_LOP
            FOREIGN KEY (MaLop)
            REFERENCES dbo.LOP(MaLop),

        CONSTRAINT CK_SINHVIEN_GioiTinh
            CHECK (GioiTinh IN (N'Nam', N'Nữ'))
    );
END;
GO

-- =====================================================
-- 5. TAO BANG MONHOC
-- So tin chi phai lon hon 0.
-- =====================================================

IF OBJECT_ID(N'dbo.MONHOC', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.MONHOC
    (
        MaMH VARCHAR(10) NOT NULL,
        TenMH NVARCHAR(100) NOT NULL,
        SoTinChi INT NOT NULL,

        CONSTRAINT PK_MONHOC
            PRIMARY KEY (MaMH),

        CONSTRAINT CK_MONHOC_SoTinChi
            CHECK (SoTinChi > 0)
    );
END;
GO

-- =====================================================
-- 6. TAO BANG KETQUA
-- Khoa chinh ghep: MaSV va MaMH.
-- Diem nam trong khoang tu 0 den 10.
-- =====================================================

IF OBJECT_ID(N'dbo.KETQUA', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.KETQUA
    (
        MaSV VARCHAR(10) NOT NULL,
        MaMH VARCHAR(10) NOT NULL,
        Diem DECIMAL(4, 2) NOT NULL,

        CONSTRAINT PK_KETQUA
            PRIMARY KEY (MaSV, MaMH),

        CONSTRAINT FK_KETQUA_SINHVIEN
            FOREIGN KEY (MaSV)
            REFERENCES dbo.SINHVIEN(MaSV),

        CONSTRAINT FK_KETQUA_MONHOC
            FOREIGN KEY (MaMH)
            REFERENCES dbo.MONHOC(MaMH),

        CONSTRAINT CK_KETQUA_Diem
            CHECK (Diem BETWEEN 0 AND 10)
    );
END;
GO

-- =====================================================
-- 7. TAO BANG TAIKHOAN
-- Luu tai khoan demo cho bai thuc hanh.
-- =====================================================

IF OBJECT_ID(N'dbo.TAIKHOAN', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.TAIKHOAN
    (
        TenDangNhap VARCHAR(50) NOT NULL,
        MatKhau VARCHAR(100) NOT NULL,
        HoTen NVARCHAR(100) NOT NULL,
        VaiTro NVARCHAR(20) NOT NULL,

        CONSTRAINT PK_TAIKHOAN
            PRIMARY KEY (TenDangNhap)
    );
END;
GO

-- =====================================================
-- 8. KIEM TRA DANH SACH BANG
-- Ket qua can co du 6 bang.
-- =====================================================

SELECT
    SCHEMA_NAME(schema_id) AS TenSchema,
    name AS TenBang
FROM sys.tables
WHERE name IN
(
    N'KHOA',
    N'LOP',
    N'SINHVIEN',
    N'MONHOC',
    N'KETQUA',
    N'TAIKHOAN'
)
ORDER BY name;
GO