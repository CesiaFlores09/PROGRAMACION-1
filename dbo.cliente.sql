CREATE TABLE [dbo].[cliente] (
    [idcliente] INT       IDENTITY (1, 1) NOT NULL,
    [codigo]    CHAR (10) NOT NULL,
    [nombre]    CHAR (65) NOT NULL,
    [direccion] CHAR (65) NOT NULL,
    [telefono]  CHAR (9)  NOT NULL,
    [email]     CHAR (65) NOT NULL,
    PRIMARY KEY CLUSTERED ([idcliente] ASC)
);

