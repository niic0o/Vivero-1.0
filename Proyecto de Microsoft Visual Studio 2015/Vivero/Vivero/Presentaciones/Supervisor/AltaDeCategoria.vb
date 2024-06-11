Public Class AltaDeCategoria
    Dim objNcategoria As N_CATEGORIAS = New N_CATEGORIAS
    Dim objNTipo As N_TIPOS_DE_PRODUCTOS = New N_TIPOS_DE_PRODUCTOS

    Dim txt_mensaje As String = "Datos incorrectos o espacios en blanco"
    Dim txt_error As String = "Error!"
    Dim txt_ok As String = "Operación realizada con éxito"
    Dim txt_info As String = "Información"
    Dim ask As MsgBoxResult


    Private Sub frmAltaCategoria_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        objNcategoria.cargarCBO_solo_activos(cboCategoria)
        objNcategoria.cargarGrid(DataGridView_Categoria)
        objNTipo.cargarDataGrid_activo_inactivo(DataGridView_Tipo)

    End Sub

    'CATEGORIA'
    Private Sub txtCategoria_LostFocus(sender As Object, e As EventArgs) Handles txtCategoria.LostFocus
        Dim cadena As String = txtCategoria.Text()
        Dim nueva_cadena As String = StrConv(cadena, VbStrConv.ProperCase)
        txtCategoria.Text() = nueva_cadena
    End Sub

    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        If String.IsNullOrWhiteSpace(txtCategoria.Text()) Then
            MsgBox(txt_mensaje, MsgBoxStyle.Critical, txt_error)
        Else
            ask = MsgBox("¿Está seguro de añadir esta Categoría?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then
                'agregar al combobox de tipo'
                'cboCategoria.Items.Add(txtCategoria.Text)
                'count_categoria += 1
                'DataGridView_Categoria.Rows.Add(count_categoria, txtCategoria.Text)
                If objNcategoria.agregar_categoria(txtCategoria.Text) Then
                    MsgBox(txt_ok, MsgBoxStyle.Information, txt_info)
                Else
                    MsgBox("Error de carga", MsgBoxStyle.Critical, "Error fatal")
                End If
                txtCategoria.Clear()
                objNcategoria.cargarGrid(DataGridView_Categoria)
                objNcategoria.cargarCBO_solo_activos(cboCategoria)
                objNTipo.cargarDataGrid_activo_inactivo(DataGridView_Tipo)
                'agregar al datagridview_clasificacion'
            Else
                    Exit Sub
            End If
        End If
    End Sub

    'TIPO'
    Private Sub btnAgregarTipo_Click(sender As Object, e As EventArgs) Handles btnAgregarTipo.Click
        If String.IsNullOrWhiteSpace(txtTipo.Text()) Or
           String.IsNullOrWhiteSpace(cboCategoria.Text()) Or
           IsNothing(cboCategoria) Then
            MsgBox(txt_mensaje, MsgBoxStyle.Critical, txt_error)
        Else
            ask = MsgBox("¿Está seguro de añadir este Tipo de Producto?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then
                If objNTipo.agregar_tipo(CByte(cboCategoria.SelectedValue()), txtTipo.Text()) Then
                    MsgBox(txt_ok, MsgBoxStyle.Information, txt_info)
                Else
                    MsgBox("Error de carga", MsgBoxStyle.Critical, "Error fatal")
                End If
                txtTipo.Clear()
                cboCategoria.SelectedItem = Nothing
                objNcategoria.cargarGrid(DataGridView_Categoria)
                objNcategoria.cargarCBO_solo_activos(cboCategoria)
                objNTipo.cargarDataGrid_activo_inactivo(DataGridView_Tipo)

            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtTipo_LostFocus(sender As Object, e As EventArgs) Handles txtTipo.LostFocus
        Dim cadena As String = txtTipo.Text()
        Dim nueva_cadena As String = StrConv(cadena, VbStrConv.ProperCase)
        txtTipo.Text() = nueva_cadena
    End Sub

    Private Sub btnCancelarCategoria_Click(sender As Object, e As EventArgs) Handles btnCancelarCategoria.Click
        txtCategoria.Clear()
    End Sub

    Private Sub btnCancelarTipo_Click(sender As Object, e As EventArgs) Handles btnCancelarTipo.Click
        txtTipo.Clear()
        cboCategoria.SelectedItem = Nothing
    End Sub

    Private Sub txtCategoria_GotFocus(sender As Object, e As EventArgs) Handles txtCategoria.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub txtTipo_GotFocus(sender As Object, e As EventArgs) Handles txtTipo.GotFocus
        Clipboard.Clear()
    End Sub
End Class