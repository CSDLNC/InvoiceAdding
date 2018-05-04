/* ******************************************************************************************** */
/* ********************************         DATABASE        *********************************** */
/* ******************************************************************************************** */

-- CREATE DATABASE
CREATE DATABASE QuanLyKhachSan;



-- CREATE TABLE AND PRIMARY KEY CONSTRAINTS

USE QuanLyKhachSan;

------ KhachHang
CREATE TABLE KhachHang
(
	maKH 			int 			NOT NULL IDENTITY(1,1),
	hoTen 			nvarchar(50) 	NOT NULL,
	tenDangNhap 	nvarchar(20) 	NOT NULL UNIQUE,
	matKhau 		nvarchar(50) 	NOT NULL,
	soCMND 			nvarchar(9) 	NOT NULL UNIQUE,
	diaChi 			nvarchar(100) 	NOT NULL,
	soDienThoai 	nvarchar(13) 	NOT NULL UNIQUE,
	moTa 			nvarchar(200),
	email 			nvarchar(50) 	NOT NULL UNIQUE,
	
	PRIMARY KEY (maKH)
);

------ KhachSan
CREATE TABLE KhachSan
(
	maKS 			int 			NOT NULL IDENTITY(1,1),
	tenKS 			nvarchar(50) 	NOT NULL,
	soSao 			int 			NOT NULL,
	soNha 			int 			NOT NULL,
	duong 			nvarchar(50) 	NOT NULL,
	quan 			nvarchar(30) 	NOT NULL,
	thanhPho 		nvarchar(30) 	NOT NULL,
	giaTB 			money 			NOT NULL,
	moTa 			nvarchar(200),
	
	PRIMARY KEY (maKS)
);

------ LoaiPhong
CREATE TABLE LoaiPhong
(
	maLoaiPhong 	int				NOT NULL IDENTITY(1,1),
	tenLoaiPhong 	nvarchar(50) 	NOT NULL,
	maKS 			int 			NOT NULL,
	donGia 			money 			NOT NULL,
	moTa 			nvarchar(200),
	slTrong 		int 			NOT NULL,
	
	PRIMARY KEY (maLoaiPhong)
);

------ Phong
CREATE TABLE Phong
(
	maPhong 		int 			NOT NULL IDENTITY(1,1),
	loaiPhong 		int 			NOT NULL,
	soPhong 		int 			NOT NULL,
	
	PRIMARY KEY (maPhong)
);

------ TrangThaiPhong
CREATE TABLE TrangThaiPhong
(
	maPhong 		int 			NOT NULL,
	ngay 			datetime 		NOT NULL,
	tinhTrang 		int 			DEFAULT 1,
	
	PRIMARY KEY (maPhong, ngay)
);

------ DatPhong
CREATE TABLE DatPhong
(
	maDP 			int 			NOT NULL IDENTITY(1,1),
	maLoaiPhong 	int 			NOT NULL,
	maKH 			int 			NOT NULL,
	ngayBatDau 		datetime 		NOT NULL,
	ngayTraPhong 	datetime 		NOT NULL,
	ngayDat 		datetime 		NOT NULL ,
	donGia 			money 			NOT NULL,
	moTa 			nvarchar(200),
	tinhTrang 		nvarchar(15) 	NOT NULL,
	
	PRIMARY KEY (maDP)
);

------ HoaDon
CREATE TABLE HoaDon
(
	maHD 			int 			NOT NULL IDENTITY(1,1),
	ngayThanhToan 	datetime 		NOT NULL,
	tongTien 		money 			NOT NULL,
	maDP 			int 			NOT NULL UNIQUE,
	
	PRIMARY KEY (maHD)
);



-- FOREIGN KEY CONSTRAINTS

USE QuanLyKhachSan;

ALTER TABLE LoaiPhong
ADD CONSTRAINT FK_KhachSan_LoaiPhong
FOREIGN KEY (maKS) REFERENCES KhachSan (maKS);

ALTER TABLE Phong
ADD CONSTRAINT FK_LoaiPhong_Phong
FOREIGN KEY (loaiPhong) REFERENCES LoaiPhong (maLoaiPhong);

ALTER TABLE TrangThaiPhong
ADD CONSTRAINT FK_Phong_TrangThaiPhong
FOREIGN KEY (maPhong) REFERENCES Phong (maPhong);

ALTER TABLE DatPhong
ADD CONSTRAINT FK_LoaiPhong_DatPhong
FOREIGN KEY (maLoaiPhong) REFERENCES LoaiPhong (maLoaiPhong);

ALTER TABLE DatPhong
ADD CONSTRAINT FK_KhachHang_DatPhong
FOREIGN KEY (maKH) REFERENCES KhachHang (maKH);

ALTER TABLE HoaDon
ADD CONSTRAINT FK_DatPhong_HoaDon
FOREIGN KEY (maDP) REFERENCES DatPhong (maDP);



-- INDEX

USE QuanLyKhachSan;

CREATE INDEX KH_TDN_MK
ON KhachHang (tenDangNhap, matKhau);

CREATE INDEX KH_CMND
ON KhachHang (soCMND);

CREATE INDEX KS_SS_TP
ON KhachSan (soSao, thanhPho);

CREATE INDEX KS_GTB_TP
ON KhachSan (giaTB, thanhPho);

CREATE INDEX KS_TP
ON KhachSan (thanhPho);

CREATE INDEX LP_MKS_DG
ON LoaiPhong (maKS);

CREATE INDEX LP_MKS
ON KhachHang (soCMND);

CREATE INDEX P_LP
ON Phong (loaiPhong);

CREATE INDEX TTP_MP
ON TrangThaiPhong (maPhong);

CREATE INDEX DP_MLP
ON DatPhong (maLoaiPhong);

CREATE INDEX DP_MKH
ON DatPhong (maKH);

CREATE INDEX HD_NTT_TT
ON HoaDon (ngayThanhToan, tongTien);

CREATE INDEX HD_MDP
ON HoaDon (maDP);