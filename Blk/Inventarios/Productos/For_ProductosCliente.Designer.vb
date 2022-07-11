<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_ProductosCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_ProductosCliente))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGProductos = New System.Windows.Forms.DataGridView()
        Me.BtnAsignar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtIdProducto = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LblNombreCliente = New System.Windows.Forms.Label()
        Me.TxtCodCliente = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox5.Location = New System.Drawing.Point(180, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(539, 53)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DESCRIPCION"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(6, 19)
        Me.TxtDescripcion.MaxLength = 50
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ReadOnly = True
        Me.TxtDescripcion.Size = New System.Drawing.Size(527, 26)
        Me.TxtDescripcion.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(162, 53)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CODIGO"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(6, 19)
        Me.TxtCodigo.MaxLength = 11
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(143, 26)
        Me.TxtCodigo.TabIndex = 1
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGProductos)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 128)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(708, 296)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PRODUCTOS"
        '
        'DGProductos
        '
        Me.DGProductos.AllowUserToAddRows = False
        Me.DGProductos.AllowUserToDeleteRows = False
        Me.DGProductos.AllowUserToOrderColumns = True
        Me.DGProductos.AllowUserToResizeColumns = False
        Me.DGProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGProductos.BackgroundColor = System.Drawing.Color.White
        Me.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProductos.Location = New System.Drawing.Point(6, 19)
        Me.DGProductos.Name = "DGProductos"
        Me.DGProductos.ReadOnly = True
        Me.DGProductos.RowHeadersVisible = False
        Me.DGProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGProductos.Size = New System.Drawing.Size(696, 271)
        Me.DGProductos.TabIndex = 1
        '
        'BtnAsignar
        '
        Me.BtnAsignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAsignar.BackColor = System.Drawing.Color.Gray
        Me.BtnAsignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAsignar.ForeColor = System.Drawing.Color.White
        Me.BtnAsignar.Image = CType(resources.GetObject("BtnAsignar.Image"), System.Drawing.Image)
        Me.BtnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAsignar.Location = New System.Drawing.Point(557, 435)
        Me.BtnAsignar.Name = "BtnAsignar"
        Me.BtnAsignar.Size = New System.Drawing.Size(162, 50)
        Me.BtnAsignar.TabIndex = 2
        Me.BtnAsignar.Text = "Asignar a Cliente"
        Me.BtnAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAsignar.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtIdProducto)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 435)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(162, 53)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "IDPRODUCTO"
        Me.GroupBox4.Visible = False
        '
        'TxtIdProducto
        '
        Me.TxtIdProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtIdProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdProducto.Location = New System.Drawing.Point(6, 19)
        Me.TxtIdProducto.MaxLength = 11
        Me.TxtIdProducto.Name = "TxtIdProducto"
        Me.TxtIdProducto.ReadOnly = True
        Me.TxtIdProducto.Size = New System.Drawing.Size(143, 26)
        Me.TxtIdProducto.TabIndex = 1
        Me.TxtIdProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LblNombreCliente)
        Me.GroupBox6.Controls.Add(Me.TxtCodCliente)
        Me.GroupBox6.Controls.Add(Me.BtnBuscar)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(708, 51)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "CLIENTE"
        '
        'LblNombreCliente
        '
        Me.LblNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreCliente.Location = New System.Drawing.Point(136, 17)
        Me.LblNombreCliente.Name = "LblNombreCliente"
        Me.LblNombreCliente.Size = New System.Drawing.Size(567, 26)
        Me.LblNombreCliente.TabIndex = 13
        Me.LblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCodCliente
        '
        Me.TxtCodCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCodCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodCliente.Location = New System.Drawing.Point(50, 17)
        Me.TxtCodCliente.MaxLength = 30
        Me.TxtCodCliente.Name = "TxtCodCliente"
        Me.TxtCodCliente.ReadOnly = True
        Me.TxtCodCliente.Size = New System.Drawing.Size(80, 26)
        Me.TxtCodCliente.TabIndex = 12
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(6, 13)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscar.TabIndex = 11
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'For_ProductosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 491)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnAsignar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_ProductosCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos Cliente"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGProductos As DataGridView
    Friend WithEvents BtnAsignar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtIdProducto As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LblNombreCliente As Label
    Friend WithEvents TxtCodCliente As TextBox
    Friend WithEvents BtnBuscar As Button
End Class
