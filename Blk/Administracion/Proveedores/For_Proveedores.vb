Imports System.ComponentModel

Public Class For_Proveedores
    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

        Dim Proveedor As New Proveedores()

        If Trim(TxtProveedor.Text) = "" Then
            MsgBox("Ingreso el Nombre Completo del Proveedor!", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtProveedor.Focus()
            Exit Sub
        End If

        Dim Rta As String = Proveedor.GuardarProveedor(Trim(TxtProveedor.Text))

        If Rta = True Then
            MsgBox("El proveedor se Agrego Correctamente.", MsgBoxStyle.Information, Gl_NomCompañia)
            Proveedor.Cargareldataset()
            Me.Dispose()
        End If


    End Sub
    Private Sub For_Proveedores_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class