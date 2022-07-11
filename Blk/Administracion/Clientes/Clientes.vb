Imports System.Data.SqlClient

Public Class Clientes
    '*************** Atributos **************************
    Private _Codigo As String
    Private _Tdoc As String
    Private _Documento As String
    Private _Cliente As String
    Private _Direccion As String
    Private _Telefono As String
    Private _NombContacto As String
    Private _ApelContacto As String
    Private _Celular As String
    Private _Correo As String
    Private _Divipol As String
    Private _Departamento As String
    Private _Municipio As String
    Private _Tipo As String
    Private _Estado As String


    '***************** Propiedades **********************
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
    Public Property Cliente As String
        Get
            Return _Cliente
        End Get
        Set(value As String)
            _Cliente = value
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
    Public Property NombContacto As String
        Get
            Return _NombContacto
        End Get
        Set(value As String)
            _NombContacto = value
        End Set
    End Property
    Public Property ApelContacto As String
        Get
            Return _ApelContacto
        End Get
        Set(value As String)
            _ApelContacto = value
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
    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            _Correo = value
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
    Public Property Divipol As String
        Get
            Return _Divipol
        End Get
        Set(value As String)
            _Divipol = value
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
    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
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


    ' '***************** Metodos ***********************
    Public Function GuardarCliente() As Boolean

        Try

            Dim comando As New SqlClient.SqlCommand("sp_ClientesGuardar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@TDOC", SqlDbType.NChar).Value = Tdoc
            comando.Parameters.Add("@DOCUMENTO", SqlDbType.NChar).Value = Documento
            comando.Parameters.Add("@CLIENTE", SqlDbType.NChar).Value = Cliente
            comando.Parameters.Add("@DIRECCION", SqlDbType.NChar).Value = Direccion
            comando.Parameters.Add("@TELEFONO", SqlDbType.NChar).Value = Telefono
            comando.Parameters.Add("@TIPO", SqlDbType.NChar).Value = Tipo
            comando.Parameters.Add("@NOMBCONTACTO", SqlDbType.NChar).Value = NombContacto
            comando.Parameters.Add("@APELLCONTACTO", SqlDbType.NChar).Value = ApelContacto
            comando.Parameters.Add("@CELULAR", SqlDbType.NChar).Value = Celular
            comando.Parameters.Add("@CORREO", SqlDbType.NChar).Value = Correo
            comando.Parameters.Add("@DIVIPOL", SqlDbType.NChar).Value = Divipol
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
    Public Function ActualizarCliente() As Boolean

        Try
            Dim comando As New SqlClient.SqlCommand("sp_ClientesActualizar", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo
            comando.Parameters.Add("@TDOC", SqlDbType.NChar).Value = Tdoc
            comando.Parameters.Add("@DOCUMENTO", SqlDbType.NChar).Value = Documento
            comando.Parameters.Add("@CLIENTE", SqlDbType.NChar).Value = Cliente
            comando.Parameters.Add("@DIRECCION", SqlDbType.NChar).Value = Direccion
            comando.Parameters.Add("@TELEFONO", SqlDbType.NChar).Value = Telefono
            comando.Parameters.Add("@TIPO", SqlDbType.NChar).Value = Tipo
            comando.Parameters.Add("@NOMBCONTACTO", SqlDbType.NChar).Value = NombContacto
            comando.Parameters.Add("@APELLCONTACTO", SqlDbType.NChar).Value = ApelContacto
            comando.Parameters.Add("@CELULAR", SqlDbType.NChar).Value = Celular
            comando.Parameters.Add("@CORREO", SqlDbType.NChar).Value = Correo
            comando.Parameters.Add("@DIVIPOL", SqlDbType.NChar).Value = Divipol
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
    Public Function ListarClientes() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ClientesListar", Conn)
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
    Public Function ListarClientesTransporte() As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ClientesTransporteListar", Conn)
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
    Public Function ConsultaTarifas(Codigo) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_ClientesTarifas", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo
        comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 1 ' Consultar

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader
        Consulta = comando.ExecuteReader

        Return Consulta

        Conn.Close()

    End Function
    Public Function CoincideCliente(Nombre) As DataView

        '******* Busqueda de Cliente por coincidencia *************
        Dim dv As New DataView
        CoincideCliente = New DataView

        dv.Table = Gl_DataSet.Tables("TClientes")
        dv.RowFilter = "Cliente like '%" & (Nombre) & "%'"

        CoincideCliente = dv
        '*************************************************************

    End Function
    Public Function CoincideClienteTransporte(Nombre) As DataView

        '******* Busqueda de Cliente Transporte por coincidencia *************
        Dim dv As New DataView
        CoincideClienteTransporte = New DataView

        dv.Table = Gl_DataSet.Tables("TClientesTransporte")
        dv.RowFilter = "Cliente like '%" & (Nombre) & "%'"

        CoincideClienteTransporte = dv
        '*************************************************************

    End Function
    Public Function BorrarCliente(Codigo) As Boolean


        Try
            Dim comando As New SqlClient.SqlCommand("sp_ClientesBorrar", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            comando.Parameters.Add("@DOCUMENTO", SqlDbType.NChar).Value = Codigo

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


    Public Function GuardarTarifa(Servicio, Valor, Unidad, Centro, Bodega) As Boolean

        Try

            Dim comando As New SqlClient.SqlCommand("sp_ClientesTarifas", Conn)
            comando.CommandType = CommandType.StoredProcedure


            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo
            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 2 ' Insertar
            comando.Parameters.Add("@SERVICIO", SqlDbType.NChar).Value = Servicio
            comando.Parameters.Add("@VALOR", SqlDbType.NChar).Value = Valor
            comando.Parameters.Add("@UNIDAD", SqlDbType.NChar).Value = Unidad
            comando.Parameters.Add("@CENTRO", SqlDbType.NChar).Value = Centro
            comando.Parameters.Add("@BODEGA", SqlDbType.NChar).Value = Bodega
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
    Public Function BorrarTarifa(Id) As Boolean


        Try
            Dim comando As New SqlClient.SqlCommand("sp_ClientesTarifas", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            comando.Parameters.Add("@CODIGO", SqlDbType.NChar).Value = Codigo
            comando.Parameters.Add("@ACCION", SqlDbType.NChar).Value = 3 ' Borrar
            comando.Parameters.Add("@ID", SqlDbType.NChar).Value = Id

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

        '-------------- Cargo Combo Tipo Cliente -------------
        Dim Cadena As String = "select * from Gen_TipoCliente"
        Dim da As New SqlDataAdapter(Cadena, Conn)
        Dim dt As New DataTable
        da.Fill(dt)

        For_Clientes.CmbTipo.DisplayMember = "TIPO"
        For_Clientes.CmbTipo.ValueMember = "ID"
        For_Clientes.CmbTipo.DataSource = dt
        '-----------------------------------------------------

        '-------------- Cargo Combo Estado Cliente -------------
        Dim Cadena2 As String = "select * from Gen_EstadoCliente"
        Dim da2 As New SqlDataAdapter(Cadena2, Conn)
        Dim dt2 As New DataTable
        da2.Fill(dt2)

        For_Clientes.CmbEstado.DisplayMember = "ESTADO"
        For_Clientes.CmbEstado.ValueMember = "ID"
        For_Clientes.CmbEstado.DataSource = dt2
        '-----------------------------------------------------

    End Sub
    Public Sub Cargareldataset()

        '----- Cargara los Clientes en el Dataset Global --------------
        Dim Tabla As New DataTable("TClientes")
        Tabla.Load(ListarClientes)

        If Gl_DataSet.Tables.Contains("TClientes") Then Gl_DataSet.Tables.Remove("TClientes")

        Gl_DataSet.Tables.Add(Tabla)
        '--------------------------------------------------------------

    End Sub
    Public Sub CargareldatasetTransporte()

        '----- Cargara los Clientes en el Dataset Global --------------
        Dim Tabla As New DataTable("TClientesTransporte")
        Tabla.Load(ListarClientesTransporte)

        If Gl_DataSet.Tables.Contains("TClientestransporte") Then Gl_DataSet.Tables.Remove("TClientestransporte")

        Gl_DataSet.Tables.Add(Tabla)
        '--------------------------------------------------------------

    End Sub
    Public Sub LimpiarVariableGlobal()
        With Gl_Cliente
            .Codigo = ""
            .Tdoc = ""
            .Documento = ""
            .Cliente = ""
            .Direccion = ""
            .Telefono = ""
            .NombContacto = ""
            .ApelContacto = ""
            .Celular = ""
            .Correo = ""
            .Departamento = ""
            .Divipol = ""
            .Municipio = ""
            .Tipo = ""
            .Estado = ""
        End With
    End Sub

End Class
