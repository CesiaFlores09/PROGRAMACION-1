CREATE TABLE [dbo].[pedidos]
(

	[idpedidos] INT NOT NULL PRIMARY KEY IDENTITY,
	[idcliente] int not null,
	[nfactura] char(15) not null,
	[fecha] date not null,
	[tipopago] int not null,
	[tipofactura] int not null, 
    CONSTRAINT [idcliente] FOREIGN KEY ([idcliente]) REFERENCES [cliente]([idcliente]),

)