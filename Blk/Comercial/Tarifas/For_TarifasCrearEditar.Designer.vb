<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_TarifasCrearEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_TarifasCrearEditar))
        Me.GbUnidad = New System.Windows.Forms.GroupBox()
        Me.CmbUnidad = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TxtCapacidad = New System.Windows.Forms.TextBox()
        Me.GbVehiculo = New System.Windows.Forms.GroupBox()
        Me.CmbTipoVehiculo = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RBItr = New System.Windows.Forms.RadioButton()
        Me.RBSpot = New System.Windows.Forms.RadioButton()
        Me.GbDestino = New System.Windows.Forms.GroupBox()
        Me.TxtMunicipioDestino = New System.Windows.Forms.TextBox()
        Me.BtnBuscaCiudad2 = New System.Windows.Forms.Button()
        Me.GbOrigen = New System.Windows.Forms.GroupBox()
        Me.TxtMunicipioOrigen = New System.Windows.Forms.TextBox()
        Me.BtnBuscaCiudad = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtKilometros = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTarifaTonelada = New System.Windows.Forms.TextBox()
        Me.TxtTarifaFlete = New System.Windows.Forms.TextBox()
        Me.TxtMargenPor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMargenPesos = New System.Windows.Forms.TextBox()
        Me.TxtCostoTonelada = New System.Windows.Forms.TextBox()
        Me.TxtCostoFlete = New System.Windows.Forms.TextBox()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.LblIdTarifa = New System.Windows.Forms.Label()
        Me.GbUnidad.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GbVehiculo.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GbDestino.SuspendLayout()
        Me.GbOrigen.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbUnidad
        '
        Me.GbUnidad.Controls.Add(Me.CmbUnidad)
        Me.GbUnidad.Location = New System.Drawing.Point(6, 286)
        Me.GbUnidad.Name = "GbUnidad"
        Me.GbUnidad.Size = New System.Drawing.Size(212, 61)
        Me.GbUnidad.TabIndex = 5
        Me.GbUnidad.TabStop = False
        Me.GbUnidad.Text = "UNIDAD MEDIDA"
        '
        'CmbUnidad
        '
        Me.CmbUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUnidad.FormattingEnabled = True
        Me.CmbUnidad.Location = New System.Drawing.Point(12, 21)
        Me.CmbUnidad.Name = "CmbUnidad"
        Me.CmbUnidad.Size = New System.Drawing.Size(184, 24)
        Me.CmbUnidad.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtCapacidad)
        Me.GroupBox6.Location = New System.Drawing.Point(224, 219)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(94, 61)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "CAPACIDAD"
        '
        'TxtCapacidad
        '
        Me.TxtCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCapacidad.Location = New System.Drawing.Point(7, 19)
        Me.TxtCapacidad.Name = "TxtCapacidad"
        Me.TxtCapacidad.Size = New System.Drawing.Size(76, 26)
        Me.TxtCapacidad.TabIndex = 0
        Me.TxtCapacidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GbVehiculo
        '
        Me.GbVehiculo.Controls.Add(Me.CmbTipoVehiculo)
        Me.GbVehiculo.Location = New System.Drawing.Point(6, 219)
        Me.GbVehiculo.Name = "GbVehiculo"
        Me.GbVehiculo.Size = New System.Drawing.Size(212, 61)
        Me.GbVehiculo.TabIndex = 3
        Me.GbVehiculo.TabStop = False
        Me.GbVehiculo.Text = "TIPO VEHICULO"
        '
        'CmbTipoVehiculo
        '
        Me.CmbTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipoVehiculo.FormattingEnabled = True
        Me.CmbTipoVehiculo.Location = New System.Drawing.Point(12, 19)
        Me.CmbTipoVehiculo.Name = "CmbTipoVehiculo"
        Me.CmbTipoVehiculo.Size = New System.Drawing.Size(184, 24)
        Me.CmbTipoVehiculo.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RBItr)
        Me.GroupBox4.Controls.Add(Me.RBSpot)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(306, 67)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SERVICIO"
        '
        'RBItr
        '
        Me.RBItr.AutoSize = True
        Me.RBItr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBItr.Location = New System.Drawing.Point(179, 29)
        Me.RBItr.Name = "RBItr"
        Me.RBItr.Size = New System.Drawing.Size(49, 22)
        Me.RBItr.TabIndex = 1
        Me.RBItr.TabStop = True
        Me.RBItr.Text = "ITR"
        Me.RBItr.UseVisualStyleBackColor = True
        '
        'RBSpot
        '
        Me.RBSpot.AutoSize = True
        Me.RBSpot.Checked = True
        Me.RBSpot.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBSpot.Location = New System.Drawing.Point(12, 29)
        Me.RBSpot.Name = "RBSpot"
        Me.RBSpot.Size = New System.Drawing.Size(133, 22)
        Me.RBSpot.TabIndex = 0
        Me.RBSpot.TabStop = True
        Me.RBSpot.Text = "Transporte Spot"
        Me.RBSpot.UseVisualStyleBackColor = True
        '
        'GbDestino
        '
        Me.GbDestino.Controls.Add(Me.TxtMunicipioDestino)
        Me.GbDestino.Controls.Add(Me.BtnBuscaCiudad2)
        Me.GbDestino.Location = New System.Drawing.Point(6, 152)
        Me.GbDestino.Name = "GbDestino"
        Me.GbDestino.Size = New System.Drawing.Size(312, 61)
        Me.GbDestino.TabIndex = 2
        Me.GbDestino.TabStop = False
        Me.GbDestino.Text = "DESTINO"
        '
        'TxtMunicipioDestino
        '
        Me.TxtMunicipioDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMunicipioDestino.Location = New System.Drawing.Point(55, 24)
        Me.TxtMunicipioDestino.Name = "TxtMunicipioDestino"
        Me.TxtMunicipioDestino.ReadOnly = True
        Me.TxtMunicipioDestino.Size = New System.Drawing.Size(246, 22)
        Me.TxtMunicipioDestino.TabIndex = 13
        '
        'BtnBuscaCiudad2
        '
        Me.BtnBuscaCiudad2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscaCiudad2.FlatAppearance.BorderSize = 0
        Me.BtnBuscaCiudad2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaCiudad2.Image = CType(resources.GetObject("BtnBuscaCiudad2.Image"), System.Drawing.Image)
        Me.BtnBuscaCiudad2.Location = New System.Drawing.Point(12, 19)
        Me.BtnBuscaCiudad2.Name = "BtnBuscaCiudad2"
        Me.BtnBuscaCiudad2.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscaCiudad2.TabIndex = 11
        Me.BtnBuscaCiudad2.UseVisualStyleBackColor = True
        '
        'GbOrigen
        '
        Me.GbOrigen.Controls.Add(Me.TxtMunicipioOrigen)
        Me.GbOrigen.Controls.Add(Me.BtnBuscaCiudad)
        Me.GbOrigen.Location = New System.Drawing.Point(6, 85)
        Me.GbOrigen.Name = "GbOrigen"
        Me.GbOrigen.Size = New System.Drawing.Size(312, 61)
        Me.GbOrigen.TabIndex = 1
        Me.GbOrigen.TabStop = False
        Me.GbOrigen.Text = "ORIGEN"
        '
        'TxtMunicipioOrigen
        '
        Me.TxtMunicipioOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMunicipioOrigen.Location = New System.Drawing.Point(54, 20)
        Me.TxtMunicipioOrigen.Name = "TxtMunicipioOrigen"
        Me.TxtMunicipioOrigen.ReadOnly = True
        Me.TxtMunicipioOrigen.Size = New System.Drawing.Size(246, 22)
        Me.TxtMunicipioOrigen.TabIndex = 12
        '
        'BtnBuscaCiudad
        '
        Me.BtnBuscaCiudad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscaCiudad.FlatAppearance.BorderSize = 0
        Me.BtnBuscaCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaCiudad.Image = CType(resources.GetObject("BtnBuscaCiudad.Image"), System.Drawing.Image)
        Me.BtnBuscaCiudad.Location = New System.Drawing.Point(12, 19)
        Me.BtnBuscaCiudad.Name = "BtnBuscaCiudad"
        Me.BtnBuscaCiudad.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscaCiudad.TabIndex = 11
        Me.BtnBuscaCiudad.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtKilometros)
        Me.GroupBox1.Location = New System.Drawing.Point(224, 286)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(94, 61)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KILOMETROS"
        '
        'TxtKilometros
        '
        Me.TxtKilometros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKilometros.Location = New System.Drawing.Point(7, 21)
        Me.TxtKilometros.MaxLength = 4
        Me.TxtKilometros.Name = "TxtKilometros"
        Me.TxtKilometros.Size = New System.Drawing.Size(76, 26)
        Me.TxtKilometros.TabIndex = 0
        Me.TxtKilometros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Controls.Add(Me.Label5)
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Controls.Add(Me.TxtTarifaTonelada)
        Me.GroupBox8.Controls.Add(Me.TxtTarifaFlete)
        Me.GroupBox8.Controls.Add(Me.TxtMargenPor)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.Label4)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.TxtMargenPesos)
        Me.GroupBox8.Controls.Add(Me.TxtCostoTonelada)
        Me.GroupBox8.Controls.Add(Me.TxtCostoFlete)
        Me.GroupBox8.Location = New System.Drawing.Point(324, 16)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(378, 330)
        Me.GroupBox8.TabIndex = 31
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "VALORES"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(330, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 25)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "%"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "TARIFA TONELADA :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "TARIFA FLETE :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtTarifaTonelada
        '
        Me.TxtTarifaTonelada.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTarifaTonelada.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTarifaTonelada.Location = New System.Drawing.Point(187, 270)
        Me.TxtTarifaTonelada.MaxLength = 15
        Me.TxtTarifaTonelada.Name = "TxtTarifaTonelada"
        Me.TxtTarifaTonelada.Size = New System.Drawing.Size(174, 31)
        Me.TxtTarifaTonelada.TabIndex = 12
        Me.TxtTarifaTonelada.Text = "$ 0"
        Me.TxtTarifaTonelada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTarifaFlete
        '
        Me.TxtTarifaFlete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtTarifaFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTarifaFlete.Location = New System.Drawing.Point(187, 233)
        Me.TxtTarifaFlete.MaxLength = 15
        Me.TxtTarifaFlete.Name = "TxtTarifaFlete"
        Me.TxtTarifaFlete.Size = New System.Drawing.Size(174, 31)
        Me.TxtTarifaFlete.TabIndex = 11
        Me.TxtTarifaFlete.Text = "$ 0"
        Me.TxtTarifaFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMargenPor
        '
        Me.TxtMargenPor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtMargenPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMargenPor.Location = New System.Drawing.Point(246, 110)
        Me.TxtMargenPor.MaxLength = 15
        Me.TxtMargenPor.Name = "TxtMargenPor"
        Me.TxtMargenPor.Size = New System.Drawing.Size(78, 31)
        Me.TxtMargenPor.TabIndex = 9
        Me.TxtMargenPor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "MARGEN (%) :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "MARGEN ($) :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "COSTO TONELADA :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "COSTO FLETE :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtMargenPesos
        '
        Me.TxtMargenPesos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtMargenPesos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMargenPesos.Location = New System.Drawing.Point(187, 157)
        Me.TxtMargenPesos.MaxLength = 15
        Me.TxtMargenPesos.Name = "TxtMargenPesos"
        Me.TxtMargenPesos.Size = New System.Drawing.Size(174, 31)
        Me.TxtMargenPesos.TabIndex = 10
        Me.TxtMargenPesos.Text = "$ 0"
        Me.TxtMargenPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtCostoTonelada
        '
        Me.TxtCostoTonelada.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCostoTonelada.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCostoTonelada.Location = New System.Drawing.Point(187, 69)
        Me.TxtCostoTonelada.MaxLength = 15
        Me.TxtCostoTonelada.Name = "TxtCostoTonelada"
        Me.TxtCostoTonelada.Size = New System.Drawing.Size(174, 31)
        Me.TxtCostoTonelada.TabIndex = 8
        Me.TxtCostoTonelada.Text = "$ 0"
        Me.TxtCostoTonelada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtCostoFlete
        '
        Me.TxtCostoFlete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtCostoFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCostoFlete.Location = New System.Drawing.Point(187, 32)
        Me.TxtCostoFlete.MaxLength = 15
        Me.TxtCostoFlete.Name = "TxtCostoFlete"
        Me.TxtCostoFlete.Size = New System.Drawing.Size(174, 31)
        Me.TxtCostoFlete.TabIndex = 7
        Me.TxtCostoFlete.Text = "$ 0"
        Me.TxtCostoFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.BackColor = System.Drawing.Color.Gray
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(570, 352)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(132, 50)
        Me.BtnEditar.TabIndex = 33
        Me.BtnEditar.Text = "Editar Tarifa"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnCrear
        '
        Me.BtnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCrear.BackColor = System.Drawing.Color.Gray
        Me.BtnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrear.ForeColor = System.Drawing.Color.White
        Me.BtnCrear.Image = CType(resources.GetObject("BtnCrear.Image"), System.Drawing.Image)
        Me.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrear.Location = New System.Drawing.Point(570, 352)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(132, 50)
        Me.BtnCrear.TabIndex = 32
        Me.BtnCrear.Text = "Crear Tarifa "
        Me.BtnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrear.UseVisualStyleBackColor = False
        '
        'LblIdTarifa
        '
        Me.LblIdTarifa.Location = New System.Drawing.Point(14, 368)
        Me.LblIdTarifa.Name = "LblIdTarifa"
        Me.LblIdTarifa.Size = New System.Drawing.Size(22, 18)
        Me.LblIdTarifa.TabIndex = 34
        Me.LblIdTarifa.Text = "0"
        Me.LblIdTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblIdTarifa.Visible = False
        '
        'For_TarifasCrearEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 409)
        Me.Controls.Add(Me.LblIdTarifa)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GbUnidad)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GbVehiculo)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GbDestino)
        Me.Controls.Add(Me.GbOrigen)
        Me.Controls.Add(Me.BtnEditar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_TarifasCrearEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Creación y Edición de Tarifas"
        Me.GbUnidad.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GbVehiculo.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GbDestino.ResumeLayout(False)
        Me.GbDestino.PerformLayout()
        Me.GbOrigen.ResumeLayout(False)
        Me.GbOrigen.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbUnidad As GroupBox
    Friend WithEvents CmbUnidad As ComboBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GbVehiculo As GroupBox
    Friend WithEvents CmbTipoVehiculo As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RBItr As RadioButton
    Friend WithEvents RBSpot As RadioButton
    Friend WithEvents GbDestino As GroupBox
    Friend WithEvents GbOrigen As GroupBox
    Friend WithEvents BtnBuscaCiudad As Button
    Friend WithEvents TxtCapacidad As TextBox
    Friend WithEvents BtnBuscaCiudad2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtKilometros As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTarifaTonelada As TextBox
    Friend WithEvents TxtTarifaFlete As TextBox
    Friend WithEvents TxtMargenPor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMargenPesos As TextBox
    Friend WithEvents TxtCostoTonelada As TextBox
    Friend WithEvents TxtCostoFlete As TextBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnCrear As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtMunicipioDestino As TextBox
    Friend WithEvents TxtMunicipioOrigen As TextBox
    Friend WithEvents LblIdTarifa As Label
End Class
