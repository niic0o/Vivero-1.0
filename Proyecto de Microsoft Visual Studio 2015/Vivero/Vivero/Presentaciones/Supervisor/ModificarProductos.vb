Imports System.Text.RegularExpressions

Public Class ModificarProductos
    Dim objNproducto As N_PRODUCTOS = New N_PRODUCTOS
    Dim objNTipo As N_TIPOS_DE_PRODUCTOS = New N_TIPOS_DE_PRODUCTOS
    Dim objNcategoria As N_CATEGORIAS = New N_CATEGORIAS
    Dim aux_decimal As Double = 0
    Dim aux_id_producto As Integer = 0
    Dim aux_id_tipo As Integer = 0
    Dim aux_id_categoria As Integer = 0

    'el boton modificar en un registro del datagrid (sube el registro a los controles)
    'el boton Guardar (confirma los cambios realizados) edita el registro
    'El boton Eliminar en un registro del datagrid (borrado logico)

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If String.IsNullOrWhiteSpace(cboCategoria.Text) Or
           String.IsNullOrWhiteSpace(cboTipo.Text) Or
           String.IsNullOrWhiteSpace(txtnombre.Text) Or
           String.IsNullOrWhiteSpace(txtdescr.Text) Or
           String.IsNullOrWhiteSpace(txtTamaño.Text) Or
           String.IsNullOrWhiteSpace(txtstock.Text) Or
           String.IsNullOrWhiteSpace(txtstockmin.Text) Or
           String.IsNullOrWhiteSpace(txtprecio.Text) Or
           String.IsNullOrWhiteSpace(txtpreciolista.Text) Or
           String.IsNullOrWhiteSpace(txtDescuento.Text) Or
           ((rdbSI.Checked = False) And (rdbNO.Checked = False)) Then
            ' String.IsNullOrWhiteSpace(txtloc.Text) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical)
        Else
            Dim disponible As String = " "
            If rdbSI.Checked = True Then
                disponible = "SI"
            Else
                disponible = "NO"
            End If
            If aux_id_categoria = 0 Or aux_id_producto = 0 Then
                MsgBox("Seleccione un item de la tabla")
                Exit Sub
            End If


            Dim n As Integer
            n = DataGridView1.Columns.Count() - 1

            Try
                Dim modif As N_PRODUCTOS = New N_PRODUCTOS

                modif.Modificar_Producto(aux_id_producto,
                                        cboCategoria.SelectedValue,
                                        cboTipo.SelectedValue,
                txtnombre.Text,
                txtdescr.Text,
                txtTamaño.Text,
                disponible,
                txtstockmin.Text,
                txtstock.Text,
                txtpreciolista.Text,
                txtprecio.Text,
                txtDescuento.Text)


                Dim ask As MsgBoxResult
                ask = MsgBox("¿Desea guardar modificacion del producto?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
                If MsgBoxResult.Yes = ask Then


                    objNproducto.cargarGrid(DataGridView1)

                    txtnombre.Clear()
                    txtdescr.Clear()
                    txtTamaño.Clear()
                    txtstock.Clear()
                    txtstockmin.Clear()
                    txtprecio.Clear()
                    txtpreciolista.Clear()
                    txtDescuento.Clear()
                    cboCategoria.SelectedItem = Nothing
                    cboTipo.SelectedItem = Nothing

                    MsgBox("La modificacion se guardo correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)

                Else
                    MessageBox.Show("No se pudo modificar", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                objNproducto.cargarGrid(DataGridView1)
            Catch ex As Exception
                MsgBox("Seleccione un item de la tabla")
            End Try
        End If
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim disponible As String = " "
        If rdbSI.Checked = True Then
            disponible = "SI"
        Else
            disponible = "NO"
        End If

        Dim FilaActual As Integer
        FilaActual = DataGridView1.CurrentRow.Index

        aux_id_categoria = DataGridView1.Rows(FilaActual).Cells("id_categoria").Value
        aux_id_tipo = DataGridView1.Rows(FilaActual).Cells("id_tipo").Value
        aux_id_producto = DataGridView1.Rows(FilaActual).Cells("id_producto").Value
        objNcategoria.cargarCBO(cboCategoria)
        objNTipo.cargarCBO(cboTipo, aux_id_categoria)
        cboCategoria.Text = DataGridView1.Rows(FilaActual).Cells("categoria").Value
        cboTipo.Text = DataGridView1.Rows(FilaActual).Cells("tipo").Value
        txtnombre.Text = DataGridView1.Rows(FilaActual).Cells("nombre").Value
        txtdescr.Text = DataGridView1.Rows(FilaActual).Cells("descripcion").Value
        txtTamaño.Text = DataGridView1.Rows(FilaActual).Cells("Tamanio").Value
        disponible = DataGridView1.Rows(FilaActual).Cells("disponible").Value
        txtstockmin.Text = DataGridView1.Rows(FilaActual).Cells("stock_min").Value
        txtstock.Text = DataGridView1.Rows(FilaActual).Cells("stock").Value
        txtpreciolista.Text = DataGridView1.Rows(FilaActual).Cells("precio_lista").Value
        txtprecio.Text = DataGridView1.Rows(FilaActual).Cells("precio_venta").Value
        txtDescuento.Text = DataGridView1.Rows(FilaActual).Cells("descuento").Value
        If disponible = "SI" Then
            rdbSI.PerformClick()
        Else
            rdbNO.PerformClick()
        End If

    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        txtnombre.Clear()
        txtdescr.Clear()
        txtTamaño.Clear()
        txtstock.Clear()
        txtstockmin.Clear()
        txtprecio.Clear()
        txtpreciolista.Clear()
        txtDescuento.Clear()
        cboCategoria.SelectedItem = Nothing
        cboTipo.SelectedItem = Nothing
        objNproducto.cargarGrid(DataGridView1)
    End Sub

    'VALIDACION ADICIONAL DE CONTROLES'
    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        txtprecio.MaxLength() = 9 'evita overflow'
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar) Or (e.KeyChar = ".") Then
            e.Handled = False
            ErrorSoloDecimales.Clear()
        Else
            e.Handled = True
            ErrorSoloDecimales.SetError(txtprecio, "Solo numeros enteros o decimales, usar punto '.'")
        End If
    End Sub

    Private Sub txtpreciolista_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpreciolista.KeyPress
        txtpreciolista.MaxLength() = 9 'evita overflow'
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar) Or (e.KeyChar = ".") Then
            e.Handled = False
            ErrorSoloDecimales.Clear()
        Else
            e.Handled = True
            ErrorSoloDecimales.SetError(txtpreciolista, "Solo numeros enteros o decimales, usar punto '.'")
        End If
    End Sub

    Private Sub txtdescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescuento.KeyPress
        txtDescuento.MaxLength() = 4
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar) Or (e.KeyChar = ".") Then
            e.Handled = False
            ErrorSoloDecimales.Clear()
        Else
            e.Handled = True
            ErrorSoloDecimales.SetError(txtpreciolista, "Solo numeros enteros o decimales, usar punto '.'")
        End If
    End Sub

    Private Sub txtstockmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstockmin.KeyPress
        txtstockmin.MaxLength() = 2
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            ErrorSoloNumeros.Clear()
        Else
            e.Handled = True
            ErrorSoloNumeros.SetError(txtstockmin, "Solo numeros")
        End If
    End Sub

    Private Sub txtstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstock.KeyPress
        txtstock.MaxLength() = 4
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            ErrorSoloNumeros.Clear()
        Else
            e.Handled = True
            ErrorSoloNumeros.SetError(txtstock, "Solo numeros")
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

    'EVITAR QUE SE PEGUE TEXTO DONDE VAN SOLO NUMEROS'
    'CONTROLA QUE SE INGRESE SOLO NUMEROS REALES'
    'VB opera con punto decimal '.' pero a los decimales como string los muestra con coma ','
    Private Sub txtprecio_LostFocus(sender As Object, e As EventArgs) Handles txtprecio.LostFocus
        'la funcion val no convierte el 0 en string a 0 en double'
        If txtprecio.Text = "0" Then
            Exit Sub
        End If
        If Val(txtprecio.Text) = False Then
            ErrorSoloDecimales.SetError(txtprecio, "Solo numeros enteros o decimales, usar punto '.'")
            txtprecio.Clear()
        Else
            aux_decimal = Val(txtprecio.Text)
            txtprecio.Text = aux_decimal
            Exit Sub
        End If
    End Sub

    Private Sub txtpreciolista_LostFocus(sender As Object, e As EventArgs) Handles txtpreciolista.LostFocus
        'la funcion val no convierte el 0 en string a 0 en double'
        If txtpreciolista.Text = "0" Then
            Exit Sub
        End If
        If Val(txtpreciolista.Text) = False Then
            ErrorSoloDecimales.SetError(txtpreciolista, "Solo numeros enteros o decimales, usar punto '.'")
            txtpreciolista.Clear()
        Else
            aux_decimal = Val(txtpreciolista.Text)
            txtpreciolista.Text = aux_decimal
            Exit Sub
        End If
    End Sub

    Private Sub txtDescuento_LostFocus(sender As Object, e As EventArgs) Handles txtDescuento.LostFocus
        'la funcion val no convierte el 0 en string a 0 en double'
        If txtDescuento.Text = "0" Then
            Exit Sub
        End If
        If Val(txtDescuento.Text) = False Then
            ErrorSoloDecimales.SetError(txtDescuento, "Solo numeros enteros o decimales, usar punto '.'")
            txtDescuento.Clear()
        Else
            aux_decimal = Val(txtDescuento.Text)
            txtDescuento.Text = aux_decimal
            Exit Sub
        End If
    End Sub

    Private Sub txtstock_LostFocus(sender As Object, e As EventArgs) Handles txtstock.LostFocus
        'la funcion val no convierte el 0 en string a 0 en double'
        If txtstock.Text = "0" Then
            Exit Sub
        End If
        If Val(txtstock.Text) = False Then
            ErrorSoloNumeros.SetError(txtstock, "Solo numeros")
            txtstock.Clear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtstockmin_LostFocus(sender As Object, e As EventArgs) Handles txtstockmin.LostFocus
        'la funcion val no convierte el 0 en string a 0 en double'
        If txtstockmin.Text = "0" Then
            Exit Sub
        End If
        If Val(txtstockmin.Text) = False Then
            ErrorSoloNumeros.SetError(txtstockmin, "Solo numeros")
            txtstockmin.Clear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtbcod_LostFocus(sender As Object, e As EventArgs)
        If Val(txtbcod.Text) = False Then
            ErrorSoloNumeros.SetError(txtbcod, "Solo numeros")
            txtbcod.Clear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ModificarProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboTipo.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        cboBuscarC.DropDownStyle = ComboBoxStyle.DropDownList
        objNTipo.cargarCBO(cboTipo, cboCategoria.SelectedValue)
        objNproducto.cargarGrid(DataGridView1)
        objNcategoria.cargarCBO_solo_activos(cboCategoria)
    End Sub

    Private Sub txtnombre_GotFocus(sender As Object, e As EventArgs) Handles txtnombre.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        'Solo Letras'
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            ErrorSoloLetras.Clear()
        Else
            e.Handled = True
            ErrorSoloLetras.SetError(txtnombre, "Solo letras")
        End If
    End Sub

    Private Sub txtnombre_LostFocus(sender As Object, e As EventArgs) Handles txtnombre.LostFocus
        Dim cadena As String = txtnombre.Text()
        Dim nueva_cadena As String = StrConv(cadena, VbStrConv.ProperCase)
        txtnombre.Text() = nueva_cadena
    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategoria.SelectedIndexChanged
        objNcategoria.cargarCBO_solo_activos(cboBuscarC)
    End Sub

    Private Sub cboCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCategoria.SelectionChangeCommitted
        Dim aux_id_categoria As Byte = cboCategoria.SelectedValue
        objNTipo.cargarCBO(cboTipo, aux_id_categoria)
    End Sub

    Private Sub cboBuscarC_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboBuscarC.SelectionChangeCommitted
        Dim aux_id_categoria As Byte = cboBuscarC.SelectedValue
        objNproducto.BuscarCategoria(aux_id_categoria, DataGridView1)
    End Sub

    Private Sub txtbcod_TextChanged(sender As Object, e As EventArgs) Handles txtbcod.TextChanged
        Dim aux_cod As Integer = 0
        If txtbcod.Text = "" Or txtbcod.Text = " " Then
            objNproducto.BuscarCodigo(aux_cod, DataGridView1)
        Else
            aux_cod = CInt(txtbcod.Text)
        End If
        objNproducto.BuscarCodigo(aux_cod, DataGridView1)
    End Sub
End Class
