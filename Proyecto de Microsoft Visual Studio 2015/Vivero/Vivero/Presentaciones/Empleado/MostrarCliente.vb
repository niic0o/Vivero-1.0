
Imports System.ComponentModel
Public Class MostrarCliente
    Dim objNcliente = New N_CLIENTES

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
        objNcliente.cargarGrid(DataGridView_Clientes)
        MsgBox("Listado actualizado", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
    End Sub

    Private Sub MuestraUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        objNcliente.cargarGrid(DataGridView_Clientes)
    End Sub

    Private Sub txtbape_TextChanged(sender As Object, e As EventArgs) Handles txtbapellido.TextChanged
        objNcliente.BuscarNombre1(txtbapellido.Text, DataGridView_Clientes)
    End Sub

    Private Sub txtbdni_TextChanged(sender As Object, e As EventArgs) Handles txtbdni.TextChanged
        Dim aux_dni As Integer = 0
        If txtbdni.Text = "" Or txtbdni.Text = " " Then
            Exit Sub
        Else
            aux_dni = CInt(txtbdni.Text)
        End If
        objNcliente.BuscarDNI1(aux_dni, DataGridView_Clientes)

    End Sub


End Class
