<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_OperacionesSubMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_OperacionesSubMenu))
        Me.BtnAprobar = New System.Windows.Forms.Button()
        Me.BtnFacturas = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAprobar
        '
        Me.BtnAprobar.BackColor = System.Drawing.Color.Gray
        Me.BtnAprobar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAprobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAprobar.ForeColor = System.Drawing.Color.White
        Me.BtnAprobar.Image = CType(resources.GetObject("BtnAprobar.Image"), System.Drawing.Image)
        Me.BtnAprobar.Location = New System.Drawing.Point(129, 5)
        Me.BtnAprobar.Name = "BtnAprobar"
        Me.BtnAprobar.Size = New System.Drawing.Size(115, 100)
        Me.BtnAprobar.TabIndex = 45
        Me.BtnAprobar.Text = "Transporte"
        Me.BtnAprobar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAprobar.UseVisualStyleBackColor = False
        '
        'BtnFacturas
        '
        Me.BtnFacturas.BackColor = System.Drawing.Color.Gray
        Me.BtnFacturas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFacturas.ForeColor = System.Drawing.Color.White
        Me.BtnFacturas.Image = CType(resources.GetObject("BtnFacturas.Image"), System.Drawing.Image)
        Me.BtnFacturas.Location = New System.Drawing.Point(8, 5)
        Me.BtnFacturas.Name = "BtnFacturas"
        Me.BtnFacturas.Size = New System.Drawing.Size(115, 100)
        Me.BtnFacturas.TabIndex = 44
        Me.BtnFacturas.Text = "Proyectos"
        Me.BtnFacturas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnFacturas.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gray
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(250, 5)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(115, 100)
        Me.BtnSalir.TabIndex = 43
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'For_OperacionesSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 110)
        Me.Controls.Add(Me.BtnAprobar)
        Me.Controls.Add(Me.BtnFacturas)
        Me.Controls.Add(Me.BtnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "For_OperacionesSubMenu"
        Me.Text = "For_OperacionesSubMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAprobar As Button
    Friend WithEvents BtnFacturas As Button
    Friend WithEvents BtnSalir As Button
End Class
