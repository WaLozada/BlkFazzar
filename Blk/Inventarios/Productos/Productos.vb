Imports System.Data.SqlClient

Public Class Productos

    '*************** Atributos **************************
    Private _IdProducto As String
    Private _Codigo As String
    Private _Descripcion As String
    Private _Familia As String
    Private _Unidad As String
    Private _Simbolo As String
    Private _Empaque As String


    '***************** Propiedades **********************
    Public Property IdProducto As String
        Get
            Return _IdProducto
        End Get
        Set(value As String)
            _IdProducto = value
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
    Public Property Familia As String
        Get
            Return _Familia
        End Get
        Set(value As String)
            _Familia = value
        End Set
    End Property
    Public Property Unidad As String
        Get
            Return _Unidad
        End Get
        Set(value As String)
            _Unidad = value
        End Set
    End Property
    Public Property Empaque As String
        Get
            Return _Empaque
        End Get
        Set(value As String)
            _Empaque = value
        End Set
    End Property
    Public Property Simbolo As String
        Get
            Return _Simbolo
        End Get
        Set(value As String)
            _Simbolo = value
        End Set
    End Property

    ' '***************** Metodos ***********************
    Public Function GuardarProducto() As String

        Try

            Dim comando As New SqlClient.SqlCommand("sp_ProductosGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo
            comando.Parameters.Add("@DESCRIPCION", SqlDbType.NChar).Value = Descripcion
            comando.Parameters.Add("@FAMILIA", SqlDbType.NChar).Value = Familia
            comando.Parameters.Add("@UNIDAD", SqlDbType.NChar).Value = Unidad
            comando.Parameters.Add("@EMPAQUE", SqlDbType.NChar).Value = Empaque
            comando.Parameters.Add("@USUARIOAPP", SqlDbType.NChar).Value = UsuarioApp.Documento

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
    Public Function ActualizarProducto() As Boolean

        Try

            Dim comando As New SqlClient.SqlCommand("sp_ProductosActualizar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@IDPRODUCTO", SqlDbType.NChar).Value = IdProducto
            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo
            comando.Parameters.Add("@DESCRIPCION", SqlDbType.NChar).Value = Descripcion
            comando.Parameters.Add("@FAMILIA", SqlDbType.NChar).Value = Familia
            comando.Parameters.Add("@UNIDAD", SqlDbType.NChar).Value = Unidad
            comando.Parameters.Add("@EMPAQUE", SqlDbType.NChar).Value = Empaque
            comando.Parameters.Add("@USUARIOAPP", SqlDbType.NChar).Value = UsuarioApp.Documento

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
    Public Function BorrarProducto(Codigo) As Boolean


        Try
            Dim comando As New SqlClient.SqlCommand("sp_ProductosBorrar", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            comando.Parameters.Add("@IDPRODUCTO", SqlDbType.NChar).Value = Codigo

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
    Public Function ListarProductos() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ProductosListar", Conn)
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
    Public Function ListarProductosTransporte() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ProductosTransporteListar", Conn)
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
    Public Function ListarProductos(IdCliente) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ProductosListar", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@IDCLIENTE", SqlDbType.NChar).Value = IdCliente

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader

        Return Consulta

        Conn.Close()

    End Function
    Public Function AsignarProducto(IdProducto, IdCliente)

        Try

            Dim comando As New SqlClient.SqlCommand("sp_ProductosAsignar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@IDPRODUCTO", SqlDbType.NChar).Value = IdProducto
            comando.Parameters.Add("@IDCLIENTE", SqlDbType.NChar).Value = IdCliente

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
    Public Sub CargarCombos()

        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TFamilias")

        For_Productos.CmbFamilia.DisplayMember = "FAMILIA"
        For_Productos.CmbFamilia.ValueMember = "ID"
        For_Productos.CmbFamilia.DataSource = dv

        Dim dv1 As New DataView

        dv1.Table = Gl_DataSet.Tables("TUnidades")

        For_Productos.CmbUnidad.DisplayMember = "UNIDAD"
        For_Productos.CmbUnidad.ValueMember = "ID"
        For_Productos.CmbUnidad.DataSource = dv1


    End Sub
    Public Sub LimpiarVariableGlobal()

        Gl_Producto.IdProducto = ""
        Gl_Producto.Codigo = ""
        Gl_Producto.Descripcion = ""
        Gl_Producto.Familia = ""
        Gl_Producto.Unidad = ""
        Gl_Producto.Simbolo = ""
        Gl_Producto.Empaque = ""

    End Sub
    Public Function CoincideNombreProducto(Nombre) As DataView

        '******* Busqueda de Producto por coincidencia *************
        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TProductos")
        dv.RowFilter = "Descripcion like '%" & (Nombre) & "%'"

        CoincideNombreProducto = dv
        '*************************************************************

    End Function

    Public Function CoincideNombreProductoTransporte(Producto) As DataView

        '******* Busqueda de Producto por coincidencia *************
        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TProductosTransporte")
        dv.RowFilter = "Producto like '%" & (Producto) & "%'"

        CoincideNombreProductoTransporte = dv
        '*************************************************************

    End Function

    Public Function CoincideCodigoProducto(Codigo) As DataView

        '******* Busqueda de Productos por coincidencia *************
        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TProductos")
        dv.RowFilter = "Codigo like '%" & (Codigo) & "%'"

        CoincideCodigoProducto = dv
        '*************************************************************

    End Function

    Public Sub Cargareldataset()

        '----- Cargara los Clientes en el Dataset Global --------------
        Dim Tabla As New DataTable("TProductos")
        Tabla.Load(ListarProductos)

        If Gl_DataSet.Tables.Contains("TProductos") Then Gl_DataSet.Tables.Remove("TProductos")

        Gl_DataSet.Tables.Add(Tabla)
        GL_ProductoCargados = 1
        '--------------------------------------------------------------

    End Sub

    Public Sub CargareldatasetTransporte()

        '----- Cargara los Clientes en el Dataset Global --------------
        Dim Tabla As New DataTable("TProductosTransporte")
        Tabla.Load(ListarProductosTransporte)

        If Gl_DataSet.Tables.Contains("TProductostransporte") Then Gl_DataSet.Tables.Remove("TProductostransporte")

        Gl_DataSet.Tables.Add(Tabla)
        GL_ProductoCargados = 1
        '--------------------------------------------------------------

    End Sub
    Public Function GuardarProductoTransporte() As String

        Try

            Dim comando As New SqlClient.SqlCommand("sp_ProductosTransporteGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure


            comando.Parameters.Add("@PRODUCTO", SqlDbType.NChar).Value = Descripcion


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
