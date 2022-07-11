<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_FacturaContabilizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_FacturaContabilizar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtWO = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtComentario = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblFactura = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LblConcepto = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LblProveedor = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LblSubtotal = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.LblIva = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.LblProyecto = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.LblCentroCosto = New System.Windows.Forms.Label()
        Me.BtnVisor = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.LblValorCC = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.LblFechaContable = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtWO)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 305)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 54)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONTABILIZAR WO"
        '
        'TxtWO
        '
        Me.TxtWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWO.Location = New System.Drawing.Point(9, 18)
        Me.TxtWO.MaxLength = 25
        Me.TxtWO.Name = "TxtWO"
        Me.TxtWO.Size = New System.Drawing.Size(187, 26)
        Me.TxtWO.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtComentario)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 102)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "COMENTARIOS"
        '
        'TxtComentario
        '
        Me.TxtComentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComentario.Location = New System.Drawing.Point(9, 16)
        Me.TxtComentario.Multiline = True
        Me.TxtComentario.Name = "TxtComentario"
        Me.TxtComentario.Size = New System.Drawing.Size(521, 81)
        Me.TxtComentario.TabIndex = 0
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Gray
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(554, 414)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(150, 51)
        Me.BtnGuardar.TabIndex = 8
        Me.BtnGuardar.Text = "Registrar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblFactura)
        Me.GroupBox3.Location = New System.Drawing.Point(138, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(206, 54)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "No. FACTURA"
        '
        'LblFactura
        '
        Me.LblFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFactura.Location = New System.Drawing.Point(6, 16)
        Me.LblFactura.Name = "LblFactura"
        Me.LblFactura.Size = New System.Drawing.Size(194, 30)
        Me.LblFactura.TabIndex = 0
        Me.LblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblConcepto)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 124)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(688, 120)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CONCEPTO"
        '
        'LblConcepto
        '
        Me.LblConcepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConcepto.Location = New System.Drawing.Point(6, 16)
        Me.LblConcepto.Name = "LblConcepto"
        Me.LblConcepto.Size = New System.Drawing.Size(672, 93)
        Me.LblConcepto.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LblProveedor)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 64)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(688, 54)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "PROVEEDOR"
        '
        'LblProveedor
        '
        Me.LblProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProveedor.Location = New System.Drawing.Point(6, 16)
        Me.LblProveedor.Name = "LblProveedor"
        Me.LblProveedor.Size = New System.Drawing.Size(672, 30)
        Me.LblProveedor.TabIndex = 0
        Me.LblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LblSubtotal)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 250)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(156, 54)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "SUBTOTAL"
        '
        'LblSubtotal
        '
        Me.LblSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubtotal.Location = New System.Drawing.Point(6, 16)
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.Size = New System.Drawing.Size(142, 30)
        Me.LblSubtotal.TabIndex = 0
        Me.LblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.LblIva)
        Me.GroupBox7.Location = New System.Drawing.Point(197, 250)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(156, 54)
        Me.GroupBox7.TabIndex = 13
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "IVA"
        '
        'LblIva
        '
        Me.LblIva.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIva.Location = New System.Drawing.Point(6, 16)
        Me.LblIva.Name = "LblIva"
        Me.LblIva.Size = New System.Drawing.Size(142, 30)
        Me.LblIva.TabIndex = 0
        Me.LblIva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.LblTotal)
        Me.GroupBox8.Location = New System.Drawing.Point(376, 250)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(156, 54)
        Me.GroupBox8.TabIndex = 14
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "TOTAL"
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(6, 16)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(142, 30)
        Me.LblTotal.TabIndex = 0
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.LblProyecto)
        Me.GroupBox9.Location = New System.Drawing.Point(350, 4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(227, 54)
        Me.GroupBox9.TabIndex = 15
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "PROYECTO"
        '
        'LblProyecto
        '
        Me.LblProyecto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProyecto.Location = New System.Drawing.Point(6, 16)
        Me.LblProyecto.Name = "LblProyecto"
        Me.LblProyecto.Size = New System.Drawing.Size(215, 28)
        Me.LblProyecto.TabIndex = 0
        Me.LblProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.LblCentroCosto)
        Me.GroupBox10.Location = New System.Drawing.Point(583, 4)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(116, 54)
        Me.GroupBox10.TabIndex = 16
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "CENTRO COSTO"
        '
        'LblCentroCosto
        '
        Me.LblCentroCosto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblCentroCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCentroCosto.Location = New System.Drawing.Point(6, 16)
        Me.LblCentroCosto.Name = "LblCentroCosto"
        Me.LblCentroCosto.Size = New System.Drawing.Size(104, 28)
        Me.LblCentroCosto.TabIndex = 0
        Me.LblCentroCosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnVisor
        '
        Me.BtnVisor.BackColor = System.Drawing.Color.Gray
        Me.BtnVisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVisor.ForeColor = System.Drawing.Color.White
        Me.BtnVisor.Image = CType(resources.GetObject("BtnVisor.Image"), System.Drawing.Image)
        Me.BtnVisor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVisor.Location = New System.Drawing.Point(554, 308)
        Me.BtnVisor.Name = "BtnVisor"
        Me.BtnVisor.Size = New System.Drawing.Size(150, 51)
        Me.BtnVisor.TabIndex = 17
        Me.BtnVisor.Text = "Ver Factura"
        Me.BtnVisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVisor.UseVisualStyleBackColor = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.LblCodigo)
        Me.GroupBox11.Location = New System.Drawing.Point(16, 4)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(116, 54)
        Me.GroupBox11.TabIndex = 18
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "CODIGO"
        '
        'LblCodigo
        '
        Me.LblCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo.Location = New System.Drawing.Point(6, 16)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(100, 30)
        Me.LblCodigo.TabIndex = 0
        Me.LblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.LblValorCC)
        Me.GroupBox12.Location = New System.Drawing.Point(548, 248)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(156, 54)
        Me.GroupBox12.TabIndex = 19
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "VALOR CENTRO COSTO"
        '
        'LblValorCC
        '
        Me.LblValorCC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblValorCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblValorCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValorCC.Location = New System.Drawing.Point(6, 16)
        Me.LblValorCC.Name = "LblValorCC"
        Me.LblValorCC.Size = New System.Drawing.Size(142, 30)
        Me.LblValorCC.TabIndex = 0
        Me.LblValorCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.Gray
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(554, 414)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(150, 51)
        Me.BtnEditar.TabIndex = 20
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'LblFechaContable
        '
        Me.LblFechaContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFechaContable.Location = New System.Drawing.Point(299, 326)
        Me.LblFechaContable.Name = "LblFechaContable"
        Me.LblFechaContable.Size = New System.Drawing.Size(243, 25)
        Me.LblFechaContable.TabIndex = 21
        Me.LblFechaContable.Visible = False
        '
        'For_FacturaContabilizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 482)
        Me.Controls.Add(Me.LblFechaContable)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.BtnVisor)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_FacturaContabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilización de Factura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtWO As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtComentario As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LblFactura As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LblConcepto As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LblProveedor As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LblSubtotal As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents LblIva As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents LblProyecto As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents LblCentroCosto As Label
    Friend WithEvents BtnVisor As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents LblCodigo As Label
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents LblValorCC As Label
    Friend WithEvents BtnEditar As Button
    Friend WithEvents LblFechaContable As Label
End Class
