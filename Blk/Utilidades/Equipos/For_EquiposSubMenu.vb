Public Class For_EquiposSubMenu
    Private Sub For_EquiposSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = (For_Principal.Width / 2) - (Me.Width / 2)
        Me.Top = ((For_Principal.PnlPrincipal.Top) + 390)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub BtnEquipos_Click(sender As Object, e As EventArgs) Handles BtnEquipos.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("38")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        For_EquiposRegistro.ShowDialog()

    End Sub

    Private Sub BtnConsultas_Click(sender As Object, e As EventArgs) Handles BtnConsultas.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("40")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        For_EquiposListar.ShowDialog()
    End Sub

    Private Sub BtnBajas_Click(sender As Object, e As EventArgs) Handles BtnBajas.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("39")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        For_EquiposBajas.ShowDialog()

    End Sub

    Private Sub BtnMovimientos_Click(sender As Object, e As EventArgs) Handles BtnMovimientos.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("41")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        For_EquiposMovimiento.ShowDialog()
    End Sub

    Private Sub BtnMantenimientos_Click(sender As Object, e As EventArgs) Handles BtnMantenimientos.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("42")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If
        For_EquiposMantenimiento.ShowDialog()
    End Sub

    Private Sub BtnHojasdevida_Click(sender As Object, e As EventArgs) Handles BtnHojasdevida.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("43")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        'Me.Dispose()
        For_EquiposHV.ShowDialog()


    End Sub
End Class