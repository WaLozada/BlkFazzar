Public Class For_UtilidadesSubMenu
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub BtnEquipos_Click(sender As Object, e As EventArgs) Handles BtnEquipos.Click

        For_EquiposSubMenu.ShowDialog()
        Me.Dispose()

    End Sub

    Private Sub For_UtilidadesSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = (For_Principal.Width / 2) - (Me.Width / 2)
        Me.Top = ((For_Principal.PnlPrincipal.Top) + 390)
    End Sub

    Private Sub BtnHabeas_Click(sender As Object, e As EventArgs) Handles BtnHabeas.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("50")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()

        For_HabeasListar.ShowDialog()

    End Sub
End Class