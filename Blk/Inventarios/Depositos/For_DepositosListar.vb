Imports System.Data.SqlClient

Public Class For_DepositosListar
    Dim Deposito As New Depositos()

    Sub Listar()
        Try
            DGDepositos.DataSource = Nothing

            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Deposito.ListarDepositos

            Tabla.Load(Consulta)
            DGDepositos.DataSource = Tabla

            DGDepositos.Columns("IDDEPOSITO").Visible = False
            DGDepositos.Columns("VISIBLE").Visible = False
            DGDepositos.Columns("ID").Visible = False

            Try
                If DGDepositos.SelectedRows.Count > 0 Then
                    DGDepositos.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub

    Private Sub For_DepositosListar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Listar()
    End Sub
    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("26")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Deposito.CargarCombos()

        For_Depositos.GBCodigoDeposito.Visible = False
        For_Depositos.BtnActualizar.Visible = False
        For_Depositos.BtnCrear.Visible = True
        For_Depositos.ShowDialog()

        Listar()
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("28")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        If Deposito.Codigo <> "" Then
            Dim Rta = MsgBox("Desea Editar los datos del Deposito " + Deposito.Codigo + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

            If Rta = vbYes Then

                Deposito.CargarCombos()
                Deposito.CargarBodegas(Deposito.CodigoCentro)

                For_Depositos.TxtCodigo.Text = Deposito.Codigo
                For_Depositos.TxtCodCliente.Text = Deposito.CodigoCliente
                For_Depositos.LblNombreCliente.Text = Deposito.Cliente
                For_Depositos.CmbCentros.SelectedIndex = For_Depositos.CmbCentros.FindString(Deposito.Centro)
                For_Depositos.CmbBodegas.SelectedIndex = For_Depositos.CmbBodegas.FindString(Deposito.Bodega)
                For_Depositos.CmbEstado.SelectedIndex = For_Depositos.CmbEstado.FindString(Deposito.Estado)
                For_Depositos.GBCodigoDeposito.Visible = True

                For_Depositos.BtnActualizar.Visible = True
                For_Depositos.BtnCrear.Visible = False
                For_Depositos.ShowDialog()

                Listar()

            End If
        End If

    End Sub
    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("29")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        If Deposito.Codigo <> "" Then

            Dim Rta = MsgBox("Desea Eliminar El Deposito " + Deposito.Codigo + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

            If Rta = vbYes Then

                Dim Respuesta = Deposito.BorrarDeposito(Deposito.Codigo)

                If Respuesta = True Then
                    MsgBox("Deposito Eliminado Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
                Else
                    MsgBox("No fue posible Borrar el Deposito. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Exit Sub
                End If

                Listar()
            End If

        End If
    End Sub
    Private Sub DGDepositos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDepositos.CellClick
        Try
            Deposito.IdDeposito = Trim(DGDepositos.Rows(e.RowIndex).Cells(0).Value)
            Deposito.Codigo = Trim(DGDepositos.Rows(e.RowIndex).Cells(1).Value)
            Deposito.CodigoCliente = Trim(DGDepositos.Rows(e.RowIndex).Cells(2).Value)
            Deposito.Cliente = Trim(DGDepositos.Rows(e.RowIndex).Cells(3).Value)
            Deposito.CodigoCentro = Trim(DGDepositos.Rows(e.RowIndex).Cells(4).Value)
            Deposito.Centro = Trim(DGDepositos.Rows(e.RowIndex).Cells(5).Value)
            Deposito.CodigoBodega = Trim(DGDepositos.Rows(e.RowIndex).Cells(6).Value)
            Deposito.Bodega = Trim(DGDepositos.Rows(e.RowIndex).Cells(7).Value)
            Deposito.Estado = Trim(DGDepositos.Rows(e.RowIndex).Cells(8).Value)
            Deposito.Visible = Trim(DGDepositos.Rows(e.RowIndex).Cells(9).Value)
            Deposito.Id = Trim(DGDepositos.Rows(e.RowIndex).Cells(10).Value)

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try
    End Sub

End Class