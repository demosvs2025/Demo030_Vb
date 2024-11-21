﻿Namespace Models
    Public Class PedidoDetalle
        Private pedidoDetalleIdValue As Integer
        Public Property PedidoDetalleId() As Integer
            Get
                Return pedidoDetalleIdValue
            End Get
            Set(ByVal value As Integer)
                pedidoDetalleIdValue = value
            End Set
        End Property
        Private pedidoIdValue As Integer
        Public Property PedidoId() As Integer
            Get
                Return pedidoIdValue
            End Get
            Set(ByVal value As Integer)
                pedidoIdValue = value
            End Set
        End Property
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
        Private subtotalValue As Decimal
        Public Property Subtotal() As Decimal
            Get
                Return subtotalValue
            End Get
            Set(ByVal value As Decimal)
                subtotalValue = value
            End Set
        End Property
    End Class
End Namespace
