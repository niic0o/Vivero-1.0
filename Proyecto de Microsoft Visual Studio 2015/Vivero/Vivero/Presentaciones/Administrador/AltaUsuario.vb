Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class AltaUsuario
    Dim is_email As Boolean = False
    Dim objNperfil = New N_PERFILES
    Dim objNusuario = New N_USUARIOS

    'Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    'End Sub

    Private Sub txtapellido_GotFocus(sender As Object, e As EventArgs) Handles txtapellido.GotFocus
        Clipboard.Clear()
    End Sub
    Private Sub txtnombre_GotFocus(sender As Object, e As EventArgs) Handles txtnombre.GotFocus
        Clipboard.Clear()
    End Sub
    Private Sub txttel_GotFocus(sender As Object, e As EventArgs) Handles txttel.GotFocus
        Clipboard.Clear()
    End Sub
    Private Sub txtcontraseña_GotFocus(sender As Object, e As EventArgs) Handles txtcontraseña.GotFocus
        Clipboard.Clear()
    End Sub
    Private Sub txtbuscardni_GotFocus(sender As Object, e As EventArgs) Handles txtbdni.GotFocus
        Clipboard.Clear()
    End Sub
    Private Sub txtbuscarnombre_GotFocus(sender As Object, e As EventArgs) Handles txtbapellido.GotFocus
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

    'podria necesitarse una amplia descripcion para referirse a una ubicacion domiciliaria'
    'Private Sub txtdireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdireccion.KeyPress

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttel.KeyPress
        'Solo numeros
        Dim texto As New Regex("[a-z]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
    End Sub

    Private Sub txtbuscarnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbapellido.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            ErrorSoloLetras.Clear()
        Else
            e.Handled = True
            ErrorSoloLetras.SetError(txtbapellido, "Solo letras")
        End If
    End Sub


    Private Sub txtbuscarnombre_LostFocus(sender As Object, e As EventArgs) Handles txtbapellido.LostFocus
        Dim cadena As String = txtbapellido.Text()
        Dim nueva_cadena As String = StrConv(cadena, VbStrConv.ProperCase)
        txtbapellido.Text() = nueva_cadena
    End Sub

    Private Sub txtbuscardni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbdni.KeyPress
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
        'Controlo campos vacios
        If String.IsNullOrWhiteSpace(txtapellido.Text) Or
        String.IsNullOrWhiteSpace(txtnombre.Text) Or
        String.IsNullOrWhiteSpace(txtdni.Text) Or
        String.IsNullOrWhiteSpace(txtusuario.Text) Or
        String.IsNullOrWhiteSpace(txtdireccion.Text) Or
        String.IsNullOrWhiteSpace(txttel.Text) Or
        is_email = False Or
        String.IsNullOrWhiteSpace(txtemail.Text) Or
        String.IsNullOrWhiteSpace(txtcontraseña.Text) Or
        IsNothing(cbotipoperfil) Or
        String.IsNullOrWhiteSpace(cbotipoperfil.Text) Or
        ((CDate(DateNac.Text) = Today)) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical)
        Else 'Controlo la contraseña
            If txtcontraseña.TextLength < 8 Then
                MsgBox("La contraseña debe tener 8 o mas caracteres", MsgBoxStyle.Critical, "Contraseña Insegura")
                Exit Sub
            End If
            Dim ask As MsgBoxResult
            'El usuario decide
            ask = MsgBox("¿Desea registrar usuario?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then
                If (objNusuario.agregar_usuario(CByte(cbotipoperfil.SelectedValue()), CInt(txtdni.Text), txtapellido.Text, txtnombre.Text, CDate(DateNac.Text), CDate(DateIngreso.Text), txtusuario.Text, txtcontraseña.Text, txtdireccion.Text, txttel.Text, txtemail.Text)) Then
                    'Apellido.DefaultCellStyle.Font = New Font("Monotype Corsiva", 15, FontStyle.Italic)
                    ' Nombre.DefaultCellStyle.Font = New Font("Monotype Corsiva", 15, FontStyle.Italic)
                    'For Each r As DataGridViewRow In DataGridView1.Rows
                    'Next
                    MsgBox("El usuario se registro correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
                    objNusuario.cargarGrid_activos_inactivos(DataGridView_Usuarios)
                    DateNac.Text = CStr(Today)
                    DateIngreso.Text = CStr(Today)
                    txtapellido.Clear()
                    txtnombre.Clear()
                    txtdni.Clear()
                    txtusuario.Clear()
                    txtdireccion.Clear()
                    txttel.Clear()
                    txtemail.Clear()
                    txtcontraseña.Clear()
                    cbotipoperfil.SelectedItem = Nothing
                    btncontraseña.Text = "Ver"
                    txtcontraseña.PasswordChar = "*"
                    is_email = False

                End If

                'objNusuario.cargarGrid(DataGridView1)
                ' Else
                'MsgBox("usuario ya existe", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                'txtdni.Focus()
                Exit Sub
            End If

        End If
        ' End If
    End Sub

    Private Sub AltaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbotipoperfil.DropDownStyle = ComboBoxStyle.DropDownList
        objNperfil.cargarCBO(cbotipoperfil)
        objNusuario.cargarGrid_activos_inactivos(DataGridView_Usuarios)
        DateIngreso.MinDate = "5/11/2000"
        DateIngreso.MaxDate = Today
        DateNac.MinDate = "1/1/1920"
        DateNac.MaxDate = Today
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        DateNac.Text = CStr(Today)
        DateIngreso.Text = CStr(Today)
        txtapellido.Clear()
        txtnombre.Clear()
        txtdni.Clear()
        txtdireccion.Clear()
        txttel.Clear()
        txtemail.Clear()
        txtcontraseña.Clear()
        txtusuario.Clear()
        cbotipoperfil.SelectedItem = Nothing
        txtapellido.Focus()
    End Sub

    Private Sub btncontraseña_Click(sender As Object, e As EventArgs) Handles btncontraseña.Click
        If btncontraseña.Text = "Ver" Then
            btncontraseña.Text = "Ocultar"
            txtcontraseña.PasswordChar = Nothing
        Else
            btncontraseña.Text = "Ver"
            txtcontraseña.PasswordChar = "*"
        End If
    End Sub

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

    Private Sub txtbape_TextChanged(sender As Object, e As EventArgs) Handles txtbapellido.TextChanged
        objNusuario.BuscarNombre1_activos_inactivos(txtbapellido.Text, DataGridView_Usuarios)
    End Sub

    Private Sub txtbdni_TextChanged(sender As Object, e As EventArgs) Handles txtbdni.TextChanged
        Dim aux_dni As Integer = 0
        If txtbdni.Text = "" Or txtbdni.Text = " " Then
            Exit Sub
        Else
            aux_dni = CInt(txtbdni.Text)
        End If
        objNusuario.BuscarDNI1_activos_inactivos(aux_dni, DataGridView_Usuarios)
    End Sub
End Class