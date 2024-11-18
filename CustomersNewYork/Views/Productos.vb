Imports CustomersNewYork.Models

Public Class Productos
    Private Sub ButtonBuscarProductos_Click(sender As Object, e As EventArgs) Handles ButtonBuscarProductos.Click
        BuscarProductos()
    End Sub
    Private Sub BuscarProductos()
        Dim dataTable As New DataTable
        Dim textoBuscar As String
        textoBuscar = TextBoxBuscarProducto.Text.Trim()

        Dim sqlProductos As New SqlProductos()
        dataTable = sqlProductos.ObtenerProductos(textoBuscar)
        DataGridViewProductos.DataSource = dataTable
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        Dim productoForm As New Producto()
        productoForm.ShowDialog()
        BuscarProductos()
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Dim productoIdSelected As Integer

        If DataGridViewProductos.Rows.Count > 0 _
            And DataGridViewProductos.SelectedRows.Count > 0 Then
            Dim selectedId As String
            selectedId = DataGridViewProductos.SelectedRows(0).Cells(0).Value.ToString()

            productoIdSelected = Integer.Parse(selectedId)
        End If

        Dim productoForm As New Producto()
        productoForm.ProductoId = productoIdSelected
        productoForm.ShowDialog()
        BuscarProductos()
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        Dim sqlProductos As New SqlProductos()
        Dim productoIdSelected As Integer

        If DataGridViewProductos.Rows.Count > 0 _
            And DataGridViewProductos.SelectedRows.Count > 0 Then
            Dim selectedId As String
            selectedId = DataGridViewProductos.SelectedRows(0).Cells(0).Value.ToString()

            productoIdSelected = Integer.Parse(selectedId)

            sqlProductos.BorrarProducto(productoIdSelected)
            MessageBox.Show("El producto se borró.")
            BuscarProductos()
        End If
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
End Class