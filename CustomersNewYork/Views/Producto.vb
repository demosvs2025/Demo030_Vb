Public Class Producto

    Private ProductoIdValue As Integer
    Public Property ProductoId() As Integer
        Get
            Return ProductoIdValue
        End Get
        Set(ByVal value As Integer)
            ProductoIdValue = value
        End Set
    End Property
    Public Sub InicializarForm()
        TextBoxProductoId.Text = ProductoIdValue.ToString()

        If ProductoIdValue > 0 Then
            LabelTitulo.Text = "Editar producto"
            ObtenerProducto()
        End If
    End Sub
    Public Sub ObtenerProducto()
        Dim dataTable As New DataTable
        Dim sqlProductos As New SqlProductos()
        dataTable = sqlProductos.ObtenerProducto(ProductoIdValue)

        Dim NombreProducto As String = dataTable.Rows(0)(0).ToString()
        Dim Cantidad As String = dataTable.Rows(0)(1).ToString()
        Dim Precio As String = dataTable.Rows(0)(2).ToString()

        TextBoxNombreProducto.Text = NombreProducto
        TextBoxCantidad.Text = Cantidad
        TextBoxPrecio.Text = Precio
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim sqlProductos As New SqlProductos()
        Dim producto As New Models.Producto

        Dim Cantidad As Integer
        Dim Precio As Decimal

        Integer.TryParse(TextBoxCantidad.Text, Cantidad)
        Decimal.TryParse(TextBoxPrecio.Text, Precio)

        producto.ProductoId = 0
        producto.NombreProducto = TextBoxNombreProducto.Text
        producto.Cantidad = Cantidad
        producto.Precio = Precio

        If ProductoIdValue > 0 Then
            producto.ProductoId = ProductoIdValue

            sqlProductos.ActualizarProducto(producto)
        Else
            sqlProductos.InsertarProducto(producto)
        End If
        MessageBox.Show("El producto se guardó.")
        Me.Close()
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarForm()
    End Sub
End Class