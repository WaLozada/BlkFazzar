<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_ITRSubMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_ITRSubMenu))
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnRegistro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gray
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(128, 8)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(115, 100)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnRegistro
        '
        Me.BtnRegistro.BackColor = System.Drawing.Color.Gray
        Me.BtnRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistro.ForeColor = System.Drawing.Color.White
        Me.BtnRegistro.Image = CType(resources.GetObject("BtnRegistro.Image"), System.Drawing.Image)
        Me.BtnRegistro.Location = New System.Drawing.Point(7, 8)
        Me.BtnRegistro.Name = "BtnRegistro"
        Me.BtnRegistro.Size = New System.Drawing.Size(115, 100)
        Me.BtnRegistro.TabIndex = 5
        Me.BtnRegistro.Text = "Registro"
        Me.BtnRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRegistro.UseVisualStyleBackColor = False
        '
        'For_ITRSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 117)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnRegistro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "For_ITRSubMenu"
        Me.Text = "For_SubITR"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnRegistro As Button
End Class
