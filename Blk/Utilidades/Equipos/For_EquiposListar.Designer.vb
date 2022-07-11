<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_EquiposListar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_EquiposListar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGActivosTI = New System.Windows.Forms.DataGridView()
        Me.BtnListar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.SDArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmbLugar = New System.Windows.Forms.ComboBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscaResp = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtResponsable = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGActivosTI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGActivosTI)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1307, 373)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'DGActivosTI
        '
        Me.DGActivosTI.AllowUserToAddRows = False
        Me.DGActivosTI.AllowUserToDeleteRows = False
        Me.DGActivosTI.AllowUserToOrderColumns = True
        Me.DGActivosTI.AllowUserToResizeColumns = False
        Me.DGActivosTI.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGActivosTI.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGActivosTI.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGActivosTI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGActivosTI.BackgroundColor = System.Drawing.Color.White
        Me.DGActivosTI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGActivosTI.Location = New System.Drawing.Point(10, 19)
        Me.DGActivosTI.MultiSelect = False
        Me.DGActivosTI.Name = "DGActivosTI"
        Me.DGActivosTI.ReadOnly = True
        Me.DGActivosTI.RowHeadersVisible = False
        Me.DGActivosTI.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGActivosTI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGActivosTI.Size = New System.Drawing.Size(1288, 348)
        Me.DGActivosTI.TabIndex = 0
        '
        'BtnListar
        '
        Me.BtnListar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnListar.Image = CType(resources.GetObject("BtnListar.Image"), System.Drawing.Image)
        Me.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnListar.Location = New System.Drawing.Point(258, 20)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(122, 50)
        Me.BtnListar.TabIndex = 1
        Me.BtnListar.Text = "Listar Activos"
        Me.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnListar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbTipo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 57)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIPO ACTIVO"
        '
        'CmbTipo
        '
        Me.CmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Location = New System.Drawing.Point(16, 20)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(206, 24)
        Me.CmbTipo.TabIndex = 0
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(12, 447)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(122, 50)
        Me.BtnLimpiar.TabIndex = 4
        Me.BtnLimpiar.Text = "Limpiar Listado"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnExcel.BackColor = System.Drawing.SystemColors.Control
        Me.BtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnExcel.Image = CType(resources.GetObject("BtnExcel.Image"), System.Drawing.Image)
        Me.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcel.Location = New System.Drawing.Point(140, 447)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(122, 50)
        Me.BtnExcel.TabIndex = 5
        Me.BtnExcel.Text = "Exportar Excel"
        Me.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcel.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmbLugar)
        Me.GroupBox3.Location = New System.Drawing.Point(403, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(314, 56)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "UBICACION"
        '
        'CmbLugar
        '
        Me.CmbLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLugar.FormattingEnabled = True
        Me.CmbLugar.Location = New System.Drawing.Point(6, 21)
        Me.CmbLugar.Name = "CmbLugar"
        Me.CmbLugar.Size = New System.Drawing.Size(302, 24)
        Me.CmbLugar.TabIndex = 2
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.BtnBuscaResp)
        Me.GroupBox14.Controls.Add(Me.Label7)
        Me.GroupBox14.Controls.Add(Me.TxtResponsable)
        Me.GroupBox14.Location = New System.Drawing.Point(723, 11)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(579, 57)
        Me.GroupBox14.TabIndex = 3
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "RESPONSABLE"
        '
        'BtnBuscaResp
        '
        Me.BtnBuscaResp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscaResp.FlatAppearance.BorderSize = 0
        Me.BtnBuscaResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaResp.Image = CType(resources.GetObject("BtnBuscaResp.Image"), System.Drawing.Image)
        Me.BtnBuscaResp.Location = New System.Drawing.Point(6, 17)
        Me.BtnBuscaResp.Name = "BtnBuscaResp"
        Me.BtnBuscaResp.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscaResp.TabIndex = 13
        Me.BtnBuscaResp.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "NOMBRE"
        '
        'TxtResponsable
        '
        Me.TxtResponsable.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResponsable.Location = New System.Drawing.Point(106, 19)
        Me.TxtResponsable.MaxLength = 50
        Me.TxtResponsable.Name = "TxtResponsable"
        Me.TxtResponsable.ReadOnly = True
        Me.TxtResponsable.Size = New System.Drawing.Size(463, 26)
        Me.TxtResponsable.TabIndex = 11
        '
        'For_EquiposListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 501)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnListar)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimizeBox = False
        Me.Name = "For_EquiposListar"
        Me.Text = "Listar Activos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGActivosTI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGActivosTI As DataGridView
    Friend WithEvents BtnListar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnExcel As Button
    Friend WithEvents SDArchivo As SaveFileDialog
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CmbLugar As ComboBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents BtnBuscaResp As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtResponsable As TextBox
End Class
