Imports System.ComponentModel

Public Class For_Depositos
    Dim Deposito As New Depositos()
    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If Trim(Me.CmbCentros.Text) = "" Then
            ListaErrores.Add("Seleccione el Centro Asociado al Deposito!")
        End If

        If Trim(Me.CmbBodegas.Text) = "" Then
            ListaErrores.Add("Seleccione la Bodega Asociada al Deposito!")
        End If

        If Trim(Me.TxtCodCliente.Text) = "" Then
            ListaErrores.Add("Seleccione el Cliente Correspondiente al Deposito!")
        End If

        If Trim(Me.CmbEstado.Text) = "" Then
            ListaErrores.Add("Indique el Estado actual del Deposito!")
        End If

        Return ListaErrores

    End Function

    Private Sub CmbCentros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCentros.SelectedIndexChanged

        CmbCentros.Text = Trim(CmbCentros.Text)
        Deposito.CargarBodegas(CmbCentros.SelectedValue)
        CmbBodegas.Focus()

    End Sub
    Private Sub CmbCentros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCentros.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbBodegas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBodegas.SelectedIndexChanged
        CmbBodegas.Text = Trim(CmbBodegas.Text)
        BtnBuscar.Focus()
    End Sub
    Private Sub CmbBodegas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbBodegas.KeyPress
        e.Handled = True
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Gl_Cliente.Cargareldataset() ' Cargo los Clientes Actuales en el Dataset Global

        For_ClientesBuscar.ShowDialog()

        Me.TxtCodCliente.Text = Gl_Cliente.Codigo
        Me.LblNombreCliente.Text = Gl_Cliente.Cliente


    End Sub
    Private Sub CmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEstado.SelectedIndexChanged

        If BtnCrear.Visible = True Then
            BtnCrear.Focus()
        Else
            BtnActualizar.Focus()
        End If

    End Sub
    Private Sub CmbEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEstado.KeyPress
        e.Handled = True
    End Sub
    Private Sub For_Depositos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click

        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        '************************** INSERTAR INFORMACION A LA BD **************************************

        Deposito.CodigoCentro = Trim(Me.CmbCentros.SelectedValue)
        Deposito.CodigoBodega = Trim(Me.CmbBodegas.SelectedValue)
        Deposito.CodigoCliente = Trim(Me.TxtCodCliente.Text)
        Deposito.Estado = Trim(Me.CmbEstado.SelectedValue)
        Deposito.Visible = 1

        Dim Respuesta = Deposito.GuardarDeposito()

        If Respuesta = True Then
            MsgBox("Deposito Creado Exitosamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        Else
            MsgBox("No fue posible crear el Deposito. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        '****************************************************************************************


    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        '************************** INSERTAR INFORMACION A LA BD **************************************

        Deposito.Codigo = Trim(Me.TxtCodigo.Text)
        Deposito.CodigoCentro = Trim(Me.CmbCentros.SelectedValue)
        Deposito.CodigoBodega = Trim(Me.CmbBodegas.SelectedValue)
        Deposito.CodigoCliente = Trim(Me.TxtCodCliente.Text)
        Deposito.Estado = Trim(Me.CmbEstado.SelectedValue)

        Dim Respuesta = Deposito.ActualizarDeposito()

        If Respuesta = True Then
            MsgBox("Deposito Actualizado Exitosamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        Else
            MsgBox("No fue posible Actualizar el Deposito. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        '****************************************************************************************

    End Sub

    Private Sub For_Depositos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class