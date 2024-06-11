<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AltaDeCategoria
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView_Categoria = New System.Windows.Forms.DataGridView()
        Me.btnCancelarCategoria = New System.Windows.Forms.Button()
        Me.btnAgregarCategoria = New System.Windows.Forms.Button()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.lblTitulo1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView_Tipo = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.btnCancelarTipo = New System.Windows.Forms.Button()
        Me.btnAgregarTipo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_Categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView_Tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Vivero.My.Resources.Resources.logovivero2
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(-1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(181, 635)
        Me.Panel3.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.DataGridView_Categoria)
        Me.Panel1.Controls.Add(Me.btnCancelarCategoria)
        Me.Panel1.Controls.Add(Me.btnAgregarCategoria)
        Me.Panel1.Controls.Add(Me.txtCategoria)
        Me.Panel1.Controls.Add(Me.lblClasificacion)
        Me.Panel1.Controls.Add(Me.lblTitulo1)
        Me.Panel1.Location = New System.Drawing.Point(186, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 300)
        Me.Panel1.TabIndex = 25
        '
        'DataGridView_Categoria
        '
        Me.DataGridView_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Categoria.Location = New System.Drawing.Point(98, 147)
        Me.DataGridView_Categoria.Name = "DataGridView_Categoria"
        Me.DataGridView_Categoria.ReadOnly = True
        Me.DataGridView_Categoria.Size = New System.Drawing.Size(383, 150)
        Me.DataGridView_Categoria.TabIndex = 16
        '
        'btnCancelarCategoria
        '
        Me.btnCancelarCategoria.Image = Global.Vivero.My.Resources.Resources.ic_cancel_128_28318__1_
        Me.btnCancelarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelarCategoria.Location = New System.Drawing.Point(303, 104)
        Me.btnCancelarCategoria.Name = "btnCancelarCategoria"
        Me.btnCancelarCategoria.Size = New System.Drawing.Size(90, 37)
        Me.btnCancelarCategoria.TabIndex = 15
        Me.btnCancelarCategoria.Text = "Cancelar"
        Me.btnCancelarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelarCategoria.UseVisualStyleBackColor = True
        '
        'btnAgregarCategoria
        '
        Me.btnAgregarCategoria.Image = Global.Vivero.My.Resources.Resources.vcsnormal_93488__1_
        Me.btnAgregarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarCategoria.Location = New System.Drawing.Point(200, 104)
        Me.btnAgregarCategoria.Name = "btnAgregarCategoria"
        Me.btnAgregarCategoria.Size = New System.Drawing.Size(84, 37)
        Me.btnAgregarCategoria.TabIndex = 14
        Me.btnAgregarCategoria.Text = "Guardar"
        Me.btnAgregarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarCategoria.UseVisualStyleBackColor = True
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(200, 68)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(193, 20)
        Me.txtCategoria.TabIndex = 2
        '
        'lblClasificacion
        '
        Me.lblClasificacion.AutoSize = True
        Me.lblClasificacion.Location = New System.Drawing.Point(116, 71)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(55, 13)
        Me.lblClasificacion.TabIndex = 1
        Me.lblClasificacion.Text = "Categoria:"
        '
        'lblTitulo1
        '
        Me.lblTitulo1.AutoSize = True
        Me.lblTitulo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo1.Location = New System.Drawing.Point(222, 21)
        Me.lblTitulo1.Name = "lblTitulo1"
        Me.lblTitulo1.Size = New System.Drawing.Size(129, 16)
        Me.lblTitulo1.TabIndex = 0
        Me.lblTitulo1.Text = "Alta de Categoria"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel4.Controls.Add(Me.DataGridView_Tipo)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtTipo)
        Me.Panel4.Controls.Add(Me.cboCategoria)
        Me.Panel4.Controls.Add(Me.btnCancelarTipo)
        Me.Panel4.Controls.Add(Me.btnAgregarTipo)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(186, 335)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(576, 289)
        Me.Panel4.TabIndex = 27
        '
        'DataGridView_Tipo
        '
        Me.DataGridView_Tipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Tipo.Location = New System.Drawing.Point(14, 131)
        Me.DataGridView_Tipo.Name = "DataGridView_Tipo"
        Me.DataGridView_Tipo.ReadOnly = True
        Me.DataGridView_Tipo.Size = New System.Drawing.Size(549, 150)
        Me.DataGridView_Tipo.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(300, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Tipo:"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(348, 42)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(170, 20)
        Me.txtTipo.TabIndex = 20
        '
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Items.AddRange(New Object() {"Plantas", "Semillas", "Jardineria", "Abonos"})
        Me.cboCategoria.Location = New System.Drawing.Point(86, 42)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(171, 21)
        Me.cboCategoria.TabIndex = 17
        '
        'btnCancelarTipo
        '
        Me.btnCancelarTipo.Image = Global.Vivero.My.Resources.Resources.ic_cancel_128_28318__1_
        Me.btnCancelarTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelarTipo.Location = New System.Drawing.Point(303, 73)
        Me.btnCancelarTipo.Name = "btnCancelarTipo"
        Me.btnCancelarTipo.Size = New System.Drawing.Size(90, 37)
        Me.btnCancelarTipo.TabIndex = 15
        Me.btnCancelarTipo.Text = "Cancelar"
        Me.btnCancelarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelarTipo.UseVisualStyleBackColor = True
        '
        'btnAgregarTipo
        '
        Me.btnAgregarTipo.Image = Global.Vivero.My.Resources.Resources.vcsnormal_93488__1_
        Me.btnAgregarTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarTipo.Location = New System.Drawing.Point(200, 73)
        Me.btnAgregarTipo.Name = "btnAgregarTipo"
        Me.btnAgregarTipo.Size = New System.Drawing.Size(84, 37)
        Me.btnAgregarTipo.TabIndex = 14
        Me.btnAgregarTipo.Text = "Guardar"
        Me.btnAgregarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarTipo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Categoria:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Alta de Tipo de Producto"
        '
        'AltaDeCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 628)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AltaDeCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltaDeCategoria"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView_Categoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView_Tipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo1 As Label
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents lblClasificacion As Label
    Friend WithEvents btnAgregarCategoria As Button
    Friend WithEvents btnCancelarCategoria As Button
    Friend WithEvents DataGridView_Categoria As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCancelarTipo As Button
    Friend WithEvents btnAgregarTipo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents DataGridView_Tipo As DataGridView
End Class
