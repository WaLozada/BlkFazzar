Imports System.Data.SqlClient

Public Class Conductores

    '*************** Atributos **************************
    Private _Documento As String
    Private _Nombre As String
    Private _Apellido As String
    Private _Id As String

    '***************** Propiedades ***********************
    Public Property Documento As String
        Get
            Return _Documento
        End Get
        Set(value As String)
            _Documento = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
        End Set
    End Property
    Public Property Id As String
        Get
            Return _Id
        End Get
        Set(value As String)
            _Id = value
        End Set
    End Property

    '***************** Metodos ***********************
    Public Function ListarConductores() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ConductoresListar", Conn)
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
    Public Function ListarConductores(Documento) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ConductoresListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 1
        comando.Parameters.Add("@DOCUMENTO", SqlDbType.NChar).Value = Documento

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
