Public Class D_FACTURAS
    Dim ctx As DB_VIVEROEntities = New DB_VIVEROEntities

    Public Function getUltimoNumero()
        Try
            Using ctx As New DB_VIVEROEntities
                Dim listaFacturas = (From q In ctx.FACTURAS Select q).ToList
                If Not listaFacturas.Count = 0 Then
                    Dim contador As Integer = listaFacturas.Count
                    Return listaFacturas.Item(contador - 1).num_factura
                Else
                    Return 0
                End If
            End Using
        Catch Ex As Exception
            Return MessageBox.Show("Error al obtener ultimo numero de factura")
        End Try
    End Function

    Public Function Agregar_Factura(ByVal e As FACTURAS) As Boolean
        Try
            ctx.FACTURAS.Add(e)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function getFacturasAll(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objMostrar = (From q In ctx.FACTURAS
                                  Select Num = q.num_factura,
                                      Fecha_Y_Hora = q.fecha_y_hora,
                                      Id_Vendedor = q.id_vendedor,
                                      Nombre = q.USUARIOS.nombre,
                                      Apellido = q.USUARIOS.apellido,
                                      DNI_Vendedor = q.USUARIOS.DNI,
                                      Id_FdePago = q.id_FdePago,
                                      FdePago = q.FORMAS_DE_PAGO.FdePago,
                                      Nombre_cliente = q.CLIENTES.nombre,
                                      Apellido_cliente = q.CLIENTES.apellido,
                                      Total = q.total,
                                      Anulado = q.anulado
                                  ).ToList

                grid.DataSource = objMostrar
                grid.Columns(2).Visible = False
                grid.Columns(6).Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function getFacturasAll_byFecha(ByVal grid As DataGridView, ByVal desde As Date, ByVal hasta As Date)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objMostrar = (From q In ctx.FACTURAS
                                  Where desde <= q.fecha_y_hora And q.fecha_y_hora <= hasta
                                  Select Num = q.num_factura,
                                      Fecha_Y_Hora = q.fecha_y_hora,
                                      Id_Vendedor = q.id_vendedor,
                                      Nombre = q.USUARIOS.nombre,
                                      Apellido = q.USUARIOS.apellido,
                                      DNI_Vendedor = q.USUARIOS.DNI,
                                      Id_FdePago = q.id_FdePago,
                                      FdePago = q.FORMAS_DE_PAGO.FdePago,
                                      Nombre_cliente = q.CLIENTES.nombre,
                                      Apellido_cliente = q.CLIENTES.apellido,
                                      Total = q.total,
                                      Anulado = q.anulado
                                  ).ToList

                grid.DataSource = objMostrar
                grid.Columns(2).Visible = False
                grid.Columns(6).Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function getFacturas_byVendedor(ByVal grid As DataGridView, ByVal aux_id_usuario As Short)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objMostrar = (From q In ctx.FACTURAS
                                  Where q.id_vendedor = aux_id_usuario
                                  Select Num = q.num_factura,
                                      Fecha_Y_Hora = q.fecha_y_hora,
                                      Nombre_Vendedor = q.USUARIOS.nombre,
                                      Apellido_Vendedor = q.USUARIOS.apellido,
                                      FdePago = q.FORMAS_DE_PAGO.FdePago,
                                      Apellido_cliente = q.CLIENTES.apellido,
                                      Nombre_cliente = q.CLIENTES.nombre,
                                      Total = q.total,
                                      Anulado = q.anulado
                                  ).ToList

                grid.DataSource = objMostrar
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function getFacturas_byFecha(ByVal grid As DataGridView, ByVal aux_id_usuario As Short, ByVal desde As Date, ByVal hasta As Date)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objMostrar = (From q In ctx.FACTURAS
                                  Where q.id_vendedor = aux_id_usuario And desde <= q.fecha_y_hora And q.fecha_y_hora <= hasta
                                  Select Num = q.num_factura,
                                      Fecha_Y_Hora = q.fecha_y_hora,
                                      Nombre_Vendedor = q.USUARIOS.nombre,
                                      Apellido_Vendedor = q.USUARIOS.apellido,
                                      FdePago = q.FORMAS_DE_PAGO.FdePago,
                                      Apellido_cliente = q.CLIENTES.apellido,
                                      Nombre_cliente = q.CLIENTES.nombre,
                                      Total = q.total,
                                      Anulado = q.anulado
                                  ).ToList

                grid.DataSource = objMostrar
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function




End Class
