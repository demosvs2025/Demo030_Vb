<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        MenuStrip1 = New MenuStrip()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        NuevoClienteToolStripMenuItem = New ToolStripMenuItem()
        BuscarClientesToolStripMenuItem = New ToolStripMenuItem()
        ReporteClientesToolStripMenuItem = New ToolStripMenuItem()
        PedidoToolStripMenuItem = New ToolStripMenuItem()
        PedidosPorClienteToolStripMenuItem = New ToolStripMenuItem()
        TotalesMayorAMenorToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        NuevoProductoToolStripMenuItem = New ToolStripMenuItem()
        BuscarProductosToolStripMenuItem = New ToolStripMenuItem()
        EmpleadosToolStripMenuItem = New ToolStripMenuItem()
        NuevoEmpleadoToolStripMenuItem = New ToolStripMenuItem()
        BuscarEmpleadosToolStripMenuItem = New ToolStripMenuItem()
        CatalogosToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        PedidosPorEmpleadoToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, PedidoToolStripMenuItem, PedidosPorClienteToolStripMenuItem, ProductosToolStripMenuItem, EmpleadosToolStripMenuItem, CatalogosToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NuevoClienteToolStripMenuItem, BuscarClientesToolStripMenuItem, ReporteClientesToolStripMenuItem})
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(61, 20)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' NuevoClienteToolStripMenuItem
        ' 
        NuevoClienteToolStripMenuItem.Name = "NuevoClienteToolStripMenuItem"
        NuevoClienteToolStripMenuItem.Size = New Size(158, 22)
        NuevoClienteToolStripMenuItem.Text = "Nuevo cliente"
        ' 
        ' BuscarClientesToolStripMenuItem
        ' 
        BuscarClientesToolStripMenuItem.Name = "BuscarClientesToolStripMenuItem"
        BuscarClientesToolStripMenuItem.Size = New Size(158, 22)
        BuscarClientesToolStripMenuItem.Text = "Buscar clientes"
        ' 
        ' ReporteClientesToolStripMenuItem
        ' 
        ReporteClientesToolStripMenuItem.Name = "ReporteClientesToolStripMenuItem"
        ReporteClientesToolStripMenuItem.Size = New Size(158, 22)
        ReporteClientesToolStripMenuItem.Text = "Reporte clientes"
        ' 
        ' PedidoToolStripMenuItem
        ' 
        PedidoToolStripMenuItem.Name = "PedidoToolStripMenuItem"
        PedidoToolStripMenuItem.Size = New Size(61, 20)
        PedidoToolStripMenuItem.Text = "Pedidos"
        ' 
        ' PedidosPorClienteToolStripMenuItem
        ' 
        PedidosPorClienteToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TotalesMayorAMenorToolStripMenuItem, PedidosPorEmpleadoToolStripMenuItem})
        PedidosPorClienteToolStripMenuItem.Name = "PedidosPorClienteToolStripMenuItem"
        PedidosPorClienteToolStripMenuItem.Size = New Size(120, 20)
        PedidosPorClienteToolStripMenuItem.Text = "Pedidos por cliente"
        ' 
        ' TotalesMayorAMenorToolStripMenuItem
        ' 
        TotalesMayorAMenorToolStripMenuItem.Name = "TotalesMayorAMenorToolStripMenuItem"
        TotalesMayorAMenorToolStripMenuItem.Size = New Size(194, 22)
        TotalesMayorAMenorToolStripMenuItem.Text = "Totales mayor a menor"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NuevoProductoToolStripMenuItem, BuscarProductosToolStripMenuItem})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(73, 20)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' NuevoProductoToolStripMenuItem
        ' 
        NuevoProductoToolStripMenuItem.Name = "NuevoProductoToolStripMenuItem"
        NuevoProductoToolStripMenuItem.Size = New Size(166, 22)
        NuevoProductoToolStripMenuItem.Text = "Nuevo producto"
        ' 
        ' BuscarProductosToolStripMenuItem
        ' 
        BuscarProductosToolStripMenuItem.Name = "BuscarProductosToolStripMenuItem"
        BuscarProductosToolStripMenuItem.Size = New Size(166, 22)
        BuscarProductosToolStripMenuItem.Text = "Buscar productos"
        ' 
        ' EmpleadosToolStripMenuItem
        ' 
        EmpleadosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NuevoEmpleadoToolStripMenuItem, BuscarEmpleadosToolStripMenuItem})
        EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        EmpleadosToolStripMenuItem.Size = New Size(77, 20)
        EmpleadosToolStripMenuItem.Text = "Empleados"
        ' 
        ' NuevoEmpleadoToolStripMenuItem
        ' 
        NuevoEmpleadoToolStripMenuItem.Name = "NuevoEmpleadoToolStripMenuItem"
        NuevoEmpleadoToolStripMenuItem.Size = New Size(170, 22)
        NuevoEmpleadoToolStripMenuItem.Text = "Nuevo empleado"
        ' 
        ' BuscarEmpleadosToolStripMenuItem
        ' 
        BuscarEmpleadosToolStripMenuItem.Name = "BuscarEmpleadosToolStripMenuItem"
        BuscarEmpleadosToolStripMenuItem.Size = New Size(170, 22)
        BuscarEmpleadosToolStripMenuItem.Text = "Buscar empleados"
        ' 
        ' CatalogosToolStripMenuItem
        ' 
        CatalogosToolStripMenuItem.Name = "CatalogosToolStripMenuItem"
        CatalogosToolStripMenuItem.Size = New Size(72, 20)
        CatalogosToolStripMenuItem.Text = "Catalogos"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(41, 20)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' PedidosPorEmpleadoToolStripMenuItem
        ' 
        PedidosPorEmpleadoToolStripMenuItem.Name = "PedidosPorEmpleadoToolStripMenuItem"
        PedidosPorEmpleadoToolStripMenuItem.Size = New Size(194, 22)
        PedidosPorEmpleadoToolStripMenuItem.Text = "Pedidos por empleado"
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Menu"
        Text = "Menu"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosPorClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalesMayorAMenorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosPorEmpleadoToolStripMenuItem As ToolStripMenuItem
End Class
