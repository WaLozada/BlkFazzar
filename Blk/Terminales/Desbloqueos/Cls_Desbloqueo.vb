Imports System.Data.SqlClient

Public Class Cls_Desbloqueo
    '*************** Atributos **************************
    Private _Centro As String
    Private _Bodega As String
    Private _Cliente As String
    '***************** Propiedades **********************
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
    Public Function ListarBloqueados(Centro, Bodega, Cliente) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_BloqueadosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

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
