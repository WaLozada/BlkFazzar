Imports System.Data.SqlClient

Public Class ClsRecibosVisor
    Private _Idproceso As String
    Private _Recibo As Integer
    Private _Centro As String
    Private _CodBodega As String
    Private _Bodega As String
    Private _Cliente As String
    Private _Servicio As String
    Private _Cantidad As String
    Private _Unidad As String
    Private _ValorUnitario As String
    Private _ValorTotal As String
    Private _Docconductor As String
    Private _Nombreconductor As String
    Private _Apellidoconductor As String
    Private _Descripcion As String
    Private _Fecha As String
    Private _Hora As String
    Private _UsuarioApp As String
    Public Property Idproceso As String
        Get
            Return _Idproceso
        End Get
        Set(value As String)
            _Idproceso = value
        End Set
    End Property
    Public Property Recibo As String
        Get
            Return _Recibo
        End Get
        Set(value As String)
            _Recibo = value
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
    Public Property CodBodega As String
        Get
            Return _CodBodega
        End Get
        Set(value As String)
            _CodBodega = value
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
    Public Property Servicio As String
        Get
            Return _Servicio
        End Get
        Set(value As String)
            _Servicio = value
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
    Public Property ValorUnitario As String
        Get
            Return _ValorUnitario
        End Get
        Set(value As String)
            _ValorUnitario = value
        End Set
    End Property
    Public Property ValorTotal As String
        Get
            Return _ValorTotal
        End Get
        Set(value As String)
            _ValorTotal = value
        End Set
    End Property
    Public Property Docconductor As String
        Get
            Return _Docconductor
        End Get
        Set(value As String)
            _Docconductor = value
        End Set
    End Property
    Public Property Nombreconductor As String
        Get
            Return _Nombreconductor
        End Get
        Set(value As String)
            _Nombreconductor = value
        End Set
    End Property
    Public Property Apellidoconductor As String
        Get
            Return _Apellidoconductor
        End Get
        Set(value As String)
            _Apellidoconductor = value
        End Set
    End Property
    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property
    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(value As String)
            _Fecha = value
        End Set
    End Property
    Public Property Hora As String
        Get
            Return _Hora
        End Get
        Set(value As String)
            _Hora = value
        End Set
    End Property
    Public Property UsuarioApp As String
        Get
            Return _UsuarioApp
        End Get
        Set(value As String)
            _UsuarioApp = value
        End Set
    End Property

    Public Function ListarServicios(Idproceso)

        Dim comando As New SqlClient.SqlCommand("sp_ServiciosCargueDescargue", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@IDPROCESO", SqlDbType.NChar).Value = Idproceso

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
