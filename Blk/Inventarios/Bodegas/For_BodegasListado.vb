Imports System.Data.SqlClient

Public Class For_BodegasListado
    Dim Bodega As New Bodegas()
    Sub Listar()
        Try
            DGBodegas.DataSource = Nothing

            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Bodega.ListarBodegas()

            Tabla.Load(Consulta)
            DGBodegas.DataSource = Tabla

            DGBodegas.Columns("CODIGO_POBLADO").HeaderText = "DIVIPOL"
            DGBodegas.Columns("IDBODEGA").Visible = False
            DGBodegas.Columns("VISIBLE").Visible = False
            DGBodegas.Columns("ID").Visible = False

            Try
                If DGBodegas.SelectedRows.Count > 0 Then
                    DGBodegas.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub
    Private Sub For_BodegasListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Perfil = ConsultaPerfil("22")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Bodega.CargarCombos()
        For_Bodegas.GBCodigoBodega.Visible = False
        For_Bodegas.BtnActualizar.Visible = False
        For_Bodegas.BtnCrear.Visible = True
        For_Bodegas.ShowDialog()
        Listar()

    End Sub
    Private Sub DGBodegas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBodegas.CellClick

        Try
            Bodega.IdBodega = Trim(DGBodegas.Rows(e.RowIndex).Cells(0).Value)
            Bodega.Codigo = Trim(DGBodegas.Rows(e.RowIndex).Cells(1).Value)
            Bodega.Descripcion = Trim(DGBodegas.Rows(e.RowIndex).Cells(2).Value)
            Bodega.Direccion = Trim(DGBodegas.Rows(e.RowIndex).Cells(3).Value)
            Bodega.Capacidad = Trim(DGBodegas.Rows(e.RowIndex).Cells(4).Value)
            Bodega.Departamento = Trim(DGBodegas.Rows(e.RowIndex).Cells(5).Value)
            Bodega.Municipio = Trim(DGBodegas.Rows(e.RowIndex).Cells(6).Value)
            Bodega.Divipol = Trim(DGBodegas.Rows(e.RowIndex).Cells(7).Value)
            Bodega.Centro = Trim(DGBodegas.Rows(e.RowIndex).Cells(8).Value)
            Bodega.Estado = Trim(DGBodegas.Rows(e.RowIndex).Cells(9).Value)
            Bodega.Visible = Trim(DGBodegas.Rows(e.RowIndex).Cells(10).Value)

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("24")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        If Bodega.Codigo <> "" Then
            Dim Rta = MsgBox("Desea Editar los datos de la Bodega " + Bodega.Codigo + " " + Bodega.Descripcion + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

            If Rta = vbYes Then

                Bodega.CargarCombos()

                For_Bodegas.GBCodigoBodega.Visible = True
                For_Bodegas.TxtBodega.Text = Bodega.Descripcion
                For_Bodegas.TxtCapacidad.Text = Bodega.Capacidad
                For_Bodegas.CmbCentros.SelectedIndex = For_Bodegas.CmbCentros.FindString(Bodega.Centro)
                For_Bodegas.CmbEstado.SelectedIndex = For_Bodegas.CmbEstado.FindString(Bodega.Estado)
                For_Bodegas.TxtDireccion.Text = Bodega.Direccion
                For_Bodegas.TxtPais.Text = "COLOMBIA"
                For_Bodegas.TxtDepto.Text = Bodega.Departamento
                For_Bodegas.TxtMunicipio.Text = Bodega.Municipio
                For_Bodegas.TxtDivipol.Text = Bodega.Divipol
                For_Bodegas.TxtCodigo.Text = Bodega.Codigo

                For_Bodegas.BtnActualizar.Visible = True
                For_Bodegas.BtnCrear.Visible = False
                For_Bodegas.ShowDialog()

                Listar()

            End If
        End If

    End Sub
    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("25")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        If Bodega.Codigo <> "" Then

            Dim Rta = MsgBox("Desea Eliminar la Bodega " + Bodega.Codigo + " " + Bodega.Descripcion + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

            If Rta = vbYes Then

                Dim Respuesta = Bodega.BorrarBodega(Bodega.Codigo)

                If Respuesta = True Then
                    MsgBox("Bodega Eliminada Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
                Else
                    MsgBox("No fue posible Borrar la Bodega. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Exit Sub
                End If

                Listar()
            End If

        End If


    End Sub

End Class