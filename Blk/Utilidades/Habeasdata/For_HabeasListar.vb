Imports System.Data.SqlClient

Public Class For_HabeasListar
    Dim Habeasdata As New Cls_Habeasdata()
    Sub Listar()
        Try
            DGSolicitudes.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim TablaSolicitudes As New DataTable

            Consulta = Habeasdata.ListarSolicitudes()

            TablaSolicitudes.Load(Consulta)
            DGSolicitudes.DataSource = TablaSolicitudes

            DGSolicitudes.Columns("IDCASO").Width = 60
            DGSolicitudes.Columns("NOM_SOLICITANTE").HeaderText = "NOMBRE SOLICITANTE"
            DGSolicitudes.Columns("NOM_SOLICITANTE").Width = 250
            DGSolicitudes.Columns("APEL_SOLICITANTE").HeaderText = "APELLIDOS SOLICITANTE"
            DGSolicitudes.Columns("APEL_SOLICITANTE").Width = 250
            DGSolicitudes.Columns("FECHA_SOLICITUD").HeaderText = "FECHA SOLICITUD"
            DGSolicitudes.Columns("FECHA_SOLICITUD").Width = 150
            DGSolicitudes.Columns("FECHA_RESPUESTA").HeaderText = "FECHA RESPUESTA"
            DGSolicitudes.Columns("FECHA_RESPUESTA").Width = 150
            'DGSolicitudes.Columns("ID").Visible = False

            Try
                If DGSolicitudes.SelectedRows.Count > 0 Then
                    DGSolicitudes.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub
    Private Sub For_HabeasListar_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Listar()


    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        For_HabeasCrear.ShowDialog()
        Listar()
    End Sub

    Private Sub DGSolicitudes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSolicitudes.CellClick

        Try
            Habeasdata.Idcaso = Trim(DGSolicitudes.Rows(e.RowIndex).Cells(0).Value)
            Habeasdata.Nom_Solicitante = Trim(DGSolicitudes.Rows(e.RowIndex).Cells(3).Value)
            Habeasdata.Apel_Solicitante = Trim(DGSolicitudes.Rows(e.RowIndex).Cells(4).Value)
            Habeasdata.Solicitud = Trim(DGSolicitudes.Rows(e.RowIndex).Cells(7).Value)
            Habeasdata.Respuesta = Trim(DGSolicitudes.Rows(e.RowIndex).Cells(9).Value)

            MsgBox("CASO: " + Habeasdata.Idcaso + Chr(13) + Chr(13) + "SOLICITUD: " + Chr(13) + Chr(13) + Habeasdata.Solicitud + Chr(13) + Chr(13) + "RESPUESTA : " + Chr(13) + Chr(13) + Habeasdata.Respuesta, MsgBoxStyle.Information, Gl_NomCompañia)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnResponder_Click(sender As Object, e As EventArgs) Handles BtnResponder.Click

        If Habeasdata.Idcaso = "" Then
            MsgBox("Seleccione el caso del cual desea dar respuesta!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        If Habeasdata.Respuesta <> "" Then
            MsgBox("Este caso ya cuenta con una respuesta al titular de la Información.", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        For_HabeasRespuesta.LblIdcaso.Text = Habeasdata.Idcaso
        For_HabeasRespuesta.LblNombre.Text = Trim(Habeasdata.Nom_Solicitante) + " " + Trim(Habeasdata.Apel_Solicitante)

        For_HabeasRespuesta.ShowDialog()
        Listar()


    End Sub
End Class