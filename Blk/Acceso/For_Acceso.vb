Public Class For_Acceso
    Private Sub For_Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '------------ Verificar que solo se abra una sesión -------------------
        Dim iProcess As Integer

        iProcess = System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length
        If iProcess <> 1 Then
            MsgBox("Ya se encuentra una sesión abierta de " + Application.ProductName, MsgBoxStyle.Critical, "BULKMATIC DE COLOMBIA")
            End
        Else
            'Lanzo la aplicacion
        End If

        '-----------------------------------------------------------------------
        'Call CorrigeFechaHora()
        Call LicenciaUso()
        Call MinimizarVentanas()

        LblVersion.Text = Version()


        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent

        LblVersion.Parent = PictureBox1
        LblVersion.BackColor = Color.Transparent
        Me.TransparencyKey = Me.BackColor
        ImgSalir.Parent = PictureBox1
        ImgSalir.Parent = PictureBox1

    End Sub

    Private Sub ImgSalir_Click(sender As Object, e As EventArgs) Handles ImgSalir.Click
        End
    End Sub

    Private Sub TxtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuario.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If TxtUsuario.Text = "" Then
                MsgBox("Digite su Identificación BLK!", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            Else
                TxtContraseña.Focus()
            End If

        Else

            '------solo numeros y controles ---------------
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsSeparator(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
            '---------------------------------------------

        End If

    End Sub
    Private Sub TxtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContraseña.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnIngresar.Focus()
        End If
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        '------------- Verifico los datos de Acceso -----------------------------
        If Trim(TxtUsuario.Text) = "" Then
            MsgBox("Digite su ID de BLK", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtUsuario.Focus()
            Exit Sub
        End If

        If Trim(TxtContraseña.Text) = "" Then
            MsgBox("Digite su Contraseña de BLK", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtContraseña.Focus()
            Exit Sub
        End If
        '-------------------------------------------------------------------------

        '---------Evito Inyecciones SQL -----------------------------------------
        Dim N_Usuario = SeguridadBlk.InyeccionSQL(TxtUsuario.Text)
        '------------------------------------------------------------------------

        Gl_Key = SeguridadBlk.EncryptStr(Trim(TxtContraseña.Text), GL_ClaveEncrip)

        Dim Autorizacion As Boolean

        Autorizacion = SeguridadBlk.Logueo(N_Usuario, Gl_Key)

        If Autorizacion = True Then

            UsuarioApp.Datosusuario(N_Usuario)
            CompañiaApp.DatosCompañia()

            Me.Dispose()

            'For_MenuPrincipal.ShowDialog()
            For_Principal.ShowDialog()

        Else
            MsgBox("ACCESO NO AUTORIZADO!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Me.Dispose()
            End
        End If

        ''---------------------------------------------------------------------------------

    End Sub

End Class