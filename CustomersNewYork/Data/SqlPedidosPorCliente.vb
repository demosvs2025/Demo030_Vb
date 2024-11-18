Imports Microsoft.Data.SqlClient

Public Class SqlPedidosPorCliente
    Public Function ObtenerPedidosPorClienteTotales()
        Dim conexionSql As New ConexionSql()

        Dim cmdText As String
        cmdText = "ObtenerPedidosPorCliente_Fechas"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure

        Dim dataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function

End Class
