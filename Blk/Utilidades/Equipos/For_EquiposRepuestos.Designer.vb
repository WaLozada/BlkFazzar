<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_EquiposRepuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_EquiposRepuestos))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.DGRepuestos = New System.Windows.Forms.DataGridView()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.CmbRepuestos = New System.Windows.Forms.ComboBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColIdRepuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRepuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCostochar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DGRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(669, 97)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "DESCRIPCION"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(6, 17)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(653, 69)
        Me.TxtDescripcion.TabIndex = 0
        '
        'DGRepuestos
        '
        Me.DGRepuestos.AllowUserToAddRows = False
        Me.DGRepuestos.AllowUserToDeleteRows = False
        Me.DGRepuestos.AllowUserToOrderColumns = True
        Me.DGRepuestos.AllowUserToResizeColumns = False
        Me.DGRepuestos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGRepuestos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGRepuestos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGRepuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGRepuestos.BackgroundColor = System.Drawing.Color.White
        Me.DGRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRepuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColIdRepuesto, Me.ColRepuesto, Me.ColCosto, Me.ColCostochar, Me.ColDescripcion})
        Me.DGRepuestos.Location = New System.Drawing.Point(12, 191)
        Me.DGRepuestos.MultiSelect = False
        Me.DGRepuestos.Name = "DGRepuestos"
        Me.DGRepuestos.ReadOnly = True
        Me.DGRepuestos.RowHeadersVisible = False
        Me.DGRepuestos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGRepuestos.Size = New System.Drawing.Size(870, 170)
        Me.DGRepuestos.TabIndex = 10
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.TxtCosto)
        Me.GroupBox11.Location = New System.Drawing.Point(277, 12)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(192, 57)
        Me.GroupBox11.TabIndex = 9
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "COSTO (sin IVA)"
        '
        'TxtCosto
        '
        Me.TxtCosto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCosto.Location = New System.Drawing.Point(6, 17)
        Me.TxtCosto.MaxLength = 15
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(174, 31)
        Me.TxtCosto.TabIndex = 3
        Me.TxtCosto.Text = "$ 0"
        Me.TxtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.CmbRepuestos)
        Me.GroupBox10.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(259, 57)
        Me.GroupBox10.TabIndex = 8
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "REPUESTO UTILIZADO"
        '
        'CmbRepuestos
        '
        Me.CmbRepuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbRepuestos.FormattingEnabled = True
        Me.CmbRepuestos.Location = New System.Drawing.Point(16, 20)
        Me.CmbRepuestos.Name = "CmbRepuestos"
        Me.CmbRepuestos.Size = New System.Drawing.Size(231, 24)
        Me.CmbRepuestos.TabIndex = 0
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.BackColor = System.Drawing.Color.Gray
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(730, 367)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(152, 64)
        Me.BtnGuardar.TabIndex = 13
        Me.BtnGuardar.Text = "Guardar Registro"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdicionar.BackColor = System.Drawing.Color.Gray
        Me.BtnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdicionar.ForeColor = System.Drawing.Color.White
        Me.BtnAdicionar.Image = CType(resources.GetObject("BtnAdicionar.Image"), System.Drawing.Image)
        Me.BtnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdicionar.Location = New System.Drawing.Point(778, 110)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(110, 57)
        Me.BtnAdicionar.TabIndex = 15
        Me.BtnAdicionar.Text = "Adicionar"
        Me.BtnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdicionar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(682, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 28)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "REPUESTOS"
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
        'For_EquiposRepuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 435)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnAdicionar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.DGRepuestos)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_EquiposRepuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Repuestos Utilizados"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DGRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents DGRepuestos As DataGridView
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents CmbRepuestos As ComboBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents ColIdRepuesto As DataGridViewTextBoxColumn
    Friend WithEvents ColRepuesto As DataGridViewTextBoxColumn
    Friend WithEvents ColCosto As DataGridViewTextBoxColumn
    Friend WithEvents ColCostochar As DataGridViewTextBoxColumn
    Friend WithEvents ColDescripcion As DataGridViewTextBoxColumn
End Class
