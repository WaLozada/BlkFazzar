Imports System.Data.SqlClient

Public Class For_EquiposRepuestos
    Sub CargarCombos()


        If Gl_DataSet.Tables.Contains("TActivosRepuestos") Then
            ' El dataTable ya fue cargado.
        Else
            '-------- Cargo Listado de Repuestos para ActivosTI -----------------
            Dim Sql = "select * from Gen_ActivosRepuestos"
            Dim da As New SqlDataAdapter(Sql, Conn)
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()

            Try
                da.Fill(Gl_DataSet, "TActivosRepuestos")
            Catch ex As Exception
            End Try
            '-----------------------------------------------------

        End If

        '-------------- Cargo Los Repuestos ---------------------
        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TActivosRepuestos")

        Me.CmbRepuestos.DisplayMember = "REPUESTO"
        Me.CmbRepuestos.ValueMember = "IDREPUESTO"
        Me.CmbRepuestos.DataSource = dv
        Me.CmbRepuestos.Text = ""
        Me.CmbRepuestos.Text = ""
        '-----------------------------------------------------


    End Sub
    Private Sub CmbRepuestos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRepuestos.SelectedIndexChanged
        TxtCosto.Focus()
    End Sub

    Private Sub CmbRepuestos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbRepuestos.KeyPress
        e.Handled = True
    End Sub
    Private Sub TxtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCosto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtDescripcion.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtCosto_LostFocus(sender As Object, e As EventArgs) Handles TxtCosto.LostFocus
        Try
            If TxtCosto.Text = "" Then
                TxtCosto.Text = "$ 0"
            Else
                TxtCosto.Text = FormatCurrency(TxtCosto.Text, 0)
            End If

        Catch ex As Exception
        End Try
    End Sub



    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

        If CmbRepuestos.Text = "" Then
            MsgBox("Seleccione el Respuesto Utilizado", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbRepuestos.Focus()
            Exit Sub
        End If

        If Trim(TxtDescripcion.Text) = "" Then
            MsgBox("Agregue una breve descripción del repuesto utilizado.", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtDescripcion.Focus()
            Exit Sub
        End If

        DGRepuestos.Rows.Add(CmbRepuestos.SelectedValue, CmbRepuestos.Text, TxtCosto.Text, CType(TxtCosto.Text, Decimal), TxtDescripcion.Text)
        CmbRepuestos.Text = ""
        TxtCosto.Text = "$ 0"
        TxtDescripcion.Text = ""

    End Sub

    Private Sub For_EquiposRepuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()

    End Sub
    Private Sub TxtCosto_GotFocus(sender As Object, e As EventArgs) Handles TxtCosto.GotFocus
        Try
            If TxtCosto.Text = "$ 0" Then
                TxtCosto.Text = ""
            Else
                TxtCosto.Text = CType(TxtCosto.Text, Decimal)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub For_EquiposRepuestos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If DGRepuestos.Rows.Count = 0 Then
            MsgBox("Ningún Repuesto para guardar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        For_EquiposMantenimiento.DGRepuestos.Rows.Clear() ' Limpio el Datagrid del formulario principal para enviar los datos de los repuestos.

        For i = 0 To DGRepuestos.Rows.Count - 1

            For_EquiposMantenimiento.DGRepuestos.Rows.Add(DGRepuestos.Rows(i).Cells(0).Value, DGRepuestos.Rows(i).Cells(1).Value, DGRepuestos.Rows(i).Cells(2).Value, DGRepuestos.Rows(i).Cells(3).Value, DGRepuestos.Rows(i).Cells(4).Value)
        Next

        MsgBox("Repuestos Registrados Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
        Me.Dispose()

    End Sub
End Class