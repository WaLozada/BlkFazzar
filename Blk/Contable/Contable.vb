Imports System.Data.SqlClient

Public Class Contable
    '*************** Atributos **************************
    Private _Codigo As String
    Private _NumFac As String
    Private _IdProveedor As String
    Private _Proveedor As String
    Private _Concepto As String
    Private _FechaExp As Date
    Private _FechaRec As Date
    Private _FechaVen As Date
    Private _Subtotal As Decimal
    Private _Iva As Decimal
    Private _Total As Decimal
    Private _Proyecto As String
    Private _CentroCosto As String
    Private _ValorCC As Decimal
    Private _Observaciones As String
    Private _RutaFactura As String
    Private _FechaRegistro As Date
    Private _UsuarioRegistro As String
    Private _PcRegistro As String
    Private _Contabilizacion As String
    Private _Comentario As String
    Private _FechaContable As Date
    Private _UsuarioContable As String
    Private _PcContable As String
    Private _RutaOrden As String
    Private _Aprobacion As String
    Private _Aprobador As String
    Private _Presupuesto As String
    Private _FechaAprobacion As Date
    Private _UsuarioAprobacion As String
    Private _PcAprobacion As String

    '***************** Propiedades ***********************
    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
        End Set
    End Property
    Public Property NumFac As String
        Get
            Return _NumFac
        End Get
        Set(value As String)
            _NumFac = value
        End Set
    End Property
    Public Property IdProveedor As String
        Get
            Return _IdProveedor
        End Get
        Set(value As String)
            _IdProveedor = value
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
    Public Property Concepto As String
        Get
            Return _Concepto
        End Get
        Set(value As String)
            _Concepto = value
        End Set
    End Property
    Public Property FechaExp As String
        Get
            Return _FechaExp
        End Get
        Set(value As String)
            _FechaExp = value
        End Set
    End Property
    Public Property FechaRec As String
        Get
            Return _FechaRec
        End Get
        Set(value As String)
            _FechaRec = value
        End Set
    End Property
    Public Property FechaVen As String
        Get
            Return _FechaVen
        End Get
        Set(value As String)
            _FechaVen = value
        End Set
    End Property
    Public Property Subtotal As String
        Get
            Return _Subtotal
        End Get
        Set(value As String)
            _Subtotal = value
        End Set
    End Property
    Public Property Iva As String
        Get
            Return _Iva
        End Get
        Set(value As String)
            _Iva = value
        End Set
    End Property
    Public Property Total As String
        Get
            Return _Total
        End Get
        Set(value As String)
            _Total = value
        End Set
    End Property
    Public Property Proyecto As String
        Get
            Return _Proyecto
        End Get
        Set(value As String)
            _Proyecto = value
        End Set
    End Property
    Public Property CentroCosto As String
        Get
            Return _CentroCosto
        End Get
        Set(value As String)
            _CentroCosto = value
        End Set
    End Property
    Public Property ValorCC As String
        Get
            Return _ValorCC
        End Get
        Set(value As String)
            _ValorCC = value
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
    Public Property RutaFactura As String
        Get
            Return _RutaFactura
        End Get
        Set(value As String)
            _RutaFactura = value
        End Set
    End Property
    Public Property FechaRegistro As String
        Get
            Return _FechaRegistro
        End Get
        Set(value As String)
            _FechaRegistro = value
        End Set
    End Property
    Public Property UsuarioRegistro As String
        Get
            Return _UsuarioRegistro
        End Get
        Set(value As String)
            _UsuarioRegistro = value
        End Set
    End Property
    Public Property PcRegistro As String
        Get
            Return _PcRegistro
        End Get
        Set(value As String)
            _PcRegistro = value
        End Set
    End Property
    Public Property Contabilizacion As String
        Get
            Return _Contabilizacion
        End Get
        Set(value As String)
            _Contabilizacion = value
        End Set
    End Property
    Public Property Comentario As String
        Get
            Return _Comentario
        End Get
        Set(value As String)
            _Comentario = value
        End Set
    End Property
    Public Property FechaContable As String
        Get
            Return _FechaContable
        End Get
        Set(value As String)
            _FechaContable = value
        End Set
    End Property
    Public Property UsuarioContable As String
        Get
            Return _UsuarioContable
        End Get
        Set(value As String)
            _UsuarioContable = value
        End Set
    End Property
    Public Property PcContable As String
        Get
            Return _PcContable
        End Get
        Set(value As String)
            _PcContable = value
        End Set
    End Property
    Public Property RutaOrden As String
        Get
            Return _RutaOrden
        End Get
        Set(value As String)
            _RutaOrden = value
        End Set
    End Property
    Public Property Aprobacion As String
        Get
            Return _Aprobacion
        End Get
        Set(value As String)
            _Aprobacion = value
        End Set
    End Property
    Public Property Aprobador As String
        Get
            Return _Aprobador
        End Get
        Set(value As String)
            _Aprobador = value
        End Set
    End Property
    Public Property Presupuesto As String
        Get
            Return _Presupuesto
        End Get
        Set(value As String)
            _Presupuesto = value
        End Set
    End Property
    Public Property FechaAprobacion As String
        Get
            Return _FechaAprobacion
        End Get
        Set(value As String)
            _FechaAprobacion = value
        End Set
    End Property
    Public Property UsuarioAprobacion As String
        Get
            Return _UsuarioAprobacion
        End Get
        Set(value As String)
            _UsuarioAprobacion = value
        End Set
    End Property
    Public Property PcAprobacion As String
        Get
            Return _PcAprobacion
        End Get
        Set(value As String)
            _PcAprobacion = value
        End Set
    End Property

    ' '***************** Metodos ***********************
    Public Function GuardarFactura() As String

        Try

            Dim comando As New SqlClient.SqlCommand("sp_FContableGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@NUMFAC", SqlDbType.NChar).Value = NumFac
            comando.Parameters.Add("@IDPROVEEDOR", SqlDbType.NChar).Value = IdProveedor
            comando.Parameters.Add("@CONCEPTO", SqlDbType.NChar).Value = Concepto
            comando.Parameters.Add("@FECHAEXP", SqlDbType.Date).Value = FechaExp
            comando.Parameters.Add("@FECHAREC", SqlDbType.Date).Value = FechaRec
            comando.Parameters.Add("@FECHAVEN", SqlDbType.Date).Value = FechaVen
            comando.Parameters.Add("@SUBTOTAL", SqlDbType.Decimal).Value = Subtotal
            comando.Parameters.Add("@IVA", SqlDbType.Decimal).Value = Iva
            comando.Parameters.Add("@TOTAL", SqlDbType.Decimal).Value = Total
            comando.Parameters.Add("@PROYECTO", SqlDbType.NChar).Value = Proyecto
            comando.Parameters.Add("@CENTROCOSTO", SqlDbType.NChar).Value = CentroCosto
            comando.Parameters.Add("@VALORCC", SqlDbType.Decimal).Value = ValorCC
            comando.Parameters.Add("@OBSERVACIONES", SqlDbType.NChar).Value = Observaciones
            comando.Parameters.Add("@RUTAFACTURA", SqlDbType.NChar).Value = RutaFactura
            comando.Parameters.Add("@USUARIOREGISTRO", SqlDbType.NChar).Value = UsuarioRegistro
            comando.Parameters.Add("@PCREGISTRO", SqlDbType.NChar).Value = PcRegistro
            comando.Parameters.Add("@APROBACION", SqlDbType.NChar).Value = Aprobacion
            comando.Parameters.Add("@APROBADOR", SqlDbType.NChar).Value = Aprobador

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            comando.ExecuteScalar()

            Return comando.Parameters("@Resultado").Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return False
        End Try

        Conn.Close()

    End Function

    Public Function GuardarContabilizacion() As String

        Try

            Dim comando As New SqlClient.SqlCommand("sp_FContableGuardarWO", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo
            comando.Parameters.Add("@NUMFAC", SqlDbType.NChar).Value = NumFac
            comando.Parameters.Add("@CONTABILIZACION", SqlDbType.NChar).Value = Contabilizacion
            comando.Parameters.Add("@COMENTARIO", SqlDbType.NChar).Value = Comentario
            comando.Parameters.Add("@USUARIOCONTABLE", SqlDbType.NChar).Value = UsuarioContable
            comando.Parameters.Add("@PCCONTABLE", SqlDbType.NChar).Value = PcContable


            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            comando.ExecuteScalar()

            Return comando.Parameters("@Resultado").Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return False
        End Try

        Conn.Close()

    End Function
    Public Function ActualizarContabilizacion(OldContabilizacion, oldComentario) As String

        Try

            Dim comando As New SqlClient.SqlCommand("sp_FContableActualizarWO", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo
            comando.Parameters.Add("@NUMFAC", SqlDbType.NChar).Value = NumFac
            comando.Parameters.Add("@OLDCONTABILIZACION", SqlDbType.NChar).Value = OldContabilizacion
            comando.Parameters.Add("@OLDCOMENTARIO", SqlDbType.NChar).Value = oldComentario
            comando.Parameters.Add("@CONTABILIZACION", SqlDbType.NChar).Value = Contabilizacion
            comando.Parameters.Add("@COMENTARIO", SqlDbType.NChar).Value = Comentario
            comando.Parameters.Add("@FECHACONTABLE", SqlDbType.DateTime).Value = FechaContable
            comando.Parameters.Add("@USUARIOCONTABLE", SqlDbType.NChar).Value = UsuarioContable
            comando.Parameters.Add("@PCCONTABLE", SqlDbType.NChar).Value = PcContable

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            comando.ExecuteScalar()

            Return comando.Parameters("@Resultado").Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return False
        End Try

        Conn.Close()

    End Function
    Public Function ListarFacturas(Desde, Hasta, Aprobacion) As SqlDataReader

        Try

            Dim comando As New SqlClient.SqlCommand("sp_FContableListar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@DESDE", SqlDbType.NChar).Value = Format(Desde, "yyyy-MM-dd HH:mm:ss")
            comando.Parameters.Add("@HASTA", SqlDbType.NChar).Value = Format(Hasta, "yyyy-MM-dd HH:mm:ss")
            If Aprobacion = "" Then
                comando.Parameters.Add("@CONSULTA", SqlDbType.NChar).Value = 1
            Else
                comando.Parameters.Add("@CONSULTA", SqlDbType.NChar).Value = 2
                comando.Parameters.Add("@APROBACION", SqlDbType.NChar).Value = Aprobacion
            End If

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()

            Return comando.ExecuteReader

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return Nothing
        End Try

        Conn.Close()

    End Function
    Public Function ListarFacturasAprobador(Aprobador) As SqlDataReader

        Try

            Dim comando As New SqlClient.SqlCommand("sp_FContableListar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@CONSULTA", SqlDbType.NChar).Value = 3
            comando.Parameters.Add("@APROBADOR", SqlDbType.NChar).Value = Aprobador

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()

            Return comando.ExecuteReader

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return Nothing
        End Try

        Conn.Close()

    End Function

    Public Function GuardarAprobacion() As String

        Try

            Dim comando As New SqlClient.SqlCommand("sp_FContableGuardarAprob", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo
            comando.Parameters.Add("@NUMFAC", SqlDbType.NChar).Value = NumFac
            comando.Parameters.Add("@PRESUPUESTO", SqlDbType.NChar).Value = Presupuesto
            comando.Parameters.Add("@APROBACION", SqlDbType.NChar).Value = Aprobacion
            comando.Parameters.Add("@USUARIOAPROBACION", SqlDbType.NChar).Value = UsuarioAprobacion
            comando.Parameters.Add("@PCAPROBACION", SqlDbType.NChar).Value = PcAprobacion

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            comando.ExecuteScalar()

            Return comando.Parameters("@Resultado").Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return False
        End Try

        Conn.Close()

    End Function

End Class
