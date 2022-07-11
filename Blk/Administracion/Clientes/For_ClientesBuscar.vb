Imports System.ComponentModel

Public Class For_ClientesBuscar
    Private Sub TxtCliente_TextChanged(sender As Object, e As EventArgs) Handles TxtCliente.TextChanged

        With DGClientes

            Dim Cliente As New Clientes()

            .DataSource = Cliente.CoincideCliente(TxtCliente.Text) ' Trae los resultados

            Dim FontCabecera As New Font(.ColumnHeadersDefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle.Font = FontCabecera

            Dim Font As New Font(.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .DefaultCellStyle.Font = Font

            .Columns("TDOC").Visible = False
            .Columns("DIRECCION").Visible = False
            .Columns("TELEFONO").Visible = False
            .Columns("TIPO").Visible = False
            .Columns("NOMBCONTACTO").Visible = False
            .Columns("APELLCONTACTO").Visible = False
            .Columns("CELULAR").Visible = False
            .Columns("CORREO").Visible = False
            .Columns("NOMBRE_DEPTO").Visible = False
            .Columns("CODIGO_POBLADO").Visible = False
            .Columns("ID").Visible = False

        End With

    End Sub

    Private Sub DGClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGClientes.CellClick

        Try
            Gl_Cliente.Codigo = Trim(DGClientes.Rows(e.RowIndex).Cells(0).Value)
            Gl_Cliente.Tdoc = Trim(DGClientes.Rows(e.RowIndex).Cells(1).Value)
            Gl_Cliente.Documento = Trim(DGClientes.Rows(e.RowIndex).Cells(2).Value)
            Gl_Cliente.Cliente = Trim(DGClientes.Rows(e.RowIndex).Cells(3).Value)
            Gl_Cliente.Direccion = Trim(DGClientes.Rows(e.RowIndex).Cells(4).Value)
            Gl_Cliente.Telefono = Trim(DGClientes.Rows(e.RowIndex).Cells(5).Value)
            Gl_Cliente.Tipo = Trim(DGClientes.Rows(e.RowIndex).Cells(6).Value)
            Gl_Cliente.NombContacto = Trim(DGClientes.Rows(e.RowIndex).Cells(7).Value)
            Gl_Cliente.ApelContacto = Trim(DGClientes.Rows(e.RowIndex).Cells(8).Value)
            Gl_Cliente.Celular = Trim(DGClientes.Rows(e.RowIndex).Cells(9).Value)
            Gl_Cliente.Correo = Trim(DGClientes.Rows(e.RowIndex).Cells(10).Value)
            Gl_Cliente.Departamento = Trim(DGClientes.Rows(e.RowIndex).Cells(11).Value)
            Gl_Cliente.Municipio = Trim(DGClientes.Rows(e.RowIndex).Cells(12).Value)
            Gl_Cliente.Divipol = Trim(DGClientes.Rows(e.RowIndex).Cells(13).Value)
            Gl_Cliente.Estado = Trim(DGClientes.Rows(e.RowIndex).Cells(14).Value)
        Catch ex As Exception
        End Try

        Me.Dispose()

    End Sub

    Private Sub For_ClientesBuscar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub For_ClientesBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Gl_Cliente.LimpiarVariableGlobal() ' Limpio la Variable Global de Cliente
    End Sub


End Class