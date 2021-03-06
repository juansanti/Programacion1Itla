USE [master]
GO
/****** Object:  Database [Inscripciones]    Script Date: 27/10/2018 9:31:00 a. m. ******/
CREATE DATABASE [Inscripciones] ON  PRIMARY 
( NAME = N'Inscripciones', FILENAME = N'C:\SQL Server\Inscripciones.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Inscripciones_log', FILENAME = N'C:\SQL Server\Inscripciones_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Inscripciones].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Inscripciones] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Inscripciones] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Inscripciones] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Inscripciones] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Inscripciones] SET ARITHABORT OFF 
GO
ALTER DATABASE [Inscripciones] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Inscripciones] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Inscripciones] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Inscripciones] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Inscripciones] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Inscripciones] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Inscripciones] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Inscripciones] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Inscripciones] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Inscripciones] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Inscripciones] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Inscripciones] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Inscripciones] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Inscripciones] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Inscripciones] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Inscripciones] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Inscripciones] SET RECOVERY FULL 
GO
ALTER DATABASE [Inscripciones] SET  MULTI_USER 
GO
ALTER DATABASE [Inscripciones] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Inscripciones] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Inscripciones', N'ON'
GO
USE [Inscripciones]
GO
/****** Object:  Table [dbo].[Escuelas]    Script Date: 27/10/2018 9:31:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Escuelas](
	[Id] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 27/10/2018 9:31:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[EscuelaId] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 27/10/2018 9:31:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](20) NOT NULL,
	[Password] [varchar](255) NOT NULL,
	[Nombres] [varchar](80) NOT NULL,
	[Apellidos] [varchar](80) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Escuelas] ([Id], [Nombre]) VALUES (1, N'Pena Gomez')
INSERT [dbo].[Escuelas] ([Id], [Nombre]) VALUES (2, N'Juan Pablo Duarte')
INSERT [dbo].[Escuelas] ([Id], [Nombre]) VALUES (3, N'Emma Balaguer')
SET IDENTITY_INSERT [dbo].[Personas] ON 

INSERT [dbo].[Personas] ([Id], [Nombre], [Apellido], [Sexo], [EscuelaId]) VALUES (1, N'Juan', N'Santi', N'M', 3)
INSERT [dbo].[Personas] ([Id], [Nombre], [Apellido], [Sexo], [EscuelaId]) VALUES (2, N'Samuel', N'Perez', N'M', 2)
INSERT [dbo].[Personas] ([Id], [Nombre], [Apellido], [Sexo], [EscuelaId]) VALUES (3, N'Veronica', N'Castro', N'F', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Apellido], [Sexo], [EscuelaId]) VALUES (4, N'test', N'test', N'f', 1)
SET IDENTITY_INSERT [dbo].[Personas] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [Login], [Password], [Nombres], [Apellidos]) VALUES (1, N'jsanti', N'641890219989519581101501581612559294203219190239', N'Juan', N'Santi')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
USE [master]
GO
ALTER DATABASE [Inscripciones] SET  READ_WRITE 
GO
