Public Class PedidosPorEmpleado
    Private Sub BuscarPedidosPorEmpleado()
        Dim dataTable As New DataTable
        Dim sqlPedidosPorEmpleado As New SqlPedidosPorEmpleado()
        dataTable = sqlPedidosPorEmpleado.ObtenerPedidosPorEmpleado()
        DataGridViewPedidosPorEmpleado.DataSource = dataTable
        DataGridViewPedidosPorEmpleado.AutoResizeColumns()
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        BuscarPedidosPorEmpleado()
    End Sub

    Private Sub ButtonVistaPreliminar_Click(sender As Object, e As EventArgs) Handles ButtonVistaPreliminar.Click

    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
End Class