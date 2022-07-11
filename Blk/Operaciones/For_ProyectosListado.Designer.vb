<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_ProyectosListado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_ProyectosListado))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGProyectos = New System.Windows.Forms.DataGridView()
        Me.BtnContratos = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGProyectos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(952, 381)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'DGProyectos
        '
        Me.DGProyectos.AllowUserToAddRows = False
        Me.DGProyectos.AllowUserToDeleteRows = False
        Me.DGProyectos.AllowUserToOrderColumns = True
        Me.DGProyectos.AllowUserToResizeColumns = False
        Me.DGProyectos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGProyectos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGProyectos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGProyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGProyectos.BackgroundColor = System.Drawing.Color.White
        Me.DGProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProyectos.Location = New System.Drawing.Point(10, 19)
        Me.DGProyectos.Name = "DGProyectos"
        Me.DGProyectos.ReadOnly = True
        Me.DGProyectos.RowHeadersVisible = False
        Me.DGProyectos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGProyectos.Size = New System.Drawing.Size(933, 356)
        Me.DGProyectos.TabIndex = 0
        '
        'BtnContratos
        '
        Me.BtnContratos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnContratos.BackColor = System.Drawing.Color.Gray
        Me.BtnContratos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContratos.ForeColor = System.Drawing.Color.White
        Me.BtnContratos.Image = CType(resources.GetObject("BtnContratos.Image"), System.Drawing.Image)
        Me.BtnContratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnContratos.Location = New System.Drawing.Point(298, 399)
        Me.BtnContratos.Name = "BtnContratos"
        Me.BtnContratos.Size = New System.Drawing.Size(132, 50)
        Me.BtnContratos.TabIndex = 20
        Me.BtnContratos.Text = "Gestión Documental"
        Me.BtnContratos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnContratos.UseVisualStyleBackColor = False
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBorrar.BackColor = System.Drawing.Color.Gray
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.Color.White
        Me.BtnBorrar.Image = CType(resources.GetObject("BtnBorrar.Image"), System.Drawing.Image)
        Me.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrar.Location = New System.Drawing.Point(436, 399)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(110, 50)
        Me.BtnBorrar.TabIndex = 19
        Me.BtnBorrar.Text = "Eliminar"
        Me.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBorrar.UseVisualStyleBackColor = False
        Me.BtnBorrar.Visible = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.BackColor = System.Drawing.Color.Gray
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(160, 399)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(132, 50)
        Me.BtnEditar.TabIndex = 18
        Me.BtnEditar.Text = "Editar "
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnCrear
        '
        Me.BtnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCrear.BackColor = System.Drawing.Color.Gray
        Me.BtnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrear.ForeColor = System.Drawing.Color.White
        Me.BtnCrear.Image = CType(resources.GetObject("BtnCrear.Image"), System.Drawing.Image)
        Me.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrear.Location = New System.Drawing.Point(22, 399)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(132, 50)
        Me.BtnCrear.TabIndex = 17
        Me.BtnCrear.Text = "Crear "
        Me.BtnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrear.UseVisualStyleBackColor = False
        '
        'For_ProyectosListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 461)
        Me.Controls.Add(Me.BtnContratos)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimizeBox = False
        Me.Name = "For_ProyectosListado"
        Me.Text = "Listado de Proyectos - Operaciones"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnContratos As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnCrear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGProyectos As DataGridView
End Class
