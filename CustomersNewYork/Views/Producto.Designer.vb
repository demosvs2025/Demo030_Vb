<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto
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
        Label5 = New Label()
        Label4 = New Label()
        TextBoxCantidad = New TextBox()
        Label3 = New Label()
        TextBoxPrecio = New TextBox()
        TextBoxNombreProducto = New TextBox()
        LabelTitulo = New Label()
        TextBoxProductoId = New TextBox()
        Label1 = New Label()
        ButtonGuardar = New Button()
        ButtonCerrar = New Button()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 144)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 15)
        Label5.TabIndex = 40
        Label5.Text = "Precio"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 39
        Label4.Text = "Cantidad"
        ' 
        ' TextBoxCantidad
        ' 
        TextBoxCantidad.Location = New Point(130, 112)
        TextBoxCantidad.Name = "TextBoxCantidad"
        TextBoxCantidad.Size = New Size(139, 23)
        TextBoxCantidad.TabIndex = 32
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 15)
        Label3.TabIndex = 31
        Label3.Text = "Nombre producto"
        ' 
        ' TextBoxPrecio
        ' 
        TextBoxPrecio.Location = New Point(130, 141)
        TextBoxPrecio.Name = "TextBoxPrecio"
        TextBoxPrecio.Size = New Size(139, 23)
        TextBoxPrecio.TabIndex = 33
        ' 
        ' TextBoxNombreProducto
        ' 
        TextBoxNombreProducto.Location = New Point(130, 83)
        TextBoxNombreProducto.Name = "TextBoxNombreProducto"
        TextBoxNombreProducto.Size = New Size(383, 23)
        TextBoxNombreProducto.TabIndex = 28
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.AutoSize = True
        LabelTitulo.Location = New Point(130, 9)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(94, 15)
        LabelTitulo.TabIndex = 27
        LabelTitulo.Text = "Nuevo producto"
        ' 
        ' TextBoxProductoId
        ' 
        TextBoxProductoId.Enabled = False
        TextBoxProductoId.Location = New Point(130, 54)
        TextBoxProductoId.Name = "TextBoxProductoId"
        TextBoxProductoId.Size = New Size(100, 23)
        TextBoxProductoId.TabIndex = 26
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 25
        Label1.Text = "Id producto"
        ' 
        ' ButtonGuardar
        ' 
        ButtonGuardar.Location = New Point(130, 185)
        ButtonGuardar.Name = "ButtonGuardar"
        ButtonGuardar.Size = New Size(75, 23)
        ButtonGuardar.TabIndex = 24
        ButtonGuardar.Text = "Guardar"
        ButtonGuardar.UseVisualStyleBackColor = True
        ' 
        ' ButtonCerrar
        ' 
        ButtonCerrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonCerrar.Location = New Point(485, 213)
        ButtonCerrar.Name = "ButtonCerrar"
        ButtonCerrar.Size = New Size(75, 23)
        ButtonCerrar.TabIndex = 47
        ButtonCerrar.Text = "Cerrar"
        ButtonCerrar.UseVisualStyleBackColor = True
        ' 
        ' Producto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(572, 248)
        Controls.Add(ButtonCerrar)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBoxCantidad)
        Controls.Add(Label3)
        Controls.Add(TextBoxPrecio)
        Controls.Add(TextBoxNombreProducto)
        Controls.Add(LabelTitulo)
        Controls.Add(TextBoxProductoId)
        Controls.Add(Label1)
        Controls.Add(ButtonGuardar)
        Name = "Producto"
        Text = "Producto"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxNombreProducto As TextBox
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents TextBoxProductoId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ButtonCerrar As Button
End Class
