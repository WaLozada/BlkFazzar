Imports System.Data.SqlClient

Public Class Consultas
    '*************** Atributos **************************
    Private _IdConsulta As String
    Private _Bodega As String
    Private _FechaCorte As String

    '***************** Propiedades ***********************
    Public Property IdConsulta As String
        Get
            Return _IdConsulta
        End Get
        Set(value As String)
            _IdConsulta = value
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
    Public Property FechaCorte As String
        Get
            Return _FechaCorte
        End Get
        Set(value As String)
            _FechaCorte = value
        End Set
    End Property

    '***************** Metodos ***********************
    Public Function ListarReportes() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ReportesListar", Conn)
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
    Public Function EjecutarReporte(IdConsulta) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_Consultas", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@IDCONSULTA", SqlDbType.NChar).Value = IdConsulta

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function EjecutarReporte(IdConsulta, Deposito) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_Consultas", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@IDCONSULTA", SqlDbType.NChar).Value = IdConsulta
        comando.Parameters.Add("@DEPOSITO", SqlDbType.NChar).Value = Deposito

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function EjecutarReporte(IdConsulta, Deposito, CodProducto) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_Consultas", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@IDCONSULTA", SqlDbType.NChar).Value = IdConsulta
        comando.Parameters.Add("@DEPOSITO", SqlDbType.NChar).Value = Deposito
        comando.Parameters.Add("@CODPRODUCTO", SqlDbType.NChar).Value = CodProducto

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function TotalDeposito(Deposito) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_Mov_Deposito", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@DEPOSITO", SqlDbType.NChar).Value = Deposito

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function

    '**************** Consulta Inventarios *************************
    Public Function ListarDepositos(Bodega, FechaCorte) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ConsultaInventarios", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@BODEGA", SqlDbType.NChar).Value = Bodega
        comando.Parameters.Add("@FECHACORTE", SqlDbType.NChar).Value = Format(FechaCorte, "yyyy-MM-dd")

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function

    Public Function ListarInventarios(Deposito, FechaCorte) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ConsultaInventarios", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@DEPOSITO", SqlDbType.NChar).Value = Deposito
        comando.Parameters.Add("@FECHACORTE", SqlDbType.NChar).Value = Format(FechaCorte, "yyyy-MM-dd")

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function

    Public Function ListarIngresos(Bodega, FechaCorte) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ConsultaIngresosDespachos", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@TIPOMOV", SqlDbType.NChar).Value = "E"
        comando.Parameters.Add("@BODEGA", SqlDbType.NChar).Value = Bodega
        comando.Parameters.Add("@FECHACORTE", SqlDbType.NChar).Value = Format(FechaCorte, "yyyy-MM-dd")

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarDespachos(Bodega, FechaCorte) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ConsultaIngresosDespachos", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@TIPOMOV", SqlDbType.NChar).Value = "S"
        comando.Parameters.Add("@BODEGA", SqlDbType.NChar).Value = Bodega
        comando.Parameters.Add("@FECHACORTE", SqlDbType.NChar).Value = Format(FechaCorte, "yyyy-MM-dd")

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarIngresosDespachos(TipoMov, Desde, Hasta) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ConsultaIngresosDespachosGrl", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@TIPOMOV", SqlDbType.NChar).Value = TipoMov
        comando.Parameters.Add("@DESDE", SqlDbType.NChar).Value = Desde
        comando.Parameters.Add("@HASTA", SqlDbType.NChar).Value = Hasta

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function

    Public Function ListarProductos(Cliente, Deposito) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ConsultasMovCliente", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@CLIENTE", SqlDbType.NChar).Value = Cliente
        comando.Parameters.Add("@DEPOSITO", SqlDbType.NChar).Value = Deposito
        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 1

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarCantidades(Cliente, Deposito, Fecha, Codproducto) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ConsultasMovCliente", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@CLIENTE", SqlDbType.NChar).Value = Cliente
        comando.Parameters.Add("@DEPOSITO", SqlDbType.NChar).Value = Deposito
        comando.Parameters.Add("@CODPRODUCTO", SqlDbType.NChar).Value = Codproducto
        comando.Parameters.Add("@FECHA", SqlDbType.NChar).Value = Fecha
        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 2

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarSaldoAnterior(Cliente, Deposito, Fecha, Codproducto) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ConsultasMovCliente", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@CLIENTE", SqlDbType.NChar).Value = Cliente
        comando.Parameters.Add("@DEPOSITO", SqlDbType.NChar).Value = Deposito
        comando.Parameters.Add("@CODPRODUCTO", SqlDbType.NChar).Value = Codproducto
        comando.Parameters.Add("@FECHA", SqlDbType.NChar).Value = Fecha
        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 3

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta2 As SqlDataReader

        Consulta2 = comando.ExecuteReader
        Return Consulta2
        Conn.Close()

    End Function

    Public Function ListarRecaudoServicios(Accion, Centro, Bodega, Desde, Hasta) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ConsultaRecaudoServicios", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = Accion
        comando.Parameters.Add("@CENTRO", SqlDbType.NChar).Value = Centro
        comando.Parameters.Add("@BODEGA", SqlDbType.NChar).Value = Bodega
        comando.Parameters.Add("@DESDE", SqlDbType.NChar).Value = Desde
        comando.Parameters.Add("@HASTA", SqlDbType.NChar).Value = Hasta

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader

        Return Consulta
        Conn.Close()

    End Function

    Public Function ListarLotes(Deposito, FechaCorte, Accion, Lote) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ConsultaLotes", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = Accion
        comando.Parameters.Add("@DEPOSITO", SqlDbType.NChar).Value = Deposito
        comando.Parameters.Add("@LOTE", SqlDbType.NChar).Value = Lote
        comando.Parameters.Add("@FECHACORTE", SqlDbType.NChar).Value = Format(FechaCorte, "yyyy-MM-dd")

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
