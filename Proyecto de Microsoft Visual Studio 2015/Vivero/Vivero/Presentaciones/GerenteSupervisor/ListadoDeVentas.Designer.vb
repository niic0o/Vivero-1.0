<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoDeVentas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView_Facturas = New System.Windows.Forms.DataGridView()
        Me.DataGridView_Detalles = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_Facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(346, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ventas Realizadas"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnimprimir)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.FechaHasta)
        Me.Panel1.Controls.Add(Me.FechaDesde)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DataGridView_Facturas)
        Me.Panel1.Controls.Add(Me.DataGridView_Detalles)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(183, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(807, 459)
        Me.Panel1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(537, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 18)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Detalles de Factura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(147, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Facturas"
        '
        'btnimprimir
        '
        Me.btnimprimir.Image = Global.Vivero.My.Resources.Resources.Print_icon_icons_com_73705
        Me.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnimprimir.Location = New System.Drawing.Point(649, 22)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(80, 38)
        Me.btnimprimir.TabIndex = 24
        Me.btnimprimir.Text = "Imprimir"
        Me.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(358, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Hasta:"
        '
        'FechaHasta
        '
        Me.FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaHasta.Location = New System.Drawing.Point(411, 40)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(92, 20)
        Me.FechaHasta.TabIndex = 22
        '
        'FechaDesde
        '
        Me.FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaDesde.Location = New System.Drawing.Point(244, 41)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(91, 20)
        Me.FechaDesde.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Buscar por Fecha:"
        '
        'DataGridView_Facturas
        '
        Me.DataGridView_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Facturas.Location = New System.Drawing.Point(3, 93)
        Me.DataGridView_Facturas.Name = "DataGridView_Facturas"
        Me.DataGridView_Facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Facturas.Size = New System.Drawing.Size(382, 363)
        Me.DataGridView_Facturas.TabIndex = 19
        '
        'DataGridView_Detalles
        '
        Me.DataGridView_Detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Detalles.Location = New System.Drawing.Point(401, 93)
        Me.DataGridView_Detalles.Name = "DataGridView_Detalles"
        Me.DataGridView_Detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Detalles.Size = New System.Drawing.Size(403, 363)
        Me.DataGridView_Detalles.TabIndex = 18
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Vivero.My.Resources.Resources.buscar
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(528, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(84, 38)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Vivero.My.Resources.Resources.logovivero2
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 506)
        Me.Panel2.TabIndex = 4
        '
        'btnactualizar
        '
        Me.btnactualizar.Image = Global.Vivero.My.Resources.Resources.actualizado
        Me.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnactualizar.Location = New System.Drawing.Point(554, 477)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(92, 42)
        Me.btnactualizar.TabIndex = 2
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'ListadoDeVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(991, 517)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnactualizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ListadoDeVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListadoDeVentas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView_Facturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Detalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnactualizar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DataGridView_Detalles As DataGridView
    Friend WithEvents DataGridView_Facturas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents FechaHasta As DateTimePicker
    Friend WithEvents FechaDesde As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents btnimprimir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
End Class
