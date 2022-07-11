Imports System.Data.SqlClient

Public Class For_BitacoraOtrosCobros
    Dim Despachos As New ClsTransporte()
    Dim Suma As Decimal = 0

    Sub CargarCombos()

        '-------------------- Cargo los Transportadores ------
        Dim Tabla1 As New DataTable
        Dim Consulta1 As SqlDataReader
        Consulta1 = Despachos.ListarCobros()

        Tabla1.Load(Consulta1)

        Me.CmbConcepto.DisplayMember = "DESCRIPCION"
        Me.CmbConcepto.ValueMember = "IDCOBRO"
        Me.CmbConcepto.DataSource = Tabla1
        Me.CmbConcepto.Text = ""

        '-----------------------------------------------------


        If For_RegistroTransporte.DGCobros.Rows.Count > 0 Then

            DGCobros.Rows.Clear()

            For i As Integer = 0 To For_RegistroTransporte.DGCobros.Rows.Count - 1
                DGCobros.Rows.Add(For_RegistroTransporte.DGCobros.Rows(i).Cells(0).Value, For_RegistroTransporte.DGCobros.Rows(i).Cells(1).Value, For_RegistroTransporte.DGCobros.Rows(i).Cells(2).Value, For_RegistroTransporte.DGCobros.Rows(i).Cells(3).Value)
            Next

            Suma = For_RegistroTransporte.TxtOtrosCobros.Tag
            TxtValorTotal.Tag = Suma
            TxtValorTotal.Text = FormatCurrency(TxtValorTotal.Tag, 0)

        End If

        DGCobros.Columns("IDCOBRO").Visible = False
        DGCobros.Columns("IDDESPACHO").Visible = False

    End Sub
    Private Sub For_BitacoraOtrosCobros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCombos()


    End Sub

    Private Sub CmbConcepto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbConcepto.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbConcepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbConcepto.SelectedIndexChanged
        TxtValor.Focus()
    End Sub

    Private Sub TxtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnAdicionar.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtValor_GotFocus(sender As Object, e As EventArgs) Handles TxtValor.GotFocus
        Try
            If TxtValor.Text = "$ 0" Then
                TxtValor.Text = ""
            Else
                TxtValor.Text = CType(TxtValor.Text, Decimal)
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub TxtValor_LostFocus(sender As Object, e As EventArgs) Handles TxtValor.LostFocus
        Try
            If TxtValor.Text = "" Then
                TxtValor.Text = "$ 0"
                TxtValor.Tag = 0
            Else
                TxtValor.Tag = Val(TxtValor.Text)
                TxtValor.Text = FormatCurrency(TxtValor.Tag, 0)
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

        If Trim(CmbConcepto.Text) = "" Then
            MsgBox("Seleccione el Concepto que desea agregar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbConcepto.Focus()
            Exit Sub
        End If

        If Val(TxtValor.Tag) = 0 Then
            MsgBox("Digite el Valor del Concepto seleccionado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtValor.Focus()
            Exit Sub
        End If

        DGCobros.Rows.Add(TxtDespacho.Text, CmbConcepto.SelectedValue, CmbConcepto.Text, TxtValor.Tag)
        Suma += TxtValor.Tag
        TxtValorTotal.Tag = Suma
        TxtValorTotal.Text = FormatCurrency(Suma, 0)


        CmbConcepto.Text = ""
        TxtValor.Text = "$ 0"
        TxtValor.Tag = 0

    End Sub

    Private Sub For_BitacoraOtrosCobros_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub DGCobros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCobros.CellClick

        If BtnGuardar.Enabled = False Then
            Exit Sub
        End If


        Try
            Dim Rta = MsgBox("Desea Eliminar el costo seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

            If Rta = MsgBoxResult.Yes Then

                Suma -= DGCobros.Rows(e.RowIndex).Cells("VALOR").Value
                TxtValorTotal.Tag = Suma
                TxtValorTotal.Text = FormatCurrency(Suma, 0)

                DGCobros.Rows.RemoveAt(e.RowIndex)

            End If

        Catch ex As Exception

        End Try



    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        '--- Temporalizo los cobros en un datagrid igual en el formulario For_Registrotransporte mientras decide guardar

        If DGCobros.Rows.Count > 0 Then

            For_RegistroTransporte.DGCobros.Rows.Clear()

            For i As Integer = 0 To DGCobros.Rows.Count - 1
                For_RegistroTransporte.DGCobros.Rows.Add(DGCobros.Rows(i).Cells(0).Value, DGCobros.Rows(i).Cells(1).Value, DGCobros.Rows(i).Cells(2).Value, DGCobros.Rows(i).Cells(3).Value)
            Next

        End If

        For_RegistroTransporte.TxtOtrosCobros.Tag = TxtValorTotal.Tag
        For_RegistroTransporte.TxtOtrosCobros.Text = FormatCurrency(TxtValorTotal.Tag, 0)

        Me.Dispose()

    End Sub

End Class