<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarUsuario
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
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.txtbuscardni = New System.Windows.Forms.TextBox()
        Me.txtbapellido = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateIngreso = New System.Windows.Forms.DateTimePicker()
        Me.DateNac = New System.Windows.Forms.DateTimePicker()
        Me.cbotipoperfil = New System.Windows.Forms.ComboBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txttel = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncontraseña = New System.Windows.Forms.Button()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.ErrorSoloNumeros = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorSoloLetras = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorIsNotEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSoloNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSoloLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIsNotEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncancelar
        '
        Me.btncancelar.Image = Global.Vivero.My.Resources.Resources.ic_cancel_128_28318__1_
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(670, 305)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(86, 39)
        Me.btncancelar.TabIndex = 55
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'txtbuscardni
        '
        Me.txtbuscardni.Location = New System.Drawing.Point(384, 12)
        Me.txtbuscardni.Name = "txtbuscardni"
        Me.txtbuscardni.Size = New System.Drawing.Size(100, 20)
        Me.txtbuscardni.TabIndex = 52
        '
        'txtbapellido
        '
        Me.txtbapellido.Location = New System.Drawing.Point(116, 12)
        Me.txtbapellido.Name = "txtbapellido"
        Me.txtbapellido.Size = New System.Drawing.Size(100, 20)
        Me.txtbapellido.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(295, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Buscar por DNI:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Buscar por Apellido:"
        '
        'DateIngreso
        '
        Me.DateIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateIngreso.Location = New System.Drawing.Point(144, 189)
        Me.DateIngreso.Name = "DateIngreso"
        Me.DateIngreso.Size = New System.Drawing.Size(100, 20)
        Me.DateIngreso.TabIndex = 48
        '
        'DateNac
        '
        Me.DateNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateNac.Location = New System.Drawing.Point(144, 143)
        Me.DateNac.Name = "DateNac"
        Me.DateNac.Size = New System.Drawing.Size(100, 20)
        Me.DateNac.TabIndex = 47
        '
        'cbotipoperfil
        '
        Me.cbotipoperfil.FormattingEnabled = True
        Me.cbotipoperfil.Items.AddRange(New Object() {"Supervisor", "GerenteSupervisor", "Empleado"})
        Me.cbotipoperfil.Location = New System.Drawing.Point(414, 229)
        Me.cbotipoperfil.Name = "cbotipoperfil"
        Me.cbotipoperfil.Size = New System.Drawing.Size(121, 21)
        Me.cbotipoperfil.TabIndex = 46
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(414, 188)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(100, 20)
        Me.txtcontraseña.TabIndex = 45
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(414, 143)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 20)
        Me.txtemail.TabIndex = 44
        '
        'txttel
        '
        Me.txttel.Location = New System.Drawing.Point(414, 96)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(100, 20)
        Me.txttel.TabIndex = 43
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(414, 61)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtdireccion.TabIndex = 42
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(144, 230)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(100, 20)
        Me.txtdni.TabIndex = 41
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(144, 99)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 40
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(144, 64)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(100, 20)
        Me.txtapellido.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(296, 233)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Tipo Perfil"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(295, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Telefono:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(295, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Contraseña:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(295, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(295, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Direccion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "DNI:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Fecha ingreso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Fecha de nacimiento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Alta de Usuarios"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.btncontraseña)
        Me.Panel1.Controls.Add(Me.txtusuario)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.DateIngreso)
        Me.Panel1.Controls.Add(Me.DateNac)
        Me.Panel1.Controls.Add(Me.cbotipoperfil)
        Me.Panel1.Controls.Add(Me.txtcontraseña)
        Me.Panel1.Controls.Add(Me.txtemail)
        Me.Panel1.Controls.Add(Me.txttel)
        Me.Panel1.Controls.Add(Me.txtdireccion)
        Me.Panel1.Controls.Add(Me.txtdni)
        Me.Panel1.Controls.Add(Me.txtnombre)
        Me.Panel1.Controls.Add(Me.txtapellido)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(224, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 296)
        Me.Panel1.TabIndex = 56
        '
        'btncontraseña
        '
        Me.btncontraseña.Location = New System.Drawing.Point(365, 187)
        Me.btncontraseña.Name = "btncontraseña"
        Me.btncontraseña.Size = New System.Drawing.Size(49, 21)
        Me.btncontraseña.TabIndex = 60
        Me.btncontraseña.Text = "Ver"
        Me.btncontraseña.UseVisualStyleBackColor = True
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(144, 262)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(100, 20)
        Me.txtusuario.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 265)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Nombre de Usuario:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.txtbuscardni)
        Me.Panel2.Controls.Add(Me.txtbapellido)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(225, 346)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(539, 222)
        Me.Panel2.TabIndex = 57
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(520, 171)
        Me.DataGridView1.TabIndex = 53
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Vivero.My.Resources.Resources.logovivero2
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(0, -6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(227, 574)
        Me.Panel3.TabIndex = 58
        '
        'BtnModificar
        '
        Me.BtnModificar.Image = Global.Vivero.My.Resources.Resources.edit_validated_40458
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(557, 305)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(91, 39)
        Me.BtnModificar.TabIndex = 59
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'ErrorSoloNumeros
        '
        Me.ErrorSoloNumeros.ContainerControl = Me
        '
        'ErrorSoloLetras
        '
        Me.ErrorSoloLetras.ContainerControl = Me
        '
        'ErrorIsNotEmail
        '
        Me.ErrorIsNotEmail.ContainerControl = Me
        '
        'ModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(765, 570)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btncancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ModificarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarUsuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSoloNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSoloLetras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIsNotEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btncancelar As Button
    Friend WithEvents txtbuscardni As TextBox
    Friend WithEvents txtbapellido As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DateIngreso As DateTimePicker
    Friend WithEvents DateNac As DateTimePicker
    Friend WithEvents cbotipoperfil As ComboBox
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txttel As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnModificar As Button
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btncontraseña As Button
    Friend WithEvents ErrorSoloNumeros As ErrorProvider
    Friend WithEvents ErrorSoloLetras As ErrorProvider
    Friend WithEvents ErrorIsNotEmail As ErrorProvider
End Class
