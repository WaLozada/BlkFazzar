<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_OrdenesServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_OrdenesServicio))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGOsm = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBFinalizadas = New System.Windows.Forms.RadioButton()
        Me.RBProceso = New System.Windows.Forms.RadioButton()
        Me.RBPendientes = New System.Windows.Forms.RadioButton()
        Me.RBTodas = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DTFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DTFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevaOrden = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGOsm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGOsm)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(794, 318)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordenes de Servicio Macro - OSM"
        '
        'DGOsm
        '
        Me.DGOsm.AllowUserToAddRows = False
        Me.DGOsm.AllowUserToDeleteRows = False
        Me.DGOsm.AllowUserToOrderColumns = True
        Me.DGOsm.AllowUserToResizeColumns = False
        Me.DGOsm.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGOsm.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGOsm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGOsm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGOsm.BackgroundColor = System.Drawing.Color.White
        Me.DGOsm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGOsm.Location = New System.Drawing.Point(10, 19)
        Me.DGOsm.Name = "DGOsm"
        Me.DGOsm.ReadOnly = True
        Me.DGOsm.RowHeadersVisible = False
        Me.DGOsm.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGOsm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGOsm.Size = New System.Drawing.Size(775, 293)
        Me.DGOsm.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBFinalizadas)
        Me.GroupBox2.Controls.Add(Me.RBProceso)
        Me.GroupBox2.Controls.Add(Me.RBPendientes)
        Me.GroupBox2.Controls.Add(Me.RBTodas)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 44)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FILTRAR"
        '
        'RBFinalizadas
        '
        Me.RBFinalizadas.AutoSize = True
        Me.RBFinalizadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RBFinalizadas.Location = New System.Drawing.Point(321, 19)
        Me.RBFinalizadas.Name = "RBFinalizadas"
        Me.RBFinalizadas.Size = New System.Drawing.Size(93, 17)
        Me.RBFinalizadas.TabIndex = 3
        Me.RBFinalizadas.Text = "FINALIZADAS"
        Me.RBFinalizadas.UseVisualStyleBackColor = True
        '
        'RBProceso
        '
        Me.RBProceso.AutoSize = True
        Me.RBProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RBProceso.Location = New System.Drawing.Point(200, 19)
        Me.RBProceso.Name = "RBProceso"
        Me.RBProceso.Size = New System.Drawing.Size(94, 17)
        Me.RBProceso.TabIndex = 2
        Me.RBProceso.Text = "EN PROCESO"
        Me.RBProceso.UseVisualStyleBackColor = True
        '
        'RBPendientes
        '
        Me.RBPendientes.AutoSize = True
        Me.RBPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RBPendientes.Location = New System.Drawing.Point(91, 19)
        Me.RBPendientes.Name = "RBPendientes"
        Me.RBPendientes.Size = New System.Drawing.Size(93, 17)
        Me.RBPendientes.TabIndex = 1
        Me.RBPendientes.Text = "PENDIENTES"
        Me.RBPendientes.UseVisualStyleBackColor = True
        '
        'RBTodas
        '
        Me.RBTodas.AutoSize = True
        Me.RBTodas.Checked = True
        Me.RBTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RBTodas.Location = New System.Drawing.Point(14, 20)
        Me.RBTodas.Name = "RBTodas"
        Me.RBTodas.Size = New System.Drawing.Size(61, 17)
        Me.RBTodas.TabIndex = 0
        Me.RBTodas.TabStop = True
        Me.RBTodas.Text = "TODAS"
        Me.RBTodas.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DTFechaHasta)
        Me.GroupBox3.Location = New System.Drawing.Point(628, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(174, 53)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "HASTA"
        '
        'DTFechaHasta
        '
        Me.DTFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaHasta.Location = New System.Drawing.Point(21, 18)
        Me.DTFechaHasta.Name = "DTFechaHasta"
        Me.DTFechaHasta.Size = New System.Drawing.Size(134, 29)
        Me.DTFechaHasta.TabIndex = 16
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DTFechaDesde)
        Me.GroupBox4.Location = New System.Drawing.Point(448, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(174, 53)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DESDE"
        '
        'DTFechaDesde
        '
        Me.DTFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaDesde.Location = New System.Drawing.Point(21, 18)
        Me.DTFechaDesde.Name = "DTFechaDesde"
        Me.DTFechaDesde.Size = New System.Drawing.Size(134, 29)
        Me.DTFechaDesde.TabIndex = 16
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.BackColor = System.Drawing.Color.Gray
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(536, 388)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(132, 50)
        Me.BtnEditar.TabIndex = 19
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnNuevaOrden
        '
        Me.BtnNuevaOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevaOrden.BackColor = System.Drawing.Color.Gray
        Me.BtnNuevaOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevaOrden.ForeColor = System.Drawing.Color.White
        Me.BtnNuevaOrden.Image = CType(resources.GetObject("BtnNuevaOrden.Image"), System.Drawing.Image)
        Me.BtnNuevaOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevaOrden.Location = New System.Drawing.Point(674, 388)
        Me.BtnNuevaOrden.Name = "BtnNuevaOrden"
        Me.BtnNuevaOrden.Size = New System.Drawing.Size(132, 50)
        Me.BtnNuevaOrden.TabIndex = 18
        Me.BtnNuevaOrden.Text = "Nueva Orden"
        Me.BtnNuevaOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevaOrden.UseVisualStyleBackColor = False
        '
        'For_OrdenesServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevaOrden)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimizeBox = False
        Me.Name = "For_OrdenesServicio"
        Me.Text = "Ordenes de Servicio Macro - OSM"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGOsm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGOsm As DataGridView
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnNuevaOrden As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RBFinalizadas As RadioButton
    Friend WithEvents RBProceso As RadioButton
    Friend WithEvents RBPendientes As RadioButton
    Friend WithEvents RBTodas As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DTFechaHasta As DateTimePicker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DTFechaDesde As DateTimePicker
End Class
