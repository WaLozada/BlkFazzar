Imports System.Data.SqlClient

Public Class Transportadores

    '*************** Atributos **************************
    Private _IdTransportador As String
    Private _Codigo As String
    Private _Transportador As String

    '***************** Propiedades ***********************
    Public Property IdTransportador As String
        Get
            Return _IdTransportador
        End Get
        Set(value As String)
            _IdTransportador = value
        End Set
    End Property
    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
        End Set
    End Property
    Public Property Transportador As String
        Get
            Return _Transportador
        End Get
        Set(value As String)
            _Transportador = value
        End Set
    End Property

    '***************** Metodos ***********************
    Public Function ListarTransport() As SqlDataReader

        Try
            Dim comando As New SqlClient.SqlCommand("sp_TransportListar", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            '------ Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------
            Dim Consulta As SqlDataReader

            Consulta = comando.ExecuteReader
            Return Consulta

        Catch ex As Exception
            Return Nothing
        End Try

        Conn.Close()

    End Function

End Class
