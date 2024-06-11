Public Class BajaUsuario

    Dim objNusuario As N_USUARIOS = New N_USUARIOS
    Dim id_usuario As Integer = 0
    Dim id_perfil As Integer = 0

    Private user_login As USUARIOS = New USUARIOS

    Public Sub New(ByVal aux_user_login As USUARIOS)

        InitializeComponent()
        user_login = aux_user_login

    End Sub

    Private Sub txtbuscarpornombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuscarpornombre.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            ErrorSoloLetras.Clear()
        Else
            e.Handled = True
            ErrorSoloLetras.SetError(txtbuscarpornombre, "Solo letras")
        End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Haga click en un item", MsgBoxStyle.Information, "Seleccione un cliente")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("¿Dar de baja al usuario?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MessageBoxIcon.Question)
            If MsgBoxResult.Yes = ask Then
                If user_login.id_usuario = id_usuario Then
                    MsgBox("No puede darse de baja así mismo", MsgBoxStyle.Critical, "Error")
                    Me.Close()
                    Exit Sub
                End If
                If objNusuario.borrar_usuario(id_perfil, id_usuario) Then
                    MsgBox("El usuario se dio de baja correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
                Else
                    MsgBox("Ya está eliminado!", MsgBoxStyle.Exclamation, "Error")
                End If
            End If
            objNusuario.cargarGrid(DataGridView1)
            txtbuscarpordni.Clear()
            txtbuscarpornombre.Clear()
            lbl_usuario.Text = " "
        End If
    End Sub

    Private Sub txtbuscarpordni_GotFocus(sender As Object, e As EventArgs) Handles txtbuscarpordni.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub txtbuscarponombre_GotFocus(sender As Object, e As EventArgs) Handles txtbuscarpornombre.GotFocus
        Clipboard.Clear()
    End Sub

    Private Sub txtbuscarpornombre_LostFocus(sender As Object, e As EventArgs) Handles txtbuscarpornombre.LostFocus
        Dim cadena As String = txtbuscarpornombre.Text()
        Dim nueva_cadena As String = StrConv(cadena, VbStrConv.ProperCase)
        txtbuscarpornombre.Text() = nueva_cadena
    End Sub

    Private Sub BajaUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        objNusuario.cargarGrid(DataGridView1)
        lbl_usuario.Text = " "
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim aux_apellido As String = " "
        Dim aux_nombre As String = " "
        id_perfil = 0
        id_usuario = 0
        Dim FilaActual As Integer
        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        FilaActual = DataGridView1.CurrentRow.Index
        id_perfil = DataGridView1.Rows(FilaActual).Cells("id_perfil").Value
        id_usuario = DataGridView1.Rows(FilaActual).Cells("id_usuario").Value
        aux_nombre = DataGridView1.Rows(FilaActual).Cells("nombre").Value
        aux_apellido = DataGridView1.Rows(FilaActual).Cells("apellido").Value
        lbl_usuario.Text = aux_apellido + " " + aux_nombre
    End Sub

    Private Sub txtbuscarpornombre_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarpornombre.TextChanged
        objNusuario.BuscarNombre1(txtbuscarpornombre.Text, DataGridView1)
    End Sub

    Private Sub txtbuscarpordni_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarpordni.TextChanged
        Dim aux_dni As Integer = 0
        If txtbuscarpordni.Text = "" Or txtbuscarpordni.Text = " " Then
            Exit Sub
        Else
            aux_dni = CInt(txtbuscarpordni.Text)
        End If
        objNusuario.BuscarDNI1(aux_dni, DataGridView1)
    End Sub
End Class
