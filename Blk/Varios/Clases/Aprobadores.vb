Imports System.Data.SqlClient

Public Class Aprobadores

    '*************** Atributos **************************
    Private _IdAprueba As String
    Private _Documento As String
    Private _Nombre As String
    Private _Apellidos As String

    '***************** Propiedades ***********************
    Public Property IdAprueba As String
        Get
            Return _IdAprueba
        End Get
        Set(value As String)
            _IdAprueba = value
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
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Apellidos As String
        Get
            Return _Apellidos
        End Get
        Set(value As String)
            _Apellidos = value
        End Set
    End Property

    '***************** Metodos ***********************
    Public Function ListarAprobadores() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_AprobadoresListar", Conn)
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
    Public Function ListarLineaspresupuesto() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_LpresupuestoListar", Conn)
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
