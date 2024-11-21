<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedido
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ButtonCerrar = New Button()
        Label4 = New Label()
        TextBoxDireccion1 = New TextBox()
        Label3 = New Label()
        TextBoxTelefono = New TextBox()
        TextBoxNombre = New TextBox()
        LabelTitulo = New Label()
        TextBoxPedidoId = New TextBox()
        Label1 = New Label()
        ButtonGuardarPedido = New Button()
        ComboBoxEmpleadoId = New ComboBox()
        ComboBoxClienteId = New ComboBox()
        Label2 = New Label()
        Label5 = New Label()
        TextBoxDireccion2 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        TextBoxComentario = New TextBox()
        Label8 = New Label()
        TextBoxFechaPedido = New TextBox()
        TextBoxTotal = New TextBox()
        Label9 = New Label()
        ButtonAgregarDetalle = New Button()
        Label10 = New Label()
        ComboBoxProductoId = New ComboBox()
        TextBoxCantidad = New TextBox()
        TextBoxPrecio = New TextBox()
        TextBoxSubtotal = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        DataGridViewPedidoDetalles = New DataGridView()
        ButtonBorrarDetalle = New Button()
        CType(DataGridViewPedidoDetalles, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonCerrar
        ' 
        ButtonCerrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonCerrar.Location = New Point(843, 459)
        ButtonCerrar.Name = "ButtonCerrar"
        ButtonCerrar.Size = New Size(75, 23)
        ButtonCerrar.TabIndex = 58
        ButtonCerrar.Text = "Cerrar"
        ButtonCerrar.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 56
        Label4.Text = "Cliente"
        ' 
        ' TextBoxDireccion1
        ' 
        TextBoxDireccion1.Location = New Point(104, 121)
        TextBoxDireccion1.Name = "TextBoxDireccion1"
        TextBoxDireccion1.Size = New Size(572, 23)
        TextBoxDireccion1.TabIndex = 54
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 53
        Label3.Text = "Empleado"
        ' 
        ' TextBoxTelefono
        ' 
        TextBoxTelefono.Location = New Point(106, 179)
        TextBoxTelefono.Name = "TextBoxTelefono"
        TextBoxTelefono.Size = New Size(139, 23)
        TextBoxTelefono.TabIndex = 55
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Location = New Point(393, 92)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(283, 23)
        TextBoxNombre.TabIndex = 52
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.AutoSize = True
        LabelTitulo.Location = New Point(393, 9)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(82, 15)
        LabelTitulo.TabIndex = 51
        LabelTitulo.Text = "Nuevo pedido"
        ' 
        ' TextBoxPedidoId
        ' 
        TextBoxPedidoId.Enabled = False
        TextBoxPedidoId.Location = New Point(104, 34)
        TextBoxPedidoId.Name = "TextBoxPedidoId"
        TextBoxPedidoId.Size = New Size(100, 23)
        TextBoxPedidoId.TabIndex = 50
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 49
        Label1.Text = "Id pedido"
        ' 
        ' ButtonGuardarPedido
        ' 
        ButtonGuardarPedido.Location = New Point(601, 208)
        ButtonGuardarPedido.Name = "ButtonGuardarPedido"
        ButtonGuardarPedido.Size = New Size(75, 23)
        ButtonGuardarPedido.TabIndex = 48
        ButtonGuardarPedido.Text = "Guardar"
        ButtonGuardarPedido.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxEmpleadoId
        ' 
        ComboBoxEmpleadoId.FormattingEnabled = True
        ComboBoxEmpleadoId.Location = New Point(104, 63)
        ComboBoxEmpleadoId.Name = "ComboBoxEmpleadoId"
        ComboBoxEmpleadoId.Size = New Size(283, 23)
        ComboBoxEmpleadoId.TabIndex = 59
        ' 
        ' ComboBoxClienteId
        ' 
        ComboBoxClienteId.FormattingEnabled = True
        ComboBoxClienteId.Location = New Point(104, 92)
        ComboBoxClienteId.Name = "ComboBoxClienteId"
        ComboBoxClienteId.Size = New Size(283, 23)
        ComboBoxClienteId.TabIndex = 60
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 61
        Label2.Text = "Dirección 1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 15)
        Label5.TabIndex = 62
        Label5.Text = "Dirección 2"
        ' 
        ' TextBoxDireccion2
        ' 
        TextBoxDireccion2.Location = New Point(104, 150)
        TextBoxDireccion2.Name = "TextBoxDireccion2"
        TextBoxDireccion2.Size = New Size(572, 23)
        TextBoxDireccion2.TabIndex = 63
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 182)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 15)
        Label6.TabIndex = 64
        Label6.Text = "Telefono"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(261, 182)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 15)
        Label7.TabIndex = 65
        Label7.Text = "Comentario"
        ' 
        ' TextBoxComentario
        ' 
        TextBoxComentario.Location = New Point(337, 179)
        TextBoxComentario.Name = "TextBoxComentario"
        TextBoxComentario.Size = New Size(339, 23)
        TextBoxComentario.TabIndex = 66
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(226, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 15)
        Label8.TabIndex = 67
        Label8.Text = "Fecha pedido"
        ' 
        ' TextBoxFechaPedido
        ' 
        TextBoxFechaPedido.Enabled = False
        TextBoxFechaPedido.Location = New Point(320, 34)
        TextBoxFechaPedido.Name = "TextBoxFechaPedido"
        TextBoxFechaPedido.Size = New Size(139, 23)
        TextBoxFechaPedido.TabIndex = 68
        ' 
        ' TextBoxTotal
        ' 
        TextBoxTotal.Enabled = False
        TextBoxTotal.Location = New Point(104, 208)
        TextBoxTotal.Name = "TextBoxTotal"
        TextBoxTotal.Size = New Size(139, 23)
        TextBoxTotal.TabIndex = 70
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 211)
        Label9.Name = "Label9"
        Label9.Size = New Size(32, 15)
        Label9.TabIndex = 69
        Label9.Text = "Total"
        ' 
        ' ButtonAgregarDetalle
        ' 
        ButtonAgregarDetalle.Location = New Point(655, 283)
        ButtonAgregarDetalle.Name = "ButtonAgregarDetalle"
        ButtonAgregarDetalle.Size = New Size(125, 23)
        ButtonAgregarDetalle.TabIndex = 71
        ButtonAgregarDetalle.Text = "Agregar detalle"
        ButtonAgregarDetalle.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 265)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 15)
        Label10.TabIndex = 73
        Label10.Text = "Producto"
        ' 
        ' ComboBoxProductoId
        ' 
        ComboBoxProductoId.FormattingEnabled = True
        ComboBoxProductoId.Location = New Point(12, 283)
        ComboBoxProductoId.Name = "ComboBoxProductoId"
        ComboBoxProductoId.Size = New Size(202, 23)
        ComboBoxProductoId.TabIndex = 74
        ' 
        ' TextBoxCantidad
        ' 
        TextBoxCantidad.Location = New Point(220, 283)
        TextBoxCantidad.Name = "TextBoxCantidad"
        TextBoxCantidad.Size = New Size(139, 23)
        TextBoxCantidad.TabIndex = 75
        ' 
        ' TextBoxPrecio
        ' 
        TextBoxPrecio.Enabled = False
        TextBoxPrecio.Location = New Point(365, 283)
        TextBoxPrecio.Name = "TextBoxPrecio"
        TextBoxPrecio.Size = New Size(139, 23)
        TextBoxPrecio.TabIndex = 76
        ' 
        ' TextBoxSubtotal
        ' 
        TextBoxSubtotal.Enabled = False
        TextBoxSubtotal.Location = New Point(510, 283)
        TextBoxSubtotal.Name = "TextBoxSubtotal"
        TextBoxSubtotal.Size = New Size(139, 23)
        TextBoxSubtotal.TabIndex = 77
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(220, 265)
        Label11.Name = "Label11"
        Label11.Size = New Size(55, 15)
        Label11.TabIndex = 78
        Label11.Text = "Cantidad"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(365, 265)
        Label12.Name = "Label12"
        Label12.Size = New Size(40, 15)
        Label12.TabIndex = 79
        Label12.Text = "Precio"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(510, 265)
        Label13.Name = "Label13"
        Label13.Size = New Size(51, 15)
        Label13.TabIndex = 80
        Label13.Text = "Subtotal"
        ' 
        ' DataGridViewPedidoDetalles
        ' 
        DataGridViewPedidoDetalles.AllowUserToAddRows = False
        DataGridViewPedidoDetalles.AllowUserToDeleteRows = False
        DataGridViewPedidoDetalles.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewPedidoDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPedidoDetalles.Location = New Point(12, 312)
        DataGridViewPedidoDetalles.MultiSelect = False
        DataGridViewPedidoDetalles.Name = "DataGridViewPedidoDetalles"
        DataGridViewPedidoDetalles.ReadOnly = True
        DataGridViewPedidoDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewPedidoDetalles.Size = New Size(906, 141)
        DataGridViewPedidoDetalles.TabIndex = 81
        ' 
        ' ButtonBorrarDetalle
        ' 
        ButtonBorrarDetalle.Location = New Point(786, 283)
        ButtonBorrarDetalle.Name = "ButtonBorrarDetalle"
        ButtonBorrarDetalle.Size = New Size(132, 23)
        ButtonBorrarDetalle.TabIndex = 82
        ButtonBorrarDetalle.Text = "Borrar seleccionado"
        ButtonBorrarDetalle.UseVisualStyleBackColor = True
        ' 
        ' Pedido
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(930, 494)
        Controls.Add(ButtonBorrarDetalle)
        Controls.Add(DataGridViewPedidoDetalles)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(TextBoxSubtotal)
        Controls.Add(TextBoxPrecio)
        Controls.Add(TextBoxCantidad)
        Controls.Add(ComboBoxProductoId)
        Controls.Add(Label10)
        Controls.Add(ButtonAgregarDetalle)
        Controls.Add(TextBoxTotal)
        Controls.Add(Label9)
        Controls.Add(TextBoxFechaPedido)
        Controls.Add(Label8)
        Controls.Add(TextBoxComentario)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBoxDireccion2)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(ComboBoxClienteId)
        Controls.Add(ComboBoxEmpleadoId)
        Controls.Add(ButtonCerrar)
        Controls.Add(Label4)
        Controls.Add(TextBoxDireccion1)
        Controls.Add(Label3)
        Controls.Add(TextBoxTelefono)
        Controls.Add(TextBoxNombre)
        Controls.Add(LabelTitulo)
        Controls.Add(TextBoxPedidoId)
        Controls.Add(Label1)
        Controls.Add(ButtonGuardarPedido)
        Name = "Pedido"
        Text = "Pedido"
        CType(DataGridViewPedidoDetalles, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxDireccion1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents TextBoxPedidoId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonGuardarPedido As Button
    Friend WithEvents ComboBoxEmpleadoId As ComboBox
    Friend WithEvents ComboBoxClienteId As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDireccion2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxComentario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxFechaPedido As TextBox
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonAgregarDetalle As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBoxProductoId As ComboBox
    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxSubtotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridViewPedidoDetalles As DataGridView
    Friend WithEvents ButtonBorrarDetalle As Button
End Class
