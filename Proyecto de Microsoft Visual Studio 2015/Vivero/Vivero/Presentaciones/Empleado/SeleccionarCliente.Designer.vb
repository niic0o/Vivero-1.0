<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarCliente
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
        Me.txtbapellido = New System.Windows.Forms.TextBox()
        Me.txtbdni = New System.Windows.Forms.TextBox()
        Me.DataGridView_Clientes = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnseleccionar = New System.Windows.Forms.Button()
        Me.ErrorSoloLetras = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorSoloNumeros = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label_select = New System.Windows.Forms.Label()
        CType(Me.DataGridView_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorSoloLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSoloNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista de Clientes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(286, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DNI:"
        '
        'txtbapellido
        '
        Me.txtbapellido.Location = New System.Drawing.Point(126, 55)
        Me.txtbapellido.Name = "txtbapellido"
        Me.txtbapellido.Size = New System.Drawing.Size(100, 20)
        Me.txtbapellido.TabIndex = 3
        '
        'txtbdni
        '
        Me.txtbdni.Location = New System.Drawing.Point(333, 55)
        Me.txtbdni.Name = "txtbdni"
        Me.txtbdni.Size = New System.Drawing.Size(100, 20)
        Me.txtbdni.TabIndex = 4
        '
        'DataGridView_Clientes
        '
        Me.DataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Clientes.Location = New System.Drawing.Point(12, 84)
        Me.DataGridView_Clientes.Name = "DataGridView_Clientes"
        Me.DataGridView_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Clientes.Size = New System.Drawing.Size(547, 375)
        Me.DataGridView_Clientes.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.DataGridView_Clientes)
        Me.Panel1.Controls.Add(Me.txtbdni)
        Me.Panel1.Controls.Add(Me.txtbapellido)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(190, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(567, 472)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Vivero.My.Resources.Resources.logovivero2
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(196, 565)
        Me.Panel2.TabIndex = 7
        '
        'btnseleccionar
        '
        Me.btnseleccionar.Image = Global.Vivero.My.Resources.Resources.actualizado
        Me.btnseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnseleccionar.Location = New System.Drawing.Point(438, 527)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(104, 38)
        Me.btnseleccionar.TabIndex = 14
        Me.btnseleccionar.Text = "Seleccionar"
        Me.btnseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnseleccionar.UseVisualStyleBackColor = True
        '
        'ErrorSoloLetras
        '
        Me.ErrorSoloLetras.ContainerControl = Me
        '
        'ErrorSoloNumeros
        '
        Me.ErrorSoloNumeros.ContainerControl = Me
        '
        'Label_select
        '
        Me.Label_select.AutoSize = True
        Me.Label_select.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_select.Location = New System.Drawing.Point(202, 527)
        Me.Label_select.Name = "Label_select"
        Me.Label_select.Size = New System.Drawing.Size(0, 13)
        Me.Label_select.TabIndex = 15
        '
        'SeleccionarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(759, 567)
        Me.Controls.Add(Me.Label_select)
        Me.Controls.Add(Me.btnseleccionar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SeleccionarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SeleccionarCliente"
        CType(Me.DataGridView_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorSoloLetras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSoloNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbapellido As TextBox
    Friend WithEvents txtbdni As TextBox
    Friend WithEvents DataGridView_Clientes As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnseleccionar As Button
    Friend WithEvents ErrorSoloLetras As ErrorProvider
    Friend WithEvents ErrorSoloNumeros As ErrorProvider
    Friend WithEvents Label_select As Label
End Class
