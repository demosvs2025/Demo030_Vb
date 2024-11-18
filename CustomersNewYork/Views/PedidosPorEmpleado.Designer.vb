<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosPorEmpleado
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
        DataGridViewPedidosPorEmpleado = New DataGridView()
        ButtonVistaPreliminar = New Button()
        CType(DataGridViewPedidosPorEmpleado, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonCerrar
        ' 
        ButtonCerrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonCerrar.Location = New Point(713, 417)
        ButtonCerrar.Name = "ButtonCerrar"
        ButtonCerrar.Size = New Size(75, 23)
        ButtonCerrar.TabIndex = 16
        ButtonCerrar.Text = "Cerrar"
        ButtonCerrar.UseVisualStyleBackColor = True
        ' 
        ' ButtonBuscar
        ' 
        ButtonBuscar.Location = New Point(12, 29)
        ButtonBuscar.Name = "ButtonBuscar"
        ButtonBuscar.Size = New Size(134, 23)
        ButtonBuscar.TabIndex = 15
        ButtonBuscar.Text = "Buscar"
        ButtonBuscar.UseVisualStyleBackColor = True
        ' 
        ' LabelBuscar
        ' 
        LabelBuscar.AutoSize = True
        LabelBuscar.Location = New Point(12, 11)
        LabelBuscar.Name = "LabelBuscar"
        LabelBuscar.Size = New Size(126, 15)
        LabelBuscar.TabIndex = 14
        LabelBuscar.Text = "Pedidos por empleado"
        ' 
        ' DataGridViewPedidosPorEmpleado
        ' 
        DataGridViewPedidosPorEmpleado.AllowUserToAddRows = False
        DataGridViewPedidosPorEmpleado.AllowUserToDeleteRows = False
        DataGridViewPedidosPorEmpleado.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewPedidosPorEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPedidosPorEmpleado.Location = New Point(12, 58)
        DataGridViewPedidosPorEmpleado.Name = "DataGridViewPedidosPorEmpleado"
        DataGridViewPedidosPorEmpleado.Size = New Size(776, 353)
        DataGridViewPedidosPorEmpleado.TabIndex = 13
        ' 
        ' ButtonVistaPreliminar
        ' 
        ButtonVistaPreliminar.Location = New Point(152, 29)
        ButtonVistaPreliminar.Name = "ButtonVistaPreliminar"
        ButtonVistaPreliminar.Size = New Size(139, 23)
        ButtonVistaPreliminar.TabIndex = 12
        ButtonVistaPreliminar.Text = "Vista preliminar"
        ButtonVistaPreliminar.UseVisualStyleBackColor = True
        ' 
        ' PedidosPorEmpleado
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonCerrar)
        Controls.Add(ButtonBuscar)
        Controls.Add(LabelBuscar)
        Controls.Add(DataGridViewPedidosPorEmpleado)
        Controls.Add(ButtonVistaPreliminar)
        Name = "PedidosPorEmpleado"
        Text = "PedidosPorEmpleado"
        CType(DataGridViewPedidosPorEmpleado, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents LabelBuscar As Label
    Friend WithEvents DataGridViewPedidosPorEmpleado As DataGridView
    Friend WithEvents ButtonVistaPreliminar As Button
End Class
