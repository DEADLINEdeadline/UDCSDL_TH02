USE master
GO
IF DB_ID('QuanLyDanhSach') IS NOT NULL
BEGIN;
	DROP DATABASE QuanLyDanhSach;
END;
GO
CREATE DATABASE QuanLyDanhSach
GO 
USE QuanLyDanhSach
GO

CREATE TABLE ACCOUNT
(
	UserName	VARCHAR(100),
	DisplayName NVARCHAR(100),
	Email		VARCHAR(100) NOT NULL UNIQUE,
	passWord	VARCHAR(1000) NOT NULL,
	typeAcc		INT NOT NULL DEFAULT 0 --1; Admin 0: staff

	CONSTRAINT PK_USERNAME PRIMARY KEY(UserName)
)
GO

CREATE TABLE SANPHAM
(
	IdSP		INT IDENTITY(1,1),
	TenSP		NVARCHAR(50),
	DonGia		FLOAT DEFAULT 0
    
	CONSTRAINT PK_IDSP PRIMARY KEY(IdSP)
)

INSERT INTO dbo.ACCOUNT(Email,UserName, DisplayName, passWord, typeAcc ) VALUES  ('1560194@gmail.com', '1560194', N'Hoàng', '123', 1)

GO

IF OBJECT_ID('usp_Login','P') IS NOT NULL
BEGIN
	DROP PROC usp_Login
END
GO


CREATE PROC usp_Login
	@userName	VARCHAR(50),
	@passWord	VARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.ACCOUNT WHERE UserName = @userName AND passWord = @passWord
END
GO

IF OBJECT_ID('usp_confirmEmail','P') IS NOT NULL
BEGIN
	DROP PROC usp_confirmEmail
END
GO


CREATE PROC usp_confirmEmail
	@email		VARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.ACCOUNT WHERE Email = @email
END
GO

IF OBJECT_ID('usp_changePassword','P') IS NOT NULL
BEGIN
	DROP PROC usp_changePassword
END
GO

CREATE PROC usp_changePassword
	@password	VARCHAR(100),
	@email		VARCHAR(100)
AS
BEGIN
	UPDATE dbo.ACCOUNT SET passWord = @password WHERE Email = @email
END
GO


IF OBJECT_ID('usp_Register','P') IS NOT NULL
BEGIN
	DROP PROC usp_Register
END
GO

CREATE PROC usp_Register
	@username		VARCHAR(100),
	@displayname	NVARCHAR(100),
	@email			VARCHAR(100),
	@password		VARCHAR(100),
	@typeacc		INT
AS
BEGIN
	IF(EXISTS(SELECT AC.UserName FROM dbo.ACCOUNT AC WHERE AC.UserName = @username))
	BEGIN
		RETURN -1;
	END
	
	IF(EXISTS(SELECT AC.Email FROM dbo.ACCOUNT AC WHERE AC.Email = @email))
	BEGIN
		RETURN -1;
	END

	INSERT INTO dbo.ACCOUNT( UserName, DisplayName, Email, passWord, typeAcc )VALUES (@username, @displayname, @email, @password, @typeacc)
END
GO

INSERT INTO dbo.SANPHAM (TenSP, DonGia ) VALUES  (N'Keo dán chuột', 10000.0)
INSERT INTO dbo.SANPHAM (TenSP, DonGia ) VALUES  (N'Keo con chó', 20000.0)

SELECT UserName AS N'Tên Đăng Nhập', DisplayName AS N'Họ Tên', Email ,typeAcc AS N'Chức vụ' FROM dbo.ACCOUNT
GO
SELECT * FROM dbo.SANPHAM