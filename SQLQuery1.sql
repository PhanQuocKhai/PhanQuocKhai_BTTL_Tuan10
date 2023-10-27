create database QLySinhVien
go

CREATE TABLE Khoa
(
   MaKhoa VARCHAR(10) PRIMARY KEY,
   TenKhoa NVARCHAR(100)
);
CREATE TABLE SinhVien
(
   MaSinhVien VARCHAR(10) PRIMARY KEY,
   HoTen NVARCHAR(100),
   NgaySinh DATE,
   GioiTinh NVARCHAR(10),
   MaKhoa VARCHAR(10)
);