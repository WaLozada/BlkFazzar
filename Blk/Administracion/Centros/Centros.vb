Imports System.Data.SqlClient

Public Class Centros
    '*************** Atributos **************************
    Private _IdCentros As String
    Private _Codigo As String
    Private _Nombre As String
    Private _Direccion As String
    Private _Correo As String
    Private _Telefono As String
    Private _Muelles As Integer
    Private _NombreResponsable As String
    Private _ApellidoResponsable As String
    Private _Pais As String
    Private _Departamento As String
    Private _Municipio As String
    Private _Divipol As String

    '***************** Propiedades ***********************
    Public Property IdCentros As String
        Get
            Return _IdCentros
        End Get
        Set(value As String)
            _IdCentros = value
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
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
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
    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            _Correo = value
        End Set
    End Property
    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property
    Public Property Muelles As Integer
        Get
            Return _Muelles
        End Get
        Set(value As Integer)
            _Muelles = value
        End Set
    End Property
    Public Property NombreResponsable As String
        Get
            Return _NombreResponsable
        End Get
        Set(value As String)
            _NombreResponsable = value
        End Set
    End Property
    Public Property ApellidoResponsable As String
        Get
            Return _ApellidoResponsable
        End Get
        Set(value As String)
            _ApellidoResponsable = value
        End Set
    End Property
    Public Property Pais As String
        Get
            Return _Pais
        End Get
        Set(value As String)
            _Pais = value
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

    ' '***************** Metodos ***********************
    Public Function GuardarCentro() As Boolean

        Try

            Dim comando As New SqlClient.SqlCommand("sp_CentrosGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@CENTRO", SqlDbType.NChar).Value = Nombre
            comando.Parameters.Add("@DIRECCION", SqlDbType.NChar).Value = Direccion
            comando.Parameters.Add("@CORREO", SqlDbType.NChar).Value = Correo
            comando.Parameters.Add("@TELEFONO", SqlDbType.NChar).Value = Telefono
            comando.Parameters.Add("@MUELLES", SqlDbType.NChar).Value = Muelles
            comando.Parameters.Add("@NOMBRESPONSABLE", SqlDbType.NChar).Value = NombreResponsable
            comando.Parameters.Add("@APELRESPONSABLE", SqlDbType.NChar).Value = ApellidoResponsable
            comando.Parameters.Add("@DIVIPOL", SqlDbType.NChar).Value = Divipol

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
    Public Function ActualizarCentro() As Boolean

        Try
            Dim comando As New SqlClient.SqlCommand("sp_CentrosActualizar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo
            comando.Parameters.Add("@CENTRO", SqlDbType.NChar).Value = Nombre
            comando.Parameters.Add("@DIRECCION", SqlDbType.NChar).Value = Direccion
            comando.Parameters.Add("@CORREO", SqlDbType.NChar).Value = Correo
            comando.Parameters.Add("@TELEFONO", SqlDbType.NChar).Value = Telefono
            comando.Parameters.Add("@MUELLES", SqlDbType.NChar).Value = Muelles
            comando.Parameters.Add("@NOMBRESPONSABLE", SqlDbType.NChar).Value = NombreResponsable
            comando.Parameters.Add("@APELRESPONSABLE", SqlDbType.NChar).Value = ApellidoResponsable
            comando.Parameters.Add("@DIVIPOL", SqlDbType.NChar).Value = Divipol

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
    Public Function ListarCentro() As SqlDataReader

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
    Public Function BorrarCentro(Codigo) As Boolean


        Try
            Dim comando As New SqlClient.SqlCommand("sp_CentrosBorrar", Conn)
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


End Class
