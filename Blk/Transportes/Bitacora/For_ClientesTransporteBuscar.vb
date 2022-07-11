Public Class For_ClientesTransporteBuscar
    Private Sub TxtCliente_TextChanged(sender As Object, e As EventArgs) Handles TxtCliente.TextChanged

        With DGClientes

            Dim Cliente As New Clientes()

            .DataSource = Cliente.CoincideClienteTransporte(TxtCliente.Text) ' Trae los resultados

            Dim FontCabecera As New Font(.ColumnHeadersDefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle.Font = FontCabecera

            Dim Font As New Font(.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .DefaultCellStyle.Font = Font

            .Columns("IDCLIENTE").Visible = False
            .Columns("ID").Visible = False

        End With

    End Sub


    Private Sub DGClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGClientes.CellClick

        Try
            Gl_Cliente.Codigo = Trim(DGClientes.Rows(e.RowIndex).Cells(0).Value)
            Gl_Cliente.Cliente = Trim(DGClientes.Rows(e.RowIndex).Cells(1).Value)

        Catch ex As Exception
        End Try

        Me.Dispose()

    End Sub

    Private Sub For_ClientesTransporteBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Gl_Cliente.LimpiarVariableGlobal() ' Limpio la Variable Global de Cliente 
    End Sub

    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click

    End Sub
End Class