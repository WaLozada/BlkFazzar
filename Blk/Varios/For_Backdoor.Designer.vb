<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_Backdoor
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtAcceso2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtAcceso1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtAcceso2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(184, 67)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'TxtAcceso2
        '
        Me.TxtAcceso2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAcceso2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAcceso2.Location = New System.Drawing.Point(12, 19)
        Me.TxtAcceso2.MaxLength = 10
        Me.TxtAcceso2.Name = "TxtAcceso2"
        Me.TxtAcceso2.Size = New System.Drawing.Size(156, 35)
        Me.TxtAcceso2.TabIndex = 0
        Me.TxtAcceso2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAcceso2.UseSystemPasswordChar = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtAcceso1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 67)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'TxtAcceso1
        '
        Me.TxtAcceso1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAcceso1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAcceso1.Location = New System.Drawing.Point(12, 22)
        Me.TxtAcceso1.MaxLength = 10
        Me.TxtAcceso1.Name = "TxtAcceso1"
        Me.TxtAcceso1.Size = New System.Drawing.Size(156, 35)
        Me.TxtAcceso1.TabIndex = 0
        Me.TxtAcceso1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAcceso1.UseSystemPasswordChar = True
        '
        'For_Backdoor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(203, 163)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_Backdoor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bulkmatic"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtAcceso2 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtAcceso1 As TextBox
End Class
