<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuVendedor
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.AgregarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarVentaToolStripMenuItem, Me.ListarVentasToolStripMenuItem, Me.AltaClienteToolStripMenuItem, Me.ModificarClienteToolStripMenuItem, Me.ListarClientesToolStripMenuItem, Me.ListarProductosToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(694, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'AgregarVentaToolStripMenuItem
        '
        Me.AgregarVentaToolStripMenuItem.Name = "AgregarVentaToolStripMenuItem"
        Me.AgregarVentaToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.AgregarVentaToolStripMenuItem.Text = "Agregar venta"
        '
        'ListarVentasToolStripMenuItem
        '
        Me.ListarVentasToolStripMenuItem.Name = "ListarVentasToolStripMenuItem"
        Me.ListarVentasToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ListarVentasToolStripMenuItem.Text = "Listar ventas"
        '
        'AltaClienteToolStripMenuItem
        '
        Me.AltaClienteToolStripMenuItem.Name = "AltaClienteToolStripMenuItem"
        Me.AltaClienteToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.AltaClienteToolStripMenuItem.Text = "Alta cliente"
        '
        'ModificarClienteToolStripMenuItem
        '
        Me.ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem"
        Me.ModificarClienteToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.ModificarClienteToolStripMenuItem.Text = "Modificar cliente"
        '
        'ListarClientesToolStripMenuItem
        '
        Me.ListarClientesToolStripMenuItem.Name = "ListarClientesToolStripMenuItem"
        Me.ListarClientesToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ListarClientesToolStripMenuItem.Text = "Listar clientes"
        '
        'ListarProductosToolStripMenuItem
        '
        Me.ListarProductosToolStripMenuItem.Name = "ListarProductosToolStripMenuItem"
        Me.ListarProductosToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.ListarProductosToolStripMenuItem.Text = "Listar productos"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'MenuVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vivero.My.Resources.Resources.plantas_ilustraciones_senor_gato_19c3baff_1200x630
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(694, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MenuVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuVendedor"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents AgregarVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
End Class
