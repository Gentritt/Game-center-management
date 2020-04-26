USE [master]
GO
/****** Object:  Database [Game-Center Management]    Script Date: 4/26/2020 8:45:28 PM ******/
CREATE DATABASE [Game-Center Management]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Game-Center Management', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Game-Center Management.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Game-Center Management_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Game-Center Management_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Game-Center Management] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Game-Center Management].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Game-Center Management] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Game-Center Management] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Game-Center Management] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Game-Center Management] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Game-Center Management] SET ARITHABORT OFF 
GO
ALTER DATABASE [Game-Center Management] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Game-Center Management] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Game-Center Management] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Game-Center Management] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Game-Center Management] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Game-Center Management] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Game-Center Management] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Game-Center Management] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Game-Center Management] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Game-Center Management] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Game-Center Management] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Game-Center Management] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Game-Center Management] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Game-Center Management] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Game-Center Management] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Game-Center Management] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Game-Center Management] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Game-Center Management] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Game-Center Management] SET  MULTI_USER 
GO
ALTER DATABASE [Game-Center Management] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Game-Center Management] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Game-Center Management] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Game-Center Management] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Game-Center Management] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Game-Center Management]
GO
/****** Object:  Table [dbo].[Fatura]    Script Date: 4/26/2020 8:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fatura](
	[FaturaID] [int] IDENTITY(1,1) NOT NULL,
	[KompjuteriID] [int] NULL,
	[KonsumatoriID] [int] NULL,
	[ProduktiID] [int] NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NOT NULL,
	[Totali] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FaturaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Guest]    Script Date: 4/26/2020 8:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Guest](
	[GuestID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GuestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Kompjuteri]    Script Date: 4/26/2020 8:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kompjuteri](
	[KompjuterID] [int] IDENTITY(1,1) NOT NULL,
	[KonsumatoriID] [int] NULL,
	[GuestID] [int] NULL,
	[IsActive] [bit] NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NOT NULL,
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KompjuterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Konsumatori]    Script Date: 4/26/2020 8:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Konsumatori](
	[KonsumatoriID] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [varchar](50) NOT NULL,
	[Mbiemri] [varchar](50) NOT NULL,
	[NumriPersonal] [varchar](11) NOT NULL,
	[Adresa] [varchar](50) NULL,
	[DataLindjes] [date] NOT NULL,
	[NumriTelefonit] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[UserPassword] [varchar](50) NOT NULL,
	[Balanca] [money] NULL,
	[IsActive] [bit] NOT NULL,
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KonsumatoriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pajisjet]    Script Date: 4/26/2020 8:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pajisjet](
	[PajisjetID] [int] IDENTITY(1,1) NOT NULL,
	[Shtepiza] [nvarchar](255) NOT NULL,
	[Mausi] [nvarchar](255) NOT NULL,
	[Tastiera] [nvarchar](255) NOT NULL,
	[Ndegjueset] [nvarchar](255) NOT NULL,
	[Monitori] [nvarchar](255) NOT NULL,
	[Mauspad] [nvarchar](50) NOT NULL,
	[Procesori] [nvarchar](50) NOT NULL,
	[KartelaGrafike] [nvarchar](50) NOT NULL,
	[MotherBoard] [nvarchar](50) NOT NULL,
	[RAM] [nvarchar](50) NOT NULL,
	[SSD] [nvarchar](50) NOT NULL,
	[HDD] [nvarchar](50) NOT NULL,
	[PCU] [nvarchar](50) NOT NULL,
	[Cooler] [nvarchar](50) NOT NULL,
	[KompjuteriID] [int] NULL,
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PajisjetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Produktet]    Script Date: 4/26/2020 8:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Produktet](
	[ProduktiID] [int] IDENTITY(1,1) NOT NULL,
	[ProduktiEmri] [varchar](50) NOT NULL,
	[ProduktiCmimi] [money] NULL,
	[ProduktiQuantity] [int] NULL,
	[ProduktiDate] [datetime] NOT NULL,
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProduktiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Puntori]    Script Date: 4/26/2020 8:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Puntori](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [varchar](50) NOT NULL,
	[Mbiemri] [varchar](50) NOT NULL,
	[NumriPersonal] [varchar](11) NOT NULL,
	[Adresa] [varchar](50) NULL,
	[DataLindjes] [date] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[NumriTelefonit] [varchar](50) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[UserPassword] [varchar](20) NOT NULL,
	[Rroga] [money] NULL,
	[OrariPunes] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL DEFAULT ((0)),
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL DEFAULT (getdate()),
	[UpdateBy] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateNo] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Puntori] ON 

INSERT [dbo].[Puntori] ([ID], [Emri], [Mbiemri], [NumriPersonal], [Adresa], [DataLindjes], [Email], [NumriTelefonit], [UserName], [UserPassword], [Rroga], [OrariPunes], [IsActive], [InsertBy], [InsertDate], [UpdateBy], [UpdateDate], [UpdateNo]) VALUES (1, N'Admin', N'admin', N'12228828282', N'Prishtin', CAST(N'2000-01-14' AS Date), N'admin@riinvest.net', N'044352029', N'admin', N'admin', 100.0000, CAST(N'2020-08-12 00:00:00.000' AS DateTime), 1, N'1', CAST(N'2020-04-26 20:40:56.140' AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Puntori] OFF
ALTER TABLE [dbo].[Guest] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Guest] ADD  DEFAULT ((0)) FOR [UpdateNo]
GO
ALTER TABLE [dbo].[Kompjuteri] ADD  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Kompjuteri] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Kompjuteri] ADD  DEFAULT ((0)) FOR [UpdateNo]
GO
ALTER TABLE [dbo].[Konsumatori] ADD  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Konsumatori] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Konsumatori] ADD  DEFAULT ((0)) FOR [UpdateNo]
GO
ALTER TABLE [dbo].[Pajisjet] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Pajisjet] ADD  DEFAULT ((0)) FOR [UpdateNo]
GO
ALTER TABLE [dbo].[Produktet] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Produktet] ADD  DEFAULT ((0)) FOR [UpdateNo]
GO
ALTER TABLE [dbo].[Fatura]  WITH CHECK ADD FOREIGN KEY([KompjuteriID])
REFERENCES [dbo].[Kompjuteri] ([KompjuterID])
GO
ALTER TABLE [dbo].[Fatura]  WITH CHECK ADD FOREIGN KEY([KonsumatoriID])
REFERENCES [dbo].[Konsumatori] ([KonsumatoriID])
GO
ALTER TABLE [dbo].[Fatura]  WITH CHECK ADD FOREIGN KEY([ProduktiID])
REFERENCES [dbo].[Produktet] ([ProduktiID])
GO
ALTER TABLE [dbo].[Kompjuteri]  WITH CHECK ADD FOREIGN KEY([GuestID])
REFERENCES [dbo].[Guest] ([GuestID])
GO
ALTER TABLE [dbo].[Kompjuteri]  WITH CHECK ADD FOREIGN KEY([KonsumatoriID])
REFERENCES [dbo].[Konsumatori] ([KonsumatoriID])
GO
ALTER TABLE [dbo].[Pajisjet]  WITH CHECK ADD FOREIGN KEY([KompjuteriID])
REFERENCES [dbo].[Kompjuteri] ([KompjuterID])
GO
/****** Object:  StoredProcedure [dbo].[InsertimiKlientit]    Script Date: 4/26/2020 8:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertimiKlientit]
@emri VARCHAR(50),
@mbiemri VARCHAR(50), 
@numriPersonal VARCHAR(11),
@adresa VARCHAR(50),
@dataLindjes DATE, 
@email VARCHAR(50),
@userName VARCHAR(20), 
@userPassword VARCHAR(20), 
@balanca MONEY,
@isActive BIT


AS

INSERT INTO dbo.Konsumatori(Emri,Mbiemri,NumriPersonal,Adresa,DataLindjes,Email,UserName,UserPassword,Balanca,IsActive)
VALUES (@emri,@mbiemri,@numriPersonal,@adresa,@dataLindjes,@email,@userName,@userPassword,@balanca,@isActive)

GO
/****** Object:  StoredProcedure [dbo].[InsertimiProdukteve]    Script Date: 4/26/2020 8:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertimiProdukteve]
@emri VARCHAR(50),
@cmimi MONEY,
@quantity INT,
@date DATETIME

AS

INSERT INTO dbo.Produktet(ProduktiEmri,ProduktiCmimi,ProduktiQuantity,ProduktiDate)
VALUES (@emri,@cmimi,@quantity,@date)
GO
/****** Object:  StoredProcedure [dbo].[InsertimiPuntorit]    Script Date: 4/26/2020 8:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertimiPuntorit]
@emri VARCHAR(50),
@mbiemri VARCHAR(50),
@numriPersonal VARCHAR(11),
@dataLindjes DATE,
@email VARCHAR(50),
@numriTelefonit VARCHAR(50),
@rroga MONEY,
@orariPunes DATETIME,
@userName VARCHAR(20),
@userPass VARCHAR(20),
@isActive BIT

AS

INSERT INTO dbo.Puntori(Emri,Mbiemri,NumriPersonal,DataLindjes,Email,NumriTelefonit,Rroga,OrariPunes,UserName,UserPassword,IsActive)
VALUES (@emri,@mbiemri,@numriPersonal,@dataLindjes,@email,@numriTelefonit,@rroga,@orariPunes,@userName,@UserPass,@isActive)
GO
USE [master]
GO
ALTER DATABASE [Game-Center Management] SET  READ_WRITE 
GO
