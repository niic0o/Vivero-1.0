<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AltaDeProducto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtstockmin = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbcod = New System.Windows.Forms.TextBox()
        Me.DataGridView_Productos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboBuscarC = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.ErrorSoloDecimales = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorSoloNumeros = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DataGridView_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorSoloDecimales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSoloNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alta de Productos"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stock:"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(273, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio de Venta:"
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
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(94, 56)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cboCategoria.TabIndex = 7
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(94, 125)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(121, 20)
        Me.txtnombre.TabIndex = 9
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(377, 129)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(73, 20)
        Me.txtstock.TabIndex = 10
        '
        'txtstockmin
        '
        Me.txtstockmin.Location = New System.Drawing.Point(377, 95)
        Me.txtstockmin.Name = "txtstockmin"
        Me.txtstockmin.Size = New System.Drawing.Size(73, 20)
        Me.txtstockmin.TabIndex = 11
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(377, 193)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(103, 20)
        Me.txtprecio.TabIndex = 12
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(274, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Buscar por categoria:"
        '
        'txtbcod
        '
        Me.txtbcod.Location = New System.Drawing.Point(131, 19)
        Me.txtbcod.Name = "txtbcod"
        Me.txtbcod.Size = New System.Drawing.Size(100, 20)
        Me.txtbcod.TabIndex = 17
        '
        'DataGridView_Productos
        '
        Me.DataGridView_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Productos.Location = New System.Drawing.Point(8, 56)
        Me.DataGridView_Productos.Name = "DataGridView_Productos"
        Me.DataGridView_Productos.ReadOnly = True
        Me.DataGridView_Productos.Size = New System.Drawing.Size(561, 219)
        Me.DataGridView_Productos.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.txtDescuento)
        Me.Panel1.Controls.Add(Me.lblDescuento)
        Me.Panel1.Controls.Add(Me.rdbNO)
        Me.Panel1.Controls.Add(Me.rdbSI)
        Me.Panel1.Controls.Add(Me.lblDisponible)
        Me.Panel1.Controls.Add(Me.txtTamaño)
        Me.Panel1.Controls.Add(Me.lblTamaño)
        Me.Panel1.Controls.Add(Me.txtpreciolista)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cboTipo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtdescr)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtprecio)
        Me.Panel1.Controls.Add(Me.txtstockmin)
        Me.Panel1.Controls.Add(Me.txtstock)
        Me.Panel1.Controls.Add(Me.txtnombre)
        Me.Panel1.Controls.Add(Me.cboCategoria)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(182, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 279)
        Me.Panel1.TabIndex = 21
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.Controls.Add(Me.cboBuscarC)
        Me.Panel2.Controls.Add(Me.DataGridView_Productos)
        Me.Panel2.Controls.Add(Me.txtbcod)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(182, 349)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(577, 286)
        Me.Panel2.TabIndex = 22
        '
        'cboBuscarC
        '
        Me.cboBuscarC.FormattingEnabled = True
        Me.cboBuscarC.Location = New System.Drawing.Point(388, 19)
        Me.cboBuscarC.Name = "cboBuscarC"
        Me.cboBuscarC.Size = New System.Drawing.Size(121, 21)
        Me.cboBuscarC.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Vivero.My.Resources.Resources.logovivero2
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(181, 635)
        Me.Panel3.TabIndex = 23
        '
        'btncancelar
        '
        Me.btncancelar.Image = Global.Vivero.My.Resources.Resources.ic_cancel_128_28318__1_
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(660, 306)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(90, 37)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Image = Global.Vivero.My.Resources.Resources.vcsnormal_93488__1_
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar.Location = New System.Drawing.Point(559, 306)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(84, 37)
        Me.btnguardar.TabIndex = 13
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'ErrorSoloDecimales
        '
        Me.ErrorSoloDecimales.ContainerControl = Me
        '
        'ErrorSoloNumeros
        '
        Me.ErrorSoloNumeros.ContainerControl = Me
        '
        'AltaDeProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(762, 628)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AltaDeProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltaDeProducto"
        CType(Me.DataGridView_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorSoloDecimales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSoloNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtstock As TextBox
    Friend WithEvents txtstockmin As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbcod As TextBox
    Friend WithEvents DataGridView_Productos As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtdescr As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboBuscarC As ComboBox
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
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents ErrorSoloDecimales As ErrorProvider
    Friend WithEvents ErrorSoloNumeros As ErrorProvider
End Class
