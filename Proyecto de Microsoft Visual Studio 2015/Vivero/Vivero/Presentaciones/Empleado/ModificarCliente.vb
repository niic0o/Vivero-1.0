Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class ModificarCliente
    Dim objNcliente = New N_CLIENTES
    Dim is_email As Boolean = False
    Dim aux_id_cliente As Integer = 0

    'controla que el usuario ingrese un formato correcto con libertad de dominios'
    Public Function EsUnEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function

    Private Sub txtemail_LostFocus(sender As Object, e As EventArgs) Handles txtemail.LostFocus
        Dim vf As Boolean = EsUnEmail(txtemail.Text)
        If vf = False Then
            MsgBox("Formato de email incorrecto", MsgBoxStyle.Exclamation, "Este correo no existe")
            is_email = False
            ErrorIsNotEmail.SetError(txtemail, "No es un correo válido")
            txttel.Focus()
        Else
            is_email = True
            ErrorIsNotEmail.Clear()
        End If
    End Sub

    Private Sub txtapellido_GotFocus(sender As Object, e As EventArgs) Handles txtapellido.GotFocus
        Clipboard.Clear()
    End Sub
    Private Sub txtnombre_GotFocus(sender As Object, e As EventArgs) Handles txtnombre.GotFocus
        Clipboard.Clear()
    End Sub
    Private Sub txttel_GotFocus(sender As Object, e As EventArgs) Handles txttel.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub txtdni_GotFocus(sender As Object, e As EventArgs) Handles txtdni.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub txtprov_GotFocus(sender As Object, e As EventArgs) Handles txtprov.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub txtloc_GotFocus(sender As Object, e As EventArgs) Handles txtloc.GotFocus
        Clipboard.Clear()
    End Sub


    Private Sub txtbuscardni_GotFocus(sender As Object, e As EventArgs) Handles txtdnicli.GotFocus
        Clipboard.Clear()
    End Sub
    Private Sub txtbapellido_GotFocus(sender As Object, e As EventArgs) Handles txtapcli.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub txtapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            ErrorSoloLetras.Clear()
        Else
            e.Handled = True
            ErrorSoloLetras.SetError(txtapellido, "Solo letras")
        End If
    End Sub


    Private Sub txtapellido_LostFocus(sender As Object, e As EventArgs) Handles txtapellido.LostFocus
        Dim cadena As String = txtapellido.Text()
        Dim nueva_cadena As String = StrConv(cadena, VbStrConv.ProperCase)
        txtapellido.Text() = nueva_cadena
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
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

    Private Sub txtdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress
        txtdni.MaxLength() = 8
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            ErrorSoloNumeros.Clear()
        Else
            e.Handled = True
            ErrorSoloNumeros.SetError(txtdni, "Solo numeros")
        End If
    End Sub


    Private Sub txtbapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapcli.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            ErrorSoloLetras.Clear()
        Else
            e.Handled = True
            ErrorSoloLetras.SetError(txtapcli, "Solo letras")
        End If
    End Sub


    Private Sub txtbapellido_LostFocus(sender As Object, e As EventArgs) Handles txtapcli.LostFocus
        Dim cadena As String = txtapcli.Text()
        Dim nueva_cadena As String = StrConv(cadena, VbStrConv.ProperCase)
        txtapcli.Text() = nueva_cadena
    End Sub

    Private Sub txtbdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdnicli.KeyPress
        txtdnicli.MaxLength() = 8
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            ErrorSoloNumeros.Clear()
        Else
            e.Handled = True
            ErrorSoloNumeros.SetError(txtdnicli, "Solo numeros")

        End If
    End Sub



    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If String.IsNullOrWhiteSpace(txtapellido.Text) Or
      String.IsNullOrWhiteSpace(txtnombre.Text) Or
      String.IsNullOrWhiteSpace(txtdni.Text) Or
      String.IsNullOrWhiteSpace(txtemail.Text) Or
      String.IsNullOrWhiteSpace(txttel.Text) Or
      String.IsNullOrWhiteSpace(textdir.Text) Or
      String.IsNullOrWhiteSpace(txtprov.Text) Or
      String.IsNullOrWhiteSpace(txtloc.Text) Then
            ' String.IsNullOrWhiteSpace(txtloc.Text) Then
            MsgBox("Debe seleccionar un cliente", MsgBoxStyle.Critical)
        Else

            ' Dim ask As MsgBoxResult

            ' ask = MsgBox("¿Modificar cliente?", MsgBoxStyle.YesNo + 'MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            ' If MsgBoxResult.Yes = ask Then

            'If (objNcliente.agregar_cliente(txtapellido.Text, txtnombre.Text, CInt(txtdni.Text), txtemail.Text, txttel.Text, textdir.Text, txtprov.Text, txtloc.Text)) Then

            ' MsgBox("El cliente se modifico correctamente", MsgBoxStyle.OkOnly + 'MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)

            'objNcliente.cargarGrid(DataGridView1)
            Dim n As Integer
            n = DataGridView1.Columns.Count() - 1

            Try
                Dim modif As N_CLIENTES = New N_CLIENTES

                modif.Modificar_Cliente(aux_id_cliente,
                    txtdni.Text,
                                        txtapellido.Text,
                txtnombre.Text,
                txtemail.Text,
                txttel.Text,
                textdir.Text,
                txtprov.Text,
                txtloc.Text)

                If MsgBox("¿Desea modificar dicho cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Gestión de Clientes") = MsgBoxResult.Yes Then
                    objNcliente.cargarGrid(DataGridView1)
                    'combobox1.selectvalue = id_categoria

                    'objNcliente.cargarGrid(DataGridView1)
                    txtapellido.Clear()
                    txtnombre.Clear()
                    txtdni.Clear()
                    txtemail.Clear()
                    txttel.Clear()
                    textdir.Clear()
                    txtprov.Clear()
                    txtloc.Clear()
                    MessageBox.Show("El Cliente ha sido actualizado correctamente", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("No se pudo modificar", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtapellido.Clear()
                    txtnombre.Clear()
                    txtdni.Clear()
                    txtemail.Clear()
                    txttel.Clear()
                    textdir.Clear()
                    txtprov.Clear()
                    txtloc.Clear()
                End If
                'objNcliente.cargarGrid(DataGridView1)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        objNcliente.cargarGrid(DataGridView1)
    End Sub


    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Dim FilaActual As Integer
        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        FilaActual = DataGridView1.CurrentRow.Index

        aux_id_cliente = DataGridView1.Rows(FilaActual).Cells("id_cliente").Value
        txtapellido.Text = DataGridView1.Rows(FilaActual).Cells("apellido").Value
        txtnombre.Text = DataGridView1.Rows(FilaActual).Cells("nombre").Value
        txtdni.Text = DataGridView1.Rows(FilaActual).Cells("dni").Value
        txtemail.Text = DataGridView1.Rows(FilaActual).Cells("email").Value
        txttel.Text = DataGridView1.Rows(FilaActual).Cells("telefono").Value
        textdir.Text = DataGridView1.Rows(FilaActual).Cells("direccion").Value
        txtprov.Text = DataGridView1.Rows(FilaActual).Cells("provincia").Value
        txtloc.Text = DataGridView1.Rows(FilaActual).Cells("localidad").Value
        is_email = True
        'Label13.Text = DataGridView1.Rows(FilaActual).Cells("id_cliente").Value
    End Sub

    Private Sub ModificarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNcliente.cargarGrid(DataGridView1)
    End Sub

    Private Sub txtapcli_TextChanged(sender As Object, e As EventArgs) Handles txtapcli.TextChanged
        objNcliente.BuscarNombre1(txtapcli.Text, DataGridView1)
    End Sub

    Private Sub txtdnicli_TextChanged(sender As Object, e As EventArgs) Handles txtdnicli.TextChanged
        Dim aux_dni As Integer = 0
        If txtdnicli.Text = "" Or txtdnicli.Text = " " Then
            objNcliente.cargarGrid(DataGridView1)
            Exit Sub
        Else
            aux_dni = CInt(txtdnicli.Text)
        End If
        objNcliente.BuscarDNI1(aux_dni, DataGridView1)
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        objNcliente.cargarGrid(DataGridView1)
        txtapellido.Clear()
        txtnombre.Clear()
        txtdni.Clear()
        txtemail.Clear()
        txttel.Clear()
        textdir.Clear()
        txtprov.Clear()
        txtloc.Clear()
    End Sub
End Class
