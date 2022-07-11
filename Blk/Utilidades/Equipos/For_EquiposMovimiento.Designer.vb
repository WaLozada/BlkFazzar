<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_EquiposMovimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_EquiposMovimiento))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGResultado = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.CmbElemento = New System.Windows.Forms.ComboBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.LblLugar = New System.Windows.Forms.Label()
        Me.CmbLugar = New System.Windows.Forms.ComboBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscaResp = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtResponsable = New System.Windows.Forms.TextBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.LblArea = New System.Windows.Forms.Label()
        Me.CmbArea = New System.Windows.Forms.ComboBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscaCiudad = New System.Windows.Forms.Button()
        Me.TxtMunicipio = New System.Windows.Forms.TextBox()
        Me.TxtDivipol = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDepto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPais = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.GroupBox1.Size = New System.Drawing.Size(846, 131)
        Me.GroupBox1.TabIndex = 28
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
        Me.DGResultado.Size = New System.Drawing.Size(828, 73)
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
        'GroupBox16
        '
        Me.GroupBox16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox16.Controls.Add(Me.LblLugar)
        Me.GroupBox16.Controls.Add(Me.CmbLugar)
        Me.GroupBox16.Location = New System.Drawing.Point(597, 152)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(267, 99)
        Me.GroupBox16.TabIndex = 32
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "LUGAR"
        '
        'LblLugar
        '
        Me.LblLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLugar.Location = New System.Drawing.Point(12, 58)
        Me.LblLugar.Name = "LblLugar"
        Me.LblLugar.Size = New System.Drawing.Size(249, 25)
        Me.LblLugar.TabIndex = 2
        Me.LblLugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbLugar
        '
        Me.CmbLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLugar.FormattingEnabled = True
        Me.CmbLugar.Location = New System.Drawing.Point(10, 21)
        Me.CmbLugar.Name = "CmbLugar"
        Me.CmbLugar.Size = New System.Drawing.Size(251, 24)
        Me.CmbLugar.TabIndex = 1
        '
        'GroupBox14
        '
        Me.GroupBox14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox14.Controls.Add(Me.BtnBuscaResp)
        Me.GroupBox14.Controls.Add(Me.Label7)
        Me.GroupBox14.Controls.Add(Me.TxtResponsable)
        Me.GroupBox14.Location = New System.Drawing.Point(12, 313)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(579, 60)
        Me.GroupBox14.TabIndex = 31
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
        'GroupBox12
        '
        Me.GroupBox12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox12.Controls.Add(Me.LblArea)
        Me.GroupBox12.Controls.Add(Me.CmbArea)
        Me.GroupBox12.Location = New System.Drawing.Point(599, 274)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(267, 99)
        Me.GroupBox12.TabIndex = 30
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "AREA"
        '
        'LblArea
        '
        Me.LblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblArea.Location = New System.Drawing.Point(12, 58)
        Me.LblArea.Name = "LblArea"
        Me.LblArea.Size = New System.Drawing.Size(249, 25)
        Me.LblArea.TabIndex = 2
        Me.LblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbArea
        '
        Me.CmbArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbArea.FormattingEnabled = True
        Me.CmbArea.Items.AddRange(New Object() {"ADMINISTRATIVA", "FINANZAS", "GESTION HUMANA", "HSEQ", "OPERACIONES", "TECNOLOGIA", "TRANSPORTE", "OTRA"})
        Me.CmbArea.Location = New System.Drawing.Point(10, 21)
        Me.CmbArea.Name = "CmbArea"
        Me.CmbArea.Size = New System.Drawing.Size(251, 24)
        Me.CmbArea.TabIndex = 1
        '
        'GroupBox13
        '
        Me.GroupBox13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox13.Controls.Add(Me.BtnBuscaCiudad)
        Me.GroupBox13.Controls.Add(Me.TxtMunicipio)
        Me.GroupBox13.Controls.Add(Me.TxtDivipol)
        Me.GroupBox13.Controls.Add(Me.Label5)
        Me.GroupBox13.Controls.Add(Me.TxtDepto)
        Me.GroupBox13.Controls.Add(Me.Label4)
        Me.GroupBox13.Controls.Add(Me.Label6)
        Me.GroupBox13.Controls.Add(Me.TxtPais)
        Me.GroupBox13.Location = New System.Drawing.Point(12, 149)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(579, 158)
        Me.GroupBox13.TabIndex = 29
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "DESTINO"
        '
        'BtnBuscaCiudad
        '
        Me.BtnBuscaCiudad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscaCiudad.FlatAppearance.BorderSize = 0
        Me.BtnBuscaCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaCiudad.Image = CType(resources.GetObject("BtnBuscaCiudad.Image"), System.Drawing.Image)
        Me.BtnBuscaCiudad.Location = New System.Drawing.Point(9, 25)
        Me.BtnBuscaCiudad.Name = "BtnBuscaCiudad"
        Me.BtnBuscaCiudad.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscaCiudad.TabIndex = 10
        Me.BtnBuscaCiudad.UseVisualStyleBackColor = True
        '
        'TxtMunicipio
        '
        Me.TxtMunicipio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMunicipio.Location = New System.Drawing.Point(234, 72)
        Me.TxtMunicipio.MaxLength = 50
        Me.TxtMunicipio.Name = "TxtMunicipio"
        Me.TxtMunicipio.ReadOnly = True
        Me.TxtMunicipio.Size = New System.Drawing.Size(325, 26)
        Me.TxtMunicipio.TabIndex = 7
        '
        'TxtDivipol
        '
        Me.TxtDivipol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDivipol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDivipol.Location = New System.Drawing.Point(150, 72)
        Me.TxtDivipol.MaxLength = 5
        Me.TxtDivipol.Name = "TxtDivipol"
        Me.TxtDivipol.ReadOnly = True
        Me.TxtDivipol.Size = New System.Drawing.Size(78, 26)
        Me.TxtDivipol.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "MUNICIPIO :"
        '
        'TxtDepto
        '
        Me.TxtDepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDepto.Location = New System.Drawing.Point(150, 25)
        Me.TxtDepto.MaxLength = 30
        Me.TxtDepto.Name = "TxtDepto"
        Me.TxtDepto.ReadOnly = True
        Me.TxtDepto.Size = New System.Drawing.Size(409, 26)
        Me.TxtDepto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DEPARTAMENTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(372, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "PAIS"
        '
        'TxtPais
        '
        Me.TxtPais.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPais.Location = New System.Drawing.Point(409, 116)
        Me.TxtPais.MaxLength = 15
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.ReadOnly = True
        Me.TxtPais.Size = New System.Drawing.Size(150, 26)
        Me.TxtPais.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox16)
        Me.Panel1.Controls.Add(Me.GroupBox13)
        Me.Panel1.Controls.Add(Me.GroupBox14)
        Me.Panel1.Controls.Add(Me.GroupBox12)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 446)
        Me.Panel1.TabIndex = 33
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(691, 379)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(175, 55)
        Me.BtnGuardar.TabIndex = 33
        Me.BtnGuardar.Text = "Registrar Movimiento"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'For_EquiposMovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 474)
        Me.Controls.Add(Me.Panel1)
        Me.MinimizeBox = False
        Me.Name = "For_EquiposMovimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Movimientos - Asignaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGResultado As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents CmbElemento As ComboBox
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents LblLugar As Label
    Friend WithEvents CmbLugar As ComboBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents BtnBuscaResp As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtResponsable As TextBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents LblArea As Label
    Friend WithEvents CmbArea As ComboBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents BtnBuscaCiudad As Button
    Friend WithEvents TxtMunicipio As TextBox
    Friend WithEvents TxtDivipol As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDepto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPais As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnGuardar As Button
End Class
