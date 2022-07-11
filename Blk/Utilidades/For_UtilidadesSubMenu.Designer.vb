<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_UtilidadesSubMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_UtilidadesSubMenu))
        Me.BtnHabeas = New System.Windows.Forms.Button()
        Me.BtnEquipos = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnHabeas
        '
        Me.BtnHabeas.BackColor = System.Drawing.Color.Gray
        Me.BtnHabeas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHabeas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHabeas.ForeColor = System.Drawing.Color.White
        Me.BtnHabeas.Image = CType(resources.GetObject("BtnHabeas.Image"), System.Drawing.Image)
        Me.BtnHabeas.Location = New System.Drawing.Point(124, 5)
        Me.BtnHabeas.Name = "BtnHabeas"
        Me.BtnHabeas.Size = New System.Drawing.Size(115, 100)
        Me.BtnHabeas.TabIndex = 45
        Me.BtnHabeas.Text = "Habeas Data"
        Me.BtnHabeas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnHabeas.UseVisualStyleBackColor = False
        '
        'BtnEquipos
        '
        Me.BtnEquipos.BackColor = System.Drawing.Color.Gray
        Me.BtnEquipos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEquipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEquipos.ForeColor = System.Drawing.Color.White
        Me.BtnEquipos.Image = CType(resources.GetObject("BtnEquipos.Image"), System.Drawing.Image)
        Me.BtnEquipos.Location = New System.Drawing.Point(3, 5)
        Me.BtnEquipos.Name = "BtnEquipos"
        Me.BtnEquipos.Size = New System.Drawing.Size(115, 100)
        Me.BtnEquipos.TabIndex = 44
        Me.BtnEquipos.Text = "Equipos"
        Me.BtnEquipos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEquipos.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gray
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(245, 5)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(115, 100)
        Me.BtnSalir.TabIndex = 43
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'For_UtilidadesSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 110)
        Me.Controls.Add(Me.BtnHabeas)
        Me.Controls.Add(Me.BtnEquipos)
        Me.Controls.Add(Me.BtnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "For_UtilidadesSubMenu"
        Me.Text = "For_UtilidadesSubMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnEquipos As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnHabeas As Button
End Class
