Imports System.Data.SqlClient

Public Class Depositos

    '*************** Atributos **************************
    Private _IdDeposito As String
    Private _CodigoCentro As String
    Private _Centro As String
    Private _CodigoBodega As String
    Private _Bodega As String
    Private _Codigo As String
    Private _CodigoCliente As String
    Private _Cliente As String
    Private _Estado As String
    Private _Visible As String
    Private _Id As String

    '***************** Propiedades **********************
    Public Property IdDeposito As String
        Get
            Return _IdDeposito
        End Get
        Set(value As String)
            _IdDeposito = value
        End Set
    End Property
    Public Property CodigoCentro As String
        Get
            Return _CodigoCentro
        End Get
        Set(value As String)
            _CodigoCentro = value
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
    Public Property CodigoBodega As String
        Get
            Return _CodigoBodega
        End Get
        Set(value As String)
            _CodigoBodega = value
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
    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
        End Set
    End Property
    Public Property CodigoCliente As String
        Get
            Return _CodigoCliente
        End Get
        Set(value As String)
            _CodigoCliente = value
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
    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property
    Public Property Visible As String
        Get
            Return _Visible
        End Get
        Set(value As String)
            _Visible = value
        End Set
    End Property
    Public Property Id As String
        Get
            Return _Id
        End Get
        Set(value As String)
            _Id = value
        End Set
    End Property

    ' '***************** Metodos ***********************
    Public Function GuardarDeposito() As Boolean

        Try

            Dim comando As New SqlClient.SqlCommand("sp_DepositosGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@CODIGOCENTRO", SqlDbType.NChar).Value = CodigoCentro
            comando.Parameters.Add("@CODIGOBODEGA", SqlDbType.NChar).Value = CodigoBodega
            comando.Parameters.Add("@CODIGOCLIENTE", SqlDbType.NChar).Value = CodigoCliente
            comando.Parameters.Add("@ESTADO", SqlDbType.NChar).Value = Estado
            comando.Parameters.Add("@VISIBLE", SqlDbType.NChar).Value = 1

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            comando.ExecuteScalar()

            ' Si Todo Bien = OK
            ' Si todo Mal = Mensaje de error
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
    Public Function ActualizarDeposito() As Boolean

        Try
            Dim comando As New SqlClient.SqlCommand("sp_DepositosActualizar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo
            comando.Parameters.Add("@CODIGOCENTRO", SqlDbType.NChar).Value = CodigoCentro
            comando.Parameters.Add("@CODIGOBODEGA", SqlDbType.NChar).Value = CodigoBodega
            comando.Parameters.Add("@CODIGOCLIENTE", SqlDbType.NChar).Value = CodigoCliente
            comando.Parameters.Add("@ESTADO", SqlDbType.NChar).Value = Estado


            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            comando.ExecuteScalar()

            ' Si Todo Bien = OK
            ' Si todo Mal = Mensaje de error
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
    Public Function ListarDepositos() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_DepositosListar", Conn)
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
    Public Function BorrarDeposito(Codigo) As Boolean


        Try
            Dim comando As New SqlClient.SqlCommand("sp_DepositosBorrar", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo

            '------ Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
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
    Public Sub CargarCombos()

        '-------------- Cargo Combo Tipo Estado -------------
        Dim Sql2 As String = "select * from Gen_TipoEstado"
        Dim da2 As New SqlDataAdapter(Sql2, Conn)
        Dim dt2 As New DataTable
        da2.Fill(dt2)

        For_Depositos.CmbEstado.DisplayMember = "ESTADO"
        For_Depositos.CmbEstado.ValueMember = "IDESTADO"
        For_Depositos.CmbEstado.DataSource = dt2
        '-----------------------------------------------------

        '--------------- Listar Centros ----------------------
        Try
            For_Depositos.CmbCentros.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Centros.ListarCentro

            Tabla.Load(Consulta)

            For_Depositos.CmbCentros.DisplayMember = "NOMBRE"
            For_Depositos.CmbCentros.ValueMember = "CODIGO"
            For_Depositos.CmbCentros.DataSource = Tabla

            For_Depositos.CmbCentros.Text = ""

            Consulta.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try
        '-------------------------------------------------------


    End Sub
    Public Sub CargarBodegas(CodigoCentro)

        '--------------- Listar Bodegas de Un Centro ----------------------
        Try
            For_Depositos.CmbBodegas.DataSource = Nothing

            Dim Bodega As New Bodegas()
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Bodega.ListarBodegas(CodigoCentro)

            Tabla.Load(Consulta)

            For_Depositos.CmbBodegas.DisplayMember = "DESCRIPCION"
            For_Depositos.CmbBodegas.ValueMember = "CODIGO"
            For_Depositos.CmbBodegas.DataSource = Tabla

            For_Depositos.CmbBodegas.Text = ""

            Consulta.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try
        '-------------------------------------------------------
    End Sub
    Public Function CodigoDeposito(CodigoBodega, CodigoCliente) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_DepositosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 1 ' Consultar deposito por codigo de Bodega y Cliente
        comando.Parameters.Add("@BODEGA", SqlDbType.NChar).Value = CodigoBodega
        comando.Parameters.Add("@CLIENTE", SqlDbType.NChar).Value = CodigoCliente

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
