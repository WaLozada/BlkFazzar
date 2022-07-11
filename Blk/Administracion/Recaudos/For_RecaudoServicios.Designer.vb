<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_RecaudoServicios
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_RecaudoServicios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGInforme = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CalendarHasta = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CalendarDesde = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbBodegas = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CmbCentros = New System.Windows.Forms.ComboBox()
        Me.SDArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BtnPdf = New System.Windows.Forms.Button()
        Me.DGInformePDF = New System.Windows.Forms.DataGridView()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGInforme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGInformePDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DGInformePDF)
        Me.GroupBox3.Controls.Add(Me.DGInforme)
        Me.GroupBox3.Location = New System.Drawing.Point(304, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(810, 344)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RECAUDO"
        '
        'DGInforme
        '
        Me.DGInforme.AllowUserToAddRows = False
        Me.DGInforme.AllowUserToDeleteRows = False
        Me.DGInforme.AllowUserToOrderColumns = True
        Me.DGInforme.AllowUserToResizeColumns = False
        Me.DGInforme.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGInforme.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
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
        Me.DGInforme.Size = New System.Drawing.Size(798, 311)
        Me.DGInforme.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CalendarHasta)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 213)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(286, 195)
        Me.GroupBox6.TabIndex = 26
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
        Me.GroupBox5.TabIndex = 25
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DESDE"
        '
        'CalendarDesde
        '
        Me.CalendarDesde.Location = New System.Drawing.Point(16, 19)
        Me.CalendarDesde.Name = "CalendarDesde"
        Me.CalendarDesde.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbBodegas)
        Me.GroupBox2.Location = New System.Drawing.Point(678, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 53)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BODEGA"
        '
        'CmbBodegas
        '
        Me.CmbBodegas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBodegas.FormattingEnabled = True
        Me.CmbBodegas.Location = New System.Drawing.Point(6, 18)
        Me.CmbBodegas.Name = "CmbBodegas"
        Me.CmbBodegas.Size = New System.Drawing.Size(309, 24)
        Me.CmbBodegas.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.CmbCentros)
        Me.GroupBox4.Location = New System.Drawing.Point(310, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(362, 53)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CENTRO (CEDIS)"
        '
        'CmbCentros
        '
        Me.CmbCentros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCentros.FormattingEnabled = True
        Me.CmbCentros.Location = New System.Drawing.Point(17, 18)
        Me.CmbCentros.Name = "CmbCentros"
        Me.CmbCentros.Size = New System.Drawing.Size(339, 24)
        Me.CmbCentros.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblTotal)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 422)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 56)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TOTAL RECAUDADO "
        '
        'LblTotal
        '
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTotal.Location = New System.Drawing.Point(6, 16)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(274, 35)
        Me.LblTotal.TabIndex = 0
        Me.LblTotal.Text = "$ 0"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnImprimir.BackColor = System.Drawing.Color.Gray
        Me.BtnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.ForeColor = System.Drawing.Color.White
        Me.BtnImprimir.Image = CType(resources.GetObject("BtnImprimir.Image"), System.Drawing.Image)
        Me.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImprimir.Location = New System.Drawing.Point(304, 422)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(146, 57)
        Me.BtnImprimir.TabIndex = 33
        Me.BtnImprimir.Text = "Imprimir Recibo"
        Me.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnImprimir.UseVisualStyleBackColor = False
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcel.BackColor = System.Drawing.Color.Gray
        Me.BtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcel.ForeColor = System.Drawing.Color.White
        Me.BtnExcel.Image = CType(resources.GetObject("BtnExcel.Image"), System.Drawing.Image)
        Me.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcel.Location = New System.Drawing.Point(973, 421)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(141, 57)
        Me.BtnExcel.TabIndex = 31
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
        Me.BtnConsultar.Location = New System.Drawing.Point(1005, 15)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(109, 53)
        Me.BtnConsultar.TabIndex = 28
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'BtnPdf
        '
        Me.BtnPdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPdf.BackColor = System.Drawing.Color.Gray
        Me.BtnPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPdf.ForeColor = System.Drawing.Color.White
        Me.BtnPdf.Image = CType(resources.GetObject("BtnPdf.Image"), System.Drawing.Image)
        Me.BtnPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPdf.Location = New System.Drawing.Point(826, 422)
        Me.BtnPdf.Name = "BtnPdf"
        Me.BtnPdf.Size = New System.Drawing.Size(141, 57)
        Me.BtnPdf.TabIndex = 34
        Me.BtnPdf.Text = "Exportar Pdf"
        Me.BtnPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPdf.UseVisualStyleBackColor = False
        '
        'DGInformePDF
        '
        Me.DGInformePDF.AllowUserToAddRows = False
        Me.DGInformePDF.AllowUserToDeleteRows = False
        Me.DGInformePDF.AllowUserToOrderColumns = True
        Me.DGInformePDF.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGInformePDF.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGInformePDF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGInformePDF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGInformePDF.BackgroundColor = System.Drawing.Color.White
        Me.DGInformePDF.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGInformePDF.Location = New System.Drawing.Point(6, 182)
        Me.DGInformePDF.Name = "DGInformePDF"
        Me.DGInformePDF.ReadOnly = True
        Me.DGInformePDF.RowHeadersVisible = False
        Me.DGInformePDF.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGInformePDF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGInformePDF.Size = New System.Drawing.Size(798, 123)
        Me.DGInformePDF.TabIndex = 1
        Me.DGInformePDF.Visible = False
        '
        'For_RecaudoServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 490)
        Me.Controls.Add(Me.BtnPdf)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.MinimizeBox = False
        Me.Name = "For_RecaudoServicios"
        Me.Text = "Recaudo Por Servicios (Cargues/Descargues)"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGInforme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGInformePDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGInforme As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CalendarHasta As MonthCalendar
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CalendarDesde As MonthCalendar
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbBodegas As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CmbCentros As ComboBox
    Friend WithEvents BtnExcel As Button
    Friend WithEvents SDArchivo As SaveFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents BtnPdf As Button
    Friend WithEvents DGInformePDF As DataGridView
End Class
