Public Class Menu
    Private Sub BuscarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarClientesToolStripMenuItem.Click
        Dim clientesForm As New Clientes()
        clientesForm.MdiParent = Me
        clientesForm.Show()
    End Sub
    Private Sub NuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoClienteToolStripMenuItem.Click
        Dim clienteForm As New Cliente()
        clienteForm.MdiParent = Me
        clienteForm.Show()
    End Sub
    Private Sub ReporteClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteClientesToolStripMenuItem.Click
        Dim clientesReporteForm As New ClientesReporte()
        clientesReporteForm.MdiParent = Me
        clientesReporteForm.Show()
    End Sub
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TotalesMayorAMenorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalesMayorAMenorToolStripMenuItem.Click
        Dim pedidosPorClienteTotalesForm As New PedidosPorClienteTotales()
        pedidosPorClienteTotalesForm.MdiParent = Me
        pedidosPorClienteTotalesForm.Show()
    End Sub

    Private Sub NuevoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoProductoToolStripMenuItem.Click
        Dim productoForm As New Producto()
        productoForm.MdiParent = Me
        productoForm.Show()
    End Sub

    Private Sub BuscarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarProductosToolStripMenuItem.Click
        Dim productosForm As New Productos()
        productosForm.MdiParent = Me
        productosForm.Show()
    End Sub

    Private Sub NuevoEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoEmpleadoToolStripMenuItem.Click
        Dim empleadoForm As New Empleado()
        empleadoForm.MdiParent = Me
        empleadoForm.Show()
    End Sub

    Private Sub BuscarEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarEmpleadosToolStripMenuItem.Click
        Dim empleadosForm As New Empleados()
        empleadosForm.MdiParent = Me
        empleadosForm.Show()
    End Sub

    Private Sub PedidosPorEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosPorEmpleadoToolStripMenuItem.Click
        Dim pedidosPorEmpleadoForm As New PedidosPorEmpleado
        pedidosPorEmpleadoForm.MdiParent = Me
        pedidosPorEmpleadoForm.Show()
    End Sub
End Class