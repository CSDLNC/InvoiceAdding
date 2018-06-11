-- SP CREATE BILL

USE [QuanLyKhachSan]
GO
DROP PROCEDURE SP_CreateBill
CREATE PROCEDURE SP_CreateBill  @maDP int
AS
BEGIN
DECLARE @maHD AS int
DECLARE @ngayThanhToan AS datetime
DECLARE @tongtien AS money
DECLARE @LastRecord AS int
DECLARE @KiemTra AS int
SET NOCOUNT ON;
--Kiem tra xem Ma Dat phong co trong bang Dat phong Khong
IF EXISTS (SELECT @maDP FROM dbo.DatPhong AS HD WHERE @maDP = HD.maDP)
      BEGIN
 --Kiem tra co maHD trong bang chua
    IF EXISTS(SELECT HD.maHD FROM dbo.HoaDon AS HD )
      BEGIN
	  --KIEM TRA SO maDP trong Bang Hoa Don?
	  IF NOT EXISTS(SELECT @maDP FROM dbo.HoaDon AS HD WHERE @maDP=HD.maDP  GROUP BY HD.maDP HAVING COUNT(*) =1 )
	BEGIN
     --Tim max trong maHD
        SET @LastRecord = (
					SELECT MAX(HD.maHD)
				    FROM dbo.HoaDon AS HD
				  )
	  
	--tao moi maHD
	    SET @maHD=@LastRecord+1;

	--chon tong tien tuong ung voi don gia ben table Dat phong
	    SELECT  @tongtien = DP.donGia
	    FROM dbo.HoaDon AS HD, dbo.DatPhong AS DP
	    WHERE  DP.maDP= @maDP 
	    SET IDENTITY_INSERT dbo.HoaDon ON

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

	ELSE-- IF thu 3 kiem tra maDP co bi duplicate khong
	BEGIN
    PRINT 'DA CO MA DP TRONG BANG HOA DON '
	END
	END
	ELSE --IF thu 2 kiem tra maHD
	BEGIN
	     
       --Neu khong co du lieu trong HoaDon
	   -- Dat maHD=1
	--chon tong tien tuong ung voi don gia ben table Dat phong
	    SELECT  @tongtien = DP.donGia
	    FROM  dbo.DatPhong AS DP
	    WHERE  DP.maDP=@maDP
	    SET IDENTITY_INSERT dbo.HoaDon ON

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
	   1,
	   GETDATE(),
	   @tongtien,
	    @maDP
	  )

	   SET IDENTITY_INSERT dbo.HoaDon OFF


	--In ket qua cho nhan vien
	SELECT * 
	FROM dbo.HoaDon AS HD 
	WHERE HD.maHD = @maHD 
  
   END-- ket thuc cua phan nhap thong tin neu maHD khong co
   END
   ELSE--IF THU 1 Kiem Tra maDP
	--Neu khong co ma DP thi in ra thong bao
	PRINT 'Ma Dat Phong Khong Chinh Xac'
END



EXEC SP_CreateBill 5;
