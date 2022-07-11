Imports System.Data.SqlClient

Public Class For_ProyectosListado

    Sub Listar()
        Try
            DGProyectos.DataSource = Nothing

            Dim Operacion As New Operaciones()
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Operacion.Listarproyecto()

            Tabla.Load(Consulta)
            DGProyectos.DataSource = Tabla

            DGProyectos.Columns("CODCLIENTE").HeaderText = "CODIGO CLIENTE"
            DGProyectos.Columns("TP_GRANEL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGProyectos.Columns("TP_GENERAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGProyectos.Columns("ALMACENAMIENTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGProyectos.Columns("ITR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGProyectos.Columns("EMPAQUE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'DGProyectos.Columns("ID").Visible = False

            Try
                If DGProyectos.SelectedRows.Count > 0 Then
                    DGProyectos.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub
    Private Sub For_ProyectosListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Listar()

    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        For_ProyectosRegistrar.ShowDialog()
    End Sub
End Class