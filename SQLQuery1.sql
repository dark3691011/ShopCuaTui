USE [ShopCuaTui]
GO

SET IDENTITY_INSERT [dbo].[Loais] ON
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh]) VALUES (1,N'Đồ nam',N'Dành cho đàn ông','hinh1')
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh]) VALUES (2,N'Đồ nữ',N'Dành cho phụ nữ','hinh2')
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh]) VALUES (3,N'Đồ trẻ em',N'Dành cho trẻ em','hinh3')
SET IDENTITY_INSERT [dbo].[Loais] OFF
GO

INSERT INTO ThuongHieus VALUES (1,N'Devil',N'50, Trần Hưng Đạo,quận 5, HCM','0123456789','logo1')
GO


SET IDENTITY_INSERT [dbo].[HangHoas] ON
INSERT INTO HangHoas ([MaHh],[TenHh],[Hinh],[MoTa],[DonGia],[SoLuong],[GiamGia],[MaLoai],[MaTh]) VALUES (1,N'Áo A1',N'./img/product/1.jpg',N'OK',350000,5,0,1,1)
INSERT INTO HangHoas ([MaHh],[TenHh],[Hinh],[MoTa],[DonGia],[SoLuong],[GiamGia],[MaLoai],[MaTh]) VALUES (2,N'Áo A2',N'./img/product/2.jpg',N'OK',450000,5,0,2,1)
INSERT INTO HangHoas ([MaHh],[TenHh],[Hinh],[MoTa],[DonGia],[SoLuong],[GiamGia],[MaLoai],[MaTh]) VALUES (3,N'Áo A3',N'./img/product/3.jpg',N'OK',550000,5,0,3,1)
GO