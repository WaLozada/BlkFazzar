<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_ProductosClienteBuscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_ProductosClienteBuscar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDeposito = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblNombreCliente = New System.Windows.Forms.Label()
        Me.TxtCodCliente = New System.Windows.Forms.TextBox()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGDespachar = New System.Windows.Forms.DataGridView()
        Me.ColCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDisponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPresentacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColidPresentacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBultos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblUnidad = New System.Windows.Forms.Label()
        Me.BtnReservar = New System.Windows.Forms.Button()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGLotes = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGInvProductos = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGDespachar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGInvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnLimpiar)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.BtnRegistrar)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1119, 495)
        Me.Panel1.TabIndex = 26
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Gray
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(884, 376)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(144, 51)
        Me.BtnLimpiar.TabIndex = 32
        Me.BtnLimpiar.Text = "Borrar Selección"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtTotal)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(884, 323)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(145, 52)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PESO TOTAL"
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(6, 18)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(101, 29)
        Me.TxtTotal.TabIndex = 22
        Me.TxtTotal.Text = "0"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(113, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Kg"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.TxtDeposito)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.LblNombreCliente)
        Me.GroupBox5.Controls.Add(Me.TxtCodCliente)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(692, 82)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CLIENTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "NOMBRE : "
        '
        'TxtDeposito
        '
        Me.TxtDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeposito.Location = New System.Drawing.Point(254, 12)
        Me.TxtDeposito.MaxLength = 30
        Me.TxtDeposito.Name = "TxtDeposito"
        Me.TxtDeposito.ReadOnly = True
        Me.TxtDeposito.Size = New System.Drawing.Size(96, 26)
        Me.TxtDeposito.TabIndex = 19
        Me.TxtDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "DEPOSITO : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "CODIGO : "
        '
        'LblNombreCliente
        '
        Me.LblNombreCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreCliente.Location = New System.Drawing.Point(75, 48)
        Me.LblNombreCliente.Name = "LblNombreCliente"
        Me.LblNombreCliente.Size = New System.Drawing.Size(609, 26)
        Me.LblNombreCliente.TabIndex = 13
        Me.LblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCodCliente
        '
        Me.TxtCodCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCodCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodCliente.Location = New System.Drawing.Point(75, 12)
        Me.TxtCodCliente.MaxLength = 30
        Me.TxtCodCliente.Name = "TxtCodCliente"
        Me.TxtCodCliente.ReadOnly = True
        Me.TxtCodCliente.Size = New System.Drawing.Size(96, 26)
        Me.TxtCodCliente.TabIndex = 12
        Me.TxtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.Gray
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Image = CType(resources.GetObject("BtnRegistrar.Image"), System.Drawing.Image)
        Me.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistrar.Location = New System.Drawing.Point(884, 432)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(144, 51)
        Me.BtnRegistrar.TabIndex = 29
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGDespachar)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 323)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(812, 160)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRODUCTOS A DESPACHAR"
        '
        'DGDespachar
        '
        Me.DGDespachar.AllowUserToAddRows = False
        Me.DGDespachar.AllowUserToDeleteRows = False
        Me.DGDespachar.AllowUserToOrderColumns = True
        Me.DGDespachar.AllowUserToResizeColumns = False
        Me.DGDespachar.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGDespachar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGDespachar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGDespachar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGDespachar.BackgroundColor = System.Drawing.Color.White
        Me.DGDespachar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDespachar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCodigo, Me.ColDescripcion, Me.ColLote, Me.ColDisponible, Me.ColUnidad, Me.ColPresentacion, Me.ColidPresentacion, Me.ColBultos})
        Me.DGDespachar.Location = New System.Drawing.Point(6, 19)
        Me.DGDespachar.MultiSelect = False
        Me.DGDespachar.Name = "DGDespachar"
        Me.DGDespachar.ReadOnly = True
        Me.DGDespachar.RowHeadersVisible = False
        Me.DGDespachar.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGDespachar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGDespachar.Size = New System.Drawing.Size(800, 135)
        Me.DGDespachar.TabIndex = 1
        '
        'ColCodigo
        '
        Me.ColCodigo.HeaderText = "CODIGO"
        Me.ColCodigo.Name = "ColCodigo"
        Me.ColCodigo.ReadOnly = True
        Me.ColCodigo.Width = 74
        '
        'ColDescripcion
        '
        Me.ColDescripcion.HeaderText = "DESCRIPCION"
        Me.ColDescripcion.Name = "ColDescripcion"
        Me.ColDescripcion.ReadOnly = True
        Me.ColDescripcion.Width = 105
        '
        'ColLote
        '
        Me.ColLote.HeaderText = "LOTE"
        Me.ColLote.Name = "ColLote"
        Me.ColLote.ReadOnly = True
        Me.ColLote.Width = 60
        '
        'ColDisponible
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColDisponible.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColDisponible.HeaderText = "CANTIDAD"
        Me.ColDisponible.Name = "ColDisponible"
        Me.ColDisponible.ReadOnly = True
        Me.ColDisponible.Width = 87
        '
        'ColUnidad
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColUnidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColUnidad.HeaderText = "UNIDAD"
        Me.ColUnidad.Name = "ColUnidad"
        Me.ColUnidad.ReadOnly = True
        Me.ColUnidad.Width = 74
        '
        'ColPresentacion
        '
        Me.ColPresentacion.HeaderText = "PRESENTACION"
        Me.ColPresentacion.Name = "ColPresentacion"
        Me.ColPresentacion.ReadOnly = True
        Me.ColPresentacion.Width = 116
        '
        'ColidPresentacion
        '
        Me.ColidPresentacion.HeaderText = "IDPRESENTACION"
        Me.ColidPresentacion.Name = "ColidPresentacion"
        Me.ColidPresentacion.ReadOnly = True
        Me.ColidPresentacion.Visible = False
        Me.ColidPresentacion.Width = 127
        '
        'ColBultos
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColBultos.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColBultos.HeaderText = "BULTOS"
        Me.ColBultos.Name = "ColBultos"
        Me.ColBultos.ReadOnly = True
        Me.ColBultos.Width = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblUnidad)
        Me.GroupBox1.Controls.Add(Me.BtnReservar)
        Me.GroupBox1.Controls.Add(Me.TxtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DGLotes)
        Me.GroupBox1.Location = New System.Drawing.Point(772, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 219)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOTES"
        '
        'LblUnidad
        '
        Me.LblUnidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblUnidad.AutoSize = True
        Me.LblUnidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUnidad.Location = New System.Drawing.Point(135, 189)
        Me.LblUnidad.Name = "LblUnidad"
        Me.LblUnidad.Size = New System.Drawing.Size(23, 16)
        Me.LblUnidad.TabIndex = 14
        Me.LblUnidad.Text = "kg"
        '
        'BtnReservar
        '
        Me.BtnReservar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReservar.BackColor = System.Drawing.Color.Gray
        Me.BtnReservar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReservar.ForeColor = System.Drawing.Color.White
        Me.BtnReservar.Image = CType(resources.GetObject("BtnReservar.Image"), System.Drawing.Image)
        Me.BtnReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReservar.Location = New System.Drawing.Point(228, 160)
        Me.BtnReservar.Name = "BtnReservar"
        Me.BtnReservar.Size = New System.Drawing.Size(110, 50)
        Me.BtnReservar.TabIndex = 13
        Me.BtnReservar.Text = "Reservar"
        Me.BtnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReservar.UseVisualStyleBackColor = False
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtCantidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.Location = New System.Drawing.Point(13, 185)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(116, 26)
        Me.TxtCantidad.TabIndex = 3
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CANTIDAD REQUERIDA : "
        '
        'DGLotes
        '
        Me.DGLotes.AllowUserToAddRows = False
        Me.DGLotes.AllowUserToDeleteRows = False
        Me.DGLotes.AllowUserToOrderColumns = True
        Me.DGLotes.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGLotes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGLotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGLotes.BackgroundColor = System.Drawing.Color.White
        Me.DGLotes.Location = New System.Drawing.Point(6, 19)
        Me.DGLotes.MultiSelect = False
        Me.DGLotes.Name = "DGLotes"
        Me.DGLotes.ReadOnly = True
        Me.DGLotes.RowHeadersVisible = False
        Me.DGLotes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGLotes.Size = New System.Drawing.Size(332, 135)
        Me.DGLotes.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGInvProductos)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(763, 226)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INVENTARIO DEL CLIENTE"
        '
        'DGInvProductos
        '
        Me.DGInvProductos.AllowUserToAddRows = False
        Me.DGInvProductos.AllowUserToDeleteRows = False
        Me.DGInvProductos.AllowUserToOrderColumns = True
        Me.DGInvProductos.AllowUserToResizeColumns = False
        Me.DGInvProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGInvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGInvProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGInvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGInvProductos.BackgroundColor = System.Drawing.Color.White
        Me.DGInvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGInvProductos.Location = New System.Drawing.Point(6, 19)
        Me.DGInvProductos.MultiSelect = False
        Me.DGInvProductos.Name = "DGInvProductos"
        Me.DGInvProductos.ReadOnly = True
        Me.DGInvProductos.RowHeadersVisible = False
        Me.DGInvProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGInvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGInvProductos.Size = New System.Drawing.Size(751, 201)
        Me.DGInvProductos.TabIndex = 1
        '
        'For_ProductosClienteBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 507)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_ProductosClienteBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Productos del Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGDespachar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGInvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDeposito As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LblNombreCliente As Label
    Friend WithEvents TxtCodCliente As TextBox
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGDespachar As DataGridView
    Friend WithEvents ColCodigo As DataGridViewTextBoxColumn
    Friend WithEvents ColDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ColLote As DataGridViewTextBoxColumn
    Friend WithEvents ColDisponible As DataGridViewTextBoxColumn
    Friend WithEvents ColUnidad As DataGridViewTextBoxColumn
    Friend WithEvents ColPresentacion As DataGridViewTextBoxColumn
    Friend WithEvents ColidPresentacion As DataGridViewTextBoxColumn
    Friend WithEvents ColBultos As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblUnidad As Label
    Friend WithEvents BtnReservar As Button
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGLotes As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGInvProductos As DataGridView
End Class
