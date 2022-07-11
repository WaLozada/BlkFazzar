<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class For_ProductoBloqueado
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_ProductoBloqueado))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TxtLote = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblUnidadProducto = New System.Windows.Forms.Label()
        Me.TxtCantidadProducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNombreProducto = New System.Windows.Forms.Label()
        Me.TxtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtObsDetalle = New System.Windows.Forms.TextBox()
        Me.DGBloqueo = New System.Windows.Forms.DataGridView()
        Me.ColCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColObservacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRuta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIdMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.BtnFoto = New System.Windows.Forms.Button()
        Me.CmbMotivo = New System.Windows.Forms.ComboBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.LblUnidadDetalle = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.ODRutaArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.LblRutaArchivoLocal = New System.Windows.Forms.Label()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGBloqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtLote)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.LblUnidadProducto)
        Me.GroupBox6.Controls.Add(Me.TxtCantidadProducto)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.LblNombreProducto)
        Me.GroupBox6.Controls.Add(Me.TxtCodigoProducto)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(628, 80)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "PRODUCTO"
        '
        'TxtLote
        '
        Me.TxtLote.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLote.Location = New System.Drawing.Point(289, 43)
        Me.TxtLote.MaxLength = 30
        Me.TxtLote.Name = "TxtLote"
        Me.TxtLote.ReadOnly = True
        Me.TxtLote.Size = New System.Drawing.Size(126, 26)
        Me.TxtLote.TabIndex = 22
        Me.TxtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(242, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "LOTE :"
        '
        'LblUnidadProducto
        '
        Me.LblUnidadProducto.AutoSize = True
        Me.LblUnidadProducto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUnidadProducto.Location = New System.Drawing.Point(600, 48)
        Me.LblUnidadProducto.Name = "LblUnidadProducto"
        Me.LblUnidadProducto.Size = New System.Drawing.Size(25, 16)
        Me.LblUnidadProducto.TabIndex = 20
        Me.LblUnidadProducto.Text = "Kg"
        Me.LblUnidadProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCantidadProducto
        '
        Me.TxtCantidadProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCantidadProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCantidadProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadProducto.Location = New System.Drawing.Point(499, 44)
        Me.TxtCantidadProducto.MaxLength = 30
        Me.TxtCantidadProducto.Name = "TxtCantidadProducto"
        Me.TxtCantidadProducto.ReadOnly = True
        Me.TxtCantidadProducto.Size = New System.Drawing.Size(94, 26)
        Me.TxtCantidadProducto.TabIndex = 19
        Me.TxtCantidadProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "CANTIDAD :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "DESCRIPCIÓN :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "CÓDIGO :"
        '
        'LblNombreProducto
        '
        Me.LblNombreProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreProducto.Location = New System.Drawing.Point(110, 15)
        Me.LblNombreProducto.Name = "LblNombreProducto"
        Me.LblNombreProducto.Size = New System.Drawing.Size(503, 23)
        Me.LblNombreProducto.TabIndex = 15
        Me.LblNombreProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCodigoProducto
        '
        Me.TxtCodigoProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCodigoProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoProducto.Location = New System.Drawing.Point(110, 44)
        Me.TxtCodigoProducto.MaxLength = 30
        Me.TxtCodigoProducto.Name = "TxtCodigoProducto"
        Me.TxtCodigoProducto.ReadOnly = True
        Me.TxtCodigoProducto.Size = New System.Drawing.Size(126, 26)
        Me.TxtCodigoProducto.TabIndex = 13
        Me.TxtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.DGBloqueo)
        Me.GroupBox1.Controls.Add(Me.BtnAdicionar)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox15)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 304)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETALLADO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtObsDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(487, 84)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OBSERVACION"
        '
        'TxtObsDetalle
        '
        Me.TxtObsDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObsDetalle.Location = New System.Drawing.Point(14, 17)
        Me.TxtObsDetalle.MaxLength = 210
        Me.TxtObsDetalle.Multiline = True
        Me.TxtObsDetalle.Name = "TxtObsDetalle"
        Me.TxtObsDetalle.Size = New System.Drawing.Size(467, 54)
        Me.TxtObsDetalle.TabIndex = 0
        '
        'DGBloqueo
        '
        Me.DGBloqueo.AllowUserToAddRows = False
        Me.DGBloqueo.AllowUserToDeleteRows = False
        Me.DGBloqueo.AllowUserToResizeColumns = False
        Me.DGBloqueo.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGBloqueo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGBloqueo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGBloqueo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGBloqueo.BackgroundColor = System.Drawing.Color.White
        Me.DGBloqueo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCodigo, Me.ColCantidad, Me.ColUnidad, Me.ColMotivo, Me.ColObservacion, Me.ColRuta, Me.ColIdMotivo, Me.ColLote})
        Me.DGBloqueo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGBloqueo.Location = New System.Drawing.Point(21, 166)
        Me.DGBloqueo.Name = "DGBloqueo"
        Me.DGBloqueo.ReadOnly = True
        Me.DGBloqueo.RowHeadersVisible = False
        Me.DGBloqueo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGBloqueo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBloqueo.Size = New System.Drawing.Size(600, 132)
        Me.DGBloqueo.TabIndex = 3
        '
        'ColCodigo
        '
        Me.ColCodigo.HeaderText = "CODIGO"
        Me.ColCodigo.Name = "ColCodigo"
        Me.ColCodigo.ReadOnly = True
        Me.ColCodigo.Width = 74
        '
        'ColCantidad
        '
        Me.ColCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColCantidad.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColCantidad.HeaderText = "CANTIDAD"
        Me.ColCantidad.Name = "ColCantidad"
        Me.ColCantidad.ReadOnly = True
        Me.ColCantidad.Width = 87
        '
        'ColUnidad
        '
        Me.ColUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColUnidad.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColUnidad.HeaderText = "UNIDAD"
        Me.ColUnidad.Name = "ColUnidad"
        Me.ColUnidad.ReadOnly = True
        Me.ColUnidad.Width = 74
        '
        'ColMotivo
        '
        Me.ColMotivo.HeaderText = "MOTIVO"
        Me.ColMotivo.Name = "ColMotivo"
        Me.ColMotivo.ReadOnly = True
        Me.ColMotivo.Width = 74
        '
        'ColObservacion
        '
        Me.ColObservacion.HeaderText = "OBSERVACION"
        Me.ColObservacion.Name = "ColObservacion"
        Me.ColObservacion.ReadOnly = True
        Me.ColObservacion.Width = 109
        '
        'ColRuta
        '
        Me.ColRuta.HeaderText = "RUTA"
        Me.ColRuta.Name = "ColRuta"
        Me.ColRuta.ReadOnly = True
        Me.ColRuta.Visible = False
        Me.ColRuta.Width = 62
        '
        'ColIdMotivo
        '
        Me.ColIdMotivo.HeaderText = "IDMOTIVO"
        Me.ColIdMotivo.Name = "ColIdMotivo"
        Me.ColIdMotivo.ReadOnly = True
        Me.ColIdMotivo.Visible = False
        Me.ColIdMotivo.Width = 85
        '
        'ColLote
        '
        Me.ColLote.HeaderText = "LOTE"
        Me.ColLote.Name = "ColLote"
        Me.ColLote.ReadOnly = True
        Me.ColLote.Width = 60
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Image = CType(resources.GetObject("BtnAdicionar.Image"), System.Drawing.Image)
        Me.BtnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdicionar.Location = New System.Drawing.Point(515, 100)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(98, 40)
        Me.BtnAdicionar.TabIndex = 2
        Me.BtnAdicionar.Text = "Adicionar"
        Me.BtnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdicionar.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.BtnFoto)
        Me.GroupBox7.Controls.Add(Me.CmbMotivo)
        Me.GroupBox7.Location = New System.Drawing.Point(180, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(433, 53)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "MOTIVO"
        '
        'BtnFoto
        '
        Me.BtnFoto.Enabled = False
        Me.BtnFoto.Image = CType(resources.GetObject("BtnFoto.Image"), System.Drawing.Image)
        Me.BtnFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFoto.Location = New System.Drawing.Point(301, 15)
        Me.BtnFoto.Name = "BtnFoto"
        Me.BtnFoto.Size = New System.Drawing.Size(126, 33)
        Me.BtnFoto.TabIndex = 16
        Me.BtnFoto.Text = "Incluir Fotorgrafía"
        Me.BtnFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFoto.UseVisualStyleBackColor = True
        '
        'CmbMotivo
        '
        Me.CmbMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMotivo.FormattingEnabled = True
        Me.CmbMotivo.Location = New System.Drawing.Point(6, 19)
        Me.CmbMotivo.Name = "CmbMotivo"
        Me.CmbMotivo.Size = New System.Drawing.Size(286, 24)
        Me.CmbMotivo.TabIndex = 15
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.LblUnidadDetalle)
        Me.GroupBox15.Controls.Add(Me.TxtCantidad)
        Me.GroupBox15.Location = New System.Drawing.Point(18, 19)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(156, 53)
        Me.GroupBox15.TabIndex = 0
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "CANTIDAD"
        '
        'LblUnidadDetalle
        '
        Me.LblUnidadDetalle.AutoSize = True
        Me.LblUnidadDetalle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUnidadDetalle.Location = New System.Drawing.Point(124, 23)
        Me.LblUnidadDetalle.Name = "LblUnidadDetalle"
        Me.LblUnidadDetalle.Size = New System.Drawing.Size(25, 16)
        Me.LblUnidadDetalle.TabIndex = 3
        Me.LblUnidadDetalle.Text = "Kg"
        Me.LblUnidadDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCantidad
        '
        Me.TxtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.Location = New System.Drawing.Point(16, 15)
        Me.TxtCantidad.MaxLength = 9
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(102, 26)
        Me.TxtCantidad.TabIndex = 1
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.BackColor = System.Drawing.Color.Gray
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(499, 406)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(142, 50)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar Detalle"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'LblRutaArchivoLocal
        '
        Me.LblRutaArchivoLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRutaArchivoLocal.Location = New System.Drawing.Point(33, 406)
        Me.LblRutaArchivoLocal.Name = "LblRutaArchivoLocal"
        Me.LblRutaArchivoLocal.Size = New System.Drawing.Size(451, 28)
        Me.LblRutaArchivoLocal.TabIndex = 3
        Me.LblRutaArchivoLocal.Visible = False
        '
        'For_ProductoBloqueado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 461)
        Me.Controls.Add(Me.LblRutaArchivoLocal)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_ProductoBloqueado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detallar Producto Bloqueado"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGBloqueo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LblNombreProducto As Label
    Friend WithEvents TxtCodigoProducto As TextBox
    Friend WithEvents TxtCantidadProducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents LblUnidadDetalle As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents CmbMotivo As ComboBox
    Friend WithEvents DGBloqueo As DataGridView
    Friend WithEvents BtnFoto As Button
    Friend WithEvents LblUnidadProducto As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtLote As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ODRutaArchivo As OpenFileDialog
    Friend WithEvents LblRutaArchivoLocal As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtObsDetalle As TextBox
    Friend WithEvents ColCodigo As DataGridViewTextBoxColumn
    Friend WithEvents ColCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ColUnidad As DataGridViewTextBoxColumn
    Friend WithEvents ColMotivo As DataGridViewTextBoxColumn
    Friend WithEvents ColObservacion As DataGridViewTextBoxColumn
    Friend WithEvents ColRuta As DataGridViewTextBoxColumn
    Friend WithEvents ColIdMotivo As DataGridViewTextBoxColumn
    Friend WithEvents ColLote As DataGridViewTextBoxColumn
End Class
