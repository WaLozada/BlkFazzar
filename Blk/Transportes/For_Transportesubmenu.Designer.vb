<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_Transportesubmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_Transportesubmenu))
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnBitacora = New System.Windows.Forms.Button()
        Me.BtnTolvas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gray
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(232, 8)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(115, 100)
        Me.BtnSalir.TabIndex = 38
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnBitacora
        '
        Me.BtnBitacora.BackColor = System.Drawing.Color.Gray
        Me.BtnBitacora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBitacora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBitacora.ForeColor = System.Drawing.Color.White
        Me.BtnBitacora.Image = CType(resources.GetObject("BtnBitacora.Image"), System.Drawing.Image)
        Me.BtnBitacora.Location = New System.Drawing.Point(5, 8)
        Me.BtnBitacora.Name = "BtnBitacora"
        Me.BtnBitacora.Size = New System.Drawing.Size(107, 100)
        Me.BtnBitacora.TabIndex = 37
        Me.BtnBitacora.Text = "Bitacora"
        Me.BtnBitacora.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBitacora.UseVisualStyleBackColor = False
        '
        'BtnTolvas
        '
        Me.BtnTolvas.BackColor = System.Drawing.Color.Gray
        Me.BtnTolvas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTolvas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTolvas.ForeColor = System.Drawing.Color.White
        Me.BtnTolvas.Image = CType(resources.GetObject("BtnTolvas.Image"), System.Drawing.Image)
        Me.BtnTolvas.Location = New System.Drawing.Point(119, 8)
        Me.BtnTolvas.Name = "BtnTolvas"
        Me.BtnTolvas.Size = New System.Drawing.Size(107, 100)
        Me.BtnTolvas.TabIndex = 39
        Me.BtnTolvas.Text = "Tolvas"
        Me.BtnTolvas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTolvas.UseVisualStyleBackColor = False
        '
        'For_Transportesubmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 116)
        Me.Controls.Add(Me.BtnTolvas)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnBitacora)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "For_Transportesubmenu"
        Me.Text = "Menu Transporte"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnBitacora As Button
    Friend WithEvents BtnTolvas As Button
End Class
