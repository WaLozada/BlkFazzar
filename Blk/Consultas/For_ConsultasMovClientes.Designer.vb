<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_ConsultasMovClientes
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_ConsultasMovClientes))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CalendarHasta = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CalendarDesde = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DGConsulta = New System.Windows.Forms.DataGridView()
        Me.ColFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIngresos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDespachos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSaldoAnterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNuevoSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtDeposito = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblNombreCliente = New System.Windows.Forms.Label()
        Me.TxtCodCliente = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbBodegas = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmbCentros = New System.Windows.Forms.ComboBox()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DGProductos = New System.Windows.Forms.DataGridView()
        Me.SDArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DGProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CalendarHasta)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 213)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(286, 195)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "HASTA"
        '
        'CalendarHasta
        '
        Me.CalendarHasta.Location = New System.Drawing.Point(16, 19)
        Me.CalendarHasta.Name = "CalendarHasta"
        Me.CalendarHasta.TabIndex = 12
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CalendarDesde)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(286, 195)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DESDE"
        '
        'CalendarDesde
        '
        Me.CalendarDesde.Location = New System.Drawing.Point(16, 19)
        Me.CalendarDesde.Name = "CalendarDesde"
        Me.CalendarDesde.TabIndex = 12
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.DGConsulta)
        Me.GroupBox4.Location = New System.Drawing.Point(314, 166)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(829, 242)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        '
        'DGConsulta
        '
        Me.DGConsulta.AllowUserToAddRows = False
        Me.DGConsulta.AllowUserToDeleteRows = False
        Me.DGConsulta.AllowUserToOrderColumns = True
        Me.DGConsulta.AllowUserToResizeColumns = False
        Me.DGConsulta.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGConsulta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGConsulta.BackgroundColor = System.Drawing.Color.White
        Me.DGConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColFecha, Me.ColCodigo, Me.ColProducto, Me.ColIngresos, Me.ColDespachos, Me.ColSaldoAnterior, Me.ColNuevoSaldo})
        Me.DGConsulta.Location = New System.Drawing.Point(10, 19)
        Me.DGConsulta.Name = "DGConsulta"
        Me.DGConsulta.ReadOnly = True
        Me.DGConsulta.RowHeadersVisible = False
        Me.DGConsulta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGConsulta.Size = New System.Drawing.Size(810, 211)
        Me.DGConsulta.TabIndex = 0
        '
        'ColFecha
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColFecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColFecha.HeaderText = "FECHA"
        Me.ColFecha.Name = "ColFecha"
        Me.ColFecha.ReadOnly = True
        Me.ColFecha.Width = 67
        '
        'ColCodigo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColCodigo.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColCodigo.HeaderText = "CODIGO"
        Me.ColCodigo.Name = "ColCodigo"
        Me.ColCodigo.ReadOnly = True
        Me.ColCodigo.Width = 74
        '
        'ColProducto
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ColProducto.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColProducto.HeaderText = "PRODUCTO"
        Me.ColProducto.Name = "ColProducto"
        Me.ColProducto.ReadOnly = True
        Me.ColProducto.Width = 93
        '
        'ColIngresos
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColIngresos.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColIngresos.HeaderText = "INGRESOS"
        Me.ColIngresos.Name = "ColIngresos"
        Me.ColIngresos.ReadOnly = True
        Me.ColIngresos.Width = 88
        '
        'ColDespachos
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColDespachos.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColDespachos.HeaderText = "DESPACHOS"
        Me.ColDespachos.Name = "ColDespachos"
        Me.ColDespachos.ReadOnly = True
        Me.ColDespachos.Width = 98
        '
        'ColSaldoAnterior
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColSaldoAnterior.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColSaldoAnterior.HeaderText = "SALDOANTERIOR"
        Me.ColSaldoAnterior.Name = "ColSaldoAnterior"
        Me.ColSaldoAnterior.ReadOnly = True
        Me.ColSaldoAnterior.Width = 124
        '
        'ColNuevoSaldo
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColNuevoSaldo.DefaultCellStyle = DataGridViewCellStyle8
        Me.ColNuevoSaldo.HeaderText = "NUEVOSALDO"
        Me.ColNuevoSaldo.Name = "ColNuevoSaldo"
        Me.ColNuevoSaldo.ReadOnly = True
        Me.ColNuevoSaldo.Width = 106
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcel.BackColor = System.Drawing.Color.Gray
        Me.BtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcel.ForeColor = System.Drawing.Color.White
        Me.BtnExcel.Image = CType(resources.GetObject("BtnExcel.Image"), System.Drawing.Image)
        Me.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcel.Location = New System.Drawing.Point(1002, 436)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(141, 57)
        Me.BtnExcel.TabIndex = 17
        Me.BtnExcel.Text = "Exportar Excel"
        Me.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtDeposito)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LblNombreCliente)
        Me.GroupBox1.Controls.Add(Me.TxtCodCliente)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(314, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 89)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CLIENTE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "CODIGO : "
        '
        'TxtDeposito
        '
        Me.TxtDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeposito.Location = New System.Drawing.Point(309, 17)
        Me.TxtDeposito.MaxLength = 30
        Me.TxtDeposito.Name = "TxtDeposito"
        Me.TxtDeposito.ReadOnly = True
        Me.TxtDeposito.Size = New System.Drawing.Size(94, 26)
        Me.TxtDeposito.TabIndex = 16
        Me.TxtDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(232, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "DEPOSITO : "
        '
        'LblNombreCliente
        '
        Me.LblNombreCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreCliente.Location = New System.Drawing.Point(48, 53)
        Me.LblNombreCliente.Name = "LblNombreCliente"
        Me.LblNombreCliente.Size = New System.Drawing.Size(629, 26)
        Me.LblNombreCliente.TabIndex = 13
        Me.LblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCodCliente
        '
        Me.TxtCodCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCodCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodCliente.Location = New System.Drawing.Point(112, 17)
        Me.TxtCodCliente.MaxLength = 30
        Me.TxtCodCliente.Name = "TxtCodCliente"
        Me.TxtCodCliente.ReadOnly = True
        Me.TxtCodCliente.Size = New System.Drawing.Size(96, 26)
        Me.TxtCodCliente.TabIndex = 12
        Me.TxtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(10, 18)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscar.TabIndex = 11
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbBodegas)
        Me.GroupBox2.Location = New System.Drawing.Point(635, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(371, 53)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BODEGA"
        '
        'CmbBodegas
        '
        Me.CmbBodegas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBodegas.FormattingEnabled = True
        Me.CmbBodegas.Location = New System.Drawing.Point(6, 18)
        Me.CmbBodegas.Name = "CmbBodegas"
        Me.CmbBodegas.Size = New System.Drawing.Size(350, 24)
        Me.CmbBodegas.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.CmbCentros)
        Me.GroupBox3.Location = New System.Drawing.Point(314, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 53)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CENTRO (CEDIS)"
        '
        'CmbCentros
        '
        Me.CmbCentros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCentros.FormattingEnabled = True
        Me.CmbCentros.Location = New System.Drawing.Point(17, 18)
        Me.CmbCentros.Name = "CmbCentros"
        Me.CmbCentros.Size = New System.Drawing.Size(286, 24)
        Me.CmbCentros.TabIndex = 0
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.Gray
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ForeColor = System.Drawing.Color.White
        Me.BtnConsultar.Image = CType(resources.GetObject("BtnConsultar.Image"), System.Drawing.Image)
        Me.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsultar.Location = New System.Drawing.Point(1012, 103)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(131, 57)
        Me.BtnConsultar.TabIndex = 21
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.DGProductos)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 414)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(286, 85)
        Me.GroupBox7.TabIndex = 22
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Visible = False
        '
        'DGProductos
        '
        Me.DGProductos.AllowUserToAddRows = False
        Me.DGProductos.AllowUserToDeleteRows = False
        Me.DGProductos.AllowUserToOrderColumns = True
        Me.DGProductos.AllowUserToResizeColumns = False
        Me.DGProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGProductos.BackgroundColor = System.Drawing.Color.White
        Me.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProductos.Location = New System.Drawing.Point(10, 19)
        Me.DGProductos.Name = "DGProductos"
        Me.DGProductos.ReadOnly = True
        Me.DGProductos.RowHeadersVisible = False
        Me.DGProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGProductos.Size = New System.Drawing.Size(267, 54)
        Me.DGProductos.TabIndex = 0
        '
        'For_ConsultasMovClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 505)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.MinimizeBox = False
        Me.Name = "For_ConsultasMovClientes"
        Me.Text = "Consultas de Movimientos por Clientes"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DGProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CalendarHasta As MonthCalendar
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CalendarDesde As MonthCalendar
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DGConsulta As DataGridView
    Friend WithEvents BtnExcel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtDeposito As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LblNombreCliente As Label
    Friend WithEvents TxtCodCliente As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbBodegas As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CmbCentros As ComboBox
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents DGProductos As DataGridView
    Friend WithEvents ColFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColCodigo As DataGridViewTextBoxColumn
    Friend WithEvents ColProducto As DataGridViewTextBoxColumn
    Friend WithEvents ColIngresos As DataGridViewTextBoxColumn
    Friend WithEvents ColDespachos As DataGridViewTextBoxColumn
    Friend WithEvents ColSaldoAnterior As DataGridViewTextBoxColumn
    Friend WithEvents ColNuevoSaldo As DataGridViewTextBoxColumn
    Friend WithEvents SDArchivo As SaveFileDialog
End Class
