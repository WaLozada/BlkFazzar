Public Class For_EquiposModelos
    Dim Activos As New ActivosTI()
    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click


        If TxtModelo.Text = "" Then
            MsgBox("Digite el nombre del Modelo que desea adicionar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Activos.Marca = LblMarca.Tag
        Activos.Tipo = LblTipo.Tag
        Activos.Modelo = Trim(TxtModelo.Text)

        Dim Respuesta = Activos.GuardarModelo(Activos.Modelo)

        If Respuesta = True Then
            MsgBox("Modelo Adicionado Correctamente. Seleccione de Nuevo la marca para listar el nuevo modelo", MsgBoxStyle.Information, Gl_NomCompañia)
        Else
            MsgBox("No fue Posible Registrar el nuevo modelo. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        Me.Dispose()

        '-----------------------------------------------------------

        Me.Dispose()

    End Sub
End Class