<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_OrdenesIngreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_OrdenesIngreso))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbBodegas = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbCentros = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DGOrdenes = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DTHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTDesde = New System.Windows.Forms.DateTimePicker()
        Me.BtnListar = New System.Windows.Forms.Button()
        Me.BtnVisualizar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbBodegas)
        Me.GroupBox2.Location = New System.Drawing.Point(333, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(371, 53)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BODEGA"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbCentros)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 53)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CENTRO (CEDIS)"
        '
        'CmbCentros
        '
        Me.CmbCentros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCentros.FormattingEnabled = True
        Me.CmbCentros.Location = New System.Drawing.Point(17, 18)
        Me.CmbCentros.Name = "CmbCentros"
        Me.CmbCentros.Size = New System.Drawing.Size(286, 24)
        Me.CmbCentros.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.DGOrdenes)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1326, 358)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ORDENES DE INGRESO"
        '
        'DGOrdenes
        '
        Me.DGOrdenes.AllowUserToAddRows = False
        Me.DGOrdenes.AllowUserToDeleteRows = False
        Me.DGOrdenes.AllowUserToOrderColumns = True
        Me.DGOrdenes.AllowUserToResizeColumns = False
        Me.DGOrdenes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGOrdenes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGOrdenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGOrdenes.BackgroundColor = System.Drawing.Color.White
        Me.DGOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGOrdenes.Location = New System.Drawing.Point(10, 19)
        Me.DGOrdenes.Name = "DGOrdenes"
        Me.DGOrdenes.ReadOnly = True
        Me.DGOrdenes.RowHeadersVisible = False
        Me.DGOrdenes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGOrdenes.Size = New System.Drawing.Size(1307, 327)
        Me.DGOrdenes.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DTHasta)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.DTDesde)
        Me.GroupBox3.Location = New System.Drawing.Point(715, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(412, 53)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FECHA :"
        '
        'DTHasta
        '
        Me.DTHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTHasta.Location = New System.Drawing.Point(273, 14)
        Me.DTHasta.Name = "DTHasta"
        Me.DTHasta.Size = New System.Drawing.Size(128, 29)
        Me.DTHasta.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "HASTA :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "DESDE :"
        '
        'DTDesde
        '
        Me.DTDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDesde.Location = New System.Drawing.Point(83, 14)
        Me.DTDesde.Name = "DTDesde"
        Me.DTDesde.Size = New System.Drawing.Size(128, 29)
        Me.DTDesde.TabIndex = 0
        '
        'BtnListar
        '
        Me.BtnListar.Image = CType(resources.GetObject("BtnListar.Image"), System.Drawing.Image)
        Me.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnListar.Location = New System.Drawing.Point(1133, 27)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(174, 40)
        Me.BtnListar.TabIndex = 40
        Me.BtnListar.Text = "Listar Ordenes de Ingreso"
        Me.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnListar.UseVisualStyleBackColor = True
        '
        'BtnVisualizar
        '
        Me.BtnVisualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnVisualizar.BackColor = System.Drawing.Color.Gray
        Me.BtnVisualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVisualizar.ForeColor = System.Drawing.Color.White
        Me.BtnVisualizar.Image = CType(resources.GetObject("BtnVisualizar.Image"), System.Drawing.Image)
        Me.BtnVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVisualizar.Location = New System.Drawing.Point(1167, 435)
        Me.BtnVisualizar.Name = "BtnVisualizar"
        Me.BtnVisualizar.Size = New System.Drawing.Size(171, 50)
        Me.BtnVisualizar.TabIndex = 39
        Me.BtnVisualizar.Text = "Visualizar Orden"
        Me.BtnVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVisualizar.UseVisualStyleBackColor = False
        '
        'For_OrdenesIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 489)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnListar)
        Me.Controls.Add(Me.BtnVisualizar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "For_OrdenesIngreso"
        Me.Text = "Ordenes de Ingreso"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbBodegas As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbCentros As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DGOrdenes As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DTHasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTDesde As DateTimePicker
    Friend WithEvents BtnListar As Button
    Friend WithEvents BtnVisualizar As Button
End Class
