Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet
Imports Microsoft.Reporting.WinForms
Imports SpreadsheetLight
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class For_RecaudoServicios
    Dim Reportes As New Consultas()
    Dim Centro As New Centros()
    Dim Bodega As New Bodegas()
    Dim RecibosVisor As New ClsRecibosVisor()
    Dim Desde, Hasta As String

    Sub ExportDataToPDFTable()

        Try


            Dim paragraph As New Paragraph
            Dim doc As New Document(iTextSharp.text.PageSize.LETTER, 40, 40, 50, 40)

            Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(SaveFileDialog1.FileName + ".pdf", FileMode.Create))
            Dim Archivo As String = SaveFileDialog1.FileName + ".pdf"
            doc.Open()

            'Dim font12BoldRed As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.UNDERLINE Or iTextSharp.text.Font.BOLDITALIC, BaseColor.BLUE)
            Dim fontBold As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 5.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
            Dim fontNormal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 6.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
            Dim fontTitulo As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)

            Dim p1, p2, p3 As New Phrase
            p1 = New Phrase(New Chunk(UCase(Gl_NomCompañia), fontTitulo))

            p2 = New Phrase(New Chunk(Chr(13) + "BODEGA :" + Trim(CmbBodegas.Text), fontTitulo))

            Dim Titulo = Chr(13) + "Recaudo por Cargues/Descargues desde " & Desde & " hasta " & Hasta

            p3 = New Phrase(New Chunk(Titulo, fontTitulo))

            doc.Add(p1)
            doc.Add(p2)
            doc.Add(p3)

            'Create instance of the pdf table and set the number of column in that table
            Dim PdfTable As New PdfPTable(DGInformePDF.ColumnCount)
            PdfTable.TotalWidth = 490.0F
            'fix the absolute width of the table
            PdfTable.LockedWidth = True
            'relative col widths in proportions - 1,4,1,1 and 1
            Dim headerwidths As Single() = GetColumnasSize(DGInformePDF)
            PdfTable.SetWidths(headerwidths)

            PdfTable.HorizontalAlignment = 1 ' 0 --> Left, 1 --> Center, 2 --> Right
            PdfTable.SpacingBefore = 2.0F

            'pdfCell Decleration
            Dim PdfPCell As PdfPCell = Nothing
            Dim PdfPCell1 As PdfPCell = Nothing

            Dim dt As New DataTable
            dt = ConvertDataGridviewInDataTable(DGInformePDF)

            If dt IsNot Nothing Then

                '---- imprimir el encabezado de la tabla ----------
                For column As Integer = 0 To dt.Columns.Count - 1
                    PdfTable.AddCell(New PdfPCell(New Phrase(DGInformePDF.Columns(column).HeaderText, fontBold)))
                Next
                PdfTable.HeaderRows = 1
                PdfTable.DefaultCell.BorderWidth = 1
                '---------------------------------------------------

                'Now add the data from datatable to pdf table
                For rows As Integer = 0 To dt.Rows.Count - 1
                    For column As Integer = 0 To dt.Columns.Count - 1
                        PdfPCell = New PdfPCell(New Phrase(dt.Rows(rows)(column).ToString(), fontNormal))
                        If column = 0 Or column = 1 Or column = 2 Or column = 6 Or column = 10 Then
                            PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                        ElseIf column = 4 Or column = 5 Then
                            PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        ElseIf column = 3 Or column = 9 Then
                            PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                        End If
                        PdfTable.AddCell(PdfPCell)
                    Next
                Next
                'Adding pdftable to the pdfdocument
                doc.Add(PdfTable)
            End If

            Dim Vacia = " " + Chr(13)
            P2 = New Phrase(New Chunk(Vacia, fontTitulo))

            doc.Add(P2)


            Dim DatoFinal1 As New Paragraph("Realizados : " + DGInformePDF.Rows.Count.ToString, fontTitulo)
            Dim DatoFinal2 As New Paragraph("Recaudo : " + LblTotal.Text, fontTitulo)
            Dim PiedeHoja As New Paragraph("Impreso por " + UsuarioApp.Nombre + " " + UsuarioApp.Papellido + " el " + Now(), fontNormal)

            doc.Add(DatoFinal1)
            doc.Add(DatoFinal2)
            doc.Add(PiedeHoja)

            doc.Close()

            MsgBox("El documento PDF se a creado correctamente.!", MsgBoxStyle.Information, Gl_NomCompañia)

            Process.Start(Archivo)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub
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
        Dim Consulta1 As SqlDataReader
        Dim Tabla1 As New DataTable

        Consulta = Reportes.ListarRecaudoServicios(1, CmbCentros.SelectedValue, CmbBodegas.SelectedValue, Desde, Hasta)
        Tabla.Load(Consulta)



        DGInforme.DataSource = Tabla

        DGInforme.Columns("CODCEDIS").Visible = False
        DGInforme.Columns("CODBODEGA").Visible = False
        DGInforme.Columns("CODCLIENTE").Visible = False
        DGInforme.Columns("CODUNIDAD").Visible = False
        DGInforme.Columns("USUARIOAPP").Visible = False
        DGInforme.Columns("TOTAL").DefaultCellStyle.Format = "C0"
        DGInforme.Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGInforme.Columns("TIPOMOV").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGInforme.Columns("RECIBO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGInforme.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGInforme.Columns("IDPROCESO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGInforme.Columns("ID").Visible = False
        DGInforme.Columns("FECHA").DefaultCellStyle.Format = "yyyy-MM-dd"

        Dim Total As Integer = 0

        For i = 0 To DGInforme.Rows.Count - 1
            Total += DGInforme.Rows(i).Cells("TOTAL").Value
        Next

        LblTotal.Text = FormatCurrency(Total, 0)

        '-------------- Informe para el PDF -------------------------------
        Consulta1 = Reportes.ListarRecaudoServicios(2, CmbCentros.SelectedValue, CmbBodegas.SelectedValue, Desde, Hasta)
        Tabla1.Load(Consulta1)
        DGInformePDF.DataSource = Tabla1
        'DGInformePDF.Columns("TOTAL").DefaultCellStyle.Format = "C0"
        DGInformePDF.Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGInformePDF.Columns("IDPROCESO").Width = 70
        DGInformePDF.Columns("CODBODEGA").Width = 80
        DGInformePDF.Columns("RECIBO").Width = 60
        DGInformePDF.Columns("CEDIS").Width = 150
        DGInformePDF.Columns("MOV").Width = 40
        DGInformePDF.Columns("CEDIS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGInformePDF.Columns("BODEGA").Width = 150

    End Sub

    Private Sub For_RecaudoServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        CargarCombo()
    End Sub

    Private Sub CmbCentros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCentros.SelectedIndexChanged

        DGInforme.DataSource = Nothing

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
        BtnConsultar.Focus()
    End Sub

    Private Sub CmbBodegas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbBodegas.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click

        Try

            If DGInforme.RowCount = 0 Then
                MsgBox("Nada para Exportar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                Exit Sub
            End If

            Dim Desde, Hasta As String

            Desde = CalendarDesde.SelectionRange.Start.Year & "-" & Long.Parse(CalendarDesde.SelectionRange.Start.Month).ToString("00") & "-" & Long.Parse(CalendarDesde.SelectionRange.Start.Day).ToString("00")
            Hasta = CalendarHasta.SelectionRange.Start.Year & "-" & Long.Parse(CalendarHasta.SelectionRange.Start.Month).ToString("00") & "-" & Long.Parse(CalendarHasta.SelectionRange.Start.Day).ToString("00")


            SDArchivo.FileName = "Arqueo_Cargue_Descargue_" & Desde & "-" & Hasta


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

            SL.MergeWorksheetCells("A1", "H1")

            SL.SetCellValue("A1", "Arqueo de Recaudo Cargues y Descargues / " & Desde & " al " & Hasta)


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
            'SL.SetCellStyle(3, 6, DGInforme.Rows.Count + 2, 6, StyleVerde) 'Colorear Verde 
            'SL.SetCellStyle(3, 7, DGInforme.Rows.Count + 2, 7, StyleVerde) 'Colorear Verde 


            SL.SaveAs(SDArchivo.FileName + ".xlsx")

            MsgBox("Archivo generado con Exito!", MsgBoxStyle.Information, Gl_NomCompañia)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("48")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        If RecibosVisor.Idproceso = "" Then
            MsgBox("Seleccione la Orden que desea imprimir el Recibo!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Try

            For_RecaudoVisor.ReportViewer1.LocalReport.DataSources.Clear()

            Dim IdProceso As ReportParameter = New ReportParameter("IdProceso", RecibosVisor.Idproceso.ToString)
            Dim Recibo As ReportParameter = New ReportParameter("Recibo", RecibosVisor.Recibo.ToString)
            Dim Centro As ReportParameter = New ReportParameter("Centro", RecibosVisor.Centro.ToString)
            Dim Bodega As ReportParameter = New ReportParameter("Bodega", RecibosVisor.Bodega.ToString)
            Dim CodBodega As ReportParameter = New ReportParameter("CodBodega", RecibosVisor.CodBodega.ToString)
            Dim Cliente As ReportParameter = New ReportParameter("Cliente", RecibosVisor.Cliente.ToString)
            Dim ValorTotal As ReportParameter = New ReportParameter("ValorTotal", FormatCurrency(RecibosVisor.ValorTotal.ToString, 0))
            Dim DocConductor As ReportParameter = New ReportParameter("DocConductor", RecibosVisor.Docconductor.ToString)
            Dim NombreConductor As ReportParameter = New ReportParameter("NombreConductor", RecibosVisor.Nombreconductor.ToString & " " & RecibosVisor.Apellidoconductor.ToString)
            Dim Fecha As ReportParameter = New ReportParameter("Fecha", RecibosVisor.Fecha.ToString)
            Dim Hora As ReportParameter = New ReportParameter("Hora", RecibosVisor.Hora.ToString)

            For_RecaudoVisor.ReportViewer1.LocalReport.SetParameters(IdProceso)
            For_RecaudoVisor.ReportViewer1.LocalReport.SetParameters(Recibo)
            For_RecaudoVisor.ReportViewer1.LocalReport.SetParameters(Centro)
            For_RecaudoVisor.ReportViewer1.LocalReport.SetParameters(Bodega)
            For_RecaudoVisor.ReportViewer1.LocalReport.SetParameters(CodBodega)
            For_RecaudoVisor.ReportViewer1.LocalReport.SetParameters(Cliente)
            For_RecaudoVisor.ReportViewer1.LocalReport.SetParameters(ValorTotal)
            For_RecaudoVisor.ReportViewer1.LocalReport.SetParameters(DocConductor)
            For_RecaudoVisor.ReportViewer1.LocalReport.SetParameters(NombreConductor)
            For_RecaudoVisor.ReportViewer1.LocalReport.SetParameters(Fecha)
            For_RecaudoVisor.ReportViewer1.LocalReport.SetParameters(Hora)


            '------- Listar los Mantenimientos que se han realizado al activo  -------
            Try
                Dim Consulta As SqlDataReader
                Dim Tabla As New DataTable

                Consulta = RecibosVisor.ListarServicios(RecibosVisor.Idproceso)

                Tabla.Load(Consulta)

                Dim rp As ReportDataSource = New ReportDataSource("DataSet1", Tabla)
                For_RecaudoVisor.ReportViewer1.LocalReport.DataSources.Add(rp)
                For_RecaudoVisor.ReportViewer1.Refresh()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            End Try
            '------------------------------------------------------------------------------

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End Try

        For_RecaudoVisor.ShowDialog()


    End Sub
    Private Sub DGInforme_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGInforme.CellClick

        Try

            RecibosVisor.Idproceso = Trim(DGInforme.Rows(e.RowIndex).Cells(0).Value)
            RecibosVisor.Recibo = Trim(DGInforme.Rows(e.RowIndex).Cells(1).Value)
            RecibosVisor.Centro = Trim(DGInforme.Rows(e.RowIndex).Cells(3).Value)
            RecibosVisor.CodBodega = Trim(DGInforme.Rows(e.RowIndex).Cells(4).Value)
            RecibosVisor.Bodega = Trim(DGInforme.Rows(e.RowIndex).Cells(5).Value)
            RecibosVisor.Cliente = Trim(DGInforme.Rows(e.RowIndex).Cells(7).Value)
            RecibosVisor.ValorTotal = Trim(DGInforme.Rows(e.RowIndex).Cells(12).Value)
            RecibosVisor.Docconductor = Trim(DGInforme.Rows(e.RowIndex).Cells(13).Value)
            RecibosVisor.Nombreconductor = Trim(DGInforme.Rows(e.RowIndex).Cells(14).Value)
            RecibosVisor.Apellidoconductor = Trim(DGInforme.Rows(e.RowIndex).Cells(15).Value)
            Dim Fecha As Date = Trim(DGInforme.Rows(e.RowIndex).Cells(16).Value.ToString)
            RecibosVisor.Fecha = Fecha.ToString("MMMM dd, yyyy").ToUpperInvariant
            RecibosVisor.Hora = Trim(DGInforme.Rows(e.RowIndex).Cells(17).Value.ToString)

            'If Trim(DGInforme.Rows(e.RowIndex).Cells(8).Value) = "E" Then
            '    RecibosVisor.Descripcion = "Servicio de Descargue"
            'Else
            '    RecibosVisor.Descripcion = "Servicio de Cargue"
            'End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnPdf_Click(sender As Object, e As EventArgs) Handles BtnPdf.Click

        If DGInformePDF.RowCount = 0 Then
            MsgBox("Nada para Exportar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            Exit Sub
        End If


        SaveFileDialog1.FileName = "Reporte"

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        If SaveFileDialog1.FileName = "" Then
            MsgBox("Ingrese el Nombre del archivo PDF", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        Else
            ExportDataToPDFTable()
        End If

    End Sub

    Private Sub For_RecaudoServicios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class