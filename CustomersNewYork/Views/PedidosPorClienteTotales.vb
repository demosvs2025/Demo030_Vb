Public Class PedidosPorClienteTotales

    Private Sub BuscarPedidosPorCliente()
        Dim dataTable As New DataTable
        Dim sqlPedidosPorCliente As New SqlPedidosPorCliente()
        dataTable = sqlPedidosPorCliente.ObtenerPedidosPorClienteTotales()
        DataGridViewPedidosPorCliente.DataSource = dataTable
        DataGridViewPedidosPorCliente.AutoResizeColumns()
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        BuscarPedidosPorCliente()
    End Sub

    Private Sub ButtonVistaPreliminar_Click(sender As Object, e As EventArgs) Handles ButtonVistaPreliminar.Click

    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
End Class