/* ******************************************************************************************** */
/* ****************************         STORED PROCEDURE        ******************************* */
/* ******************************************************************************************** */


-- SP REGISTER ACCOUNT

USE [QuanLyKhachSan]
GO

CREATE PROCEDURE SP_RegisterAccount (@HoTen nvarchar(50), @TenDangNhap nvarchar(20), @MatKhau varchar(50), @soCMND varchar(9), @diaChi nvarchar(100), @soDienThoai varchar(13), @moTa nvarchar(200), @email varchar(50))
AS BEGIN
DECLARE @ChuoiTruyVan nvarchar(3000),
        @DSThamSo nvarchar(500)
        
IF (@HoTen IS NOT NULL AND @TenDangNhap IS NOT NULL AND @MatKhau IS NOT NULL AND @soCMND IS NOT NULL AND @diaChi IS NOT NULL AND @soDienThoai IS NOT NULL AND @email IS NOT NULL)
	BEGIN
		DECLARE @KT_tenDangNhap int
		SELECT @KT_tenDangNhap = COUNT(*)
		FROM KhachHang
		WHERE tenDangNhap = @TenDangNhap
		DECLARE @KT_soCMND int
		SELECT @KT_soCMND = COUNT(*)
		FROM KhachHang
		WHERE soCMND = @soCMND
		DECLARE @KT_soDienThoai int
		SELECT @KT_soDienThoai = COUNT(*)
		FROM KhachHang
		WHERE soDienThoai = @soDienThoai
		DECLARE @KT_email int
		SELECT @KT_email = COUNT(*)
		FROM KhachHang
		WHERE email = @email

		IF (@KT_tenDangNhap > 0)
			BEGIN
				PRINT N'Tên Đăng Nhập Đã Tồn Tại.';
			END
		ELSE IF (@KT_soCMND > 0)
			BEGIN
				PRINT N'Số CMND Đã Tồn Tại.';
			END
		ELSE IF (@KT_soDienThoai > 0)
			BEGIN
				PRINT N'Số Điện Thoại Đã Tồn Tại.';
			END
		ELSE IF (@KT_email > 0)
			BEGIN
				PRINT N'Địa Chỉ Email Đã Tồn Tại.';
			END
		ELSE
			SET @ChuoiTruyVan = 'INSERT INTO KhachHang (hoTen, tenDangNhap, matKhau, soCMND, diaChi, soDienThoai, moTa, email) 
								VALUES (@HoTen, @TenDangNhap, @MatKhau, @soCMND, @diaChi, @soDienThoai, @moTa, @email)'
	END
ELSE
	PRINT N'Bạn Chưa Điền Đầy Đủ Thông Tin Đăng Ký.';


SET @DSThamSo =' @HoTen nvarchar(50), @TenDangNhap nvarchar(20), @MatKhau varchar(50), @soCMND varchar(9), @diaChi nvarchar(100), @soDienThoai varchar(13), @moTa nvarchar(200), @email varchar(50) '

EXEC SP_EXECUTESQL @ChuoiTruyVan, 
				   @DSThamSo,
				   @HoTen, 
				   @TenDangNhap, 
				   @MatKhau, 
				   @soCMND,
				   @diaChi,
				   @soDienThoai,
				   @moTa,
				   @email


END



-- SP SEARCHING HOTEL INFORMATION

USE [QuanLyKhachSan]
GO

CREATE PROCEDURE SP_SearchHotelInform (@voteStar int, @minPrice money, @maxPrice money, @City nvarchar(30))
AS BEGIN
DECLARE @SqlString nvarchar(1000), @input nvarchar(1000)

IF (@voteStar IS NOT NULL AND @City IS NOT NULL)
SET @SqlString = 'SELECT * 
				  FROM dbo.KhachSan KS 
				  WHERE KS.soSao = @voteStar 
				  AND KS.thanhPho = @City'

ELSE IF (@minPrice IS NOT NULL AND @maxPrice IS NOT NULL AND @City IS NOT NULL)
SET @SqlString = 'SELECT * 
				  FROM dbo.KhachSan KS 
				  WHERE KS.giaTB <= @maxPrice
				  AND KS.giaTB >= @minPrice
				  AND KS.thanhPho = @City'

ELSE IF (@minPrice IS NOT NULL AND @maxPrice IS NULL AND @City IS NOT NULL)
SET @SqlString = 'SELECT * 
				  FROM dbo.KhachSan KS 
				  WHERE KS.giaTB >= @minPrice 
				  AND KS.thanhPho = @City'

ELSE IF (@minPrice IS NULL AND @maxPrice IS NOT NULL AND @City IS NOT NULL)
SET @SqlString = 'SELECT * 
				  FROM dbo.KhachSan KS 
				  WHERE KS.giaTB <= @maxPrice 
				  AND KS.thanhPho = @City'

ELSE IF @City IS NULL
PRINT N'Lỗi! Thành Phố không được để trống.';

SET @input = '@voteStar int, @minPrice money, @maxPrice money, @City nvarchar(30)'

EXEC SP_EXECUTESQL @SqlString, @input, @voteStar, @minPrice, @maxPrice, @City

END



-- SP LOGIN ACCOUNT
 
USE [QuanLyKhachSan]
GO

CREATE PROCEDURE SP_LoginAccount (@TenDangNhap nvarchar(20), @MatKhau varchar(50))
AS BEGIN
DECLARE @ChuoiTruyVan nvarchar(3000),
        @DSThamSo nvarchar(500)
        
IF (@TenDangNhap IS NOT NULL AND @MatKhau IS NOT NULL)
	BEGIN
		DECLARE @KT_DN int
		SELECT @KT_DN = COUNT(*)
		FROM KhachHang
		WHERE tenDangNhap = @TenDangNhap AND MatKhau = @MatKhau

		IF (@KT_DN > 0)
			PRINT N'Đăng Nhập Thành Công !!!.';
		ELSE
			PRINT N'Tên Đăng Nhập Không Tồn Tại Hoặc Mật Khẩu Không Chính Xác !!!.';
	END
ELSE
	PRINT N'Vui Lòng Nhập Đầy Đủ Tên Đăng Nhập Và Mật Khẩu !!!.';

SET @DSThamSo =' @TenDangNhap nvarchar(20), @MatKhau varchar(50) '

EXEC SP_EXECUTESQL @ChuoiTruyVan, 
				   @DSThamSo, 
				   @TenDangNhap, 
				   @MatKhau


END



-- SP UPDATE STATUS

USE [QuanLyKhachSan]
GO

--UPDATE STATUS OF ROOM
CREATE PROCEDURE SP_UpdateStatus
	@NUM_ROOM int, @DATE datetime, @STATUS int
AS
BEGIN
	UPDATE TrangThaiPhong
	SET tinhTrang = @STATUS
	WHERE maPhong = @NUM_ROOM and ngay = @DATE
END
GO


-- RESULT = 0 // FAIL
-- RESULT = 1 // SUCCESS
CREATE PROCEDURE SP_Booking 
(  
	@USER nvarchar(20), @PASS nvarchar(50), @NUM_GUEST int, @NUM_ROOM int, @CHECK_IN datetime, @CHECK_OUT datetime,
	@RESULT int OUTPUT
)
AS
BEGIN  
	--GET STATUS OF THIS ROOM
	DECLARE @STATUS int, @DATE datetime;
	SELECT @STATUS = tt.tinhTrang, @DATE = MAX(tt.ngay) FROM Phong p join TrangThaiPhong tt ON p.maPhong = tt.maPhong
														WHERE p.maPhong = @NUM_ROOM
														GROUP BY tt.ngay, tt.tinhTrang

	SET @RESULT = 0;

	--CHECK STATUS OF THIS ROOM
	IF (@STATUS = 0 ) 
		BEGIN

		--GET DATA
		DECLARE @TARIFF money, @DETAIL nvarchar(200);
		SELECT @TARIFF = loai.donGia, @DETAIL = loai.moTa FROM Phong p JOIN LoaiPhong loai ON p.loaiPhong = loai.maLoaiPhong
														  WHERE p.maPhong = @NUM_ROOM

		--SAVE INFORMATION OF THIS ROOM
		INSERT INTO DatPhong (maLoaiPhong, maKH, ngayBatDau, ngayTraPhong, ngayDat, donGia, moTa, tinhTrang)
		VALUES (@NUM_ROOM, @NUM_GUEST, @CHECK_IN, @CHECK_OUT, GETDATE(), @TARIFF, @DETAIL, 1)

		--UPDATE STATUS
		EXEC sp_UpdateStatus @NUM_ROOM, @DATE, 1

		--BOOKING IS SUCCESSFUL
		SET @RESULT = 1;  
		PRINT 'Đã đặt phòng thành công.'
		END

	ELSE PRINT 'Xin lỗi, phòng bạn chọn đã có người đặt. Mời bạn chọn phòng khác.';
		
END



-- SP CREATE BILL

USE [QuanLyKhachSan]
GO

CREATE PROCEDURE SP_CreateBill  @maDP int
AS
BEGIN
DECLARE @maHD AS int
DECLARE @ngayThanhToan AS datetime
DECLARE @tongtien AS money
DECLARE @LastRecord AS int
SET NOCOUNT ON;

--Tim max trong maHD
SET @LastRecord = (
					SELECT MAX(HD.maHD)
				    FROM dbo.HoaDon AS HD
				  )


--Kiem tra xem Ma Dat phong co trong bang Hoa Don Khong
IF EXISTS (SELECT * FROM dbo.HoaDon AS HD WHERE @maDP = HD.maDP)

	BEGIN

	--tao moi maHD
	SET @maHD=@LastRecord+1;

	--chon tong tien tuong ung voi don gia ben table Dat phong
	SELECT  @tongtien = DP.donGia
	FROM dbo.HoaDon AS HD, dbo.DatPhong AS DP
	WHERE  HD.maDP = @maDP AND HD.maDP = DP.maDP
	SET IDENTITY_INSERT dbo.HoaDon ON
	--Xoa di hoa don cua Ma dat phong cu 
	DELETE FROM HoaDon WHERE maDP=@maDP
	-- nhap hoa don moi 
	INSERT INTO dbo.HoaDon
	(
		maHD,
		ngayThanhToan,
		tongTien,
		maDP
	)
	VALUES
	(   
	@maHD,
	GETDATE(),
	@tongtien,
	@maDP
	 )

	SET IDENTITY_INSERT dbo.HoaDon OFF


	--In ket qua cho nhan vien
	SELECT * 
	FROM dbo.HoaDon AS HD 
	WHERE HD.maHD = @maHD 

	END

ELSE
	--Neu khong co ma DP thi in ra thong bao
	BEGIN
	PRINT 'Ma Dat Phong Khong Chinh Xac'
	END

END



-- SP SEARCHING BILL INFORMATION

USE [QuanLyKhachSan]
GO

CREATE PROCEDURE SP_SearchBill (@ConsID int, @Day datetime, @minTotal money, @maxTotal money)
AS BEGIN
DECLARE @SqlString nvarchar(1000),
        @ParaList nvarchar(1000)
        
SET @SqlString= 'SELECT maHD, ngayThanhToan, tongTien FROM HoaDon HD, DatPhong DP WHERE (HD.maDP =DP.maDP)'

IF @ConsID IS NOT NULL SET @SqlString= @SqlString + ' AND (DP.maKH =@ConsID )'

IF @Day IS NOT NULL SET @SqlString = @SqlString + ' AND (HD.ngayThanhToan = @Day ) '

IF (@minTotal IS NOT NULL and @maxTotal IS NOT NULL) -- Neu co 2 can
SET @SqlString = @SqlString + ' AND (HD.tongTien >= @minTotal ) AND (HD.tongTien <= @maxTotal ) '
ELSE
IF (@minTotal IS NULL and @maxTotal IS NOT NULL) -- Neu ko co min
SET @SqlString = @SqlString + ' AND (HD.tongTien <= @maxTotal ) '
ELSE
IF (@minTotal IS NOT NULL and @maxTotal IS NULL) -- Neu ko co max
SET @SqlString = @SqlString + ' AND (HD.tongTien >= @minTotal ) ' 

SET @ParaList =' @ConsID int, @Day datetime, @minTotal money, @maxTotal money '

EXEC SP_EXECUTESQL @SqlString, 
				   @ParaList, 
				   @ConsID, 
				   @Day, 
				   @minTotal,
				   @maxTotal


END



-- SP STATISTIC EMPTY ROOM AND SP REVENUE REPORT

USE [QuanLyKhachSan]
GO

-- Statistic Empty Room
CREATE PROCEDURE SP_EmptyRoomStatistics(@hotelname nvarchar(50),@typeofroomname nvarchar(50) ,@date datetime, @sortoption int)
AS BEGIN
DECLARE @sqlstring nvarchar(1500), @input nvarchar(100)
IF(@date IS NOT NULL)

BEGIN
	SET @sqlstring = 'SELECT K.maKS, K.tenKS, K.thanhPho, K.soSao, L.maLoaiPhong, L.tenLoaiPhong, SUM(CASE WHEN T.tinhTrang=0 THEN 1 ELSE 0 END) AS soPhongTrong
					  FROM TrangThaiPhong T, Phong P, KhachSan K, LoaiPhong L 
					  WHERE T.maPhong=P.maPhong AND P.loaiPhong=L.maLoaiPhong AND L.maKS=K.maKS AND T.ngay=@date'
	---IF(@hotelname IS NULL)---không thống kê theo khách sạn --không làm gì cả
	IF(@hotelname IS NOT  NULL)---thống kê theo khách sạn 
		SET @sqlstring = @sqlstring + ' AND K.tenKS LIKE N''%' +@hotelname + '%'''
	---IF(@typeofroomname IS NULL)---không thống kê theo loại phòng --không làm gì cả
	IF(@typeofroomname IS NOT  NULL)---thống kê theo khách sạn 
		set @sqlstring = @sqlstring + ' AND L.tenLoaiPhong LIKE N''%' +@typeofroomname + '%'''

	---thêm phần group by và order
	SET @sqlstring = @sqlstring + ' GROUP BY K.maKS, K.tenKS, K.thanhPho, K.soSao,L.maLoaiPhong, L.tenLoaiPhong'
	IF (@sortoption=1) --nếu muốn sắp xếp theo thành phố và số sao
		SET @sqlstring = @sqlstring + ' ORDER BY K.thanhPho, K.soSao'
END

ELSE
	PRINT N'Lỗi! không chọn ngày thống kê';

SET @input = ' @hotelname NVARCHAR (50),@typeofroomname NVARCHAR(50) ,@date DATETIME'
EXEC SP_EXECUTESQL @sqlstring,
			       @input,
				   @hotelname,
				   @typeofroomname,
				   @date			   
END

USE [QuanLyKhachSan]
GO

-- Revenue Report
CREATE PROCEDURE SP_RevenueReport (@option nvarchar(10),@hotelname nvarchar(50), @m int, @y int)
AS BEGIN
DECLARE @sqlstring nvarchar(1500), @input nvarchar(100)
IF(@option = N'Tháng') --báo cáo doanh thu theo tháng
	BEGIN
		IF(@m IS NOT NULL AND @y IS NULL) ---chỉ theo tháng (cho trước)

		BEGIN
			SET @sqlstring = 'SELECT K.maKS, K.tenKS, DATEPART(MONTH,H.ngayThanhToan) as Thang, SUM(H.tongTien) as DoanhThu
						      FROM HoaDon H, DatPhong D, LoaiPhong L, KhachSan K
						      WHERE H.maDP=D.maDP AND D.maLoaiPhong=L.maLoaiPhong AND L.maKS=K.maKS AND DATEPART(MONTH,H.ngayThanhToan) = @m'
			---IF(@hotelname IS NULL) ---không báo cáo theo khách sạn --không làm gì cả
			IF(@hotelname IS NOT NULL)---báo cáo theo khách sạn
				SET @sqlstring = @sqlstring  + ' AND K.tenKS like N''%' +@hotelname + '%'''
			---thêm phần group by và order
			SET @sqlstring = @sqlstring + ' GROUP BY DATEPART(MONTH,H.ngayThanhToan), K.maKS, K.tenKS'
			SET @sqlstring = @sqlstring + ' ORDER BY K.maKS'
		END

		ELSE ---theo tháng, năm

		BEGIN
			SET @sqlstring = 'SELECT K.maKS, K.tenKS, DATEPART(MONTH,H.ngayThanhToan) as Thang, DATEPART(YEAR,H.ngayThanhToan) as Nam,SUM(H.tongTien) as DoanhThu
						      FROM HoaDon H, DatPhong D, LoaiPhong L, KhachSan K
						      WHERE H.maDP=D.maDP AND D.maLoaiPhong=L.maLoaiPhong AND L.maKS=K.maKS'
			---IF(@hotelname IS NULL) ---không báo cáo theo khách sạn --không làm gì cả
			IF(@hotelname IS NOT NULL)---báo cáo theo khách sạn
				SET @sqlstring = @sqlstring + ' AND K.tenKS LIKE N''%' +@hotelname + '%'''
			---IF(@m IS NULL AND @y IS NULL) ---tháng bất kỳ, năm bất kỳ ---không làm gì hết
			IF(@m IS NULL AND @y IS NOT NULL) ---tháng bất kỳ, năm cho trước
				SET @sqlstring = @sqlstring + ' AND DATEPART(YEAR,H.ngayThanhToan) = @y'	
			IF(@m IS NOT NULL AND @y IS NOT NULL) ---tháng cho trước, năm cho trươc
				SET @sqlstring = @sqlstring + ' AND DATEPART(YEAR,H.ngayThanhToan) = @y AND DATEPART(MONTH,H.ngayThanhToan) = @m'
			---thêm phần group by và order
			SET @sqlstring = @sqlstring + ' GROUP BY DATEPART(MONTH,H.ngayThanhToan), DATEPART(YEAR,H.ngayThanhToan), K.maKS, K.tenKS'
			SET @sqlstring = @sqlstring + ' ORDER BY K.maKS'
		END

	END

ELSE IF((@option = N'Năm' AND @m IS NULL AND @y IS NOT NULL)
   OR (@option = N'Năm' AND @m IS NULL AND @y IS NULL)) ---báo cáo doanh thu theo năm

BEGIN
	SET @sqlstring = 'SELECT K.maKS, K.tenKS,DATEPART(YEAR,H.ngayThanhToan) as Nam, SUM(H.tongTien) as DoanhThu
					  FROM HoaDon H, DatPhong D, LoaiPhong L, KhachSan K
					  WHERE H.maDP=D.maDP AND D.maLoaiPhong=L.maLoaiPhong AND L.maKS=K.maKS'
	---IF(@hotelname IS NULL) ---không báo cáo theo khách sạn--không làm gì cả
	IF(@hotelname IS NOT NULL)---báo cáo theo khách sạn
		SET @sqlstring = @sqlstring + ' AND K.tenKS LIKE N''%' +@hotelname + '%'''
	--IF(@y IS NULL) --theo năm bất kỳ ---không làm gì cả
	IF(@y IS NOT NULL)
		SET @sqlstring = @sqlstring + ' AND DATEPART(YEAR,H.ngayThanhToan) = @y'
	--thêm group by và order
	SET @sqlstring = @sqlstring + ' GROUP BY DATEPART(YEAR,H.ngayThanhToan), K.maKS, K.tenKS'
	SET @sqlstring = @sqlstring + ' ORDER BY K.maKS'
END

ELSE
	PRINT N'Lỗi! Không thể báo cáo doanh thu theo năm theo định dạng này.';

SET @input = ' @option NVARCHAR(10), @hotelname NVARCHAR(50), @m INT, @y INT '
EXEC SP_EXECUTESQL @sqlstring,
				   @input,
				   @option,
				   @hotelname,
				   @m,
				   @y
END