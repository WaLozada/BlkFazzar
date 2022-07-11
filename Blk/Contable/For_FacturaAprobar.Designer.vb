<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_FacturaAprobar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_FacturaAprobar))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGFacturas = New System.Windows.Forms.DataGridView()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.CmbAprobacion = New System.Windows.Forms.ComboBox()
        Me.CmbPresupuesto = New System.Windows.Forms.ComboBox()
        Me.BtnVisor = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DGFacturas)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(924, 363)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "LISTADO DE FACTURAS"
        '
        'DGFacturas
        '
        Me.DGFacturas.AllowUserToAddRows = False
        Me.DGFacturas.AllowUserToDeleteRows = False
        Me.DGFacturas.AllowUserToOrderColumns = True
        Me.DGFacturas.AllowUserToResizeColumns = False
        Me.DGFacturas.AllowUserToResizeRows = False
        Me.DGFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGFacturas.BackgroundColor = System.Drawing.Color.White
        Me.DGFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGFacturas.Location = New System.Drawing.Point(10, 19)
        Me.DGFacturas.Name = "DGFacturas"
        Me.DGFacturas.ReadOnly = True
        Me.DGFacturas.RowHeadersVisible = False
        Me.DGFacturas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGFacturas.Size = New System.Drawing.Size(905, 332)
        Me.DGFacturas.TabIndex = 0
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcel.BackColor = System.Drawing.Color.Gray
        Me.BtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcel.ForeColor = System.Drawing.Color.White
        Me.BtnExcel.Image = CType(resources.GetObject("BtnExcel.Image"), System.Drawing.Image)
        Me.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcel.Location = New System.Drawing.Point(795, 381)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(141, 57)
        Me.BtnExcel.TabIndex = 2
        Me.BtnExcel.Text = "Exportar Excel"
        Me.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnRegistrar)
        Me.GroupBox1.Controls.Add(Me.CmbAprobacion)
        Me.GroupBox1.Controls.Add(Me.CmbPresupuesto)
        Me.GroupBox1.Location = New System.Drawing.Point(131, 381)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 57)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LINEA DE PRESUPUESTO"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Image = CType(resources.GetObject("BtnRegistrar.Image"), System.Drawing.Image)
        Me.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistrar.Location = New System.Drawing.Point(509, 11)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(102, 41)
        Me.BtnRegistrar.TabIndex = 2
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'CmbAprobacion
        '
        Me.CmbAprobacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAprobacion.FormattingEnabled = True
        Me.CmbAprobacion.Items.AddRange(New Object() {"APROBADA", "RECHAZADA"})
        Me.CmbAprobacion.Location = New System.Drawing.Point(369, 22)
        Me.CmbAprobacion.Name = "CmbAprobacion"
        Me.CmbAprobacion.Size = New System.Drawing.Size(134, 24)
        Me.CmbAprobacion.TabIndex = 1
        '
        'CmbPresupuesto
        '
        Me.CmbPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPresupuesto.FormattingEnabled = True
        Me.CmbPresupuesto.Location = New System.Drawing.Point(10, 22)
        Me.CmbPresupuesto.Name = "CmbPresupuesto"
        Me.CmbPresupuesto.Size = New System.Drawing.Size(353, 24)
        Me.CmbPresupuesto.TabIndex = 0
        '
        'BtnVisor
        '
        Me.BtnVisor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnVisor.BackColor = System.Drawing.Color.Gray
        Me.BtnVisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVisor.ForeColor = System.Drawing.Color.White
        Me.BtnVisor.Image = CType(resources.GetObject("BtnVisor.Image"), System.Drawing.Image)
        Me.BtnVisor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVisor.Location = New System.Drawing.Point(8, 387)
        Me.BtnVisor.Name = "BtnVisor"
        Me.BtnVisor.Size = New System.Drawing.Size(117, 51)
        Me.BtnVisor.TabIndex = 0
        Me.BtnVisor.Text = "Ver Factura"
        Me.BtnVisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVisor.UseVisualStyleBackColor = False
        '
        'For_FacturaAprobar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 450)
        Me.Controls.Add(Me.BtnVisor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_FacturaAprobar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aprobar Facturas"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGFacturas As DataGridView
    Friend WithEvents BtnExcel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents CmbAprobacion As ComboBox
    Friend WithEvents CmbPresupuesto As ComboBox
    Friend WithEvents BtnVisor As Button
End Class
