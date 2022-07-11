<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_EquiposRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_EquiposRegistro))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.RBInactivo = New System.Windows.Forms.RadioButton()
        Me.RBActivo = New System.Windows.Forms.RadioButton()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.LblFechaCompra = New System.Windows.Forms.Label()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.LblProveedor = New System.Windows.Forms.Label()
        Me.BtnBuscarProv = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.MCalendar = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TxtFactura = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.DGCaracteristicas = New System.Windows.Forms.DataGridView()
        Me.ColIdCaracteristica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCaracteristica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIdDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.CmbDetalle = New System.Windows.Forms.ComboBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.CmbCaracteristica = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.LblLugar = New System.Windows.Forms.Label()
        Me.CmbLugar = New System.Windows.Forms.ComboBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscaResp = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtResponsable = New System.Windows.Forms.TextBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.LblArea = New System.Windows.Forms.Label()
        Me.CmbArea = New System.Windows.Forms.ComboBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscaCiudad = New System.Windows.Forms.Button()
        Me.TxtMunicipio = New System.Windows.Forms.TextBox()
        Me.TxtDivipol = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDepto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPais = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtActivo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnAddModelo = New System.Windows.Forms.Button()
        Me.LblModelo = New System.Windows.Forms.Label()
        Me.CmbModelo = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtSerial = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.CmbMarca = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGCaracteristicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblTipo)
        Me.GroupBox1.Controls.Add(Me.CmbTipo)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 57)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIPO ACTIVO"
        '
        'LblTipo
        '
        Me.LblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipo.Location = New System.Drawing.Point(254, 18)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(224, 25)
        Me.LblTipo.TabIndex = 1
        Me.LblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbTipo
        '
        Me.CmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Location = New System.Drawing.Point(16, 20)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(230, 24)
        Me.CmbTipo.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox15)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.GroupBox9)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 505)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.RBInactivo)
        Me.GroupBox15.Controls.Add(Me.RBActivo)
        Me.GroupBox15.Location = New System.Drawing.Point(825, 140)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(182, 57)
        Me.GroupBox15.TabIndex = 13
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "ESTADO"
        '
        'RBInactivo
        '
        Me.RBInactivo.AutoSize = True
        Me.RBInactivo.Location = New System.Drawing.Point(99, 26)
        Me.RBInactivo.Name = "RBInactivo"
        Me.RBInactivo.Size = New System.Drawing.Size(75, 17)
        Me.RBInactivo.TabIndex = 1
        Me.RBInactivo.Text = "INACTIVO"
        Me.RBInactivo.UseVisualStyleBackColor = True
        '
        'RBActivo
        '
        Me.RBActivo.AutoSize = True
        Me.RBActivo.Checked = True
        Me.RBActivo.Location = New System.Drawing.Point(19, 26)
        Me.RBActivo.Name = "RBActivo"
        Me.RBActivo.Size = New System.Drawing.Size(64, 17)
        Me.RBActivo.TabIndex = 0
        Me.RBActivo.TabStop = True
        Me.RBActivo.Text = "ACTIVO"
        Me.RBActivo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Gray
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(906, 433)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(152, 64)
        Me.BtnGuardar.TabIndex = 12
        Me.BtnGuardar.Text = "Guardar Activo"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(749, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(295, 28)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "REGISTRO DE ACTIVOS"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.ItemSize = New System.Drawing.Size(290, 25)
        Me.TabControl1.Location = New System.Drawing.Point(19, 209)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(881, 292)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox17)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(873, 259)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DETALLE DE LA COMPRA"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.LblFechaCompra)
        Me.GroupBox7.Location = New System.Drawing.Point(316, 14)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(183, 61)
        Me.GroupBox7.TabIndex = 10
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "FECHA FACTURA"
        '
        'LblFechaCompra
        '
        Me.LblFechaCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFechaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaCompra.Location = New System.Drawing.Point(31, 16)
        Me.LblFechaCompra.Name = "LblFechaCompra"
        Me.LblFechaCompra.Size = New System.Drawing.Size(123, 38)
        Me.LblFechaCompra.TabIndex = 6
        Me.LblFechaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.LblProveedor)
        Me.GroupBox17.Controls.Add(Me.BtnBuscarProv)
        Me.GroupBox17.Location = New System.Drawing.Point(309, 82)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(558, 53)
        Me.GroupBox17.TabIndex = 9
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "PROVEEDOR"
        '
        'LblProveedor
        '
        Me.LblProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProveedor.Location = New System.Drawing.Point(44, 19)
        Me.LblProveedor.Name = "LblProveedor"
        Me.LblProveedor.Size = New System.Drawing.Size(508, 26)
        Me.LblProveedor.TabIndex = 14
        Me.LblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnBuscarProv
        '
        Me.BtnBuscarProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarProv.FlatAppearance.BorderSize = 0
        Me.BtnBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarProv.Image = CType(resources.GetObject("BtnBuscarProv.Image"), System.Drawing.Image)
        Me.BtnBuscarProv.Location = New System.Drawing.Point(6, 15)
        Me.BtnBuscarProv.Name = "BtnBuscarProv"
        Me.BtnBuscarProv.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscarProv.TabIndex = 12
        Me.BtnBuscarProv.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.MCalendar)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(293, 245)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "FECHA FACTURA"
        '
        'MCalendar
        '
        Me.MCalendar.Location = New System.Drawing.Point(24, 49)
        Me.MCalendar.Name = "MCalendar"
        Me.MCalendar.TabIndex = 4
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TxtObservaciones)
        Me.GroupBox8.Location = New System.Drawing.Point(307, 141)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(560, 110)
        Me.GroupBox8.TabIndex = 8
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "OBSERVACIONES"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservaciones.Location = New System.Drawing.Point(6, 19)
        Me.TxtObservaciones.MaxLength = 250
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(548, 85)
        Me.TxtObservaciones.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtFactura)
        Me.GroupBox6.Location = New System.Drawing.Point(508, 14)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(230, 62)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "NUMERO DE FACTURA"
        '
        'TxtFactura
        '
        Me.TxtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFactura.Location = New System.Drawing.Point(6, 19)
        Me.TxtFactura.MaxLength = 15
        Me.TxtFactura.Name = "TxtFactura"
        Me.TxtFactura.Size = New System.Drawing.Size(204, 29)
        Me.TxtFactura.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnAdicionar)
        Me.TabPage2.Controls.Add(Me.DGCaracteristicas)
        Me.TabPage2.Controls.Add(Me.GroupBox11)
        Me.TabPage2.Controls.Add(Me.GroupBox10)
        Me.TabPage2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(873, 259)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CARACTERISTICAS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdicionar.BackColor = System.Drawing.Color.Gray
        Me.BtnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdicionar.ForeColor = System.Drawing.Color.White
        Me.BtnAdicionar.Image = CType(resources.GetObject("BtnAdicionar.Image"), System.Drawing.Image)
        Me.BtnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdicionar.Location = New System.Drawing.Point(744, 15)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(110, 57)
        Me.BtnAdicionar.TabIndex = 14
        Me.BtnAdicionar.Text = "Adicionar"
        Me.BtnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdicionar.UseVisualStyleBackColor = False
        '
        'DGCaracteristicas
        '
        Me.DGCaracteristicas.AllowUserToAddRows = False
        Me.DGCaracteristicas.AllowUserToDeleteRows = False
        Me.DGCaracteristicas.AllowUserToOrderColumns = True
        Me.DGCaracteristicas.AllowUserToResizeColumns = False
        Me.DGCaracteristicas.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGCaracteristicas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGCaracteristicas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGCaracteristicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGCaracteristicas.BackgroundColor = System.Drawing.Color.White
        Me.DGCaracteristicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCaracteristicas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColIdCaracteristica, Me.ColCaracteristica, Me.ColIdDetalle, Me.ColDetalle})
        Me.DGCaracteristicas.Location = New System.Drawing.Point(18, 78)
        Me.DGCaracteristicas.MultiSelect = False
        Me.DGCaracteristicas.Name = "DGCaracteristicas"
        Me.DGCaracteristicas.ReadOnly = True
        Me.DGCaracteristicas.RowHeadersVisible = False
        Me.DGCaracteristicas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGCaracteristicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGCaracteristicas.Size = New System.Drawing.Size(831, 175)
        Me.DGCaracteristicas.TabIndex = 3
        '
        'ColIdCaracteristica
        '
        Me.ColIdCaracteristica.HeaderText = "IDCARACTERISTICA"
        Me.ColIdCaracteristica.Name = "ColIdCaracteristica"
        Me.ColIdCaracteristica.ReadOnly = True
        Me.ColIdCaracteristica.Visible = False
        Me.ColIdCaracteristica.Width = 116
        '
        'ColCaracteristica
        '
        Me.ColCaracteristica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColCaracteristica.HeaderText = "CARACTERISTICA"
        Me.ColCaracteristica.Name = "ColCaracteristica"
        Me.ColCaracteristica.ReadOnly = True
        Me.ColCaracteristica.Width = 200
        '
        'ColIdDetalle
        '
        Me.ColIdDetalle.HeaderText = "IDDETALLE"
        Me.ColIdDetalle.Name = "ColIdDetalle"
        Me.ColIdDetalle.ReadOnly = True
        Me.ColIdDetalle.Visible = False
        Me.ColIdDetalle.Width = 91
        '
        'ColDetalle
        '
        Me.ColDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColDetalle.HeaderText = "DETALLE"
        Me.ColDetalle.Name = "ColDetalle"
        Me.ColDetalle.ReadOnly = True
        Me.ColDetalle.Width = 600
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.CmbDetalle)
        Me.GroupBox11.Location = New System.Drawing.Point(283, 15)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(455, 57)
        Me.GroupBox11.TabIndex = 2
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "DETALLE"
        '
        'CmbDetalle
        '
        Me.CmbDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDetalle.FormattingEnabled = True
        Me.CmbDetalle.Location = New System.Drawing.Point(16, 20)
        Me.CmbDetalle.Name = "CmbDetalle"
        Me.CmbDetalle.Size = New System.Drawing.Size(426, 24)
        Me.CmbDetalle.TabIndex = 0
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.CmbCaracteristica)
        Me.GroupBox10.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(259, 57)
        Me.GroupBox10.TabIndex = 1
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "CARACTERISTICA"
        '
        'CmbCaracteristica
        '
        Me.CmbCaracteristica.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCaracteristica.FormattingEnabled = True
        Me.CmbCaracteristica.Location = New System.Drawing.Point(16, 20)
        Me.CmbCaracteristica.Name = "CmbCaracteristica"
        Me.CmbCaracteristica.Size = New System.Drawing.Size(231, 24)
        Me.CmbCaracteristica.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox16)
        Me.TabPage3.Controls.Add(Me.GroupBox14)
        Me.TabPage3.Controls.Add(Me.GroupBox12)
        Me.TabPage3.Controls.Add(Me.GroupBox13)
        Me.TabPage3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(873, 259)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "UBICACIÓN"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.LblLugar)
        Me.GroupBox16.Controls.Add(Me.CmbLugar)
        Me.GroupBox16.Location = New System.Drawing.Point(553, 17)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(307, 99)
        Me.GroupBox16.TabIndex = 9
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "LUGAR"
        '
        'LblLugar
        '
        Me.LblLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLugar.Location = New System.Drawing.Point(12, 53)
        Me.LblLugar.Name = "LblLugar"
        Me.LblLugar.Size = New System.Drawing.Size(289, 41)
        Me.LblLugar.TabIndex = 2
        Me.LblLugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbLugar
        '
        Me.CmbLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLugar.FormattingEnabled = True
        Me.CmbLugar.Location = New System.Drawing.Point(10, 21)
        Me.CmbLugar.Name = "CmbLugar"
        Me.CmbLugar.Size = New System.Drawing.Size(293, 24)
        Me.CmbLugar.TabIndex = 1
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.BtnBuscaResp)
        Me.GroupBox14.Controls.Add(Me.Label7)
        Me.GroupBox14.Controls.Add(Me.TxtResponsable)
        Me.GroupBox14.Location = New System.Drawing.Point(8, 178)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(539, 60)
        Me.GroupBox14.TabIndex = 8
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "RESPONSABLE"
        '
        'BtnBuscaResp
        '
        Me.BtnBuscaResp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscaResp.FlatAppearance.BorderSize = 0
        Me.BtnBuscaResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaResp.Image = CType(resources.GetObject("BtnBuscaResp.Image"), System.Drawing.Image)
        Me.BtnBuscaResp.Location = New System.Drawing.Point(6, 17)
        Me.BtnBuscaResp.Name = "BtnBuscaResp"
        Me.BtnBuscaResp.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscaResp.TabIndex = 13
        Me.BtnBuscaResp.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "NOMBRE"
        '
        'TxtResponsable
        '
        Me.TxtResponsable.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResponsable.Location = New System.Drawing.Point(106, 19)
        Me.TxtResponsable.MaxLength = 50
        Me.TxtResponsable.Name = "TxtResponsable"
        Me.TxtResponsable.ReadOnly = True
        Me.TxtResponsable.Size = New System.Drawing.Size(427, 26)
        Me.TxtResponsable.TabIndex = 11
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.LblArea)
        Me.GroupBox12.Controls.Add(Me.CmbArea)
        Me.GroupBox12.Location = New System.Drawing.Point(553, 130)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(307, 99)
        Me.GroupBox12.TabIndex = 7
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "AREA"
        '
        'LblArea
        '
        Me.LblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblArea.Location = New System.Drawing.Point(12, 58)
        Me.LblArea.Name = "LblArea"
        Me.LblArea.Size = New System.Drawing.Size(289, 25)
        Me.LblArea.TabIndex = 2
        Me.LblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbArea
        '
        Me.CmbArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbArea.FormattingEnabled = True
        Me.CmbArea.Items.AddRange(New Object() {"ADMINISTRATIVA", "FINANZAS", "GESTION HUMANA", "HSEQ", "OPERACIONES", "TECNOLOGIA", "TRANSPORTE", "OTRA", "", "", ""})
        Me.CmbArea.Location = New System.Drawing.Point(10, 21)
        Me.CmbArea.Name = "CmbArea"
        Me.CmbArea.Size = New System.Drawing.Size(291, 24)
        Me.CmbArea.TabIndex = 1
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.BtnBuscaCiudad)
        Me.GroupBox13.Controls.Add(Me.TxtMunicipio)
        Me.GroupBox13.Controls.Add(Me.TxtDivipol)
        Me.GroupBox13.Controls.Add(Me.Label5)
        Me.GroupBox13.Controls.Add(Me.TxtDepto)
        Me.GroupBox13.Controls.Add(Me.Label4)
        Me.GroupBox13.Controls.Add(Me.Label6)
        Me.GroupBox13.Controls.Add(Me.TxtPais)
        Me.GroupBox13.Location = New System.Drawing.Point(8, 14)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(539, 158)
        Me.GroupBox13.TabIndex = 6
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "UBICACION"
        '
        'BtnBuscaCiudad
        '
        Me.BtnBuscaCiudad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscaCiudad.FlatAppearance.BorderSize = 0
        Me.BtnBuscaCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaCiudad.Image = CType(resources.GetObject("BtnBuscaCiudad.Image"), System.Drawing.Image)
        Me.BtnBuscaCiudad.Location = New System.Drawing.Point(17, 29)
        Me.BtnBuscaCiudad.Name = "BtnBuscaCiudad"
        Me.BtnBuscaCiudad.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscaCiudad.TabIndex = 10
        Me.BtnBuscaCiudad.UseVisualStyleBackColor = True
        '
        'TxtMunicipio
        '
        Me.TxtMunicipio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMunicipio.Location = New System.Drawing.Point(242, 76)
        Me.TxtMunicipio.MaxLength = 50
        Me.TxtMunicipio.Name = "TxtMunicipio"
        Me.TxtMunicipio.ReadOnly = True
        Me.TxtMunicipio.Size = New System.Drawing.Size(291, 26)
        Me.TxtMunicipio.TabIndex = 7
        '
        'TxtDivipol
        '
        Me.TxtDivipol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDivipol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDivipol.Location = New System.Drawing.Point(158, 76)
        Me.TxtDivipol.MaxLength = 5
        Me.TxtDivipol.Name = "TxtDivipol"
        Me.TxtDivipol.ReadOnly = True
        Me.TxtDivipol.Size = New System.Drawing.Size(78, 26)
        Me.TxtDivipol.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "MUNICIPIO :"
        '
        'TxtDepto
        '
        Me.TxtDepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDepto.Location = New System.Drawing.Point(158, 29)
        Me.TxtDepto.MaxLength = 30
        Me.TxtDepto.Name = "TxtDepto"
        Me.TxtDepto.ReadOnly = True
        Me.TxtDepto.Size = New System.Drawing.Size(375, 26)
        Me.TxtDepto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DEPARTAMENTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(346, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "PAIS"
        '
        'TxtPais
        '
        Me.TxtPais.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPais.Location = New System.Drawing.Point(383, 116)
        Me.TxtPais.MaxLength = 15
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.ReadOnly = True
        Me.TxtPais.Size = New System.Drawing.Size(150, 26)
        Me.TxtPais.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.BtnBuscar)
        Me.GroupBox9.Controls.Add(Me.TxtActivo)
        Me.GroupBox9.Location = New System.Drawing.Point(15, 14)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(151, 57)
        Me.GroupBox9.TabIndex = 9
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "No. ACTIVO"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(104, 15)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscar.TabIndex = 12
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtActivo
        '
        Me.TxtActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtActivo.Location = New System.Drawing.Point(6, 18)
        Me.TxtActivo.MaxLength = 5
        Me.TxtActivo.Name = "TxtActivo"
        Me.TxtActivo.Size = New System.Drawing.Size(92, 29)
        Me.TxtActivo.TabIndex = 0
        Me.TxtActivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnAddModelo)
        Me.GroupBox3.Controls.Add(Me.LblModelo)
        Me.GroupBox3.Controls.Add(Me.CmbModelo)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 140)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(539, 57)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MODELO"
        '
        'BtnAddModelo
        '
        Me.BtnAddModelo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddModelo.FlatAppearance.BorderSize = 0
        Me.BtnAddModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddModelo.Image = CType(resources.GetObject("BtnAddModelo.Image"), System.Drawing.Image)
        Me.BtnAddModelo.Location = New System.Drawing.Point(16, 18)
        Me.BtnAddModelo.Name = "BtnAddModelo"
        Me.BtnAddModelo.Size = New System.Drawing.Size(27, 27)
        Me.BtnAddModelo.TabIndex = 13
        Me.BtnAddModelo.UseVisualStyleBackColor = True
        '
        'LblModelo
        '
        Me.LblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModelo.Location = New System.Drawing.Point(300, 18)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(224, 25)
        Me.LblModelo.TabIndex = 2
        Me.LblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbModelo
        '
        Me.CmbModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbModelo.FormattingEnabled = True
        Me.CmbModelo.Location = New System.Drawing.Point(58, 20)
        Me.CmbModelo.Name = "CmbModelo"
        Me.CmbModelo.Size = New System.Drawing.Size(230, 24)
        Me.CmbModelo.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtSerial)
        Me.GroupBox4.Location = New System.Drawing.Point(560, 140)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(259, 57)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SERIAL"
        '
        'TxtSerial
        '
        Me.TxtSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSerial.Location = New System.Drawing.Point(16, 19)
        Me.TxtSerial.MaxLength = 25
        Me.TxtSerial.Name = "TxtSerial"
        Me.TxtSerial.Size = New System.Drawing.Size(230, 23)
        Me.TxtSerial.TabIndex = 0
        Me.TxtSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblMarca)
        Me.GroupBox2.Controls.Add(Me.CmbMarca)
        Me.GroupBox2.Location = New System.Drawing.Point(515, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(492, 57)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MARCA"
        '
        'LblMarca
        '
        Me.LblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMarca.Location = New System.Drawing.Point(262, 19)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(224, 25)
        Me.LblMarca.TabIndex = 3
        Me.LblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbMarca
        '
        Me.CmbMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMarca.FormattingEnabled = True
        Me.CmbMarca.Location = New System.Drawing.Point(16, 20)
        Me.CmbMarca.Name = "CmbMarca"
        Me.CmbMarca.Size = New System.Drawing.Size(230, 24)
        Me.CmbMarca.TabIndex = 0
        '
        'For_EquiposRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 535)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_EquiposRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Activos"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DGCaracteristicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TxtFactura As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents MCalendar As MonthCalendar
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtSerial As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CmbModelo As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbMarca As ComboBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents TxtActivo As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LblFechaCompra As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents CmbDetalle As ComboBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents CmbCaracteristica As ComboBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DGCaracteristicas As DataGridView
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents BtnBuscaResp As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtResponsable As TextBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents CmbArea As ComboBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents BtnBuscaCiudad As Button
    Friend WithEvents TxtMunicipio As TextBox
    Friend WithEvents TxtDivipol As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDepto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPais As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents LblTipo As Label
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents RBInactivo As RadioButton
    Friend WithEvents RBActivo As RadioButton
    Friend WithEvents LblModelo As Label
    Friend WithEvents LblMarca As Label
    Friend WithEvents LblArea As Label
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents LblLugar As Label
    Friend WithEvents CmbLugar As ComboBox
    Friend WithEvents ColIdCaracteristica As DataGridViewTextBoxColumn
    Friend WithEvents ColCaracteristica As DataGridViewTextBoxColumn
    Friend WithEvents ColIdDetalle As DataGridViewTextBoxColumn
    Friend WithEvents ColDetalle As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents LblProveedor As Label
    Friend WithEvents BtnBuscarProv As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents BtnAddModelo As Button
End Class
