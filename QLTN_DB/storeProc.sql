USE QLTN
GO
--///////////////////// DIRTY READ //////////////////////////////
--Transaction1 lost update  //// login proc
CREATE 
--ALTER
PROC USP_Login @username NCHAR(40), @password NCHAR(40)
AS 
BEGIN TRAN
	
	BEGIN TRY
	IF NOT EXISTS (SELECT * FROM users u WHERE u.username = @username and u.u_password = @password)
	BEGIN
		RAISERROR(N'Mật khẩu hoặc username không đúng',16,1)
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
		RAISERROR(N'LỖI HỆ THỐNG',16,1)
		ROLLBACK TRAN
		RETURN
	END CATCH
COMMIT TRAN
RETURN
GO
--Transaction2 lost update  //// change pass proc
CREATE 
--ALTER
PROC usp_ChangPassword @id INT, @NewPassword nvarchar(50)
AS
BEGIN TRAN
	BEGIN TRY
		UPDATE users SET u_password = @NewPassword 
		WHERE id=@id
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		RAISERROR(N'LỖI HỆ THỐNG',16,1)
		ROLLBACK TRAN
		RETURN 0
	END CATCH
COMMIT TRAN
RETURN 1
GO
--///////////////////// UNREPEATABLE READ ////////////////////////////
--Transaction1 dirty read /// Login
CREATE
--ALTER
PROC usp_RegisterHouse
	@dientich DECIMAL(5,2), @gia FLOAT, @songuoi INT, @diachi NVARCHAR(50), @quan INT, @mota NVARCHAR(50), @chunha INT
AS
BEGIN TRAN
	BEGIN TRY
	DECLARE @phithue FLOAT, @MaNha INT
	SET @phithue = (SELECT price FROM fees WHERE name=N'Phi gioi thieu')

	INSERT INTO houses (area, rental, number_people, h_address, district_id, h_description, h_user_id)
		VALUES (@dientich, @gia, @songuoi, @diachi, @quan, @mota, @chunha)
	SET @MaNha = (SELECT CAST(scope_identity() AS int))
	--ĐỂ TEST
	WAITFOR DELAY '0:0:10'
	-------------

	INSERT INTO contracts (house_id, c_order, fee) VALUES (@MaNha,1, @phithue)

	END TRY
	BEGIN CATCH
		RAISERROR(N'Số dư của bạn không đủ!!',16,1)
		ROLLBACK TRAN
		RETURN 0
	END CATCH
COMMIT TRAN
RETURN 1
GO
--Transaction2 dirty read /// change pass
CREATE 
--ALTER
PROC usp_XemChiTietNha @MaNha INT
AS
SET TRAN ISOLATION LEVEL READ UNCOMMITTED
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM houses 
		WHERE id=@MaNha)
		BEGIN
			RAISERROR(N'Mã nhà không tồn tại',16,1)
			PRINT CAST(@MaNha AS VARCHAR(10)) + N' Không tồn tại Mã nhà này'
			ROLLBACK TRAN
		RETURN 1
		END
		SELECT * FROM houses WHERE id=@MaNha
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0
GO
--dirty read trigger
CREATE TRIGGER trg_TruTienDKNha ON contracts
FOR INSERT
AS 
BEGIN
	DECLARE @fee FLOAT, @userId INT
	SET	@fee = (SELECT price FROM fees WHERE id=3) 
	SELECT @userId = u.id FROM inserted i JOIN houses h ON i.house_id = h.id JOIN users u ON h.h_user_id = u.id
	UPDATE users SET account_balance = account_balance - @fee WHERE id = @userId
END
GO

--//////////////////////// LOST UPDATE /////////////////////////


--///////////////////////// PHANTOM READ //////////////////////////


--/////////////////////////ADDITION///////////////////////////
--update account info proc
CREATE 
--ALTER
PROC USP_UpdateAccountInfo  @id int, @username NCHAR(40), @fullname NCHAR(40), @dob DATE, @phone NCHAR(11), @idCard NCHAR(11)
AS 
BEGIN
	UPDATE users SET username=@username, fullname=@fullname, dob=@dob, phone=@phone, id_card=@idCard WHERE id=@id
END
GO
--update balance
CREATE 
--ALTER
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

SELECT bd.*, h.*, d.name AS distric, u.fullname FROM booking_detail bd JOIN houses h ON bd.house_id=h.id JOIN districts d ON d.id = h.district_id JOIN users u ON u.id = h.h_user_id