
CREATE database OnYourWeddingDay

USE OnYourWeddingDay
go

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
	Salary DECIMAL(9,0),
	MessageI nvarchar(500),

	FOREIGN KEY (MaChucVu) REFERENCES ChucVu (MaChucVu)
)

CREATE TABLE ChucVu(
	MaChucVu INT IDENTITY(1,1) PRIMARY KEY,
	ChucVu VARCHAR(50),
)











BEGIN -- TRIGER AND STORE PROCDURE

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
	@emails VARCHAR(100), @password varchar(100)
	as
	Begin
		select * FROM dbo.nhanvien WHERE Email = @emails AND Pass = @password
	END

	create proc Inste
	@emails varchar(100),
	@name varchar (100),
	@pass varchar(100)
	as
	begin
		insert into nhanvien (Hoten,Email,Pass) VALUES (@name , @emails , @pass)
	END

	create proc getaccount
	@emails varchar (100), @pass varchar(100)
	AS BEGIN
		SELECT * FROM dbo.nhanvien WHERE Email = @emails AND Pass = @pass
	END
END

BEGIN --SQL Execute
	BEGIN -- TAKE OUT ACCOUNT TO LOGIN
		Exec dbo.getaccount @emails = N'hermonie023@cs.kevart.com' , @pass = N'emma021021' 
		Exec dbo.getaccount @emails = N'hermonie023@cs.kevart.com' , @pass = N'emma021021'
		SELECT * FROM dbo.nhanvien WHERE Email = N'hermonie023@cs.kevart.com' AND Pass = N'emma021021'
	END
END

BEGIN -- Insert Data 
	BEGIN --INSERT DATA NHANVIEN
		INSERT INTO dbo.nhanvien (Hoten,Email,Pass,Gender,Phone,Addre,CMND,Birth,Descrip, MaChucVu,Regency,Salary,MessageI,Pic)
		SELECT N'Emma Wattson', N'hermomie05@cs.kaviert.com' , N'emmawat0412112' , N'Female' , 083441564 , N'Pa-ri, France' , 196461313 ,'1990-4-15', N'I am a Good Girl' , '1', N'Designer', '', ,
	END
	BEGIN --INSERT DATA CHUCVU
		INSERT INTO dbo.ChucVu
		(
			ChucVu
		)
		VALUES
		('Manager' -- ChucVu - varchar(50)
		)
		INSERT INTO dbo.ChucVu
		(
			ChucVu
		)
		VALUES
		('Deputy Manager' -- ChucVu - varchar(50)
			)
		INSERT INTO dbo.ChucVu
		(
			ChucVu
		)
		VALUES
		(
		'Receptionists' -- ChucVu - varchar(50)
		)
	END
END