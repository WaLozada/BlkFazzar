Public Class For_HabeasRespuesta
    Dim Habeasdata As New Cls_Habeasdata

    Private Sub For_HabeasRespuesta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DTFechaRta.Text = Date.Now

    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click

        If DTFechaRta.Value > Date.Now Then
            MsgBox("La Fecha de respuesta es mayor al dia de hoy!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        If TxtRespuesta.Text = "" Then
            MsgBox("Redacte la respuesta entregada al titular de la información con el mayor detalle posible!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Dim Fecha_Respuesta = Format(DTFechaRta.Value, "yyyy-MM-dd")

        Habeasdata.Idcaso = LblIdcaso.Text
        Habeasdata.Fecha_Respuesta = Fecha_Respuesta
        Habeasdata.Respuesta = Trim(TxtRespuesta.Text)
        Habeasdata.Responsable = UsuarioApp.Documento

        Dim Respuesta As String
        Respuesta = Habeasdata.GuardarRespuesta()

        If Respuesta = True Then
            MsgBox("La respuesta fue registrada correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)

            Me.Dispose()
        Else
            MsgBox("Ocurrio un error en el proceso de registro, Por favor consulte con el administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If


    End Sub
End Class