<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_EquiposHV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_EquiposHV))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGResultado = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.CmbElemento = New System.Windows.Forms.ComboBox()
        Me.BtnListar = New System.Windows.Forms.Button()
        Me.BtnVisualizar = New System.Windows.Forms.Button()
        Me.DGCaracteristicas = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGCaracteristicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGResultado)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.TxtNumero)
        Me.GroupBox1.Controls.Add(Me.CmbElemento)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(924, 183)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ELEMENTO"
        '
        'DGResultado
        '
        Me.DGResultado.AllowUserToAddRows = False
        Me.DGResultado.AllowUserToDeleteRows = False
        Me.DGResultado.AllowUserToOrderColumns = True
        Me.DGResultado.AllowUserToResizeColumns = False
        Me.DGResultado.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGResultado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGResultado.BackgroundColor = System.Drawing.Color.White
        Me.DGResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGResultado.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGResultado.Location = New System.Drawing.Point(6, 51)
        Me.DGResultado.Name = "DGResultado"
        Me.DGResultado.ReadOnly = True
        Me.DGResultado.RowHeadersVisible = False
        Me.DGResultado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGResultado.Size = New System.Drawing.Size(906, 125)
        Me.DGResultado.TabIndex = 26
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(295, 13)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscar.TabIndex = 25
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtNumero
        '
        Me.TxtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumero.Location = New System.Drawing.Point(117, 19)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(172, 22)
        Me.TxtNumero.TabIndex = 1
        '
        'CmbElemento
        '
        Me.CmbElemento.FormattingEnabled = True
        Me.CmbElemento.Items.AddRange(New Object() {"ACTIVO", "SERIAL"})
        Me.CmbElemento.Location = New System.Drawing.Point(6, 19)
        Me.CmbElemento.Name = "CmbElemento"
        Me.CmbElemento.Size = New System.Drawing.Size(105, 21)
        Me.CmbElemento.TabIndex = 0
        '
        'BtnListar
        '
        Me.BtnListar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnListar.BackColor = System.Drawing.Color.Gray
        Me.BtnListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListar.ForeColor = System.Drawing.Color.White
        Me.BtnListar.Image = CType(resources.GetObject("BtnListar.Image"), System.Drawing.Image)
        Me.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnListar.Location = New System.Drawing.Point(12, 205)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(221, 50)
        Me.BtnListar.TabIndex = 35
        Me.BtnListar.Text = "Listar Equipos de Computo"
        Me.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnListar.UseVisualStyleBackColor = False
        '
        'BtnVisualizar
        '
        Me.BtnVisualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnVisualizar.BackColor = System.Drawing.Color.Gray
        Me.BtnVisualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVisualizar.ForeColor = System.Drawing.Color.White
        Me.BtnVisualizar.Image = CType(resources.GetObject("BtnVisualizar.Image"), System.Drawing.Image)
        Me.BtnVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVisualizar.Location = New System.Drawing.Point(735, 203)
        Me.BtnVisualizar.Name = "BtnVisualizar"
        Me.BtnVisualizar.Size = New System.Drawing.Size(193, 55)
        Me.BtnVisualizar.TabIndex = 34
        Me.BtnVisualizar.Text = "Hoja de Vida del Equipo"
        Me.BtnVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVisualizar.UseVisualStyleBackColor = False
        '
        'DGCaracteristicas
        '
        Me.DGCaracteristicas.AllowUserToAddRows = False
        Me.DGCaracteristicas.AllowUserToDeleteRows = False
        Me.DGCaracteristicas.AllowUserToOrderColumns = True
        Me.DGCaracteristicas.AllowUserToResizeColumns = False
        Me.DGCaracteristicas.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGCaracteristicas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGCaracteristicas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGCaracteristicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGCaracteristicas.BackgroundColor = System.Drawing.Color.White
        Me.DGCaracteristicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGCaracteristicas.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGCaracteristicas.Location = New System.Drawing.Point(239, 194)
        Me.DGCaracteristicas.Name = "DGCaracteristicas"
        Me.DGCaracteristicas.ReadOnly = True
        Me.DGCaracteristicas.RowHeadersVisible = False
        Me.DGCaracteristicas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGCaracteristicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGCaracteristicas.Size = New System.Drawing.Size(490, 64)
        Me.DGCaracteristicas.TabIndex = 36
        Me.DGCaracteristicas.Visible = False
        '
        'For_EquiposHV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 270)
        Me.Controls.Add(Me.DGCaracteristicas)
        Me.Controls.Add(Me.BtnListar)
        Me.Controls.Add(Me.BtnVisualizar)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimizeBox = False
        Me.Name = "For_EquiposHV"
        Me.Text = "Hoja de Vida Equipos de TI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGCaracteristicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGResultado As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents CmbElemento As ComboBox
    Friend WithEvents BtnVisualizar As Button
    Friend WithEvents BtnListar As Button
    Friend WithEvents DGCaracteristicas As DataGridView
End Class
