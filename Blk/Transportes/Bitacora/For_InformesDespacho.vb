Imports System.Data.SqlClient

Public Class For_InformesDespacho
    Dim Despachos As New ClsTransporte()
    Private Sub For_InformesDespacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CmbAño.Text = Date.Now.Year
        CmbYear.Text = Date.Now.Year


        CmbMes.Text = MonthName(Date.Now.Month)
        CmbMes.Tag = Date.Now.Month


        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        'Me.PanelPrincipal.Left = (Me.Width / 2) - (Me.PanelPrincipal.Width / 2)

    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click

        If CmbAño.Text = "" Then
            MsgBox("Seleccione el Año que desea Consultar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbAño.Focus()
            Exit Sub
        End If

        Dim Desde, Hasta As String

        Desde = CmbAño.Text & "-01-01"
        Hasta = CmbAño.Text & "-12-31"

        '---- Consulta Costos,Ingresos,Utilidad, Margen 
        DGInforme1.DataSource = Nothing

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Try
            Consulta = Despachos.ConsultaHistorico(1, Desde, Hasta)
            Tabla.Load(Consulta)

            DGInforme1.DataSource = Tabla
            DGInforme1.Columns("COSTO").DefaultCellStyle.Format = "C0"
            DGInforme1.Columns("INGRESOS").DefaultCellStyle.Format = "C0"
            DGInforme1.Columns("UTILIDAD").DefaultCellStyle.Format = "C0"

            DGInforme1.Columns("COSTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme1.Columns("INGRESOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme1.Columns("UTILIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme1.Columns("MARGEN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGInforme1.Columns("FECHA").Visible = False

        Catch ex As Exception

        End Try


        DGInforme11.DataSource = Nothing

        Dim Consulta11 As SqlDataReader
        Dim Tabla11 As New DataTable

        Try
            Consulta11 = Despachos.ConsultaHistorico(11, Desde, Hasta)
            Tabla11.Load(Consulta11)

            DGInforme11.DataSource = Tabla11
            DGInforme11.Columns("COSTO").DefaultCellStyle.Format = "C0"
            DGInforme11.Columns("INGRESOS").DefaultCellStyle.Format = "C0"
            DGInforme11.Columns("UTILIDAD").DefaultCellStyle.Format = "C0"

            DGInforme11.Columns("COSTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme11.Columns("INGRESOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme11.Columns("UTILIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme11.Columns("MARGEN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Catch ex As Exception

        End Try


        ' -- Consulta Cantidad Despachos/Mes

        DGInforme2.DataSource = Nothing

        Dim Consulta2 As SqlDataReader
        Dim Tabla2 As New DataTable

        Try
            Consulta2 = Despachos.ConsultaHistorico(2, Desde, Hasta)
            Tabla2.Load(Consulta2)

            DGInforme2.DataSource = Tabla2

            DGInforme2.Columns("DESPACHOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGInforme2.Columns("FECHA").Visible = False

        Catch ex As Exception

        End Try


        ' -- Total Cantidad Despachos/Mes

        DGInforme21.DataSource = Nothing

        Dim Consulta21 As SqlDataReader
        Dim Tabla21 As New DataTable

        Try
            Consulta21 = Despachos.ConsultaHistorico(21, Desde, Hasta)
            Tabla21.Load(Consulta21)

            DGInforme21.DataSource = Tabla21

            DGInforme21.Columns("DESPACHOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        Catch ex As Exception

        End Try


        ' -- Consulta Cantidad Toneladas/Mes

        DGInforme3.DataSource = Nothing

        Dim Consulta3 As SqlDataReader
        Dim Tabla3 As New DataTable

        Try
            Consulta3 = Despachos.ConsultaHistorico(3, Desde, Hasta)
            Tabla3.Load(Consulta3)

            DGInforme3.DataSource = Tabla3

            DGInforme3.Columns("TONELADAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGInforme3.Columns("FECHA").Visible = False

        Catch ex As Exception

        End Try



        ' -- Consulta Cantidad Toneladas

        DGInforme31.DataSource = Nothing

        Dim Consulta31 As SqlDataReader
        Dim Tabla31 As New DataTable

        Try
            Consulta31 = Despachos.ConsultaHistorico(31, Desde, Hasta)
            Tabla31.Load(Consulta31)

            DGInforme31.DataSource = Tabla31

            DGInforme31.Columns("TONELADAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        Catch ex As Exception

        End Try


        ' -- Consulta Zona,Costos,Ingresos,Utilidad, Margen

        DGInforme4.DataSource = Nothing

        Dim Consulta4 As SqlDataReader
        Dim Tabla4 As New DataTable

        Try
            Consulta4 = Despachos.ConsultaHistorico(4, Desde, Hasta)
            Tabla4.Load(Consulta4)

            DGInforme4.DataSource = Tabla4
            DGInforme4.Columns("COSTO").DefaultCellStyle.Format = "C0"
            DGInforme4.Columns("INGRESOS").DefaultCellStyle.Format = "C0"
            DGInforme4.Columns("UTILIDAD").DefaultCellStyle.Format = "C0"

            DGInforme4.Columns("COSTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme4.Columns("INGRESOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme4.Columns("UTILIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGInforme4.Columns("MARGEN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGInforme4.Columns("FECHA").Visible = False

        Catch ex As Exception

        End Try

    End Sub

    Private Sub For_InformesDespacho_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub BtnConsultaMes_Click(sender As Object, e As EventArgs) Handles BtnConsultaMes.Click

        If CmbYear.Text = "" Then
            MsgBox("Seleccione el Año que desea Consultar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbYear.Focus()
            Exit Sub
        End If

        If CmbMes.Text = "" Then
            MsgBox("Seleccione el mes que desea Consultar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbMes.Focus()
            Exit Sub
        End If

        Dim Desde, Hasta As String

        Desde = CmbYear.Text & "-" & Format(CmbMes.Tag, "00") & "-01"
        Hasta = CmbYear.Text & "-" & Format(CmbMes.Tag, "00") & "-" & System.DateTime.DaysInMonth(CmbYear.Text, CmbMes.Tag)

        '---- Consulta Costos,Ingresos,Utilidad, Margen 

        DGCostos.DataSource = Nothing

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Try
            Consulta = Despachos.ConsultaHistorico(1, Desde, Hasta)
            Tabla.Load(Consulta)

            DGCostos.DataSource = Tabla
            DGCostos.Columns("COSTO").DefaultCellStyle.Format = "C0"
            DGCostos.Columns("INGRESOS").DefaultCellStyle.Format = "C0"
            DGCostos.Columns("UTILIDAD").DefaultCellStyle.Format = "C0"

            DGCostos.Columns("COSTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGCostos.Columns("INGRESOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGCostos.Columns("UTILIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGCostos.Columns("MARGEN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGCostos.Columns("FECHA").Visible = False

        Catch ex As Exception

        End Try

        ' -- Consulta Cantidad Despachos/Mes

        DGDespachos.DataSource = Nothing

        Dim Consulta2 As SqlDataReader
        Dim Tabla2 As New DataTable

        Try
            Consulta2 = Despachos.ConsultaHistorico(2, Desde, Hasta)
            Tabla2.Load(Consulta2)

            DGDespachos.DataSource = Tabla2

            DGDespachos.Columns("DESPACHOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGDespachos.Columns("FECHA").Visible = False

        Catch ex As Exception

        End Try


        ' -- Consulta Cantidad Toneladas/Mes

        DGToneladas.DataSource = Nothing

        Dim Consulta3 As SqlDataReader
        Dim Tabla3 As New DataTable

        Try
            Consulta3 = Despachos.ConsultaHistorico(3, Desde, Hasta)
            Tabla3.Load(Consulta3)

            DGToneladas.DataSource = Tabla3

            DGToneladas.Columns("TONELADAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGToneladas.Columns("FECHA").Visible = False

        Catch ex As Exception

        End Try


        ' -- Consulta Zona,Costos,Ingresos,Utilidad, Margen

        DGTerminales.DataSource = Nothing

        Dim Consulta4 As SqlDataReader
        Dim Tabla4 As New DataTable

        Try
            Consulta4 = Despachos.ConsultaHistorico(4, Desde, Hasta)
            Tabla4.Load(Consulta4)

            DGTerminales.DataSource = Tabla4
            DGTerminales.Columns("COSTO").DefaultCellStyle.Format = "C0"
            DGTerminales.Columns("INGRESOS").DefaultCellStyle.Format = "C0"
            DGTerminales.Columns("UTILIDAD").DefaultCellStyle.Format = "C0"

            DGTerminales.Columns("COSTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGTerminales.Columns("INGRESOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGTerminales.Columns("UTILIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGTerminales.Columns("MARGEN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGTerminales.Columns("FECHA").Visible = False

        Catch ex As Exception

        End Try

        ' -- Consulta Cliente,Costos,Ingresos,Utilidad, Margen

        DGClientes.DataSource = Nothing

        Dim Consulta5 As SqlDataReader
        Dim Tabla5 As New DataTable

        Try
            Consulta5 = Despachos.ConsultaHistorico(5, Desde, Hasta)
            Tabla5.Load(Consulta5)

            DGClientes.DataSource = Tabla5
            DGClientes.Columns("COSTO").Width = 150
            DGClientes.Columns("COSTO").DefaultCellStyle.Format = "C0"
            DGClientes.Columns("INGRESOS").DefaultCellStyle.Format = "C0"
            DGClientes.Columns("UTILIDAD").DefaultCellStyle.Format = "C0"

            DGClientes.Columns("COSTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGClientes.Columns("INGRESOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGClientes.Columns("UTILIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGClientes.Columns("MARGEN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGClientes.Columns("DESPACHOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGClientes.Columns("FECHA").Visible = False

        Catch ex As Exception

        End Try


        ' -- Consulta Despachos Dia

        DGDespachosdia.DataSource = Nothing

        Dim Consulta6 As SqlDataReader
        Dim Tabla6 As New DataTable

        Try
            Consulta6 = Despachos.ConsultaHistorico(6, Desde, Hasta)
            Tabla6.Load(Consulta6)

            DGDespachosdia.DataSource = Tabla6

            DGDespachosdia.Columns("DESPACHOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        Catch ex As Exception

        End Try

    End Sub

    Private Sub CmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMes.SelectedIndexChanged

        CmbMes.Tag = NumeroMes(CmbMes.Text)
        BtnConsultaMes.Focus()

    End Sub

    Private Sub CmbMes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbMes.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbYear.SelectedIndexChanged
        CmbMes.Focus()
    End Sub

    Private Sub CmbYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbYear.KeyPress
        e.Handled = True
    End Sub
End Class