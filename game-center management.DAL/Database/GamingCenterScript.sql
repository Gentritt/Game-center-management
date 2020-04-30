USE [master]
GO
/****** Object:  Database [Gaming-Center Management]    Script Date: 4/30/2020 9:36:11 PM ******/
CREATE DATABASE [Gaming-Center Management]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gaming-Center Management', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Gaming-Center Management.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Gaming-Center Management_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Gaming-Center Management_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Gaming-Center Management] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gaming-Center Management].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gaming-Center Management] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gaming-Center Management] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gaming-Center Management] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gaming-Center Management] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gaming-Center Management] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gaming-Center Management] SET  MULTI_USER 
GO
ALTER DATABASE [Gaming-Center Management] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gaming-Center Management] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gaming-Center Management] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gaming-Center Management] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Gaming-Center Management] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Gaming-Center Management]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 4/30/2020 9:36:11 PM ******/
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
/****** Object:  Table [dbo].[Clients]    Script Date: 4/30/2020 9:36:11 PM ******/
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
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL DEFAULT (getdate()),
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
/****** Object:  Table [dbo].[ComputerParts]    Script Date: 4/30/2020 9:36:11 PM ******/
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
	[PSU] [nvarchar](50) NOT NULL,
	[Cooler] [nvarchar](50) NOT NULL,
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Computers]    Script Date: 4/30/2020 9:36:11 PM ******/
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
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ComputerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employess]    Script Date: 4/30/2020 9:36:11 PM ******/
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
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL DEFAULT (getdate()),
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 4/30/2020 9:36:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[BillID] [int] NULL,
	[Quantity] [int] NOT NULL,
	[Price] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 4/30/2020 9:36:11 PM ******/
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
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ClientID], [IsGuest], [Name], [LastName], [PersonalID], [Adress], [Birthday], [PhoneNumber], [Email], [UserName], [Password], [Balance], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (1, 0, N'Gentrit', N'Selimi', N'1122292', N'Podujeve', CAST(N'1999-10-14' AS Date), N'044222999', N'gentrit.seliimi@riinvest.net', N'gentrit', N'gentrit', 100000.0000, 1, N'1', CAST(N'2020-04-30 00:00:00.000' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Employess] ON 

INSERT [dbo].[Employess] ([EmployeeID], [Name], [LastName], [PersonalID], [Adress], [Birthday], [Email], [PhoneNumber], [UserName], [Password], [Salary], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (1, N'admin', N'admin', N'1111222922', N'prishtin', CAST(N'2020-04-30' AS Date), N'admin@riinvest.net ', N'044 322 222', N'admin', N'admin', 10000.0000, 1, N'1', CAST(N'2020-04-30 00:00:00.000' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Employess] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Clients__C9F28456B4DEE99D]    Script Date: 4/30/2020 9:36:11 PM ******/
ALTER TABLE [dbo].[Clients] ADD UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [NonClusteredIndex-20200430-210523]    Script Date: 4/30/2020 9:36:11 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [NonClusteredIndex-20200430-210523] ON [dbo].[Clients]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Employes__C9F284562E7A0272]    Script Date: 4/30/2020 9:36:11 PM ******/
ALTER TABLE [dbo].[Employess] ADD UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [NonClusteredIndex-20200430-210611]    Script Date: 4/30/2020 9:36:11 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [NonClusteredIndex-20200430-210611] ON [dbo].[Employess]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([BillID])
REFERENCES [dbo].[Bill] ([BillID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
/****** Object:  StoredProcedure [dbo].[Add_Clients]    Script Date: 4/30/2020 9:36:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Add_Clients]
@isguest bit,
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
@isactive bit

AS
INSERT INTO dbo.Clients
(
    --ClientID - column value is auto-generated
    IsGuest,
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
    IsActive
)
VALUES
(
@isguest,@name,@lastname,@personalid,@address,@birthday,@phonenumber,@email,@username,@password,@balance,@isactive
)


GO
/****** Object:  StoredProcedure [dbo].[Add_Employess]    Script Date: 4/30/2020 9:36:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Add_Employess]
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
@isactive bit
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
    IsActive
)
VALUES
(
    @name,@lastname,@personalid,@address,@birthday,@email,@phonenumber,@username,@password,@salary,@isactive
)
GO
/****** Object:  StoredProcedure [dbo].[Add_Products]    Script Date: 4/30/2020 9:36:11 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Clients_GetALL]    Script Date: 4/30/2020 9:36:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Clients_GetALL]
AS
SELECT * FROM dbo.Clients c
GO
/****** Object:  StoredProcedure [dbo].[Employess_GetALL]    Script Date: 4/30/2020 9:36:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Employess_GetALL]
AS
SELECT * FROM dbo.Employess e
GO
/****** Object:  StoredProcedure [dbo].[LoginEmployee]    Script Date: 4/30/2020 9:36:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoginEmployee]
@username varchar(50),
@password varchar(50)
as
SELECT * FROM dbo.Employess e
WHERE e.UserName = @username
AND e.Password = @password
GO
USE [master]
GO
ALTER DATABASE [Gaming-Center Management] SET  READ_WRITE 
GO
