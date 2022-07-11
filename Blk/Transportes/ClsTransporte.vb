Imports System.Data.SqlClient

Public Class ClsTransporte
    '*************** Atributos **************************
    Private _NumDespacho As String
    Private _Cliente As Integer
    Private _Origen As String
    Private _Destino As String
    Private _PLaca As String
    Private _Producto As String
    Private _Fecha As String
    Private _Valor As Integer
    Private _Manifiesto As String
    Private _Remesa As String
    Private _TipoDespacho As String
    Private _Zona As Integer
    Private _CeCo As String
    Private _Transportador As String
    Private _TipoVehiculo As Integer
    Private _Costo As Integer
    Private _CargueDescargue As Integer
    Private _CostoTransporte As Integer
    Private _ValorTonelada As Double
    Private _PesoCarga As Double
    Private _ValorCliente As Integer
    Private _OtrosCobros As Integer
    Private _OtrosCobrosDetalle As DataGridView
    Private _Utilidad As Integer
    Private _Margen As Double
    Private _Remision As String
    Private _Factura As String
    Private _Observacion As String

    '***************** Propiedades **********************

    Public Property NumDespacho As String
        Get
            Return _NumDespacho
        End Get
        Set(value As String)
            _NumDespacho = value
        End Set
    End Property
    Public Property Cliente As Integer
        Get
            Return _Cliente
        End Get
        Set(value As Integer)
            _Cliente = value
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
    Public Property Destino As String
        Get
            Return _Destino
        End Get
        Set(value As String)
            _Destino = value
        End Set
    End Property
    Public Property Placa As String
        Get
            Return _PLaca
        End Get
        Set(value As String)
            _PLaca = value
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
    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(value As String)
            _Fecha = value
        End Set
    End Property
    Public Property Valor As Integer
        Get
            Return _Valor
        End Get
        Set(value As Integer)
            _Valor = value
        End Set
    End Property
    Public Property Remesa As String
        Get
            Return _Remesa
        End Get
        Set(value As String)
            _Remesa = value
        End Set
    End Property
    Public Property Manifiesto As String
        Get
            Return _Manifiesto
        End Get
        Set(value As String)
            _Manifiesto = value
        End Set
    End Property
    Public Property TipoDespacho As String
        Get
            Return _TipoDespacho
        End Get
        Set(value As String)
            _TipoDespacho = value
        End Set
    End Property
    Public Property Zona As Integer
        Get
            Return _Zona
        End Get
        Set(value As Integer)
            _Zona = value
        End Set
    End Property
    Public Property Ceco As String
        Get
            Return _CeCo
        End Get
        Set(value As String)
            _CeCo = value
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
    Public Property TipoVehiculo As Integer
        Get
            Return _TipoVehiculo
        End Get
        Set(value As Integer)
            _TipoVehiculo = value
        End Set
    End Property
    Public Property Costo As Integer
        Get
            Return _costo
        End Get
        Set(value As Integer)
            _costo = value
        End Set
    End Property
    Public Property CargueDescargue As Integer
        Get
            Return _CargueDescargue
        End Get
        Set(value As Integer)
            _CargueDescargue = value
        End Set
    End Property
    Public Property CostoTransporte As Integer
        Get
            Return _CostoTransporte
        End Get
        Set(value As Integer)
            _CostoTransporte = value
        End Set
    End Property
    Public Property ValorTonelada As Double
        Get
            Return _ValorTonelada
        End Get
        Set(value As Double)
            _ValorTonelada = value
        End Set
    End Property
    Public Property PesoCarga As Double
        Get
            Return _PesoCarga
        End Get
        Set(value As Double)
            _PesoCarga = value
        End Set
    End Property
    Public Property ValorCliente As Integer
        Get
            Return _ValorCliente
        End Get
        Set(value As Integer)
            _ValorCliente = value
        End Set
    End Property
    Public Property OtrosCobros As Integer
        Get
            Return _OtrosCobros
        End Get
        Set(value As Integer)
            _OtrosCobros = value
        End Set
    End Property
    Public Property OtrosCobrosDetalle As DataGridView
        Get
            Return _OtrosCobrosDetalle
        End Get
        Set(value As DataGridView)
            _OtrosCobrosDetalle = value
        End Set
    End Property
    Public Property Utilidad As Integer
        Get
            Return _Utilidad
        End Get
        Set(value As Integer)
            _Utilidad = value
        End Set
    End Property
    Public Property Margen As Double
        Get
            Return _Margen
        End Get
        Set(value As Double)
            _Margen = value
        End Set
    End Property
    Public Property Remision As String
        Get
            Return _Remision
        End Get
        Set(value As String)
            _Remision = value
        End Set
    End Property
    Public Property Factura As String
        Get
            Return _Factura
        End Get
        Set(value As String)
            _Factura = value
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


    '**************** Metodos ****************************

    Public Function ListarDespachos(Criterio, Desde, Hasta, Optional Cliente = "", Optional Origen = "", Optional Destino = "", Optional TipoDespacho = "", Optional TipoVehiculo = "", Optional Zona = "", Optional EmpTransportadora = "", Optional Manifiesto = "") As SqlDataReader

        Try


            Dim comando As New SqlClient.SqlCommand("sp_DespachosListar", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Closed Then Conn.Open()


            comando.Parameters.Add("@CONSULTA", SqlDbType.Int).Value = Criterio
            comando.Parameters.Add("@DESDE", SqlDbType.NChar).Value = Desde
            comando.Parameters.Add("@HASTA", SqlDbType.NChar).Value = Hasta
            comando.Parameters.Add("@CLIENTE", SqlDbType.NChar).Value = Cliente
            comando.Parameters.Add("@ORIGEN", SqlDbType.NChar).Value = Origen
            comando.Parameters.Add("@DESTINO", SqlDbType.NChar).Value = Destino
            comando.Parameters.Add("@TIPODESPACHO", SqlDbType.NChar).Value = TipoDespacho
            comando.Parameters.Add("@TIPOVEHICULO", SqlDbType.NChar).Value = TipoVehiculo
            comando.Parameters.Add("@ZONA", SqlDbType.NChar).Value = Zona
            comando.Parameters.Add("@EMPTRANSPORTADORA", SqlDbType.NChar).Value = EmpTransportadora
            comando.Parameters.Add("@MANIFIESTO", SqlDbType.NChar).Value = Manifiesto

            '------ Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------
            Dim Consulta As SqlDataReader
            Consulta = comando.ExecuteReader

            Return Consulta

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return Nothing
        End Try
        Conn.Close()

    End Function

    Public Function GuardarDespacho()

        Try

            Dim comando As New SqlClient.SqlCommand("sp_DespachosGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@CLIENTE", SqlDbType.Int).Value = Cliente
            comando.Parameters.Add("@ORIGEN", SqlDbType.NChar).Value = Origen
            comando.Parameters.Add("@DESTINO", SqlDbType.NChar).Value = Destino
            comando.Parameters.Add("@FECHA", SqlDbType.NChar).Value = Fecha
            comando.Parameters.Add("@ZONA", SqlDbType.Int).Value = Zona
            comando.Parameters.Add("@TIPODESPACHO", SqlDbType.Int).Value = TipoDespacho
            comando.Parameters.Add("@TIPOVEHICULO", SqlDbType.Int).Value = TipoVehiculo
            comando.Parameters.Add("@PLACA", SqlDbType.NChar).Value = Placa
            comando.Parameters.Add("@TRANSPORTADOR", SqlDbType.NChar).Value = Transportador
            comando.Parameters.Add("@REMESA", SqlDbType.NChar).Value = Remesa
            comando.Parameters.Add("@MANIFIESTO", SqlDbType.NChar).Value = Manifiesto
            comando.Parameters.Add("@CECO", SqlDbType.NChar).Value = Ceco
            comando.Parameters.Add("@REMISION", SqlDbType.NChar).Value = Remision
            comando.Parameters.Add("@FACTURA", SqlDbType.NChar).Value = Factura
            comando.Parameters.Add("@VALORDECLARADO", SqlDbType.Int).Value = Valor
            comando.Parameters.Add("@PRODUCTO", SqlDbType.NChar).Value = Producto
            comando.Parameters.Add("@COSTO", SqlDbType.Int).Value = Costo
            comando.Parameters.Add("@CARGUEDESCARGUE", SqlDbType.NChar).Value = CargueDescargue
            comando.Parameters.Add("@COSTOTRANSPORTE", SqlDbType.NChar).Value = CostoTransporte
            comando.Parameters.Add("@VALORTONELADA", SqlDbType.Decimal).Value = ValorTonelada
            comando.Parameters.Add("@PESOCARGA", SqlDbType.Decimal).Value = PesoCarga
            comando.Parameters.Add("@VALORCLIENTE", SqlDbType.NChar).Value = ValorCliente
            comando.Parameters.Add("@OTROSCOBROS", SqlDbType.NChar).Value = OtrosCobros
            comando.Parameters.Add("@UTILIDAD", SqlDbType.NChar).Value = Utilidad
            comando.Parameters.Add("@MARGEN", SqlDbType.Decimal).Value = Margen
            comando.Parameters.Add("@OBSERVACION", SqlDbType.NChar).Value = Observacion
            comando.Parameters.Add("@PC", SqlDbType.NChar).Value = Environment.MachineName
            comando.Parameters.Add("@USUARIOAPP", SqlDbType.NChar).Value = Globales.UsuarioApp.Documento

            '----------------------Envio el Datagrid de los Otros Costos ------------------

            Dim ArchivoTemp1 As String = ""

            For i = 0 To OtrosCobrosDetalle.Rows.Count - 1

                Dim xIdCobro As Integer = OtrosCobrosDetalle.Rows(i).Cells(1).Value
                Dim xValor As Decimal = Trim(OtrosCobrosDetalle.Rows(i).Cells(3).Value)


                ArchivoTemp1 = ArchivoTemp1 & "<DETALLE NUMDESPACHO=''  
                                                        IDCOBRO='" & xIdCobro & "'
                                                        VALOR='" & xValor & "'
                                                   />"
            Next

            Dim XMLCobros = "<?xml version='1.0'?><COBROS>" & ArchivoTemp1 & "</COBROS>"

            comando.Parameters.Add("@COBROSXML", SqlDbType.NChar).Value = XMLCobros
            '------------------------------------------------------------------------------

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
    Public Function ActualizarDespacho() As String

        Try

            Dim comando As New SqlClient.SqlCommand("sp_DespachosActualizar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@NUMDESPACHO", SqlDbType.NChar).Value = NumDespacho
            comando.Parameters.Add("@CLIENTE", SqlDbType.Int).Value = Cliente
            comando.Parameters.Add("@ORIGEN", SqlDbType.NChar).Value = Origen
            comando.Parameters.Add("@DESTINO", SqlDbType.NChar).Value = Destino
            comando.Parameters.Add("@FECHA", SqlDbType.NChar).Value = Fecha
            comando.Parameters.Add("@ZONA", SqlDbType.Int).Value = Zona
            comando.Parameters.Add("@TIPODESPACHO", SqlDbType.Int).Value = TipoDespacho
            comando.Parameters.Add("@TIPOVEHICULO", SqlDbType.Int).Value = TipoVehiculo
            comando.Parameters.Add("@PLACA", SqlDbType.NChar).Value = Placa
            comando.Parameters.Add("@TRANSPORTADOR", SqlDbType.NChar).Value = Transportador
            comando.Parameters.Add("@REMESA", SqlDbType.NChar).Value = Remesa
            comando.Parameters.Add("@MANIFIESTO", SqlDbType.NChar).Value = Manifiesto
            comando.Parameters.Add("@CECO", SqlDbType.NChar).Value = Ceco
            comando.Parameters.Add("@REMISION", SqlDbType.NChar).Value = Remision
            comando.Parameters.Add("@FACTURA", SqlDbType.NChar).Value = Factura
            comando.Parameters.Add("@VALORDECLARADO", SqlDbType.Int).Value = Valor
            comando.Parameters.Add("@PRODUCTO", SqlDbType.NChar).Value = Producto
            comando.Parameters.Add("@COSTO", SqlDbType.Int).Value = Costo
            comando.Parameters.Add("@CARGUEDESCARGUE", SqlDbType.NChar).Value = CargueDescargue
            comando.Parameters.Add("@COSTOTRANSPORTE", SqlDbType.NChar).Value = CostoTransporte
            comando.Parameters.Add("@VALORTONELADA", SqlDbType.Decimal).Value = ValorTonelada
            comando.Parameters.Add("@PESOCARGA", SqlDbType.Decimal).Value = PesoCarga
            comando.Parameters.Add("@VALORCLIENTE", SqlDbType.NChar).Value = ValorCliente
            comando.Parameters.Add("@OTROSCOBROS", SqlDbType.NChar).Value = OtrosCobros
            comando.Parameters.Add("@UTILIDAD", SqlDbType.NChar).Value = Utilidad
            comando.Parameters.Add("@MARGEN", SqlDbType.Decimal).Value = Margen
            comando.Parameters.Add("@OBSERVACION", SqlDbType.NChar).Value = Observacion
            comando.Parameters.Add("@PC", SqlDbType.NChar).Value = Environment.MachineName
            comando.Parameters.Add("@USUARIOAPP", SqlDbType.NChar).Value = Globales.UsuarioApp.Documento

            '----------------------Envio el Datagrid de los Otros Costos ------------------

            Dim ArchivoTemp1 As String = ""

            For i = 0 To OtrosCobrosDetalle.Rows.Count - 1

                Dim xIdCobro As Integer = OtrosCobrosDetalle.Rows(i).Cells(1).Value
                Dim xValor As Decimal = Trim(OtrosCobrosDetalle.Rows(i).Cells(3).Value)


                ArchivoTemp1 = ArchivoTemp1 & "<DETALLE NUMDESPACHO='" & NumDespacho & "'  
                                                        IDCOBRO='" & xIdCobro & "'
                                                        VALOR='" & xValor & "'
                                                   />"
            Next

            Dim XMLCobros = "<?xml version='1.0'?><COBROS>" & ArchivoTemp1 & "</COBROS>"

            comando.Parameters.Add("@COBROSXML", SqlDbType.NChar).Value = XMLCobros
            '------------------------------------------------------------------------------


            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            comando.ExecuteScalar()

            If comando.Parameters("@Resultado").Value = "OK" Then
                Return "OK"
            Else
                Return comando.Parameters("@Resultado").Value
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return False
        End Try

        Conn.Close()

    End Function
    Public Function ConsultarDespacho(Accion, Numdespacho) As SqlDataReader

        Try


            Dim comando As New SqlClient.SqlCommand("sp_DespachosListar", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            comando.Parameters.Add("@CONSULTA", SqlDbType.Int).Value = Accion
            comando.Parameters.Add("@NUMDESPACHO", SqlDbType.NChar).Value = Numdespacho

            '------ Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------
            Dim Consulta As SqlDataReader
            Consulta = comando.ExecuteReader

            Return Consulta

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return Nothing
        End Try
        Conn.Close()

    End Function
    Public Function ConsultarFecha(Fecha As Date) As SqlDataReader

        Try

            Dim Ultimodíames As Date = New DateTime(Fecha.Year, Fecha.Month, DateTime.DaysInMonth(Fecha.Year, Fecha.Month)) ' Ultimo dia del mes del despacho

            Dim comando As New SqlClient.SqlCommand("sp_DiasConsultar", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 1 ' Dias Laborales No Festivos ni fin de semana
            comando.Parameters.Add("@ULTIMODIAMES", SqlDbType.NChar).Value = Format(Ultimodíames, "yyyy-MM-dd")

            '------ Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------
            Dim Consulta As SqlDataReader
            Consulta = comando.ExecuteReader

            Return Consulta

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return Nothing
        End Try
        Conn.Close()

    End Function
    Public Function ConsultaHistorico(Accion, Desde, Hasta) As SqlDataReader

        Try

            Dim comando As New SqlClient.SqlCommand("sp_DespachosConsultar", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            comando.Parameters.Add("@CONSULTA", SqlDbType.Int).Value = Accion
            comando.Parameters.Add("@DESDE", SqlDbType.NChar).Value = Desde
            comando.Parameters.Add("@HASTA", SqlDbType.NChar).Value = Hasta


            '------ Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------
            Dim Consulta As SqlDataReader
            Consulta = comando.ExecuteReader

            Return Consulta

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return Nothing
        End Try
        Conn.Close()

    End Function
    Public Function ListarCobros() As SqlDataReader

        Try
            Dim comando As New SqlClient.SqlCommand("sp_DespachosConsultar", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            '------ Variable que recibe el Resultado ----------
            comando.Parameters.Add("@CONSULTA", SqlDbType.Int).Value = 7
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
    Public Function DetalleCobros(Accion, NumDespacho) As SqlDataReader

        Try
            Dim comando As New SqlClient.SqlCommand("sp_DespachosConsultar", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            '------ Variable que recibe el Resultado ----------
            comando.Parameters.Add("@CONSULTA", SqlDbType.Int).Value = Accion
            comando.Parameters.Add("@NUMDESPACHO", SqlDbType.NChar).Value = NumDespacho
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
