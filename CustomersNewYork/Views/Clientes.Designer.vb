<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        LabelBuscar = New Label()
        TextBoxBuscarCliente = New TextBox()
        ButtonBuscarCliente = New Button()
        DataGridViewClientes = New DataGridView()
        ButtonCerrar = New Button()
        ButtonNuevo = New Button()
        ButtonEditar = New Button()
        ButtonBorrar = New Button()
        Label1 = New Label()
        CType(DataGridViewClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelBuscar
        ' 
        LabelBuscar.AutoSize = True
        LabelBuscar.Location = New Point(12, 9)
        LabelBuscar.Name = "LabelBuscar"
        LabelBuscar.Size = New Size(42, 15)
        LabelBuscar.TabIndex = 0
        LabelBuscar.Text = "Buscar"
        ' 
        ' TextBoxBuscarCliente
        ' 
        TextBoxBuscarCliente.Location = New Point(12, 27)
        TextBoxBuscarCliente.Name = "TextBoxBuscarCliente"
        TextBoxBuscarCliente.Size = New Size(412, 23)
        TextBoxBuscarCliente.TabIndex = 1
        ' 
        ' ButtonBuscarCliente
        ' 
        ButtonBuscarCliente.Location = New Point(430, 27)
        ButtonBuscarCliente.Name = "ButtonBuscarCliente"
        ButtonBuscarCliente.Size = New Size(134, 23)
        ButtonBuscarCliente.TabIndex = 2
        ButtonBuscarCliente.Text = "Buscar cliente"
        ButtonBuscarCliente.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewClientes
        ' 
        DataGridViewClientes.AllowUserToAddRows = False
        DataGridViewClientes.AllowUserToDeleteRows = False
        DataGridViewClientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewClientes.Location = New Point(12, 111)
        DataGridViewClientes.MultiSelect = False
        DataGridViewClientes.Name = "DataGridViewClientes"
        DataGridViewClientes.ReadOnly = True
        DataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewClientes.Size = New Size(776, 298)
        DataGridViewClientes.TabIndex = 3
        ' 
        ' ButtonCerrar
        ' 
        ButtonCerrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonCerrar.Location = New Point(713, 415)
        ButtonCerrar.Name = "ButtonCerrar"
        ButtonCerrar.Size = New Size(75, 23)
        ButtonCerrar.TabIndex = 4
        ButtonCerrar.Text = "Cerrar"
        ButtonCerrar.UseVisualStyleBackColor = True
        ' 
        ' ButtonNuevo
        ' 
        ButtonNuevo.Location = New Point(12, 56)
        ButtonNuevo.Name = "ButtonNuevo"
        ButtonNuevo.Size = New Size(75, 23)
        ButtonNuevo.TabIndex = 5
        ButtonNuevo.Text = "Nuevo"
        ButtonNuevo.UseVisualStyleBackColor = True
        ' 
        ' ButtonEditar
        ' 
        ButtonEditar.Location = New Point(93, 56)
        ButtonEditar.Name = "ButtonEditar"
        ButtonEditar.Size = New Size(75, 23)
        ButtonEditar.TabIndex = 6
        ButtonEditar.Text = "Editar"
        ButtonEditar.UseVisualStyleBackColor = True
        ' 
        ' ButtonBorrar
        ' 
        ButtonBorrar.Location = New Point(174, 56)
        ButtonBorrar.Name = "ButtonBorrar"
        ButtonBorrar.Size = New Size(75, 23)
        ButtonBorrar.TabIndex = 7
        ButtonBorrar.Text = "Borrar"
        ButtonBorrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(226, 15)
        Label1.TabIndex = 8
        Label1.Text = "Seleccionar un cliente para Editar o Borrar"
        ' 
        ' Clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(ButtonBorrar)
        Controls.Add(ButtonEditar)
        Controls.Add(ButtonNuevo)
        Controls.Add(ButtonCerrar)
        Controls.Add(DataGridViewClientes)
        Controls.Add(ButtonBuscarCliente)
        Controls.Add(TextBoxBuscarCliente)
        Controls.Add(LabelBuscar)
        Name = "Clientes"
        Text = "Clientes"
        CType(DataGridViewClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelBuscar As Label
    Friend WithEvents TextBoxBuscarCliente As TextBox
    Friend WithEvents ButtonBuscarCliente As Button
    Friend WithEvents DataGridViewClientes As DataGridView
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonBorrar As Button
    Friend WithEvents Label1 As Label
End Class
