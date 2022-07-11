Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight

Public Class For_ConsultasDiario
    Dim Centro As New Centros()
    Dim Bodega As New Bodegas()
    Dim Reportes As New Consultas()

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
    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click

        If CmbCentros.Text = "" Then
            MsgBox("Seleccione el Centro de Distribución!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbCentros.Focus()
            Exit Sub
        End If

        If CmbBodegas.Text = "" Then
            MsgBox("Seleccione la Bodega!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbBodegas.Focus()
            Exit Sub
        End If

        If CmbMovimiento.Text = "" Then
            MsgBox("Seleccione el Tipo de Movimiento para Generar el Reporte!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbMovimiento.Focus()
            Exit Sub
        End If

        Dim FechaCorte As String = DTFechaCorte.Value

        If FechaCorte > Date.Now Then
            MsgBox("Fecha del Reporte es mayor a la fecha Actual.", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If


        LblTotal.Text = 0
        LblBultos.Text = 0
        LblBloqueo.Text = 0
        LblBultosBloqueo.Text = 0


        DGInforme.DataSource = Nothing

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        If CmbMovimiento.Text = "INGRESOS" Then
            Consulta = Reportes.ListarIngresos(CmbBodegas.SelectedValue, DTFechaCorte.Value)
            GBBloqueo.Visible = True
        Else
            Consulta = Reportes.ListarDespachos(CmbBodegas.SelectedValue, DTFechaCorte.Value)
            GBBloqueo.Visible = False
        End If


        Tabla.Load(Consulta)
        DGInforme.DataSource = Tabla

        DGInforme.Columns("ID").Visible = False

        For i = 0 To DGInforme.Rows.Count - 1
            LblTotal.Text += Math.Abs(Val(DGInforme.Rows(i).Cells(5).Value))
            LblBultos.Text += Math.Abs(Val(DGInforme.Rows(i).Cells(6).Value))
            If CmbMovimiento.Text = "INGRESOS" Then
                LblBloqueo.Text += Math.Abs(Val(DGInforme.Rows(i).Cells(7).Value))
                LblBultosBloqueo.Text += Math.Abs(Val(DGInforme.Rows(i).Cells(8).Value))
            End If

        Next
        DGInforme.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGInforme.Columns("BULTOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        If CmbMovimiento.Text = "INGRESOS" Then
            DGInforme.Columns("BLOQUEO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGInforme.Columns("BULTOSBLOQUEO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

    End Sub
    Private Sub For_ConsultasIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        CargarCombo()
    End Sub
    Private Sub For_ConsultasIngresos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub CmbCentros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCentros.SelectedIndexChanged

        DGInforme.DataSource = Nothing
        LblTotal.Text = 0
        LblBultos.Text = 0
        LblBloqueo.Text = 0
        LblBultosBloqueo.Text = 0

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
        CmbMovimiento.Focus()
    End Sub

    Private Sub CmbBodegas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbBodegas.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click

        Dim Dia As Date = DTFechaCorte.Value

        Dim FechaCorte As String = Dia.Year & "-" & Long.Parse(Dia.Month).ToString("00") & "-" & Long.Parse(Dia.Day).ToString("00")

        Try

            If DGInforme.RowCount = 0 Then
                MsgBox("Nada para Exportar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                Exit Sub
            End If

            If CmbMovimiento.Text = "INGRESOS" Then
                SDArchivo.FileName = "Reporte_Diario_Ingresos_" & FechaCorte
            Else
                SDArchivo.FileName = "Reporte_Diario_Despachos_" & FechaCorte
            End If


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
            StyleVerde.FormatCode = "#,##0"
            StyleRosado.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.LightSalmon, System.Drawing.Color.White)
            StyleRosado.FormatCode = "#,##0"

            SL.MergeWorksheetCells("A1", "E1")
            If CmbMovimiento.Text = "INGRESOS" Then
                SL.SetCellValue("A1", "Reporte Diario de Ingreso de Mercancía / " & FechaCorte.ToString)
            Else
                SL.SetCellValue("A1", "Reporte Diario de Despacho de Mercancía / " & FechaCorte.ToString)
            End If

            SL.SetCellStyle("A1", StyleTitulo)

            '----- Encabezado de las columnas de la Tabla -------------
            For i = 1 To DGInforme.ColumnCount
                SL.SetCellValue(2, i, DGInforme.Columns(i - 1).HeaderText)
                SL.SetCellStyle(2, i, StyleCabecera)
                SL.SetCellStyle(2, i, StyleCentrado)
            Next

            '----- Datos de la Tabla -------------------------------
            For F = 0 To DGInforme.Rows.Count - 1
                For C = 1 To DGInforme.ColumnCount
                    SL.SetCellValue(F + 3, C, Trim(DGInforme.Rows(F).Cells(C - 1).Value.ToString))
                Next

            Next

            SL.SetCellStyle(3, 6, DGInforme.Rows.Count + 2, 9, StyleCentrado) 'Centrar Valores
            SL.SetCellStyle(3, 6, DGInforme.Rows.Count + 2, 6, StyleVerde) 'Colorear Verde 
            SL.SetCellStyle(3, 7, DGInforme.Rows.Count + 2, 7, StyleVerde) 'Colorear Verde 

            If CmbMovimiento.Text = "INGRESOS" Then
                SL.SetCellStyle(3, 8, DGInforme.Rows.Count + 2, 8, StyleRosado) 'Colorear Rosado
                SL.SetCellStyle(3, 9, DGInforme.Rows.Count + 2, 9, StyleRosado) 'Colorear Rosado 
            End If


            SL.SaveAs(SDArchivo.FileName + ".xlsx")

            MsgBox("Archivo generado con Exito!", MsgBoxStyle.Information, Gl_NomCompañia)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub CmbMovimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMovimiento.SelectedIndexChanged
        DTFechaCorte.Focus()
    End Sub

    Private Sub CmbMovimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbMovimiento.KeyPress
        e.Handled = True
    End Sub
End Class