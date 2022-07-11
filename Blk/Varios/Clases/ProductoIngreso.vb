Imports System.Data.SqlClient

Public Class ProductoIngreso

    '*************** Atributos **************************
    Private _Codigo As String
    Private _Producto As String
    Private _Cantidad As String
    Private _Unidad As String
    Private _Presentacion As String
    Private _Bultos As String
    Private _Lote As String
    Private _Bloqueado As String
    Private _Sobrante As String



    '***************** Propiedades **********************
    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
        End Set
    End Property
    Public Property Producto As String
        Get
            Return _Producto
        End Get
        Set(value As String)
            _Producto = value
        End Set
    End Property
    Public Property Cantidad As String
        Get
            Return _Cantidad
        End Get
        Set(value As String)
            _Cantidad = value
        End Set
    End Property
    Public Property Unidad As String
        Get
            Return _Unidad
        End Get
        Set(value As String)
            _Unidad = value
        End Set
    End Property
    Public Property Presentacion As String
        Get
            Return _Presentacion
        End Get
        Set(value As String)
            _Presentacion = value
        End Set
    End Property
    Public Property Bultos As String
        Get
            Return _Bultos
        End Get
        Set(value As String)
            _Bultos = value
        End Set
    End Property
    Public Property Lote As String
        Get
            Return _Lote
        End Get
        Set(value As String)
            _Lote = value
        End Set
    End Property
    Public Property Bloqueado As String
        Get
            Return _Bloqueado
        End Get
        Set(value As String)
            _Bloqueado = value
        End Set
    End Property
    Public Property Sobrante As String
        Get
            Return _Sobrante
        End Get
        Set(value As String)
            _Sobrante = value
        End Set
    End Property

    Public Function ListarObservaciones(Accion) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ObservacionesListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()


        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = Accion

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Sub LimpiarVariable()

        Codigo = ""
        Producto = ""
        Cantidad = ""
        Unidad = ""
        Presentacion = ""
        Bultos = ""
        Lote = ""
        Bloqueado = ""
        Sobrante = ""

    End Sub

End Class
