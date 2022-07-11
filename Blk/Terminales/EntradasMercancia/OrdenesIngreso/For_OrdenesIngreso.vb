Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class For_OrdenesIngreso
    Dim Centro As New Centros()
    Dim Bodega As New Bodegas()
    Dim Orden As New Ordenes()
    Dim Ordenvisor As New OrdenVisor()

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
            DGOrdenes.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim TablaRemisiones As New DataTable

            Orden.Centro = CmbCentros.SelectedValue
            Orden.Bodega = CmbBodegas.SelectedValue
            Orden.Desde = DTDesde.Value
            Orden.Hasta = DTHasta.Value

            Consulta = Orden.ListarOrdenes()

            TablaRemisiones.Load(Consulta)
            DGOrdenes.DataSource = TablaRemisiones

            Try
                DGOrdenes.ClearSelection()
            Catch ex As Exception
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub
    Private Sub For_OrdenesIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        DGOrdenes.DataSource = Nothing
        OrdenVisor.LimpiarVariables()

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = Bodega.ListarBodegas(CmbCentros.SelectedValue)
        ordenVisor.Centro = Trim(CmbCentros.Text)
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

        OrdenVisor.Bodega = Trim(CmbBodegas.Text)

        Dim Consulta As SqlDataReader
        Dim DatosBodega As New DataTable

        Consulta = Bodega.DatosBodega(CmbCentros.SelectedValue, CmbBodegas.SelectedValue)
        OrdenVisor.Centro = Trim(CmbCentros.Text)


        If Consulta.Read() Then
            OrdenVisor.Bodegadireccion = Trim(Consulta("DIRECCION").ToString())
        End If
        Consulta.Close()

        DTDesde.Focus()
    End Sub

    Private Sub BtnVisualizar_Click(sender As Object, e As EventArgs) Handles BtnVisualizar.Click

        If OrdenVisor.Idproceso = "" Then
            MsgBox("Seleccione la Orden de Ingreso que desea visualizar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = Ordenvisor.ListarOrdenVisor()

        Tabla.Load(Consulta)

        Try

            For_OrdenVisor.ReportViewer1.LocalReport.DataSources.Clear()

            Dim Centrobodega As ReportParameter = New ReportParameter("Centrobodega", OrdenVisor.Centro.ToString & " / " & OrdenVisor.Bodega.ToString)
            Dim Bodegadireccion As ReportParameter = New ReportParameter("Bodegadireccion", OrdenVisor.Bodegadireccion.ToString)
            Dim IdProceso As ReportParameter = New ReportParameter("Idproceso", OrdenVisor.Idproceso.ToString)
            Dim Cliente As ReportParameter = New ReportParameter("Cliente", OrdenVisor.Cliente.ToString)
            Dim Deposito As ReportParameter = New ReportParameter("Deposito", Ordenvisor.Deposito.ToString)
            Dim Observacion As ReportParameter = New ReportParameter("Observacion", OrdenVisor.Observacion.ToString)
            Dim Docconductor As ReportParameter = New ReportParameter("Docconductor", OrdenVisor.Docconductor.ToString)
            Dim Nombreconductor As ReportParameter = New ReportParameter("Nombreconductor", OrdenVisor.Nombreconductor.ToString & " " & OrdenVisor.Apellidoconductor)
            Dim Placa As ReportParameter = New ReportParameter("Placa", OrdenVisor.Placa.ToString)
            Dim Tipo As ReportParameter = New ReportParameter("Tipo", Ordenvisor.Tipo.ToString)
            Dim Transportador As ReportParameter = New ReportParameter("Transportador", Ordenvisor.Transportador.ToString)
            Dim Fecha As ReportParameter = New ReportParameter("Fecha", OrdenVisor.Fecha.ToString)
            Dim Hora As ReportParameter = New ReportParameter("Hora", OrdenVisor.Hora.ToString)

            For_OrdenVisor.ReportViewer1.LocalReport.SetParameters(Centrobodega)
            For_OrdenVisor.ReportViewer1.LocalReport.SetParameters(Bodegadireccion)
            For_OrdenVisor.ReportViewer1.LocalReport.SetParameters(IdProceso)
            For_OrdenVisor.ReportViewer1.LocalReport.SetParameters(Cliente)
            For_OrdenVisor.ReportViewer1.LocalReport.SetParameters(Deposito)
            For_OrdenVisor.ReportViewer1.LocalReport.SetParameters(Observacion)
            For_OrdenVisor.ReportViewer1.LocalReport.SetParameters(Docconductor)
            For_OrdenVisor.ReportViewer1.LocalReport.SetParameters(Nombreconductor)
            For_OrdenVisor.ReportViewer1.LocalReport.SetParameters(Placa)
            For_OrdenVisor.ReportViewer1.LocalReport.SetParameters(Tipo)
            For_OrdenVisor.ReportViewer1.LocalReport.SetParameters(Transportador)
            For_OrdenVisor.ReportViewer1.LocalReport.SetParameters(Fecha)
            For_OrdenVisor.ReportViewer1.LocalReport.SetParameters(Hora)


            Dim rp As ReportDataSource = New ReportDataSource("DataSet2", Tabla)
            For_OrdenVisor.ReportViewer1.LocalReport.DataSources.Add(rp)
            For_OrdenVisor.ReportViewer1.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End Try

        For_OrdenVisor.ShowDialog()

    End Sub

    Private Sub DGOrdenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOrdenes.CellClick

        Try

            Ordenvisor.Idproceso = Trim(DGOrdenes.Rows(e.RowIndex).Cells(0).Value)
            Ordenvisor.Cliente = Trim(DGOrdenes.Rows(e.RowIndex).Cells(1).Value)
            Ordenvisor.Deposito = Trim(DGOrdenes.Rows(e.RowIndex).Cells(2).Value)
            Ordenvisor.Observacion = Trim(DGOrdenes.Rows(e.RowIndex).Cells(6).Value)
            Ordenvisor.Docconductor = Trim(DGOrdenes.Rows(e.RowIndex).Cells(7).Value)
            Ordenvisor.Nombreconductor = Trim(DGOrdenes.Rows(e.RowIndex).Cells(8).Value)
            Ordenvisor.Apellidoconductor = Trim(DGOrdenes.Rows(e.RowIndex).Cells(9).Value)
            Ordenvisor.Placa = Trim(DGOrdenes.Rows(e.RowIndex).Cells(10).Value)
            Ordenvisor.Tipo = Trim(DGOrdenes.Rows(e.RowIndex).Cells(11).Value)
            Ordenvisor.Transportador = Trim(DGOrdenes.Rows(e.RowIndex).Cells(12).Value)
            Dim Fecha As Date = Trim(DGOrdenes.Rows(e.RowIndex).Cells(13).Value.ToString)
            Ordenvisor.Fecha = Fecha.ToString("MMMM dd, yyyy").ToUpperInvariant
            Ordenvisor.Hora = Trim(DGOrdenes.Rows(e.RowIndex).Cells(14).Value.ToString)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CmbBodegas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbBodegas.KeyPress
        e.Handled = True
    End Sub
End Class