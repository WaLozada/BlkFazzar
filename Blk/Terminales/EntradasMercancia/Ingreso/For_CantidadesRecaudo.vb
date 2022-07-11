Imports System.Data.SqlClient

Public Class For_CantidadesRecaudo

    Dim Cliente As New Clientes()


    Sub CargarCombos()

        '-------------- Cargo Servicios ------------
        Dim dv1 As New DataView

        dv1.Table = Gl_DataSet.Tables("TServicios")

        Me.CmbServicios.DisplayMember = "TIPO"
        Me.CmbServicios.ValueMember = "ID"
        dv1.RowFilter = String.Format("ID=3 OR ID=4")
        Me.CmbServicios.DataSource = dv1
        Me.CmbServicios.Text = ""
        '-----------------------------------------------------

    End Sub
    Private Sub For_CantidadesRecaudo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
    End Sub

    Private Sub CmbServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbServicios.SelectedIndexChanged

        TxtCantidad.Focus()
    End Sub

    Private Sub CmbServicios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbServicios.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

        If Trim(TxtCantidad.Text) = "" Then
            MsgBox("Indique la cantidad de producto!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        For i = 0 To DGTarifasServicios.Rows.Count - 1
            If CmbServicios.SelectedValue = DGTarifasServicios.Rows(i).Cells(0).Value Then
                MsgBox("Ya se registro una Cantidad para ese tipo de servicio.Si desea Cambiarla debe eliminar el registro existente e ingresarla de nuevo.!", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            End If
        Next

        If (Val(TxtSumacantidad.Text) + Val(TxtCantidad.Text)) > TxtCantidadTotal.Text Then
            MsgBox("La Cantidad ingresada superaria el total de producto a descargar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        DGTarifasServicios.Rows.Add(CmbServicios.SelectedValue, CmbServicios.Text, TxtCantidad.Text, FormatCurrency(TxtValorUnitario.Text, 0), FormatCurrency(TxtValorTotal.Text, 0))

        TxtSumaservicios.Text = CType(TxtSumaservicios.Text, Integer) + CType(TxtValorTotal.Text, Integer)
        TxtSumacantidad.Text += Val(TxtCantidad.Text)

        If Val(TxtSumacantidad.Text) = Val(TxtCantidadTotal.Text) Then
            BtnAdicionar.Enabled = False
            BtnGuardar.Enabled = True
        End If

        TxtTotalServicio.Text = FormatCurrency(TxtSumaservicios.Text, 0)

        TxtCantidad.Text = ""
        CmbServicios.Text = ""
        TxtValorUnitario.Text = ""
        TxtValorTotal.Text = ""

    End Sub

    Private Sub BtnTarifas_Click(sender As Object, e As EventArgs) Handles BtnTarifas.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("49")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Cliente.Codigo = For_IngresoMercancia.TxtCodCliente.Text
        Cliente.Cliente = For_IngresoMercancia.LblNombreCliente.Text

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

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


        '-----------------------------------------------------------------------------------

        For_ClientesTarifas.ShowDialog()

    End Sub

    Private Sub For_CantidadesRecaudo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub CmbServicios_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbServicios.SelectionChangeCommitted

        ' ---- Consultar y traer los precios del servicio de Descargue para ese cedis en esa Bodega ---

        Dim Descargue As New ClsCargueDescargue()

        Dim Consulta1 As SqlDataReader

        Consulta1 = Descargue.ValoresDescargue(For_IngresoMercancia.CmbCentros.SelectedValue, For_IngresoMercancia.CmbBodegas.SelectedValue, Gl_Cliente.Codigo, CmbServicios.SelectedValue)

        If Consulta1.Read() Then
            TxtValorUnitario.Text = Trim(Consulta1("VALOR").ToString())
        Else
            TxtValorUnitario.Text = 0
        End If
        Consulta1.Close()

        '----------------------------------------------------------------------------------------------

    End Sub

    Private Sub TxtCantidad_LostFocus(sender As Object, e As EventArgs) Handles TxtCantidad.LostFocus

        Try
            If Trim(TxtValorUnitario.Text) = "" Then TxtValorUnitario.Text = 0
            'If Val(TxtValorUnitario.Text) > 0 Then
            TxtValorTotal.Text = TxtValorUnitario.Text * (TxtCantidad.Text / 1000)
            ' Else
            'MsgBox("Tarifa no parametrizada", MsgBoxStyle.Critical, Gl_NomCompañia)
            'TxtCantidad.Focus()
            'Exit Sub
            'End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnAdicionar.Focus()
        Else
            '------ Permitir la Coma como signo decimal -----
            If Asc(e.KeyChar) = 44 Then
                e.Handled = False
                Exit Sub
            End If
            '-------------------------------------------------
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub


    Private Sub DGTarifasServicios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTarifasServicios.CellClick

        Dim Rta = MsgBox("Desea Eliminar el Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

        If Rta = vbYes Then

            TxtSumaservicios.Text = CType(TxtSumaservicios.Text, Integer) - CType(DGTarifasServicios.Rows(e.RowIndex).Cells(4).Value, Integer)
            TxtSumacantidad.Text -= Val(DGTarifasServicios.Rows(e.RowIndex).Cells(2).Value)

            TxtTotalServicio.Text = FormatCurrency(TxtSumaservicios.Text, 0)
            DGTarifasServicios.Rows.RemoveAt(e.RowIndex)
            BtnAdicionar.Enabled = True
            BtnGuardar.Enabled = False
        End If


    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        For_IngresoMercancia.DGTarifasServicios.Rows.Clear()

        '-------------------------------------------------------------------------------
        With DGTarifasServicios
            '0 IdServicio
            '1 Servicio
            '2 Cantidad
            '3 Valor
            '4 Total

            For I = 0 To .Rows.Count - 1
                For_IngresoMercancia.DGTarifasServicios.Rows.Add(Trim(.Rows(I).Cells(0).Value),
                                                           Trim(.Rows(I).Cells(1).Value),
                                                           Trim(.Rows(I).Cells(2).Value),
                                                           Trim(.Rows(I).Cells(3).Value),
                                                           Trim(.Rows(I).Cells(4).Value))
            Next

            For_IngresoMercancia.TxtValorTotal.Text = TxtTotalServicio.Text

        End With

        Me.Dispose()

    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged

    End Sub
End Class