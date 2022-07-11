Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight

Public Class For_ConsultasLotes
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
    End Sub


    Private Sub For_ConsultasLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        CargarCombos()
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

    Private Sub CmbCentros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCentros.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbBodegas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBodegas.SelectedIndexChanged
        ' --- Si Cambia de Bodega toc limpiar los datos del Cliente para seleccionar uno nuevo por cuestion del Deposito
        Me.TxtCodCliente.Text = ""
        Me.LblNombreCliente.Text = ""
        Me.TxtDeposito.Text = ""
        Gl_Cliente.LimpiarVariableGlobal()

        BtnBuscar.Focus()
    End Sub

    Private Sub CmbBodegas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbBodegas.KeyPress
        e.Handled = True
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

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        Try

            Dim DGridExportar As DataGridView

            DGridExportar = DGLotes


            If DGridExportar.RowCount = 0 Then
                MsgBox("Nada para Exportar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                Exit Sub
            End If

            SDArchivo.FileName = "InformexLotes"


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
            SL.SetCellValue("A2", Trim(LblNombreCliente.Text))
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
                    SL.SetCellValue(F + 4, C, Trim(DGridExportar.Rows(F).Cells(C - 1).Value.ToString))
                Next

            Next

            'If DGridExportar.Columns(0).HeaderText = "IDPROCESO" Then
            '    SL.SetCellStyle(4, 7, DGridExportar.Rows.Count + 3, 14, StyleCentrado) 'Centrar Valores
            '    SL.SetCellStyle(4, 11, DGridExportar.Rows.Count + 3, 12, StyleVerde) 'Colorear Verde 
            '    SL.SetCellStyle(4, 13, DGridExportar.Rows.Count + 3, 14, StyleRosado) 'Colorear Rosado
            'Else
            '    SL.SetCellStyle(4, 3, DGridExportar.Rows.Count + 3, 11, StyleCentrado) 'Centrar Valores
            '    SL.SetCellStyle(4, 3, DGridExportar.Rows.Count + 3, 3, StyleVerde) 'Colorear Verde 
            '    SL.SetCellStyle(4, 5, DGridExportar.Rows.Count + 3, 5, StyleVerde) 'Colorear Verde 
            '    SL.SetCellStyle(4, 6, DGridExportar.Rows.Count + 3, 7, StyleRosado) 'Colorear Rosado

            'End If


            SL.SaveAs(SDArchivo.FileName + ".xlsx")

            MsgBox("Archivo generado con Exito!", MsgBoxStyle.Information, Gl_NomCompañia)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click

        Dim FechaCorte As String

        FechaCorte = DTFechaCorte.Value

        DGLotes.DataSource = Nothing

        If FechaCorte > Date.Now Then
            MsgBox("Fecha de Corte es mayor a la fecha Actual.", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        LblTotal.Text = ""
        LblBultos.Text = ""

        Try

            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Dim Accion As Integer

            If Trim(TxtLote.Text) = "" Then
                Accion = 1 ' Listar todos, No especificar un lote
            Else
                Accion = 2 ' Listar solo el lote indicado
            End If

            Dim Lote As String = Trim(TxtLote.Text)


            Consulta = Reportes.ListarLotes(Trim(TxtDeposito.Text), DTFechaCorte.Value, Accion, Lote)

            Tabla.Load(Consulta)
            DGLotes.DataSource = Tabla

            DGLotes.Columns("IDPRESENTACION").Visible = False
            DGLotes.Columns("FECHA").DefaultCellStyle.Format = "yyyy-MM-dd"

            Dim Total As Decimal = 0
            Dim Bultos As Integer = 0

            For I = 0 To DGLotes.Rows.Count - 1
                Total += CType((DGLotes.Rows(I).Cells("CANTIDAD").Value), Decimal)
                Bultos += Val(DGLotes.Rows(I).Cells("BULTOS").Value)
            Next
            LblTotal.Text = Total
            LblBultos.Text = Bultos

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

    End Sub

    Private Sub For_ConsultasLotes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub DGLotes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGLotes.CellClick


        Dim RTA = MsgBox("Desea Copiar el Lote de este Registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Gl_NomCompañia)

        Try
            If RTA = vbYes Then
                My.Computer.Clipboard.SetText(Trim(DGLotes.Rows(e.RowIndex).Cells("LOTE").Value), System.Windows.Forms.TextDataFormat.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try



    End Sub
End Class