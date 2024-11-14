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
End Class