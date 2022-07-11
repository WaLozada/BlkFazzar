Imports System.ComponentModel

Public Class For_Centros
    Dim Centro As New Centros()
    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If Trim(TxtCentro.Text) = "" Then
            ListaErrores.Add("Digite el Nombre del Centro")
        End If

        If Trim(TxtDireccion.Text) = "" Then
            ListaErrores.Add("Digite la Dirección del Centro!")
        End If

        If Trim(TxtCorreo.Text) = "" Then
            ListaErrores.Add("Digite el Correo Electrónico del Centro")
        End If

        If Trim(TxtCelular.Text) = "" Then
            ListaErrores.Add("Digite el Teléfono del Centro")
        End If

        If Trim(CmbMuelles.Text) = "" Then
            ListaErrores.Add("Seleccione la Cantidad de Muelles del Centro")
        End If

        If Trim(TxtNombResponsable.Text) = "" Then
            ListaErrores.Add("Establezca el Responsable del Centro")
        End If

        If Trim(TxtPais.Text) = "" Then
            ListaErrores.Add("Establezca la Ubicación del Centro")
        End If

        Return ListaErrores

    End Function
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
        Centro.Nombre = Me.TxtCentro.Text
        Centro.Direccion = Me.TxtDireccion.Text
        Centro.Correo = Me.TxtCorreo.Text
        Centro.Telefono = Me.TxtCelular.Text
        Centro.Muelles = Me.CmbMuelles.Text
        Centro.NombreResponsable = Me.TxtNombResponsable.Text
        Centro.ApellidoResponsable = Me.TxtApelResponsable.Text
        Centro.Divipol = Me.TxtDivipol.Text

        Dim Respuesta = Centro.GuardarCentro()

        If Respuesta = True Then
            MsgBox("Centro Creado exitosamente!", MsgBoxStyle.Information, Gl_NomCompañia)
        Else
            MsgBox("No fue posible crear el centro. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        Me.Dispose()

        '**********************************************************************************************

    End Sub
    Private Sub TxtCentro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCentro.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TxtDireccion.Focus()
        End If

    End Sub
    Private Sub TxtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtCorreo.Focus()
        End If
    End Sub
    Private Sub TxtCorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCorreo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmbMuelles.Focus()
        End If
    End Sub
    Private Sub TxtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCelular.KeyPress

        If Asc(e.KeyChar) = 13 Then
            CmbMuelles.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If

    End Sub
    Private Sub CmbMuelles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMuelles.SelectedIndexChanged
        BtnBuscar1.Focus()
    End Sub
    Private Sub CmbMuelles_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbMuelles.KeyPress
        Dim Rta As Boolean
        Rta = SoloNumeros(e.KeyChar)
        e.Handled = Rta
    End Sub
    Private Sub BtnBuscar2_Click(sender As Object, e As EventArgs) Handles BtnBuscar2.Click

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

        '************************** ACTUALIZAR INFO EN LA BD **************************************

        Centro.Codigo = Me.TxtCodigo.Text
        Centro.Nombre = Me.TxtCentro.Text
        Centro.Direccion = Me.TxtDireccion.Text
        Centro.Correo = Me.TxtCorreo.Text
        Centro.Telefono = Me.TxtCelular.Text
        Centro.Muelles = Me.CmbMuelles.Text
        Centro.NombreResponsable = Me.TxtNombResponsable.Text
        Centro.ApellidoResponsable = Me.TxtApelResponsable.Text
        Centro.Divipol = Me.TxtDivipol.Text

        Dim Respuesta = Centro.ActualizarCentro()

        If Respuesta = True Then
            MsgBox("Centro Actualizado exitosamente!", MsgBoxStyle.Information, Gl_NomCompañia)
        Else
            MsgBox("No fue posible Actualizar el centro. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Me.Dispose()

        '**********************************************************************************************

    End Sub
    Private Sub For_Centros_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

End Class