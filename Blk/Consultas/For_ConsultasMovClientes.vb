Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Globalization
Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight

Public Class For_ConsultasMovClientes

    Dim Centro As New Centros()
    Dim Bodega As New Bodegas()
    Dim Deposito As New Depositos()
    Dim Reportes As New Consultas()
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

        'CalendarDesde.SelectionRange.Start = CalendarDesde.SelectionRange.Start.Year & "/" & Long.Parse(CalendarDesde.SelectionRange.Start.Month).ToString("00") & "/01"
        CalendarDesde.Text = CalendarDesde.SelectionRange.Start.Year & "/" & Long.Parse(CalendarDesde.SelectionRange.Start.Month).ToString("00") & "/01"

    End Sub
    Private Sub For_ConsultasMovClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        CargarCombos()



    End Sub

    Private Sub CmbBodegas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBodegas.SelectedIndexChanged

        ' --- Si Cambia de Bodega toc limpiar los datos del Cliente para seleccionar uno nuevo por cuestion del Deposito
        Me.TxtCodCliente.Text = ""
        Me.LblNombreCliente.Text = ""
        Me.TxtDeposito.Text = ""
        Gl_Cliente.LimpiarVariableGlobal()

        BtnBuscar.Focus()

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

            Me.TxtCodCliente.Text = ""
            Me.LblNombreCliente.Text = ""
            Me.TxtDeposito.Text = ""
        Else
            Me.TxtDeposito.Text = Codigo
        End If

    End Sub

    Private Sub CmbCentros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCentros.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbBodegas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbBodegas.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click

        Dim Desde, Hasta As String

        Desde = CalendarDesde.SelectionRange.Start.Year & "/" & Long.Parse(CalendarDesde.SelectionRange.Start.Month).ToString("00") & "/" & Long.Parse(CalendarDesde.SelectionRange.Start.Day).ToString("00")
        Hasta = CalendarHasta.SelectionRange.Start.Year & "/" & Long.Parse(CalendarHasta.SelectionRange.Start.Month).ToString("00") & "/" & Long.Parse(CalendarHasta.SelectionRange.Start.Day).ToString("00")

        If Hasta < Desde Then
            MsgBox("La fecha final de la consulta es menor a la fecha de inicio!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        If Hasta > Date.Now Then
            MsgBox("La fecha final de la consulta es mayor al dia actual!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        If TxtCodCliente.Text = "" Then
            MsgBox("Seleccione el cliente del cual realizara la consulta!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        DGProductos.DataSource = Nothing

        ' 1. LISTAR TODOS LOS PRODUCTOS (DISTINCT CODPRODUCTO , PRODUCTO) DE ESE CLIENTE
        Dim ConsultaProductos As SqlDataReader
        Dim TablaProductos As New DataTable

        ConsultaProductos = Reportes.ListarProductos(TxtCodCliente.Text, TxtDeposito.Text)
        TablaProductos.Load(ConsultaProductos)
        DGProductos.DataSource = TablaProductos

        '2. AGREGO LOS DIAS Y PRODUCTOS POR CADA UNO EN EL DGCONSULTA

        Dim FechaReporte As DateTime = CalendarDesde.SelectionRange.Start
        DGConsulta.DataSource = Nothing
        DGConsulta.Rows.Clear()

        While FechaReporte <= CalendarHasta.SelectionRange.Start

            For I = 0 To DGProductos.Rows.Count - 1
                DGConsulta.Rows.Add(FechaReporte.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), Trim(DGProductos.Rows(I).Cells(0).Value), Trim(DGProductos.Rows(I).Cells(1).Value), "0", "0", "0", "0", "0")
            Next

            FechaReporte = FechaReporte.AddDays(1)
        End While

        '3. CONSULTO LOS INGRESOS, LOS DESPACHOS Y EL SALDO ANTERIOR DE CADA PRODUCTO POR FECHA

        Dim ConsultaCantidades As SqlDataReader
        Dim ConsultaSaldo As SqlDataReader
        Dim TablaCantidades As New DataTable

        For I = 0 To DGConsulta.Rows.Count - 1
            ConsultaCantidades = Reportes.ListarCantidades(TxtCodCliente.Text, TxtDeposito.Text, Trim(DGConsulta.Rows(I).Cells(0).Value), Trim(DGConsulta.Rows(I).Cells(1).Value)) ' VariablesEnviadas(Cliente, Deposito , Fecha, CodProducto)

            If ConsultaCantidades.HasRows = True Then

                If ConsultaCantidades.Read() Then
                    DGConsulta.Rows(I).Cells(3).Value = Trim(ConsultaCantidades("INGRESOS").ToString())
                    DGConsulta.Rows(I).Cells(4).Value = Trim(ConsultaCantidades("DESPACHOS").ToString())

                    If Trim(ConsultaCantidades("SALDOANTERIOR").ToString()) <> "" Then
                        DGConsulta.Rows(I).Cells(5).Value = Trim(ConsultaCantidades("SALDOANTERIOR").ToString())
                    End If

                    DGConsulta.Rows(I).Cells(6).Value = Val(DGConsulta.Rows(I).Cells(5).Value) + Val(DGConsulta.Rows(I).Cells(3).Value) - Val(DGConsulta.Rows(I).Cells(4).Value)
                End If

            Else
                ConsultaCantidades.Close()

                '---- NO TUBIERON MOVIMIENTO ESE DIA PERO SE DEBE CONSULTAR EL SALDO ANTERIOR
                ConsultaSaldo = Reportes.ListarSaldoAnterior(TxtCodCliente.Text, TxtDeposito.Text, Trim(DGConsulta.Rows(I).Cells(0).Value), Trim(DGConsulta.Rows(I).Cells(1).Value)) ' VariablesEnviadas(Cliente, Deposito , Fecha, CodProducto)

                '----- VERIFICAR SI TENIA SALDO ANTERIOR -----
                If ConsultaSaldo.HasRows = True Then

                    If ConsultaSaldo.Read() Then
                        DGConsulta.Rows(I).Cells(5).Value = Val(ConsultaSaldo("SALDOANTERIOR").ToString())
                        DGConsulta.Rows(I).Cells(6).Value = Val(DGConsulta.Rows(I).Cells(5).Value) ' Sigue siendo el mismo saldo
                    End If

                End If

                ConsultaSaldo.Close()
            End If

            ConsultaCantidades.Close()
        Next


    End Sub

    Private Sub For_ConsultasMovClientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click

        'Dim Dia As Date = DTFechaCorte.Value

        'Dim FechaCorte As String = Dia.Year & "-" & Long.Parse(Dia.Month).ToString("00") & "-" & Long.Parse(Dia.Day).ToString("00")

        Try

            If DGConsulta.RowCount = 0 Then
                MsgBox("Nada para Exportar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                Exit Sub
            End If

            SDArchivo.FileName = "Reporte_Movimientos_" & TxtCodCliente.Text

            If SDArchivo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            If SDArchivo.FileName = "" Then
                MsgBox("Ingrese el Nombre del archivo Excel", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            End If


            'Dim FH As Date = FechaHoraServer()

            Dim SL As New SLDocument()

            Dim StyleCabecera As SLStyle = SL.CreateStyle()
            Dim StyleCentrado As SLStyle = SL.CreateStyle()
            Dim StyleTitulo As SLStyle = SL.CreateStyle()

            Dim StyleVerde As SLStyle = SL.CreateStyle()
            Dim StyleRosado As SLStyle = SL.CreateStyle()

            StyleTitulo.Font.Bold = True
            StyleTitulo.Font.FontSize = 16
            StyleTitulo.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.White, System.Drawing.Color.White)

            StyleCabecera.Font.Bold = True
            StyleCabecera.Font.FontSize = 10
            StyleCabecera.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.Yellow, System.Drawing.Color.White)

            StyleCentrado.Alignment.Horizontal = HorizontalAlignmentValues.Center
            StyleCentrado.Border.RightBorder.BorderStyle = BorderStyleValues.Hair
            StyleCentrado.Border.LeftBorder.BorderStyle = BorderStyleValues.Hair
            StyleCentrado.Border.TopBorder.BorderStyle = BorderStyleValues.Hair

            StyleVerde.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.PaleGreen, System.Drawing.Color.White)
            StyleRosado.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.LightSalmon, System.Drawing.Color.White)

            SL.MergeWorksheetCells("A1", "G1")
            SL.SetCellValue("A1", "Relación de Movimientos " & Trim(LblNombreCliente.Text) & " Desde: " & CalendarDesde.SelectionRange.Start & " Hasta: " & CalendarHasta.SelectionRange.Start)
            SL.SetCellStyle("A1", StyleTitulo)

            '----- Encabezado de las columnas de la Tabla -------------
            For i = 1 To DGConsulta.ColumnCount
                SL.SetCellValue(2, i, DGConsulta.Columns(i - 1).HeaderText)
                SL.SetCellStyle(2, i, StyleCabecera)
                SL.SetCellStyle(2, i, StyleCentrado)
            Next

            '----- Datos de la Tabla -------------------------------
            For F = 0 To DGConsulta.Rows.Count - 1
                For C = 1 To DGConsulta.ColumnCount
                    SL.SetCellValue(F + 3, C, Trim(DGConsulta.Rows(F).Cells(C - 1).Value.ToString))
                Next

            Next

            SL.SetCellStyle(3, 4, DGConsulta.Rows.Count + 2, 7, StyleCentrado) 'Centrar Valores
            SL.SetCellStyle(3, 7, DGConsulta.Rows.Count + 2, 7, StyleVerde) 'Colorear Verde 
            ' SL.SetCellStyle(3, 7, DGConsulta.Rows.Count + 2, 7, StyleVerde) 'Colorear Verde 


            'SL.SetCellStyle(3, 5, DGConsulta.Rows.Count + 2, 8, StyleRosado) 'Colorear Rosado
            'SL.SetCellStyle(3, 9, DGConsulta.Rows.Count + 2, 9, StyleRosado) 'Colorear Rosado 


            SL.SaveAs(SDArchivo.FileName + ".xlsx")

            MsgBox("Archivo generado con Exito!", MsgBoxStyle.Information, Gl_NomCompañia)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class