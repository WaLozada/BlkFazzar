Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight

Public Class For_EquiposBajas
    Dim Activos As New ActivosTI()
    Sub Listar()

        TxtNumero.Text = ""
        DGResultado.DataSource = Nothing

        Try
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Activos.ListarBajas()

            Tabla.Load(Consulta)
            DGListadoBaja.DataSource = Tabla

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


        Try
            If DGListadoBaja.SelectedRows.Count > 0 Then
                DGListadoBaja.CurrentRow.Selected = False
            End If

        Catch ex As Exception
        End Try

        DGListadoBaja.Sort(DGListadoBaja.Columns("IDACTIVO"), ListSortDirection.Ascending)

    End Sub
    Private Sub For_EquiposBajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Listar()

    End Sub
    Private Sub CmbElemento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbElemento.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbElemento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbElemento.SelectedIndexChanged
        TxtNumero.Focus()
    End Sub

    Private Sub TxtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnBuscar.Focus()
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        If TxtNumero.Text = "" Then
            MsgBox("Nada Para Consultar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            Exit Sub
        End If

        Dim Campo As String = Trim(CmbElemento.Text)
        Dim Valor As String = ""

        If Campo = "ACTIVO" Then
            Valor = String.Format("{0:00000}", Val(TxtNumero.Text))
        Else
            Valor = Trim(TxtNumero.Text)
        End If

        Try
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Activos.ListarEquipo(Campo, Valor)

            Tabla.Load(Consulta)
            DGResultado.DataSource = Tabla

            DGResultado.Columns("IDTIPO").Visible = False
            DGResultado.Columns("NOMBRE_POBLADO").HeaderText = "CIUDAD"
            DGResultado.Columns("FECHACOMPRA").DefaultCellStyle.Format = "yyyy-MM-dd"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

        Try
            If DGResultado.SelectedRows.Count > 0 Then
                DGResultado.CurrentRow.Selected = False
            End If

        Catch ex As Exception
        End Try


    End Sub
    Private Sub For_EquiposBajas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()

    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click

        Try

            If DGListadoBaja.RowCount = 0 Then
                MsgBox("Nada para Exportar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                Exit Sub
            End If

            SDArchivo.FileName = "InventariodeBaja"


            If SDArchivo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            If SDArchivo.FileName = "" Then
                MsgBox("Ingrese el Nombre del archivo Excel", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            End If


            Dim FH As Date = FechaHoraServer()

            Dim SL As New SLDocument()

            Dim StyleCabecera As SLStyle = SL.CreateStyle()
            Dim StyleCentrado As SLStyle = SL.CreateStyle()

            StyleCabecera.Font.Bold = True
            StyleCabecera.Font.FontSize = 10
            StyleCabecera.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.Yellow, System.Drawing.Color.White)

            StyleCentrado.Alignment.Horizontal = HorizontalAlignmentValues.Center
            StyleCentrado.Border.RightBorder.BorderStyle = BorderStyleValues.Hair
            StyleCentrado.Border.LeftBorder.BorderStyle = BorderStyleValues.Hair
            StyleCentrado.Border.TopBorder.BorderStyle = BorderStyleValues.Hair

            '----- Encabezado de las columnas de la Tabla -------------
            For i = 1 To DGListadoBaja.ColumnCount - 1
                SL.SetCellValue(1, i, DGListadoBaja.Columns(i - 1).HeaderText)
                SL.SetCellStyle(1, i, StyleCabecera)
                SL.SetCellStyle(1, i, StyleCentrado)
            Next

            '----- Datos de la Tabla -------------------------------
            For F = 0 To DGListadoBaja.Rows.Count - 1
                For C = 1 To DGListadoBaja.ColumnCount - 1
                    SL.SetCellValue(F + 2, C, Trim(DGListadoBaja.Rows(F).Cells(C - 1).Value))
                Next
            Next

            SL.SaveAs(SDArchivo.FileName + ".xlsx")

            MsgBox("Archivo generado con Exito!", MsgBoxStyle.Information, Gl_NomCompañia)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub DGResultado_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGResultado.CellFormatting
        e.CellStyle.SelectionBackColor = e.CellStyle.BackColor
        e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor
    End Sub

    Private Sub BtnDarBaja_Click(sender As Object, e As EventArgs) Handles BtnDarBaja.Click

        If DGResultado.Rows.Count = 0 Then
            MsgBox("Ningún elemento en la lista!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            TxtNumero.Focus()
            Exit Sub
        End If

        For_EquiposDarbaja.LblActivo.Text = DGResultado.Rows(0).Cells(0).Value
        For_EquiposDarbaja.LblElemento.Text = DGResultado.Rows(0).Cells(2).Value
        For_EquiposDarbaja.LblMarca.Text = DGResultado.Rows(0).Cells(3).Value
        For_EquiposDarbaja.LblModelo.Text = DGResultado.Rows(0).Cells(4).Value
        For_EquiposDarbaja.LblSerial.Text = DGResultado.Rows(0).Cells(5).Value


        For_EquiposDarbaja.ShowDialog()


    End Sub
End Class