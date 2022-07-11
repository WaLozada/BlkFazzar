Public Class For_EntradasSubMenu
    Private Sub LblClose_Click(sender As Object, e As EventArgs) Handles LblClose.Click
        Me.Dispose()
    End Sub

    Private Sub BtnIngresoMaterial_Click(sender As Object, e As EventArgs) Handles BtnIngresoMaterial.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("14")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()
        For_IngresoMercancia.ShowDialog()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub For_EntradasSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = (For_Principal.Width / 2) - (Me.Width / 2)
        Me.Top = ((For_Principal.PnlPrincipal.Top) + 400)

    End Sub

    Private Sub BtnOrdenCargue_Click(sender As Object, e As EventArgs) Handles BtnOrdenCargue.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("16")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        MinimizarVentanas()
        For_OrdenesIngreso.ShowDialog()

    End Sub

    Private Sub BtnIngresoGranel_Click(sender As Object, e As EventArgs) Handles BtnIngresoGranel.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("15")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If


    End Sub
End Class