<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class For_EquiposMantenimiento
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_EquiposMantenimiento))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CalendarFechaMto = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RBColaborador = New System.Windows.Forms.RadioButton()
        Me.RBProveedor = New System.Windows.Forms.RadioButton()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.LblResponsable = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RBCorrectivo = New System.Windows.Forms.RadioButton()
        Me.RBPreventivo = New System.Windows.Forms.RadioButton()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblModelo = New System.Windows.Forms.Label()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblActivo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblSerial = New System.Windows.Forms.Label()
        Me.LblElemento = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.CmbElemento = New System.Windows.Forms.ComboBox()
        Me.DGResultado = New System.Windows.Forms.DataGridView()
        Me.DGRepuestos = New System.Windows.Forms.DataGridView()
        Me.ColIdRepuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRepuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCostochar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGHistorico = New System.Windows.Forms.DataGridView()
        Me.BtnRepuestos = New System.Windows.Forms.Button()
        Me.BtnBuscarProv = New System.Windows.Forms.Button()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(10, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 476)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.ItemSize = New System.Drawing.Size(425, 25)
        Me.TabControl1.Location = New System.Drawing.Point(15, 169)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(881, 292)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 33
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnRepuestos)
        Me.TabPage2.Controls.Add(Me.GroupBox8)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox17)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.BtnAdicionar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(873, 259)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "REGISTRO DEL MANTENIMIENTO"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TxtObservaciones)
        Me.GroupBox8.Location = New System.Drawing.Point(302, 140)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(418, 110)
        Me.GroupBox8.TabIndex = 33
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "DESCRIPCIÓN / OBSERVACIONES"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservaciones.Location = New System.Drawing.Point(6, 19)
        Me.TxtObservaciones.MaxLength = 250
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(406, 85)
        Me.TxtObservaciones.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CalendarFechaMto)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 231)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FECHA DEL MANTENIMIENTO"
        '
        'CalendarFechaMto
        '
        Me.CalendarFechaMto.Location = New System.Drawing.Point(17, 44)
        Me.CalendarFechaMto.Name = "CalendarFechaMto"
        Me.CalendarFechaMto.TabIndex = 30
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnBuscarProv)
        Me.GroupBox5.Controls.Add(Me.RBColaborador)
        Me.GroupBox5.Controls.Add(Me.RBProveedor)
        Me.GroupBox5.Location = New System.Drawing.Point(571, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(279, 56)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "REALIZADO POR:"
        '
        'RBColaborador
        '
        Me.RBColaborador.AutoSize = True
        Me.RBColaborador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBColaborador.Location = New System.Drawing.Point(119, 22)
        Me.RBColaborador.Name = "RBColaborador"
        Me.RBColaborador.Size = New System.Drawing.Size(102, 20)
        Me.RBColaborador.TabIndex = 18
        Me.RBColaborador.TabStop = True
        Me.RBColaborador.Text = "Colaborador"
        Me.RBColaborador.UseVisualStyleBackColor = True
        '
        'RBProveedor
        '
        Me.RBProveedor.AutoSize = True
        Me.RBProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBProveedor.Location = New System.Drawing.Point(14, 22)
        Me.RBProveedor.Name = "RBProveedor"
        Me.RBProveedor.Size = New System.Drawing.Size(90, 20)
        Me.RBProveedor.TabIndex = 17
        Me.RBProveedor.TabStop = True
        Me.RBProveedor.Text = "Proveedor"
        Me.RBProveedor.UseVisualStyleBackColor = True
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.LblResponsable)
        Me.GroupBox17.Location = New System.Drawing.Point(302, 81)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(554, 53)
        Me.GroupBox17.TabIndex = 18
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "RESPONSABLE"
        '
        'LblResponsable
        '
        Me.LblResponsable.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblResponsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResponsable.Location = New System.Drawing.Point(11, 17)
        Me.LblResponsable.Name = "LblResponsable"
        Me.LblResponsable.Size = New System.Drawing.Size(537, 26)
        Me.LblResponsable.TabIndex = 14
        Me.LblResponsable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RBCorrectivo)
        Me.GroupBox4.Controls.Add(Me.RBPreventivo)
        Me.GroupBox4.Location = New System.Drawing.Point(302, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(239, 56)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TIPO DE MANTENIMIENTO"
        '
        'RBCorrectivo
        '
        Me.RBCorrectivo.AutoSize = True
        Me.RBCorrectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCorrectivo.Location = New System.Drawing.Point(136, 19)
        Me.RBCorrectivo.Name = "RBCorrectivo"
        Me.RBCorrectivo.Size = New System.Drawing.Size(87, 20)
        Me.RBCorrectivo.TabIndex = 16
        Me.RBCorrectivo.TabStop = True
        Me.RBCorrectivo.Text = "Correctivo"
        Me.RBCorrectivo.UseVisualStyleBackColor = True
        '
        'RBPreventivo
        '
        Me.RBPreventivo.AutoSize = True
        Me.RBPreventivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBPreventivo.Location = New System.Drawing.Point(11, 21)
        Me.RBPreventivo.Name = "RBPreventivo"
        Me.RBPreventivo.Size = New System.Drawing.Size(90, 20)
        Me.RBPreventivo.TabIndex = 15
        Me.RBPreventivo.TabStop = True
        Me.RBPreventivo.Text = "Preventivo"
        Me.RBPreventivo.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(873, 259)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "HISTORIAL DE MANTENIMIENTO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGHistorico)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(852, 247)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LblModelo)
        Me.GroupBox1.Controls.Add(Me.LblMarca)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblActivo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LblSerial)
        Me.GroupBox1.Controls.Add(Me.LblElemento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtNumero)
        Me.GroupBox1.Controls.Add(Me.CmbElemento)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(886, 142)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ELEMENTO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(478, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(393, 28)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "REGISTRO DE MANTENIMIENTO"
        '
        'LblModelo
        '
        Me.LblModelo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModelo.Location = New System.Drawing.Point(350, 98)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(160, 28)
        Me.LblModelo.TabIndex = 43
        Me.LblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblMarca
        '
        Me.LblMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMarca.Location = New System.Drawing.Point(99, 98)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(160, 28)
        Me.LblMarca.TabIndex = 42
        Me.LblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(265, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "MODELO :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "MARCA :"
        '
        'LblActivo
        '
        Me.LblActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblActivo.Location = New System.Drawing.Point(98, 62)
        Me.LblActivo.Name = "LblActivo"
        Me.LblActivo.Size = New System.Drawing.Size(66, 28)
        Me.LblActivo.TabIndex = 33
        Me.LblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "ACTIVO :"
        '
        'LblSerial
        '
        Me.LblSerial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerial.Location = New System.Drawing.Point(606, 98)
        Me.LblSerial.Name = "LblSerial"
        Me.LblSerial.Size = New System.Drawing.Size(238, 28)
        Me.LblSerial.TabIndex = 37
        Me.LblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblElemento
        '
        Me.LblElemento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblElemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblElemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblElemento.Location = New System.Drawing.Point(272, 62)
        Me.LblElemento.Name = "LblElemento"
        Me.LblElemento.Size = New System.Drawing.Size(238, 28)
        Me.LblElemento.TabIndex = 39
        Me.LblElemento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(522, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "SERIAL :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(170, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "ELEMENTO :"
        '
        'TxtNumero
        '
        Me.TxtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumero.Location = New System.Drawing.Point(117, 19)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(172, 22)
        Me.TxtNumero.TabIndex = 1
        '
        'CmbElemento
        '
        Me.CmbElemento.FormattingEnabled = True
        Me.CmbElemento.Items.AddRange(New Object() {"ACTIVO", "SERIAL"})
        Me.CmbElemento.Location = New System.Drawing.Point(6, 19)
        Me.CmbElemento.Name = "CmbElemento"
        Me.CmbElemento.Size = New System.Drawing.Size(105, 21)
        Me.CmbElemento.TabIndex = 0
        '
        'DGResultado
        '
        Me.DGResultado.AllowUserToAddRows = False
        Me.DGResultado.AllowUserToDeleteRows = False
        Me.DGResultado.AllowUserToOrderColumns = True
        Me.DGResultado.AllowUserToResizeColumns = False
        Me.DGResultado.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGResultado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGResultado.BackgroundColor = System.Drawing.Color.White
        Me.DGResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGResultado.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGResultado.Location = New System.Drawing.Point(920, 82)
        Me.DGResultado.Name = "DGResultado"
        Me.DGResultado.ReadOnly = True
        Me.DGResultado.RowHeadersVisible = False
        Me.DGResultado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGResultado.Size = New System.Drawing.Size(0, 73)
        Me.DGResultado.TabIndex = 27
        Me.DGResultado.Visible = False
        '
        'DGRepuestos
        '
        Me.DGRepuestos.AllowUserToAddRows = False
        Me.DGRepuestos.AllowUserToDeleteRows = False
        Me.DGRepuestos.AllowUserToOrderColumns = True
        Me.DGRepuestos.AllowUserToResizeColumns = False
        Me.DGRepuestos.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGRepuestos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGRepuestos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGRepuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGRepuestos.BackgroundColor = System.Drawing.Color.White
        Me.DGRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRepuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColIdRepuesto, Me.ColRepuesto, Me.ColCosto, Me.ColCostochar, Me.ColDescripcion})
        Me.DGRepuestos.Location = New System.Drawing.Point(921, 174)
        Me.DGRepuestos.MultiSelect = False
        Me.DGRepuestos.Name = "DGRepuestos"
        Me.DGRepuestos.ReadOnly = True
        Me.DGRepuestos.RowHeadersVisible = False
        Me.DGRepuestos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGRepuestos.Size = New System.Drawing.Size(0, 170)
        Me.DGRepuestos.TabIndex = 28
        Me.DGRepuestos.Visible = False
        '
        'ColIdRepuesto
        '
        Me.ColIdRepuesto.HeaderText = "IDREPUESTO"
        Me.ColIdRepuesto.Name = "ColIdRepuesto"
        Me.ColIdRepuesto.ReadOnly = True
        Me.ColIdRepuesto.Visible = False
        Me.ColIdRepuesto.Width = 83
        '
        'ColRepuesto
        '
        Me.ColRepuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColRepuesto.HeaderText = "REPUESTO"
        Me.ColRepuesto.Name = "ColRepuesto"
        Me.ColRepuesto.ReadOnly = True
        Me.ColRepuesto.Width = 200
        '
        'ColCosto
        '
        Me.ColCosto.HeaderText = "COSTO"
        Me.ColCosto.Name = "ColCosto"
        Me.ColCosto.ReadOnly = True
        Me.ColCosto.Width = 69
        '
        'ColCostochar
        '
        Me.ColCostochar.HeaderText = "COSTOCHAR"
        Me.ColCostochar.Name = "ColCostochar"
        Me.ColCostochar.ReadOnly = True
        Me.ColCostochar.Visible = False
        Me.ColCostochar.Width = 99
        '
        'ColDescripcion
        '
        Me.ColDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColDescripcion.HeaderText = "DESCRIPCION"
        Me.ColDescripcion.Name = "ColDescripcion"
        Me.ColDescripcion.ReadOnly = True
        Me.ColDescripcion.Width = 450
        '
        'DGHistorico
        '
        Me.DGHistorico.AllowUserToAddRows = False
        Me.DGHistorico.AllowUserToDeleteRows = False
        Me.DGHistorico.AllowUserToOrderColumns = True
        Me.DGHistorico.AllowUserToResizeColumns = False
        Me.DGHistorico.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGHistorico.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGHistorico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGHistorico.BackgroundColor = System.Drawing.Color.White
        Me.DGHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGHistorico.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGHistorico.Location = New System.Drawing.Point(6, 19)
        Me.DGHistorico.Name = "DGHistorico"
        Me.DGHistorico.ReadOnly = True
        Me.DGHistorico.RowHeadersVisible = False
        Me.DGHistorico.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGHistorico.Size = New System.Drawing.Size(840, 222)
        Me.DGHistorico.TabIndex = 28
        '
        'BtnRepuestos
        '
        Me.BtnRepuestos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRepuestos.BackColor = System.Drawing.Color.Gray
        Me.BtnRepuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRepuestos.ForeColor = System.Drawing.Color.White
        Me.BtnRepuestos.Image = CType(resources.GetObject("BtnRepuestos.Image"), System.Drawing.Image)
        Me.BtnRepuestos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRepuestos.Location = New System.Drawing.Point(726, 140)
        Me.BtnRepuestos.Name = "BtnRepuestos"
        Me.BtnRepuestos.Size = New System.Drawing.Size(141, 51)
        Me.BtnRepuestos.TabIndex = 34
        Me.BtnRepuestos.Text = "Respuestos"
        Me.BtnRepuestos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRepuestos.UseVisualStyleBackColor = False
        '
        'BtnBuscarProv
        '
        Me.BtnBuscarProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarProv.FlatAppearance.BorderSize = 0
        Me.BtnBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarProv.Image = CType(resources.GetObject("BtnBuscarProv.Image"), System.Drawing.Image)
        Me.BtnBuscarProv.Location = New System.Drawing.Point(237, 13)
        Me.BtnBuscarProv.Name = "BtnBuscarProv"
        Me.BtnBuscarProv.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscarProv.TabIndex = 19
        Me.BtnBuscarProv.UseVisualStyleBackColor = True
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdicionar.BackColor = System.Drawing.Color.Gray
        Me.BtnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdicionar.ForeColor = System.Drawing.Color.White
        Me.BtnAdicionar.Image = CType(resources.GetObject("BtnAdicionar.Image"), System.Drawing.Image)
        Me.BtnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdicionar.Location = New System.Drawing.Point(726, 193)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(141, 51)
        Me.BtnAdicionar.TabIndex = 14
        Me.BtnAdicionar.Text = "Registrar Mto."
        Me.BtnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdicionar.UseVisualStyleBackColor = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(295, 13)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscar.TabIndex = 25
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'For_EquiposMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 491)
        Me.Controls.Add(Me.DGRepuestos)
        Me.Controls.Add(Me.DGResultado)
        Me.Controls.Add(Me.Panel1)
        Me.MinimizeBox = False
        Me.Name = "For_EquiposMantenimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents CmbElemento As ComboBox
    Friend WithEvents LblSerial As Label
    Friend WithEvents LblElemento As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblActivo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblModelo As Label
    Friend WithEvents LblMarca As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents BtnRepuestos As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CalendarFechaMto As MonthCalendar
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BtnBuscarProv As Button
    Friend WithEvents RBColaborador As RadioButton
    Friend WithEvents RBProveedor As RadioButton
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents LblResponsable As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RBCorrectivo As RadioButton
    Friend WithEvents RBPreventivo As RadioButton
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DGResultado As DataGridView
    Friend WithEvents DGRepuestos As DataGridView
    Friend WithEvents ColIdRepuesto As DataGridViewTextBoxColumn
    Friend WithEvents ColRepuesto As DataGridViewTextBoxColumn
    Friend WithEvents ColCosto As DataGridViewTextBoxColumn
    Friend WithEvents ColCostochar As DataGridViewTextBoxColumn
    Friend WithEvents ColDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents DGHistorico As DataGridView
End Class
