Public Class For_ComercialSubMenu
    Private Sub For_ComercialSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = (For_Principal.Width / 2) - (Me.Width / 2)
        Me.Top = ((For_Principal.PnlPrincipal.Top) + 390)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub BtnFacturas_Click(sender As Object, e As EventArgs) Handles BtnFacturas.Click

        MinimizarVentanas()

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("44")

        If Perfil = False Then

            Dim Perfil2 As Boolean
            Perfil2 = ConsultaPerfil("45")

            If Perfil2 = False Then

                MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
                If Conn.State = 1 Then Conn.Close()
                Exit Sub
            Else
                'For_TarifasTransporteListado.BtnListarTodo.Visible = True
                For_TarifasTransporteListado.BtnCotizar.Visible = True

            End If
        Else
            ' For_TarifasTransporteListado.BtnListarTodo.Visible = False
            For_TarifasTransporteListado.BtnCotizar.Visible = False

        End If

        Me.Dispose()

        For_TarifasTransporteListado.ShowDialog()

    End Sub
End Class