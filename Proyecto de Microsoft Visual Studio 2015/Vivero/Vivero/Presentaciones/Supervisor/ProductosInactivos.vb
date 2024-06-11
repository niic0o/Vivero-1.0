Public Class ProductosInactivos

    Dim id_producto As Integer = 0
    Dim aux_prod As String = " "
    Dim aux_cat As String = " "
    Dim objNproducto As N_PRODUCTOS = New N_PRODUCTOS
    Dim objNcategoria As N_CATEGORIAS = New N_CATEGORIAS

    Private Sub ProductosInactivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        objNcategoria.cargarCBO_solo_activos(CboCategoria)
        objNproducto.cargarGrid_inactivos(DataGridView1)
    End Sub

    Private Sub txtbcod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbcod.KeyPress
        txtbcod.MaxLength() = 20
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            ErrorSoloNumeros.Clear()
        Else
            e.Handled = True
            ErrorSoloNumeros.SetError(txtbcod, "Solo numeros")
        End If
    End Sub

    Private Sub txtbcod_LostFocus(sender As Object, e As EventArgs) Handles txtbcod.LostFocus
        If Val(txtbcod.Text) = False Then
            ErrorSoloNumeros.SetError(txtbcod, "Solo numeros")
            txtbcod.Clear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnactivar_Click(sender As Object, e As EventArgs) Handles btnactivar.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Haga click en un item", MsgBoxStyle.Information, "Seleccione un usuario eliminado")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("¿Desea activar el producto '" + aux_prod + "' De la categoria " + aux_cat + "?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then
                If objNproducto.activar_producto(id_producto) Then
                    MsgBox("El producto se activó correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
                Else
                    MsgBox("Ese producto ya esta activo", MsgBoxStyle.Critical,
                           "Error")
                End If
            End If
            objNproducto.cargarGrid_inactivos(DataGridView1)
            txtbcod.Clear()
            CboCategoria.SelectedItem() = Nothing
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        objNproducto.cargarGrid_inactivos(DataGridView1)
        MsgBox("Listado actualizado", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
    End Sub

    Private Sub txtbcod_TextChanged(sender As Object, e As EventArgs) Handles txtbcod.TextChanged
        Dim aux_cod As Integer = 0
        If txtbcod.Text = "" Or txtbcod.Text = " " Then
            Exit Sub
        Else
            aux_cod = CInt(txtbcod.Text)
        End If
        objNproducto.BuscarCodigo_inactivos(aux_cod, DataGridView1)
    End Sub

    Private Sub CboCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboCategoria.SelectionChangeCommitted
        objNproducto.BuscarCategoria_inactivos(CboCategoria.SelectedValue(), DataGridView1)
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        id_producto = 0
        Dim FilaActual As Integer
        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        FilaActual = DataGridView1.CurrentRow.Index
        id_producto = DataGridView1.Rows(FilaActual).Cells("id_producto").Value
        aux_prod = DataGridView1.Rows(FilaActual).Cells("nombre").Value
        aux_cat = DataGridView1.Rows(FilaActual).Cells("categoria").Value
    End Sub
End Class
