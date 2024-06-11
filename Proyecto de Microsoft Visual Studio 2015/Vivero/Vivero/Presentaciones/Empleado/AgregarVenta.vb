Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Public Class AgregarVenta
    Dim objNTipoPago As N_FORMA_PAGO = New N_FORMA_PAGO
    Dim objNFactura As N_FACTURAS = New N_FACTURAS
    Dim objNDetalle As N_FACTURAS_DETALLE = New N_FACTURAS_DETALLE
    Dim objNProducto As N_PRODUCTOS = New N_PRODUCTOS
    Dim aux_decimal As Double = 0
    Dim aux_total As Double = 0.0
    Dim p_cat As String
    Public cliente_selected As CLIENTES = New CLIENTES
    Private user_login As USUARIOS = New USUARIOS
    Public producto_selected As PRODUCTOS = New PRODUCTOS

    Public Sub New(ByVal aux_user_login As USUARIOS)

        InitializeComponent()
        user_login = aux_user_login

    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        txtcantidad.MaxLength() = 2
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            ErrorSoloNumeros.Clear()
        Else
            e.Handled = True
            ErrorSoloNumeros.SetError(txtcantidad, "Solo numeros")
        End If
    End Sub

    Private Sub txtcantidad_LostFocus(sender As Object, e As EventArgs) Handles txtcantidad.LostFocus
        If Val(txtcantidad.Text) = False Then
            ErrorSoloNumeros.SetError(txtcantidad, "Solo numeros")
            txtcantidad.Clear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtcantidad_GotFocus(sender As Object, e As EventArgs) Handles txtcantidad.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub txtnfactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnfactura.KeyPress
        'Solo numeros
        Dim texto As New Regex("[a-z]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
    End Sub

    Private Sub txtvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvendedor.KeyPress
        'Solo Letras
        Dim texto As New Regex("[0-9]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
    End Sub

    Private Sub txtcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcliente.KeyPress
        'Solo Letras
        Dim texto As New Regex("[0-9]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
    End Sub

    Private Sub txtproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdesc.KeyPress
        'Solo Letras
        Dim texto As New Regex("[0-9]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        'Solo numeros
        Dim texto As New Regex("[a-z]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
    End Sub

    Private Sub AgregarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTipoPago.DropDownStyle = ComboBoxStyle.DropDownList
        objNTipoPago.cargarCBO(cboTipoPago)
        txtvendedor.Text = (CStr(user_login.apellido)) + " " + (CStr(user_login.nombre))
        txtnfactura.Text = CStr((objNFactura.ultimo_numero) + 1)
        aux_total = 0.0
        txtTotal.Text() = CStr(aux_total)
        DateFactura.Text = DateTime.Now
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If String.IsNullOrWhiteSpace(txtnfactura.Text) Or
                String.IsNullOrWhiteSpace(txtCategoria.Text) Or
            String.IsNullOrWhiteSpace(txtcliente.Text) Or
        String.IsNullOrWhiteSpace(txtdesc.Text) Or
        String.IsNullOrWhiteSpace(txtcantidad.Text) Or
        String.IsNullOrWhiteSpace(txtprecio.Text) Or
        String.IsNullOrWhiteSpace(txtStock.Text) Or
        String.IsNullOrWhiteSpace(txtdescuento.Text) Or
        String.IsNullOrWhiteSpace(txtvendedor.Text) Or
        String.IsNullOrWhiteSpace(txtdni.Text) Or
        String.IsNullOrWhiteSpace(cboTipoPago.Text) Or
        IsNothing(cboTipoPago) Then

            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical)
            Exit Sub
        Else

            Dim ask As MsgBoxResult

            ask = MsgBox("¿Agregar el producto: " + Me.producto_selected.nombre + " a la venta?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then


                If Me.producto_selected.stock < (CShort(txtcantidad.Text)) Then
                    MsgBox("!La cantidad supera el stock!", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                If Me.producto_Repetido() = True Then
                    MsgBox("!Ese producto ya está en el listado! Elimine el producto e ingrese una nueva cantidad", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                'desarrollar carga del datagrid'
                'campos: (no)num_factura, (no)id_item, id_producto, descripcion, precio, cantidad, sub_total

                Dim aux_sub_total As Double = 0.0
                aux_sub_total = (CDbl(txtcantidad.Text)) * (CDbl(txtprecio.Text))
                aux_total = aux_total + aux_sub_total
                Dim aux_descripcion As String = txtCategoria.Text + " - " + txtdesc.Text
                Me.DataGridView_VentaDetalle.Rows.Add(CInt(producto_selected.id_producto), aux_descripcion, CDbl(txtprecio.Text), CShort(txtcantidad.Text), CDbl(aux_sub_total))
                txtTotal.Text = aux_total

                'MsgBox("El cliente se registro correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)

                'objNcliente.cargarGrid(DataGridView1)
                txtCategoria.Clear()
                txtdesc.Clear()
                txtcantidad.Clear()
                txtprecio.Clear()
                txtdescuento.Clear()
                txtStock.Clear()
            End If

        End If

    End Sub

    Private Sub txtdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress
        'Solo numeros
        Dim texto As New Regex("[a-z]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click


        Dim vendedor6 As SeleccionarProducto = New SeleccionarProducto(producto_selected)
        vendedor6.ShowDialog()
        'cargo el producto en la instancia de AgregarVenta para trabajar con el datagrid y demas controles'
        Me.producto_selected = vendedor6.producto_selected
        'evito que me rellene con null el campo categoria, cada vez que llamo a SeleccionarProducto la relacion entre objetos se reinicia
        If IsNothing(Me.producto_selected.TIPOS_DE_PRODUCTOS.CATEGORIAS.categoria) Then
            Exit Sub
        End If
        txtCategoria.Text = Me.producto_selected.TIPOS_DE_PRODUCTOS.CATEGORIAS.categoria
        txtdesc.Text = CStr(Me.producto_selected.nombre)
        txtcantidad.Clear()
        txtprecio.Text = CStr(Me.producto_selected.precio_venta)
        txtdescuento.Text = CStr(Me.producto_selected.descuento)
        txtStock.Text = CStr(Me.producto_selected.stock)
        If (Me.producto_selected.descuento) = 0 Then
            Exit Sub
        Else
            txtprecio.Text = CStr(Me.descontar(Me.producto_selected.descuento, Me.producto_selected.precio_venta))
            MsgBox("El producto tiene un: " + txtdescuento.Text + "% de descuento", MsgBoxStyle.Information, "Informe al cliente: ")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (DataGridView_VentaDetalle.SelectedRows.Count = 1) Then
            Dim fila As Integer = Me.DataGridView_VentaDetalle.CurrentRow.Index
            Dim supr_sub_total As Double = Me.DataGridView_VentaDetalle.Rows(fila).Cells(4).Value
            aux_total = aux_total - supr_sub_total
            txtTotal.Text = aux_total

            DataGridView_VentaDetalle.Rows.Remove(Me.DataGridView_VentaDetalle.CurrentRow)

            MsgBox("Item eliminado", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
        Else
            MsgBox("Haga click en un item", MsgBoxStyle.Information, "Seleccione una fila de la tabla")
        End If
    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        If String.IsNullOrWhiteSpace(txtnfactura.Text) Or
        String.IsNullOrWhiteSpace(txtcliente.Text) Or
        String.IsNullOrWhiteSpace(txtvendedor.Text) Or
        String.IsNullOrWhiteSpace(txtdni.Text) Or
        String.IsNullOrWhiteSpace(cboTipoPago.Text) Or
        IsNothing(cboTipoPago) Or
        DataGridView_VentaDetalle.Rows.Count = 0 Then
            ' String.IsNullOrWhiteSpace(txtloc.Text) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical)
        Else

            Dim ask As MsgBoxResult

            ask = MsgBox("¿Confirmar la venta?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)

            If MsgBoxResult.Yes = ask Then

                'ESTO ES UNA PRUEBA.  BORRAR DESPUES'
                'Dim cadena As String = CStr(CInt(txtnfactura.Text)) + " " + CStr(CDate(DateFactura.Text)) + " " + CStr(CShort(user_login.id_usuario)) + " " + CStr(CByte(cboTipoPago.SelectedValue())) + " " + CStr(CInt(cliente_selected.id_cliente)) + " " + CStr(CDbl(txtTotal.Text))
                'MsgBox(" " + cadena)
                If objNFactura.agregar_factura(CInt(txtnfactura.Text), CDate(DateTime.Now), CShort(user_login.id_usuario), CByte(cboTipoPago.SelectedValue()), CInt(cliente_selected.id_cliente), CDbl(txtTotal.Text)) Then

                    'ACA VA TODO LO DE DETALLE
                    Dim aux_id_item As Byte = 0
                    For i As Integer = 0 To DataGridView_VentaDetalle.Rows.Count - 1
                        '0 cod_producto
                        '1 descripcion
                        '2 precio
                        '3 cantidad
                        '4 sub_total
                        Dim aux_n_factura As Integer = CInt(txtnfactura.Text)
                        aux_id_item = CByte((aux_id_item) + 1)
                        Dim aux_id_producto As Integer = CInt(Me.DataGridView_VentaDetalle.Rows(i).Cells(0).Value)
                        Dim aux_descripcion As String = Me.DataGridView_VentaDetalle.Rows(i).Cells(1).Value
                        Dim aux_precio As Double = CDbl(Me.DataGridView_VentaDetalle.Rows(i).Cells(2).Value)
                        Dim aux_cantidad As Short = CShort(Me.DataGridView_VentaDetalle.Rows(i).Cells(3).Value)
                        Dim aux_subtotal As Double = CDbl(Me.DataGridView_VentaDetalle.Rows(i).Cells(4).Value)

                        objNDetalle.agregar_un_detalle(aux_n_factura, aux_id_item, aux_id_producto, aux_descripcion, aux_precio, aux_cantidad, aux_subtotal)
                        'esto es de prueba borra despues
                        'cadena = CStr(aux_n_factura) + " " + CStr(aux_id_item) + " " + CStr(aux_id_producto) + " " + CStr(aux_descripcion) + " " + CStr(aux_precio) + " " + CStr(aux_cantidad) + " " + CStr(aux_subtotal)
                        'MsgBox(" " + cadena)
                    Next

                    aux_id_item = 0
                    'ACA TERMINA TODO LO DE DETALLE
                    'ACA ACTUALIZO EL NUMERO DE FACTURA RECIEN Y REINICIALIZO TODO

                    MsgBox("La factura se generó satisfactoriamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
                    Dim menu As VerFactura = New VerFactura
                    menu.ShowDialog()
                    Me.Reiniciar_Formulario()
                Else
                    MsgBox("Ocurrió un error al generar la factura. El formulario se reiniara", MsgBoxStyle.Critical)
                    Me.Reiniciar_Formulario()
                End If
            Else
                Exit Sub 'confirmar venta = no
            End If

        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        txtdni.Clear()
        txtcliente.Clear()
        Dim vendedor4 As SeleccionarCliente = New SeleccionarCliente(cliente_selected)
        vendedor4.ShowDialog()
        txtcliente.Text = (CStr(vendedor4.cliente_selected.apellido)) + " " + (CStr(vendedor4.cliente_selected.nombre))
        txtdni.Text = (CStr(cliente_selected.DNI))

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtnfactura.Text) Or
        String.IsNullOrWhiteSpace(txtcliente.Text) Or
        String.IsNullOrWhiteSpace(txtdesc.Text) Or
        String.IsNullOrWhiteSpace(txtcantidad.Text) Or
        String.IsNullOrWhiteSpace(txtprecio.Text) Or
        String.IsNullOrWhiteSpace(txtvendedor.Text) Or
        String.IsNullOrWhiteSpace(txtdni.Text) Then
            ' String.IsNullOrWhiteSpace(txtloc.Text) Then
            MsgBox("Debe seleccionar un cliente", MsgBoxStyle.Critical)
        Else

            Dim ask As MsgBoxResult

            ask = MsgBox("¿Modificar cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then

                'If (objNcliente.agregar_cliente(txtapellido.Text, txtnombre.Text, CInt(txtdni.Text), txtemail.Text, txttel.Text, textdir.Text, txtprov.Text, txtloc.Text)) Then

                MsgBox("El cliente se modifico correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)

                'objNcliente.cargarGrid(DataGridView1)
                txtnfactura.Clear()
                txtcliente.Clear()
                txtdesc.Clear()
                txtcantidad.Clear()
                txtprecio.Clear()
                txtvendedor.Clear()
                txtdni.Clear()

            End If

        End If
    End Sub

    Private Sub txtprecio_LostFocus(sender As Object, e As EventArgs) Handles txtprecio.LostFocus
        If Val(txtprecio.Text) = False Then
            ErrorSoloDecimales.SetError(txtprecio, "Solo numeros enteros o decimales, usar punto '.'")
            txtprecio.Clear()
        Else
            aux_decimal = Val(txtprecio.Text)
            txtprecio.Text = aux_decimal
            Exit Sub
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCategoria.Clear()
        txtdesc.Clear()
        txtcantidad.Clear()
        txtdescuento.Clear()
        txtprecio.Clear()
        txtStock.Clear()

    End Sub

    Private Sub Reiniciar_Formulario()
        txtnfactura.Text = CStr(Me.objNFactura.ultimo_numero() + 1)
        Me.cliente_selected = Nothing
        Me.producto_selected = Nothing
        Me.producto_selected = New PRODUCTOS
        Me.cliente_selected = New CLIENTES
        txtcliente.Clear()
        txtdni.Clear()
        cboTipoPago.SelectedItem = Nothing
        objNTipoPago.cargarCBO(cboTipoPago)
        aux_total = 0.0
        txtTotal.Clear()
        txtCategoria.Clear()
        txtdesc.Clear()
        txtcantidad.Clear()
        txtdescuento.Clear()
        txtprecio.Clear()
        txtStock.Clear()
        DataGridView_VentaDetalle.Rows.Clear()
    End Sub

    Private Sub btnCancelarVenta_Click(sender As Object, e As EventArgs) Handles btnCancelarVenta.Click

        Dim ask As MsgBoxResult

        ask = MsgBox("¿Cancelar la Venta? Perderá todo el listado", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)

        If MsgBoxResult.Yes = ask Then
            Me.Reiniciar_Formulario()
        Else
            Exit Sub
        End If
    End Sub

    Private Function producto_Repetido() As Boolean
        Dim auxid As Integer = producto_selected.id_producto

        For i As Integer = 0 To DataGridView_VentaDetalle.Rows.Count - 1
            '0 cod_producto
            Dim aux_id_producto As Integer = CInt(Me.DataGridView_VentaDetalle.Rows(i).Cells(0).Value)
            If auxid = aux_id_producto Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function descontar(ByVal aux_dto As Double, ByVal aux_importe As Double) As Double
        Dim aux_nuevo_importe As Double
        aux_nuevo_importe = (aux_importe - (aux_importe * (aux_dto / 100)))
        Return aux_nuevo_importe
    End Function

End Class