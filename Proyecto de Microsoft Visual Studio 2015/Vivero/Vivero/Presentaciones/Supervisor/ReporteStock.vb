Imports System.ComponentModel
Public Class ReporteStock
    Private Sub ReporteStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatosProdPorCategoria.DataTable1' Puede moverla o quitarla según sea necesario.
        Me.DataTable1TableAdapter.ProductosPorCategoria(Me.DatosProdPorCategoria.DataTable1)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class