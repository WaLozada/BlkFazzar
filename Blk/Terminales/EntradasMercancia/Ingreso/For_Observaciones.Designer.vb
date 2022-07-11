<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_Observaciones
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_Observaciones))
        Me.DGObservaciones = New System.Windows.Forms.DataGridView()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        CType(Me.DGObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGObservaciones
        '
        Me.DGObservaciones.AllowUserToAddRows = False
        Me.DGObservaciones.AllowUserToDeleteRows = False
        Me.DGObservaciones.AllowUserToOrderColumns = True
        Me.DGObservaciones.AllowUserToResizeColumns = False
        Me.DGObservaciones.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGObservaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGObservaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGObservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGObservaciones.BackgroundColor = System.Drawing.Color.White
        Me.DGObservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGObservaciones.Location = New System.Drawing.Point(12, 12)
        Me.DGObservaciones.Name = "DGObservaciones"
        Me.DGObservaciones.ReadOnly = True
        Me.DGObservaciones.RowHeadersVisible = False
        Me.DGObservaciones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGObservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGObservaciones.Size = New System.Drawing.Size(733, 345)
        Me.DGObservaciones.TabIndex = 1
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Image = CType(resources.GetObject("BtnAdicionar.Image"), System.Drawing.Image)
        Me.BtnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdicionar.Location = New System.Drawing.Point(593, 362)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(152, 40)
        Me.BtnAdicionar.TabIndex = 3
        Me.BtnAdicionar.Text = "Incluir Observaciones"
        Me.BtnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdicionar.UseVisualStyleBackColor = True
        '
        'For_Observaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 405)
        Me.Controls.Add(Me.BtnAdicionar)
        Me.Controls.Add(Me.DGObservaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_Observaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Observaciones"
        CType(Me.DGObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGObservaciones As DataGridView
    Friend WithEvents BtnAdicionar As Button
End Class
