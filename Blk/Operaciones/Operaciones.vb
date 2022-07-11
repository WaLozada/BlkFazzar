Imports System.Data.SqlClient

Public Class Operaciones

    '*************** Atributos **************************

    Private _Idproyecto As String
    Private _Nombre As String
    Private _CodCliente As String
    Private _Cliente As String
    Private _CodResponsable As String
    Private _Responsable As String
    Private _TPGranel As Integer
    Private _TPGeneral As Integer
    Private _Almacenamiento As Integer
    Private _Itr As Integer
    Private _Empaque As Integer
    Private _FechaInicio As String
    Private _FechaFinal As String

    '***************** Propiedades ***********************
    Public Property Idproyecto As String
        Get
            Return _Idproyecto
        End Get
        Set(value As String)
            _Idproyecto = value
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
    Public Property CodCliente As String
        Get
            Return _CodCliente
        End Get
        Set(value As String)
            _CodCliente = value
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
    Public Property CodResponsable As String
        Get
            Return _CodResponsable
        End Get
        Set(value As String)
            _CodResponsable = value
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
    Public Property TPGranel As Integer
        Get
            Return _TPGranel
        End Get
        Set(value As Integer)
            _TPGranel = value
        End Set
    End Property
    Public Property TPGeneral As Integer
        Get
            Return _TPGeneral
        End Get
        Set(value As Integer)
            _TPGeneral = value
        End Set
    End Property
    Public Property Almacenamiento As Integer
        Get
            Return _Almacenamiento
        End Get
        Set(value As Integer)
            _Almacenamiento = value
        End Set
    End Property
    Public Property Itr As Integer
        Get
            Return _Itr
        End Get
        Set(value As Integer)
            _Itr = value
        End Set
    End Property
    Public Property Empaque As Integer
        Get
            Return _Empaque
        End Get
        Set(value As Integer)
            _Empaque = value
        End Set
    End Property
    Public Property FechaInicio As String
        Get
            Return _FechaInicio
        End Get
        Set(value As String)
            _FechaInicio = value
        End Set
    End Property
    Public Property FechaFinal As String
        Get
            Return _FechaFinal
        End Get
        Set(value As String)
            _FechaFinal = value
        End Set
    End Property

    ' '***************** Metodos ***********************
    Public Function Guardarproyecto() As Boolean

        'Try

        '    Dim comando As New SqlClient.SqlCommand("sp_CentrosGuardar", Conn)
        '    comando.CommandType = CommandType.StoredProcedure

        '    comando.Parameters.Add("@CENTRO", SqlDbType.NChar).Value = Nombre
        '    comando.Parameters.Add("@DIRECCION", SqlDbType.NChar).Value = Direccion
        '    comando.Parameters.Add("@CORREO", SqlDbType.NChar).Value = Correo
        '    comando.Parameters.Add("@TELEFONO", SqlDbType.NChar).Value = Telefono
        '    comando.Parameters.Add("@MUELLES", SqlDbType.NChar).Value = Muelles
        '    comando.Parameters.Add("@NOMBRESPONSABLE", SqlDbType.NChar).Value = NombreResponsable
        '    comando.Parameters.Add("@APELRESPONSABLE", SqlDbType.NChar).Value = ApellidoResponsable
        '    comando.Parameters.Add("@DIVIPOL", SqlDbType.NChar).Value = Divipol

        '    '----- Variable que recibe el Resultado ----------
        '    comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
        '    comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '    '-------------------------------------------------

        '    If Conn.State = ConnectionState.Open Then Conn.Close()
        '    Conn.Open()
        '    comando.ExecuteScalar()

        '    ' Si Todo Bien = OK
        '    ' Si todo Mal = Mensaje de error
        '    If comando.Parameters("@Resultado").Value = "OK" Then
        '        Return True
        '    Else
        '        Return False
        '    End If


        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        '    Return False
        'End Try

        'Conn.Close()
        Return False
    End Function
    Public Function Listarproyecto() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ProyectosListar", Conn)
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
    Public Function ActualizarProyecto() As Boolean

        'Try
        '    Dim comando As New SqlClient.SqlCommand("sp_CentrosActualizar", Conn)
        '    comando.CommandType = CommandType.StoredProcedure

        '    comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo
        '    comando.Parameters.Add("@CENTRO", SqlDbType.NChar).Value = Nombre
        '    comando.Parameters.Add("@DIRECCION", SqlDbType.NChar).Value = Direccion
        '    comando.Parameters.Add("@CORREO", SqlDbType.NChar).Value = Correo
        '    comando.Parameters.Add("@TELEFONO", SqlDbType.NChar).Value = Telefono
        '    comando.Parameters.Add("@MUELLES", SqlDbType.NChar).Value = Muelles
        '    comando.Parameters.Add("@NOMBRESPONSABLE", SqlDbType.NChar).Value = NombreResponsable
        '    comando.Parameters.Add("@APELRESPONSABLE", SqlDbType.NChar).Value = ApellidoResponsable
        '    comando.Parameters.Add("@DIVIPOL", SqlDbType.NChar).Value = Divipol

        '    '----- Variable que recibe el Resultado ----------
        '    comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 200)
        '    comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '    '-------------------------------------------------

        '    If Conn.State = ConnectionState.Open Then Conn.Close()
        '    Conn.Open()
        '    comando.ExecuteScalar()

        '    ' Si Todo Bien = OK
        '    ' Si todo Mal = Mensaje de error
        '    If comando.Parameters("@Resultado").Value = "OK" Then
        '        Return True
        '    Else
        '        Return False
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        '    Return False
        'End Try

        'Conn.Close()
        Return False
    End Function
    Public Function BorrarProyecto(Codigo) As Boolean


        'Try
        '    Dim comando As New SqlClient.SqlCommand("sp_CentrosBorrar", Conn)
        '    comando.CommandType = CommandType.StoredProcedure
        '    If Conn.State = ConnectionState.Closed Then Conn.Open()

        '    comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo

        '    '------ Variable que recibe el Resultado ----------
        '    comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        '    comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '    '-------------------------------------------------

        '    If Conn.State = ConnectionState.Open Then Conn.Close()
        '    Conn.Open()
        '    comando.ExecuteScalar()


        '    If comando.Parameters("@Resultado").Value = "OK" Then
        '        Return True
        '    Else
        '        Return False
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        '    Return False
        'End Try

        'Conn.Close()

        Return False

    End Function
End Class
