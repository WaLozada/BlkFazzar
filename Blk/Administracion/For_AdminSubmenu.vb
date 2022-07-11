Public Class For_AdminSubmenu
    Private Sub BtnCentros_Click(sender As Object, e As EventArgs) Handles BtnCentros.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("04")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()
        For_CentrosListado.ShowDialog()

    End Sub

    Private Sub LblClose_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click


        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("08")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()
        For_ClientesListado.ShowDialog()

    End Sub

    Private Sub For_AdminSubmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = (For_Principal.Width / 2) - (Me.Width / 2)
        Me.Top = ((For_Principal.PnlPrincipal.Top) + 400)


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("11")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        For_UsuariosListar.ShowDialog()

    End Sub

    Private Sub BtnClave_Click(sender As Object, e As EventArgs) Handles BtnClave.Click
        Me.Dispose()
        MinimizarVentanas()
        For_UsuariosClave.ShowDialog()

    End Sub

    Private Sub BtnCompañia_Click(sender As Object, e As EventArgs) Handles BtnCompañia.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("01")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If


    End Sub

    Private Sub BtnRecaudos_Click(sender As Object, e As EventArgs) Handles BtnRecaudos.Click


        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("47")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        For_RecaudoServicios.ShowDialog()
    End Sub

    Private Sub BtnCeCo_Click(sender As Object, e As EventArgs) Handles BtnCeCo.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("56")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        For_CeCoListar.ShowDialog()
    End Sub
End Class