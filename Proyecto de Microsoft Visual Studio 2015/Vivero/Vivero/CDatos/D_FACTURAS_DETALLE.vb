Public Class D_FACTURAS_DETALLE
    Dim ctx As DB_VIVEROEntities = New DB_VIVEROEntities

    Public Function UltimoDetalle()
        Try
            Using ctx
                Dim listaDetalle = (From q In ctx.FACTURAS_DETALLE Select q).ToList
                Dim contador As Integer = listaDetalle.Count

                If contador = 0 Then
                    Return 0
                Else
                    Return listaDetalle.Item(contador - 1).id_item
                End If
            End Using
        Catch Ex As Exception
            Return MessageBox.Show("Error al obtener ultimo detalle")
        End Try
    End Function

    Public Function Agregar_Factura_Detalle(ByVal e As FACTURAS_DETALLE) As Boolean
        Try
            ctx.FACTURAS_DETALLE.Add(e)
            ctx.SaveChanges()

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function getDetalle_byFactura(ByVal grid As DataGridView, ByVal aux_num_factura As Integer)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objMostrar = (From q In ctx.FACTURAS_DETALLE
                                  Where q.num_factura = aux_num_factura
                                  Select Factura_Numero = q.num_factura,
                                      Item = q.id_item,
                                      Cod_prod = q.id_producto,
                                      Descripcion = q.descripcion,
                                      Precio = q.precio,
                                      Cantidad = q.cantidad,
                                      Sub_Total = q.sub_total
                                  ).ToList

                grid.DataSource = objMostrar
                grid.Columns(0).Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
