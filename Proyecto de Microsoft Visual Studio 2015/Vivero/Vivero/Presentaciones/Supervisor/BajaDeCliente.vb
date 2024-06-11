
Public Class BajaDeCliente

    Dim objNcliente As N_CLIENTES = New N_CLIENTES
    Dim id_cliente As Integer = 0

    Private Sub txtapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido.KeyPress
        'Solo Letras
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

    Private Sub txtdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress
        'Solo numeros
        txtdni.MaxLength() = 8
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            ErrorSoloNumeros.Clear()
        Else
            e.Handled = True
            ErrorSoloNumeros.SetError(txtdni, "Solo numeros")
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Haga click en un item", MsgBoxStyle.Information, "Seleccione un cliente")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("¿Dar de baja al cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then
                If objNcliente.borrar_cliente(id_cliente) Then
                    MsgBox("El cliente se dio de baja correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
                Else
                    MsgBox("Ya está eliminado!", MsgBoxStyle.Exclamation, "Error")
                End If
            End If
            objNcliente.cargarGrid(DataGridView1)
            txtdni.Clear()
            txtapellido.Clear()
            lbl_cliente.Text = " "
        End If
    End Sub

    Private Sub txtapellido_GotFocus(sender As Object, e As EventArgs) Handles txtapellido.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub txtdni_GotFocus(sender As Object, e As EventArgs) Handles txtdni.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub BajaDeCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        objNcliente.cargarGrid(DataGridView1)
        lbl_cliente.Text = " "
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim aux_apellido As String = " "
        Dim aux_nombre As String = " "
        id_cliente = 0
        Dim FilaActual As Integer
        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        FilaActual = DataGridView1.CurrentRow.Index
        id_cliente = DataGridView1.Rows(FilaActual).Cells("id_cliente").Value
        aux_nombre = DataGridView1.Rows(FilaActual).Cells("nombre").Value
        aux_apellido = DataGridView1.Rows(FilaActual).Cells("apellido").Value
        lbl_cliente.Text = aux_apellido + " " + aux_nombre
    End Sub

    Private Sub txtapellido_TextChanged(sender As Object, e As EventArgs) Handles txtapellido.TextChanged
        objNcliente.BuscarNombre1(txtapellido.Text, DataGridView1)
    End Sub

    Private Sub txtdni_TextChanged(sender As Object, e As EventArgs) Handles txtdni.TextChanged
        Dim aux_dni As Integer = 0
        If txtdni.Text = "" Or txtdni.Text = " " Then
            Exit Sub
        Else
            aux_dni = CInt(txtdni.Text)
        End If
        objNcliente.BuscarDNI1(aux_dni, DataGridView1)
    End Sub

End Class
