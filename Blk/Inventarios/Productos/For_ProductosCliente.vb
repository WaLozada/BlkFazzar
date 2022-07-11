Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class For_ProductosCliente
    Dim Producto As New Productos()
    Dim Cliente As New Clientes()

    Sub ListarProductosCliente()
        Try
            DGProductos.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Cliente.Codigo = TxtCodCliente.Text

            Consulta = Producto.ListarProductos(Cliente.Codigo)

            Tabla.Load(Consulta)
            DGProductos.DataSource = Tabla
            DGProductos.Columns("IDPRODUCTO").Visible = False
            DGProductos.Columns("ID").Visible = False
            Consulta.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub
    Private Sub For_ProductosCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
    Private Sub DGProductos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGProductos.CellFormatting
        e.CellStyle.SelectionBackColor = e.CellStyle.BackColor
        e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor
    End Sub
    Private Sub BtnAsignar_Click(sender As Object, e As EventArgs) Handles BtnAsignar.Click

        If Cliente.Codigo = "" Then
            MsgBox("Seleccione el Cliente al cual Asignara el producto!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            BtnBuscar.Focus()
            Exit Sub
        End If

        For i = 0 To DGProductos.Rows.Count - 1
            If Trim(TxtCodigo.Text) = Trim(DGProductos.Rows(i).Cells(1).Value) Then
                MsgBox("Este producto ya se encuentra asignado al cliente seleccionado!", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            End If
        Next

        Dim Respuesta = Producto.AsignarProducto(TxtIdProducto.Text, Cliente.Codigo)

        If Respuesta = True Then
            MsgBox("Producto Asignado Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
        Else
            MsgBox("No fue posible Asignar el Producto. Consulte con el Administrador!", MsgBoxStyle.Information, Gl_NomCompañia)
        End If

        Me.Dispose()

    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Gl_Cliente.Cargareldataset() ' Cargo los Clientes Actuales en el Dataset Global

        For_ClientesBuscar.ShowDialog()

        Me.TxtCodCliente.Text = Gl_Cliente.Codigo
        Me.LblNombreCliente.Text = Gl_Cliente.Cliente

        ListarProductosCliente()

        DGProductos.Focus()

    End Sub
End Class