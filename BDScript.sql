USE [master]
GO
/****** Object:  Database [miapp-r4]    Script Date: 09/05/2021 10:13:36 ******/
CREATE DATABASE [miapp-r4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'miapp-r4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\miapp-r4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'miapp-r4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\miapp-r4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [miapp-r4] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [miapp-r4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [miapp-r4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [miapp-r4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [miapp-r4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [miapp-r4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [miapp-r4] SET ARITHABORT OFF 
GO
ALTER DATABASE [miapp-r4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [miapp-r4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [miapp-r4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [miapp-r4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [miapp-r4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [miapp-r4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [miapp-r4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [miapp-r4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [miapp-r4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [miapp-r4] SET  DISABLE_BROKER 
GO
ALTER DATABASE [miapp-r4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [miapp-r4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [miapp-r4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [miapp-r4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [miapp-r4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [miapp-r4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [miapp-r4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [miapp-r4] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [miapp-r4] SET  MULTI_USER 
GO
ALTER DATABASE [miapp-r4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [miapp-r4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [miapp-r4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [miapp-r4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [miapp-r4] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [miapp-r4] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [miapp-r4] SET QUERY_STORE = OFF
GO
USE [miapp-r4]
GO
/****** Object:  Table [dbo].[PersonasBD]    Script Date: 09/05/2021 10:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonasBD](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [nchar](10) NULL,
	[FechaNacimiento] [datetime] NULL,
	[IdSexo] [int] NULL,
	[IdTipoDocumento] [int] NULL,
	[IdCarrera] [int] NULL,
	[NroDocumento] [varchar](50) NULL,
	[Calle] [varchar](50) NULL,
	[NroCasa] [varchar](50) NULL,
	[Soltero] [bit] NULL,
	[Casado] [bit] NULL,
	[Hijos] [bit] NULL,
	[CantidadHijos] [int] NULL,
 CONSTRAINT [PK_PersonasBD] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoCarreraBD]    Script Date: 09/05/2021 10:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCarreraBD](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TipoCarreraBD] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumentoBD]    Script Date: 09/05/2021 10:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumentoBD](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TipoDocumentoBD] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoSexoBD]    Script Date: 09/05/2021 10:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoSexoBD](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TipoSexoBD] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosBD]    Script Date: 09/05/2021 10:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosBD](
	[IdUsuarioBD] [int] IDENTITY(1,1) NOT NULL,
	[NombreDeUsuarioBD] [varchar](50) NOT NULL,
	[PasswordBD] [varchar](10) NOT NULL,
 CONSTRAINT [PK_UsuariosBD] PRIMARY KEY CLUSTERED 
(
	[IdUsuarioBD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PersonasBD] ON 

INSERT [dbo].[PersonasBD] ([Id], [Nombre], [Apellido], [FechaNacimiento], [IdSexo], [IdTipoDocumento], [IdCarrera], [NroDocumento], [Calle], [NroCasa], [Soltero], [Casado], [Hijos], [CantidadHijos]) VALUES (1, N'nico', N'sanchez   ', CAST(N'1996-10-14T00:00:00.000' AS DateTime), 1, 1, 1, N'39822803', N'121', N'121', 1, 1, 1, 3)
INSERT [dbo].[PersonasBD] ([Id], [Nombre], [Apellido], [FechaNacimiento], [IdSexo], [IdTipoDocumento], [IdCarrera], [NroDocumento], [Calle], [NroCasa], [Soltero], [Casado], [Hijos], [CantidadHijos]) VALUES (2, N'julio', N'laciar    ', CAST(N'1996-10-14T00:00:00.000' AS DateTime), 1, 1, 1, N'45645645', N'121', N'121', 1, 0, 0, 0)
INSERT [dbo].[PersonasBD] ([Id], [Nombre], [Apellido], [FechaNacimiento], [IdSexo], [IdTipoDocumento], [IdCarrera], [NroDocumento], [Calle], [NroCasa], [Soltero], [Casado], [Hijos], [CantidadHijos]) VALUES (3, N'nico', N'sanchez   ', CAST(N'1996-10-14T00:00:00.000' AS DateTime), 1, 1, 1, N'121', N'121', N'121', 1, 1, 1, 3)
INSERT [dbo].[PersonasBD] ([Id], [Nombre], [Apellido], [FechaNacimiento], [IdSexo], [IdTipoDocumento], [IdCarrera], [NroDocumento], [Calle], [NroCasa], [Soltero], [Casado], [Hijos], [CantidadHijos]) VALUES (4, N'ivan', N'romero    ', CAST(N'1996-11-11T00:00:00.000' AS DateTime), 1, 1, 1, N'45645645', N'151', N'alvear', 1, 0, 0, 0)
INSERT [dbo].[PersonasBD] ([Id], [Nombre], [Apellido], [FechaNacimiento], [IdSexo], [IdTipoDocumento], [IdCarrera], [NroDocumento], [Calle], [NroCasa], [Soltero], [Casado], [Hijos], [CantidadHijos]) VALUES (5, N'ignacio', N'laciar    ', CAST(N'1999-10-14T00:00:00.000' AS DateTime), 1, 1, 1, N'39465465', N'pellegrini', N'515', 0, 0, 0, 0)
INSERT [dbo].[PersonasBD] ([Id], [Nombre], [Apellido], [FechaNacimiento], [IdSexo], [IdTipoDocumento], [IdCarrera], [NroDocumento], [Calle], [NroCasa], [Soltero], [Casado], [Hijos], [CantidadHijos]) VALUES (6, N'sandra', N'ruarte    ', CAST(N'1994-05-14T00:00:00.000' AS DateTime), 2, 1, 1, N'19949889', N'saez peña', N'515', 0, 1, 0, 0)
INSERT [dbo].[PersonasBD] ([Id], [Nombre], [Apellido], [FechaNacimiento], [IdSexo], [IdTipoDocumento], [IdCarrera], [NroDocumento], [Calle], [NroCasa], [Soltero], [Casado], [Hijos], [CantidadHijos]) VALUES (7, N'victor', N'diaz      ', CAST(N'1967-06-17T00:00:00.000' AS DateTime), 2, 1, 1, N'45645646', N'referino', N'223', 0, 0, 1, 2)
SET IDENTITY_INSERT [dbo].[PersonasBD] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoCarreraBD] ON 

INSERT [dbo].[TipoCarreraBD] ([Id], [Nombre], [Descripcion]) VALUES (1, N'ing sistemas', NULL)
INSERT [dbo].[TipoCarreraBD] ([Id], [Nombre], [Descripcion]) VALUES (2, N'ing quimica', NULL)
INSERT [dbo].[TipoCarreraBD] ([Id], [Nombre], [Descripcion]) VALUES (3, N'ing mecanica', NULL)
SET IDENTITY_INSERT [dbo].[TipoCarreraBD] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoDocumentoBD] ON 

INSERT [dbo].[TipoDocumentoBD] ([Id], [Nombre], [Descripcion]) VALUES (1, N'DNI', NULL)
INSERT [dbo].[TipoDocumentoBD] ([Id], [Nombre], [Descripcion]) VALUES (2, N'Pasaporte', NULL)
INSERT [dbo].[TipoDocumentoBD] ([Id], [Nombre], [Descripcion]) VALUES (3, N'Libreta', NULL)
SET IDENTITY_INSERT [dbo].[TipoDocumentoBD] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoSexoBD] ON 

INSERT [dbo].[TipoSexoBD] ([Id], [Nombre], [Descripcion]) VALUES (1, N'masculino', NULL)
INSERT [dbo].[TipoSexoBD] ([Id], [Nombre], [Descripcion]) VALUES (2, N'femenino', NULL)
INSERT [dbo].[TipoSexoBD] ([Id], [Nombre], [Descripcion]) VALUES (3, N'otro', NULL)
SET IDENTITY_INSERT [dbo].[TipoSexoBD] OFF
GO
SET IDENTITY_INSERT [dbo].[UsuariosBD] ON 

INSERT [dbo].[UsuariosBD] ([IdUsuarioBD], [NombreDeUsuarioBD], [PasswordBD]) VALUES (1, N'ignacio', N'laciar')
INSERT [dbo].[UsuariosBD] ([IdUsuarioBD], [NombreDeUsuarioBD], [PasswordBD]) VALUES (2, N'ramiro', N'roldan')
INSERT [dbo].[UsuariosBD] ([IdUsuarioBD], [NombreDeUsuarioBD], [PasswordBD]) VALUES (3, N'ramiro', N'1234')
INSERT [dbo].[UsuariosBD] ([IdUsuarioBD], [NombreDeUsuarioBD], [PasswordBD]) VALUES (4, N'usuario5', N'123')
INSERT [dbo].[UsuariosBD] ([IdUsuarioBD], [NombreDeUsuarioBD], [PasswordBD]) VALUES (5, N'roberdeniro', N'hola')
SET IDENTITY_INSERT [dbo].[UsuariosBD] OFF
GO
/****** Object:  StoredProcedure [dbo].[GetInsetarUsuario]    Script Date: 09/05/2021 10:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetInsetarUsuario]
	@nombreUsu varchar(50), 
	@pass varchar(10)
	AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO UsuariosBD (NombreDeUsuarioBD, PasswordBD) VALUES(@nombreUsu, @pass)
END
GO
/****** Object:  StoredProcedure [dbo].[GetTiposCarrera]    Script Date: 09/05/2021 10:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetTiposCarrera]

	AS
BEGIN

	SET NOCOUNT ON;

	SELECT * from TipoCarreraBD
END
GO
/****** Object:  StoredProcedure [dbo].[GetTiposDocumentos]    Script Date: 09/05/2021 10:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetTiposDocumentos]

	AS
BEGIN

	SET NOCOUNT ON;

	SELECT * from TipoDocumentoBD
END
GO
USE [master]
GO
ALTER DATABASE [miapp-r4] SET  READ_WRITE 
GO
