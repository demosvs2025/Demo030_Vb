Imports Microsoft.Data.SqlClient
Public Class SqlEmpleados
    Public Function ObtenerEmpleados(textoBuscar As String)
        Dim conexionSql As New ConexionSql()

        Dim cmdText As String
        cmdText = "Empleados_Obtener"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Nombre", textoBuscar)

        Dim dataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Function ObtenerEmpleado(empleadoId As Integer)
        Dim conexionSql As New ConexionSql()

        Dim cmdText As String
        cmdText = "Empleados_ObtenerPorId"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@EmpleadoId", empleadoId)

        Dim dataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function

    Public Sub InsertarEmpleado(empleado As Models.Empleado)
        Dim conexionSql As New ConexionSql()
        Dim cmdText As String
        cmdText = "Empleados_Insertar"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Nombre", empleado.Nombre)
        command.Parameters.AddWithValue("@ApellidoPaterno", empleado.ApellidoPaterno)
        command.Parameters.AddWithValue("@ApellidoMaterno", empleado.ApellidoMaterno)

        command.Connection.Open()
        command.ExecuteNonQuery()
        command.Connection.Close()
    End Sub

    Public Sub ActualizarEmpleado(empleado As Models.Empleado)
        Dim conexionSql As New ConexionSql()
        Dim cmdText As String
        cmdText = "Empleados_Actualizar"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@EmpleadoId", empleado.EmpleadoId)
        command.Parameters.AddWithValue("@Nombre", empleado.Nombre)
        command.Parameters.AddWithValue("@ApellidoPaterno", empleado.ApellidoPaterno)
        command.Parameters.AddWithValue("@ApellidoMaterno", empleado.ApellidoMaterno)

        command.Connection.Open()
        command.ExecuteNonQuery()
        command.Connection.Close()
    End Sub

    Public Sub BorrarEmpleado(empleadoId As Integer)
        Dim conexionSql As New ConexionSql()
        Dim cmdText As String
        cmdText = "Empleados_Borrar"

        Dim command As New SqlCommand(cmdText, conexionSql.ObtenerSqlConnection())
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@EmpleadoId", empleadoId)

        command.Connection.Open()
        command.ExecuteNonQuery()
        command.Connection.Close()
    End Sub
End Class
