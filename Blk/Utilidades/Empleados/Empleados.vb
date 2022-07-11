Imports System.Data.SqlClient

Public Class Empleados
    '*************** Atributos **************************
    Private _IdEmpleado As String
    Private _Nombre As String
    Private _Apellido As String
    Private _Area As String
    Private _Cargo As String
    Private _Estado As String


    '***************** Propiedades **********************
    Public Property IdEmpleado As String
        Get
            Return _IdEmpleado
        End Get
        Set(value As String)
            _IdEmpleado = value
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
    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
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
    Public Property Cargo As String
        Get
            Return _Cargo
        End Get
        Set(value As String)
            _Cargo = value
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

    Public Function ListarEmpleados() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_EmpleadosListar", Conn)
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
    Public Function GuardarEmpleado(Nombre, Apellido, Area, Cargo) As String

        Try

            Dim comando As New SqlClient.SqlCommand("sp_EmpleadosGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@NOMBRE", SqlDbType.NChar).Value = Nombre
            comando.Parameters.Add("@APELLIDO", SqlDbType.NChar).Value = Apellido
            comando.Parameters.Add("@AREA", SqlDbType.NChar).Value = Area ' El codigo no el nombre
            comando.Parameters.Add("@CARGO", SqlDbType.NChar).Value = Cargo ' El codigo no el nombre
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
        Dim Tabla As New DataTable("TEmpleados")
        Tabla.Load(ListarEmpleados)

        If Gl_DataSet.Tables.Contains("TEmpleados") Then Gl_DataSet.Tables.Remove("TEmpleados")

        Gl_DataSet.Tables.Add(Tabla)
        '--------------------------------------------------------------

    End Sub

    Public Function CoincideEmpleado(Nombre) As DataView

        '******* Busqueda de Empleado por coincidencia *************
        Dim dv As New DataView
        'CoincideEmpleado = New DataView

        dv.Table = Gl_DataSet.Tables("TEmpleados")
        dv.RowFilter = "Nombre like '%" & (Nombre) & "%'"

        CoincideEmpleado = dv
        '*************************************************************

    End Function
    Public Sub LimpiarVariableGlobal()

        With GL_Empleado
            .IdEmpleado = ""
            .Nombre = ""
            .Apellido = ""
            .Area = ""
            .Cargo = ""
            .Estado = ""

        End With
    End Sub

End Class
