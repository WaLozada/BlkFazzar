Public Class For_AcercadeBlk
    Private Sub For_AcercadeBlk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        PnlPrincipal.Top = (Height) / 2 - (PnlPrincipal.Height / 2)
        PnlPrincipal.Left = (Width / 2) - (PnlPrincipal.Width / 2)
        LblVersion.Text = Version()

    End Sub

    Private Sub ImgSalir_Click(sender As Object, e As EventArgs) Handles ImgSalir.Click
        Me.Dispose()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.LinkLabel1.LinkVisited = True

        ' Navigate to a URL.
        System.Diagnostics.Process.Start("https://www.bulkmatic.com.co")
    End Sub
    Private Sub LblAutor_DoubleClick(sender As Object, e As EventArgs) Handles LblAutor.DoubleClick
        for_Backdoor.showdialog()
    End Sub
End Class