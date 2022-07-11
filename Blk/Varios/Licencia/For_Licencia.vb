Public Class For_Licencia
    Private Sub PicSalir_Click(sender As Object, e As EventArgs) Handles PicSalir.Click
        End
    End Sub

    Private Sub BtnPegar_Click(sender As Object, e As EventArgs) Handles BtnPegar.Click

        Dim Campos As String()
        Dim KeyLu As String

        KeyLu = Trim(Clipboard.GetText)

        Campos = Split(KeyLu, "-")
        TxtClave1.Text = Campos(0)
        TxtClave2.Text = Campos(1)
        TxtClave3.Text = Campos(2)
        TxtClave4.Text = Campos(3)

    End Sub

    Private Sub LblID_Click(sender As Object, e As EventArgs) Handles LblID.Click

        On Error Resume Next

        Clipboard.Clear()
        Clipboard.SetText(Trim(LblID.Text))
        MsgBox("Licencia Copiada!", MsgBoxStyle.Information, Gl_NomCompañia)


    End Sub

    Private Sub BtnValidar_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click

        Try

            Dim RTA As Boolean

            RTA = Compare(LblID.Text)

            If RTA = True Then
                'Call CreaVarEntorno() ' Creo la Variable de Entorno
                Call CreaLLave()
                MsgBox("Licencia Activada!", MsgBoxStyle.Information, Gl_NomCompañia)

                Me.Dispose()
            Else
                MsgBox("Licencia No Valida!", MsgBoxStyle.Critical, Gl_NomCompañia)
                End
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class