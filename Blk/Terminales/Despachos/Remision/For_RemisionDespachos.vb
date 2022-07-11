Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class For_RemisionDespachos

    Dim Remision As New Remisiones()
    Dim Centro As New Centros()
    Dim Bodega As New Bodegas()
    Dim RemisionVisor As New RemisionVisor()
    Sub CargarCombos()

        DTDesde.Value = Date.Now
        DTHasta.Value = Date.Now
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
    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If CmbCentros.Text = "" Then
            ListaErrores.Add("Seleccione el Centro de Distribución (CEDIS)!")
        End If

        If CmbBodegas.Text = "" Then
            ListaErrores.Add("Seleccione la Bodega!")
        End If

        If DTDesde.Value > DTHasta.Value Then
            ListaErrores.Add("La Fecha de Inicio es Mayor a la Fecha de Finalización!")
        End If

        Return ListaErrores

    End Function
    Sub Listar()
        Try
            DGRemisiones.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim TablaRemisiones As New DataTable

            Remision.Centro = CmbCentros.SelectedValue
            Remision.Bodega = CmbBodegas.SelectedValue
            Remision.Desde = DTDesde.Value
            Remision.Hasta = DTHasta.Value

            Consulta = Remision.ListarRemisiones()

            TablaRemisiones.Load(Consulta)
            DGRemisiones.DataSource = TablaRemisiones


            DGRemisiones.Columns("CONDUCTOR").Visible = False
            DGRemisiones.Columns("NOMBRE").Visible = False
            DGRemisiones.Columns("APELLIDO").Visible = False
            DGRemisiones.Columns("PLACA").Visible = False
            DGRemisiones.Columns("TIPO").Visible = False
            DGRemisiones.Columns("TRANSPORTADOR").Visible = False



            Try
                DGRemisiones.ClearSelection()
            Catch ex As Exception
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub
    Private Sub For_RemisionDespachos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        DGRemisiones.DataSource = Nothing
        RemisionVisor.LimpiarVariables()

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = Bodega.ListarBodegas(CmbCentros.SelectedValue)
        RemisionVisor.Centro = Trim(CmbCentros.Text)
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

    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click

        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Listar()

    End Sub

    Private Sub CmbBodegas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBodegas.SelectedIndexChanged

        RemisionVisor.Bodega = Trim(CmbBodegas.Text)

        Dim Consulta As SqlDataReader
        Dim DatosBodega As New DataTable

        Consulta = Bodega.DatosBodega(CmbCentros.SelectedValue, CmbBodegas.SelectedValue)
        RemisionVisor.Centro = Trim(CmbCentros.Text)
        'DatosBodega.Load(Consulta)

        If Consulta.Read() Then
            RemisionVisor.Bodegadireccion = Trim(Consulta("DIRECCION").ToString())
        End If
        Consulta.Close()

        DTDesde.Focus()
    End Sub

    Private Sub BtnVisualizar_Click(sender As Object, e As EventArgs) Handles BtnVisualizar.Click

        If RemisionVisor.Idproceso = "" Then
            MsgBox("Seleccione la Remisión que desea visualizar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = RemisionVisor.ListarRemisionVisor()

        Tabla.Load(Consulta)

        For_ReporteVisor.ReportViewer1.LocalReport.DataSources.Clear()

        Dim Centrobodega As ReportParameter = New ReportParameter("Centrobodega", RemisionVisor.Centro.ToString & " / " & RemisionVisor.Bodega.ToString)
        Dim Bodegadireccion As ReportParameter = New ReportParameter("Bodegadireccion", RemisionVisor.Bodegadireccion.ToString)
        Dim IdProceso As ReportParameter = New ReportParameter("Idproceso", RemisionVisor.Idproceso.ToString)
        Dim Cliente As ReportParameter = New ReportParameter("Cliente", RemisionVisor.Cliente.ToString)
        Dim Deposito As ReportParameter = New ReportParameter("Deposito", RemisionVisor.Deposito.ToString)
        Dim Pedido As ReportParameter = New ReportParameter("Pedido", RemisionVisor.Pedido.ToString)
        Dim Referencia As ReportParameter = New ReportParameter("Referencia", RemisionVisor.Referencia.ToString)
        Dim Observacion As ReportParameter = New ReportParameter("Observacion", RemisionVisor.Observacion.ToString)
        Dim Docconductor As ReportParameter = New ReportParameter("Docconductor", RemisionVisor.Docconductor.ToString)
        Dim Nombreconductor As ReportParameter = New ReportParameter("Nombreconductor", RemisionVisor.Nombreconductor.ToString & " " & RemisionVisor.Apellidoconductor)
        Dim Placa As ReportParameter = New ReportParameter("Placa", RemisionVisor.Placa.ToString)
        Dim Tipo As ReportParameter = New ReportParameter("Tipo", RemisionVisor.Tipo.ToString)
        Dim Fecha As ReportParameter = New ReportParameter("Fecha", RemisionVisor.Fecha.ToString)
        Dim Hora As ReportParameter = New ReportParameter("Hora", RemisionVisor.Hora.ToString)

        For_ReporteVisor.ReportViewer1.LocalReport.SetParameters(Centrobodega)
        For_ReporteVisor.ReportViewer1.LocalReport.SetParameters(Bodegadireccion)
        For_ReporteVisor.ReportViewer1.LocalReport.SetParameters(IdProceso)
        For_ReporteVisor.ReportViewer1.LocalReport.SetParameters(Cliente)
        For_ReporteVisor.ReportViewer1.LocalReport.SetParameters(Deposito)
        For_ReporteVisor.ReportViewer1.LocalReport.SetParameters(Pedido)
        For_ReporteVisor.ReportViewer1.LocalReport.SetParameters(Referencia)
        For_ReporteVisor.ReportViewer1.LocalReport.SetParameters(Observacion)
        For_ReporteVisor.ReportViewer1.LocalReport.SetParameters(Docconductor)
        For_ReporteVisor.ReportViewer1.LocalReport.SetParameters(Nombreconductor)
        For_ReporteVisor.ReportViewer1.LocalReport.SetParameters(Placa)
        For_ReporteVisor.ReportViewer1.LocalReport.SetParameters(Tipo)
        For_ReporteVisor.ReportViewer1.LocalReport.SetParameters(Fecha)
        For_ReporteVisor.ReportViewer1.LocalReport.SetParameters(Hora)


        Dim rp As ReportDataSource = New ReportDataSource("DataSet1", Tabla)
        For_ReporteVisor.ReportViewer1.LocalReport.DataSources.Add(rp)
        For_ReporteVisor.ReportViewer1.Refresh()


        For_ReporteVisor.ShowDialog()

    End Sub
    Private Sub DGRemisiones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRemisiones.CellClick

        Try

            RemisionVisor.Idproceso = Trim(DGRemisiones.Rows(e.RowIndex).Cells(0).Value)
            RemisionVisor.Cliente = Trim(DGRemisiones.Rows(e.RowIndex).Cells(1).Value)
            RemisionVisor.Deposito = Trim(DGRemisiones.Rows(e.RowIndex).Cells(2).Value)
            RemisionVisor.Pedido = Trim(DGRemisiones.Rows(e.RowIndex).Cells(3).Value)
            RemisionVisor.Referencia = Trim(DGRemisiones.Rows(e.RowIndex).Cells(4).Value)
            RemisionVisor.Observacion = Trim(DGRemisiones.Rows(e.RowIndex).Cells(8).Value)
            RemisionVisor.Docconductor = Trim(DGRemisiones.Rows(e.RowIndex).Cells(9).Value)
            RemisionVisor.Nombreconductor = Trim(DGRemisiones.Rows(e.RowIndex).Cells(10).Value)
            RemisionVisor.Apellidoconductor = Trim(DGRemisiones.Rows(e.RowIndex).Cells(11).Value)
            RemisionVisor.Placa = Trim(DGRemisiones.Rows(e.RowIndex).Cells(12).Value)
            RemisionVisor.Tipo = Trim(DGRemisiones.Rows(e.RowIndex).Cells(13).Value)
            Dim Fecha As Date = Trim(DGRemisiones.Rows(e.RowIndex).Cells(15).Value.ToString)
            RemisionVisor.Fecha = Fecha.ToString("MMMM dd, yyyy").ToUpperInvariant
            RemisionVisor.Hora = Trim(DGRemisiones.Rows(e.RowIndex).Cells(16).Value.ToString)

        Catch ex As Exception

        End Try



    End Sub


End Class