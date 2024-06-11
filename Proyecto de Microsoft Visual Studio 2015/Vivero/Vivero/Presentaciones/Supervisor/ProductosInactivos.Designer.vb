<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductosInactivos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CboCategoria = New System.Windows.Forms.ComboBox()
        Me.txtbcod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnactivar = New System.Windows.Forms.Button()
        Me.ErrorSoloNumeros = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSoloNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Lista de productos Inactivos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.CboCategoria)
        Me.Panel1.Controls.Add(Me.txtbcod)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(180, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 504)
        Me.Panel1.TabIndex = 26
        '
        'CboCategoria
        '
        Me.CboCategoria.FormattingEnabled = True
        Me.CboCategoria.Items.AddRange(New Object() {"Plantas", "Semillas", "Jardineria", "Abonos"})
        Me.CboCategoria.Location = New System.Drawing.Point(419, 54)
        Me.CboCategoria.Name = "CboCategoria"
        Me.CboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.CboCategoria.TabIndex = 33
        '
        'txtbcod
        '
        Me.txtbcod.Location = New System.Drawing.Point(161, 53)
        Me.txtbcod.Name = "txtbcod"
        Me.txtbcod.Size = New System.Drawing.Size(100, 20)
        Me.txtbcod.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(298, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Busqueda por Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Busqueda por Codigo:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(565, 403)
        Me.DataGridView1.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Vivero.My.Resources.Resources.logovivero2
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(181, 580)
        Me.Panel2.TabIndex = 27
        '
        'btnactualizar
        '
        Me.btnactualizar.Image = Global.Vivero.My.Resources.Resources.actualizado
        Me.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnactualizar.Location = New System.Drawing.Point(541, 538)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(89, 42)
        Me.btnactualizar.TabIndex = 25
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btnactivar
        '
        Me.btnactivar.Image = Global.Vivero.My.Resources.Resources.vcsnormal_93488__1_
        Me.btnactivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnactivar.Location = New System.Drawing.Point(315, 538)
        Me.btnactivar.Name = "btnactivar"
        Me.btnactivar.Size = New System.Drawing.Size(124, 42)
        Me.btnactivar.TabIndex = 24
        Me.btnactivar.Text = "Activar producto"
        Me.btnactivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnactivar.UseVisualStyleBackColor = True
        '
        'ErrorSoloNumeros
        '
        Me.ErrorSoloNumeros.ContainerControl = Me
        '
        'ProductosInactivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(765, 581)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnactivar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ProductosInactivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductosInactivos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSoloNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnactivar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ErrorSoloNumeros As ErrorProvider
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CboCategoria As ComboBox
    Friend WithEvents txtbcod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
