Imports System.Data.SqlClient

Public Class Compañia
    '----------------- Atributos -----------------
    Private _Codigo As String
    Private _Nit As String
    Private _Nombre As String
    Private _Sigla As String
    Private _Divipol As String
    Private _Ciudad As String
    Private _Direccion As String
    Private _Telefono As String
    Private _Email As String
    Private _Id As String
    '--------------- Propiedades ------------------
    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
        End Set
    End Property
    Public Property Nit As String
        Get
            Return _Nit
        End Get
        Set(value As String)
            _Nit = value
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
    Public Property Divipol As String
        Get
            Return _Divipol
        End Get
        Set(value As String)
            _Divipol = value
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
    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
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
    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
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

    '-------------------- Metodos ----------------------
    Public Sub DatosCompañia()
        Try

            Dim comando As New SqlClient.SqlCommand("sp_Compañia", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@Accion", SqlDbType.NChar).Value = 0 ' Datos Totales

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            Conn.Open()

            Dim Consulta As SqlDataReader
            Consulta = comando.ExecuteReader

            If Consulta.Read() Then
                CompañiaApp.Codigo = Trim(Consulta("CODIGO").ToString())
                CompañiaApp.Nit = Trim(Consulta("NIT").ToString())
                CompañiaApp.Nombre = Trim(Consulta("NOMBRE").ToString())
                CompañiaApp.Sigla = Trim(Consulta("SIGLA").ToString())
                CompañiaApp.Divipol = Trim(Consulta("DIVIPOL").ToString())
                CompañiaApp.Ciudad = Trim(Consulta("CIUDAD").ToString())
                CompañiaApp.Direccion = Trim(Consulta("DIRECCION").ToString())
                CompañiaApp.Telefono = Trim(Consulta("TELEFONO").ToString())
                CompañiaApp.Email = Trim(Consulta("EMAIL").ToString())
                CompañiaApp.Id = Trim(Consulta("ID").ToString())
            End If
            Consulta.Close()

            If Conn.State = ConnectionState.Open Then Conn.Close()

        Catch ex As Exception
            Conn.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try
    End Sub
End Class
