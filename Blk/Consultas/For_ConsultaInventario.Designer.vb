<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_ConsultaInventario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_ConsultaInventario))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbBodegas = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CmbCentros = New System.Windows.Forms.ComboBox()
        Me.DTFechaCorte = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGDepositos = New System.Windows.Forms.DataGridView()
        Me.DGInventario = New System.Windows.Forms.DataGridView()
        Me.SDArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.GBBloqueo = New System.Windows.Forms.GroupBox()
        Me.LblBultosBloqueo = New System.Windows.Forms.Label()
        Me.LblBloqueo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LblBultos = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DGRegistros = New System.Windows.Forms.DataGridView()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.BtnGeneral = New System.Windows.Forms.Button()
        Me.BtnDetalle = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBBloqueo.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbBodegas)
        Me.GroupBox2.Location = New System.Drawing.Point(358, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 53)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BODEGA"
        '
        'CmbBodegas
        '
        Me.CmbBodegas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBodegas.FormattingEnabled = True
        Me.CmbBodegas.Location = New System.Drawing.Point(6, 18)
        Me.CmbBodegas.Name = "CmbBodegas"
        Me.CmbBodegas.Size = New System.Drawing.Size(334, 24)
        Me.CmbBodegas.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.CmbCentros)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(340, 53)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CENTRO (CEDIS)"
        '
        'CmbCentros
        '
        Me.CmbCentros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCentros.FormattingEnabled = True
        Me.CmbCentros.Location = New System.Drawing.Point(17, 18)
        Me.CmbCentros.Name = "CmbCentros"
        Me.CmbCentros.Size = New System.Drawing.Size(315, 24)
        Me.CmbCentros.TabIndex = 0
        '
        'DTFechaCorte
        '
        Me.DTFechaCorte.CustomFormat = "yyyy-MM-dd"
        Me.DTFechaCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFechaCorte.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTFechaCorte.Location = New System.Drawing.Point(6, 17)
        Me.DTFechaCorte.Name = "DTFechaCorte"
        Me.DTFechaCorte.Size = New System.Drawing.Size(134, 29)
        Me.DTFechaCorte.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTFechaCorte)
        Me.GroupBox1.Location = New System.Drawing.Point(710, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 53)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FECHA DE CORTE"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DGDepositos)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(529, 354)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DEPOSITOS"
        '
        'DGDepositos
        '
        Me.DGDepositos.AllowUserToAddRows = False
        Me.DGDepositos.AllowUserToDeleteRows = False
        Me.DGDepositos.AllowUserToOrderColumns = True
        Me.DGDepositos.AllowUserToResizeColumns = False
        Me.DGDepositos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGDepositos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGDepositos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGDepositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGDepositos.BackgroundColor = System.Drawing.Color.White
        Me.DGDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDepositos.Location = New System.Drawing.Point(10, 19)
        Me.DGDepositos.Name = "DGDepositos"
        Me.DGDepositos.ReadOnly = True
        Me.DGDepositos.RowHeadersVisible = False
        Me.DGDepositos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGDepositos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGDepositos.Size = New System.Drawing.Size(507, 323)
        Me.DGDepositos.TabIndex = 0
        '
        'DGInventario
        '
        Me.DGInventario.AllowUserToAddRows = False
        Me.DGInventario.AllowUserToDeleteRows = False
        Me.DGInventario.AllowUserToOrderColumns = True
        Me.DGInventario.AllowUserToResizeColumns = False
        Me.DGInventario.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGInventario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGInventario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGInventario.BackgroundColor = System.Drawing.Color.White
        Me.DGInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGInventario.Location = New System.Drawing.Point(6, 6)
        Me.DGInventario.Name = "DGInventario"
        Me.DGInventario.ReadOnly = True
        Me.DGInventario.RowHeadersVisible = False
        Me.DGInventario.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGInventario.Size = New System.Drawing.Size(614, 295)
        Me.DGInventario.TabIndex = 0
        '
        'GBBloqueo
        '
        Me.GBBloqueo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GBBloqueo.Controls.Add(Me.LblBultosBloqueo)
        Me.GBBloqueo.Controls.Add(Me.LblBloqueo)
        Me.GBBloqueo.Controls.Add(Me.Label7)
        Me.GBBloqueo.Controls.Add(Me.Label3)
        Me.GBBloqueo.Controls.Add(Me.Label6)
        Me.GBBloqueo.Location = New System.Drawing.Point(523, 431)
        Me.GBBloqueo.Name = "GBBloqueo"
        Me.GBBloqueo.Size = New System.Drawing.Size(450, 57)
        Me.GBBloqueo.TabIndex = 30
        Me.GBBloqueo.TabStop = False
        '
        'LblBultosBloqueo
        '
        Me.LblBultosBloqueo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblBultosBloqueo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBultosBloqueo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblBultosBloqueo.Location = New System.Drawing.Point(357, 18)
        Me.LblBultosBloqueo.Name = "LblBultosBloqueo"
        Me.LblBultosBloqueo.Size = New System.Drawing.Size(84, 26)
        Me.LblBultosBloqueo.TabIndex = 35
        Me.LblBultosBloqueo.Text = "0"
        Me.LblBultosBloqueo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBloqueo
        '
        Me.LblBloqueo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblBloqueo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBloqueo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblBloqueo.Location = New System.Drawing.Point(112, 18)
        Me.LblBloqueo.Name = "LblBloqueo"
        Me.LblBloqueo.Size = New System.Drawing.Size(100, 26)
        Me.LblBloqueo.TabIndex = 34
        Me.LblBloqueo.Text = "0"
        Me.LblBloqueo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(266, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 19)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "BULTOS :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(216, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 19)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Kg"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 19)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "BLOQUEO :"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.LblBultos)
        Me.GroupBox6.Controls.Add(Me.LblTotal)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 430)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(505, 57)
        Me.GroupBox6.TabIndex = 29
        Me.GroupBox6.TabStop = False
        '
        'LblBultos
        '
        Me.LblBultos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblBultos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBultos.ForeColor = System.Drawing.Color.Green
        Me.LblBultos.Location = New System.Drawing.Point(398, 19)
        Me.LblBultos.Name = "LblBultos"
        Me.LblBultos.Size = New System.Drawing.Size(88, 27)
        Me.LblBultos.TabIndex = 31
        Me.LblBultos.Text = "0"
        Me.LblBultos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTotal
        '
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.Green
        Me.LblTotal.Location = New System.Drawing.Point(83, 18)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(181, 27)
        Me.LblTotal.TabIndex = 29
        Me.LblTotal.Text = "0"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(307, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "BULTOS :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(270, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 19)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Kg"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "TOTAL :"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ItemSize = New System.Drawing.Size(380, 25)
        Me.TabControl1.Location = New System.Drawing.Point(547, 73)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(634, 340)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 32
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGInventario)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(626, 307)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "INVENTARIO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGRegistros)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(626, 307)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "REGISTRO DE MOVIMIENTOS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DGRegistros
        '
        Me.DGRegistros.AllowUserToAddRows = False
        Me.DGRegistros.AllowUserToDeleteRows = False
        Me.DGRegistros.AllowUserToOrderColumns = True
        Me.DGRegistros.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGRegistros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGRegistros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGRegistros.BackgroundColor = System.Drawing.Color.White
        Me.DGRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRegistros.Location = New System.Drawing.Point(6, 6)
        Me.DGRegistros.Name = "DGRegistros"
        Me.DGRegistros.ReadOnly = True
        Me.DGRegistros.RowHeadersVisible = False
        Me.DGRegistros.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGRegistros.Size = New System.Drawing.Size(614, 295)
        Me.DGRegistros.TabIndex = 1
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcel.BackColor = System.Drawing.Color.Gray
        Me.BtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcel.ForeColor = System.Drawing.Color.White
        Me.BtnExcel.Image = CType(resources.GetObject("BtnExcel.Image"), System.Drawing.Image)
        Me.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcel.Location = New System.Drawing.Point(1040, 430)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(141, 57)
        Me.BtnExcel.TabIndex = 20
        Me.BtnExcel.Text = "Exportar Excel"
        Me.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcel.UseVisualStyleBackColor = False
        '
        'BtnGeneral
        '
        Me.BtnGeneral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGeneral.BackColor = System.Drawing.Color.Gray
        Me.BtnGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGeneral.ForeColor = System.Drawing.Color.White
        Me.BtnGeneral.Image = CType(resources.GetObject("BtnGeneral.Image"), System.Drawing.Image)
        Me.BtnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGeneral.Location = New System.Drawing.Point(979, 431)
        Me.BtnGeneral.Name = "BtnGeneral"
        Me.BtnGeneral.Size = New System.Drawing.Size(141, 57)
        Me.BtnGeneral.TabIndex = 31
        Me.BtnGeneral.Text = "Ver Total"
        Me.BtnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGeneral.UseVisualStyleBackColor = False
        Me.BtnGeneral.Visible = False
        '
        'BtnDetalle
        '
        Me.BtnDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDetalle.BackColor = System.Drawing.Color.Gray
        Me.BtnDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDetalle.ForeColor = System.Drawing.Color.White
        Me.BtnDetalle.Image = CType(resources.GetObject("BtnDetalle.Image"), System.Drawing.Image)
        Me.BtnDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDetalle.Location = New System.Drawing.Point(708, 431)
        Me.BtnDetalle.Name = "BtnDetalle"
        Me.BtnDetalle.Size = New System.Drawing.Size(141, 57)
        Me.BtnDetalle.TabIndex = 21
        Me.BtnDetalle.Text = "Ver Inventario"
        Me.BtnDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDetalle.UseVisualStyleBackColor = False
        Me.BtnDetalle.Visible = False
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.Gray
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ForeColor = System.Drawing.Color.White
        Me.BtnConsultar.Image = CType(resources.GetObject("BtnConsultar.Image"), System.Drawing.Image)
        Me.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsultar.Location = New System.Drawing.Point(865, 15)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(131, 53)
        Me.BtnConsultar.TabIndex = 18
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'For_ConsultaInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 495)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnGeneral)
        Me.Controls.Add(Me.GBBloqueo)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.BtnDetalle)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.MinimizeBox = False
        Me.Name = "For_ConsultaInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Reporte de Inventario"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBBloqueo.ResumeLayout(False)
        Me.GBBloqueo.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DGRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbBodegas As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CmbCentros As ComboBox
    Friend WithEvents DTFechaCorte As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGDepositos As DataGridView
    Friend WithEvents BtnDetalle As Button
    Friend WithEvents BtnExcel As Button
    Friend WithEvents DGInventario As DataGridView
    Friend WithEvents SDArchivo As SaveFileDialog
    Friend WithEvents GBBloqueo As GroupBox
    Friend WithEvents LblBultosBloqueo As Label
    Friend WithEvents LblBloqueo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LblBultos As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGeneral As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DGRegistros As DataGridView
End Class
