USE [ShopCuaTui]
GO

SET IDENTITY_INSERT [dbo].[Loais] ON
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh]) VALUES (1,N'Áo',N'','')
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh]) VALUES (2,N'Quần',N'','')
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh]) VALUES (3,N'Váy',N'','')
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh],[MaLoaiCha]) VALUES (4,N'Áo len',N'','',1)
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh],[MaLoaiCha]) VALUES (5,N'Áo sơ mi',N'','',1)
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh],[MaLoaiCha]) VALUES (6,N'Áo rộng',N'','',1)
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh],[MaLoaiCha]) VALUES (7,N'Áo cộc',N'','',1)
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh],[MaLoaiCha]) VALUES (8,N'Quần jean',N'','',2)
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh],[MaLoaiCha]) VALUES (9,N'Quần short',N'','',2)
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh],[MaLoaiCha]) VALUES (10,N'Quần tây',N'','',2)
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh],[MaLoaiCha]) VALUES (11,N'Váy dài',N'','',3)
INSERT INTO Loais ([MaLoai],[TenLoai],[MoTa],[Hinh],[MaLoaiCha]) VALUES (12,N'Váy ngắn',N'','',3)
SET IDENTITY_INSERT [dbo].[Loais] OFF
GO

INSERT INTO ThuongHieus VALUES (1,N'Bestiny',N'50, Trần Hưng Đạo,quận 5, HCM','0123456789','logo1')
INSERT INTO ThuongHieus ([MaTh],[TenThuongHieu],[DiaChi],[DienThoai],[Logo],[Mota]) VALUES (2,N'Bestini',N'Paris','','Logo1.jpg',N'BESTINI’s handbags, shopping bags, shoulder bags are modern and trendy. These items will complete your outfits and will seduce you by its quality and features.')
INSERT INTO ThuongHieus ([MaTh],[TenThuongHieu],[DiaChi],[DienThoai],[Logo],[Mota]) VALUES (2,N'Christy',N'','','Logo2.jpg',N'Casual chic and laid back are what best describes CHRISTY. Its collection is cool and trendy. It will suit all modern and fashionable women.')
INSERT INTO ThuongHieus ([MaTh],[TenThuongHieu],[DiaChi],[DienThoai],[Logo],[Mota]) VALUES (2,N'Danity',N'Paris','','Logo3.jpg',N'DANITY PARIS is a feminine brand, sparkling, delicate with a romantic touch. It looks like us, women. Independent and serene, it assumes its femininity with elegance. Day and night, the DANITY PARIS dresses sublimate the silhouettes and make us beautiful. Because being dressed and feminine is no longer a taboo.')
INSERT INTO ThuongHieus ([MaTh],[TenThuongHieu],[DiaChi],[DienThoai],[Logo],[Mota]) VALUES (2,N'Kaia',N'Paris','','Logo4.jpg',N'KAIA’s collection is the definition of casual chic : clothes that are comfortable but with style. Pairing floral prints with basic colors and cuts, his collection is ideal for a laid-back feminine outfit.')
INSERT INTO ThuongHieus ([MaTh],[TenThuongHieu],[DiaChi],[DienThoai],[Logo],[Mota]) VALUES (2,N'Mar&Co',N'France','','Logo5.jpg',N'The trendy and timeless spirit of the MAR&CO brand is at the heart of an exclusive collection! Casual creations, a bit romantic, which revolve around a floral print that dresses women today.
With rhinestones, sequins or printed patterns, MAR&CO offers fashion accessories that are in style and that will beautify your outfits.')
INSERT INTO ThuongHieus ([MaTh],[TenThuongHieu],[DiaChi],[DienThoai],[Logo],[Mota]) VALUES (2,N'Ki&Love',N'England','','Logo6.jpg',N'The brand KI&LOVE offer a very bohemian collection. With its floral prints, his clothes brings freshness and color to the wardrobe. His collection is ideal for the spring/summer season.')
GO


SET IDENTITY_INSERT [dbo].[HangHoas] ON
INSERT INTO HangHoas ([MaHh],[TenHh],[Hinh],[MoTa],[DonGia],[SoLuong],[GiamGia],[MaLoai],[MaTh]) VALUES (1,N'Áo A1',N'./img/product/1.jpg',N'OK',350000,5,0,1,1)
INSERT INTO HangHoas ([MaHh],[TenHh],[Hinh],[MoTa],[DonGia],[SoLuong],[GiamGia],[MaLoai],[MaTh]) VALUES (2,N'Áo A2',N'./img/product/2.jpg',N'OK',450000,5,0,2,1)
INSERT INTO HangHoas ([MaHh],[TenHh],[Hinh],[MoTa],[DonGia],[SoLuong],[GiamGia],[MaLoai],[MaTh]) VALUES (3,N'Áo A3',N'./img/product/3.jpg',N'OK',550000,5,0,3,1)
GO