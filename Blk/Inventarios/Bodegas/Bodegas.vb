Imports System.Data.SqlClient

Public Class Bodegas

    '*************** Atributos **************************
    Private _IdBodega As String
    Private _Codigo As String
    Private _Descripcion As String
    Private _Direccion As String
    Private _Capacidad As String
    Private _Departamento As String
    Private _Municipio As String
    Private _Divipol As String
    Private _Centro As String
    Private _Estado As String
    Private _Visible As String



    '***************** Propiedades **********************
    Public Property IdBodega As String
        Get
            Return _IdBodega
        End Get
        Set(value As String)
            _IdBodega = value
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
    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property
    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property
    Public Property Capacidad As String
        Get
            Return _Capacidad
        End Get
        Set(value As String)
            _Capacidad = value
        End Set
    End Property
    Public Property Departamento As String
        Get
            Return _Departamento
        End Get
        Set(value As String)
            _Departamento = value
        End Set
    End Property
    Public Property Municipio As String
        Get
            Return _Municipio
        End Get
        Set(value As String)
            _Municipio = value
        End Set
    End Property
    Public Property Divipol As String
        Get
            Return _Divipol
        End Get
        Set(value As String)
            _Divipol = value
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

    ' '***************** Metodos ***********************
    Public Function GuardarBodega() As Boolean

        Try

            Dim comando As New SqlClient.SqlCommand("sp_BodegasGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@DESCRIPCION", SqlDbType.NChar).Value = Descripcion
            comando.Parameters.Add("@DIRECCION", SqlDbType.NChar).Value = Direccion
            comando.Parameters.Add("@CAPACIDAD", SqlDbType.NChar).Value = Capacidad
            comando.Parameters.Add("@DIVIPOL", SqlDbType.NChar).Value = Divipol
            comando.Parameters.Add("@CENTRO", SqlDbType.NChar).Value = Centro
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
    Public Function ActualizarBodega() As Boolean

        Try
            Dim comando As New SqlClient.SqlCommand("sp_BodegasActualizar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo
            comando.Parameters.Add("@DESCRIPCION", SqlDbType.NChar).Value = Descripcion
            comando.Parameters.Add("@DIRECCION", SqlDbType.NChar).Value = Direccion
            comando.Parameters.Add("@CAPACIDAD", SqlDbType.NChar).Value = Capacidad
            comando.Parameters.Add("@DIVIPOL", SqlDbType.NChar).Value = Divipol
            comando.Parameters.Add("@CENTRO", SqlDbType.NChar).Value = Centro
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
    Public Function ListarBodegas() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_BodegasListar", Conn)
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
    Public Function ListarBodegas(CodigoCentro) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_BodegasListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@CODIGOCENTRO", SqlDbType.NChar).Value = CodigoCentro

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function DatosBodega(CodigoCentro, CodigoBodega) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_BodegasListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@CODIGOCENTRO", SqlDbType.NChar).Value = CodigoCentro
        comando.Parameters.Add("@CODIGOBODEGA", SqlDbType.NChar).Value = CodigoBodega

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function BorrarBodega(Codigo) As Boolean


        Try
            Dim comando As New SqlClient.SqlCommand("sp_BodegasBorrar", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo
            comando.Parameters.Add("@VISIBLE", SqlDbType.NChar).Value = 0

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

        For_Bodegas.CmbEstado.DisplayMember = "ESTADO"
        For_Bodegas.CmbEstado.ValueMember = "IDESTADO"
        For_Bodegas.CmbEstado.DataSource = dt2
        '-----------------------------------------------------

        '--------------- Listar Centros ----------------------
        Try
            For_Bodegas.CmbCentros.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Centros.ListarCentro

            Tabla.Load(Consulta)

            For_Bodegas.CmbCentros.DisplayMember = "NOMBRE"
            For_Bodegas.CmbCentros.ValueMember = "CODIGO"
            For_Bodegas.CmbCentros.DataSource = Tabla

            For_Bodegas.CmbCentros.Text = ""

            'For Each Item As DataRow In Tabla.Rows
            '    For_Bodegas.CmbCentros.Items.Add(Trim(Item(0)) + " " + Trim(Item(1)))
            'Next

            Consulta.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try
        '-------------------------------------------------------


    End Sub

End Class
