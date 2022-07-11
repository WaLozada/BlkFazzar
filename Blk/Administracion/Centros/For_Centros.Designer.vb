<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_Centros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_Centros))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCentro = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar1 = New System.Windows.Forms.Button()
        Me.TxtApelResponsable = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombResponsable = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtCelular = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbMuelles = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar2 = New System.Windows.Forms.Button()
        Me.TxtMunicipio = New System.Windows.Forms.TextBox()
        Me.TxtDivipol = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDepto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPais = New System.Windows.Forms.TextBox()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCentro)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CENTRO"
        '
        'TxtCentro
        '
        Me.TxtCentro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCentro.Location = New System.Drawing.Point(17, 16)
        Me.TxtCentro.MaxLength = 30
        Me.TxtCentro.Name = "TxtCentro"
        Me.TxtCentro.Size = New System.Drawing.Size(258, 26)
        Me.TxtCentro.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtDireccion)
        Me.GroupBox2.Location = New System.Drawing.Point(308, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 53)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DIRECCION"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(17, 16)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(377, 26)
        Me.TxtDireccion.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnBuscar1)
        Me.GroupBox3.Controls.Add(Me.TxtApelResponsable)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtNombResponsable)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(700, 61)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESPONSABLE"
        '
        'BtnBuscar1
        '
        Me.BtnBuscar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar1.Enabled = False
        Me.BtnBuscar1.FlatAppearance.BorderSize = 0
        Me.BtnBuscar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar1.Image = CType(resources.GetObject("BtnBuscar1.Image"), System.Drawing.Image)
        Me.BtnBuscar1.Location = New System.Drawing.Point(659, 14)
        Me.BtnBuscar1.Name = "BtnBuscar1"
        Me.BtnBuscar1.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscar1.TabIndex = 9
        Me.BtnBuscar1.UseVisualStyleBackColor = True
        '
        'TxtApelResponsable
        '
        Me.TxtApelResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApelResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApelResponsable.Location = New System.Drawing.Point(404, 19)
        Me.TxtApelResponsable.MaxLength = 30
        Me.TxtApelResponsable.Name = "TxtApelResponsable"
        Me.TxtApelResponsable.Size = New System.Drawing.Size(249, 26)
        Me.TxtApelResponsable.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(335, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "APELLIDO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOMBRE"
        '
        'TxtNombResponsable
        '
        Me.TxtNombResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombResponsable.Location = New System.Drawing.Point(80, 19)
        Me.TxtNombResponsable.MaxLength = 20
        Me.TxtNombResponsable.Name = "TxtNombResponsable"
        Me.TxtNombResponsable.Size = New System.Drawing.Size(249, 26)
        Me.TxtNombResponsable.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtCelular)
        Me.GroupBox4.Location = New System.Drawing.Point(404, 71)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(181, 53)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TELEFONO"
        '
        'TxtCelular
        '
        Me.TxtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCelular.Location = New System.Drawing.Point(17, 16)
        Me.TxtCelular.MaxLength = 10
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(158, 26)
        Me.TxtCelular.TabIndex = 0
        Me.TxtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.CmbMuelles)
        Me.GroupBox5.Location = New System.Drawing.Point(591, 71)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(121, 53)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "MUELLES"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "No."
        '
        'CmbMuelles
        '
        Me.CmbMuelles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMuelles.FormattingEnabled = True
        Me.CmbMuelles.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CmbMuelles.Location = New System.Drawing.Point(53, 14)
        Me.CmbMuelles.MaxLength = 1
        Me.CmbMuelles.Name = "CmbMuelles"
        Me.CmbMuelles.Size = New System.Drawing.Size(58, 28)
        Me.CmbMuelles.TabIndex = 0
        Me.CmbMuelles.Text = "0"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtCorreo)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(386, 53)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "E-MAIL"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(17, 16)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(358, 26)
        Me.TxtCorreo.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.BtnBuscar2)
        Me.GroupBox7.Controls.Add(Me.TxtMunicipio)
        Me.GroupBox7.Controls.Add(Me.TxtDivipol)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.TxtDepto)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.TxtPais)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 197)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(543, 90)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "UBICACION"
        '
        'BtnBuscar2
        '
        Me.BtnBuscar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar2.FlatAppearance.BorderSize = 0
        Me.BtnBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar2.Image = CType(resources.GetObject("BtnBuscar2.Image"), System.Drawing.Image)
        Me.BtnBuscar2.Location = New System.Drawing.Point(505, 50)
        Me.BtnBuscar2.Name = "BtnBuscar2"
        Me.BtnBuscar2.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscar2.TabIndex = 10
        Me.BtnBuscar2.UseVisualStyleBackColor = True
        '
        'TxtMunicipio
        '
        Me.TxtMunicipio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMunicipio.Location = New System.Drawing.Point(173, 56)
        Me.TxtMunicipio.MaxLength = 50
        Me.TxtMunicipio.Name = "TxtMunicipio"
        Me.TxtMunicipio.ReadOnly = True
        Me.TxtMunicipio.Size = New System.Drawing.Size(326, 26)
        Me.TxtMunicipio.TabIndex = 7
        '
        'TxtDivipol
        '
        Me.TxtDivipol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDivipol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDivipol.Location = New System.Drawing.Point(89, 56)
        Me.TxtDivipol.MaxLength = 5
        Me.TxtDivipol.Name = "TxtDivipol"
        Me.TxtDivipol.ReadOnly = True
        Me.TxtDivipol.Size = New System.Drawing.Size(78, 26)
        Me.TxtDivipol.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "MUNICIPIO :"
        '
        'TxtDepto
        '
        Me.TxtDepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDepto.Location = New System.Drawing.Point(313, 19)
        Me.TxtDepto.MaxLength = 30
        Me.TxtDepto.Name = "TxtDepto"
        Me.TxtDepto.ReadOnly = True
        Me.TxtDepto.Size = New System.Drawing.Size(224, 26)
        Me.TxtDepto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DEPARTAMENTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PAIS"
        '
        'TxtPais
        '
        Me.TxtPais.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPais.Location = New System.Drawing.Point(51, 19)
        Me.TxtPais.MaxLength = 15
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.ReadOnly = True
        Me.TxtPais.Size = New System.Drawing.Size(150, 26)
        Me.TxtPais.TabIndex = 0
        '
        'BtnCrear
        '
        Me.BtnCrear.BackColor = System.Drawing.Color.Gray
        Me.BtnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrear.ForeColor = System.Drawing.Color.White
        Me.BtnCrear.Image = CType(resources.GetObject("BtnCrear.Image"), System.Drawing.Image)
        Me.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrear.Location = New System.Drawing.Point(581, 238)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(131, 51)
        Me.BtnCrear.TabIndex = 7
        Me.BtnCrear.Text = "Crear Centro"
        Me.BtnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrear.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Gray
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(581, 238)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(131, 51)
        Me.BtnActualizar.TabIndex = 8
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TxtCodigo)
        Me.GroupBox8.Location = New System.Drawing.Point(12, 313)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(65, 53)
        Me.GroupBox8.TabIndex = 9
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "CODIGO"
        Me.GroupBox8.Visible = False
        '
        'TxtCodigo
        '
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(17, 16)
        Me.TxtCodigo.MaxLength = 30
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(37, 26)
        Me.TxtCodigo.TabIndex = 0
        '
        'For_Centros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(734, 306)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnActualizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_Centros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CENTROS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCentro As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtApelResponsable As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombResponsable As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtCelular As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CmbMuelles As ComboBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TxtPais As TextBox
    Friend WithEvents BtnBuscar1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtMunicipio As TextBox
    Friend WithEvents TxtDivipol As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDepto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCrear As Button
    Friend WithEvents BtnBuscar2 As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TxtCodigo As TextBox
End Class
