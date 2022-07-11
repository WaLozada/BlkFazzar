Imports System.ComponentModel


Public Class For_MenuPrincipal
    Sub MostrarIp()
        'Dim ip As System.Net.IPHostEntry
        'ip = System.Net.Dns.GetHostEntry(My.Computer.Name)
        'LblIP.Text = ip.AddressList(0).ToString
    End Sub
    Private Sub PicSalir_Click(sender As Object, e As EventArgs) Handles PicSalir.Click
        End
    End Sub
    Private Sub For_MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblUsuario.Text = UsuarioApp.Nombre + " " + UsuarioApp.Papellido + " " + UsuarioApp.Sapellido
        LblArea.Text = UsuarioApp.Area
        LblUbicacion.Text = "ADMINISTRADOR"

        Dim FH As Date = FechaHoraServer()

        LblFecha.Text = FH.ToString("dddd") + " " + FH.Day.ToString + " de " + FH.ToString("MMMM") + " de " + FH.Year.ToString

        MostrarIp()

        CargueTablasParametricas()


    End Sub
    Private Sub ImgAdminArriba_MouseDown(sender As Object, e As MouseEventArgs) Handles ImgAdminArriba.MouseDown
        Me.ImgAdminAbajo.Visible = True
        Me.ImgAdminArriba.Visible = False
    End Sub
    Private Sub ImgAdminArriba_MouseUp(sender As Object, e As MouseEventArgs) Handles ImgAdminArriba.MouseUp
        Me.ImgAdminAbajo.Visible = False
        Me.ImgAdminArriba.Visible = True
        For_AdminSubmenu.ShowDialog()
    End Sub
    Private Sub ImgEntradasArriba_MouseDown(sender As Object, e As MouseEventArgs) Handles ImgEntradasArriba.MouseDown
        Me.ImgEntradasAbajo.Visible = True
        Me.ImgEntradasArriba.Visible = False
    End Sub
    Private Sub ImgEntradasArriba_MouseUp(sender As Object, e As MouseEventArgs) Handles ImgEntradasArriba.MouseUp
        Me.ImgEntradasArriba.Visible = True
        Me.ImgEntradasAbajo.Visible = False
        For_EntradasSubMenu.ShowDialog()

    End Sub
    Private Sub ImgDespachosArriba_MouseDown(sender As Object, e As MouseEventArgs) Handles ImgDespachosArriba.MouseDown
        Me.ImgDespachosAbajo.Visible = True
        Me.ImgDespachosArriba.Visible = False
    End Sub
    Private Sub ImgDespachosArriba_MouseUp(sender As Object, e As MouseEventArgs) Handles ImgDespachosArriba.MouseUp
        Me.ImgDespachosArriba.Visible = True
        Me.ImgDespachosAbajo.Visible = False
        For_DespachosSubMenu.ShowDialog()
    End Sub
    Private Sub ImgConsultasArriba_MouseDown(sender As Object, e As MouseEventArgs) Handles ImgConsultasArriba.MouseDown
        Me.ImgConsultasAbajo.Visible = True
        Me.ImgConsultasArriba.Visible = False
    End Sub
    Private Sub ImgConsultasArriba_MouseUp(sender As Object, e As MouseEventArgs) Handles ImgConsultasArriba.MouseUp
        Me.ImgConsultasAbajo.Visible = False
        Me.ImgConsultasArriba.Visible = True
    End Sub
    Private Sub ImgUtilidadesArriba_MouseDown(sender As Object, e As MouseEventArgs) Handles ImgUtilidadesArriba.MouseDown
        Me.ImgUtilidadesAbajo.Visible = True
        Me.ImgUtilidadesArriba.Visible = False
    End Sub
    Private Sub ImgUtilidadesArriba_MouseUp(sender As Object, e As MouseEventArgs) Handles ImgUtilidadesArriba.MouseUp
        Me.ImgUtilidadesAbajo.Visible = False
        Me.ImgUtilidadesArriba.Visible = True
    End Sub
    Private Sub ImgInventarioArriba_MouseDown(sender As Object, e As MouseEventArgs) Handles ImgInventarioArriba.MouseDown
        Me.ImgInventarioAbajo.Visible = True
        Me.ImgInventarioArriba.Visible = False
    End Sub
    Private Sub ImgInventarioArriba_MouseUp(sender As Object, e As MouseEventArgs) Handles ImgInventarioArriba.MouseUp
        Me.ImgInventarioAbajo.Visible = False
        Me.ImgInventarioArriba.Visible = True
        For_InvSubMenu.ShowDialog()
    End Sub
    Private Sub For_MenuPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

End Class
