Imports System.Data.SqlClient


Public Class For_CeCoListar
    Dim CentroCosto As New CentroCostos()

    Sub CargarCombos()

        '-------------- Cargo Terminales --------------------------
        Dim dv3 As New DataView

        dv3.Table = Gl_DataSet.Tables("TTerminales")

        Me.CmbTerminales.DisplayMember = "TERMINAL"
        Me.CmbTerminales.ValueMember = "IDTERMINAL"
        Me.CmbTerminales.DataSource = dv3
        Me.CmbTerminales.Text = ""
        '-----------------------------------------------------

    End Sub
    Private Sub For_CeCoListar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCombos()

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Me.TabControl1.Left = (Me.Width / 2) - (TabControl1.Width / 2)

        Me.ToolTip1.SetToolTip(Me.BtnCopiar, "Copiar Nombre del Cliente")

    End Sub

    Private Sub CmbTerminales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTerminales.SelectedIndexChanged

        Try

            '-------------------- Cargo los Segmentos -------------
            Dim Tabla As New DataTable
            Dim Consulta2 As SqlDataReader
            Consulta2 = CentroCosto.ListarCentros(1, Trim(CmbTerminales.SelectedValue))

            Tabla.Load(Consulta2)

            Me.CmbSegmentos.DisplayMember = "SEGMENTO"
            Me.CmbSegmentos.ValueMember = "IDSEGMENTO"
            Me.CmbSegmentos.DataSource = Tabla
            Me.CmbSegmentos.Text = ""

            '-----------------------------------------------------

            Consulta2.Close()

        Catch ex As Exception

        End Try
        DGClientes.DataSource = Nothing


        CmbSegmentos.Focus()

    End Sub

    Private Sub CmbSegmentos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbSegmentos.SelectionChangeCommitted

        '-------------------- Cargo los Centros de Costo -------------
        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = CentroCosto.ListarClientes(CmbTerminales.SelectedValue, CmbSegmentos.SelectedValue)

        Tabla.Load(Consulta)

        DGClientes.DataSource = Tabla

        Consulta.Close()
        '-----------------------------------------------------

        DGClientes.Focus()

    End Sub

    Private Sub CmbTerminales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTerminales.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbSegmentos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbSegmentos.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnCrearCeCo_Click(sender As Object, e As EventArgs) Handles BtnCrearCeCo.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("55")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If


        For_CeCoClientesCrear.ShowDialog()
    End Sub

    Private Sub For_CeCoListar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click

        Gl_Cliente.CargareldatasetTransporte() ' Cargo los Clientes Actuales en el Dataset Global
        Gl_Cliente.LimpiarVariableGlobal() ' Limpio la variable Global de Clientes 

        For_ClientesTransporteBuscar.ShowDialog()

        If Gl_Cliente.Codigo = "" Then ' Si no selecciona ningun cliente no debe Continuar.
            Exit Sub
        End If

        Me.LblCliente.Tag = Gl_Cliente.Codigo
        Me.LblCliente.Text = Trim(Gl_Cliente.Cliente)

        ' ----- Listar los centros de Costo de un cliente en especifico -----

        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = CentroCosto.ListarCecoClientes(Trim(LblCliente.Text))

        Tabla.Load(Consulta)

        DGCeCoClientes.DataSource = Tabla

        Consulta.Close()

        '--------------------------------------------------------------------


    End Sub

    Private Sub BtnCopiar_Click(sender As Object, e As EventArgs) Handles BtnCopiar.Click

        Try

            If Trim(LblCliente.Text) = "" Then
                MsgBox("Realice la búsqueda del Cliente antes de copiarlo!", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            Else
                My.Computer.Clipboard.SetText(Trim(LblCliente.Text), System.Windows.Forms.TextDataFormat.Text)
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class