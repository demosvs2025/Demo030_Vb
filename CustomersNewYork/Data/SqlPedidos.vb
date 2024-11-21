Imports Microsoft.Data.SqlClient
Public Class SqlPedidos
    Public Function ObtenerPedidos(nombreEmpleado As String, nombreCliente As String)
        Dim conexionSql As New ConexionSql()

        Dim cmdText As String
        cmdText = "Pedidos_Obtener"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@NombreEmpleado", nombreEmpleado)
        command.Parameters.AddWithValue("@NombreCliente", nombreCliente)

        Dim dataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Function ObtenerPedidoDetalles(pedidoId As Integer)
        Dim conexionSql As New ConexionSql()

        Dim cmdText As String
        cmdText = "PedidoDetalles_ObtenerPorId"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@PedidoId", pedidoId)

        Dim dataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Function ObtenerPedido(pedidoId As Integer)
        Dim conexionSql As New ConexionSql()

        Dim cmdText As String
        cmdText = "Pedidos_ObtenerPorId"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@PedidoId", pedidoId)

        Dim dataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Function InsertarPedido(pedido As Models.Pedido)
        Dim conexionSql As New ConexionSql()
        Dim cmdText As String
        cmdText = "Pedidos_Insertar"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@EmpleadoId", pedido.EmpleadoId)
        command.Parameters.AddWithValue("@ClienteId", pedido.ClienteId)
        command.Parameters.AddWithValue("@Nombre", pedido.Nombre)
        command.Parameters.AddWithValue("@Direccion1", pedido.Direccion1)
        command.Parameters.AddWithValue("@Direccion2", pedido.Direccion2)
        command.Parameters.AddWithValue("@Telefono", pedido.Telefono)
        command.Parameters.AddWithValue("@Comentario", pedido.Comentario)
        command.Parameters.AddWithValue("@FechaPedido", pedido.FechaPedido)
        command.Parameters.AddWithValue("@Total", pedido.Total)

        Dim dataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Function InsertarPedidoDetalle(pedidoDetalle As Models.PedidoDetalle)
        Dim conexionSql As New ConexionSql()
        Dim cmdText As String
        cmdText = "PedidoDetalles_Insertar"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@PedidoId", pedidoDetalle.PedidoId)
        command.Parameters.AddWithValue("@ProductoId", pedidoDetalle.ProductoId)
        command.Parameters.AddWithValue("@NombreProducto", pedidoDetalle.NombreProducto)
        command.Parameters.AddWithValue("@Cantidad", pedidoDetalle.Cantidad)
        command.Parameters.AddWithValue("@Precio", pedidoDetalle.Precio)
        command.Parameters.AddWithValue("@Subtotal", pedidoDetalle.Subtotal)

        Dim dataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Sub ActualizarPedido(Pedido As Models.Pedido)
        Dim conexionSql As New ConexionSql()
        Dim cmdText As String
        cmdText = "Pedidos_Actualizar"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@PedidoId", Pedido.PedidoId)
        command.Parameters.AddWithValue("@EmpleadoId", Pedido.EmpleadoId)
        command.Parameters.AddWithValue("@ClienteId", Pedido.ClienteId)
        command.Parameters.AddWithValue("@Nombre", Pedido.Nombre)
        command.Parameters.AddWithValue("@Direccion1", Pedido.Direccion1)
        command.Parameters.AddWithValue("@Direccion2", Pedido.Direccion2)
        command.Parameters.AddWithValue("@Telefono", Pedido.Telefono)
        command.Parameters.AddWithValue("@Comentario", Pedido.Comentario)
        command.Parameters.AddWithValue("@FechaPedido", Pedido.FechaPedido)

        command.Connection.Open()
        command.ExecuteNonQuery()
        command.Connection.Close()
    End Sub

    Public Sub BorrarPedido(pedidoId As Integer)
        Dim conexionSql As New ConexionSql()
        Dim cmdText As String
        cmdText = "Pedidos_Borrar"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@PedidoId", pedidoId)

        command.Connection.Open()
        command.ExecuteNonQuery()
        command.Connection.Close()
    End Sub

    Public Function BorrarPedidoDetalle(pedidoDetalleId As Integer)
        Dim conexionSql As New ConexionSql()
        Dim cmdText As String
        cmdText = "PedidoDetalles_Borrar"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@PedidoDetalleId", pedidoDetalleId)

        Dim dataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function
End Class
