Public Class N_FACTURAS

    Dim D_una_factura As D_FACTURAS = New D_FACTURAS

    Function agregar_factura(ByVal aux_num_factura As Integer, ByVal aux_fecha_y_hora As Date, ByVal aux_id_vendedor As Short, ByVal aux_id_FdePago As Byte, ByVal aux_id_cliente As Integer, ByVal aux_total As Double) As Boolean

        Dim E_una_factura = New FACTURAS()
        Dim no As String = "NO"

        With E_una_factura
            .num_factura() = aux_num_factura
            .fecha_y_hora() = aux_fecha_y_hora
            .id_vendedor() = aux_id_vendedor
            .id_FdePago() = aux_id_FdePago
            .id_cliente() = aux_id_cliente
            .total() = aux_total
            .anulado() = no
        End With

        Dim D_una_factura = New D_FACTURAS
        Dim agregar As Boolean = D_una_factura.Agregar_Factura(E_una_factura)
        If agregar Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub cargarGrid(ByVal grid As DataGridView)

        Dim facturas As D_FACTURAS = New D_FACTURAS
        facturas.getFacturasAll(grid)
        grid.ClearSelection()
    End Sub

    Public Function ultimo_numero() As Integer
        Dim ult_num As Integer
        ult_num = D_una_factura.getUltimoNumero()
        Return ult_num
    End Function

    Public Sub cargarGrid_byVendedor(ByVal grid As DataGridView, ByVal aux_id_usuario As Short)
        Dim facturas As D_FACTURAS = New D_FACTURAS
        facturas.getFacturas_byVendedor(grid, aux_id_usuario)
        grid.ClearSelection()
    End Sub

    Public Sub cargarGrid_byFecha(ByVal grid As DataGridView, ByVal aux_id_usuario As Short, ByVal desde As Date, ByVal hasta As Date)
        Dim facturas As D_FACTURAS = New D_FACTURAS
        facturas.getFacturas_byFecha(grid, aux_id_usuario, desde, hasta)
        grid.ClearSelection()
    End Sub

    Public Sub cargarGrid_byFecha_All(ByVal grid As DataGridView, ByVal desde As Date, ByVal hasta As Date)
        Dim facturas As D_FACTURAS = New D_FACTURAS
        facturas.getFacturasAll_byFecha(grid, desde, hasta)
        grid.ClearSelection()
    End Sub

End Class
