Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class For_Clientes
    Dim Cliente As New Clientes()
    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If Trim(TxtDocumento.Text) = "" Then
            ListaErrores.Add("Digite el Número de Identificación del Cliente")
        End If

        If Trim(TxtCliente.Text) = "" Then
            ListaErrores.Add("Digite el Nombre del Cliente")
        End If

        If Trim(TxtDireccion.Text) = "" Then
            ListaErrores.Add("Digite la Dirección del Cliente")
        End If

        If Trim(TxtTelefono.Text) = "" Then
            ListaErrores.Add("Digite el Teléfono del Cliente")
        End If

        If Trim(TxtNombContacto.Text) = "" Then
            ListaErrores.Add("Digite el Nombre de la persona de contacto")
        End If

        If Trim(TxtApelContacto.Text) = "" Then
            ListaErrores.Add("Digite el Apellido de la persona de contacto")
        End If

        If Trim(TxtCelular.Text) = "" Then
            ListaErrores.Add("Digite el Celular del Contacto")
        End If

        If Trim(TxtCorreo.Text) = "" Then
            ListaErrores.Add("Digite el Correo Electrónico del Centro")
        End If

        If Trim(TxtPais.Text) = "" Then
            ListaErrores.Add("Establezca la Ubicación del Cliente")
        End If

        Return ListaErrores

    End Function

    Private Sub CmbTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTipo.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipo.SelectedIndexChanged

        If CmbTipo.Text = "PERSONA JURIDICA" Then
            CmbTdoc.Items.Clear()
            CmbTdoc.Text = "NT"
        Else
            CmbTdoc.Items.Clear()
            CmbTdoc.Text = "CC"
            CmbTdoc.Items.Add("CC")
            CmbTdoc.Items.Add("CE")
            CmbTdoc.Items.Add("PP")
        End If

        TxtDocumento.Focus()

    End Sub
    Private Sub CmbTdoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTdoc.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbTdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTdoc.SelectedIndexChanged
        TxtDocumento.Focus()
    End Sub
    Private Sub TxtDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDocumento.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TxtCliente.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtDireccion.Focus()
        End If
    End Sub
    Private Sub TxtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtTelefono.Focus()
        End If
    End Sub
    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtNombContacto.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtNombContacto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombContacto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtApelContacto.Focus()
        End If
    End Sub
    Private Sub TxtApelContacto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApelContacto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtCelular.Focus()
        End If
    End Sub
    Private Sub TxtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCelular.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtCorreo.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtCorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCorreo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnBuscar.Focus()
        End If
    End Sub
    Private Sub CmbEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbEstado.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEstado.SelectedIndexChanged
        BtnBuscar.Focus()
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Gl_Divipolitica.Pais = ""
        Gl_Divipolitica.NombreDepto = ""
        Gl_Divipolitica.NombreMunicipio = ""
        Gl_Divipolitica.CodigoPoblado = ""


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
        Cliente.Tdoc = Me.CmbTdoc.Text
        Cliente.Documento = Me.TxtDocumento.Text
        Cliente.Cliente = Me.TxtCliente.Text
        Cliente.Direccion = Me.TxtDireccion.Text
        Cliente.Telefono = Me.TxtTelefono.Text
        Cliente.Tipo = Trim(Me.CmbTipo.SelectedValue)
        Cliente.NombContacto = Me.TxtNombContacto.Text
        Cliente.ApelContacto = Me.TxtApelContacto.Text
        Cliente.Celular = Me.TxtCelular.Text
        Cliente.Correo = Me.TxtCorreo.Text
        Cliente.Divipol = Me.TxtDivipol.Text
        Cliente.Estado = Trim(Me.CmbEstado.SelectedValue)

        Dim Respuesta = Cliente.GuardarCliente()

        If Respuesta = True Then
            MsgBox("Cliente Creado Exitosamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        Else
            MsgBox("No fue posible crear el Cliente. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        '**********************************************************************************************

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
        Cliente.Codigo = Me.TxtCodigo.Text
        Cliente.Tdoc = Me.CmbTdoc.Text
        Cliente.Documento = Me.TxtDocumento.Text
        Cliente.Cliente = Me.TxtCliente.Text
        Cliente.Direccion = Me.TxtDireccion.Text
        Cliente.Telefono = Me.TxtTelefono.Text
        Cliente.Tipo = Trim(Me.CmbTipo.SelectedValue)
        Cliente.NombContacto = Me.TxtNombContacto.Text
        Cliente.ApelContacto = Me.TxtApelContacto.Text
        Cliente.Celular = Me.TxtCelular.Text
        Cliente.Correo = Me.TxtCorreo.Text
        Cliente.Divipol = Me.TxtDivipol.Text
        Cliente.Estado = Trim(Me.CmbEstado.SelectedValue)

        Dim Respuesta = Cliente.ActualizarCliente()

        If Respuesta = True Then
            MsgBox("Cliente Actualizado Exitosamente!", MsgBoxStyle.Information, Gl_NomCompañia)
        Else
            MsgBox("No fue Posible Actualizar el Cliente. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Me.Dispose()

        '**********************************************************************************************

    End Sub
    Private Sub For_Clientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

End Class