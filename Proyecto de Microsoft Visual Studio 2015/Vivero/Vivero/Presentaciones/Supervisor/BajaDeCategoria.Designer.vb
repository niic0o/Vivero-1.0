<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BajaDeCategoria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnActivarCategoria = New System.Windows.Forms.Button()
        Me.btnEliminarCategoria = New System.Windows.Forms.Button()
        Me.DataGridView_Categoria = New System.Windows.Forms.DataGridView()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblTitulo1 = New System.Windows.Forms.Label()
        Me.btnEliminarSubTipo = New System.Windows.Forms.Panel()
        Me.btnActivarTipo = New System.Windows.Forms.Button()
        Me.btnEliminarTipo = New System.Windows.Forms.Button()
        Me.DataGridView_Tipo = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_Categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnEliminarSubTipo.SuspendLayout()
        CType(Me.DataGridView_Tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Vivero.My.Resources.Resources.logovivero2
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(2, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(178, 567)
        Me.Panel2.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.btnActivarCategoria)
        Me.Panel1.Controls.Add(Me.btnEliminarCategoria)
        Me.Panel1.Controls.Add(Me.DataGridView_Categoria)
        Me.Panel1.Controls.Add(Me.txtCategoria)
        Me.Panel1.Controls.Add(Me.lblCategoria)
        Me.Panel1.Controls.Add(Me.lblTitulo1)
        Me.Panel1.Location = New System.Drawing.Point(186, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 300)
        Me.Panel1.TabIndex = 27
        '
        'btnActivarCategoria
        '
        Me.btnActivarCategoria.Image = Global.Vivero.My.Resources.Resources.vcsnormal_93488__1_
        Me.btnActivarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActivarCategoria.Location = New System.Drawing.Point(307, 251)
        Me.btnActivarCategoria.Name = "btnActivarCategoria"
        Me.btnActivarCategoria.Size = New System.Drawing.Size(88, 46)
        Me.btnActivarCategoria.TabIndex = 25
        Me.btnActivarCategoria.Text = "Activar"
        Me.btnActivarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActivarCategoria.UseVisualStyleBackColor = True
        '
        'btnEliminarCategoria
        '
        Me.btnEliminarCategoria.Image = Global.Vivero.My.Resources.Resources.ic_cancel_128_28318__1_
        Me.btnEliminarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarCategoria.Location = New System.Drawing.Point(188, 251)
        Me.btnEliminarCategoria.Name = "btnEliminarCategoria"
        Me.btnEliminarCategoria.Size = New System.Drawing.Size(88, 46)
        Me.btnEliminarCategoria.TabIndex = 17
        Me.btnEliminarCategoria.Text = "Eliminar"
        Me.btnEliminarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarCategoria.UseVisualStyleBackColor = True
        '
        'DataGridView_Categoria
        '
        Me.DataGridView_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Categoria.Location = New System.Drawing.Point(14, 70)
        Me.DataGridView_Categoria.Name = "DataGridView_Categoria"
        Me.DataGridView_Categoria.ReadOnly = True
        Me.DataGridView_Categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Categoria.Size = New System.Drawing.Size(549, 175)
        Me.DataGridView_Categoria.TabIndex = 16
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(96, 41)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(180, 20)
        Me.txtCategoria.TabIndex = 2
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(11, 44)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(55, 13)
        Me.lblCategoria.TabIndex = 1
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblTitulo1
        '
        Me.lblTitulo1.AutoSize = True
        Me.lblTitulo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo1.Location = New System.Drawing.Point(197, 8)
        Me.lblTitulo1.Name = "lblTitulo1"
        Me.lblTitulo1.Size = New System.Drawing.Size(136, 16)
        Me.lblTitulo1.TabIndex = 0
        Me.lblTitulo1.Text = "Eliminar Categoria"
        '
        'btnEliminarSubTipo
        '
        Me.btnEliminarSubTipo.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnEliminarSubTipo.Controls.Add(Me.btnActivarTipo)
        Me.btnEliminarSubTipo.Controls.Add(Me.btnEliminarTipo)
        Me.btnEliminarSubTipo.Controls.Add(Me.DataGridView_Tipo)
        Me.btnEliminarSubTipo.Controls.Add(Me.Label5)
        Me.btnEliminarSubTipo.Controls.Add(Me.txtTipo)
        Me.btnEliminarSubTipo.Controls.Add(Me.Label3)
        Me.btnEliminarSubTipo.Location = New System.Drawing.Point(186, 318)
        Me.btnEliminarSubTipo.Name = "btnEliminarSubTipo"
        Me.btnEliminarSubTipo.Size = New System.Drawing.Size(576, 299)
        Me.btnEliminarSubTipo.TabIndex = 29
        '
        'btnActivarTipo
        '
        Me.btnActivarTipo.Image = Global.Vivero.My.Resources.Resources.vcsnormal_93488__1_
        Me.btnActivarTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActivarTipo.Location = New System.Drawing.Point(307, 250)
        Me.btnActivarTipo.Name = "btnActivarTipo"
        Me.btnActivarTipo.Size = New System.Drawing.Size(88, 46)
        Me.btnActivarTipo.TabIndex = 27
        Me.btnActivarTipo.Text = "Activar"
        Me.btnActivarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActivarTipo.UseVisualStyleBackColor = True
        '
        'btnEliminarTipo
        '
        Me.btnEliminarTipo.Image = Global.Vivero.My.Resources.Resources.ic_cancel_128_28318__1_
        Me.btnEliminarTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarTipo.Location = New System.Drawing.Point(188, 250)
        Me.btnEliminarTipo.Name = "btnEliminarTipo"
        Me.btnEliminarTipo.Size = New System.Drawing.Size(88, 46)
        Me.btnEliminarTipo.TabIndex = 23
        Me.btnEliminarTipo.Text = "Eliminar"
        Me.btnEliminarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarTipo.UseVisualStyleBackColor = True
        '
        'DataGridView_Tipo
        '
        Me.DataGridView_Tipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Tipo.Location = New System.Drawing.Point(14, 63)
        Me.DataGridView_Tipo.Name = "DataGridView_Tipo"
        Me.DataGridView_Tipo.ReadOnly = True
        Me.DataGridView_Tipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Tipo.Size = New System.Drawing.Size(549, 178)
        Me.DataGridView_Tipo.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Tipo:"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(87, 37)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(189, 20)
        Me.txtTipo.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(232, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Eliminar Tipo"
        '
        'BajaDeCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 629)
        Me.Controls.Add(Me.btnEliminarSubTipo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BajaDeCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BajaDeCategoria"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView_Categoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnEliminarSubTipo.ResumeLayout(False)
        Me.btnEliminarSubTipo.PerformLayout()
        CType(Me.DataGridView_Tipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView_Categoria As DataGridView
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblTitulo1 As Label
    Friend WithEvents btnEliminarSubTipo As Panel
    Friend WithEvents DataGridView_Tipo As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEliminarCategoria As Button
    Friend WithEvents btnEliminarTipo As Button
    Friend WithEvents btnActivarCategoria As Button
    Friend WithEvents btnActivarTipo As Button
End Class
