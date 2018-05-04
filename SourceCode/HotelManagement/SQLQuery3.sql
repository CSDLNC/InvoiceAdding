USE [QuanLyKhachSan]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[SP_EmptyRoomStatistics]
		@hotelname = NULL,
		@typeofroomname = NULL,
		@date = NULL

SELECT	@return_value as 'Return Value'

GO
