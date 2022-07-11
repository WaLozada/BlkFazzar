<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_ProductosTransporteCrear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_ProductosTransporteCrear))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtProducto = New System.Windows.Forms.TextBox()
        Me.BtnProducto = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtProducto)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRODUCTO"
        '
        'TxtProducto
        '
        Me.TxtProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProducto.Location = New System.Drawing.Point(13, 18)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(525, 26)
        Me.TxtProducto.TabIndex = 0
        '
        'BtnProducto
        '
        Me.BtnProducto.BackColor = System.Drawing.Color.DarkGray
        Me.BtnProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProducto.ForeColor = System.Drawing.Color.White
        Me.BtnProducto.Image = CType(resources.GetObject("BtnProducto.Image"), System.Drawing.Image)
        Me.BtnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProducto.Location = New System.Drawing.Point(572, 21)
        Me.BtnProducto.Name = "BtnProducto"
        Me.BtnProducto.Size = New System.Drawing.Size(153, 51)
        Me.BtnProducto.TabIndex = 38
        Me.BtnProducto.Text = "Crear Producto"
        Me.BtnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProducto.UseVisualStyleBackColor = False
        '
        'For_ProductosTransporteCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 93)
        Me.Controls.Add(Me.BtnProducto)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_ProductosTransporteCrear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Creación Productos Transporte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtProducto As TextBox
    Friend WithEvents BtnProducto As Button
End Class
