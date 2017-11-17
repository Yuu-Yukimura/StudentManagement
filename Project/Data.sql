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
-- 3.bảng sinh viên
-- 4.bảng công nợ
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
	Avatar VARCHAR(100) NOT NULL,
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
	IDStaff INT NOT NULL

	-- FOREIGN
	FOREIGN KEY (IDStaff) REFERENCES dbo.Staff(ID)
)
GO

-- 3.bảng công nợ
CREATE TABLE Debt 
(
	-- INFO
	ID INT PRIMARY KEY IDENTITY,
	SumOfDebt MONEY NOT NULL DEFAULT 0
)
GO

-- 4.bảng sinh viên
CREATE TABLE Student
(
	-- INFO
	ID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL DEFAULT 'Chưa đặt tên',
	Avatar VARCHAR(100) NOT NULL,
	Sex BIT NOT NULL DEFAULT 1, -- 0 là nữ, 1 là nam
	DateOfBirth DATE NOT NULL DEFAULT '20000101',
	Address NVARCHAR(50) NOT NULL,
	Phone VARCHAR(20),
	ParentPhone VARCHAR(20),
	IDDebt INT NOT NULL

	-- FOREIGN
	FOREIGN KEY (IDDebt) REFERENCES dbo.Debt(ID)
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



--
--
--



