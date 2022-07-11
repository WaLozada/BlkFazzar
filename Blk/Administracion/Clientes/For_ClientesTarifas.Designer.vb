<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_ClientesTarifas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_ClientesTarifas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblNombreCliente = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.DGTarifas = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmbBodegas = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CmbCentros = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CmbServicios = New System.Windows.Forms.ComboBox()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.CmbUnidad = New System.Windows.Forms.ComboBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(92, 49)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CODIGO"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo.Location = New System.Drawing.Point(6, 16)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(0, 20)
        Me.LblCodigo.TabIndex = 0
        Me.LblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblNombreCliente)
        Me.GroupBox2.Location = New System.Drawing.Point(115, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(615, 49)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CODIGO"
        '
        'LblNombreCliente
        '
        Me.LblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreCliente.Location = New System.Drawing.Point(6, 16)
        Me.LblNombreCliente.Name = "LblNombreCliente"
        Me.LblNombreCliente.Size = New System.Drawing.Size(577, 20)
        Me.LblNombreCliente.TabIndex = 0
        Me.LblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.BtnBorrar)
        Me.GroupBox4.Controls.Add(Me.BtnEditar)
        Me.GroupBox4.Controls.Add(Me.DGTarifas)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 190)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(714, 201)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TARIFAS"
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBorrar.BackColor = System.Drawing.Color.Gray
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.Color.White
        Me.BtnBorrar.Image = CType(resources.GetObject("BtnBorrar.Image"), System.Drawing.Image)
        Me.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrar.Location = New System.Drawing.Point(596, 145)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(110, 50)
        Me.BtnBorrar.TabIndex = 16
        Me.BtnBorrar.Text = "Eliminar"
        Me.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.BackColor = System.Drawing.Color.Gray
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(480, 145)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(110, 50)
        Me.BtnEditar.TabIndex = 15
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = False
        Me.BtnEditar.Visible = False
        '
        'DGTarifas
        '
        Me.DGTarifas.AllowUserToAddRows = False
        Me.DGTarifas.AllowUserToDeleteRows = False
        Me.DGTarifas.AllowUserToOrderColumns = True
        Me.DGTarifas.AllowUserToResizeColumns = False
        Me.DGTarifas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGTarifas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGTarifas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGTarifas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGTarifas.BackgroundColor = System.Drawing.Color.White
        Me.DGTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTarifas.Location = New System.Drawing.Point(11, 19)
        Me.DGTarifas.Name = "DGTarifas"
        Me.DGTarifas.ReadOnly = True
        Me.DGTarifas.RowHeadersVisible = False
        Me.DGTarifas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGTarifas.Size = New System.Drawing.Size(695, 120)
        Me.DGTarifas.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmbBodegas)
        Me.GroupBox3.Location = New System.Drawing.Point(359, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(371, 53)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BODEGA"
        '
        'CmbBodegas
        '
        Me.CmbBodegas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBodegas.FormattingEnabled = True
        Me.CmbBodegas.Location = New System.Drawing.Point(6, 18)
        Me.CmbBodegas.Name = "CmbBodegas"
        Me.CmbBodegas.Size = New System.Drawing.Size(350, 24)
        Me.CmbBodegas.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.CmbCentros)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 69)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(336, 53)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CENTRO"
        '
        'CmbCentros
        '
        Me.CmbCentros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCentros.FormattingEnabled = True
        Me.CmbCentros.Location = New System.Drawing.Point(10, 18)
        Me.CmbCentros.Name = "CmbCentros"
        Me.CmbCentros.Size = New System.Drawing.Size(320, 24)
        Me.CmbCentros.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CmbServicios)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 127)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(219, 57)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "SERVICIO"
        '
        'CmbServicios
        '
        Me.CmbServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbServicios.FormattingEnabled = True
        Me.CmbServicios.Location = New System.Drawing.Point(11, 19)
        Me.CmbServicios.Name = "CmbServicios"
        Me.CmbServicios.Size = New System.Drawing.Size(202, 24)
        Me.CmbServicios.TabIndex = 1
        '
        'TxtValor
        '
        Me.TxtValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValor.Location = New System.Drawing.Point(6, 19)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(147, 29)
        Me.TxtValor.TabIndex = 23
        Me.TxtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TxtValor)
        Me.GroupBox7.Location = New System.Drawing.Point(241, 127)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(162, 57)
        Me.GroupBox7.TabIndex = 24
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "VALOR"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.CmbUnidad)
        Me.GroupBox8.Location = New System.Drawing.Point(409, 127)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(184, 57)
        Me.GroupBox8.TabIndex = 25
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "UNIDAD"
        '
        'CmbUnidad
        '
        Me.CmbUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUnidad.FormattingEnabled = True
        Me.CmbUnidad.Location = New System.Drawing.Point(11, 19)
        Me.CmbUnidad.Name = "CmbUnidad"
        Me.CmbUnidad.Size = New System.Drawing.Size(162, 24)
        Me.CmbUnidad.TabIndex = 1
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Gray
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(599, 135)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(131, 45)
        Me.BtnGuardar.TabIndex = 26
        Me.BtnGuardar.Text = "Guardar Tarifa"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'For_ClientesTarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 403)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_ClientesTarifas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clientes Tarifas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblCodigo As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblNombreCliente As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DGTarifas As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CmbBodegas As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CmbCentros As ComboBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CmbServicios As ComboBox
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents CmbUnidad As ComboBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnEditar As Button
End Class
