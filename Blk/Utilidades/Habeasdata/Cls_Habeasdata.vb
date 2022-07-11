Imports System.Data.SqlClient

Public Class Cls_Habeasdata
    '*************** Atributos **************************
    Private _Idcaso As String
    Private _Tdoc As String
    Private _Documento As String
    Private _Nom_Solicitante As String
    Private _Apel_Solicitante As String
    Private _Fecha_Solicitud As String
    Private _Medio As String
    Private _Solicitud As String
    Private _Estado As String
    Private _Respuesta As String
    Private _Responsable As String
    Private _Fecha_Respuesta As String

    '***************** Propiedades **********************
    Public Property Idcaso As String
        Get
            Return _Idcaso
        End Get
        Set(value As String)
            _Idcaso = value
        End Set
    End Property
    Public Property Tdoc As String
        Get
            Return _Tdoc
        End Get
        Set(value As String)
            _Tdoc = value
        End Set
    End Property
    Public Property Documento As String
        Get
            Return _Documento
        End Get
        Set(value As String)
            _Documento = value
        End Set
    End Property
    Public Property Nom_Solicitante As String
        Get
            Return _Nom_Solicitante
        End Get
        Set(value As String)
            _Nom_Solicitante = value
        End Set
    End Property
    Public Property Apel_Solicitante As String
        Get
            Return _Apel_Solicitante
        End Get
        Set(value As String)
            _Apel_Solicitante = value
        End Set
    End Property
    Public Property Fecha_Solicitud As String
        Get
            Return _Fecha_Solicitud
        End Get
        Set(value As String)
            _Fecha_Solicitud = value
        End Set
    End Property
    Public Property Medio As String
        Get
            Return _Medio
        End Get
        Set(value As String)
            _Medio = value
        End Set
    End Property
    Public Property Solicitud As String
        Get
            Return _Solicitud
        End Get
        Set(value As String)
            _Solicitud = value
        End Set
    End Property
    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property
    Public Property Respuesta As String
        Get
            Return _Respuesta
        End Get
        Set(value As String)
            _Respuesta = value
        End Set
    End Property
    Public Property Responsable As String
        Get
            Return _Responsable
        End Get
        Set(value As String)
            _Responsable = value
        End Set
    End Property
    Public Property Fecha_Respuesta As String
        Get
            Return _Fecha_Respuesta
        End Get
        Set(value As String)
            _Fecha_Respuesta = value
        End Set
    End Property

    ' '***************** Metodos ***********************
    Public Function GuardarSolicitud() As Boolean

        Try

            Dim comando As New SqlClient.SqlCommand("sp_HabeasGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@TDOC", SqlDbType.NChar).Value = Tdoc
            comando.Parameters.Add("@DOCUMENTO", SqlDbType.NChar).Value = Documento
            comando.Parameters.Add("@NOM_SOLICITANTE", SqlDbType.NChar).Value = Nom_Solicitante
            comando.Parameters.Add("@APEL_SOLICITANTE", SqlDbType.NChar).Value = Apel_Solicitante
            comando.Parameters.Add("@FECHA_SOLICITUD", SqlDbType.NChar).Value = Fecha_Solicitud
            comando.Parameters.Add("@MEDIO", SqlDbType.NChar).Value = Medio
            comando.Parameters.Add("@SOLICITUD", SqlDbType.NChar).Value = Solicitud
            comando.Parameters.Add("@ESTADO", SqlDbType.NChar).Value = Estado
            'comando.Parameters.Add("@RESPUESTA", SqlDbType.NChar).Value = Respuesta
            'comando.Parameters.Add("@RESPONSABLE", SqlDbType.NChar).Value = Responsable
            'comando.Parameters.Add("@FECHA_RESPUESTA", SqlDbType.NChar).Value = Fecha_Respuesta


            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            comando.ExecuteScalar()

            ' Si Todo Bien = OK
            ' Si todo Mal = Mensaje de error
            If comando.Parameters("@Resultado").Value = "OK" Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return False
        End Try

        Conn.Close()

    End Function
    Public Function ActualizarSolicitud() As Boolean

        Try
            Dim comando As New SqlClient.SqlCommand("sp_HabeasActualizar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@IDCASO", SqlDbType.NChar).Value = Nom_Solicitante
            comando.Parameters.Add("@TDOC", SqlDbType.NChar).Value = Tdoc
            comando.Parameters.Add("@DOCUMENTO", SqlDbType.NChar).Value = Documento
            comando.Parameters.Add("@NOM_SOLICITANTE", SqlDbType.NChar).Value = Nom_Solicitante
            comando.Parameters.Add("@APEL_SOLICITANTE", SqlDbType.NChar).Value = Apel_Solicitante
            comando.Parameters.Add("@FECHA_SOLICITUD", SqlDbType.NChar).Value = Fecha_Solicitud
            comando.Parameters.Add("@MEDIO", SqlDbType.NChar).Value = Medio
            comando.Parameters.Add("@SOLICITUD", SqlDbType.NChar).Value = Solicitud
            comando.Parameters.Add("@ESTADO", SqlDbType.NChar).Value = Estado
            comando.Parameters.Add("@RESPUESTA", SqlDbType.NChar).Value = Respuesta
            comando.Parameters.Add("@RESPONSABLE", SqlDbType.NChar).Value = Responsable
            comando.Parameters.Add("@FECHA_RESPUESTA", SqlDbType.NChar).Value = Fecha_Respuesta

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            comando.ExecuteScalar()

            ' Si Todo Bien = OK
            ' Si todo Mal = Mensaje de error
            If comando.Parameters("@Resultado").Value = "OK" Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return False
        End Try

        Conn.Close()

    End Function
    Public Function GuardarRespuesta() As Boolean

        Try
            Dim comando As New SqlClient.SqlCommand("sp_HabeasRespuesta", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@IDCASO", SqlDbType.NChar).Value = Idcaso
            comando.Parameters.Add("@ESTADO", SqlDbType.NChar).Value = "Reclamo Resuelto"
            comando.Parameters.Add("@RESPUESTA", SqlDbType.NChar).Value = Respuesta
            comando.Parameters.Add("@RESPONSABLE", SqlDbType.NChar).Value = Responsable
            comando.Parameters.Add("@FECHA_RESPUESTA", SqlDbType.NChar).Value = Fecha_Respuesta

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            comando.ExecuteScalar()

            ' Si Todo Bien = OK
            ' Si todo Mal = Mensaje de error
            If comando.Parameters("@Resultado").Value = "OK" Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return False
        End Try

        Conn.Close()

    End Function
    Public Function ListarSolicitudes() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_HabeasListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader
        Consulta = comando.ExecuteReader

        Return Consulta

        Conn.Close()

    End Function

End Class
