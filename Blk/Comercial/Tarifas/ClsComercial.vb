Imports System.Data.SqlClient

Public Class ClsComercial

    '*************** Atributos **************************
    Private _IdServicio As String
    Private _Servicio As String
    Private _DiviOrigen As String
    Private _Origen As String
    Private _DiviDestino As String
    Private _Destino As String
    Private _Kilometros As Integer
    Private _IdTipoVehiculo As Integer
    Private _Capacidad As Double
    Private _UnidadM As String
    Private _CostoFlete As Integer
    Private _CostoTonelada As Integer
    Private _MargenPorcentaje As Double
    Private _MargenDinero As Integer
    Private _TarifaFlete As Integer
    Private _TarifaTonelada As Integer
    Private _FechaHora As Date
    Private _UsuarioApp As String
    Private _Observacion As String
    Private _Id As Integer

    '***************** Propiedades **********************
    Public Property IdServicio As String
        Get
            Return _IdServicio
        End Get
        Set(value As String)
            _IdServicio = value
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
    Public Property DiviOrigen As String
        Get
            Return _DiviOrigen
        End Get
        Set(value As String)
            _DiviOrigen = value
        End Set
    End Property
    Public Property Origen As String
        Get
            Return _Origen
        End Get
        Set(value As String)
            _Origen = value
        End Set
    End Property
    Public Property DiviDestino As String
        Get
            Return _DiviDestino
        End Get
        Set(value As String)
            _DiviDestino = value
        End Set
    End Property
    Public Property Destino As String
        Get
            Return _Destino
        End Get
        Set(value As String)
            _Destino = value
        End Set
    End Property
    Public Property Kilometros As Integer
        Get
            Return _Kilometros
        End Get
        Set(value As Integer)
            _Kilometros = value
        End Set
    End Property
    Public Property IdTipoVehiculo As Integer
        Get
            Return _IdTipoVehiculo
        End Get
        Set(value As Integer)
            _IdTipoVehiculo = value
        End Set
    End Property
    Public Property Capacidad As Double
        Get
            Return _Capacidad
        End Get
        Set(value As Double)
            _Capacidad = value
        End Set
    End Property
    Public Property UnidadM As String
        Get
            Return _UnidadM
        End Get
        Set(value As String)
            _UnidadM = value
        End Set
    End Property
    Public Property CostoFlete As Integer
        Get
            Return _CostoFlete
        End Get
        Set(value As Integer)
            _CostoFlete = value
        End Set
    End Property
    Public Property CostoTonelada As Integer
        Get
            Return _CostoTonelada
        End Get
        Set(value As Integer)
            _CostoTonelada = value
        End Set
    End Property
    Public Property MargenPorcentaje As Double
        Get
            Return _MargenPorcentaje
        End Get
        Set(value As Double)
            _MargenPorcentaje = value
        End Set
    End Property
    Public Property MargenDinero As Integer
        Get
            Return _MargenDinero
        End Get
        Set(value As Integer)
            _MargenDinero = value
        End Set
    End Property
    Public Property TarifaFlete As Integer
        Get
            Return _TarifaFlete
        End Get
        Set(value As Integer)
            _TarifaFlete = value
        End Set
    End Property
    Public Property TarifaTonelada As Integer
        Get
            Return _TarifaTonelada
        End Get
        Set(value As Integer)
            _TarifaTonelada = value
        End Set
    End Property
    Public Property FechaHora As Date
        Get
            Return _FechaHora
        End Get
        Set(value As Date)
            _FechaHora = value
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
    Public Property Observacion As String
        Get
            Return _Observacion
        End Get
        Set(value As String)
            _Observacion = value
        End Set
    End Property
    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Function ListarCombos(Accion As String, Optional Tipovehiculo As Integer = 0) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ComercialListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        ' 1- Origenes
        ' 2- Destinos
        ' 3- Tipo de Vehiculos
        ' 4- Unidades de Medida
        ' 5- Capacidad

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = Accion
        comando.Parameters.Add("@TIPOVEHICULO", SqlDbType.Int).Value = Tipovehiculo

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarTarifa(Accion, DiviOrigen, DiviDestino, IdTipoVehiculo, Capacidad, UnidadM) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ComercialListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = Accion
        comando.Parameters.Add("@DIVIORIGEN", SqlDbType.NChar).Value = DiviOrigen
        comando.Parameters.Add("@DIVIDESTINO", SqlDbType.NChar).Value = DiviDestino
        comando.Parameters.Add("@TIPOVEHICULO", SqlDbType.NChar).Value = IdTipoVehiculo
        comando.Parameters.Add("@CAPACIDAD", SqlDbType.Decimal).Value = Capacidad
        comando.Parameters.Add("@UNIDADM", SqlDbType.NChar).Value = UnidadM

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarCotizar(Accion) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ComercialListar", Conn)
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

    Public Function GuardarTarifa(Accion) As String

        Try

            Dim comando As New SqlClient.SqlCommand("sp_ComercialCrudTarifa", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@IDSERVICIO", SqlDbType.NChar).Value = IdServicio
            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = Accion
            comando.Parameters.Add("@DIVIORIGEN", SqlDbType.NChar).Value = DiviOrigen
            comando.Parameters.Add("@DIVIDESTINO", SqlDbType.NChar).Value = DiviDestino
            comando.Parameters.Add("@TIPOVEHICULO", SqlDbType.NChar).Value = IdTipoVehiculo
            comando.Parameters.Add("@CAPACIDAD", SqlDbType.Decimal).Value = Capacidad
            comando.Parameters.Add("@UNIDADM", SqlDbType.NChar).Value = UnidadM
            comando.Parameters.Add("@KILOMETROS", SqlDbType.NChar).Value = Kilometros
            comando.Parameters.Add("@COSTOFLETE", SqlDbType.NChar).Value = CostoFlete
            comando.Parameters.Add("@COSTOTONELADA", SqlDbType.NChar).Value = CostoTonelada
            comando.Parameters.Add("@MARGENPOR", SqlDbType.Decimal).Value = MargenPorcentaje
            comando.Parameters.Add("@MARGENDINERO", SqlDbType.NChar).Value = MargenDinero
            comando.Parameters.Add("@TARIFAFLETE", SqlDbType.NChar).Value = TarifaFlete
            comando.Parameters.Add("@TARIFATONELADA", SqlDbType.NChar).Value = TarifaTonelada
            comando.Parameters.Add("@USUARIOAPP", SqlDbType.NChar).Value = Globales.UsuarioApp.Documento
            comando.Parameters.Add("@OBSERVACION", SqlDbType.NChar).Value = Observacion
            comando.Parameters.Add("@ID", SqlDbType.NChar).Value = Id ' Este valor identifica si es una por cotizar

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

    Public Function EditarTarifa(id) As String

        Try

            Dim comando As New SqlClient.SqlCommand("sp_ComercialCrudTarifa", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@IDSERVICIO", SqlDbType.NChar).Value = IdServicio
            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 2 'Editar Tarifa
            comando.Parameters.Add("@DIVIORIGEN", SqlDbType.NChar).Value = DiviOrigen
            comando.Parameters.Add("@DIVIDESTINO", SqlDbType.NChar).Value = DiviDestino
            comando.Parameters.Add("@TIPOVEHICULO", SqlDbType.NChar).Value = IdTipoVehiculo
            comando.Parameters.Add("@CAPACIDAD", SqlDbType.Decimal).Value = Capacidad
            comando.Parameters.Add("@UNIDADM", SqlDbType.NChar).Value = UnidadM
            comando.Parameters.Add("@KILOMETROS", SqlDbType.NChar).Value = Kilometros
            comando.Parameters.Add("@COSTOFLETE", SqlDbType.NChar).Value = CostoFlete
            comando.Parameters.Add("@COSTOTONELADA", SqlDbType.NChar).Value = CostoTonelada
            comando.Parameters.Add("@MARGENPOR", SqlDbType.Decimal).Value = MargenPorcentaje
            comando.Parameters.Add("@MARGENDINERO", SqlDbType.NChar).Value = MargenDinero
            comando.Parameters.Add("@TARIFAFLETE", SqlDbType.NChar).Value = TarifaFlete
            comando.Parameters.Add("@TARIFATONELADA", SqlDbType.NChar).Value = TarifaTonelada
            comando.Parameters.Add("@USUARIOAPP", SqlDbType.NChar).Value = Globales.UsuarioApp.Documento
            comando.Parameters.Add("@ID", SqlDbType.NChar).Value = id

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

End Class
