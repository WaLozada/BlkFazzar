Imports System.Data.SqlClient

Public Class For_BackView
    Dim User As New Usuarios
    Private Sub TxtEmpleado_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub For_BackView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = User.ListarAccesoUsr()

            Tabla.Load(Consulta)
            DGUsuarios.DataSource = Tabla

            DGUsuarios.Columns("CLAVE").Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub
    Private Sub DGUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsuarios.CellClick
        Try

            TxtAcceso.Text = SeguridadBlk.UnEncryptStr(trim(DGUsuarios.Rows(e.RowIndex).Cells(5).Value), GL_ClaveEncrip)

        Catch ex As Exception
        End Try
    End Sub
End Class