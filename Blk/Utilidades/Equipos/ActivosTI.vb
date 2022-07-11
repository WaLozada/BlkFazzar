Imports System.Data.SqlClient

Public Class ActivosTI

    '*************** Atributos **************************
    Private _IdActivo As String
    Private _Tipo As String
    Private _Marca As String
    Private _Modelo As String
    Private _Serial As String
    Private _Estado As String
    Private _FechaFactura As String
    Private _NumFactura As String
    Private _Proveedor As String
    Private _Observaciones As String
    Private _Caracteristicas As DataGridView
    Private _Ciudad As String
    Private _Lugar As String
    Private _Area As String
    Private _Responsable As String
    Private _TipoMto As String
    Private _Realizadopor As String
    Private _FechaMto As String
    Private _Repuestos As DataGridView


    '***************** Propiedades **********************
    Public Property IdActivo As String
        Get
            Return _IdActivo
        End Get
        Set(value As String)
            _IdActivo = value
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
    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(value As String)
            _Marca = value
        End Set
    End Property
    Public Property Modelo As String
        Get
            Return _Modelo
        End Get
        Set(value As String)
            _Modelo = value
        End Set
    End Property
    Public Property Serial As String
        Get
            Return _Serial
        End Get
        Set(value As String)
            _Serial = value
        End Set
    End Property
    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property
    Public Property FechaFactura As String
        Get
            Return _FechaFactura
        End Get
        Set(value As String)
            _FechaFactura = value
        End Set
    End Property
    Public Property NumFactura As String
        Get
            Return _NumFactura
        End Get
        Set(value As String)
            _NumFactura = value
        End Set
    End Property
    Public Property Proveedor As String
        Get
            Return _Proveedor
        End Get
        Set(value As String)
            _Proveedor = value
        End Set
    End Property
    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(value As String)
            _Observaciones = value
        End Set
    End Property
    Public Property Caracteristicas As DataGridView
        Get
            Return _Caracteristicas
        End Get
        Set(value As DataGridView)
            _Caracteristicas = value
        End Set
    End Property
    Public Property Ciudad As String
        Get
            Return _Ciudad
        End Get
        Set(value As String)
            _Ciudad = value
        End Set
    End Property
    Public Property Lugar As String
        Get
            Return _Lugar
        End Get
        Set(value As String)
            _Lugar = value
        End Set
    End Property
    Public Property Area As String
        Get
            Return _Area
        End Get
        Set(value As String)
            _Area = value
        End Set
    End Property
    Public Property Repuestos As DataGridView
        Get
            Return _Repuestos
        End Get
        Set(value As DataGridView)
            _Repuestos = value
        End Set
    End Property
    Public Property Responsable As String
        Get
            Return _Responsable
        End Get
        Set(value As String)
            _Responsable = value
        End Set
    End Property
    Public Property TipoMto As String
        Get
            Return _TipoMto
        End Get
        Set(value As String)
            _TipoMto = value
        End Set
    End Property
    Public Property Realizadopor As String
        Get
            Return _Realizadopor
        End Get
        Set(value As String)
            _Realizadopor = value
        End Set
    End Property
    Public Property FechaMto As String
        Get
            Return _FechaMto
        End Get
        Set(value As String)
            _FechaMto = value
        End Set
    End Property

    ' '***************** Metodos ***********************
    Public Function ListarTipos() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ActivosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 1 ' Listar Tipos

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarMarcas() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ActivosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 2 ' Listar Marcas

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarModelos(Marca, tipo) As SqlDataReader

        Try

            Dim comando As New SqlClient.SqlCommand("sp_ActivosListar", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 3 ' Listar Modelos
            comando.Parameters.Add("@MARCA", SqlDbType.NChar).Value = Marca
            comando.Parameters.Add("@IDTIPO", SqlDbType.NChar).Value = tipo

            '------ Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------
            Dim Consulta As SqlDataReader

            Consulta = comando.ExecuteReader
            Return Consulta
            Conn.Close()

        Catch ex As Exception
            Return Nothing
        End Try


    End Function
    Public Function ListarCaracteristicas(Tipo) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ActivosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 4 ' Listar Caracteristicas
        comando.Parameters.Add("@TIPO", SqlDbType.NChar).Value = Tipo ' Listar Marcas

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarCaracteristicas(IdActivo, Accion, Idtipo)

        Dim comando As New SqlClient.SqlCommand("sp_ActivosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = Accion ' 12 Caracteristicas , 13 Software
        comando.Parameters.Add("@IDACTIVO", SqlDbType.NChar).Value = IdActivo
        comando.Parameters.Add("@IDTIPO", SqlDbType.NChar).Value = Idtipo

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarDetalles(Grupo, tipo) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ActivosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 5 ' Listar Detalles
        comando.Parameters.Add("@IDGRUPO", SqlDbType.NChar).Value = Grupo ' Listar Marcas
        comando.Parameters.Add("@TIPO", SqlDbType.NChar).Value = tipo ' Listar Marcas

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarProveedores() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_CentrosListar", Conn)
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
    Public Function GuardarModelo(NombreModelo)

        Try
            Dim comando As New SqlClient.SqlCommand("sp_ActivosModeloGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@IDMARCA", SqlDbType.NChar).Value = Marca
            comando.Parameters.Add("@MODELO", SqlDbType.NChar).Value = NombreModelo
            comando.Parameters.Add("@IDTIPO", SqlDbType.NChar).Value = Tipo

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
    Public Function GuardarActivo()

        Try
            Dim comando As New SqlClient.SqlCommand("sp_ActivosGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@TIPO", SqlDbType.NChar).Value = Tipo
            comando.Parameters.Add("@MARCA", SqlDbType.NChar).Value = Marca
            comando.Parameters.Add("@MODELO", SqlDbType.NChar).Value = Modelo
            comando.Parameters.Add("@SERIAL", SqlDbType.NChar).Value = Serial
            comando.Parameters.Add("@ESTADO", SqlDbType.NChar).Value = Estado
            comando.Parameters.Add("@FECHAFACTURA", SqlDbType.NChar).Value = FechaFactura
            comando.Parameters.Add("@FACTURA", SqlDbType.NChar).Value = NumFactura
            comando.Parameters.Add("@PROVEEDOR", SqlDbType.NChar).Value = Proveedor
            comando.Parameters.Add("@OBSERVACIONES", SqlDbType.NChar).Value = Observaciones
            comando.Parameters.Add("@CIUDAD", SqlDbType.NChar).Value = Ciudad
            comando.Parameters.Add("@LUGAR", SqlDbType.NChar).Value = Lugar
            comando.Parameters.Add("@AREA", SqlDbType.NChar).Value = Area
            comando.Parameters.Add("@RESPONSABLE", SqlDbType.NChar).Value = Responsable

            '----------------------Envio el Datagrid de las Caracteristicas ------------------

            Dim ArchivoTemp1 As String = ""

            With Caracteristicas
                For i = 0 To .Rows.Count - 1
                    ArchivoTemp1 = ArchivoTemp1 & "<DETALLE IDACTIVO=''  
                                                            IDCARACTERISTICA='" & Trim(.Rows(i).Cells(0).Value) & "'
                                                            IDDETALLE='" & Trim(.Rows(i).Cells(2).Value) & "'
                                                   />"
                Next
            End With

            Dim XMLProductos = "<?xml version='1.0'?><CARACTERISTICAS>" & ArchivoTemp1 & "</CARACTERISTICAS>"

            comando.Parameters.Add("@CARACTERISTICASXML", SqlDbType.NChar).Value = XMLProductos
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
    Public Function GuardarMantenimiento()

        Try
            Dim comando As New SqlClient.SqlCommand("sp_ActivosMtoGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@IDACTIVO", SqlDbType.NChar).Value = IdActivo
            comando.Parameters.Add("@TIPOMTO", SqlDbType.NChar).Value = TipoMto
            comando.Parameters.Add("@REALIZADOPOR", SqlDbType.NChar).Value = Realizadopor
            comando.Parameters.Add("@RESPONSABLE", SqlDbType.NChar).Value = Responsable
            comando.Parameters.Add("@FECHAMTO", SqlDbType.NChar).Value = FechaMto
            comando.Parameters.Add("@OBSERVACIONES", SqlDbType.NChar).Value = Observaciones

            '----------------------Envio el Datagrid de los Repuestos ------------------

            If Repuestos.Rows.Count > 0 Then ' Si se ingresaron repuestos en el mantenimiento.

                Dim ArchivoTemp1 As String = ""

                With Repuestos
                    For i = 0 To .Rows.Count - 1
                        ArchivoTemp1 = ArchivoTemp1 & "<DETALLE IDACTIVO='" & IdActivo & "'  
                                                            IDMTO =''
                                                            IDREPUESTO='" & Trim(.Rows(i).Cells(0).Value) & "'
                                                            COSTO='" & Trim(.Rows(i).Cells(3).Value) & "'
                                                            DESCRIPCION='" & Trim(.Rows(i).Cells(4).Value) & "'
                                                            FECHAMTO='" & FechaMto & "'
                                                   />"
                    Next
                End With

                Dim XMLProductos = "<?xml version='1.0'?><REPUESTOS>" & ArchivoTemp1 & "</REPUESTOS>"
                comando.Parameters.Add("@REPUESTOSXML", SqlDbType.NChar).Value = XMLProductos
                comando.Parameters.Add("@USOREPUESTOS", SqlDbType.NChar).Value = "SI"
            Else
                comando.Parameters.Add("@REPUESTOSXML", SqlDbType.NChar).Value = ""
                comando.Parameters.Add("@USOREPUESTOS", SqlDbType.NChar).Value = "NO"
            End If

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
    Public Function ListarActivos()

        Dim comando As New SqlClient.SqlCommand("sp_ActivosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 6 ' Listar Activos totales

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarActivos(Tipo)

        Dim comando As New SqlClient.SqlCommand("sp_ActivosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 7 ' Listar Activos por Tipo
        comando.Parameters.Add("@TIPO", SqlDbType.NChar).Value = Tipo

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarActivosxCondicion(Accion, Valor)

        Dim comando As New SqlClient.SqlCommand("sp_ActivosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = Accion

        If Accion = 14 Then ' Consulta por Area (14)
            comando.Parameters.Add("@IDLUGAR", SqlDbType.NChar).Value = Valor
        Else ' Consulta por Reponsable (15)
            comando.Parameters.Add("@IDEMPLEADO", SqlDbType.NChar).Value = Valor
        End If

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------
            Dim Consulta As SqlDataReader

            Consulta = comando.ExecuteReader
            Return Consulta
            Conn.Close()

    End Function
    Public Function ListarMantenimientos(IdActivo)

        Dim comando As New SqlClient.SqlCommand("sp_ActivosMtoListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 1
        comando.Parameters.Add("@IDACTIVO", SqlDbType.NChar).Value = IdActivo

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarMantenimientos(IdActivo, IdMto)

        Dim comando As New SqlClient.SqlCommand("sp_ActivosMtoListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 2
        comando.Parameters.Add("@IDACTIVO", SqlDbType.NChar).Value = IdActivo
        comando.Parameters.Add("@IDMTO", SqlDbType.NChar).Value = IdMto

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarEquipo(Campo, Valor)

        Dim comando As New SqlClient.SqlCommand("sp_ActivosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        If Campo = "ACTIVO" Then
            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 8 ' Listar Activos por Tipo
            comando.Parameters.Add("@IDACTIVO", SqlDbType.NChar).Value = Valor
        Else
            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 9 ' Listar Activos por Tipo
            comando.Parameters.Add("@SERIAL", SqlDbType.NChar).Value = Valor
        End If

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarComputadores()

        Dim comando As New SqlClient.SqlCommand("sp_ActivosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 11 ' Listar Activos (Portatiles y PC)

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function

    Public Function ListarBajas()

        Dim comando As New SqlClient.SqlCommand("sp_ActivosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 10 ' Listar Activos dados de baja

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function GuardarBaja(IdActivo, Motivo, Observacion)

        Try
            Dim comando As New SqlClient.SqlCommand("sp_ActivosBajaGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@IDACTIVO", SqlDbType.NChar).Value = IdActivo
            comando.Parameters.Add("@MOTIVO", SqlDbType.NChar).Value = Motivo
            comando.Parameters.Add("@OBSERVACION", SqlDbType.NChar).Value = Observacion
            comando.Parameters.Add("@USUARIOAPP", SqlDbType.NChar).Value = UsuarioApp.Documento

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
    Public Function GuardarMovimiento()

        Try
            Dim comando As New SqlClient.SqlCommand("sp_ActivosMovimientos", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@IDACTIVO", SqlDbType.NChar).Value = IdActivo
            comando.Parameters.Add("@CIUDAD", SqlDbType.NChar).Value = Ciudad
            comando.Parameters.Add("@LUGAR", SqlDbType.NChar).Value = Lugar
            comando.Parameters.Add("@AREA", SqlDbType.NChar).Value = Area
            comando.Parameters.Add("@RESPONSABLE", SqlDbType.NChar).Value = Responsable
            comando.Parameters.Add("@USUARIOAPP", SqlDbType.NChar).Value = UsuarioApp.Documento

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
