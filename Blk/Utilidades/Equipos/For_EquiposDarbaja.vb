Public Class For_EquiposDarbaja
    Dim Activos As New ActivosTI()
    Private Sub CmbMotivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMotivo.SelectedIndexChanged
        TxtObservacion.Focus()
    End Sub

    Private Sub CmbMotivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbMotivo.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        If LblActivo.Text = "" Then
            MsgBox("Nada para Registrar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        '----------- Ingresar Datos -------------------------------

        Dim IdActivo As String = Trim(LblActivo.Text)
        Dim Motivo As String = Trim(CmbMotivo.Text)
        Dim Observaciones As String = Trim(TxtObservacion.Text)

        Dim Respuesta = Activos.GuardarBaja(IdActivo, Motivo, Observaciones)

        If Respuesta = True Then
            MsgBox("Baja del Activo Registrada Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
        Else
            MsgBox("No fue Posible Registrar la Baja del Activo. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        Me.Dispose()

        '-----------------------------------------------------------

        For_EquiposBajas.Listar()

    End Sub
End Class