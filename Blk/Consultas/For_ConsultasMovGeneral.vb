Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight
Imports System.ComponentModel
Imports System.Globalization

Public Class For_ConsultasMovGeneral
    Dim Reportes As New Consultas()

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click

        Dim TMov As Char() = ""

        If CmbMovimiento.Text = "" Then
            MsgBox("Seleccione el Tipo de Movimiento para Generar el Reporte!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbMovimiento.Focus()
            Exit Sub
        Else
            Select Case CmbMovimiento.Text
                Case "INGRESOS"
                    TMov = "E"
                Case "DESPACHOS"
                    TMov = "S"
                Case "TODO"
                    TMov = "T"
            End Select
        End If

        Dim Desde, Hasta As String

        Desde = CalendarDesde.SelectionRange.Start.Year & "-" & Long.Parse(CalendarDesde.SelectionRange.Start.Month).ToString("00") & "-" & Long.Parse(CalendarDesde.SelectionRange.Start.Day).ToString("00")
        Hasta = CalendarHasta.SelectionRange.Start.Year & "-" & Long.Parse(CalendarHasta.SelectionRange.Start.Month).ToString("00") & "-" & Long.Parse(CalendarHasta.SelectionRange.Start.Day).ToString("00")

        If Hasta < Desde Then
            MsgBox("La fecha final de la consulta es menor a la fecha de inicio!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        If Hasta > Date.Now Then
            MsgBox("La fecha final de la consulta es mayor al dia actual!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        DGInforme.DataSource = Nothing

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = Reportes.ListarIngresosDespachos(TMov, Desde, Hasta)

        Tabla.Load(Consulta)
        DGInforme.DataSource = Tabla


        DGInforme.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGInforme.Columns("BULTOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGInforme.Columns("BULTOSBLOQUEO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGInforme.Columns("BLOQUEO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGInforme.Columns("TIPOMOV").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGInforme.Columns("BULTOSBLOQUEO").HeaderText = "B.BLOQUEO"
        DGInforme.Columns("CODCLIENTE").Visible = False
        DGInforme.Columns("ID").Visible = False

        DGInforme.Columns("FECHA").DefaultCellStyle.Format = "yyyy-MM-dd"

        'For i = 0 To DGInforme.Rows.Count - 1
        '    LblTotal.Text += Math.Abs(Val(DGInforme.Rows(i).Cells(5).Value))
        '    LblBultos.Text += Math.Abs(Val(DGInforme.Rows(i).Cells(6).Value))
        '    If CmbMovimiento.Text = "INGRESOS" Then
        '        LblBloqueo.Text += Math.Abs(Val(DGInforme.Rows(i).Cells(7).Value))
        '        LblBultosBloqueo.Text += Math.Abs(Val(DGInforme.Rows(i).Cells(8).Value))
        '    End If

        'Next

    End Sub

    Private Sub CmbMovimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMovimiento.SelectedIndexChanged
        BtnConsultar.Focus()
    End Sub

    Private Sub CmbMovimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbMovimiento.KeyPress
        e.Handled = True
    End Sub

    Private Sub For_ConsultasMovGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------
    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click

        Try

            If DGInforme.RowCount = 0 Then
                MsgBox("Nada para Exportar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                Exit Sub
            End If

            Dim Desde = CalendarDesde.SelectionRange.Start.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
            Dim Hasta = CalendarHasta.SelectionRange.Start.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

            SDArchivo.FileName = "Reporte_General_Movimientos_" & Desde & "_" & Hasta

            If SDArchivo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            If SDArchivo.FileName = "" Then
                MsgBox("Ingrese el Nombre del archivo Excel", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            End If

            Dim SL As New SLDocument()

            Dim StyleCabecera As SLStyle = SL.CreateStyle()
            Dim StyleCentrado As SLStyle = SL.CreateStyle()
            Dim StyleTitulo As SLStyle = SL.CreateStyle()
            Dim StyleFecha As SLStyle = SL.CreateStyle()
            Dim StyleNumeros As SLStyle = SL.CreateStyle()

            Dim StyleVerde As SLStyle = SL.CreateStyle()
            Dim StyleRosado As SLStyle = SL.CreateStyle()

            StyleTitulo.Font.Bold = True
            StyleTitulo.Font.FontSize = 16
            StyleTitulo.Border.RightBorder.BorderStyle = BorderStyleValues.MediumDashed
            StyleTitulo.Border.LeftBorder.BorderStyle = BorderStyleValues.MediumDashed
            StyleTitulo.Border.TopBorder.BorderStyle = BorderStyleValues.MediumDashed
            StyleTitulo.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.White, System.Drawing.Color.White)

            StyleCabecera.Font.Bold = True
            StyleCabecera.Font.FontSize = 10
            StyleCabecera.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.Yellow, System.Drawing.Color.White)

            StyleFecha.FormatCode = "yyyy-MM-dd"
            StyleNumeros.FormatCode = "###0_);[Red](###0)"

            StyleCentrado.Alignment.Horizontal = HorizontalAlignmentValues.Center

            'StyleVerde.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.PaleGreen, System.Drawing.Color.White)
            'StyleRosado.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.LightSalmon, System.Drawing.Color.White)

            SL.MergeWorksheetCells("A1", "G1")
            SL.SetCellValue("A1", "Relación General de Movimientos Desde: " & Desde & " Hasta: " & Hasta)
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

            SL.SetCellStyle(3, 14, DGInforme.Rows.Count + 2, 14, StyleFecha) 'Estilo Fecha
            SL.SetCellStyle(3, 4, DGInforme.Rows.Count + 2, 4, StyleCentrado) 'Centrar Valores
            SL.SetCellStyle(3, 8, DGInforme.Rows.Count + 2, 8, StyleCentrado) 'Centrar Valores
            SL.SetCellStyle(3, 9, DGInforme.Rows.Count + 2, 12, StyleNumeros) 'Numeros
            'SL.SetCellStyle(3, 7, DGInforme.Rows.Count + 2, 7, StyleVerde) 'Colorear Verde 

            'SL.SetCellStyle(3, 5, DGConsulta.Rows.Count + 2, 8, StyleRosado) 'Colorear Rosado
            'SL.SetCellStyle(3, 9, DGConsulta.Rows.Count + 2, 9, StyleRosado) 'Colorear Rosado 


            SL.SaveAs(SDArchivo.FileName + ".xlsx")

            MsgBox("Archivo generado con Exito!", MsgBoxStyle.Information, Gl_NomCompañia)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub For_ConsultasMovGeneral_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub
End Class