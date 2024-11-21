Namespace Models
    Public Class Pedido
        Private pedidoIdValue As Integer
        Public Property PedidoId() As Integer
            Get
                Return pedidoIdValue
            End Get
            Set(ByVal value As Integer)
                pedidoIdValue = value
            End Set
        End Property
        Private empleadoIdValue As Integer
        Public Property EmpleadoId() As Integer
            Get
                Return empleadoIdValue
            End Get
            Set(ByVal value As Integer)
                empleadoIdValue = value
            End Set
        End Property
        Private clienteIdValue As Integer
        Public Property ClienteId() As Integer
            Get
                Return clienteIdValue
            End Get
            Set(ByVal value As Integer)
                clienteIdValue = value
            End Set
        End Property
        Private nombreValue As String
        Public Property Nombre() As String
            Get
                Return nombreValue
            End Get
            Set(ByVal value As String)
                nombreValue = value
            End Set
        End Property
        Private direccion1Value As String
        Public Property Direccion1() As String
            Get
                Return direccion1Value
            End Get
            Set(ByVal value As String)
                direccion1Value = value
            End Set
        End Property
        Private direccion2Value As String
        Public Property Direccion2() As String
            Get
                Return direccion2Value
            End Get
            Set(ByVal value As String)
                direccion2Value = value
            End Set
        End Property
        Private telefonoValue As String
        Public Property Telefono() As String
            Get
                Return telefonoValue
            End Get
            Set(ByVal value As String)
                telefonoValue = value
            End Set
        End Property
        Private comentarioValue As String
        Public Property Comentario() As String
            Get
                Return comentarioValue
            End Get
            Set(ByVal value As String)
                comentarioValue = value
            End Set
        End Property
        Private fechaPedidoValue As Date
        Public Property FechaPedido() As Date
            Get
                Return fechaPedidoValue
            End Get
            Set(ByVal value As Date)
                fechaPedidoValue = value
            End Set
        End Property
        Private totalValue As Decimal
        Public Property Total() As Decimal
            Get
                Return totalValue
            End Get
            Set(ByVal value As Decimal)
                totalValue = value
            End Set
        End Property
    End Class
End Namespace