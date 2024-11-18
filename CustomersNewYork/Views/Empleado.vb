Public Class Empleado
    Private empleadoIdValue As Integer

    Public Property EmpleadoId() As Integer
        Get
            Return empleadoIdValue
        End Get
        Set(ByVal value As Integer)
            empleadoIdValue = value
        End Set
    End Property

    Public Sub InicializarForm()
        TextBoxEmpleadoId.Text = empleadoIdValue.ToString()

        If empleadoIdValue > 0 Then
            LabelTitulo.Text = "Editar empleado"
            ObtenerEmpleado()
        End If
    End Sub

    Public Sub ObtenerEmpleado()
        Dim dataTable As New DataTable
        Dim sqlEmpleados As New SqlEmpleados()
        dataTable = sqlEmpleados.ObtenerEmpleado(empleadoIdValue)

        Dim Nombre As String = dataTable.Rows(0)(0).ToString()
        Dim ApellidoPaterno As String = dataTable.Rows(0)(1).ToString()
        Dim ApellidoMaterno As String = dataTable.Rows(0)(2).ToString()

        TextBoxNombre.Text = Nombre
        TextBoxApellidoPaterno.Text = ApellidoPaterno
        TextBoxApellidoMaterno.Text = ApellidoMaterno
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim sqlEmpleados As New SqlEmpleados()
        Dim empleado As New Models.Empleado

        empleado.EmpleadoId = 0
        empleado.Nombre = TextBoxNombre.Text
        empleado.ApellidoPaterno = TextBoxApellidoPaterno.Text
        empleado.ApellidoMaterno = TextBoxApellidoMaterno.Text

        If empleadoIdValue > 0 Then
            empleado.EmpleadoId = empleadoIdValue

            sqlEmpleados.ActualizarEmpleado(empleado)
        Else
            sqlEmpleados.InsertarEmpleado(empleado)
        End If
        MessageBox.Show("El empleado se guardó.")
        Me.Close()
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarForm()
    End Sub
End Class