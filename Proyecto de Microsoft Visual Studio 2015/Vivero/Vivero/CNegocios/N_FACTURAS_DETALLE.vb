Public Class N_FACTURAS_DETALLE

    Dim objNProducto As N_PRODUCTOS = New N_PRODUCTOS
    Dim un_detalle As D_FACTURAS_DETALLE = New D_FACTURAS_DETALLE

    Function agregar_un_detalle(ByVal aux_num_factura As Integer, ByVal aux_id_item As Byte, ByVal aux_id_producto As Integer, ByVal aux_descripcion As String, ByVal aux_precio As Double, ByVal aux_cantidad As Short, ByVal aux_sub_total As Double) As Boolean

        Dim un_detalle = New FACTURAS_DETALLE()

        With un_detalle
            .num_factura() = aux_num_factura
            .id_item() = aux_id_item
            .id_producto() = aux_id_producto
            .descripcion() = aux_descripcion
            .precio() = aux_precio
            .cantidad() = aux_cantidad
            .sub_total() = aux_sub_total
        End With

        Dim D_un_detalle = New D_FACTURAS_DETALLE
        Dim agregar As Boolean = D_un_detalle.Agregar_Factura_Detalle(un_detalle)
        If agregar Then
            objNProducto.actualizar_stock(un_detalle.id_producto, un_detalle.cantidad)
            objNProducto.set_veces_vendido(un_detalle.id_producto, un_detalle.cantidad)
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub cargarGrid(ByVal grid As DataGridView, ByVal aux_num_factura As Integer)

        Dim detalles As D_FACTURAS_DETALLE = New D_FACTURAS_DETALLE
        detalles.getDetalle_byFactura(grid, aux_num_factura)
        grid.ClearSelection()
    End Sub

End Class
