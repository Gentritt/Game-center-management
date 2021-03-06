USE [master]
GO
/****** Object:  Database [Gaming-Center MG]    Script Date: 08/09/2020 12:56:21 ******/
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
/****** Object:  Table [dbo].[Bills]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bills](
	[BillID] [int] IDENTITY(1,1) NOT NULL,
	[Employee] [varchar](20) NULL,
	[ComputerID] [int] NULL,
	[Client] [varchar](50) NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
	[Total] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 08/09/2020 12:56:21 ******/
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
/****** Object:  Table [dbo].[ComputerParts]    Script Date: 08/09/2020 12:56:21 ******/
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
	[InsertDate] [datetime] NULL DEFAULT (getdate()),
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[PartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Computers]    Script Date: 08/09/2020 12:56:21 ******/
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
	[IsActive] [bit] NOT NULL DEFAULT ((0)),
	[InsertBy] [varchar](50) NULL,
	[InsertDate] [datetime] NULL DEFAULT (getdate()),
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[ComputerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employess]    Script Date: 08/09/2020 12:56:21 ******/
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
/****** Object:  Table [dbo].[Orderss]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orderss](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[BillID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[Price] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 08/09/2020 12:56:21 ******/
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
	[InsertDate] [datetime] NULL DEFAULT (getdate()),
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Bills] ON 

INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3, N'admin', 5, N'syl', CAST(N'2020-06-08 20:00:00.000' AS DateTime), CAST(N'2020-06-08 20:04:00.000' AS DateTime), NULL)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (5, N'admin', 3, N'Guest', CAST(N'2020-06-08 20:05:00.000' AS DateTime), CAST(N'2020-06-08 20:05:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (6, N'admin', 6, N'Guest', CAST(N'2020-06-08 20:06:00.000' AS DateTime), CAST(N'2020-06-08 21:41:00.000' AS DateTime), 2.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (7, N'admin', 1, N'Guest', CAST(N'2020-06-08 20:09:00.000' AS DateTime), CAST(N'2020-06-08 20:09:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (8, N'admin', 5, N'Guest', CAST(N'2020-06-08 20:09:00.000' AS DateTime), CAST(N'2020-06-08 21:32:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (10, N'admin', 6, N'Guest', CAST(N'2020-06-09 06:16:00.000' AS DateTime), CAST(N'2020-06-09 06:18:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (11, N'admin', 6, N'syl', CAST(N'2020-06-09 06:19:00.000' AS DateTime), CAST(N'2020-06-09 06:20:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (13, N'admin', 4, N'Guest', CAST(N'2020-06-09 06:21:00.000' AS DateTime), CAST(N'2020-06-09 06:23:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (14, N'admin', 4, N'syl', CAST(N'2020-06-09 06:23:00.000' AS DateTime), CAST(N'2020-06-09 06:27:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (15, N'admin', 4, N'syl', CAST(N'2020-06-09 06:25:00.000' AS DateTime), CAST(N'2020-06-09 12:48:00.000' AS DateTime), 6.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (16, N'admin', 1, N'Guest', CAST(N'2020-06-09 06:30:00.000' AS DateTime), CAST(N'2020-06-09 09:30:00.000' AS DateTime), 3.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (18, N'admin', 1, N'Guest', CAST(N'2020-06-09 07:37:00.000' AS DateTime), CAST(N'2020-06-09 07:37:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (20, N'admin', 13, N'Guest', CAST(N'2020-06-09 12:29:00.000' AS DateTime), CAST(N'2020-06-09 12:29:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (22, N'admin', 1, N'syl', CAST(N'2020-06-09 22:36:00.000' AS DateTime), CAST(N'2020-06-20 18:23:00.000' AS DateTime), 260.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (24, N'Admin', 3, N'Guest', CAST(N'2020-06-09 23:36:00.000' AS DateTime), CAST(N'2020-06-09 23:36:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (26, N'Admin', 4, N'Guest', CAST(N'2020-06-14 17:13:00.000' AS DateTime), CAST(N'2020-06-20 16:27:00.000' AS DateTime), 143.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (27, N'Admin', 6, N'Guest', CAST(N'2020-06-14 17:13:00.000' AS DateTime), NULL, 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (28, N'Admin', 13, N'Guest', CAST(N'2020-06-14 17:18:00.000' AS DateTime), CAST(N'2020-06-14 17:19:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (29, N'Admin', 6, N'bleon', CAST(N'2020-06-14 17:50:00.000' AS DateTime), CAST(N'2020-06-14 17:51:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (30, N'Admin', 1, N'Guest', CAST(N'2020-06-20 20:32:00.000' AS DateTime), CAST(N'2020-06-20 20:33:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (31, N'Admin', 4, N'syl', CAST(N'2020-06-20 20:34:00.000' AS DateTime), CAST(N'2020-06-20 20:40:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (32, N'Admin', 5, N'Guest', CAST(N'2020-06-20 20:40:00.000' AS DateTime), CAST(N'2020-06-20 20:40:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (33, N'Admin', 5, N'bleon', CAST(N'2020-06-20 20:44:00.000' AS DateTime), CAST(N'2020-06-20 20:44:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (34, N'Admin', 6, N'bleon', CAST(N'2020-06-20 20:58:00.000' AS DateTime), CAST(N'2020-06-20 20:58:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1032, N'Admin', 3, N'Guest', CAST(N'2020-06-23 17:23:00.000' AS DateTime), CAST(N'2020-06-23 17:23:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1033, N'Admin', 1, N'Guest', CAST(N'2020-07-13 12:13:00.000' AS DateTime), CAST(N'2020-07-13 12:14:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1034, N'Admin', 1, N'Guest', CAST(N'2020-07-13 12:23:00.000' AS DateTime), CAST(N'2020-07-14 21:52:00.000' AS DateTime), 33.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1035, N'Admin', 1, N'syl', CAST(N'2020-07-14 21:54:00.000' AS DateTime), CAST(N'2020-07-14 21:55:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1036, N'Admin', 4, N'Guest', CAST(N'2020-07-14 22:13:00.000' AS DateTime), CAST(N'2020-07-14 22:14:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1037, N'Admin', 6, N'bleon', CAST(N'2020-07-14 22:14:00.000' AS DateTime), CAST(N'2020-07-14 22:18:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1038, N'Admin', 13, N'Guest', CAST(N'2020-07-14 22:20:00.000' AS DateTime), CAST(N'2020-07-14 22:20:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1039, N'Admin', 4, N'Guest', CAST(N'2020-07-16 10:52:00.000' AS DateTime), CAST(N'2020-07-16 11:36:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1040, N'Admin', 5, N'Guest', CAST(N'2020-07-16 14:37:00.000' AS DateTime), CAST(N'2020-07-16 14:37:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1041, N'Admin', 6, N'bleon', CAST(N'2020-07-16 14:38:00.000' AS DateTime), CAST(N'2020-07-16 14:39:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1042, N'Admin', 3, N'Guest', CAST(N'2020-07-16 14:40:00.000' AS DateTime), CAST(N'2020-07-16 14:41:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1043, N'Admin', 13, N'Guest', CAST(N'2020-07-16 14:40:00.000' AS DateTime), CAST(N'2020-07-16 14:41:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1044, N'Admin', 1, N'Guest', CAST(N'2020-07-16 14:42:00.000' AS DateTime), CAST(N'2020-07-16 14:44:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1045, N'Admin', 3, N'Guest', CAST(N'2020-07-16 14:43:00.000' AS DateTime), CAST(N'2020-07-16 14:44:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1046, N'Admin', 4, N'Guest', CAST(N'2020-07-16 14:43:00.000' AS DateTime), CAST(N'2020-07-16 14:44:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1047, N'Admin', 5, N'Guest', CAST(N'2020-07-16 14:43:00.000' AS DateTime), CAST(N'2020-07-16 14:44:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1048, N'Admin', 1, N'Guest', CAST(N'2020-07-16 14:44:00.000' AS DateTime), CAST(N'2020-07-16 14:44:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1049, N'Admin', 1, N'Guest', CAST(N'2020-07-16 14:47:00.000' AS DateTime), CAST(N'2020-07-16 14:48:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1050, N'Admin', 1, N'Guest', CAST(N'2020-07-23 13:43:00.000' AS DateTime), CAST(N'2020-07-23 13:46:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1051, N'Admin', 3, N'Guest', CAST(N'2020-07-23 13:43:00.000' AS DateTime), CAST(N'2020-07-23 13:46:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1052, N'Admin', 4, N'Guest', CAST(N'2020-07-23 13:43:00.000' AS DateTime), CAST(N'2020-07-23 13:47:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1053, N'Admin', 1, N'bleon', CAST(N'2020-07-23 14:09:00.000' AS DateTime), CAST(N'2020-07-24 12:09:00.000' AS DateTime), 22.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1054, N'Admin', 1, N'Guest', CAST(N'2020-07-24 12:10:00.000' AS DateTime), CAST(N'2020-07-24 12:15:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1055, N'Admin', 1, N'Guest', CAST(N'2020-07-24 12:20:00.000' AS DateTime), CAST(N'2020-07-24 12:20:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1056, N'Admin', 4, N'Guest', CAST(N'2020-07-24 12:23:00.000' AS DateTime), CAST(N'2020-07-24 12:30:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (1057, N'Admin', 5, N'Guest', CAST(N'2020-07-24 12:37:00.000' AS DateTime), CAST(N'2020-07-24 12:37:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (2056, N'Admin', 1, N'Guest', CAST(N'2020-07-26 15:35:00.000' AS DateTime), CAST(N'2020-07-26 15:39:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (2057, N'Admin', 4, N'bleon', CAST(N'2020-07-26 15:39:00.000' AS DateTime), CAST(N'2020-07-26 15:52:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (2058, N'Admin', 6, N'Guest', CAST(N'2020-07-26 15:53:00.000' AS DateTime), CAST(N'2020-08-03 09:32:00.000' AS DateTime), 190.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (2059, N'Admin', 5, N'Guest', CAST(N'2020-07-28 09:19:00.000' AS DateTime), CAST(N'2020-07-28 09:19:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (2060, N'Admin', 5, N'Guest', CAST(N'2020-07-28 11:22:00.000' AS DateTime), CAST(N'2020-08-01 19:36:00.000' AS DateTime), 104.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3059, N'Admin', 1, N'Guest', CAST(N'2020-08-03 09:24:00.000' AS DateTime), CAST(N'2020-08-03 09:25:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3060, N'Admin', 1, N'Guest', CAST(N'2020-08-03 09:28:00.000' AS DateTime), CAST(N'2020-08-03 09:28:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3061, N'Admin', 1, N'Guest', CAST(N'2020-08-03 09:29:00.000' AS DateTime), CAST(N'2020-08-03 09:29:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3062, N'Admin', 3, N'Guest', CAST(N'2020-08-03 09:29:00.000' AS DateTime), CAST(N'2020-08-03 09:29:00.000' AS DateTime), 5.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3063, N'Admin', 1, N'syl', CAST(N'2020-08-03 09:29:00.000' AS DateTime), CAST(N'2020-08-03 09:30:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3064, N'Admin', 1, N'Guest', CAST(N'2020-08-03 11:32:00.000' AS DateTime), CAST(N'2020-08-03 11:32:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3065, N'Admin', 4, N'Guest', CAST(N'2020-08-03 11:33:00.000' AS DateTime), CAST(N'2020-08-03 11:33:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3066, N'Admin', 5, N'bleon', CAST(N'2020-08-03 11:33:00.000' AS DateTime), CAST(N'2020-08-03 11:34:00.000' AS DateTime), 2.5000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3067, N'Admin', 1, N'Guest', CAST(N'2020-08-03 20:56:00.000' AS DateTime), CAST(N'2020-08-03 20:57:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3068, N'Admin', 4, N'Guest', CAST(N'2020-08-04 11:20:00.000' AS DateTime), CAST(N'2020-08-04 11:22:00.000' AS DateTime), 2.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3069, N'Admin', 1, N'Guest', CAST(N'2020-08-04 11:22:00.000' AS DateTime), CAST(N'2020-08-04 11:23:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3070, N'Admin', 1, N'Guest', CAST(N'2020-08-04 11:23:00.000' AS DateTime), CAST(N'2020-08-04 11:24:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3071, N'Admin', 1, N'Guest', CAST(N'2020-08-08 12:48:00.000' AS DateTime), CAST(N'2020-08-08 12:49:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3072, N'Admin', 1, N'Guest', CAST(N'2020-08-12 10:34:00.000' AS DateTime), CAST(N'2020-08-12 10:35:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (3073, N'Admin', 13, N'Guest', CAST(N'2020-08-12 11:05:00.000' AS DateTime), CAST(N'2020-08-12 11:06:00.000' AS DateTime), 2.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (4072, N'Admin', 1017, N'Guest', CAST(N'2020-08-20 09:57:00.000' AS DateTime), CAST(N'2020-08-20 09:58:00.000' AS DateTime), 2.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (4073, N'Admin', 1017, N'bleon', CAST(N'2020-08-20 09:59:00.000' AS DateTime), CAST(N'2020-08-20 13:29:00.000' AS DateTime), 6.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (4074, N'Admin', 6, N'syl', CAST(N'2020-08-25 09:44:00.000' AS DateTime), CAST(N'2020-08-25 09:45:00.000' AS DateTime), 2.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (5074, N'Admin', 6, N'Guest', CAST(N'2020-08-31 10:02:00.000' AS DateTime), CAST(N'2020-08-31 10:03:00.000' AS DateTime), 5.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (5075, N'Admin', 4, N'Guest', CAST(N'2020-08-31 10:43:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (5076, N'Admin', 4, N'Guest', CAST(N'2020-08-31 10:51:00.000' AS DateTime), CAST(N'2020-08-31 10:58:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (5077, N'Admin', 13, N'Guest', CAST(N'2020-08-31 10:52:00.000' AS DateTime), CAST(N'2020-08-31 10:58:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (5078, N'Admin', 3, N'Guest', CAST(N'2020-08-31 10:58:00.000' AS DateTime), CAST(N'2020-08-31 10:58:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (5079, N'Admin', 6, N'Guest', CAST(N'2020-08-31 10:58:00.000' AS DateTime), CAST(N'2020-08-31 10:58:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (5080, N'Admin', 4, N'Guest', CAST(N'2020-08-31 11:02:00.000' AS DateTime), CAST(N'2020-08-31 11:02:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (5081, N'Admin', 13, N'Guest', CAST(N'2020-08-31 11:02:00.000' AS DateTime), CAST(N'2020-08-31 11:03:00.000' AS DateTime), 10.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (5082, N'Admin', 3, N'Guest', CAST(N'2020-08-31 11:02:00.000' AS DateTime), CAST(N'2020-08-31 11:02:00.000' AS DateTime), NULL)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (5083, N'Admin', 5, N'Guest', CAST(N'2020-08-31 12:36:00.000' AS DateTime), CAST(N'2020-08-31 12:36:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (6083, N'Admin', 4, N'bleon', CAST(N'2020-09-01 11:18:00.000' AS DateTime), CAST(N'2020-09-01 11:19:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (8087, N'Admin', 1, N'bleon', CAST(N'2020-09-06 12:33:00.000' AS DateTime), CAST(N'2020-09-06 12:34:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (8088, N'Admin', 1, N'Guest', CAST(N'2020-09-06 12:35:00.000' AS DateTime), CAST(N'2020-09-06 12:37:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (8089, N'Admin', 3, N'Guest', CAST(N'2020-09-06 12:38:00.000' AS DateTime), CAST(N'2020-09-06 12:43:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (8090, N'Admin', 4, N'Guest', CAST(N'2020-09-06 12:43:00.000' AS DateTime), CAST(N'2020-09-06 12:52:00.000' AS DateTime), 1.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (8091, N'Admin', 6, N'bleon', CAST(N'2020-09-06 12:50:00.000' AS DateTime), CAST(N'2020-09-06 12:52:00.000' AS DateTime), 4.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (8092, N'Admin', 1, N'Guest', CAST(N'2020-09-06 12:54:00.000' AS DateTime), CAST(N'2020-09-06 12:55:00.000' AS DateTime), 5.0000)
INSERT [dbo].[Bills] ([BillID], [Employee], [ComputerID], [Client], [StartTime], [EndTime], [Total]) VALUES (8094, N'Admin', 1, N'Guest', CAST(N'2020-09-08 12:12:00.000' AS DateTime), CAST(N'2020-09-08 12:12:00.000' AS DateTime), 42.0000)
SET IDENTITY_INSERT [dbo].[Bills] OFF
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ClientID], [IsGuest], [Name], [LastName], [PersonalID], [Adress], [Birthday], [PhoneNumber], [Email], [UserName], [Password], [Balance], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (2, NULL, N'syl', N'sylani', N'123123123', N'Prishtin', CAST(N'1999-01-01' AS Date), N'038111444', N'syla@hotmail.com', N'syl', N'1234', 100.0000, 0, N'admin', CAST(N'2020-06-07 00:00:00.000' AS DateTime), N'Admin', CAST(N'2020-06-09 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Clients] ([ClientID], [IsGuest], [Name], [LastName], [PersonalID], [Adress], [Birthday], [PhoneNumber], [Email], [UserName], [Password], [Balance], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (4, NULL, N'Guest', N'Guest', N'111111', N'Genti', CAST(N'2000-01-01' AS Date), N'00123123', N'guest@hotmail.com', N'Guest', N'Guest', 999879.0000, 0, N'admin', CAST(N'2020-06-07 00:00:00.000' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Clients] ([ClientID], [IsGuest], [Name], [LastName], [PersonalID], [Adress], [Birthday], [PhoneNumber], [Email], [UserName], [Password], [Balance], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (6, NULL, N'bleon', N'xhemajli', N'123123123', N'Angli', CAST(N'2002-01-01' AS Date), N'123123123', N'bleon@hotmail.com', N'bleon', N'1234', 179.0000, 0, N'Admin', CAST(N'2020-06-14 00:00:00.000' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Clients] ([ClientID], [IsGuest], [Name], [LastName], [PersonalID], [Adress], [Birthday], [PhoneNumber], [Email], [UserName], [Password], [Balance], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (13, NULL, N'aaaa', N'aaaa', N'123123213', N'prishtin', CAST(N'2020-05-04' AS Date), N'21321312', N'a@hotmail.com', N'aaaa', N'123', 2.0000, 0, N'Admin', CAST(N'2020-09-08 00:00:00.000' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[ComputerParts] ON 

INSERT [dbo].[ComputerParts] ([PartID], [Case], [Mouse], [Keyboard], [HeadSets], [Monitor], [MousePad], [Processor], [GraphicCard], [MotherBoard], [RAM], [SSD], [HDD], [PCU], [Cooler], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (5, N'Asus', N'Asus', N'Asus', N'Asus', N'Asus', N'Asus', N'AMD Ryzen 3990X', N'NVIDIA RTX 2080Ti', N'Asus', N'32GB', N'1TB', N'1TB', N'1000W', N'Asus', N'eugen', CAST(N'2020-06-07 00:00:00.000' AS DateTime), N'Admin', CAST(N'2020-06-09 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[ComputerParts] ([PartID], [Case], [Mouse], [Keyboard], [HeadSets], [Monitor], [MousePad], [Processor], [GraphicCard], [MotherBoard], [RAM], [SSD], [HDD], [PCU], [Cooler], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (6, N'LogiTech', N'LogiTech', N'LogiTech', N'LogiTech', N'LogiTech', N'LogiTech', N'Intel I9 9900K', N'NVIDIA RTX 2080Ti', N'ASUS', N'32GB', N'1TB', N'1TB', N'800W', N'LogiTech', N'admin', CAST(N'2020-06-08 00:00:00.000' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[ComputerParts] OFF
SET IDENTITY_INSERT [dbo].[Computers] ON 

INSERT [dbo].[Computers] ([ComputerID], [PartID], [PricePerHour], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (1, 6, 1.0000, 0, N'admin', CAST(N'2020-06-06 00:00:00.000' AS DateTime), N'admin', CAST(N'2020-06-08 00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Computers] ([ComputerID], [PartID], [PricePerHour], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (3, 5, 1.0000, 0, N'admin', CAST(N'2020-06-06 00:00:00.000' AS DateTime), N'Admin', CAST(N'2020-06-09 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Computers] ([ComputerID], [PartID], [PricePerHour], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (4, 6, 1.0000, 0, N'admin', CAST(N'2020-06-06 00:00:00.000' AS DateTime), N'admin', CAST(N'2020-06-08 00:00:00.000' AS DateTime), 4)
INSERT [dbo].[Computers] ([ComputerID], [PartID], [PricePerHour], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (5, 6, 1.0000, 0, N'admin', CAST(N'2020-06-06 00:00:00.000' AS DateTime), N'Admin', CAST(N'2020-08-31 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Computers] ([ComputerID], [PartID], [PricePerHour], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (6, 5, 1.0000, 0, N'admin', CAST(N'2020-06-07 00:00:00.000' AS DateTime), N'Admin', CAST(N'2020-08-31 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Computers] ([ComputerID], [PartID], [PricePerHour], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (13, 5, 1.0000, 0, N'admin', CAST(N'2020-06-09 00:00:00.000' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Computers] ([ComputerID], [PartID], [PricePerHour], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (1016, 5, 1.0000, 0, N'Admin', CAST(N'2020-08-15 00:00:00.000' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Computers] ([ComputerID], [PartID], [PricePerHour], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (1017, 6, 1.0000, 0, N'Admin', CAST(N'2020-08-15 00:00:00.000' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Computers] OFF
SET IDENTITY_INSERT [dbo].[Employess] ON 

INSERT [dbo].[Employess] ([EmployeeID], [Name], [LastName], [PersonalID], [Adress], [Birthday], [Email], [PhoneNumber], [UserName], [Password], [Salary], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (1, N'Admin', N'Admin', N'1111111', N'Genti', CAST(N'2000-01-01' AS Date), N'admin@hotmail.com', N'049123123', N'Admin', N'admin', 400.0000, 1, NULL, CAST(N'2020-06-06 17:20:00.210' AS DateTime), N'admin', CAST(N'2020-06-09 00:00:00.000' AS DateTime), 4)
INSERT [dbo].[Employess] ([EmployeeID], [Name], [LastName], [PersonalID], [Adress], [Birthday], [Email], [PhoneNumber], [UserName], [Password], [Salary], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (2, N'Eugen', N'Sekiraqa', N'10932832', N'Eshref Ademaj', CAST(N'2000-01-03' AS Date), N'eugen.sekiraqa@hotmail.com', N'049140560', N'eugen', N'111222', 350.0000, 0, N'Admin', CAST(N'2020-06-14 00:00:00.000' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Employess] OFF
SET IDENTITY_INSERT [dbo].[Orderss] ON 

INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (1, 1, 7, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (2, 1, 16, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (3, 1, 30, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (4, 6, 1033, 1, 0.5000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (5, 1, 1033, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (6, 1, 1034, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (7, 1, 1039, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (9, 6, 1039, 5, 2.5000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (10, 1, 1040, 2, 2.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (11, 6, 1040, 1, 0.5000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (12, 1, 1041, 2, 2.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (13, 6, 1041, 1, 0.5000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (14, 3, 1039, 4, 4.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (15, 6, 1042, 3, 1.5000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (16, 7, 1042, 4, 4.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (17, 4, 1043, 2, 2.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (18, 1, 1044, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (19, 1, 1045, 2, 2.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (20, 1, 1046, 3, 3.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (21, 1, 1047, 4, 4.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (22, 1, 1049, 8, 8.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (23, 4, 1049, 5, 5.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (24, 1, 1050, 2, 2.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (25, 4, 1050, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (26, 7, 1051, 6, 6.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (27, 6, 1052, 1, 0.5000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (28, 7, 1054, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (29, 4, 1054, 3, 3.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (30, 1, 1056, 2, 2.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (31, 6, 1056, 3, 1.5000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (32, 4, 1057, 4, 4.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (1030, 1, 2056, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (1031, 6, 2056, 3, 1.5000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (1032, 4, 2057, 4, 4.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (1033, 4, 2059, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (2033, 4, 3062, 4, 4.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (2034, 6, 3063, 7, 3.5000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (2035, 4, 3067, 4, 4.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (2036, 4, 3071, 3, 3.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (2037, 3, 4072, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (2038, 4, 4073, 3, 3.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (3038, 4, 4074, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (3039, 6, 3066, 3, 1.5000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (4038, 3, 5074, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (4039, 4, 5074, 3, 3.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (5043, 1, 8091, 3, 3.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (5044, 4, 8092, 4, 4.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (5046, 3, 8094, 4, 4.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (5047, 1008, 8094, 1, 1.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (5049, 3, 8094, 9, 9.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (5050, 3, 8094, 9, 9.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (5051, 3, 8094, 9, 9.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (5052, 3, 8094, 9, 9.0000)
INSERT [dbo].[Orderss] ([OrderID], [ProductID], [BillID], [Quantity], [Price]) VALUES (5053, 3, 8094, 9, 9.0000)
SET IDENTITY_INSERT [dbo].[Orderss] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductQuantity], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (1, N'Coca Cola', 1.0000, 300, N'admin', CAST(N'2020-06-06 00:00:00.000' AS DateTime), N'admin', CAST(N'2020-06-07 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductQuantity], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (3, N'Fanta', 1.0000, 102, N'admin', CAST(N'2020-06-08 00:00:00.000' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductQuantity], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (4, N'Sprite', 1.0000, 200, N'admin', CAST(N'2020-06-08 00:00:00.000' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductQuantity], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (6, N'Uj', 0.5000, 500, N'Admin', CAST(N'2020-06-19 00:00:00.000' AS DateTime), N'Admin', CAST(N'2020-06-19 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductQuantity], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (7, N'7UP', 1.0000, 300, N'Admin', CAST(N'2020-06-20 00:00:00.000' AS DateTime), NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductQuantity], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (1008, N'Coca Cola Zero', 1.0000, 200, N'Admin', CAST(N'2020-09-08 00:00:00.000' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Clients__C9F28456CBDF394C]    Script Date: 08/09/2020 12:56:21 ******/
ALTER TABLE [dbo].[Clients] ADD UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Employes__C9F28456FD5500A6]    Script Date: 08/09/2020 12:56:21 ******/
ALTER TABLE [dbo].[Employess] ADD UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD FOREIGN KEY([Client])
REFERENCES [dbo].[Clients] ([UserName])
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD FOREIGN KEY([ComputerID])
REFERENCES [dbo].[Computers] ([ComputerID])
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD FOREIGN KEY([Employee])
REFERENCES [dbo].[Employess] ([UserName])
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Clients] FOREIGN KEY([Client])
REFERENCES [dbo].[Clients] ([UserName])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Clients]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Computers] FOREIGN KEY([ComputerID])
REFERENCES [dbo].[Computers] ([ComputerID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Computers]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Employess] FOREIGN KEY([Employee])
REFERENCES [dbo].[Employess] ([UserName])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Employess]
GO
ALTER TABLE [dbo].[Computers]  WITH CHECK ADD FOREIGN KEY([PartID])
REFERENCES [dbo].[ComputerParts] ([PartID])
GO
ALTER TABLE [dbo].[Computers]  WITH CHECK ADD  CONSTRAINT [FK_Computers_ComputerParts] FOREIGN KEY([PartID])
REFERENCES [dbo].[ComputerParts] ([PartID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Computers] CHECK CONSTRAINT [FK_Computers_ComputerParts]
GO
ALTER TABLE [dbo].[Orderss]  WITH CHECK ADD FOREIGN KEY([BillID])
REFERENCES [dbo].[Bills] ([BillID])
GO
ALTER TABLE [dbo].[Orderss]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[Orderss]  WITH CHECK ADD  CONSTRAINT [FK_Orderss_Bills] FOREIGN KEY([BillID])
REFERENCES [dbo].[Bills] ([BillID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orderss] CHECK CONSTRAINT [FK_Orderss_Bills]
GO
ALTER TABLE [dbo].[Orderss]  WITH CHECK ADD  CONSTRAINT [FK_Orderss_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orderss] CHECK CONSTRAINT [FK_Orderss_Products]
GO
/****** Object:  StoredProcedure [dbo].[ADD_ComputerParts]    Script Date: 08/09/2020 12:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[Add_Computers]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
CREATE PROCEDURE [dbo].[Add_Computers]
(
@partid int,
@priceperhour money,
@insertby varchar(50),
@insertdate datetime
)
AS
BEGIN
INSERT INTO dbo.Computers
(
    --ComputerID - column value is auto-generated
    PartID,
    PricePerHour,
    InsertBy,
    InsertDate
)
VALUES
(
@partid,@priceperhour,@insertby,@insertdate
)
END


GO
/****** Object:  StoredProcedure [dbo].[Add_Employess]    Script Date: 08/09/2020 12:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[Add_EndTime]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Add_EndTime]
@endTime DATETIME
AS
INSERT INTO dbo.Bills(EndTime)
VALUES (@endTime);

GO
/****** Object:  StoredProcedure [dbo].[Add_Products]    Script Date: 08/09/2020 12:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[AddBill]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddBill]
@employee VARCHAR(20),
@computerID INT,
@client VARCHAR(50),
@startTime DATETIME
AS
INSERT INTO dbo.Bills(Employee, ComputerID, Client, StartTime)
VALUES (@employee, @computerID, @client, @startTime)

GO
/****** Object:  StoredProcedure [dbo].[Balance]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Balance]
@username VARCHAR(50),
@price MONEY
AS
UPDATE dbo.Clients
SET Balance -= @price
WHERE UserName = @username
GO
/****** Object:  StoredProcedure [dbo].[Bill_GETALL]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Bill_GETALL]
@computerID INT
AS
SELECT * FROM dbo.Bills
WHERE ComputerID = @computerID

GO
/****** Object:  StoredProcedure [dbo].[BillAdd]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BillAdd]
@employee VARCHAR(20),
@computerID INT,
@client VARCHAR(50),
@startTime DATETIME,
@endTime DATETIME

AS

INSERT INTO dbo.Bills(Employee, ComputerID, Client, StartTime, EndTime)
VALUES (@employee, @computerID, @client, @startTime, @endTime)
GO
/****** Object:  StoredProcedure [dbo].[Clients_Edit]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Clients_Edit]
@clientid int,
@name varchar(50),
@lastname varchar(50),
@personalid varchar(11),
@address varchar(50),
@birthday date,
@email varchar(50),
@phonenumber varchar(50),
@username varchar(50),
@password varchar(50),
@balance money,
@updateby varchar(50),
@updatedate datetime,
@updateno int

AS
BEGIN
	UPDATE dbo.Clients
	SET
	    --ClientID - column value is auto-generated
	    dbo.Clients.Name = @name,
	    dbo.Clients.LastName = @lastname,
	    dbo.Clients.PersonalID = @personalid,
	    dbo.Clients.Adress = @address,
	    dbo.Clients.Birthday = @birthday,
	    dbo.Clients.PhoneNumber = @phonenumber,
	    dbo.Clients.Email = @email,
	    dbo.Clients.UserName = @username,
	    dbo.Clients.[Password] = @password,
	    dbo.Clients.Balance = @balance,
	    dbo.Clients.UpdateBy = @updateby,
	    dbo.Clients.UpdateDate = @updatedate,
	    dbo.Clients.UpdateNo = @updateno
		WHERE ClientID = @clientid
END


GO
/****** Object:  StoredProcedure [dbo].[Clients_Editt]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Clients_Editt]
@clientid int,
@isguest bit,
@name varchar(50),
@lastname varchar(50),
@personalid varchar(11),
@address varchar(50),
@birthday date,
@email varchar(50),
@phonenumber varchar(50),
@username varchar(50),
@password varchar(50),
@balance money,
@updateby varchar(50),
@updatedate datetime,
@updateno int

AS
BEGIN
	UPDATE dbo.Clients
	SET
	    --ClientID - column value is auto-generated
	    dbo.Clients.IsGuest = @isguest,
	    dbo.Clients.Name = @name,
	    dbo.Clients.LastName = @lastname,
	    dbo.Clients.PersonalID = @personalid,
	    dbo.Clients.Adress = @address,
	    dbo.Clients.Birthday = @birthday,
	    dbo.Clients.PhoneNumber = @phonenumber,
	    dbo.Clients.Email = @email,
	    dbo.Clients.UserName = @username,
	    dbo.Clients.[Password] = @password,
	    dbo.Clients.Balance = @balance,
	    dbo.Clients.UpdateBy = @updateby,
	    dbo.Clients.UpdateDate = @updatedate,
	    dbo.Clients.UpdateNo = @updateno
		WHERE ClientID = @clientid
END



GO
/****** Object:  StoredProcedure [dbo].[Clients_GetALL]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDUre [dbo].[Clients_GetALL]
AS
SELECT * FROM dbo.Clients c


GO
/****** Object:  StoredProcedure [dbo].[Clients_Insert]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Clients_Insert]
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
/****** Object:  StoredProcedure [dbo].[Computers_Delete]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Computers_Delete]
(
@computerid int
)
AS
BEGIN

DELETE FROM dbo.Computers WHERE dbo.Computers.ComputerID = @computerid
END


GO
/****** Object:  StoredProcedure [dbo].[Computers_Update]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Computers_Update]
(
@computerid int,
@partid int,
@priceperhour money,
@updateby varchar(50),
@updatedate datetime,
@updateno int
)
AS
BEGIN
UPDATE dbo.Computers
SET
    --ComputerID - column value is auto-generated
    dbo.Computers.PartID = @partid,
    dbo.Computers.PricePerHour =@priceperhour,
    dbo.Computers.UpdateBy = @updateby,
    dbo.Computers.UpdateDate = @updatedate,
    dbo.Computers.UpdateNo = @updateno

	WHERE ComputerID = @computerid
END



GO
/****** Object:  StoredProcedure [dbo].[DecQuantity]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DecQuantity]
@name VARCHAR(50),
@quantity INT
AS
UPDATE dbo.Products
SET ProductQuantity -= @quantity
WHERE ProductName = @name
GO
/****** Object:  StoredProcedure [dbo].[Delete_ClientsByID]    Script Date: 08/09/2020 12:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[Delete_ComputerPartsByID]    Script Date: 08/09/2020 12:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[Delete_EmployeeByID]    Script Date: 08/09/2020 12:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[Delete_ProductsByID]    Script Date: 08/09/2020 12:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[Edit_Products]    Script Date: 08/09/2020 12:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[Employess_Edit]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Employess_Edit]
@employeeid int,
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
@updateby varchar(50),
@updatedate datetime,
@updateno int
AS
BEGIN
UPDATE dbo.Employess
SET
    --EmployeeID - column value is auto-generated
    dbo.Employess.Name = @name,
    dbo.Employess.LastName = @lastname,
    dbo.Employess.PersonalID = @personalid,
    dbo.Employess.Adress = @address,
    dbo.Employess.Birthday = @birthday,
    dbo.Employess.Email = @email,
    dbo.Employess.PhoneNumber = @phonenumber,
    dbo.Employess.UserName = @username,
    dbo.Employess.[Password] = @password,
    dbo.Employess.Salary = @salary,
    dbo.Employess.UpdateBy = @updateby,
    dbo.Employess.UpdateDate = @updatedate,
    dbo.Employess.UpdateNo = @updateno
	where dbo.Employess.EmployeeID = @employeeid
End


GO
/****** Object:  StoredProcedure [dbo].[Employess_GetALL]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Employess_GetALL]
AS
SELECT * FROM dbo.Employess e


GO
/****** Object:  StoredProcedure [dbo].[EndTime_ADD]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EndTime_ADD]
@BillID INT,
@endTime DATETIME
AS
UPDATE dbo.Bills
SET EndTime = @endTime
WHERE BillID = @billID


GO
/****** Object:  StoredProcedure [dbo].[Get_Product]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Get_Product]
AS
SELECT ProductName, ProductPrice FROM dbo.Products
GO
/****** Object:  StoredProcedure [dbo].[GETALL_Bill]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GETALL_Bill]
AS
SELECT * FROM dbo.Bills

GO
/****** Object:  StoredProcedure [dbo].[GetALL_ComputerParts]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetALL_ComputerParts]
AS
SELECT * FROM dbo.ComputerParts cp


GO
/****** Object:  StoredProcedure [dbo].[GetALL_Computers]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetALL_Computers]
AS
SELECT * FROM dbo.Computers c


GO
/****** Object:  StoredProcedure [dbo].[GetAll_Order]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAll_Order]
AS
SELECT * FROM Orderss
GO
/****** Object:  StoredProcedure [dbo].[GetBill]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBill]
@computerID INT
AS
SELECT TOP(1) * FROM dbo.Bills
WHERE ComputerID = @computerID
ORDER BY BillID DESC;

GO
/****** Object:  StoredProcedure [dbo].[GetBillID]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBillID]
@computerID INT
AS
SELECT TOP 1 BillID FROM dbo.Bills
WHERE ComputerID = @computerID
ORDER BY BillID DESC
GO
/****** Object:  StoredProcedure [dbo].[GetByIdOrder]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetByIdOrder]
@id INT
AS
BEGIN
SELECT * FROM dbo.Products
WHERE ProductID = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[GetCase]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCase]
AS
BEGIN
SELECT cp.[Case] FROM dbo.ComputerParts cp

END


GO
/****** Object:  StoredProcedure [dbo].[GetClient]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[GetClient]
 AS
 SELECT UserName FROM Clients

GO
/****** Object:  StoredProcedure [dbo].[GetClientID]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetClientID]
AS
SELECT ClientID FROM Clients

GO
/****** Object:  StoredProcedure [dbo].[GetPartID]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPartID]
AS
BEGIN
SELECT PartID FROM dbo.ComputerParts cp

END



GO
/****** Object:  StoredProcedure [dbo].[GetProduct]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProduct]
AS
SELECT ProductName FROM dbo.Products
GO
/****** Object:  StoredProcedure [dbo].[GetTotalPriceBill]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetTotalPriceBill]
@billID INT
AS
BEGIN
SELECT SUM(Price) From dbo.Orderss
WHERE BillID = @billID
END
GO
/****** Object:  StoredProcedure [dbo].[GetTotalPriceOrders]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetTotalPriceOrders]
@billID INT
AS
BEGIN
SELECT SUM(Price) as shuma
 From dbo.Orderss
WHERE BillID = @billID
END
GO
/****** Object:  StoredProcedure [dbo].[IsActive]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IsActive]
@computerId INT
AS
UPDATE dbo.Computers
SET IsActive = 1
WHERE ComputerID = @computerId
GO
/****** Object:  StoredProcedure [dbo].[IsActiveFalse]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IsActiveFalse]
@computerId INT
AS
UPDATE dbo.Computers
SET IsActive = 0
WHERE ComputerID = @computerId
GO
/****** Object:  StoredProcedure [dbo].[LoginEmployee]    Script Date: 08/09/2020 12:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[OrderAdd]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderAdd]
@productId INT,
@billId INT,
@quantity INT,
@price MONEY
AS
INSERT INTO Orderss(ProductID, BillID, Quantity, Price)
VALUES (@productId, @billId, @quantity, @price);

GO
/****** Object:  StoredProcedure [dbo].[PCparts_Edit]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PCparts_Edit]
(
@partid int ,
@case varchar(255),
@mouse varchar(255),
@keyboard varchar(255),
@headsets varchar(255),
@monitor varchar(255),
@mousepad varchar(50),
@processor varchar(255),
@graphiccard varchar(255),
@motherboard varchar(50),
@ram varchar(50),
@ssd varchar (50),
@hdd varchar(50),
@psu varchar(50),
@cooler varchar(50),
@updateby varchar(50),
@updatedate datetime,
@updateno int
)
AS
BEGIN
UPDATE dbo.ComputerParts
SET
    --PartID - column value is auto-generated
    dbo.ComputerParts.[Case] = @case,
    dbo.ComputerParts.Mouse = @mouse,
    dbo.ComputerParts.Keyboard = @keyboard,
    dbo.ComputerParts.HeadSets = @headsets,
    dbo.ComputerParts.Monitor = @monitor,
    dbo.ComputerParts.MousePad = @mousepad,
    dbo.ComputerParts.Processor = @processor,
    dbo.ComputerParts.GraphicCard = @graphiccard,
    dbo.ComputerParts.MotherBoard = @motherboard,
    dbo.ComputerParts.RAM = @ram,
    dbo.ComputerParts.SSD = @ssd,
    dbo.ComputerParts.HDD = @hdd,
    dbo.ComputerParts.PCU = @psu,
    dbo.ComputerParts.Cooler = @cooler,
    dbo.ComputerParts.UpdateBy = @updateby,
    dbo.ComputerParts.UpdateDate = @updatedate,
    dbo.ComputerParts.UpdateNo = @updateno
	WHERE PartID = @partid
END



GO
/****** Object:  StoredProcedure [dbo].[Product_Edit]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Product_Edit]
@productid int,
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
  WHERE dbo.Products.ProductID = @productid
End


GO
/****** Object:  StoredProcedure [dbo].[Product_GETALL]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Product_GETALL]
AS
SELECT p.ProductID,p.ProductName,p.ProductPrice,p.ProductQuantity FROM dbo.Products p


GO
/****** Object:  StoredProcedure [dbo].[ProductGetByID]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ProductGetByID](
@productID int
)
as

BEGIN 
SELECT * FROM dbo.Products p
WHERE p.ProductID = @productID
END




GO
/****** Object:  StoredProcedure [dbo].[Products_ADD]    Script Date: 08/09/2020 12:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[Total_ADD]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Total_ADD]
@billID INT,
@total MONEY
AS
UPDATE Bills
SET Total = @total
WHERE BillID = @billID

GO
/****** Object:  StoredProcedure [dbo].[UserName_Check]    Script Date: 08/09/2020 12:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserName_Check](
@username varchar(50)
)
AS
BEGIN
SELECT * FROM dbo.Employess e WHERE e.UserName =@username
END


GO
USE [master]
GO
ALTER DATABASE [Gaming-Center MG] SET  READ_WRITE 
GO
