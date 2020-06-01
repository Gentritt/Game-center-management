USE [master]
GO
/****** Object:  Database [Gaming-Center MG]    Script Date: 5/8/2020 8:53:06 PM ******/
CREATE DATABASE [Gaming-Center MG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gaming-Center MG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Gaming-Center MG.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Gaming-Center MG_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Gaming-Center MG_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Gaming-Center MG] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gaming-Center MG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gaming-Center MG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gaming-Center MG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gaming-Center MG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gaming-Center MG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gaming-Center MG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gaming-Center MG] SET  MULTI_USER 
GO
ALTER DATABASE [Gaming-Center MG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gaming-Center MG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gaming-Center MG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gaming-Center MG] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Gaming-Center MG] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Gaming-Center MG]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[ComputerID] [int] NULL,
	[ClientID] [int] NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NOT NULL,
	[Totali] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clients]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[IsGuest] [bit] NULL,
	[Name] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[PersonalID] [varchar](11) NOT NULL,
	[Adress] [varchar](50) NULL,
	[Birthday] [date] NOT NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Balance] [money] NULL,
	[IsActive] [bit] NOT NULL DEFAULT ((0)),
	[InsertBy] [varchar](50) NULL,
	[InsertDate] [datetime] NULL DEFAULT (getdate()),
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ComputerParts]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ComputerParts](
	[PartID] [int] IDENTITY(1,1) NOT NULL,
	[Case] [nvarchar](255) NOT NULL,
	[Mouse] [nvarchar](255) NOT NULL,
	[Keyboard] [nvarchar](255) NOT NULL,
	[HeadSets] [nvarchar](255) NOT NULL,
	[Monitor] [nvarchar](255) NOT NULL,
	[MousePad] [nvarchar](50) NOT NULL,
	[Processor] [nvarchar](50) NOT NULL,
	[GraphicCard] [nvarchar](50) NOT NULL,
	[MotherBoard] [nvarchar](50) NOT NULL,
	[RAM] [nvarchar](50) NOT NULL,
	[SSD] [nvarchar](50) NOT NULL,
	[HDD] [nvarchar](50) NOT NULL,
	[PCU] [nvarchar](50) NOT NULL,
	[Cooler] [nvarchar](50) NOT NULL,
	[InsertBy] [varchar](50) NULL,
	[InsertDate] [datetime] NULL,
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Computers]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Computers](
	[ComputerID] [int] IDENTITY(1,1) NOT NULL,
	[PartID] [int] NULL,
	[PricePerHour] [money] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[InsertBy] [varchar](50) NULL,
	[InsertDate] [datetime] NULL,
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ComputerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employess]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employess](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[PersonalID] [varchar](11) NOT NULL,
	[Adress] [varchar](50) NULL,
	[Birthday] [date] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Salary] [money] NULL,
	[IsActive] [bit] NOT NULL DEFAULT ((0)),
	[InsertBy] [varchar](50) NULL,
	[InsertDate] [datetime] NULL DEFAULT (getdate()),
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NOT NULL,
	[Price] [money] NULL,
	[BillID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[ProductPrice] [money] NULL,
	[ProductQuantity] [int] NULL,
	[InsertBy] [varchar](50) NULL,
	[InsertDate] [datetime] NULL,
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ClientID], [IsGuest], [Name], [LastName], [PersonalID], [Adress], [Birthday], [PhoneNumber], [Email], [UserName], [Password], [Balance], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (1, NULL, N'gentrit', N'selimi', N'2222', N'pristhine', CAST(N'1999-04-01' AS Date), N'+388441111', N'g.@riinvest.net', N'Gentrit', N'1212121', 100.0000, 0, N'admin', CAST(N'2020-05-08 00:00:00.000' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Employess] ON 

INSERT [dbo].[Employess] ([EmployeeID], [Name], [LastName], [PersonalID], [Adress], [Birthday], [Email], [PhoneNumber], [UserName], [Password], [Salary], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (1, N'admin', N'admin', N'11111111', N'prishtine', CAST(N'1999-10-14' AS Date), N'g@riinvest.net', N'444111222', N'admin', N'admin', 100.0000, 1, NULL, CAST(N'2020-05-07 23:53:40.233' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Employess] ([EmployeeID], [Name], [LastName], [PersonalID], [Adress], [Birthday], [Email], [PhoneNumber], [UserName], [Password], [Salary], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (2, N'ssss', N'sss', N'222', N'pristhine', CAST(N'2020-04-05' AS Date), N'g@riinvest.net', N'2222', N'ggg', N'ssss', 100.0000, 0, N'admin', CAST(N'2020-05-08 00:00:00.000' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Employess] ([EmployeeID], [Name], [LastName], [PersonalID], [Adress], [Birthday], [Email], [PhoneNumber], [UserName], [Password], [Salary], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (3, N'sss', N'ssss', N'2', N'', CAST(N'2020-04-05' AS Date), N'g@riiv', N'2', N'ss', N'ss', 0.0000, 0, N'admin', CAST(N'2020-05-08 00:00:00.000' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Employess] ([EmployeeID], [Name], [LastName], [PersonalID], [Adress], [Birthday], [Email], [PhoneNumber], [UserName], [Password], [Salary], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (6, N'Eugen', N'Sekirqa', N'112221', N'pristhine', CAST(N'2020-04-05' AS Date), N'e.2@riinvest.net', N'22222', N'Eugen', N'222222', 100.0000, 0, N'admin', CAST(N'2020-05-08 00:00:00.000' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Employess] ([EmployeeID], [Name], [LastName], [PersonalID], [Adress], [Birthday], [Email], [PhoneNumber], [UserName], [Password], [Salary], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (7, N'Genti', N'selimi', N'222', N'Prishtine', CAST(N'2020-04-05' AS Date), N'ge@riinvest.net', N'222', N'Gentrit', N'Selimi', 100.0000, 0, N'admin', CAST(N'2020-05-08 00:00:00.000' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Employess] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Clients__C9F284569C6241AC]    Script Date: 5/8/2020 8:53:06 PM ******/
ALTER TABLE [dbo].[Clients] ADD UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Employes__C9F28456DACC5903]    Script Date: 5/8/2020 8:53:06 PM ******/
ALTER TABLE [dbo].[Employess] ADD UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ComputerParts] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[ComputerParts] ADD  DEFAULT ((0)) FOR [UpdateNo]
GO
ALTER TABLE [dbo].[Computers] ADD  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Computers] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Computers] ADD  DEFAULT ((0)) FOR [UpdateNo]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((0)) FOR [UpdateNo]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([ComputerID])
REFERENCES [dbo].[Computers] ([ComputerID])
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employess] ([EmployeeID])
GO
ALTER TABLE [dbo].[Computers]  WITH CHECK ADD FOREIGN KEY([PartID])
REFERENCES [dbo].[ComputerParts] ([PartID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [BillID] FOREIGN KEY([BillID])
REFERENCES [dbo].[Bill] ([BillID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [BillID]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Orders]
GO
/****** Object:  StoredProcedure [dbo].[ADD_ComputerParts]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ADD_ComputerParts]
@case nvarchar(255),
@mouse nvarchar(255),
@keyboard nvarchar(255),
@headsets nvarchar(255),
@monitor nvarchar(255),
@mousepad nvarchar(50),
@processor nvarchar(50),
@graphiccard nvarchar(50),
@motherboard nvarchar(50),
@ram nvarchar(50),
@ssd nvarchar(50),
@hdd nvarchar(50),
@psu nvarchar(50),
@cooler nvarchar(50),
@insertby varchar(50),
@insertdate datetime
AS
INSERT INTO ComputerParts
(
    --PartID - column value is auto-generated
    [Case],
    Mouse,
    Keyboard,
    HeadSets,
    Monitor,
    MousePad,
    Processor,
    GraphicCard,
    MotherBoard,
    RAM,
    SSD,
    HDD,
    PCU,
    Cooler,
    InsertBy,
    InsertDate
  
)
VALUES
(
@case,@mouse,@keyboard,@headsets,@monitor,@mousepad,@processor,@graphiccard,@motherboard,@ram,@ssd,@hdd,@psu,@cooler,@insertby,@insertdate
)
GO
/****** Object:  StoredProcedure [dbo].[Add_Employess]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Add_Employess]

@name varchar(50),
@lastname varchar(50),
@personalid varchar(11),
@address varchar(50),
@birthday date,
@email varchar(50),
@phonenumber varchar(50),
@username varchar(50),
@password varchar(50),
@salary money,
@insertby varchar(50),
@insertdate date
AS 
INSERT INTO dbo.Employess
(
    --EmployeeID - column value is auto-generated
    Name,
    LastName,
    PersonalID,
    Adress,
    Birthday,
    Email,
    PhoneNumber,
    UserName,
    Password,
    Salary,
    InsertBy,
	InsertDate
)
VALUES
(
    @name,@lastname,@personalid,@address,@birthday,@email,@phonenumber,@username,@password,@salary,@insertby,@insertdate
)
GO
/****** Object:  StoredProcedure [dbo].[Add_Products]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Add_Products]

@productname varchar(50),
@productprice money,
@quantity int

As
INSERT INTO dbo.Products
(
    --ProductID - column value is auto-generated
    ProductName,
    ProductPrice,
    ProductQuantity
	)
VALUES
(
   @productname,@productprice,@quantity
)


GO
/****** Object:  StoredProcedure [dbo].[Clients_GetALL]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDUre [dbo].[Clients_GetALL]
AS
SELECT * FROM dbo.Clients c
GO
/****** Object:  StoredProcedure [dbo].[Clients_Insert]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Clients_Insert]
@name varchar(50),
@lastname varchar(50),
@personalid varchar(11),
@address varchar(50),
@birthday date,
@phonenumber varchar(20),
@email varchar(50),
@username varchar(50),
@password varchar(50),
@balance money,
@insertby varchar(50),
@insertdate datetime


AS
INSERT INTO dbo.Clients
(
    --ClientID - column value is auto-generated
    
    Name,
    LastName,
    PersonalID,
    Adress,
    Birthday,
    PhoneNumber,
    Email,
    UserName,
    Password,
    Balance,
	InsertBy,
	InsertDate
  
)
VALUES
(
@name,@lastname,@personalid,@address,@birthday,@phonenumber,@email,@username,@password,@balance,@insertby,@insertdate
)
GO
/****** Object:  StoredProcedure [dbo].[Delete_ClientsByID]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Delete_ClientsByID]
@clientid int
as
BEGIN
DELETE FROM dbo.Clients WHERE dbo.Clients.ClientID= @clientid
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_ComputerPartsByID]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Delete_ComputerPartsByID]
@partid int
AS
BEGIN
DELETE FROM dbo.ComputerParts WHERE dbo.ComputerParts.PartID = @partid
END

GO
/****** Object:  StoredProcedure [dbo].[Delete_EmployeeByID]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Delete_EmployeeByID]
@employeeid int 
AS
BEGIN
DELETE FROM dbo.Employess WHERE dbo.Employess.EmployeeID = @employeeid
END

GO
/****** Object:  StoredProcedure [dbo].[Delete_ProductsByID]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Delete_ProductsByID]
@productid int
AS
BEGIN
DELETE FROM dbo.Products WHERE dbo.Products.ProductID = @productid
END
GO
/****** Object:  StoredProcedure [dbo].[Edit_Products]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Edit_Products]
@productname varchar(50),
@productprice money,
@productquantity int,
@updateby varchar(50),
@updatedate datetime,
@updateno int
AS
BEGIN 

UPDATE dbo.Products
SET
  dbo.Products.ProductName = @productname, dbo.Products.ProductPrice = @productprice, dbo.Products.ProductQuantity = @productquantity
  ,UpdateBy = @updateby, dbo.Products.UpdateDate = @updatedate, dbo.Products.UpdateNo=@updateno
  WHERE dbo.Products.ProductName = @productname;

End
GO
/****** Object:  StoredProcedure [dbo].[Employess_GetALL]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Employess_GetALL]
AS
SELECT * FROM dbo.Employess e
GO
/****** Object:  StoredProcedure [dbo].[GetALL_ComputerParts]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetALL_ComputerParts]
AS
SELECT * FROM dbo.ComputerParts cp
GO
/****** Object:  StoredProcedure [dbo].[GetALL_Computers]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetALL_Computers]
AS
SELECT * FROM dbo.Computers c
GO
/****** Object:  StoredProcedure [dbo].[LoginEmployee]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[LoginEmployee]
@username varchar(50),
@password varchar(50)
as
SELECT * FROM dbo.Employess e
WHERE e.UserName = @username
AND e.Password = @password
GO
/****** Object:  StoredProcedure [dbo].[Products_ADD]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Products_ADD]

@productname varchar(50),
@productprice money,
@quantity int,
@insertby varchar(50),
@insertdate datetime

As
INSERT INTO dbo.Products
(
    --ProductID - column value is auto-generated
    ProductName,
    ProductPrice,
    ProductQuantity,
	InsertBy,
	InsertDate
	)
VALUES
(
   @productname,@productprice,@quantity,@insertby,@insertdate
)
GO
/****** Object:  StoredProcedure [dbo].[Products_getALL]    Script Date: 5/8/2020 8:53:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Products_getALL]
AS
SELECT * FROM dbo.Products p
GO
USE [master]
GO
ALTER DATABASE [Gaming-Center MG] SET  READ_WRITE 
GO
