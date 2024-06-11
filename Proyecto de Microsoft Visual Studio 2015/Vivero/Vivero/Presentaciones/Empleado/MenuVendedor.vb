Imports System.Windows.Forms
Imports System.ComponentModel

Public Class MenuVendedor

    Private user_login As USUARIOS = New USUARIOS

    Public Sub New(ByVal aux_user_login As USUARIOS)

        InitializeComponent()
        user_login = aux_user_login

    End Sub

    Private Sub AgregarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarVentaToolStripMenuItem.Click
        Dim objeto_AgregarVenta As AgregarVenta = New AgregarVenta(user_login)
        objeto_AgregarVenta.ShowDialog()
    End Sub

    Private Sub ListarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarVentasToolStripMenuItem.Click
        Dim objeto_MisVentas As MisVentas = New MisVentas(user_login)
        objeto_MisVentas.ShowDialog()
    End Sub

    Private Sub AltaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaClienteToolStripMenuItem.Click
        Dim vendedor1 As AltaCliente = New AltaCliente
        vendedor1.ShowDialog()
    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarClienteToolStripMenuItem.Click
        Dim vendedor2 As ModificarCliente = New ModificarCliente
        vendedor2.ShowDialog()
    End Sub

    Private Sub ListarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarClientesToolStripMenuItem.Click
        Dim vendedor4 As MostrarCliente = New MostrarCliente
        vendedor4.ShowDialog()
    End Sub

    Private Sub ListarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarProductosToolStripMenuItem.Click
        Dim vendedor6 As VerProductos = New VerProductos
        vendedor6.ShowDialog()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("¿Cerrar sesion?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question)
        If MsgBoxResult.Yes = ask Then
            Me.Close()
            Login.Show()
            Login.txtusuario.Clear()
            Login.txtcontraseña.Clear()
        End If
    End Sub

    Private Sub MenuVendedor_Load(sender As Object, e As EventArgs) Handles Me.Load
        MsgBox("Hola " + user_login.apellido + " " + CStr(user_login.DNI))
    End Sub
End Class