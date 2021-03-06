USE [master]
GO
/****** Object:  Database [Astronauttien henkilörekisteri ]    Script Date: 25.4.2022 12.11.58 ******/
CREATE DATABASE [Astronauttien henkilörekisteri ]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Astronauttien henkilörekisteri', FILENAME = N'C:\Users\eerik\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\Astronauttien henkilörekisteri .mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Astronauttien henkilörekisteri _log', FILENAME = N'C:\Users\eerik\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\Astronauttien henkilörekisteri .ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Astronauttien henkilörekisteri ].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET ANSI_NULLS ON 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET ANSI_PADDING ON 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET ARITHABORT ON 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET RECOVERY FULL 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET  MULTI_USER 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET QUERY_STORE = OFF
GO
USE [Astronauttien henkilörekisteri ]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Astronauttien henkilörekisteri ]
GO
/****** Object:  Table [dbo].[Astronautit]    Script Date: 25.4.2022 12.11.58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Astronautit](
	[AstronautitID] [int] IDENTITY(1,1) NOT NULL,
	[Etunimi] [nchar](50) NULL,
	[Sukunimi] [nchar](50) NULL,
	[Syntyma-aika] [date] NULL,
	[Avaruudessa vietetty aika] [tinyint] NULL,
	[Kansallisuus] [nchar](50) NULL,
	[Sukupuoli] [nchar](50) NULL,
 CONSTRAINT [PK_Astronautit] PRIMARY KEY CLUSTERED 
(
	[AstronautitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View]    Script Date: 25.4.2022 12.11.58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View]
	AS SELECT * FROM [Astronautit]
GO
/****** Object:  Table [dbo].[AstronautitTehtavat valitaulu]    Script Date: 25.4.2022 12.11.58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AstronautitTehtavat valitaulu](
	[AstronautitTehtavaID] [int] IDENTITY(1,1) NOT NULL,
	[AstronautitID] [int] NULL,
	[TehtavatID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AstronautitTehtavaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kansallisuus]    Script Date: 25.4.2022 12.11.58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kansallisuus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Kansallisuus] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sukupuoli]    Script Date: 25.4.2022 12.11.58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sukupuoli](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Sukupuoli] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tehtavat]    Script Date: 25.4.2022 12.11.58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tehtavat](
	[TehtavatID] [int] IDENTITY(1,1) NOT NULL,
	[tehtavat] [nchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[TehtavatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Astronauttien henkilörekisteri ] SET  READ_WRITE 
GO
