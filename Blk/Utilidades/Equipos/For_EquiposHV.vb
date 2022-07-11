Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class For_EquiposHV
    Dim Activos As New ActivosTI()
    Dim Idtipo As String
    Dim VProcesador As String = ""
    Dim VDisco As String = ""
    Dim VCapacidad As String = ""
    Dim VMemoria As String = ""

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


        '--------- Listar los datos del Activo seleccionado en un DG tempotal ----------------------
        Try
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Activos.ListarEquipo(Campo, Valor)

            Tabla.Load(Consulta)
            DGResultado.DataSource = Tabla

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

        Try
            If DGResultado.SelectedRows.Count > 0 Then
                DGResultado.CurrentRow.Selected = False
            End If

        Catch ex As Exception
        End Try
        '-----------------------------------------------------------------------------------
    End Sub

    Private Sub CmbElemento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbElemento.SelectedIndexChanged
        TxtNumero.Focus()
    End Sub

    Private Sub CmbElemento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbElemento.KeyPress
        e.Handled = True
    End Sub

    Private Sub For_EquiposHV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

    End Sub

    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click

        '--------- Listar los datos del Activo seleccionado en un DG tempotal ----------------------
        Try
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Activos.ListarComputadores

            Tabla.Load(Consulta)
            DGResultado.DataSource = Tabla

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

        Try
            If DGResultado.SelectedRows.Count > 0 Then
                DGResultado.CurrentRow.Selected = False
            End If

        Catch ex As Exception
        End Try
        '-----------------------------------------------------------------------------------


    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnVisualizar.Click

        If Activos.IdActivo = "" Then
            MsgBox("Seleccione el equipo del cual desea consultar la Hoja de Vida", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If


        If Idtipo <> "001" And Idtipo <> "002" And Idtipo <> "016" Then
            MsgBox("La consulta de Hoja de Vida solo esta disponible para Equipos de Computo!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            Exit Sub
        End If


        Try

            For_EquiposVisor.ReportViewer1.LocalReport.DataSources.Clear()

            Dim Proveedor As ReportParameter = New ReportParameter("Proveedor", Activos.Proveedor.ToString)
            Dim Factura As ReportParameter = New ReportParameter("Factura", Activos.NumFactura.ToString)
            Dim FechaCompra As ReportParameter = New ReportParameter("FechaCompra", Activos.FechaFactura.ToString)
            Dim TipoEquipo As ReportParameter = New ReportParameter("TipoEquipo", Activos.Tipo.ToString)
            Dim IdActivo As ReportParameter = New ReportParameter("IdActivo", Activos.IdActivo.ToString)
            Dim Marca As ReportParameter = New ReportParameter("Marca", Activos.Marca.ToString)
            Dim Modelo As ReportParameter = New ReportParameter("Modelo", Activos.Modelo.ToString)
            Dim Serial As ReportParameter = New ReportParameter("Serial", Activos.Serial.ToString)
            Dim Procesador As ReportParameter = New ReportParameter("Procesador", VProcesador.ToString)
            Dim Disco As ReportParameter = New ReportParameter("Disco", VDisco.ToString)
            Dim Capacidad As ReportParameter = New ReportParameter("Capacidad", VCapacidad.ToString)
            Dim Memoria As ReportParameter = New ReportParameter("Memoria", VMemoria.ToString)

            With For_EquiposVisor
                .ReportViewer1.LocalReport.SetParameters(Proveedor)
                .ReportViewer1.LocalReport.SetParameters(Factura)
                .ReportViewer1.LocalReport.SetParameters(FechaCompra)
                .ReportViewer1.LocalReport.SetParameters(TipoEquipo)
                .ReportViewer1.LocalReport.SetParameters(IdActivo)
                .ReportViewer1.LocalReport.SetParameters(Marca)
                .ReportViewer1.LocalReport.SetParameters(Modelo)
                .ReportViewer1.LocalReport.SetParameters(Serial)
                .ReportViewer1.LocalReport.SetParameters(Procesador)
                .ReportViewer1.LocalReport.SetParameters(Disco)
                .ReportViewer1.LocalReport.SetParameters(Capacidad)
                .ReportViewer1.LocalReport.SetParameters(Memoria)

                '------- Consultar Software del Equipo ---------------

                Try
                    Dim Consulta As SqlDataReader
                    Dim Tabla As New DataTable

                    Consulta = Activos.ListarCaracteristicas(Activos.IdActivo, "13", Idtipo) ' Con 12 Traer Caracteristicas, con 13 el Software

                    Tabla.Load(Consulta)
                    'DGCaracteristicas.DataSource = Tabla

                    Dim rp As ReportDataSource = New ReportDataSource("DataSet1", Tabla)
                    .ReportViewer1.LocalReport.DataSources.Add(rp)
                    .ReportViewer1.Refresh()

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
                End Try

                '------------------------------------------------------------

                '------- Listar los Mantenimientos que se han realizado al activo  -------
                Try
                    Dim Consulta1 As SqlDataReader
                    Dim Tabla1 As New DataTable

                    Consulta1 = Activos.ListarMantenimientos(Activos.IdActivo)

                    Tabla1.Load(Consulta1)

                    Dim rp1 As ReportDataSource = New ReportDataSource("DataSet2", Tabla1)
                    .ReportViewer1.LocalReport.DataSources.Add(rp1)
                    .ReportViewer1.Refresh()

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
                End Try
                '------------------------------------------------------------------------------


            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End Try

        For_EquiposVisor.ShowDialog()
    End Sub
    Private Sub DGResultado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGResultado.CellClick

        Try
            Activos.Proveedor = Trim(DGResultado.Rows(e.RowIndex).Cells("NOMBRE").Value)
            Activos.NumFactura = Trim(DGResultado.Rows(e.RowIndex).Cells("FACTURA").Value)
            Activos.FechaFactura = Trim(DGResultado.Rows(e.RowIndex).Cells("FECHACOMPRA").Value)
            Activos.Tipo = Trim(DGResultado.Rows(e.RowIndex).Cells("TIPO").Value)
            Activos.IdActivo = Trim(DGResultado.Rows(e.RowIndex).Cells("IDACTIVO").Value)
            Activos.Marca = Trim(DGResultado.Rows(e.RowIndex).Cells("MARCA").Value)
            Activos.Modelo = Trim(DGResultado.Rows(e.RowIndex).Cells("MODELO").Value)
            Activos.Serial = Trim(DGResultado.Rows(e.RowIndex).Cells("SERIAL").Value)
            Idtipo = DGResultado.Rows(e.RowIndex).Cells("IDTIPO").Value
            '------- Consultar Caracteristicas del Equipo ---------------

            Try
                Dim Consulta As SqlDataReader
                Dim Tabla As New DataTable

                Consulta = Activos.ListarCaracteristicas(Activos.IdActivo, "12", Idtipo) ' Con 12 Traer Caracteristicas, con 13 el Software

                Tabla.Load(Consulta)
                DGCaracteristicas.DataSource = Tabla

                For I = 0 To DGCaracteristicas.Rows.Count - 1
                    Select Case DGCaracteristicas.Rows(I).Cells("IDGRUPO").Value
                        Case "01"
                            VProcesador = Trim(DGCaracteristicas.Rows(I).Cells("CARACTERISTICA").Value)
                        Case "02"
                            VMemoria = Trim(DGCaracteristicas.Rows(I).Cells("CARACTERISTICA").Value)
                        Case "03"
                            VDisco = Trim(DGCaracteristicas.Rows(I).Cells("CARACTERISTICA").Value)
                        Case "04"
                            VCapacidad = Trim(DGCaracteristicas.Rows(I).Cells("CARACTERISTICA").Value)
                    End Select
                Next

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            End Try

            '------------------------------------------------------------


        Catch ex As Exception

        End Try

    End Sub

    Private Sub For_EquiposHV_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class