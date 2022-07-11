
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Module Funciones
    Function Version() As String

        Version = "Versión : 1.0.25"

    End Function
    Public Function ConsultaPerfil(Perfil) As Boolean

        Try

            Dim comando As New SqlClient.SqlCommand("sp_PerfilesListar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 3 ' Listar perfiles del Usuario
            comando.Parameters.Add("@USUARIO", SqlDbType.NChar).Value = UsuarioApp.Codigo
            comando.Parameters.Add("@PERFIL", SqlDbType.NChar).Value = Perfil

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()

            Conn.Open()
            Dim Consulta As SqlDataReader
            Consulta = comando.ExecuteReader
            Dim Permiso As Boolean

            If Consulta.Read() Then
                If Trim(Consulta("CANTIDAD").ToString()) = 0 Then
                    Permiso = False
                Else
                    Permiso = True
                End If
            Else
                Permiso = False
            End If
            Consulta.Close()

            Return Permiso

        Catch ex As Exception
            Conn.Close()
            Return False
        End Try

    End Function

    Public Function SoloNumeros(valor) As Boolean

        If Char.IsDigit(valor) Then
            SoloNumeros = False
        ElseIf Char.IsControl(valor) Then
            SoloNumeros = False
        Else
            SoloNumeros = True
        End If

    End Function
    Public Function Sololetras(valor) As Boolean

        If Char.IsLetter(valor) Then
            Sololetras = False
        ElseIf Char.IsControl(valor) Then
            Sololetras = False
        ElseIf Char.IsWhiteSpace(valor) Then
            Sololetras = False
        Else
            Sololetras = True
        End If

    End Function
    Public Function FechaHoraServer() As String

        Try

            Dim comando As New SqlClient.SqlCommand("sp_GetServerDate", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            FechaHoraServer = comando.ExecuteScalar()
            Conn.Close()
        Catch ex As Exception
            FechaHoraServer = "No Disponible"
        End Try


    End Function
    Function CalcularBultos(idPresentacion As Integer, Cantidad As Decimal) As String

        '-------------- Encuentro el Divisor y hago el Calculo ------------

        Dim table As DataTable = Gl_DataSet.Tables("TPresentacion")
        Dim Divisor As Decimal

        ' Especifico que la columna id sea igual a la presentacion Seleccionada.
        Dim expression As String
        expression = "ID = " & idPresentacion
        Dim foundRows() As DataRow

        ' Uso el Select method para encontrar la fila que concuerda con el filtro.
        foundRows = table.Select(expression)

        'Selecciono especificamente la columna 2 (Divisor) que es el valor por el que debe dividir
        Divisor = foundRows(0)(2)

        If (Cantidad Mod Divisor) = 0 Then
            Return Cantidad / Divisor
        Else
            'MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación Seleccionada!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Return ""

        End If

        '-----------------------------------------------------

    End Function
    Function LimpiarNumeros(Cadena) As String

        Dim Numero As String = ""

        For i = 1 To Len(Cadena)
            If IsNumeric(Mid(Cadena, i, 1)) = True Then
                Numero = Numero & Mid(Cadena, i, 1)
            End If

        Next

        Return Numero

    End Function
    Function CargaralFtp(Modulo, RutaArchivo, NombreArchivo) As String

        Try

            'Dim Destino As String

            'Try
            '    Dim ftp As FtpWebRequest = DirectCast(FtpWebRequest.Create("Ftp://190.249.176.190/Archivos/" & Modulo), FtpWebRequest)

            '    ftp.Credentials = New NetworkCredential(SeguridadBlk.UnEncryptStr(Usftp, GL_ClaveEncrip), SeguridadBlk.UnEncryptStr(Clftp, GL_ClaveEncrip))
            '    '************************
            '    ftp.KeepAlive = False
            '    ftp.AuthenticationLevel = Security.AuthenticationLevel.MutualAuthRequested
            '    ftp.Method = WebRequestMethods.Ftp.MakeDirectory
            '    Dim ftpresp As FtpWebResponse = DirectCast(ftp.GetResponse, FtpWebResponse)
            '    '***********************
            '    Dim sreader As New IO.StreamReader(ftpresp.GetResponseStream)
            '    ftpresp.Close()


            'Catch ex As Exception
            '    'Return ex.Message
            'End Try


            'Destino = "Ftp://190.249.176.190/Archivos/" & Modulo & "/" & NombreArchivo

            'My.Computer.Network.UploadFile(RutaArchivo, Destino, SeguridadBlk.UnEncryptStr(Usftp, GL_ClaveEncrip), SeguridadBlk.UnEncryptStr(Clftp, GL_ClaveEncrip), True, 100)

            Return "OK"

        Catch ex As Exception

            Return ex.Message

        End Try


    End Function
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function
    Public Function ConvertDataGridviewInDataTable(dgv As DataGridView) As DataTable
        Dim dtnuevo As New DataTable()
        Dim columNueva As DataColumn
        Dim filaNueva As DataRow
        Dim numColum As Integer

        'Replicamos las columnas del DataGridView en el DataTable nuevo
        For Each Columdgv As DataGridViewColumn In dgv.Columns
            columNueva = New DataColumn(Columdgv.DataPropertyName, Columdgv.ValueType)
            'columNueva = New DataColumn(Columdgv.DataPropertyName, Type.GetType("System.String"))
            dtnuevo.Columns.Add(columNueva)
        Next
        numColum = dtnuevo.Columns.Count

        'Rellenamos los valores del DataTable nuevo con los valores de las celdas del DataGridView
        For Each filaDatos As DataGridViewRow In dgv.Rows
            filaNueva = dtnuevo.NewRow()
            For i As Integer = 0 To (numColum - 1)
                filaNueva(i) = filaDatos.Cells(i).Value
            Next
            dtnuevo.Rows.Add(filaNueva)
        Next
        Return dtnuevo
    End Function
    Public Function HexToDec(ByVal HexStr As String) As Double
        Dim mult As Double
        Dim DecNum As Double
        Dim ch As String
        mult = 1
        DecNum = 0

        Dim i As Integer
        For i = Len(HexStr) To 1 Step -1
            ch = Mid(HexStr, i, 1)
            If (ch >= "0") And (ch <= "9") Then
                DecNum = DecNum + (Val(ch) * mult)
            Else
                If (ch >= "A") And (ch <= "F") Then
                    DecNum = DecNum + ((Asc(ch) - Asc("A") + 10) * mult)
                Else
                    If (ch >= "a") And (ch <= "f") Then
                        DecNum = DecNum + ((Asc(ch) - Asc("a") + 10) * mult)
                    Else
                        HexToDec = 0
                        Exit Function
                    End If
                End If
            End If
            mult = mult * 16
        Next i
        HexToDec = DecNum
    End Function
    Function DecToOct(ByRef DecStr As String) As String

        Dim Resultado As Integer
        Dim Residuo As Double
        Dim Octa As String = ""

        Do
            Resultado = Fix(DecStr / 8)
            Residuo = DecStr Mod 8
            Octa = Residuo & Octa
            DecStr = Resultado

        Loop Until Resultado = 0

        DecToOct = Octa


    End Function
    Function NumeroMes(Mes) As Integer

        Select Case Mes
            Case "Enero"
                NumeroMes = 1
            Case "Febrero"
                NumeroMes = 2
            Case "Marzo"
                NumeroMes = 3
            Case "Abril"
                NumeroMes = 4
            Case "Mayo"
                NumeroMes = 5
            Case "Junio"
                NumeroMes = 6
            Case "Julio"
                NumeroMes = 7
            Case "Agosto"
                NumeroMes = 8
            Case "Septiembre"
                NumeroMes = 9
            Case "Octubre"
                NumeroMes = 10
            Case "Noviembre"
                NumeroMes = 11
            Case Else
                NumeroMes = 12
        End Select

    End Function


End Module
