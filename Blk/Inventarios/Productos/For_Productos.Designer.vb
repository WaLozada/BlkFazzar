<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class For_Productos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_Productos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GBCodigo = New System.Windows.Forms.GroupBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbFamilia = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmbUnidad = New System.Windows.Forms.ComboBox()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CmbEmpaque = New System.Windows.Forms.ComboBox()
        Me.GBCodigoProducto = New System.Windows.Forms.GroupBox()
        Me.TxtIdProducto = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DGProductos = New System.Windows.Forms.DataGridView()
        Me.ChkAutomatico = New System.Windows.Forms.CheckBox()
        Me.GBCodigo.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GBCodigoProducto.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DGProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBCodigo
        '
        Me.GBCodigo.Controls.Add(Me.ChkAutomatico)
        Me.GBCodigo.Controls.Add(Me.TxtCodigo)
        Me.GBCodigo.Location = New System.Drawing.Point(12, 19)
        Me.GBCodigo.Name = "GBCodigo"
        Me.GBCodigo.Size = New System.Drawing.Size(293, 53)
        Me.GBCodigo.TabIndex = 0
        Me.GBCodigo.TabStop = False
        Me.GBCodigo.Text = "CODIGO"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(139, 16)
        Me.TxtCodigo.MaxLength = 11
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(143, 26)
        Me.TxtCodigo.TabIndex = 1
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox5.Location = New System.Drawing.Point(311, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(443, 53)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DESCRIPCION"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(14, 16)
        Me.TxtDescripcion.MaxLength = 50
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(423, 26)
        Me.TxtDescripcion.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbFamilia)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 53)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FAMILIA"
        '
        'CmbFamilia
        '
        Me.CmbFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbFamilia.FormattingEnabled = True
        Me.CmbFamilia.Location = New System.Drawing.Point(14, 16)
        Me.CmbFamilia.Name = "CmbFamilia"
        Me.CmbFamilia.Size = New System.Drawing.Size(232, 26)
        Me.CmbFamilia.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmbUnidad)
        Me.GroupBox3.Location = New System.Drawing.Point(282, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(185, 53)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "UNIDAD DE MEDIDA"
        '
        'CmbUnidad
        '
        Me.CmbUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUnidad.FormattingEnabled = True
        Me.CmbUnidad.Location = New System.Drawing.Point(14, 16)
        Me.CmbUnidad.Name = "CmbUnidad"
        Me.CmbUnidad.Size = New System.Drawing.Size(155, 26)
        Me.CmbUnidad.TabIndex = 1
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.BackColor = System.Drawing.Color.Gray
        Me.BtnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdicionar.ForeColor = System.Drawing.Color.White
        Me.BtnAdicionar.Image = CType(resources.GetObject("BtnAdicionar.Image"), System.Drawing.Image)
        Me.BtnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdicionar.Location = New System.Drawing.Point(623, 85)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(131, 51)
        Me.BtnAdicionar.TabIndex = 5
        Me.BtnAdicionar.Text = "Adicionar "
        Me.BtnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdicionar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Gray
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(623, 85)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(131, 51)
        Me.BtnActualizar.TabIndex = 11
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CmbEmpaque)
        Me.GroupBox4.Location = New System.Drawing.Point(507, 78)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(86, 53)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "EMPAQUE"
        '
        'CmbEmpaque
        '
        Me.CmbEmpaque.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEmpaque.FormattingEnabled = True
        Me.CmbEmpaque.Items.AddRange(New Object() {"SI", "NO"})
        Me.CmbEmpaque.Location = New System.Drawing.Point(14, 16)
        Me.CmbEmpaque.Name = "CmbEmpaque"
        Me.CmbEmpaque.Size = New System.Drawing.Size(59, 26)
        Me.CmbEmpaque.TabIndex = 0
        '
        'GBCodigoProducto
        '
        Me.GBCodigoProducto.Controls.Add(Me.TxtIdProducto)
        Me.GBCodigoProducto.Location = New System.Drawing.Point(12, 386)
        Me.GBCodigoProducto.Name = "GBCodigoProducto"
        Me.GBCodigoProducto.Size = New System.Drawing.Size(122, 53)
        Me.GBCodigoProducto.TabIndex = 13
        Me.GBCodigoProducto.TabStop = False
        Me.GBCodigoProducto.Text = "IDPRODUCTO"
        Me.GBCodigoProducto.Visible = False
        '
        'TxtIdProducto
        '
        Me.TxtIdProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtIdProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdProducto.Location = New System.Drawing.Point(17, 16)
        Me.TxtIdProducto.MaxLength = 10
        Me.TxtIdProducto.Name = "TxtIdProducto"
        Me.TxtIdProducto.ReadOnly = True
        Me.TxtIdProducto.Size = New System.Drawing.Size(98, 26)
        Me.TxtIdProducto.TabIndex = 0
        Me.TxtIdProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtIdProducto.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DGProductos)
        Me.GroupBox6.Location = New System.Drawing.Point(13, 142)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(741, 238)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "PRODUCTOS REGISTRADOS"
        '
        'DGProductos
        '
        Me.DGProductos.AllowUserToAddRows = False
        Me.DGProductos.AllowUserToDeleteRows = False
        Me.DGProductos.AllowUserToResizeColumns = False
        Me.DGProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGProductos.BackgroundColor = System.Drawing.Color.White
        Me.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProductos.Location = New System.Drawing.Point(13, 16)
        Me.DGProductos.Name = "DGProductos"
        Me.DGProductos.ReadOnly = True
        Me.DGProductos.RowHeadersVisible = False
        Me.DGProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGProductos.Size = New System.Drawing.Size(722, 216)
        Me.DGProductos.TabIndex = 2
        '
        'ChkAutomatico
        '
        Me.ChkAutomatico.AutoSize = True
        Me.ChkAutomatico.Checked = True
        Me.ChkAutomatico.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAutomatico.Location = New System.Drawing.Point(14, 23)
        Me.ChkAutomatico.Name = "ChkAutomatico"
        Me.ChkAutomatico.Size = New System.Drawing.Size(119, 17)
        Me.ChkAutomatico.TabIndex = 2
        Me.ChkAutomatico.Text = "ASIGNAR CODIGO"
        Me.ChkAutomatico.UseVisualStyleBackColor = True
        '
        'For_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 386)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GBCodigoProducto)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnAdicionar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GBCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTOS"
        Me.GBCodigo.ResumeLayout(False)
        Me.GBCodigo.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GBCodigoProducto.ResumeLayout(False)
        Me.GBCodigoProducto.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DGProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBCodigo As GroupBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbFamilia As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CmbUnidad As ComboBox
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CmbEmpaque As ComboBox
    Friend WithEvents GBCodigoProducto As GroupBox
    Friend WithEvents TxtIdProducto As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DGProductos As DataGridView
    Friend WithEvents ChkAutomatico As CheckBox
End Class
