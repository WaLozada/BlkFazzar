Imports System.Data.SqlClient

Public Class For_UsuariosListar
    Dim Usuario As New Usuarios()
    Sub Listar()
        Try
            DGUsuarios.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim TablaClientes As New DataTable

            Consulta = Usuario.ListarUsuarios()

            TablaClientes.Load(Consulta)
            DGUsuarios.DataSource = TablaClientes

            'DGUsuarios.Columns("NOMBCONTACTO").HeaderText = "NOMBRE CONTACTO"

            DGUsuarios.Columns("CADUCIDAD").Visible = False
            DGUsuarios.Columns("FECHACADUCIDAD").Visible = False
            DGUsuarios.Columns("IDROL").Visible = False
            DGUsuarios.Columns("IDAREA").Visible = False
            DGUsuarios.Columns("IDUBICACION").Visible = False
            DGUsuarios.Columns("FECHANAC").DefaultCellStyle.Format = "yyyy-MM-dd"
            DGUsuarios.Columns("FECHACLAVE").DefaultCellStyle.Format = "yyyy-MM-dd"
            DGUsuarios.Columns("FECHACADUCIDAD").DefaultCellStyle.Format = "yyyy-MM-dd"

            DGUsuarios.Columns("ID").Visible = False

            Try
                If DGUsuarios.SelectedRows.Count > 0 Then
                    DGUsuarios.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub
    Private Sub For_UsuariosListar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Perfil = ConsultaPerfil("10")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        For_UsuariosCrear.ShowDialog()

        Listar()

    End Sub

    Private Sub For_UsuariosListar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub DGUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsuarios.CellClick

        Try
            Usuario.Codigo = Trim(DGUsuarios.Rows(e.RowIndex).Cells(0).Value)
            Usuario.Tdoc = Trim(DGUsuarios.Rows(e.RowIndex).Cells(1).Value)
            Usuario.Documento = Trim(DGUsuarios.Rows(e.RowIndex).Cells(2).Value)
            Usuario.Papellido = Trim(DGUsuarios.Rows(e.RowIndex).Cells(3).Value)
            Usuario.Sapellido = Trim(DGUsuarios.Rows(e.RowIndex).Cells(4).Value)
            Usuario.Nombre = Trim(DGUsuarios.Rows(e.RowIndex).Cells(5).Value)
            Usuario.FechaNac = Trim(DGUsuarios.Rows(e.RowIndex).Cells(6).Value)
            Usuario.Direccion = Trim(DGUsuarios.Rows(e.RowIndex).Cells(7).Value)
            Usuario.Celular = Trim(DGUsuarios.Rows(e.RowIndex).Cells(8).Value)
            Usuario.Email = Trim(DGUsuarios.Rows(e.RowIndex).Cells(9).Value)
            Usuario.Area = Trim(DGUsuarios.Rows(e.RowIndex).Cells(11).Value)
            Usuario.Rol = Trim(DGUsuarios.Rows(e.RowIndex).Cells(12).Value)
            Usuario.FechaClave = Trim(DGUsuarios.Rows(e.RowIndex).Cells(14).Value)
            Usuario.Caducidad = Trim(DGUsuarios.Rows(e.RowIndex).Cells(15).Value)
            Usuario.Vigencia = Trim(DGUsuarios.Rows(e.RowIndex).Cells(16).Value)
            Usuario.Estado = Trim(DGUsuarios.Rows(e.RowIndex).Cells(17).Value)
            Usuario.Ubicacion = Trim(DGUsuarios.Rows(e.RowIndex).Cells(18).Value)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("12")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        With For_UsuariosCrear

            .TxtDocumento.Text = Usuario.Documento
            .TxtNombre.Text = Usuario.Nombre
            .TxtPapell.Text = Usuario.Papellido
            .TxtSapell.Text = Usuario.Sapellido
            .DTFechaNac.Value = Usuario.FechaNac
            .TxtDireccion.Text = Usuario.Direccion
            .TxtCelular.Text = Usuario.Celular
            .TxtEmail.Text = Usuario.Email
            .CmbRol.SelectedItem = Usuario.Rol
            If Usuario.Estado = "Activo" Then
                .RBActivo.Checked = True
            Else
                .RBInactivo.Checked = True
            End If
            If Usuario.Caducidad = 1 Then
                .RBIndefinido.Checked = True
            Else
                .RBVence.Checked = True
            End If
            .DTVigencia.Value = Usuario.Vigencia
            .CargarCombo()
            .CmbArea.Text = Usuario.Area
            .CmbUbicacion.SelectedItem = Usuario.Ubicacion
            .BtnEditar.Visible = True
            .BtnCrear.Visible = False
        End With

        For_UsuariosCrear.ShowDialog()


    End Sub

    Private Sub BtnPerfil_Click(sender As Object, e As EventArgs) Handles BtnPerfil.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("13")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        If Usuario.Codigo = "" Then
            MsgBox("Seleccione el Usuario al que desea establecer el Perfil!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        For_UsuarioPerfil.LblUsuario.Text = Usuario.Nombre & " " & Usuario.Papellido & " " & Usuario.Sapellido
        For_UsuarioPerfil.LblUsuario.Tag = Usuario.Codigo
        For_UsuarioPerfil.ShowDialog()

    End Sub
End Class