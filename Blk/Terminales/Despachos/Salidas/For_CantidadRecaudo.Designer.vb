<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_CantidadRecaudo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_CantidadRecaudo))
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TxtSumacantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtSumaservicios = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtTotalServicio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGTarifasServicios = New System.Windows.Forms.DataGridView()
        Me.ColdServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColValorTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtValorTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtValorUnitario = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblUnidad2 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CmbServicios = New System.Windows.Forms.ComboBox()
        Me.GBCobroServicio = New System.Windows.Forms.GroupBox()
        Me.LblUnidad = New System.Windows.Forms.Label()
        Me.TxtCantidadTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnTarifas = New System.Windows.Forms.Button()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGTarifasServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GBCobroServicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TxtSumacantidad)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Location = New System.Drawing.Point(406, 12)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(136, 56)
        Me.GroupBox8.TabIndex = 43
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "SUMA CANTIDAD"
        Me.GroupBox8.Visible = False
        '
        'TxtSumacantidad
        '
        Me.TxtSumacantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtSumacantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSumacantidad.Location = New System.Drawing.Point(24, 18)
        Me.TxtSumacantidad.Name = "TxtSumacantidad"
        Me.TxtSumacantidad.ReadOnly = True
        Me.TxtSumacantidad.Size = New System.Drawing.Size(96, 29)
        Me.TxtSumacantidad.TabIndex = 5
        Me.TxtSumacantidad.Text = "0"
        Me.TxtSumacantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 4
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtSumaservicios)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(264, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(136, 56)
        Me.GroupBox5.TabIndex = 42
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "SUMA SERVICIOS"
        Me.GroupBox5.Visible = False
        '
        'TxtSumaservicios
        '
        Me.TxtSumaservicios.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtSumaservicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSumaservicios.Location = New System.Drawing.Point(24, 18)
        Me.TxtSumaservicios.Name = "TxtSumaservicios"
        Me.TxtSumaservicios.ReadOnly = True
        Me.TxtSumaservicios.Size = New System.Drawing.Size(96, 29)
        Me.TxtSumaservicios.TabIndex = 5
        Me.TxtSumaservicios.Text = "0"
        Me.TxtSumaservicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtTotalServicio)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(666, 147)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(182, 56)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TOTAL SERVICIO DESCARGUE"
        '
        'TxtTotalServicio
        '
        Me.TxtTotalServicio.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTotalServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalServicio.ForeColor = System.Drawing.Color.Green
        Me.TxtTotalServicio.Location = New System.Drawing.Point(7, 18)
        Me.TxtTotalServicio.Name = "TxtTotalServicio"
        Me.TxtTotalServicio.ReadOnly = True
        Me.TxtTotalServicio.Size = New System.Drawing.Size(169, 32)
        Me.TxtTotalServicio.TabIndex = 5
        Me.TxtTotalServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGTarifasServicios)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(631, 128)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "COSTOS DESCARGUE"
        '
        'DGTarifasServicios
        '
        Me.DGTarifasServicios.AllowUserToAddRows = False
        Me.DGTarifasServicios.AllowUserToDeleteRows = False
        Me.DGTarifasServicios.AllowUserToOrderColumns = True
        Me.DGTarifasServicios.AllowUserToResizeColumns = False
        Me.DGTarifasServicios.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGTarifasServicios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGTarifasServicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGTarifasServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGTarifasServicios.BackgroundColor = System.Drawing.Color.White
        Me.DGTarifasServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColdServicio, Me.ColServicio, Me.ColCantidad, Me.ColValor, Me.ColValorTotal})
        Me.DGTarifasServicios.Location = New System.Drawing.Point(6, 19)
        Me.DGTarifasServicios.Name = "DGTarifasServicios"
        Me.DGTarifasServicios.ReadOnly = True
        Me.DGTarifasServicios.RowHeadersVisible = False
        Me.DGTarifasServicios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGTarifasServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGTarifasServicios.Size = New System.Drawing.Size(619, 103)
        Me.DGTarifasServicios.TabIndex = 1
        '
        'ColdServicio
        '
        Me.ColdServicio.HeaderText = "IDSERVICIO"
        Me.ColdServicio.Name = "ColdServicio"
        Me.ColdServicio.ReadOnly = True
        Me.ColdServicio.Visible = False
        Me.ColdServicio.Width = 93
        '
        'ColServicio
        '
        Me.ColServicio.HeaderText = "SERVICIO"
        Me.ColServicio.Name = "ColServicio"
        Me.ColServicio.ReadOnly = True
        Me.ColServicio.Width = 82
        '
        'ColCantidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColCantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColCantidad.HeaderText = "CANTIDAD"
        Me.ColCantidad.Name = "ColCantidad"
        Me.ColCantidad.ReadOnly = True
        Me.ColCantidad.Width = 87
        '
        'ColValor
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColValor.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColValor.HeaderText = "VALOR"
        Me.ColValor.Name = "ColValor"
        Me.ColValor.ReadOnly = True
        Me.ColValor.Width = 68
        '
        'ColValorTotal
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColValorTotal.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColValorTotal.HeaderText = "TOTAL"
        Me.ColValorTotal.Name = "ColValorTotal"
        Me.ColValorTotal.ReadOnly = True
        Me.ColValorTotal.Width = 67
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtValorTotal)
        Me.GroupBox2.Location = New System.Drawing.Point(606, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(154, 57)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TOTAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "$"
        '
        'TxtValorTotal
        '
        Me.TxtValorTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValorTotal.Location = New System.Drawing.Point(37, 19)
        Me.TxtValorTotal.Name = "TxtValorTotal"
        Me.TxtValorTotal.ReadOnly = True
        Me.TxtValorTotal.Size = New System.Drawing.Size(111, 29)
        Me.TxtValorTotal.TabIndex = 23
        Me.TxtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.TxtValorUnitario)
        Me.GroupBox7.Location = New System.Drawing.Point(446, 75)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(154, 57)
        Me.GroupBox7.TabIndex = 34
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "VALOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "$"
        '
        'TxtValorUnitario
        '
        Me.TxtValorUnitario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtValorUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValorUnitario.Location = New System.Drawing.Point(37, 19)
        Me.TxtValorUnitario.Name = "TxtValorUnitario"
        Me.TxtValorUnitario.ReadOnly = True
        Me.TxtValorUnitario.Size = New System.Drawing.Size(111, 29)
        Me.TxtValorUnitario.TabIndex = 23
        Me.TxtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblUnidad2)
        Me.GroupBox1.Controls.Add(Me.TxtCantidad)
        Me.GroupBox1.Location = New System.Drawing.Point(264, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 56)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CANTIDAD"
        '
        'LblUnidad2
        '
        Me.LblUnidad2.AutoSize = True
        Me.LblUnidad2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUnidad2.Location = New System.Drawing.Point(143, 21)
        Me.LblUnidad2.Name = "LblUnidad2"
        Me.LblUnidad2.Size = New System.Drawing.Size(25, 16)
        Me.LblUnidad2.TabIndex = 7
        Me.LblUnidad2.Text = "Kg"
        Me.LblUnidad2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.Location = New System.Drawing.Point(10, 17)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(126, 29)
        Me.TxtCantidad.TabIndex = 0
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CmbServicios)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(246, 57)
        Me.GroupBox6.TabIndex = 32
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "SERVICIO"
        '
        'CmbServicios
        '
        Me.CmbServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbServicios.FormattingEnabled = True
        Me.CmbServicios.Location = New System.Drawing.Point(11, 19)
        Me.CmbServicios.Name = "CmbServicios"
        Me.CmbServicios.Size = New System.Drawing.Size(229, 24)
        Me.CmbServicios.TabIndex = 1
        '
        'GBCobroServicio
        '
        Me.GBCobroServicio.Controls.Add(Me.LblUnidad)
        Me.GBCobroServicio.Controls.Add(Me.TxtCantidadTotal)
        Me.GBCobroServicio.Controls.Add(Me.Label11)
        Me.GBCobroServicio.Location = New System.Drawing.Point(12, 12)
        Me.GBCobroServicio.Name = "GBCobroServicio"
        Me.GBCobroServicio.Size = New System.Drawing.Size(197, 56)
        Me.GBCobroServicio.TabIndex = 39
        Me.GBCobroServicio.TabStop = False
        Me.GBCobroServicio.Text = "CANTIDAD TOTAL A DESCARGAR"
        '
        'LblUnidad
        '
        Me.LblUnidad.AutoSize = True
        Me.LblUnidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUnidad.Location = New System.Drawing.Point(136, 27)
        Me.LblUnidad.Name = "LblUnidad"
        Me.LblUnidad.Size = New System.Drawing.Size(25, 16)
        Me.LblUnidad.TabIndex = 6
        Me.LblUnidad.Text = "Kg"
        Me.LblUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCantidadTotal
        '
        Me.TxtCantidadTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtCantidadTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadTotal.Location = New System.Drawing.Point(24, 18)
        Me.TxtCantidadTotal.Name = "TxtCantidadTotal"
        Me.TxtCantidadTotal.ReadOnly = True
        Me.TxtCantidadTotal.Size = New System.Drawing.Size(96, 29)
        Me.TxtCantidadTotal.TabIndex = 5
        Me.TxtCantidadTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 20)
        Me.Label11.TabIndex = 4
        '
        'BtnTarifas
        '
        Me.BtnTarifas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnTarifas.BackColor = System.Drawing.Color.Gray
        Me.BtnTarifas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTarifas.ForeColor = System.Drawing.Color.White
        Me.BtnTarifas.Image = CType(resources.GetObject("BtnTarifas.Image"), System.Drawing.Image)
        Me.BtnTarifas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTarifas.Location = New System.Drawing.Point(737, 15)
        Me.BtnTarifas.Name = "BtnTarifas"
        Me.BtnTarifas.Size = New System.Drawing.Size(110, 54)
        Me.BtnTarifas.TabIndex = 40
        Me.BtnTarifas.Text = "Tarifas"
        Me.BtnTarifas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTarifas.UseVisualStyleBackColor = False
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Image = CType(resources.GetObject("BtnAdicionar.Image"), System.Drawing.Image)
        Me.BtnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdicionar.Location = New System.Drawing.Point(766, 84)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(82, 40)
        Me.BtnAdicionar.TabIndex = 36
        Me.BtnAdicionar.Text = "Adicionar"
        Me.BtnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdicionar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.BackColor = System.Drawing.Color.Gray
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(665, 205)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(182, 54)
        Me.BtnGuardar.TabIndex = 38
        Me.BtnGuardar.Text = "Registrar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'For_CantidadRecaudo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 267)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnTarifas)
        Me.Controls.Add(Me.BtnAdicionar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GBCobroServicio)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_CantidadRecaudo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cantidad de Recaudo por Servicios de Cargue "
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGTarifasServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GBCobroServicio.ResumeLayout(False)
        Me.GBCobroServicio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TxtSumacantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TxtSumaservicios As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtTotalServicio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnTarifas As Button
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGTarifasServicios As DataGridView
    Friend WithEvents ColdServicio As DataGridViewTextBoxColumn
    Friend WithEvents ColServicio As DataGridViewTextBoxColumn
    Friend WithEvents ColCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ColValor As DataGridViewTextBoxColumn
    Friend WithEvents ColValorTotal As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtValorTotal As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtValorUnitario As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblUnidad2 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CmbServicios As ComboBox
    Friend WithEvents GBCobroServicio As GroupBox
    Friend WithEvents LblUnidad As Label
    Friend WithEvents TxtCantidadTotal As TextBox
    Friend WithEvents Label11 As Label
End Class
