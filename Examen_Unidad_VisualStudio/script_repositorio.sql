USE [repositorios]
GO
/****** Object:  Table [dbo].[autor]    Script Date: 13/10/2018 03:11:25 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[autor](
	[idautor] [int] NOT NULL,
	[nombre] [nchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idautor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coleccion]    Script Date: 13/10/2018 03:11:25 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coleccion](
	[idcoleccion] [int] NOT NULL,
	[nombre_coleccion] [nchar](100) NOT NULL,
	[idsubcomunidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idcoleccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[comunidad]    Script Date: 13/10/2018 03:11:25 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comunidad](
	[idcomunidad] [int] NOT NULL,
	[nombre_comunidad] [nchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idcomunidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[consulta]    Script Date: 13/10/2018 03:11:25 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[consulta](
	[idconsulta] [int] NOT NULL,
	[idusuario] [int] NOT NULL,
	[iditem] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idconsulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[fichero]    Script Date: 13/10/2018 03:11:25 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fichero](
	[idfichero] [int] NOT NULL,
	[link] [nchar](100) NOT NULL,
	[descripcion] [nchar](100) NOT NULL,
	[tamaño] [nchar](100) NOT NULL,
	[formato] [nchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idfichero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[fichero_item]    Script Date: 13/10/2018 03:11:25 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fichero_item](
	[idfichero_item] [int] NOT NULL,
	[iditem] [int] NOT NULL,
	[idfichero] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idfichero_item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[item]    Script Date: 13/10/2018 03:11:25 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item](
	[iditem] [int] NOT NULL,
	[titulo] [text] NOT NULL,
	[fechapublicacion] [date] NOT NULL,
	[editorial] [nchar](100) NOT NULL,
	[resumen] [text] NOT NULL,
	[uri] [text] NOT NULL,
	[idcoleccion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[iditem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[item_autor]    Script Date: 13/10/2018 03:11:25 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item_autor](
	[iditem_autor] [int] NOT NULL,
	[idautor] [int] NOT NULL,
	[iditem] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[iditem_autor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[item_metadato]    Script Date: 13/10/2018 03:11:25 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item_metadato](
	[iditem_metadato] [int] NOT NULL,
	[idmetadato] [int] NOT NULL,
	[iditem] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[iditem_metadato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[metadato]    Script Date: 13/10/2018 03:11:25 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[metadato](
	[idmetadato] [int] NOT NULL,
	[campodc] [nchar](100) NOT NULL,
	[valor] [nchar](1000) NOT NULL,
	[lenguaje] [nchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idmetadato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[palabrasclave]    Script Date: 13/10/2018 03:11:25 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[palabrasclave](
	[idpalabrasclave] [int] NOT NULL,
	[nombre] [nchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idpalabrasclave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[palabrasclave_item]    Script Date: 13/10/2018 03:11:25 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[palabrasclave_item](
	[idpalabrasclave_item] [int] NOT NULL,
	[idpalabrasclave] [int] NOT NULL,
	[iditem] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idpalabrasclave_item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[subcomunidad]    Script Date: 13/10/2018 03:11:25 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subcomunidad](
	[idsubcomunidad] [int] NOT NULL,
	[nombre_subcomunidad] [nchar](100) NOT NULL,
	[idcomunidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idsubcomunidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuario]    Script Date: 13/10/2018 03:11:25 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[idusuario] [int] NOT NULL,
	[direccionip] [nchar](100) NOT NULL,
	[Pais] [nchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[coleccion]  WITH CHECK ADD FOREIGN KEY([idsubcomunidad])
REFERENCES [dbo].[subcomunidad] ([idsubcomunidad])
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD FOREIGN KEY([iditem])
REFERENCES [dbo].[item] ([iditem])
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD FOREIGN KEY([idusuario])
REFERENCES [dbo].[usuario] ([idusuario])
GO
ALTER TABLE [dbo].[fichero_item]  WITH CHECK ADD FOREIGN KEY([idfichero])
REFERENCES [dbo].[fichero] ([idfichero])
GO
ALTER TABLE [dbo].[fichero_item]  WITH CHECK ADD FOREIGN KEY([iditem])
REFERENCES [dbo].[item] ([iditem])
GO
ALTER TABLE [dbo].[item]  WITH CHECK ADD FOREIGN KEY([idcoleccion])
REFERENCES [dbo].[coleccion] ([idcoleccion])
GO
ALTER TABLE [dbo].[item_autor]  WITH CHECK ADD FOREIGN KEY([idautor])
REFERENCES [dbo].[autor] ([idautor])
GO
ALTER TABLE [dbo].[item_autor]  WITH CHECK ADD FOREIGN KEY([iditem])
REFERENCES [dbo].[item] ([iditem])
GO
ALTER TABLE [dbo].[item_metadato]  WITH CHECK ADD FOREIGN KEY([iditem])
REFERENCES [dbo].[item] ([iditem])
GO
ALTER TABLE [dbo].[item_metadato]  WITH CHECK ADD FOREIGN KEY([idmetadato])
REFERENCES [dbo].[metadato] ([idmetadato])
GO
ALTER TABLE [dbo].[palabrasclave_item]  WITH CHECK ADD FOREIGN KEY([iditem])
REFERENCES [dbo].[item] ([iditem])
GO
ALTER TABLE [dbo].[palabrasclave_item]  WITH CHECK ADD FOREIGN KEY([idpalabrasclave])
REFERENCES [dbo].[palabrasclave] ([idpalabrasclave])
GO
ALTER TABLE [dbo].[subcomunidad]  WITH CHECK ADD FOREIGN KEY([idcomunidad])
REFERENCES [dbo].[comunidad] ([idcomunidad])
GO
