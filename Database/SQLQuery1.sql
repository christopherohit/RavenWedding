
CREATE database OnYourWeddingDay

USE OnYourWeddingDay
go
Use OnYourWeddingDay
DROP TABLE nhanvien
Create TABLE nhanvien(
	id INT IDENTITY(1,1) PRIMARY KEY,
	Hoten VARCHAR(100) NOT NULL,
	Email VARCHAR(100) NOT NULL,
	Pass VARCHAR(100) NOT NULL,
	Gender VARCHAR(500),
	Pic VARBINARY(MAX),
	Phone INT,
	Addre VARCHAR(150),
	CMND INT UNIQUE,
	Birth DATE,
	Descrip VARCHAR(500),
	MaChucVu int,
	Regency VARCHAR(100),
	Salary DECIMAL(9,0)
	FOREIGN KEY (MaChucVu) REFERENCES ChucVu (MaChucVu)
)

CREATE TABLE ChucVu(
	MaChucVu INT IDENTITY(1,1) PRIMARY KEY,
	ChucVu VARCHAR(50),
)
INSERT INTO dbo.ChucVu
(
	ChucVu
)
VALUES


CREATE TRIGGER LuongChucVu ON nhanvien
AFTER INSERT
AS
BEGIN
DECLARE @id INT
DECLARE @Machuvu INT
DECLARE @luong INT
	SELECT @Machuvu = machucvu FROM dbo.ChucVu
	SELECT MaChucVu , @luong = luong FROM inserted WHERE MaChucVu = @Machuvu
	UPDATE dbo.nhanvien SET luong = @luong * 10 WHERE MaChucVu = 1
	UPDATE dbo.nhanvien SET luong = @luong * 9 WHERE MaChucVu = 2
	UPDATE dbo.nhanvien SET luong = @luong * 8 WHERE MaChucVu = 3
	UPDATE dbo.nhanvien SET luong = @luong * 7 WHERE MaChucVu = 4
	UPDATE dbo.nhanvien SET luong = @luong * 6 WHERE MaChucVu = 5
	UPDATE dbo.nhanvien SET luong = @luong * 5 WHERE MaChucVu = 6
	UPDATE dbo.nhanvien SET luong = @luong * 4 WHERE MaChucVu = 7
	UPDATE dbo.nhanvien SET luong = @luong * 3 WHERE MaChucVu = 8
	UPDATE dbo.nhanvien SET luong = @luong * 2 WHERE MaChucVu = 9
END

create proc getaccount
@emails VARCHAR(100)
as
Begin
	select Email , Pass from nhanvien where Email = @emails
End 
go

Exec dbo.getaccount @emails = N'k9'

create proc Inste
@emails varchar(100),
@name varchar (100),
@pass varchar(100)
as
begin
	insert into nhanvien (Hoten,Email,Pass,) value (@name , @emails , @pass)
end
