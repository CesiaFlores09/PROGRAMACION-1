CREATE TABLE [dbo].[producto]
(
	[idproducto] INT NOT NULL PRIMARY KEY IDENTITY,
	[idcategoria] int not null,
	[codigo] char(10) not null,
	[nombre] char(65) not null,
	[marca] char (30) not null,
	[medidas] char (30) not null, 
    CONSTRAINT [FK_producto_categoria] FOREIGN KEY ([idcategoria]) REFERENCES [categoria]([idcategoria]),
)
