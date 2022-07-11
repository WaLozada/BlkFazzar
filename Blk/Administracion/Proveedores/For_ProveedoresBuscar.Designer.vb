<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_ProveedoresBuscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_ProveedoresBuscar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGProveedor = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.BtnProveedor = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGProveedor)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 311)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESULTADOS"
        '
        'DGProveedor
        '
        Me.DGProveedor.AllowUserToAddRows = False
        Me.DGProveedor.AllowUserToDeleteRows = False
        Me.DGProveedor.AllowUserToResizeColumns = False
        Me.DGProveedor.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGProveedor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGProveedor.BackgroundColor = System.Drawing.Color.White
        Me.DGProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProveedor.Location = New System.Drawing.Point(6, 19)
        Me.DGProveedor.Name = "DGProveedor"
        Me.DGProveedor.ReadOnly = True
        Me.DGProveedor.RowHeadersVisible = False
        Me.DGProveedor.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGProveedor.Size = New System.Drawing.Size(658, 286)
        Me.DGProveedor.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtProveedor)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 51)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PROVEEDOR"
        '
        'TxtProveedor
        '
        Me.TxtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProveedor.Location = New System.Drawing.Point(6, 19)
        Me.TxtProveedor.MaxLength = 30
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(476, 26)
        Me.TxtProveedor.TabIndex = 1
        '
        'BtnProveedor
        '
        Me.BtnProveedor.BackColor = System.Drawing.Color.DarkGray
        Me.BtnProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedor.ForeColor = System.Drawing.Color.White
        Me.BtnProveedor.Image = CType(resources.GetObject("BtnProveedor.Image"), System.Drawing.Image)
        Me.BtnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProveedor.Location = New System.Drawing.Point(506, 12)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Size = New System.Drawing.Size(178, 51)
        Me.BtnProveedor.TabIndex = 30
        Me.BtnProveedor.Text = "Adicionar Proveedor"
        Me.BtnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProveedor.UseVisualStyleBackColor = False
        '
        'For_ProveedoresBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 395)
        Me.Controls.Add(Me.BtnProveedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_ProveedoresBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGProveedor As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents BtnProveedor As Button
End Class
