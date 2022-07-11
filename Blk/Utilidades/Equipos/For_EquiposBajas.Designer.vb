<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_EquiposBajas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_EquiposBajas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGResultado = New System.Windows.Forms.DataGridView()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.CmbElemento = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGListadoBaja = New System.Windows.Forms.DataGridView()
        Me.SDArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnDarBaja = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGListadoBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGResultado)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.BtnDarBaja)
        Me.GroupBox1.Controls.Add(Me.TxtNumero)
        Me.GroupBox1.Controls.Add(Me.CmbElemento)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(809, 131)
        Me.GroupBox1.TabIndex = 27
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.DGResultado.Size = New System.Drawing.Size(791, 73)
        Me.DGResultado.TabIndex = 26
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DGListadoBaja)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(809, 291)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "IINVENTARIO DADO DE BAJA"
        '
        'DGListadoBaja
        '
        Me.DGListadoBaja.AllowUserToAddRows = False
        Me.DGListadoBaja.AllowUserToDeleteRows = False
        Me.DGListadoBaja.AllowUserToOrderColumns = True
        Me.DGListadoBaja.AllowUserToResizeColumns = False
        Me.DGListadoBaja.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGListadoBaja.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGListadoBaja.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGListadoBaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGListadoBaja.BackgroundColor = System.Drawing.Color.White
        Me.DGListadoBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGListadoBaja.Location = New System.Drawing.Point(12, 19)
        Me.DGListadoBaja.Name = "DGListadoBaja"
        Me.DGListadoBaja.ReadOnly = True
        Me.DGListadoBaja.RowHeadersVisible = False
        Me.DGListadoBaja.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGListadoBaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGListadoBaja.Size = New System.Drawing.Size(791, 266)
        Me.DGListadoBaja.TabIndex = 27
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcel.BackColor = System.Drawing.SystemColors.Control
        Me.BtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnExcel.Image = CType(resources.GetObject("BtnExcel.Image"), System.Drawing.Image)
        Me.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcel.Location = New System.Drawing.Point(699, 440)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(122, 50)
        Me.BtnExcel.TabIndex = 36
        Me.BtnExcel.Text = "Exportar Excel"
        Me.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcel.UseVisualStyleBackColor = False
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
        'BtnDarBaja
        '
        Me.BtnDarBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDarBaja.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDarBaja.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnDarBaja.FlatAppearance.BorderSize = 2
        Me.BtnDarBaja.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnDarBaja.Image = CType(resources.GetObject("BtnDarBaja.Image"), System.Drawing.Image)
        Me.BtnDarBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDarBaja.Location = New System.Drawing.Point(703, 13)
        Me.BtnDarBaja.Name = "BtnDarBaja"
        Me.BtnDarBaja.Size = New System.Drawing.Size(100, 33)
        Me.BtnDarBaja.TabIndex = 24
        Me.BtnDarBaja.Text = "Dar de Baja"
        Me.BtnDarBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDarBaja.UseVisualStyleBackColor = False
        '
        'For_EquiposBajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 495)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimizeBox = False
        Me.Name = "For_EquiposBajas"
        Me.Text = "Relación Equipos de Baja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGListadoBaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnDarBaja As Button
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents CmbElemento As ComboBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGResultado As DataGridView
    Friend WithEvents DGListadoBaja As DataGridView
    Friend WithEvents BtnExcel As Button
    Friend WithEvents SDArchivo As SaveFileDialog
End Class
