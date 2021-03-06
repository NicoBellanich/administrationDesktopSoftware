USE [master]
GO
/****** Object:  Database [axionF]    Script Date: 11/14/2018 19:11:15 ******/
CREATE DATABASE [axionF] ON  PRIMARY 
( NAME = N'axionF', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\axionF.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'axionF_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\axionF_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [axionF] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [axionF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [axionF] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [axionF] SET ANSI_NULLS OFF
GO
ALTER DATABASE [axionF] SET ANSI_PADDING OFF
GO
ALTER DATABASE [axionF] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [axionF] SET ARITHABORT OFF
GO
ALTER DATABASE [axionF] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [axionF] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [axionF] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [axionF] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [axionF] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [axionF] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [axionF] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [axionF] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [axionF] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [axionF] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [axionF] SET  DISABLE_BROKER
GO
ALTER DATABASE [axionF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [axionF] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [axionF] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [axionF] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [axionF] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [axionF] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [axionF] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [axionF] SET  READ_WRITE
GO
ALTER DATABASE [axionF] SET RECOVERY SIMPLE
GO
ALTER DATABASE [axionF] SET  MULTI_USER
GO
ALTER DATABASE [axionF] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [axionF] SET DB_CHAINING OFF
GO
USE [axionF]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 11/14/2018 19:11:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] NOT NULL,
	[nombre] [nchar](10) NOT NULL,
	[contraseña] [nchar](10) NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[usuario] ([id], [nombre], [contraseña]) VALUES (1, N'admin     ', N'admin     ')
INSERT [dbo].[usuario] ([id], [nombre], [contraseña]) VALUES (2, N'cajero1   ', N'cajero1   ')
INSERT [dbo].[usuario] ([id], [nombre], [contraseña]) VALUES (3, N'nico      ', N'nico      ')
/****** Object:  Table [dbo].[tipoProducto]    Script Date: 11/14/2018 19:11:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoProducto](
	[id] [int] NOT NULL,
	[descripcion] [nchar](30) NULL,
 CONSTRAINT [PK_tipoProducto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tipoProducto] ([id], [descripcion]) VALUES (1, N'Menu                          ')
INSERT [dbo].[tipoProducto] ([id], [descripcion]) VALUES (2, N'Despensa                      ')
INSERT [dbo].[tipoProducto] ([id], [descripcion]) VALUES (3, N'Heladera                      ')
/****** Object:  Table [dbo].[tipoFactura]    Script Date: 11/14/2018 19:11:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoFactura](
	[idTipo] [int] NOT NULL,
	[nombre] [nchar](1) NULL,
 CONSTRAINT [PK_tipoFactura] PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tipoFactura] ([idTipo], [nombre]) VALUES (1, N'A')
INSERT [dbo].[tipoFactura] ([idTipo], [nombre]) VALUES (2, N'B')
INSERT [dbo].[tipoFactura] ([idTipo], [nombre]) VALUES (3, N'C')
/****** Object:  Table [dbo].[tipoDni]    Script Date: 11/14/2018 19:11:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoDni](
	[id] [int] NOT NULL,
	[descripcion] [nchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tipoDni] ([id], [descripcion]) VALUES (1, N'Libreta de Enrolamiento                           ')
INSERT [dbo].[tipoDni] ([id], [descripcion]) VALUES (2, N'DNI                                               ')
INSERT [dbo].[tipoDni] ([id], [descripcion]) VALUES (3, N'Visa                                              ')
/****** Object:  Table [dbo].[proveedor]    Script Date: 11/14/2018 19:11:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[proveedor](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [char](50) NULL,
	[domicilio] [char](50) NULL,
	[telefono] [int] NULL,
	[idBarrio] [int] NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[proveedor] ON
INSERT [dbo].[proveedor] ([idProveedor], [nombre], [domicilio], [telefono], [idBarrio]) VALUES (1, N'Aquiles                                           ', N'Carcano                                           ', 111222333, 1)
INSERT [dbo].[proveedor] ([idProveedor], [nombre], [domicilio], [telefono], [idBarrio]) VALUES (3, N'Romulo                                            ', N'Laguna Azul                                       ', 2123, 1)
INSERT [dbo].[proveedor] ([idProveedor], [nombre], [domicilio], [telefono], [idBarrio]) VALUES (5, N'Valtico                                           ', N'TABOADA                                           ', 111, 2)
SET IDENTITY_INSERT [dbo].[proveedor] OFF
/****** Object:  Table [dbo].[producto]    Script Date: 11/14/2018 19:11:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[producto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[idTipoProducto] [int] NOT NULL,
	[precioVentaUnit] [int] NULL,
	[stock] [int] NULL,
	[nombre] [char](50) NULL,
	[precioCompraUnit] [int] NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC,
	[idTipoProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[producto] ON
INSERT [dbo].[producto] ([idProducto], [idTipoProducto], [precioVentaUnit], [stock], [nombre], [precioCompraUnit]) VALUES (6, 1, 60, 97, N'Coca-Cola                                         ', 40)
INSERT [dbo].[producto] ([idProducto], [idTipoProducto], [precioVentaUnit], [stock], [nombre], [precioCompraUnit]) VALUES (8, 2, 42, 148, N'Seven-Up                                          ', 12)
INSERT [dbo].[producto] ([idProducto], [idTipoProducto], [precioVentaUnit], [stock], [nombre], [precioCompraUnit]) VALUES (10, 2, 65, 110, N'Pepsi                                             ', 45)
INSERT [dbo].[producto] ([idProducto], [idTipoProducto], [precioVentaUnit], [stock], [nombre], [precioCompraUnit]) VALUES (12, 3, 30, 50, N'Helados Glups                                     ', 15)
SET IDENTITY_INSERT [dbo].[producto] OFF
/****** Object:  Table [dbo].[pedido]    Script Date: 11/14/2018 19:11:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedido](
	[idPedido] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[estado] [nchar](10) NULL,
	[usuario] [nchar](10) NULL,
	[total] [int] NULL,
 CONSTRAINT [PK_pedido_1] PRIMARY KEY CLUSTERED 
(
	[idPedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[pedido] ON
INSERT [dbo].[pedido] ([idPedido], [fecha], [estado], [usuario], [total]) VALUES (14, CAST(0xF03E0B00 AS Date), N'Terminado ', N'admin     ', 129)
INSERT [dbo].[pedido] ([idPedido], [fecha], [estado], [usuario], [total]) VALUES (15, CAST(0xF03E0B00 AS Date), N'En Curso  ', N'admin     ', 42)
INSERT [dbo].[pedido] ([idPedido], [fecha], [estado], [usuario], [total]) VALUES (16, CAST(0xF03E0B00 AS Date), N'Terminado ', N'admin     ', 727)
INSERT [dbo].[pedido] ([idPedido], [fecha], [estado], [usuario], [total]) VALUES (17, CAST(0xF03E0B00 AS Date), N'Cancelado ', N'admin     ', 3185)
INSERT [dbo].[pedido] ([idPedido], [fecha], [estado], [usuario], [total]) VALUES (18, CAST(0xF03E0B00 AS Date), N'Terminado ', N'admin     ', 3030)
INSERT [dbo].[pedido] ([idPedido], [fecha], [estado], [usuario], [total]) VALUES (19, CAST(0xF03E0B00 AS Date), N'En Curso  ', N'admin     ', 77)
INSERT [dbo].[pedido] ([idPedido], [fecha], [estado], [usuario], [total]) VALUES (20, CAST(0xF03E0B00 AS Date), N'En Curso  ', N'admin     ', 1500)
INSERT [dbo].[pedido] ([idPedido], [fecha], [estado], [usuario], [total]) VALUES (21, CAST(0xF23E0B00 AS Date), N'Cancelado ', N'admin     ', 1380)
INSERT [dbo].[pedido] ([idPedido], [fecha], [estado], [usuario], [total]) VALUES (22, CAST(0xF33E0B00 AS Date), N'Terminado ', N'admin     ', 420)
SET IDENTITY_INSERT [dbo].[pedido] OFF
/****** Object:  Table [dbo].[facturas]    Script Date: 11/14/2018 19:11:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facturas](
	[idFactura] [int] NOT NULL,
	[tipo] [nchar](1) NULL,
	[fecha] [date] NULL,
	[total] [int] NULL,
	[usuario] [nchar](10) NULL,
 CONSTRAINT [PK_facturas] PRIMARY KEY CLUSTERED 
(
	[idFactura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (2, N'A', CAST(0x8B3E0B00 AS Date), 650, N'cajero1   ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (3, N'A', CAST(0xAA3E0B00 AS Date), 270, N'cajero1   ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (4, N'B', CAST(0xE63E0B00 AS Date), 207, N'cajero1   ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (5, N'A', CAST(0xE63E0B00 AS Date), 132, N'cajero1   ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (6, N'A', CAST(0xE73E0B00 AS Date), 500, N'cajero1   ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (7, N'A', CAST(0xEE3E0B00 AS Date), 165, N'admin     ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (8, N'A', CAST(0xEE3E0B00 AS Date), 144, N'admin     ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (9, N'A', CAST(0xEE3E0B00 AS Date), 180, N'cajero1   ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (10, N'A', CAST(0xEE3E0B00 AS Date), 2470, N'admin     ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (11, N'A', CAST(0xEF3E0B00 AS Date), 110, N'admin     ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (12, N'A', CAST(0xF03E0B00 AS Date), 847, N'admin     ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (13, N'B', CAST(0xF03E0B00 AS Date), 125, N'admin     ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (14, N'B', CAST(0xF03E0B00 AS Date), 132, N'admin     ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (15, N'C', CAST(0xF03E0B00 AS Date), 197, N'admin     ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (16, N'A', CAST(0xF23E0B00 AS Date), 60, N'admin     ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (17, N'C', CAST(0xF23E0B00 AS Date), 120, N'admin     ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (18, N'A', CAST(0xF33E0B00 AS Date), 150, N'admin     ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (19, N'A', CAST(0xF33E0B00 AS Date), 72, N'nico      ')
INSERT [dbo].[facturas] ([idFactura], [tipo], [fecha], [total], [usuario]) VALUES (20, N'A', CAST(0xF33E0B00 AS Date), 65, N'nico      ')
/****** Object:  Table [dbo].[empleado]    Script Date: 11/14/2018 19:11:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleado](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [char](50) NULL,
	[apellido] [char](50) NULL,
	[idTipoDNI] [int] NULL,
	[nroDNI] [int] NULL,
	[domicilio] [char](50) NULL,
	[idBarrio] [int] NULL,
	[salario] [int] NULL,
 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[empleado] ON
INSERT [dbo].[empleado] ([idEmpleado], [nombre], [apellido], [idTipoDNI], [nroDNI], [domicilio], [idBarrio], [salario]) VALUES (1, N'Joaquin                                           ', N'Mel                                               ', 2, 134687597, N'Laberne 1234                                      ', 1, 12222)
INSERT [dbo].[empleado] ([idEmpleado], [nombre], [apellido], [idTipoDNI], [nroDNI], [domicilio], [idBarrio], [salario]) VALUES (2, N'German                                            ', N'carletti                                          ', 2, 45657894, N'Magul 111                                         ', 2, 11111)
INSERT [dbo].[empleado] ([idEmpleado], [nombre], [apellido], [idTipoDNI], [nroDNI], [domicilio], [idBarrio], [salario]) VALUES (4, N'Nico                                              ', N'Bellanich                                         ', 2, 40248767, N'Traful 757                                        ', 2, 20000)
INSERT [dbo].[empleado] ([idEmpleado], [nombre], [apellido], [idTipoDNI], [nroDNI], [domicilio], [idBarrio], [salario]) VALUES (5, N'Juan                                              ', N'Gutierrez                                         ', 3, 12345432, N'Lomas casa A                                      ', 3, 1)
SET IDENTITY_INSERT [dbo].[empleado] OFF
/****** Object:  Table [dbo].[detalleXfactura]    Script Date: 11/14/2018 19:11:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalleXfactura](
	[idfactura] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precioventa] [decimal](8, 2) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (2, 10, 10, CAST(650.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (3, 9, 10, CAST(150.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (3, 8, 10, CAST(120.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (5, 8, 11, CAST(132.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (6, 8, 1, CAST(12.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (7, 9, 11, CAST(165.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (8, 8, 12, CAST(144.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (9, 9, 12, CAST(180.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (10, 10, 38, CAST(2470.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (12, 8, 11, CAST(132.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (12, 10, 11, CAST(715.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (13, 6, 1, CAST(60.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (13, 10, 1, CAST(65.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (14, 8, 11, CAST(132.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (15, 10, 1, CAST(65.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (15, 8, 11, CAST(132.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (16, 12, 2, CAST(60.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (17, 12, 2, CAST(60.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (17, 6, 1, CAST(60.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (18, 12, 5, CAST(150.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (19, 6, 1, CAST(60.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (19, 8, 1, CAST(12.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (20, 10, 1, CAST(65.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (11, 10, 1, CAST(65.00 AS Decimal(8, 2)))
INSERT [dbo].[detalleXfactura] ([idfactura], [idproducto], [cantidad], [precioventa]) VALUES (11, 9, 3, CAST(45.00 AS Decimal(8, 2)))
/****** Object:  Table [dbo].[detallePedido]    Script Date: 11/14/2018 19:11:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detallePedido](
	[numeroDetalle] [int] IDENTITY(1,1) NOT NULL,
	[idPedido] [int] NOT NULL,
	[idProducto] [int] NULL,
	[cantidad] [int] NULL,
	[precio] [int] NULL,
	[subtotal] [int] NULL,
 CONSTRAINT [PK_detallePedido] PRIMARY KEY CLUSTERED 
(
	[numeroDetalle] ASC,
	[idPedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[detallePedido] ON
INSERT [dbo].[detallePedido] ([numeroDetalle], [idPedido], [idProducto], [cantidad], [precio], [subtotal]) VALUES (29, 15, 8, 1, 12, 12)
INSERT [dbo].[detallePedido] ([numeroDetalle], [idPedido], [idProducto], [cantidad], [precio], [subtotal]) VALUES (30, 15, 9, 2, 15, 30)
INSERT [dbo].[detallePedido] ([numeroDetalle], [idPedido], [idProducto], [cantidad], [precio], [subtotal]) VALUES (31, 16, 8, 1, 12, 12)
INSERT [dbo].[detallePedido] ([numeroDetalle], [idPedido], [idProducto], [cantidad], [precio], [subtotal]) VALUES (32, 16, 10, 11, 65, 715)
INSERT [dbo].[detallePedido] ([numeroDetalle], [idPedido], [idProducto], [cantidad], [precio], [subtotal]) VALUES (33, 17, 10, 13, 65, 845)
INSERT [dbo].[detallePedido] ([numeroDetalle], [idPedido], [idProducto], [cantidad], [precio], [subtotal]) VALUES (34, 17, 9, 156, 15, 2340)
INSERT [dbo].[detallePedido] ([numeroDetalle], [idPedido], [idProducto], [cantidad], [precio], [subtotal]) VALUES (35, 18, 10, 12, 65, 780)
INSERT [dbo].[detallePedido] ([numeroDetalle], [idPedido], [idProducto], [cantidad], [precio], [subtotal]) VALUES (36, 18, 9, 150, 15, 2250)
INSERT [dbo].[detallePedido] ([numeroDetalle], [idPedido], [idProducto], [cantidad], [precio], [subtotal]) VALUES (37, 19, 8, 1, 12, 12)
INSERT [dbo].[detallePedido] ([numeroDetalle], [idPedido], [idProducto], [cantidad], [precio], [subtotal]) VALUES (38, 19, 10, 1, 65, 65)
INSERT [dbo].[detallePedido] ([numeroDetalle], [idPedido], [idProducto], [cantidad], [precio], [subtotal]) VALUES (39, 20, 9, 100, 15, 1500)
INSERT [dbo].[detallePedido] ([numeroDetalle], [idPedido], [idProducto], [cantidad], [precio], [subtotal]) VALUES (40, 21, 10, 12, 65, 780)
INSERT [dbo].[detallePedido] ([numeroDetalle], [idPedido], [idProducto], [cantidad], [precio], [subtotal]) VALUES (41, 21, 12, 20, 30, 600)
INSERT [dbo].[detallePedido] ([numeroDetalle], [idPedido], [idProducto], [cantidad], [precio], [subtotal]) VALUES (42, 22, 12, 14, 30, 420)
SET IDENTITY_INSERT [dbo].[detallePedido] OFF
/****** Object:  Table [dbo].[cierreCaja]    Script Date: 11/14/2018 19:11:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cierreCaja](
	[usuarioSaliente] [nchar](10) NOT NULL,
	[usuarioEntrante] [nchar](10) NOT NULL,
	[cierreCaja] [int] NULL,
	[cierreCajaCalculado] [int] NULL,
	[fecha] [date] NULL,
	[hora] [time](7) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[cierreCaja] ([usuarioSaliente], [usuarioEntrante], [cierreCaja], [cierreCajaCalculado], [fecha], [hora]) VALUES (N'admin     ', N'cajero1   ', 309, 309, CAST(0xEE3E0B00 AS Date), NULL)
INSERT [dbo].[cierreCaja] ([usuarioSaliente], [usuarioEntrante], [cierreCaja], [cierreCajaCalculado], [fecha], [hora]) VALUES (N'admin     ', N'cajero1   ', 301, 309, CAST(0xEE3E0B00 AS Date), NULL)
INSERT [dbo].[cierreCaja] ([usuarioSaliente], [usuarioEntrante], [cierreCaja], [cierreCajaCalculado], [fecha], [hora]) VALUES (N'admin     ', N'cajero1   ', 301, 309, CAST(0xEE3E0B00 AS Date), NULL)
INSERT [dbo].[cierreCaja] ([usuarioSaliente], [usuarioEntrante], [cierreCaja], [cierreCajaCalculado], [fecha], [hora]) VALUES (N'admin     ', N'cajero1   ', 301, 309, CAST(0xEE3E0B00 AS Date), NULL)
INSERT [dbo].[cierreCaja] ([usuarioSaliente], [usuarioEntrante], [cierreCaja], [cierreCajaCalculado], [fecha], [hora]) VALUES (N'nico      ', N'admin     ', 15, 137, CAST(0xF33E0B00 AS Date), NULL)
INSERT [dbo].[cierreCaja] ([usuarioSaliente], [usuarioEntrante], [cierreCaja], [cierreCajaCalculado], [fecha], [hora]) VALUES (N'nico      ', N'admin     ', 122, 137, CAST(0xF33E0B00 AS Date), CAST(0x07002E7183A00000 AS Time))
/****** Object:  Table [dbo].[barrio]    Script Date: 11/14/2018 19:11:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[barrio](
	[id] [int] NOT NULL,
	[nombre] [nchar](50) NULL,
	[codigo postal] [int] NULL,
 CONSTRAINT [PK_barrio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[barrio] ([id], [nombre], [codigo postal]) VALUES (1, N'Cofico                                            ', 5100)
INSERT [dbo].[barrio] ([id], [nombre], [codigo postal]) VALUES (2, N'Guemes                                            ', 5000)
INSERT [dbo].[barrio] ([id], [nombre], [codigo postal]) VALUES (3, N'V.Belgrano                                        ', 600)
