Public Class For_UsuariosCrear
    Dim Usuario As New Usuarios()
    Sub CargarCombo()

        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TRol")

        Me.CmbRol.DisplayMember = "ROL"
        Me.CmbRol.ValueMember = "IDROL"
        Me.CmbRol.DataSource = dv

        Dim dv1 As New DataView

        dv1.Table = Gl_DataSet.Tables("TAreas")

        Me.CmbArea.DisplayMember = "AREA"
        Me.CmbArea.ValueMember = "IDAREA"
        Me.CmbArea.DataSource = dv1

        Dim dv2 As New DataView

        dv2.Table = Gl_DataSet.Tables("TUbicaciones")

        Me.CmbUbicacion.DisplayMember = "UBICACION"
        Me.CmbUbicacion.ValueMember = "IDUBICACION"
        Me.CmbUbicacion.DataSource = dv2


    End Sub
    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If Trim(TxtDocumento.Text) = "" Then
            ListaErrores.Add("- Digite el Número de Documento")
        End If

        If Trim(TxtNombre.Text) = "" Then
            ListaErrores.Add("- Digite el Nombre del Usuario")
        End If

        If Trim(TxtPapell.Text) = "" Then
            ListaErrores.Add("- Digite el Primer Apellido")
        End If

        If Trim(TxtDireccion.Text) = "" Then
            ListaErrores.Add("- Digite la direccion de Residencia")
        End If

        If Trim(TxtCelular.Text) = "" Then
            ListaErrores.Add("- Digite el Número de Celular")
        End If

        If Trim(CmbRol.Text) = "" Then
            ListaErrores.Add("- Seleccione el Rol")
        End If

        If Trim(TxtClave.Text) = "" Then
            ListaErrores.Add("- Digite la Clave de Acceso")
        End If

        If Trim(CmbArea.Text) = "" Then
            ListaErrores.Add("- Seleccione el Area a la Cual Pertenece")
        End If

        If Trim(CmbUbicacion.Text) = "" Then
            ListaErrores.Add("- Selecione la Ubicacion")
        End If

        Return ListaErrores

    End Function
    Private Sub CmbTdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTdoc.SelectedIndexChanged
        TxtDocumento.Focus()
    End Sub
    Private Sub TxtDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDocumento.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtNombre.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtPapell.Focus()
        Else
            Dim Rta As Boolean
            Rta = Sololetras(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtPapell_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPapell.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtSapell.Focus()
        Else
            Dim Rta As Boolean
            Rta = Sololetras(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtSapell_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSapell.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DTFechaNac.Focus()
        Else
            Dim Rta As Boolean
            Rta = Sololetras(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub DTFechaNac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DTFechaNac.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtDireccion.Focus()
        End If
    End Sub
    Private Sub TxtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtEmail.Focus()
        End If
    End Sub
    Private Sub TxtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEmail.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtCelular.Focus()
        End If
    End Sub
    Private Sub TxtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCelular.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmbRol.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub CmbRol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRol.SelectedIndexChanged
        TxtClave.Focus()
    End Sub
    Private Sub RBInactivo_CheckedChanged(sender As Object, e As EventArgs) Handles RBInactivo.CheckedChanged
        TxtClave.Focus()
    End Sub
    Private Sub RBActivo_CheckedChanged(sender As Object, e As EventArgs) Handles RBActivo.CheckedChanged
        TxtClave.Focus()
    End Sub
    Private Sub RBIndefinido_CheckedChanged(sender As Object, e As EventArgs) Handles RBIndefinido.CheckedChanged
        CmbArea.Focus()
    End Sub
    Private Sub RBVence_CheckedChanged(sender As Object, e As EventArgs) Handles RBVence.CheckedChanged
        DTVigencia.Focus()
    End Sub
    Private Sub DTVigencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DTVigencia.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmbArea.Focus()
        Else
            Dim Rta As Boolean
            Rta = Sololetras(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub CmbArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbArea.SelectedIndexChanged
        CmbUbicacion.Focus()
    End Sub
    Private Sub CmbUbicacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUbicacion.SelectedIndexChanged
        If BtnCrear.Visible = True Then
            BtnCrear.Focus()
        Else
            BtnEditar.Focus()
        End If
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

        Usuario.Tdoc = CmbTdoc.Text
        Usuario.Documento = Trim(TxtDocumento.Text)
        Usuario.Nombre = Trim(TxtNombre.Text)
        Usuario.Papellido = Trim(TxtPapell.Text)
        Usuario.Sapellido = Trim(TxtSapell.Text)
        Usuario.FechaNac = DTFechaNac.Value
        Usuario.Direccion = Trim(TxtDireccion.Text)
        Usuario.Email = Trim(TxtEmail.Text)
        Usuario.Celular = Trim(TxtCelular.Text)
        Usuario.Rol = CmbRol.SelectedValue
        If RBActivo.Checked = True Then
            Usuario.Estado = 1
        Else
            Usuario.Estado = 0
        End If
        Usuario.Clave = SeguridadBlk.EncryptStr(Trim(TxtClave.Text), GL_ClaveEncrip)
        Usuario.FechaClave = Date.Today.AddDays(90) ' cambio de Clave a los 90 dias
        If RBIndefinido.Checked = True Then
            Usuario.Caducidad = 1
            Usuario.Vigencia = "2999/12/31"
        Else
            Usuario.Caducidad = 0
            Usuario.Vigencia = DTVigencia.Value
        End If
        Usuario.Area = CmbArea.SelectedValue
        Usuario.Ubicacion = CmbUbicacion.SelectedValue

        Dim TempParidad As String

        TempParidad = SeguridadBlk.SHA1(Trim(TxtNombre.Text) & "@" & Trim(TxtDocumento.Text) & "@" & Trim(TxtPapell.Text) & "@" & SeguridadBlk.EncryptStr(Trim(TxtClave.Text), GL_ClaveEncrip))
        Usuario.Paridad = TempParidad

        Dim Respuesta As String
        Respuesta = Usuario.GuardarUsuario()

        If Respuesta = True Then
            MsgBox("Usuario Creado Exitosamente!", MsgBoxStyle.Information, Gl_NomCompañia)

            BtnEditar.Visible = True
            BtnCrear.Visible = False
            Me.Dispose()
        Else
            MsgBox("Ocurrio un error en el proceso de creación, Por favor consulte con el administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If


    End Sub
    Private Sub For_UsuariosCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        'Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        'Me.Width = Ventanas.Ancho
        '----------------------------------
        CargarCombo()
    End Sub
    Private Sub CmbRol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbRol.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbArea.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbUbicacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbUbicacion.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbTdoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTdoc.KeyPress
        e.Handled = True
    End Sub
    Private Sub For_UsuariosCrear_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class