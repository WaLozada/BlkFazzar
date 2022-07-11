Public Class For_FacturaContabilizar
    Dim FContable As New Contable()
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If Trim(TxtWO.Text) = "" Then
            MsgBox("Ingrese el Valor de ContabilizaciÓn del WO", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtWO.Focus()
            Exit Sub
        End If

        '************************** Insertar Información a la Base de Datos ************************

        FContable.Codigo = Trim(LblCodigo.Text)
        FContable.NumFac = Trim(LblFactura.Text)
        FContable.Contabilizacion = Trim(TxtWO.Text)
        FContable.Comentario = Trim(TxtComentario.Text)
        FContable.UsuarioContable = Trim(UsuarioApp.Documento)
        FContable.PcContable = Trim(Environment.MachineName)

        Dim Respuesta = FContable.GuardarContabilizacion()

        If Respuesta = "OK" Then
            MsgBox("La Factura Fue Contabilizada Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        Else
            MsgBox("No fue posible Contabilizar la Factura. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        '**********************************************************************************************


    End Sub

    Private Sub BtnVisor_Click(sender As Object, e As EventArgs) Handles BtnVisor.Click

        Try
            Dim url As String = BtnVisor.Tag
            Process.Start("Chrome", url)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


        'For_WebVisor.WebBrowser1.Navigate(BtnVisor.Tag)
        'For_WebVisor.ShowDialog()

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If Trim(TxtWO.Text) = "" Then
            MsgBox("Ingrese el Valor de ContabilizaciÓn del WO", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtWO.Focus()
            Exit Sub
        End If

        Dim OldContabilizacion As String = FContable.Contabilizacion
        Dim OldComentario As String = FContable.Comentario

        If OldContabilizacion = Trim(TxtWO.Text) And OldComentario = Trim(TxtComentario.Text) Then
            MsgBox("Nada para Actualizar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            Exit Sub
        End If

        '************************** Insertar Información a la Base de Datos ************************

        FContable.Contabilizacion = Trim(TxtWO.Text)
        FContable.Comentario = Trim(TxtComentario.Text)
        FContable.Codigo = Trim(LblCodigo.Text)
        FContable.NumFac = Trim(LblFactura.Text)
        FContable.UsuarioContable = Trim(UsuarioApp.Documento)
        FContable.PcContable = Trim(Environment.MachineName)

        Dim Respuesta = FContable.ActualizarContabilizacion(OldContabilizacion, OldComentario)

        If Respuesta = "OK" Then
            MsgBox("La Contabilización fue Editada Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        Else
            MsgBox("No fue posible Contabilizar la Factura. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        '**********************************************************************************************

    End Sub

    Private Sub For_FacturaContabilizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FContable.Contabilizacion = TxtWO.Text
        FContable.Comentario = TxtComentario.Text
        FContable.FechaContable = LblFechaContable.Text

    End Sub
End Class