Imports System.ComponentModel

Public Class For_Divipoliticas

    Sub TxtCiudad_TextChanged(sender As Object, e As EventArgs) Handles TxtCiudad.TextChanged

        With DGCiudades

            Dim Divisiones As New Divipoliticas()

            .DataSource = Divisiones.CoincideDivipol(TxtCiudad.Text) ' Trae los resultados

            Dim FontCabecera As New Font(.ColumnHeadersDefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle.Font = FontCabecera

            Dim Font As New Font(.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .DefaultCellStyle.Font = Font

            .Columns("CODIGO_DEPTO").Visible = False
            .Columns("CODIGO_MUNICIPIO").Visible = False
            .Columns("CODIGO_POBLADO").Visible = False
            .Columns("TIPO").Visible = False
            .Columns("ID").Visible = False

            .Columns.Item("NOMBRE_DEPTO").Width = 170
            .Columns.Item("NOMBRE_MUNICIPIO").Width = 400

            .Columns("NOMBRE_DEPTO").HeaderText = "DEPARTAMENTO"
            .Columns("NOMBRE_MUNICIPIO").HeaderText = "MUNICIPIO"

        End With

    End Sub

    Private Sub For_Divipoliticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Divipoliticas As New Divipoliticas()
        Divipoliticas.CargarDivipoliticas()

    End Sub

    Private Sub For_Divipoliticas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
    Private Sub DGCiudades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCiudades.CellClick

        Try
            Gl_Divipolitica.Pais = "COLOMBIA"
            Gl_Divipolitica.CodigoDepto = Trim(DGCiudades.Rows(e.RowIndex).Cells(0).Value)
            Gl_Divipolitica.NombreDepto = Trim(DGCiudades.Rows(e.RowIndex).Cells(1).Value)
            Gl_Divipolitica.CodigoMunicipio = Trim(DGCiudades.Rows(e.RowIndex).Cells(2).Value)
            Gl_Divipolitica.NombreMunicipio = Trim(DGCiudades.Rows(e.RowIndex).Cells(3).Value)
            Gl_Divipolitica.CodigoPoblado = Trim(DGCiudades.Rows(e.RowIndex).Cells(4).Value)
            Gl_Divipolitica.NombrePoblado = Trim(DGCiudades.Rows(e.RowIndex).Cells(5).Value)
            Gl_Divipolitica.Tipo = Trim(DGCiudades.Rows(e.RowIndex).Cells(6).Value)
        Catch ex As Exception

        End Try


        Me.Dispose()

    End Sub

End Class