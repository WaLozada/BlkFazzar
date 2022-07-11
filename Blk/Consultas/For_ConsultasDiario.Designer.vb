<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_ConsultasDiario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_ConsultasDiario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTFechaCorte = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbBodegas = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CmbCentros = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGInforme = New System.Windows.Forms.DataGridView()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LblBultos = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBBloqueo = New System.Windows.Forms.GroupBox()
        Me.LblBultosBloqueo = New System.Windows.Forms.Label()
        Me.LblBloqueo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SDArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CmbMovimiento = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGInforme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GBBloqueo.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.Gray
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ForeColor = System.Drawing.Color.White
        Me.BtnConsultar.Image = CType(resources.GetObject("BtnConsultar.Image"), System.Drawing.Image)
        Me.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsultar.Location = New System.Drawing.Point(1018, 15)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(131, 53)
        Me.BtnConsultar.TabIndex = 22
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTFechaCorte)
        Me.GroupBox1.Location = New System.Drawing.Point(858, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 53)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FECHA CONSULTA"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbBodegas)
        Me.GroupBox2.Location = New System.Drawing.Point(358, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 53)
        Me.GroupBox2.TabIndex = 20
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
        Me.GroupBox4.TabIndex = 19
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
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DGInforme)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1138, 370)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "REGISTROS DE INGRESO"
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
        Me.DGInforme.Size = New System.Drawing.Size(1119, 339)
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
        Me.BtnExcel.Location = New System.Drawing.Point(1008, 447)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(141, 57)
        Me.BtnExcel.TabIndex = 24
        Me.BtnExcel.Text = "Exportar Excel"
        Me.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcel.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.LblBultos)
        Me.GroupBox5.Controls.Add(Me.LblTotal)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 442)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(499, 57)
        Me.GroupBox5.TabIndex = 26
        Me.GroupBox5.TabStop = False
        '
        'LblBultos
        '
        Me.LblBultos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblBultos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBultos.ForeColor = System.Drawing.Color.Green
        Me.LblBultos.Location = New System.Drawing.Point(394, 20)
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
        Me.LblTotal.Size = New System.Drawing.Size(177, 27)
        Me.LblTotal.TabIndex = 29
        Me.LblTotal.Text = "0"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(303, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "BULTOS :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(266, 24)
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
        'GBBloqueo
        '
        Me.GBBloqueo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GBBloqueo.Controls.Add(Me.LblBultosBloqueo)
        Me.GBBloqueo.Controls.Add(Me.LblBloqueo)
        Me.GBBloqueo.Controls.Add(Me.Label7)
        Me.GBBloqueo.Controls.Add(Me.Label3)
        Me.GBBloqueo.Controls.Add(Me.Label6)
        Me.GBBloqueo.Location = New System.Drawing.Point(531, 447)
        Me.GBBloqueo.Name = "GBBloqueo"
        Me.GBBloqueo.Size = New System.Drawing.Size(450, 57)
        Me.GBBloqueo.TabIndex = 28
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
        Me.GroupBox6.Controls.Add(Me.CmbMovimiento)
        Me.GroupBox6.Location = New System.Drawing.Point(710, 13)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(142, 52)
        Me.GroupBox6.TabIndex = 29
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "TIPO MOVIMIENTO"
        '
        'CmbMovimiento
        '
        Me.CmbMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMovimiento.FormattingEnabled = True
        Me.CmbMovimiento.Items.AddRange(New Object() {"INGRESOS", "DESPACHOS"})
        Me.CmbMovimiento.Location = New System.Drawing.Point(10, 17)
        Me.CmbMovimiento.Name = "CmbMovimiento"
        Me.CmbMovimiento.Size = New System.Drawing.Size(126, 24)
        Me.CmbMovimiento.TabIndex = 0
        '
        'For_ConsultasDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 507)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GBBloqueo)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.MinimizeBox = False
        Me.Name = "For_ConsultasDiario"
        Me.Text = "Reporte Diario de Ingresos / Despachos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGInforme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GBBloqueo.ResumeLayout(False)
        Me.GBBloqueo.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnConsultar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTFechaCorte As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbBodegas As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CmbCentros As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGInforme As DataGridView
    Friend WithEvents BtnExcel As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LblBultos As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GBBloqueo As GroupBox
    Friend WithEvents LblBultosBloqueo As Label
    Friend WithEvents LblBloqueo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SDArchivo As SaveFileDialog
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CmbMovimiento As ComboBox
End Class
