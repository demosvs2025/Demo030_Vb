<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosPorClienteTotales
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
        ButtonBuscar = New Button()
        LabelBuscar = New Label()
        DataGridViewPedidosPorCliente = New DataGridView()
        ButtonVistaPreliminar = New Button()
        CType(DataGridViewPedidosPorCliente, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonCerrar
        ' 
        ButtonCerrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonCerrar.Location = New Point(713, 415)
        ButtonCerrar.Name = "ButtonCerrar"
        ButtonCerrar.Size = New Size(75, 23)
        ButtonCerrar.TabIndex = 11
        ButtonCerrar.Text = "Cerrar"
        ButtonCerrar.UseVisualStyleBackColor = True
        ' 
        ' ButtonBuscar
        ' 
        ButtonBuscar.Location = New Point(12, 27)
        ButtonBuscar.Name = "ButtonBuscar"
        ButtonBuscar.Size = New Size(134, 23)
        ButtonBuscar.TabIndex = 10
        ButtonBuscar.Text = "Buscar"
        ButtonBuscar.UseVisualStyleBackColor = True
        ' 
        ' LabelBuscar
        ' 
        LabelBuscar.AutoSize = True
        LabelBuscar.Location = New Point(12, 9)
        LabelBuscar.Name = "LabelBuscar"
        LabelBuscar.Size = New Size(233, 15)
        LabelBuscar.TabIndex = 9
        LabelBuscar.Text = "Pedidos por cliente, totales mayor a menor"
        ' 
        ' DataGridViewPedidosPorCliente
        ' 
        DataGridViewPedidosPorCliente.AllowUserToAddRows = False
        DataGridViewPedidosPorCliente.AllowUserToDeleteRows = False
        DataGridViewPedidosPorCliente.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewPedidosPorCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPedidosPorCliente.Location = New Point(12, 56)
        DataGridViewPedidosPorCliente.Name = "DataGridViewPedidosPorCliente"
        DataGridViewPedidosPorCliente.Size = New Size(776, 353)
        DataGridViewPedidosPorCliente.TabIndex = 8
        ' 
        ' ButtonVistaPreliminar
        ' 
        ButtonVistaPreliminar.Location = New Point(152, 27)
        ButtonVistaPreliminar.Name = "ButtonVistaPreliminar"
        ButtonVistaPreliminar.Size = New Size(139, 23)
        ButtonVistaPreliminar.TabIndex = 7
        ButtonVistaPreliminar.Text = "Vista preliminar"
        ButtonVistaPreliminar.UseVisualStyleBackColor = True
        ' 
        ' PedidosPorClienteTotales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonCerrar)
        Controls.Add(ButtonBuscar)
        Controls.Add(LabelBuscar)
        Controls.Add(DataGridViewPedidosPorCliente)
        Controls.Add(ButtonVistaPreliminar)
        Name = "PedidosPorClienteTotales"
        Text = "PedidosPorClienteTotales"
        CType(DataGridViewPedidosPorCliente, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents LabelBuscar As Label
    Friend WithEvents DataGridViewPedidosPorCliente As DataGridView
    Friend WithEvents ButtonVistaPreliminar As Button
End Class
