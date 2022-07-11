Imports System.Data.SqlClient

Public Class Usuarios
    '*************** Atributos **************************
    Private _Codigo As String
    Private _Tdoc As String
    Private _Documento As String
    Private _Nombre As String
    Private _Papellido As String
    Private _Sapellido As String
    Private _FechaNac As String
    Private _Direccion As String
    Private _Email As String
    Private _Celular As String
    Private _Rol As String
    Private _Estado As String
    Private _Clave As String
    Private _FechaClave As String
    Private _Caducidad As String
    Private _Vigencia As String
    Private _Area As String
    Private _Ubicacion As String
    Private _Paridad As String

    '***************** Propiedades ***********************
    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
        End Set
    End Property
    Public Property Tdoc As String
        Get
            Return _Tdoc
        End Get
        Set(value As String)
            _Tdoc = value
        End Set
    End Property
    Public Property Documento As String
        Get
            Return _Documento
        End Get
        Set(value As String)
            _Documento = value
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
    Public Property Papellido As String
        Get
            Return _Papellido
        End Get
        Set(value As String)
            _Papellido = value
        End Set
    End Property
    Public Property Sapellido As String
        Get
            Return _Sapellido
        End Get
        Set(value As String)
            _Sapellido = value
        End Set
    End Property
    Public Property FechaNac As String
        Get
            Return _FechaNac
        End Get
        Set(value As String)
            _FechaNac = value
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
    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property
    Public Property Celular As String
        Get
            Return _Celular
        End Get
        Set(value As String)
            _Celular = value
        End Set
    End Property
    Public Property Rol As String
        Get
            Return _Rol
        End Get
        Set(value As String)
            _Rol = value
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
    Public Property Caducidad As String
        Get
            Return _Caducidad
        End Get
        Set(value As String)
            _Caducidad = value
        End Set
    End Property
    Public Property Clave As String
        Get
            Return _Clave
        End Get
        Set(value As String)
            _Clave = value
        End Set
    End Property
    Public Property FechaClave As String
        Get
            Return _FechaClave
        End Get
        Set(value As String)
            _FechaClave = value
        End Set
    End Property
    Public Property Vigencia As String
        Get
            Return _Vigencia
        End Get
        Set(value As String)
            _Vigencia = value
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
    Public Property Ubicacion As String
        Get
            Return _Ubicacion
        End Get
        Set(value As String)
            _Ubicacion = value
        End Set
    End Property
    Public Property Paridad As String
        Get
            Return _Paridad
        End Get
        Set(value As String)
            _Paridad = value
        End Set
    End Property

    ' '***************** Metodos ***********************
    Public Function GuardarUsuario() As String

        Try

            Dim comando As New SqlClient.SqlCommand("sp_UsuariosGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@TDOC", SqlDbType.NChar).Value = Tdoc
            comando.Parameters.Add("@DOCUMENTO", SqlDbType.NChar).Value = Documento
            comando.Parameters.Add("@PAPELLIDO", SqlDbType.NChar).Value = Papellido
            comando.Parameters.Add("@SAPELLIDO", SqlDbType.NChar).Value = Sapellido
            comando.Parameters.Add("@NOMBRE", SqlDbType.NChar).Value = Nombre
            comando.Parameters.Add("@FECHANAC", SqlDbType.Date).Value = FechaNac
            comando.Parameters.Add("@DIRECCION", SqlDbType.NChar).Value = Direccion
            comando.Parameters.Add("@EMAIL", SqlDbType.NChar).Value = Email
            comando.Parameters.Add("@CELULAR", SqlDbType.NChar).Value = Celular
            comando.Parameters.Add("@ROL", SqlDbType.NChar).Value = Rol
            comando.Parameters.Add("@ESTADO", SqlDbType.NChar).Value = Estado
            comando.Parameters.Add("@CLAVE", SqlDbType.NChar).Value = Clave
            comando.Parameters.Add("@FECHACLAVE", SqlDbType.Date).Value = FechaClave
            comando.Parameters.Add("@CADUCIDAD", SqlDbType.NChar).Value = Caducidad
            comando.Parameters.Add("@VIGENCIA", SqlDbType.Date).Value = Vigencia
            comando.Parameters.Add("@AREA", SqlDbType.NChar).Value = Area
            comando.Parameters.Add("@UBICACION", SqlDbType.NChar).Value = Ubicacion
            comando.Parameters.Add("@PARIDAD", SqlDbType.NChar).Value = Paridad


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
    Public Function CambioClave(NewClave, TempParidad) As Boolean

        Try
            Dim comando As New SqlClient.SqlCommand("sp_UsuariosActualizar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 1 ' Cambio de Clave
            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = UsuarioApp.Codigo
            comando.Parameters.Add("@CLAVE", SqlDbType.NChar).Value = NewClave
            comando.Parameters.Add("@DOCUMENTO", SqlDbType.NChar).Value = UsuarioApp.Documento
            comando.Parameters.Add("@PARIDAD", SqlDbType.NChar).Value = TempParidad
            comando.Parameters.Add("@OLDCLAVE", SqlDbType.NChar).Value = Gl_Key

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



    End Function
    Public Function ListarUsuarios() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_UsuariosListar", Conn)
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
    Public Function ListarPerfiles() As SqlDataReader

        Try

            Dim comando As New SqlClient.SqlCommand("sp_PerfilesListar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 1 ' Listar todos los perfiles

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 300)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()

            Conn.Open()

            Return comando.ExecuteReader

        Catch ex As Exception
            Conn.Close()
            Return Nothing
        End Try

    End Function
    Public Function ListarPerfiles(CodUsuario) As SqlDataReader

        Try

            Dim comando As New SqlClient.SqlCommand("sp_PerfilesListar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 2 ' Listar perfiles del Usuario
            comando.Parameters.Add("@USUARIO", SqlDbType.NChar).Value = CodUsuario

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            If Conn.State = ConnectionState.Open Then Conn.Close()

            Conn.Open()

            Return comando.ExecuteReader

        Catch ex As Exception
            Conn.Close()
            Return Nothing
        End Try

    End Function
    Public Function Establecerperfiles(CodUsuario, Permisos) As Boolean


        Dim i As Integer
        Dim Perfil As String
        Try


            '********************* VERIFICA CONCEPTOS NO GUARDADOS **********************************
            For i = 0 To Permisos.count - 1

                Perfil = Format(i + 1, "00")

                Dim comando As New SqlClient.SqlCommand("sp_PerfilesGuardar", Conn)
                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = CodUsuario
                comando.Parameters.Add("@PERFIL", SqlDbType.NChar).Value = Perfil

                If Permisos(i) = 1 Then
                    comando.Parameters.Add("@ACTIVO", SqlDbType.NChar).Value = "SI"
                Else
                    comando.Parameters.Add("@ACTIVO", SqlDbType.NChar).Value = "NO"
                End If

                '----- Variable que recibe el Resultado ----------

                comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
                comando.Parameters("@Resultado").Direction = ParameterDirection.Output

                '-------------------------------------------------

                If Conn.State = 1 Then Conn.Close()
                Conn.Open()
                comando.ExecuteScalar()

            Next

            Return True

        Catch ex As Exception

            Return False

        End Try

        If Conn.State = 1 Then Conn.Close()


    End Function
    Public Function ListarAccesoUsr() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_Logueo", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 3

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
