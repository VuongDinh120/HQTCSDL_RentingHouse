USE QLTN
GO

--CREATE 
ALTER
PROC USP_Login @username NCHAR(40), @password NCHAR(40)
AS 
BEGIN TRAN
	
	BEGIN TRY
	IF NOT EXISTS (SELECT * FROM users u WHERE u.username = @username and u.u_password = @password)
	BEGIN
		PRINT N'Mật khẩu hoặc username không đúng'
		ROLLBACK TRAN
		RETURN
	END
	--ĐỂ TEST
	--WAITFOR DELAY '0:0:10'
	-------------
	SELECT * FROM users u WHERE u.username = @username and u.u_password = @password
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN
	END CATCH
COMMIT TRAN
RETURN
GO

--CREATE 
ALTER
PROC USP_UpdateAccountInfo  @id int, @username NCHAR(40), @fullname NCHAR(40), @dob DATE, @phone NCHAR(11), @idCard NCHAR(11)
AS 
BEGIN
	UPDATE users SET username=@username, fullname=@fullname, dob=@dob, phone=@phone, id_card=@idCard WHERE id=@id
END
GO

--CREATE 
ALTER
PROC USP_UpdateBalance  @id int, @newbalance FLOAT
AS 
BEGIN TRAN
	BEGIN TRY
		
		IF NOT EXISTS (SELECT * FROM users WHERE id=@id)
		BEGIN
			PRINT N'user ID không tồn tại'
			ROLLBACK TRAN
			RETURN 0
		END
		
		DECLARE @sodu FLOAT
		SELECT @sodu=account_balance FROM users WHERE id=@id

		--ĐỂ TEST
		--WAITFOR DELAY '0:0:10'
		-------------

		SET @sodu = @sodu + @newbalance

		UPDATE users SET account_balance = @sodu WHERE id=@id
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN 0
	END CATCH
COMMIT TRAN
RETURN 1
GO
select * from users