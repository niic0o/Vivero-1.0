<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerFactura
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosDeFacturas = New Vivero.DatosDeFacturas()
        Me.FACTURAS_DETALLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataTable1TableAdapter = New Vivero.DatosDeFacturasTableAdapters.DataTable1TableAdapter()
        Me.FACTURAS_DETALLETableAdapter = New Vivero.DatosDeFacturasTableAdapters.FACTURAS_DETALLETableAdapter()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDeFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTURAS_DETALLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DatosDeFacturas
        '
        'DatosDeFacturas
        '
        Me.DatosDeFacturas.DataSetName = "DatosDeFacturas"
        Me.DatosDeFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FACTURAS_DETALLEBindingSource
        '
        Me.FACTURAS_DETALLEBindingSource.DataMember = "FACTURAS_DETALLE"
        Me.FACTURAS_DETALLEBindingSource.DataSource = Me.DatosDeFacturas
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.ReportViewer1)
        Me.Panel1.Location = New System.Drawing.Point(194, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(702, 461)
        Me.Panel1.TabIndex = 4
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.FACTURAS_DETALLEBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Vivero.ReportFacturas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(696, 455)
        Me.ReportViewer1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Vivero.My.Resources.Resources.logovivero2
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(4, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 506)
        Me.Panel2.TabIndex = 5
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'FACTURAS_DETALLETableAdapter
        '
        Me.FACTURAS_DETALLETableAdapter.ClearBeforeFill = True
        '
        'VerFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 485)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "VerFactura"
        Me.Text = "VerFactura"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDeFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTURAS_DETALLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DatosDeFacturas As DatosDeFacturas
    Friend WithEvents FACTURAS_DETALLEBindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As DatosDeFacturasTableAdapters.DataTable1TableAdapter
    Friend WithEvents FACTURAS_DETALLETableAdapter As DatosDeFacturasTableAdapters.FACTURAS_DETALLETableAdapter
End Class
