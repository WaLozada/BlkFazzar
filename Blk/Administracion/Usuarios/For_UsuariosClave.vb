Imports System.Data.SqlClient

Public Class For_UsuariosClave
    Dim NewClave, OldClave As String
    Dim User As New Usuarios()
    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)
        If Trim(TxtAnterior.Text) = "" Then
            ListaErrores.Add("- Digite la Clave Anterior!")
        End If


        If Trim(TxtNueva.Text) = "" Then
            ListaErrores.Add("- Digite la Nueva Clave!")
        End If

        If Trim(TxtConfirmacion.Text) = "" Then
            ListaErrores.Add("- Digite la Confirmación de la clave!")
        End If

        If Trim(TxtNueva.Text) <> Trim(TxtConfirmacion.Text) Then
            ListaErrores.Add("- La Nueva clave y la confirmación no Coinciden!")
        End If

        If Trim(TxtAnterior.Text) = Trim(TxtNueva.Text) Then
            ListaErrores.Add("- La clave no ha variado entre la anterior y la Nueva.")
        End If

        If Len(Trim(TxtNueva.Text)) < 5 Or Len(Trim(TxtNueva.Text)) > 10 Then
            ListaErrores.Add("- Longitud de la Clave NO valida.")
        End If

        OldClave = Trim(SeguridadBlk.EncryptStr(Trim(TxtAnterior.Text), GL_ClaveEncrip))

        If Gl_Key <> OldClave Then
            ListaErrores.Add("- La Clave anterior no es valida!")
        End If

        Return ListaErrores

    End Function

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click

        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        NewClave = Trim(SeguridadBlk.EncryptStr(Trim(TxtNueva.Text), GL_ClaveEncrip))

        Dim TempParidad As String

        TempParidad = SeguridadBlk.SHA1(UsuarioApp.Nombre & "@" & UsuarioApp.Documento & "@" & UsuarioApp.Papellido & "@" & NewClave)

        Try

            Dim Rta = User.CambioClave(NewClave, TempParidad)

            If Rta = True Then
                MsgBox("Clave Cambiada con exito!", MsgBoxStyle.Information, Gl_NomCompañia)
                Gl_ClaveOK = 1
            Else
                MsgBox("No fue posible el cambio de clave, Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
                Gl_ClaveOK = 0
            End If


            If Conn.State = 1 Then Conn.Close()

        Catch ex As Exception

        End Try


        Me.Dispose()

    End Sub
    Private Sub TxtAnterior_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAnterior.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtNueva.Focus()
        End If
    End Sub
    Private Sub TxtNueva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNueva.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtConfirmacion.Focus()
        End If
    End Sub

    Private Sub TxtConfirmacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtConfirmacion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnCrear.Focus()
        End If
    End Sub
End Class