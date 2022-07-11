<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_ConsultasResportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_ConsultasResportes))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbReporte = New System.Windows.Forms.ComboBox()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DGConsulta = New System.Windows.Forms.DataGridView()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.BtnPdf = New System.Windows.Forms.Button()
        Me.CalendarDesde = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CalendarHasta = New System.Windows.Forms.MonthCalendar()
        Me.SDArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.BtnDetalle = New System.Windows.Forms.Button()
        Me.BtnGeneral = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CmbReporte)
        Me.GroupBox1.Location = New System.Drawing.Point(303, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 61)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REPORTE"
        '
        'CmbReporte
        '
        Me.CmbReporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbReporte.FormattingEnabled = True
        Me.CmbReporte.Location = New System.Drawing.Point(10, 20)
        Me.CmbReporte.Name = "CmbReporte"
        Me.CmbReporte.Size = New System.Drawing.Size(553, 28)
        Me.CmbReporte.TabIndex = 0
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnConsultar.BackColor = System.Drawing.Color.Gray
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ForeColor = System.Drawing.Color.White
        Me.BtnConsultar.Image = CType(resources.GetObject("BtnConsultar.Image"), System.Drawing.Image)
        Me.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsultar.Location = New System.Drawing.Point(882, 15)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(131, 57)
        Me.BtnConsultar.TabIndex = 8
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.DGConsulta)
        Me.GroupBox4.Location = New System.Drawing.Point(303, 74)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(707, 333)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        '
        'DGConsulta
        '
        Me.DGConsulta.AllowUserToAddRows = False
        Me.DGConsulta.AllowUserToDeleteRows = False
        Me.DGConsulta.AllowUserToOrderColumns = True
        Me.DGConsulta.AllowUserToResizeColumns = False
        Me.DGConsulta.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGConsulta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGConsulta.BackgroundColor = System.Drawing.Color.White
        Me.DGConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGConsulta.Location = New System.Drawing.Point(10, 19)
        Me.DGConsulta.Name = "DGConsulta"
        Me.DGConsulta.ReadOnly = True
        Me.DGConsulta.RowHeadersVisible = False
        Me.DGConsulta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGConsulta.Size = New System.Drawing.Size(688, 302)
        Me.DGConsulta.TabIndex = 0
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcel.BackColor = System.Drawing.Color.Gray
        Me.BtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcel.ForeColor = System.Drawing.Color.White
        Me.BtnExcel.Image = CType(resources.GetObject("BtnExcel.Image"), System.Drawing.Image)
        Me.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcel.Location = New System.Drawing.Point(872, 413)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(141, 57)
        Me.BtnExcel.TabIndex = 10
        Me.BtnExcel.Text = "Exportar Excel"
        Me.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcel.UseVisualStyleBackColor = False
        '
        'BtnPdf
        '
        Me.BtnPdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPdf.BackColor = System.Drawing.Color.Gray
        Me.BtnPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPdf.ForeColor = System.Drawing.Color.White
        Me.BtnPdf.Image = CType(resources.GetObject("BtnPdf.Image"), System.Drawing.Image)
        Me.BtnPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPdf.Location = New System.Drawing.Point(725, 413)
        Me.BtnPdf.Name = "BtnPdf"
        Me.BtnPdf.Size = New System.Drawing.Size(141, 57)
        Me.BtnPdf.TabIndex = 11
        Me.BtnPdf.Text = "Exportar Pdf"
        Me.BtnPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPdf.UseVisualStyleBackColor = False
        Me.BtnPdf.Visible = False
        '
        'CalendarDesde
        '
        Me.CalendarDesde.Location = New System.Drawing.Point(16, 19)
        Me.CalendarDesde.Name = "CalendarDesde"
        Me.CalendarDesde.TabIndex = 12
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CalendarDesde)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(286, 195)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DESDE"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CalendarHasta)
        Me.GroupBox6.Location = New System.Drawing.Point(11, 213)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(286, 195)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "HASTA"
        '
        'CalendarHasta
        '
        Me.CalendarHasta.Location = New System.Drawing.Point(16, 19)
        Me.CalendarHasta.Name = "CalendarHasta"
        Me.CalendarHasta.TabIndex = 12
        '
        'BtnDetalle
        '
        Me.BtnDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDetalle.BackColor = System.Drawing.Color.Gray
        Me.BtnDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDetalle.ForeColor = System.Drawing.Color.White
        Me.BtnDetalle.Image = CType(resources.GetObject("BtnDetalle.Image"), System.Drawing.Image)
        Me.BtnDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDetalle.Location = New System.Drawing.Point(303, 413)
        Me.BtnDetalle.Name = "BtnDetalle"
        Me.BtnDetalle.Size = New System.Drawing.Size(141, 57)
        Me.BtnDetalle.TabIndex = 14
        Me.BtnDetalle.Text = "Ver Detalle"
        Me.BtnDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDetalle.UseVisualStyleBackColor = False
        '
        'BtnGeneral
        '
        Me.BtnGeneral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnGeneral.BackColor = System.Drawing.Color.Gray
        Me.BtnGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGeneral.ForeColor = System.Drawing.Color.White
        Me.BtnGeneral.Image = CType(resources.GetObject("BtnGeneral.Image"), System.Drawing.Image)
        Me.BtnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGeneral.Location = New System.Drawing.Point(450, 413)
        Me.BtnGeneral.Name = "BtnGeneral"
        Me.BtnGeneral.Size = New System.Drawing.Size(141, 57)
        Me.BtnGeneral.TabIndex = 15
        Me.BtnGeneral.Text = "Ver Total"
        Me.BtnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGeneral.UseVisualStyleBackColor = False
        '
        'For_ConsultasResportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 477)
        Me.Controls.Add(Me.BtnGeneral)
        Me.Controls.Add(Me.BtnDetalle)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.BtnPdf)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimizeBox = False
        Me.Name = "For_ConsultasResportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consultas y/o Reportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbReporte As ComboBox
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DGConsulta As DataGridView
    Friend WithEvents BtnExcel As Button
    Friend WithEvents BtnPdf As Button
    Friend WithEvents CalendarDesde As MonthCalendar
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CalendarHasta As MonthCalendar
    Friend WithEvents SDArchivo As SaveFileDialog
    Friend WithEvents BtnDetalle As Button
    Friend WithEvents BtnGeneral As Button
End Class
