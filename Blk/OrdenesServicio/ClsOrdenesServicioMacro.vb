Imports System.Data.SqlClient

Public Class ClsOrdenesServicioMacro

    '*************** Atributos **************************
    Private _Servicio As Integer
    Private _Cliente As String
    Private _Centro As String
    Private _Estado As Integer
    Private _Observaciones As String

    '***************** Propiedades **********************

    Public Property Servicio As Integer
        Get
            Return _Servicio
        End Get
        Set(value As Integer)
            _Servicio = value
        End Set
    End Property
    Public Property Cliente As String
        Get
            Return _Cliente
        End Get
        Set(value As String)
            _Cliente = value
        End Set
    End Property
    Public Property Centro As String
        Get
            Return _Centro
        End Get
        Set(value As String)
            _Centro = value
        End Set
    End Property
    Public Property Estado As Integer
        Get
            Return _Estado
        End Get
        Set(value As Integer)
            _Estado = value
        End Set
    End Property
    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(value As String)
            _Observaciones = value
        End Set
    End Property

    '**************** Metodos ****************************
    Public Function GuardarOSM() As Boolean

        Try

            Dim comando As New SqlClient.SqlCommand("sp_OSMGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@SERVICIO", SqlDbType.Int).Value = Servicio
            comando.Parameters.Add("@CLIENTE", SqlDbType.NChar).Value = Cliente
            comando.Parameters.Add("@CENTRO", SqlDbType.NChar).Value = Centro
            comando.Parameters.Add("@ESTADO", SqlDbType.Int).Value = 1 ' 1-Pendiente, 2-En Proceso, 3-Finalizada
            comando.Parameters.Add("@OBSERVACIONES", SqlDbType.NVarChar).Value = Observaciones
            comando.Parameters.Add("@REGISTRO", SqlDbType.NChar).Value = UsuarioApp.Documento

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            comando.ExecuteScalar()

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
    Public Function ListarOSM(Desde, Hasta, Accion) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_OSMListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.Int).Value = Accion
        comando.Parameters.Add("@DESDE", SqlDbType.DateTime).Value = Desde
        comando.Parameters.Add("@HASTA", SqlDbType.DateTime).Value = Hasta

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
