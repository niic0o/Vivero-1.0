Imports System.Text.RegularExpressions
Public Class UsuariosInactivos

    Dim objNusuario As N_USUARIOS = New N_USUARIOS
    Dim id_perfil As Integer = 0
    Dim id_usuario As Integer = 0
    Dim aux_apellido As String = " "
    Dim aux_nombre As String = " "

    Private Sub txtbuscarpornombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuscarpornombre.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            ErrorSoloLetras.Clear()
        Else
            e.Handled = True
            ErrorSoloLetras.SetError(txtbuscarpornombre, "Solo letras")
        End If
    End Sub

    Private Sub txtbuscarponombre_GotFocus(sender As Object, e As EventArgs) Handles txtbuscarpornombre.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub txtbuscarpornombre_LostFocus(sender As Object, e As EventArgs) Handles txtbuscarpornombre.LostFocus
        Dim cadena As String = txtbuscarpornombre.Text()
        Dim nueva_cadena As String = StrConv(cadena, VbStrConv.ProperCase)
        txtbuscarpornombre.Text() = nueva_cadena
    End Sub

    Private Sub txtbuscarpordni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuscarpordni.KeyPress
        txtbuscarpordni.MaxLength() = 8
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            ErrorSoloNumeros.Clear()
        Else
            e.Handled = True
            ErrorSoloNumeros.SetError(txtbuscarpordni, "Solo numeros")
        End If
    End Sub

    Private Sub txtbuscardni_LostFocus(sender As Object, e As EventArgs) Handles txtbuscarpordni.LostFocus
        If Val(txtbuscarpordni.Text) = False Then
            ErrorSoloNumeros.SetError(txtbuscarpordni, "Solo numeros")
            txtbuscarpordni.Clear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnactivar_Click(sender As Object, e As EventArgs) Handles btnactivar.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Haga click en un item", MsgBoxStyle.Information, "Seleccione un usuario eliminado")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("¿Desea activar al usuario " + aux_apellido + " " + aux_nombre + "?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then
                If objNusuario.activar_usuario(id_perfil, id_usuario) Then
                    MsgBox("El usuario se activó correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
                Else
                    MsgBox("Ese usuario ya esta activo", MsgBoxStyle.Critical,
                           "Error")
                End If
            End If
            objNusuario.cargarGrid_inactivos(DataGridView1)
            txtbuscarpordni.Clear()
            txtbuscarpornombre.Clear()
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        MsgBox("Listado actualizado", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
        objNusuario.cargarGrid_inactivos(DataGridView1)
    End Sub

    Private Sub UsuariosInactivos_Load(sender As Object, e As EventArgs) Handles Me.Load
        objNusuario.cargarGrid_inactivos(DataGridView1)
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        id_perfil = 0
        id_usuario = 0
        Dim FilaActual As Integer
        'controlo que CurrentRow no genere una null exception al no tener valor Index
        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        FilaActual = DataGridView1.CurrentRow.Index
        id_perfil = DataGridView1.Rows(FilaActual).Cells("id_perfil").Value
        id_usuario = DataGridView1.Rows(FilaActual).Cells("id_usuario").Value
        aux_nombre = DataGridView1.Rows(FilaActual).Cells("nombre").Value
        aux_apellido = DataGridView1.Rows(FilaActual).Cells("apellido").Value
    End Sub

    Private Sub txtbuscarpornombre_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarpornombre.TextChanged
        objNusuario.BuscarNombre1_inactivos(txtbuscarpornombre.Text, DataGridView1)
    End Sub

    Private Sub txtbuscarpordni_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarpordni.TextChanged
        Dim aux_dni As Integer = 0
        If txtbuscarpordni.Text = "" Or txtbuscarpordni.Text = " " Then
            Exit Sub
        Else
            aux_dni = CInt(txtbuscarpordni.Text)
        End If
        objNusuario.BuscarDNI1_inactivos(aux_dni, DataGridView1)
    End Sub
End Class
