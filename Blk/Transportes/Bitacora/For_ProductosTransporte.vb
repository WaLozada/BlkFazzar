Public Class For_ProductosTransporte
    Dim Productos As New Productos()
    Private Sub TxtCliente_TextChanged(sender As Object, e As EventArgs) Handles TxtProducto.TextChanged

        With DGProductos



            .DataSource = Productos.CoincideNombreProductoTransporte(TxtProducto.Text) ' Trae los resultados

            Dim FontCabecera As New Font(.ColumnHeadersDefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle.Font = FontCabecera

            Dim Font As New Font(.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .DefaultCellStyle.Font = Font

            .Columns("IDPRODUCTO").Visible = False
            .Columns("ID").Visible = False

        End With

    End Sub

    Private Sub For_ProductosTransporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Productos.CargareldatasetTransporte()

    End Sub
    Private Sub DGProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProductos.CellClick
        Try
            Gl_Producto.IdProducto = Trim(DGProductos.Rows(e.RowIndex).Cells(0).Value)
            Gl_Producto.Descripcion = Trim(DGProductos.Rows(e.RowIndex).Cells(1).Value)

            Me.Dispose()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnProducto_Click(sender As Object, e As EventArgs) Handles BtnProducto.Click


        For_ProductosTransporteCrear.ShowDialog()

        Productos.CargareldatasetTransporte()

    End Sub
End Class