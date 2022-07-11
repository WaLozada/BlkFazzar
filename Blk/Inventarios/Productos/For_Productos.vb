Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class For_Productos
    Dim Producto As New Productos()

    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If ChkAutomatico.Checked = False And Trim(TxtCodigo.Text) = "" Then
            ListaErrores.Add("Digite el Codigo del Material(Producto)")
        End If

        If Trim(TxtDescripcion.Text) = "" Then
            ListaErrores.Add("Digite el Nombre del Material(Producto)")
        End If

        If Trim(CmbFamilia.Text) = "" Then
            ListaErrores.Add("Seleccione la Familia a la que pertenece el Material(Producto)")
        End If

        If Trim(CmbUnidad.Text) = "" Then
            ListaErrores.Add("Seleccione la unidad de Medida del Material(Producto)")
        End If

        If Trim(CmbEmpaque.Text) = "" Then
            ListaErrores.Add("Indique la presentación del Material(Producto)")
        End If

        Return ListaErrores

    End Function

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        '************************** Insertar Información a la Base de Datos ************************
        If ChkAutomatico.Checked = True Then
            Producto.Codigo = "" ' Asigno codigo por base de datos
        Else
            Producto.Codigo = Me.TxtCodigo.Text
        End If

        Producto.Descripcion = Me.TxtDescripcion.Text
        Producto.Familia = Trim(Me.CmbFamilia.SelectedValue)
        Producto.Unidad = Trim(Me.CmbUnidad.SelectedValue)
        Producto.Empaque = Me.CmbEmpaque.Text

        Dim Respuesta = Producto.GuardarProducto()

        If Respuesta = "OK" Then
            MsgBox("Producto Creado exitosamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        Else
            If Val(Respuesta) > 0 Then
                MsgBox("El Producto que desea Ingresar ya existe para el código " & Trim(Respuesta), MsgBoxStyle.Critical, Gl_NomCompañia)
            Else
                MsgBox("El Código que desea Ingresar ya existe para el producto " & Trim(Respuesta), MsgBoxStyle.Critical, Gl_NomCompañia)
            End If

        End If

        '**************************************************************************************

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

        '************************** Insertar Información a la Base de Datos ************************
        Producto.IdProducto = Me.TxtIdProducto.Text
        Producto.Codigo = Me.TxtCodigo.Text
        Producto.Descripcion = Me.TxtDescripcion.Text
        Producto.Familia = Trim(Me.CmbFamilia.SelectedValue)
        Producto.Unidad = Trim(Me.CmbUnidad.SelectedValue)
        Producto.Empaque = Me.CmbEmpaque.Text

        Dim Respuesta = Producto.ActualizarProducto()

        If Respuesta = True Then
            MsgBox("Producto Actualizado Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
        Else
            MsgBox("No fue posible Actualizar el Producto. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        Me.Dispose()

        '**************************************************************************************
    End Sub

    Private Sub TxtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtDescripcion.Focus()
        End If

    End Sub
    Private Sub TxtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmbFamilia.Focus()
        End If
    End Sub
    Private Sub CmbFamilia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFamilia.SelectedIndexChanged
        CmbUnidad.Focus()
    End Sub

    Private Sub CmbEmpaque_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEmpaque.SelectedIndexChanged
        If BtnAdicionar.Visible = True Then
            BtnAdicionar.Focus()
        Else
            BtnActualizar.Focus()
        End If
    End Sub

    Private Sub For_Productos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub TxtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TxtDescripcion.TextChanged


        With DGProductos

            DGProductos.DataSource = Producto.CoincideNombreProducto(TxtDescripcion.Text) ' Trae los resultados

            Dim FontCabecera As New Font(.ColumnHeadersDefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle.Font = FontCabecera

            Dim Font As New Font(.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
            .DefaultCellStyle.Font = Font

            .Columns("IDPRODUCTO").Visible = False
            .Columns("SIMBOLO").Visible = False
            .Columns("ID").Visible = False

        End With

    End Sub

    Private Sub For_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ChkAutomatico_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAutomatico.CheckedChanged
        If ChkAutomatico.Checked = False Then
            TxtCodigo.Enabled = True
        Else
            TxtCodigo.Enabled = False
        End If
    End Sub
End Class