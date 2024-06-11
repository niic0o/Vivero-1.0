<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Backup
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
        Me.btnbackup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnbackup
        '
        Me.btnbackup.Image = Global.Vivero.My.Resources.Resources.backup
        Me.btnbackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbackup.Location = New System.Drawing.Point(351, 176)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(128, 45)
        Me.btnbackup.TabIndex = 0
        Me.btnbackup.Text = "Realizar BackUp"
        Me.btnbackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnbackup.UseVisualStyleBackColor = True
        '
        'Backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vivero.My.Resources.Resources.Día_Mundial_del_Backup_1000x600
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(748, 433)
        Me.Controls.Add(Me.btnbackup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Backup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnbackup As Button
End Class
