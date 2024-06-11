Imports System.Windows.Forms

Public Class MenuSupervisor

    Private user_login As USUARIOS = New USUARIOS

    Public Sub New(ByVal aux_user_login As USUARIOS)

        InitializeComponent()
        user_login = aux_user_login

    End Sub

    Private Sub AltaDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeProductosToolStripMenuItem.Click
        Dim supervisor1 As AltaDeProducto = New AltaDeProducto
        supervisor1.ShowDialog()
    End Sub

    Private Sub ModificarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarProductosToolStripMenuItem.Click
        Dim supervisor2 As ModificarProductos = New ModificarProductos
        supervisor2.ShowDialog()
    End Sub

    Private Sub BajaDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaDeProductosToolStripMenuItem.Click
        Dim supervisor3 As BajaDeProducto = New BajaDeProducto
        supervisor3.ShowDialog()
    End Sub

    Private Sub MostrarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarProductosToolStripMenuItem.Click
        Dim supervisor4 As MostrarProductos = New MostrarProductos
        supervisor4.ShowDialog()
    End Sub

    Private Sub ProductosInactivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosInactivosToolStripMenuItem.Click
        Dim supervisor5 As ProductosInactivos = New ProductosInactivos
        supervisor5.ShowDialog()
    End Sub

    Private Sub BajaDeCLientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaDeCLientesToolStripMenuItem.Click
        Dim supervisor6 As BajaDeCliente = New BajaDeCliente
        supervisor6.ShowDialog()
    End Sub

    Private Sub ClientesInactivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesInactivosToolStripMenuItem.Click
        Dim supervisor7 As ClientesInactivos = New ClientesInactivos
        supervisor7.ShowDialog()
    End Sub

    Private Sub ReporteDeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentasToolStripMenuItem.Click
        Dim reportestock As ReporteStock = New ReporteStock
        reportestock.ShowDialog()
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

    Private Sub AltaDeCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeCategoriaToolStripMenuItem.Click
        Dim supervisor10 As AltaDeCategoria = New AltaDeCategoria
        supervisor10.ShowDialog()
    End Sub

    Private Sub ModificarCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarCategoriaToolStripMenuItem.Click
        Dim supervisor11 As ModificarCategoria = New ModificarCategoria
        supervisor11.ShowDialog()
    End Sub

    Private Sub BajaDeCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaDeCategoriaToolStripMenuItem.Click
        Dim supervisor12 As BajaDeCategoria = New BajaDeCategoria
        supervisor12.ShowDialog()
    End Sub

    Private Sub MenuSupervisor_Load(sender As Object, e As EventArgs) Handles Me.Load
        MsgBox("Hola " + user_login.apellido + " " + CStr(user_login.DNI))
    End Sub
End Class
