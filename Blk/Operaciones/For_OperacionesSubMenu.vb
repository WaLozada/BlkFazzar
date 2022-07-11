Public Class For_OperacionesSubMenu
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub BtnFacturas_Click(sender As Object, e As EventArgs) Handles BtnFacturas.Click

        For_ProyectosListado.ShowDialog()

    End Sub

    Private Sub For_OperacionesSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = (For_Principal.Width / 2) - (Me.Width / 2)
        Me.Top = ((For_Principal.PnlPrincipal.Top) + 390)
    End Sub
End Class