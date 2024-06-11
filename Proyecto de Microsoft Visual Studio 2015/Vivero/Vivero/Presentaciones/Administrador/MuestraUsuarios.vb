
Public Class MuestraUsuarios

    Dim objNusuario = New N_USUARIOS

    Private Sub txtbuscardni_GotFocus(sender As Object, e As EventArgs) Handles txtbdni.GotFocus
        Clipboard.Clear()
    End Sub
    Private Sub txtbuscarnombre_GotFocus(sender As Object, e As EventArgs) Handles txtbapellido.GotFocus
        Clipboard.Clear()
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

    Private Sub txtbuscarpordni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbdni.KeyPress
        txtbdni.MaxLength() = 8
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            ErrorSoloNumeros.Clear()
        Else
            e.Handled = True
            ErrorSoloNumeros.SetError(txtbdni, "Solo numeros")
        End If
    End Sub

    Private Sub txtbuscardni_LostFocus(sender As Object, e As EventArgs) Handles txtbdni.LostFocus
        If Val(txtbdni.Text) = False Then
            ErrorSoloNumeros.SetError(txtbdni, "Solo numeros")
            txtbdni.Clear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        objNusuario.cargarGrid(DataGridView_Usuarios)
        MsgBox("Listado actualizado", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
    End Sub

    Private Sub MuestraUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        objNusuario.cargarGrid(DataGridView_Usuarios)
    End Sub

    Private Sub txtbape_TextChanged(sender As Object, e As EventArgs) Handles txtbapellido.TextChanged
        objNusuario.BuscarNombre1(txtbapellido.Text, DataGridView_Usuarios)
    End Sub

    Private Sub txtbdni_TextChanged(sender As Object, e As EventArgs) Handles txtbdni.TextChanged
        Dim aux_dni As Integer = 0
        If txtbdni.Text = "" Or txtbdni.Text = " " Then
            Exit Sub
        Else
            aux_dni = CInt(txtbdni.Text)
        End If
        objNusuario.BuscarDNI1(aux_dni, DataGridView_Usuarios)

    End Sub

    'Private Sub DataGridView_Usuarios_RowValidated(sender As Object, e As 'DataGridViewCellEventArgs) Handles DataGridView_Usuarios.RowValidated
    'If DataGridView_Usuarios.Rows.Count > 0 Then
    'For Each Fila As DataGridViewRow In DataGridView_Usuarios.Rows
    'If Not Fila Is Nothing Then
    'If Fila.Cells("eliminado").Value = "SI" Then
    '        DataGridView_Usuarios.RowsDefaultCellStyle.ForeColor = Color.Red
    '      End If
    'End If
    'Next
    'End If
    ' End Sub
End Class
