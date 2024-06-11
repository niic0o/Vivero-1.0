Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class AltaCliente

    Dim objNcliente = New N_CLIENTES
    Dim is_email As Boolean = False

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


    Private Sub txtbuscardni_GotFocus(sender As Object, e As EventArgs) Handles txtbdni.GotFocus
        Clipboard.Clear()
    End Sub
    Private Sub txtbapellido_GotFocus(sender As Object, e As EventArgs) Handles txtbapellido.GotFocus
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

    Private Sub txtdni_LostFocus(sender As Object, e As EventArgs) Handles txtdni.LostFocus
        If Val(txtdni.Text) = False Then
            ErrorSoloNumeros.SetError(txtdni, "Solo numeros")
            txtdni.Clear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtbapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbapellido.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            ErrorSoloLetras.Clear()
        Else
            e.Handled = True
            ErrorSoloLetras.SetError(txtbapellido, "Solo letras")
        End If
    End Sub


    Private Sub txtbapellido_LostFocus(sender As Object, e As EventArgs) Handles txtbapellido.LostFocus
        Dim cadena As String = txtbapellido.Text()
        Dim nueva_cadena As String = StrConv(cadena, VbStrConv.ProperCase)
        txtbapellido.Text() = nueva_cadena
    End Sub

    Private Sub txtbdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbdni.KeyPress
        txtbdni.MaxLength() = 8
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            ErrorSoloNumeros.Clear()
        Else
            e.Handled = True
            ErrorSoloNumeros.SetError(txtbdni, "Solo numeros")
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If String.IsNullOrWhiteSpace(txtapellido.Text) Or
        String.IsNullOrWhiteSpace(txtnombre.Text) Or
        String.IsNullOrWhiteSpace(txtdni.Text) Or
        String.IsNullOrWhiteSpace(txtemail.Text) Or
        String.IsNullOrWhiteSpace(txttel.Text) Or
        String.IsNullOrWhiteSpace(textdir.Text) Or
        String.IsNullOrWhiteSpace(txtprov.Text) Or
        is_email = False Or
        String.IsNullOrWhiteSpace(txtloc.Text) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical)
        Else

            Dim ask As MsgBoxResult

            ask = MsgBox("¿Desea registrar el cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then

                If (objNcliente.agregar_cliente(txtapellido.Text, txtnombre.Text, CInt(txtdni.Text), txtemail.Text, txttel.Text, textdir.Text, txtprov.Text, txtloc.Text)) Then

                    MsgBox("El cliente se registro correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)

                    objNcliente.cargarGrid_activos_inactivos(DataGridView_Clientes)
                    txtapellido.Clear()
                    txtnombre.Clear()
                    txtdni.Clear()
                    txtemail.Clear()
                    txttel.Clear()
                    textdir.Clear()
                    txtprov.Clear()
                    txtloc.Clear()
                Else
                    MsgBox("Error de carga, puede que este cliente ya esté registrado", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                    txtdni.Focus()
                End If
            Else
                Exit Sub
            End If

        End If


    End Sub

    Private Sub AltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNcliente.cargarGrid_activos_inactivos(DataGridView_Clientes)
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        txtapellido.Clear()
        txtnombre.Clear()
        txtdni.Clear()
        txtemail.Clear()
        txttel.Clear()
        textdir.Clear()
        txtprov.Clear()
    End Sub

    Private Sub txtbapellido_TextChanged(sender As Object, e As EventArgs) Handles txtbapellido.TextChanged
        objNcliente.BuscarNombre1_activos_inactivos(txtbapellido.Text, DataGridView_Clientes)
    End Sub

    Private Sub txtbdni_TextChanged(sender As Object, e As EventArgs) Handles txtbdni.TextChanged
        Dim aux_dni As Integer = 0
        If txtbdni.Text = "" Or txtbdni.Text = " " Then
            Exit Sub
        Else
            aux_dni = CInt(txtbdni.Text)
        End If
        objNcliente.BuscarDNI1_activos_inactivos(aux_dni, DataGridView_Clientes)
    End Sub
End Class
