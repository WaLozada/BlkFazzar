Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight

Public Class For_ConsultaInventario
    Dim Centro As New Centros()
    Dim Bodega As New Bodegas()
    'Dim Deposito As New Depositos()
    Dim Reportes As New Consultas()
    Dim NombreCliente As String
    Dim CodDeposito As String = ""
    Sub CargarCombo()

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
    End Sub

    Private Sub For_ConsultaInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        CargarCombo()

    End Sub

    Private Sub CmbCentros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCentros.SelectedIndexChanged

        DGDepositos.DataSource = Nothing
        DGInventario.DataSource = Nothing
        CmbBodegas.Text = ""

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
        DTFechaCorte.Focus()
    End Sub

    Private Sub CmbBodegas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbBodegas.KeyPress
        e.Handled = True
    End Sub
    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click

        Dim FechaCorte As String

        FechaCorte = DTFechaCorte.Value

        DGDepositos.DataSource = Nothing
        DGInventario.DataSource = Nothing
        DGRegistros.DataSource = Nothing


        If FechaCorte > Date.Now Then
            MsgBox("Fecha de Corte es mayor a la fecha Actual.", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = Reportes.ListarDepositos(CmbBodegas.SelectedValue, DTFechaCorte.Value)

        Tabla.Load(Consulta)
        DGDepositos.DataSource = Tabla

        DGDepositos.Columns("CODCLIENTE").HeaderText = "CODIGO"


    End Sub

    Private Sub For_ConsultaInventario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click

        Try

            Dim DGridExportar As DataGridView

            If TabControl1.SelectedIndex = 0 Then
                DGridExportar = DGInventario
            Else
                DGridExportar = DGRegistros
            End If

            If DGridExportar.RowCount = 0 Then
                MsgBox("Nada para Exportar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                Exit Sub
            End If

            SDArchivo.FileName = "Inventario"


            If SDArchivo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            If SDArchivo.FileName = "" Then
                MsgBox("Ingrese el Nombre del archivo Excel", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            End If


            Dim FH As Date = FechaHoraServer()
            'Dim Titulo As String

            '************ http://spreadsheetlight.com/sample-code/ *******
            Dim SL As New SLDocument()

            Dim StyleCabecera As SLStyle = SL.CreateStyle()
            Dim StyleCentrado As SLStyle = SL.CreateStyle()
            Dim StyleTitulo As SLStyle = SL.CreateStyle()

            Dim StyleVerde As SLStyle = SL.CreateStyle()
            Dim StyleRosado As SLStyle = SL.CreateStyle()

            StyleTitulo.Font.Bold = True
            StyleTitulo.Font.FontSize = 14
            StyleTitulo.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.White, System.Drawing.Color.White)

            StyleCabecera.Font.Bold = True
            StyleCabecera.Font.FontSize = 10
            StyleCabecera.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.Yellow, System.Drawing.Color.White)

            StyleCentrado.Alignment.Horizontal = HorizontalAlignmentValues.Center
            StyleCentrado.Border.RightBorder.BorderStyle = BorderStyleValues.Hair
            StyleCentrado.Border.LeftBorder.BorderStyle = BorderStyleValues.Hair
            StyleCentrado.Border.TopBorder.BorderStyle = BorderStyleValues.Hair

            StyleVerde.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.PaleGreen, System.Drawing.Color.White)
            StyleVerde.FormatCode = "#,##0"
            StyleRosado.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.LightSalmon, System.Drawing.Color.White)
            StyleRosado.FormatCode = "#,##0"

            SL.MergeWorksheetCells("A1", "G1")
            SL.MergeWorksheetCells("A2", "G2")
            Dim Titulo As String = Trim(CmbCentros.Text) + " / " + Trim(CmbBodegas.Text)
            SL.SetCellValue("A1", Titulo)
            SL.SetCellValue("A2", NombreCliente)
            SL.SetCellStyle("A1", StyleTitulo)
            SL.SetCellStyle("A2", StyleTitulo)

            '----- Encabezado de las columnas de la Tabla -------------
            For i = 1 To DGridExportar.ColumnCount
                SL.SetCellValue(3, i, DGridExportar.Columns(i - 1).HeaderText)
                SL.SetCellStyle(3, i, StyleCabecera)
                SL.SetCellStyle(3, i, StyleCentrado)
            Next

            '----- Datos de la Tabla -------------------------------
            For F = 0 To DGridExportar.Rows.Count - 1
                For C = 1 To DGridExportar.ColumnCount
                    SL.SetCellValue(F + 4, C, Trim(DGridExportar.Rows(F).Cells(C - 1).Value))
                Next

            Next

            If DGridExportar.Columns(0).HeaderText = "IDPROCESO" Then
                SL.SetCellStyle(4, 7, DGridExportar.Rows.Count + 3, 14, StyleCentrado) 'Centrar Valores
                SL.SetCellStyle(4, 11, DGridExportar.Rows.Count + 3, 12, StyleVerde) 'Colorear Verde 
                SL.SetCellStyle(4, 13, DGridExportar.Rows.Count + 3, 14, StyleRosado) 'Colorear Rosado
            Else
                SL.SetCellStyle(4, 3, DGridExportar.Rows.Count + 3, 11, StyleCentrado) 'Centrar Valores
                SL.SetCellStyle(4, 3, DGridExportar.Rows.Count + 3, 3, StyleVerde) 'Colorear Verde 
                SL.SetCellStyle(4, 5, DGridExportar.Rows.Count + 3, 5, StyleVerde) 'Colorear Verde 
                SL.SetCellStyle(4, 6, DGridExportar.Rows.Count + 3, 7, StyleRosado) 'Colorear Rosado

            End If


            SL.SaveAs(SDArchivo.FileName + ".xlsx")

            MsgBox("Archivo generado con Exito!", MsgBoxStyle.Information, Gl_NomCompañia)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub DGDepositos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDepositos.CellClick

        Dim FechaCorte As String

        LblTotal.Text = 0
        LblBultos.Text = 0
        LblBloqueo.Text = 0
        LblBultosBloqueo.Text = 0

        FechaCorte = DTFechaCorte.Value

        DGInventario.DataSource = Nothing

        If FechaCorte > Date.Now Then
            MsgBox("Fecha de Corte es mayor a la fecha Actual.", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Try
            CodDeposito = Trim(DGDepositos.Rows(e.RowIndex).Cells(2).Value)
            Me.NombreCliente = Trim(DGDepositos.Rows(e.RowIndex).Cells(1).Value)
        Catch ex As Exception
        End Try


        Consulta = Reportes.ListarInventarios(CodDeposito, DTFechaCorte.Value)

        Tabla.Load(Consulta)
        DGInventario.DataSource = Tabla

        DGInventario.Columns("BULTOSDISPONIBLE").HeaderText = "BULTOS"
        DGInventario.Columns("DEPOSITO").Visible = False
        DGInventario.Columns("IDPRESENTACION").Visible = False
        DGInventario.Columns("ID").Visible = False
        DGInventario.Columns("SIMBOLO").Width = 40
        DGInventario.Columns("DISPONIBLE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGInventario.Columns("SIMBOLO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGInventario.Columns("BULTOSDISPONIBLE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGInventario.Columns("BLOQUEADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGInventario.Columns("BULTOSBLOQUEADOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGInventario.Columns("BULTOSDISPONIBLE").HeaderText = "BULTOS"
        DGInventario.Columns("BULTOSBLOQUEADOS").HeaderText = "B.BLOQUEADOS"


        For I = 0 To DGInventario.Rows.Count - 1
            LblTotal.Text += (DGInventario.Rows(I).Cells(2).Value)
            LblBultos.Text += Math.Abs(Val(DGInventario.Rows(I).Cells(4).Value))
            LblBloqueo.Text += Math.Abs(Val(DGInventario.Rows(I).Cells(3).Value))
            LblBultosBloqueo.Text += Math.Abs(Val(DGInventario.Rows(I).Cells(6).Value))
        Next


        Try
            If DGInventario.SelectedRows.Count > 0 Then
                DGInventario.CurrentRow.Selected = False
            End If

        Catch ex As Exception
        End Try

        '----------- ESTA SECCION ES PARA QUITAR LOS PRODUCTOS SIN EXISTENCIAS ------------
        DGInventario.MultiSelect = True

        For I = 0 To DGInventario.Rows.Count - 1

            If Trim(DGInventario.Rows(I).Cells(2).Value) = 0 Then
                DGInventario.Rows(I).Selected = True
            End If

        Next

        '-------------Borro los Seleccionados ------------
        Dim value0 As DataGridViewSelectedRowCollection
        value0 = DGInventario.SelectedRows

        For Each vfila As DataGridViewRow In value0
            DGInventario.Rows.Remove(vfila)
        Next
        '-------------------------------------------------

        DGInventario.MultiSelect = False

        '-----------------------------------------------------------------------------------



        '---- Mostrar el informe Total ---------

        DGRegistros.DataSource = Nothing

        Dim ConsultaTotal As SqlDataReader
        Dim TablaTotal As New DataTable

        ConsultaTotal = Reportes.TotalDeposito(CodDeposito)
        TablaTotal.Load(ConsultaTotal)
        DGRegistros.DataSource = TablaTotal

        '---------------------------------------


    End Sub

    Private Sub BtnGeneral_Click(sender As Object, e As EventArgs) Handles BtnGeneral.Click

        If CodDeposito = "" Then
            MsgBox("Seleccione el cliente de quien desea el reporte detallado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        DGInventario.DataSource = Nothing

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = Reportes.TotalDeposito(CodDeposito)
        Tabla.Load(Consulta)
        DGInventario.DataSource = Tabla

    End Sub

    Private Sub DGDepositos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDepositos.CellContentClick

    End Sub

End Class