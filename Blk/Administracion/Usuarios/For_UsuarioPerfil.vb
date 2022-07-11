Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class For_UsuarioPerfil
    Dim Usuario As New Usuarios()
    Sub Listar()

        '--------------Listar todos los Codigos de perfil ----------------------
        Dim Consulta As SqlDataReader
        Consulta = Usuario.ListarPerfiles()

        If Consulta Is Nothing Then
            MsgBox("No fue posible listar los perfiles!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        For Each perfil In Consulta

            ChklPerfiles.Items.Add(Trim(perfil("IDPERFIL").ToString) & " " & Trim(perfil("PERFIL").ToString))

        Next

        Consulta.Close()

        '--------------- Listar los perfiles del Uusario --------------------------
        Dim Consulta2 As SqlDataReader
        Consulta2 = Usuario.ListarPerfiles(LblUsuario.Tag)

        For Each perfil2 In Consulta2


            Dim CodPerfil = Trim(perfil2("PERFIL").ToString)

            For i = 0 To ChklPerfiles.Items.Count - 1

                If Mid$(ChklPerfiles.Items(i), 1, 2) = CodPerfil Then
                    ChklPerfiles.SetItemCheckState(i, CheckState.Checked)
                    Exit For
                End If


            Next i


        Next
        Consulta2.Close()

    End Sub

    Private Sub For_UsuarioPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------
        Listar()


    End Sub

    Private Sub For_UsuarioPerfil_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub BtnGuardarPerfil_Click(sender As Object, e As EventArgs) Handles BtnGuardarPerfil.Click

        Dim Permisos As New List(Of String)
        Dim Perfil As String

        For i = 0 To ChklPerfiles.Items.Count - 1
            Perfil = Format(i + 1, "00")

            If Mid$(ChklPerfiles.Items(i), 1, 2) = Perfil Then

                If ChklPerfiles.GetItemChecked(i) = True Then
                    Permisos.Add(1) 'Activo
                Else
                    Permisos.Add(0) 'Inactivo
                End If

            End If
        Next

        Dim Rta = Usuario.Establecerperfiles(LblUsuario.Tag, Permisos)

        If Rta = True Then
            MsgBox("Perfil Actualizado Correctamente!", vbInformation, Gl_NomCompañia)
            Me.Dispose()
        Else
            MsgBox("Inconvenientes en la Actualización" + Chr(13) + Chr(13) + "Consulte con el Administrador", MsgBoxStyle.Exclamation, Gl_NomCompañia)
        End If

    End Sub
End Class