Imports System.ComponentModel
Public Class ReporteDeIngresos
    Private Sub ReporteDeIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatosVentasPorVendedor.DataTable1' Puede moverla o quitarla según sea necesario.
        Me.DataTable1TableAdapter.IngresoPorVendedor(Me.DatosVentasPorVendedor.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class