Imports Microsoft.Data.SqlClient
Public Class SqlProductos
    Public Function ObtenerProductos(textoBuscar As String)
        Dim conexionSql As New ConexionSql()

        Dim cmdText As String
        cmdText = "Productos_Obtener"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@NombreProducto", textoBuscar)

        Dim dataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Function ObtenerProducto(productoId As Integer)
        Dim conexionSql As New ConexionSql()

        Dim cmdText As String
        cmdText = "Productos_ObtenerPorId"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@ProductoId", productoId)

        Dim dataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Sub InsertarProducto(producto As Models.Producto)
        Dim conexionSql As New ConexionSql()
        Dim cmdText As String
        cmdText = "Productos_Insertar"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto)
        command.Parameters.AddWithValue("@Cantidad", producto.Cantidad)
        command.Parameters.AddWithValue("@Precio", producto.Precio)

        command.Connection.Open()
        command.ExecuteNonQuery()
        command.Connection.Close()
    End Sub

    Public Sub ActualizarProducto(producto As Models.Producto)
        Dim conexionSql As New ConexionSql()
        Dim cmdText As String
        cmdText = "Productos_Actualizar"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@ProductoId", producto.ProductoId)
        command.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto)
        command.Parameters.AddWithValue("@Cantidad", producto.Cantidad)
        command.Parameters.AddWithValue("@Precio", producto.Precio)

        command.Connection.Open()
        command.ExecuteNonQuery()
        command.Connection.Close()
    End Sub

    Public Sub BorrarProducto(productoId As Integer)
        Dim conexionSql As New ConexionSql()
        Dim cmdText As String
        cmdText = "Productos_Borrar"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@ProductoId", productoId)

        command.Connection.Open()
        command.ExecuteNonQuery()
        command.Connection.Close()
    End Sub

    Public Function ObtenerProductosCombo1()
        Dim conexionSql As New ConexionSql()

        Dim cmdText As String
        cmdText = "Productos_ObtenerCombo1"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure

        Dim dataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function
End Class
