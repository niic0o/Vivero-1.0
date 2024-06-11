Public Class BajaDeCategoria
    Dim txt_mensaje As String = "Datos incorrectos o espacios en blanco"
    Dim txt_error As String = "Error!"
    Dim txt_ok As String = "Operación realizada con éxito"
    Dim txt_info As String = "Información"

    Dim categoria_id_c As Integer = 0
    Dim tipo_id_t As Integer = 0
    Dim tipo_id_c As Integer = 0
    Dim objNtipo As N_TIPOS_DE_PRODUCTOS = New N_TIPOS_DE_PRODUCTOS
    Dim objNcategoria As N_CATEGORIAS = New N_CATEGORIAS

    'Convierto en mayusculas'

    Private Sub txtCategoria_LostFocus(sender As Object, e As EventArgs) Handles txtCategoria.LostFocus
        Dim cadena As String = txtCategoria.Text()
        Dim nueva_cadena As String = StrConv(cadena, VbStrConv.ProperCase)
        txtCategoria.Text() = nueva_cadena
    End Sub

    Private Sub txtTipo_LostFocus(sender As Object, e As EventArgs) Handles txtTipo.LostFocus
        Dim cadena As String = txtTipo.Text()
        Dim nueva_cadena As String = StrConv(cadena, VbStrConv.ProperCase)
        txtTipo.Text() = nueva_cadena
    End Sub

    Private Sub btnEliminarCategoria_Click(sender As Object, e As EventArgs) Handles btnEliminarCategoria.Click
        If String.IsNullOrWhiteSpace(txtCategoria.Text()) Then
            MsgBox(txt_mensaje, MsgBoxStyle.Critical, txt_error)
        Else

            Dim ask As MsgBoxResult

            ask = MsgBox("¿Dar de baja la categoria?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then
                If objNcategoria.borrar_categoria(categoria_id_c) = True Then
                    MsgBox("La categoria se dio de baja correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
                Else
                    MsgBox("Ya está eliminado!", MsgBoxStyle.Exclamation, "Error")
                End If
            End If
        End If
        txtCategoria.Clear()
        objNcategoria.cargarGrid(DataGridView_Categoria)
        objNtipo.cargarDataGrid_activo_inactivo(DataGridView_Tipo)
    End Sub


    Private Sub btnEliminarTipo_Click(sender As Object, e As EventArgs) Handles btnEliminarTipo.Click
        If String.IsNullOrWhiteSpace(txtTipo.Text()) Then
            MsgBox(txt_mensaje, MsgBoxStyle.Critical, txt_error)
        Else

            Dim ask As MsgBoxResult

            ask = MsgBox("¿Dar de baja el tipo de producto?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then
                If objNtipo.borrar_tipos(tipo_id_c, tipo_id_t) = True Then
                    MsgBox("El tipo de producto se dio de baja correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
                Else
                    MsgBox("Ya está eliminado!", MsgBoxStyle.Exclamation, "Error")
                End If
            End If
        End If
        txtTipo.Clear()
        objNcategoria.cargarGrid(DataGridView_Categoria)
        objNtipo.cargarDataGrid_activo_inactivo(DataGridView_Tipo)
    End Sub

    Private Sub btnActivarCategoria_Click(sender As Object, e As EventArgs) Handles btnActivarCategoria.Click
        If String.IsNullOrWhiteSpace(txtCategoria.Text()) Then
            MsgBox(txt_mensaje, MsgBoxStyle.Critical, txt_error)
        Else

            Dim ask As MsgBoxResult

            ask = MsgBox("¿Dar de alta la categoria?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then
                If objNcategoria.activar_categoria(categoria_id_c) = True Then
                    MsgBox("La categoria se dio de alta correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
                Else
                    MsgBox("Ya está activado!", MsgBoxStyle.Exclamation, "Error")
                End If
            End If
        End If
        txtCategoria.Clear()
        objNcategoria.cargarGrid(DataGridView_Categoria)
        objNtipo.cargarDataGrid_activo_inactivo(DataGridView_Tipo)
    End Sub


    Private Sub btnActivarTipo_Click(sender As Object, e As EventArgs) Handles btnActivarTipo.Click
        If String.IsNullOrWhiteSpace(txtTipo.Text()) Then
            MsgBox(txt_mensaje, MsgBoxStyle.Critical, txt_error)
        Else

            Dim ask As MsgBoxResult

            ask = MsgBox("¿Dar de alta el tipo de producto?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then
                If objNtipo.activar_tipos(tipo_id_c, tipo_id_t) = True Then
                    MsgBox("El tipo de producto se dio de alta correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
                Else
                    MsgBox("Ya está activado!", MsgBoxStyle.Exclamation, "Error")
                End If
            End If
        End If
        txtTipo.Clear()
        objNcategoria.cargarGrid(DataGridView_Categoria)
        objNtipo.cargarDataGrid_activo_inactivo(DataGridView_Tipo)
    End Sub

    Private Sub BajaDeCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNtipo.cargarDataGrid_activo_inactivo(DataGridView_Tipo)
        objNcategoria.cargarGrid(DataGridView_Categoria)
    End Sub

    Private Sub DataGridView_Categoria_Click(sender As Object, e As EventArgs) Handles DataGridView_Categoria.Click
        Dim FilaActual As Integer
        If DataGridView_Categoria.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        FilaActual = DataGridView_Categoria.CurrentRow.Index
        categoria_id_c = DataGridView_Categoria.Rows(FilaActual).Cells("id_categoria").Value
        txtCategoria.Text = DataGridView_Categoria.Rows(FilaActual).Cells("categoria").Value

    End Sub

    Private Sub DataGridView_Tipo_Click(sender As Object, e As EventArgs) Handles DataGridView_Tipo.Click
        Dim FilaActual As Integer
        If DataGridView_Tipo.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        FilaActual = DataGridView_Tipo.CurrentRow.Index
        tipo_id_c = DataGridView_Tipo.Rows(FilaActual).Cells("id_categoria").Value
        tipo_id_t = DataGridView_Tipo.Rows(FilaActual).Cells("id_tipo").Value
        txtTipo.Text = DataGridView_Tipo.Rows(FilaActual).Cells("tipo").Value
    End Sub
End Class