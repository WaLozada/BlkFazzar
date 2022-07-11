<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_EquiposDarbaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_EquiposDarbaja))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtObservacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbMotivo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblElemento = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblSerial = New System.Windows.Forms.Label()
        Me.LblModelo = New System.Windows.Forms.Label()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.LblActivo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnRegistrar)
        Me.GroupBox2.Controls.Add(Me.TxtObservacion)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.CmbMotivo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(824, 266)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MOTIVO DE LA BAJA"
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacion.Location = New System.Drawing.Point(14, 90)
        Me.TxtObservacion.Multiline = True
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(799, 114)
        Me.TxtObservacion.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "OBSERVACION :"
        '
        'CmbMotivo
        '
        Me.CmbMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMotivo.FormattingEnabled = True
        Me.CmbMotivo.Items.AddRange(New Object() {"Venta", "Daño", "Depreciación", "Donación", "Otro"})
        Me.CmbMotivo.Location = New System.Drawing.Point(98, 27)
        Me.CmbMotivo.Name = "CmbMotivo"
        Me.CmbMotivo.Size = New System.Drawing.Size(325, 28)
        Me.CmbMotivo.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "BAJA POR :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblElemento)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LblSerial)
        Me.GroupBox1.Controls.Add(Me.LblModelo)
        Me.GroupBox1.Controls.Add(Me.LblMarca)
        Me.GroupBox1.Controls.Add(Me.LblActivo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(824, 106)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS:"
        '
        'LblElemento
        '
        Me.LblElemento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblElemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblElemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblElemento.Location = New System.Drawing.Point(259, 23)
        Me.LblElemento.Name = "LblElemento"
        Me.LblElemento.Size = New System.Drawing.Size(238, 28)
        Me.LblElemento.TabIndex = 9
        Me.LblElemento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(174, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ELEMENTO :"
        '
        'LblSerial
        '
        Me.LblSerial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerial.Location = New System.Drawing.Point(575, 61)
        Me.LblSerial.Name = "LblSerial"
        Me.LblSerial.Size = New System.Drawing.Size(238, 28)
        Me.LblSerial.TabIndex = 7
        Me.LblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblModelo
        '
        Me.LblModelo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModelo.Location = New System.Drawing.Point(346, 62)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(151, 28)
        Me.LblModelo.TabIndex = 6
        Me.LblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblMarca
        '
        Me.LblMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMarca.Location = New System.Drawing.Point(95, 62)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(151, 28)
        Me.LblMarca.TabIndex = 5
        Me.LblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblActivo
        '
        Me.LblActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblActivo.Location = New System.Drawing.Point(96, 23)
        Me.LblActivo.Name = "LblActivo"
        Me.LblActivo.Size = New System.Drawing.Size(66, 28)
        Me.LblActivo.TabIndex = 4
        Me.LblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(508, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SERIAL :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(261, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MODELO :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MARCA :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ACTIVO :"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRegistrar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnRegistrar.Image = CType(resources.GetObject("BtnRegistrar.Image"), System.Drawing.Image)
        Me.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistrar.Location = New System.Drawing.Point(692, 210)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(121, 50)
        Me.BtnRegistrar.TabIndex = 37
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'For_EquiposDarbaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 402)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_EquiposDarbaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Elementos de Baja"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtObservacion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CmbMotivo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblElemento As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblSerial As Label
    Friend WithEvents LblModelo As Label
    Friend WithEvents LblMarca As Label
    Friend WithEvents LblActivo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRegistrar As Button
End Class
