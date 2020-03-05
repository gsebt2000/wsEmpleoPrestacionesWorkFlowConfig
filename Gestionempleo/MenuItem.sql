CREATE TABLE [dbo].[MenuItem]
(
	[GrupoID] [varchar](30) NOT NULL,
	[Nivel] int not null,
	[Menu] [varchar](30) NOT NULL,
	[Item] [varchar](30) NOT NULL,
	[Orden] [int] NULL,
	[ItemCaption] [varchar](60) NULL,
	[Salto] [varchar](500) NULL,
	[TipoItem] [int] NULL,
	[Icono] [varchar](150) NULL,
	[Habilitado] [int] NULL,
	[ToolTipText] [varchar](100) NULL,
	[Ayuda] [varchar](100) NULL,
	[ParsearSalto] [int] NULL,
	[ControlAccesoTipo] [int] NULL,
	[ItemId] [varchar](30) NULL,

 CONSTRAINT [PK_MENUITEM] PRIMARY KEY CLUSTERED 
(
	[GrupoID] ASC,
	[Nivel] ASC,
	[Menu] ASC,
	[Item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
