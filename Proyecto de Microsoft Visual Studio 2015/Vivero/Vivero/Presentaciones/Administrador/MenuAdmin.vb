Imports System.Windows.Forms

Public Class MenuAdmin

    Private user_login As USUARIOS = New USUARIOS

    Public Sub New(ByVal aux_user_login As USUARIOS)

        InitializeComponent()
        user_login = aux_user_login

    End Sub

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub AltaDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeUsuarioToolStripMenuItem.Click
        Dim usuario1 As AltaUsuario = New AltaUsuario
        usuario1.ShowDialog()

    End Sub

    Private Sub ModificarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarUsuarioToolStripMenuItem.Click
        Dim usuario2 As ModificarUsuario = New ModificarUsuario
        usuario2.ShowDialog()
    End Sub

    Private Sub BajaDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaDeUsuarioToolStripMenuItem.Click
        Dim usuario3 As BajaUsuario = New BajaUsuario(user_login)
        usuario3.ShowDialog()
    End Sub

    Private Sub BackUPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackUPToolStripMenuItem.Click
        Dim usuario6 As Backup = New Backup
        usuario6.ShowDialog()
    End Sub

    Private Sub MostrarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarUsuariosToolStripMenuItem.Click
        Dim usuario5 As MuestraUsuarios = New MuestraUsuarios
        usuario5.ShowDialog()
    End Sub

    Private Sub UsuariosInactivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosInactivosToolStripMenuItem.Click
        Dim usuario4 As UsuariosInactivos = New UsuariosInactivos
        usuario4.ShowDialog()
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

    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        MsgBox("Hola " + user_login.apellido + " " + CStr(user_login.DNI))
    End Sub
End Class