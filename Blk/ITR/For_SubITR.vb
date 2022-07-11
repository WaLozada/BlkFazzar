Public Class For_ITRSubMenu
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles BtnRegistro.Click

        For_RegistroITR.ShowDialog()

    End Sub

    Private Sub For_ITRSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = (For_Principal.Width / 2) - (Me.Width / 2)
        Me.Top = ((For_Principal.PnlPrincipal.Top) + 400)

    End Sub
End Class