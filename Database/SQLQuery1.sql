
CREATE database OnYourWeddingDay
USE OnYourWeddingDay

go

create table Work(
	id int identity (1,1) primary key,
	NameOfWork varchar(500),
	MaxTime datetime,
	Prize varchar(500)
)

create table task(
	id int identity (1,1) primary key,
	NameTask varchar(100),
	WorkFrom date , 
	WorkTo date,
	PeopleDo varchar(500),
	workinclude int,
	Describe varchar(500),
	Exception varchar(500)

	foreign key (workinclude) references Work(id)
	
)

alter table nhanvien add column Id task int foreign key
CREATE TABLE nhanvien(
	id INT IDENTITY(1,1) PRIMARY KEY,
	Hoten VARCHAR(100) NOT NULL,
	Email VARCHAR(100) NOT NULL,
	Pass VARCHAR(100) NOT NULL,
	Gender VARCHAR(500),
	Pic VARBINARY(MAX),
	Phone INT,
	Addre VARCHAR(150),
	CMND INT,
	Birth DATE,
	Descrip VARCHAR(500),
	MaChucVu int,
	Regency VARCHAR(100),
	Salary DECIMAL(9,0),
	is_blocked BIT ,
	is_reported BIT,
	create_at DATETIME,
	FOREIGN KEY (MaChucVu) REFERENCES ChucVu (MaChucVu)
	UNIQUE(Email)
)

CREATE TABLE USER_CONTACT (
	ID INT IDENTITY (1,1) PRIMARY KEY,
	USER_ID INT,
	CONTACT_ID INT,
	FULLNAME VARCHAR(100),
	CREATE_AT DATETIME,

	FOREIGN KEY (USER_ID) REFERENCES dbo.nhanvien (id),
	FOREIGN KEY (CONTACT_ID) REFERENCES CONTACT (ID)
)

CREATE TABLE CONTACT (
	ID INT IDENTITY(1,1) PRIMARY KEY,
	FULLNAME VARCHAR(100),
	PHONE INT,
	EMAILS VARCHAR(255),
	CREATE_AT DATETIME
)

CREATE TABLE ChucVu(
	MaChucVu INT IDENTITY(1,1) PRIMARY KEY,
	ChucVu VARCHAR(50),
)

CREATE TABLE DEVICE (
	ID INT IDENTITY (1,1) PRIMARY KEY,
	USER_ID INT,
	DEVICE_ID INT,
	DEVICE_TOKEN VARCHAR(120),
	CREATE_AT DATETIME,
	UPDATE_AT DATETIME

	FOREIGN KEY (USER_ID) REFERENCES dbo.nhanvien (id)
)

CREATE TABLE ACCESS (
	ID INT IDENTITY(1,1) PRIMARY KEY,
	USER_ID INT,
	DEVICE_ID INT,
	TOKEN VARCHAR(60),
	CREATE_AT DATETIME,
	UPDATE_AT DATETIME

	FOREIGN KEY (USER_ID) REFERENCES dbo.nhanvien (id),
	FOREIGN KEY (DEVICE_ID) REFERENCES dbo.DEVICE (ID)
)

CREATE TABLE CONVERSATIONS (
	ID INT IDENTITY (1,1) PRIMARY KEY,
	USER_ID INT, --CREATOR_ID
	TITLE VARCHAR(255),
	CHANNEL_ID VARCHAR(255),
	CREATE_AT DATETIME,
	UPDATE_AT DATETIME,
	DELETE_AT DATETIME

	FOREIGN KEY (USER_ID) REFERENCES dbo.nhanvien (id)
)

CREATE TABLE PARTICIPANT (
	ID INT IDENTITY (1,1) PRIMARY KEY,
	CONVERSATIONS_ID INT,
	USER_ID INT,
	CREATE_AT DATETIME,
	UPDATE_AT DATETIME

	FOREIGN KEY (USER_ID) REFERENCES dbo.nhanvien (id),
	FOREIGN KEY (CONVERSATIONS_ID) REFERENCES dbo.CONVERSATIONS (ID)
)

CREATE TABLE BLOCK_LIST (
	ID INT IDENTITY (1,1) PRIMARY KEY,
	USER_ID INT,
	PARTICIPANT_ID INT,
	CREATE_AT DATETIME

	FOREIGN KEY (USER_ID) REFERENCES dbo.nhanvien (id),
	FOREIGN KEY (PARTICIPANT_ID) REFERENCES dbo.PARTICIPANT (ID)
)

CREATE TABLE USER_VERIFICATION (
	USER_ID INT,
	VERIFICATION_CODE VARCHAR(45),
	CREATE_AT DATETIME

	FOREIGN KEY (USER_ID) REFERENCES dbo.nhanvien (id)
)

CREATE TABLE REPORT (
	ID INT IDENTITY (1,1) PRIMARY KEY,
	USER_ID INT,
	PARTICIPANT_ID INT,
	REPORT_TYPE VARCHAR(45),
	NOTES TEXT,
	CREATE_AT DATETIME

	FOREIGN KEY (USER_ID) REFERENCES dbo.nhanvien (id),
	FOREIGN KEY (PARTICIPANT_ID) REFERENCES dbo.PARTICIPANT (ID)
)

CREATE TABLE DELETE_CONVERSATION (
	ID INT IDENTITY (1,1) PRIMARY KEY,
	CONVERSATION_ID INT,
	USER_ID INT,
	CREATE_AT DATETIME

	FOREIGN KEY (USER_ID) REFERENCES dbo.nhanvien (id),
	FOREIGN KEY (CONVERSATION_ID) REFERENCES dbo.CONVERSATIONS (
ID)
)

CREATE TABLE MESSAGES (
	ID INT IDENTITY (1,1) PRIMARY KEY,
	CONVERSATION_ID INT,
	USER_ID INT, -- SENDER_ID
	GUILD VARCHAR(100),
	MESSAGES VARCHAR(455),
	CREATE_AT DATETIME,
	UPDATE_AT DATETIME

	FOREIGN KEY (CONVERSATION_ID) REFERENCES dbo.CONVERSATIONS (ID),
	FOREIGN KEY (USER_ID) REFERENCES dbo.nhanvien (id)
)

CREATE TABLE DELETE_MESSAGE (
	ID INT IDENTITY (1,1) PRIMARY KEY,
	MESS_ID INT,
	USER_ID INT,
	CREATE_AT DATETIME,
	UPDATE_AT DATETIME
	
	FOREIGN KEY (MESS_ID) REFERENCES dbo.MESSAGES (ID),
	FOREIGN KEY (USER_ID) REFERENCES dbo.nhanvien (id)
)

CREATE TABLE ATTACHMENT (
	ID INT IDENTITY(1,1) PRIMARY KEY,
	MESSAGE_ID INT,
	THUMP_URL VARCHAR(455),
	FILE_URL VARCHAR(455),
	CREATE_AT DATETIME,
	UPDATE_AT DATETIME

	FOREIGN KEY (MESSAGE_ID) REFERENCES dbo.MESSAGES (ID)
)

CREATE TABLE StageWedd(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	TenSanh VARCHAR(200) NOT NULL,
	TypeOfStage VARCHAR(100),
	SoLuongBan INT,
	MimiumPrice MONEY NOT NULL,
	Notice VARCHAR(200) DEFAULT N'Empty',
)


CREATE TABLE MenuFood(
	ID INT IDENTITY(1,1) PRIMARY KEY ,
	NameFood VARCHAR(100) NOT NULL,
	TotalCost MONEY NOT NULL
)

CREATE TABLE SoftDrink(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	NameDrink VARCHAR(100) NOT NULL,
	TotalCost MONEY NOT NULL,
)

CREATE TABLE Services(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	TypeOfService VARCHAR(100) NOT NULL,
	Cost MONEY NOT NULL
)

CREATE TABLE Party(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Periods VARCHAR(50) NOT NULL,
	Statuse VARCHAR(50) NOT NULL DEFAULT N'Non Ready'
)

CREATE TABLE Client (
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Fullname VARCHAR(100) NOT NULL,
	Emails VARCHAR(100) NOT NULL UNIQUE,
	MobilePhone INT ,
	Addresse VARCHAR(500),
	CertifiNumber INT ,
	MainChar1 VARCHAR(100),
	MainChar2 VARCHAR(100),
	Sanh INT ,
	MonAn INT,
	ThucUong INT,
	Periods INT,
	NeedSer INT,
	DateCele DATE NOT NULL,
	SetMoney MONEY NOT NULL,

	FOREIGN KEY (Sanh) REFERENCES dbo.StageWedd(ID),
	FOREIGN KEY (MonAn) REFERENCES dbo.MenuFood(ID),
	FOREIGN KEY (ThucUong) REFERENCES dbo.SoftDrink(ID),
	FOREIGN KEY (Periods) REFERENCES dbo.Party(ID),
	FOREIGN KEY (NeedSer) REFERENCES dbo.Services(ID),
)

CREATE TABLE InfoParty(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	InForMember INT NOT NULL,
	InForCustom INT NOT NULL,
	Sanh INT ,
	Services INT,
	Food INT,
	Drink INT,
	SoLuongNhanVien INT ,
	Party INT

	FOREIGN KEY (InForMember) REFERENCES dbo.nhanvien(id),
	FOREIGN KEY (InForCustom) REFERENCES dbo.Client(ID),
	FOREIGN KEY (Sanh) REFERENCES dbo.StageWedd(ID),
	FOREIGN KEY (Services) REFERENCES dbo.Services(ID),
	FOREIGN KEY (Food) REFERENCES dbo.MenuFood(ID),
	FOREIGN KEY (Drink) REFERENCES dbo.SoftDrink(ID)
)

CREATE TABLE Recipst (
	ID INT IDENTITY(1,1) PRIMARY KEY ,
	InfoParty INT ,
	Client INT ,
	Stage INT,
	Serv INT ,
	Food INT ,
	Drink INT ,
	TongTien MONEY ,
	TienCoc MONEY ,
	TienConLai MONEY,

	FOREIGN KEY (InfoParty) REFERENCES dbo.InfoParty(ID),
	FOREIGN KEY (Client) REFERENCES dbo.Client (ID),
	FOREIGN KEY (Stage) REFERENCES dbo.StageWedd (ID),
	FOREIGN KEY (Serv) REFERENCES dbo.Services (ID),
	FOREIGN KEY (Food) REFERENCES dbo.MenuFood (ID),
	FOREIGN KEY (Drink) REFERENCES dbo.SoftDrink (ID),
	)

CREATE TABLE DoanhThu(
	id INT IDENTITY(1,1) PRIMARY KEY,
	Thang INT ,
	TongDoanhThu INT,
	soluongtiec INT 
)

CREATE TABLE BReport (
	ID INT IDENTITY (1,1) PRIMARY KEY,
	TenNguoiLap INT,
	DoanhThu INT, 
    NgayLap DATE NOT NULL,

	FOREIGN KEY (TenNguoiLap) REFERENCES dbo.nhanvien (id),
	FOREIGN KEY (DoanhThu) REFERENCES dbo.DoanhThu(id)
)




BEGIN -- TRIGER AND STORE PROCDURE
	CREATE UNIQUE INDEX indexunique
		ON dbo.nhanvien(Phone,CMND)
		WHERE Phone IS NOT NULL AND CMND IS NOT NULL
	
		
	CREATE TRIGGER LuongChucVu ON nhanvien
	AFTER INSERT
	AS BEGIN 
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
	END -- Fail

	CREATE PROC getaccount
	@emails VARCHAR(100), @password varchar(100)
	AS BEGIN
		select * FROM dbo.nhanvien WHERE Email = @emails AND Pass = @password
	END -- OK

	CREATE PROC Inste
	@emails varchar(100),
	@name varchar (100),
	@pass varchar(100)
	AS BEGIN
		insert into nhanvien (Hoten,Email,Pass) VALUES (@name , @emails , @pass)
	END --Fail

	CREATE PROC getaccount
	@emails varchar (100),
	@pass varchar(100)
	AS BEGIN
		SELECT * FROM dbo.nhanvien WHERE Email = @emails AND Pass = @pass
	END --OK

	CREATE PROC CapNhapPass
	@Emails varchar(100),
	@pass varchar(100)
	AS BEGIN 
	UPDATE dbo.nhanvien
	SET Pass = @pass WHERE Email = @Emails
	END --OK

	CREATE PROC FillIn4InFormation
		@Emails varchar(100),
		@gender varchar (50),
		@phone int ,
		@Address varchar (500),
		@ICM INT , 
		@DOB DATE,
		@DES VARCHAR(500)
			AS BEGIN
				UPDATE dbo.nhanvien
				SET  Gender = @gender , Phone = @phone , Addre = @Address, CMND = @ICM , Birth = @DOB , Descrip = @DES WHERE Email = @Emails
			END --OK

	drop proc UpdatePerson
	Create proc UpdatePerson
	@Emails varchar(100),
	@name varchar(100),
	@gender varchar(500),
	@phone int ,
	@Address varchar(150),
	@ICM INT , 
	@DOB DATE,
	@DES VARCHAR(500),
	@id int
	as begin
	update nhanvien
	set Hoten = @name, Gender = @gender , Phone = @phone , Addre = @Address, CMND = @ICM , Birth = @DOB , Descrip = @DES , Email = @Emails where id = @id
	end

	EXEC UpdatePerson  @name = N'Emma Charlotte Duerre Watson' , @gender = N'Female'  , @phone = 0792361509 , @Address = N'Pa-ri, France'  , @ICM = 196461313  , @DOB = N'1990-04-15', @DES = N'I am a Good Girl', @Emails = N'Hermione.UST@Brown.inter.st.edu.com', @id = 1
	create proc DeleteUser
	@id int
	as begin
	delete from nhanvien where id = @id
	end

	CREATE PROC BlockAccount
	@Emails varchar(100),
	@isblock varchar(100)
	AS BEGIN
	UPDATE dbo.nhanvien
	SET is_reported = 1 WHERE Email = @Emails
	END --OK

	CREATE PROC InsertMember
	@name varchar (100),
	@email varchar (100),
	@pass varchar (100)
	AS BEGIN
		INSERT INTO dbo.nhanvien
		(
		    Hoten,
		    Email,
		    Pass,
		    Gender,
		    Phone,
		    Addre,
		    CMND,
		    Birth,
		    Descrip,
		    MaChucVu,
		    Regency,
		    Salary,
		    is_blocked,
		    is_reported,
		    create_at,
			Pic
		)
		VALUES
		(   @name,        -- Hoten - varchar(100)
		    @email,        -- Email - varchar(100)
		    @pass,        -- Pass - varchar(100)
		    NULL,        -- Gender - varchar(500)
		    NULL,         -- Phone - int
		    NULL,        -- Addre - varchar(150)
		    NULL,         -- CMND - int
		    NULL, -- Birth - date
		    NULL,        -- Descrip - varchar(500)
		    NULL,         -- MaChucVu - int
		    NULL,        -- Regency - varchar(100)
		    NULL,      -- Salary - decimal(9, 0)
		    NULL,      -- is_blocked - bit
		    NULL,      -- is_reported - bit
		    NULL, -- create_at - datetime
			NULL
		)
		END --OK

END

BEGIN --SQL Execute
	BEGIN -- TAKE OUT ACCOUNT TO LOGIN
		Exec dbo.getaccount @emails = N'hermomie05@cs.kaviert.com' , @password = N'emmawat0412112' 
		Exec dbo.getaccount @emails = N'hermonie023@cs.kevart.com' , @pass = N'emma021021'
		SELECT * FROM dbo.nhanvien WHERE Email = N'hermonie023@cs.kevart.com' AND Pass = N'emma021021'
	END

	BEGIN
		EXEC CapNhapPass @Emails = N'hermomie05@cs.kaviert.com' , @pass = N'emawattson123123'
		EXEC FillInFormation @Emails = N'hermomie05@cs.kaviert.com' , @name = N'Emma Wattson' , @gender = N'Female', @phone = 83441564 , @Address = N'Pa-ri, France' , @ICM = 196461313 , @DOB = N'' , @DES = N''
		EXEC InsertMember @name = N'Andy Genicius' , @email = N'isnotAndy@genicius.com' , @pass = N'04913sd121265'
	END
END

BEGIN -- Insert Data 
	BEGIN --INSERT DATA NHANVIEN
		INSERT INTO dbo.nhanvien (Hoten,Email,Pass,Gender,Phone,Addre,CMND,Birth,Descrip, MaChucVu,Regency,Salary,is_blocked,is_reported,create_at,Pic)
		SELECT N'Emma Wattson', N'hermomie05@cs.kaviert.com' , N'emmawat0412112' , N'Female' , 083441564 , N'Pa-ri, France' , 196461313 ,'1990-4-15', N'I am a Good Girl' , '1', N'Designer', '45000000',0,0,'2017-7-10', BulkColumn FROM OPENROWSET(BULK 'D:\Lesson\RIT\C #\Winform\Raven\Database\Used\HuongDanVien\Emma2.jpg', SINGLE_BLOB) AS PICTURE
		INSERT INTO dbo.nhanvien (Hoten,Email,Pass,Gender,Phone,Addre,CMND,Birth,Descrip,MaChucVu,Regency,Salary,is_blocked,is_reported,create_at, Pic)
		SELECT N'Gong Ji-cheol', N'sonofwind@epl.com', N'289131642', N'Male', 0794222361, N'52/89 LastStrip, Howard Sterm, Paris, France', 265995113, '1986-10-12', N'I am Goblin', 1, N'Puty Directory', 45000000, 0, 0, '2020-3-10' , BulkColumn FROM OPENROWSET(BULK 'D:\Lesson\RIT\C #\Winform\Raven\Database\Used\HuongDanVien\Gong Yoo.jpg', SINGLE_BLOB) AS PICTURE
		
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

BEGIN -- DROP TABLE
	DROP TABLE nhanvien
END