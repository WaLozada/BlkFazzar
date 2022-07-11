<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_EntradasSubMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_EntradasSubMenu))
        Me.BtnIngresoGranel = New System.Windows.Forms.Button()
        Me.LblClose = New System.Windows.Forms.Label()
        Me.BtnIngresoMaterial = New System.Windows.Forms.Button()
        Me.BtnOrdenCargue = New System.Windows.Forms.Button()
        Me.BtnFotos = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnIngresoGranel
        '
        Me.BtnIngresoGranel.BackColor = System.Drawing.Color.Gray
        Me.BtnIngresoGranel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresoGranel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresoGranel.ForeColor = System.Drawing.Color.White
        Me.BtnIngresoGranel.Image = CType(resources.GetObject("BtnIngresoGranel.Image"), System.Drawing.Image)
        Me.BtnIngresoGranel.Location = New System.Drawing.Point(123, 4)
        Me.BtnIngresoGranel.Name = "BtnIngresoGranel"
        Me.BtnIngresoGranel.Size = New System.Drawing.Size(115, 100)
        Me.BtnIngresoGranel.TabIndex = 1
        Me.BtnIngresoGranel.Text = "Ingreso Granel"
        Me.BtnIngresoGranel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnIngresoGranel.UseVisualStyleBackColor = False
        '
        'LblClose
        '
        Me.LblClose.AutoSize = True
        Me.LblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClose.Location = New System.Drawing.Point(573, 4)
        Me.LblClose.Name = "LblClose"
        Me.LblClose.Size = New System.Drawing.Size(15, 13)
        Me.LblClose.TabIndex = 30
        Me.LblClose.Text = "X"
        Me.LblClose.Visible = False
        '
        'BtnIngresoMaterial
        '
        Me.BtnIngresoMaterial.BackColor = System.Drawing.Color.Gray
        Me.BtnIngresoMaterial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresoMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresoMaterial.ForeColor = System.Drawing.Color.White
        Me.BtnIngresoMaterial.Image = CType(resources.GetObject("BtnIngresoMaterial.Image"), System.Drawing.Image)
        Me.BtnIngresoMaterial.Location = New System.Drawing.Point(3, 4)
        Me.BtnIngresoMaterial.Name = "BtnIngresoMaterial"
        Me.BtnIngresoMaterial.Size = New System.Drawing.Size(115, 100)
        Me.BtnIngresoMaterial.TabIndex = 0
        Me.BtnIngresoMaterial.Text = "Ingreso Material"
        Me.BtnIngresoMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnIngresoMaterial.UseVisualStyleBackColor = False
        '
        'BtnOrdenCargue
        '
        Me.BtnOrdenCargue.BackColor = System.Drawing.Color.Gray
        Me.BtnOrdenCargue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOrdenCargue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrdenCargue.ForeColor = System.Drawing.Color.White
        Me.BtnOrdenCargue.Image = CType(resources.GetObject("BtnOrdenCargue.Image"), System.Drawing.Image)
        Me.BtnOrdenCargue.Location = New System.Drawing.Point(242, 4)
        Me.BtnOrdenCargue.Name = "BtnOrdenCargue"
        Me.BtnOrdenCargue.Size = New System.Drawing.Size(115, 100)
        Me.BtnOrdenCargue.TabIndex = 2
        Me.BtnOrdenCargue.Text = "Orden Ingreso"
        Me.BtnOrdenCargue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnOrdenCargue.UseVisualStyleBackColor = False
        '
        'BtnFotos
        '
        Me.BtnFotos.BackColor = System.Drawing.Color.Gray
        Me.BtnFotos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFotos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFotos.ForeColor = System.Drawing.Color.White
        Me.BtnFotos.Image = CType(resources.GetObject("BtnFotos.Image"), System.Drawing.Image)
        Me.BtnFotos.Location = New System.Drawing.Point(360, 4)
        Me.BtnFotos.Name = "BtnFotos"
        Me.BtnFotos.Size = New System.Drawing.Size(115, 100)
        Me.BtnFotos.TabIndex = 3
        Me.BtnFotos.Text = "Registro Fotos"
        Me.BtnFotos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnFotos.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gray
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(481, 4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(115, 100)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'For_EntradasSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 113)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnFotos)
        Me.Controls.Add(Me.BtnOrdenCargue)
        Me.Controls.Add(Me.BtnIngresoMaterial)
        Me.Controls.Add(Me.BtnIngresoGranel)
        Me.Controls.Add(Me.LblClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(460, 550)
        Me.Name = "For_EntradasSubMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "For_EntradasSubMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnIngresoGranel As Button
    Friend WithEvents LblClose As Label
    Friend WithEvents BtnIngresoMaterial As Button
    Friend WithEvents BtnOrdenCargue As Button
    Friend WithEvents BtnFotos As Button
    Friend WithEvents BtnSalir As Button
End Class
