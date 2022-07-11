Public Class For_InvSubMenu
    Private Sub LblClose_Click(sender As Object, e As EventArgs) Handles LblClose.Click
        Me.Dispose()
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click


        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("19")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        For_ProductosListado.ShowDialog()
    End Sub

    Private Sub BtnBodegas_Click(sender As Object, e As EventArgs) Handles BtnBodegas.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("23")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        For_BodegasListado.ShowDialog()
    End Sub

    Private Sub BtnDepositos_Click(sender As Object, e As EventArgs) Handles BtnDepositos.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("27")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Me.Dispose()
        For_DepositosListar.ShowDialog()
    End Sub

    Private Sub For_InvSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = (For_Principal.Width / 2) - (Me.Width / 2)
        Me.Top = ((For_Principal.PnlPrincipal.Top) + 400)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub
End Class