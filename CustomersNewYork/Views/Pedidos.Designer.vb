<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
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
        Label1 = New Label()
        ButtonBorrar = New Button()
        ButtonEditar = New Button()
        ButtonNuevo = New Button()
        ButtonCerrar = New Button()
        DataGridViewPedidos = New DataGridView()
        ButtonBuscarPedidos = New Button()
        TextBoxBuscarNombreEmpleado = New TextBox()
        LabelBuscar = New Label()
        DataGridViewPedidoDetalles = New DataGridView()
        Label2 = New Label()
        TextBoxBuscarNombreCliente = New TextBox()
        Label3 = New Label()
        CType(DataGridViewPedidos, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewPedidoDetalles, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 15)
        Label1.TabIndex = 27
        Label1.Text = "Seleccionar un pedido para Editar o Borrar"
        ' 
        ' ButtonBorrar
        ' 
        ButtonBorrar.Location = New Point(174, 58)
        ButtonBorrar.Name = "ButtonBorrar"
        ButtonBorrar.Size = New Size(75, 23)
        ButtonBorrar.TabIndex = 26
        ButtonBorrar.Text = "Borrar"
        ButtonBorrar.UseVisualStyleBackColor = True
        ' 
        ' ButtonEditar
        ' 
        ButtonEditar.Location = New Point(93, 58)
        ButtonEditar.Name = "ButtonEditar"
        ButtonEditar.Size = New Size(75, 23)
        ButtonEditar.TabIndex = 25
        ButtonEditar.Text = "Editar"
        ButtonEditar.UseVisualStyleBackColor = True
        ' 
        ' ButtonNuevo
        ' 
        ButtonNuevo.Location = New Point(12, 58)
        ButtonNuevo.Name = "ButtonNuevo"
        ButtonNuevo.Size = New Size(75, 23)
        ButtonNuevo.TabIndex = 24
        ButtonNuevo.Text = "Nuevo"
        ButtonNuevo.UseVisualStyleBackColor = True
        ' 
        ' ButtonCerrar
        ' 
        ButtonCerrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonCerrar.Location = New Point(713, 460)
        ButtonCerrar.Name = "ButtonCerrar"
        ButtonCerrar.Size = New Size(75, 23)
        ButtonCerrar.TabIndex = 23
        ButtonCerrar.Text = "Cerrar"
        ButtonCerrar.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewPedidos
        ' 
        DataGridViewPedidos.AllowUserToAddRows = False
        DataGridViewPedidos.AllowUserToDeleteRows = False
        DataGridViewPedidos.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPedidos.Location = New Point(12, 113)
        DataGridViewPedidos.MultiSelect = False
        DataGridViewPedidos.Name = "DataGridViewPedidos"
        DataGridViewPedidos.ReadOnly = True
        DataGridViewPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewPedidos.Size = New Size(776, 154)
        DataGridViewPedidos.TabIndex = 22
        ' 
        ' ButtonBuscarPedidos
        ' 
        ButtonBuscarPedidos.Location = New Point(588, 28)
        ButtonBuscarPedidos.Name = "ButtonBuscarPedidos"
        ButtonBuscarPedidos.Size = New Size(134, 23)
        ButtonBuscarPedidos.TabIndex = 21
        ButtonBuscarPedidos.Text = "Buscar pedidos"
        ButtonBuscarPedidos.UseVisualStyleBackColor = True
        ' 
        ' TextBoxBuscarNombreEmpleado
        ' 
        TextBoxBuscarNombreEmpleado.Location = New Point(12, 29)
        TextBoxBuscarNombreEmpleado.Name = "TextBoxBuscarNombreEmpleado"
        TextBoxBuscarNombreEmpleado.Size = New Size(282, 23)
        TextBoxBuscarNombreEmpleado.TabIndex = 20
        ' 
        ' LabelBuscar
        ' 
        LabelBuscar.AutoSize = True
        LabelBuscar.Location = New Point(12, 11)
        LabelBuscar.Name = "LabelBuscar"
        LabelBuscar.Size = New Size(164, 15)
        LabelBuscar.TabIndex = 19
        LabelBuscar.Text = "Buscar por nombre empleado"
        ' 
        ' DataGridViewPedidoDetalles
        ' 
        DataGridViewPedidoDetalles.AllowUserToAddRows = False
        DataGridViewPedidoDetalles.AllowUserToDeleteRows = False
        DataGridViewPedidoDetalles.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewPedidoDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPedidoDetalles.Location = New Point(12, 300)
        DataGridViewPedidoDetalles.MultiSelect = False
        DataGridViewPedidoDetalles.Name = "DataGridViewPedidoDetalles"
        DataGridViewPedidoDetalles.ReadOnly = True
        DataGridViewPedidoDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewPedidoDetalles.Size = New Size(776, 154)
        DataGridViewPedidoDetalles.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 282)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 29
        Label2.Text = "Detalles"
        ' 
        ' TextBoxBuscarNombreCliente
        ' 
        TextBoxBuscarNombreCliente.Location = New Point(300, 29)
        TextBoxBuscarNombreCliente.Name = "TextBoxBuscarNombreCliente"
        TextBoxBuscarNombreCliente.Size = New Size(282, 23)
        TextBoxBuscarNombreCliente.TabIndex = 31
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(300, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 15)
        Label3.TabIndex = 30
        Label3.Text = "Buscar por nombre cliente"
        ' 
        ' Pedidos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 495)
        Controls.Add(TextBoxBuscarNombreCliente)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DataGridViewPedidoDetalles)
        Controls.Add(Label1)
        Controls.Add(ButtonBorrar)
        Controls.Add(ButtonEditar)
        Controls.Add(ButtonNuevo)
        Controls.Add(ButtonCerrar)
        Controls.Add(DataGridViewPedidos)
        Controls.Add(ButtonBuscarPedidos)
        Controls.Add(TextBoxBuscarNombreEmpleado)
        Controls.Add(LabelBuscar)
        Name = "Pedidos"
        Text = "Pedidos"
        CType(DataGridViewPedidos, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewPedidoDetalles, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonBorrar As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents DataGridViewPedidos As DataGridView
    Friend WithEvents ButtonBuscarPedidos As Button
    Friend WithEvents TextBoxBuscarNombreEmpleado As TextBox
    Friend WithEvents LabelBuscar As Label
    Friend WithEvents DataGridViewPedidoDetalles As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxBuscarNombreCliente As TextBox
    Friend WithEvents Label3 As Label
End Class
