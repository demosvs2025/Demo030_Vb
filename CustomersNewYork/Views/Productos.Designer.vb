<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        DataGridViewProductos = New DataGridView()
        ButtonBuscarProductos = New Button()
        TextBoxBuscarProducto = New TextBox()
        LabelBuscar = New Label()
        CType(DataGridViewProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 15)
        Label1.TabIndex = 18
        Label1.Text = "Seleccionar un producto para Editar o Borrar"
        ' 
        ' ButtonBorrar
        ' 
        ButtonBorrar.Location = New Point(174, 56)
        ButtonBorrar.Name = "ButtonBorrar"
        ButtonBorrar.Size = New Size(75, 23)
        ButtonBorrar.TabIndex = 17
        ButtonBorrar.Text = "Borrar"
        ButtonBorrar.UseVisualStyleBackColor = True
        ' 
        ' ButtonEditar
        ' 
        ButtonEditar.Location = New Point(93, 56)
        ButtonEditar.Name = "ButtonEditar"
        ButtonEditar.Size = New Size(75, 23)
        ButtonEditar.TabIndex = 16
        ButtonEditar.Text = "Editar"
        ButtonEditar.UseVisualStyleBackColor = True
        ' 
        ' ButtonNuevo
        ' 
        ButtonNuevo.Location = New Point(12, 56)
        ButtonNuevo.Name = "ButtonNuevo"
        ButtonNuevo.Size = New Size(75, 23)
        ButtonNuevo.TabIndex = 15
        ButtonNuevo.Text = "Nuevo"
        ButtonNuevo.UseVisualStyleBackColor = True
        ' 
        ' ButtonCerrar
        ' 
        ButtonCerrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonCerrar.Location = New Point(713, 415)
        ButtonCerrar.Name = "ButtonCerrar"
        ButtonCerrar.Size = New Size(75, 23)
        ButtonCerrar.TabIndex = 14
        ButtonCerrar.Text = "Cerrar"
        ButtonCerrar.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewProductos
        ' 
        DataGridViewProductos.AllowUserToAddRows = False
        DataGridViewProductos.AllowUserToDeleteRows = False
        DataGridViewProductos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewProductos.Location = New Point(12, 111)
        DataGridViewProductos.MultiSelect = False
        DataGridViewProductos.Name = "DataGridViewProductos"
        DataGridViewProductos.ReadOnly = True
        DataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewProductos.Size = New Size(776, 298)
        DataGridViewProductos.TabIndex = 13
        ' 
        ' ButtonBuscarProductos
        ' 
        ButtonBuscarProductos.Location = New Point(430, 27)
        ButtonBuscarProductos.Name = "ButtonBuscarProductos"
        ButtonBuscarProductos.Size = New Size(134, 23)
        ButtonBuscarProductos.TabIndex = 12
        ButtonBuscarProductos.Text = "Buscar productos"
        ButtonBuscarProductos.UseVisualStyleBackColor = True
        ' 
        ' TextBoxBuscarProducto
        ' 
        TextBoxBuscarProducto.Location = New Point(12, 27)
        TextBoxBuscarProducto.Name = "TextBoxBuscarProducto"
        TextBoxBuscarProducto.Size = New Size(412, 23)
        TextBoxBuscarProducto.TabIndex = 11
        ' 
        ' LabelBuscar
        ' 
        LabelBuscar.AutoSize = True
        LabelBuscar.Location = New Point(12, 9)
        LabelBuscar.Name = "LabelBuscar"
        LabelBuscar.Size = New Size(42, 15)
        LabelBuscar.TabIndex = 10
        LabelBuscar.Text = "Buscar"
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(ButtonBorrar)
        Controls.Add(ButtonEditar)
        Controls.Add(ButtonNuevo)
        Controls.Add(ButtonCerrar)
        Controls.Add(DataGridViewProductos)
        Controls.Add(ButtonBuscarProductos)
        Controls.Add(TextBoxBuscarProducto)
        Controls.Add(LabelBuscar)
        Name = "Productos"
        Text = "Productos"
        CType(DataGridViewProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonBorrar As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents DataGridViewProductos As DataGridView
    Friend WithEvents ButtonBuscarProductos As Button
    Friend WithEvents TextBoxBuscarProducto As TextBox
    Friend WithEvents LabelBuscar As Label
End Class
