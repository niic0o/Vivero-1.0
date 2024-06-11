<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdmin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.AltaDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosInactivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeUsuarioToolStripMenuItem, Me.ModificarUsuarioToolStripMenuItem, Me.BajaDeUsuarioToolStripMenuItem, Me.BackUPToolStripMenuItem, Me.MostrarUsuariosToolStripMenuItem, Me.UsuariosInactivosToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(753, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'AltaDeUsuarioToolStripMenuItem
        '
        Me.AltaDeUsuarioToolStripMenuItem.Name = "AltaDeUsuarioToolStripMenuItem"
        Me.AltaDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.AltaDeUsuarioToolStripMenuItem.Text = "Alta de Usuario"
        '
        'ModificarUsuarioToolStripMenuItem
        '
        Me.ModificarUsuarioToolStripMenuItem.Name = "ModificarUsuarioToolStripMenuItem"
        Me.ModificarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.ModificarUsuarioToolStripMenuItem.Text = "Modificar Usuario"
        '
        'BajaDeUsuarioToolStripMenuItem
        '
        Me.BajaDeUsuarioToolStripMenuItem.Name = "BajaDeUsuarioToolStripMenuItem"
        Me.BajaDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.BajaDeUsuarioToolStripMenuItem.Text = "Baja de Usuario"
        '
        'BackUPToolStripMenuItem
        '
        Me.BackUPToolStripMenuItem.Name = "BackUPToolStripMenuItem"
        Me.BackUPToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.BackUPToolStripMenuItem.Text = "BackUP"
        '
        'MostrarUsuariosToolStripMenuItem
        '
        Me.MostrarUsuariosToolStripMenuItem.Name = "MostrarUsuariosToolStripMenuItem"
        Me.MostrarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.MostrarUsuariosToolStripMenuItem.Text = "Listar Usuarios"
        '
        'UsuariosInactivosToolStripMenuItem
        '
        Me.UsuariosInactivosToolStripMenuItem.Name = "UsuariosInactivosToolStripMenuItem"
        Me.UsuariosInactivosToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.UsuariosInactivosToolStripMenuItem.Text = "Usuarios Inactivos"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vivero.My.Resources.Resources.plantas_ilustraciones_senor_gato_19c3baff_1200x630
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(753, 504)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MenuAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuAdmin"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents AltaDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackUPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosInactivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
End Class
