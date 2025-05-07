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

	
/*---------------------------------------------------------------------------------------*/	
	CREATE TABLE SignInSignUp (
    Id INT IDENTITY(1,1) PRIMARY KEY,  -- Auto-incremented Primary Key
    Name NVARCHAR(100) NOT NULL CHECK (LEN(Name) >= 3), -- Name must have at least 3 characters
    EmailId NVARCHAR(255) NOT NULL UNIQUE CHECK (EmailId LIKE '%_@_%._%'), -- Email validation
    Password NVARCHAR(255) NOT NULL CHECK (LEN(Password) >= 6) -- Password must be at least 6 characters
);	

/*----------------------------------------------------------------------------*/
/*Table For RoomType*/

CREATE TABLE RoomType (
    RoomId INT IDENTITY(1,1) PRIMARY KEY,
    RoomType NVARCHAR(100) NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity >= 0),
    Capacity INT NOT NULL CHECK (Capacity > 0),
    Price DECIMAL(10, 2) NOT NULL CHECK (Price >= 0),
    CreatedBy NVARCHAR(50) NOT NULL,
    CreatedOn DATETIME DEFAULT GETDATE(),
    ModifyBy NVARCHAR(50) NULL,
    ModifyOn DATETIME NULL,
    Status NVARCHAR(20) DEFAULT 'Active' CHECK (Status IN ('Active', 'Inactive'))
);



/*-----------------------------------------------------------------------*/
/* Table For RoomMaster*/
CREATE TABLE RoomMaster (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    RoomType NVARCHAR(100) NOT NULL,
    RoomNo NVARCHAR(50) NOT NULL,
    CreatedOn DATETIME DEFAULT GETDATE(),
    CreatedBy NVARCHAR(100) NOT NULL,
    ModifyOn DATETIME NULL,
    ModifyBy NVARCHAR(100) NULL,
    Status NVARCHAR(50) NOT NULL
);

/*----------------------------------------------------------------------*/
/*Table For Booking Master*/

CREATE TABLE BookingMaster (
    GuestId INT IDENTITY(1,1) PRIMARY KEY,
    GuestFirstName VARCHAR(50),
    GuestLastName VARCHAR(50),
    GuestMobileNo VARCHAR(15),
    Gender VARCHAR(10),
    Email VARCHAR(100),
    GovDocument VARCHAR(255),
    GuestCount INT,
    TotalAllocatedRoom INT,
    RoomType VARCHAR(50),
    RoomNumber VARCHAR(10),
    GovDocumentData VARBINARY(MAX),
    Status VARCHAR(20),
    BookingDate DATETIME,
    CheckoutDate DATETIME
);








