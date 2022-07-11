Imports System.Data.SqlClient

Public Class ClsCargueDescargue

    '*************** Atributos **************************
    Private _Servicio As String
    Private _Centro As String
    Private _Bodega As String
    Private _Cliente As String

    '***************** Propiedades **********************
    Public Property Servicio As String
        Get
            Return _Servicio
        End Get
        Set(value As String)
            _Servicio = value
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
    Public Property Bodega As String
        Get
            Return _Bodega
        End Get
        Set(value As String)
            _Bodega = value
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

    ' '***************** Metodos ***********************

    Public Function ValoresDescargue(Centro, Bodega, Cliente, Servicio) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_TarifasCargueDescargue", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()


        comando.Parameters.Add("@SERVICIO", SqlDbType.NChar).Value = Servicio ' 3- Descargue/Palet, 4-DesCargue/suelta
        comando.Parameters.Add("@CENTRO", SqlDbType.NChar).Value = Centro
        comando.Parameters.Add("@BODEGA", SqlDbType.NChar).Value = Bodega
        comando.Parameters.Add("@CLIENTE", SqlDbType.NChar).Value = Cliente

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function

    Public Function ValoresCargue(Centro, Bodega, Cliente) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_TarifasCargueDescargue", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()


        comando.Parameters.Add("@SERVICIO", SqlDbType.NChar).Value = 2 ' 1- Descargue, 2-Cargue
        comando.Parameters.Add("@CENTRO", SqlDbType.NChar).Value = Centro
        comando.Parameters.Add("@BODEGA", SqlDbType.NChar).Value = Bodega
        comando.Parameters.Add("@CLIENTE", SqlDbType.NChar).Value = Cliente

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
