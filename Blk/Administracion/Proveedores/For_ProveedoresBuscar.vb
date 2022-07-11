Public Class For_ProveedoresBuscar
    Private Sub For_ProveedoresBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GL_Proveedor.LimpiarVariableGlobal() ' Limpio la Variable Global de Cliente

        TxtProveedor_TextChanged("", e)

    End Sub
    Private Sub TxtProveedor_TextChanged(sender As Object, e As EventArgs) Handles TxtProveedor.TextChanged

        With DGProveedor

            Dim Proveedor As New Proveedores()

            .DataSource = Proveedor.CoincideProveedor(TxtProveedor.Text) ' Trae los resultados

            Dim FontCabecera As New Font(.ColumnHeadersDefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle.Font = FontCabecera

            Dim Font As New Font(.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .DefaultCellStyle.Font = Font

            .Columns("IDPROVEEDOR").Visible = False
            .Columns("USUARIOAPP").Visible = False
            .Columns("FECHAHORA").Visible = False
            .Columns("ESTADO").Visible = False
            .Columns("ID").Visible = False

        End With

    End Sub
    Private Sub DGProveedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProveedor.CellClick

        Try
            GL_Proveedor.IdProveedor = Trim(DGProveedor.Rows(e.RowIndex).Cells(0).Value)
            GL_Proveedor.Codigo = Trim(DGProveedor.Rows(e.RowIndex).Cells(1).Value)
            Gl_Proveedor.Nombre = Trim(DGProveedor.Rows(e.RowIndex).Cells(2).Value)
            Gl_Proveedor.Estado = Trim(DGProveedor.Rows(e.RowIndex).Cells(3).Value)

        Catch ex As Exception
        End Try

        Me.Dispose()

    End Sub
    Private Sub For_ProveedoresBuscar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub BtnProveedor_Click(sender As Object, e As EventArgs) Handles BtnProveedor.Click
        For_Proveedores.ShowDialog()
    End Sub
End Class