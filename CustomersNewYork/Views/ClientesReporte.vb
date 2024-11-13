Imports System.Drawing

Public Class ClientesReporte
    Private sFormat As StringFormat
    Private columnLefts As New ArrayList
    Private columnsWidths As New ArrayList
    Private cellHeight As Integer = 0
    Private totalWidth As Integer = 0
    Private row As Integer = 0
    Private firstPage As Boolean = False
    Private newPage As Boolean = False
    Private headerHeight As Integer = 0

    Private Sub ButtonVistaPreliminar_Click(sender As Object, e As EventArgs) Handles ButtonVistaPreliminar.Click
        If DataGridViewClientes.Rows.Count > 0 Then
            Dim printPreview As New PrintPreviewDialog
            printPreview.Document = PrintDocumentClientes
            printPreview.ShowDialog()
        Else
            MessageBox.Show("No hay clientes para el reporte, Buscar clientes, y Vista preliminar.")
        End If
    End Sub
    Private Sub PrintDocumentClientes_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocumentClientes.BeginPrint
        Try
            sFormat = New StringFormat
            sFormat.Alignment = StringAlignment.Near
            sFormat.LineAlignment = StringAlignment.Center
            sFormat.Trimming = StringTrimming.EllipsisCharacter

            columnLefts.Clear()
            columnsWidths.Clear()
            cellHeight = 0
            row = 0
            newPage = True
            firstPage = True

            totalWidth = 0
            For Each dgvCol As DataGridViewColumn In DataGridViewClientes.Columns
                totalWidth += dgvCol.Width
            Next dgvCol
        Catch ex As Exception
            MessageBox.Show("Error begin print: " & ex.Message)
        End Try
    End Sub
    Private Sub PrintDocumentClientes_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentClientes.PrintPage
        Try
            Dim leftMargin As Integer = e.MarginBounds.Left
            Dim topMargin As Integer = e.MarginBounds.Top
            Dim morePagesToPrint As Boolean = False
            Dim tmpWidth As Integer = 0

            If firstPage Then
                For Each dgvCol As DataGridViewColumn In DataGridViewClientes.Columns
                    tmpWidth = CInt(Math.Truncate(Math.Floor(CDbl(CDbl(dgvCol.Width) / CDbl(totalWidth) * CDbl(totalWidth) * CDbl(e.MarginBounds.Width) / CDbl(totalWidth)))))
                    headerHeight = CInt(e.Graphics.MeasureString(dgvCol.HeaderText, dgvCol.InheritedStyle.Font, tmpWidth).Height + 11)

                    columnLefts.Add(leftMargin)
                    columnsWidths.Add(tmpWidth)
                    leftMargin += tmpWidth
                Next dgvCol
            End If

            Do While row <= DataGridViewClientes.Rows.Count - 1
                Dim dgvRow As DataGridViewRow = DataGridViewClientes.Rows(row)

                cellHeight = dgvRow.Height + 5
                Dim count As Integer = 0
                If topMargin + cellHeight >= e.MarginBounds.Height + e.MarginBounds.Top Then
                    newPage = True
                    firstPage = False
                    morePagesToPrint = True

                    Exit Do
                Else
                    If newPage Then
                        e.Graphics.DrawString("Clientes",
                            New Font(DataGridViewClientes.Font, FontStyle.Bold),
                            Brushes.Black,
                            e.MarginBounds.Left,
                            e.MarginBounds.Top)

                        Dim sDate As String = Date.Now.ToLongDateString & " " & Date.Now.ToShortTimeString

                        Dim iDraw1 As Integer
                        Dim iDraw2 As Integer

                        iDraw1 = e.MarginBounds.Left +
                                (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(sDate, New Font(DataGridViewClientes.Font, FontStyle.Bold), e.MarginBounds.Width).Width)

                        iDraw2 = e.MarginBounds.Top -
                                (e.Graphics.MeasureString("Clientes", New Font(New Font(DataGridViewClientes.Font, FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13)

                        e.Graphics.DrawString(sDate,
                            New Font(DataGridViewClientes.Font, FontStyle.Bold),
                            Brushes.Black,
                            iDraw1,
                            iDraw2)

                        topMargin = e.MarginBounds.Top + headerHeight

                        For Each dgvCol As DataGridViewColumn In DataGridViewClientes.Columns
                            e.Graphics.FillRectangle(New SolidBrush(Color.LightGray), New Rectangle(DirectCast(columnLefts(count), Integer), topMargin, DirectCast(columnsWidths(count), Integer), headerHeight))
                            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(DirectCast(columnLefts(count), Integer), topMargin, DirectCast(columnsWidths(count), Integer), headerHeight))
                            e.Graphics.DrawString(dgvCol.HeaderText, dgvCol.InheritedStyle.Font, New SolidBrush(dgvCol.InheritedStyle.ForeColor), New RectangleF(DirectCast(columnLefts(count), Integer), topMargin, DirectCast(columnsWidths(count), Integer), headerHeight), sFormat)

                            count += 1
                        Next dgvCol

                        newPage = False
                        topMargin += headerHeight
                    End If

                    count = 0
                    For Each cell As DataGridViewCell In dgvRow.Cells
                        If cell.Value IsNot Nothing Then
                            e.Graphics.DrawString(cell.Value.ToString, cell.InheritedStyle.Font, New SolidBrush(cell.InheritedStyle.ForeColor), New RectangleF(DirectCast(columnLefts(count), Integer), CSng(topMargin), DirectCast(columnsWidths(count), Integer), headerHeight), sFormat)
                        End If
                        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(DirectCast(columnLefts(count), Integer), topMargin, DirectCast(columnsWidths(count), Integer), cellHeight))
                        count += 1
                    Next cell

                End If

                row += 1
                topMargin += cellHeight
            Loop

            If morePagesToPrint Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error print page: " & ex.Message)
        End Try
    End Sub
    Private Sub BuscarClientes()
        Dim dataTable As New DataTable
        Dim textoBuscar As String
        textoBuscar = TextBoxBuscarCliente.Text.Trim()

        Dim sqlClientes As New SqlClientes()
        dataTable = sqlClientes.ObtenerClientesReporte(textoBuscar)
        DataGridViewClientes.DataSource = dataTable
        DataGridViewClientes.AutoResizeColumns()
    End Sub
    Private Sub ButtonBuscarCliente_Click(sender As Object, e As EventArgs) Handles ButtonBuscarCliente.Click
        BuscarClientes()
    End Sub
End Class