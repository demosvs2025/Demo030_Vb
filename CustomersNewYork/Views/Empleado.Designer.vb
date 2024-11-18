<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleado
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
        Label5 = New Label()
        Label4 = New Label()
        TextBoxApellidoPaterno = New TextBox()
        Label3 = New Label()
        TextBoxApellidoMaterno = New TextBox()
        TextBoxNombre = New TextBox()
        LabelTitulo = New Label()
        TextBoxEmpleadoId = New TextBox()
        Label1 = New Label()
        ButtonGuardar = New Button()
        SuspendLayout()
        ' 
        ' ButtonCerrar
        ' 
        ButtonCerrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonCerrar.Location = New Point(509, 207)
        ButtonCerrar.Name = "ButtonCerrar"
        ButtonCerrar.Size = New Size(75, 23)
        ButtonCerrar.TabIndex = 58
        ButtonCerrar.Text = "Cerrar"
        ButtonCerrar.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(11, 144)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 15)
        Label5.TabIndex = 57
        Label5.Text = "Apellido materno"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 15)
        Label4.TabIndex = 56
        Label4.Text = "Apellido paterno"
        ' 
        ' TextBoxApellidoPaterno
        ' 
        TextBoxApellidoPaterno.Location = New Point(129, 112)
        TextBoxApellidoPaterno.Name = "TextBoxApellidoPaterno"
        TextBoxApellidoPaterno.Size = New Size(383, 23)
        TextBoxApellidoPaterno.TabIndex = 54
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 53
        Label3.Text = "Nombre"
        ' 
        ' TextBoxApellidoMaterno
        ' 
        TextBoxApellidoMaterno.Location = New Point(129, 141)
        TextBoxApellidoMaterno.Name = "TextBoxApellidoMaterno"
        TextBoxApellidoMaterno.Size = New Size(383, 23)
        TextBoxApellidoMaterno.TabIndex = 55
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Location = New Point(129, 83)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(383, 23)
        TextBoxNombre.TabIndex = 52
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.AutoSize = True
        LabelTitulo.Location = New Point(129, 9)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(98, 15)
        LabelTitulo.TabIndex = 51
        LabelTitulo.Text = "Nuevo empleado"
        ' 
        ' TextBoxEmpleadoId
        ' 
        TextBoxEmpleadoId.Enabled = False
        TextBoxEmpleadoId.Location = New Point(129, 54)
        TextBoxEmpleadoId.Name = "TextBoxEmpleadoId"
        TextBoxEmpleadoId.Size = New Size(100, 23)
        TextBoxEmpleadoId.TabIndex = 50
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 49
        Label1.Text = "Id empleado"
        ' 
        ' ButtonGuardar
        ' 
        ButtonGuardar.Location = New Point(129, 185)
        ButtonGuardar.Name = "ButtonGuardar"
        ButtonGuardar.Size = New Size(75, 23)
        ButtonGuardar.TabIndex = 48
        ButtonGuardar.Text = "Guardar"
        ButtonGuardar.UseVisualStyleBackColor = True
        ' 
        ' Empleado
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(596, 242)
        Controls.Add(ButtonCerrar)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBoxApellidoPaterno)
        Controls.Add(Label3)
        Controls.Add(TextBoxApellidoMaterno)
        Controls.Add(TextBoxNombre)
        Controls.Add(LabelTitulo)
        Controls.Add(TextBoxEmpleadoId)
        Controls.Add(Label1)
        Controls.Add(ButtonGuardar)
        Name = "Empleado"
        Text = "Empleado"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxApellidoPaterno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxApellidoMaterno As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents TextBoxEmpleadoId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonGuardar As Button
End Class
