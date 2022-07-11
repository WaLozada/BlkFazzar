Imports System.Data.SqlClient

Public Class For_RegistroTransporte
    Dim Transportador As New Transportadores()
    Dim Despachos As New ClsTransporte()
    Dim CentroCosto As New CentroCostos()
    Dim Suma As Decimal = 0
    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If DTFecha.SelectionStart > Date.Now Then
            ListaErrores.Add("Fecha de Despacho mayor a la fecha Actual.")
        End If

        If Trim(LblCliente.Text) = "" Then
            ListaErrores.Add("- Indique el Cliente")
        End If

        If Trim(LblCliente.Text) <> Trim(CmbCliente.Text) Then
            ListaErrores.Add("- El Cliente debe coincidir con la selección del centro de Costo!")
        End If

        If Trim(LblOrigen.Text) = "" Then
            ListaErrores.Add("- Indique el Origen")
        End If

        If Trim(LblDestino.Text) = "" Then
            ListaErrores.Add("- indique el Destino")
        End If

        If Trim(CmbZona.Text) = "" Then
            ListaErrores.Add("- Seleccione la Zona")
        End If

        If Trim(CmbTipoDespacho.Text) = "" Then
            ListaErrores.Add("- Seleccione el Tipo de Despacho")
        End If

        If Trim(CmbTipoVehiculo.Text) = "" Then
            ListaErrores.Add("- Seleccione el Tipo de Vehiculo")
        End If

        If Trim(TxtPlaca.Text) = "" Then
            ListaErrores.Add("- Digite la Placa del Vehiculo que prestara el servicio")
        End If

        If Trim(LblProducto.Text) = "" Then
            ListaErrores.Add("- Seleccione el producto que sera movilizado!")
        End If

        If Trim(CmbTransportadora.Text) = "" Then
            ListaErrores.Add("- Seleccione la Empresa Transportadora")
        End If

        If Trim(TxtRemesa.Text) = "" Then
            ListaErrores.Add("- Digite el Codigo de la Remesa")
        End If

        If Trim(TxtManifiesto.Text) = "" Then
            ListaErrores.Add("- Digite el Codigo del Manifiesto")
        End If

        If Trim(TxtCeCo.Text) = "" Then
            ListaErrores.Add("- Seleccione el Centro de Costo")
        End If

        If Val(TxtCosto.Tag) = 0 Then
            ListaErrores.Add("- Digite el Costo del Despacho")
        End If

        If Val(TxtCostoTrans.Tag) = 0 Then
            ListaErrores.Add("- Digite el Costo del Transporte")
        End If

        If Val(TxtValorCliente.Tag) = 0 Then
            ListaErrores.Add("- Digite el Costo al cliente")
        End If

        If Val(TxtPesoCarga.Text) = 0 Then
            ListaErrores.Add("- Digite el Peso de la Carga")
        End If

        If CmbZona.SelectedValue <> CmbTerminales.SelectedValue Then
            ListaErrores.Add("- La zona seleccionada no corresponde a la terminal del centro de costo!")
        End If

        Dim CostoTransporte As Decimal
        Dim ValorTonelada As Double
        Dim Utilidad As Decimal

        CostoTransporte = TxtCosto.Tag + TxtCD.Tag + TxtOtrosCobros.Tag

        If CostoTransporte <> TxtCostoTrans.Tag Then
            ListaErrores.Add("- El costo total de transporte NO es correcto!")
        End If

        ValorTonelada = TxtValorCliente.Tag / TxtPesoCarga.Text

        If ValorTonelada <> TxtValorTon.Tag Then
            ListaErrores.Add("- El Valor de la tonelada no es correcto!")
        End If

        Utilidad = TxtValorCliente.Tag - CostoTransporte

        If Utilidad <> TxtUtilidad.Tag Then
            ListaErrores.Add("- El calculo de la Utilidad no es correcto!")
        End If


        Return ListaErrores

    End Function
    Sub Cargarcombos()

        '-------------------- Cargo los Transportadores ------
        Dim Tabla1 As New DataTable
        Dim Consulta1 As SqlDataReader
        Consulta1 = Transportador.ListarTransport()

        Tabla1.Load(Consulta1)

        Me.CmbTransportadora.DisplayMember = "TRANSPORTADOR"
        Me.CmbTransportadora.ValueMember = "CODIGO"
        Me.CmbTransportadora.DataSource = Tabla1
        Me.CmbTransportadora.Text = ""

        '-----------------------------------------------------

        '-------------- Cargo Los Tipos de Vehiculos ---------
        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TVehiculosDespachos")

        Me.CmbTipoVehiculo.DisplayMember = "TIPO"
        Me.CmbTipoVehiculo.ValueMember = "ID"
        Me.CmbTipoVehiculo.DataSource = dv
        Me.CmbTipoVehiculo.Text = ""
        '-----------------------------------------------------

        '-------------- Cargo Zonas --------------------------
        Dim dv1 As New DataView

        dv1.Table = Gl_DataSet.Tables("TZonas")

        Me.CmbZona.DisplayMember = "ZONA"
        Me.CmbZona.ValueMember = "IDZONA"
        Me.CmbZona.DataSource = dv1
        Me.CmbZona.Text = ""
        '-----------------------------------------------------

        '-------------- Cargo Tipo Despacho --------------------------
        Dim dv2 As New DataView

        dv2.Table = Gl_DataSet.Tables("TDespachos")

        Me.CmbTipoDespacho.DisplayMember = "TIPODESPACHO"
        Me.CmbTipoDespacho.ValueMember = "IDDESPACHO"
        Me.CmbTipoDespacho.DataSource = dv2
        Me.CmbTipoDespacho.Text = ""
        '-----------------------------------------------------

        '-------------- Cargo Terminales --------------------------
        Dim dv3 As New DataView

        dv3.Table = Gl_DataSet.Tables("TTerminales")

        Me.CmbTerminales.DisplayMember = "TERMINAL"
        Me.CmbTerminales.ValueMember = "IDTERMINAL"
        Me.CmbTerminales.DataSource = dv3
        Me.CmbTerminales.Text = ""
        '-----------------------------------------------------

    End Sub

    Function ValidarFecha(Fecha) As Boolean


        Try

            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Despachos.ConsultarFecha(Fecha)
            Tabla.Load(Consulta)

            ' Tomo el ultimo registro de la consulta que representa el dia maximo para permitir la edición

            Dim Row As DataRow = Tabla.Rows(Tabla.Rows.Count - 1)
            Dim FechaEdicion As DateTime = Row("FECHA")

            ' Si la fecha actual es mayor a la fecha maxima de edición indicara que no es posible la misma. 
            If Date.Now > FechaEdicion Then
                ValidarFecha = False
            Else
                ValidarFecha = True
            End If

        Catch ex As Exception
            ValidarFecha = False
        End Try


    End Function
    Private Sub For_RegistroTransporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cargarcombos()

        DTFecha.SelectionStart = Date.Now.Year & "/" & Date.Now.Month & "/" & Date.Now.Day


        If GL_Editar = 1 Then '- Validacion para cargar datos de Edición 


            Try

                '---- Consulto los datos del Numero de Depacho para Cargar los datos ---------
                Dim Consulta As SqlDataReader
                Dim Tabla As New DataTable

                Consulta = Despachos.ConsultarDespacho(3, TxtDespacho.Text)
                Tabla.Load(Consulta)

                Dim Row As DataRow = Tabla.Rows(Tabla.Rows.Count - 1)

                Dim Fecha As DateTime = Row("FECHA")

                LblCliente.Tag = Row("IDCLIENTE")
                LblCliente.Text = Trim(Row("CLIENTE"))
                LblOrigen.Tag = Row("DIVIORIGEN")
                LblOrigen.Text = Row("ORIGEN")
                LblDestino.Tag = Row("DIVIDESTINO")
                LblDestino.Text = Row("DESTINO")
                TxtPlaca.Text = Row("PLACA")
                LblProducto.Tag = Row("IDPRODUCTO")
                LblProducto.Text = Trim(Row("PRODUCTO"))
                DTFecha.SetDate(Fecha)
                DTFecha.AddBoldedDate(Fecha)
                TxtValorDeclarado.Tag = Row("VALOR")
                TxtValorDeclarado.Text = FormatCurrency(Row("VALOR"), 0)
                TxtManifiesto.Text = Trim(Row("MANIFIESTO"))
                TxtRemesa.Text = Trim(Row("REMESA"))
                CmbTipoDespacho.SelectedText = Row("TIPODESPACHO")
                CmbTipoDespacho.SelectedValue = Row("IDDESPACHO")
                CmbZona.SelectedText = Row("ZONA")
                CmbZona.SelectedValue = Row("IDZONA")
                CmbTerminales.SelectedText = Row("TERMINAL")
                CmbTerminales.SelectedValue = Row("IDTERMINAL")
                CmbSegmentos.SelectedText = Row("SEGMENTO")
                CmbSegmentos.SelectedValue = Row("IDSEGMENTO")
                TxtCeCo.Text = Row("CECO")
                CmbTransportadora.SelectedText = Trim(Row("TRANSPORTADOR"))
                CmbTransportadora.SelectedValue = Row("IDTRANSP")
                CmbTipoVehiculo.SelectedText = Row("TIPOVEHICULO")
                CmbTipoVehiculo.SelectedValue = Row("IDTIPOVEH")
                TxtCosto.Tag = Row("COSTO")
                TxtCosto.Text = FormatCurrency(Row("COSTO"), 0)
                TxtCD.Tag = Row("CARGUEDESCARGUE")
                TxtCD.Text = FormatCurrency(Row("CARGUEDESCARGUE"), 0)
                TxtCostoTrans.Tag = Row("COSTOTRANSPORTE")
                TxtCostoTrans.Text = FormatCurrency(Row("COSTOTRANSPORTE"), 0)
                TxtValorTon.Tag = Row("TONELADA")
                TxtValorTon.Text = FormatCurrency(Row("TONELADA"), 2)
                TxtPesoCarga.Text = Row("PESOCARGA")
                TxtValorCliente.Tag = Row("VALORCLIENTE")
                TxtValorCliente.Text = FormatCurrency(Row("VALORCLIENTE"), 0)
                TxtUtilidad.Tag = Row("UTILIDAD")
                TxtUtilidad.Text = FormatCurrency(Row("UTILIDAD"), 0)
                TxtMargen.Text = Row("MARGEN")
                TxtMargen.Tag = Row("MARGEN")
                TxtRemision.Text = Trim(Row("REMISIONES"))
                TxtFactura.Text = Trim(Row("FACTURA"))
                TxtObservacion.Text = Row("OBSERVACIONES")

                '--------------------------------------------------------------------

                '---------Cargar los Registros existentes para ese Despacho ---------

                DGCobros.DataSource = Nothing

                Dim Consulta1 As SqlDataReader
                Dim Tabla1 As New DataTable

                Try
                    Consulta1 = Despachos.DetalleCobros(8, TxtDespacho.Text)
                    Tabla1.Load(Consulta1)
                    'DGCobros.DataSource = Tabla
                    Dim Row1 As DataRow

                    For I = 0 To Tabla1.Rows.Count - 1
                        Row1 = Tabla1.Rows(I)
                        DGCobros.Rows.Add(Row1("NUMDESPACHO"), Row1("IDCOBRO"), Row1("DESCRIPCION"), Row1("VALOR"))
                        Suma += Row1("VALOR")
                    Next

                    DGCobros.Columns("IDCOBRO").Visible = False

                    TxtOtrosCobros.Tag = Suma
                    TxtOtrosCobros.Text = FormatCurrency(Suma, 0)

                Catch ex As Exception

                End Try
                '--------------------------------------------------------------------



            Catch ex As Exception

            End Try


        End If


        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Me.PanelPrincipal.Left = (Me.Width / 2) - (Me.PanelPrincipal.Width / 2)

    End Sub
    Private Sub CmbTerminales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTerminales.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbSegmentos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbSegmentos.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbTipoDespacho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoDespacho.SelectedIndexChanged
        CmbTipoVehiculo.Focus()
    End Sub
    Private Sub CmbTipoVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoVehiculo.SelectedIndexChanged
        TxtPlaca.Focus()
    End Sub
    Private Sub CmbZona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbZona.SelectedIndexChanged
        CmbTipoDespacho.Focus()
    End Sub
    Private Sub CmbTerminales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTerminales.SelectedIndexChanged

        Try

            '-------------------- Cargo los Segmentos -------------
            Dim Tabla As New DataTable
            Dim Consulta2 As SqlDataReader
            Consulta2 = CentroCosto.ListarCentros(4, Trim(CmbTerminales.SelectedValue))

            Tabla.Load(Consulta2)

            Me.CmbSegmentos.DisplayMember = "SEGMENTO"
            Me.CmbSegmentos.ValueMember = "IDSEGMENTO"
            Me.CmbSegmentos.DataSource = Tabla
            Me.CmbSegmentos.Text = ""

            '-----------------------------------------------------
            TxtCeCo.Text = ""


            Consulta2.Close()

        Catch ex As Exception

        End Try



        CmbSegmentos.Focus()

    End Sub
    Private Sub CmbSegmentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSegmentos.SelectedIndexChanged

        '-------------------- Cargo los Centros de Costo -------------
        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = CentroCosto.ListarClientes(CmbTerminales.SelectedValue, CmbSegmentos.SelectedValue)

        Tabla.Load(Consulta)

        Me.CmbCliente.DisplayMember = "CLIENTE"
        Me.CmbCliente.ValueMember = "CECO"
        Me.CmbCliente.DataSource = Tabla
        Me.CmbCliente.Text = ""

        Consulta.Close()
        '-----------------------------------------------------
        TxtCeCo.Text = ""
        CmbCliente.Focus()


    End Sub
    Private Sub CmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCliente.SelectedIndexChanged

        TxtCeCo.Text = CmbCliente.SelectedValue
        TxtRemision.Focus()
    End Sub
    Private Sub CmbTransportadora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTransportadora.SelectedIndexChanged
        TxtRemesa.Focus()
    End Sub

    Private Sub TxtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCosto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtCD.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtCosto_LostFocus(sender As Object, e As EventArgs) Handles TxtCosto.LostFocus
        Try
            If TxtCosto.Text = "" Then
                TxtCosto.Text = "$ 0"
                TxtCosto.Tag = 0
            Else

                TxtCosto.Tag = Val(TxtCosto.Text)
                TxtCosto.Text = FormatCurrency(TxtCosto.Tag, 0)

            End If

        Catch ex As Exception
        End Try
    End Sub
    Private Sub TxtCosto_GotFocus(sender As Object, e As EventArgs) Handles TxtCosto.GotFocus
        Try
            If TxtCosto.Text = "$ 0" Then
                TxtCosto.Text = ""
            Else
                TxtCosto.Text = CType(TxtCosto.Text, Decimal)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtCD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCD.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtCostoTrans.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtCD_LostFocus(sender As Object, e As EventArgs) Handles TxtCD.LostFocus
        Try
            If TxtCD.Text = "" Then
                TxtCD.Text = "$ 0"
                TxtCD.Tag = 0
            Else
                TxtCD.Tag = Val(TxtCD.Text)
                TxtCD.Text = FormatCurrency(TxtCD.Tag, 0)
            End If

            TxtCostoTrans.Text = TxtCosto.Tag + TxtCD.Tag + TxtOtrosCobros.Text

        Catch ex As Exception
        End Try
    End Sub
    Private Sub TxtCD_GotFocus(sender As Object, e As EventArgs) Handles TxtCD.GotFocus
        Try
            If TxtCD.Text = "$ 0" Then
                TxtCD.Text = ""
            Else
                TxtCD.Text = CType(TxtCD.Text, Decimal)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtCostoTrans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCostoTrans.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtPesoCarga.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtCostoTrans_LostFocus(sender As Object, e As EventArgs) Handles TxtCostoTrans.LostFocus
        Try
            If TxtCostoTrans.Text = "" Then
                TxtCostoTrans.Text = "$ 0"
                TxtCostoTrans.Tag = 0
            Else

                TxtCostoTrans.Tag = Val(TxtCostoTrans.Text)
                TxtCostoTrans.Text = FormatCurrency(TxtCostoTrans.Tag, 0)

            End If

        Catch ex As Exception
        End Try
    End Sub
    Private Sub TxtCostoTrans_GotFocus(sender As Object, e As EventArgs) Handles TxtCostoTrans.GotFocus
        Try
            If TxtCostoTrans.Text = "$ 0" Then
                TxtCostoTrans.Text = ""
                TxtCostoTrans.Text = TxtCosto.Tag + TxtCD.Tag
            Else
                TxtCostoTrans.Text = CType(TxtCostoTrans.Text, Decimal)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtPesoCarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPesoCarga.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TxtValorCliente.Focus()
        Else
            If Asc(e.KeyChar) = 44 Then
                e.Handled = False
                Exit Sub
            End If
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If

    End Sub


    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click

        Gl_Cliente.CargareldatasetTransporte() ' Cargo los Clientes Actuales en el Dataset Global
        Gl_Cliente.LimpiarVariableGlobal() ' Limpio la variable Global de Clientes 


        For_ClientesTransporteBuscar.ShowDialog()

        If Gl_Cliente.Codigo = "" Then ' Si no selecciona ningun cliente no debe Continuar.
            Exit Sub
        End If

        Me.LblCliente.Tag = Gl_Cliente.Codigo
        Me.LblCliente.Text = Gl_Cliente.Cliente
    End Sub
    Private Sub BtnBuscaOrigen_Click(sender As Object, e As EventArgs) Handles BtnBuscaOrigen.Click

        Gl_Divipolitica.Pais = ""
        Gl_Divipolitica.NombreDepto = ""
        Gl_Divipolitica.NombreMunicipio = ""
        Gl_Divipolitica.CodigoPoblado = ""


        For_Divipoliticas.ShowDialog()

        Me.LblOrigen.Tag = Gl_Divipolitica.CodigoPoblado
        Me.LblOrigen.Text = Gl_Divipolitica.NombreMunicipio
    End Sub
    Private Sub BtnBuscaDestino_Click(sender As Object, e As EventArgs) Handles BtnBuscaDestino.Click

        Gl_Divipolitica.Pais = ""
        Gl_Divipolitica.NombreDepto = ""
        Gl_Divipolitica.NombreMunicipio = ""
        Gl_Divipolitica.CodigoPoblado = ""


        For_Divipoliticas.ShowDialog()

        Me.LblDestino.Tag = Gl_Divipolitica.CodigoPoblado
        Me.LblDestino.Text = Gl_Divipolitica.NombreMunicipio

        CmbZona.Focus()
    End Sub
    Private Sub CmbTipoDespacho_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTipoDespacho.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbTipoVehiculo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTipoVehiculo.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbZona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbZona.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbTransportadora_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTransportadora.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCliente.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtRemision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRemision.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtFactura.Focus()
        End If
    End Sub
    Private Sub TxtFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFactura.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtValorDeclarado.Focus()
        End If
    End Sub
    Private Sub TxtPesoCarga_LostFocus(sender As Object, e As EventArgs) Handles TxtPesoCarga.LostFocus

        TxtPesoCarga.Text = Replace(TxtPesoCarga.Text, ".", ",")
        TxtPesoCarga.Tag = TxtPesoCarga.Text
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Try

            Despachos.Fecha = Format(DTFecha.SelectionStart, "yyyy-MM-dd")
            Despachos.Cliente = LblCliente.Tag
            Despachos.Origen = LblOrigen.Tag
            Despachos.Destino = LblDestino.Tag
            Despachos.Zona = CmbZona.SelectedValue
            Despachos.TipoDespacho = CmbTipoDespacho.SelectedValue
            Despachos.TipoVehiculo = CmbTipoVehiculo.SelectedValue
            Despachos.Placa = TxtPlaca.Text
            Despachos.Transportador = CmbTransportadora.SelectedValue
            Despachos.Remesa = TxtRemesa.Text
            Despachos.Manifiesto = TxtManifiesto.Text
            Despachos.Ceco = TxtCeCo.Text
            Despachos.Remision = TxtRemision.Text
            Despachos.Factura = TxtFactura.Text
            Despachos.Valor = TxtValorDeclarado.Tag
            Despachos.Producto = LblProducto.Tag
            Despachos.Costo = TxtCosto.Tag
            Despachos.CargueDescargue = TxtCD.Tag
            Despachos.CostoTransporte = TxtCostoTrans.Tag
            Despachos.ValorTonelada = TxtValorTon.Tag
            Despachos.PesoCarga = TxtPesoCarga.Text
            Despachos.ValorCliente = TxtValorCliente.Tag
            Despachos.OtrosCobros = TxtOtrosCobros.Tag
            Despachos.Utilidad = TxtUtilidad.Tag
            Despachos.Margen = TxtMargen.Tag
            Despachos.Observacion = TxtObservacion.Text


            '------Detalle de los otros Cobros ---------
            Despachos.OtrosCobrosDetalle = DGCobros
            '-------------------------------------------

            Dim Respuesta = Despachos.GuardarDespacho()

            If Respuesta = True Then
                MsgBox("Despacho Registrado Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
                Me.Dispose()

                'For_BitacoraTransporte.DGInforme.DataSource = Nothing
                'For_BitacoraTransporte.Listar(Date.Now.Year & "/" & Date.Now.Month & "/" & "01", Date.Now)

            Else
                MsgBox("No fue Posible Registrar el despacho. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
            End If

        Catch ex As Exception

        End Try

        '-----------------------------------------------------------


    End Sub

    Private Sub TxtValorDeclarado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValorDeclarado.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtCosto.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtValorDeclarado_LostFocus(sender As Object, e As EventArgs) Handles TxtValorDeclarado.LostFocus
        Try
            If TxtValorDeclarado.Text = "" Then
                TxtValorDeclarado.Text = "$ 0"
                TxtValorDeclarado.Tag = 0
            Else

                TxtValorDeclarado.Tag = Val(TxtValorDeclarado.Text)
                TxtValorDeclarado.Text = FormatCurrency(TxtValorDeclarado.Tag, 0)

            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtRemesa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRemesa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtManifiesto.Focus()
        End If
    End Sub
    Private Sub TxtManifiesto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtManifiesto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmbTerminales.Focus()
        End If
    End Sub

    Private Sub BtnBuscaProducto_Click(sender As Object, e As EventArgs) Handles BtnBuscaProducto.Click

        For_ProductosTransporte.ShowDialog()

        LblProducto.Tag = Gl_Producto.IdProducto
        LblProducto.Text = Gl_Producto.Descripcion

        TxtValorDeclarado.Focus()

    End Sub
    Private Sub TxtPlaca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPlaca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmbTransportadora.Focus()
        End If
    End Sub
    Private Sub For_RegistroTransporte_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub TxtValorDeclarado_GotFocus(sender As Object, e As EventArgs) Handles TxtValorDeclarado.GotFocus
        Try
            If TxtValorDeclarado.Text = "$ 0" Then
                TxtValorDeclarado.Text = ""
            Else
                TxtValorDeclarado.Text = CType(TxtValorDeclarado.Text, Decimal)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        '------------- Verificar que aun puede editar despues de X Dias despues del fin de mes ------

        Dim Rta = ValidarFecha(Format(DTFecha.SelectionStart, "yyyy-MM-dd"))

        If Rta = False Then
            MsgBox("No es posible editar el despacho, el tiempo máximo permitido para la edición a finalizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        '--------------------------------------------------------------------------------------------

        Try

            Despachos.NumDespacho = Trim(TxtDespacho.Text)
            Despachos.Fecha = Format(DTFecha.SelectionStart, "yyyy-MM-dd")
            Despachos.Cliente = LblCliente.Tag
            Despachos.Origen = LblOrigen.Tag
            Despachos.Destino = LblDestino.Tag
            Despachos.Zona = CmbZona.SelectedValue
            Despachos.TipoDespacho = CmbTipoDespacho.SelectedValue
            Despachos.TipoVehiculo = CmbTipoVehiculo.SelectedValue
            Despachos.Placa = TxtPlaca.Text
            Despachos.Transportador = CmbTransportadora.SelectedValue
            Despachos.Remesa = TxtRemesa.Text
            Despachos.Manifiesto = TxtManifiesto.Text
            Despachos.Ceco = TxtCeCo.Text
            Despachos.Remision = TxtRemision.Text
            Despachos.Factura = TxtFactura.Text
            Despachos.Valor = TxtValorDeclarado.Tag
            Despachos.Producto = LblProducto.Tag
            Despachos.Costo = TxtCosto.Tag
            Despachos.CargueDescargue = TxtCD.Tag
            Despachos.CostoTransporte = TxtCostoTrans.Tag
            Despachos.ValorTonelada = TxtValorTon.Tag
            Despachos.PesoCarga = TxtPesoCarga.Text
            Despachos.ValorCliente = TxtValorCliente.Tag
            Despachos.OtrosCobros = TxtOtrosCobros.Tag
            Despachos.Utilidad = TxtUtilidad.Tag
            Despachos.Margen = TxtMargen.Tag 'n
            Despachos.Observacion = TxtObservacion.Text

            '------Detalle de los otros Cobros ---------
            Despachos.OtrosCobrosDetalle = DGCobros
            '-------------------------------------------

            Dim Respuesta = Despachos.ActualizarDespacho()

            If Respuesta = "OK" Then
                MsgBox("Despacho Actualizado Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
                Me.Dispose()
            Else
                MsgBox("No fue Posible Actualizar el despacho. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
            End If

        Catch ex As Exception

        End Try




    End Sub
    Private Sub TxtValorCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValorCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtObservacion.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtValorCliente_GotFocus(sender As Object, e As EventArgs) Handles TxtValorCliente.GotFocus
        Try
            If TxtValorCliente.Text = "$ 0" Then
                TxtValorCliente.Text = ""
            Else
                TxtValorCliente.Text = CType(TxtValorCliente.Text, Decimal)
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub TxtValorCliente_LostFocus(sender As Object, e As EventArgs) Handles TxtValorCliente.LostFocus

        Try
            If TxtValorCliente.Text = "" Then
                TxtValorCliente.Text = "$ 0"
                TxtValorCliente.Tag = 0
            Else

                TxtValorCliente.Tag = Val(TxtValorCliente.Text)
                TxtValorCliente.Text = FormatCurrency(TxtValorCliente.Tag, 0)

            End If

            TxtValorTon.Tag = TxtValorCliente.Tag / TxtPesoCarga.Tag
            TxtValorTon.Text = FormatCurrency(TxtValorTon.Tag, 2)

            TxtUtilidad.Tag = TxtValorCliente.Tag - TxtCostoTrans.Tag
            TxtUtilidad.Text = FormatCurrency(TxtUtilidad.Tag, 0)

            TxtMargen.Tag = Math.Round((TxtUtilidad.Tag / TxtValorCliente.Tag) * 100, 1)
            TxtMargen.Text = FormatPercent(TxtUtilidad.Tag / TxtValorCliente.Tag, 1)

        Catch ex As Exception
        End Try

    End Sub
    Private Sub BtnOtrosCobros_Click(sender As Object, e As EventArgs) Handles BtnOtrosCobros.Click

        For_BitacoraOtrosCobros.TxtDespacho.Text = TxtDespacho.Text
        For_BitacoraOtrosCobros.ShowDialog()

        TxtCostoTrans.Text = TxtCosto.Tag + TxtCD.Tag + TxtOtrosCobros.Tag

        TxtCostoTrans.Focus()


    End Sub

End Class