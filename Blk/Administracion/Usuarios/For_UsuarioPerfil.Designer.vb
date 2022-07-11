<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_UsuarioPerfil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_UsuarioPerfil))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChklPerfiles = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.BtnGuardarPerfil = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ChklPerfiles)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(694, 358)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PERFILES"
        '
        'ChklPerfiles
        '
        Me.ChklPerfiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChklPerfiles.CheckOnClick = True
        Me.ChklPerfiles.ColumnWidth = 255
        Me.ChklPerfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChklPerfiles.FormattingEnabled = True
        Me.ChklPerfiles.Location = New System.Drawing.Point(12, 19)
        Me.ChklPerfiles.MultiColumn = True
        Me.ChklPerfiles.Name = "ChklPerfiles"
        Me.ChklPerfiles.Size = New System.Drawing.Size(674, 327)
        Me.ChklPerfiles.TabIndex = 0
        Me.ChklPerfiles.ThreeDCheckBoxes = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LblUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 55)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USUARIO"
        '
        'LblUsuario
        '
        Me.LblUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(12, 19)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(674, 22)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "NOMBRE DE USUARIO"
        Me.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnGuardarPerfil
        '
        Me.BtnGuardarPerfil.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarPerfil.BackColor = System.Drawing.Color.Gray
        Me.BtnGuardarPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarPerfil.ForeColor = System.Drawing.Color.White
        Me.BtnGuardarPerfil.Image = CType(resources.GetObject("BtnGuardarPerfil.Image"), System.Drawing.Image)
        Me.BtnGuardarPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarPerfil.Location = New System.Drawing.Point(548, 430)
        Me.BtnGuardarPerfil.Name = "BtnGuardarPerfil"
        Me.BtnGuardarPerfil.Size = New System.Drawing.Size(158, 51)
        Me.BtnGuardarPerfil.TabIndex = 4
        Me.BtnGuardarPerfil.Text = "Guardar Perfil"
        Me.BtnGuardarPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardarPerfil.UseVisualStyleBackColor = False
        '
        'For_UsuarioPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 490)
        Me.Controls.Add(Me.BtnGuardarPerfil)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MinimizeBox = False
        Me.Name = "For_UsuarioPerfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Establecer Perfiles"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ChklPerfiles As CheckedListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents BtnGuardarPerfil As Button
End Class
