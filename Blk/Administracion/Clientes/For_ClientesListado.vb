Imports System.Data.SqlClient

Public Class For_ClientesListado

    Dim Cliente As New Clientes()

    Sub Listar()
        Try
            DGClientes.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim TablaClientes As New DataTable

            Consulta = Cliente.ListarClientes()

            TablaClientes.Load(Consulta)
            DGClientes.DataSource = TablaClientes

            DGClientes.Columns("NOMBCONTACTO").HeaderText = "NOMBRE CONTACTO"
            DGClientes.Columns("APELLCONTACTO").HeaderText = "APELLIDOS CONTACTO"
            DGClientes.Columns("NOMBRE_DEPTO").HeaderText = "DEPARTAMENTO"
            DGClientes.Columns("NOMBRE_MUNICIPIO").HeaderText = "MUNICIPIO"
            DGClientes.Columns("CODIGO_POBLADO").HeaderText = "CODIGO"
            DGClientes.Columns("ID").Visible = False

            Try
                If DGClientes.SelectedRows.Count > 0 Then
                    DGClientes.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

            Cliente.Cargareldataset() ' Carga el Dataset Global con el listado de Clientes

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub
    Private Sub For_ClientesListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Perfil = ConsultaPerfil("07")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Cliente.CargarCombos()
        For_Clientes.GBCodigoCliente.Visible = False
        For_Clientes.BtnActualizar.Visible = False
        For_Clientes.BtnCrear.Visible = True
        For_Clientes.ShowDialog()
        Listar()

    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("09")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        If Cliente.Documento <> "" Then
            Dim Rta = MsgBox("Desea Editar los datos de " + Cliente.Cliente + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

            If Rta = vbYes Then

                Cliente.CargarCombos()

                For_Clientes.GBCodigoCliente.Visible = True
                For_Clientes.TxtCodigo.Text = Cliente.Codigo
                For_Clientes.CmbTdoc.Text = Cliente.Tdoc
                For_Clientes.TxtDocumento.Text = Cliente.Documento
                For_Clientes.TxtCliente.Text = Cliente.Cliente
                For_Clientes.TxtDireccion.Text = Cliente.Direccion
                For_Clientes.TxtTelefono.Text = Cliente.Telefono
                For_Clientes.TxtNombContacto.Text = Cliente.NombContacto
                For_Clientes.TxtApelContacto.Text = Cliente.ApelContacto
                For_Clientes.TxtCelular.Text = Cliente.Celular
                For_Clientes.TxtCorreo.Text = Cliente.Correo
                For_Clientes.TxtDivipol.Text = Cliente.Divipol
                For_Clientes.TxtPais.Text = "COLOMBIA"
                For_Clientes.TxtDepto.Text = Cliente.Departamento
                For_Clientes.TxtMunicipio.Text = Cliente.Municipio
                For_Clientes.CmbTipo.SelectedIndex = For_Clientes.CmbTipo.FindString(Cliente.Tipo)
                For_Clientes.CmbEstado.SelectedIndex = For_Clientes.CmbEstado.FindString(Cliente.Estado)

                'Otras Opciones
                'For_Clientes.CmbEstado.SelectedValue = CByte(Cliente.Codigo)
                'For_Clientes.CmbEstado.Text = For_Clientes.CmbEstado.Items(Cliente.Codigo)

                For_Clientes.BtnActualizar.Visible = True
                For_Clientes.BtnCrear.Visible = False
                For_Clientes.ShowDialog()

                Listar()

            End If
        End If

    End Sub
    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("07")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        If Cliente.Codigo <> "" Then

            Dim Rta = MsgBox("Desea Eliminar a " + Cliente.Cliente + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

            If Rta = vbYes Then

                Dim Respuesta = Cliente.BorrarCliente(Cliente.Documento)

                If Respuesta = True Then
                    MsgBox("Cliente Eliminado Exitosamente!", MsgBoxStyle.Information, Gl_NomCompañia)
                Else
                    MsgBox("No fue posible Eliminar el Cliente. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Exit Sub
                End If

                Listar()
            End If

        End If


    End Sub
    Private Sub DGClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGClientes.CellClick

        Try
            Cliente.Codigo = Trim(DGClientes.Rows(e.RowIndex).Cells(0).Value)
            Cliente.Tdoc = Trim(DGClientes.Rows(e.RowIndex).Cells(1).Value)
            Cliente.Documento = Trim(DGClientes.Rows(e.RowIndex).Cells(2).Value)
            Cliente.Cliente = Trim(DGClientes.Rows(e.RowIndex).Cells(3).Value)
            Cliente.Direccion = Trim(DGClientes.Rows(e.RowIndex).Cells(4).Value)
            Cliente.Telefono = Trim(DGClientes.Rows(e.RowIndex).Cells(5).Value)
            Cliente.Tipo = Trim(DGClientes.Rows(e.RowIndex).Cells(6).Value)
            Cliente.NombContacto = Trim(DGClientes.Rows(e.RowIndex).Cells(7).Value)
            Cliente.ApelContacto = Trim(DGClientes.Rows(e.RowIndex).Cells(8).Value)
            Cliente.Celular = Trim(DGClientes.Rows(e.RowIndex).Cells(9).Value)
            Cliente.Correo = Trim(DGClientes.Rows(e.RowIndex).Cells(10).Value)
            Cliente.Departamento = Trim(DGClientes.Rows(e.RowIndex).Cells(11).Value)
            Cliente.Municipio = Trim(DGClientes.Rows(e.RowIndex).Cells(12).Value)
            Cliente.Divipol = Trim(DGClientes.Rows(e.RowIndex).Cells(13).Value)
            Cliente.Estado = Trim(DGClientes.Rows(e.RowIndex).Cells(14).Value)
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub

    Private Sub BtnTarifas_Click(sender As Object, e As EventArgs) Handles BtnTarifas.Click


        For_ClientesTarifas.LblNombreCliente.Text = Cliente.Cliente
        For_ClientesTarifas.LblCodigo.Text = Cliente.Codigo

        '---------------------Consultar Tarifas de Cargue y Descargue-----------------------

        Try
            For_ClientesTarifas.DGTarifas.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim Tablatarifas As New DataTable

            Consulta = Cliente.ConsultaTarifas(Cliente.Codigo)

            Tablatarifas.Load(Consulta)
            For_ClientesTarifas.DGTarifas.DataSource = Tablatarifas

            For_ClientesTarifas.DGTarifas.Columns("CODIGO").Visible = False
            For_ClientesTarifas.DGTarifas.Columns("IDSERVICIO").Visible = False
            For_ClientesTarifas.DGTarifas.Columns("IDUNIDAD").Visible = False
            For_ClientesTarifas.DGTarifas.Columns("IDCENTRO").Visible = False
            For_ClientesTarifas.DGTarifas.Columns("IDBODEGA").Visible = False
            For_ClientesTarifas.DGTarifas.Columns("TIPO").HeaderText = "SERVICIO"
            For_ClientesTarifas.DGTarifas.Columns("VALOR").DefaultCellStyle.Format = "C0"
            For_ClientesTarifas.DGTarifas.Columns("TIPO").HeaderText = "SERVICIO"
            For_ClientesTarifas.DGTarifas.Columns("NOMBRE").HeaderText = "CEDIS"
            For_ClientesTarifas.DGTarifas.Columns("DESCRIPCION").HeaderText = "BODEGA"
            For_ClientesTarifas.DGTarifas.Columns("ID").Visible = False
            'For_ClientesTarifas.DGTarifas.Columns("ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


        '-----------------------------------------------------------------------------------

        For_ClientesTarifas.ShowDialog()

    End Sub

    Private Sub DGClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGClientes.CellContentClick

    End Sub
End Class