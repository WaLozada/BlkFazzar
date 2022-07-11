<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_ConsultasMovGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_ConsultasMovGeneral))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CalendarHasta = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CalendarDesde = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGInforme = New System.Windows.Forms.DataGridView()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbMovimiento = New System.Windows.Forms.ComboBox()
        Me.SDArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGInforme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CalendarHasta)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 213)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(286, 195)
        Me.GroupBox6.TabIndex = 17
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
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DESDE"
        '
        'CalendarDesde
        '
        Me.CalendarDesde.Location = New System.Drawing.Point(16, 19)
        Me.CalendarDesde.Name = "CalendarDesde"
        Me.CalendarDesde.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DGInforme)
        Me.GroupBox3.Location = New System.Drawing.Point(304, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(840, 396)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "REGISTROS DE INGRESO/DESPACHOS"
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
        Me.DGInforme.Location = New System.Drawing.Point(6, 19)
        Me.DGInforme.Name = "DGInforme"
        Me.DGInforme.ReadOnly = True
        Me.DGInforme.RowHeadersVisible = False
        Me.DGInforme.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGInforme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGInforme.Size = New System.Drawing.Size(828, 363)
        Me.DGInforme.TabIndex = 0
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcel.BackColor = System.Drawing.Color.Gray
        Me.BtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcel.ForeColor = System.Drawing.Color.White
        Me.BtnExcel.Image = CType(resources.GetObject("BtnExcel.Image"), System.Drawing.Image)
        Me.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcel.Location = New System.Drawing.Point(1003, 414)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(141, 57)
        Me.BtnExcel.TabIndex = 25
        Me.BtnExcel.Text = "Exportar Excel"
        Me.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcel.UseVisualStyleBackColor = False
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.Gray
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ForeColor = System.Drawing.Color.White
        Me.BtnConsultar.Image = CType(resources.GetObject("BtnConsultar.Image"), System.Drawing.Image)
        Me.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsultar.Location = New System.Drawing.Point(167, 416)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(131, 53)
        Me.BtnConsultar.TabIndex = 26
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbMovimiento)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 414)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 52)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIPO MOVIMIENTO"
        '
        'CmbMovimiento
        '
        Me.CmbMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMovimiento.FormattingEnabled = True
        Me.CmbMovimiento.Items.AddRange(New Object() {"INGRESOS", "DESPACHOS", "TODO"})
        Me.CmbMovimiento.Location = New System.Drawing.Point(10, 17)
        Me.CmbMovimiento.Name = "CmbMovimiento"
        Me.CmbMovimiento.Size = New System.Drawing.Size(126, 24)
        Me.CmbMovimiento.TabIndex = 0
        '
        'For_ConsultasMovGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 479)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.MinimizeBox = False
        Me.Name = "For_ConsultasMovGeneral"
        Me.Text = "Consulta de Ingresos y Despachos por periodo "
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGInforme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CalendarHasta As MonthCalendar
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CalendarDesde As MonthCalendar
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGInforme As DataGridView
    Friend WithEvents BtnExcel As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbMovimiento As ComboBox
    Friend WithEvents SDArchivo As SaveFileDialog
End Class
