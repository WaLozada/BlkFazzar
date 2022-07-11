<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_BitacoraOtrosCobros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_BitacoraOtrosCobros))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TxtDespacho = New System.Windows.Forms.TextBox()
        Me.DGCobros = New System.Windows.Forms.DataGridView()
        Me.IDDESPACHO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCOBRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.CmbConcepto = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtValorTotal = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DGCobros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtDespacho)
        Me.GroupBox6.Controls.Add(Me.DGCobros)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(339, 216)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "DETALLE DE COBROS"
        '
        'TxtDespacho
        '
        Me.TxtDespacho.Location = New System.Drawing.Point(237, 163)
        Me.TxtDespacho.Name = "TxtDespacho"
        Me.TxtDespacho.Size = New System.Drawing.Size(92, 20)
        Me.TxtDespacho.TabIndex = 7
        Me.TxtDespacho.Visible = False
        '
        'DGCobros
        '
        Me.DGCobros.AllowUserToAddRows = False
        Me.DGCobros.AllowUserToDeleteRows = False
        Me.DGCobros.AllowUserToOrderColumns = True
        Me.DGCobros.AllowUserToResizeColumns = False
        Me.DGCobros.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGCobros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGCobros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGCobros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGCobros.BackgroundColor = System.Drawing.Color.White
        Me.DGCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCobros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDESPACHO, Me.IDCOBRO, Me.DESCRIPCION, Me.VALOR})
        Me.DGCobros.Location = New System.Drawing.Point(10, 19)
        Me.DGCobros.Name = "DGCobros"
        Me.DGCobros.ReadOnly = True
        Me.DGCobros.RowHeadersVisible = False
        Me.DGCobros.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGCobros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGCobros.Size = New System.Drawing.Size(323, 185)
        Me.DGCobros.TabIndex = 0
        '
        'IDDESPACHO
        '
        Me.IDDESPACHO.HeaderText = "DESPACHO"
        Me.IDDESPACHO.Name = "IDDESPACHO"
        Me.IDDESPACHO.ReadOnly = True
        Me.IDDESPACHO.Width = 91
        '
        'IDCOBRO
        '
        Me.IDCOBRO.HeaderText = "IDCOBRO"
        Me.IDCOBRO.Name = "IDCOBRO"
        Me.IDCOBRO.ReadOnly = True
        Me.IDCOBRO.Width = 81
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        Me.DESCRIPCION.Width = 105
        '
        'VALOR
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.VALOR.DefaultCellStyle = DataGridViewCellStyle2
        Me.VALOR.HeaderText = "VALOR"
        Me.VALOR.Name = "VALOR"
        Me.VALOR.ReadOnly = True
        Me.VALOR.Width = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtValor)
        Me.GroupBox1.Controls.Add(Me.BtnAdicionar)
        Me.GroupBox1.Controls.Add(Me.CmbConcepto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 91)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COBROS ADICIONALES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "VALOR :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CONCEPTO :"
        '
        'TxtValor
        '
        Me.TxtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValor.Location = New System.Drawing.Point(89, 50)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(128, 29)
        Me.TxtValor.TabIndex = 3
        Me.TxtValor.Text = "$ 0"
        Me.TxtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Image = CType(resources.GetObject("BtnAdicionar.Image"), System.Drawing.Image)
        Me.BtnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdicionar.Location = New System.Drawing.Point(237, 48)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(89, 33)
        Me.BtnAdicionar.TabIndex = 2
        Me.BtnAdicionar.Text = "Adicionar"
        Me.BtnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdicionar.UseVisualStyleBackColor = True
        '
        'CmbConcepto
        '
        Me.CmbConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbConcepto.FormattingEnabled = True
        Me.CmbConcepto.Location = New System.Drawing.Point(89, 20)
        Me.CmbConcepto.Name = "CmbConcepto"
        Me.CmbConcepto.Size = New System.Drawing.Size(237, 24)
        Me.CmbConcepto.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtValorTotal)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 331)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 54)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Tag = ""
        Me.Label1.Text = "TOTAL"
        '
        'TxtValorTotal
        '
        Me.TxtValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValorTotal.Location = New System.Drawing.Point(89, 19)
        Me.TxtValorTotal.Name = "TxtValorTotal"
        Me.TxtValorTotal.ReadOnly = True
        Me.TxtValorTotal.Size = New System.Drawing.Size(153, 29)
        Me.TxtValorTotal.TabIndex = 0
        Me.TxtValorTotal.Tag = "0"
        Me.TxtValorTotal.Text = "$ 0"
        Me.TxtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(267, 335)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(84, 47)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'For_BitacoraOtrosCobros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 394)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_BitacoraOtrosCobros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Otros Cobros del Despacho"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DGCobros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DGCobros As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbConcepto As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtValorTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtDespacho As TextBox
    Friend WithEvents IDDESPACHO As DataGridViewTextBoxColumn
    Friend WithEvents IDCOBRO As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents VALOR As DataGridViewTextBoxColumn
End Class
