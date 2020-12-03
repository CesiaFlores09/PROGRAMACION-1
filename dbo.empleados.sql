CREATE TABLE [dbo].[empleados]
(
	[idempleados] INT NOT NULL PRIMARY KEY IDENTITY,
	[idpuestolaboral] int not null,
	[codigo] char(10 ) not null,
	[nombre] char(65) not null,
	[direccion] char not null,
	[telefono] char(9) not null,
	[email] char(65) not null, 
    CONSTRAINT [FK_empleados_puesto] FOREIGN KEY ([idpuestolaboral]) REFERENCES [puesto]([idpuestolaboral])
)
