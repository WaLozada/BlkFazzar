Imports System.Data.SqlClient

Public Class For_Observaciones
    Dim ProductosIngreso As New ProductoIngreso()
    Sub Listar(Bandera)

        Try
            DGObservaciones.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim TablaClientes As New DataTable
            Dim Filtro As String

            If Bandera = "Ingresos" Then
                Filtro = "E"
            Else
                Filtro = "S"
            End If

            Consulta = ProductosIngreso.ListarObservaciones(Filtro)

            TablaClientes.Load(Consulta)
            DGObservaciones.DataSource = TablaClientes
            DGObservaciones.Columns("ES").Visible = False

            Try
                If DGObservaciones.SelectedRows.Count > 0 Then
                    DGObservaciones.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

    End Sub

    Private Sub For_Observaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Listar(Me.Tag)

    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

        Dim value As DataGridViewSelectedRowCollection = Me.DGObservaciones.SelectedRows
        Dim Lista As New List(Of String)

        'Cargar la lista
        For Each loFila As DataGridViewRow In value
            Lista.Add(Trim(loFila.Cells("OBSERVACION").Value.ToString))
        Next

        Dim Redaccion As String = ""

        'Recorrer la lista
        For Each Item As String In Lista
            Redaccion += Item + String.Format(Environment.NewLine)
        Next

        If Tag = "Despachos" Then
            For_DespachoMercancia.TxtObservacion.Text = Redaccion
        Else
            For_IngresoMercancia.TxtObservacion.Text = Redaccion
        End If


        Me.Dispose()


    End Sub
End Class