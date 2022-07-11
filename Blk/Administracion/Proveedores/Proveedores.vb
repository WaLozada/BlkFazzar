Imports System.Data.SqlClient

Public Class Proveedores
    '*************** Atributos **************************
    Private _IdProveedor As String
    Private _Codigo As String
    Private _Nombre As String
    Private _Estado As String


    '***************** Propiedades **********************
    Public Property IdProveedor As String
        Get
            Return _IdProveedor
        End Get
        Set(value As String)
            _IdProveedor = value
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
    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property

    '**************** Metodos ****************************
    Public Function ListarProveedores() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ProveedoresListar", Conn)
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
    Public Function GuardarProveedor(Nombre) As String

        Try

            Dim comando As New SqlClient.SqlCommand("sp_ProveedoresGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@NOMBRE", SqlDbType.NChar).Value = Nombre
            comando.Parameters.Add("@USUARIOAPP", SqlDbType.NChar).Value = UsuarioApp.Documento
            comando.Parameters.Add("@ESTADO", SqlDbType.NChar).Value = 1

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
    Public Sub Cargareldataset()

        '----- Cargara los Proveedores en el Dataset Global --------------
        Dim Tabla As New DataTable("TProveedores")
        Tabla.Load(ListarProveedores)

        If Gl_DataSet.Tables.Contains("TProveedores") Then Gl_DataSet.Tables.Remove("TProveedores")

        Gl_DataSet.Tables.Add(Tabla)
        '--------------------------------------------------------------

    End Sub
    Public Function CoincideProveedor(Nombre) As DataView

        '******* Busqueda de Proveedor por coincidencia *************
        Dim dv As New DataView
        CoincideProveedor = New DataView

        dv.Table = Gl_DataSet.Tables("TProveedores")
        dv.RowFilter = "Nombre like '%" & (Nombre) & "%'"

        CoincideProveedor = dv
        '*************************************************************

    End Function
    Public Sub LimpiarVariableGlobal()
        With GL_Proveedor
            .IdProveedor = ""
            .Codigo = ""
            .Nombre = ""
            .Estado = ""
        End With
    End Sub
End Class
