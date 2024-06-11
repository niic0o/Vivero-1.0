Imports System.ComponentModel
Public Class VentasProductos
    Private Sub VentasProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatosProductos.DataTable1' Puede moverla o quitarla según sea necesario.
        Me.DataTable1TableAdapter.ProductosMasVendidos(Me.DatosProductos.DataTable1)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class