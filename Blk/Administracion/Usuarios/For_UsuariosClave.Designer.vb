<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_UsuariosClave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_UsuariosClave))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtConfirmacion = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtNueva = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtAnterior = New System.Windows.Forms.TextBox()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtConfirmacion)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 67)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONFIRMACION"
        '
        'TxtConfirmacion
        '
        Me.TxtConfirmacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtConfirmacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConfirmacion.Location = New System.Drawing.Point(12, 19)
        Me.TxtConfirmacion.MaxLength = 10
        Me.TxtConfirmacion.Name = "TxtConfirmacion"
        Me.TxtConfirmacion.Size = New System.Drawing.Size(184, 35)
        Me.TxtConfirmacion.TabIndex = 0
        Me.TxtConfirmacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtConfirmacion.UseSystemPasswordChar = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtNueva)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 67)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NUEVA CLAVE"
        '
        'TxtNueva
        '
        Me.TxtNueva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNueva.Location = New System.Drawing.Point(12, 22)
        Me.TxtNueva.MaxLength = 10
        Me.TxtNueva.Name = "TxtNueva"
        Me.TxtNueva.Size = New System.Drawing.Size(184, 35)
        Me.TxtNueva.TabIndex = 0
        Me.TxtNueva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNueva.UseSystemPasswordChar = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtAnterior)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CLAVE ANTERIOR"
        '
        'TxtAnterior
        '
        Me.TxtAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAnterior.Location = New System.Drawing.Point(11, 22)
        Me.TxtAnterior.MaxLength = 10
        Me.TxtAnterior.Name = "TxtAnterior"
        Me.TxtAnterior.Size = New System.Drawing.Size(185, 35)
        Me.TxtAnterior.TabIndex = 0
        Me.TxtAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAnterior.UseSystemPasswordChar = True
        '
        'BtnCrear
        '
        Me.BtnCrear.BackColor = System.Drawing.Color.Gray
        Me.BtnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrear.ForeColor = System.Drawing.Color.White
        Me.BtnCrear.Image = CType(resources.GetObject("BtnCrear.Image"), System.Drawing.Image)
        Me.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrear.Location = New System.Drawing.Point(14, 272)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(103, 51)
        Me.BtnCrear.TabIndex = 3
        Me.BtnCrear.Text = "Cambiar"
        Me.BtnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrear.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gray
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(119, 272)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(103, 51)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "La longitud de la Contraseña debe ser entre 5 y 10 caracteres."
        '
        'For_UsuariosClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 335)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_UsuariosClave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Clave"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtConfirmacion As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtNueva As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtAnterior As TextBox
    Friend WithEvents BtnCrear As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
End Class
