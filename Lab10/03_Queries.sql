/*
    LAB10 - EDUMANAGERDB
    File: 03_Queries.sql

    Gom 12 truy van va kiem thu.

    Cau 5 va 6 su dung ROLLBACK de khoi phuc
    du lieu mau sau khi thu UPDATE va DELETE.
*/

USE EduManagerDB;
GO

-- =====================================================
-- CAU 1. LIET KE TOAN BO SINH VIEN
-- =====================================================

SELECT
    MaSV,
    HoTen,
    NgaySinh,
    GioiTinh,
    MaLop
FROM dbo.SINHVIEN
ORDER BY MaSV;
GO

-- =====================================================
-- CAU 2. SINH VIEN KEM TEN LOP VA TEN KHOA
-- =====================================================

SELECT
    sv.MaSV,
    sv.HoTen,
    sv.NgaySinh,
    sv.GioiTinh,
    l.TenLop,
    k.TenKhoa
FROM dbo.SINHVIEN AS sv
INNER JOIN dbo.LOP AS l
    ON sv.MaLop = l.MaLop
INNER JOIN dbo.KHOA AS k
    ON l.MaKhoa = k.MaKhoa
ORDER BY sv.MaSV;
GO

-- =====================================================
-- CAU 3. TIM THEO MOT PHAN HO TEN
-- =====================================================

SELECT
    MaSV,
    HoTen,
    MaLop
FROM dbo.SINHVIEN
WHERE HoTen LIKE N'%Nguyễn%'
ORDER BY MaSV;
GO

-- =====================================================
-- CAU 4. LIET KE SINH VIEN THEO MA LOP
-- =====================================================

SELECT
    MaSV,
    HoTen,
    NgaySinh,
    GioiTinh,
    MaLop
FROM dbo.SINHVIEN
WHERE MaLop = 'CT01'
ORDER BY MaSV;
GO

-- =====================================================
-- CAU 5. CAP NHAT HO TEN SINH VIEN
-- Chay ca khoi giao dich, khong chi chay UPDATE.
-- =====================================================

BEGIN TRANSACTION;

    SELECT
        N'Trước cập nhật' AS TrangThai,
        MaSV,
        HoTen
    FROM dbo.SINHVIEN
    WHERE MaSV = 'SV01';

    UPDATE dbo.SINHVIEN
    SET HoTen = N'Nguyễn Văn An (cập nhật)'
    WHERE MaSV = 'SV01';

    SELECT
        N'Sau cập nhật' AS TrangThai,
        MaSV,
        HoTen
    FROM dbo.SINHVIEN
    WHERE MaSV = 'SV01';

ROLLBACK TRANSACTION;

SELECT
    N'Đã khôi phục dữ liệu mẫu' AS TrangThai,
    MaSV,
    HoTen
FROM dbo.SINHVIEN
WHERE MaSV = 'SV01';
GO

-- =====================================================
-- CAU 6. XOA SINH VIEN CHUA CO DIEM
-- SV06 chua co ket qua hoc tap.
-- Chay ca khoi giao dich, khong chi chay DELETE.
-- =====================================================

BEGIN TRANSACTION;

    SELECT
        N'Trước xóa' AS TrangThai,
        MaSV,
        HoTen
    FROM dbo.SINHVIEN
    WHERE MaSV = 'SV06';

    DELETE FROM dbo.SINHVIEN
    WHERE MaSV = 'SV06'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.KETQUA AS kq
          WHERE kq.MaSV = dbo.SINHVIEN.MaSV
      );

    SELECT
        N'Số dòng SV06 sau xóa' AS NoiDung,
        COUNT(*) AS SoDong
    FROM dbo.SINHVIEN
    WHERE MaSV = 'SV06';

ROLLBACK TRANSACTION;

SELECT
    N'Đã khôi phục dữ liệu mẫu' AS TrangThai,
    MaSV,
    HoTen
FROM dbo.SINHVIEN
WHERE MaSV = 'SV06';
GO

-- =====================================================
-- CAU 7. LIET KE DIEM THEO SINH VIEN VA MON HOC
-- =====================================================

SELECT
    sv.MaSV,
    sv.HoTen,
    mh.MaMH,
    mh.TenMH,
    kq.Diem
FROM dbo.KETQUA AS kq
INNER JOIN dbo.SINHVIEN AS sv
    ON kq.MaSV = sv.MaSV
INNER JOIN dbo.MONHOC AS mh
    ON kq.MaMH = mh.MaMH
ORDER BY sv.MaSV, mh.MaMH;
GO

-- =====================================================
-- CAU 8. DIEM TRUNG BINH TUNG SINH VIEN
-- Trung binh cong cac mon da co diem.
-- Sinh vien chua co diem hien thi NULL.
-- =====================================================

SELECT
    sv.MaSV,
    sv.HoTen,
    COUNT(kq.MaMH) AS SoMonCoDiem,
    CAST(AVG(kq.Diem) AS DECIMAL(5, 2)) AS DiemTrungBinh
FROM dbo.SINHVIEN AS sv
LEFT JOIN dbo.KETQUA AS kq
    ON sv.MaSV = kq.MaSV
GROUP BY
    sv.MaSV,
    sv.HoTen
ORDER BY sv.MaSV;
GO

-- =====================================================
-- CAU 9. THONG KE SO SINH VIEN THEO LOP
-- =====================================================

SELECT
    l.MaLop,
    l.TenLop,
    COUNT(sv.MaSV) AS SoSinhVien
FROM dbo.LOP AS l
LEFT JOIN dbo.SINHVIEN AS sv
    ON l.MaLop = sv.MaLop
GROUP BY
    l.MaLop,
    l.TenLop
ORDER BY l.MaLop;
GO

-- =====================================================
-- CAU 10. LIET KE LOP CO TU HAI SINH VIEN
-- =====================================================

SELECT
    l.MaLop,
    l.TenLop,
    COUNT(sv.MaSV) AS SoSinhVien
FROM dbo.LOP AS l
LEFT JOIN dbo.SINHVIEN AS sv
    ON l.MaLop = sv.MaLop
GROUP BY
    l.MaLop,
    l.TenLop
HAVING COUNT(sv.MaSV) >= 2
ORDER BY l.MaLop;
GO

-- =====================================================
-- CAU 11. TEST LOP KHONG TON TAI
-- Mong doi loi FOREIGN KEY, ma loi 547.
-- =====================================================

BEGIN TRY
    BEGIN TRANSACTION;

    INSERT INTO dbo.SINHVIEN
    (
        MaSV,
        HoTen,
        NgaySinh,
        GioiTinh,
        MaLop
    )
    VALUES
    (
        'SV_TEST',
        N'Sinh viên kiểm thử',
        '20050101',
        N'Nam',
        'L999'
    );

    ROLLBACK TRANSACTION;

    SELECT
        N'Không đạt: đã chấp nhận lớp không tồn tại.'
            AS KetQuaKiemThu;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION;
    END;

    SELECT
        CASE
            WHEN ERROR_NUMBER() = 547
                THEN N'Đạt: chặn lớp không tồn tại.'
            ELSE N'Cần kiểm tra lỗi phát sinh.'
        END AS KetQuaKiemThu,
        ERROR_NUMBER() AS MaLoi,
        ERROR_MESSAGE() AS NoiDungLoi;
END CATCH;
GO

-- =====================================================
-- CAU 12. TEST DIEM NGOAI KHOANG 0 DEN 10
-- Mong doi loi CHECK, ma loi 547.
-- =====================================================

BEGIN TRY
    BEGIN TRANSACTION;

    INSERT INTO dbo.KETQUA (MaSV, MaMH, Diem)
    VALUES ('SV01', 'MH03', 11);

    ROLLBACK TRANSACTION;

    SELECT
        N'Không đạt: đã chấp nhận điểm ngoài khoảng.'
            AS KetQuaKiemThu;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION;
    END;

    SELECT
        CASE
            WHEN ERROR_NUMBER() = 547
                THEN N'Đạt: chặn điểm ngoài khoảng 0 đến 10.'
            ELSE N'Cần kiểm tra lỗi phát sinh.'
        END AS KetQuaKiemThu,
        ERROR_NUMBER() AS MaLoi,
        ERROR_MESSAGE() AS NoiDungLoi;
END CATCH;
GO