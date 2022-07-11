Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight

Public Class For_ConsultasResportes
    Dim Reportes As New Consultas()
    Dim Deposito As String

    Sub CargarCombo()

        '-------------------- Cargo los Reportes Establecidos -------------
        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = Reportes.ListarReportes()

        Tabla.Load(Consulta)

        Me.CmbReporte.DisplayMember = "REPORTE"
        Me.CmbReporte.ValueMember = "ID"
        Me.CmbReporte.DataSource = Tabla
        Me.CmbReporte.Text = ""
        '-----------------------------------------------------
    End Sub
    Private Sub For_ConsultasResportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Dim FH As Date = FechaHoraServer()

        CalendarDesde.Text = Long.Parse(FH.Day).ToString("00") & "/" & Long.Parse(FH.Month).ToString("00") & "/" & FH.Year
        CalendarHasta.Text = Long.Parse(FH.Day).ToString("00") & "/" & Long.Parse(FH.Month).ToString("00") & "/" & FH.Year

        CargarCombo()

    End Sub
    Private Sub CmbReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbReporte.SelectedIndexChanged
        CalendarDesde.Focus()
    End Sub
    Private Sub CmbReporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbReporte.KeyPress
        e.Handled = True
    End Sub
    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click

        If CmbReporte.Text = "" Then
            MsgBox("Seleccione el Tipo de Reporte que desea Realizar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbReporte.Focus()
            Exit Sub
        End If

        Dim Desde, Hasta As String

        Desde = CalendarDesde.SelectionRange.Start.Year & "/" & Long.Parse(CalendarDesde.SelectionRange.Start.Month).ToString("00") & "/" & Long.Parse(CalendarDesde.SelectionRange.Start.Day).ToString("00")
        Hasta = CalendarHasta.SelectionRange.Start.Year & "/" & Long.Parse(CalendarHasta.SelectionRange.Start.Month).ToString("00") & "/" & Long.Parse(CalendarHasta.SelectionRange.Start.Day).ToString("00")


        DGConsulta.DataSource = Nothing

        If Desde = "" Or Hasta = "" Then
            MsgBox("Indique el periodo del cual desea Realizar el Soporte!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            Exit Sub
        End If

        If Desde > Hasta Then
            MsgBox("Fecha de Inicio de la Consulta es mayor a la fecha de Culminación.", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = Reportes.EjecutarReporte(CmbReporte.SelectedValue)
        Tabla.Load(Consulta)
        DGConsulta.DataSource = Tabla

        Deposito = ""

    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click

        Try

            If DGConsulta.RowCount = 0 Then
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
            Dim Titulo As String = ""

            '************ http://spreadsheetlight.com/sample-code/ *******

            '// set row 4 with 1st style
            'SL.SetRowStyle(4, style1);
            '// set rows 5 through 8 with 2nd style
            'SL.SetRowStyle(5, 8, style2);

            'SLStyle style3 = SL.CreateStyle();
            'style3.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.Aqua, System.Drawing.Color.DarkSalmon);
            'style.Border.LeftBorder.BorderStyle = BorderStyleValues.Double
            '// set column 5 with 3rd style
            'SL.SetColumnStyle(5, style3);
            '// set columns 7 through 9 with 4th style
            'SL.SetColumnStyle(7, 9, style4);
            'style5.SetFont("Impact", 24);
            'SL.SetCellValue(3, 4, "Do you have style?");
            'SL.SetCellStyle("D3", style5);

            '// set the cells from F3 to I1 to 5th style.
            '// Note that this works as long as the opposite corners of the cell range Is given.
            '// This Is effectively the same as providing
            '// sl.SetCellStyle("F1", "I3", style5);
            '// Or for that matter,
            '// sl.SetCellStyle("I3", "F1", style5);
            'SL.SetCellStyle("F3", "I1", style5);

            '// this sets from rows 1 through 2, columns 11 through 13 with 5th style
            'SL.SetCellStyle(1, 11, 2, 13, style5);

            '// this copies the style from D3 to the range of cells A1B2
            'SL.CopyCellStyle("D3", "A1", "B2");

            '// this copies the style from row 4 to row 10
            'SL.CopyRowStyle(4, 10);

            '// this copies the style from column 8 to columns 1 through 3
            'SL.CopyColumnStyle(8, 1, 3);

            '// gets the existing style from D3
            'SLStyle modstyle = SL.GetCellStyle("D3");
            'modstyle.Fill.SetPattern(PatternValues.DarkHorizontal, SLThemeColorIndexValues.Accent6Color, SLThemeColorIndexValues.Accent5Color);
            'modstyle.RemoveBorder();

            '// sets the modified style to K15
            'SL.SetCellStyle("K15", modstyle);

            'SL.ImportDataTable("A2", DGConsulta, False) --> Importar Tatatables.

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
            For i = 1 To DGConsulta.ColumnCount - 1
                SL.SetCellValue(1, i, DGConsulta.Columns(i).HeaderText)
                SL.SetCellStyle(1, i, StyleCabecera)
                SL.SetCellStyle(1, i, StyleCentrado)
            Next

            '----- Datos de la Tabla -------------------------------
            For F = 0 To DGConsulta.Rows.Count - 1
                For C = 0 To DGConsulta.ColumnCount - 1
                    SL.SetCellValue(F + 2, C, Trim(DGConsulta.Rows(F).Cells(C).Value))
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

    Private Sub BtnDetalle_Click(sender As Object, e As EventArgs) Handles BtnDetalle.Click

        If Deposito = "" Then
            MsgBox("Seleccione el cliente de quien desea el reporte detallado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Dim Desde, Hasta As String

        Desde = CalendarDesde.SelectionRange.Start.Year & "/" & Long.Parse(CalendarDesde.SelectionRange.Start.Month).ToString("00") & "/" & Long.Parse(CalendarDesde.SelectionRange.Start.Day).ToString("00")
        Hasta = CalendarHasta.SelectionRange.Start.Year & "/" & Long.Parse(CalendarHasta.SelectionRange.Start.Month).ToString("00") & "/" & Long.Parse(CalendarHasta.SelectionRange.Start.Day).ToString("00")


        For_ConsultasDetalle.DGConsulta.DataSource = Nothing

        If Desde = "" Or Hasta = "" Then
            MsgBox("Indique el periodo del cual desea Realizar el Soporte!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            Exit Sub
        End If

        If Desde > Hasta Then
            MsgBox("Fecha de Inicio de la Consulta es mayor a la fecha de Culminación.", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = Reportes.EjecutarReporte(CmbReporte.SelectedValue, Deposito)
        Tabla.Load(Consulta)
        For_ConsultasDetalle.DGConsulta.DataSource = Tabla


        For_ConsultasDetalle.ShowDialog()


    End Sub

    Private Sub DGConsulta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGConsulta.CellClick
        Try
            Deposito = Trim(DGConsulta.Rows(e.RowIndex).Cells(4).Value)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub For_ConsultasResportes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub BtnGeneral_Click(sender As Object, e As EventArgs) Handles BtnGeneral.Click

        If Deposito = "" Then
            MsgBox("Seleccione el cliente de quien desea el reporte detallado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        DGConsulta.DataSource = Nothing

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = Reportes.TotalDeposito(Deposito)
        Tabla.Load(Consulta)
        DGConsulta.DataSource = Tabla


    End Sub
End Class