<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_Clientes))
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtMunicipio = New System.Windows.Forms.TextBox()
        Me.TxtDivipol = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDepto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPais = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtCelular = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtApelContacto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombContacto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbTdoc = New System.Windows.Forms.ComboBox()
        Me.TxtDocumento = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.GBCodigoCliente = New System.Windows.Forms.GroupBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GBCodigoCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.BtnBuscar)
        Me.GroupBox7.Controls.Add(Me.TxtMunicipio)
        Me.GroupBox7.Controls.Add(Me.TxtDivipol)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.TxtDepto)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.TxtPais)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 287)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(543, 90)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "UBICACION"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(505, 50)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscar.TabIndex = 4
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtMunicipio
        '
        Me.TxtMunicipio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMunicipio.Location = New System.Drawing.Point(184, 56)
        Me.TxtMunicipio.MaxLength = 50
        Me.TxtMunicipio.Name = "TxtMunicipio"
        Me.TxtMunicipio.ReadOnly = True
        Me.TxtMunicipio.Size = New System.Drawing.Size(315, 26)
        Me.TxtMunicipio.TabIndex = 3
        '
        'TxtDivipol
        '
        Me.TxtDivipol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDivipol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDivipol.Location = New System.Drawing.Point(89, 56)
        Me.TxtDivipol.MaxLength = 8
        Me.TxtDivipol.Name = "TxtDivipol"
        Me.TxtDivipol.ReadOnly = True
        Me.TxtDivipol.Size = New System.Drawing.Size(89, 26)
        Me.TxtDivipol.TabIndex = 2
        Me.TxtDivipol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.TxtDepto.TabIndex = 1
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtDireccion)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 53)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DIRECCION"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(17, 16)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(449, 26)
        Me.TxtDireccion.TabIndex = 0
        '
        'TxtCorreo
        '
        Me.TxtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(295, 54)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(379, 26)
        Me.TxtCorreo.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtTelefono)
        Me.GroupBox4.Location = New System.Drawing.Point(489, 130)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(202, 53)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TELEFONO"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(17, 16)
        Me.TxtTelefono.MaxLength = 10
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(179, 26)
        Me.TxtTelefono.TabIndex = 0
        Me.TxtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtCelular)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtCorreo)
        Me.GroupBox3.Controls.Add(Me.TxtApelContacto)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtNombContacto)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 189)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(680, 90)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONTACTO"
        '
        'TxtCelular
        '
        Me.TxtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCelular.Location = New System.Drawing.Point(67, 54)
        Me.TxtCelular.MaxLength = 10
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(172, 26)
        Me.TxtCelular.TabIndex = 2
        Me.TxtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Celular :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Correo :"
        '
        'TxtApelContacto
        '
        Me.TxtApelContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApelContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApelContacto.Location = New System.Drawing.Point(377, 19)
        Me.TxtApelContacto.MaxLength = 30
        Me.TxtApelContacto.Name = "TxtApelContacto"
        Me.TxtApelContacto.Size = New System.Drawing.Size(297, 26)
        Me.TxtApelContacto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellidos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre :"
        '
        'TxtNombContacto
        '
        Me.TxtNombContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombContacto.Location = New System.Drawing.Point(67, 19)
        Me.TxtNombContacto.MaxLength = 20
        Me.TxtNombContacto.Name = "TxtNombContacto"
        Me.TxtNombContacto.Size = New System.Drawing.Size(249, 26)
        Me.TxtNombContacto.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbTdoc)
        Me.GroupBox1.Controls.Add(Me.TxtDocumento)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NIT"
        '
        'CmbTdoc
        '
        Me.CmbTdoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTdoc.FormattingEnabled = True
        Me.CmbTdoc.Items.AddRange(New Object() {"CC", "CE", "PP"})
        Me.CmbTdoc.Location = New System.Drawing.Point(14, 16)
        Me.CmbTdoc.Name = "CmbTdoc"
        Me.CmbTdoc.Size = New System.Drawing.Size(58, 26)
        Me.CmbTdoc.TabIndex = 0
        Me.CmbTdoc.Text = "NT"
        '
        'TxtDocumento
        '
        Me.TxtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocumento.Location = New System.Drawing.Point(78, 16)
        Me.TxtDocumento.MaxLength = 10
        Me.TxtDocumento.Name = "TxtDocumento"
        Me.TxtDocumento.Size = New System.Drawing.Size(114, 26)
        Me.TxtDocumento.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtCliente)
        Me.GroupBox5.Location = New System.Drawing.Point(225, 71)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(466, 53)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CLIENTE"
        '
        'TxtCliente
        '
        Me.TxtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCliente.Location = New System.Drawing.Point(14, 16)
        Me.TxtCliente.MaxLength = 100
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(446, 26)
        Me.TxtCliente.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CmbTipo)
        Me.GroupBox6.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(170, 53)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "TIPO:"
        '
        'CmbTipo
        '
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Location = New System.Drawing.Point(13, 20)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(146, 21)
        Me.CmbTipo.TabIndex = 0
        Me.CmbTipo.Text = "PERSONA JURIDICA"
        '
        'BtnCrear
        '
        Me.BtnCrear.BackColor = System.Drawing.Color.Gray
        Me.BtnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrear.ForeColor = System.Drawing.Color.White
        Me.BtnCrear.Image = CType(resources.GetObject("BtnCrear.Image"), System.Drawing.Image)
        Me.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrear.Location = New System.Drawing.Point(560, 337)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(131, 51)
        Me.BtnCrear.TabIndex = 7
        Me.BtnCrear.Text = "Crear Cliente"
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
        Me.BtnActualizar.Location = New System.Drawing.Point(560, 337)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(131, 51)
        Me.BtnActualizar.TabIndex = 9
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.CmbEstado)
        Me.GroupBox8.Location = New System.Drawing.Point(562, 287)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(130, 42)
        Me.GroupBox8.TabIndex = 6
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "ESTADO"
        '
        'CmbEstado
        '
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Location = New System.Drawing.Point(14, 16)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(94, 21)
        Me.CmbEstado.TabIndex = 0
        Me.CmbEstado.Text = "ACTIVO"
        '
        'GBCodigoCliente
        '
        Me.GBCodigoCliente.Controls.Add(Me.TxtCodigo)
        Me.GBCodigoCliente.Location = New System.Drawing.Point(569, 12)
        Me.GBCodigoCliente.Name = "GBCodigoCliente"
        Me.GBCodigoCliente.Size = New System.Drawing.Size(122, 53)
        Me.GBCodigoCliente.TabIndex = 11
        Me.GBCodigoCliente.TabStop = False
        Me.GBCodigoCliente.Text = "CODIGO CLIENTE"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(17, 16)
        Me.TxtCodigo.MaxLength = 10
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(98, 26)
        Me.TxtCodigo.TabIndex = 0
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'For_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 404)
        Me.Controls.Add(Me.GBCodigoCliente)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnActualizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENTES BULKMATIC"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GBCodigoCliente.ResumeLayout(False)
        Me.GBCodigoCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtMunicipio As TextBox
    Friend WithEvents TxtDivipol As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDepto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPais As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtApelContacto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombContacto As TextBox
    Friend WithEvents TxtCelular As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtDocumento As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents CmbTdoc As ComboBox
    Friend WithEvents BtnCrear As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents CmbEstado As ComboBox
    Friend WithEvents GBCodigoCliente As GroupBox
    Friend WithEvents TxtCodigo As TextBox
End Class
