CREATE TABLE [dbo].[Clientes]
(
    [ClienteId] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [TipoPersonaId] INT NOT NULL, 
    [NombreEmpresa] NVARCHAR(250) NULL, 
    [Nombre] NVARCHAR(100) NULL, 
    [ApellidoPaterno] NVARCHAR(100) NULL, 
    [ApellidoMaterno] NVARCHAR(100) NULL, 
    [Direccion1] NVARCHAR(300) NOT NULL, 
    [Direccion2] NVARCHAR(300) NULL, 
    [Telefono] NVARCHAR(50) NULL, 
    [Comentario] NVARCHAR(300) NULL
)