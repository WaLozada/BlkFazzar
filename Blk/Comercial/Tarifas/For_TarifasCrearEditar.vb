Imports System.Data.SqlClient

Public Class For_TarifasCrearEditar
    Dim Comercial As New ClsComercial()

    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If Trim(TxtMunicipioOrigen.Text) = "" Then
            ListaErrores.Add("- Seleccione el Municipio de Origen")
        End If

        If Trim(TxtMunicipioDestino.Text) = "" Then
            ListaErrores.Add("- Seleccione el municipio de Destino")
        End If

        If Trim(CmbTipoVehiculo.Text) = "" Then
            ListaErrores.Add("- Seleccione el tipo de Vehículo")
        End If

        If Val(TxtCapacidad.Text) = 0 Then
            ListaErrores.Add("- Digíte la capacidad del Vehículo")
        End If

        If Trim(CmbUnidad.Text) = "" Then
            ListaErrores.Add("- Seleccione la unidad de medida")
        End If

        If Val(TxtKilometros.Text) = 0 Then
            ListaErrores.Add("- Digíte la cantidad de Km entre el Origen y el Destino")
        End If

        If Trim(TxtCostoFlete.Text) = "$ 0" Then
            ListaErrores.Add("- Digíte el Costo del Flete")
        End If

        If Trim(TxtCostoTonelada.Text) = "$ 0" Then
            ListaErrores.Add("- Digíte el Costo del Flete x Unidad de Medida")
        End If

        If Trim(TxtMargenPor.Text) = "" Then
            ListaErrores.Add("- Digíte el porcentaje del Margen")
        End If

        If Trim(TxtMargenPesos.Text) = "$ 0" Then
            ListaErrores.Add("- Digíte el margen en dinero")
        End If

        If Trim(TxtTarifaFlete.Text) = "$ 0" Then
            ListaErrores.Add("- Digíte la tarifa del Flete")
        End If

        If Trim(TxtTarifaTonelada.Text) = "$ 0" Then
            ListaErrores.Add("- Digíte la tarifa del flete x Unidad de Medida")
        End If

        Return ListaErrores

    End Function

    Sub CargarCombos()

        '-------------- Cargo Los Tipos de Vehiculos ---------
        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TVehiculos")

        Me.CmbTipoVehiculo.DisplayMember = "TIPO"
        Me.CmbTipoVehiculo.ValueMember = "ID"
        Me.CmbTipoVehiculo.DataSource = dv
        Me.CmbTipoVehiculo.Text = ""
        '-----------------------------------------------------

        '-------------------- Cargo las Unidades de Medida --------------
        Dim dv1 As New DataView

        dv1.Table = Gl_DataSet.Tables("TUnidades")

        Me.CmbUnidad.DisplayMember = "UNIDAD"
        Me.CmbUnidad.ValueMember = "ID"
        Me.CmbUnidad.DataSource = dv1
        Me.CmbUnidad.Text = ""
        '-----------------------------------------------------


    End Sub
    Sub Recalcular()

        TxtMargenPesos.Tag = (TxtCostoFlete.Tag * TxtMargenPor.Text) / 100
        TxtMargenPesos.Text = FormatCurrency(TxtMargenPesos.Tag, 0)
        TxtTarifaFlete.Tag = (TxtCostoFlete.Tag + TxtMargenPesos.Tag)
        TxtTarifaFlete.Text = FormatCurrency(TxtTarifaFlete.Tag, 0)
        TxtTarifaTonelada.Tag = Val(TxtTarifaFlete.Tag) / TxtCapacidad.Text
        TxtTarifaTonelada.Text = FormatCurrency(TxtTarifaTonelada.Tag, 0)

    End Sub
    Private Sub TxtCostoFlete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCostoFlete.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtCostoTonelada.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtCostoTonelada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCostoTonelada.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtMargenPor.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub

    Private Sub TxtMargenPesos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMargenPesos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtTarifaFlete.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtTarifaFlete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTarifaFlete.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtTarifaTonelada.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtTarifaTonelada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTarifaTonelada.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If BtnCrear.Visible = True Then
                BtnCrear.Focus()
            Else
                BtnEditar.Focus()
            End If

        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub

    Private Sub TxtCostoFlete_GotFocus(sender As Object, e As EventArgs) Handles TxtCostoFlete.GotFocus

        Try
            If TxtCostoFlete.Text = "$ 0" Then
                TxtCostoFlete.Text = ""
            Else
                TxtCostoFlete.Text = CType(TxtCostoFlete.Text, Decimal)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtCostoTonelada_GotFocus(sender As Object, e As EventArgs) Handles TxtCostoTonelada.GotFocus
        Try
            If TxtCostoTonelada.Text = "$ 0" Then
                TxtCostoTonelada.Text = ""
            Else
                TxtCostoTonelada.Text = CType(TxtCostoTonelada.Text, Decimal)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtMargenPesos_GotFocus(sender As Object, e As EventArgs) Handles TxtMargenPesos.GotFocus
        Try
            If TxtMargenPesos.Text = "$ 0" Then
                TxtMargenPesos.Text = ""
            Else
                TxtMargenPesos.Text = CType(TxtMargenPesos.Text, Decimal)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtTarifaFlete_GotFocus(sender As Object, e As EventArgs) Handles TxtTarifaFlete.GotFocus
        Try
            If TxtTarifaFlete.Text = "$ 0" Then
                TxtTarifaFlete.Text = ""
            Else
                TxtTarifaFlete.Text = CType(TxtTarifaFlete.Text, Decimal)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtTarifaTonelada_GotFocus(sender As Object, e As EventArgs) Handles TxtTarifaTonelada.GotFocus
        Try
            If TxtTarifaTonelada.Text = "$ 0" Then
                TxtTarifaTonelada.Text = ""
            Else
                TxtTarifaTonelada.Text = CType(TxtTarifaTonelada.Text, Decimal)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtCostoFlete_LostFocus(sender As Object, e As EventArgs) Handles TxtCostoFlete.LostFocus
        Try
            If TxtCostoFlete.Text = "" Then
                TxtCostoFlete.Text = "$ 0"
                TxtCostoFlete.Tag = 0
            Else

                TxtCostoFlete.Tag = Val(TxtCostoFlete.Text)
                TxtCostoFlete.Text = FormatCurrency(TxtCostoFlete.Tag, 0)

                If Val(TxtCapacidad.Text) = 0 Then
                    MsgBox("Ingrese la Capacidad del Vehículo!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Exit Sub
                End If


                TxtCostoTonelada.Tag = Val(TxtCostoFlete.Tag) / TxtCapacidad.Text
                TxtCostoTonelada.Text = FormatCurrency(TxtCostoTonelada.Tag, 0)

            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtCostoTonelada_LostFocus(sender As Object, e As EventArgs) Handles TxtCostoTonelada.LostFocus
        Try
            If TxtCostoTonelada.Text = "" Then
                TxtCostoTonelada.Text = "$ 0"
                TxtCostoTonelada.Tag = 0
            Else
                TxtCostoTonelada.Tag = Val(TxtCostoTonelada.Text)
                TxtCostoTonelada.Text = FormatCurrency(TxtCostoTonelada.Text, 0)
            End If

        Catch ex As Exception
        End Try
    End Sub
    Private Sub TxtMargenPesos_LostFocus(sender As Object, e As EventArgs) Handles TxtMargenPesos.LostFocus
        Try
            If TxtMargenPesos.Text = "" Then
                TxtMargenPesos.Text = "$ 0"
                TxtMargenPesos.Tag = 0
            Else
                TxtMargenPesos.Tag = Val(TxtMargenPesos.Text)
                TxtMargenPesos.Text = FormatCurrency(TxtMargenPesos.Text, 0)
            End If

        Catch ex As Exception
        End Try
    End Sub
    Private Sub TxtTarifaFlete_LostFocus(sender As Object, e As EventArgs) Handles TxtTarifaFlete.LostFocus
        Try
            If TxtTarifaFlete.Text = "" Then
                TxtTarifaFlete.Text = "$ 0"
                TxtTarifaFlete.Tag = 0
            Else
                TxtTarifaFlete.Tag = Val(TxtTarifaFlete.Text)
                TxtTarifaFlete.Text = FormatCurrency(TxtTarifaFlete.Text, 0)
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtTarifaTonelada_LostFocus(sender As Object, e As EventArgs) Handles TxtTarifaTonelada.LostFocus
        Try
            If TxtTarifaTonelada.Text = "" Then
                TxtTarifaTonelada.Text = "$ 0"
                TxtTarifaTonelada.Tag = 0
            Else
                TxtTarifaTonelada.Tag = Val(TxtTarifaTonelada.Text)
                TxtTarifaTonelada.Text = FormatCurrency(TxtTarifaTonelada.Text, 0)
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnBuscaCiudad_Click(sender As Object, e As EventArgs) Handles BtnBuscaCiudad.Click

        Gl_Divipolitica.Pais = ""
        Gl_Divipolitica.NombreDepto = ""
        Gl_Divipolitica.NombreMunicipio = ""
        Gl_Divipolitica.CodigoPoblado = ""


        For_Divipoliticas.ShowDialog()


        Me.TxtMunicipioOrigen.Tag = Gl_Divipolitica.CodigoPoblado
        Me.TxtMunicipioOrigen.Text = Gl_Divipolitica.NombreMunicipio


    End Sub

    Private Sub BtnBuscaCiudad2_Click(sender As Object, e As EventArgs) Handles BtnBuscaCiudad2.Click

        Gl_Divipolitica.Pais = ""
        Gl_Divipolitica.NombreDepto = ""
        Gl_Divipolitica.NombreMunicipio = ""
        Gl_Divipolitica.CodigoPoblado = ""


        For_Divipoliticas.ShowDialog()


        Me.TxtMunicipioDestino.Tag = Gl_Divipolitica.CodigoPoblado
        Me.TxtMunicipioDestino.Text = Gl_Divipolitica.NombreMunicipio
    End Sub

    Private Sub For_TarifasCrearEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCombos()

    End Sub

    Private Sub CmbTipoVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoVehiculo.SelectedIndexChanged
        TxtCapacidad.Focus()
    End Sub

    Private Sub CmbTipoVehiculo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTipoVehiculo.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbUnidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUnidad.SelectedIndexChanged
        TxtKilometros.Focus()
    End Sub

    Private Sub CmbUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbUnidad.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtKilometros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKilometros.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtCostoFlete.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub



    Private Sub TxtMargenPor_LostFocus(sender As Object, e As EventArgs) Handles TxtMargenPor.LostFocus

        Try
            TxtMargenPesos.Tag = (TxtCostoFlete.Tag * TxtMargenPor.Text) / 100
            TxtMargenPesos.Text = FormatCurrency(TxtMargenPesos.Tag, 0)
            TxtTarifaFlete.Tag = (TxtCostoFlete.Tag + TxtMargenPesos.Tag)
            TxtTarifaFlete.Text = FormatCurrency(TxtTarifaFlete.Tag, 0)
            TxtTarifaTonelada.Tag = Val(TxtTarifaFlete.Tag) / TxtCapacidad.Text
            TxtTarifaTonelada.Text = FormatCurrency(TxtTarifaTonelada.Tag, 0)
        Catch ex As Exception

        End Try

        TxtMargenPesos.Focus()

    End Sub

    Private Sub For_TarifasCrearEditar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub TxtMargenPor_TextChanged(sender As Object, e As EventArgs) Handles TxtMargenPor.TextChanged
        TxtMargenPesos.Tag = 0
        TxtMargenPesos.Text = "$ 0"

        TxtTarifaFlete.Tag = 0
        TxtTarifaFlete.Text = "$ 0"

        TxtTarifaTonelada.Tag = 0
        TxtTarifaTonelada.Text = "$ 0"
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


        '---------------Rectificar los Valores ---------------

        Recalcular()

        '-----------------------------------------------------

        '----------- Ingresar Datos -------------------------------
        Comercial.IdServicio = 5 ' Cambiar si se ingresa lo de ITR
        Comercial.DiviOrigen = Mid(TxtMunicipioOrigen.Tag, 1, 5)
        Comercial.DiviDestino = Mid(TxtMunicipioDestino.Tag, 1, 5)
        Comercial.IdTipoVehiculo = CmbTipoVehiculo.SelectedValue
        Comercial.Capacidad = TxtCapacidad.Text
        Comercial.UnidadM = CmbUnidad.SelectedValue
        Comercial.Kilometros = Val(TxtKilometros.Text)
        Comercial.CostoFlete = TxtCostoFlete.Tag
        Comercial.CostoTonelada = TxtCostoTonelada.Tag
        Comercial.MargenPorcentaje = TxtMargenPor.Text
        Comercial.MargenDinero = TxtMargenPesos.Tag
        Comercial.TarifaFlete = TxtTarifaFlete.Tag
        Comercial.TarifaTonelada = TxtTarifaTonelada.Tag
        Comercial.Id = LblIdTarifa.Text

        Dim Respuesta = Comercial.GuardarTarifa(1)

        If Respuesta = True Then
            MsgBox("Tarifa Registrada Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
            For_TarifasCotizar.Dispose()
            For_TarifasTransporteListado.DGTarifa.DataSource = Nothing
            For_TarifasTransporteListado.Refresh()

        Else
            MsgBox("No fue Posible Registrar la tarifa. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        '-----------------------------------------------------------

    End Sub

    Private Sub TxtMargenPor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMargenPor.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TxtMargenPesos.Focus()
        Else

            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf asc(e.KeyChar) = 44 Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If

    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        '---------------Rectificar los Valores ---------------

        Recalcular()

        '-----------------------------------------------------

        '----------- Ingresar Datos -------------------------------
        Comercial.IdServicio = 5 ' Cambiar si se ingresa lo de ITR
        Comercial.DiviOrigen = Mid(TxtMunicipioOrigen.Tag, 1, 5)
        Comercial.DiviDestino = Mid(TxtMunicipioDestino.Tag, 1, 5)
        Comercial.IdTipoVehiculo = CmbTipoVehiculo.SelectedValue
        Comercial.Capacidad = TxtCapacidad.Text
        Comercial.UnidadM = CmbUnidad.SelectedValue
        Comercial.Kilometros = Val(TxtKilometros.Text)
        Comercial.CostoFlete = TxtCostoFlete.Tag
        Comercial.CostoTonelada = TxtCostoTonelada.Tag
        Comercial.MargenPorcentaje = TxtMargenPor.Text
        Comercial.MargenDinero = TxtMargenPesos.Tag
        Comercial.TarifaFlete = TxtTarifaFlete.Tag
        Comercial.TarifaTonelada = TxtTarifaTonelada.Tag

        Dim Respuesta = Comercial.EditarTarifa(LblIdTarifa.Text)

        If Respuesta = True Then
            MsgBox("Tarifa Editada Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
            For_TarifasTransporteListado.DGTarifa.DataSource = Nothing
            For_TarifasTransporteListado.Refresh()
        Else
            MsgBox("No fue Posible Registrar la tarifa. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        '-----------------------------------------------------------

    End Sub

End Class