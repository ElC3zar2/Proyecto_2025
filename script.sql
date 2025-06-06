USE [master]
GO
/****** Object:  Database [proyecto]    Script Date: 17/05/2025 12:20:20 ******/
CREATE DATABASE [proyecto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'proyecto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\proyecto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'proyecto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\proyecto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [proyecto] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [proyecto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [proyecto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [proyecto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [proyecto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [proyecto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [proyecto] SET ARITHABORT OFF 
GO
ALTER DATABASE [proyecto] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [proyecto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [proyecto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [proyecto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [proyecto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [proyecto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [proyecto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [proyecto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [proyecto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [proyecto] SET  ENABLE_BROKER 
GO
ALTER DATABASE [proyecto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [proyecto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [proyecto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [proyecto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [proyecto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [proyecto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [proyecto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [proyecto] SET RECOVERY FULL 
GO
ALTER DATABASE [proyecto] SET  MULTI_USER 
GO
ALTER DATABASE [proyecto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [proyecto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [proyecto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [proyecto] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [proyecto] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [proyecto] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'proyecto', N'ON'
GO
ALTER DATABASE [proyecto] SET QUERY_STORE = ON
GO
ALTER DATABASE [proyecto] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [proyecto]
GO
/****** Object:  Table [dbo].[alimento_usuario]    Script Date: 17/05/2025 12:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alimento_usuario](
	[id_alimento] [int] IDENTITY(1,1) NOT NULL,
	[fk_id_usuario] [int] NULL,
	[nombre_alimento] [varchar](30) NULL,
	[cantidad] [int] NULL,
	[carbohidratos] [float] NULL,
	[proteinas] [float] NULL,
	[grasas] [float] NULL,
	[calorias] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_alimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[calculo]    Script Date: 17/05/2025 12:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[calculo](
	[id_calculo] [int] IDENTITY(1,1) NOT NULL,
	[fk_id_usuario] [int] NULL,
	[IMC] [float] NULL,
	[TDEE] [float] NULL,
	[comp_calorias] [float] NULL,
	[macro_nutrientes] [varchar](100) NULL,
	[alerta] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_calculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 17/05/2025 12:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_completo] [varchar](60) NULL,
	[edad] [int] NULL,
	[genero] [varchar](9) NULL,
	[departamento] [varchar](30) NULL,
	[municipio] [varchar](30) NULL,
	[peso] [int] NULL,
	[altura] [int] NULL,
	[actividad_fisica] [varchar](10) NULL,
	[ocupacion] [varchar](20) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[usuario] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[alimento_usuario]  WITH CHECK ADD FOREIGN KEY([fk_id_usuario])
REFERENCES [dbo].[usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[calculo]  WITH CHECK ADD FOREIGN KEY([fk_id_usuario])
REFERENCES [dbo].[usuario] ([id_usuario])
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarAlimento]    Script Date: 17/05/2025 12:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarAlimento]
    @fk_id_usuario INT,
    @nombre_alimento VARCHAR(50),
    @cantidad int,
    @carbohidratos FLOAT ,
    @proteinas FLOAT ,
    @grasas FLOAT ,
    @calorias FLOAT 
AS
BEGIN
    INSERT INTO alimento_usuario (fk_id_usuario, nombre_alimento, cantidad, carbohidratos, proteinas, grasas, calorias)
    VALUES (@fk_id_usuario, @nombre_alimento, @cantidad, @carbohidratos, @proteinas, @grasas, @calorias)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarUsuario]    Script Date: 17/05/2025 12:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarUsuario]
    @nombre_completo VARCHAR(60),
    @edad INT,
    @genero VARCHAR(9),
    @departamento VARCHAR(30),
    @municipio VARCHAR(30),
    @peso INT,
    @altura INT,
    @actividad_fisica VARCHAR(10),
    @ocupacion VARCHAR(20)
AS
BEGIN
    INSERT INTO usuario (nombre_completo, edad, genero, departamento, municipio, peso, altura, actividad_fisica, ocupacion)
    VALUES (@nombre_completo, @edad, @genero, @departamento, @municipio, @peso, @altura, @actividad_fisica, @ocupacion)
END;
GO
USE [master]
GO
ALTER DATABASE [proyecto] SET  READ_WRITE 
GO
