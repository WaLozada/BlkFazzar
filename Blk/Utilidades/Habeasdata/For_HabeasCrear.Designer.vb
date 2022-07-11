<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_HabeasCrear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_HabeasCrear))
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.CmbMedio = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TxtSolicitud = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DTFechaSol = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CmbTdoc = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtDocumento = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtApell = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.CmbMedio)
        Me.GroupBox14.Location = New System.Drawing.Point(465, 71)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(170, 53)
        Me.GroupBox14.TabIndex = 5
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "MEDIO SOLICITUD"
        '
        'CmbMedio
        '
        Me.CmbMedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMedio.FormattingEnabled = True
        Me.CmbMedio.Items.AddRange(New Object() {"Formulario WEB", "Correo Electronico", "LLamada Telefónica"})
        Me.CmbMedio.Location = New System.Drawing.Point(8, 17)
        Me.CmbMedio.Name = "CmbMedio"
        Me.CmbMedio.Size = New System.Drawing.Size(149, 24)
        Me.CmbMedio.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TxtSolicitud)
        Me.GroupBox8.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(623, 196)
        Me.GroupBox8.TabIndex = 6
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "SOLICITUD"
        '
        'TxtSolicitud
        '
        Me.TxtSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSolicitud.Location = New System.Drawing.Point(11, 19)
        Me.TxtSolicitud.MaxLength = 300
        Me.TxtSolicitud.Multiline = True
        Me.TxtSolicitud.Name = "TxtSolicitud"
        Me.TxtSolicitud.Size = New System.Drawing.Size(606, 171)
        Me.TxtSolicitud.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DTFechaSol)
        Me.GroupBox7.Location = New System.Drawing.Point(320, 72)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(139, 52)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "FECHA SOLICITUD"
        '
        'DTFechaSol
        '
        Me.DTFechaSol.CustomFormat = "yyyy-MM-dd"
        Me.DTFechaSol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFechaSol.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTFechaSol.Location = New System.Drawing.Point(6, 17)
        Me.DTFechaSol.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DTFechaSol.Name = "DTFechaSol"
        Me.DTFechaSol.Size = New System.Drawing.Size(125, 26)
        Me.DTFechaSol.TabIndex = 33
        Me.DTFechaSol.Value = New Date(2020, 6, 24, 0, 0, 0, 0)
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CmbTdoc)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(77, 53)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TDOC"
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtDocumento)
        Me.GroupBox4.Location = New System.Drawing.Point(100, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(197, 53)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DOCUMENTO"
        '
        'TxtDocumento
        '
        Me.TxtDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocumento.Location = New System.Drawing.Point(6, 18)
        Me.TxtDocumento.MaxLength = 11
        Me.TxtDocumento.Name = "TxtDocumento"
        Me.TxtDocumento.Size = New System.Drawing.Size(175, 26)
        Me.TxtDocumento.TabIndex = 0
        Me.TxtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtApell)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 53)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "APELLIDOS"
        '
        'TxtApell
        '
        Me.TxtApell.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApell.Location = New System.Drawing.Point(11, 19)
        Me.TxtApell.MaxLength = 30
        Me.TxtApell.Name = "TxtApell"
        Me.TxtApell.Size = New System.Drawing.Size(285, 26)
        Me.TxtApell.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(303, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 53)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NOMBRES"
        '
        'TxtNombre
        '
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(11, 19)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(308, 26)
        Me.TxtNombre.TabIndex = 0
        '
        'BtnCrear
        '
        Me.BtnCrear.BackColor = System.Drawing.Color.Gray
        Me.BtnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrear.ForeColor = System.Drawing.Color.White
        Me.BtnCrear.Image = CType(resources.GetObject("BtnCrear.Image"), System.Drawing.Image)
        Me.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrear.Location = New System.Drawing.Point(473, 332)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(158, 51)
        Me.BtnCrear.TabIndex = 7
        Me.BtnCrear.Text = "Crear Solicitud"
        Me.BtnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrear.UseVisualStyleBackColor = False
        '
        'For_HabeasCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 395)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_HabeasCrear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro de Solicitud de Habeas Data"
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents CmbMedio As ComboBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TxtSolicitud As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents DTFechaSol As DateTimePicker
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CmbTdoc As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtDocumento As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtApell As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents BtnCrear As Button
End Class
