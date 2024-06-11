<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtingresar = New System.Windows.Forms.Button()
        Me.txtsalir = New System.Windows.Forms.Button()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.Contraseña = New System.Windows.Forms.Label()
        Me.btncontraseña = New System.Windows.Forms.Button()
        Me.btnAcerca = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(142, 67)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(168, 20)
        Me.txtcontraseña.TabIndex = 12
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(142, 12)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(168, 20)
        Me.txtusuario.TabIndex = 11
        '
        'txtingresar
        '
        Me.txtingresar.Image = Global.Vivero.My.Resources.Resources.entrar
        Me.txtingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtingresar.Location = New System.Drawing.Point(490, 299)
        Me.txtingresar.Name = "txtingresar"
        Me.txtingresar.Size = New System.Drawing.Size(84, 43)
        Me.txtingresar.TabIndex = 13
        Me.txtingresar.Text = "Ingresar"
        Me.txtingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtingresar.UseVisualStyleBackColor = True
        '
        'txtsalir
        '
        Me.txtsalir.Image = Global.Vivero.My.Resources.Resources.log_out
        Me.txtsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtsalir.Location = New System.Drawing.Point(580, 299)
        Me.txtsalir.Name = "txtsalir"
        Me.txtsalir.Size = New System.Drawing.Size(84, 43)
        Me.txtsalir.TabIndex = 14
        Me.txtsalir.Text = "Salir"
        Me.txtsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtsalir.UseVisualStyleBackColor = True
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.Location = New System.Drawing.Point(23, 13)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(66, 16)
        Me.Usuario.TabIndex = 15
        Me.Usuario.Text = "Usuario:"
        '
        'Contraseña
        '
        Me.Contraseña.AutoSize = True
        Me.Contraseña.BackColor = System.Drawing.SystemColors.Control
        Me.Contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contraseña.Location = New System.Drawing.Point(23, 71)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(91, 16)
        Me.Contraseña.TabIndex = 16
        Me.Contraseña.Text = "Contraseña:"
        '
        'btncontraseña
        '
        Me.btncontraseña.Location = New System.Drawing.Point(316, 65)
        Me.btncontraseña.Name = "btncontraseña"
        Me.btncontraseña.Size = New System.Drawing.Size(75, 23)
        Me.btncontraseña.TabIndex = 17
        Me.btncontraseña.Text = "Ver"
        Me.btncontraseña.UseVisualStyleBackColor = True
        '
        'btnAcerca
        '
        Me.btnAcerca.Image = Global.Vivero.My.Resources.Resources.aaa
        Me.btnAcerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcerca.Location = New System.Drawing.Point(26, 299)
        Me.btnAcerca.Name = "btnAcerca"
        Me.btnAcerca.Size = New System.Drawing.Size(102, 43)
        Me.btnAcerca.TabIndex = 18
        Me.btnAcerca.Text = "Acerca de Nosotros"
        Me.btnAcerca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAcerca.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vivero.My.Resources.Resources.plantas_ilustraciones_senor_gato_19c3baff_1200x630
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(676, 349)
        Me.Controls.Add(Me.btnAcerca)
        Me.Controls.Add(Me.btncontraseña)
        Me.Controls.Add(Me.Contraseña)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.txtsalir)
        Me.Controls.Add(Me.txtingresar)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.txtusuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtingresar As Button
    Friend WithEvents txtsalir As Button
    Friend WithEvents Usuario As Label
    Friend WithEvents Contraseña As Label
    Friend WithEvents btncontraseña As Button
    Friend WithEvents btnAcerca As Button
End Class
