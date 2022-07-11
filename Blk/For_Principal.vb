Imports System.ComponentModel

Public Class For_Principal

    Private Sub For_Principal_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged

        PnlPrincipal.Top = (Height) / 2 - (PnlPrincipal.Height / 2)
        PnlPrincipal.Left = (Width / 2) - (PnlPrincipal.Width / 2)

    End Sub
    Private Sub For_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Ubicacion As New Ubicaciones()
        Dim Area As New Areas()

        'PnlPrincipal.Top = (Height - 120) / 2 - (PnlPrincipal.Height / 2)
        PnlPrincipal.Top = (Height) / 2 - (PnlPrincipal.Height / 2)
        PnlPrincipal.Left = (Width / 2) - (PnlPrincipal.Width / 2)

        Dim FH As Date = FechaHoraServer()

        LblFecha.Text = FH.ToString("dddd") + " " + FH.Day.ToString + " de " + FH.ToString("MMMM") + " de " + FH.Year.ToString

        'LblFecha.Text = "Miercoles 1 de Julio de 2020"

        CargueTablasParametricas()

        LblUsuario.Text = UsuarioApp.Nombre + " " + UsuarioApp.Papellido + " " + UsuarioApp.Sapellido
        LblArea.Text = Area.CualArea(Trim(UsuarioApp.Area))
        LblUbicacion.Text = Ubicacion.CualUbicacion(Trim(UsuarioApp.Ubicacion))
        LblVersion.Text = Version()

    End Sub

    Private Sub For_Principal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnIngresos.Click
        For_EntradasSubMenu.ShowDialog()
    End Sub

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        For_AdminSubmenu.ShowDialog()
    End Sub

    Private Sub BtnTransporte_Click(sender As Object, e As EventArgs) Handles BtnTransporte.Click

        'MsgBox("Acceso Denegado!", vbCritical, Gl_NomCompañia)
        For_Transportesubmenu.ShowDialog()
    End Sub

    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click
        For_InvSubMenu.ShowDialog()
    End Sub

    Private Sub BtnConsultas_Click(sender As Object, e As EventArgs) Handles BtnConsultas.Click
        For_ConsultasSubMenu.ShowDialog()
    End Sub

    Private Sub BtnContable_Click(sender As Object, e As EventArgs) Handles BtnContable.Click
        For_ContableSubMenu.ShowDialog()
    End Sub

    Private Sub PicAcercade_Click(sender As Object, e As EventArgs) Handles PicAcercade.Click
        For_AcercadeBlk.ShowDialog()
    End Sub

    Private Sub BtnUtilidades_Click(sender As Object, e As EventArgs) Handles BtnUtilidades.Click
        For_UtilidadesSubMenu.ShowDialog()
    End Sub

    Private Sub BtnOperaciones_Click(sender As Object, e As EventArgs) Handles BtnOperaciones.Click

        For_OperacionesSubMenu.showdialog()

    End Sub

    Private Sub BtnComercial_Click(sender As Object, e As EventArgs) Handles BtnComercial.Click

        for_ComercialSubMenu.ShowDialog()

    End Sub

    Private Sub BtnMacroOrden_Click(sender As Object, e As EventArgs) Handles BtnMacroOrden.Click

        'MsgBox("Acceso No Autorizado", MsgBoxStyle.Critical, Gl_NomCompañia)
        'Exit Sub

        For_OrdenesServicio.ShowDialog()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click



        For_ITRSubMenu.ShowDialog()

    End Sub

    Private Sub BtnTerminales_Click(sender As Object, e As EventArgs) Handles BtnTerminales.Click

        For_TerminalesSubmenu.ShowDialog()

    End Sub
End Class