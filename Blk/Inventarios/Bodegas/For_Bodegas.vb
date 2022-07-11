Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class For_Bodegas

    Dim Bodega As New Bodegas()
    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If Trim(Me.TxtBodega.Text) = "" Then
            ListaErrores.Add("Digite el Nombre de Identificación de la Bodega")
        End If

        If Trim(Me.TxtCapacidad.Text) = "" Then
            ListaErrores.Add("Digite la Capacidad de Almacenamiento de la Bodega")
        End If

        If Trim(Me.CmbCentros.Text) = "" Then
            ListaErrores.Add("Seleccione el Centro(CEDIS) al cual estará asociada la Bodega")
        End If

        If Trim(Me.TxtDireccion.Text) = "" Then
            ListaErrores.Add("Digite la Dirección de la Bodega")
        End If

        If Trim(Me.TxtPais.Text) = "" Then
            ListaErrores.Add("Indique la Ubicación de la Bodega")
        End If


        Return ListaErrores

    End Function

    Private Sub TxtBodega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBodega.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtCapacidad.Focus()
        End If
    End Sub
    Private Sub TxtCapacidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCapacidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmbCentros.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub CmbCentros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCentros.SelectedIndexChanged
        CmbEstado.Focus()
    End Sub
    Private Sub CmbCentros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCentros.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEstado.SelectedIndexChanged
        TxtDireccion.Focus()
    End Sub
    Private Sub CmbEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEstado.KeyPress
        e.Handled = True
    End Sub
    Private Sub TxtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnCrear.Focus()
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Gl_Divipolitica.Pais = ""
        Gl_Divipolitica.NombreDepto = ""
        Gl_Divipolitica.CodigoPoblado = ""
        Gl_Divipolitica.NombreMunicipio = ""

        For_Divipoliticas.ShowDialog()

        Me.TxtPais.Text = Gl_Divipolitica.Pais
        Me.TxtDepto.Text = Gl_Divipolitica.NombreDepto
        Me.TxtDivipol.Text = Gl_Divipolitica.CodigoPoblado
        Me.TxtMunicipio.Text = Gl_Divipolitica.NombreMunicipio

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
        Bodega.Descripcion = Me.TxtBodega.Text
        Bodega.Capacidad = Me.TxtCapacidad.Text
        Bodega.Centro = Trim(Me.CmbCentros.SelectedValue)
        Bodega.Direccion = Me.TxtDireccion.Text
        Bodega.Estado = Trim(Me.CmbEstado.SelectedValue)
        Bodega.Divipol = Me.TxtDivipol.Text

        Dim Respuesta = Bodega.GuardarBodega()

        If Respuesta = True Then
            MsgBox("Bodega Creada Exitosamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        Else
            MsgBox("No fue posible crear la Bodega. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
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

        '************************** ACTUALIZAR INFORMACION DE LA BD **************************************
        Bodega.Codigo = TxtCodigo.Text
        Bodega.Descripcion = Me.TxtBodega.Text
        Bodega.Capacidad = Me.TxtCapacidad.Text
        Bodega.Centro = Trim(Me.CmbCentros.SelectedValue)
        Bodega.Direccion = Me.TxtDireccion.Text
        Bodega.Estado = Trim(Me.CmbEstado.SelectedValue)
        Bodega.Divipol = Me.TxtDivipol.Text

        Dim Respuesta = Bodega.ActualizarBodega()

        If Respuesta = True Then
            MsgBox("Bodega Actualizada Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        Else
            MsgBox("No fue posible crear la Bodega. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        '****************************************************************************************
    End Sub
    Private Sub For_Bodegas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

End Class