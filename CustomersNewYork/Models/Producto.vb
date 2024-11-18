Namespace Models
    Public Class Producto
        Private productoIdValue As Integer
        Public Property ProductoId() As Integer
            Get
                Return productoIdValue
            End Get
            Set(ByVal value As Integer)
                productoIdValue = value
            End Set
        End Property
        Private nombreProductoValue As String
        Public Property NombreProducto() As String
            Get
                Return nombreProductoValue
            End Get
            Set(ByVal value As String)
                nombreProductoValue = value
            End Set
        End Property
        Private cantidadValue As Integer
        Public Property Cantidad() As Integer
            Get
                Return cantidadValue
            End Get
            Set(ByVal value As Integer)
                cantidadValue = value
            End Set
        End Property
        Private precioValue As Decimal
        Public Property Precio() As Decimal
            Get
                Return precioValue
            End Get
            Set(ByVal value As Decimal)
                precioValue = value
            End Set
        End Property
    End Class
End Namespace