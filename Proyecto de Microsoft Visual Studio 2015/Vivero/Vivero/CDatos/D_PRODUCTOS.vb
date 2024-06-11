Public Class D_PRODUCTOS
    Dim ctx As DB_VIVEROEntities = New DB_VIVEROEntities

    Function Dguardar_producto(ByVal e As PRODUCTOS) As Boolean
        Try
            ctx.PRODUCTOS.Add(e)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function D_getProductosAll(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.PRODUCTOS
                                     Where q.eliminado = "NO" And q.TIPOS_DE_PRODUCTOS.eliminado = "NO" And q.TIPOS_DE_PRODUCTOS.CATEGORIAS.eliminado = "NO"
                                     Select Id_categoria = q.id_categoria,
                                         Id_tipo = q.id_tipo,
                                         Id_producto = q.id_producto,
                                   Categoria = q.TIPOS_DE_PRODUCTOS.CATEGORIAS.categoria,
                                         Tipo = q.TIPOS_DE_PRODUCTOS.tipo,
                                         Nombre = q.nombre,
                                         Descripcion = q.descripcion,
                                         Tamanio = q.tamanio,
                                         Disponible = q.disponible,
                                         Stock_min = q.stock_min,
                                         Stock = q.stock,
                                         Precio_lista = q.precio_lista,
                                         Precio_venta = q.precio_venta,
                                         Descuento = q.descuento,
                                         Veces_vendido = q.veces_vendido,
                                         Eliminado = q.eliminado
).ToList
                grid.DataSource = objetoMostrar
                grid.Columns("Id_categoria").Visible = False
                grid.Columns("Id_tipo").Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_getProductosAll_inactivos(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.PRODUCTOS
                                     Where q.eliminado = "SI" And q.TIPOS_DE_PRODUCTOS.eliminado = "NO" And q.TIPOS_DE_PRODUCTOS.CATEGORIAS.eliminado = "NO"
                                     Select Id_categoria = q.id_categoria,
                                         Id_tipo = q.id_tipo,
                                         Id_producto = q.id_producto,
                                   Categoria = q.TIPOS_DE_PRODUCTOS.CATEGORIAS.categoria,
                                         Tipo = q.TIPOS_DE_PRODUCTOS.tipo,
                                         Nombre = q.nombre,
                                         Descripcion = q.descripcion,
                                         Tamanio = q.tamanio,
                                         Disponible = q.disponible,
                                         Stock_min = q.stock_min,
                                         Stock = q.stock,
                                         Precio_lista = q.precio_lista,
                                         Precio_venta = q.precio_venta,
                                         Descuento = q.descuento,
                                         Veces_vendido = q.veces_vendido,
                                         Eliminado = q.eliminado
).ToList
                grid.DataSource = objetoMostrar
                grid.Columns("Id_categoria").Visible = False
                grid.Columns("Id_tipo").Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_getProductosAll_activo_inactivo(ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoMostrar = (From q In ctx.PRODUCTOS
                                     Where q.TIPOS_DE_PRODUCTOS.eliminado = "NO" And q.TIPOS_DE_PRODUCTOS.CATEGORIAS.eliminado = "NO"
                                     Select Id_categoria = q.id_categoria,
                                         Id_tipo = q.id_tipo,
                                         Id_producto = q.id_producto,
                                   Categoria = q.TIPOS_DE_PRODUCTOS.CATEGORIAS.categoria,
                                         Tipo = q.TIPOS_DE_PRODUCTOS.tipo,
                                         Nombre = q.nombre,
                                         Descripcion = q.descripcion,
                                         Tamanio = q.tamanio,
                                         Disponible = q.disponible,
                                         Stock_min = q.stock_min,
                                         Stock = q.stock,
                                         Precio_lista = q.precio_lista,
                                         Precio_venta = q.precio_venta,
                                         Descuento = q.descuento,
                                         Veces_vendido = q.veces_vendido,
                                         Eliminado = q.eliminado
).ToList
                grid.DataSource = objetoMostrar
                grid.Columns("Id_categoria").Visible = False
                grid.Columns("Id_tipo").Visible = False
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function DModificarProducto(ByVal objProducto As PRODUCTOS)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetomodif = (From u In ctx.PRODUCTOS
                                   Where u.id_producto = objProducto.id_producto
                                   Select u).First

                ' Objeto Producto a       Objeto Producto obtenido
                '    Modificar              del form Modificar

                objetomodif.nombre = objProducto.nombre
                objetomodif.stock = objProducto.stock
                objetomodif.id_categoria = objProducto.id_categoria
                objetomodif.id_tipo = objProducto.id_tipo
                objetomodif.stock_min = objProducto.stock_min
                objetomodif.stock = objProducto.stock
                objetomodif.descripcion = objProducto.descripcion
                objetomodif.precio_lista = objProducto.precio_lista
                objetomodif.precio_venta = objProducto.precio_venta
                objetomodif.tamanio = objProducto.tamanio
                objetomodif.descuento = objProducto.descuento
                objetomodif.disponible = objProducto.disponible

                ctx.SaveChanges()
            End Using
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function D_Buscar_Codigo(ByVal aux_cod As Integer, grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities

                Dim listaProducto = (From q In ctx.PRODUCTOS
                                     Where (aux_cod = q.id_producto) And q.eliminado = "NO" And q.TIPOS_DE_PRODUCTOS.eliminado = "NO" And q.TIPOS_DE_PRODUCTOS.CATEGORIAS.eliminado = "NO"
                                     Select Id_categoria = q.id_categoria,
                                         Id_tipo = q.id_tipo,
                                         Id_producto = q.id_producto,
                                   Categoria = q.TIPOS_DE_PRODUCTOS.CATEGORIAS.categoria,
                                         Tipo = q.TIPOS_DE_PRODUCTOS.tipo,
                                         Nombre = q.nombre,
                                         Descripcion = q.descripcion,
                                         Tamanio = q.tamanio,
                                         Disponible = q.disponible,
                                         Stock_min = q.stock_min,
                                         Stock = q.stock,
                                         Precio_lista = q.precio_lista,
                                         Precio_venta = q.precio_venta,
                                         Descuento = q.descuento,
                                         Veces_vendido = q.veces_vendido,
                                         Eliminado = q.eliminado
).ToList
                grid.DataSource = listaProducto
                If listaProducto.Count <> 0 Then
                    grid.DataSource = listaProducto
                    grid.Columns("Id_categoria").Visible = False
                    grid.Columns("Id_tipo").Visible = False
                Else
                    D_getProductosAll(grid)
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function D_Buscar_Codigo_inactivos(ByVal aux_cod As Integer, grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities

                Dim listaProducto = (From q In ctx.PRODUCTOS
                                     Where (aux_cod = q.id_producto) And q.eliminado = "SI" And q.TIPOS_DE_PRODUCTOS.eliminado = "NO" And q.TIPOS_DE_PRODUCTOS.CATEGORIAS.eliminado = "NO"
                                     Select Id_categoria = q.id_categoria,
                                         Id_tipo = q.id_tipo,
                                         Id_producto = q.id_producto,
                                   Categoria = q.TIPOS_DE_PRODUCTOS.CATEGORIAS.categoria,
                                         Tipo = q.TIPOS_DE_PRODUCTOS.tipo,
                                         Nombre = q.nombre,
                                         Descripcion = q.descripcion,
                                         Tamanio = q.tamanio,
                                         Disponible = q.disponible,
                                         Stock_min = q.stock_min,
                                         Stock = q.stock,
                                         Precio_lista = q.precio_lista,
                                         Precio_venta = q.precio_venta,
                                         Descuento = q.descuento,
                                         Veces_vendido = q.veces_vendido,
                                         Eliminado = q.eliminado
).ToList
                grid.DataSource = listaProducto
                If listaProducto.Count <> 0 Then
                    grid.DataSource = listaProducto
                    grid.Columns("Id_categoria").Visible = False
                    grid.Columns("Id_tipo").Visible = False
                Else
                    D_getProductosAll_inactivos(grid)
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function D_Buscar_Categoria(ByVal aux_id_categoria As Byte, ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities

                Dim listaProducto = (From q In ctx.PRODUCTOS
                                     Where (aux_id_categoria = q.id_categoria) And q.eliminado = "NO" And q.TIPOS_DE_PRODUCTOS.eliminado = "NO" And q.TIPOS_DE_PRODUCTOS.CATEGORIAS.eliminado = "NO"
                                     Select Id_categoria = q.id_categoria,
                                         Id_tipo = q.id_tipo,
                                         Id_producto = q.id_producto,
                                   Categoria = q.TIPOS_DE_PRODUCTOS.CATEGORIAS.categoria,
                                         Tipo = q.TIPOS_DE_PRODUCTOS.tipo,
                                         Nombre = q.nombre,
                                         Descripcion = q.descripcion,
                                         Tamanio = q.tamanio,
                                         Disponible = q.disponible,
                                         Stock_min = q.stock_min,
                                         Stock = q.stock,
                                         Precio_lista = q.precio_lista,
                                         Precio_venta = q.precio_venta,
                                         Descuento = q.descuento,
                                         Veces_vendido = q.veces_vendido,
                                         Eliminado = q.eliminado
).ToList
                grid.DataSource = listaProducto
                If listaProducto.Count <> 0 Then
                    grid.DataSource = listaProducto
                    grid.Columns("Id_categoria").Visible = False
                    grid.Columns("Id_tipo").Visible = False
                Else
                    Me.D_getProductosAll(grid)
                End If

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function D_Buscar_Categoria_inactivos(ByVal aux_id_categoria As Byte, ByVal grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities

                Dim listaProducto = (From q In ctx.PRODUCTOS
                                     Where (aux_id_categoria = q.id_categoria) And q.eliminado = "SI" And q.TIPOS_DE_PRODUCTOS.eliminado = "NO" And q.TIPOS_DE_PRODUCTOS.CATEGORIAS.eliminado = "NO"
                                     Select Id_categoria = q.id_categoria,
                                         Id_tipo = q.id_tipo,
                                         Id_producto = q.id_producto,
                                   Categoria = q.TIPOS_DE_PRODUCTOS.CATEGORIAS.categoria,
                                         Tipo = q.TIPOS_DE_PRODUCTOS.tipo,
                                         Nombre = q.nombre,
                                         Descripcion = q.descripcion,
                                         Tamanio = q.tamanio,
                                         Disponible = q.disponible,
                                         Stock_min = q.stock_min,
                                         Stock = q.stock,
                                         Precio_lista = q.precio_lista,
                                         Precio_venta = q.precio_venta,
                                         Descuento = q.descuento,
                                         Veces_vendido = q.veces_vendido,
                                         Eliminado = q.eliminado
).ToList
                grid.DataSource = listaProducto
                If listaProducto.Count <> 0 Then
                    grid.DataSource = listaProducto
                    grid.Columns("Id_categoria").Visible = False
                    grid.Columns("Id_tipo").Visible = False
                Else
                    MsgBox("No hay productos inactivos de esa categoria", MsgBoxStyle.Information)
                End If

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function Buscar_Descripcion(ByVal aux_nombre As String, grid As DataGridView)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim listaProductos = (From q In ctx.PRODUCTOS
                                      Where (q.nombre.StartsWith(aux_nombre) = True) And q.eliminado = "NO" And q.TIPOS_DE_PRODUCTOS.eliminado = "NO" And q.TIPOS_DE_PRODUCTOS.CATEGORIAS.eliminado = "NO"
                                      Select Id_categoria = q.id_categoria,
                                         Id_tipo = q.id_tipo,
                                         Id_producto = q.id_producto,
                                   Categoria = q.TIPOS_DE_PRODUCTOS.CATEGORIAS.categoria,
                                         Tipo = q.TIPOS_DE_PRODUCTOS.tipo,
                                         Nombre = q.nombre,
                                         Descripcion = q.descripcion,
                                         Tamanio = q.tamanio,
                                         Disponible = q.disponible,
                                         Stock_min = q.stock_min,
                                         Stock = q.stock,
                                         Precio_lista = q.precio_lista,
                                         Precio_venta = q.precio_venta,
                                         Descuento = q.descuento,
                                         Veces_vendido = q.veces_vendido,
                                         Eliminado = q.eliminado
                                         ).ToList

                If listaProductos.Count <> 0 Then
                    grid.DataSource = listaProductos
                    grid.Columns("Id_categoria").Visible = False
                    grid.Columns("Id_tipo").Visible = False
                Else
                    D_getProductosAll(grid)
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


    Public Function D_borrar_producto(ByVal aux_id As Integer)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoBorrar = (From q In ctx.PRODUCTOS
                                    Where q.id_producto = aux_id
                                    Select q).First()

                If objetoBorrar.eliminado = "NO" Then
                    objetoBorrar.eliminado = "SI"
                    ctx.SaveChanges()
                Else
                    Return False
                End If

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_activar_producto(ByVal aux_id As Integer)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim objetoBorrar = (From q In ctx.PRODUCTOS
                                    Where q.id_producto = aux_id
                                    Select q).First()

                If objetoBorrar.eliminado = "SI" Then
                    objetoBorrar.eliminado = "NO"
                    ctx.SaveChanges()
                Else
                    Return False
                End If

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_Actualizar_Stock(ByVal aux_id_producto As Integer, ByVal aux_cantidad As Short)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim un_producto = (From q In ctx.PRODUCTOS
                                   Where q.id_producto = aux_id_producto
                                   Select q).First()

                If un_producto.stock >= 0 Then
                    un_producto.stock = (un_producto.stock - aux_cantidad)
                    If un_producto.stock <= 0 Then
                        MsgBox("El producto: " + un_producto.nombre + " - Codigo: " + CStr(un_producto.id_producto) + " - tiene un stock menor o igual a 0, comuniqueselo al supervisor")
                    End If
                    ctx.SaveChanges()
                    Else
                        Return False
                End If

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function D_SetVecesVendido(ByVal aux_id_producto As Integer, ByVal aux_cantidad As Short)
        Try
            Using ctx As New DB_VIVEROEntities
                Dim un_producto = (From q In ctx.PRODUCTOS
                                   Where q.id_producto = aux_id_producto
                                   Select q).First()

                un_producto.veces_vendido = (un_producto.veces_vendido + aux_cantidad)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            MsgBox("ERROR FATAL: anote el detalle del producto y comuniqueselo al supervisor")
            Return False
        End Try
    End Function

End Class
