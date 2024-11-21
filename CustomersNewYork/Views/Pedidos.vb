Public Class Pedidos
    Private Sub ButtonBuscarPedidos_Click(sender As Object, e As EventArgs) Handles ButtonBuscarPedidos.Click
        BuscarPedidos()
    End Sub
    Private Sub BuscarPedidos()
        Dim dataTable As New DataTable
        Dim buscarNombreEmpleado As String
        Dim buscarNombreCliente As String
        buscarNombreEmpleado = TextBoxBuscarNombreEmpleado.Text.Trim()
        buscarNombreCliente = TextBoxBuscarNombreCliente.Text.Trim()

        Dim sqlPedidos As New SqlPedidos()
        dataTable = sqlPedidos.ObtenerPedidos(buscarNombreEmpleado, buscarNombreCliente)
        DataGridViewPedidos.DataSource = dataTable

        If DataGridViewPedidos.Rows.Count > 0 Then
            DataGridViewPedidos.Rows(0).Selected = True

            BuscarPedidoDetalles()
        End If
    End Sub
    Private Sub DataGridViewPedidos_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewPedidos.SelectionChanged
        BuscarPedidoDetalles()
    End Sub
    Private Function PedidoSeleccionado()
        Dim pedidoIdSelected As Integer

        If DataGridViewPedidos.Rows.Count > 0 _
                And DataGridViewPedidos.SelectedRows.Count > 0 Then
            Dim selectedId As String
            selectedId = DataGridViewPedidos.SelectedRows(0).Cells(0).Value.ToString()

            pedidoIdSelected = Integer.Parse(selectedId)
        End If
        Return pedidoIdSelected
    End Function
    Private Sub BuscarPedidoDetalles()
        Dim pedidoIdSelected As Integer
        pedidoIdSelected = PedidoSeleccionado()

        Dim dataTable As New DataTable

        Dim sqlPedidos As New SqlPedidos()
        dataTable = sqlPedidos.ObtenerPedidoDetalles(pedidoIdSelected)
        DataGridViewPedidoDetalles.DataSource = dataTable
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        Dim pedidoForm As New Pedido()
        pedidoForm.ShowDialog()
        BuscarPedidos()
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Dim pedidoIdSelected As Integer
        pedidoIdSelected = PedidoSeleccionado()

        Dim pedidoForm As New Pedido()
        pedidoForm.PedidoId = pedidoIdSelected
        pedidoForm.ShowDialog()
        BuscarPedidos()
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        Dim sqlPedidos As New SqlPedidos()

        Dim pedidoIdSelected As Integer
        pedidoIdSelected = PedidoSeleccionado()

        If pedidoIdSelected > 0 Then
            sqlPedidos.BorrarPedido(pedidoIdSelected)
            MessageBox.Show("El pedido se borró.")
            BuscarPedidos()
        End If
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
End Class