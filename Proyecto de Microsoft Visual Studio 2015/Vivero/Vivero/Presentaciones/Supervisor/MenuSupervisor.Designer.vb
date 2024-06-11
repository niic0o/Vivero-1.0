<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuSupervisor
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
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosInactivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaDeCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaDeCLientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesInactivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.CategoriasToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ReporteDeVentasToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(900, 23)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeProductosToolStripMenuItem, Me.ModificarProductosToolStripMenuItem, Me.BajaDeProductosToolStripMenuItem, Me.MostrarProductosToolStripMenuItem, Me.ProductosInactivosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 19)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'AltaDeProductosToolStripMenuItem
        '
        Me.AltaDeProductosToolStripMenuItem.Name = "AltaDeProductosToolStripMenuItem"
        Me.AltaDeProductosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AltaDeProductosToolStripMenuItem.Text = "Alta de Productos"
        '
        'ModificarProductosToolStripMenuItem
        '
        Me.ModificarProductosToolStripMenuItem.Name = "ModificarProductosToolStripMenuItem"
        Me.ModificarProductosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ModificarProductosToolStripMenuItem.Text = "Modificar Productos"
        '
        'BajaDeProductosToolStripMenuItem
        '
        Me.BajaDeProductosToolStripMenuItem.Name = "BajaDeProductosToolStripMenuItem"
        Me.BajaDeProductosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.BajaDeProductosToolStripMenuItem.Text = "Baja de Productos"
        '
        'MostrarProductosToolStripMenuItem
        '
        Me.MostrarProductosToolStripMenuItem.Name = "MostrarProductosToolStripMenuItem"
        Me.MostrarProductosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.MostrarProductosToolStripMenuItem.Text = "Mostrar Productos"
        '
        'ProductosInactivosToolStripMenuItem
        '
        Me.ProductosInactivosToolStripMenuItem.Name = "ProductosInactivosToolStripMenuItem"
        Me.ProductosInactivosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ProductosInactivosToolStripMenuItem.Text = "Productos Inactivos"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeCategoriaToolStripMenuItem, Me.ModificarCategoriaToolStripMenuItem, Me.BajaDeCategoriaToolStripMenuItem})
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(75, 19)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'AltaDeCategoriaToolStripMenuItem
        '
        Me.AltaDeCategoriaToolStripMenuItem.Name = "AltaDeCategoriaToolStripMenuItem"
        Me.AltaDeCategoriaToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AltaDeCategoriaToolStripMenuItem.Text = "Alta De Categorias"
        '
        'ModificarCategoriaToolStripMenuItem
        '
        Me.ModificarCategoriaToolStripMenuItem.Name = "ModificarCategoriaToolStripMenuItem"
        Me.ModificarCategoriaToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ModificarCategoriaToolStripMenuItem.Text = "Modificar Categorias"
        '
        'BajaDeCategoriaToolStripMenuItem
        '
        Me.BajaDeCategoriaToolStripMenuItem.Name = "BajaDeCategoriaToolStripMenuItem"
        Me.BajaDeCategoriaToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.BajaDeCategoriaToolStripMenuItem.Text = "Eliminar Categorias"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaDeCLientesToolStripMenuItem, Me.ClientesInactivosToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 19)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'BajaDeCLientesToolStripMenuItem
        '
        Me.BajaDeCLientesToolStripMenuItem.Name = "BajaDeCLientesToolStripMenuItem"
        Me.BajaDeCLientesToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.BajaDeCLientesToolStripMenuItem.Text = "Baja de Clientes"
        '
        'ClientesInactivosToolStripMenuItem
        '
        Me.ClientesInactivosToolStripMenuItem.Name = "ClientesInactivosToolStripMenuItem"
        Me.ClientesInactivosToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ClientesInactivosToolStripMenuItem.Text = "Clientes Inactivos"
        '
        'ReporteDeVentasToolStripMenuItem
        '
        Me.ReporteDeVentasToolStripMenuItem.Name = "ReporteDeVentasToolStripMenuItem"
        Me.ReporteDeVentasToolStripMenuItem.Size = New System.Drawing.Size(108, 19)
        Me.ReporteDeVentasToolStripMenuItem.Text = "Reporte de Stock"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(88, 19)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'MenuSupervisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vivero.My.Resources.Resources.plantas_ilustraciones_senor_gato_19c3baff_1200x630
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(900, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "MenuSupervisor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuSupervisor"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaDeCLientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesInactivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosInactivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaDeCategoriaToolStripMenuItem As ToolStripMenuItem
End Class
