Imports System.Windows.Forms
Imports System.ComponentModel


Public Class MenuGerenteSupervisor

    Private user_login As USUARIOS = New USUARIOS

    Public Sub New(ByVal aux_user_login As USUARIOS)

        InitializeComponent()
        user_login = aux_user_login

    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Hola " + user_login.apellido + " " + CStr(user_login.DNI))
    End Sub

    Private Sub ReporteDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentasToolStripMenuItem.Click
        Dim ReporteIngresos As ReporteDeIngresos = New ReporteDeIngresos
        ReporteIngresos.ShowDialog()
    End Sub

    Private Sub ListadoDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeVentasToolStripMenuItem.Click
        Dim ListadoVentas As ListadoDeVentas = New ListadoDeVentas
        ListadoVentas.ShowDialog()
    End Sub

    Private Sub VentasProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasProductosToolStripMenuItem.Click
        Dim VentasProductos As VentasProductos = New VentasProductos
        VentasProductos.ShowDialog()
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
End Class