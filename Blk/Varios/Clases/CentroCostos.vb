Imports System.Data.SqlClient

Public Class CentroCostos

    '*************** Atributos **************************
    Private _IdCentroCosto As String
    Private _Nombre As String
    Private _Sigla As String
    Private _Proyecto As String
    Private _Terminal As Integer
    Private _Segmento As Integer




    '***************** Propiedades ***********************
    Public Property IdCentroCosto As String
        Get
            Return _IdCentroCosto
        End Get
        Set(value As String)
            _IdCentroCosto = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Sigla As String
        Get
            Return _Sigla
        End Get
        Set(value As String)
            _Sigla = value
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
    Public Property Terminal As Integer
        Get
            Return _Terminal
        End Get
        Set(value As Integer)
            _Terminal = value
        End Set
    End Property
    Public Property Segmento As Integer
        Get
            Return _Segmento
        End Get
        Set(value As Integer)
            _Segmento = value
        End Set
    End Property

    ' '***************** Metodos ***********************
    Public Function ListarProyectos() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_CCostosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 2 ' Listado de Proyectos

        '----- Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------

        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
    Public Function ListarCentros(Accion, Terminal) As SqlDataReader

        If Conn.State = ConnectionState.Closed Then Conn.Open()


        Try

            Dim comando As New SqlClient.SqlCommand("sp_CCostosListar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = Accion ' Listado de Centros
            comando.Parameters.Add("@TERMINAL", SqlDbType.NChar).Value = Terminal

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            Dim Consulta3 As SqlDataReader

            Consulta3 = comando.ExecuteReader
            Return Consulta3

        Catch ex As Exception
            Return Nothing
        End Try

        Conn.Close()

    End Function
    Public Function ListarClientes(Terminal, Segmento) As SqlDataReader


        Try
            Dim comando As New SqlClient.SqlCommand("sp_CCostosListar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 2 ' Listado de Centros
            comando.Parameters.Add("@TERMINAL", SqlDbType.NChar).Value = Terminal
            comando.Parameters.Add("@SEGMENTO", SqlDbType.NChar).Value = Segmento

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
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

    Public Function ListarCecoClientes(Cliente) As SqlDataReader


        Try
            Dim comando As New SqlClient.SqlCommand("sp_CCostosListar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 5 ' Listado de CeCos del Cliente
            comando.Parameters.Add("@CLIENTE", SqlDbType.NChar).Value = Cliente

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
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

    Public Function GuardarCliente()

        Try

            Dim comando As New SqlClient.SqlCommand("sp_CCostosGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure


            comando.Parameters.Add("@TERMINAL", SqlDbType.Int).Value = Terminal
            comando.Parameters.Add("@SEGMENTO", SqlDbType.Int).Value = Segmento
            comando.Parameters.Add("@CLIENTE", SqlDbType.NChar).Value = Nombre
            comando.Parameters.Add("@CECO", SqlDbType.NChar).Value = Sigla

            'comando.Parameters.Add("@PC", SqlDbType.NChar).Value = Environment.MachineName
            'comando.Parameters.Add("@USUARIOAPP", SqlDbType.NChar).Value = Globales.UsuarioApp.Documento


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
                Return Trim(comando.Parameters("@Resultado").Value)
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Return False
        End Try

        Conn.Close()


    End Function

End Class
