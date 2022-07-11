<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_CeCoClientesCrear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_CeCoClientesCrear))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbSegmentos = New System.Windows.Forms.ComboBox()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.CmbTerminales = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtCeco = New System.Windows.Forms.TextBox()
        Me.BtnCrearCliente = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbSegmentos)
        Me.GroupBox1.Location = New System.Drawing.Point(360, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 56)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEGMENTO"
        '
        'CmbSegmentos
        '
        Me.CmbSegmentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSegmentos.FormattingEnabled = True
        Me.CmbSegmentos.Location = New System.Drawing.Point(6, 19)
        Me.CmbSegmentos.Name = "CmbSegmentos"
        Me.CmbSegmentos.Size = New System.Drawing.Size(315, 24)
        Me.CmbSegmentos.TabIndex = 3
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.CmbTerminales)
        Me.GroupBox20.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(341, 57)
        Me.GroupBox20.TabIndex = 55
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "TERMINAL"
        '
        'CmbTerminales
        '
        Me.CmbTerminales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTerminales.FormattingEnabled = True
        Me.CmbTerminales.Location = New System.Drawing.Point(10, 19)
        Me.CmbTerminales.Name = "CmbTerminales"
        Me.CmbTerminales.Size = New System.Drawing.Size(320, 24)
        Me.CmbTerminales.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtCliente)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 54)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CLIENTE"
        '
        'TxtCliente
        '
        Me.TxtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCliente.Location = New System.Drawing.Point(7, 18)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(509, 26)
        Me.TxtCliente.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtCeco)
        Me.GroupBox3.Location = New System.Drawing.Point(539, 93)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(154, 54)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CODIGO"
        '
        'TxtCeco
        '
        Me.TxtCeco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCeco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCeco.Location = New System.Drawing.Point(7, 18)
        Me.TxtCeco.MaxLength = 6
        Me.TxtCeco.Name = "TxtCeco"
        Me.TxtCeco.Size = New System.Drawing.Size(141, 26)
        Me.TxtCeco.TabIndex = 0
        Me.TxtCeco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCrearCliente
        '
        Me.BtnCrearCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnCrearCliente.BackColor = System.Drawing.Color.Gray
        Me.BtnCrearCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearCliente.ForeColor = System.Drawing.Color.White
        Me.BtnCrearCliente.Image = CType(resources.GetObject("BtnCrearCliente.Image"), System.Drawing.Image)
        Me.BtnCrearCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrearCliente.Location = New System.Drawing.Point(505, 160)
        Me.BtnCrearCliente.Name = "BtnCrearCliente"
        Me.BtnCrearCliente.Size = New System.Drawing.Size(188, 53)
        Me.BtnCrearCliente.TabIndex = 59
        Me.BtnCrearCliente.Text = "Crear Centro de Costo "
        Me.BtnCrearCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrearCliente.UseVisualStyleBackColor = False
        '
        'For_CeCoClientesCrear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 225)
        Me.Controls.Add(Me.BtnCrearCliente)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox20)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_CeCoClientesCrear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Crear Cliente en Centro de Costo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbSegmentos As ComboBox
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents CmbTerminales As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtCeco As TextBox
    Friend WithEvents BtnCrearCliente As Button
End Class
