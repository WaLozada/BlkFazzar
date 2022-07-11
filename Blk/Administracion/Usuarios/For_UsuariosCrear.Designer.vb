<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class For_UsuariosCrear
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_UsuariosCrear))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtPapell = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtCelular = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtDocumento = New System.Windows.Forms.TextBox()
        Me.CmbTdoc = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TxtSapell = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DTFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.CmbRol = New System.Windows.Forms.ComboBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.RBInactivo = New System.Windows.Forms.RadioButton()
        Me.RBActivo = New System.Windows.Forms.RadioButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.RBVence = New System.Windows.Forms.RadioButton()
        Me.RBIndefinido = New System.Windows.Forms.RadioButton()
        Me.DTVigencia = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.CmbArea = New System.Windows.Forms.ComboBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.CmbUbicacion = New System.Windows.Forms.ComboBox()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
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
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(297, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 53)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NOMBRE"
        '
        'TxtNombre
        '
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(11, 19)
        Me.TxtNombre.MaxLength = 20
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(210, 26)
        Me.TxtNombre.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtPapell)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 53)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRIMER APELLIDO"
        '
        'TxtPapell
        '
        Me.TxtPapell.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPapell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPapell.Location = New System.Drawing.Point(11, 19)
        Me.TxtPapell.MaxLength = 12
        Me.TxtPapell.Name = "TxtPapell"
        Me.TxtPapell.Size = New System.Drawing.Size(142, 26)
        Me.TxtPapell.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtCelular)
        Me.GroupBox3.Location = New System.Drawing.Point(382, 204)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(143, 53)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CELULAR"
        '
        'TxtCelular
        '
        Me.TxtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCelular.Location = New System.Drawing.Point(11, 19)
        Me.TxtCelular.MaxLength = 10
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(123, 26)
        Me.TxtCelular.TabIndex = 0
        Me.TxtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtDocumento)
        Me.GroupBox4.Location = New System.Drawing.Point(125, 25)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(157, 53)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DOCUMENTO"
        '
        'TxtDocumento
        '
        Me.TxtDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocumento.Location = New System.Drawing.Point(11, 19)
        Me.TxtDocumento.MaxLength = 11
        Me.TxtDocumento.Name = "TxtDocumento"
        Me.TxtDocumento.Size = New System.Drawing.Size(140, 26)
        Me.TxtDocumento.TabIndex = 0
        Me.TxtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbTdoc
        '
        Me.CmbTdoc.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTdoc.FormattingEnabled = True
        Me.CmbTdoc.Items.AddRange(New Object() {"CC", "CE", "TI"})
        Me.CmbTdoc.Location = New System.Drawing.Point(11, 18)
        Me.CmbTdoc.Name = "CmbTdoc"
        Me.CmbTdoc.Size = New System.Drawing.Size(57, 27)
        Me.CmbTdoc.TabIndex = 29
        Me.CmbTdoc.Text = "CC"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CmbTdoc)
        Me.GroupBox5.Location = New System.Drawing.Point(37, 25)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(77, 53)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TDOC"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtSapell)
        Me.GroupBox6.Location = New System.Drawing.Point(211, 86)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(165, 53)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "SEGUNDO APELLIDO"
        '
        'TxtSapell
        '
        Me.TxtSapell.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSapell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSapell.Location = New System.Drawing.Point(11, 19)
        Me.TxtSapell.MaxLength = 12
        Me.TxtSapell.Name = "TxtSapell"
        Me.TxtSapell.Size = New System.Drawing.Size(142, 26)
        Me.TxtSapell.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DTFechaNac)
        Me.GroupBox7.Location = New System.Drawing.Point(385, 86)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(139, 52)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "FECHA NAC."
        '
        'DTFechaNac
        '
        Me.DTFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaNac.Location = New System.Drawing.Point(6, 17)
        Me.DTFechaNac.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DTFechaNac.Name = "DTFechaNac"
        Me.DTFechaNac.Size = New System.Drawing.Size(125, 26)
        Me.DTFechaNac.TabIndex = 33
        Me.DTFechaNac.Value = New Date(2020, 6, 24, 0, 0, 0, 0)
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TxtDireccion)
        Me.GroupBox8.Location = New System.Drawing.Point(37, 145)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(487, 53)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "DIRECCION"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(11, 19)
        Me.TxtDireccion.MaxLength = 50
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(468, 26)
        Me.TxtDireccion.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TxtEmail)
        Me.GroupBox9.Location = New System.Drawing.Point(37, 204)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(339, 53)
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "EMAIL"
        '
        'TxtEmail
        '
        Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(11, 19)
        Me.TxtEmail.MaxLength = 50
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(316, 26)
        Me.TxtEmail.TabIndex = 0
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.CmbRol)
        Me.GroupBox10.Location = New System.Drawing.Point(37, 263)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(339, 53)
        Me.GroupBox10.TabIndex = 8
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "ROL"
        '
        'CmbRol
        '
        Me.CmbRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbRol.FormattingEnabled = True
        Me.CmbRol.Location = New System.Drawing.Point(11, 19)
        Me.CmbRol.Name = "CmbRol"
        Me.CmbRol.Size = New System.Drawing.Size(315, 24)
        Me.CmbRol.TabIndex = 0
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.RBInactivo)
        Me.GroupBox11.Controls.Add(Me.RBActivo)
        Me.GroupBox11.Location = New System.Drawing.Point(381, 263)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(143, 53)
        Me.GroupBox11.TabIndex = 9
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "ESTADO"
        '
        'RBInactivo
        '
        Me.RBInactivo.AutoSize = True
        Me.RBInactivo.Location = New System.Drawing.Point(72, 20)
        Me.RBInactivo.Name = "RBInactivo"
        Me.RBInactivo.Size = New System.Drawing.Size(63, 17)
        Me.RBInactivo.TabIndex = 1
        Me.RBInactivo.Text = "Inactivo"
        Me.RBInactivo.UseVisualStyleBackColor = True
        '
        'RBActivo
        '
        Me.RBActivo.AutoSize = True
        Me.RBActivo.Checked = True
        Me.RBActivo.Location = New System.Drawing.Point(11, 20)
        Me.RBActivo.Name = "RBActivo"
        Me.RBActivo.Size = New System.Drawing.Size(55, 17)
        Me.RBActivo.TabIndex = 0
        Me.RBActivo.TabStop = True
        Me.RBActivo.Text = "Activo"
        Me.RBActivo.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.TxtClave)
        Me.GroupBox12.Location = New System.Drawing.Point(37, 322)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(165, 53)
        Me.GroupBox12.TabIndex = 10
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "CLAVE"
        '
        'TxtClave
        '
        Me.TxtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClave.Location = New System.Drawing.Point(11, 14)
        Me.TxtClave.MaxLength = 10
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClave.Size = New System.Drawing.Size(142, 31)
        Me.TxtClave.TabIndex = 0
        Me.TxtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.RBVence)
        Me.GroupBox13.Controls.Add(Me.RBIndefinido)
        Me.GroupBox13.Controls.Add(Me.DTVigencia)
        Me.GroupBox13.Location = New System.Drawing.Point(211, 322)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(313, 53)
        Me.GroupBox13.TabIndex = 11
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "VIGENCIA"
        '
        'RBVence
        '
        Me.RBVence.AutoSize = True
        Me.RBVence.Location = New System.Drawing.Point(102, 24)
        Me.RBVence.Name = "RBVence"
        Me.RBVence.Size = New System.Drawing.Size(56, 17)
        Me.RBVence.TabIndex = 36
        Me.RBVence.Text = "Vence"
        Me.RBVence.UseVisualStyleBackColor = True
        '
        'RBIndefinido
        '
        Me.RBIndefinido.AutoSize = True
        Me.RBIndefinido.Checked = True
        Me.RBIndefinido.Location = New System.Drawing.Point(19, 25)
        Me.RBIndefinido.Name = "RBIndefinido"
        Me.RBIndefinido.Size = New System.Drawing.Size(71, 17)
        Me.RBIndefinido.TabIndex = 35
        Me.RBIndefinido.TabStop = True
        Me.RBIndefinido.Text = "Indefinido"
        Me.RBIndefinido.UseVisualStyleBackColor = True
        '
        'DTVigencia
        '
        Me.DTVigencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTVigencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTVigencia.Location = New System.Drawing.Point(181, 16)
        Me.DTVigencia.Name = "DTVigencia"
        Me.DTVigencia.Size = New System.Drawing.Size(125, 26)
        Me.DTVigencia.TabIndex = 34
        Me.DTVigencia.Value = New Date(2020, 6, 24, 0, 0, 0, 0)
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.CmbArea)
        Me.GroupBox15.Location = New System.Drawing.Point(37, 384)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(245, 53)
        Me.GroupBox15.TabIndex = 12
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "AREA"
        '
        'CmbArea
        '
        Me.CmbArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbArea.FormattingEnabled = True
        Me.CmbArea.Location = New System.Drawing.Point(8, 17)
        Me.CmbArea.Name = "CmbArea"
        Me.CmbArea.Size = New System.Drawing.Size(231, 24)
        Me.CmbArea.TabIndex = 0
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.CmbUbicacion)
        Me.GroupBox14.Location = New System.Drawing.Point(288, 384)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(237, 53)
        Me.GroupBox14.TabIndex = 13
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "UBICACION"
        '
        'CmbUbicacion
        '
        Me.CmbUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUbicacion.FormattingEnabled = True
        Me.CmbUbicacion.Location = New System.Drawing.Point(8, 17)
        Me.CmbUbicacion.Name = "CmbUbicacion"
        Me.CmbUbicacion.Size = New System.Drawing.Size(220, 24)
        Me.CmbUbicacion.TabIndex = 0
        '
        'BtnCrear
        '
        Me.BtnCrear.BackColor = System.Drawing.Color.Gray
        Me.BtnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrear.ForeColor = System.Drawing.Color.White
        Me.BtnCrear.Image = CType(resources.GetObject("BtnCrear.Image"), System.Drawing.Image)
        Me.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrear.Location = New System.Drawing.Point(367, 453)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(158, 51)
        Me.BtnCrear.TabIndex = 14
        Me.BtnCrear.Text = "Crear Usuario"
        Me.BtnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrear.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.Gray
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(367, 453)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(158, 51)
        Me.BtnEditar.TabIndex = 43
        Me.BtnEditar.Text = "Editar Usuario"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = False
        Me.BtnEditar.Visible = False
        '
        'For_UsuariosCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 516)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.GroupBox15)
        Me.Controls.Add(Me.GroupBox13)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnEditar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_UsuariosCrear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Creación de Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtPapell As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtCelular As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtDocumento As TextBox
    Friend WithEvents CmbTdoc As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TxtSapell As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents DTFechaNac As DateTimePicker
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents CmbRol As ComboBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents RBInactivo As RadioButton
    Friend WithEvents RBActivo As RadioButton
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents RBVence As RadioButton
    Friend WithEvents RBIndefinido As RadioButton
    Friend WithEvents DTVigencia As DateTimePicker
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents CmbArea As ComboBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents CmbUbicacion As ComboBox
    Friend WithEvents BtnCrear As Button
    Friend WithEvents BtnEditar As Button
End Class
