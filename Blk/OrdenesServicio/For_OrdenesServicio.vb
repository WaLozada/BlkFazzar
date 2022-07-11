Imports System.Data.SqlClient

Public Class For_OrdenesServicio

    Dim OrdenServicioMacro As New ClsOrdenesServicioMacro()

    Sub Colorear()
        For i = 0 To DGOsm.Rows.Count - 1

            Select Case Trim(DGOsm.Rows(i).Cells(7).Value)
                Case 3
                    DGOsm.Rows(i).Cells(8).Style.BackColor = Color.YellowGreen
                Case 1
                    DGOsm.Rows(i).Cells(8).Style.BackColor = Color.Orange
                Case 2
                    DGOsm.Rows(i).Cells(8).Style.BackColor = Color.Yellow
            End Select

            Try
                If DGOsm.SelectedRows.Count > 0 Then
                    DGOsm.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

        Next
    End Sub
    Sub Listar()

        Try
            DGOsm.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim TablaOrdenes As New DataTable

            Consulta = OrdenServicioMacro.ListarOSM(DTFechaDesde.Value, DTFechaHasta.Value, 1)

            TablaOrdenes.Load(Consulta)
            DGOsm.DataSource = TablaOrdenes

            DGOsm.Columns("IDSERVICIO").Visible = False
            DGOsm.Columns("CODCENTRO").Visible = False
            DGOsm.Columns("IDESTADO").Visible = False

            Try
                If DGOsm.SelectedRows.Count > 0 Then
                    DGOsm.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

        Colorear()

    End Sub
    Private Sub For_OrdenesServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------
        Listar()

    End Sub

    Private Sub For_OrdenesServicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub RBPendientes_CheckedChanged(sender As Object, e As EventArgs) Handles RBPendientes.CheckedChanged



    End Sub

    Private Sub RBTodas_CheckedChanged(sender As Object, e As EventArgs) Handles RBTodas.CheckedChanged


    End Sub

    Private Sub RBProceso_CheckedChanged(sender As Object, e As EventArgs) Handles RBProceso.CheckedChanged



    End Sub

    Private Sub RBFinalizadas_CheckedChanged(sender As Object, e As EventArgs) Handles RBFinalizadas.CheckedChanged


    End Sub

    Private Sub BtnNuevaOrden_Click(sender As Object, e As EventArgs) Handles BtnNuevaOrden.Click
        For_OrdenesServicioRegistrar.ShowDialog()

        'DGOsm.DataSource = Nothing
        Listar()

    End Sub
End Class