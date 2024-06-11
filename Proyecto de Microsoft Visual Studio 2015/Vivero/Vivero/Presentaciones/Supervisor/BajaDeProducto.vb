
Public Class BajaDeProducto

    Dim objNproducto As N_PRODUCTOS = New N_PRODUCTOS
    Dim objNcategoria As N_CATEGORIAS = New N_CATEGORIAS
    Dim id_producto As Integer = 0

    Private Sub txtbcod_LostFocus(sender As Object, e As EventArgs) Handles txtbcod.LostFocus
        If Val(txtbcod.Text) = False Then
            ErrorSoloNumeros.SetError(txtbcod, "Solo numeros")
            txtbcod.Clear()
        Else
            Exit Sub
        End If
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

    Private Sub BajaDeProducto_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        objNcategoria.cargarCBO_solo_activos(cboCategoria)
        objNproducto.cargarGrid(DataGridView1)
        Label_select.Text = " "
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Haga click en un item", MsgBoxStyle.Information, "Seleccione un producto")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("¿Dar de baja al producto?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then
                If objNproducto.borrar_producto(id_producto) Then
                    MsgBox("El producto se dio de baja correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
                    objNproducto.cargarGrid(DataGridView1)
                Else
                    MsgBox("Ya está eliminado!", MsgBoxStyle.Exclamation, "Error")
                End If
            End If
            txtbcod.Clear()
            cboCategoria.SelectedItem = Nothing
            Label_select.Text = " "
        End If
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        id_producto = 0
        Dim FilaActual As Integer
        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        FilaActual = DataGridView1.CurrentRow.Index
        id_producto = DataGridView1.Rows(FilaActual).Cells("id_producto").Value
        Label_select.Text = DataGridView1.Rows(FilaActual).Cells("nombre").Value
    End Sub

    Private Sub cboCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCategoria.SelectionChangeCommitted
        objNproducto.BuscarCategoria(cboCategoria.SelectedValue(), DataGridView1)
    End Sub

    Private Sub txtbcod_TextChanged(sender As Object, e As EventArgs) Handles txtbcod.TextChanged
        Dim aux_cod As Integer = 0
        If txtbcod.Text = "" Or txtbcod.Text = " " Then
            Exit Sub
        Else
            aux_cod = CInt(txtbcod.Text)
        End If
        objNproducto.BuscarCodigo(aux_cod, DataGridView1)
    End Sub

End Class
