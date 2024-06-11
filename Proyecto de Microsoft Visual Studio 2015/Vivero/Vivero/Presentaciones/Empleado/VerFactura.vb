Imports System.ComponentModel
Public Class VerFactura
    Dim objNFactura As N_FACTURAS = New N_FACTURAS
    Dim num As Integer = 0
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(ByVal aux_num As Integer)
        num = aux_num
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub VerFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If num = 0 Then

            'TODO: esta línea de código carga datos en la tabla 'DatosDeFacturas.DataTable1' Puede moverla o quitarla según sea necesario.
            Me.DataTable1TableAdapter.SelectFactura(Me.DatosDeFacturas.DataTable1, objNFactura.ultimo_numero)
            ' Me.DataTable1TableAdapter.SelectFactura(Me.DatosDeFacturas.DataTable1)
            'TODO: esta línea de código carga datos en la tabla 'DatosDeFacturas.FACTURAS_DETALLE' Puede moverla o quitarla según sea necesario.
            Me.FACTURAS_DETALLETableAdapter.SelectDetalle_byFactura(Me.DatosDeFacturas.FACTURAS_DETALLE, objNFactura.ultimo_numero)

            Me.ReportViewer1.RefreshReport()
        Else
            'TODO: esta línea de código carga datos en la tabla 'DatosDeFacturas.DataTable1' Puede moverla o quitarla según sea necesario.
            Me.DataTable1TableAdapter.SelectFactura(Me.DatosDeFacturas.DataTable1, num)
            ' Me.DataTable1TableAdapter.SelectFactura(Me.DatosDeFacturas.DataTable1)
            'TODO: esta línea de código carga datos en la tabla 'DatosDeFacturas.FACTURAS_DETALLE' Puede moverla o quitarla según sea necesario.
            Me.FACTURAS_DETALLETableAdapter.SelectDetalle_byFactura(Me.DatosDeFacturas.FACTURAS_DETALLE, num)

            Me.ReportViewer1.RefreshReport()
        End If

    End Sub
End Class