<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AltaCliente
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txttel = New System.Windows.Forms.TextBox()
        Me.textdir = New System.Windows.Forms.TextBox()
        Me.txtprov = New System.Windows.Forms.TextBox()
        Me.txtloc = New System.Windows.Forms.TextBox()
        Me.DataGridView_Clientes = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbapellido = New System.Windows.Forms.TextBox()
        Me.txtbdni = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.ErrorIsNotEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorSoloLetras = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorSoloNumeros = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DataGridView_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorIsNotEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSoloLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSoloNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alta de Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DNI:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(307, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telefono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(307, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Direccion:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(307, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Provincia:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(307, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Localidad:"
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(104, 82)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(100, 20)
        Me.txtapellido.TabIndex = 9
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(104, 121)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 10
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(104, 159)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(100, 20)
        Me.txtdni.TabIndex = 11
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(104, 196)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 20)
        Me.txtemail.TabIndex = 12
        '
        'txttel
        '
        Me.txttel.Location = New System.Drawing.Point(383, 81)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(100, 20)
        Me.txttel.TabIndex = 13
        '
        'textdir
        '
        Me.textdir.Location = New System.Drawing.Point(383, 121)
        Me.textdir.Name = "textdir"
        Me.textdir.Size = New System.Drawing.Size(100, 20)
        Me.textdir.TabIndex = 14
        '
        'txtprov
        '
        Me.txtprov.Location = New System.Drawing.Point(383, 159)
        Me.txtprov.Name = "txtprov"
        Me.txtprov.Size = New System.Drawing.Size(100, 20)
        Me.txtprov.TabIndex = 15
        '
        'txtloc
        '
        Me.txtloc.Location = New System.Drawing.Point(383, 199)
        Me.txtloc.Name = "txtloc"
        Me.txtloc.Size = New System.Drawing.Size(100, 20)
        Me.txtloc.TabIndex = 16
        '
        'DataGridView_Clientes
        '
        Me.DataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Clientes.Location = New System.Drawing.Point(15, 85)
        Me.DataGridView_Clientes.Name = "DataGridView_Clientes"
        Me.DataGridView_Clientes.ReadOnly = True
        Me.DataGridView_Clientes.Size = New System.Drawing.Size(546, 199)
        Me.DataGridView_Clientes.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Lista de Clientes:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(112, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Apellido:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(342, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "DNI:"
        '
        'txtbapellido
        '
        Me.txtbapellido.Location = New System.Drawing.Point(192, 34)
        Me.txtbapellido.Name = "txtbapellido"
        Me.txtbapellido.Size = New System.Drawing.Size(100, 20)
        Me.txtbapellido.TabIndex = 23
        '
        'txtbdni
        '
        Me.txtbdni.Location = New System.Drawing.Point(404, 34)
        Me.txtbdni.Name = "txtbdni"
        Me.txtbdni.Size = New System.Drawing.Size(100, 20)
        Me.txtbdni.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.txtloc)
        Me.Panel1.Controls.Add(Me.txtprov)
        Me.Panel1.Controls.Add(Me.textdir)
        Me.Panel1.Controls.Add(Me.txttel)
        Me.Panel1.Controls.Add(Me.txtemail)
        Me.Panel1.Controls.Add(Me.txtdni)
        Me.Panel1.Controls.Add(Me.txtnombre)
        Me.Panel1.Controls.Add(Me.txtapellido)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(182, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(570, 247)
        Me.Panel1.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.Controls.Add(Me.txtbdni)
        Me.Panel2.Controls.Add(Me.txtbapellido)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.DataGridView_Clientes)
        Me.Panel2.Location = New System.Drawing.Point(182, 322)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(570, 296)
        Me.Panel2.TabIndex = 26
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Vivero.My.Resources.Resources.logovivero2
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(185, 618)
        Me.Panel3.TabIndex = 27
        '
        'btncancelar
        '
        Me.btncancelar.Image = Global.Vivero.My.Resources.Resources.ic_cancel_128_28318__1_
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(655, 265)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(88, 42)
        Me.btncancelar.TabIndex = 18
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Image = Global.Vivero.My.Resources.Resources.vcsnormal_93488__1_
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar.Location = New System.Drawing.Point(561, 265)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(88, 42)
        Me.btnguardar.TabIndex = 17
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'ErrorIsNotEmail
        '
        Me.ErrorIsNotEmail.ContainerControl = Me
        '
        'ErrorSoloLetras
        '
        Me.ErrorSoloLetras.ContainerControl = Me
        '
        'ErrorSoloNumeros
        '
        Me.ErrorSoloNumeros.ContainerControl = Me
        '
        'AltaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(755, 618)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Name = "AltaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltaCliente"
        CType(Me.DataGridView_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorIsNotEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSoloLetras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSoloNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txttel As TextBox
    Friend WithEvents textdir As TextBox
    Friend WithEvents txtprov As TextBox
    Friend WithEvents txtloc As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents DataGridView_Clientes As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbapellido As TextBox
    Friend WithEvents txtbdni As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ErrorIsNotEmail As ErrorProvider
    Friend WithEvents ErrorSoloLetras As ErrorProvider
    Friend WithEvents ErrorSoloNumeros As ErrorProvider
End Class
