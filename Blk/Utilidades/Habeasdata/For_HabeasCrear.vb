Public Class For_HabeasCrear
    Dim Habeasdata As New Cls_Habeasdata
    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If Trim(TxtDocumento.Text) = "" Then
            ListaErrores.Add("- Digite el Número de Documento")
        End If

        If Trim(TxtNombre.Text) = "" Then
            ListaErrores.Add("- Digite el Nombre del Solicitante")
        End If

        If Trim(TxtApell.Text) = "" Then
            ListaErrores.Add("- Digite los Apellidos del Solicitante")
        End If

        If Trim(TxtSolicitud.Text) = "" Then
            ListaErrores.Add("- Digite la solicitud")
        End If

        If Trim(CmbMedio.Text) = "" Then
            ListaErrores.Add("- Seleccione el Medio por el cual llego la solicitud")
        End If

        If DTFechaSol.Text > Date.Now Then
            ListaErrores.Add("- La fecha de la Solicitud no puede ser mayor a hoy!")
        End If

        Return ListaErrores

    End Function
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
            TxtApell.Focus()
        Else
            Dim Rta As Boolean
            Rta = Sololetras(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub CmbUbicacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbMedio.KeyPress
        e.Handled = True
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

        Dim FechaSolicitud = DTFechaSol.Value

        Habeasdata.Tdoc = CmbTdoc.Text
        Habeasdata.Documento = Trim(TxtDocumento.Text)
        Habeasdata.Nom_Solicitante = Trim(TxtNombre.Text)
        Habeasdata.Apel_Solicitante = Trim(TxtApell.Text)
        Habeasdata.Medio = Trim(CmbMedio.Text)
        Habeasdata.Fecha_Solicitud = Format(FechaSolicitud, "yyyy-MM-dd")
        Habeasdata.Solicitud = Trim(TxtSolicitud.Text)
        Habeasdata.Estado = "Reclamo en Tramite"

        Dim Respuesta As String
        Respuesta = Habeasdata.GuardarSolicitud()

        If Respuesta = True Then
            MsgBox("Solicitud Registrada Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)

            Me.Dispose()
        Else
            MsgBox("Ocurrio un error en el proceso de creación, Por favor consulte con el administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

    End Sub
    Private Sub For_HabeasCrear_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub For_HabeasCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTFechaSol.Text = Date.Now
    End Sub
End Class