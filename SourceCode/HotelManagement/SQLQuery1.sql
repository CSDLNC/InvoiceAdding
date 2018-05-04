USE [QuanLyKhachSan]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[SP_CreateBill]
		@maDP = NULL

SELECT	@return_value as 'Return Value'

GO
