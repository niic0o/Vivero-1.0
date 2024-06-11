Imports System.Text.RegularExpressions
Public Class AltaDeProducto

    Dim objNproducto As N_PRODUCTOS = New N_PRODUCTOS
    Dim objNTipo As N_TIPOS_DE_PRODUCTOS = New N_TIPOS_DE_PRODUCTOS
    Dim objNcategoria As N_CATEGORIAS = New N_CATEGORIAS
    Dim aux_decimal As Double = 0

    'Dim ocategoria = New Ncategoria
    'Dim objNproducto = New Nproducto

    'Private Sub txtcod_KeyPress(sender As Object, e As KeyPressEventArgs)
    'Solo numeros
    'Dim texto As New Regex("[a-z]", RegexOptions.IgnoreCase)
    '  e.Handled = texto.IsMatch(e.KeyChar)
    'End Sub

    Private Sub txtnombre_LostFocus(sender As Object, e As EventArgs) Handles txtnombre.LostFocus
        Dim cadena As String = txtnombre.Text()
        Dim nueva_cadena As String = StrConv(cadena, VbStrConv.ProperCase)
        txtnombre.Text() = nueva_cadena
    End Sub


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
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
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical)
        Else
            Dim disponible As String = " "
            If rdbSI.Checked = True Then
                disponible = "SI"
            Else
                disponible = "NO"
            End If
            Dim ask As MsgBoxResult
            ask = MsgBox("¿Desea cargar el producto?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then

                If (objNproducto.agregar_producto(CByte(cboCategoria.SelectedValue()), CShort(cboTipo.SelectedValue()), CStr(txtnombre.Text()), CStr(txtdescr.Text), CStr(txtTamaño.Text), disponible, CInt(txtstock.Text()), CInt(txtstockmin.Text()), CDbl(txtprecio.Text()), CDbl(txtpreciolista.Text()), CDbl(txtDescuento.Text()))) Then

                    MsgBox("El producto se cargo correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
                    objNproducto.cargarGrid(DataGridView_Productos)
                    cboTipo.SelectedItem = Nothing
                    cboCategoria.SelectedItem = Nothing
                    txtnombre.Clear()
                    txtdescr.Clear()
                    txtTamaño.Clear()
                    txtstock.Clear()
                    txtstockmin.Clear()
                    txtprecio.Clear()
                    txtpreciolista.Clear()
                    txtDescuento.Clear()
                Else
                    MsgBox("Error de carga", MsgBoxStyle.Critical, "Error fatal")
                End If
            Else
                'MsgBox("producto ya existe", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                'txtstock.Focus()
                Exit Sub
                End If
            End If


    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        cboTipo.SelectedItem = Nothing
        cboCategoria.SelectedItem = Nothing
        txtnombre.Clear()
        txtdescr.Clear()
        txtTamaño.Clear()
        txtstock.Clear()
        txtstockmin.Clear()
        txtprecio.Clear()
        txtpreciolista.Clear()
        txtDescuento.Clear()
    End Sub

    Private Sub AltaDeProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTipo.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        cboBuscarC.DropDownStyle = ComboBoxStyle.DropDownList
        objNproducto.cargarGrid(DataGridView_Productos)
        objNcategoria.cargarCBO_solo_activos(cboCategoria)
        objNcategoria.cargarCBO_solo_activos(cboBuscarC)
        'objNproducto.cargarGrid(DataGridView1)
        'DataGridView1.Columns(3).Visible = False
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

    Private Sub txtbcod_LostFocus(sender As Object, e As EventArgs) Handles txtbcod.LostFocus
        If Val(txtbcod.Text) = False Then
            ErrorSoloNumeros.SetError(txtbcod, "Solo numeros")
            txtbcod.Clear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cboCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCategoria.SelectionChangeCommitted
        Dim aux_id_categoria As Byte = cboCategoria.SelectedValue
        objNTipo.cargarCBO(cboTipo, aux_id_categoria)
    End Sub

    Private Sub txtbcod_TextChanged(sender As Object, e As EventArgs) Handles txtbcod.TextChanged
        Dim aux_cod As Integer = 0
        If txtbcod.Text = "" Or txtbcod.Text = " " Then
            objNproducto.BuscarCodigo(aux_cod, DataGridView_Productos)
        Else
            aux_cod = CInt(txtbcod.Text)
        End If
        objNproducto.BuscarCodigo(aux_cod, DataGridView_Productos)
    End Sub

    Private Sub cboBuscarC_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboBuscarC.SelectionChangeCommitted
        Dim aux_id_categoria As Byte = cboBuscarC.SelectedValue
        objNproducto.BuscarCategoria(aux_id_categoria, DataGridView_Productos)
    End Sub

    'Procedimiento de prueba para saber si capturo el id_categoria del combo box
    'Private Sub cboCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) 'Handles cboCategoria.SelectionChangeCommitted
    ' txtstock.Text = CInt(cboCategoria.SelectedValue())
    'End Sub
End Class
