Imports System.Data.SqlClient

Public Class For_CeCoClientesCrear
    Dim CentroCosto As New CentroCostos()

    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If Trim(CmbTerminales.Text) = "" Then
            ListaErrores.Add("Seleccione la Terminal a la cual pertenece!")
        End If

        If Trim(CmbSegmentos.Text) = "" Then
            ListaErrores.Add("- Seleccione el Segmento al que pertenece!")
        End If

        If Trim(TxtCliente.Text) = "" Then
            ListaErrores.Add("- Digite el Nombre del Cliente")
        End If

        If Trim(TxtCeco.Text) = "" Then
            ListaErrores.Add("- indique el codigo de Centro de Costo Asociado")
        End If

        Return ListaErrores

    End Function
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

    Private Sub CmbSegmentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSegmentos.SelectedIndexChanged

        TxtCliente.Focus()

    End Sub

    Private Sub CmbSegmentos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbSegmentos.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbTerminales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTerminales.SelectedIndexChanged
        CmbSegmentos.Focus()
    End Sub

    Private Sub CmbTerminales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTerminales.KeyPress
        e.Handled = True
    End Sub
    Private Sub TxtCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCliente.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TxtCeco.Focus()
        End If

    End Sub

    Private Sub For_CeCoClientesCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCombos()

    End Sub

    Private Sub CmbTerminales_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbTerminales.SelectionChangeCommitted

        Try

            '-------------------- Cargo los Segmentos -------------
            Dim Tabla As New DataTable
            Dim Consulta2 As SqlDataReader
            Consulta2 = CentroCosto.ListarCentros(3, CmbTerminales.SelectedValue)

            Tabla.Load(Consulta2)

            Me.CmbSegmentos.DisplayMember = "SEGMENTO"
            Me.CmbSegmentos.ValueMember = "IDSEGMENTO"
            Me.CmbSegmentos.DataSource = Tabla
            Me.CmbSegmentos.Text = ""

            '-----------------------------------------------------
            TxtCeco.Text = ""


            Consulta2.Close()

        Catch ex As Exception

        End Try

        CmbSegmentos.Focus()
    End Sub

    Private Sub For_CeCoClientesCrear_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub BtnCrearCliente_Click(sender As Object, e As EventArgs) Handles BtnCrearCliente.Click

        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Try

            CentroCosto.Terminal = CmbTerminales.SelectedValue
            CentroCosto.Segmento = CmbSegmentos.SelectedValue
            CentroCosto.Nombre = Trim(UCase(TxtCliente.Text))
            CentroCosto.Sigla = Trim(UCase(TxtCeco.Text))

            Dim Respuesta = CentroCosto.GuardarCliente()

            If Respuesta = "OK" Then
                MsgBox("Cliente Registrado Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
                Me.Dispose()
            Else
                MsgBox(Respuesta, MsgBoxStyle.Critical, Gl_NomCompañia)
            End If

        Catch ex As Exception

        End Try

        '-----------------------------------------------------------


    End Sub
End Class