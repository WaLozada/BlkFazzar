Public Class For_TerminalesSubmenu
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

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub For_TerminalesSubmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = (For_Principal.Width / 2) - (Me.Width / 2)
        Me.Top = ((For_Principal.PnlPrincipal.Top) + 400)

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

    Private Sub BtnRemisiones_Click(sender As Object, e As EventArgs) Handles BtnRemisiones.Click

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For_DesbloqueoMaterial.ShowDialog()

    End Sub
End Class