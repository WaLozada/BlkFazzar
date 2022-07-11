Imports System.Data.SqlClient

Public Class For_CentrosListado
    Dim Centro As New Centros()
    Sub Listar()
        Try
            DGCentros.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Centros.ListarCentro()

            Tabla.Load(Consulta)
            DGCentros.DataSource = Tabla

            DGCentros.Columns("NOMBRES_RESPONSABLE").HeaderText = "NOMBRE RESPONSABLE."
            DGCentros.Columns("APELLIDOS_RESPONSABLE").HeaderText = "APELLIDOS RESPONSABLE."
            DGCentros.Columns("NOMBRE_DEPTO").HeaderText = "DEPARTAMENTO"
            DGCentros.Columns("NOMBRE_MUNICIPIO").HeaderText = "MUNICIPIO"
            DGCentros.Columns("CODIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGCentros.Columns("MUELLES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGCentros.Columns("DIVIPOL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGCentros.Columns("IDCENTRO").Visible = False
            DGCentros.Columns("ID").Visible = False

            Try
                If DGCentros.SelectedRows.Count > 0 Then
                    DGCentros.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub

    Private Sub For_CentrosListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Perfil = ConsultaPerfil("03")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        For_Centros.BtnActualizar.Visible = False
        For_Centros.BtnCrear.Visible = True
        For_Centros.ShowDialog()
        Listar()

    End Sub
    Private Sub DGCentros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCentros.CellClick

        Try
            Centro.IdCentros = Trim(DGCentros.Rows(e.RowIndex).Cells(0).Value)
            Centro.Codigo = Trim(DGCentros.Rows(e.RowIndex).Cells(1).Value)
            Centro.Nombre = Trim(DGCentros.Rows(e.RowIndex).Cells(2).Value)
            Centro.Direccion = Trim(DGCentros.Rows(e.RowIndex).Cells(3).Value)
            Centro.Correo = Trim(DGCentros.Rows(e.RowIndex).Cells(4).Value)
            Centro.Telefono = Trim(DGCentros.Rows(e.RowIndex).Cells(5).Value)
            Centro.Muelles = Trim(DGCentros.Rows(e.RowIndex).Cells(6).Value)
            Centro.NombreResponsable = Trim(DGCentros.Rows(e.RowIndex).Cells(7).Value)
            Centro.ApellidoResponsable = Trim(DGCentros.Rows(e.RowIndex).Cells(8).Value)
            Centro.Departamento = Trim(DGCentros.Rows(e.RowIndex).Cells(9).Value)
            Centro.Municipio = Trim(DGCentros.Rows(e.RowIndex).Cells(10).Value)
            Centro.Divipol = Trim(DGCentros.Rows(e.RowIndex).Cells(11).Value)

        Catch ex As Exception

        End Try


    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click


        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("05")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If


        If Centro.Codigo <> "" Then
            Dim Rta = MsgBox("Desea Editar los datos de " + Centro.Nombre + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

            If Rta = vbYes Then

                For_Centros.TxtCodigo.Text = Centro.Codigo
                For_Centros.TxtCentro.Text = Centro.Nombre
                For_Centros.TxtDireccion.Text = Centro.Direccion
                For_Centros.TxtCorreo.Text = Centro.Correo
                For_Centros.TxtCelular.Text = Centro.Telefono
                For_Centros.CmbMuelles.Text = Centro.Muelles
                For_Centros.TxtNombResponsable.Text = Centro.NombreResponsable
                For_Centros.TxtApelResponsable.Text = Centro.ApellidoResponsable
                For_Centros.TxtPais.Text = "COLOMBIA"
                For_Centros.TxtDepto.Text = Centro.Departamento
                For_Centros.TxtDivipol.Text = Centro.Divipol
                For_Centros.TxtMunicipio.Text = Centro.Municipio

                For_Centros.BtnActualizar.Visible = True
                For_Centros.BtnCrear.Visible = False
                For_Centros.ShowDialog()
                Listar()

            End If
        End If

    End Sub
    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("06")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If


        If Centro.Codigo <> "" Then

            Dim Rta = MsgBox("Desea Eliminar " + Centro.Nombre + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

            If Rta = vbYes Then

                Dim Respuesta = Centro.BorrarCentro(Centro.Codigo)

                If Respuesta = True Then
                    MsgBox("Centro Eliminado Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
                Else
                    MsgBox("No fue posible Eliminar el centro. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Exit Sub
                End If

                Listar()
            End If

        End If


    End Sub

End Class