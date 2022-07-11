Imports System.Data.SqlClient

Public Class EntradasMercancia

    '*************** Atributos **************************
    Private _Centro As String
    Private _Bodega As String
    Private _Cliente As String
    Private _Deposito As String
    Private _Transportadora As String
    Private _Placa As String
    Private _TipoVehiculo As String
    Private _DocConductor As String
    Private _NombConductor As String
    Private _ApelConductor As String
    Private _Productos As DataGridView
    Private _Detallebloqueo As DataGridView
    Private _Soportes As DataGridView
    Private _RecaudoDescargues As DataGridView
    Private _Observacion As String

    '***************** Propiedades **********************
    Public Property Centro As String
        Get
            Return _Centro
        End Get
        Set(value As String)
            _Centro = value
        End Set
    End Property
    Public Property Bodega As String
        Get
            Return _Bodega
        End Get
        Set(value As String)
            _Bodega = value
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
    Public Property Deposito As String
        Get
            Return _Deposito
        End Get
        Set(value As String)
            _Deposito = value
        End Set
    End Property
    Public Property Transportadora As String
        Get
            Return _Transportadora
        End Get
        Set(value As String)
            _Transportadora = value
        End Set
    End Property
    Public Property Placa As String
        Get
            Return _Placa
        End Get
        Set(value As String)
            _Placa = value
        End Set
    End Property
    Public Property TipoVehiculo As String
        Get
            Return _TipoVehiculo
        End Get
        Set(value As String)
            _TipoVehiculo = value
        End Set
    End Property
    Public Property DocConductor As String
        Get
            Return _DocConductor
        End Get
        Set(value As String)
            _DocConductor = value
        End Set
    End Property
    Public Property NombConductor As String
        Get
            Return _NombConductor
        End Get
        Set(value As String)
            _NombConductor = value
        End Set
    End Property
    Public Property ApelConductor As String
        Get
            Return _ApelConductor
        End Get
        Set(value As String)
            _ApelConductor = value
        End Set
    End Property
    Public Property Productos As DataGridView
        Get
            Return _Productos
        End Get
        Set(value As DataGridView)
            _Productos = value
        End Set
    End Property
    Public Property DetalleBloqueo As DataGridView
        Get
            Return _Detallebloqueo
        End Get
        Set(value As DataGridView)
            _Detallebloqueo = value
        End Set
    End Property
    Public Property Soportes As DataGridView
        Get
            Return _Soportes
        End Get
        Set(value As DataGridView)
            _Soportes = value
        End Set
    End Property
    Public Property RecaudoDescargues As DataGridView
        Get
            Return _RecaudoDescargues
        End Get
        Set(value As DataGridView)
            _RecaudoDescargues = value
        End Set
    End Property
    Public Property Observacion As String
        Get
            Return _Observacion
        End Get
        Set(value As String)
            _Observacion = value
        End Set
    End Property


    ' '***************** Metodos ***********************
    Public Function GuardarMercancia(Cantidad, Unidad, Total)

        Try

            Dim comando As New SqlClient.SqlCommand("sp_MercanciaIngreso", Conn)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Add("@CENTRO", SqlDbType.NChar).Value = Centro
            comando.Parameters.Add("@BODEGA", SqlDbType.NChar).Value = Bodega
            comando.Parameters.Add("@CLIENTE", SqlDbType.NChar).Value = Cliente
            comando.Parameters.Add("@DEPOSITO", SqlDbType.NChar).Value = Deposito
            comando.Parameters.Add("@PROVEEDOR", SqlDbType.NChar).Value = Transportadora
            comando.Parameters.Add("@PLACA", SqlDbType.NChar).Value = Placa
            comando.Parameters.Add("@TIPOVEHICULO", SqlDbType.NChar).Value = TipoVehiculo
            comando.Parameters.Add("@DOCCONDUCTOR", SqlDbType.NChar).Value = DocConductor
            comando.Parameters.Add("@NOMBCONDUCTOR", SqlDbType.NChar).Value = NombConductor
            comando.Parameters.Add("@APELCONDUCTOR", SqlDbType.NChar).Value = ApelConductor
            comando.Parameters.Add("@OBSERVACION", SqlDbType.NVarChar).Value = Observacion
            comando.Parameters.Add("@USUARIOAPP", SqlDbType.NChar).Value = UsuarioApp.Documento
            comando.Parameters.Add("@PC", SqlDbType.NChar).Value = Environment.MachineName
            '------- Necesarias para el Recibo de Recaudo de Descargue -------------------
            comando.Parameters.Add("@CANTIDAD", SqlDbType.Decimal).Value = CType(Cantidad, Decimal)
            comando.Parameters.Add("@UNIDAD", SqlDbType.NChar).Value = Unidad
            comando.Parameters.Add("@TOTAL", SqlDbType.Decimal).Value = CType(Total, Decimal)
            '------------------------------------------------------------------------------

            '---Calcular los totales actuales de cada producto para alimentar el grid antes de Enviarlo a la BD --------------

            Dim ObjTotales As New TotalesProducto()
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            '----Creo Tabla Temporal----
            Dim TablaTemp As New DataTable

            Dim dcCodigo As New DataColumn("Codigo", Type.GetType("System.String"))
            Dim dcPresentacion As New DataColumn("Presentacion", Type.GetType("System.Int32"))
            Dim dcTotalBloqueo As New DataColumn("TotalBloqueo", Type.GetType("System.Decimal"))
            Dim dcTotalBultosBloqueo As New DataColumn("TotalBultosBloqueo", Type.GetType("System.Int32"))
            Dim dcDisponible As New DataColumn("Disponible", Type.GetType("System.Decimal"))
            Dim dcBultosDisponible As New DataColumn("BultosDisponible", Type.GetType("System.Int32"))

            TablaTemp.Columns.AddRange(New DataColumn() {dcCodigo, dcPresentacion, dcTotalBloqueo, dcTotalBultosBloqueo, dcDisponible, dcBultosDisponible})
            'TablaTemp.PrimaryKey = New DataColumn() {dcCodigo} 'Asignamos una clave primaria
            '-----------------------------


            With Productos

                For i = 0 To .Rows.Count - 1

                    Dim TotalBloqueo As Decimal = 0
                    Dim TotalBultosBloqueo As Integer = 0
                    Dim Disponible As Decimal = 0
                    Dim BultosDisponible As Integer = 0

                    '--- Miro si los totales ya los tengo en mi tabla temporal ---
                    Dim flag As Integer = 0

                    For x = 0 To TablaTemp.Rows.Count - 1
                        ' Comparo el Codigo con la columna codigo de la tabla temporal y la presentacion con sul correspondiente columna
                        If (TablaTemp.Rows(x).Item("Codigo") = Trim(.Rows(i).Cells(0).Value)) And (TablaTemp.Rows(x).Item("Presentacion") = Trim(.Rows(i).Cells(5).Value)) Then

                            ' si el codigo ya estaba temporalizado tomo los datos de ahi.

                            TotalBloqueo = TablaTemp.Rows(x).Item("TotalBloqueo")
                            TotalBultosBloqueo = TablaTemp.Rows(x).Item("TotalbultosBloqueo")
                            Disponible = TablaTemp.Rows(x).Item("Disponible")
                            BultosDisponible = TablaTemp.Rows(x).Item("BultosDisponible")

                            flag = 1
                        End If


                    Next

                    If flag = 0 Then ' si no estaban temporizados los consulto a la base de datos

                        Consulta = ObjTotales.ConsultaTotales(Centro, Bodega, Deposito, Cliente, Trim(.Rows(i).Cells(5).Value), Trim(.Rows(i).Cells(0).Value))

                        If Consulta.Read() Then
                            TotalBloqueo = Trim(Consulta("TOTALBLOQUEO").ToString())
                            TotalBultosBloqueo = Trim(Consulta("TOTALBULTOSBLOQUEO").ToString())
                            Disponible = Trim(Consulta("DISPONIBLE").ToString())
                            BultosDisponible = Trim(Consulta("BULTOSDISPONIBLE").ToString())
                        End If
                        Consulta.Close()

                        '---- Los Adicino en la Tabla Temporal -----

                        Dim dr As DataRow
                        dr = TablaTemp.NewRow
                        dr("Codigo") = Trim(Productos.Rows(i).Cells(0).Value)
                        dr("Presentacion") = Trim(Productos.Rows(i).Cells(5).Value)
                        dr("TotalBloqueo") = TotalBloqueo
                        dr("TotalBultosBloqueo") = TotalBultosBloqueo
                        dr("Disponible") = Disponible
                        dr("BultosDisponible") = BultosDisponible
                        TablaTemp.Rows.Add(dr)

                        '--------------------------------------------

                    End If

                    ' -- le asigno esos valores a la fila

                    TotalBloqueo += (.Rows(i).Cells(8).Value)
                    TotalBultosBloqueo += Val(.Rows(i).Cells(9).Value)

                    Dim TempDisponible As Decimal = ((Productos.Rows(i).Cells(2).Value) - (Productos.Rows(i).Cells(8).Value)) ' Cantidad - bloqueado

                    If TempDisponible < 0 Then TempDisponible = 0

                    Disponible += TempDisponible

                    Dim TempBultos As Integer = Val(Productos.Rows(i).Cells(6).Value) - Val(Productos.Rows(i).Cells(9).Value)

                    If TempBultos < 0 Then TempBultos = 0

                    BultosDisponible += TempBultos

                    .Rows(i).Cells(10).Value = TotalBloqueo
                    .Rows(i).Cells(11).Value = TotalBultosBloqueo
                    .Rows(i).Cells(12).Value = Disponible
                    .Rows(i).Cells(13).Value = BultosDisponible

                    '---- Actualizo los nuevos valores en la tabla temporl para ese codigo ----

                    For x = 0 To TablaTemp.Rows.Count - 1

                        If TablaTemp.Rows(x).Item(0) = Trim(.Rows(i).Cells(0).Value) Then ' Comparo el Codigo con la columna codigo de la tabla temporal

                            ' si el codigo ya estaba temporalizado tomo los datos de ahi.

                            TablaTemp.Rows(x).Item("TotalBloqueo") = TotalBloqueo
                            TablaTemp.Rows(x).Item("TotalBultosBloqueo") = TotalBultosBloqueo
                            TablaTemp.Rows(x).Item("Disponible") = Disponible
                            TablaTemp.Rows(x).Item("BultosDisponible") = BultosDisponible

                        End If


                    Next
                    ' debo limpiar las variables

                    TotalBloqueo = 0
                    TotalBultosBloqueo = 0
                    Disponible = 0
                    BultosDisponible = 0
                    '--------------------------------------------------------------------------

                Next
            End With

            '-----------------------------------------------------------------------------------------------------------------

            '----------------------Envio el Datagrid de los Productos ------------------

            Dim ArchivoTemp1 As String = ""

            With Productos
                For i = 0 To .Rows.Count - 1

                    Dim xCantidad As Decimal = ((Productos.Rows(i).Cells(2).Value))
                    Dim xBloqueo As Decimal = Trim(Productos.Rows(i).Cells(8).Value)
                    Dim xTotalBloqueo As Decimal = Trim(Productos.Rows(i).Cells(10).Value)
                    Dim xDisponible As Decimal = Trim(Productos.Rows(i).Cells(12).Value)
                    Dim xSobrante As Decimal = Trim(Productos.Rows(i).Cells(14).Value)

                    ArchivoTemp1 = ArchivoTemp1 & "<DETALLE IDPROCESO='' CENTRO='' BODEGA='' DEPOSITO='' CLIENTE='' 
                                                            CODIGO='" & Trim(.Rows(i).Cells(0).Value) & "'
                                                            LOTE='" & Trim(.Rows(i).Cells(7).Value) & "'
                                                            TIPOMOV='E'
                                                            CANTIDAD='" & (Replace(xCantidad, ",", ".")) & "'
                                                            BULTOS='" & Trim(.Rows(i).Cells(6).Value) & "'
                                                            PRESENTACION ='" & Trim(.Rows(i).Cells(5).Value) & "'
                                                            BLOQUEO='" & (Replace(xBloqueo, ",", ".")) & "'
                                                            BULTOSBLOQUEO='" & Trim(.Rows(i).Cells(9).Value) & "'
                                                            TOTALBLOQUEO='" & (Replace(xTotalBloqueo, ",", ".")) & "'
                                                            TOTALBULTOSBLOQUEO='" & Trim(.Rows(i).Cells(11).Value) & "'
                                                            DISPONIBLE='" & (Replace(xDisponible, ",", ".")) & "'
                                                            BULTOSDISPONIBLE='" & Trim(.Rows(i).Cells(13).Value) & "'
                                                            SOBRANTE='" & (Replace(xSobrante, ",", ".")) & "'
                                                            BULTOSSOBRANTE='" & Trim(.Rows(i).Cells(15).Value) & "'
                                                            FECHA='' HORA=''
                                                   />"
                Next
            End With

            Dim XMLProductos = "<?xml version='1.0'?><PRODUCTOS>" & ArchivoTemp1 & "</PRODUCTOS>"

            comando.Parameters.Add("@PRODUCTOSXML", SqlDbType.NChar).Value = XMLProductos
            '------------------------------------------------------------------------------

            '----------------------Envio el Datagrid de los Bloqueos ----------------------
            Dim ArchivoTemp2 As String = ""

            With DetalleBloqueo
                For i = 0 To .Rows.Count - 1

                    Dim xCantidad As Decimal = Trim(.Rows(i).Cells(1).Value)

                    ArchivoTemp2 = ArchivoTemp2 & "<DETALLE IDPROCESO='' CODIGO='" & Trim(.Rows(i).Cells(0).Value) & "' CANTIDAD='" & (Replace(xCantidad, ",", ".")) & "' MOTIVO='" & Trim(.Rows(i).Cells(6).Value) & "' OBSERVACION='" & Trim(.Rows(i).Cells(4).Value) & "' RUTA='' LOTE='" & Trim(.Rows(i).Cells(7).Value) & "' />"
                Next
            End With

            Dim XMLBloqueos = "<?xml version='1.0'?><BLOQUEOS>" & ArchivoTemp2 & "</BLOQUEOS>"

            comando.Parameters.Add("@BLOQUEOSXML", SqlDbType.NChar).Value = XMLBloqueos

            '------------------------------------------------------------------------------

            '----------------------Envio el Datagrid de los Soportes ----------------------
            Dim ArchivoTemp3 As String = ""

            With Soportes
                For i = 0 To .Rows.Count - 1
                    ArchivoTemp3 = ArchivoTemp3 & "<DETALLE IDPROCESO='' DOCUMENTO='" & Trim(.Rows(i).Cells(4).Value) & "' REFERENCIA='" & Trim(.Rows(i).Cells(2).Value) & "' RUTA=''  />"
                Next
            End With

            Dim XMLSoportes = "<?xml version='1.0'?><SOPORTES>" & ArchivoTemp3 & "</SOPORTES>"

            comando.Parameters.Add("@SOPORTESXML", SqlDbType.NChar).Value = XMLSoportes

            '------------------------------------------------------------------------------

            '----------------------Envio el Datagrid de los Recaudos Servicios ----------------------
            Dim ArchivoTemp4 As String = ""

            With RecaudoDescargues
                For i = 0 To .Rows.Count - 1

                    Dim xCantidad As Decimal = .Rows(i).Cells(2).Value

                    ArchivoTemp4 = ArchivoTemp4 & "<DETALLE IDPROCESO='' BODEGA='" & Trim(Bodega) & "' RECIBO='' SERVICIO='" & Trim(.Rows(i).Cells(0).Value) & "' CANTIDAD='" & (Replace(xCantidad, ",", ".")) & "' VALOR='" & CType(.Rows(i).Cells(3).Value, Decimal) & "' TOTAL='" & CType(.Rows(i).Cells(4).Value, Decimal) & "' />"
                Next
            End With

            Dim XMLRecaudos = "<?xml version='1.0'?><RECAUDOS>" & ArchivoTemp4 & "</RECAUDOS>"

            comando.Parameters.Add("@RECAUDOSXML", SqlDbType.NChar).Value = XMLRecaudos

            '------------------------------------------------------------------------------


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

End Class
