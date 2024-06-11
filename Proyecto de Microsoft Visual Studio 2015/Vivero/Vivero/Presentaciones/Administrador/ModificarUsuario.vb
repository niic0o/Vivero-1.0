Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class ModificarUsuario
    Dim is_email As Boolean = False
    Dim aux_id_perfil As Integer = 0
    Dim aux_id_usuario As Integer = 0
    Dim objNusuarios = New N_USUARIOS
    Dim objNperfil = New N_PERFILES

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
    Private Sub txtbuscardni_GotFocus(sender As Object, e As EventArgs) Handles txtbuscardni.GotFocus
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

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttel.KeyPress
        'Solo numeros
        Dim texto As New Regex("[a-z]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If String.IsNullOrWhiteSpace(txtapellido.Text) Or
        String.IsNullOrWhiteSpace(txtnombre.Text) Or
        String.IsNullOrWhiteSpace(txtdni.Text) Or
        String.IsNullOrWhiteSpace(txtusuario.Text) Or
        String.IsNullOrWhiteSpace(txtdireccion.Text) Or
        String.IsNullOrWhiteSpace(txttel.Text) Or
        is_email = False Or
        String.IsNullOrWhiteSpace(txtemail.Text) Or
        String.IsNullOrWhiteSpace(txtcontraseña.Text) Or
        String.IsNullOrWhiteSpace(cbotipoperfil.Text) Or
        IsNothing(cbotipoperfil) Or
            ((CDate(DateNac.Text) = Today)) Or
        ((CDate(DateIngreso.Text) = Today)) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical)
        Else 'Controlo la contraseña
            If txtcontraseña.TextLength < 8 Then
                MsgBox("La contraseña debe tener 8 o mas caracteres", MsgBoxStyle.Critical, "Contraseña Insegura")
                Exit Sub
            End If

            ' If (objNusuario.agregar_usuario(CByte(cbotipoperfil.SelectedValue()), CInt(txtdni.Text), txtapellido.Text, txtnombre.Text, CDate(DateNac.Text), CDate(DateIngreso.Text), txtusuario.Text, txtcontraseña.Text, txtdireccion.Text, txttel.Text, txtemail.Text)) Then

            Dim n As Integer
            n = DataGridView1.Columns.Count() - 1

            Try
                Dim modif As N_USUARIOS = New N_USUARIOS

                modif.Modificar_Usuario(cbotipoperfil.SelectedValue(),
                                        aux_id_perfil,
                                        aux_id_usuario,
                              txtdni.Text,
                              txtapellido.Text,
                              txtnombre.Text,
                                DateNac.Text,
                               DateIngreso.Text,
                                txtusuario.Text,
                                txtcontraseña.Text,
                                txtdireccion.Text,
                                txttel.Text,
                              txtemail.Text)

                If MsgBox("¿Desea modificar dicho cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Gestión de Clientes") = MsgBoxResult.Yes Then

                    objNusuarios.cargargrid(DataGridView1)

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

                    MessageBox.Show("El Cliente ha sido actualizado correctamente", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("No se pudo modificar", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                objNusuarios.cargarGrid(DataGridView1)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Dim FilaActual As Integer
        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        FilaActual = DataGridView1.CurrentRow.Index
        aux_id_perfil = DataGridView1.Rows(FilaActual).Cells("id_perfil").Value
        cbotipoperfil.Text = DataGridView1.Rows(FilaActual).Cells("Perfil").Value
        aux_id_usuario = DataGridView1.Rows(FilaActual).Cells("id_usuario").Value
        txtdni.Text = DataGridView1.Rows(FilaActual).Cells("DNI").Value
        txtapellido.Text = DataGridView1.Rows(FilaActual).Cells("apellido").Value
        txtnombre.Text = DataGridView1.Rows(FilaActual).Cells("nombre").Value
        DateNac.Text = DataGridView1.Rows(FilaActual).Cells("Fecha_nac").Value
        DateIngreso.Text = DataGridView1.Rows(FilaActual).Cells("Fecha_ingreso").Value
        txtusuario.Text = DataGridView1.Rows(FilaActual).Cells("username").Value
        txtcontraseña.Text = DataGridView1.Rows(FilaActual).Cells("contraseña").Value
        txtdireccion.Text = DataGridView1.Rows(FilaActual).Cells("direccion").Value
        txttel.Text = DataGridView1.Rows(FilaActual).Cells("telefono").Value
        txtemail.Text = DataGridView1.Rows(FilaActual).Cells("email").Value
        EsUnEmail(txtemail.Text)
        is_email = True
        'Label13.Text = DataGridView1.Rows(FilaActual).Cells("id_cliente").Value
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

    Private Sub ModificarUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbotipoperfil.DropDownStyle = ComboBoxStyle.DropDownList
        objNperfil.cargarCBO(cbotipoperfil)
        objNusuarios.cargarGrid(DataGridView1)
        DateIngreso.MinDate = "5/11/2000"
        DateIngreso.MaxDate = Today
        DateNac.MinDate = "1/1/1920"
        DateNac.MaxDate = Today
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
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

    Private Sub txtbuscardni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuscardni.KeyPress
        txtbuscardni.MaxLength() = 8
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            ErrorSoloNumeros.Clear()
        Else
            e.Handled = True
            ErrorSoloNumeros.SetError(txtbuscardni, "Solo numeros")
        End If
    End Sub

    Private Sub txtbuscardni_LostFocus(sender As Object, e As EventArgs) Handles txtbuscardni.LostFocus
        If Val(txtdni.Text) = False Then
            ErrorSoloNumeros.SetError(txtbuscardni, "Solo numeros")
            txtbuscardni.Clear()
        Else
            ErrorSoloNumeros.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub txtbapellido_TextChanged(sender As Object, e As EventArgs) Handles txtbapellido.TextChanged
        objNusuarios.BuscarNombre1(txtbapellido.Text, DataGridView1)
    End Sub

    Private Sub txtbuscardni_TextChanged(sender As Object, e As EventArgs) Handles txtbuscardni.TextChanged
        Dim aux_dni As Integer = 0
        If txtbuscardni.Text = "" Or txtbuscardni.Text = " " Then
            Exit Sub
        Else
            aux_dni = CInt(txtbuscardni.Text)
        End If
        objNusuarios.BuscarDNI1(aux_dni, DataGridView1)
    End Sub


End Class
