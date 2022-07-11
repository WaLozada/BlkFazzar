Public Class For_ProductosTransporteCrear
    Dim Productos As New Productos()
    Private Sub For_ProductosTransporteCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub BtnProducto_Click(sender As Object, e As EventArgs) Handles BtnProducto.Click

        If Trim(TxtProducto.Text) = "" Then
            MsgBox("Digite el Nombre del Producto!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If


        Try

            Productos.Descripcion = Trim(TxtProducto.Text)

            Dim Respuesta = Productos.GuardarProductoTransporte()

            If Respuesta = "OK" Then
                MsgBox("Producto Registrado Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
                Me.Dispose()
            Else
                MsgBox(Respuesta, MsgBoxStyle.Critical, Gl_NomCompañia)
            End If

        Catch ex As Exception

        End Try



    End Sub
End Class