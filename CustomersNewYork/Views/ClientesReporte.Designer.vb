<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesReporte
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
        ButtonVistaPreliminar = New Button()
        PrintDocumentClientes = New Printing.PrintDocument()
        DataGridViewClientes = New DataGridView()
        ButtonBuscarCliente = New Button()
        TextBoxBuscarCliente = New TextBox()
        LabelBuscar = New Label()
        CType(DataGridViewClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonVistaPreliminar
        ' 
        ButtonVistaPreliminar.Location = New Point(570, 27)
        ButtonVistaPreliminar.Name = "ButtonVistaPreliminar"
        ButtonVistaPreliminar.Size = New Size(139, 23)
        ButtonVistaPreliminar.TabIndex = 0
        ButtonVistaPreliminar.Text = "Vista preliminar"
        ButtonVistaPreliminar.UseVisualStyleBackColor = True
        ' 
        ' PrintDocumentClientes
        ' 
        ' 
        ' DataGridViewClientes
        ' 
        DataGridViewClientes.AllowUserToAddRows = False
        DataGridViewClientes.AllowUserToDeleteRows = False
        DataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewClientes.Location = New Point(12, 56)
        DataGridViewClientes.Name = "DataGridViewClientes"
        DataGridViewClientes.Size = New Size(767, 150)
        DataGridViewClientes.TabIndex = 1
        ' 
        ' ButtonBuscarCliente
        ' 
        ButtonBuscarCliente.Location = New Point(430, 27)
        ButtonBuscarCliente.Name = "ButtonBuscarCliente"
        ButtonBuscarCliente.Size = New Size(134, 23)
        ButtonBuscarCliente.TabIndex = 5
        ButtonBuscarCliente.Text = "Buscar clientes"
        ButtonBuscarCliente.UseVisualStyleBackColor = True
        ' 
        ' TextBoxBuscarCliente
        ' 
        TextBoxBuscarCliente.Location = New Point(12, 27)
        TextBoxBuscarCliente.Name = "TextBoxBuscarCliente"
        TextBoxBuscarCliente.Size = New Size(412, 23)
        TextBoxBuscarCliente.TabIndex = 4
        ' 
        ' LabelBuscar
        ' 
        LabelBuscar.AutoSize = True
        LabelBuscar.Location = New Point(12, 9)
        LabelBuscar.Name = "LabelBuscar"
        LabelBuscar.Size = New Size(42, 15)
        LabelBuscar.TabIndex = 3
        LabelBuscar.Text = "Buscar"
        ' 
        ' ClientesReporte
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonBuscarCliente)
        Controls.Add(TextBoxBuscarCliente)
        Controls.Add(LabelBuscar)
        Controls.Add(DataGridViewClientes)
        Controls.Add(ButtonVistaPreliminar)
        Name = "ClientesReporte"
        Text = "ClientesReporte"
        CType(DataGridViewClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonVistaPreliminar As Button
    Friend WithEvents PrintDocumentClientes As Printing.PrintDocument
    Friend WithEvents DataGridViewClientes As DataGridView
    Friend WithEvents ButtonBuscarCliente As Button
    Friend WithEvents TextBoxBuscarCliente As TextBox
    Friend WithEvents LabelBuscar As Label
End Class
