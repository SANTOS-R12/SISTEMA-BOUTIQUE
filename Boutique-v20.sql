USE [master]
GO
/****** Object:  Database [boutique]    Script Date: 9/6/2020 04:53 PM ******/
CREATE DATABASE [boutique]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'boutique', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.ASUS\MSSQL\DATA\boutique.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'boutique_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.ASUS\MSSQL\DATA\boutique_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [boutique] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [boutique].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [boutique] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [boutique] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [boutique] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [boutique] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [boutique] SET ARITHABORT OFF 
GO
ALTER DATABASE [boutique] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [boutique] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [boutique] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [boutique] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [boutique] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [boutique] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [boutique] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [boutique] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [boutique] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [boutique] SET  ENABLE_BROKER 
GO
ALTER DATABASE [boutique] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [boutique] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [boutique] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [boutique] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [boutique] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [boutique] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [boutique] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [boutique] SET RECOVERY FULL 
GO
ALTER DATABASE [boutique] SET  MULTI_USER 
GO
ALTER DATABASE [boutique] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [boutique] SET DB_CHAINING OFF 
GO
ALTER DATABASE [boutique] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [boutique] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [boutique] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'boutique', N'ON'
GO
ALTER DATABASE [boutique] SET QUERY_STORE = OFF
GO
USE [boutique]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NOT NULL,
	[descripcion] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[dui] [nvarchar](9) NOT NULL,
	[nombre] [nvarchar](100) NOT NULL,
	[apellido] [nvarchar](100) NOT NULL,
	[direccion] [nvarchar](150) NOT NULL,
	[telefono] [nvarchar](9) NOT NULL,
	[estado] [nvarchar](1) NOT NULL,
	[id_saldop] [int] NOT NULL,
 CONSTRAINT [PK__cliente__D876F1BE0EAB64AC] PRIMARY KEY CLUSTERED 
(
	[dui] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pedido]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedido](
	[id_pedido] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[detalle] [nvarchar](150) NOT NULL,
	[precio] [decimal](6, 2) NOT NULL,
	[cantidad] [int] NOT NULL,
	[id_proveedor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pedido_Por_producto]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedido_Por_producto](
	[id_producto] [int] NOT NULL,
	[id_pedido] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[precio] [decimal](6, 2) NOT NULL,
	[nombrePro] [nvarchar](150) NOT NULL,
	[descripcion] [nvarchar](150) NOT NULL,
	[cantidad] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto_Por_Venta]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto_Por_Venta](
	[id_producto] [int] NOT NULL,
	[id_venta] [int] NOT NULL,
	[cant] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NOT NULL,
	[apellido] [nvarchar](100) NOT NULL,
	[direccion] [nvarchar](150) NOT NULL,
	[telefono] [nvarchar](9) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[rol] [nvarchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[saldo_P]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[saldo_P](
	[id_saldop] [int] IDENTITY(1,1) NOT NULL,
	[importe] [decimal](6, 2) NULL,
	[cobrado] [decimal](6, 2) NULL,
	[pendiente] [decimal](6, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_saldop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NOT NULL,
	[clave] [nvarchar](10) NOT NULL,
	[id_rol] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[dui] [nvarchar](9) NOT NULL,
	[id_usuario] [int] NOT NULL,
 CONSTRAINT [PK__venta__459533BF2F0295F6] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[categoria] ON 

INSERT [dbo].[categoria] ([id_categoria], [nombre], [descripcion]) VALUES (1, N'Ropa', N'ropa')
INSERT [dbo].[categoria] ([id_categoria], [nombre], [descripcion]) VALUES (2, N'Mujer', N'Ropa para Mujer')
INSERT [dbo].[categoria] ([id_categoria], [nombre], [descripcion]) VALUES (3, N'Hombre', N'Ropa para hombre')
INSERT [dbo].[categoria] ([id_categoria], [nombre], [descripcion]) VALUES (4, N'Niño', N'Ropa para niño')
INSERT [dbo].[categoria] ([id_categoria], [nombre], [descripcion]) VALUES (5, N'Bebe', N'Ropa para bebe')
INSERT [dbo].[categoria] ([id_categoria], [nombre], [descripcion]) VALUES (8, N'Sueter', N'Sueter para Hombre y Mujer')
SET IDENTITY_INSERT [dbo].[categoria] OFF
GO
INSERT [dbo].[cliente] ([dui], [nombre], [apellido], [direccion], [telefono], [estado], [id_saldop]) VALUES (N'051412300', N'Kevin', N'Elias', N'Santa Ana', N'21212222', N'A', 1)
INSERT [dbo].[cliente] ([dui], [nombre], [apellido], [direccion], [telefono], [estado], [id_saldop]) VALUES (N'051515151', N'Danny', N'Gonzalez', N'Santa Ana, el trebol', N'74747474', N'B', 8)
INSERT [dbo].[cliente] ([dui], [nombre], [apellido], [direccion], [telefono], [estado], [id_saldop]) VALUES (N'051515152', N'Daniela', N'castillo', N'San Salvador', N'74747474', N'B', 7)
INSERT [dbo].[cliente] ([dui], [nombre], [apellido], [direccion], [telefono], [estado], [id_saldop]) VALUES (N'052305230', N'Miguel', N'Dolores', N'Santa Ana', N'77441122', N'B', 10)
INSERT [dbo].[cliente] ([dui], [nombre], [apellido], [direccion], [telefono], [estado], [id_saldop]) VALUES (N'078434340', N'Marcela ', N'Anaya', N'el congo', N'70052345', N'A', 1)
INSERT [dbo].[cliente] ([dui], [nombre], [apellido], [direccion], [telefono], [estado], [id_saldop]) VALUES (N'090909090', N'Cristiano', N'Ronaldo', N'Colonia ivu', N'23456789', N'A', 1)
INSERT [dbo].[cliente] ([dui], [nombre], [apellido], [direccion], [telefono], [estado], [id_saldop]) VALUES (N'095656565', N'balmore', N'miranda', N'Colonia los naranjos', N'78903434', N'A', 1)
INSERT [dbo].[cliente] ([dui], [nombre], [apellido], [direccion], [telefono], [estado], [id_saldop]) VALUES (N'097890660', N'sergio', N'miranda', N'Colonia los pinos', N'78906745', N'A', 1)
INSERT [dbo].[cliente] ([dui], [nombre], [apellido], [direccion], [telefono], [estado], [id_saldop]) VALUES (N'151412301', N'Marvin', N'Santos', N'Ahuachapan', N'21212222', N'A', 1)
INSERT [dbo].[cliente] ([dui], [nombre], [apellido], [direccion], [telefono], [estado], [id_saldop]) VALUES (N'151412302', N'hector', N'elias', N'Santa Ana', N'74757475', N'B', 9)
INSERT [dbo].[cliente] ([dui], [nombre], [apellido], [direccion], [telefono], [estado], [id_saldop]) VALUES (N'333333333', N'ruth', N'santos', N'San miguel', N'23456798', N'A', 1)
INSERT [dbo].[cliente] ([dui], [nombre], [apellido], [direccion], [telefono], [estado], [id_saldop]) VALUES (N'999999981', N'alejandra', N'anaya', N'Santa ana', N'21212121', N'A', 1)
INSERT [dbo].[cliente] ([dui], [nombre], [apellido], [direccion], [telefono], [estado], [id_saldop]) VALUES (N'999999990', N'juan', N'murcia', N'Santa ana', N'21345678', N'A', 1)
GO
SET IDENTITY_INSERT [dbo].[pedido] ON 

INSERT [dbo].[pedido] ([id_pedido], [fecha], [detalle], [precio], [cantidad], [id_proveedor]) VALUES (1, CAST(N'1999-02-25' AS Date), N'Blusa Europea', CAST(500.00 AS Decimal(6, 2)), 1, 3)
INSERT [dbo].[pedido] ([id_pedido], [fecha], [detalle], [precio], [cantidad], [id_proveedor]) VALUES (2, CAST(N'2020-05-12' AS Date), N'Pantalon Skin', CAST(450.00 AS Decimal(6, 2)), 1, 4)
INSERT [dbo].[pedido] ([id_pedido], [fecha], [detalle], [precio], [cantidad], [id_proveedor]) VALUES (3, CAST(N'2020-05-12' AS Date), N'Short Comando', CAST(600.00 AS Decimal(6, 2)), 1, 3)
INSERT [dbo].[pedido] ([id_pedido], [fecha], [detalle], [precio], [cantidad], [id_proveedor]) VALUES (4, CAST(N'2020-05-30' AS Date), N'Sueter Europeo', CAST(350.00 AS Decimal(6, 2)), 1, 4)
INSERT [dbo].[pedido] ([id_pedido], [fecha], [detalle], [precio], [cantidad], [id_proveedor]) VALUES (5, CAST(N'2020-05-28' AS Date), N'Blusa Floral', CAST(300.00 AS Decimal(6, 2)), 1, 7)
INSERT [dbo].[pedido] ([id_pedido], [fecha], [detalle], [precio], [cantidad], [id_proveedor]) VALUES (6, CAST(N'2020-06-12' AS Date), N'Ropa para niño europeo', CAST(600.00 AS Decimal(6, 2)), 1, 8)
SET IDENTITY_INSERT [dbo].[pedido] OFF
GO
SET IDENTITY_INSERT [dbo].[producto] ON 

INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (15, CAST(10.00 AS Decimal(6, 2)), N'Jeans mujer', N'Jeans para mujer ', 20, 2)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (16, CAST(12.00 AS Decimal(6, 2)), N'Jeans hombre talla 30', N'Jeans hombre talla 30', 20, 3)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (18, CAST(12.00 AS Decimal(6, 2)), N'Jeans hombre talla 32', N'Jeans hombre talla 32', 20, 3)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (19, CAST(12.00 AS Decimal(6, 2)), N'Jeans hombre talla 34', N'Jeans hombre talla 34', 20, 3)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (21, CAST(12.00 AS Decimal(6, 2)), N'Jeans hombre talla 36', N'Jeans hombre talla 36', 20, 3)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (22, CAST(6.00 AS Decimal(6, 2)), N'Blusa manga larga', N'Blusa manga larga', 20, 2)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (24, CAST(5.00 AS Decimal(6, 2)), N'Blusa manga corta', N'Blusa manga corta', 20, 2)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (25, CAST(4.00 AS Decimal(6, 2)), N'Blusa de tirantes', N'Blusa de tirantes', 20, 2)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (26, CAST(4.00 AS Decimal(6, 2)), N'Short playero', N'Short playero', 20, 2)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (27, CAST(5.00 AS Decimal(6, 2)), N'Vestidos', N'Vestidos', 20, 2)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (29, CAST(6.00 AS Decimal(6, 2)), N'Camisa manga larga', N'Camisa manga larga', 20, 4)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (30, CAST(6.00 AS Decimal(6, 2)), N'Short para niño', N'Short para niño', 20, 4)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (31, CAST(4.00 AS Decimal(6, 2)), N'Mameluco', N'Mameluco', 10, 5)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (32, CAST(6.00 AS Decimal(6, 2)), N'Centro', N'centro', 30, 3)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (33, CAST(4.00 AS Decimal(6, 2)), N'Camisa manga larga', N'Camisa manga larga', 10, 3)
INSERT [dbo].[producto] ([id_producto], [precio], [nombrePro], [descripcion], [cantidad], [id_categoria]) VALUES (34, CAST(4.00 AS Decimal(6, 2)), N'Camisa manga corta', N'Camisa manga corta', 10, 3)
SET IDENTITY_INSERT [dbo].[producto] OFF
GO
SET IDENTITY_INSERT [dbo].[proveedor] ON 

INSERT [dbo].[proveedor] ([id_proveedor], [nombre], [apellido], [direccion], [telefono]) VALUES (3, N'Alejandro', N'Del Cid', N'San Salvador', N'24122422')
INSERT [dbo].[proveedor] ([id_proveedor], [nombre], [apellido], [direccion], [telefono]) VALUES (4, N'Marcela', N'Miranda', N'Italia', N'21097878')
INSERT [dbo].[proveedor] ([id_proveedor], [nombre], [apellido], [direccion], [telefono]) VALUES (7, N'Marvin', N'Ruiz', N'Ahuachapan', N'24130460')
INSERT [dbo].[proveedor] ([id_proveedor], [nombre], [apellido], [direccion], [telefono]) VALUES (8, N'Jessica', N'Lima', N'Las Chinamas', N'23049874')
INSERT [dbo].[proveedor] ([id_proveedor], [nombre], [apellido], [direccion], [telefono]) VALUES (9, N'Balmore', N'Miranda', N'San miguel', N'24135678')
SET IDENTITY_INSERT [dbo].[proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[roles] ON 

INSERT [dbo].[roles] ([id_rol], [rol]) VALUES (1, N'admin')
INSERT [dbo].[roles] ([id_rol], [rol]) VALUES (2, N'user')
SET IDENTITY_INSERT [dbo].[roles] OFF
GO
SET IDENTITY_INSERT [dbo].[saldo_P] ON 

INSERT [dbo].[saldo_P] ([id_saldop], [importe], [cobrado], [pendiente]) VALUES (1, CAST(0.00 AS Decimal(6, 2)), CAST(0.00 AS Decimal(6, 2)), CAST(0.00 AS Decimal(6, 2)))
INSERT [dbo].[saldo_P] ([id_saldop], [importe], [cobrado], [pendiente]) VALUES (2, CAST(10.00 AS Decimal(6, 2)), CAST(8.00 AS Decimal(6, 2)), CAST(2.00 AS Decimal(6, 2)))
INSERT [dbo].[saldo_P] ([id_saldop], [importe], [cobrado], [pendiente]) VALUES (3, CAST(25.70 AS Decimal(6, 2)), CAST(20.00 AS Decimal(6, 2)), CAST(5.70 AS Decimal(6, 2)))
INSERT [dbo].[saldo_P] ([id_saldop], [importe], [cobrado], [pendiente]) VALUES (4, CAST(10.00 AS Decimal(6, 2)), CAST(8.00 AS Decimal(6, 2)), CAST(2.00 AS Decimal(6, 2)))
INSERT [dbo].[saldo_P] ([id_saldop], [importe], [cobrado], [pendiente]) VALUES (5, CAST(25.70 AS Decimal(6, 2)), CAST(20.00 AS Decimal(6, 2)), CAST(5.70 AS Decimal(6, 2)))
INSERT [dbo].[saldo_P] ([id_saldop], [importe], [cobrado], [pendiente]) VALUES (6, CAST(20.00 AS Decimal(6, 2)), CAST(15.00 AS Decimal(6, 2)), CAST(5.00 AS Decimal(6, 2)))
INSERT [dbo].[saldo_P] ([id_saldop], [importe], [cobrado], [pendiente]) VALUES (7, CAST(50.00 AS Decimal(6, 2)), CAST(40.00 AS Decimal(6, 2)), CAST(10.00 AS Decimal(6, 2)))
INSERT [dbo].[saldo_P] ([id_saldop], [importe], [cobrado], [pendiente]) VALUES (8, CAST(70.00 AS Decimal(6, 2)), CAST(50.00 AS Decimal(6, 2)), CAST(20.00 AS Decimal(6, 2)))
INSERT [dbo].[saldo_P] ([id_saldop], [importe], [cobrado], [pendiente]) VALUES (9, CAST(28.00 AS Decimal(6, 2)), CAST(20.00 AS Decimal(6, 2)), CAST(8.00 AS Decimal(6, 2)))
INSERT [dbo].[saldo_P] ([id_saldop], [importe], [cobrado], [pendiente]) VALUES (10, CAST(25.00 AS Decimal(6, 2)), CAST(20.00 AS Decimal(6, 2)), CAST(5.00 AS Decimal(6, 2)))
INSERT [dbo].[saldo_P] ([id_saldop], [importe], [cobrado], [pendiente]) VALUES (11, CAST(15.00 AS Decimal(6, 2)), CAST(5.00 AS Decimal(6, 2)), CAST(10.00 AS Decimal(6, 2)))
SET IDENTITY_INSERT [dbo].[saldo_P] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([id_usuario], [nombre], [clave], [id_rol]) VALUES (10, N'kevin', N'0123456789', 1)
INSERT [dbo].[usuario] ([id_usuario], [nombre], [clave], [id_rol]) VALUES (11, N'marcela', N'0123456789', 1)
INSERT [dbo].[usuario] ([id_usuario], [nombre], [clave], [id_rol]) VALUES (12, N'balmore', N'0123456789', 1)
INSERT [dbo].[usuario] ([id_usuario], [nombre], [clave], [id_rol]) VALUES (13, N'marceemple', N'0123456789', 2)
INSERT [dbo].[usuario] ([id_usuario], [nombre], [clave], [id_rol]) VALUES (14, N'admin', N'0123456789', 1)
INSERT [dbo].[usuario] ([id_usuario], [nombre], [clave], [id_rol]) VALUES (15, N'marvin', N'0123456789', 1)
INSERT [dbo].[usuario] ([id_usuario], [nombre], [clave], [id_rol]) VALUES (19, N'marvinemple', N'0123456789', 2)
INSERT [dbo].[usuario] ([id_usuario], [nombre], [clave], [id_rol]) VALUES (20, N'kevinemple', N'0123456789', 2)
INSERT [dbo].[usuario] ([id_usuario], [nombre], [clave], [id_rol]) VALUES (21, N'balmoreemple', N'0123456789', 2)
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__roles__C2B79D26BF946B4F]    Script Date: 9/6/2020 04:53 PM ******/
ALTER TABLE [dbo].[roles] ADD UNIQUE NONCLUSTERED 
(
	[rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [FK__cliente__id_sald__5BE2A6F2] FOREIGN KEY([id_saldop])
REFERENCES [dbo].[saldo_P] ([id_saldop])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK__cliente__id_sald__5BE2A6F2]
GO
ALTER TABLE [dbo].[pedido]  WITH CHECK ADD FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[proveedor] ([id_proveedor])
GO
ALTER TABLE [dbo].[pedido_Por_producto]  WITH CHECK ADD FOREIGN KEY([id_pedido])
REFERENCES [dbo].[pedido] ([id_pedido])
GO
ALTER TABLE [dbo].[pedido_Por_producto]  WITH CHECK ADD FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id_producto])
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[producto_Por_Venta]  WITH CHECK ADD FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id_producto])
GO
ALTER TABLE [dbo].[producto_Por_Venta]  WITH CHECK ADD  CONSTRAINT [FK__producto___id_ve__619B8048] FOREIGN KEY([id_venta])
REFERENCES [dbo].[venta] ([id_venta])
GO
ALTER TABLE [dbo].[producto_Por_Venta] CHECK CONSTRAINT [FK__producto___id_ve__619B8048]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD FOREIGN KEY([id_rol])
REFERENCES [dbo].[roles] ([id_rol])
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK__venta__dui__6383C8BA] FOREIGN KEY([dui])
REFERENCES [dbo].[cliente] ([dui])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK__venta__dui__6383C8BA]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK__venta__id_usuari__6477ECF3] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK__venta__id_usuari__6477ECF3]
GO
/****** Object:  StoredProcedure [dbo].[DELETE_CATEGORIA]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DELETE_CATEGORIA]
(
 @id_categoria int

)
as
delete  from categoria
 where id_categoria = @id_categoria


GO
/****** Object:  StoredProcedure [dbo].[DELETE_CLIENTE]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DELETE_CLIENTE]
@dui nvarchar(9)
as 
delete  from cliente where dui = @dui

GO
/****** Object:  StoredProcedure [dbo].[DELETE_PEDIDO]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DELETE_PEDIDO]
(
 @id_pedido int

)
as
delete  from pedido
 where id_pedido = @id_pedido


GO
/****** Object:  StoredProcedure [dbo].[DELETE_PRODUCTO]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DELETE_PRODUCTO]
(
 @id_producto int
)
as
delete  from producto
 where id_producto = @id_producto


GO
/****** Object:  StoredProcedure [dbo].[DELETE_PROVEEDOR]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DELETE_PROVEEDOR]
(
 @id_proveedor int
)
as
delete  from proveedor
 where id_proveedor = @id_proveedor


GO
/****** Object:  StoredProcedure [dbo].[DELETE_ROLES]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DELETE_ROLES]
(
 @id_rol int

)
as
delete  from roles
 where id_rol = @id_rol

GO
/****** Object:  StoredProcedure [dbo].[DELETE_SALDOP]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DELETE_SALDOP]
(
 @id_saldop int

)
as
delete  from saldo_P
 where id_saldop = @id_saldop


GO
/****** Object:  StoredProcedure [dbo].[DELETE_USUARIO]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DELETE_USUARIO]
(
 @id_usuario int


)
as
delete  from usuario
 where id_usuario = @id_usuario


GO
/****** Object:  StoredProcedure [dbo].[DELETE_VENTA]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DELETE_VENTA]
(
 @id_venta int

)
as
delete  from venta
 where id_venta = @id_venta


GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_CATEGORIA]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[INSERTAR_CATEGORIA]
(
 @nombre nvarchar(100),
 @descripcion nvarchar(150)
)
as
begin
 insert into categoria([nombre], [descripcion]) values (@nombre, @descripcion)
end

GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_CLIENTE]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[INSERTAR_CLIENTE]
(
 @dui nvarchar(9),
 @nombre nvarchar(100),
 @apellido nvarchar(100),
 @direccion nvarchar(150),
 @telefono nvarchar(9),
 @estado nvarchar(1),
 @id_saldop int
)
as
begin
 insert into cliente([dui], [nombre], [apellido],[direccion],[telefono],[estado],[id_saldop])  values (@dui, @nombre, @apellido,@direccion, @telefono,@estado, @id_saldop)
end

GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_PEDIDO]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[INSERTAR_PEDIDO]
(

 @fecha date,
 @detalle nvarchar(150),
 @precio decimal(6,2),
 @cantidad int,
 @id_proveedor int

)
as
begin
 insert into pedido([fecha], [detalle],[precio],[cantidad],[id_proveedor]) values (@fecha, @detalle,@precio, @cantidad, @id_proveedor)
end

GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_PRODUCTO]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[INSERTAR_PRODUCTO]
(

 @precio decimal(6,2),
 @nombrePro nvarchar(150),
 @descripcion nvarchar(25),
 @cantidad int,
 @id_categoria int

)
as
begin
  insert into producto([precio],[nombrePro],[descripcion],[cantidad],[id_categoria]) 
  values (@precio,@nombrePro, @descripcion,@cantidad, @id_categoria)
end

GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_PROVEEDOR]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[INSERTAR_PROVEEDOR]
(
 
 @nombre nvarchar(100),
 @apellido nvarchar(100),
 @direccion nvarchar(150),
 @telefono nvarchar(9)

)
as
begin
 insert into proveedor([nombre],[apellido],[direccion],[telefono]) values (@nombre, @apellido, @direccion,@telefono)
end

GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_ROLES]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[INSERTAR_ROLES]
(
 
 @rol nvarchar


)
as
begin
 insert into roles([rol]) values (@rol)
end

GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_saldoP]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[INSERTAR_saldoP]
(
 
 @importe decimal(6,2),
 @cobrado decimal(6,2),
 @pendiente decimal (6,2)


)
as
begin
 insert into saldo_P([importe],[cobrado],[pendiente]) values (@importe,@cobrado,@pendiente)
end

GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_USUARIO]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[INSERTAR_USUARIO]
(
 
 @nombre nvarchar(100),
 @clave nvarchar(10),
 @id_rol int


)
as
begin
 insert into usuario([nombre],[clave],[id_rol]) values (@nombre,@clave,@id_rol)
end

GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_VENTA]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[INSERTAR_VENTA]
(
 
 @fecha date,
 @dui int,
 @id_usuario int


)
as
begin
 insert into venta([fecha],[dui],[id_usuario]) values (@fecha,@dui,@id_usuario)
end

GO
/****** Object:  StoredProcedure [dbo].[REPORTE_CLIENTES]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[REPORTE_CLIENTES]
AS
SELECT * FROM cliente

GO
/****** Object:  StoredProcedure [dbo].[REPORTE_pedido_proveedores]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[REPORTE_pedido_proveedores]
AS
SELECT id_pedido,fecha, detalle, precio,cantidad,nombre,apellido FROM pedido,proveedor

GO
/****** Object:  StoredProcedure [dbo].[REPORTE_PROVEEDORES]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[REPORTE_PROVEEDORES]
AS
SELECT * FROM proveedor

GO
/****** Object:  StoredProcedure [dbo].[REPORTE_venta]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[REPORTE_venta]
AS
select descripcion,precio,fecha,dui,id_usuario from producto,venta

GO
/****** Object:  StoredProcedure [dbo].[SELEC_CATNOMBRE]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELEC_CATNOMBRE] AS
SELECT categoria.nombre FROM categoria 
GO
/****** Object:  StoredProcedure [dbo].[SELECT_CATEGORIA_FULL]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECT_CATEGORIA_FULL]
AS
SELECT nombre FROM categoria

GO
/****** Object:  StoredProcedure [dbo].[SELECT_CLIENTE_FULL]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECT_CLIENTE_FULL]
AS
SELECT dui, nombre, apellido, direccion, telefono, estado, id_saldop FROM cliente

GO
/****** Object:  StoredProcedure [dbo].[SELECT_MORA_USUARIO]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECT_MORA_USUARIO]
AS
SELECT nombre,apellido,dui,pendiente from cliente inner join saldo_P on cliente.id_saldop=saldo_P.id_saldop where estado= 'B'

GO
/****** Object:  StoredProcedure [dbo].[SELECT_PEDIDO_FULL]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECT_PEDIDO_FULL]
AS
SELECT id_pedido,proveedor.id_proveedor ,proveedor.nombre,precio,detalle,cantidad, fecha  FROM pedido INNER JOIN proveedor on pedido.id_proveedor= proveedor.id_proveedor 

GO
/****** Object:  StoredProcedure [dbo].[SELECT_pedido_Por_producto_FULL]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECT_pedido_Por_producto_FULL]
AS
SELECT id_producto, id_pedido FROM pedido_Por_producto

GO
/****** Object:  StoredProcedure [dbo].[SELECT_PRODUCTO_FULL]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECT_PRODUCTO_FULL]
AS

SELECT id_producto, precio,nombrePro,producto.descripcion,cantidad, categoria.id_categoria,categoria.nombre    FROM producto INNER JOIN categoria on producto.id_categoria = categoria.id_categoria

GO
/****** Object:  StoredProcedure [dbo].[SELECT_producto_Por_Venta_FULL]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECT_producto_Por_Venta_FULL]
AS
SELECT id_producto, id_venta FROM producto_Por_Venta

GO
/****** Object:  StoredProcedure [dbo].[SELECT_PROVEEDOR_FULL]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECT_PROVEEDOR_FULL]
AS
SELECT id_proveedor, nombre, apellido, direccion, telefono FROM proveedor

GO
/****** Object:  StoredProcedure [dbo].[SELECT_ROLES_FULL]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECT_ROLES_FULL]
AS
SELECT id_rol, rol FROM roles

GO
/****** Object:  StoredProcedure [dbo].[SELECT_saldo_P_FULL]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECT_saldo_P_FULL]
AS
SELECT id_saldop, importe, cobrado, pendiente FROM saldo_P

GO
/****** Object:  StoredProcedure [dbo].[SELECT_USUARIO_FULL]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECT_USUARIO_FULL]
AS
SELECT id_usuario, nombre, clave, roles.id_rol,roles.rol FROM usuario INNER JOIN roles on usuario.id_rol = roles.id_rol

GO
/****** Object:  StoredProcedure [dbo].[SELECT_VENTA_FULL]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECT_VENTA_FULL]
AS
SELECT id_venta, fecha, dui, id_usuario FROM venta

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_CATEGORIA]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UPDATE_CATEGORIA]
(
 @id_categoria int,
 @nombre nvarchar(100),
 @descripcion nvarchar(150)

) 
as
update categoria set 
nombre = @nombre, 
descripcion = @descripcion
where id_categoria = @id_categoria

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_CLIENTE]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UPDATE_CLIENTE]
(
 @dui nvarchar(9),
 @nombre nvarchar(100),
 @apellido nvarchar(100),
 @direccion nvarchar(150),
 @telefono nvarchar(9),
 @estado nvarchar(1),
 @id_saldop int

) 
as
update cliente set 
nombre = @nombre, 
apellido = @apellido, 
direccion = @direccion, 
telefono = @telefono, 
estado = @estado, 
id_saldop = @id_saldop
where dui = @dui

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_PEDIDO]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UPDATE_PEDIDO]
(
 @id_pedido int,
 @fecha date,
 @detalle nvarchar(150),
 @precio decimal(6,2),
 @cantidad int,
 @id_proveedor int

) 
as
update pedido set 
fecha = @fecha,
detalle =  @detalle, 
precio =  @precio, 
cantidad =  @cantidad, 
id_proveedor =  @id_proveedor
where id_pedido =  @id_pedido

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_PRODUCTO]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UPDATE_PRODUCTO]
(
 @id_producto int,
 @precio decimal(6,2),
 @nombrePro nvarchar(150),
 @descripcion nvarchar(150),
 @cantidad int,
 @id_categoria int

) 
as
update producto set 
precio =  @precio,
nombrePro = @nombrePro,
descripcion =  @descripcion, 
cantidad =  @cantidad, 
id_categoria =  @id_categoria
where id_producto =  @id_producto

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_PROVEEDOR]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UPDATE_PROVEEDOR]
(
 @id_proveedor int,
 @nombre nvarchar(100),
 @apellido nvarchar(100),
 @direccion nvarchar(150),
 @telefono nvarchar(9)

) 
as
update proveedor set 
nombre =  @nombre, 
apellido =  @apellido, 
direccion =  @direccion, 
telefono =  @telefono 
where id_proveedor =  @id_proveedor

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_ROLES]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UPDATE_ROLES]
(
 @id_rol int,
 @rol nvarchar(5)
) 
as
update roles set 
rol =  @rol
where id_rol =  @id_rol

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_SALDOP]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UPDATE_SALDOP]
(
 @id_saldop int,
 @importe decimal(6,2),
 @cobrado decimal(6,2),
 @pendiente decimal(6,2)
) 
as
update saldo_P set 
importe =  @importe,
cobrado =  @cobrado,
pendiente =  @pendiente
where id_saldop =  @id_saldop

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_USUARIO]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UPDATE_USUARIO]
(
 @id_usuario int,
 @nombre nvarchar(100),
 @clave nvarchar(10),
 @id_rol int
) 
as
update usuario set 
nombre =  @nombre, 
clave =  @clave, 
id_rol =  @id_rol
where id_usuario =  @id_usuario

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_VENTA]    Script Date: 9/6/2020 04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UPDATE_VENTA]
(
 @id_venta int,
 @fecha date,


 @dui int,
 @id_usuario int
) 
as
update venta set
fecha =  @fecha,

dui =  @dui, 
id_usuario =  @id_usuario
where id_venta =  @id_venta

GO
USE [master]
GO
ALTER DATABASE [boutique] SET  READ_WRITE 
GO
