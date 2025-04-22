 /*In These File We Have Database For 
 HotelManagement & tables we have 
 1)SignInSignUp
 2) RoomType
 3) RoomMaster
 4)BookingMaster 
 */

	CREATE DATABASE HotelManagemet;

	use HotelManagement;
	select * from SignInSignUp;
	select * from RoomType
	select * from RoomMaster
	select * from BookingMaster

	DROP TABLE BookingMaster;


	ALTER TABLE BookingMaster
ADD COLUMN CheckoutDate;

SELECT name 
FROM sys.check_constraints 
WHERE parent_object_id = OBJECT_ID('BookingMaster');

ALTER TABLE BookingMaster
DROP CONSTRAINT CK__BookingMa__Total__55009F39;

ALTER TABLE BookingMaster
DROP COLUMN CheckoutDate;

ALTER TABLE BookingMaster
ADD CheckoutDate VARBINARY(MAX);

ALTER TABLE BookingMaster
ADD Status VARCHAR(20) NOT NULL DEFAULT 'Active';

ALTER TABLE BookingMaster
ADD CheckoutDate DATETIME NOT NULL DEFAULT GETDATE();

ALTER TABLE BookingMaster
ALTER COLUMN CheckoutDate DATETIME NULL;

	
/*----------------------------------------------------------------------------*/
/*Table For RoomType*/

CREATE TABLE RoomType (
    RoomId INT IDENTITY(1,1) PRIMARY KEY,   -- Auto-incremented primary key
    RoomType NVARCHAR(100) NOT NULL,        -- Room type (text)
    Quantity INT NOT NULL CHECK (Quantity >= 0),  -- Number of rooms (must be non-negative)
    Capacity INT NOT NULL CHECK (Capacity > 0),   -- Room capacity (must be greater than 0)
    Price DECIMAL(10,2) NOT NULL CHECK (Price >= 0), -- Price with 2 decimal places
    CreatedBy NVARCHAR(50) NOT NULL,       -- User who created the entry
    CreatedOn DATETIME DEFAULT GETDATE(),  -- Auto-set to current date and time
    ModifyBy NVARCHAR(50) NULL,            -- User who modified the entry
    ModifyOn DATETIME NULL,                -- Nullable, only updated when modified
    Status NVARCHAR(20) DEFAULT 'Active' CHECK (Status IN ('Active', 'Inactive')) -- Status constraint
);

INSERT INTO RoomType (RoomType, Quantity, Capacity, Price, CreatedBy, Status)
VALUES 
('Deluxe AC', 10, 2, 3500.00, 'Manager1', 'Active'),
('Super Deluxe AC', 5, 3, 4500.00, 'Manager2', 'Active'),
('Standard Non-AC', 15, 2, 2000.00, 'Manager3', 'Active'),
('Suite Room', 3, 4, 7500.00, 'Manager1', 'Active'),
('Family Room', 6, 5, 5000.00, 'Manager4', 'Active');

select * from RoomType;
/*-----------------------------------------------------------------------*/
/* Table For RoomMaster*/

CREATE TABLE RoomMaster (
    RoomId INT IDENTITY(1,1) PRIMARY KEY,   -- Auto-incremented primary key
    RoomType NVARCHAR(100) NOT NULL,        -- Room type (text)
    Quantity INT NOT NULL CHECK (Quantity >= 0),  -- Number of rooms (must be non-negative)
    Capacity INT NOT NULL CHECK (Capacity > 0),   -- Room capacity (must be greater than 0)
    Price INT NOT NULL CHECK (Price >= 0),  -- Price in INR (only integer values)
    CreatedOn DATETIME DEFAULT GETDATE(),   -- Auto-set to current date and time
    CreatedBy NVARCHAR(50) NOT NULL,        -- User who created the entry
    ModifyOn DATETIME NULL,                 -- Nullable, only updated when modified
    ModifyBy NVARCHAR(50) NULL,             -- User who modified the entry
    Status NVARCHAR(20) DEFAULT 'Active' CHECK (Status IN ('Active', 'Inactive')) -- Status constraint
);

INSERT INTO RoomMaster (RoomType, Quantity, Capacity, Price, CreatedBy, Status)
VALUES 
('Deluxe AC', 10, 2, 4500, 'Manager1', 'Active'),
('Super Deluxe AC', 5, 3, 6500, 'Manager2', 'Active'),
('Standard Non-AC', 15, 2, 2000, 'Manager3', 'Active'),
('Suite Room', 3, 4, 12000, 'Manager1', 'Active'),
('Family Room', 7, 4, 8000, 'Manager4', 'Active');

select * from RoomMaster;  

/*-----------------------------------------------------------------------------------------*/

/* To Check Server Name Hit The Query */

SELECT @@SERVERNAME;

/*-----------------------------------------------------------------------------------------*/
INSERT INTO RoomType (RoomType, Quantity, Capacity, Price, CreatedBy, CreatedOn, Status)
VALUES ('Deluxe', 5, 2, 1000.00, 'Admin', GETDATE(), 'Active');


select * from RoomType;

DELETE FROM RoomType;

DELETE FROM RoomMaster;
/*------------------------------------------------------------------------------------------------------*/

/*Table For SignInSignUp  */

CREATE TABLE SignInSignUp (
    Id INT IDENTITY(1,1) PRIMARY KEY,  -- Auto-incremented Primary Key
    Name NVARCHAR(100) NOT NULL CHECK (LEN(Name) >= 3), -- Name must have at least 3 characters
    EmailId NVARCHAR(255) NOT NULL UNIQUE CHECK (EmailId LIKE '%_@_%._%'), -- Email validation
    Password NVARCHAR(255) NOT NULL CHECK (LEN(Password) >= 6) -- Password must be at least 6 characters
);

INSERT INTO SignInSignUp (Name, EmailId, Password) 
VALUES 
('Amit Sharma', 'amit.sharma@gmail.com', 'Amit@123'),
('Deepika Joshi', 'deepika.joshi@gmail.com', 'Deepika@222'),
('Suresh Nair', 'suresh.nair@live.com', 'Suresh@333'),
('Anjali Desai', 'anjali.desai@hotmail.com', 'Anjali@444');



select * from RoomMaster;

TRUNCATE TABLE RoomMaster;
TRUNCATE TABLE RoomType;
/*----------------------------------------------------------------------*/
/*Table For Booking Master*/

CREATE TABLE BookingMaster (
    GuestId INT IDENTITY(1,1) PRIMARY KEY,
    GuestFirstName VARCHAR(50) NOT NULL,
    GuestLastName VARCHAR(50) NOT NULL,
    GuestMobileNo VARCHAR(15) NOT NULL UNIQUE,
    Gender VARCHAR(10) CHECK (Gender IN ('Male', 'Female', 'Other')),
    Email VARCHAR(100) UNIQUE,
    GovDocument VARCHAR(50) NOT NULL,
    GuestCount INT NOT NULL CHECK (GuestCount > 0),
    TotalAllocatedRoom INT NOT NULL CHECK (TotalAllocatedRoom > 0),
    RoomType VARCHAR(50) NOT NULL,
    RoomNumber VARCHAR(10) NOT NULL UNIQUE
);

INSERT INTO BookingMaster (GuestFirstName, GuestLastName, GuestMobileNo, 
							Gender, Email, GovDocument, GuestCount, 
							TotalAllocatedRoom, RoomType, RoomNumber)
VALUES
('Rajesh', 'Sharma', '9876543210', 'Male', 'rajesh.sharma@gmail.com', 'Aadhar: 1234-5678-9012', 2, 1, 'Deluxe', '101'),
('Priya', 'Mehta', '9823456789', 'Female', 'priya.mehta@yahoo.com', 'Aadhar: 2345-6789-0123', 3, 1, 'Suite', '202'),
('Amit', 'Patil', '9890123456', 'Male', 'amit.patil@rediffmail.com', 'PAN: BCDPA1234E', 1, 1, 'Executive', '305'),
('Sneha', 'Rao', '9765432109', 'Female', 'sneha.rao@hotmail.com', 'Passport: J1234567', 4, 2, 'Presidential', '401'),
('Vikram', 'Singh', '9812345678', 'Male', 'vikram.singh@gmail.com', 'Aadhar: 3456-7890-1234', 2, 1, 'Deluxe', '102');

shwo tables



ALTER TABLE BookingMaster
DROP CONSTRAINT CK__BookingMa__Guest__540C7B00;

SELECT name 
FROM sys.check_constraints 
WHERE parent_object_id = OBJECT_ID('BookingMaster');

ALTER TABLE BookingMaster
DROP CONSTRAINT CK__BookingMa__Guest__540C7B00;


SELECT name 
FROM sys.indexes 
WHERE object_id = OBJECT_ID('BookingMaster') 
AND is_unique = 1;

ALTER TABLE BookingMaster
DROP CONSTRAINT UQ__BookingM__AE10E07A98BC44DF;

ALTER TABLE BookingMaster
DROP CONSTRAINT UQ__BookingM__A9D105348271DAD7;

ALTER TABLE BookingMaster
DROP CONSTRAINT UQ__BookingM__A23A435DDCD714FD;


ALTER TABLE BookingMaster
ALTER COLUMN CheckoutDate DATETIME NULL;
