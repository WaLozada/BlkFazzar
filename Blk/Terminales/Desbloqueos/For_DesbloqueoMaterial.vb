Imports System.Data.SqlClient

Public Class For_DesbloqueoMaterial
    Dim Centro As New Centros()
    Dim Bodega As New Bodegas()
    Dim Deposito As New Depositos()
    Dim Bloqueados As New Cls_Desbloqueo()
    Sub Listar(Centro, Bodega, Cliente)
        Try
            DGBloqueados.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable


            Consulta = Bloqueados.ListarBloqueados(Centro, Bodega, Cliente)

            Tabla.Load(Consulta)
            DGBloqueados.DataSource = Tabla
            DGBloqueados.Columns("IDBLOQUEO").Visible = False
            Consulta.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

    End Sub
    Sub CargarCombos()

        '-------------------- Cargo los Centros -------------
        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = Centro.ListarCentro()

        Tabla.Load(Consulta)

        Me.CmbCentros.DisplayMember = "NOMBRE"
        Me.CmbCentros.ValueMember = "CODIGO"
        Me.CmbCentros.DataSource = Tabla
        Me.CmbCentros.Text = ""
        '-----------------------------------------------------
    End Sub


    Private Sub For_DesbloqueoMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCombos()

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        'Me.TabControl1.Left = (Me.Width / 2) - (TabControl1.Width / 2)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        If Trim(CmbBodegas.Text) = "" Then
            MsgBox("Debe Selecionar primero la Bodega!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            CmbBodegas.Focus()
            Exit Sub
        End If

        Gl_Cliente.Cargareldataset() ' Cargo los Clientes Actuales en el Dataset Global
        Gl_Cliente.LimpiarVariableGlobal() ' Limpio la variable Global de Clientes 


        For_ClientesBuscar.ShowDialog()

        If Gl_Cliente.Codigo = "" Then ' Si no selecciona ningun cliente no debe Continuar.
            Exit Sub
        End If

        Dim Consulta As SqlDataReader
        Dim Codigo As String = ""

        Consulta = Deposito.CodigoDeposito(CmbBodegas.SelectedValue, Gl_Cliente.Codigo)

        If Consulta.Read() Then
            Codigo = Trim(Consulta("CODIGO").ToString())
        End If
        Consulta.Close()

        If Trim(Codigo) = "" Then
            MsgBox("El cliente Seleccionado No Cuenta con Deposito En la Bodega Indicada!", MsgBoxStyle.Critical, Gl_NomCompañia)
        Else
            Me.TxtCodCliente.Text = Gl_Cliente.Codigo
            Me.LblNombreCliente.Text = Gl_Cliente.Cliente
            Me.TxtDeposito.Text = Codigo

            Listar(CmbCentros.SelectedValue, CmbBodegas.SelectedValue, Gl_Cliente.Codigo)

            Gl_Cliente.LimpiarVariableGlobal()

        End If

    End Sub

    Private Sub CmbCentros_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbCentros.SelectionChangeCommitted
        '------------ Listo las Bodegas del Centro Seleccionado ---------------
        CmbBodegas.DataSource = Nothing

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = Bodega.ListarBodegas(CmbCentros.SelectedValue)

        Tabla.Load(Consulta)

        Me.CmbBodegas.DisplayMember = "DESCRIPCION"
        Me.CmbBodegas.ValueMember = "CODIGO"
        Me.CmbBodegas.DataSource = Tabla

        Me.CmbBodegas.Text = ""



        Consulta.Close()
        '-------------------------------------------------------------------------

        CmbBodegas.Focus()
    End Sub
    Private Sub CmbBodegas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbBodegas.SelectionChangeCommitted
        BtnBuscar.Focus()
    End Sub

    Private Sub For_DesbloqueoMaterial_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub DGBloqueados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBloqueados.CellClick

        Dim Rta = MsgBox("Desea Desbloequear el material Seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

        If Rta = vbYes Then

        End If

    End Sub
End Class