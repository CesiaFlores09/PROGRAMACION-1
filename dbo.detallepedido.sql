CREATE TABLE [dbo].[dpedidos]
(
	[idDetpedidos] INT NOT NULL PRIMARY KEY,
	[idpedidos] int not null,
	[idproducto] int not null,
	[Cantidad] decimal (10,2) not null,
	[Precio] decimal (10,2) not null,
	[Descuento] int not null, 
    CONSTRAINT [idproducto] FOREIGN KEY ([idproducto]) REFERENCES [producto]([idproducto]), 
    CONSTRAINT [idpedidos] FOREIGN KEY ([idpedidos]) REFERENCES [pedidos]([idpedidos])

	)