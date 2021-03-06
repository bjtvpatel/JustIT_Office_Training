USE [master]
GO
/****** Object:  Database [TechMVCDatabase]    Script Date: 20/05/2017 18:53:26 ******/
CREATE DATABASE [TechMVCDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TechMVCDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\TechMVCDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TechMVCDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\TechMVCDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TechMVCDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TechMVCDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TechMVCDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TechMVCDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TechMVCDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TechMVCDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET RECOVERY FULL 
GO
ALTER DATABASE [TechMVCDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [TechMVCDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TechMVCDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TechMVCDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TechMVCDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TechMVCDatabase', N'ON'
GO
USE [TechMVCDatabase]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [TechMVCDatabase]
GO
/****** Object:  User [bjtvlondon]    Script Date: 20/05/2017 18:53:26 ******/
CREATE USER [bjtvlondon] FOR LOGIN [bjtvlondon] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [bjtvlondon]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [bjtvlondon]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [bjtvlondon]
GO
ALTER ROLE [db_datareader] ADD MEMBER [bjtvlondon]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [bjtvlondon]
GO
/****** Object:  Table [dbo].[TechDetail]    Script Date: 20/05/2017 18:53:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Brand] [varchar](50) NOT NULL,
	[ModelName] [varchar](50) NOT NULL,
	[Category] [varchar](50) NOT NULL,
	[Price] [money] NULL,
	[Image] [image] NULL,
	[Photo] [varchar](max) NULL,
	[AlternateText] [nvarchar](100) NULL,
 CONSTRAINT [PK_TechDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[TechDetail] ON 

INSERT [dbo].[TechDetail] ([Id], [Brand], [ModelName], [Category], [Price], [Image], [Photo], [AlternateText]) VALUES (1, N'Apple', N'Iphone 7', N'Mobile', 599.0000, NULL, N'https://raw.githubusercontent.com/bjtvpatel/JustIT_Office_Training/master/Week-5/TechMVCDatabase/Photos/iphone/Modified_Iphone/iphone7s_411x640.JPG', N'Iphone 7 is the best model of year 2016')
INSERT [dbo].[TechDetail] ([Id], [Brand], [ModelName], [Category], [Price], [Image], [Photo], [AlternateText]) VALUES (3, N'Apple', N'Iphone-7s', N'Mobile', 699.0000, NULL, N'https://github.com/bjtvpatel/JustIT_Office_Training/blob/master/Week-5/TechMVCDatabase/Photos/iphone/Modified_Iphone/u_10151613_397x640.jpg?raw=true', NULL)
INSERT [dbo].[TechDetail] ([Id], [Brand], [ModelName], [Category], [Price], [Image], [Photo], [AlternateText]) VALUES (4, N'Apple', N'Iphone-6', N'Moble', 399.0000, NULL, N'https://github.com/bjtvpatel/JustIT_Office_Training/blob/master/Week-5/TechMVCDatabase/Photos/iphone/Modified_Iphone/u_10151613_397x640.jpg?raw=true', NULL)
INSERT [dbo].[TechDetail] ([Id], [Brand], [ModelName], [Category], [Price], [Image], [Photo], [AlternateText]) VALUES (5, N'Samsung', N'Galaxy-6', N'Mobile', 499.0000, NULL, N'https://github.com/bjtvpatel/JustIT_Office_Training/blob/master/Week-5/TechMVCDatabase/Photos/iphone/Modified_Iphone/samsung-galaxy-s8-render_385x640.jpg?raw=true', NULL)
INSERT [dbo].[TechDetail] ([Id], [Brand], [ModelName], [Category], [Price], [Image], [Photo], [AlternateText]) VALUES (6, N'Samsung', N'Galaxy-6 Edge', N'Mobile', 549.0000, NULL, N'https://github.com/bjtvpatel/JustIT_Office_Training/blob/master/Week-5/TechMVCDatabase/Photos/iphone/Modified_Iphone/samsung-galaxy-s8-render_385x640.jpg?raw=true', NULL)
INSERT [dbo].[TechDetail] ([Id], [Brand], [ModelName], [Category], [Price], [Image], [Photo], [AlternateText]) VALUES (7, N'Apple', N'Ipad Air 4', N'Tablet', 299.0000, NULL, N'https://raw.githubusercontent.com/bjtvpatel/JustIT_Office_Training/master/Week-5/TechMVCDatabase/Photos/Apple-Ipad/Modified/md528ba-ipad-mini-2_1_441x640.jpg', NULL)
INSERT [dbo].[TechDetail] ([Id], [Brand], [ModelName], [Category], [Price], [Image], [Photo], [AlternateText]) VALUES (8, N'Apple', N'Ipad 2', N'Tablet', 150.0000, NULL, N'https://raw.githubusercontent.com/bjtvpatel/JustIT_Office_Training/master/Week-5/TechMVCDatabase/Photos/Apple-Ipad/Modified/ipad2_w_480x591.jpg', NULL)
INSERT [dbo].[TechDetail] ([Id], [Brand], [ModelName], [Category], [Price], [Image], [Photo], [AlternateText]) VALUES (9, N'Samsung', N'Note', N'Table', 175.0000, NULL, N'https://github.com/bjtvpatel/JustIT_Office_Training/blob/master/Week-5/TechMVCDatabase/Photos/Apple-Ipad/Modified/ipad2_w.jpg?raw=true', NULL)
INSERT [dbo].[TechDetail] ([Id], [Brand], [ModelName], [Category], [Price], [Image], [Photo], [AlternateText]) VALUES (10, N'Motorola', N'Moto G4', N'Mobile', 599.0000, NULL, N'http://cdn2.gsmarena.com/vv/pics/motorola/motorola-moto-g4-plus-r1.jpg', NULL)
INSERT [dbo].[TechDetail] ([Id], [Brand], [ModelName], [Category], [Price], [Image], [Photo], [AlternateText]) VALUES (11, N'Samsung', N'Galaxy S8', N'Mobile', 599.0000, NULL, N'https://raw.githubusercontent.com/bjtvpatel/JustIT_Office_Training/master/Week-5/TechMVCDatabase/Photos/iphone/Modified_Iphone/samsung-galaxy-s8-_480x608.jpg', NULL)
SET IDENTITY_INSERT [dbo].[TechDetail] OFF
USE [master]
GO
ALTER DATABASE [TechMVCDatabase] SET  READ_WRITE 
GO
