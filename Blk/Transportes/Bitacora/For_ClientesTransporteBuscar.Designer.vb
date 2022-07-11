<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_ClientesTransporteBuscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_ClientesTransporteBuscar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGClientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGClientes)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 281)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESULTADOS"
        '
        'DGClientes
        '
        Me.DGClientes.AllowUserToAddRows = False
        Me.DGClientes.AllowUserToDeleteRows = False
        Me.DGClientes.AllowUserToResizeColumns = False
        Me.DGClientes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGClientes.BackgroundColor = System.Drawing.Color.White
        Me.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGClientes.Location = New System.Drawing.Point(6, 19)
        Me.DGClientes.Name = "DGClientes"
        Me.DGClientes.ReadOnly = True
        Me.DGClientes.RowHeadersVisible = False
        Me.DGClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGClientes.Size = New System.Drawing.Size(631, 255)
        Me.DGClientes.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtCliente)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(660, 51)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CLIENTE"
        '
        'TxtCliente
        '
        Me.TxtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCliente.Location = New System.Drawing.Point(6, 19)
        Me.TxtCliente.MaxLength = 30
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(633, 26)
        Me.TxtCliente.TabIndex = 1
        '
        'BtnCliente
        '
        Me.BtnCliente.BackColor = System.Drawing.Color.DarkGray
        Me.BtnCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCliente.ForeColor = System.Drawing.Color.White
        Me.BtnCliente.Image = CType(resources.GetObject("BtnCliente.Image"), System.Drawing.Image)
        Me.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCliente.Location = New System.Drawing.Point(701, 20)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(159, 51)
        Me.BtnCliente.TabIndex = 34
        Me.BtnCliente.Text = "Adicionar Cliente"
        Me.BtnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCliente.UseVisualStyleBackColor = False
        '
        'For_ClientesTransporteBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 361)
        Me.Controls.Add(Me.BtnCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_ClientesTransporteBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clientes Transporte "
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGClientes As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents BtnCliente As Button
End Class
