Public Class For_ContableSubMenu
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub For_ContableSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = (For_Principal.Width / 2) - (Me.Width / 2)
        Me.Top = ((For_Principal.PnlPrincipal.Top) + 400)
    End Sub

    Private Sub BtnFacturas_Click(sender As Object, e As EventArgs) Handles BtnFacturas.Click


        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("31")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()
        For_FacturasListar.ShowDialog()

    End Sub

    Private Sub BtnAprobar_Click(sender As Object, e As EventArgs) Handles BtnAprobar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("34")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()
        For_FacturaAprobar.ShowDialog()


    End Sub
End Class