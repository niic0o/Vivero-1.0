
Imports System.ComponentModel
Public Class SeleccionarCliente
    Dim objNcliente As N_CLIENTES = New N_CLIENTES
    Public cliente_selected As CLIENTES = New CLIENTES

    Dim p_id As Integer
    Dim p_ape As String
    Dim p_nom As String
    Dim p_dni As Integer
    Dim p_email As String
    Dim p_tel As String
    Dim p_dir As String
    Dim p_prov As String
    Dim p_loc As String

    Public Sub New(ByVal aux_cliente_selected As CLIENTES)
        InitializeComponent()
        cliente_selected = aux_cliente_selected
    End Sub

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

    Private Sub btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        If DataGridView_Clientes.SelectedRows.Count = 0 Then
            MsgBox("Haga click en un item", MsgBoxStyle.Information, "Seleccione un cliente de la tabla")
        Else
            objNcliente.cargarGrid(DataGridView_Clientes)
            MsgBox("Cliente: " + p_ape + " " + p_nom, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MessageBoxIcon.Information)
            cliente_selected.id_cliente = p_id
            cliente_selected.apellido = p_ape
            cliente_selected.nombre = p_nom
            cliente_selected.DNI = p_dni
            cliente_selected.email = p_email
            cliente_selected.telefono = p_tel
            cliente_selected.direccion = p_dir
            cliente_selected.provincia = p_prov
            cliente_selected.localidad = p_loc
            Me.Close()
        End If

    End Sub

    Private Sub MuestraUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        objNcliente.cargarGrid(DataGridView_Clientes)
        Label_select.Text = " "
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

    Private Sub DataGridView_Clientes_Click(sender As Object, e As EventArgs) Handles DataGridView_Clientes.Click
        Dim FilaActual As Integer
        If DataGridView_Clientes.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        FilaActual = DataGridView_Clientes.CurrentRow.Index
        p_id = DataGridView_Clientes.Rows(FilaActual).Cells("id_cliente").Value
        p_ape = DataGridView_Clientes.Rows(FilaActual).Cells("apellido").Value
        p_nom = DataGridView_Clientes.Rows(FilaActual).Cells("nombre").Value
        p_dni = DataGridView_Clientes.Rows(FilaActual).Cells("dni").Value
        p_email = DataGridView_Clientes.Rows(FilaActual).Cells("email").Value
        p_tel = DataGridView_Clientes.Rows(FilaActual).Cells("telefono").Value
        p_dir = DataGridView_Clientes.Rows(FilaActual).Cells("direccion").Value
        p_prov = DataGridView_Clientes.Rows(FilaActual).Cells("provincia").Value
        p_loc = DataGridView_Clientes.Rows(FilaActual).Cells("localidad").Value
        Label_select.Text = p_ape + " " + p_nom
    End Sub
End Class
