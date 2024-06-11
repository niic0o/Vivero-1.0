<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarVenta
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnfactura = New System.Windows.Forms.TextBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtvendedor = New System.Windows.Forms.TextBox()
        Me.DateFactura = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView_VentaDetalle = New System.Windows.Forms.DataGridView()
        Me.id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelarVenta = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.cboTipoPago = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ErrorSoloDecimales = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.ErrorSoloNumeros = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DataGridView_VentaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorSoloDecimales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSoloNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° Factura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(316, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vendedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(595, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cliente:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(316, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Producto:"
        '
        'txtnfactura
        '
        Me.txtnfactura.Enabled = False
        Me.txtnfactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnfactura.Location = New System.Drawing.Point(126, 16)
        Me.txtnfactura.Name = "txtnfactura"
        Me.txtnfactura.ReadOnly = True
        Me.txtnfactura.Size = New System.Drawing.Size(132, 20)
        Me.txtnfactura.TabIndex = 5
        '
        'txtdesc
        '
        Me.txtdesc.Enabled = False
        Me.txtdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(391, 114)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.ReadOnly = True
        Me.txtdesc.Size = New System.Drawing.Size(180, 20)
        Me.txtdesc.TabIndex = 7
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(378, 146)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 8
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(378, 177)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.ReadOnly = True
        Me.txtprecio.Size = New System.Drawing.Size(100, 20)
        Me.txtprecio.TabIndex = 9
        '
        'txtvendedor
        '
        Me.txtvendedor.Enabled = False
        Me.txtvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvendedor.Location = New System.Drawing.Point(404, 16)
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.ReadOnly = True
        Me.txtvendedor.Size = New System.Drawing.Size(166, 20)
        Me.txtvendedor.TabIndex = 10
        '
        'DateFactura
        '
        Me.DateFactura.Enabled = False
        Me.DateFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFactura.Location = New System.Drawing.Point(652, 16)
        Me.DateFactura.Name = "DateFactura"
        Me.DateFactura.Size = New System.Drawing.Size(105, 20)
        Me.DateFactura.TabIndex = 11
        Me.DateFactura.Value = New Date(2021, 11, 3, 18, 37, 0, 0)
        '
        'DataGridView_VentaDetalle
        '
        Me.DataGridView_VentaDetalle.AllowUserToAddRows = False
        Me.DataGridView_VentaDetalle.AllowUserToDeleteRows = False
        Me.DataGridView_VentaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_VentaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_producto, Me.descripcion, Me.precio, Me.cantidad, Me.sub_total})
        Me.DataGridView_VentaDetalle.Location = New System.Drawing.Point(3, 13)
        Me.DataGridView_VentaDetalle.Name = "DataGridView_VentaDetalle"
        Me.DataGridView_VentaDetalle.ReadOnly = True
        Me.DataGridView_VentaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_VentaDetalle.Size = New System.Drawing.Size(621, 196)
        Me.DataGridView_VentaDetalle.TabIndex = 16
        '
        'id_producto
        '
        Me.id_producto.HeaderText = "Cod_producto"
        Me.id_producto.Name = "id_producto"
        Me.id_producto.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'sub_total
        '
        Me.sub_total.HeaderText = "Sub Total"
        Me.sub_total.Name = "sub_total"
        Me.sub_total.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.btnCancelarVenta)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.txtCategoria)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtStock)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtdni)
        Me.Panel1.Controls.Add(Me.txtdescuento)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtcliente)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnBuscarCliente)
        Me.Panel1.Controls.Add(Me.btnBuscarProducto)
        Me.Panel1.Controls.Add(Me.cboTipoPago)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DateFactura)
        Me.Panel1.Controls.Add(Me.txtvendedor)
        Me.Panel1.Controls.Add(Me.txtprecio)
        Me.Panel1.Controls.Add(Me.txtcantidad)
        Me.Panel1.Controls.Add(Me.txtdesc)
        Me.Panel1.Controls.Add(Me.txtnfactura)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(5, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 232)
        Me.Panel1.TabIndex = 17
        '
        'btnCancelarVenta
        '
        Me.btnCancelarVenta.BackColor = System.Drawing.Color.DarkGray
        Me.btnCancelarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarVenta.ForeColor = System.Drawing.Color.White
        Me.btnCancelarVenta.Image = Global.Vivero.My.Resources.Resources.ic_cancel_128_28318__1_
        Me.btnCancelarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelarVenta.Location = New System.Drawing.Point(652, 188)
        Me.btnCancelarVenta.Name = "btnCancelarVenta"
        Me.btnCancelarVenta.Size = New System.Drawing.Size(133, 41)
        Me.btnCancelarVenta.TabIndex = 29
        Me.btnCancelarVenta.Text = "Cancelar Venta"
        Me.btnCancelarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelarVenta.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.Vivero.My.Resources.Resources.ic_cancel_128_28318__1_
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(503, 184)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 39)
        Me.btnCancelar.TabIndex = 28
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtCategoria
        '
        Me.txtCategoria.Enabled = False
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(391, 84)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(180, 20)
        Me.txtCategoria.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(316, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Categoria:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(316, 210)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Stock:"
        '
        'txtStock
        '
        Me.txtStock.Enabled = False
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(378, 207)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Apellido y Nombre"
        '
        'txtdni
        '
        Me.txtdni.Enabled = False
        Me.txtdni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdni.Location = New System.Drawing.Point(147, 131)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.ReadOnly = True
        Me.txtdni.Size = New System.Drawing.Size(128, 20)
        Me.txtdni.TabIndex = 16
        '
        'txtdescuento
        '
        Me.txtdescuento.Enabled = False
        Me.txtdescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescuento.Location = New System.Drawing.Point(552, 150)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.ReadOnly = True
        Me.txtdescuento.Size = New System.Drawing.Size(52, 20)
        Me.txtdescuento.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Location = New System.Drawing.Point(112, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "DNI:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(484, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Descuento:"
        '
        'txtcliente
        '
        Me.txtcliente.Enabled = False
        Me.txtcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliente.Location = New System.Drawing.Point(147, 92)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.ReadOnly = True
        Me.txtcliente.Size = New System.Drawing.Size(128, 20)
        Me.txtcliente.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(316, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Descripcion:"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = Global.Vivero.My.Resources.Resources.buscar
        Me.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarCliente.Location = New System.Drawing.Point(652, 127)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(121, 43)
        Me.btnBuscarCliente.TabIndex = 19
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        Me.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Image = Global.Vivero.My.Resources.Resources.buscar
        Me.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarProducto.Location = New System.Drawing.Point(652, 57)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(121, 43)
        Me.btnBuscarProducto.TabIndex = 18
        Me.btnBuscarProducto.Text = "Buscar Producto"
        Me.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'cboTipoPago
        '
        Me.cboTipoPago.FormattingEnabled = True
        Me.cboTipoPago.Location = New System.Drawing.Point(126, 184)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoPago.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Tipo pago:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(316, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Precio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(316, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cantidad:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.Controls.Add(Me.DataGridView_VentaDetalle)
        Me.Panel2.Location = New System.Drawing.Point(211, 245)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(627, 221)
        Me.Panel2.TabIndex = 18
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Image = Global.Vivero.My.Resources.Resources.vcsnormal_93488__1_
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmar.Location = New System.Drawing.Point(718, 472)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(117, 43)
        Me.btnConfirmar.TabIndex = 15
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.Vivero.My.Resources.Resources.ic_cancel_128_28318__1_
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(592, 472)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(81, 43)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Vivero.My.Resources.Resources.add_icon_icons_com_74429
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(480, 472)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(88, 43)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'ErrorSoloDecimales
        '
        Me.ErrorSoloDecimales.ContainerControl = Me
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Vivero.My.Resources.Resources.logovivero2
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(5, 245)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 273)
        Me.Panel3.TabIndex = 19
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(323, 478)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(129, 35)
        Me.txtTotal.TabIndex = 20
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(215, 481)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(80, 29)
        Me.lblTotal.TabIndex = 21
        Me.lblTotal.Text = "Total:"
        '
        'ErrorSoloNumeros
        '
        Me.ErrorSoloNumeros.ContainerControl = Me
        '
        'AgregarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(847, 521)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnEliminar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AgregarVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarVenta"
        CType(Me.DataGridView_VentaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ErrorSoloDecimales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSoloNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnfactura As TextBox
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtvendedor As TextBox
    Friend WithEvents DateFactura As DateTimePicker
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents DataGridView_VentaDetalle As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboTipoPago As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents ErrorSoloDecimales As ErrorProvider
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtdni As TextBox
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ErrorSoloNumeros As ErrorProvider
    Friend WithEvents id_producto As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents sub_total As DataGridViewTextBoxColumn
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCancelarVenta As Button
End Class
