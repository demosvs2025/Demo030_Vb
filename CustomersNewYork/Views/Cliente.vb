Public Class Cliente
    Private ClienteIdValue As Integer
    Public Property ClienteId() As Integer
        Get
            Return ClienteIdValue
        End Get
        Set(ByVal value As Integer)
            ClienteIdValue = value
        End Set
    End Property
    Public Sub InicializarForm()
        TextBoxClienteId.Text = ClienteIdValue.ToString()

        If ClienteIdValue > 0 Then
            LabelTitulo.Text = "Editar cliente"
            ObtenerCliente()
        Else
            NuevoCliente()
        End If
    End Sub
    Public Sub ObtenerCliente()
        Dim dataTable As New DataTable
        Dim sqlClientes As New SqlClientes()
        dataTable = sqlClientes.ObtenerCliente(ClienteIdValue)

        Dim TipoPersonaId As String = dataTable.Rows(0)(1).ToString()
        Dim NombreEmpresa As String = dataTable.Rows(0)(2).ToString()
        Dim Nombre As String = dataTable.Rows(0)(3).ToString()
        Dim ApellidoPaterno As String = dataTable.Rows(0)(4).ToString()
        Dim ApellidoMaterno As String = dataTable.Rows(0)(5).ToString()
        Dim Direccion1 As String = dataTable.Rows(0)(6).ToString()
        Dim Direccion2 As String = dataTable.Rows(0)(7).ToString()
        Dim Telefono As String = dataTable.Rows(0)(8).ToString()
        Dim Comentario As String = dataTable.Rows(0)(9).ToString()

        If Integer.Parse(TipoPersonaId) = 1 Then
            RadioButtonTipoPersona1.Checked = True
        Else
            RadioButtonTipoPersona2.Checked = True
        End If
        TextBoxNombreEmpresa.Text = NombreEmpresa
        TextBoxNombre.Text = Nombre
        TextBoxApellidoPaterno.Text = ApellidoPaterno
        TextBoxApellidoMaterno.Text = ApellidoMaterno
        TextBoxDireccion1.Text = Direccion1
        TextBoxDireccion2.Text = Direccion2
        TextBoxTelefono.Text = Telefono
        TextBoxComentario.Text = Comentario
    End Sub
    Public Sub NuevoCliente()
        RadioButtonTipoPersona1.Checked = True
    End Sub
    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim sqlClientes As New SqlClientes()
        Dim cliente As New Models.Cliente

        cliente.ClienteId = 0
        If RadioButtonTipoPersona1.Checked Then
            cliente.TipoPersonaId = 1
        Else
            cliente.TipoPersonaId = 2
        End If
        cliente.NombreEmpresa = TextBoxNombreEmpresa.Text
        cliente.Nombre = TextBoxNombre.Text
        cliente.ApellidoPaterno = TextBoxApellidoPaterno.Text
        cliente.ApellidoMaterno = TextBoxApellidoMaterno.Text
        cliente.Direccion1 = TextBoxDireccion1.Text
        cliente.Direccion2 = TextBoxDireccion2.Text
        cliente.Telefono = TextBoxTelefono.Text
        cliente.Comentario = TextBoxComentario.Text

        If ClienteIdValue > 0 Then
            cliente.ClienteId = ClienteIdValue

            sqlClientes.ActualizarCliente(cliente)
        Else
            sqlClientes.InsertarCliente(cliente)
        End If
        MessageBox.Show("El cliente se guardó.")
        Me.Close()
    End Sub
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarForm()
    End Sub
    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub
End Class