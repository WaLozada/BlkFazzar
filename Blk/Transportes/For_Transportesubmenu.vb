Public Class For_Transportesubmenu
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub For_Transportesubmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = (For_Principal.Width / 2) - (Me.Width / 2)
        Me.Top = ((For_Principal.PnlPrincipal.Top) + 395)
    End Sub

    Private Sub BtnBitacora_Click(sender As Object, e As EventArgs) Handles BtnBitacora.Click


        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("51")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()
        For_BitacoraTransporte.ShowDialog()



    End Sub
End Class