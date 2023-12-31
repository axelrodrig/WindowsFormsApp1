USE [EstadisticaBiblioteca]
GO
/****** Object:  Table [dbo].[Libro]    Script Date: 22/7/2023 14:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libro](
	[id_Libro] [int] IDENTITY(1,1) NOT NULL,
	[signatura] [varchar](15) NOT NULL,
 CONSTRAINT [PK__Libro__7813660F21874147] PRIMARY KEY CLUSTERED 
(
	[id_Libro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Libro] SET (LOCK_ESCALATION = DISABLE)
GO
/****** Object:  Table [dbo].[Prestamo]    Script Date: 22/7/2023 14:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestamo](
	[id_prestamo] [int] IDENTITY(1,1) NOT NULL,
	[fecha_prestamo] [varchar](50) NOT NULL,
	[fecha_devolucion] [varchar](50) NULL,
	[signaturas] [varchar](max) NOT NULL,
	[id_usuario] [varchar](15) NOT NULL,
	[estado_prestamo] [varchar](10) NULL,
	[aprobado_por] [varchar](60) NOT NULL,
	[recibido_por] [varchar](60) NULL,
 CONSTRAINT [PK__Prestamo__5E87BE272EE64118] PRIMARY KEY CLUSTERED 
(
	[id_prestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Usuario]    Script Date: 22/7/2023 14:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Usuario](
	[tipo] [varchar](50) NOT NULL,
	[id_TipoUsuario] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Tipo_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_TipoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tipo_Usuario] SET (LOCK_ESCALATION = DISABLE)
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 22/7/2023 14:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[identificacion] [varchar](20) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
	[telefono] [varchar](15) NOT NULL,
	[correo] [varchar](80) NOT NULL,
	[id_tipoUsuario] [int] NOT NULL,
	[carrera] [varchar](50) NOT NULL,
	[turno] [varchar](15) NOT NULL,
	[año] [varchar](15) NOT NULL,
 CONSTRAINT [PK__Usuario__4E3E04AD2688B8F1] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuario] SET (LOCK_ESCALATION = DISABLE)
GO
/****** Object:  Table [dbo].[Usuario_sistema]    Script Date: 22/7/2023 14:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_sistema](
	[id_usuarioSistema] [int] NOT NULL,
	[usuarios] [varchar](50) NOT NULL,
	[clave] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuarioSistema] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Libro] ON 

INSERT [dbo].[Libro] ([id_Libro], [signatura]) VALUES (18, N'2910')
INSERT [dbo].[Libro] ([id_Libro], [signatura]) VALUES (19, N'1029')
INSERT [dbo].[Libro] ([id_Libro], [signatura]) VALUES (20, N'29100')
INSERT [dbo].[Libro] ([id_Libro], [signatura]) VALUES (21, N'2902')
INSERT [dbo].[Libro] ([id_Libro], [signatura]) VALUES (22, N'1000')
INSERT [dbo].[Libro] ([id_Libro], [signatura]) VALUES (23, N'12345')
INSERT [dbo].[Libro] ([id_Libro], [signatura]) VALUES (24, N'29101')
SET IDENTITY_INSERT [dbo].[Libro] OFF
GO
SET IDENTITY_INSERT [dbo].[Prestamo] ON 

INSERT [dbo].[Prestamo] ([id_prestamo], [fecha_prestamo], [fecha_devolucion], [signaturas], [id_usuario], [estado_prestamo], [aprobado_por], [recibido_por]) VALUES (4, N'22/7/2023 11:37:57', N'sábado, 22 de julio de 2023', N'29101,2910', N'22507420', N'Entregado', N'Heysell Rivas Peralta', N'Isolina Tinoco Meza')
SET IDENTITY_INSERT [dbo].[Prestamo] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipo_Usuario] ON 

INSERT [dbo].[Tipo_Usuario] ([tipo], [id_TipoUsuario]) VALUES (N'ESTUDIANTES', 1)
INSERT [dbo].[Tipo_Usuario] ([tipo], [id_TipoUsuario]) VALUES (N'DOCENTES', 2)
INSERT [dbo].[Tipo_Usuario] ([tipo], [id_TipoUsuario]) VALUES (N'EXTERNO', 3)
INSERT [dbo].[Tipo_Usuario] ([tipo], [id_TipoUsuario]) VALUES (N'ADMINISTRADOR', 4)
SET IDENTITY_INSERT [dbo].[Tipo_Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id_usuario], [nombres], [apellidos], [identificacion], [direccion], [telefono], [correo], [id_tipoUsuario], [carrera], [turno], [año]) VALUES (5, N'Axel', N'Rodriguez', N'22507420', N'Pueblo Nuevo', N'88749622', N'axel07430@gmail.com', 1, N'Ing. Sistemas', N'veespertino', N'segundo')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
INSERT [dbo].[Usuario_sistema] ([id_usuarioSistema], [usuarios], [clave]) VALUES (1, N'ADMINISTRADOR', N'ADMINISTRADOR')
INSERT [dbo].[Usuario_sistema] ([id_usuarioSistema], [usuarios], [clave]) VALUES (2, N'DOCENTE', N'DOCENTE')
INSERT [dbo].[Usuario_sistema] ([id_usuarioSistema], [usuarios], [clave]) VALUES (3, N'ESTUDIANTE', N'ESTUDIANTE')
INSERT [dbo].[Usuario_sistema] ([id_usuarioSistema], [usuarios], [clave]) VALUES (4, N'EXTERNO', N'EXTERNO')
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Tipo_Usuario1] FOREIGN KEY([id_tipoUsuario])
REFERENCES [dbo].[Tipo_Usuario] ([id_TipoUsuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Tipo_Usuario1]
GO
