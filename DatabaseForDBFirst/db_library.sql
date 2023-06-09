USE [master]
GO
/****** Object:  Database [db_library]    Script Date: 04/04/2023 09:42:31 ******/
CREATE DATABASE [db_library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LIBRARY', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LIBRARY.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LIBRARY_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LIBRARY_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_library] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_library] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_library] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_library] SET RECOVERY FULL 
GO
ALTER DATABASE [db_library] SET  MULTI_USER 
GO
ALTER DATABASE [db_library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_library] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_library] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_library', N'ON'
GO
ALTER DATABASE [db_library] SET QUERY_STORE = OFF
GO
USE [db_library]
GO
/****** Object:  Table [dbo].[eserler]    Script Date: 04/04/2023 09:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eserler](
	[eserId] [int] IDENTITY(1,1) NOT NULL,
	[eserAdi] [nvarchar](30) NULL,
	[yazar] [int] NULL,
	[kategori] [int] NULL,
	[yayinTarihi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[eserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kategoriler]    Script Date: 04/04/2023 09:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kategoriler](
	[kategoriId] [int] IDENTITY(1,1) NOT NULL,
	[kategoriAdi] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[kategoriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ülkeler]    Script Date: 04/04/2023 09:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ülkeler](
	[ulkeId] [int] IDENTITY(1,1) NOT NULL,
	[ulkeAdi] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ulkeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[yazarlar]    Script Date: 04/04/2023 09:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yazarlar](
	[yazarId] [int] IDENTITY(1,1) NOT NULL,
	[yazarAdi] [nvarchar](30) NULL,
	[yazarYasi] [int] NULL,
	[yazarUlkesi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[yazarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[eserler] ON 

INSERT [dbo].[eserler] ([eserId], [eserAdi], [yazar], [kategori], [yayinTarihi]) VALUES (1, N'Suç Ve Ceza', 1, 1, 1960)
INSERT [dbo].[eserler] ([eserId], [eserAdi], [yazar], [kategori], [yayinTarihi]) VALUES (2, N'Don Kişot', 2, 2, 1970)
INSERT [dbo].[eserler] ([eserId], [eserAdi], [yazar], [kategori], [yayinTarihi]) VALUES (3, N'Anna Karenina', 3, 3, 1980)
INSERT [dbo].[eserler] ([eserId], [eserAdi], [yazar], [kategori], [yayinTarihi]) VALUES (4, N'Büyük Umutalar ', 4, 4, 1990)
INSERT [dbo].[eserler] ([eserId], [eserAdi], [yazar], [kategori], [yayinTarihi]) VALUES (5, N'Beyaz Geceler ', 5, 5, 2000)
INSERT [dbo].[eserler] ([eserId], [eserAdi], [yazar], [kategori], [yayinTarihi]) VALUES (6, N'Sefiller', 6, 6, 2010)
INSERT [dbo].[eserler] ([eserId], [eserAdi], [yazar], [kategori], [yayinTarihi]) VALUES (7, N'Robınson Crusoe', 7, 7, 2333)
SET IDENTITY_INSERT [dbo].[eserler] OFF
GO
SET IDENTITY_INSERT [dbo].[kategoriler] ON 

INSERT [dbo].[kategoriler] ([kategoriId], [kategoriAdi]) VALUES (1, N'Dram')
INSERT [dbo].[kategoriler] ([kategoriId], [kategoriAdi]) VALUES (2, N'Polisiye')
INSERT [dbo].[kategoriler] ([kategoriId], [kategoriAdi]) VALUES (3, N'Psikoloji')
INSERT [dbo].[kategoriler] ([kategoriId], [kategoriAdi]) VALUES (4, N'Bilim-kurgu')
INSERT [dbo].[kategoriler] ([kategoriId], [kategoriAdi]) VALUES (5, N'Aşk')
INSERT [dbo].[kategoriler] ([kategoriId], [kategoriAdi]) VALUES (6, N'Edebi')
INSERT [dbo].[kategoriler] ([kategoriId], [kategoriAdi]) VALUES (7, N'Fantastik')
SET IDENTITY_INSERT [dbo].[kategoriler] OFF
GO
SET IDENTITY_INSERT [dbo].[ülkeler] ON 

INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (1, N'Turkey')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (2, N'Usa')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (3, N'Uk')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (4, N'Germany')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (5, N'Netharlands')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (6, N'France')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (7, N'Portugal')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (8, N'Spain')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (9, N'Italy')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (10, N'Iran')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (11, N'Iraq')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (12, N'Sweden')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (13, N'Norway')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (14, N'Denmark')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (15, N'Ireland')
INSERT [dbo].[ülkeler] ([ulkeId], [ulkeAdi]) VALUES (16, N'Arabia')
SET IDENTITY_INSERT [dbo].[ülkeler] OFF
GO
SET IDENTITY_INSERT [dbo].[yazarlar] ON 

INSERT [dbo].[yazarlar] ([yazarId], [yazarAdi], [yazarYasi], [yazarUlkesi]) VALUES (1, N'William Shakespeare', 20, 1)
INSERT [dbo].[yazarlar] ([yazarId], [yazarAdi], [yazarYasi], [yazarUlkesi]) VALUES (2, N'Agatha Christie', 30, 2)
INSERT [dbo].[yazarlar] ([yazarId], [yazarAdi], [yazarYasi], [yazarUlkesi]) VALUES (3, N'Barbara Cartland', 40, 3)
INSERT [dbo].[yazarlar] ([yazarId], [yazarAdi], [yazarYasi], [yazarUlkesi]) VALUES (4, N'Danielle Steel', 50, 4)
INSERT [dbo].[yazarlar] ([yazarId], [yazarAdi], [yazarYasi], [yazarUlkesi]) VALUES (5, N'J. K. Rowling', 55, 5)
INSERT [dbo].[yazarlar] ([yazarId], [yazarAdi], [yazarYasi], [yazarUlkesi]) VALUES (6, N'Akira Toriyama', 60, 6)
SET IDENTITY_INSERT [dbo].[yazarlar] OFF
GO
/****** Object:  StoredProcedure [dbo].[Tercih]    Script Date: 04/04/2023 09:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Tercih]
as
begin
SELECT eserId,eserAdi,yazarAdi,ulkeAdi,kategoriAdi,yayinTarihi FROM eserler e 
inner join yazarlar y on y.yazarId = e.yazar 
inner join ülkeler ü on ü.ulkeId = y.yazarUlkesi 
inner join kategoriler k  on k.kategoriId = e.kategori
end
GO
USE [master]
GO
ALTER DATABASE [db_library] SET  READ_WRITE 
GO
