Imports System.Security.Cryptography
Imports System.Text

Module SeguridadBlk

    Public Function UnEncryptStr(ByVal S As String, ByVal P As String) As String ' S = Cadena a desencriptar  P = Password
        Dim i As Integer, R As String
        Dim C1 As Integer, C2 As Integer
        R = ""
        If Len(P) > 0 Then
            For i = 1 To Len(S)
                C1 = Asc(Mid(S, i, 1))
                If i > Len(P) Then
                    C2 = Asc(Mid(P, i Mod Len(P) + 1, 1))
                Else
                    C2 = Asc(Mid(P, i, 1))
                End If
                C1 = C1 - C2 - 64
                If Math.Sign(C1) = -1 Then C1 = 256 + C1
                R = R + Chr(C1)
            Next i
        Else
            R = S
        End If
        UnEncryptStr = R
    End Function
    Public Function EncryptStr(ByVal S As String, ByVal P As String) As String 'S = Cadena a encriptar  P = Password
        Dim i As Integer, R As String
        Dim C1 As Integer, C2 As Integer
        R = ""
        If Len(P) > 0 Then
            For i = 1 To Len(S)
                C1 = Asc(Mid(S, i, 1))
                If i > Len(P) Then
                    C2 = Asc(Mid(P, i Mod Len(P) + 1, 1))
                Else
                    C2 = Asc(Mid(P, i, 1))
                End If
                C1 = C1 + C2 + 64
                If C1 > 255 Then C1 = C1 - 256
                R = R + Chr(C1)
            Next i
        Else
            R = S
        End If

        EncryptStr = R

    End Function
    Public Function InyeccionSQL(ByVal Usuario) As String

        Dim N_Usuario As String

        N_Usuario = Replace(Usuario, "=", "")
        N_Usuario = Replace(N_Usuario, "(", "")
        N_Usuario = Replace(N_Usuario, ")", "")
        N_Usuario = Replace(N_Usuario, "[", "")
        N_Usuario = Replace(N_Usuario, "]", "")
        N_Usuario = Replace(N_Usuario, "*", "")
        N_Usuario = Replace(N_Usuario, "#", "")
        N_Usuario = Replace(N_Usuario, "-", "")
        N_Usuario = Replace(N_Usuario, ",", "")
        N_Usuario = Replace(N_Usuario, ".", "")
        N_Usuario = Replace(N_Usuario, "INSERT", "")
        N_Usuario = Replace(N_Usuario, "DELETE", "")
        N_Usuario = Replace(N_Usuario, "'", "")
        N_Usuario = Replace(N_Usuario, "INTO", "")
        N_Usuario = Replace(N_Usuario, "/*", "")

        Return N_Usuario

    End Function
    Public Function SHA1(ByVal text As String) As String
        Dim myString As String = text
        Dim Data As Byte()

        Data = Encoding.ASCII.GetBytes(myString)

        Dim shaM As New SHA1Managed()
        Dim resultHash As Byte() = shaM.ComputeHash(Data)

        Dim resultHexString = text
        Dim b As Byte

        For Each b In resultHash
            resultHexString += Hex(b)
        Next
        Dim b64 As String = Convert.ToBase64String(resultHash)
        Return b64

    End Function
    Public Function Logueo(Usuario, clave) As Boolean

        Try

            Dim comando As New SqlClient.SqlCommand("sp_Logueo", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@Accion", SqlDbType.NChar).Value = 0 ' Traer Clave
            comando.Parameters.Add("@Usuario", SqlDbType.NChar).Value = Trim(Usuario)

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            Conn.Open()

            comando.ExecuteScalar()

            If Trim(comando.Parameters("@Resultado").Value) = Trim(Gl_Key) Then

                'Dim usx = SeguridadBlk.UnEncryptStr("Ä!Ö£ßßØ", GL_ClaveEncrip)

                Logueo = True
                Conn.Close()
                Exit Function
            Else
                Logueo = False
            End If

        Catch ex As Exception
            Conn.Close()
            Logueo = False
        End Try


    End Function



End Module
