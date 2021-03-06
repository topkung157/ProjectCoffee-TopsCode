USE [master]
GO
/****** Object:  Database [coffee]    Script Date: 30/4/2563 21:25:43 ******/
CREATE DATABASE [coffee]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'coffee', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\coffee.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'coffee_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\coffee_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [coffee] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [coffee].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [coffee] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [coffee] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [coffee] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [coffee] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [coffee] SET ARITHABORT OFF 
GO
ALTER DATABASE [coffee] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [coffee] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [coffee] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [coffee] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [coffee] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [coffee] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [coffee] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [coffee] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [coffee] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [coffee] SET  DISABLE_BROKER 
GO
ALTER DATABASE [coffee] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [coffee] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [coffee] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [coffee] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [coffee] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [coffee] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [coffee] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [coffee] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [coffee] SET  MULTI_USER 
GO
ALTER DATABASE [coffee] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [coffee] SET DB_CHAINING OFF 
GO
ALTER DATABASE [coffee] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [coffee] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [coffee] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [coffee] SET QUERY_STORE = OFF
GO
USE [coffee]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 30/4/2563 21:25:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[coffee_id] [varchar](20) NULL,
	[coffee_name] [varchar](20) NULL,
	[coffee_hot] [float] NULL,
	[coffee_ice] [float] NULL,
	[coffee_smoot] [float] NULL,
	[coffee_image] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 30/4/2563 21:25:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[users_username] [varchar](50) NULL,
	[users_password] [varchar](50) NULL,
	[users_name] [varchar](50) NULL,
	[users_lastname] [varchar](50) NULL,
	[users_tel] [varchar](10) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [coffee] SET  READ_WRITE 
GO
