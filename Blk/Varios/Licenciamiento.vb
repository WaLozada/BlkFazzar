Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Management
Module Licenciamiento

    Sub LicenciaUso()

        Try
            'Conn.Open()

            'If Conn.State = ConnectionState.Open Then MsgBox("Conectado!")

            Dim Nserie As String
            Nserie = HDSerial()

            If Nserie = "0" Then
                MsgBox("Validación del Sistema NO completada. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
                If Conn.State = 1 Then Conn.Close()
                End
            End If

            'Dim Licencia As String() = GetVariableEntorno("BLK")

            SYS_GetPath = System.Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%\BLK")

            Dim Existe As Boolean
            Existe = My.Computer.FileSystem.FileExists(SYS_GetPath & "\syswallu.dll")

            If Existe = False Then

                For_Licencia.LblID.Text = IDSOFT()
                For_Licencia.ShowDialog()

            End If

            FileOpen(10, SYS_GetPath & "\syswallu.dll", OpenMode.Input) 'Abre el archivo 

            Dim LineadeTexto, Cadena As String
            Dim disco As Integer
            Dim Datos As String()
            Dim FechaLic As Date


            Do Until EOF(10) 'lee las líneas contenidas en el archivo 
                LineadeTexto = LineInput(10) 'Lee la línea entera 

                Cadena = SeguridadBlk.UnEncryptStr(LineadeTexto, GL_ClaveEncrip)
                Datos = Split(Cadena, "@") ' Separo los datos 

                disco = Math.Abs(Val(Datos(7)))
                FechaLic = Mid$(Datos(8), 1, 2) & "/" & Datos(3) & "/" & Mid$(Datos(9), 1, 4)
                GL_HDS = Datos(7)
                Exit Do
            Loop

            FileClose(10)

            If Val(Nserie.ToString) <> Val(disco.ToString) Then
                MsgBox("Estación No Licenciada. Consulte con el Administrador!*1", MsgBoxStyle.Critical, "Bulkmatic de Colombia S.A.S")
                FileClose(10)
                Kill(SYS_GetPath & "\syswallu.dll")
                If Conn.State = 1 Then Conn.Close()
                End
            End If


            '------- Controlo las licencias adquiridas ------------

            Dim Licencias As Boolean

            Licencias = Licenciamiento.ValidarLicencias(GL_HDS)

            If Licencias = False Then
                If Conn.State = 1 Then Conn.Close()
                End
            End If
            '----------------------------------------------------------

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            End
        End Try

    End Sub
    Sub CreaVarEntorno()

        Dim NitCte = InputBox("Indique los 10 díigitos del Nit del Cliente sin puntos, comas o guiones!", Gl_NomCompañia, "")
        Dim NSerie As String
        NSerie = HDSerial()

        Dim Dato As String = NitCte & "@" & NSerie

        Dim Resultado As Boolean = SetVariableEntorno("BLK", Dato)

        If Resultado = True Then
            MsgBox("Se requiere iniciar de nuevo la aplicacion!", vbInformation, Gl_NomCompañia)
            'End
        Else
            MsgBox("No fue posible registrar la Licencia!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

    End Sub
    Sub CreaLLave()

        Dim wal As String = ""

        Try


            Dim Dias As Double
            Dim AL As Long
            Dim Datos As String()
            Dim FinLic As Date
            Dim A0, A1, A2, A3, A4, A5, A6, A7, A8, A9 As String
            Dim M, d, A As Integer


            Datos = Split(For_Licencia.LblID.Text, "-")

            AL = Trim(Datos(3)) / 2
            Dias = Val(For_Licencia.TxtClave4.Text) - Val(AL)
            FinLic = DateAdd(DateInterval.Day, Dias, Date.Now)
            M = Val(FinLic.Month)
            d = Val(FinLic.Day)
            A = Val(FinLic.Year)

            Dim Cadena As String

            Cadena = "1234567987654321234564890/"

            A0 = Mid$(Cadena, 3, 3) & Mid$(Cadena, 7, 3) & Mid$(Cadena, 5, 3) & Mid$(Cadena, 7, 3) & Mid$(Cadena, 3, 3)
            A1 = Mid$(Cadena, 5, 3) & Mid$(Cadena, 8, 3) & Mid$(Cadena, 1, 3) & Mid$(Cadena, 4, 3) & Mid$(Cadena, 5, 3)
            A2 = Mid$(Cadena, 4, 3) & Mid$(Cadena, 1, 3) & Mid$(Cadena, 11, 3) & Mid$(Cadena, 9, 3) & Mid$(Cadena, 2, 3)
            A3 = Format(M, "00")
            A4 = Mid$(Cadena, 9, 3) & Mid$(Cadena, 1, 3) & Mid$(Cadena, 6, 3) & Mid$(Cadena, 2, 3) & Mid$(Cadena, 1, 3)
            A5 = Mid$(Cadena, 9, 3) & Mid$(Cadena, 1, 3) & Mid$(Cadena, 6, 3) & Mid$(Cadena, 2, 3) & Mid$(Cadena, 1, 3)
            A6 = Mid$(Cadena, 12, 3) & Mid$(Cadena, 1, 3) & Mid$(Cadena, 1, 3) & Mid$(Cadena, 1, 3) & Mid$(Cadena, 1, 3)
            A7 = HDSerial()
            A8 = Format(d, "00") & Mid$(Cadena, 5, 2) & Mid$(Cadena, 3, 1) & Mid$(Cadena, 4, 1)
            A9 = Format(A, "0000") & Mid$(Cadena, 9, 1) & Mid$(Cadena, 7, 1)

            wal = SeguridadBlk.EncryptStr(A0 & "@" & A1 & "@" & A2 & "@" & A3 & "@" & A4 & "@" & A5 & "@" & A6 & "@" & A7 & "@" & A8 & "@" & A9, GL_ClaveEncrip)

            FileClose()

            Dim Archivo As String = SYS_GetPath & "\syswallu.dll"

            Dim Existe As Boolean
            Existe = My.Computer.FileSystem.FileExists(Archivo)

            If Existe = True Then
                Kill(Archivo)
            End If

            FileOpen(2, SYS_GetPath & "\syswallu.dll", OpenMode.Output) 'guarda en el archivo  
            Print(2, wal)
            FileClose(2)

        Catch ex As Exception

            'Try


            '    Dim Existe As Boolean
            '    Existe = My.Computer.FileSystem.FileExists("C:\Program Files (x86)\BLK\SW8.EXE")

            '    If Existe = False Then
            '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Bulkmatic de Colombia")
            '        End
            '    Else
            '        Dim Comando As String
            '        Dim Valor As String

            '        Valor = wal

            '        Comando = "cmd /K CD C:\Program Files (x86)\BLK\ &SW8.EXE " & Valor
            '        Shell(Comando, AppWinStyle.Hide, True)

            '        Exit Sub
            '    End If

            'Catch ex2 As Exception
            '    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Bulkmatic de Colombia S.A.S")
            '    End
            'End Try

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Bulkmatic de Colombia S.A.S")
        End Try

    End Sub
    Function HDSerial() As String

        Dim Drive As String = Mid$(My.Application.Info.DirectoryPath, 1, 1)

        Dim disco As New System.Management.ManagementObject("win32_logicaldisk.deviceid=""" + Drive + ":""")
        disco.Get()

        Dim SRL As String = disco("VolumeSerialNumber").ToString()

        Try
            Dim TempSerial As String = ""

            For I = 1 To Len(SRL)

                TempSerial = TempSerial & Asc(Mid$(SRL, I, 1))

            Next

            HDSerial = Mid$(TempSerial, Len(TempSerial) - 4, 5)

        Catch ex As Exception

            'MsgBox(ex.Message)
            'HDSerial = "0"

            Try
                Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_DiskDrive")

                For Each queryObj As ManagementObject In searcher.Get()  ' tomo el primero
                    Dim Sn As String = queryObj("SerialNumber").ToString

                    HDSerial = Mid$(Sn, Len(Sn) - 4, 5)
                    Exit Function
                Next
                HDSerial = 0
            Catch ex1 As ManagementException
                MsgBox(ex1.Message)
                HDSerial = "0"
            End Try



        End Try

        'Get serial number of RAM chips.     -->   wmic memorychip get serialnumber
        'This command lists serial number for each RAM module installed on the computer. 
        'Get serial number for hard disks    --> wmic diskdrive get serialnumber
        'Get serial number for mother boards --> wmic baseboard get serialnumber
        'Get Serial number for cdrom drive   --> wmic cdrom where drive='d:' get SerialNumber      "Replace'd:’ with the drive letter for the cdrom on your computer."


    End Function
    Public Function IDSOFT()


        Dim FH As DateTime

        FH = FechaHoraServer()

        Dim ALEATORIO_ID As Long
        Dim HR, FC As Long
        Dim AL1, DS1, HR1, FC1 As String
        Dim DS As String

        Randomize() ' inicializar la semilla
        ALEATORIO_ID = CLng((12345 - 99999) * Rnd() + 99999)

        DS = HDSerial()
        HR = Long.Parse(FH.Minute).ToString("00") & Long.Parse(FH.Second).ToString("00")
        FC = Long.Parse(FH.Date.Month).ToString("00") & Long.Parse(FH.Date.Day).ToString("00")


        DS1 = Hex(DS + ALEATORIO_ID)
        HR1 = Hex(HR + ALEATORIO_ID)
        FC1 = Hex(FC + ALEATORIO_ID)
        AL1 = ALEATORIO_ID * 2

        IDSOFT = DS1 & " - " & HR1 & " - " & FC1 & " - " & AL1

    End Function
    Public Function ValidarLicencias(SerialHD) As Boolean

        ''----------------- VERIFICAR SERIALES --------------------
        Dim FH As DateTime

        FH = FechaHoraServer()

        Try

            Dim comando As New SqlClient.SqlCommand("sp_InsertaSerialesHD", ConnP)
            comando.CommandType = CommandType.StoredProcedure


            comando.Parameters.Add("@NIT", SqlDbType.NChar).Value = Trim(GL_NITPUB)
            comando.Parameters.Add("@SERIALHD", SqlDbType.NChar).Value = Trim(SerialHD)
            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Trim(GL_CODPUB)
            comando.Parameters.Add("@FECHA", SqlDbType.NChar).Value = FH.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)
            comando.Parameters.Add("@HORA", SqlDbType.NChar).Value = FH.ToString("hh:mm tt", CultureInfo.InvariantCulture)
            comando.Parameters.Add("@LICENCIAS", SqlDbType.NChar).Value = Trim(GL_Licencias)
            comando.Parameters.Add("@MAQUINA", SqlDbType.NChar).Value = Environment.MachineName
            comando.Parameters.Add("@VERSION", SqlDbType.NChar).Value = Funciones.Version

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 250)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output

            '-------------------------------------------------

            If ConnP.State = ConnectionState.Open Then ConnP.Close()
            ConnP.Open()
            comando.ExecuteScalar()

            If comando.Parameters("@Resultado").Value = "OK" Then
                'MsgBox("Cliente Actualizado Correctamente!", MsgBoxStyle.Information, "BLK")
                ValidarLicencias = True
            ElseIf comando.Parameters("@Resultado").Value = "NO" Then
                MsgBox("Ya llego al Limite de licencias contratadas." + Chr(13) + Chr(13) + "Consulte con el proveedor para adquirir nuevas licencias", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                ValidarLicencias = False
            Else
                MsgBox("Error de Validación, Consulte con el administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
                ValidarLicencias = False
            End If

            Conn.Close()

        Catch ex As Exception
            If Conn.State = ConnectionState.Open Then Conn.Close()
            ValidarLicencias = False
            'MsgBox(ex.Message)
        End Try


    End Function
    Public Function Compare(ID) As Boolean

        Dim DATOS As String()
        Dim AL As Long
        Dim DS, FC, HR As String
        Dim A As String = ""
        Dim B As String = ""
        Dim DS1, FC1, HR1, DS2, FC2, HR2 As Long

        DATOS = Split(ID, "-")

        DS = Trim(DATOS(0))
        FC = Trim(DATOS(1))
        HR = Trim(DATOS(2))
        AL = Trim(DATOS(3)) / 2

        DS1 = (CDec("&H" & DS)) - AL
        FC1 = (CDec("&H" & FC)) - AL
        HR1 = (CDec("&H" & HR)) - AL

        DS2 = Mid$(DecToOct(Val(DS1) + AL), 1, 6)
        FC2 = DecToOct(Val(FC1) + AL)
        HR2 = DecToOct(Val(HR1) + AL)

        A = DS2 & "-" & FC2 & "-" & HR2

        With For_Licencia
            B = Trim(.TxtClave1.Text) & "-" & Trim(.TxtClave2.Text) & "-" & Trim(.TxtClave3.Text)
        End With

        If A = B Then
            Compare = True
        Else
            Compare = False
        End If

    End Function
    Private Sub Ejecutar_Comando(ByVal Comando As String, ByVal Argumentos As String)

        'CierraCMD()


        'Dim process As Process = New Process()
        'process.StartInfo.FileName = "cmd.exe"
        'process.StartInfo.Arguments = "/C SET BLK"
        'process.StartInfo.UseShellExecute = False
        'process.StartInfo.RedirectStandardOutput = True
        'process.StartInfo.RedirectStandardError = True
        'process.Start()
        'Dim output As String = process.StandardOutput.ReadToEnd()
        'MsgBox(output)
        'Dim err As String = process.StandardError.ReadToEnd()
        'MsgBox(err)
        'process.WaitForExit()

    End Sub
    Public Function GetVariableEntorno(Nombre) As String()

        Try

            'Dim Comando As String = "SET " & Nombre
            'Dim VEntorno = Shell(Comando, AppWinStyle.Hide, True)
            'CierraCMD()

            If Environment.OSVersion.Platform = PlatformID.Win32NT Then

                Dim VEntorno = SeguridadBlk.UnEncryptStr(Environment.GetEnvironmentVariable("BLK"), GL_ClaveEncrip)

                Dim Datos As String() = Split(VEntorno, "@")
                Return Datos

            Else
                Return Nothing
            End If

        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function SetVariableEntorno(Nombre, Valor) As Boolean

        Try

            'También puedes crear una variable de entorno mediante la línea de comandos, 
            'para eso utiliza el comando SETX de la siguiente forma
            'SETX VARIABLE VALOR.

            Dim Comando As String = "SETX " & Nombre & " " & Valor

            If Environment.OSVersion.Platform = PlatformID.Win32NT Then
                'Environment.SetEnvironmentVariable(Nombre, Valor)
                Shell(Comando, AppWinStyle.Hide, True)
                CierraCMD()
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function
    Sub Wal()

        Try

            'FileOpen(99, My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\BLK\wal.dll", OpenMode.Input) 'Abre el archivo 
            FileOpen(99, System.Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%\BLK") & "\wal.dll", OpenMode.Input) 'Abre el archivo 



            Dim LineadeTexto, Cadena As String
            Dim Datos As String()

            Do Until EOF(99) 'lee las líneas contenidas en el archivo 
                LineadeTexto = LineInput(99) 'Lee la línea entera 

                Cadena = SeguridadBlk.UnEncryptStr(LineadeTexto, GL_ClaveEncrip)
                Datos = Split(Cadena, "@") ' Separo los datos 

                GL_CodPub = Datos(0)
                GL_NitPub = Datos(1)
                Exit Do
            Loop

            FileClose(99)

        Catch ex As Exception
            MsgBox("Archivo de arranque no disponible", MsgBoxStyle.Critical, "Bulkmatic de Colombia S.A.S")
            End
        End Try

    End Sub
    Public Function ConexionPublica() As Boolean

        Dim Estado As String = ""
        Dim BD, US, PW, SV, IPA As String()

        Call Wal()
        '----------------- DATOS DE LA COMPAÑIA --------------------

        Try

            Dim SQL = "SELECT BDATOS,[USER],PASW,IP,ESTADO,FECHAVENCE,LICENCIAS,IPAUTORIZADA FROM DESTINOS WHERE CODIGO='" & GL_CodPub & "' AND NIT='" & GL_NitPub & "' "

            Dim da As New SqlDataAdapter(SQL, ConnP)
            Dim ds As New DataSet
            Dim Fila As DataRow
            If ConnP.State = ConnectionState.Open Then ConnP.Close()
            ConnP.Open()


            da.Fill(ds, "InfoCliente")

            For Each Fila In ds.Tables("InfoCliente").Rows

                BD = Split(SeguridadBlk.UnEncryptStr(Trim(Fila("BDATOS").ToString()), GL_ClaveEncrip), "@")
                US = Split(SeguridadBlk.UnEncryptStr(Trim(Fila("USER").ToString()), GL_ClaveEncrip), "@")
                PW = Split(SeguridadBlk.UnEncryptStr(Trim(Fila("PASW").ToString()), GL_ClaveEncrip), "@")
                SV = Split(SeguridadBlk.UnEncryptStr(Trim(Fila("IP").ToString()), GL_ClaveEncrip), "@")
                IPA = Split(SeguridadBlk.UnEncryptStr(Trim(Fila("IPAUTORIZADA").ToString()), GL_ClaveEncrip), "@")


                BaseDatos = BD(1)
                User = US(1)
                Psw = PW(0)
                Servidor = SV(0)
                Estado = Trim(Fila("ESTADO").ToString())
                GL_Licencias = Trim(Fila("LICENCIAS").ToString())
                GL_FechaVence = Trim(Fila("FECHAVENCE").ToString())

                Try

                    Dim FechaVence As Date = CType(GL_FechaVence, Date)
                    Dim FechaActual As Date = CType(Now.ToString("yyyy/MM/dd"), Date)
                    Dim Diferencia As Integer

                    Diferencia = DateDiff(DateInterval.Day, FechaActual, FechaVence)

                    If Diferencia > 30 Then
                        'For_MenuPrincipal.LblAviso.Visible = False
                        'For_MenuPrincipal.LblDias.Visible = False
                    ElseIf Diferencia > 1 And Diferencia <= 30 Then
                        'For_MenuPrincipal.LblAviso.Visible = True
                        'For_MenuPrincipal.LblDias.Text = Diferencia & " Dias."
                        'For_MenuPrincipal.LblDias.Visible = True
                    ElseIf Diferencia = 1 Then
                        'For_MenuPrincipal.LblDias.ForeColor = Color.Red
                        'For_MenuPrincipal.LblAviso.Visible = True
                        'For_MenuPrincipal.LblDias.Text = Diferencia & " Dia."
                        'For_MenuPrincipal.LblDias.Visible = True
                    ElseIf Diferencia = 0 Then
                        'For_MenuPrincipal.LblDias.ForeColor = Color.Red
                        'For_MenuPrincipal.LblAviso.Visible = True
                        'For_MenuPrincipal.LblDias.Text = "Ultimo dia de licenciamiento!"
                        'For_MenuPrincipal.LblDias.Visible = True
                    ElseIf Diferencia < 0 Then
                        MsgBox("La licencia de Uso para este Cliente ha Caducado!" + Chr(13) + "Consulte con el Area comercial de BULKMATIC DE COLOMBIA S.A.S para reactivar el servicio.", MsgBoxStyle.Critical, "Bulkmatic de Colombia S.A.S")
                        If ConnP.State = 1 Then ConnP.Close()
                        End
                    End If

                Catch ex As Exception

                End Try

                ConnP.Close()
                ConexionPublica = True
            Next


        Catch ex As Exception
            MsgBox("Imposible Conectar al servidor Principal. Consulte con el Administrador!", MsgBoxStyle.Critical, "Bulkmatic de Colombia S.A.S")
            ConexionPublica = False
            End
        End Try
        '----------------------------------------------------------------------

        If Estado = "INACTIVO" Then
            If ConnP.State = 1 Then ConnP.Close()
            MsgBox("Este Cliente se encuentra INACTIVO!." + Chr(13) + "Consulte el Area Comercial de BULKMATIC DE COLOMBIA S.A.S!", MsgBoxStyle.Critical, "Bulkmatic de Colombia S.A.S")
            ConexionPublica = False
            End
        End If

    End Function

End Module
