Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class For_IngresoMercancia
    Dim Centro As New Centros()
    Dim Bodega As New Bodegas()
    Dim Deposito As New Depositos()
    Dim Transportador As New Transportadores()
    Dim EntradaMercancia As New EntradasMercancia()
    Dim Fila As Integer
    Dim ProductoIngresar As New ProductoIngreso()

    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If Trim(CmbCentros.Text) = "" Then
            ListaErrores.Add("- Seleccione el Centro de Distribución")
        End If

        If Trim(CmbBodegas.Text) = "" Then
            ListaErrores.Add("- Seleccione la Bodega.")
        End If

        If Trim(TxtCodCliente.Text) = "" Then
            ListaErrores.Add("- Seleccione el Cliente dueño del Producto.")
        End If

        If ChkTransporte.Checked = False Then

            If Trim(CmbTransportadora.Text) = "" Then
                ListaErrores.Add("- Seleccione la Empresa que Realizó el Transporte.")
            End If

            If Trim(TxtLetrasPlaca.Text) = "" Or Trim(TxtNumeroPlaca.Text) = "" Then
                ListaErrores.Add("- Ingrese la Placa del Vehículo Correctamente")
            End If

            If Trim(CmbTipoVehiculo.Text) = "" Then
                ListaErrores.Add("- Seleccione el Tipo de Vehículo")
            End If

            If Trim(TxtDocumento.Text) = "" Then
                ListaErrores.Add("- Digite el Número de Documento del Conductor")
            End If

            If Trim(TxtNombreConductor.Text) = "" Or TxtApellidosConductor.Text = "" Then
                ListaErrores.Add("- Digite el Nombre del Conductor")
            End If

        End If


        If DGProductos.Rows.Count = 0 Then
            ListaErrores.Add("- Ingrese los Productos Correspondientes al Ingreso de Mercancia.")
        End If

        If DGArchivos.Rows.Count = 0 Then
            ListaErrores.Add("- Ingrese Mínimo un Documento de Referencia.")
        End If

        If TxtObservacion.Text = "" Then
            ListaErrores.Add("- Ingrese una observación sobre el ingreso de la Mercancia.")
        End If


        If TxtValorTotal.Text = "" Then
            ListaErrores.Add("- Registre las cantidades por el servicio de descargue")
        End If

        Dim Suma As Decimal
        Dim NombreProducto As String


        For i = 0 To DGProductos.Rows.Count - 1
            If DGProductos.Rows(i).Cells(8).Value > 0 Then ' Si el producto tiene material bloqueado debe detallarlo.

                NombreProducto = Trim(DGProductos.Rows(i).Cells(1).Value)
                Suma = 0

                For j = 0 To DGDetalleBloqueo.Rows.Count - 1

                    If (DGProductos.Rows(i).Cells(0).Value = DGDetalleBloqueo.Rows(j).Cells(0).Value) And (DGProductos.Rows(i).Cells(7).Value) = DGDetalleBloqueo.Rows(j).Cells(7).Value Then
                        Suma += DGDetalleBloqueo.Rows(j).Cells(1).Value
                    End If

                Next

                If Suma < DGProductos.Rows(i).Cells(8).Value Then
                    ListaErrores.Add("- El Producto " + NombreProducto + " Con número de Lote " + (DGProductos.Rows(i).Cells(7).Value).ToString + " Contiene Material Bloqueado que se debe Detallar.")
                End If


            End If

        Next


        Return ListaErrores

    End Function
    Sub ValidarConductor(Documento)

        Dim Conductor As New Conductores()
        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = Conductor.ListarConductores(Documento)

        If Consulta.Read() Then
            TxtNombreConductor.Text = Trim(Consulta("NOMBRE").ToString())
            TxtApellidosConductor.Text = Trim(Consulta("APELLIDO").ToString())
        End If

        Consulta.Close()

    End Sub
    Sub CargarCombos()

        '-------------------- Cargo los Centros -------------
        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = Centro.ListarCentro()

        Tabla.Load(Consulta)

        Me.CmbCentros.DisplayMember = "NOMBRE"
        Me.CmbCentros.ValueMember = "CODIGO"
        Me.CmbCentros.DataSource = Tabla
        Me.CmbCentros.Text = ""
        '-----------------------------------------------------

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

        dv.Table = Gl_DataSet.Tables("TVehiculos")

        Me.CmbTipoVehiculo.DisplayMember = "TIPO"
        Me.CmbTipoVehiculo.ValueMember = "ID"
        Me.CmbTipoVehiculo.DataSource = dv
        Me.CmbTipoVehiculo.Text = ""
        '-----------------------------------------------------

        '-------------- Cargo Las Presentaciones ------------
        Dim dv1 As New DataView

        dv1.Table = Gl_DataSet.Tables("TPresentacion")

        Me.CmbPresentacion.DisplayMember = "DESCRIPCION"
        Me.CmbPresentacion.ValueMember = "ID"
        Me.CmbPresentacion.DataSource = dv1
        Me.CmbPresentacion.Text = ""
        '-----------------------------------------------------

        '-------------- Cargo Los Tipo de Documento ------------
        Dim dv2 As New DataView
        dv2.Table = Gl_DataSet.Tables("TDocumento")

        Me.CmbReferencia1.DisplayMember = "DOCUMENTO"
        Me.CmbReferencia1.ValueMember = "IDDOC"
        Me.CmbReferencia1.DataSource = dv2
        Me.CmbReferencia1.Text = ""

        '-----------------------------------------------------

    End Sub
    Private Sub CmbCentros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCentros.SelectedIndexChanged

        '------------ Listo las Bodegas del Centro Seleccionado ---------------
        CmbBodegas.DataSource = Nothing

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = Bodega.ListarBodegas(CmbCentros.SelectedValue)

        Tabla.Load(Consulta)

        Me.CmbBodegas.DisplayMember = "DESCRIPCION"
        Me.CmbBodegas.ValueMember = "CODIGO"
        Me.CmbBodegas.DataSource = Tabla

        Me.CmbBodegas.Text = ""

        Consulta.Close()
        '-------------------------------------------------------------------------

        CmbBodegas.Focus()

    End Sub
    Private Sub CmbCentros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCentros.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbBodegas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBodegas.SelectedIndexChanged

        ' --- Si Cambia de Bodega toc limpiar los datos del Cliente para seleccionar uno nuevo por cuestion del Deposito
        Me.TxtCodCliente.Text = ""
        Me.LblNombreCliente.Text = ""
        Me.TxtDeposito.Text = ""

        DGProductos.Rows.Clear()
        DGDetalleBloqueo.Rows.Clear()
        ProductoIngresar.Bloqueado = 0
        TxtCantidadTotal.Text = 0


        Gl_Cliente.LimpiarVariableGlobal()

        BtnBuscar.Focus()

    End Sub
    Private Sub CmbBodegas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbBodegas.KeyPress
        e.Handled = True
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        If Trim(CmbBodegas.Text) = "" Then
            MsgBox("Debe Selecionar primero la Bodega!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            CmbBodegas.Focus()
            Exit Sub
        End If

        Gl_Cliente.Cargareldataset() ' Cargo los Clientes Actuales en el Dataset Global
        Gl_Cliente.LimpiarVariableGlobal() ' Limpio la variable Global de Clientes 


        For_ClientesBuscar.ShowDialog()

        If Gl_Cliente.Codigo = "" Then ' Si no selecciona ningun cliente no debe Continuar.
            Exit Sub
        End If

        Me.TxtCodCliente.Text = Gl_Cliente.Codigo
        Me.LblNombreCliente.Text = Gl_Cliente.Cliente

        Dim Consulta As SqlDataReader
        Dim Codigo As String = ""

        Consulta = Deposito.CodigoDeposito(CmbBodegas.SelectedValue, Gl_Cliente.Codigo)

        If Consulta.Read() Then
            Codigo = Trim(Consulta("CODIGO").ToString())
        End If
        Consulta.Close()

        If Trim(Codigo) = "" Then
            MsgBox("El cliente Seleccionado No Cuenta con Deposito En la Bodega Indicada!", MsgBoxStyle.Critical, Gl_NomCompañia)

            '------------Mandarlo A crear deposito -----

            Deposito.CargarCombos()

            For_Depositos.GBCodigoDeposito.Visible = False
            For_Depositos.BtnActualizar.Visible = False
            For_Depositos.BtnCrear.Visible = True
            For_Depositos.ShowDialog()

            '-------------------------------------------

            Me.TxtCodCliente.Text = ""
            Me.LblNombreCliente.Text = ""
            Me.TxtDeposito.Text = ""

            MsgBox("Seleccione de Nuevo el Cliente!", MsgBoxStyle.Information, Gl_NomCompañia)
        Else
            Me.TxtDeposito.Text = Codigo

        End If

        '--------- Limpiar datos por si ya tenia seleccionados y cambio el cliente ----- 
        DGProductos.Rows.Clear()
        DGDetalleBloqueo.Rows.Clear()
        ProductoIngresar.Bloqueado = 0
        TxtCantidadTotal.Text = 0
        '---------------------------------------------------------------------------------

    End Sub
    Private Sub CmbTransportadora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTransportadora.SelectedIndexChanged
        TxtDocumento.Focus()
    End Sub
    Private Sub CmbTransportadora_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTransportadora.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbTipoVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoVehiculo.SelectedIndexChanged
        TxtDocumento.Focus()
    End Sub
    Private Sub CmbTipoVehiculo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTipoVehiculo.KeyPress
        e.Handled = True
    End Sub
    Private Sub TxtNombreConductor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombreConductor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtApellidosConductor.Focus()
        Else
            Dim Rta As Boolean
            Rta = Sololetras(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtApellidosConductor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellidosConductor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtLetrasPlaca.Focus()
        Else
            Dim Rta As Boolean
            Rta = Sololetras(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub CmbPresentacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPresentacion.SelectedIndexChanged


        If IsNumeric(TxtCantidad.Text) = True Then

            Dim Resultado As String
            Resultado = CalcularBultos(CmbPresentacion.SelectedValue, TxtCantidad.Text)

            If Resultado = "" Then
                TxtCantidad.Focus()
                CmbPresentacion.Text = ""
                MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación Ingresada!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Else
                TxtBultos.Text = Resultado
                TxtLote.Focus()
            End If


        Else
            TxtCantidad.Focus()
        End If

        TxtLote.Focus()

    End Sub
    Private Sub CmbPresentacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbPresentacion.KeyPress

        If Asc(e.KeyChar) = 13 And CmbPresentacion.Text <> "" Then

            Dim Resultado As String
            Resultado = CalcularBultos(CmbPresentacion.SelectedValue, TxtCantidad.Text)

            If Resultado = "" Then
                TxtCantidad.Focus()
                'MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación Ingresada!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Else
                TxtBultos.Text = Resultado
                TxtLote.Focus()
            End If


        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TxtLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLote.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtCantidadBloqueo.Focus()
        End If
    End Sub
    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

        If TxtCodigoProducto.Text = "" Then
            MsgBox("Seleccione el Producto que Desea Adicionar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            BtnProducto.Focus()
            Exit Sub
        End If

        If Val(TxtCantidad.Text) = 0 And Val(TxtCantidadBloqueo.Text) = 0 And Val(TxtCantidadSobrante.Text) = 0 Then
            MsgBox("Registre la cantidad de material a Ingresar", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        If CmbPresentacion.Text = "" Then
            MsgBox("Indique la Forma de Presentación del Producto!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbPresentacion.Focus()
            Exit Sub
        End If

        If Val(TxtCantidad.Text) > 0 And Trim(TxtBultos.Text) = "" Then
            MsgBox("No fue posible realizar el Cálculo de Bultos. Establezca de Nuevo la Presentación", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbPresentacion.Text = ""
            TxtCantidad.Focus()
            Exit Sub
        End If

        If TxtLote.Text = "" Then
            MsgBox("Indique el Número de Lote del Producto!", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtLote.Focus()
            Exit Sub
        End If

        For i = 0 To DGProductos.Rows.Count - 1
            If (Trim(TxtCodigoProducto.Text) = Trim(DGProductos.Rows(i).Cells(0).Value)) And (Trim(TxtLote.Text) = Trim(DGProductos.Rows(i).Cells(6).Value)) Then
                MsgBox("Este producto ya fue ingresado con el mismo número de Lote.", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            End If
        Next

        Dim CantidadIngreso As Decimal = TxtCantidad.Text
        Dim CantidadBloqueo As Decimal

        If Trim(TxtCantidadBloqueo.Text) = "" Then
            CantidadBloqueo = 0
        Else
            CantidadBloqueo = CType(TxtCantidadBloqueo.Text, Decimal)

        End If


        DGProductos.Rows.Add(Trim(TxtCodigoProducto.Text),
                             Trim(LblProducto.Text),
                             CantidadIngreso,
                             Trim(LblUnidad.Text),
                             Trim(CmbPresentacion.Text),
                             Trim(CmbPresentacion.SelectedValue),
                             CalcularBultos(CmbPresentacion.SelectedValue, CantidadIngreso),
                             Trim(TxtLote.Text),
                             CantidadBloqueo,
                             CalcularBultos(CmbPresentacion.SelectedValue, CantidadBloqueo),
                             "",
                             "",
                             "",
                             "",
                             Val(TxtCantidadSobrante.Text),
                             CalcularBultos(CmbPresentacion.SelectedValue, Val(TxtCantidadSobrante.Text)))


        TxtCantidadTotal.Text += CantidadIngreso

        TxtCodigoProducto.Text = ""
        LblProducto.Text = ""
        TxtCantidad.Text = ""
        LblUnidad.Text = ""
        CmbPresentacion.Text = ""
        TxtBultos.Text = ""
        TxtLote.Text = ""
        TxtCantidadBloqueo.Text = ""
        TxtBultosBloqueo.Text = ""
        TxtCantidadSobrante.Text = ""
        TxtBultosSobrante.Text = ""

        DGProductos.ClearSelection()

    End Sub
    Private Sub CmbReferencia1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbReferencia1.SelectedIndexChanged
        TxtNumReferencia1.Focus()
    End Sub
    Private Sub CmbReferencia1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbReferencia1.KeyPress
        e.Handled = True
    End Sub
    Private Sub TxtNumReferencia1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumReferencia1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnSeleccionArchivo.Focus()
        End If
    End Sub
    Private Sub For_IngresoMercancia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCombos()

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Me.TabControl1.Left = (Me.Width / 2) - (TabControl1.Width / 2)

    End Sub
    Private Sub TxtLetrasPlaca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLetrasPlaca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtNumeroPlaca.Focus()
        Else
            Dim Rta As Boolean
            Rta = Sololetras(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtNumeroPlaca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumeroPlaca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmbTipoVehiculo.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDocumento.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TxtNombreConductor.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub BtnProducto_Click(sender As Object, e As EventArgs) Handles BtnProducto.Click

        For_ProductosBuscar.ShowDialog()

        Me.TxtCodigoProducto.Text = Gl_Producto.Codigo
        Me.LblProducto.Text = Gl_Producto.Descripcion
        Me.LblUnidad.Text = Gl_Producto.Simbolo


        Me.TxtCantidad.Focus()


    End Sub
    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress

        If Asc(e.KeyChar) = 13 Then
            CmbPresentacion.Focus()
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
    Private Sub For_IngresoMercancia_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
    Private Sub DGProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProductos.CellClick

        Try
            Fila = e.RowIndex

            ProductoIngresar.Codigo = Trim(DGProductos.Rows(e.RowIndex).Cells(0).Value)
            ProductoIngresar.Producto = Trim(DGProductos.Rows(e.RowIndex).Cells(1).Value)
            ProductoIngresar.Cantidad = Trim(DGProductos.Rows(e.RowIndex).Cells(2).Value)
            ProductoIngresar.Unidad = Trim(DGProductos.Rows(e.RowIndex).Cells(3).Value)
            ProductoIngresar.Presentacion = Trim(DGProductos.Rows(e.RowIndex).Cells(5).Value)
            ProductoIngresar.Bultos = Trim(DGProductos.Rows(e.RowIndex).Cells(6).Value)
            ProductoIngresar.Lote = Trim(DGProductos.Rows(e.RowIndex).Cells(7).Value)
            ProductoIngresar.Bloqueado = Trim(DGProductos.Rows(e.RowIndex).Cells(8).Value)
            ProductoIngresar.Sobrante = Trim(DGProductos.Rows(e.RowIndex).Cells(13).Value)

        Catch ex As Exception
            ProductoIngresar.Bloqueado = 0
        End Try


    End Sub
    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        Me.TxtBultos.Text = ""
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        If RBItr.Checked = True Then
            DGTarifasServicios.Rows.Clear()
            DGTarifasServicios.Rows.Add(6, "SERVICIO ITR", TxtCantidadTotal.Text, 0, 0)
        End If

        '************************** Insertar Información a la Base de Datos ************************
        EntradaMercancia.Centro = CmbCentros.SelectedValue
        EntradaMercancia.Bodega = CmbBodegas.SelectedValue
        EntradaMercancia.Cliente = TxtCodCliente.Text
        EntradaMercancia.Deposito = TxtDeposito.Text


        If ChkTransporte.Checked = False Then
            EntradaMercancia.Transportadora = CmbTransportadora.SelectedValue
            EntradaMercancia.Placa = TxtLetrasPlaca.Text & TxtNumeroPlaca.Text
            EntradaMercancia.TipoVehiculo = CmbTipoVehiculo.SelectedValue
            EntradaMercancia.DocConductor = TxtDocumento.Text
            EntradaMercancia.NombConductor = TxtNombreConductor.Text
            EntradaMercancia.ApelConductor = TxtApellidosConductor.Text
        Else
            EntradaMercancia.Transportadora = "T000" ' No Aplica
            EntradaMercancia.Placa = "AAA000" ' No Aplica
            EntradaMercancia.TipoVehiculo = 0 ' No Aplica
            EntradaMercancia.DocConductor = "00000000" 'No Aplica
            EntradaMercancia.NombConductor = ""
            EntradaMercancia.ApelConductor = ""
        End If


        '-- Productos --
        EntradaMercancia.Productos = DGProductos
        '---------------

        '-- DetalleBloqueos ---
        EntradaMercancia.DetalleBloqueo = DGDetalleBloqueo
        '----------------------

        '-- Soportes --
        EntradaMercancia.Soportes = DGArchivos
        '--------------

        '---Recaudo Descargues ---
        EntradaMercancia.RecaudoDescargues = DGTarifasServicios
        '-------------------------

        EntradaMercancia.Observacion = TxtObservacion.Text

        Dim Respuesta = EntradaMercancia.GuardarMercancia(TxtCantidadTotal.Text, 1, TxtValorTotal.Text) 'Cantidad,Unidad,Total

        If Respuesta = True Then
            MsgBox("Mercancia Registrada Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        Else
            MsgBox("No fue Posible Registrar la Mercancia. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        '**************************************************************************************

    End Sub


    Private Sub TxtCantidadBloqueo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidadBloqueo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnAdicionar.Focus()
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
    Private Sub TxtCantidadSobrante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidadSobrante.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnAdicionar.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub

    Private Sub TxtCantidadBloqueo_LostFocus(sender As Object, e As EventArgs) Handles TxtCantidadBloqueo.LostFocus

        If IsNumeric(TxtCantidadBloqueo.Text) = True Then

            Dim Resultado As String
            Resultado = CalcularBultos(CmbPresentacion.SelectedValue, TxtCantidadBloqueo.Text)

            If Resultado = "" Then
                TxtCantidadBloqueo.Focus()
            Else
                TxtBultosBloqueo.Text = Resultado
            End If

        End If

    End Sub

    Private Sub TxtCantidadBloqueo_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidadBloqueo.TextChanged
        TxtBultosBloqueo.Text = ""
    End Sub

    Private Sub TxtCantidadSobrante_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidadSobrante.TextChanged
        TxtBultosSobrante.Text = ""
    End Sub

    Private Sub TxtCantidadSobrante_LostFocus(sender As Object, e As EventArgs) Handles TxtCantidadSobrante.LostFocus

        If IsNumeric(TxtCantidadSobrante.Text) = True Then

            Dim Resultado As String
            Resultado = CalcularBultos(CmbPresentacion.SelectedValue, TxtCantidadSobrante.Text)

            If Resultado = "" Then
                TxtCantidadSobrante.Focus()
            Else
                TxtBultosSobrante.Text = Resultado
            End If

        End If
    End Sub

    Private Sub BtnDetalleBloqueo_Click(sender As Object, e As EventArgs) Handles BtnDetalleBloqueo.Click
        Try

            If ProductoIngresar.Bloqueado = 0 Or IsNothing(ProductoIngresar.Bloqueado) Then
                MsgBox("No se Registro Producto Bloqueado para el Item Seleccionado!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                Exit Sub
            Else
                For_ProductoBloqueado.TxtCodigoProducto.Text = ProductoIngresar.Codigo
                For_ProductoBloqueado.LblNombreProducto.Text = ProductoIngresar.Producto
                For_ProductoBloqueado.TxtLote.Text = ProductoIngresar.Lote
                For_ProductoBloqueado.TxtCantidadProducto.Text = ProductoIngresar.Bloqueado
                For_ProductoBloqueado.LblUnidadProducto.Text = ProductoIngresar.Unidad
                For_ProductoBloqueado.LblUnidadDetalle.Text = ProductoIngresar.Unidad

                For i = 0 To DGDetalleBloqueo.Rows.Count - 1

                    If (Me.DGDetalleBloqueo.Rows(i).Cells(0).Value = Trim(ProductoIngresar.Codigo)) And (Me.DGDetalleBloqueo.Rows(i).Cells(7).Value = Trim(ProductoIngresar.Lote)) Then
                        For_ProductoBloqueado.DGBloqueo.Rows.Add(DGDetalleBloqueo.Rows(i).Cells(0).Value, DGDetalleBloqueo.Rows(i).Cells(1).Value, DGDetalleBloqueo.Rows(i).Cells(2).Value, DGDetalleBloqueo.Rows(i).Cells(3).Value, DGDetalleBloqueo.Rows(i).Cells(4).Value, DGDetalleBloqueo.Rows(i).Cells(5).Value, DGDetalleBloqueo.Rows(i).Cells(6).Value, DGDetalleBloqueo.Rows(i).Cells(7).Value)
                    End If

                Next


                For_ProductoBloqueado.ShowDialog()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnEliminaProducto_Click(sender As Object, e As EventArgs) Handles BtnEliminaProducto.Click

        If Trim(ProductoIngresar.Codigo) = "" Then
            Exit Sub
        End If

        Dim CantidadIngreso As Decimal = TxtCantidadTotal.Text


        Dim Rta = MsgBox("Desea Eliminar el Producto - " + ProductoIngresar.Producto + " - ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

        If Rta = vbYes Then

            '------ Si ya lo habia Registrado lo Borro del DG Principal y vuelvo a ingresarlos --------

            For i = 0 To Me.DGDetalleBloqueo.Rows.Count - 1

                If (Trim(Me.DGDetalleBloqueo.Rows(i).Cells(0).Value) = Trim(ProductoIngresar.Codigo)) And (Trim(Me.DGDetalleBloqueo.Rows(i).Cells(7).Value) = Trim(ProductoIngresar.Lote)) Then
                    Me.DGDetalleBloqueo.Rows(i).Selected = True
                End If

            Next

            Dim value As DataGridViewSelectedRowCollection
            value = Me.DGDetalleBloqueo.SelectedRows

            For Each vfila As DataGridViewRow In value
                Me.DGDetalleBloqueo.Rows.Remove(vfila)
            Next

            Me.DGDetalleBloqueo.ClearSelection()
            '-----------------------------------------------------------------------------------------

            DGProductos.Rows.RemoveAt(Fila)
            TxtCantidadTotal.Text = CantidadIngreso - ProductoIngresar.Cantidad
            'TxtCantidadTn.Text = TxtCantidadTn.Text - (Val(ProductoIngresar.Cantidad) / 1000)

            ProductoIngresar.limpiarVariable()

        End If
    End Sub

    Private Sub BtnSeleccionArchivo_Click(sender As Object, e As EventArgs) Handles BtnSeleccionArchivo.Click



        Try
            ODRutaArchivo.FileName = ""
            ODRutaArchivo.Filter = "Archivo |*.Pdf;*.Jpg;*.Jpeg;*.png"

            ODRutaArchivo.ShowDialog()

            If ODRutaArchivo.FileName = "" Then
                MsgBox("No Selecciono Ningún Archivo!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            End If

            LblRutaArchivoLocal.Text = ODRutaArchivo.FileName

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAdicionarArchivo_Click(sender As Object, e As EventArgs) Handles BtnAdicionarArchivo.Click

        If Trim(CmbReferencia1.Text) = "" Then
            MsgBox("Seleccione el Tipo de Archivo que Desea Registrar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbReferencia1.Focus()
            Exit Sub
        End If

        If Trim(TxtNumReferencia1.Text) = "" Then
            MsgBox("Digite el Numero de Referencia del Documento!", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtNumReferencia1.Focus()
            Exit Sub
        End If

        'If Trim(LblRutaArchivoLocal.Text) = "" Then
        '    MsgBox("Seleccione el Archivo correspondiente!", MsgBoxStyle.Critical, Gl_NomCompañia)
        '    BtnSeleccionArchivo.Focus()
        '    Exit Sub
        'End If

        DGArchivos.Rows.Add(0, Trim(CmbReferencia1.Text), Trim(TxtNumReferencia1.Text), LblRutaArchivoLocal.Text, CmbReferencia1.SelectedValue)

        For i = 0 To DGArchivos.Rows.Count - 1
            DGArchivos.Rows(i).Cells(0).Value = i + 1
        Next

        CmbReferencia1.Text = ""
        TxtNumReferencia1.Text = ""
        LblRutaArchivoLocal.Text = ""
        CmbReferencia1.Focus()


    End Sub

    Private Sub BtnSeleccionFoto_Click(sender As Object, e As EventArgs)


        Try
            ODRutaArchivo.FileName = ""
            ODRutaArchivo.Filter = "Archivo |*.Jpg;*.Jpeg;*.png"

            ODRutaArchivo.ShowDialog()

            If ODRutaArchivo.FileName = "" Then
                MsgBox("No Selecciono Ninguna Foto!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            End If

            LblRutaImagenLocal.Text = ODRutaArchivo.FileName

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGArchivos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGArchivos.CellClick


        Dim Rta = MsgBox("Desea Eliminar Este Archivo ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

        If Rta = vbYes Then
            DGArchivos.Rows.RemoveAt(e.RowIndex)

            For i = 0 To DGArchivos.Rows.Count - 1
                DGArchivos.Rows(i).Cells(0).Value = i + 1
            Next

            CmbReferencia1.Focus()
        End If


    End Sub
    Private Sub BtnRedactar_Click_1(sender As Object, e As EventArgs) Handles BtnRedactar.Click

        For_Observaciones.Tag = "Ingresos"
        For_Observaciones.ShowDialog()
        TxtObservacion.Focus()
    End Sub
    Private Sub ChkTransporte_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTransporte.CheckedChanged
        If ChkTransporte.Checked = True Then
            GBTransportadora.Enabled = False
            GBConductor.Enabled = False
            GBPlaca.Enabled = False
            GBTipoVehiculo.Enabled = False
        Else
            GBTransportadora.Enabled = True
            GBConductor.Enabled = True
            GBPlaca.Enabled = True
            GBTipoVehiculo.Enabled = True

        End If
    End Sub

    Private Sub TxtDocumento_LostFocus(sender As Object, e As EventArgs) Handles TxtDocumento.LostFocus

        Dim Documento As String = LimpiarNumeros(Trim(TxtDocumento.Text))

        TxtDocumento.Text = Documento
        ValidarConductor(Documento)
        TxtNombreConductor.Focus()

    End Sub

    Private Sub BtnCantidades_Click(sender As Object, e As EventArgs) Handles BtnCantidades.Click

        If TxtCodCliente.Text = "" Then
            MsgBox("Debe seleccionar el cliente!", MsgBoxStyle.Critical, Gl_NomCompañia)
            TabControl1.SelectedIndex = 0
            Exit Sub
        End If

        If TxtCantidadTotal.Text = 0 Then
            MsgBox("Debe seleccionar primero los productos a Descargar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            TabControl1.SelectedIndex = 1
            Exit Sub
        End If

        If DGTarifasServicios.Rows.Count > 0 Then

            With DGTarifasServicios
                '0 IdServicio
                '1 Servicio
                '2 Cantidad
                '3 Valor
                '4 Total

                For I = 0 To .Rows.Count - 1
                    For_CantidadesRecaudo.DGTarifasServicios.Rows.Add(Trim(.Rows(I).Cells(0).Value),
                                                               Trim(.Rows(I).Cells(1).Value),
                                                               Trim(.Rows(I).Cells(2).Value),
                                                               Trim(.Rows(I).Cells(3).Value),
                                                               Trim(.Rows(I).Cells(4).Value))
                Next
            End With

            For_CantidadesRecaudo.BtnAdicionar.Enabled = False
            For_CantidadesRecaudo.BtnGuardar.Enabled = True
            For_CantidadesRecaudo.TxtTotalServicio.Text = TxtValorTotal.Text
            For_CantidadesRecaudo.TxtSumacantidad.Text = TxtCantidadTotal.Text
            For_CantidadesRecaudo.TxtSumaservicios.Text = CType(TxtValorTotal.Text, Integer)

        End If

        For_CantidadesRecaudo.TxtCantidadTotal.Text = TxtCantidadTotal.Text
        For_CantidadesRecaudo.LblUnidad.Text = LblUnidad2.Text
        For_CantidadesRecaudo.LblUnidad2.Text = LblUnidad2.Text

        For_CantidadesRecaudo.ShowDialog()


    End Sub

    Private Sub RBItr_CheckedChanged(sender As Object, e As EventArgs) Handles RBItr.CheckedChanged

        If RBItr.Checked = True Then
            TxtValorTotal.Text = 0
            BtnCantidades.Enabled = False
        Else
            TxtValorTotal.Text = ""
            BtnCantidades.Enabled = True
        End If

    End Sub

    Private Sub RBNacional_CheckedChanged(sender As Object, e As EventArgs) Handles RBNacional.CheckedChanged
        If RBNacional.Checked = True Then
            TxtValorTotal.Text = ""
            BtnCantidades.Enabled = True
        Else
            TxtValorTotal.Text = 0
            BtnCantidades.Enabled = False
        End If
    End Sub

    Private Sub DGProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProductos.CellContentClick

    End Sub
End Class