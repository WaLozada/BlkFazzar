<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_CeCoListar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_CeCoListar))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnCrearCeCo = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbSegmentos = New System.Windows.Forms.ComboBox()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.CmbTerminales = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGClientes = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGCeCoClientes = New System.Windows.Forms.DataGridView()
        Me.BtnCopiar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGCeCoClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCrearCeCo
        '
        Me.BtnCrearCeCo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnCrearCeCo.BackColor = System.Drawing.Color.Gray
        Me.BtnCrearCeCo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearCeCo.ForeColor = System.Drawing.Color.White
        Me.BtnCrearCeCo.Image = CType(resources.GetObject("BtnCrearCeCo.Image"), System.Drawing.Image)
        Me.BtnCrearCeCo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrearCeCo.Location = New System.Drawing.Point(594, 424)
        Me.BtnCrearCeCo.Name = "BtnCrearCeCo"
        Me.BtnCrearCeCo.Size = New System.Drawing.Size(186, 53)
        Me.BtnCrearCeCo.TabIndex = 53
        Me.BtnCrearCeCo.Text = "Crear Centro de Costo "
        Me.BtnCrearCeCo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrearCeCo.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ItemSize = New System.Drawing.Size(380, 30)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(768, 406)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 55
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox20)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(760, 368)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CENTROS DE COSTO POR TERMINAL"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.CmbSegmentos)
        Me.GroupBox1.Location = New System.Drawing.Point(393, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 56)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEGMENTO"
        '
        'CmbSegmentos
        '
        Me.CmbSegmentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSegmentos.FormattingEnabled = True
        Me.CmbSegmentos.Location = New System.Drawing.Point(6, 19)
        Me.CmbSegmentos.Name = "CmbSegmentos"
        Me.CmbSegmentos.Size = New System.Drawing.Size(315, 24)
        Me.CmbSegmentos.TabIndex = 3
        '
        'GroupBox20
        '
        Me.GroupBox20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox20.Controls.Add(Me.CmbTerminales)
        Me.GroupBox20.Location = New System.Drawing.Point(45, 6)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(341, 57)
        Me.GroupBox20.TabIndex = 55
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "TERMINAL"
        '
        'CmbTerminales
        '
        Me.CmbTerminales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTerminales.FormattingEnabled = True
        Me.CmbTerminales.Location = New System.Drawing.Point(10, 19)
        Me.CmbTerminales.Name = "CmbTerminales"
        Me.CmbTerminales.Size = New System.Drawing.Size(320, 24)
        Me.CmbTerminales.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DGClientes)
        Me.GroupBox3.Location = New System.Drawing.Point(45, 68)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(681, 294)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CLIENTES"
        '
        'DGClientes
        '
        Me.DGClientes.AllowUserToAddRows = False
        Me.DGClientes.AllowUserToDeleteRows = False
        Me.DGClientes.AllowUserToOrderColumns = True
        Me.DGClientes.AllowUserToResizeColumns = False
        Me.DGClientes.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGClientes.BackgroundColor = System.Drawing.Color.White
        Me.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGClientes.Location = New System.Drawing.Point(10, 19)
        Me.DGClientes.Name = "DGClientes"
        Me.DGClientes.ReadOnly = True
        Me.DGClientes.RowHeadersVisible = False
        Me.DGClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGClientes.Size = New System.Drawing.Size(659, 269)
        Me.DGClientes.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(760, 368)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CENTROS DE COSTO POR CLIENTE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnCopiar)
        Me.GroupBox5.Controls.Add(Me.LblCliente)
        Me.GroupBox5.Controls.Add(Me.BtnBuscarCliente)
        Me.GroupBox5.Location = New System.Drawing.Point(44, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(681, 61)
        Me.GroupBox5.TabIndex = 58
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CLIENTE"
        '
        'LblCliente
        '
        Me.LblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCliente.Location = New System.Drawing.Point(48, 18)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(578, 32)
        Me.LblCliente.TabIndex = 14
        Me.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarCliente.FlatAppearance.BorderSize = 0
        Me.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarCliente.Image = CType(resources.GetObject("BtnBuscarCliente.Image"), System.Drawing.Image)
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(6, 18)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscarCliente.TabIndex = 12
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DGCeCoClientes)
        Me.GroupBox2.Location = New System.Drawing.Point(44, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(681, 289)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CENTROS DE COSTO DEL CLIENTE"
        '
        'DGCeCoClientes
        '
        Me.DGCeCoClientes.AllowUserToAddRows = False
        Me.DGCeCoClientes.AllowUserToDeleteRows = False
        Me.DGCeCoClientes.AllowUserToOrderColumns = True
        Me.DGCeCoClientes.AllowUserToResizeColumns = False
        Me.DGCeCoClientes.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGCeCoClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGCeCoClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGCeCoClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGCeCoClientes.BackgroundColor = System.Drawing.Color.White
        Me.DGCeCoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCeCoClientes.Location = New System.Drawing.Point(10, 19)
        Me.DGCeCoClientes.Name = "DGCeCoClientes"
        Me.DGCeCoClientes.ReadOnly = True
        Me.DGCeCoClientes.RowHeadersVisible = False
        Me.DGCeCoClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGCeCoClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGCeCoClientes.Size = New System.Drawing.Size(659, 264)
        Me.DGCeCoClientes.TabIndex = 0
        '
        'BtnCopiar
        '
        Me.BtnCopiar.BackColor = System.Drawing.Color.White
        Me.BtnCopiar.Image = CType(resources.GetObject("BtnCopiar.Image"), System.Drawing.Image)
        Me.BtnCopiar.Location = New System.Drawing.Point(632, 15)
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(39, 37)
        Me.BtnCopiar.TabIndex = 15
        Me.BtnCopiar.UseVisualStyleBackColor = False
        '
        'For_CeCoListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 489)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnCrearCeCo)
        Me.MinimizeBox = False
        Me.Name = "For_CeCoListar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado de Centros de Costo"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGCeCoClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCrearCeCo As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbSegmentos As ComboBox
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents CmbTerminales As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGClientes As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGCeCoClientes As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LblCliente As Label
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents BtnCopiar As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
