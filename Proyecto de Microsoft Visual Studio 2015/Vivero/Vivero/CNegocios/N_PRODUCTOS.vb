Public Class N_PRODUCTOS

    Dim D_producto As D_PRODUCTOS = New D_PRODUCTOS

    Function agregar_producto(ByVal aux_id_categoria As Byte, ByVal aux_id_tipo As Short, ByVal aux_nombre As String, ByVal aux_desc As String, ByVal aux_tamanio As String, ByVal aux_disponible As String, ByVal aux_stock As Byte, ByVal aux_stock_min As Short, ByVal aux_precio As Double, ByVal aux_precioventa As Double, ByVal aux_descuento As Byte) As Boolean

        Dim E_un_producto = New PRODUCTOS()
        Dim no As String = "NO"
        With E_un_producto
            .id_categoria = aux_id_categoria
            .id_tipo = aux_id_tipo
            '.Id_Producto() = aux_id_producto
            .nombre() = aux_nombre
            .descripcion() = aux_desc
            .tamanio() = aux_tamanio
            .disponible() = aux_disponible
            .stock_min() = aux_stock_min
            .stock() = aux_stock
            .precio_lista() = aux_precio
            .precio_venta() = aux_precioventa
            .descuento() = aux_descuento
            .veces_vendido() = 0
            .eliminado() = no
        End With

        Dim D_un_producto = New D_PRODUCTOS
        Dim agregar As Boolean = D_un_producto.Dguardar_producto(E_un_producto)
        If agregar Then
            Return True
        Else
            Return False
        End If

    End Function

    Function Modificar_Producto(ByVal aux_id_producto As Integer, ByVal aux_id_categoria As Byte, ByVal aux_id_tipo As Short, ByVal aux_nombre As String, ByVal aux_desc As String, ByVal aux_tamanio As String, ByVal aux_disponible As String, ByVal aux_stock_min As Byte, ByVal aux_stock As Short, ByVal aux_precio As Double, ByVal aux_precioventa As Double, ByVal aux_descuento As Byte)
        Dim oproducto = New PRODUCTOS
        With oproducto
            .id_producto = aux_id_producto
            .id_categoria = aux_id_categoria
            .id_tipo = aux_id_tipo
            .nombre = aux_nombre
            .descripcion = aux_desc
            .tamanio = aux_tamanio
            .disponible = aux_disponible
            .stock = aux_stock
            .stock_min = aux_stock_min
            .precio_lista = aux_precio
            .precio_venta = aux_precioventa
            .descuento = aux_descuento
            '.eliminado = eliminado
            '.veces_vendido = vendido

        End With


        Dim agregar = D_producto.DModificarProducto(oproducto)
        If agregar Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub cargarGrid(ByVal grid As DataGridView)

        Dim productos As D_PRODUCTOS = New D_PRODUCTOS
        productos.D_getProductosAll(grid)
        grid.ClearSelection()
    End Sub

    Public Sub cargarGrid_inactivos(ByVal grid As DataGridView)

        Dim productos As D_PRODUCTOS = New D_PRODUCTOS
        productos.D_getProductosAll_inactivos(grid)
        grid.ClearSelection()
    End Sub

    Public Sub cargarGrid_activo_inactivo(ByVal grid As DataGridView)

        Dim productos As D_PRODUCTOS = New D_PRODUCTOS
        productos.D_getProductosAll_activo_inactivo(grid)
        grid.ClearSelection()
    End Sub

    Public Sub BuscarCodigo(ByVal cod As Integer, ByVal grid As DataGridView)
        Dim objproducto = New D_PRODUCTOS
        objproducto.D_Buscar_Codigo(cod, grid)
        grid.ClearSelection()
    End Sub

    Public Sub BuscarCodigo_inactivos(ByVal cod As Integer, ByVal grid As DataGridView)
        Dim objproducto = New D_PRODUCTOS
        objproducto.D_Buscar_Codigo_inactivos(cod, grid)
        grid.ClearSelection()
    End Sub

    Public Sub BuscarCategoria(ByVal aux_id_categoria As Byte, ByVal grid As DataGridView)
        Dim objproducto = New D_PRODUCTOS
        objproducto.D_Buscar_Categoria(aux_id_categoria, grid)
        grid.ClearSelection()
    End Sub

    Public Sub BuscarCategoria_inactivos(ByVal aux_id_categoria As Byte, ByVal grid As DataGridView)
        Dim objproducto = New D_PRODUCTOS
        objproducto.D_Buscar_Categoria_inactivos(aux_id_categoria, grid)
        grid.ClearSelection()
    End Sub

    Public Sub Buscar_Descripcion(ByVal aux_nombre As String, grid As DataGridView)
        Dim objproducto = New D_PRODUCTOS
        objproducto.Buscar_Descripcion(aux_nombre, grid)
        grid.ClearSelection()
    End Sub

    Public Function borrar_producto(ByVal aux_id As Integer) As Boolean
        Dim agregar As Boolean = D_producto.D_borrar_producto(aux_id)
        If agregar Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function activar_producto(ByVal aux_id As Integer) As Boolean
        Dim agregar As Boolean = D_producto.D_activar_producto(aux_id)
        If agregar Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function actualizar_stock(ByVal aux_id As Integer, ByVal aux_cantidad As Short) As Boolean
        Dim update As Boolean = D_producto.D_Actualizar_Stock(aux_id, aux_cantidad)
        If update Then
            Return True
        Else
            MsgBox("Pida al supervisor que actualice el Stock en el sistema", MsgBoxStyle.Information)
            Return False
        End If
    End Function

    Public Function set_veces_vendido(ByVal aux_id As Integer, ByVal aux_cantidad As Short)
        Dim update As Boolean = D_producto.D_SetVecesVendido(aux_id, aux_cantidad)
        If update Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
