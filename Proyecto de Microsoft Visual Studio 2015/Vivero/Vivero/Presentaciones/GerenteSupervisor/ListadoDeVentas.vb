Public Class ListadoDeVentas

    Dim objNFactura As N_FACTURAS = New N_FACTURAS
    Dim objNDetalle As N_FACTURAS_DETALLE = New N_FACTURAS_DETALLE
    Dim imprimir_factura As VerFactura
    Dim fila As Integer
    Dim aux_num_factura As Integer

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click

        objNFactura.cargarGrid(DataGridView_Facturas)
        DataGridView_Detalles.Columns.Clear()
        MsgBox("Listado actualizado", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
    End Sub

    Private Sub MisVentas_Load(sender As Object, e As EventArgs) Handles Me.Load
        objNFactura.cargarGrid(DataGridView_Facturas)
        FechaDesde.Value = DateAdd("d", -1, DateTime.Now.Date)
        FechaHasta.Value = DateAdd("d", 1, DateTime.Now.Date)
        FechaDesde.MinDate = "5/11/2000"
        FechaDesde.MaxDate = "5/11/2050"
        FechaHasta.MinDate = "5/11/2000"
        FechaHasta.MaxDate = "5/11/2050"
    End Sub

    Private Sub DataGridView_Facturas_Click(sender As Object, e As EventArgs) Handles DataGridView_Facturas.Click
        If DataGridView_Facturas.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        fila = DataGridView_Facturas.CurrentRow.Index
        aux_num_factura = Me.DataGridView_Facturas.Rows(fila).Cells(0).Value
        objNDetalle.cargarGrid(DataGridView_Detalles, aux_num_factura)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        objNFactura.cargarGrid_byFecha_All(DataGridView_Facturas, CDate(FechaDesde.Text), CDate(FechaHasta.Text))
        DataGridView_Detalles.Columns.Clear()
    End Sub

    Private Sub FechaDesde_CloseUp(sender As Object, e As EventArgs) Handles FechaDesde.CloseUp
        FechaHasta.MinDate = DateAdd("d", 1, CDate(FechaDesde.Text))
    End Sub

    Private Sub FechaHasta_CloseUp(sender As Object, e As EventArgs) Handles FechaHasta.CloseUp
        FechaDesde.MaxDate = DateAdd("d", -1, CDate(FechaHasta.Text))
    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        If DataGridView_Facturas.SelectedRows.Count = 0 Then
            MsgBox("Haga click en una factura", MsgBoxStyle.Information, "Seleccione una factura de la tabla")
        Else
            fila = DataGridView_Facturas.CurrentRow.Index
            aux_num_factura = Me.DataGridView_Facturas.Rows(fila).Cells(0).Value
            imprimir_factura = New VerFactura(aux_num_factura)
            imprimir_factura.ShowDialog()
        End If
    End Sub
End Class