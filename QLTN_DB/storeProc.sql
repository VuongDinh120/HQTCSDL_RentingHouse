USE QLTN
GO

CREATE 
--ALTER
PROC USP_Login @username NCHAR(40), @password NCHAR(40)
AS 
BEGIN TRAN
	--WAITFOR DELAY '0:0:05'
	IF NOT EXISTS (SELECT * FROM users u WHERE u.username = @username and u.u_password = @password)
	BEGIN
		PRINT N'Mật khẩu hoặc username không đúng'
		RETURN
	END

	PRINT 'Đăng nhập thành công'
	SELECT * FROM users u WHERE u.username = @username and u.u_password = @password
COMMIT TRAN
GO

CREATE 
--ALTER
PROC USP_UpdateAccountInfo  @id int,@username NCHAR(40), @fullname NCHAR(40), @dob DATE, @phone NCHAR(11), @idCard NCHAR(11)
AS 
BEGIN
	UPDATE users SET username=@username, fullname=@fullname, dob=@dob, phone=@phone, id_card=@idCard WHERE id=@id
END
GO

--EXEC USP_Login N'user01','123456'