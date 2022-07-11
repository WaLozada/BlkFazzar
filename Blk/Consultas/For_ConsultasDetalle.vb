Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight

Public Class For_ConsultasDetalle
    Dim Reportes As New Consultas()
    Private Sub For_ConsultasDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------
    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click

        Try

            If DGConsulta.RowCount = 0 Then
                MsgBox("Nada para Exportar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                Exit Sub
            End If

            SDArchivo.FileName = "InventarioGeneral"


            If SDArchivo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            If SDArchivo.FileName = "" Then
                MsgBox("Ingrese el Nombre del archivo Excel", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            End If


            Dim FH As Date = FechaHoraServer()
            'Dim Titulo As String

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

    Private Sub DGConsulta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGConsulta.CellClick
        Dim Deposito As String = ""
        Dim CodProducto As String = ""

        Try
            Deposito = Trim(DGConsulta.Rows(e.RowIndex).Cells(0).Value)
            CodProducto = Trim(DGConsulta.Rows(e.RowIndex).Cells(1).Value)
        Catch ex As Exception

        End Try

        DGLotes.DataSource = Nothing


        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = Reportes.EjecutarReporte(For_ConsultasResportes.CmbReporte.SelectedValue, Deposito, CodProducto)
        Tabla.Load(Consulta)
        DGLotes.DataSource = Tabla

    End Sub

    Private Sub For_ConsultasDetalle_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub DGConsulta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGConsulta.CellContentClick

    End Sub
End Class