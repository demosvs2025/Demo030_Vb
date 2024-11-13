Public Class Clientes
    Private Sub ButtonBuscarCliente_Click(sender As Object, e As EventArgs) Handles ButtonBuscarCliente.Click
        BuscarCliente()
    End Sub
    Private Sub BuscarCliente()
        Dim dataTable As New DataTable
        Dim textoBuscar As String
        textoBuscar = TextBoxBuscarCliente.Text.Trim()

        Dim sqlClientes As New SqlClientes()
        dataTable = sqlClientes.ObtenerClientes(textoBuscar)
        DataGridViewClientes.DataSource = dataTable
    End Sub
    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        Dim clienteForm As New Cliente()
        clienteForm.ShowDialog()
        BuscarCliente()
    End Sub
    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Dim clienteIdSelected As Integer

        If DataGridViewClientes.Rows.Count > 0 _
            And DataGridViewClientes.SelectedRows.Count > 0 Then
            Dim selectedId As String
            selectedId = DataGridViewClientes.SelectedRows(0).Cells(0).Value.ToString()

            clienteIdSelected = Integer.Parse(selectedId)
        End If

        Dim clienteForm As New Cliente()
        clienteForm.ClienteId = clienteIdSelected
        clienteForm.ShowDialog()
        BuscarCliente()
    End Sub
    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        Dim sqlClientes As New SqlClientes()
        Dim clienteIdSelected As Integer

        If DataGridViewClientes.Rows.Count > 0 _
            And DataGridViewClientes.SelectedRows.Count > 0 Then
            Dim selectedId As String
            selectedId = DataGridViewClientes.SelectedRows(0).Cells(0).Value.ToString()

            clienteIdSelected = Integer.Parse(selectedId)

            sqlClientes.BorrarCliente(clienteIdSelected)
            MessageBox.Show("El cliente se borró.")
            BuscarCliente()
        End If
    End Sub
    Private Sub DataGridViewClientes_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewClientes.SelectionChanged

    End Sub
    Private Sub DataGridViewClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewClientes.CellContentClick

    End Sub

    Private Sub ButtonReporteClientes_Click(sender As Object, e As EventArgs) Handles ButtonReporteClientes.Click
        Dim clientesReporteForm As New ClientesReporte()
        clientesReporteForm.ShowDialog()
    End Sub
End Class