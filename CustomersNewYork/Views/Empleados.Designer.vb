<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        DataGridViewEmpleados = New DataGridView()
        ButtonBuscarEmpleados = New Button()
        TextBoxBuscarEmpleados = New TextBox()
        LabelBuscar = New Label()
        CType(DataGridViewEmpleados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 15)
        Label1.TabIndex = 27
        Label1.Text = "Seleccionar un empleado para Editar o Borrar"
        ' 
        ' ButtonBorrar
        ' 
        ButtonBorrar.Location = New Point(174, 56)
        ButtonBorrar.Name = "ButtonBorrar"
        ButtonBorrar.Size = New Size(75, 23)
        ButtonBorrar.TabIndex = 26
        ButtonBorrar.Text = "Borrar"
        ButtonBorrar.UseVisualStyleBackColor = True
        ' 
        ' ButtonEditar
        ' 
        ButtonEditar.Location = New Point(93, 56)
        ButtonEditar.Name = "ButtonEditar"
        ButtonEditar.Size = New Size(75, 23)
        ButtonEditar.TabIndex = 25
        ButtonEditar.Text = "Editar"
        ButtonEditar.UseVisualStyleBackColor = True
        ' 
        ' ButtonNuevo
        ' 
        ButtonNuevo.Location = New Point(12, 56)
        ButtonNuevo.Name = "ButtonNuevo"
        ButtonNuevo.Size = New Size(75, 23)
        ButtonNuevo.TabIndex = 24
        ButtonNuevo.Text = "Nuevo"
        ButtonNuevo.UseVisualStyleBackColor = True
        ' 
        ' ButtonCerrar
        ' 
        ButtonCerrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonCerrar.Location = New Point(713, 415)
        ButtonCerrar.Name = "ButtonCerrar"
        ButtonCerrar.Size = New Size(75, 23)
        ButtonCerrar.TabIndex = 23
        ButtonCerrar.Text = "Cerrar"
        ButtonCerrar.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewEmpleados
        ' 
        DataGridViewEmpleados.AllowUserToAddRows = False
        DataGridViewEmpleados.AllowUserToDeleteRows = False
        DataGridViewEmpleados.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewEmpleados.Location = New Point(12, 111)
        DataGridViewEmpleados.MultiSelect = False
        DataGridViewEmpleados.Name = "DataGridViewEmpleados"
        DataGridViewEmpleados.ReadOnly = True
        DataGridViewEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewEmpleados.Size = New Size(776, 298)
        DataGridViewEmpleados.TabIndex = 22
        ' 
        ' ButtonBuscarEmpleados
        ' 
        ButtonBuscarEmpleados.Location = New Point(430, 27)
        ButtonBuscarEmpleados.Name = "ButtonBuscarEmpleados"
        ButtonBuscarEmpleados.Size = New Size(134, 23)
        ButtonBuscarEmpleados.TabIndex = 21
        ButtonBuscarEmpleados.Text = "Buscar empleados"
        ButtonBuscarEmpleados.UseVisualStyleBackColor = True
        ' 
        ' TextBoxBuscarEmpleados
        ' 
        TextBoxBuscarEmpleados.Location = New Point(12, 27)
        TextBoxBuscarEmpleados.Name = "TextBoxBuscarEmpleados"
        TextBoxBuscarEmpleados.Size = New Size(412, 23)
        TextBoxBuscarEmpleados.TabIndex = 20
        ' 
        ' LabelBuscar
        ' 
        LabelBuscar.AutoSize = True
        LabelBuscar.Location = New Point(12, 9)
        LabelBuscar.Name = "LabelBuscar"
        LabelBuscar.Size = New Size(42, 15)
        LabelBuscar.TabIndex = 19
        LabelBuscar.Text = "Buscar"
        ' 
        ' Empleados
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(ButtonBorrar)
        Controls.Add(ButtonEditar)
        Controls.Add(ButtonNuevo)
        Controls.Add(ButtonCerrar)
        Controls.Add(DataGridViewEmpleados)
        Controls.Add(ButtonBuscarEmpleados)
        Controls.Add(TextBoxBuscarEmpleados)
        Controls.Add(LabelBuscar)
        Name = "Empleados"
        Text = "Empleados"
        CType(DataGridViewEmpleados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonBorrar As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents DataGridViewEmpleados As DataGridView
    Friend WithEvents ButtonBuscarEmpleados As Button
    Friend WithEvents TextBoxBuscarEmpleados As TextBox
    Friend WithEvents LabelBuscar As Label
End Class
