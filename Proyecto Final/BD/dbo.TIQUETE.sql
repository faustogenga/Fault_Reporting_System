
CREATE TABLE [dbo].[TIQUETE](
	[id] INT IDENTITY (1, 1) NOT NULL,
	[cedula_usuario] [bigint] NOT NULL,
	[cedula_admin] [bigint] NOT NULL,
	[asunto] [varchar](200) NOT NULL,
	[descripcion] [varchar](500) NULL,
	[estado] [varchar](50) NOT NULL,
	[tipo] [varchar](200) NOT NULL,
	[fecha_creacion] [date] NOT NULL,
	[severidad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TIQUETE]  WITH CHECK ADD  CONSTRAINT [cedula_admin_FK] FOREIGN KEY([cedula_admin])
REFERENCES [dbo].[ADMINISTRADOR] ([cedula])
GO

ALTER TABLE [dbo].[TIQUETE] CHECK CONSTRAINT [cedula_admin_FK]
GO

ALTER TABLE [dbo].[TIQUETE]  WITH CHECK ADD  CONSTRAINT [cedula_usuario_FK] FOREIGN KEY([cedula_usuario])
REFERENCES [dbo].[USUARIO] ([cedula])
GO

ALTER TABLE [dbo].[TIQUETE] CHECK CONSTRAINT [cedula_cliente_FK]
GO


