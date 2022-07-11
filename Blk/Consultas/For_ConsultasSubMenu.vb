Public Class For_ConsultasSubMenu
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("35")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()
        For_ConsultaInventario.ShowDialog()
    End Sub
    Private Sub For_ConsultasSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = (For_Principal.Width / 2) - (Me.Width / 2)
        Me.Top = ((For_Principal.PnlPrincipal.Top) + 395)
    End Sub

    Private Sub BtnIngresos_Click(sender As Object, e As EventArgs) Handles BtnIngresos.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("36")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()
        For_ConsultasDiario.ShowDialog()


    End Sub

    Private Sub BtnMovClientes_Click(sender As Object, e As EventArgs) Handles BtnMovClientes.Click


        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("37") ' Historial de Movimientos

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()
        For_ConsultasMovClientes.ShowDialog()


    End Sub

    Private Sub BtnMovGeneral_Click(sender As Object, e As EventArgs) Handles BtnMovGeneral.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("37") ' Historial de Movimientos

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()
        For_ConsultasMovGeneral.ShowDialog()

    End Sub

    Private Sub BtnLotes_Click(sender As Object, e As EventArgs) Handles BtnLotes.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("35")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()
        For_ConsultasLotes.ShowDialog()

    End Sub

End Class