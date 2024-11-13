Imports Microsoft.Data.SqlClient

Public Class ConexionSql
    Public Function ObtenerSqlConnection()
        Dim connectionString As String
        connectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Demo030_Vb_Database\CustomersNewYork.mdf;Integrated Security=True"

        Dim connnection As New SqlConnection(connectionString)
        Return connnection
    End Function
End Class
