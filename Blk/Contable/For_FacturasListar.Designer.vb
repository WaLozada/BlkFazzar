<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_FacturasListar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_FacturasListar))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGFacturas = New System.Windows.Forms.DataGridView()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBPendientes = New System.Windows.Forms.RadioButton()
        Me.RBAprobadas = New System.Windows.Forms.RadioButton()
        Me.RBTodas = New System.Windows.Forms.RadioButton()
        Me.BtnContabilizar = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DGFacturas)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(941, 352)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "LISTADO DE FACTURAS"
        '
        'DGFacturas
        '
        Me.DGFacturas.AllowUserToAddRows = False
        Me.DGFacturas.AllowUserToDeleteRows = False
        Me.DGFacturas.AllowUserToOrderColumns = True
        Me.DGFacturas.AllowUserToResizeColumns = False
        Me.DGFacturas.AllowUserToResizeRows = False
        Me.DGFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGFacturas.BackgroundColor = System.Drawing.Color.White
        Me.DGFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGFacturas.Location = New System.Drawing.Point(10, 19)
        Me.DGFacturas.Name = "DGFacturas"
        Me.DGFacturas.ReadOnly = True
        Me.DGFacturas.RowHeadersVisible = False
        Me.DGFacturas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGFacturas.Size = New System.Drawing.Size(922, 321)
        Me.DGFacturas.TabIndex = 0
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcel.BackColor = System.Drawing.Color.Gray
        Me.BtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcel.ForeColor = System.Drawing.Color.White
        Me.BtnExcel.Image = CType(resources.GetObject("BtnExcel.Image"), System.Drawing.Image)
        Me.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcel.Location = New System.Drawing.Point(812, 433)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(141, 57)
        Me.BtnExcel.TabIndex = 5
        Me.BtnExcel.Text = "Exportar Excel"
        Me.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcel.UseVisualStyleBackColor = False
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRegistrar.BackColor = System.Drawing.Color.Gray
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Image = CType(resources.GetObject("BtnRegistrar.Image"), System.Drawing.Image)
        Me.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistrar.Location = New System.Drawing.Point(12, 433)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(165, 57)
        Me.BtnRegistrar.TabIndex = 4
        Me.BtnRegistrar.Text = "Registrar Factura"
        Me.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTFechaHasta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DTFechaDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 53)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTRAR"
        '
        'DTFechaHasta
        '
        Me.DTFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaHasta.Location = New System.Drawing.Point(269, 18)
        Me.DTFechaHasta.Name = "DTFechaHasta"
        Me.DTFechaHasta.Size = New System.Drawing.Size(134, 29)
        Me.DTFechaHasta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "HASTA :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DESDE :"
        '
        'DTFechaDesde
        '
        Me.DTFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaDesde.Location = New System.Drawing.Point(67, 18)
        Me.DTFechaDesde.Name = "DTFechaDesde"
        Me.DTFechaDesde.Size = New System.Drawing.Size(134, 29)
        Me.DTFechaDesde.TabIndex = 1
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.Gray
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ForeColor = System.Drawing.Color.White
        Me.BtnConsultar.Image = CType(resources.GetObject("BtnConsultar.Image"), System.Drawing.Image)
        Me.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsultar.Location = New System.Drawing.Point(684, 12)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(131, 53)
        Me.BtnConsultar.TabIndex = 0
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBPendientes)
        Me.GroupBox2.Controls.Add(Me.RBAprobadas)
        Me.GroupBox2.Controls.Add(Me.RBTodas)
        Me.GroupBox2.Location = New System.Drawing.Point(431, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 52)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTAR"
        '
        'RBPendientes
        '
        Me.RBPendientes.AutoSize = True
        Me.RBPendientes.Location = New System.Drawing.Point(154, 22)
        Me.RBPendientes.Name = "RBPendientes"
        Me.RBPendientes.Size = New System.Drawing.Size(78, 17)
        Me.RBPendientes.TabIndex = 2
        Me.RBPendientes.Text = "Pendientes"
        Me.RBPendientes.UseVisualStyleBackColor = True
        '
        'RBAprobadas
        '
        Me.RBAprobadas.AutoSize = True
        Me.RBAprobadas.Location = New System.Drawing.Point(72, 22)
        Me.RBAprobadas.Name = "RBAprobadas"
        Me.RBAprobadas.Size = New System.Drawing.Size(76, 17)
        Me.RBAprobadas.TabIndex = 1
        Me.RBAprobadas.Text = "Aprobadas"
        Me.RBAprobadas.UseVisualStyleBackColor = True
        '
        'RBTodas
        '
        Me.RBTodas.AutoSize = True
        Me.RBTodas.Checked = True
        Me.RBTodas.Location = New System.Drawing.Point(11, 22)
        Me.RBTodas.Name = "RBTodas"
        Me.RBTodas.Size = New System.Drawing.Size(55, 17)
        Me.RBTodas.TabIndex = 0
        Me.RBTodas.TabStop = True
        Me.RBTodas.Text = "Todas"
        Me.RBTodas.UseVisualStyleBackColor = True
        '
        'BtnContabilizar
        '
        Me.BtnContabilizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnContabilizar.BackColor = System.Drawing.Color.Gray
        Me.BtnContabilizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContabilizar.ForeColor = System.Drawing.Color.White
        Me.BtnContabilizar.Image = CType(resources.GetObject("BtnContabilizar.Image"), System.Drawing.Image)
        Me.BtnContabilizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnContabilizar.Location = New System.Drawing.Point(183, 433)
        Me.BtnContabilizar.Name = "BtnContabilizar"
        Me.BtnContabilizar.Size = New System.Drawing.Size(165, 57)
        Me.BtnContabilizar.TabIndex = 6
        Me.BtnContabilizar.Text = "Contabilizar"
        Me.BtnContabilizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnContabilizar.UseVisualStyleBackColor = False
        '
        'For_FacturasListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 496)
        Me.Controls.Add(Me.BtnContabilizar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.GroupBox3)
        Me.MinimizeBox = False
        Me.Name = "For_FacturasListar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas Bulkmatic de Colombia "
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGFacturas As DataGridView
    Friend WithEvents BtnExcel As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTFechaHasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTFechaDesde As DateTimePicker
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RBPendientes As RadioButton
    Friend WithEvents RBAprobadas As RadioButton
    Friend WithEvents RBTodas As RadioButton
    Friend WithEvents BtnContabilizar As Button
End Class
