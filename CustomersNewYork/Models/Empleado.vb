Namespace Models

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

        Private nombreValue As String
        Public Property Nombre() As String
            Get
                Return nombreValue
            End Get
            Set(ByVal value As String)
                nombreValue = value
            End Set
        End Property

        Private apellidoPaternoValue As String
        Public Property ApellidoPaterno() As String
            Get
                Return apellidoPaternoValue
            End Get
            Set(ByVal value As String)
                apellidoPaternoValue = value
            End Set
        End Property

        Private apellidoMaternoValue As String
        Public Property ApellidoMaterno() As String
            Get
                Return apellidoMaternoValue
            End Get
            Set(ByVal value As String)
                apellidoMaternoValue = value
            End Set
        End Property
    End Class

End Namespace
