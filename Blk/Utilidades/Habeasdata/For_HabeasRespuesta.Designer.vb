<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_HabeasRespuesta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_HabeasRespuesta))
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TxtRespuesta = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DTFechaRta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblIdcaso = New System.Windows.Forms.Label()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TxtRespuesta)
        Me.GroupBox8.Location = New System.Drawing.Point(16, 70)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(701, 196)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "RESPUESTA"
        '
        'TxtRespuesta
        '
        Me.TxtRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRespuesta.Location = New System.Drawing.Point(11, 19)
        Me.TxtRespuesta.MaxLength = 300
        Me.TxtRespuesta.Multiline = True
        Me.TxtRespuesta.Name = "TxtRespuesta"
        Me.TxtRespuesta.Size = New System.Drawing.Size(684, 171)
        Me.TxtRespuesta.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DTFechaRta)
        Me.GroupBox7.Location = New System.Drawing.Point(138, 11)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(139, 52)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "FECHA RESPUESTA"
        '
        'DTFechaRta
        '
        Me.DTFechaRta.CustomFormat = "yyyy-MM-dd"
        Me.DTFechaRta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFechaRta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTFechaRta.Location = New System.Drawing.Point(6, 17)
        Me.DTFechaRta.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DTFechaRta.Name = "DTFechaRta"
        Me.DTFechaRta.Size = New System.Drawing.Size(125, 26)
        Me.DTFechaRta.TabIndex = 33
        Me.DTFechaRta.Value = New Date(2020, 6, 24, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblIdcaso)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 57)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "IDCASO"
        '
        'LblIdcaso
        '
        Me.LblIdcaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdcaso.Location = New System.Drawing.Point(6, 23)
        Me.LblIdcaso.Name = "LblIdcaso"
        Me.LblIdcaso.Size = New System.Drawing.Size(98, 25)
        Me.LblIdcaso.TabIndex = 0
        Me.LblIdcaso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCrear
        '
        Me.BtnCrear.BackColor = System.Drawing.Color.Gray
        Me.BtnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrear.ForeColor = System.Drawing.Color.White
        Me.BtnCrear.Image = CType(resources.GetObject("BtnCrear.Image"), System.Drawing.Image)
        Me.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrear.Location = New System.Drawing.Point(538, 266)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(179, 51)
        Me.BtnCrear.TabIndex = 4
        Me.BtnCrear.Text = "Registrar Respuesta"
        Me.BtnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrear.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblNombre)
        Me.GroupBox2.Location = New System.Drawing.Point(286, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(431, 58)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SOLICITANTE"
        '
        'LblNombre
        '
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(13, 25)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(412, 22)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'For_HabeasRespuesta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 333)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_HabeasRespuesta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Respuesta Solicitud Habeas Data"
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TxtRespuesta As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents DTFechaRta As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblIdcaso As Label
    Friend WithEvents BtnCrear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblNombre As Label
End Class
