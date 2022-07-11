Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight

Public Class For_BitacoraTransporte
    Dim Transportador As New Transportadores()
    Dim Despachos As New ClsTransporte()
    Dim Numdespacho As String

    Sub Limpiarcampos()

        LblCliente.Text = ""
        LblOrigen.Text = ""
        LblOrigen.Tag = ""
        LblDestino.Text = ""
        LblDestino.Tag = ""
        CmbTipoDespacho.Text = ""
        CmbTipoVehiculo.Text = ""
        CmbZona.Text = ""
        CmbTransportadora.Text = ""
        TxtManifiesto.Text = ""

        DTFechaDesde.Value = Date.Now.Year & "/" & Date.Now.Month & "/" & "01"
        DTFechaHasta.Value = Date.Now

    End Sub
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



    End Sub

    Sub Apariencia()
        Try

            DGInforme.Columns("ID").Visible = False
            DGInforme.Columns("MARGEN").HeaderText = "MARGEN (%)"
            DGInforme.Columns("FECHA").DefaultCellStyle.Format = "yyyy-MM-dd"
            DGInforme.Columns("VALOR").DefaultCellStyle.Format = "C0"
            DGInforme.Columns("COSTO").DefaultCellStyle.Format = "C0"
            DGInforme.Columns("CARGUEDESCARGUE").DefaultCellStyle.Format = "C0"
            DGInforme.Columns("COSTOTRANSPORTE").DefaultCellStyle.Format = "C0"
            DGInforme.Columns("TONELADA").DefaultCellStyle.Format = "C2"
            DGInforme.Columns("VALORCLIENTE").DefaultCellStyle.Format = "C0"
            DGInforme.Columns("OTROSCOBROS").DefaultCellStyle.Format = "C0"
            DGInforme.Columns("UTILIDAD").DefaultCellStyle.Format = "C0"

            DGInforme.Columns("DESPACHO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGInforme.Columns("PLACA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGInforme.Columns("CENTROCOSTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGInforme.Columns("FECHA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGInforme.Columns("PESOCARGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGInforme.Columns("MARGEN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGInforme.Columns("VALOR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme.Columns("COSTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme.Columns("CARGUEDESCARGUE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme.Columns("COSTOTRANSPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme.Columns("TONELADA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme.Columns("VALORCLIENTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme.Columns("OTROSCOBROS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme.Columns("UTILIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme.Columns("TIPO").HeaderText = "TIPO VEHICULO"

        Catch ex As Exception

        End Try


    End Sub
    Sub Listar(Desde, Hasta)

        DGInforme.DataSource = Nothing

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = Despachos.ListarDespachos(1, Desde, Hasta)
        Tabla.Load(Consulta)

        DGInforme.DataSource = Tabla
        GBListado.Text = "Despachos Realizados : " + Str(Tabla.Rows.Count).ToString

        Apariencia()
        Limpiarcampos()
    End Sub
    Private Sub For_BitacoraTransporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cargarcombos()

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        DTFechaDesde.Value = Date.Now.Year & "/" & Date.Now.Month & "/" & "01"
        DTFechaHasta.Value = Date.Now

        Dim Desde = DTFechaDesde.Value.Year & "-" & DTFechaDesde.Value.Month & "-" & DTFechaDesde.Value.Day
        Dim Hasta = DTFechaHasta.Value.Year & "-" & DTFechaHasta.Value.Month & "-" & DTFechaHasta.Value.Day

        Listar(Desde, Hasta)

    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click

        Dim Desde, Hasta As String

        Desde = DTFechaDesde.Value
        Hasta = DTFechaHasta.Value

        If Hasta > Date.Now Then
            MsgBox("Fecha de Consulta es mayor a la fecha Actual.", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        If Hasta < Desde Then
            MsgBox("La fecha final de la consulta es menor a la fecha de inicio!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Desde = DTFechaDesde.Value.Year & "-" & String.Format(DTFechaDesde.Value.Month, "00") & "-" & String.Format(DTFechaDesde.Value.Day, "00")
        Hasta = DTFechaHasta.Value.Year & "-" & String.Format(DTFechaHasta.Value.Month, "00") & "-" & String.Format(DTFechaHasta.Value.Day, "00")

        Dim Cliente As String = ""
        Dim TipoDespacho As String = ""
        Dim TipoVehiculo As String = ""
        Dim Zona As String = ""
        Dim Origen As String = ""
        Dim Destino As String = ""
        Dim EmpTransportadora As String = ""
        Dim Manifiesto As String = ""

        If Trim(LblCliente.Text) <> "" Then Cliente = LblCliente.Tag
        If Trim(LblOrigen.Text) <> "" Then Origen = LblOrigen.Tag
        If Trim(LblDestino.Text) <> "" Then Destino = LblDestino.Tag
        If Trim(CmbTipoDespacho.Text) <> "" Then TipoDespacho = CmbTipoDespacho.SelectedValue
        If Trim(CmbTipoVehiculo.Text) <> "" Then TipoVehiculo = CmbTipoVehiculo.SelectedValue
        If Trim(CmbZona.Text) <> "" Then Zona = CmbZona.SelectedValue
        If Trim(CmbTransportadora.Text) <> "" Then EmpTransportadora = CmbTransportadora.SelectedValue
        If Trim(TxtManifiesto.Text) <> "" Then Manifiesto = Trim(TxtManifiesto.Text)

        DGInforme.DataSource = Nothing

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Try
            Consulta = Despachos.ListarDespachos(2, Desde, Hasta, Cliente, Origen, Destino, TipoDespacho, TipoVehiculo, Zona, EmpTransportadora, Manifiesto)
            Tabla.Load(Consulta)

            DGInforme.DataSource = Nothing
            DGInforme.DataSource = Tabla

            GBListado.Text = "Despachos Realizados : " + Str(Tabla.Rows.Count).ToString
        Catch ex As Exception

        End Try


        Apariencia()

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

    End Sub
    Private Sub CmbTipoDespacho_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbTipoDespacho.SelectionChangeCommitted
        CmbTipoVehiculo.Focus()
    End Sub
    Private Sub CmbTipoVehiculo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbTipoVehiculo.SelectionChangeCommitted
        CmbZona.Focus()
    End Sub
    Private Sub CmbZona_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbZona.SelectionChangeCommitted
        CmbTransportadora.Focus()
    End Sub
    Private Sub CmbTransportadora_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbTransportadora.SelectionChangeCommitted
        BtnConsultar.Focus()
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

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("52")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If


        GL_Editar = 0

        For_RegistroTransporte.BtnRegistrar.Visible = True
        For_RegistroTransporte.BtnActualizar.Visible = False

        For_RegistroTransporte.ShowDialog()

        DTFechaDesde.Value = Date.Now.Year & "/" & Date.Now.Month & "/" & "01"
        DTFechaHasta.Value = Date.Now

        Dim Desde = DTFechaDesde.Value.Year & "-" & DTFechaDesde.Value.Month & "-" & DTFechaDesde.Value.Day
        Dim Hasta = DTFechaHasta.Value.Year & "-" & DTFechaHasta.Value.Month & "-" & DTFechaHasta.Value.Day

        Listar(Desde, Hasta)


    End Sub

    Private Sub For_BitacoraTransporte_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        GL_Editar = 0
        Me.Dispose()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        Limpiarcampos()

        DGInforme.DataSource = Nothing
        GBListado.Text = "Despachos"

    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        Try

            If DGInforme.RowCount = 0 Then
                MsgBox("Nada para Exportar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                Exit Sub
            End If

            SDArchivo.FileName = "Despachos"


            If SDArchivo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            If SDArchivo.FileName = "" Then
                MsgBox("Ingrese el Nombre del archivo Excel", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            End If


            Dim FH As Date = FechaHoraServer()
            Dim Titulo As String = ""

            Dim SL As New SLDocument()

            Dim StyleCabecera As SLStyle = SL.CreateStyle()
            Dim StyleCentrado As SLStyle = SL.CreateStyle()
            Dim StyleVerde As SLStyle = SL.CreateStyle()
            Dim StyleRosado As SLStyle = SL.CreateStyle()

            StyleCabecera.Font.Bold = True
            StyleCabecera.Font.FontSize = 10
            StyleCabecera.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.Yellow, System.Drawing.Color.White)

            StyleCentrado.Alignment.Horizontal = HorizontalAlignmentValues.Center
            StyleCentrado.Border.RightBorder.BorderStyle = BorderStyleValues.Hair
            StyleCentrado.Border.LeftBorder.BorderStyle = BorderStyleValues.Hair
            StyleCentrado.Border.TopBorder.BorderStyle = BorderStyleValues.Hair

            StyleVerde.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.PaleGreen, System.Drawing.Color.White)
            StyleRosado.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.LightSalmon, System.Drawing.Color.White)

            '----- Encabezado de las columnas de la Tabla -------------
            For i = 0 To DGInforme.ColumnCount - 1
                SL.SetCellValue(1, i + 1, DGInforme.Columns(i).HeaderText)
                SL.SetCellStyle(1, i + 1, StyleCabecera)
                SL.SetCellStyle(1, i + 1, StyleCentrado)
            Next

            '----- Datos de la Tabla -------------------------------
            For F = 0 To DGInforme.Rows.Count - 1
                For C = 0 To DGInforme.ColumnCount - 1
                    SL.SetCellValue(F + 2, C + 1, Trim(DGInforme.Rows(F).Cells(C).Value))
                Next

            Next

            'SL.SetCellStyle(2, 7, DGConsulta.Rows.Count + 1, 12, StyleCentrado) 'Centrar Valores
            'SL.SetCellStyle(2, 7, DGConsulta.Rows.Count + 1, 7, StyleVerde) 'Colorear Verde 
            'SL.SetCellStyle(2, 9, DGConsulta.Rows.Count + 1, 9, StyleVerde) 'Colorear Verde 
            'SL.SetCellStyle(2, 10, DGConsulta.Rows.Count + 1, 10, StyleRosado) 'Colorear Rosado
            'SL.SetCellStyle(2, 12, DGConsulta.Rows.Count + 1, 12, StyleRosado) 'Colorear Rosado 

            SL.SaveAs(SDArchivo.FileName + ".xlsx")

            MsgBox("Archivo generado con Exito!", MsgBoxStyle.Information, Gl_NomCompañia)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If Trim(Numdespacho) = "" Then
            MsgBox("Seleccione El despacho que desea editar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("54") ' Editar Cualquier Despacho

        If Perfil = False Then

            '----------Verificar si tiene permiso para editar ese despacho ------

            Perfil = ConsultaPerfil("53") ' Editar Despachos Propios

            If Perfil = False Then
                MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
                If Conn.State = 1 Then Conn.Close()
                Exit Sub
            Else
                'Verificar si puede editar el despacho seleccionado

                Dim Consulta As SqlDataReader
                Dim Tabla As New DataTable

                Consulta = Despachos.ConsultarDespacho(4, Numdespacho)
                Tabla.Load(Consulta)

                Dim Row As DataRow = Tabla.Rows(Tabla.Rows.Count - 1)

                If Trim(Row("USUARIOAPP")) <> UsuarioApp.Documento Then
                    MsgBox("No es posible editar despachos registrados por otros usuarios!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    If Conn.State = 1 Then Conn.Close()
                    Exit Sub
                End If
                '----------------------------------------------------

            End If

        End If

        For_RegistroTransporte.TxtDespacho.Text = Numdespacho
        For_RegistroTransporte.BtnRegistrar.Visible = False
        For_RegistroTransporte.BtnActualizar.Visible = True

        GL_Editar = 1

        For_RegistroTransporte.ShowDialog()

        DTFechaDesde.Value = Date.Now.Year & "/" & Date.Now.Month & "/" & "01"
        DTFechaHasta.Value = Date.Now

        Dim Desde = DTFechaDesde.Value.Year & "-" & DTFechaDesde.Value.Month & "-" & DTFechaDesde.Value.Day
        Dim Hasta = DTFechaHasta.Value.Year & "-" & DTFechaHasta.Value.Month & "-" & DTFechaHasta.Value.Day

        Listar(Desde, Hasta)


    End Sub

    Private Sub DGInforme_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGInforme.CellClick

        Try
            Numdespacho = DGInforme.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnInformes_Click(sender As Object, e As EventArgs) Handles BtnInformes.Click

        For_InformesDespacho.ShowDialog()

    End Sub

    Private Sub DGInforme_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGInforme.CellContentClick

    End Sub

    Private Sub BtnDetalleCobros_Click(sender As Object, e As EventArgs) Handles BtnDetalleCobros.Click

        If Numdespacho = "" Then
            MsgBox("Seleccione un despacho que contenga cobros adicionales para conocer el detalle!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If


        '---------Cargar los Registros existentes para ese Despacho ---------

        For_BitacoraOtrosCobros.DGCobros.DataSource = Nothing

        Dim Consulta1 As SqlDataReader
        Dim Tabla1 As New DataTable
        Dim suma As Integer


        Try
            Consulta1 = Despachos.DetalleCobros(8, Numdespacho)
            Tabla1.Load(Consulta1)
            Dim Row1 As DataRow

            If Tabla1.Rows.Count = 0 Then
                MsgBox("El despacho seleccionado no cuenta con cobros adicionales!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                Exit Sub
            End If

            For I = 0 To Tabla1.Rows.Count - 1
                Row1 = Tabla1.Rows(I)
                For_BitacoraOtrosCobros.DGCobros.Rows.Add(Row1("NUMDESPACHO"), Row1("IDCOBRO"), Row1("DESCRIPCION"), Row1("VALOR"))
                suma += Row1("VALOR")
            Next

            For_BitacoraOtrosCobros.DGCobros.Columns("IDCOBRO").Visible = False
            For_BitacoraOtrosCobros.TxtValorTotal.Text = FormatCurrency(suma, 0)

        Catch ex As Exception

        End Try
        '--------------------------------------------------------------------

        For_BitacoraOtrosCobros.BtnAdicionar.Enabled = False
        For_BitacoraOtrosCobros.BtnGuardar.Enabled = False

        For_BitacoraOtrosCobros.TxtDespacho.Text = Numdespacho
        For_BitacoraOtrosCobros.ShowDialog()

    End Sub
End Class