<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_HabeasListar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_HabeasListar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGSolicitudes = New System.Windows.Forms.DataGridView()
        Me.BtnResponder = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGSolicitudes)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(870, 370)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'DGSolicitudes
        '
        Me.DGSolicitudes.AllowUserToAddRows = False
        Me.DGSolicitudes.AllowUserToDeleteRows = False
        Me.DGSolicitudes.AllowUserToOrderColumns = True
        Me.DGSolicitudes.AllowUserToResizeColumns = False
        Me.DGSolicitudes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGSolicitudes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGSolicitudes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGSolicitudes.BackgroundColor = System.Drawing.Color.White
        Me.DGSolicitudes.Location = New System.Drawing.Point(10, 19)
        Me.DGSolicitudes.Name = "DGSolicitudes"
        Me.DGSolicitudes.ReadOnly = True
        Me.DGSolicitudes.RowHeadersVisible = False
        Me.DGSolicitudes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGSolicitudes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGSolicitudes.Size = New System.Drawing.Size(851, 345)
        Me.DGSolicitudes.TabIndex = 0
        '
        'BtnResponder
        '
        Me.BtnResponder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnResponder.BackColor = System.Drawing.Color.Gray
        Me.BtnResponder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResponder.ForeColor = System.Drawing.Color.White
        Me.BtnResponder.Image = CType(resources.GetObject("BtnResponder.Image"), System.Drawing.Image)
        Me.BtnResponder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnResponder.Location = New System.Drawing.Point(12, 388)
        Me.BtnResponder.Name = "BtnResponder"
        Me.BtnResponder.Size = New System.Drawing.Size(176, 50)
        Me.BtnResponder.TabIndex = 17
        Me.BtnResponder.Text = "Responder Solicitud"
        Me.BtnResponder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnResponder.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.BackColor = System.Drawing.Color.Gray
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(546, 388)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(165, 50)
        Me.BtnEditar.TabIndex = 16
        Me.BtnEditar.Text = "Editar Solicitud"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = False
        Me.BtnEditar.Visible = False
        '
        'BtnCrear
        '
        Me.BtnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCrear.BackColor = System.Drawing.Color.Gray
        Me.BtnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrear.ForeColor = System.Drawing.Color.White
        Me.BtnCrear.Image = CType(resources.GetObject("BtnCrear.Image"), System.Drawing.Image)
        Me.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrear.Location = New System.Drawing.Point(717, 388)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(165, 50)
        Me.BtnCrear.TabIndex = 15
        Me.BtnCrear.Text = "Registrar Solicitud"
        Me.BtnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrear.UseVisualStyleBackColor = False
        '
        'For_HabeasListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 450)
        Me.Controls.Add(Me.BtnResponder)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "For_HabeasListar"
        Me.Text = "Gestión de Solicitudes del Titular de la Información"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnCrear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGSolicitudes As DataGridView
    Friend WithEvents BtnResponder As Button
End Class
