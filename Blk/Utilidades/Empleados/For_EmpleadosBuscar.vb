Public Class For_EmpleadosBuscar
    Private Sub For_EmpleadosBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GL_Empleado.LimpiarVariableGlobal() ' Limpio la Variable Global de Empleado

        TxtEmpleado_TextChanged("", e)

    End Sub

    Private Sub TxtEmpleado_TextChanged(sender As Object, e As EventArgs) Handles TxtEmpleado.TextChanged

        With DGEmpleados

            Dim Empleado As New Empleados()

            .DataSource = Empleado.CoincideEmpleado(TxtEmpleado.Text) ' Trae los resultados

            Dim FontCabecera As New Font(.ColumnHeadersDefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle.Font = FontCabecera

            Dim Font As New Font(.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .DefaultCellStyle.Font = Font

            .Columns("IDEMPLEADO").Visible = False
            .Columns("IDAREA").Visible = False
            .Columns("IDCARGO").Visible = False
            .Columns("ESTADO").Visible = False

        End With

    End Sub

    Private Sub For_EmpleadosBuscar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub DGEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGEmpleados.CellClick
        Try
            GL_Empleado.IdEmpleado = Trim(DGEmpleados.Rows(e.RowIndex).Cells(0).Value)
            GL_Empleado.Nombre = Trim(DGEmpleados.Rows(e.RowIndex).Cells(1).Value)
            GL_Empleado.Apellido = Trim(DGEmpleados.Rows(e.RowIndex).Cells(2).Value)
            GL_Empleado.Area = Trim(DGEmpleados.Rows(e.RowIndex).Cells(4).Value)
            GL_Empleado.Cargo = Trim(DGEmpleados.Rows(e.RowIndex).Cells(6).Value)
            GL_Empleado.Estado = Trim(DGEmpleados.Rows(e.RowIndex).Cells(7).Value)

        Catch ex As Exception
        End Try

        Me.Dispose()
    End Sub
End Class