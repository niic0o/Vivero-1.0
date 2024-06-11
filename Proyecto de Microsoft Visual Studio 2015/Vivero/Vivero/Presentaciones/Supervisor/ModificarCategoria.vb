Public Class ModificarCategoria
    Dim txt_mensaje As String = "Datos incorrectos o espacios en blanco"
    Dim txt_error As String = "Error!"
    Dim txt_ok As String = "Operación realizada con éxito"
    Dim txt_info As String = "Información"
    Dim ask As MsgBoxResult
    Dim count_categoria As Integer = 0
    Dim count_tipo As Integer = 0

    Dim objNcategoria As N_CATEGORIAS = New N_CATEGORIAS
    Dim objNTipo As N_TIPOS_DE_PRODUCTOS = New N_TIPOS_DE_PRODUCTOS
    Dim aux_id_categoria As Integer = 0
    Dim aux_id_tipo As Integer = 0
    'el boton modificar en un registro del datagrid (sube el registro a los controles)
    'el boton Guardar confirma los cambios realizados si no existe repetido y edita el registro
    'El boton Eliminar en un registro del datagrid (borrado logico)

    Private Sub frmAltaCategoria_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        objNcategoria.cargarCBO_solo_activos(cboCategoria)
        objNcategoria.cargarGrid_solo_activos(DataGridView_Categoria)
        objNTipo.cargarDataGrid(DataGridView_Tipo)
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
            Dim n As Integer
            n = DataGridView_Tipo.Columns.Count() - 1

            Try
                Dim modif As N_CATEGORIAS = New N_CATEGORIAS

                modif.Modificar_Categoria(aux_id_categoria,
                                     txtCategoria.Text)

                ask = MsgBox("¿Está seguro de modificar esta Categoría?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
                If MsgBoxResult.Yes = ask Then

                    objNcategoria.cargarGrid_solo_activos(DataGridView_Categoria)
                    objNTipo.cargarDataGrid(DataGridView_Tipo)
                    txtTipo.Clear()
                    cboCategoria.SelectedItem = Nothing
                    objNcategoria.cargarCBO_solo_activos(cboCategoria)


                    txtCategoria.Clear()
                    'cboCategoria.ResetText()


                Else
                    MessageBox.Show("No se pudo modificar", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                objNcategoria.cargarGrid(DataGridView_Categoria)
                objNTipo.cargarDataGrid(DataGridView_Tipo)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'agregar al combobox de tipo'
            'cboCategoria.Items.Add(txtCategoria.Text)
            'count_categoria += 1
            'DataGridView_Categoria.Rows.Add(count_categoria, txtCategoria.Text)
            'MsgBox(txt_ok, MsgBoxStyle.Information, txt_info)
            'txtCategoria.Clear()
            'agregar al datagridview_clasificacion'
            'agregar a la tabla clasificacion'

        End If

    End Sub

    'TIPO'
    Private Sub btnAgregarTipo_Click(sender As Object, e As EventArgs) Handles btnAgregarTipo.Click
        If String.IsNullOrWhiteSpace(txtTipo.Text()) Or
           String.IsNullOrWhiteSpace(cboCategoria.Text()) Then
            MsgBox(txt_mensaje, MsgBoxStyle.Critical, txt_error)
        Else

            Dim n As Integer
            n = DataGridView_Tipo.Columns.Count() - 1

            Try
                Dim modif As N_TIPOS_DE_PRODUCTOS = New N_TIPOS_DE_PRODUCTOS

                modif.Modificar_Tipo(aux_id_categoria,
                                     aux_id_tipo,
                                        cboCategoria.SelectedValue,
                                        txtTipo.Text)

                ask = MsgBox("¿Está seguro de modificar este Tipo de Producto?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
                If MsgBoxResult.Yes = ask Then

                    objNcategoria.cargarGrid_solo_activos(DataGridView_Categoria)
                    objNTipo.cargarDataGrid(DataGridView_Tipo)

                    txtTipo.Clear()
                    cboCategoria.SelectedItem = Nothing

                    MsgBox("La modificacion se guardo correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)



                Else
                    MessageBox.Show("No se pudo modificar", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                objNcategoria.cargarGrid_solo_activos(DataGridView_Categoria)
                objNTipo.cargarDataGrid(DataGridView_Tipo)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            'agregar al combobox de producto'
            'MsgBox(txt_ok, MsgBoxStyle.Information, txt_info)
            'count_tipo += 1
            'DataGridView_Tipo.Rows.Add(0, cboCategoria.Text, count_tipo, txtTipo.Text)
            'txtTipo.Clear()
            'agregar al datagridview_tipo'
            'agregar a la tabla tipo'


            Exit Sub
        End If

    End Sub

    Private Sub DataGridView_Tipo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Tipo.Click
        Dim FilaActual As Integer
        If DataGridView_Tipo.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        FilaActual = DataGridView_Tipo.CurrentRow.Index
        aux_id_categoria = DataGridView_Tipo.Rows(FilaActual).Cells("id_categoria").Value
        cboCategoria.Text = DataGridView_Tipo.Rows(FilaActual).Cells("Categoria").Value
        aux_id_tipo = DataGridView_Tipo.Rows(FilaActual).Cells("id_tipo").Value
        txtTipo.Text = DataGridView_Tipo.Rows(FilaActual).Cells("tipo").Value

    End Sub

    Private Sub DataGridView_Categoria_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Categoria.Click
        Dim FilaActual As Integer
        If DataGridView_Categoria.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        FilaActual = DataGridView_Categoria.CurrentRow.Index
        aux_id_categoria = DataGridView_Categoria.Rows(FilaActual).Cells("id_categoria").Value
        txtCategoria.Text = DataGridView_Categoria.Rows(FilaActual).Cells("Categoria").Value

    End Sub

    Private Sub txtTipo_LostFocus(sender As Object, e As EventArgs) Handles txtTipo.LostFocus
        Dim cadena As String = txtTipo.Text()
        Dim nueva_cadena As String = StrConv(cadena, VbStrConv.ProperCase)
        txtTipo.Text() = nueva_cadena
    End Sub

    Private Sub btnCancelarCategorian_Click(sender As Object, e As EventArgs) Handles btnCancelarCategoria.Click
        txtCategoria.Clear()
    End Sub

    Private Sub btnCancelarTipo_Click(sender As Object, e As EventArgs) Handles btnCancelarTipo.Click
        txtTipo.Clear()
        cboCategoria = Nothing
    End Sub

    Private Sub txtCategoria_GotFocus(sender As Object, e As EventArgs) Handles txtCategoria.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub txtTipo_GotFocus(sender As Object, e As EventArgs) Handles txtTipo.GotFocus
        Clipboard.Clear()
    End Sub
End Class