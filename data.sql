﻿SCREATE DATABASE NetManagement;
GO
USE NetManagement;
GO
CREATE TABLE Quyen
(
 MaQuyen INT PRIMARY KEY IDENTITY,
 TenQuyen NVARCHAR(255)
)
GO
CREATE TABLE NhanVien
(
  MaNV INT PRIMARY KEY IDENTITY,
  HoTen NVARCHAR(255),
  DiaChi NVARCHAR(255),
  SDT VARCHAR(11),
  MaQuyen INT,
  MatKhau VARCHAR(50),
  CONSTRAINT FK_Quyen FOREIGN KEY (MaQuyen) REFERENCES Quyen(MaQuyen)
)
GO
CREATE TABLE NguoiDung
(
 MaND INT PRIMARY KEY IDENTITY,
 TenTK VARCHAR(50),
 MatKhau VARCHAR(50),
 SoTienConLai FLOAT
)
GO
CREATE TABLE May
(
 MaMay INT PRIMARY KEY IDENTITY,
 SoMay NVARCHAR(25),
 GiaTienTrenGio INT,
 TinhTrang BIT
)
GO
CREATE TABLE DichVu
(
 MaDV INT PRIMARY KEY IDENTITY,
 TenDV NVARCHAR(255),
 Gia FLOAT,
 HinhAnh NVARCHAR(255)
)
GO
CREATE TABLE HoaDon
(
 MaHD INT PRIMARY KEY IDENTITY,
 MaNV INT,
 MaND INT,
 NgayLapHD DATETIME,
 TongTien FLOAT,
 TinhTrang BIT,
 CONSTRAINT FK_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV),
 CONSTRAINT FK_ND FOREIGN KEY(MaND) REFERENCES NguoiDung(MaND)
)
GO
CREATE TABLE CTHoaDon
(
 MaCTHD INT PRIMARY KEY IDENTITY,
 MaDV INT,
 MaHD INT,
 SoLuong INT,
 ThanhTien FLOAT,
 CONSTRAINT FK_DV FOREIGN KEY(MaDV) REFERENCES DichVu(MaDV),
 CONSTRAINT FK_HD FOREIGN KEY(MaHD) REFERENCES HoaDon(MaHD)
)
GO
CREATE TABLE SuDung
(
 MaSD INT PRIMARY KEY IDENTITY,
 MaMay INT,
 MaND INT,
 TGianBD DATETIME,
 TGianKT DATETIME
 CONSTRAINT FK_May FOREIGN KEY(MaMay) REFERENCES May(MaMay),
 CONSTRAINT FK_NguoiDung FOREIGN KEY (MaND) REFERENCES NguoiDung(MaND)
)
GO
INSERT INTO Quyen(TenQuyen) VALUES
(N'Admin'),
(N'Employee')
GO
INSERT INTO NhanVien(HoTen, DiaChi, SDT, MatKhau, MaQuyen) VALUES  
('kyanh','Viet Nam','0901433', '123', 1),
('Dat','Viet Nam', '0901522', '123', 2)

GO
DECLARE @i INT;
SET @i = 1
WHILE @i <= 15
BEGIN
	INSERT INTO May(SoMay, GiaTienTrenGio, TinhTrang) VALUES (N'Máy số ' + CAST(@i AS NVARCHAR(25)), 8000, 0)
	SET @i = @i + 1
END
WHILE @i <= 30
BEGIN
	INSERT INTO May(SoMay, GiaTienTrenGio, TinhTrang) VALUES (N'Máy số ' + CAST(@i AS NVARCHAR(25)), 12000, 0)
	SET @i = @i + 1
END