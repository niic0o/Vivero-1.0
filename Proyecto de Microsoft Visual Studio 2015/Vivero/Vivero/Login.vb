Public Class Login

    Dim objNusuario As N_USUARIOS = New N_USUARIOS
    Dim user_login As USUARIOS = New USUARIOS
    Dim id_perfil As Byte = 0
    Dim alerta As Byte = 0

    Private Sub txtsalir_Click(sender As Object, e As EventArgs) Handles txtsalir.Click
        Me.Close()
    End Sub

    Private Sub txtingresar_Click(sender As Object, e As EventArgs) Handles txtingresar.Click
        If String.IsNullOrWhiteSpace(txtusuario.Text) Or
        String.IsNullOrWhiteSpace(txtcontraseña.Text) Then
            MsgBox("Complete todos los campos", MsgBoxStyle.Critical)
        Else
            If (objNusuario.Verificar_Usuario(txtusuario.Text, txtcontraseña.Text)) Then
                user_login = (objNusuario.Verificar_Perfil(txtusuario.Text, txtcontraseña.Text))
                Select Case user_login.id_perfil
                    Case 1
                        Dim menu As MenuAdmin = New MenuAdmin(user_login)
                        menu.Show()
                        btncontraseña.Text = "Ver"
                        txtcontraseña.PasswordChar = "*"
                    Case 2
                        Dim menu As MenuGerenteSupervisor = New MenuGerenteSupervisor(user_login)
                        menu.Show()
                        btncontraseña.Text = "Ver"
                        txtcontraseña.PasswordChar = "*"
                    Case 3
                        Dim menu As MenuSupervisor = New MenuSupervisor(user_login)
                        menu.Show()
                        btncontraseña.Text = "Ver"
                        txtcontraseña.PasswordChar = "*"
                    Case 4
                        Dim menu As MenuVendedor = New MenuVendedor(user_login)
                        menu.Show()
                        btncontraseña.Text = "Ver"
                        txtcontraseña.PasswordChar = "*"
                    Case Else
                        MsgBox("Error Fatal. Contacte al administrador de Base de Datos", MsgBoxStyle.Critical, "Error de inicio de sesión")
                        Exit Sub
                End Select
                txtusuario.Clear()
                txtcontraseña.Clear()
                MsgBox("Bienvenido al sistema", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
            Else
                MsgBox("La contraseña es incorrecta o el usuario no está registrado", MsgBoxStyle.Critical)
                alerta += 1
                If alerta = 4 Then
                    MsgBox("Ha ingresado datos incorrectamente muchas veces, la aplicación se cerrará")
                    Me.Close()
                End If

            End If
        End If
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

    Private Sub txtusuario_GotFocus(sender As Object, e As EventArgs) Handles txtusuario.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub txtcontraseña_GotFocus(sender As Object, e As EventArgs) Handles txtcontraseña.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub btnAcerca_Click(sender As Object, e As EventArgs) Handles btnAcerca.Click
        MsgBox("Diseñado y Desarrollado por:
Sena Nicolás Ariel y Bartoloni Gianfranco
-----------------------------------------
Supervisado por: Alfonso Pedro
UNNE - FACENA - Taller De Programación II - 2021
----------------------------------------
Contactos:
nicosena10@gmail.com
giianzitow@gmail.com", MsgBoxStyle.Information, "Acerca de Nosotros")
    End Sub
End Class