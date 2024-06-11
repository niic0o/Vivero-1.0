CREATE DATABASE DB_VIVERO;
go

use DB_VIVERO;
go

CREATE TABLE [dbo].[CATEGORIAS] (
    [id_categoria] TINYINT       IDENTITY (1, 1) NOT NULL,
    [categoria]    NVARCHAR (50) NOT NULL,
    [eliminado]    NVARCHAR (2)  DEFAULT ('NO') NOT NULL,
    CONSTRAINT [PK_id_categoria] PRIMARY KEY CLUSTERED ([id_categoria] ASC),
    CONSTRAINT [unica_categoria] UNIQUE NONCLUSTERED ([categoria] ASC)
);
go

CREATE TABLE [dbo].[TIPOS_DE_PRODUCTOS] (
    [id_categoria] TINYINT       NOT NULL,
    [id_tipo]      SMALLINT      IDENTITY (1, 1) NOT NULL,
    [tipo]         NVARCHAR (50) NOT NULL,
    [eliminado]    NVARCHAR (2)  CONSTRAINT [DF_eliminado] DEFAULT ('NO') NOT NULL,
    CONSTRAINT [PK_id_categoria_id_tipo] PRIMARY KEY CLUSTERED ([id_categoria] ASC, [id_tipo] ASC),
    CONSTRAINT [FK_categoria] FOREIGN KEY ([id_categoria]) REFERENCES [dbo].[CATEGORIAS] ([id_categoria])
);
go

CREATE TABLE [dbo].[PRODUCTOS] (
    [id_categoria]  TINYINT        NOT NULL,
    [id_tipo]       SMALLINT       NOT NULL,
    [id_producto]   INT            IDENTITY (1, 1) NOT NULL,
    [nombre]        NVARCHAR (100) NOT NULL,
    [descripcion]   NVARCHAR (250) NOT NULL,
    [tamanio]       NVARCHAR (25)  NOT NULL,
    [disponible]    NVARCHAR (2)   NOT NULL,
    [stock_min]     TINYINT        NOT NULL,
    [stock]         SMALLINT       NOT NULL,
    [precio_lista]  FLOAT (53)     NOT NULL,
    [precio_venta]  FLOAT (53)     NOT NULL,
    [descuento]     TINYINT        NOT NULL,
    [veces_vendido] INT            CONSTRAINT [DF_vendido] DEFAULT ((0)) NOT NULL,
    [eliminado]     NVARCHAR (2)   CONSTRAINT [DF_eliminado_prod] DEFAULT ('NO') NOT NULL,
    CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED ([id_producto] ASC),
    CONSTRAINT [unico_nombre] UNIQUE NONCLUSTERED ([nombre] ASC),
    CONSTRAINT [FK_productos_tipo] FOREIGN KEY ([id_categoria], [id_tipo]) REFERENCES [dbo].[TIPOS_DE_PRODUCTOS] ([id_categoria], [id_tipo])
);
go

CREATE TABLE [dbo].[PERFILES] (
    [id_perfil] TINYINT       IDENTITY (1, 1) NOT NULL,
    [perfil]    NVARCHAR (25) NOT NULL,
    CONSTRAINT [PK_id_perfil] PRIMARY KEY CLUSTERED ([id_perfil] ASC),
    CONSTRAINT [unico_perfil] UNIQUE NONCLUSTERED ([perfil] ASC)
);
go

CREATE TABLE [dbo].[USUARIOS] (
    [id_perfil]     TINYINT       NOT NULL,
    [id_usuario]    SMALLINT      IDENTITY (1, 1) NOT NULL,
    [DNI]           INT           NOT NULL,
    [apellido]      NVARCHAR (50) NOT NULL,
    [nombre]        NVARCHAR (50) NOT NULL,
    [fecha_nac]     DATE          NOT NULL,
    [fecha_ingreso] DATE          NOT NULL,
    [username]      NVARCHAR (25) NOT NULL,
    [contraseña]    NVARCHAR (25) NOT NULL,
    [direccion]     NVARCHAR (50) NOT NULL,
    [telefono]      NVARCHAR (20) NULL,
    [email]         NVARCHAR (50) NOT NULL,
    [eliminado]     NVARCHAR (2)  CONSTRAINT [DF_eliminado_user] DEFAULT ('NO') NOT NULL,
    CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED ([id_usuario] ASC),
    CONSTRAINT [unico_dni] UNIQUE NONCLUSTERED ([DNI] ASC),
    CONSTRAINT [unico_username] UNIQUE NONCLUSTERED ([username] ASC),
    CONSTRAINT [FK_id_perfil] FOREIGN KEY ([id_perfil]) REFERENCES [dbo].[PERFILES] ([id_perfil]),
    CONSTRAINT [CHK_dniLimite] CHECK ([DNI]>(0) AND [DNI]<(50000000)),
    CONSTRAINT [CHK_passLimite] CHECK (len([contraseña])>(7))
);
go

CREATE TABLE [dbo].[CLIENTES] (
    [id_cliente] INT           IDENTITY (1, 1) NOT NULL,
    [apellido]   NVARCHAR (50) NOT NULL,
    [nombre]     NVARCHAR (50) NOT NULL,
    [DNI]        INT           NOT NULL,
    [email]      NVARCHAR (50) NULL,
    [telefono]   NVARCHAR (20) NULL,
    [direccion]  NVARCHAR (50) NOT NULL,
    [provincia]  NVARCHAR (50) NOT NULL,
    [localidad]  NVARCHAR (50) NOT NULL,
    [eliminado]  NVARCHAR (2)  CONSTRAINT [DF_eliminado_cliente] DEFAULT ('NO') NOT NULL,
    CONSTRAINT [PK_id_cliente] PRIMARY KEY CLUSTERED ([id_cliente] ASC),
    CONSTRAINT [unico_dni_cliente] UNIQUE NONCLUSTERED ([DNI] ASC),
    CONSTRAINT [CHK_dniLimiteCliente] CHECK ([DNI]>(0) AND [DNI]<(50000000))
);
go

CREATE TABLE [dbo].[FORMAS_DE_PAGO] (
    [id_FdePago] TINYINT       IDENTITY (1, 1) NOT NULL,
    [FdePago]    NVARCHAR (25) NOT NULL,
    CONSTRAINT [PK_id_FdePago] PRIMARY KEY CLUSTERED ([id_FdePago] ASC),
    CONSTRAINT [unica_FdePago] UNIQUE NONCLUSTERED ([FdePago] ASC)
);
go

CREATE TABLE [dbo].[FACTURAS] (
    [num_factura]  INT           NOT NULL,
    [fecha_y_hora] SMALLDATETIME NOT NULL,
    [id_vendedor]  SMALLINT      NOT NULL,
    [id_FdePago]   TINYINT       NOT NULL,
    [id_cliente]   INT           NOT NULL,
    [total]        FLOAT (53)    NOT NULL,
    [anulado]      NVARCHAR (2)  CONSTRAINT [DF_anulado] DEFAULT ('NO') NOT NULL,
    CONSTRAINT [PK_num_factura] PRIMARY KEY CLUSTERED ([num_factura] ASC),
    CONSTRAINT [FK_factura_FdePago] FOREIGN KEY ([id_FdePago]) REFERENCES [dbo].[FORMAS_DE_PAGO] ([id_FdePago]),
    CONSTRAINT [FK_factura_cliente] FOREIGN KEY ([id_cliente]) REFERENCES [dbo].[CLIENTES] ([id_cliente]),
    CONSTRAINT [FK_factura_usuario)] FOREIGN KEY ([id_vendedor]) REFERENCES [dbo].[USUARIOS] ([id_usuario]),
    CONSTRAINT [CHK_noNegativoF] CHECK ([num_factura]>(0)),
    CONSTRAINT [CHK_noNegativoT] CHECK ([total]>(0))
);
go

CREATE TABLE [dbo].[FACTURAS_DETALLE] (
    [num_factura] INT            NOT NULL,
    [id_item]     TINYINT        NOT NULL,
    [id_producto] INT            NOT NULL,
    [descripcion] NVARCHAR (100) NOT NULL,
    [precio]      FLOAT (53)     NOT NULL,
    [cantidad]    SMALLINT       NOT NULL,
    [sub_total]   FLOAT (53)     NOT NULL,
    CONSTRAINT [PK_num_factura_id_item] PRIMARY KEY CLUSTERED ([num_factura] ASC, [id_item] ASC),
    CONSTRAINT [FK_detalle_facturas] FOREIGN KEY ([num_factura]) REFERENCES [dbo].[FACTURAS] ([num_factura]),
    CONSTRAINT [FK_detalle_producto] FOREIGN KEY ([id_producto]) REFERENCES [dbo].[PRODUCTOS] ([id_producto])
);
go