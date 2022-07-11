Imports System.Data.SqlClient

Public Class For_EquiposRegistro
    Dim Activos As New ActivosTI()
    Sub CargarCombos()

        '-------------------- Cargo los Tipos de Activo -------------
        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = Activos.ListarTipos()

        Tabla.Load(Consulta)

        Me.CmbTipo.DisplayMember = "TIPO"
        Me.CmbTipo.ValueMember = "IDTIPO"
        Me.CmbTipo.DataSource = Tabla
        Me.CmbTipo.Text = ""
        Me.LblTipo.Text = ""
        '-----------------------------------------------------

        '-------------------- Cargo las Marcas --------------
        Dim Tabla1 As New DataTable
        Dim Consulta1 As SqlDataReader
        Consulta1 = Activos.ListarMarcas()

        Tabla1.Load(Consulta1)

        Me.CmbMarca.DisplayMember = "MARCA"
        Me.CmbMarca.ValueMember = "IDMARCA"
        Me.CmbMarca.DataSource = Tabla1
        Me.CmbMarca.Text = ""
        Me.LblMarca.Text = ""
        '-----------------------------------------------------

        '-------------- Cargo Las Areas ---------------------
        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TAreas")

        Me.CmbArea.DisplayMember = "AREA"
        Me.CmbArea.ValueMember = "IDAREA"
        Me.CmbArea.DataSource = dv
        Me.CmbArea.Text = ""
        Me.LblArea.Text = ""
        '-----------------------------------------------------

        '-------------- Cargo Los Lugares ---------------------
        Dim dv1 As New DataView

        dv1.Table = Gl_DataSet.Tables("TLugar")

        Me.CmbLugar.DisplayMember = "LUGAR"
        Me.CmbLugar.ValueMember = "IDLUGAR"
        Me.CmbLugar.DataSource = dv1
        Me.CmbLugar.Text = ""
        Me.LblLugar.Text = ""
        '-----------------------------------------------------

        CmbCaracteristica.DataSource = Nothing


    End Sub
    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If Trim(CmbTipo.Text) = "" Then
            ListaErrores.Add("- Seleccione el tipo de Activo")
        End If

        If Trim(CmbMarca.Text) = "" Then
            ListaErrores.Add("- Seleccione la Marca del Activo")
        End If

        If Trim(CmbModelo.Text) = "" Then
            ListaErrores.Add("- Seleccione el Modelo del Activo")
        End If

        If Trim(TxtSerial.Text) = "" Then
            ListaErrores.Add("- Digíte el número de Serial del Activo")
        End If

        If Trim(LblFechaCompra.Text) = "" Then
            ListaErrores.Add("- Seleccione la fecha de la Factura de compra")
        End If

        If Trim(TxtFactura.Text) = "" Then
            ListaErrores.Add("- Digíte el número de la Factura de compra")
        End If

        If Trim(LblProveedor.Text) = "" Then
            ListaErrores.Add("- Seleccione el Proveedor")
        End If

        If DGCaracteristicas.Rows.Count = 0 Then
            ListaErrores.Add("- Adicione al menos una caracteristica del Activo ")
        End If

        If Trim(TxtDivipol.Text) = "" Then
            ListaErrores.Add("- Seleccione la Ubicación del Activo")
        End If

        If Trim(TxtResponsable.Text) = "" Then
            ListaErrores.Add("- Seleccione el Responsable del Activo")
        End If

        If Trim(CmbLugar.Text) = "" Then
            ListaErrores.Add("- Seleccione el Lugar de ubicación del Activo")
        End If

        If Trim(CmbArea.Text) = "" Then
            ListaErrores.Add("- Seleccione el Area de Ubicación del Archivo")
        End If


        Return ListaErrores

    End Function

    Private Sub For_EquiposRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCombos()

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Me.Panel1.Left = (Me.Width / 2) - (Panel1.Width / 2)

        'LblFechaCompra.Text = Format(Date.Now, "yyyy-MM-dd")

    End Sub

    Private Sub CmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipo.SelectedIndexChanged

        LblTipo.Text = Trim(CmbTipo.Text)
        LblMarca.Text = ""
        LblModelo.Text = ""
        CmbMarca.Text = ""
        CmbModelo.DataSource = Nothing


        '-------------------- Cargo los Tipos de Activo -------------
        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = Activos.ListarCaracteristicas(CmbTipo.SelectedValue)

        Tabla.Load(Consulta)

        Me.CmbCaracteristica.DisplayMember = "GRUPO"
        Me.CmbCaracteristica.ValueMember = "IDGRUPO"
        Me.CmbCaracteristica.DataSource = Tabla
        Me.CmbCaracteristica.Text = ""
        '-----------------------------------------------------

        CmbMarca.Focus()
    End Sub

    Private Sub CmbTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTipo.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMarca.SelectedIndexChanged

        CmbModelo.DataSource = Nothing

        '-------------------- Cargo los Tipos de Activo -------------
        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = Activos.ListarModelos(CmbMarca.SelectedValue, CmbTipo.SelectedValue)

        Tabla.Load(Consulta)

        Me.CmbModelo.DisplayMember = "MODELO"
        Me.CmbModelo.ValueMember = "IDMODELO"
        Me.CmbModelo.DataSource = Tabla
        Me.CmbModelo.Text = ""
        Me.LblModelo.Text = ""
        '-----------------------------------------------------
        LblMarca.Text = Trim(CmbMarca.Text)
        CmbModelo.Focus()


    End Sub

    Private Sub CmbMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbMarca.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbModelo.SelectedIndexChanged

        LblModelo.Text = Trim(CmbModelo.Text)
        TxtSerial.Focus()

    End Sub

    Private Sub CmbModelo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbModelo.KeyPress

        e.Handled = True

    End Sub

    Private Sub For_EquiposRegistro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub TxtSerial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSerial.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TxtFactura.Focus()
        End If

    End Sub

    Private Sub RBInactivo_CheckedChanged(sender As Object, e As EventArgs) Handles RBInactivo.CheckedChanged
        MCalendar.Focus()
    End Sub

    Private Sub RBActivo_CheckedChanged(sender As Object, e As EventArgs) Handles RBActivo.CheckedChanged
        MCalendar.Focus()
    End Sub

    Private Sub MCalendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MCalendar.DateChanged

        LblFechaCompra.Text = Format(MCalendar.SelectionStart, "yyyy-MM-dd")
        TxtFactura.Focus()

    End Sub

    Private Sub TxtFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFactura.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnBuscarProv.Focus()
        End If
    End Sub

    Private Sub CmbCaracteristica_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCaracteristica.SelectedIndexChanged

        '-------------------- Cargo los Tipos de Activo -------------
        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = Activos.ListarDetalles(CmbCaracteristica.SelectedValue, CmbTipo.SelectedValue)

        Tabla.Load(Consulta)

        Me.CmbDetalle.DisplayMember = "CARACTERISTICA"
        Me.CmbDetalle.ValueMember = "IDCARACTERISTICA"
        Me.CmbDetalle.DataSource = Tabla
        Me.CmbDetalle.Text = ""
        '-----------------------------------------------------

        CmbDetalle.Focus()


    End Sub

    Private Sub CmbDetalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDetalle.SelectedIndexChanged

        BtnAdicionar.Focus()

    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

        If CmbCaracteristica.Text = "" Then
            MsgBox("Seleccione la Caracteristica", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbCaracteristica.Focus()
            Exit Sub
        End If

        If CmbDetalle.Text = "" Then
            MsgBox("Seleccione el detalle", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbDetalle.Focus()
            Exit Sub
        End If

        For I = 0 To DGCaracteristicas.Rows.Count - 1
            If DGCaracteristicas.Rows(0).Cells(2).Value = CmbDetalle.SelectedValue Then
                MsgBox("Esta caracteristica ya fue adicionada!", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            End If
        Next

        DGCaracteristicas.Rows.Add(CmbCaracteristica.SelectedValue, Trim(CmbCaracteristica.Text), CmbDetalle.SelectedValue, Trim(CmbDetalle.Text))

        CmbCaracteristica.Text = ""
        CmbDetalle.Text = ""


    End Sub

    Private Sub BtnBuscarProv_Click(sender As Object, e As EventArgs) Handles BtnBuscarProv.Click

        GL_Proveedor.Cargareldataset()
        For_ProveedoresBuscar.ShowDialog()

        If GL_Proveedor.Codigo <> "" Then
            LblProveedor.Text = GL_Proveedor.Nombre
            LblProveedor.Tag = GL_Proveedor.Codigo
            TxtObservaciones.Focus()
        End If

    End Sub
    Private Sub DGCaracteristicas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCaracteristicas.CellClick

        Dim Rta = MsgBox("Desea Eliminar la Caracteristica seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

        If Rta = MsgBoxResult.Yes Then
            DGCaracteristicas.Rows.RemoveAt(e.RowIndex)
        End If

    End Sub

    Private Sub CmbArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbArea.SelectedIndexChanged
        LblArea.Text = Trim(CmbArea.Text)
        BtnGuardar.Focus()

    End Sub

    Private Sub BtnBuscaCiudad_Click(sender As Object, e As EventArgs) Handles BtnBuscaCiudad.Click

        Gl_Divipolitica.Pais = ""
        Gl_Divipolitica.NombreDepto = ""
        Gl_Divipolitica.NombreMunicipio = ""
        Gl_Divipolitica.CodigoPoblado = ""


        For_Divipoliticas.ShowDialog()

        Me.TxtPais.Text = Gl_Divipolitica.Pais
        Me.TxtDepto.Text = Gl_Divipolitica.NombreDepto
        Me.TxtDivipol.Text = Gl_Divipolitica.CodigoPoblado
        Me.TxtMunicipio.Text = Gl_Divipolitica.NombreMunicipio
        Me.CmbLugar.Text = ""
        Me.LblLugar.Text = ""
        BtnBuscaResp.Focus()


    End Sub

    Private Sub BtnBuscaResp_Click(sender As Object, e As EventArgs) Handles BtnBuscaResp.Click

        GL_Empleado.Nombre = ""
        GL_Empleado.Apellido = ""
        GL_Empleado.Area = ""

        GL_Empleado.Cargareldataset()
        For_EmpleadosBuscar.ShowDialog()

        Me.TxtResponsable.Text = Trim(GL_Empleado.Nombre) & " " & Trim(GL_Empleado.Apellido)
        Me.CmbArea.Text = GL_Empleado.Area
        Me.LblArea.Text = GL_Empleado.Area


    End Sub

    Private Sub CmbLugar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbLugar.SelectedIndexChanged
        LblLugar.Text = Trim(CmbLugar.Text)
        CmbArea.Focus()
    End Sub

    Private Sub CmbLugar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbLugar.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbArea.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        '----------- Ingresar Datos -------------------------------

        Activos.Tipo = CmbTipo.SelectedValue
        Activos.Marca = CmbMarca.SelectedValue
        Activos.Modelo = CmbModelo.SelectedValue
        Activos.Serial = Trim(TxtSerial.Text)
        If RBActivo.Checked = True Then
            Activos.Estado = 1
        Else
            Activos.Estado = 2
        End If
        Activos.FechaFactura = LblFechaCompra.Text
        Activos.NumFactura = Trim(TxtFactura.Text)
        Activos.Proveedor = LblProveedor.Tag
        Activos.Observaciones = Trim(TxtObservaciones.Text)
        Activos.Ciudad = TxtDivipol.Text
        Activos.Responsable = GL_Empleado.IdEmpleado  ' codigo del empleado.
        Activos.Lugar = CmbLugar.SelectedValue
        Activos.Area = CmbArea.SelectedValue

        '-- Caracteristicas --
        Activos.Caracteristicas = DGCaracteristicas
        '---------------

        Dim Respuesta = Activos.GuardarActivo()

        If Respuesta = True Then
            MsgBox("Activo Registrado Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
        Else
            MsgBox("No fue Posible Registrar el Activo. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        Me.Dispose()

        '-----------------------------------------------------------


    End Sub

    Private Sub CmbDetalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbDetalle.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnAddModelo_Click(sender As Object, e As EventArgs) Handles BtnAddModelo.Click

        If CmbTipo.Text = "" Then
            MsgBox("Seleccione el tipo de equipo!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbTipo.Focus()
            Exit Sub
        End If
        If CmbMarca.Text = "" Then
            MsgBox("Seleccione la Marca de la cual adicionará un nuevo Modelo!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbMarca.Focus()
            Exit Sub
        End If

        For_EquiposModelos.LblTipo.Text = Trim(CmbTipo.Text)
        For_EquiposModelos.LblTipo.Tag = CmbTipo.SelectedValue

        For_EquiposModelos.LblMarca.Text = Trim(CmbMarca.Text)
        For_EquiposModelos.LblMarca.Tag = CmbMarca.SelectedValue

        For_EquiposModelos.ShowDialog()




    End Sub
End Class