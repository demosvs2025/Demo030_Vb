/*
DROP PROCEDURE, FUNCTION, TABLE, VIEW
CREATE TABLE, VIEW, FUNCTION, PROCEDURE
*/

DROP PROCEDURE [dbo].[ObtenerPedidosPorCliente_Fechas]
GO

DROP PROCEDURE [dbo].[ObtenerPedidosPorEmpleado]
GO

DROP PROCEDURE [dbo].[Productos_Obtener]
GO
DROP PROCEDURE [dbo].[Productos_ObtenerPorId]
GO
DROP PROCEDURE [dbo].[Productos_Insertar]
GO
DROP PROCEDURE [dbo].[Productos_Actualizar]
GO
DROP PROCEDURE [dbo].[Productos_Borrar]
GO
DROP PROCEDURE [dbo].[Productos_ObtenerCombo1]
GO


DROP PROCEDURE [dbo].[Empleados_Obtener]
GO
DROP PROCEDURE [dbo].[Empleados_ObtenerPorId]
GO
DROP PROCEDURE [dbo].[Empleados_Insertar]
GO
DROP PROCEDURE [dbo].[Empleados_Actualizar]
GO
DROP PROCEDURE [dbo].[Empleados_Borrar]
GO
DROP PROCEDURE [dbo].[Empleados_ObtenerCombo1]
GO

DROP PROCEDURE [dbo].[Clientes_ObtenerCombo1]
GO


DROP PROCEDURE [dbo].[Pedidos_Obtener]
GO

DROP PROCEDURE [dbo].[PedidoDetalles_ObtenerPorId]
GO

DROP PROCEDURE [dbo].[Pedidos_ObtenerPorId]
GO

DROP PROCEDURE [dbo].[Pedidos_Insertar]
GO

DROP PROCEDURE [dbo].[Pedidos_Actualizar]
GO

DROP PROCEDURE [dbo].[PedidoDetalles_Insertar]
GO

DROP PROCEDURE [dbo].[PedidoDetalles_Borrar]
GO

DROP PROCEDURE [dbo].[Pedidos_Borrar]
GO


DROP FUNCTION [dbo].[ObtenerFechaFormato1]
GO

DROP FUNCTION [dbo].[ObtenerDecimalFormato1]
GO


DROP TABLE [dbo].[PedidoDetalles]
GO

DROP TABLE [dbo].[Pedidos]
GO

DROP TABLE [dbo].[Empleados]
GO

DROP TABLE [dbo].[Productos]
GO

DROP TABLE [dbo].[Clientes]
GO

DROP VIEW [dbo].[EmpleadosPedidos_Vista]
GO

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
GO

CREATE TABLE [dbo].[Productos]
(
    [ProductoId] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [NombreProducto] NVARCHAR(100) NOT NULL, 
    [Cantidad] INT NOT NULL, 
    [Precio] DECIMAL(18,2) NOT NULL
)
GO

CREATE TABLE [dbo].[Empleados]
(
    [EmpleadoId] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Nombre] NVARCHAR(100) NULL, 
    [ApellidoPaterno] NVARCHAR(100) NULL, 
    [ApellidoMaterno] NVARCHAR(100) NULL
)
GO

CREATE TABLE [dbo].[Pedidos]
(
    [PedidoId] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [EmpleadoId] INT NOT NULL, 
    [ClienteId] INT NOT NULL, 
    [Nombre] NVARCHAR(250) NOT NULL,
    [Direccion1] NVARCHAR(300) NOT NULL, 
    [Direccion2] NVARCHAR(300) NULL, 
    [Telefono] NVARCHAR(50) NULL, 
    [Comentario] NVARCHAR(300) NULL,
    [FechaPedido] DATETIME NOT NULL,
    [Total] DECIMAL(18,2) NOT NULL,
    FOREIGN KEY(EmpleadoId) REFERENCES Empleados(EmpleadoId),
    FOREIGN KEY(ClienteId) REFERENCES Clientes(ClienteId)
)
GO

CREATE TABLE [dbo].[PedidoDetalles]
(
    [PedidoDetalleId] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [PedidoId] INT NOT NULL, 
    [ProductoId] INT NOT NULL, 
    [NombreProducto] NVARCHAR(100) NOT NULL, 
    [Cantidad] INT NOT NULL, 
    [Precio] DECIMAL(18,2) NOT NULL,
    [Subtotal] DECIMAL(18,2) NOT NULL,
    FOREIGN KEY(PedidoId) REFERENCES Pedidos(PedidoId),
    FOREIGN KEY(ProductoId) REFERENCES Productos(ProductoId)
)
GO

---------------------------------------------------------------------
-- VIEWS Pedidos
---------------------------------------------------------------------

CREATE VIEW [dbo].[EmpleadosPedidos_Vista] AS 
    SELECT 
        emp.Nombre + ' ' + emp.ApellidoPaterno + ' ' + emp.ApellidoMaterno AS 'Nombre empleado',
        COUNT(ped.PedidoId) AS 'Pedidos'
    FROM Empleados emp LEFT JOIN Pedidos ped ON emp.EmpleadoId = ped.EmpleadoId
    GROUP BY emp.Nombre + ' ' + emp.ApellidoPaterno + ' ' + emp.ApellidoMaterno
GO

---------------------------------------------------------------------
-- FUNCTIONS 
---------------------------------------------------------------------

CREATE FUNCTION [dbo].[ObtenerFechaFormato1] (
    @Fecha DATETIME
)
RETURNS NVARCHAR(10) AS
BEGIN
    DECLARE @FechaFormato NVARCHAR(10)

    SET @FechaFormato = CONVERT(NVARCHAR(10), @Fecha, 103)

    RETURN @FechaFormato
END
GO



CREATE FUNCTION [dbo].[ObtenerDecimalFormato1] (
    @Decimal DECIMAL(18,2)
)
RETURNS NVARCHAR(10) AS
BEGIN
    DECLARE @DecimalFormato NVARCHAR(10)

    SET @DecimalFormato = '$ ' + CONVERT(VARCHAR(18), CAST(@Decimal AS money), 1)

    RETURN @DecimalFormato
END
GO
        
---------------------------------------------------------------------
-- PROCEDURES Productos
---------------------------------------------------------------------

CREATE PROCEDURE [dbo].[Productos_Obtener]
(
    @NombreProducto NVARCHAR(100)
)
AS
BEGIN
    SELECT ProductoId AS 'Id Producto', NombreProducto AS 'Nombre producto', Cantidad, Precio
    FROM Productos
    WHERE NombreProducto LIKE '%' + @NombreProducto + '%'
    ORDER BY NombreProducto
END
GO

CREATE PROCEDURE [dbo].[Productos_ObtenerPorId]
(
    @ProductoId INT
)
AS
BEGIN
    SELECT NombreProducto, Cantidad, Precio
    FROM Productos
    WHERE ProductoId = @ProductoId
END
GO

CREATE PROCEDURE [dbo].[Productos_Insertar]
(
    @NombreProducto NVARCHAR(100), 
    @Cantidad INT, 
    @Precio DECIMAL(18,2)
)
AS
BEGIN
    INSERT Productos 
    VALUES(@NombreProducto, @Cantidad, @Precio)
END
GO

CREATE PROCEDURE [dbo].[Productos_Actualizar]
(
    @ProductoId INT,
    @NombreProducto NVARCHAR(100), 
    @Cantidad INT, 
    @Precio DECIMAL(18,2)
)
AS
BEGIN
    UPDATE Productos SET
        NombreProducto = @NombreProducto,
        Cantidad = @Cantidad,
        Precio = @Precio
    WHERE ProductoId = @ProductoId
END
GO

CREATE PROCEDURE [dbo].[Productos_Borrar]
(
    @ProductoId INT
)
AS
BEGIN
    DELETE Productos
    WHERE ProductoId = @ProductoId
END
GO

CREATE PROCEDURE [dbo].[Productos_ObtenerCombo1]
AS
BEGIN
    SELECT ProductoId, 
        NombreProducto AS 'Nombre'
    FROM Productos
    ORDER BY 2
END
GO

---------------------------------------------------------------------
-- PROCEDURES Empleados
---------------------------------------------------------------------

CREATE PROCEDURE [dbo].[Empleados_Obtener]
(
    @Nombre NVARCHAR(300)
)
AS
BEGIN
    SELECT EmpleadoId AS 'Id Empleado', 
        Nombre AS 'Nombre', 
        ApellidoPaterno AS 'Apellido paterno', 
        ApellidoMaterno AS 'Apellido materno'
    FROM Empleados
    WHERE (Nombre + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno) LIKE '%' + @Nombre + '%'
    ORDER BY (Nombre + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno)
END
GO

CREATE PROCEDURE [dbo].[Empleados_ObtenerPorId]
(
    @EmpleadoId INT
)
AS
BEGIN
    SELECT Nombre, ApellidoPaterno, ApellidoMaterno
    FROM Empleados
    WHERE EmpleadoId = @EmpleadoId
END
GO

CREATE PROCEDURE [dbo].[Empleados_Insertar]
(
    @Nombre NVARCHAR(100), 
    @ApellidoPaterno NVARCHAR(100), 
    @ApellidoMaterno NVARCHAR(100)
)
AS
BEGIN
    INSERT Empleados 
    VALUES(@Nombre, @ApellidoPaterno, @ApellidoMaterno)
END
GO

GO
CREATE PROCEDURE [dbo].[Empleados_Actualizar]
(
    @EmpleadoId INT,
    @Nombre NVARCHAR(100), 
    @ApellidoPaterno NVARCHAR(100), 
    @ApellidoMaterno NVARCHAR(100)
)
AS
BEGIN
    UPDATE Empleados SET
        Nombre = @Nombre,
        ApellidoPaterno = @ApellidoPaterno,
        ApellidoMaterno = @ApellidoMaterno
    WHERE EmpleadoId = @EmpleadoId
END
GO

CREATE PROCEDURE [dbo].[Empleados_Borrar]
(
    @EmpleadoId INT
)
AS
BEGIN
    DELETE Empleados
    WHERE EmpleadoId = @EmpleadoId
END
GO

CREATE PROCEDURE [dbo].[Empleados_ObtenerCombo1]
AS
BEGIN
    SELECT EmpleadoId, 
        Nombre + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno AS 'Nombre'
    FROM Empleados
    ORDER BY 2
END
GO

---------------------------------------------------------------------
-- PROCEDURES Clientes
---------------------------------------------------------------------

CREATE PROCEDURE [dbo].[Clientes_ObtenerCombo1]
AS
BEGIN
    SELECT 
        ClienteId,
        CASE WHEN TipoPersonaId = 1 THEN 
            NombreEmpresa
        ELSE 
            Nombre + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno 
        END AS 'Nombre'
    FROM Clientes
    ORDER BY 2
END
GO

---------------------------------------------------------------------
-- PROCEDURES Pedidos
---------------------------------------------------------------------

CREATE PROCEDURE [dbo].[Pedidos_Obtener]
(
    @NombreEmpleado NVARCHAR(100),
    @NombreCliente NVARCHAR(100)
)
AS
BEGIN
    SELECT 
        ped.PedidoId AS 'Id Pedido', 
        (emp.Nombre + ' ' + emp.ApellidoPaterno + ' ' + emp.ApellidoMaterno) AS 'Nombre empleado',
        ped.Nombre AS 'Nombre cliente', 
        dbo.ObtenerFechaFormato1(FechaPedido) AS 'Fecha pedido', 
        dbo.ObtenerDecimalFormato1(Total) AS 'Total'
    FROM Pedidos ped LEFT JOIN Empleados emp ON ped.EmpleadoId = emp.EmpleadoId
    WHERE (emp.Nombre + ' ' + emp.ApellidoPaterno + ' ' + emp.ApellidoMaterno) LIKE '%' + @NombreEmpleado + '%'
         AND ped.Nombre LIKE '%' + @NombreCliente + '%'
    ORDER BY ped.PedidoId DESC
END
GO

CREATE PROCEDURE [dbo].[PedidoDetalles_ObtenerPorId]
(
    @PedidoId INT
)
AS
BEGIN
    SELECT 
        PedidoDetalleId AS 'Id Detalle',
        ProductoId AS 'Id Producto',
        NombreProducto AS 'Nombre producto',
        Cantidad,
        dbo.ObtenerDecimalFormato1(Precio) AS 'Precio',
        dbo.ObtenerDecimalFormato1(Subtotal) AS 'Subtotal'
    FROM PedidoDetalles
    WHERE PedidoId = @PedidoId
    ORDER BY PedidoDetalleId
END
GO

CREATE PROCEDURE [dbo].[Pedidos_ObtenerPorId]
(
    @PedidoId INT
)
AS
BEGIN
    SELECT 
        EmpleadoId,
        ClienteId,
        Nombre, 
        Direccion1,
        Direccion2,
        Telefono,
        Comentario,
        dbo.ObtenerFechaFormato1(FechaPedido), 
        Total AS 'Total'
    FROM Pedidos
    WHERE PedidoId = @PedidoId
END
GO

CREATE PROCEDURE [dbo].[Pedidos_Insertar]
(
    @EmpleadoId INT, 
    @ClienteId INT, 
    @Nombre NVARCHAR(250),
    @Direccion1 NVARCHAR(300), 
    @Direccion2 NVARCHAR(300), 
    @Telefono NVARCHAR(50), 
    @Comentario NVARCHAR(300),
    @FechaPedido DATETIME,
    @Total DECIMAL(18,2)
)
AS
BEGIN
    INSERT Pedidos
    VALUES(
        @EmpleadoId, 
        @ClienteId, 
        @Nombre,
        @Direccion1, 
        @Direccion2, 
        @Telefono, 
        @Comentario,
        @FechaPedido,
        @Total
    )

    SELECT @@IDENTITY
END
GO

CREATE PROCEDURE [dbo].[Pedidos_Actualizar]
(
    @PedidoId INT,    
    @EmpleadoId INT, 
    @ClienteId INT, 
    @Nombre NVARCHAR(250),
    @Direccion1 NVARCHAR(300), 
    @Direccion2 NVARCHAR(300), 
    @Telefono NVARCHAR(50), 
    @Comentario NVARCHAR(300),
    @FechaPedido DATETIME
)
AS
BEGIN
    UPDATE Pedidos SET
        EmpleadoId = @EmpleadoId,
        ClienteId = @ClienteId,
        Nombre = @Nombre,
        Direccion1 = @Direccion1,
        Direccion2 = @Direccion2,
        Telefono = @Telefono,
        Comentario = @Comentario,
        FechaPedido = @FechaPedido
    WHERE PedidoId = @PedidoId
END
GO

CREATE PROCEDURE [dbo].[PedidoDetalles_Insertar]
(
    @PedidoId INT,
    @ProductoId INT,
    @NombreProducto NVARCHAR(100),
    @Cantidad INT,
    @Precio DECIMAL(18,2),
    @Subtotal DECIMAL(18,2)
)
AS
BEGIN
    DECLARE @Total DECIMAL(18,2)
    SET @Total = 0

    DECLARE @ErrorMessage NVARCHAR(500)
    SET @ErrorMessage = ''

    BEGIN TRANSACTION

    BEGIN TRY
        -- Actualizar cantidad disponible de productos, e insertar detalle del pedido (con la cantidad)
        UPDATE Productos SET
            Cantidad = Cantidad - @Cantidad
        WHERE ProductoId = @ProductoId

        INSERT PedidoDetalles
        VALUES(
            @PedidoId,
            @ProductoId,
            @NombreProducto,
            @Cantidad,
            @Precio,
            @Subtotal
        )

        SELECT @Total = SUM(Subtotal)
        FROM PedidoDetalles
        WHERE PedidoId = @PedidoId

        UPDATE Pedidos SET
            Total = @Total
        WHERE PedidoId = @PedidoId

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = 'Ocurrio un error, numero: ' 
            + ISNULL(CAST(Error_Number() AS NVARCHAR), '') + '. ' 
            + ' mensaje: '+ Error_Message()

        ROLLBACK TRANSACTION
    END CATCH

    SELECT 
        ISNULL(@@IDENTITY, 0) AS 'Pedido detalle id',
        @Total AS 'Total del pedido',
        @ErrorMessage AS 'Error message'
END
GO

CREATE PROCEDURE [dbo].[PedidoDetalles_Borrar]
(
    @PedidoDetalleId INT
)
AS
BEGIN
    DECLARE 
        @PedidoId INT,
        @ProductoId INT,
        @Cantidad DECIMAL(18,2)

    DECLARE @Total DECIMAL(18,2)
    SET @Total = 0

    DECLARE @ErrorMessage NVARCHAR(500)
    SET @ErrorMessage = ''

    BEGIN TRANSACTION

    BEGIN TRY

        SELECT 
            @PedidoId = PedidoId,
            @ProductoId = ProductoId,
            @Cantidad = Cantidad 
        FROM PedidoDetalles 
        WHERE PedidoDetalleId = @PedidoDetalleId

        -- Actualizar cantidad disponible de productos, y borrar detalle del pedido
        UPDATE Productos SET
            Cantidad = Cantidad + @Cantidad
        WHERE ProductoId = @ProductoId

        DELETE PedidoDetalles
        WHERE PedidoDetalleId = @PedidoDetalleId

        SELECT @Total = ISNULL(SUM(Subtotal), 0)
        FROM PedidoDetalles
        WHERE PedidoId = @PedidoId

        UPDATE Pedidos SET
            Total = @Total
        WHERE PedidoId = @PedidoId

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = 'Ocurrio un error, numero: ' 
            + ISNULL(CAST(Error_Number() AS NVARCHAR), '') + '. ' 
            + ' mensaje: '+ Error_Message()

        ROLLBACK TRANSACTION
    END CATCH

    SELECT 
        ISNULL(@@IDENTITY, 0) AS 'Pedido detalle id',
        @Total AS 'Total del pedido',
        @ErrorMessage AS 'Error message'
END
GO

CREATE PROCEDURE [dbo].[Pedidos_Borrar]
(
    @PedidoId INT
)
AS
BEGIN

    DECLARE @PedidoDetalleId INT

    
    DECLARE CursorPedidoDetalles CURSOR STATIC
    FOR 
        SELECT PedidoDetalleId
        FROM PedidoDetalles
        WHERE PedidoId = @PedidoId
    
    OPEN CursorPedidoDetalles

    FETCH NEXT FROM CursorPedidoDetalles
    INTO @PedidoDetalleId

    DECLARE @Row INT

    WHILE @@FETCH_STATUS = 0
    BEGIN

        EXEC PedidoDetalles_Borrar @PedidoDetalleId
    
        FETCH NEXT FROM CursorPedidoDetalles
        INTO @PedidoDetalleId
    END

    CLOSE CursorPedidoDetalles
    DEALLOCATE CursorPedidoDetalles

    DELETE Pedidos    
    WHERE PedidoId = @PedidoId
END
GO
        
---------------------------------------------------------------------
-- PROCEDURES Reportes
---------------------------------------------------------------------

CREATE PROCEDURE [dbo].[ObtenerPedidosPorCliente_Fechas]
AS
BEGIN

    CREATE TABLE #PedidosPorCliente_Fechas(
        ClienteId INT,
        NombreCliente NVARCHAR(300),
	    Total1 DECIMAL(18,2),
        FechaPedido1 NVARCHAR(10),
	    Total2 DECIMAL(18,2),
        FechaPedido2 NVARCHAR(10),
	    Total3 DECIMAL(18,2),
        FechaPedido3 NVARCHAR(10),
	    Total4 DECIMAL(18,2),
        FechaPedido4 NVARCHAR(10),
	    Total5 DECIMAL(18,2),
        FechaPedido5 NVARCHAR(10),
	    Total6 DECIMAL(18,2),
        FechaPedido6 NVARCHAR(10)
        )

    DECLARE CursorClientes CURSOR STATIC
    FOR SELECT 
        cli.ClienteId,
        CASE WHEN cli.TipoPersonaId = 1 THEN 
            cli.NombreEmpresa
        ELSE
            cli.Nombre + ' ' +  cli.ApellidoPaterno + ' ' + cli.ApellidoMaterno
        END AS NombreCliente    
    FROM
        Clientes cli 
    WHERE cli.ClienteId IN (
        SELECT DISTINCT ped.ClienteId FROM Pedidos ped
    )
    ORDER BY NombreCliente

    DECLARE
        @ClienteId INT,
        @NombreCliente NVARCHAR(300)

	DECLARE 
	    @Total DECIMAL(18,2),
	    @Total1 DECIMAL(18,2),
	    @Total2 DECIMAL(18,2),
	    @Total3 DECIMAL(18,2),
	    @Total4 DECIMAL(18,2),
	    @Total5 DECIMAL(18,2),
	    @Total6 DECIMAL(18,2),
        @FechaPedido NVARCHAR(10),
        @FechaPedido1 NVARCHAR(10),
        @FechaPedido2 NVARCHAR(10),
        @FechaPedido3 NVARCHAR(10),
        @FechaPedido4 NVARCHAR(10),
        @FechaPedido5 NVARCHAR(10),
        @FechaPedido6 NVARCHAR(10)

    OPEN CursorClientes

    FETCH NEXT FROM CursorClientes
    INTO @ClienteId, @NombreCliente

    DECLARE @Row INT

    WHILE @@FETCH_STATUS = 0
    BEGIN

        DECLARE CursorPedidosPorCliente CURSOR STATIC
        FOR 
        SELECT TOP 5
             ped.Total,
             dbo.ObtenerFechaFormato1(ped.FechaPedido)
        FROM Pedidos ped 
        WHERE ClienteId = @ClienteId
        ORDER BY ped.Total DESC
        
        OPEN CursorPedidosPorCliente

        FETCH NEXT FROM CursorPedidosPorCliente
        INTO @Total, @FechaPedido

        SET @Total1 = NULL
        SET @Total2 = NULL
        SET @Total3 = NULL
        SET @Total4 = NULL
        SET @Total5 = NULL
        SET @Total6 = NULL
        SET @FechaPedido1 = NULL
        SET @FechaPedido2 = NULL
        SET @FechaPedido3 = NULL
        SET @FechaPedido4 = NULL
        SET @FechaPedido5 = NULL
        SET @FechaPedido6 = NULL

        SET @Row = 1
        
        WHILE @@FETCH_STATUS = 0
        BEGIN
    
            IF @Row = 1
            BEGIN
                SET @Total1 = @Total
                SET @FechaPedido1 = @FechaPedido
            END
            ELSE IF @Row = 2
            BEGIN
                SET @Total2 = @Total
                SET @FechaPedido2 = @FechaPedido
            END
            ELSE IF @Row = 3
            BEGIN
                SET @Total3 = @Total
                SET @FechaPedido3 = @FechaPedido
            END
            ELSE IF @Row = 4
            BEGIN
                SET @Total4 = @Total
                SET @FechaPedido4 = @FechaPedido
            END
            ELSE IF @Row = 5
            BEGIN
                SET @Total5 = @Total
                SET @FechaPedido5 = @FechaPedido
            END
            ELSE IF @Row = 6
            BEGIN
                SET @Total6 = @Total
                SET @FechaPedido6 = @FechaPedido
            END

            SET @Row = @Row + 1

            FETCH NEXT FROM CursorPedidosPorCliente
            INTO @Total, @FechaPedido
        END
        
        INSERT INTO #PedidosPorCliente_Fechas
            SELECT @ClienteId, @NombreCliente, 
                @Total1, @FechaPedido1, 
                @Total2, @FechaPedido2,
                @Total3, @FechaPedido3,
                @Total4, @FechaPedido4,
                @Total5, @FechaPedido5,
                @Total6, @FechaPedido6

        CLOSE CursorPedidosPorCliente
        DEALLOCATE CursorPedidosPorCliente
              
        FETCH NEXT FROM CursorClientes
        INTO @ClienteId, @NombreCliente
    END

    CLOSE CursorClientes
    DEALLOCATE CursorClientes

    SELECT
        ClienteId AS 'Id cliente',
        NombreCliente AS 'Nombre cliente',
	    dbo.ObtenerDecimalFormato1(ISNULL(Total1, 0)) AS 'Total 1',
        ISNULL(FechaPedido1, '') AS 'Fecha pedido 1',
	    dbo.ObtenerDecimalFormato1(ISNULL(Total2, 0)) AS 'Total 2',
        ISNULL(FechaPedido2, '') AS 'Fecha pedido 2',
	    dbo.ObtenerDecimalFormato1(ISNULL(Total3, 0)) AS 'Total 3',
        ISNULL(FechaPedido3, '') AS 'Fecha pedido 3',
	    dbo.ObtenerDecimalFormato1(ISNULL(Total4, 0)) AS 'Total 4',
        ISNULL(FechaPedido4, '') AS 'Fecha pedido 4',
	    dbo.ObtenerDecimalFormato1(ISNULL(Total5, 0)) AS 'Total 5',
        ISNULL(FechaPedido5, '') AS 'Fecha pedido 5',
	    dbo.ObtenerDecimalFormato1(ISNULL(Total6, 0)) AS 'Total 6',
        ISNULL(FechaPedido6, '') AS 'Fecha pedido 6'
    FROM #PedidosPorCliente_Fechas 
    ORDER BY NombreCliente

    RETURN 0
END
GO

CREATE PROCEDURE [dbo].[ObtenerPedidosPorEmpleado]
AS
BEGIN
    SELECT *
    FROM [EmpleadosPedidos_Vista]
    ORDER BY 1
END
GO


---------------------------------------------------------------------
-- INSERTS
---------------------------------------------------------------------

INSERT Clientes VALUES(1, 'Empresa 1', null, null, null, 'Dirección empresa 1', null, '555-0180', null)
INSERT Clientes VALUES(2, null, 'Emily', 'Jordan', 'Williams', 'Dirección persona 2', null, '555-0181', null)
INSERT Clientes VALUES(1, 'Empresa 3', null, null, null, 'Dirección empresa 3', null, '555-0182', null)
INSERT Clientes VALUES(1, 'Empresa 4', null, null, null, 'Dirección empresa 4', null, '555-0183', null)
INSERT Clientes VALUES(1, 'Empresa 5', null, null, null, 'Dirección empresa 5', null, '555-0184', null)
INSERT Clientes VALUES(1, 'Empresa 6', null, null, null, 'Dirección empresa 6', null, '555-0185', null)
INSERT Clientes VALUES(1, 'Empresa 7', null, null, null, 'Dirección empresa 7', null, '555-0186', null)
INSERT Clientes VALUES(1, 'Empresa 8', null, null, null, 'Dirección empresa 8', null, '555-0187', null)


INSERT Empleados VALUES('Charlotte', 'Smith', 'Johnson')
INSERT Empleados VALUES('Madison', 'Brown', 'Wilson')
INSERT Empleados VALUES('Elizabeth', 'Miller', 'Davis')
INSERT Empleados VALUES('William', 'Wilson', 'Brown')
INSERT Empleados VALUES('Liam', 'Taylor', 'Smith')
INSERT Empleados VALUES('Michael', 'Moore', 'Williams')

INSERT Productos VALUES('Producto 1', 400, 10)
INSERT Productos VALUES('Producto 2', 500, 10)
INSERT Productos VALUES('Producto 3', 600, 10)
INSERT Productos VALUES('Producto 4', 700, 10)
INSERT Productos VALUES('Producto 5', 800, 10)
INSERT Productos VALUES('Producto 6', 900, 10)

INSERT Pedidos VALUES(1, 1, 'Empresa 1', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250114', 100)
INSERT Pedidos VALUES(2, 1, 'Empresa 1', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250215', 150)
INSERT Pedidos VALUES(3, 1, 'Empresa 1', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250216', 190)
INSERT Pedidos VALUES(4, 1, 'Empresa 1', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250217', 120)
INSERT Pedidos VALUES(5, 1, 'Empresa 1', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250218', 160)
INSERT Pedidos VALUES(6, 1, 'Empresa 1', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250219', 140)
INSERT Pedidos VALUES(1, 1, 'Empresa 1', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250220', 210)

INSERT Pedidos VALUES(2, 3, 'Empresa 3', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250314', 200)
INSERT Pedidos VALUES(3, 3, 'Empresa 3', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250315', 250)
INSERT Pedidos VALUES(4, 3, 'Empresa 3', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250316', 290)
INSERT Pedidos VALUES(5, 3, 'Empresa 3', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250317', 220)
INSERT Pedidos VALUES(6, 3, 'Empresa 3', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250318', 260)
INSERT Pedidos VALUES(1, 3, 'Empresa 3', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250319', 240)
INSERT Pedidos VALUES(2, 3, 'Empresa 3', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250320', 310)

INSERT Pedidos VALUES(3, 4, 'Empresa 4', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250414', 100)
INSERT Pedidos VALUES(4, 4, 'Empresa 4', 'Dir 1', 'Dir 2', '555', 'Comentario', '20250415', 150)


INSERT PedidoDetalles VALUES(1, 1, 'Producto 1', 5, 10, 50)
INSERT PedidoDetalles VALUES(1, 2, 'Producto 2', 5, 10, 50)

INSERT PedidoDetalles VALUES(2, 1, 'Producto 1', 5, 10, 50)
INSERT PedidoDetalles VALUES(2, 2, 'Producto 2', 5, 10, 50)
INSERT PedidoDetalles VALUES(2, 3, 'Producto 3', 5, 10, 50)

INSERT PedidoDetalles VALUES(3, 1, 'Producto 1', 19, 10, 190)
INSERT PedidoDetalles VALUES(4, 1, 'Producto 1', 12, 10, 120)
INSERT PedidoDetalles VALUES(5, 1, 'Producto 1', 16, 10, 160)
INSERT PedidoDetalles VALUES(6, 1, 'Producto 1', 14, 10, 140)
INSERT PedidoDetalles VALUES(7, 1, 'Producto 1', 21, 10, 210)

INSERT PedidoDetalles VALUES(8, 1, 'Producto 1', 20, 10, 200)
INSERT PedidoDetalles VALUES(9, 1, 'Producto 1', 25, 10, 250)
INSERT PedidoDetalles VALUES(10, 1, 'Producto 1', 29, 10, 290)
INSERT PedidoDetalles VALUES(11, 1, 'Producto 1', 22, 10, 220)
INSERT PedidoDetalles VALUES(12, 1, 'Producto 1', 26, 10, 260)
INSERT PedidoDetalles VALUES(13, 1, 'Producto 1', 24, 10, 240)
INSERT PedidoDetalles VALUES(14, 1, 'Producto 1', 31, 10, 310)

INSERT PedidoDetalles VALUES(15, 1, 'Producto 1', 1, 10, 10)
INSERT PedidoDetalles VALUES(15, 2, 'Producto 2', 1, 10, 10)
INSERT PedidoDetalles VALUES(15, 3, 'Producto 3', 1, 10, 10)
INSERT PedidoDetalles VALUES(15, 4, 'Producto 4', 7, 10, 70)

INSERT PedidoDetalles VALUES(16, 1, 'Producto 1', 1, 10, 10)
INSERT PedidoDetalles VALUES(16, 2, 'Producto 2', 1, 10, 10)
INSERT PedidoDetalles VALUES(16, 3, 'Producto 3', 1, 10, 10)
INSERT PedidoDetalles VALUES(16, 4, 'Producto 4', 1, 10, 10)
INSERT PedidoDetalles VALUES(16, 5, 'Producto 5', 11, 10, 110)


---------------------------------------------------------------------
-- EXEC PROCEDURE Reporte
---------------------------------------------------------------------

-- exec [dbo].[ObtenerPedidosPorCliente_Fechas]


