Imports System.Data.SqlClient

Public Class OrdenVisor
    Private _Centro As String
    Private _Bodega As String
    Private _Bodegadireccion As String
    Private _Idproceso As String
    Private _Cliente As String
    Private _Deposito As String
    Private _Observacion As String
    Private _Docconductor As String
    Private _Nombreconductor As String
    Private _Apellidoconductor As String
    Private _Placa As String
    Private _Tipo As String
    Private _Transportador As String
    Private _Fecha As String
    Private _Hora As String

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
    Public Property Bodegadireccion As String
        Get
            Return _Bodegadireccion
        End Get
        Set(value As String)
            _Bodegadireccion = value
        End Set
    End Property
    Public Property Idproceso As String
        Get
            Return _Idproceso
        End Get
        Set(value As String)
            _Idproceso = value
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
    Public Property Deposito As String
        Get
            Return _Deposito
        End Get
        Set(value As String)
            _Deposito = value
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
    Public Property Observacion As String
        Get
            Return _Observacion
        End Get
        Set(value As String)
            _Observacion = value
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
    Public Property Placa As String
        Get
            Return _Placa
        End Get
        Set(value As String)
            _Placa = value
        End Set
    End Property
    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
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

    Public Function ListarOrdenVisor() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_OrdenVisor", Conn)
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
    Public Sub LimpiarVariables()
        Centro = ""
        Bodega = ""
        Bodegadireccion = ""
        Idproceso = ""
        Cliente = ""
        Deposito = ""
        Transportador = ""
        Observacion = ""
        Docconductor = ""
        Nombreconductor = ""
        Apellidoconductor = ""
        Placa = ""
        Tipo = ""
        Fecha = ""
        Hora = ""
    End Sub
End Class
