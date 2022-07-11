Imports System.Data.SqlClient
Imports System.Net.Mail


Module Procedimientos
    Sub MinimizarVentanas()

        '---------Minimizo Todas las Ventanas Abiertas ----------
        Dim Sh As System.Object
        Sh = CreateObject("Shell.Application")
        Sh.MinimizeAll()
        'Sh = Nothing
        '---------------------------------------------

    End Sub
    Sub CierraCMD()

        '-------FINALIZAR PROCESOS ABIERTOS DEL CMD------
        Dim Lista_Procesos(), P As Process
        Lista_Procesos = Process.GetProcessesByName("CMD")

        For Each P In Lista_Procesos
            P.Kill()
        Next
        '--------------------------------------------------

    End Sub
    Sub CargueTablasParametricas()

        '******************* Cargar en el Dataset Global Las Tablas Parametricas ****************

        '-------------- Cargo Tabla Familias ----------------
        Dim Sql = "select * from Gen_Familias"
        Dim da As New SqlDataAdapter(Sql, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da.Fill(Gl_DataSet, "TFamilias")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------------- Cargo Tabla Unidades -----------------
        Dim Sql1 = "select * from Gen_TipoUnidad"
        Dim da1 As New SqlDataAdapter(Sql1, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da1.Fill(Gl_DataSet, "TUnidades")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------------- Cargo Tipo Vehiculos -----------------
        Dim Sql2 = "select * from Gen_TipoVehiculo Where Visible=1 Order by ID"
        Dim da2 As New SqlDataAdapter(Sql2, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da2.Fill(Gl_DataSet, "TVehiculos")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------- Cargo Tabla Tipo Presentacion -----------------
        Dim Sql3 = "select ID,DESCRIPCION,DIVISOR from Gen_Presentacion Order by Orden"
        Dim da3 As New SqlDataAdapter(Sql3, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da3.Fill(Gl_DataSet, "TPresentacion")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------- Cargo Tabla Tipo Presentacion -----------------
        Dim Sql4 = "select * from Gen_TipoDocumento"
        Dim da4 As New SqlDataAdapter(Sql4, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da4.Fill(Gl_DataSet, "TDocumento")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------- Cargo Tabla Tipo Presentacion -----------------
        Dim Sql5 = "select * from Gen_TipoBloqueo"
        Dim da5 As New SqlDataAdapter(Sql5, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da5.Fill(Gl_DataSet, "TBloqueo")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------- Cargo Tabla Tipo Areas -----------------
        Dim Sql6 = "select * from Gen_Areas"
        Dim da6 As New SqlDataAdapter(Sql6, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da6.Fill(Gl_DataSet, "TAreas")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------- Cargo Tabla Tipo Roles -----------------
        Dim Sql7 = "select * from Gen_TipoRol"
        Dim da7 As New SqlDataAdapter(Sql7, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da7.Fill(Gl_DataSet, "TRol")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------- Cargo Tabla Tipo Roles -----------------
        Dim Sql8 = "select * from Gen_Ubicaciones"
        Dim da8 As New SqlDataAdapter(Sql8, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da8.Fill(Gl_DataSet, "TUbicaciones")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------- Cargo Tabla Lugares -----------------
        Dim Sql9 = "select * from Gen_Lugares where Visible='1'"
        Dim da9 As New SqlDataAdapter(Sql9, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da9.Fill(Gl_DataSet, "TLugar")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------------- Cargo Tabla Unidades -----------------
        Dim Sql10 = "select * from Gen_Servicios"
        Dim da10 As New SqlDataAdapter(Sql10, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da10.Fill(Gl_DataSet, "TServicios")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------------- Cargo Tabla Servicios Macro -----------------
        Dim Sql11 = "select * from Gen_ServiciosMacro"
        Dim da11 As New SqlDataAdapter(Sql11, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da11.Fill(Gl_DataSet, "TServiciosMacro")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------------- Cargo Tabla Unidades -----------------
        Dim Sql12 = "select * from Gen_Zonas"
        Dim da12 As New SqlDataAdapter(Sql12, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da12.Fill(Gl_DataSet, "TZonas")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------------- Cargo Tabla Unidades -----------------
        Dim Sql13 = "select * from Gen_TipoDespacho"
        Dim da13 As New SqlDataAdapter(Sql13, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da13.Fill(Gl_DataSet, "TDespachos")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------------- Cargo Tipo Vehiculos -----------------
        Dim Sql14 = "select * from Gen_TipoVehiculo Where Bitacora=1 Order by Tipo"
        Dim da14 As New SqlDataAdapter(Sql14, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da14.Fill(Gl_DataSet, "TVehiculosDespachos")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------------- Cargo Terminales -----------------
        Dim Sql15 = "select * from Gen_Terminales Order by idterminal"
        Dim da15 As New SqlDataAdapter(Sql15, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da15.Fill(Gl_DataSet, "TTerminales")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '-------------- Cargo Segmentos -----------------
        Dim Sql16 = "select * from Gen_Segmentos Order by idsegmento"
        Dim da16 As New SqlDataAdapter(Sql16, Conn)
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Try
            da16.Fill(Gl_DataSet, "TSegmentos")
        Catch ex As Exception
        End Try
        '-----------------------------------------------------

        '**************************************************************************************
    End Sub

    Public Sub EnvioMail(Destinatario, Asunto, Mensaje)

        Try
            Dim correo As New MailMessage
            Dim smtp As New SmtpClient()

            correo.From = New MailAddress("blkcolombia@bulkmatic.com.co", "Bulkmatic de Colombia", System.Text.Encoding.UTF8)
            correo.To.Add(Destinatario)
            correo.SubjectEncoding = System.Text.Encoding.UTF8
            correo.Subject = Asunto
            correo.Body = Mensaje
            correo.BodyEncoding = System.Text.Encoding.UTF8
            correo.IsBodyHtml = False '(formato tipo web o normal:  true = web)
            correo.Priority = MailPriority.High '>> prioridad

            smtp.Credentials = New System.Net.NetworkCredential("blkcolombia@bulkmatic.com.co", "Blk2020*")
            smtp.Port = 587
            smtp.Host = "smtp.office365.com"
            smtp.EnableSsl = True

            smtp.Send(correo)

            MsgBox("Mensaje Enviado!", MsgBoxStyle.Information, Gl_NomCompañia)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub

End Module
