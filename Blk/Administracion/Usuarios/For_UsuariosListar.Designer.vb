<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_UsuariosListar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_UsuariosListar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGUsuarios = New System.Windows.Forms.DataGridView()
        Me.BtnPerfil = New System.Windows.Forms.Button()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnCorreo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGUsuarios)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 370)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'DGUsuarios
        '
        Me.DGUsuarios.AllowUserToAddRows = False
        Me.DGUsuarios.AllowUserToDeleteRows = False
        Me.DGUsuarios.AllowUserToOrderColumns = True
        Me.DGUsuarios.AllowUserToResizeColumns = False
        Me.DGUsuarios.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.DGUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUsuarios.Location = New System.Drawing.Point(10, 19)
        Me.DGUsuarios.Name = "DGUsuarios"
        Me.DGUsuarios.ReadOnly = True
        Me.DGUsuarios.RowHeadersVisible = False
        Me.DGUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGUsuarios.Size = New System.Drawing.Size(807, 345)
        Me.DGUsuarios.TabIndex = 0
        '
        'BtnPerfil
        '
        Me.BtnPerfil.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPerfil.BackColor = System.Drawing.Color.Gray
        Me.BtnPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPerfil.ForeColor = System.Drawing.Color.White
        Me.BtnPerfil.Image = CType(resources.GetObject("BtnPerfil.Image"), System.Drawing.Image)
        Me.BtnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPerfil.Location = New System.Drawing.Point(352, 388)
        Me.BtnPerfil.Name = "BtnPerfil"
        Me.BtnPerfil.Size = New System.Drawing.Size(158, 51)
        Me.BtnPerfil.TabIndex = 2
        Me.BtnPerfil.Text = "Establecer Perfil"
        Me.BtnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPerfil.UseVisualStyleBackColor = False
        '
        'BtnCrear
        '
        Me.BtnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCrear.BackColor = System.Drawing.Color.Gray
        Me.BtnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrear.ForeColor = System.Drawing.Color.White
        Me.BtnCrear.Image = CType(resources.GetObject("BtnCrear.Image"), System.Drawing.Image)
        Me.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrear.Location = New System.Drawing.Point(680, 388)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(158, 51)
        Me.BtnCrear.TabIndex = 0
        Me.BtnCrear.Text = "Crear Usuario"
        Me.BtnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrear.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.BackColor = System.Drawing.Color.Gray
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(516, 388)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(158, 51)
        Me.BtnEditar.TabIndex = 3
        Me.BtnEditar.Text = "Editar Usuario"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnCorreo
        '
        Me.BtnCorreo.BackColor = System.Drawing.Color.Gray
        Me.BtnCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCorreo.ForeColor = System.Drawing.Color.White
        Me.BtnCorreo.Image = CType(resources.GetObject("BtnCorreo.Image"), System.Drawing.Image)
        Me.BtnCorreo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnCorreo.Location = New System.Drawing.Point(12, 388)
        Me.BtnCorreo.Name = "BtnCorreo"
        Me.BtnCorreo.Size = New System.Drawing.Size(158, 51)
        Me.BtnCorreo.TabIndex = 45
        Me.BtnCorreo.Text = "Enviar Correo"
        Me.BtnCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCorreo.UseVisualStyleBackColor = False
        Me.BtnCorreo.Visible = False
        '
        'For_UsuariosListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 450)
        Me.Controls.Add(Me.BtnCorreo)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnPerfil)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "For_UsuariosListar"
        Me.Text = "Listado de Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGUsuarios As DataGridView
    Friend WithEvents BtnPerfil As Button
    Friend WithEvents BtnCrear As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnCorreo As Button
End Class
