Public Class For_Backdoor
    Private Sub TxtAcceso1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAcceso1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtAcceso2.Focus()
        End If
    End Sub

    Private Sub TxtAcceso2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAcceso2.KeyPress
        If Asc(e.KeyChar) = 13 Then

            Dim Autorizado As String = "pzD5atyifJKLFVHZANtqY2DAzG0=" 'blk.dll
            Dim strEncryptedText As String = SeguridadBlk.SHA1(TxtAcceso1.Text)

            If (Autorizado = strEncryptedText) And (TxtAcceso2.Text = Format(Year(Now), "0000") & Format(Month(Now), "00")) Then
                Me.Dispose()
                For_BackView.ShowDialog()

            Else
                End
            End If

        End If
    End Sub

End Class