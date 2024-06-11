Imports System.ComponentModel
Public Class SeleccionarProducto

    Dim objNcategoria As N_CATEGORIAS = New N_CATEGORIAS
    Dim objNproducto As N_PRODUCTOS = New N_PRODUCTOS
    Dim condicion_cbo As Boolean = False
    Dim condicion_txt As Boolean = False
    Public producto_selected As PRODUCTOS = New PRODUCTOS
    Private tipo_selected As TIPOS_DE_PRODUCTOS = New TIPOS_DE_PRODUCTOS
    Private categoria_selected As CATEGORIAS = New CATEGORIAS
    Dim p_id_cat As Byte
    Dim p_id_tipo As Short
    Dim p_id_prod As Integer
    Dim p_cat As String
    Dim p_tipo As String
    Dim p_nom As String
    Dim p_desc As String
    Dim p_tam As String
    Dim p_disp As String
    Dim p_min As Byte
    Dim p_stock As Short
    Dim p_lista As Double
    Dim p_precio As Double
    Dim p_dto As Double

    Public Sub New(ByVal aux_producto_selected As PRODUCTOS)
        InitializeComponent()
        producto_selected = aux_producto_selected
        producto_selected.TIPOS_DE_PRODUCTOS = tipo_selected
        producto_selected.TIPOS_DE_PRODUCTOS.CATEGORIAS = categoria_selected
    End Sub

    Private Sub MostrarProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboFiltro.DropDownStyle = ComboBoxStyle.DropDownList
        objNcategoria.cargarCBO_solo_activos(cboFiltro)
        objNproducto.cargarGrid(DataGridView_Productos)
        Label_select.Text = " "
        Dim condicion_cbo As Boolean = False
        Dim condicion_txt As Boolean = False
    End Sub
    'Private Sub 'evento disparado al elegir un item' Handles 'evento'
    'Capturo el valor del cboFiltro.Text y muestro en el DataGridView todos los registros
    'que tengan ese valor
    'End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If String.IsNullOrWhiteSpace(txtNombre.Text) And IsNothing(cboFiltro) Then
            MsgBox("Ingrese datos a buscar", MsgBoxStyle.Information, "Sugerencia")
        Else
            If condicion_txt = True And condicion_cbo = False Then

                objNproducto.Buscar_Descripcion(txtNombre.Text, DataGridView_Productos)
            Else
                objNproducto.BuscarCategoria(CByte(cboFiltro.SelectedValue()), DataGridView_Productos)
            End If
        End If
        condicion_cbo = False
        condicion_txt = False
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If DataGridView_Productos.SelectedRows.Count = 0 Then
            MsgBox("Haga click en un item", MsgBoxStyle.Information, "Seleccione un cliente de la tabla")
        Else
            txtNombre.Clear()
            cboFiltro.SelectedItem = Nothing
            objNproducto.cargarGrid(DataGridView_Productos)
            objNcategoria.cargarCBO_solo_activos(cboFiltro)

            MsgBox("Categoria: " + p_cat + " - Producto: " + p_nom, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
            With producto_selected
                .id_categoria() = p_id_cat
                .id_tipo() = p_id_tipo
                .id_producto() = p_id_prod
                .nombre() = p_nom
                .descripcion() = p_desc
                .tamanio() = p_tam
                .disponible() = p_disp
                .stock_min() = p_min
                .stock() = p_stock
                .precio_lista() = p_lista
                .precio_venta() = p_precio
                .descuento() = p_dto
                .TIPOS_DE_PRODUCTOS.CATEGORIAS.categoria() = p_cat
            End With
            Me.Close()
        End If
    End Sub


    Private Sub txtNombre_GotFocus(sender As Object, e As EventArgs) Handles txtNombre.GotFocus
        condicion_cbo = False
        condicion_txt = True
    End Sub

    Private Sub cboFiltro_Click(sender As Object, e As EventArgs) Handles cboFiltro.Click
        condicion_cbo = True
        condicion_txt = False
    End Sub

    Private Sub DataGridView_Productos_Click(sender As Object, e As EventArgs) Handles DataGridView_Productos.Click
        Dim FilaActual As Integer
        If DataGridView_Productos.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        FilaActual = DataGridView_Productos.CurrentRow.Index
        p_id_cat = DataGridView_Productos.Rows(FilaActual).Cells("id_categoria").Value
        p_id_tipo = DataGridView_Productos.Rows(FilaActual).Cells("id_tipo").Value
        p_id_prod = DataGridView_Productos.Rows(FilaActual).Cells("id_producto").Value
        p_cat = DataGridView_Productos.Rows(FilaActual).Cells("categoria").Value
        p_tipo = DataGridView_Productos.Rows(FilaActual).Cells("tipo").Value
        p_nom = DataGridView_Productos.Rows(FilaActual).Cells("nombre").Value
        p_desc = DataGridView_Productos.Rows(FilaActual).Cells("descripcion").Value
        p_tam = DataGridView_Productos.Rows(FilaActual).Cells("Tamanio").Value
        p_disp = DataGridView_Productos.Rows(FilaActual).Cells("disponible").Value
        p_min = DataGridView_Productos.Rows(FilaActual).Cells("stock_min").Value
        p_stock = DataGridView_Productos.Rows(FilaActual).Cells("stock").Value
        p_lista = DataGridView_Productos.Rows(FilaActual).Cells("precio_lista").Value
        p_precio = DataGridView_Productos.Rows(FilaActual).Cells("precio_venta").Value
        p_dto = DataGridView_Productos.Rows(FilaActual).Cells("descuento").Value
        Label_select.Text = p_nom
    End Sub


End Class
