USE master
GO
if db_id('QLTN') is not null
	drop database QLTN
GO
CREATE DATABASE QLTN
GO

USE QLTN
GO

CREATE TABLE districts(
	id INT PRIMARY KEY IDENTITY(1,1),
	name nvarchar(40),
)
GO

CREATE TABLE roles(
	id INT PRIMARY KEY IDENTITY(1,1),
	r_type nvarchar(40),
)
GO

CREATE TABLE users(
	id INT PRIMARY KEY IDENTITY(1,1),
	username nchar(40),
	u_password nchar(40),
	fullname nvarchar(40),
	dob nchar(40),
	phone nchar(15),
	id_card nchar(15),
	account_balance float DEFAULT 0 CHECK (account_balance>=0),
	role_id INT
)
GO

CREATE TABLE fees(
	id INT PRIMARY KEY IDENTITY(1,1),
	name nvarchar(40),
	price float CHECK (price>=0)
)
GO

CREATE TABLE transactions(
	id INT PRIMARY KEY IDENTITY(1,1),
	t_datetime datetime DEFAULT GETDATE(),
	t_money float,
	t_fee_id INT,
	t_user_id INT
)
GO

CREATE TABLE booking(
	id INT PRIMARY KEY IDENTITY(1,1),
	begin_date DATE,
	end_date DATE,
	received_date DATE DEFAULT GETDATE(),
	b_status nvarchar(40),
	number_house int,
	rent_fee float,
	liability_fee float,
	b_user_id INT,
)
GO

CREATE TABLE houses(
	id INT PRIMARY KEY IDENTITY(1,1),
	area decimal(5,2),
	rental float,
	number_people int,
	h_address nvarchar(100), 
	h_description nvarchar(100),
	h_add_info nvarchar(100),
	h_status nvarchar(40),
	reason nvarchar(40),
	created_at datetime DEFAULT GETDATE(),
	district_id INT,
	h_user_id INT,
)
GO

CREATE TABLE booking_detail(
	booking_id INT,
	house_id INT,
	meet_time datetime, 
	meet_address nvarchar(40),
	meet_phone nchar(15),
	is_rented int DEFAULT 0,
	feedback nvarchar(40),
	CONSTRAINT PK_booking_detail PRIMARY KEY(booking_id, house_id)
)
GO

CREATE TABLE surveys(
	id INT PRIMARY KEY IDENTITY(1,1),
	detail nvarchar(100),
	s_status nvarchar(40),
	house_id INT,
	s_user_id INT,
)
GO

CREATE TABLE contracts(
	house_id INT,
	c_order int,
	begin_date DATE,
	end_date DATE,
	fee float,
	CONSTRAINT PK_contract PRIMARY KEY(house_id, c_order)
)
GO



ALTER TABLE users WITH CHECK ADD CONSTRAINT FK_users_roles FOREIGN KEY(role_id)
REFERENCES roles(id)
GO
ALTER TABLE users CHECK CONSTRAINT FK_users_roles
GO

ALTER TABLE houses WITH CHECK ADD CONSTRAINT FK_houses_users FOREIGN KEY(h_user_id)
REFERENCES users(id)
GO
ALTER TABLE houses CHECK CONSTRAINT FK_houses_users
GO

ALTER TABLE houses WITH CHECK ADD CONSTRAINT FK_houses_districts FOREIGN KEY(district_id)
REFERENCES districts(id)
GO
ALTER TABLE houses CHECK CONSTRAINT FK_houses_districts
GO

ALTER TABLE surveys WITH CHECK ADD CONSTRAINT FK_surveys_users FOREIGN KEY(s_user_id)
REFERENCES users(id)
GO
ALTER TABLE surveys CHECK CONSTRAINT FK_surveys_users
GO

ALTER TABLE surveys WITH CHECK ADD CONSTRAINT FK_surveys_houses FOREIGN KEY(house_id)
REFERENCES houses(id)
GO
ALTER TABLE surveys CHECK CONSTRAINT FK_surveys_houses
GO

ALTER TABLE contracts WITH CHECK ADD CONSTRAINT FK_contracts_houses FOREIGN KEY(house_id)
REFERENCES houses(id)
GO
ALTER TABLE contracts CHECK CONSTRAINT FK_contracts_houses
GO

ALTER TABLE transactions WITH CHECK ADD CONSTRAINT FK_transactions_fees FOREIGN KEY(t_fee_id)
REFERENCES fees(id)
GO
ALTER TABLE transactions CHECK CONSTRAINT FK_transactions_fees
GO

ALTER TABLE transactions WITH CHECK ADD CONSTRAINT FK_transactions_users FOREIGN KEY(t_user_id)
REFERENCES users(id)
GO
ALTER TABLE transactions CHECK CONSTRAINT FK_transactions_users
GO

ALTER TABLE booking WITH CHECK ADD CONSTRAINT FK_booking_users FOREIGN KEY(b_user_id)
REFERENCES users(id)
GO
ALTER TABLE booking CHECK CONSTRAINT FK_booking_users
GO


ALTER TABLE booking_detail WITH CHECK ADD CONSTRAINT FK_booking_detail_booking FOREIGN KEY(booking_id)
REFERENCES booking(id)
GO
ALTER TABLE booking_detail CHECK CONSTRAINT FK_booking_detail_booking
GO

ALTER TABLE booking_detail WITH CHECK ADD CONSTRAINT FK_booking_detail_houses FOREIGN KEY(house_id)
REFERENCES houses(id)
GO
ALTER TABLE booking_detail CHECK CONSTRAINT FK_booking_detail_houses
GO
