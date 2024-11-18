Public Class Empleados
    Private Sub ButtonBuscarEmpleados_Click(sender As Object, e As EventArgs) Handles ButtonBuscarEmpleados.Click
        BuscarEmpleados()
    End Sub
    Private Sub BuscarEmpleados()
        Dim dataTable As New DataTable
        Dim textoBuscar As String
        textoBuscar = TextBoxBuscarEmpleados.Text.Trim()

        Dim sqlEmpleados As New SqlEmpleados()
        dataTable = sqlEmpleados.ObtenerEmpleados(textoBuscar)
        DataGridViewEmpleados.DataSource = dataTable
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        Dim empleadoForm As New Empleado()
        empleadoForm.ShowDialog()
        BuscarEmpleados()
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Dim empleadoIdSelected As Integer

        If DataGridViewEmpleados.Rows.Count > 0 _
            And DataGridViewEmpleados.SelectedRows.Count > 0 Then
            Dim selectedId As String
            selectedId = DataGridViewEmpleados.SelectedRows(0).Cells(0).Value.ToString()

            empleadoIdSelected = Integer.Parse(selectedId)
        End If

        Dim empleadoForm As New Empleado()
        empleadoForm.EmpleadoId = empleadoIdSelected
        empleadoForm.ShowDialog()
        BuscarEmpleados()
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        Dim sqlEmpleados As New SqlEmpleados()
        Dim empleadoIdSelected As Integer

        If DataGridViewEmpleados.Rows.Count > 0 _
            And DataGridViewEmpleados.SelectedRows.Count > 0 Then
            Dim selectedId As String
            selectedId = DataGridViewEmpleados.SelectedRows(0).Cells(0).Value.ToString()

            empleadoIdSelected = Integer.Parse(selectedId)

            sqlEmpleados.BorrarEmpleado(empleadoIdSelected)
            MessageBox.Show("El empleado se borró.")
            BuscarEmpleados()
        End If
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
End Class