Imports System.Data.SqlClient

Public Class Ordenes
    Private _Centro As String
    Private _Bodega As String
    Private _Desde As Date
    Private _Hasta As Date

    Public Property Centro As String
        Get
            Return _Centro
        End Get
        Set(value As String)
            _Centro = value
        End Set
    End Property
    Public Property Bodega As String
        Get
            Return _Bodega
        End Get
        Set(value As String)
            _Bodega = value
        End Set
    End Property
    Public Property Desde As Date
        Get
            Return _Desde
        End Get
        Set(value As Date)
            _Desde = value
        End Set
    End Property
    Public Property Hasta As Date
        Get
            Return _Hasta
        End Get
        Set(value As Date)
            _Hasta = value
        End Set
    End Property
    Public Function ListarOrdenes() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_OrdenesListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@CENTRO", SqlDbType.NChar).Value = Centro
        comando.Parameters.Add("@BODEGA", SqlDbType.NChar).Value = Bodega
        comando.Parameters.Add("@DESDE", SqlDbType.Date).Value = Desde
        comando.Parameters.Add("@HASTA", SqlDbType.Date).Value = Hasta

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
