Imports System.ComponentModel

Public Class For_ProductoBloqueado
    Sub CargoCombo()
        '-------------- Cargo Los Tipos de Vehiculos ---------
        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TBloqueo")

        Me.CmbMotivo.DisplayMember = "BLOQUEO"
        Me.CmbMotivo.ValueMember = "IDBLOQUEO"
        Me.CmbMotivo.DataSource = dv
        Me.CmbMotivo.Text = ""
        '-----------------------------------------------------

    End Sub
    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmbMotivo.Focus()
        Else
            If Asc(e.KeyChar) = 44 Then
                e.Handled = False
                Exit Sub
            End If
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub

    Private Sub CmbMotivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMotivo.SelectedIndexChanged
        TxtObsDetalle.Focus()
    End Sub

    Private Sub For_ProductoBloqueado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargoCombo()

    End Sub

    Private Sub BtnFoto_Click(sender As Object, e As EventArgs) Handles BtnFoto.Click


        Try
            ODRutaArchivo.FileName = ""
            ODRutaArchivo.Filter = "Imagenes |*.Jpg;*.Jpeg;*.png"

            ODRutaArchivo.ShowDialog()

            If ODRutaArchivo.FileName = "" Then
                MsgBox("No Selecciono Ninguna Imagen!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            End If

            LblRutaArchivoLocal.Text = ODRutaArchivo.FileName

        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

        If TxtCantidad.Text = "" Then
            MsgBox("Indique una Cantidad de Producto bloqueado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtCantidad.Focus()
            Exit Sub
        End If

        If Trim(CmbMotivo.Text) = "" Then
            MsgBox("Indique el Motivo del Bloqueo!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbMotivo.Focus()
            Exit Sub
        End If

        If TxtObsDetalle.Text = "" Then
            MsgBox("Realice una Observación Referente al Bloqueo!", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtObsDetalle.Focus()
            Exit Sub
        End If

        If Val(TxtCantidad.Text) > Val(TxtCantidadProducto.Text) Then
            MsgBox("La Cantidad de Producto a Registrar es Mayor al Total de Producto Bloqueado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtCantidad.Focus()
            Exit Sub
        End If

        '-------------- Validar que con el Producto a adicionar no se supere el total Bloqueado ----------
        Dim Suma As Decimal
        Dim CantidadBloqueado As Decimal = TxtCantidad.Text
        Dim CantidadProducto As Decimal = TxtCantidadProducto.Text

        For i = 0 To DGBloqueo.Rows.Count - 1
            Suma += DGBloqueo.Rows(i).Cells(1).Value
        Next

        If (Suma + CantidadBloqueado) > CantidadProducto Then
            MsgBox("La cantidad de Producto a Registrar Superaría el Total de Producto Bloqueado", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtCantidad.Focus()
            Exit Sub
        End If
        '--------------------------------------------------------------------------------------------------

        DGBloqueo.Rows.Add(TxtCodigoProducto.Text, CantidadBloqueado, LblUnidadDetalle.Text, Trim(CmbMotivo.Text), Trim(TxtObsDetalle.Text), LblRutaArchivoLocal.Text, CmbMotivo.SelectedValue, TxtLote.Text)

        '----- Verfificar si con la Cantidad adicionada se completo el total de producto Bloqueado -------
        Suma = 0

        For i = 0 To DGBloqueo.Rows.Count - 1
            Suma += DGBloqueo.Rows(i).Cells(1).Value
        Next

        If Suma = CantidadProducto Then
            BtnGuardar.Enabled = True
        End If

        '--------------------------------------------------------------------------------------------------

        TxtCantidad.Text = ""
        CmbMotivo.Text = ""
        TxtObsDetalle.Text = ""
        LblRutaArchivoLocal.Text = ""
        TxtCantidad.Focus()


    End Sub

    Private Sub For_ProductoBloqueado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub CmbMotivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbMotivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnFoto.Focus()
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub DGBloqueo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBloqueo.CellClick

        Dim Rta = MsgBox("Desea Eliminar Este Registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

        If Rta = vbYes Then
            DGBloqueo.Rows.RemoveAt(e.RowIndex)
            BtnGuardar.Enabled = False
        End If

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        '------ Si ya lo habia Registrado lo Borro del DG Principal y vuelvo a ingresarlos --------

        For i = 0 To For_IngresoMercancia.DGDetalleBloqueo.Rows.Count - 1

            If (For_IngresoMercancia.DGDetalleBloqueo.Rows(i).Cells(0).Value = Trim(Me.TxtCodigoProducto.Text)) And (For_IngresoMercancia.DGDetalleBloqueo.Rows(i).Cells(7).Value = Trim(Me.TxtLote.Text)) Then
                For_IngresoMercancia.DGDetalleBloqueo.Rows(i).Selected = True
            End If

        Next

        Dim value As DataGridViewSelectedRowCollection
        value = For_IngresoMercancia.DGDetalleBloqueo.SelectedRows

        For Each vfila As DataGridViewRow In value
            For_IngresoMercancia.DGDetalleBloqueo.Rows.Remove(vfila)
        Next

        '-----------------------------------------------------------------------------------------

        '-------------- Ingreso Detalle del Producto Bloqueado al DG Principal --------------------
        For i = 0 To DGBloqueo.Rows.Count - 1
            For_IngresoMercancia.DGDetalleBloqueo.Rows.Add(DGBloqueo.Rows(i).Cells(0).Value, DGBloqueo.Rows(i).Cells(1).Value, DGBloqueo.Rows(i).Cells(2).Value, DGBloqueo.Rows(i).Cells(3).Value, DGBloqueo.Rows(i).Cells(4).Value, DGBloqueo.Rows(i).Cells(5).Value, DGBloqueo.Rows(i).Cells(6).Value, DGBloqueo.Rows(i).Cells(7).Value)
        Next

        For_IngresoMercancia.DGDetalleBloqueo.ClearSelection()

        Me.Dispose()
        '-------------------------------------------------------------------------------------------



    End Sub

End Class