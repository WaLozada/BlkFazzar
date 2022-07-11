Public Class For_TarifasMotivo
    Dim Comercial As New ClsComercial()
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click


        If Trim(TxtMotivo.Text) = "" Then
            MsgBox("Indique el motivo por el cual requiere actualización.", MsgBoxStyle.Information, Gl_NomCompañia)
            Exit Sub
        End If

        Comercial.Observacion = Trim(TxtMotivo.Text)
        Comercial.Id = LblID.Text


        Dim Respuesta = Comercial.GuardarTarifa(4)


        If Respuesta = True Then
            MsgBox("La solicitud de actualización de tarifa se realizo correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        End If

    End Sub
End Class