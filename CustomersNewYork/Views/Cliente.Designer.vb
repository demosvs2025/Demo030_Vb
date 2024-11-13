<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        ButtonGuardar = New Button()
        Label1 = New Label()
        TextBoxClienteId = New TextBox()
        LabelTitulo = New Label()
        TextBoxNombreEmpresa = New TextBox()
        Label2 = New Label()
        RadioButtonTipoPersona1 = New RadioButton()
        GroupBox1 = New GroupBox()
        RadioButtonTipoPersona2 = New RadioButton()
        Label3 = New Label()
        TextBoxNombre = New TextBox()
        TextBoxApellidoPaterno = New TextBox()
        TextBoxApellidoMaterno = New TextBox()
        TextBoxDireccion1 = New TextBox()
        TextBoxDireccion2 = New TextBox()
        TextBoxTelefono = New TextBox()
        TextBoxComentario = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        ButtonCancelar = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ButtonGuardar
        ' 
        ButtonGuardar.Location = New Point(130, 375)
        ButtonGuardar.Name = "ButtonGuardar"
        ButtonGuardar.Size = New Size(75, 23)
        ButtonGuardar.TabIndex = 0
        ButtonGuardar.Text = "Guardar"
        ButtonGuardar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 1
        Label1.Text = "Id cliente"
        ' 
        ' TextBoxClienteId
        ' 
        TextBoxClienteId.Enabled = False
        TextBoxClienteId.Location = New Point(130, 54)
        TextBoxClienteId.Name = "TextBoxClienteId"
        TextBoxClienteId.Size = New Size(100, 23)
        TextBoxClienteId.TabIndex = 2
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.AutoSize = True
        LabelTitulo.Location = New Point(130, 9)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(80, 15)
        LabelTitulo.TabIndex = 3
        LabelTitulo.Text = "Nuevo cliente"
        ' 
        ' TextBoxNombreEmpresa
        ' 
        TextBoxNombreEmpresa.Location = New Point(130, 126)
        TextBoxNombreEmpresa.Name = "TextBoxNombreEmpresa"
        TextBoxNombreEmpresa.Size = New Size(383, 23)
        TextBoxNombreEmpresa.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 5
        Label2.Text = "Tipo persona"
        ' 
        ' RadioButtonTipoPersona1
        ' 
        RadioButtonTipoPersona1.AutoSize = True
        RadioButtonTipoPersona1.Location = New Point(6, 12)
        RadioButtonTipoPersona1.Name = "RadioButtonTipoPersona1"
        RadioButtonTipoPersona1.Size = New Size(56, 19)
        RadioButtonTipoPersona1.TabIndex = 6
        RadioButtonTipoPersona1.TabStop = True
        RadioButtonTipoPersona1.Text = "Moral"
        RadioButtonTipoPersona1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButtonTipoPersona2)
        GroupBox1.Controls.Add(RadioButtonTipoPersona1)
        GroupBox1.Location = New Point(130, 83)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(188, 37)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' RadioButtonTipoPersona2
        ' 
        RadioButtonTipoPersona2.AutoSize = True
        RadioButtonTipoPersona2.Location = New Point(90, 12)
        RadioButtonTipoPersona2.Name = "RadioButtonTipoPersona2"
        RadioButtonTipoPersona2.Size = New Size(54, 19)
        RadioButtonTipoPersona2.TabIndex = 7
        RadioButtonTipoPersona2.TabStop = True
        RadioButtonTipoPersona2.Text = "Fisica"
        RadioButtonTipoPersona2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 15)
        Label3.TabIndex = 8
        Label3.Text = "Nombre empresa"
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Location = New Point(130, 155)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(270, 23)
        TextBoxNombre.TabIndex = 9
        ' 
        ' TextBoxApellidoPaterno
        ' 
        TextBoxApellidoPaterno.Location = New Point(130, 184)
        TextBoxApellidoPaterno.Name = "TextBoxApellidoPaterno"
        TextBoxApellidoPaterno.Size = New Size(270, 23)
        TextBoxApellidoPaterno.TabIndex = 10
        ' 
        ' TextBoxApellidoMaterno
        ' 
        TextBoxApellidoMaterno.Location = New Point(130, 213)
        TextBoxApellidoMaterno.Name = "TextBoxApellidoMaterno"
        TextBoxApellidoMaterno.Size = New Size(270, 23)
        TextBoxApellidoMaterno.TabIndex = 11
        ' 
        ' TextBoxDireccion1
        ' 
        TextBoxDireccion1.Location = New Point(130, 242)
        TextBoxDireccion1.Name = "TextBoxDireccion1"
        TextBoxDireccion1.Size = New Size(383, 23)
        TextBoxDireccion1.TabIndex = 12
        ' 
        ' TextBoxDireccion2
        ' 
        TextBoxDireccion2.Location = New Point(130, 271)
        TextBoxDireccion2.Name = "TextBoxDireccion2"
        TextBoxDireccion2.Size = New Size(383, 23)
        TextBoxDireccion2.TabIndex = 13
        ' 
        ' TextBoxTelefono
        ' 
        TextBoxTelefono.Location = New Point(130, 300)
        TextBoxTelefono.Name = "TextBoxTelefono"
        TextBoxTelefono.Size = New Size(100, 23)
        TextBoxTelefono.TabIndex = 14
        ' 
        ' TextBoxComentario
        ' 
        TextBoxComentario.Location = New Point(130, 329)
        TextBoxComentario.Name = "TextBoxComentario"
        TextBoxComentario.Size = New Size(383, 23)
        TextBoxComentario.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 158)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 16
        Label4.Text = "Nombre"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 187)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 15)
        Label5.TabIndex = 17
        Label5.Text = "Apellido paterno"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 216)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 15)
        Label6.TabIndex = 18
        Label6.Text = "Apellido materno"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 245)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 15)
        Label7.TabIndex = 19
        Label7.Text = "Dirección 1"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 274)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 15)
        Label8.TabIndex = 20
        Label8.Text = "Dirección 2"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 303)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 15)
        Label9.TabIndex = 21
        Label9.Text = "Telefono"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 332)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 15)
        Label10.TabIndex = 22
        Label10.Text = "Comentario"
        ' 
        ' ButtonCancelar
        ' 
        ButtonCancelar.Location = New Point(211, 375)
        ButtonCancelar.Name = "ButtonCancelar"
        ButtonCancelar.Size = New Size(75, 23)
        ButtonCancelar.TabIndex = 23
        ButtonCancelar.Text = "Cancelar"
        ButtonCancelar.UseVisualStyleBackColor = True
        ' 
        ' Cliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(588, 421)
        Controls.Add(ButtonCancelar)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBoxComentario)
        Controls.Add(TextBoxTelefono)
        Controls.Add(TextBoxDireccion2)
        Controls.Add(TextBoxDireccion1)
        Controls.Add(TextBoxApellidoMaterno)
        Controls.Add(TextBoxApellidoPaterno)
        Controls.Add(TextBoxNombre)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(TextBoxNombreEmpresa)
        Controls.Add(LabelTitulo)
        Controls.Add(TextBoxClienteId)
        Controls.Add(Label1)
        Controls.Add(ButtonGuardar)
        Name = "Cliente"
        Text = "Cliente"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxClienteId As TextBox
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents TextBoxNombreEmpresa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButtonTipoPersona1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonTipoPersona2 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxApellidoPaterno As TextBox
    Friend WithEvents TextBoxApellidoMaterno As TextBox
    Friend WithEvents TextBoxDireccion1 As TextBox
    Friend WithEvents TextBoxDireccion2 As TextBox
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents TextBoxComentario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonCancelar As Button
End Class
