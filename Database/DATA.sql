/* ******************************************************************************************** */
/* *****************************         INSERT DATABASE        ******************************* */
/* ******************************************************************************************** */

------ DatPhong

SET IDENTITY_INSERT DatPhong ON
insert into DatPhong(maDP,maLoaiPhong,maKH,ngayBatDau,ngayTraPhong,ngayDat,donGia,moTa,tinhTrang)
values ('001','1','12','5/5/2018','5/7/2018','5/13/2018','400000',N'abc','1')
insert into DatPhong(maDP,maLoaiPhong,maKH,ngayBatDau,ngayTraPhong,ngayDat,donGia,moTa,tinhTrang)
values ('002','2','14','6/6/2018','6/8/2018','5/12/2018','600000',N'abc','1')
insert into DatPhong(maDP,maLoaiPhong,maKH,ngayBatDau,ngayTraPhong,ngayDat,donGia,moTa,tinhTrang)
values ('003','3','15','7/7/2018','7/10/2018','5/11/2018','470000',N'abc','0')
insert into DatPhong(maDP,maLoaiPhong,maKH,ngayBatDau,ngayTraPhong,ngayDat,donGia,moTa,tinhTrang)
values ('004','1','16','8/8/2018','8/10/2018','8/1/2018','120000',N'abc','1')
insert into DatPhong(maDP,maLoaiPhong,maKH,ngayBatDau,ngayTraPhong,ngayDat,donGia,moTa,tinhTrang)
values ('005','2','17','9/9/2018','9/12/2018','9/4/2018','420000',N'abc','1')
insert into DatPhong(maDP,maLoaiPhong,maKH,ngayBatDau,ngayTraPhong,ngayDat,donGia,moTa,tinhTrang)
values ('006','3','12','10/10/2018','10/14/2018','10/4/2018','150000',N'abc','1')
insert into DatPhong(maDP,maLoaiPhong,maKH,ngayBatDau,ngayTraPhong,ngayDat,donGia,moTa,tinhTrang)
values ('007','1','15','11/11/2018','11/14/2018','11/2/2018','260000',N'abc','0')
insert into DatPhong(maDP,maLoaiPhong,maKH,ngayBatDau,ngayTraPhong,ngayDat,donGia,moTa,tinhTrang)
values ('008','2','12','6/6/2018','6/7/2018','6/2/2018','630000',N'abc','1')
insert into DatPhong(maDP,maLoaiPhong,maKH,ngayBatDau,ngayTraPhong,ngayDat,donGia,moTa,tinhTrang)
values ('009','3','15','6/6/2018','6/8/2018','6/11/2018','750000',N'abc','1')
SET IDENTITY_INSERT DatPhong OFF



------ HoaDon

SET IDENTITY_INSERT HoaDon ON
insert into HoaDon(maHD,ngayThanhToan,tongTien,maDP) values ('01','5/5/2018',1000000,'001')
insert into HoaDon(maHD,ngayThanhToan,tongTien,maDP) values ('02','6/8/2018',2000000,'002')
insert into HoaDon(maHD,ngayThanhToan,tongTien,maDP) values ('03','7/8/2018',3000000,'003')
insert into HoaDon(maHD,ngayThanhToan,tongTien,maDP) values ('04','8/8/2018',1000000,'004')
insert into HoaDon(maHD,ngayThanhToan,tongTien,maDP) values ('05','9/10/2018',2000000,'005')
insert into HoaDon(maHD,ngayThanhToan,tongTien,maDP) values ('06','10/10/2018',1500000,'006')
insert into HoaDon(maHD,ngayThanhToan,tongTien,maDP) values ('07','10/10/2018',1800000,'007')
insert into HoaDon(maHD,ngayThanhToan,tongTien,maDP) values ('08','6/6/2018',2000000,'008')
insert into HoaDon(maHD,ngayThanhToan,tongTien,maDP) values ('09','6/6/2018',900000,'009')
SET IDENTITY_INSERT HoaDon OFF



------ KhachSan

SET IDENTITY_INSERT KhachSan ON
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('001',N'Đông Dương',5,123, N'Nguyễn Trãi',N'Q. Bình Thạnh', N'Hồ Chí Minh', 3000000,N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('002',N'Ánh Sao',4,1267, N'Nguyễn Bỉnh Khiêm',N'Quận 3', N'Đà Nẵng', 5000000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('003',N'Thanh Tùng',5,12, N'Lê Lợi',N'Q. Hoàn Kiếm', N'Hà Nội', 1000000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('004',N'Riverside',3,133, N'Nguyễn Tất Thành', N'Quận 1', N'Hồ Chí Minh', 7000000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('005',N'Đồng Khởi',2,123, N'Ông Bích Khiêm', N'Q. Hà Đông', N'Hà Nội', 2000000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('006',N'Hanoi Dream',1,123, N'Phạm Ngũ Lão', N'Q. Cầu Giấy', N'Hà Nội', 3000000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('007',N'Hoàng Phú Gia',5,123, N'Trần Hưng Đạo', N'Quận 2', N'Đà Nẵng', 4000000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('008',N'Ocean Vilas',5,123, N'',N'Quận 3', N'Đà Nẵng', 3500000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('009',N'Đông Hà',4,123, N'Lê Lai',N'Quận 1', N'Đà Nẵng', 4500000, N'abcxyz')
insert into KhachSan(maKS,tenKS,soSao,soNha,duong,quan,thanhpho,giaTB,mota) 
values ('010',N'Viền Đông',3,123, N'Lý Thường Kiệt', N'Q. Tân Bình', N'Hồ Chí Minh', 2500000, N'abcxyz')
SET IDENTITY_INSERT KhachSan OFF



------ LoaiPhong

SET IDENTITY_INSERT LoaiPhong ON
insert into LoaiPhong(maLoaiPhong, tenLoaiPhong, maKS, moTa, donGia, slTrong) values ('001',N'VIP', '001', N'tốt', 100000,100) 
insert into LoaiPhong(maLoaiPhong, tenLoaiPhong, maKS, moTa, donGia, slTrong) values ('002',N'VIPP', '001', N'tốt', 500000,100) 
insert into LoaiPhong(maLoaiPhong, tenLoaiPhong, maKS, moTa, donGia, slTrong) values ('003',N'VIPPP', '002', N'tốt', 600000,100) 
insert into LoaiPhong(maLoaiPhong, tenLoaiPhong, maKS, moTa, donGia, slTrong)values ('004',N'VIPPPP', '002', N'tốt', 700000,100) 
insert into LoaiPhong(maLoaiPhong, tenLoaiPhong, maKS, moTa, donGia, slTrong)values ('005',N'VIPPPPP', '003', N'tốt', 800000,100) 
insert into LoaiPhong(maLoaiPhong, tenLoaiPhong, maKS, moTa, donGia, slTrong)values ('006',N'VIPPPPPP', '003', N'tốt', 500000,100) 
insert into LoaiPhong(maLoaiPhong, tenLoaiPhong, maKS, moTa, donGia, slTrong) values ('007',N'VIPPPPPPP', '004', N'tốt', 300000,100) 
insert into LoaiPhong(maLoaiPhong, tenLoaiPhong, maKS, moTa, donGia, slTrong) values ('008',N'VIPPPPPPPP', '004', N'tốt', 200000,100) 
insert into LoaiPhong(maLoaiPhong, tenLoaiPhong, maKS, moTa, donGia, slTrong) values ('009',N'VIPPPPPPPPP', '005', N'tốt', 100000,100) 
insert into LoaiPhong(maLoaiPhong, tenLoaiPhong, maKS, moTa, donGia, slTrong) values ('0010',N'VIPPPPPPPPP', '005', N'tốt', 500000,100) 
SET IDENTITY_INSERT LoaiPhong OFF



------ KhachHang

SET IDENTITY_INSERT KhachHang ON
insert into KhachHang(maKH, hoTen, tenDangNhap, matKhau, soCMND, diaChi,soDienThoai, moTa, email)
values ('12',N'Nguyễn Văn A', 'anguyen','123','123456',N'lê quang định','123457','mô tả','anguyen@gmail.com')
insert into KhachHang(maKH, hoTen, tenDangNhap, matKhau, soCMND, diaChi,soDienThoai, moTa, email)
values ('13',N'Nguyễn Văn B', 'bnguyen','123','123457',N'lê quang định','123458','mô tả','bnguyen@gmail.com')
insert into KhachHang(maKH, hoTen, tenDangNhap, matKhau, soCMND, diaChi,soDienThoai, moTa, email)
values ('14',N'Nguyễn Văn C', 'cnguyen','123','123458',N'lê quang định','123459','mô tả','cnguyen@gmail.com')
insert into KhachHang(maKH, hoTen, tenDangNhap, matKhau, soCMND, diaChi,soDienThoai, moTa, email)
values ('15',N'Nguyễn Văn D', 'dnguyen','123','123459',N'lê quang định','123455','mô tả','dnguyen@gmail.com')
insert into KhachHang(maKH, hoTen, tenDangNhap, matKhau, soCMND, diaChi,soDienThoai, moTa, email)
values ('16',N'Nguyễn Văn E', 'enguyen','123','123455',N'lê quang định','123450','mô tả','enguyen@gmail.com')
insert into KhachHang(maKH, hoTen, tenDangNhap, matKhau, soCMND, diaChi,soDienThoai, moTa, email)
values ('17',N'Nguyễn Văn F', 'Fnguyen','123','123450',N'lê quang định','123456','mô tả','fnguyen@gmail.com')
SET IDENTITY_INSERT KhachHang OFF



------ Phong

SET IDENTITY_INSERT Phong ON
insert into Phong(maPhong, loaiPhong, soPhong) values ('001','001',100)
insert into Phong(maPhong, loaiPhong, soPhong) values ('002','002',100)
insert into Phong(maPhong, loaiPhong, soPhong) values ('003','003',100)
insert into Phong(maPhong, loaiPhong, soPhong) values ('004','004',100)
insert into Phong(maPhong, loaiPhong, soPhong) values ('005','005',100)
insert into Phong(maPhong, loaiPhong, soPhong) values ('006','006',100)
insert into Phong(maPhong, loaiPhong, soPhong) values ('007','007',100)
insert into Phong(maPhong, loaiPhong, soPhong) values ('008','008',100)
insert into Phong(maPhong, loaiPhong, soPhong) values ('009','009',100)
insert into Phong(maPhong, loaiPhong, soPhong) values ('010','010',100)
SET IDENTITY_INSERT Phong OFF



------ TrangThaiPhong

insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('001','5/5/2018','2')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('001','10/5/2018','1')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('002','5/5/2018','1')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('004','5/5/2018','1')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('005','5/5/2018','1')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('006','5/5/2018','1')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('007','5/5/2018','1')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('008','5/5/2018','1')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('009','5/5/2018','1')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('010','5/5/2018','1')

insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('001','6/5/2018','1')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('002','6/5/2018','0')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('003','6/5/2018','1')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('004','6/5/2018','0')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('005','6/5/2018','0')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('006','6/5/2018','0')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('007','6/5/2018','1')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('008','6/5/2018','0')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('009','6/5/2018','0')
insert into TrangThaiPhong(maPhong, ngay, tinhTrang) values ('010','6/5/2018','2')