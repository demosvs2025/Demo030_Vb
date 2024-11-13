Namespace Models
    Public Class Cliente
        Private clienteIdValue As Integer

        Public Property ClienteId() As Integer
            Get
                Return clienteIdValue
            End Get
            Set(ByVal value As Integer)
                clienteIdValue = value
            End Set
        End Property

        Private tipoPersonaIdValue As Integer
        Public Property TipoPersonaId() As Integer
            Get
                Return tipoPersonaIdValue
            End Get
            Set(ByVal value As Integer)
                tipoPersonaIdValue = value
            End Set
        End Property

        Private nombreEmpresaValue As String
        Public Property NombreEmpresa() As String
            Get
                Return nombreEmpresaValue
            End Get
            Set(ByVal value As String)
                nombreEmpresaValue = value
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

    End Class
End Namespace