Imports System.ComponentModel

Public Class For_ProductosBuscar
    Dim Producto As New Productos()
    Private Sub For_ProductosBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Gl_Producto.LimpiarVariableGlobal()

        If GL_ProductoCargados = 0 Then
            Producto.Cargareldataset()
        End If

    End Sub

    Private Sub TxtProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtProducto.TextChanged

        With DGProductos



            .DataSource = Producto.CoincideNombreProducto(TxtProducto.Text) ' Trae los resultados

            Dim FontCabecera As New Font(.ColumnHeadersDefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle.Font = FontCabecera

            Dim Font As New Font(.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .DefaultCellStyle.Font = Font

            DGProductos.Columns("IDPRODUCTO").Visible = False
            DGProductos.Columns("ID").Visible = False

        End With

    End Sub
    Private Sub TxtCodigoProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigoProducto.TextChanged

        With DGProductos

            .DataSource = Producto.CoincideCodigoProducto(TxtCodigoProducto.Text) ' Trae los resultados

            Dim FontCabecera As New Font(.ColumnHeadersDefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle.Font = FontCabecera

            Dim Font As New Font(.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .DefaultCellStyle.Font = Font

            DGProductos.Columns("IDPRODUCTO").Visible = False
            DGProductos.Columns("ID").Visible = False

        End With

    End Sub

    Private Sub TxtCodigoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigoProducto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DGProductos.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub DGProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProductos.CellClick
        Try

            Gl_Producto.IdProducto = Trim(DGProductos.Rows(e.RowIndex).Cells(0).Value)
            Gl_Producto.Codigo = Trim(DGProductos.Rows(e.RowIndex).Cells(1).Value)
            Gl_Producto.Descripcion = Trim(DGProductos.Rows(e.RowIndex).Cells(2).Value)
            Gl_Producto.Familia = Trim(DGProductos.Rows(e.RowIndex).Cells(3).Value)
            Gl_Producto.Unidad = Trim(DGProductos.Rows(e.RowIndex).Cells(4).Value)
            Gl_Producto.Empaque = Trim(DGProductos.Rows(e.RowIndex).Cells(5).Value)
            Gl_Producto.Simbolo = Trim(DGProductos.Rows(e.RowIndex).Cells(7).Value)

        Catch ex As Exception
        End Try

        Me.Dispose()
    End Sub

    Private Sub For_ProductosBuscar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class