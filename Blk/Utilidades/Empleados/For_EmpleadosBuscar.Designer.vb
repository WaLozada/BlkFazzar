<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_EmpleadosBuscar
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_EmpleadosBuscar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGEmpleados = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtEmpleado = New System.Windows.Forms.TextBox()
        Me.BtnProveedor = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGEmpleados)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(737, 334)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESULTADOS"
        '
        'DGEmpleados
        '
        Me.DGEmpleados.AllowUserToAddRows = False
        Me.DGEmpleados.AllowUserToDeleteRows = False
        Me.DGEmpleados.AllowUserToResizeColumns = False
        Me.DGEmpleados.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGEmpleados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGEmpleados.BackgroundColor = System.Drawing.Color.White
        Me.DGEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGEmpleados.Location = New System.Drawing.Point(6, 19)
        Me.DGEmpleados.Name = "DGEmpleados"
        Me.DGEmpleados.ReadOnly = True
        Me.DGEmpleados.RowHeadersVisible = False
        Me.DGEmpleados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGEmpleados.Size = New System.Drawing.Size(725, 308)
        Me.DGEmpleados.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtEmpleado)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 51)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EMPLEADO"
        '
        'TxtEmpleado
        '
        Me.TxtEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpleado.Location = New System.Drawing.Point(6, 19)
        Me.TxtEmpleado.MaxLength = 30
        Me.TxtEmpleado.Name = "TxtEmpleado"
        Me.TxtEmpleado.Size = New System.Drawing.Size(543, 26)
        Me.TxtEmpleado.TabIndex = 1
        '
        'BtnProveedor
        '
        Me.BtnProveedor.BackColor = System.Drawing.Color.DarkGray
        Me.BtnProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedor.ForeColor = System.Drawing.Color.White
        Me.BtnProveedor.Image = CType(resources.GetObject("BtnProveedor.Image"), System.Drawing.Image)
        Me.BtnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProveedor.Location = New System.Drawing.Point(573, 12)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Size = New System.Drawing.Size(178, 51)
        Me.BtnProveedor.TabIndex = 33
        Me.BtnProveedor.Text = "Adicionar Empleado"
        Me.BtnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProveedor.UseVisualStyleBackColor = False
        '
        'For_EmpleadosBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 411)
        Me.Controls.Add(Me.BtnProveedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_EmpleadosBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Empleados"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnProveedor As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGEmpleados As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtEmpleado As TextBox
End Class
