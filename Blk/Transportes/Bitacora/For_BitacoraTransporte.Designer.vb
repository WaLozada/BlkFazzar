<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class For_BitacoraTransporte
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_BitacoraTransporte))
        Me.GBListado = New System.Windows.Forms.GroupBox()
        Me.DGInforme = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.CmbTipoVehiculo = New System.Windows.Forms.ComboBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.CmbTransportadora = New System.Windows.Forms.ComboBox()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.CmbTipoDespacho = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.CmbZona = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.LblDestino = New System.Windows.Forms.Label()
        Me.BtnBuscaDestino = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LblOrigen = New System.Windows.Forms.Label()
        Me.BtnBuscaOrigen = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DTFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DTFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.SDArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.BtnInformes = New System.Windows.Forms.Button()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.BtnDetalleCobros = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtManifiesto = New System.Windows.Forms.TextBox()
        Me.GBListado.SuspendLayout()
        CType(Me.DGInforme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBListado
        '
        Me.GBListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBListado.Controls.Add(Me.DGInforme)
        Me.GBListado.Location = New System.Drawing.Point(335, 13)
        Me.GBListado.Name = "GBListado"
        Me.GBListado.Size = New System.Drawing.Size(872, 462)
        Me.GBListado.TabIndex = 23
        Me.GBListado.TabStop = False
        Me.GBListado.Text = "Despachos"
        '
        'DGInforme
        '
        Me.DGInforme.AllowUserToAddRows = False
        Me.DGInforme.AllowUserToDeleteRows = False
        Me.DGInforme.AllowUserToOrderColumns = True
        Me.DGInforme.AllowUserToResizeColumns = False
        Me.DGInforme.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGInforme.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGInforme.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGInforme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGInforme.BackgroundColor = System.Drawing.Color.White
        Me.DGInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGInforme.Location = New System.Drawing.Point(10, 19)
        Me.DGInforme.Name = "DGInforme"
        Me.DGInforme.ReadOnly = True
        Me.DGInforme.RowHeadersVisible = False
        Me.DGInforme.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGInforme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGInforme.Size = New System.Drawing.Size(853, 437)
        Me.DGInforme.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox2.Controls.Add(Me.GroupBox11)
        Me.GroupBox2.Controls.Add(Me.GroupBox10)
        Me.GroupBox2.Controls.Add(Me.BtnConsultar)
        Me.GroupBox2.Controls.Add(Me.GroupBox9)
        Me.GroupBox2.Controls.Add(Me.GroupBox8)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 521)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FILTROS"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Gray
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(13, 460)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(149, 53)
        Me.BtnLimpiar.TabIndex = 11
        Me.BtnLimpiar.Text = "Limpiar Consulta"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.CmbTipoVehiculo)
        Me.GroupBox11.Location = New System.Drawing.Point(146, 286)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(167, 52)
        Me.GroupBox11.TabIndex = 7
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Tipo Vehiculo"
        '
        'CmbTipoVehiculo
        '
        Me.CmbTipoVehiculo.FormattingEnabled = True
        Me.CmbTipoVehiculo.Items.AddRange(New Object() {"Cautivo", "Spot"})
        Me.CmbTipoVehiculo.Location = New System.Drawing.Point(9, 20)
        Me.CmbTipoVehiculo.Name = "CmbTipoVehiculo"
        Me.CmbTipoVehiculo.Size = New System.Drawing.Size(152, 21)
        Me.CmbTipoVehiculo.TabIndex = 0
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.CmbTransportadora)
        Me.GroupBox10.Location = New System.Drawing.Point(13, 402)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(300, 52)
        Me.GroupBox10.TabIndex = 10
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Empresa de Transporte"
        '
        'CmbTransportadora
        '
        Me.CmbTransportadora.FormattingEnabled = True
        Me.CmbTransportadora.Location = New System.Drawing.Point(9, 20)
        Me.CmbTransportadora.Name = "CmbTransportadora"
        Me.CmbTransportadora.Size = New System.Drawing.Size(282, 21)
        Me.CmbTransportadora.TabIndex = 0
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.Gray
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ForeColor = System.Drawing.Color.White
        Me.BtnConsultar.Image = CType(resources.GetObject("BtnConsultar.Image"), System.Drawing.Image)
        Me.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsultar.Location = New System.Drawing.Point(168, 460)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(145, 53)
        Me.BtnConsultar.TabIndex = 12
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.CmbTipoDespacho)
        Me.GroupBox9.Location = New System.Drawing.Point(13, 286)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(127, 52)
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Tipo Despacho"
        '
        'CmbTipoDespacho
        '
        Me.CmbTipoDespacho.FormattingEnabled = True
        Me.CmbTipoDespacho.Items.AddRange(New Object() {"Cautivo", "Spot"})
        Me.CmbTipoDespacho.Location = New System.Drawing.Point(9, 20)
        Me.CmbTipoDespacho.Name = "CmbTipoDespacho"
        Me.CmbTipoDespacho.Size = New System.Drawing.Size(112, 21)
        Me.CmbTipoDespacho.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.CmbZona)
        Me.GroupBox8.Location = New System.Drawing.Point(13, 344)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(183, 52)
        Me.GroupBox8.TabIndex = 8
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Zona"
        '
        'CmbZona
        '
        Me.CmbZona.FormattingEnabled = True
        Me.CmbZona.Location = New System.Drawing.Point(9, 20)
        Me.CmbZona.Name = "CmbZona"
        Me.CmbZona.Size = New System.Drawing.Size(174, 21)
        Me.CmbZona.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.LblDestino)
        Me.GroupBox7.Controls.Add(Me.BtnBuscaDestino)
        Me.GroupBox7.Location = New System.Drawing.Point(13, 219)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(300, 61)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Destino"
        '
        'LblDestino
        '
        Me.LblDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDestino.Location = New System.Drawing.Point(50, 16)
        Me.LblDestino.Name = "LblDestino"
        Me.LblDestino.Size = New System.Drawing.Size(240, 32)
        Me.LblDestino.TabIndex = 14
        Me.LblDestino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBuscaDestino
        '
        Me.BtnBuscaDestino.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscaDestino.FlatAppearance.BorderSize = 0
        Me.BtnBuscaDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaDestino.Image = CType(resources.GetObject("BtnBuscaDestino.Image"), System.Drawing.Image)
        Me.BtnBuscaDestino.Location = New System.Drawing.Point(6, 18)
        Me.BtnBuscaDestino.Name = "BtnBuscaDestino"
        Me.BtnBuscaDestino.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscaDestino.TabIndex = 12
        Me.BtnBuscaDestino.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LblOrigen)
        Me.GroupBox6.Controls.Add(Me.BtnBuscaOrigen)
        Me.GroupBox6.Location = New System.Drawing.Point(13, 152)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(300, 61)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Origen"
        '
        'LblOrigen
        '
        Me.LblOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblOrigen.Location = New System.Drawing.Point(50, 17)
        Me.LblOrigen.Name = "LblOrigen"
        Me.LblOrigen.Size = New System.Drawing.Size(240, 32)
        Me.LblOrigen.TabIndex = 13
        Me.LblOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBuscaOrigen
        '
        Me.BtnBuscaOrigen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscaOrigen.FlatAppearance.BorderSize = 0
        Me.BtnBuscaOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaOrigen.Image = CType(resources.GetObject("BtnBuscaOrigen.Image"), System.Drawing.Image)
        Me.BtnBuscaOrigen.Location = New System.Drawing.Point(6, 18)
        Me.BtnBuscaOrigen.Name = "BtnBuscaOrigen"
        Me.BtnBuscaOrigen.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscaOrigen.TabIndex = 12
        Me.BtnBuscaOrigen.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LblCliente)
        Me.GroupBox5.Controls.Add(Me.BtnBuscarCliente)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 85)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(300, 61)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cliente"
        '
        'LblCliente
        '
        Me.LblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCliente.Location = New System.Drawing.Point(48, 18)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(240, 32)
        Me.LblCliente.TabIndex = 14
        Me.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarCliente.FlatAppearance.BorderSize = 0
        Me.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarCliente.Image = CType(resources.GetObject("BtnBuscarCliente.Image"), System.Drawing.Image)
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(6, 18)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscarCliente.TabIndex = 12
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DTFechaHasta)
        Me.GroupBox4.Location = New System.Drawing.Point(168, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(149, 56)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hasta"
        '
        'DTFechaHasta
        '
        Me.DTFechaHasta.CustomFormat = "yyyy-MM-dd"
        Me.DTFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTFechaHasta.Location = New System.Drawing.Point(6, 19)
        Me.DTFechaHasta.Name = "DTFechaHasta"
        Me.DTFechaHasta.Size = New System.Drawing.Size(134, 29)
        Me.DTFechaHasta.TabIndex = 17
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DTFechaDesde)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(149, 56)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Desde"
        '
        'DTFechaDesde
        '
        Me.DTFechaDesde.CustomFormat = "yyyy-MM-dd"
        Me.DTFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTFechaDesde.Location = New System.Drawing.Point(6, 19)
        Me.DTFechaDesde.Name = "DTFechaDesde"
        Me.DTFechaDesde.Size = New System.Drawing.Size(134, 29)
        Me.DTFechaDesde.TabIndex = 17
        '
        'BtnInformes
        '
        Me.BtnInformes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnInformes.BackColor = System.Drawing.Color.Gray
        Me.BtnInformes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInformes.ForeColor = System.Drawing.Color.White
        Me.BtnInformes.Image = CType(resources.GetObject("BtnInformes.Image"), System.Drawing.Image)
        Me.BtnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInformes.Location = New System.Drawing.Point(482, 480)
        Me.BtnInformes.Name = "BtnInformes"
        Me.BtnInformes.Size = New System.Drawing.Size(177, 50)
        Me.BtnInformes.TabIndex = 14
        Me.BtnInformes.Text = "Informes Despacho"
        Me.BtnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInformes.UseVisualStyleBackColor = False
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnExcel.BackColor = System.Drawing.Color.Gray
        Me.BtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcel.ForeColor = System.Drawing.Color.White
        Me.BtnExcel.Image = CType(resources.GetObject("BtnExcel.Image"), System.Drawing.Image)
        Me.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcel.Location = New System.Drawing.Point(335, 481)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(141, 50)
        Me.BtnExcel.TabIndex = 13
        Me.BtnExcel.Text = "Exportar Excel"
        Me.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcel.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.BackColor = System.Drawing.Color.Gray
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(847, 481)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(177, 50)
        Me.BtnEditar.TabIndex = 16
        Me.BtnEditar.Text = "Editar Despacho"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRegistrar.BackColor = System.Drawing.Color.Gray
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Image = CType(resources.GetObject("BtnRegistrar.Image"), System.Drawing.Image)
        Me.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistrar.Location = New System.Drawing.Point(1030, 480)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(177, 50)
        Me.BtnRegistrar.TabIndex = 17
        Me.BtnRegistrar.Text = "Registrar Despacho"
        Me.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'BtnDetalleCobros
        '
        Me.BtnDetalleCobros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDetalleCobros.BackColor = System.Drawing.Color.Gray
        Me.BtnDetalleCobros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDetalleCobros.ForeColor = System.Drawing.Color.White
        Me.BtnDetalleCobros.Image = CType(resources.GetObject("BtnDetalleCobros.Image"), System.Drawing.Image)
        Me.BtnDetalleCobros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDetalleCobros.Location = New System.Drawing.Point(664, 480)
        Me.BtnDetalleCobros.Name = "BtnDetalleCobros"
        Me.BtnDetalleCobros.Size = New System.Drawing.Size(177, 50)
        Me.BtnDetalleCobros.TabIndex = 15
        Me.BtnDetalleCobros.Text = "Detalle Cobros Adicionales"
        Me.BtnDetalleCobros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDetalleCobros.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtManifiesto)
        Me.GroupBox1.Location = New System.Drawing.Point(202, 344)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(111, 52)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manifiesto"
        '
        'TxtManifiesto
        '
        Me.TxtManifiesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtManifiesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtManifiesto.Location = New System.Drawing.Point(6, 21)
        Me.TxtManifiesto.MaxLength = 15
        Me.TxtManifiesto.Name = "TxtManifiesto"
        Me.TxtManifiesto.Size = New System.Drawing.Size(97, 22)
        Me.TxtManifiesto.TabIndex = 0
        Me.TxtManifiesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'For_BitacoraTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 542)
        Me.Controls.Add(Me.BtnDetalleCobros)
        Me.Controls.Add(Me.BtnInformes)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBListado)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.MinimizeBox = False
        Me.Name = "For_BitacoraTransporte"
        Me.Text = "Bitacora de Transporte"
        Me.GBListado.ResumeLayout(False)
        CType(Me.DGInforme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents GBListado As GroupBox
    Friend WithEvents DGInforme As DataGridView
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DTFechaHasta As DateTimePicker
    Friend WithEvents DTFechaDesde As DateTimePicker
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents CmbTransportadora As ComboBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents CmbTipoDespacho As ComboBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents CmbZona As ComboBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents BtnBuscaDestino As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents BtnBuscaOrigen As Button
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents CmbTipoVehiculo As ComboBox
    Friend WithEvents LblDestino As Label
    Friend WithEvents LblOrigen As Label
    Friend WithEvents LblCliente As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnExcel As Button
    Friend WithEvents SDArchivo As SaveFileDialog
    Friend WithEvents BtnInformes As Button
    Friend WithEvents BtnDetalleCobros As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtManifiesto As TextBox
End Class
