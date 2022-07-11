Public Class For_DespachosSubMenu
    Private Sub LblClose_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub BtnSalidaMaterial_Click(sender As Object, e As EventArgs) Handles BtnSalidaMaterial.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("17")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()
        For_DespachoMercancia.ShowDialog()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub For_DespachosSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = (For_Principal.Width / 2) - (Me.Width / 2)
        Me.Top = ((For_Principal.PnlPrincipal.Top) + 395)
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("18")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()
        For_RemisionDespachos.ShowDialog()

    End Sub
End Class