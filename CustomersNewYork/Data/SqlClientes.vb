Imports Microsoft.Data.SqlClient
Public Class SqlClientes
    Public Function ObtenerClientes(textoBuscar As String)
        Dim conexionSql As New ConexionSql()

        Dim cmdText As String
        cmdText = "select " _
             & " ClienteId as 'Id cliente', " _
             & " case when TipoPersonaId = 1 then 'Persona Moral' else 'Persona Fisica' end as 'Tipo Persona', " _
             & " NombreEmpresa as 'Nombre empresa', " _
             & " Nombre, " _
             & " ApellidoPaterno as 'Apellido paterno', " _
             & " ApellidoMaterno as 'Apellido materno', " _
             & " Direccion1 as 'Dirección 1', " _
             & " Direccion2 as 'Dirección 2', " _
             & " Telefono, " _
             & " Comentario " _
             & " from Clientes " _
             & " where (isnull(NombreEmpresa, '') like '%" + textoBuscar + "%' " _
             & "       or (isnull(Nombre, '') +  ' ' " _
             & "           + isnull(ApellidoPaterno, '') +  ' ' " _
             & "           + isnull(ApellidoMaterno, ''))  like '%" + textoBuscar + "%') " _
             & " order by ClienteId"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        Dim dataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function
    Public Function ObtenerCliente(clienteId As Integer)
        Dim conexionSql As New ConexionSql()

        Dim cmdText As String
        cmdText = "select * from Clientes " _
             & " where ClienteId = " + clienteId.ToString()

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        Dim dataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function
    Public Sub InsertarCliente(cliente As Models.Cliente)
        Dim conexionSql As New ConexionSql()

        Dim cmdText As String
        cmdText = "insert Clientes values(" _
             & " " + cliente.TipoPersonaId.ToString() + "," _
             & " '" + cliente.NombreEmpresa + "'," _
             & " '" + cliente.Nombre + "'," _
             & " '" + cliente.ApellidoPaterno + "'," _
             & " '" + cliente.ApellidoMaterno + "'," _
             & " '" + cliente.Direccion1 + "'," _
             & " '" + cliente.Direccion2 + "'," _
             & " '" + cliente.Telefono + "'," _
             & " '" + cliente.Comentario + "'" _
             & " ) "

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.Connection.Open()
        command.ExecuteNonQuery()
        command.Connection.Close()
    End Sub
    Public Sub ActualizarCliente(cliente As Models.Cliente)
        Dim conexionSql As New ConexionSql()

        Dim cmdText As String
        cmdText = "update Clientes set " _
             & " TipoPersonaId = " + cliente.TipoPersonaId.ToString() + ", " _
             & " NombreEmpresa = '" + cliente.NombreEmpresa + "', " _
             & " Nombre = '" + cliente.Nombre + "', " _
             & " ApellidoPaterno = '" + cliente.ApellidoPaterno + "', " _
             & " ApellidoMaterno = '" + cliente.ApellidoMaterno + "', " _
             & " Direccion1 = '" + cliente.Direccion1 + "', " _
             & " Direccion2 = '" + cliente.Direccion2 + "', " _
             & " Telefono = '" + cliente.Telefono + "', " _
             & " Comentario = '" + cliente.Comentario + "' " _
             & " where ClienteId = " + cliente.ClienteId.ToString()

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.Connection.Open()
        command.ExecuteNonQuery()
        command.Connection.Close()
    End Sub
    Public Sub BorrarCliente(clienteId As Integer)
        Dim conexionSql As New ConexionSql()

        Dim cmdText As String
        cmdText = "delete Clientes " _
             & " where ClienteId = " + clienteId.ToString()

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.Connection.Open()
        command.ExecuteNonQuery()
        command.Connection.Close()
    End Sub
End Class
