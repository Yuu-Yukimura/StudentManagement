USE master
GO

-- Tạo Database 
CREATE DATABASE StudentManagement
GO

USE StudentManagement
GO

--
-- TẠO BẢNG
-- 1.bảng nhân viên 
-- 2.bảng tài khoản
-- 3.bảng công nợ
-- 4.bảng sinh viên
-- 5.bảng chi tiết nợ
-- 6.bảng môn học
-- 7.bảng lớp
-- 8.bảng chi tiết lớp
-- 9.bảng kết qua học tập


-- 1.bảng nhân viên
CREATE TABLE Staff
(
	-- INFO
	ID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL DEFAULT 'Chưa đặt tên',
	Avatar IMAGE,
	Sex BIT NOT NULL DEFAULT 1, -- 0 là nữ, 1 là nam
	DateOfBirth DATE NOT NULL DEFAULT '19900101',
	Address NVARCHAR(50) NOT NULL,
	Phone VARCHAR(20),
	MaritalStatus BIT NOT NULL DEFAULT '0', -- 0 là chưa kết hôn, 1 là đã kết hôn
	Type BIT NOT NULL DEFAULT '0', -- 0 là nhân viên, 1 là giảng viên
	Administrator BIT NOT NULL DEFAULT '0', -- 0 là user, 1 là admin
)
GO


-- 2.bảng tài khoản
CREATE TABLE Account
(
	-- INFO
	UserName VARCHAR(50) PRIMARY KEY,
	PassWord VARCHAR(50) NOT NULL DEFAULT '1',
	IDStaff INT UNIQUE NOT NULL

	-- FOREIGN
	FOREIGN KEY (IDStaff) REFERENCES dbo.Staff(ID)
)
GO

-- 3.bảng sinh viên
CREATE TABLE Student
(
	-- INFO
	ID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL DEFAULT 'Chưa đặt tên',
	Avatar IMAGE,
	Sex BIT NOT NULL DEFAULT 1, -- 0 là nữ, 1 là nam
	DateOfBirth DATE NOT NULL DEFAULT '20000101',
	Address NVARCHAR(50) NOT NULL,
	Phone VARCHAR(20),
	ParentPhone VARCHAR(20),
)
GO

-- 4.bảng công nợ
CREATE TABLE Debt 
(
	-- INFO
	ID INT PRIMARY KEY IDENTITY,
	SumOfDebt MONEY NOT NULL DEFAULT 0,
	IDStudent INT UNIQUE NOT NULL

	-- FOREIGN
	FOREIGN KEY (IDStudent) REFERENCES dbo.Student(ID)
)
GO

-- 5.bảng chi tiết nợ
CREATE TABLE DebtInfo
(
	-- INFO
	ID INT PRIMARY KEY IDENTITY,
	Money MONEY NOT NULL DEFAULT 0,
	Date DATE NOT NULL,
	IDDebt INT NOT NULL,

	-- FOREIGN
	FOREIGN KEY (IDDebt) REFERENCES dbo.Debt(ID)
)

-- 6.bảng môn học
CREATE TABLE Subject
(
	-- INFO
	ID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL DEFAULT 'Chưa đặt tên',
	Money MONEY NOT NULL DEFAULT 0,
)
GO

-- 7.bảng lớp
CREATE TABLE Class
(
	-- INFO
	ID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL DEFAULT 'Chưa đặt tên',
	Status INT NOT NULL DEFAULT 1, -- -1 là đã kết thúc, 0 là đang học, 1 là đang mở để đk
	DateStart DATE NOT NULL,
	DateEnd DATE NOT NULL,
	IDSubject INT NOT NULL,
	IDStaff INT NOT NULL,

	-- FOREIGN
	FOREIGN KEY (IDSubject) REFERENCES dbo.Subject(ID),
	FOREIGN KEY (IDStaff) REFERENCES dbo.Staff(ID)
)
GO

-- 8.bảng chi tiết lớp
CREATE TABLE ClassInfo
(
	-- INFO
	ID INT PRIMARY KEY IDENTITY,
	IDClass INT NOT NULL,
	IDStudent INT NOT NULL

	-- FOREIGN
	FOREIGN KEY (IDClass) REFERENCES dbo.Class(ID),
	FOREIGN KEY (IDStudent) REFERENCES dbo.Student(ID)
)
GO

-- 9.bảng kết qua học tập
CREATE TABLE Result
(
	-- INFO
	ID INT PRIMARY KEY IDENTITY,
	IDStudent INT NOT NULL,
	IDSubject INT NOT NULL,
	HalfGrade FLOAT,
	FinalGrade FLOAT,

	-- FOREIGN
	FOREIGN KEY (IDSubject) REFERENCES dbo.Subject(ID),
	FOREIGN KEY (IDStudent) REFERENCES dbo.Student(ID)
)
GO


--
-- THÊM RECORD
-- 1.bảng nhân viên 
-- 2.bảng tài khoản
-- 3.bảng sinh viên
-- 4.bảng công nợ
-- 5.bảng chi tiết nợ
-- 6.bảng môn học
-- 7.bảng lớp
-- 8.bảng chi tiết lớp
-- 9.bảng kết qua học tập


-- 1.bảng nhân viên
-- 1.1
INSERT dbo.Staff ( Name, Avatar, Sex, DateOfBirth, Address, Phone, MaritalStatus, Type, Administrator)
		   VALUES(N'Nguyễn Hoàng Quang Duy', null, 1, '19971010', N'Láng Cát', '0981333793', 1, 0, 1 )
-- 1.2
INSERT dbo.Staff ( Name, Avatar, Sex, DateOfBirth, Address, Phone, MaritalStatus, Type, Administrator)
		   VALUES(N'Hoàng Nhật Phong', null, 1, '19971015', N'Long Hải, Long Điền, Bà Rịa - Vũng Tàu', '333666999', 0, 0, 1 )
-- 1.3
INSERT dbo.Staff ( Name, Avatar, Sex, DateOfBirth, Address, Phone, MaritalStatus, Type, Administrator)
		   VALUES(N'Nguyễn Ngọc An', null, 1, '19931115', N'HCM', '012012321', 1, 1, 0 )
-- 1.4
INSERT dbo.Staff ( Name, Avatar, Sex, DateOfBirth, Address, Phone, MaritalStatus, Type, Administrator)
		   VALUES(N'Nguyễn Thị Bích Ngọc', null, 0, '19900711', N'Bà Rịa', '0122395421', 0, 0, 0 )
-- 1.5
INSERT dbo.Staff ( Name, Avatar, Sex, DateOfBirth, Address, Phone, MaritalStatus, Type, Administrator)
		   VALUES(N'Nguyễn Hải Yến', null, 0, '19950921', N'Đà Lạt', '7485452321', 0, 1, 0 )
GO
-- 2.bảng tài khoản
-- 2.1
INSERT dbo.Account (UserName, PassWord, IDStaff)
		     VALUES('1','1',1)
-- 2.2
INSERT dbo.Account (UserName, PassWord, IDStaff)
		     VALUES('novaghoul','1',2)
-- 2.3
INSERT dbo.Account (UserName, PassWord, IDStaff)
		     VALUES('an','1',3)
-- 2.4
INSERT dbo.Account (UserName, PassWord, IDStaff)
		     VALUES('ngoc','1',4)
-- 2.5
INSERT dbo.Account (UserName, PassWord, IDStaff)
		     VALUES('yen','1',5)
GO
-- 3.bảng sinh viên
-- 3.1
INSERT dbo.Student (Name, Avatar, Sex, DateOfBirth, Address, Phone, ParentPhone)
		     VALUES(N'Nguyễn Văn Ân', null, 1, '19990101', N'P1, Vũng Tàu', '0102452564', '0109854165')
-- 3.2
INSERT dbo.Student (Name, Avatar, Sex, DateOfBirth, Address, Phone, ParentPhone)
		     VALUES(N'Bùi Thị Bích', null, 0, '19980611', N'P12, Vũng Tàu', '0209854154', '0208547962')
-- 3.3
INSERT dbo.Student (Name, Avatar, Sex, DateOfBirth, Address, Phone, ParentPhone)
		     VALUES(N'Nguyễn Ngọc Cường', null, 1, '19990319', N'Bà Rịa', '0306523741', '0409856324')
-- 3.4
INSERT dbo.Student (Name, Avatar, Sex, DateOfBirth, Address, Phone, ParentPhone)
		     VALUES(N'Nguyễn Hải Duyên', null, 0, '19991101', N'Long Hải', '0401478963', '0403698741')
-- 3.5
INSERT dbo.Student (Name, Avatar, Sex, DateOfBirth, Address, Phone, ParentPhone)
		     VALUES(N'Đỗ Mỹ Uyên', null, 0, '19990515', N'Láng Cát', '0505213468', '05095178642')
-- 3.6
INSERT dbo.Student (Name, Avatar, Sex, DateOfBirth, Address, Phone, ParentPhone)
		     VALUES(N'Bách Mã Kỳ', null, 1, '19990909', N'Hải Sơn', '0605962487', '0607541268')
-- 3.7
INSERT dbo.Student (Name, Avatar, Sex, DateOfBirth, Address, Phone, ParentPhone)
		     VALUES(N'Xuân Mỹ Hải', null, 1, '19990811', N'Hội Bài', '0707419623', '0703625195')
-- 3.8
INSERT dbo.Student (Name, Avatar, Sex, DateOfBirth, Address, Phone, ParentPhone)
		     VALUES(N'Haruki Murakami', null, 1, '19991212', N'Nhật Bản', '0805284697', '0808457269')
-- 3.9
INSERT dbo.Student (Name, Avatar, Sex, DateOfBirth, Address, Phone, ParentPhone)
		     VALUES(N'Vladimir Puctin', null, 1, '19990713', N'Russia', '0908541237', '0909584712')
-- 3.10
INSERT dbo.Student (Name, Avatar, Sex, DateOfBirth, Address, Phone, ParentPhone)
		     VALUES(N'Dorand Thump', null, 1, '19990101', N'USA', '1002601428', '1002361594')
GO
-- 4.bảng công nợ
-- 4.1
INSERT dbo.Debt (SumOfDebt, IDStudent)
		  VALUES(0, 1)
-- 4.2
INSERT dbo.Debt (SumOfDebt, IDStudent)
		  VALUES(0, 2)
-- 4.3
INSERT dbo.Debt (SumOfDebt, IDStudent)
		  VALUES(0, 3)
-- 4.4
INSERT dbo.Debt (SumOfDebt, IDStudent)
		  VALUES(0, 4)
-- 4.5
INSERT dbo.Debt (SumOfDebt, IDStudent)
		  VALUES(0, 5)
-- 4.6
INSERT dbo.Debt (SumOfDebt, IDStudent)
		  VALUES(0, 6)
-- 4.7
INSERT dbo.Debt (SumOfDebt, IDStudent)
		  VALUES(0, 7)
-- 4.8
INSERT dbo.Debt (SumOfDebt, IDStudent)
		  VALUES(0, 8)
-- 4.9
INSERT dbo.Debt (SumOfDebt, IDStudent)
		  VALUES(0, 9)
-- 4.10
INSERT dbo.Debt (SumOfDebt, IDStudent)
		  VALUES(0, 10)
GO
-- 5.bảng chi tiết nợ



-- 6.bảng môn học



-- 7.bảng lớp



-- 8.bảng chi tiết lớp



-- 9.bảng kết qua học tập














--
-- Tạo PROC
--


-- Login
CREATE PROC USP_Login
@userName VARCHAR(50), @passWord VARCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

-- Hiển thị toàn bộ danh sách sinh viên
CREATE PROC USP_LoadStudentList
AS SELECT * FROM dbo.Student
GO
-- Hiển thị toàn bộ danh sách nhân 
CREATE PROC USP_LoadStaffList
AS SELECT * FROM dbo.Staff
GO
