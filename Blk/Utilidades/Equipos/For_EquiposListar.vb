Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight
Public Class For_EquiposListar
    Dim Activos As New ActivosTI()
    Sub CargarCombos()

        '-------------------- Cargo los Tipos de Activo -------------
        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = Activos.ListarTipos()

        Tabla.Load(Consulta)

        Me.CmbTipo.DisplayMember = "TIPO"
        Me.CmbTipo.ValueMember = "IDTIPO"
        Me.CmbTipo.DataSource = Tabla
        Me.CmbTipo.Text = ""
        '-----------------------------------------------------

        '-------------- Cargo Los Lugares ---------------------
        Dim dv1 As New DataView

        dv1.Table = Gl_DataSet.Tables("TLugar")

        Me.CmbLugar.DisplayMember = "LUGAR"
        Me.CmbLugar.ValueMember = "IDLUGAR"
        Me.CmbLugar.DataSource = dv1
        Me.CmbLugar.Text = ""
        DGActivosTI.DataSource = Nothing
        '-----------------------------------------------------

    End Sub

    Private Sub For_EquiposListar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCombos()

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

    End Sub

    Private Sub CmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipo.SelectedIndexChanged
        BtnListar.Focus()
    End Sub

    Private Sub CmbTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTipo.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        CmbTipo.Text = ""
        DGActivosTI.DataSource = Nothing
        TxtResponsable.Text = ""
        CmbLugar.Text = ""
    End Sub

    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click

        Try

            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            If Trim(CmbTipo.Text) = "" Then
                Consulta = Activos.ListarActivos()
            Else
                Consulta = Activos.ListarActivos(CmbTipo.SelectedValue)
            End If


            Tabla.Load(Consulta)
            DGActivosTI.DataSource = Tabla

            DGActivosTI.Columns("IDTIPO").Visible = False
            DGActivosTI.Columns("NOMBRE_POBLADO").HeaderText = "CIUDAD"
            DGActivosTI.Columns("FECHACOMPRA").DefaultCellStyle.Format = "yyyy-MM-dd"

            DGActivosTI.Sort(DGActivosTI.Columns("IDACTIVO"), ListSortDirection.Ascending)

            CmbLugar.Text = ""
            TxtResponsable.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, GL_ClaveEncrip - Gl_NomCompañia)
        End Try


    End Sub

    Private Sub For_EquiposListar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click


        Try

            If DGActivosTI.RowCount = 0 Then
                MsgBox("Nada para Exportar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                Exit Sub
            End If

            SDArchivo.FileName = "InventarioActivosTI"


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
            For i = 1 To DGActivosTI.ColumnCount - 1
                SL.SetCellValue(1, i, DGActivosTI.Columns(i - 1).HeaderText)
                SL.SetCellStyle(1, i, StyleCabecera)
                SL.SetCellStyle(1, i, StyleCentrado)
            Next

            '----- Datos de la Tabla -------------------------------
            For F = 0 To DGActivosTI.Rows.Count - 1
                For C = 1 To DGActivosTI.ColumnCount - 1
                    SL.SetCellValue(F + 2, C, Trim(DGActivosTI.Rows(F).Cells(C - 1).Value))
                Next
            Next

            SL.SaveAs(SDArchivo.FileName + ".xlsx")

            MsgBox("Archivo generado con Exito!", MsgBoxStyle.Information, Gl_NomCompañia)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub BtnBuscaResp_Click(sender As Object, e As EventArgs) Handles BtnBuscaResp.Click

        GL_Empleado.Nombre = ""
        GL_Empleado.Apellido = ""
        GL_Empleado.Area = ""

        GL_Empleado.Cargareldataset()
        For_EmpleadosBuscar.ShowDialog()

        Me.TxtResponsable.Text = Trim(GL_Empleado.Nombre) & " " & Trim(GL_Empleado.Apellido)

        Try

            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Activos.ListarActivosxCondicion(15, GL_Empleado.IdEmpleado)

            Tabla.Load(Consulta)
            DGActivosTI.DataSource = Tabla

            DGActivosTI.Columns("IDTIPO").Visible = False
            DGActivosTI.Columns("IDLUGAR").Visible = False
            DGActivosTI.Columns("IDAREA").Visible = False
            DGActivosTI.Columns("IDEMPLEADO").Visible = False
            DGActivosTI.Columns("NOMBRE_POBLADO").HeaderText = "CIUDAD"
            DGActivosTI.Columns("FECHACOMPRA").DefaultCellStyle.Format = "yyyy-MM-dd"

            DGActivosTI.Sort(DGActivosTI.Columns("IDACTIVO"), ListSortDirection.Ascending)


            CmbLugar.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

    End Sub

    Private Sub CmbLugar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbLugar.SelectedIndexChanged

        Try

            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Activos.ListarActivosxCondicion(14, CmbLugar.SelectedValue)

            Tabla.Load(Consulta)
            DGActivosTI.DataSource = Tabla

            DGActivosTI.Columns("IDTIPO").Visible = False
            DGActivosTI.Columns("IDLUGAR").Visible = False
            DGActivosTI.Columns("IDAREA").Visible = False
            DGActivosTI.Columns("IDEMPLEADO").Visible = False
            DGActivosTI.Columns("NOMBRE_POBLADO").HeaderText = "CIUDAD"
            DGActivosTI.Columns("FECHACOMPRA").DefaultCellStyle.Format = "yyyy-MM-dd"

            DGActivosTI.Sort(DGActivosTI.Columns("IDACTIVO"), ListSortDirection.Ascending)

            TxtResponsable.Text = ""
            DGActivosTI.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try
    End Sub

    Private Sub CmbLugar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbLugar.KeyPress
        e.Handled = True
    End Sub
End Class