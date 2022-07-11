Imports System.Data.SqlClient

Public Class For_DespachoMercancia
    Dim Centro As New Centros()
    Dim Bodega As New Bodegas()
    Dim Deposito As New Depositos()
    Dim Transportador As New Transportadores()
    Dim Fila As Integer
    Dim ProductoIngresar As New ProductoIngreso()
    Dim Despacho As New DespachoMercancia()
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

    End Sub
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
    Function CalcularBultos(Caso, Cantidad) As String

        Select Case Caso
            Case 1 ' Bolsa x 25 Kilos

                If (Cantidad Mod 25) = 0 Then
                    Return Cantidad \ 25
                Else
                    MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación Ingresada!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Return ""
                End If
            Case 2 ' Big Bag x 850 Kilos

                If (Cantidad Mod 850) = 0 Then
                    Return Cantidad \ 850
                Else
                    MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación Ingresada!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Return ""
                End If

            Case 3 ' Big Bag x 1250 Kilos

                If (Cantidad Mod 1250) = 0 Then
                    Return Cantidad \ 1250
                Else
                    MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación Ingresada!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Return ""
                End If
            Case 4 ' Bolsa x 50 Kilos

                If (Cantidad Mod 50) = 0 Then
                    Return Cantidad \ 50
                Else
                    'MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación Ingresada!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Return ""
                End If
            Case 5 ' Bolsa Big Bag x 1000 Kilos

                If (Cantidad Mod 1000) = 0 Then
                    Return Cantidad \ 1000
                Else
                    'MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación Ingresada!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Return ""
                End If
            Case 6 ' Bolsa Big Bag x 1200 Kilos

                If (Cantidad Mod 1200) = 0 Then
                    Return Cantidad \ 1200
                Else
                    'MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación Ingresada!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Return ""
                End If
            Case 7 ' Bolsa x 20 Kilos

                If (Cantidad Mod 20) = 0 Then
                    Return Cantidad \ 20
                Else
                    MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación Ingresada!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Return ""
                End If
            Case 8 ' Caja X 12 Kilos

                If (Cantidad Mod 12) = 0 Then
                    Return Cantidad \ 12
                Else
                    MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación Ingresada!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Return ""
                End If
            Case 9 ' Tambor X 250 Kilos

                If (Cantidad Mod 250) = 0 Then
                    Return Cantidad \ 250
                Else
                    MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación Ingresada!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Return ""
                End If
            Case 10 ' Bolsa X 15 Kilos

                If (Cantidad Mod 15) = 0 Then
                    Return Cantidad \ 15
                Else
                    ' MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación Ingresada!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Return ""
                End If
            Case Else
                Return ""
        End Select

    End Function
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

        If Trim(TxtNumeroPedido.Text) = "" Then
            ListaErrores.Add("- Ingrese el Número/Destino del Despacho")
        End If

        If Trim(TxtReferencia.Text) = "" Then
            ListaErrores.Add("- Ingrese la Referencia del Despacho")
        End If

        If ChkTransporte.Checked = False Then

            If Trim(CmbTransportadora.Text) = "" Then
                ListaErrores.Add("- Seleccione la Empresa que Realizará el Transporte.")
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
            ListaErrores.Add("- Ingrese Los productos que se van a Despachar.")
        End If

        If TxtObservacion.Text = "" Then
            ListaErrores.Add("- Ingrese una observación sobre el Despacho de la Mercancia.")
        End If

        If TxtValorTotal.Text = "" Then
            ListaErrores.Add("- Registre las cantidades por el servicio de Cargue")
        End If

        Return ListaErrores

    End Function
    Private Sub For_DespachoMercanciaExt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Me.TabControl1.Left = (Me.Width / 2) - (TabControl1.Width / 2)

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
        Me.TxtNumeroPedido.Text = ""
        Me.TxtReferencia.Text = ""

        DGProductos.Rows.Clear()
        TxtTotal.Text = 0
        ChkDepositoPropio.Checked = False

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

        Dim Consulta As SqlDataReader
        Dim Codigo As String = ""

        Consulta = Deposito.CodigoDeposito(CmbBodegas.SelectedValue, Gl_Cliente.Codigo)

        If Consulta.Read() Then
            Codigo = Trim(Consulta("CODIGO").ToString())
        End If
        Consulta.Close()

        If Trim(Codigo) = "" Then
            MsgBox("El cliente Seleccionado No Cuenta con Deposito En la Bodega Indicada!", MsgBoxStyle.Critical, Gl_NomCompañia)
        Else
            Me.TxtCodCliente.Text = Gl_Cliente.Codigo
            Me.LblNombreCliente.Text = Gl_Cliente.Cliente
            Me.TxtDeposito.Text = Codigo
            TxtNumeroPedido.Focus()

            DGProductos.Rows.Clear()
            TxtTotal.Text = 0
            ChkDepositoPropio.Checked = False
            TxtNumeroPedido.Text = ""
            TxtReferencia.Text = ""

            Gl_Cliente.LimpiarVariableGlobal()

        End If

    End Sub
    Private Sub TxtNumeroPedido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumeroPedido.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TxtReferencia.Focus()
        End If

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

        If Asc(e.KeyChar) = 13 Then
            TxtDocumento.Focus()
        Else
            e.Handled = True
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
    Private Sub BtnProducto_Click(sender As Object, e As EventArgs) Handles BtnProducto.Click

        If Trim(TxtCodCliente.Text) = "" Then
            MsgBox("Debe seleccionar primero el cliente del cual despachara material!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        '---- Si ya tenia seleccionado producto para despachar lo vuelvo a montar en el formulario de seleccion -----
        If DGProductos.Rows.Count > 0 Then
            For i = 0 To DGProductos.Rows.Count - 1
                '0 Codigo
                '1 Producto
                '2 Cantidad
                '3 Unidad
                '4 Presentacion
                '5 IdPresentacion
                '6 Bultos
                '7 Lote

                For_ProductosClienteBuscar.DGDespachar.Rows.Add(
                                     Trim(DGProductos.Rows(i).Cells(0).Value),
                                     Trim(DGProductos.Rows(i).Cells(1).Value),
                                     Trim(DGProductos.Rows(i).Cells(7).Value),
                                     CType(DGProductos.Rows(i).Cells(2).Value, Decimal),
                                     Trim(DGProductos.Rows(i).Cells(3).Value),
                                     Trim(DGProductos.Rows(i).Cells(4).Value),
                                     Trim(DGProductos.Rows(i).Cells(5).Value),
                                     Val(DGProductos.Rows(i).Cells(6).Value))
            Next

            For_ProductosClienteBuscar.TxtTotal.Text = TxtTotal.Text

        End If
        '------------------------------------------------------------------------------------------------------

        For_ProductosClienteBuscar.TxtCodCliente.Text = Trim(Me.TxtCodCliente.Text)
        For_ProductosClienteBuscar.LblNombreCliente.Text = Trim(Me.LblNombreCliente.Text)
        For_ProductosClienteBuscar.TxtDeposito.Text = Trim(Me.TxtDeposito.Text)

        For_ProductosClienteBuscar.ShowDialog()

    End Sub

    Private Sub DGProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            Fila = e.RowIndex

            ProductoIngresar.Codigo = Trim(DGProductos.Rows(e.RowIndex).Cells(0).Value)
            ProductoIngresar.Producto = Trim(DGProductos.Rows(e.RowIndex).Cells(1).Value)
            ProductoIngresar.Cantidad = Trim(DGProductos.Rows(e.RowIndex).Cells(2).Value)
            ProductoIngresar.Unidad = Trim(DGProductos.Rows(e.RowIndex).Cells(3).Value)
            ProductoIngresar.Presentacion = Trim(DGProductos.Rows(e.RowIndex).Cells(5).Value)
            ProductoIngresar.Bultos = Trim(DGProductos.Rows(e.RowIndex).Cells(6).Value)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub For_DespachoMercanciaExt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub BtnRedactar_Click(sender As Object, e As EventArgs) Handles BtnRedactar.Click

        For_Observaciones.Tag = "Despachos"
        For_Observaciones.ShowDialog()
        TxtObservacion.Focus()

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
            DGTarifasServicios.Rows.Add(6, "SERVICIO ITR", TxtTotal.Text, 0, 0)
        End If

        '************************** Insertar Información a la Base de Datos ************************
        Despacho.Centro = CmbCentros.SelectedValue
        Despacho.Bodega = CmbBodegas.SelectedValue
        Despacho.Cliente = TxtCodCliente.Text
        Despacho.Deposito = TxtDeposito.Text
        Despacho.NumPedido = Trim(TxtNumeroPedido.Text)
        Despacho.Referencia = Trim(TxtReferencia.Text)

        If ChkTransporte.Checked = False Then
            Despacho.Transportadora = CmbTransportadora.SelectedValue
            Despacho.Placa = TxtLetrasPlaca.Text & TxtNumeroPlaca.Text
            Despacho.TipoVehiculo = CmbTipoVehiculo.SelectedValue
            Despacho.DocConductor = TxtDocumento.Text
            Despacho.NombConductor = TxtNombreConductor.Text
            Despacho.ApelConductor = TxtApellidosConductor.Text
        Else
            Despacho.Transportadora = "T000" ' No Aplica
            Despacho.Placa = "AAA000" ' No Aplica
            Despacho.TipoVehiculo = 0 ' No Aplica
            Despacho.DocConductor = "00000000" 'No Aplica
            Despacho.NombConductor = ""
            Despacho.ApelConductor = ""
        End If


        '-- Productos --
        Despacho.Productos = DGProductos
        '---------------

        '---Recaudo Cargues ---
        Despacho.RecaudoCargues = DGTarifasServicios
        '-------------------------


        Despacho.Observacion = TxtObservacion.Text

        Dim Respuesta = Despacho.GuardarMercancia(TxtTotal.Text, 1, TxtValorTotal.Text)

        If Respuesta = True Then
            MsgBox("Mercancia Despachada Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        Else
            MsgBox("No fue Posible Registrar el Despacho de la Mercancia. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        '**************************************************************************************

    End Sub
    Private Sub BtnReferencia_Click(sender As Object, e As EventArgs) Handles BtnReferencia.Click

        Gl_Cliente.LimpiarVariableGlobal() ' Limpio la variable Global de Clientes 

        For_ClientesBuscar.ShowDialog()

        If Gl_Cliente.Codigo = "" Then ' Si no selecciona ningun cliente no debe Continuar.
            Exit Sub
        End If

        Me.TxtReferencia.Text = Gl_Cliente.Cliente


    End Sub
    Private Sub ChkDepositoPropio_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDepositoPropio.CheckedChanged

        If ChkDepositoPropio.Checked = True Then
            TxtNumeroPedido.Text = "DEPOSITO PROPIO"
            TxtReferencia.Text = LblNombreCliente.Text
        Else
            TxtNumeroPedido.Text = ""
            TxtReferencia.Text = ""
        End If

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

    Private Sub RBNacional_CheckedChanged(sender As Object, e As EventArgs) Handles RBNacional.CheckedChanged
        If RBNacional.Checked = True Then
            TxtValorTotal.Text = ""
            BtnCantidades.Enabled = True
        Else
            TxtValorTotal.Text = 0
            BtnCantidades.Enabled = False
        End If
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

    Private Sub BtnCantidades_Click(sender As Object, e As EventArgs) Handles BtnCantidades.Click

        If TxtCodCliente.Text = "" Then
            MsgBox("Debe seleccionar el cliente!", MsgBoxStyle.Critical, Gl_NomCompañia)
            TabControl1.SelectedIndex = 0
            Exit Sub
        End If

        If TxtTotal.Text = 0 Then
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
                    For_CantidadRecaudo.DGTarifasServicios.Rows.Add(Trim(.Rows(I).Cells(0).Value),
                                                               Trim(.Rows(I).Cells(1).Value),
                                                               Trim(.Rows(I).Cells(2).Value),
                                                               Trim(.Rows(I).Cells(3).Value),
                                                               Trim(.Rows(I).Cells(4).Value))
                Next
            End With

            For_CantidadRecaudo.BtnAdicionar.Enabled = False
            For_CantidadRecaudo.BtnGuardar.Enabled = True
            For_CantidadRecaudo.TxtTotalServicio.Text = TxtValorTotal.Text
            For_CantidadRecaudo.TxtSumacantidad.Text = TxtTotal.Text
            For_CantidadRecaudo.TxtSumaservicios.Text = CType(TxtValorTotal.Text, Integer)

        End If

        For_CantidadRecaudo.TxtCantidadTotal.Text = TxtTotal.Text
        For_CantidadRecaudo.LblUnidad.Text = LblUnidad.Text
        For_CantidadRecaudo.LblUnidad2.Text = LblUnidad.Text

        For_CantidadRecaudo.ShowDialog()

    End Sub
End Class