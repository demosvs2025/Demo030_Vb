Imports CustomersNewYork.Models

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

    Private cantidadDisponibleProductoSeleccionado As Integer
    Private NombreProductoSeleccionado As String

    Public Sub InicializarForm()
        TextBoxPedidoId.Text = pedidoIdValue.ToString()

        InicializarEmpleadosCombo1()
        InicializarClientesCombo1()
        InicializarProductosCombo1()

        Dim FechaPedido As Date = Now()

        TextBoxFechaPedido.Text = FechaPedido.ToString("dd/MM/yyyy")
        TextBoxTotal.Text = "0"

        If pedidoIdValue > 0 Then
            LabelTitulo.Text = "Editar pedido"
            ObtenerPedido()
        End If
    End Sub
    Private Sub InicializarEmpleadosCombo1()
        Dim dataTable As New DataTable

        Dim sqlEmpleados As New SqlEmpleados()
        dataTable = sqlEmpleados.ObtenerEmpleadosCombo1()
        ComboBoxEmpleadoId.DataSource = dataTable
        ComboBoxEmpleadoId.ValueMember = "EmpleadoId"
        ComboBoxEmpleadoId.DisplayMember = "Nombre"
    End Sub

    Private Sub InicializarClientesCombo1()
        Dim dataTable As New DataTable

        Dim sqlClientes As New SqlClientes()
        dataTable = sqlClientes.ObtenerClientesCombo1()
        ComboBoxClienteId.DataSource = dataTable
        ComboBoxClienteId.ValueMember = "ClienteId"
        ComboBoxClienteId.DisplayMember = "Nombre"
    End Sub

    Private Sub InicializarProductosCombo1()
        Dim dataTable As New DataTable

        Dim sqlProductos As New SqlProductos()
        dataTable = sqlProductos.ObtenerProductosCombo1()
        ComboBoxProductoId.DataSource = dataTable
        ComboBoxProductoId.ValueMember = "ProductoId"
        ComboBoxProductoId.DisplayMember = "Nombre"

        If (ComboBoxProductoId.Items.Count > 0) Then
            ComboBoxProductoId.SelectedIndex = 0
        End If
    End Sub

    Public Sub ObtenerPedido()
        Dim dataTable As New DataTable
        Dim sqlPedidos As New SqlPedidos()
        dataTable = sqlPedidos.ObtenerPedido(pedidoIdValue)

        Dim EmpleadoId As String = dataTable.Rows(0)(0).ToString()
        Dim ClienteId As String = dataTable.Rows(0)(1).ToString()
        Dim Nombre As String = dataTable.Rows(0)(2).ToString()
        Dim Direccion1 As String = dataTable.Rows(0)(3).ToString()
        Dim Direccion2 As String = dataTable.Rows(0)(4).ToString()
        Dim Telefono As String = dataTable.Rows(0)(5).ToString()
        Dim Comentario As String = dataTable.Rows(0)(6).ToString()
        Dim FechaPedido As String = dataTable.Rows(0)(7).ToString()
        Dim Total As String = dataTable.Rows(0)(8).ToString()

        ComboBoxEmpleadoId.SelectedValue = EmpleadoId
        ComboBoxClienteId.SelectedValue = ClienteId
        TextBoxNombre.Text = Nombre
        TextBoxDireccion1.Text = Direccion1
        TextBoxDireccion2.Text = Direccion2
        TextBoxTelefono.Text = Telefono
        TextBoxComentario.Text = Comentario
        TextBoxFechaPedido.Text = FechaPedido
        TextBoxTotal.Text = Total

        BuscarPedidoDetalles()
    End Sub

    Private Sub BuscarPedidoDetalles()
        Dim dataTable As New DataTable

        Dim sqlPedidos As New SqlPedidos()
        dataTable = sqlPedidos.ObtenerPedidoDetalles(pedidoIdValue)
        DataGridViewPedidoDetalles.DataSource = dataTable
    End Sub

    Private Sub GuardarPedido()
        Dim sqlPedidos As New SqlPedidos()
        Dim pedido As New Models.Pedido

        pedido.PedidoId = 0
        pedido.EmpleadoId = ComboBoxEmpleadoId.SelectedValue
        pedido.ClienteId = ComboBoxClienteId.SelectedValue
        pedido.Nombre = TextBoxNombre.Text
        pedido.Direccion1 = TextBoxDireccion1.Text
        pedido.Direccion2 = TextBoxDireccion2.Text
        pedido.Telefono = TextBoxTelefono.Text
        pedido.Comentario = TextBoxComentario.Text
        pedido.FechaPedido = TextBoxFechaPedido.Text
        pedido.Total = TextBoxTotal.Text

        If pedidoIdValue > 0 Then
            pedido.PedidoId = pedidoIdValue

            sqlPedidos.ActualizarPedido(pedido)
        Else
            Dim dataTable As New DataTable
            dataTable = sqlPedidos.InsertarPedido(pedido)

            Dim pedidoIdInsertar As Integer

            Integer.TryParse(dataTable.Rows(0)(0).ToString(), pedidoIdInsertar)

            pedidoIdValue = pedidoIdInsertar
            TextBoxPedidoId.Text = pedidoIdInsertar.ToString()

        End If
        MessageBox.Show("El pedido se guardó.")
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardarPedido.Click
        GuardarPedido()
    End Sub

    Private Sub ButtonCancelarPedido_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBoxClienteId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxClienteId.SelectedIndexChanged
        If (ComboBoxClienteId.Items.Count > 0 And ComboBoxClienteId.SelectedIndex >= 0) Then
            Dim ClienteIdInteger As Integer
            Dim NombreCliente As String = ""

            Integer.TryParse(ComboBoxClienteId.SelectedValue.ToString(), ClienteIdInteger)

            If ClienteIdInteger > 0 Then
                NombreCliente = ComboBoxClienteId.Text
            End If

            TextBoxNombre.Text = NombreCliente
        End If
    End Sub

    Private Sub ComboBoxProductoId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProductoId.SelectedIndexChanged
        If (ComboBoxProductoId.Items.Count > 0 And ComboBoxProductoId.SelectedIndex >= 0) Then
            Dim ProductoIdInteger As Integer

            Dim PrecioDecimal As Decimal = 0
            Dim SubtotalDecimal As Decimal = 0

            Integer.TryParse(ComboBoxProductoId.SelectedValue.ToString(), ProductoIdInteger)

            If ProductoIdInteger > 0 Then

                Dim dataTable As New DataTable
                Dim sqlProductos As New SqlProductos()
                dataTable = SqlProductos.ObtenerProducto(ProductoIdInteger)

                NombreProductoSeleccionado = dataTable.Rows(0)(0).ToString()
                Dim Cantidad As String = DataTable.Rows(0)(1).ToString()
                Dim Precio As String = DataTable.Rows(0)(2).ToString()

                Integer.TryParse(Cantidad, cantidadDisponibleProductoSeleccionado)

                Dim CantidadInteger As Integer
                Integer.TryParse(TextBoxCantidad.Text, CantidadInteger)

                If CantidadInteger > cantidadDisponibleProductoSeleccionado Then
                    CantidadInteger = cantidadDisponibleProductoSeleccionado
                    TextBoxCantidad.Text = CantidadInteger
                End If

                Decimal.TryParse(Precio, PrecioDecimal)

                SubtotalDecimal = CantidadInteger * PrecioDecimal
            End If

            TextBoxPrecio.Text = PrecioDecimal
            TextBoxSubtotal.Text = SubtotalDecimal
        End If
    End Sub

    Private Sub TextBoxCantidad_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCantidad.TextChanged

        Dim CantidadInteger As Integer
        Integer.TryParse(TextBoxCantidad.Text, CantidadInteger)

        If CantidadInteger > cantidadDisponibleProductoSeleccionado Then
            MessageBox.Show("El producto seleccionado tiene la cantidad disponible: " _
                            & cantidadDisponibleProductoSeleccionado.ToString())

            CantidadInteger = cantidadDisponibleProductoSeleccionado
            TextBoxCantidad.Text = CantidadInteger
        End If

        Dim Precio As String = TextBoxPrecio.Text

        Dim PrecioDecimal As Decimal = 0
        Dim SubtotalDecimal As Decimal = 0

        Decimal.TryParse(Precio, PrecioDecimal)

        SubtotalDecimal = CantidadInteger * PrecioDecimal

        TextBoxPrecio.Text = PrecioDecimal
        TextBoxSubtotal.Text = SubtotalDecimal

    End Sub

    Private Sub ButtonAgregarDetalle_Click(sender As Object, e As EventArgs) Handles ButtonAgregarDetalle.Click
        If pedidoIdValue = 0 Then
            GuardarPedido()
        End If

        If TextBoxCantidad.Text.Length = 0 Or Not IsNumeric(TextBoxCantidad.Text) Then
            TextBoxCantidad.Text = 0
        End If

        Dim sqlPedidos As New SqlPedidos()
        Dim pedidoDetalle As New Models.PedidoDetalle

        pedidoDetalle.PedidoDetalleId = 0
        pedidoDetalle.PedidoId = pedidoIdValue
        pedidoDetalle.ProductoId = ComboBoxProductoId.SelectedValue
        pedidoDetalle.NombreProducto = NombreProductoSeleccionado
        pedidoDetalle.Cantidad = TextBoxCantidad.Text
        pedidoDetalle.Precio = TextBoxPrecio.Text
        pedidoDetalle.Subtotal = TextBoxSubtotal.Text

        Dim dataTable As New DataTable
        dataTable = sqlPedidos.InsertarPedidoDetalle(pedidoDetalle)

        Dim resultadoId As String = dataTable.Rows(0)(0).ToString()
        Dim resultadoTotal As String = dataTable.Rows(0)(1).ToString()
        Dim resultadoMensajeError As String = dataTable.Rows(0)(2).ToString()

        If resultadoMensajeError.Length > 0 Then
            MessageBox.Show(resultadoMensajeError)
        Else
            TextBoxTotal.Text = resultadoTotal
            BuscarPedidoDetalles()
        End If
    End Sub

    Private Function PedidoDetalleSeleccionado()
        Dim pedidoDetalleIdSelected As Integer

        If DataGridViewPedidoDetalles.Rows.Count > 0 _
                And DataGridViewPedidoDetalles.SelectedRows.Count > 0 Then
            Dim selectedId As String
            selectedId = DataGridViewPedidoDetalles.SelectedRows(0).Cells(0).Value.ToString()

            pedidoDetalleIdSelected = Integer.Parse(selectedId)
        End If
        Return pedidoDetalleIdSelected
    End Function

    Private Sub ButtonBorrarDetalle_Click(sender As Object, e As EventArgs) Handles ButtonBorrarDetalle.Click
        Dim sqlPedidos As New SqlPedidos()

        Dim pedidoDetalleIdSelected As Integer
        pedidoDetalleIdSelected = PedidoDetalleSeleccionado()

        Dim dataTable As New DataTable
        dataTable = sqlPedidos.BorrarPedidoDetalle(pedidoDetalleIdSelected)

        Dim resultadoId As String = dataTable.Rows(0)(0).ToString()
        Dim resultadoTotal As String = dataTable.Rows(0)(1).ToString()
        Dim resultadoMensajeError As String = dataTable.Rows(0)(2).ToString()

        If resultadoMensajeError.Length > 0 Then
            MessageBox.Show(resultadoMensajeError)
        Else
            TextBoxTotal.Text = resultadoTotal
        End If
        BuscarPedidoDetalles()
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

    Private Sub Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarForm()
    End Sub

    Private Sub DataGridViewPedidoDetalles_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewPedidoDetalles.SelectionChanged

    End Sub
End Class