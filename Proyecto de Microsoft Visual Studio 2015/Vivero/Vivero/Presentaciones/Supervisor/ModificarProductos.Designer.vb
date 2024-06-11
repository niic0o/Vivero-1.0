<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarProductos
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.rdbNO = New System.Windows.Forms.RadioButton()
        Me.rdbSI = New System.Windows.Forms.RadioButton()
        Me.lblDisponible = New System.Windows.Forms.Label()
        Me.txtTamaño = New System.Windows.Forms.TextBox()
        Me.lblTamaño = New System.Windows.Forms.Label()
        Me.txtpreciolista = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdescr = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtstockmin = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ErrorSoloNumeros = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorSoloDecimales = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboBuscarC = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtbcod = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ErrorSoloLetras = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel4.SuspendLayout()
        CType(Me.ErrorSoloNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSoloDecimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSoloLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Vivero.My.Resources.Resources.logovivero2
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(186, 688)
        Me.Panel3.TabIndex = 45
        '
        'btncancelar
        '
        Me.btncancelar.Image = Global.Vivero.My.Resources.Resources.ic_cancel_128_28318__1_
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(673, 329)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(85, 39)
        Me.btncancelar.TabIndex = 34
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Image = Global.Vivero.My.Resources.Resources.edit_validated_40458
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(557, 329)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(91, 39)
        Me.BtnModificar.TabIndex = 46
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel4.Controls.Add(Me.txtDescuento)
        Me.Panel4.Controls.Add(Me.lblDescuento)
        Me.Panel4.Controls.Add(Me.rdbNO)
        Me.Panel4.Controls.Add(Me.rdbSI)
        Me.Panel4.Controls.Add(Me.lblDisponible)
        Me.Panel4.Controls.Add(Me.txtTamaño)
        Me.Panel4.Controls.Add(Me.lblTamaño)
        Me.Panel4.Controls.Add(Me.txtpreciolista)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.cboTipo)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtdescr)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtprecio)
        Me.Panel4.Controls.Add(Me.txtstockmin)
        Me.Panel4.Controls.Add(Me.txtstock)
        Me.Panel4.Controls.Add(Me.txtnombre)
        Me.Panel4.Controls.Add(Me.cboCategoria)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Location = New System.Drawing.Point(187, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(581, 295)
        Me.Panel4.TabIndex = 22
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(377, 227)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(103, 20)
        Me.txtDescuento.TabIndex = 26
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(274, 230)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(76, 13)
        Me.lblDescuento.TabIndex = 25
        Me.lblDescuento.Text = "Descuento(%):"
        '
        'rdbNO
        '
        Me.rdbNO.AutoSize = True
        Me.rdbNO.Location = New System.Drawing.Point(420, 62)
        Me.rdbNO.Name = "rdbNO"
        Me.rdbNO.Size = New System.Drawing.Size(41, 17)
        Me.rdbNO.TabIndex = 24
        Me.rdbNO.TabStop = True
        Me.rdbNO.Text = "NO"
        Me.rdbNO.UseVisualStyleBackColor = True
        '
        'rdbSI
        '
        Me.rdbSI.AutoSize = True
        Me.rdbSI.Location = New System.Drawing.Point(377, 62)
        Me.rdbSI.Name = "rdbSI"
        Me.rdbSI.Size = New System.Drawing.Size(35, 17)
        Me.rdbSI.TabIndex = 23
        Me.rdbSI.TabStop = True
        Me.rdbSI.Text = "SI"
        Me.rdbSI.UseVisualStyleBackColor = True
        '
        'lblDisponible
        '
        Me.lblDisponible.AutoSize = True
        Me.lblDisponible.Location = New System.Drawing.Point(273, 64)
        Me.lblDisponible.Name = "lblDisponible"
        Me.lblDisponible.Size = New System.Drawing.Size(59, 13)
        Me.lblDisponible.TabIndex = 22
        Me.lblDisponible.Text = "Disponible:"
        '
        'txtTamaño
        '
        Me.txtTamaño.Location = New System.Drawing.Point(94, 224)
        Me.txtTamaño.Name = "txtTamaño"
        Me.txtTamaño.Size = New System.Drawing.Size(121, 20)
        Me.txtTamaño.TabIndex = 21
        '
        'lblTamaño
        '
        Me.lblTamaño.AutoSize = True
        Me.lblTamaño.Location = New System.Drawing.Point(22, 227)
        Me.lblTamaño.Name = "lblTamaño"
        Me.lblTamaño.Size = New System.Drawing.Size(49, 13)
        Me.lblTamaño.TabIndex = 20
        Me.lblTamaño.Text = "Tamaño:"
        '
        'txtpreciolista
        '
        Me.txtpreciolista.Location = New System.Drawing.Point(377, 160)
        Me.txtpreciolista.Name = "txtpreciolista"
        Me.txtpreciolista.Size = New System.Drawing.Size(103, 20)
        Me.txtpreciolista.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(274, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Precio de Lista:"
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(94, 90)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(121, 21)
        Me.cboTipo.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Tipo:"
        '
        'txtdescr
        '
        Me.txtdescr.Location = New System.Drawing.Point(94, 160)
        Me.txtdescr.Multiline = True
        Me.txtdescr.Name = "txtdescr"
        Me.txtdescr.Size = New System.Drawing.Size(121, 53)
        Me.txtdescr.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Descripcion:"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(377, 193)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(103, 20)
        Me.txtprecio.TabIndex = 12
        '
        'txtstockmin
        '
        Me.txtstockmin.Location = New System.Drawing.Point(377, 95)
        Me.txtstockmin.Name = "txtstockmin"
        Me.txtstockmin.Size = New System.Drawing.Size(73, 20)
        Me.txtstockmin.TabIndex = 11
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(377, 129)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(73, 20)
        Me.txtstock.TabIndex = 10
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(94, 125)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(121, 20)
        Me.txtnombre.TabIndex = 9
        '
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Items.AddRange(New Object() {"Plantas", "Semillas", "Jardineria", "Abonos"})
        Me.cboCategoria.Location = New System.Drawing.Point(94, 56)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cboCategoria.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Categoria:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(273, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio de Venta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stock minimo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stock:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Modificar Productos"
        '
        'ErrorSoloNumeros
        '
        Me.ErrorSoloNumeros.ContainerControl = Me
        '
        'ErrorSoloDecimales
        '
        Me.ErrorSoloDecimales.ContainerControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.Controls.Add(Me.cboBuscarC)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.txtbcod)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(187, 389)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(581, 299)
        Me.Panel2.TabIndex = 47
        '
        'cboBuscarC
        '
        Me.cboBuscarC.FormattingEnabled = True
        Me.cboBuscarC.Items.AddRange(New Object() {"Plantas", "Semillas", "Jardineria", "Abonos"})
        Me.cboBuscarC.Location = New System.Drawing.Point(388, 19)
        Me.cboBuscarC.Name = "cboBuscarC"
        Me.cboBuscarC.Size = New System.Drawing.Size(121, 21)
        Me.cboBuscarC.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(561, 219)
        Me.DataGridView1.TabIndex = 19
        '
        'txtbcod
        '
        Me.txtbcod.Location = New System.Drawing.Point(131, 19)
        Me.txtbcod.Name = "txtbcod"
        Me.txtbcod.Size = New System.Drawing.Size(100, 20)
        Me.txtbcod.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(274, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Buscar por categoria:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Buscar por codigo:"
        '
        'ErrorSoloLetras
        '
        Me.ErrorSoloLetras.ContainerControl = Me
        '
        'ModificarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(770, 689)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btncancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ModificarProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarProductos"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ErrorSoloNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSoloDecimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSoloLetras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncancelar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnModificar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents lblDescuento As Label
    Friend WithEvents rdbNO As RadioButton
    Friend WithEvents rdbSI As RadioButton
    Friend WithEvents lblDisponible As Label
    Friend WithEvents txtTamaño As TextBox
    Friend WithEvents lblTamaño As Label
    Friend WithEvents txtpreciolista As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdescr As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtstockmin As TextBox
    Friend WithEvents txtstock As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ErrorSoloNumeros As ErrorProvider
    Friend WithEvents ErrorSoloDecimales As ErrorProvider
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cboBuscarC As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtbcod As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ErrorSoloLetras As ErrorProvider
End Class
