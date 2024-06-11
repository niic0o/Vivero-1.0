Imports System.ComponentModel
Public Class VerProductos

    Dim objNcategoria As N_CATEGORIAS = New N_CATEGORIAS
    Dim objNproducto As N_PRODUCTOS = New N_PRODUCTOS
    Dim condicion_cbo As Boolean = False
    Dim condicion_txt As Boolean = False

    Private Sub MostrarProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboFiltro.DropDownStyle = ComboBoxStyle.DropDownList
        objNcategoria.cargarCBO_solo_activos(cboFiltro)
        objNproducto.cargarGrid(DataGridView_Productos)
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

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        txtNombre.Clear()
        cboFiltro.SelectedItem = Nothing
        objNproducto.cargarGrid(DataGridView_Productos)
        objNcategoria.cargarCBO_solo_activos(cboFiltro)
        'mostrar todos los elementos de la tabla producto
        MsgBox("Listado actualizado", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)

    End Sub


    Private Sub txtNombre_GotFocus(sender As Object, e As EventArgs) Handles txtNombre.GotFocus
        condicion_cbo = False
        condicion_txt = True
    End Sub

    Private Sub cboFiltro_Click(sender As Object, e As EventArgs) Handles cboFiltro.Click
        condicion_cbo = True
        condicion_txt = False
    End Sub
End Class
