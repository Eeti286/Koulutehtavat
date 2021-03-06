USE [master]
GO
/****** Object:  Database [KoulutusTietokanta]    Script Date: 2.5.2022 15.34.53 ******/
CREATE DATABASE [KoulutusTietokanta]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KoulutusTietokanta', FILENAME = N'C:\Users\eerik\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\KoulutusTietokanta.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KoulutusTietokanta_log', FILENAME = N'C:\Users\eerik\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\KoulutusTietokanta.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [KoulutusTietokanta] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KoulutusTietokanta].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KoulutusTietokanta] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [KoulutusTietokanta] SET ANSI_NULLS ON 
GO
ALTER DATABASE [KoulutusTietokanta] SET ANSI_PADDING ON 
GO
ALTER DATABASE [KoulutusTietokanta] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [KoulutusTietokanta] SET ARITHABORT ON 
GO
ALTER DATABASE [KoulutusTietokanta] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KoulutusTietokanta] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KoulutusTietokanta] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KoulutusTietokanta] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KoulutusTietokanta] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [KoulutusTietokanta] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [KoulutusTietokanta] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KoulutusTietokanta] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [KoulutusTietokanta] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KoulutusTietokanta] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KoulutusTietokanta] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KoulutusTietokanta] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KoulutusTietokanta] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KoulutusTietokanta] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KoulutusTietokanta] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KoulutusTietokanta] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KoulutusTietokanta] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KoulutusTietokanta] SET RECOVERY FULL 
GO
ALTER DATABASE [KoulutusTietokanta] SET  MULTI_USER 
GO
ALTER DATABASE [KoulutusTietokanta] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KoulutusTietokanta] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KoulutusTietokanta] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KoulutusTietokanta] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KoulutusTietokanta] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KoulutusTietokanta] SET QUERY_STORE = OFF
GO
USE [KoulutusTietokanta]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [KoulutusTietokanta]
GO
/****** Object:  Table [dbo].[Hekilokortti]    Script Date: 2.5.2022 15.34.53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hekilokortti](
	[OpiskelijaID] [int] IDENTITY(1,1) NOT NULL,
	[Etunimi] [varchar](50) NOT NULL,
	[Sukunimi] [varchar](50) NOT NULL,
	[Henkilotunnus] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OpiskelijaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Koe]    Script Date: 2.5.2022 15.34.53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Koe](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KoeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KoeValitaulu]    Script Date: 2.5.2022 15.34.53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KoeValitaulu](
	[KoeID] [int] NOT NULL,
	[KysymysID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kurssi]    Script Date: 2.5.2022 15.34.53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kurssi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KurssiID] [int] NOT NULL,
	[Nimi] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KurssinKokeet]    Script Date: 2.5.2022 15.34.53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KurssinKokeet](
	[KurssiID] [int] NOT NULL,
	[KoeID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kysymykset]    Script Date: 2.5.2022 15.34.53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kysymykset](
	[KysymysID] [int] IDENTITY(1,1) NOT NULL,
	[Aihe] [varchar](50) NOT NULL,
	[Kieli] [varchar](50) NOT NULL,
	[Vaikeus] [int] NOT NULL,
	[Kysymys] [varchar](500) NOT NULL,
	[Vastaus] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KysymysID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Opintorekisteri]    Script Date: 2.5.2022 15.34.53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Opintorekisteri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OpiskelijaID] [int] NOT NULL,
	[KurssiID] [int] NOT NULL,
	[SuoritusPvm] [date] NOT NULL,
	[Arvosana] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KoeValitaulu]  WITH CHECK ADD FOREIGN KEY([KysymysID])
REFERENCES [dbo].[Kysymykset] ([KysymysID])
GO
ALTER TABLE [dbo].[KurssinKokeet]  WITH CHECK ADD FOREIGN KEY([KoeID])
REFERENCES [dbo].[Koe] ([ID])
GO
ALTER TABLE [dbo].[Opintorekisteri]  WITH CHECK ADD FOREIGN KEY([KurssiID])
REFERENCES [dbo].[Kurssi] ([ID])
GO
ALTER TABLE [dbo].[Opintorekisteri]  WITH CHECK ADD FOREIGN KEY([OpiskelijaID])
REFERENCES [dbo].[Hekilokortti] ([OpiskelijaID])
GO
USE [master]
GO
ALTER DATABASE [KoulutusTietokanta] SET  READ_WRITE 
GO
