Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet
Imports SpreadsheetLight

Public Class For_TarifasTransporteListado
    Dim Comercial As New ClsComercial()
    Dim DiviOrigen, Origen, DiviDestino, Destino, vehiculo, unidad, kilometros As String
    Dim Capacidad As Double
    Dim CostoFlete, CostoTon, MargenPor, MargenDinero, TarifaFlete, TarifaTon As String
    Dim Servicio, id As Integer

    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If Trim(CmbOrigen.Text) = "" Then
            ListaErrores.Add("- Seleccione el Origen")
        End If

        If Trim(CmbDestino.Text) = "" Then
            ListaErrores.Add("- Seleccione el Destino")
        End If

        If Trim(CmbTipoVehiculo.Text) = "" Then
            ListaErrores.Add("- Seleccione el tipo de Vehículo")
        End If

        If Trim(CmbCapacidad.Text) = "" Then
            ListaErrores.Add("- Seleccione la Capacidad")
        End If

        If Trim(CmbUnidad.Text) = "" Then
            ListaErrores.Add("- Seleccione la unidad de medida")
        End If

        Return ListaErrores

    End Function
    Sub CargarCombos()

        '-------------------- Cargo los Origenes -------------

        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = Comercial.ListarCombos(1)

        Tabla.Load(Consulta)

        Me.CmbOrigen.DisplayMember = "NOMBRE_MUNICIPIO"
        Me.CmbOrigen.ValueMember = "CODIGO_MUNICIPIO"
        Me.CmbOrigen.Text = ""
        Me.CmbOrigen.DataSource = Tabla

        '-------------------- Cargo los Destinos -------------

        Dim Tabla0 As New DataTable
        Dim Consulta0 As SqlDataReader
        Consulta0 = Comercial.ListarCombos(2)

        Tabla0.Load(Consulta0)

        Me.CmbDestino.DisplayMember = "NOMBRE_MUNICIPIO"
        Me.CmbDestino.ValueMember = "CODIGO_MUNICIPIO"
        Me.CmbDestino.DataSource = Tabla0

        '-----------------------------------------------------

        '-------------------- Cargo los Tipo Vehiculos --------------
        'Dim Tabla1 As New DataTable
        'Dim Consulta1 As SqlDataReader
        'Consulta1 = Comercial.ListarCombos(3) ' Tipos de Vehiculos

        'Tabla1.Load(Consulta1)

        'Me.CmbTipoVehiculo.DisplayMember = "TIPO"
        'Me.CmbTipoVehiculo.ValueMember = "ID"
        'Me.CmbTipoVehiculo.DataSource = Tabla1


        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TVehiculos")

        Me.CmbTipoVehiculo.DisplayMember = "TIPO"
        Me.CmbTipoVehiculo.ValueMember = "ID"
        Me.CmbTipoVehiculo.DataSource = dv
        Me.CmbTipoVehiculo.Text = ""
        '-----------------------------------------------------

        '-------------------- Cargo las Unidades de Medida --------------
        Dim Tabla2 As New DataTable
        Dim Consulta2 As SqlDataReader
        Consulta2 = Comercial.ListarCombos(4) ' Unidades de Medida

        Tabla2.Load(Consulta2)

        Me.CmbUnidad.DisplayMember = "UNIDAD"
        Me.CmbUnidad.ValueMember = "ID"
        Me.CmbUnidad.DataSource = Tabla2
        '-----------------------------------------------------




    End Sub

    Private Sub For_TarifasTransporteListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        CargarCombos()

        CmbOrigen.Text = ""
        CmbDestino.Text = ""
        CmbTipoVehiculo.Text = ""
        CmbCapacidad.Text = ""
        CmbUnidad.Text = ""



    End Sub

    Private Sub CmbTipoVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoVehiculo.SelectedIndexChanged

        '-------------------- Cargo las Capacidades --------------
        Dim Tabla3 As New DataTable
        Dim Consulta3 As SqlDataReader
        Consulta3 = Comercial.ListarCombos(5, CmbTipoVehiculo.SelectedValue) ' Capacidades

        Tabla3.Load(Consulta3)

        Me.CmbCapacidad.DisplayMember = "CAPACIDAD"
        'Me.CmbCapacidad.ValueMember = "ID"
        Me.CmbCapacidad.DataSource = Tabla3
        '-----------------------------------------------------

        CmbUnidad.Focus()

    End Sub

    Private Sub CmbOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbOrigen.SelectedIndexChanged
        CmbOrigen.Tag = CmbOrigen.SelectedValue
        CmbDestino.Focus()
    End Sub

    Private Sub CmbDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDestino.SelectedIndexChanged
        CmbDestino.Tag = CmbDestino.SelectedValue
        CmbTipoVehiculo.Focus()
    End Sub

    Private Sub CmbCapacidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCapacidad.SelectedIndexChanged
        CmbUnidad.Focus()
    End Sub

    Private Sub BtnBuscaCiudad_Click(sender As Object, e As EventArgs) Handles BtnBuscaCiudad.Click

        Gl_Divipolitica.Pais = ""
        Gl_Divipolitica.NombreDepto = ""
        Gl_Divipolitica.NombreMunicipio = ""
        Gl_Divipolitica.CodigoPoblado = ""


        For_Divipoliticas.ShowDialog()


        Me.CmbOrigen.Tag = Gl_Divipolitica.CodigoPoblado
        Me.CmbOrigen.Text = Gl_Divipolitica.NombreMunicipio

    End Sub

    Private Sub BtnBuscaCiudad2_Click(sender As Object, e As EventArgs) Handles BtnBuscaCiudad2.Click

        Gl_Divipolitica.Pais = ""
        Gl_Divipolitica.NombreDepto = ""
        Gl_Divipolitica.NombreMunicipio = ""
        Gl_Divipolitica.CodigoPoblado = ""


        For_Divipoliticas.ShowDialog()


        Me.CmbDestino.Tag = Gl_Divipolitica.CodigoPoblado
        Me.CmbDestino.Text = Gl_Divipolitica.NombreMunicipio

    End Sub

    Private Sub BtnCotizar_Click(sender As Object, e As EventArgs) Handles BtnCotizar.Click

        For_TarifasCotizar.ShowDialog()

    End Sub

    Private Sub DGTarifa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTarifa.CellContentClick

    End Sub

    Private Sub CmbOrigen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbOrigen.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbDestino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbDestino.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbTipoVehiculo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbTipoVehiculo.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbCapacidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCapacidad.KeyPress
        'e.Handled = True
    End Sub

    Private Sub CmbUnidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUnidad.SelectedIndexChanged
        BtnConsultaTarifa.Focus()
    End Sub

    Private Sub CmbUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbUnidad.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnConsultaTarifa_Click(sender As Object, e As EventArgs) Handles BtnConsultaTarifa.Click

        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Comercial.DiviOrigen = Mid(CmbOrigen.Tag, 1, 5)
        Comercial.DiviDestino = Mid(CmbDestino.Tag, 1, 5)
        Comercial.IdTipoVehiculo = CmbTipoVehiculo.SelectedValue
        Comercial.Capacidad = Convert.ToDecimal(CmbCapacidad.Text)
        Comercial.UnidadM = CmbUnidad.SelectedValue

        Try

            DGTarifa.DataSource = Nothing

            'Dim Comercial As New ClsComercial()
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Comercial.ListarTarifa(6, Comercial.DiviOrigen, Comercial.DiviDestino, CmbTipoVehiculo.SelectedValue, Convert.ToDecimal(Comercial.Capacidad), CmbUnidad.SelectedValue)

            Tabla.Load(Consulta)
            DGTarifa.DataSource = Tabla

            If DGTarifa.RowCount = 0 Then

                MsgBox("No se cuenta con tarifa registrada para las caracteristicas indicadas!", MsgBoxStyle.Critical, Gl_NomCompañia)

                Dim Rta = MsgBox("Desea Solicitar la cotizacón de esta ruta? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

                If Rta = vbYes Then

                    '----------- Ingresar Datos -------------------------------
                    Comercial.IdServicio = 5 ' Cambiar si se ingresa lo de ITR
                    Comercial.DiviOrigen = Mid(CmbOrigen.Tag, 1, 5)
                    Comercial.DiviDestino = Mid(CmbDestino.Tag, 1, 5)
                    Comercial.IdTipoVehiculo = CmbTipoVehiculo.SelectedValue
                    Comercial.Capacidad = CmbCapacidad.Text
                    Comercial.UnidadM = CmbUnidad.SelectedValue

                    Dim Respuesta = Comercial.GuardarTarifa(3)

                    If Respuesta = True Then
                        MsgBox("Solicitud Registrada Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
                    Else
                        MsgBox("No fue Posible Registrar la Solicitud. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    End If

                    '-----------------------------------------------------------
                End If


                Exit Sub
            End If

            DGTarifa.Columns("KILOMETROS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGTarifa.Columns("CAPACIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGTarifa.Columns("COSTOFLETE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGTarifa.Columns("COSTOTONELADA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGTarifa.Columns("MARGENPORCENTAJE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGTarifa.Columns("MARGENDINERO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGTarifa.Columns("TARIFAFLETE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGTarifa.Columns("TARIFATONELADA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            DGTarifa.Columns("IDSERVICIO").Visible = False
            DGTarifa.Columns("DIVIORIGEN").Visible = False
            DGTarifa.Columns("DIVIDESTINO").Visible = False
            DGTarifa.Columns("ID").Visible = False

            Dim Perfil As Boolean
            Perfil = ConsultaPerfil("44")

            If Perfil = True Then

                DGTarifa.Columns("COSTOFLETE").Visible = False
                DGTarifa.Columns("COSTOTONELADA").Visible = False
                DGTarifa.Columns("MARGENPORCENTAJE").Visible = False
                DGTarifa.Columns("MARGENDINERO").Visible = False

                DGTarifas.Visible = True
                DGTarifasAdmin.Visible = False

            Else
                DGTarifa.Columns("COSTOFLETE").DefaultCellStyle.Format = "C0"
                DGTarifa.Columns("COSTOTONELADA").DefaultCellStyle.Format = "C0"
                DGTarifa.Columns("MARGENDINERO").DefaultCellStyle.Format = "C0"

                DGTarifa.Columns("MARGENPORCENTAJE").HeaderText = "MARGEN %"

                DGTarifas.Visible = False
                DGTarifasAdmin.Visible = True

            End If

            DGTarifa.Columns("TARIFAFLETE").DefaultCellStyle.Format = "C0"
            DGTarifa.Columns("TARIFATONELADA").DefaultCellStyle.Format = "C0"

            Try
                If DGTarifa.SelectedRows.Count > 0 Then
                    DGTarifa.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try



    End Sub

    Private Sub For_TarifasTransporteListado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

        If DGTarifa.RowCount = 0 Then
            MsgBox("Nada para adicionar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If


        If DGTarifas.Visible = True Then

            DGTarifas.Columns(7).DefaultCellStyle.Format = "C0"
            DGTarifas.Columns(8).DefaultCellStyle.Format = "C0"


            DGTarifas.Rows.Add(DGTarifa.Rows(0).Cells(1).Value, DGTarifa.Rows(0).Cells(3).Value, DGTarifa.Rows(0).Cells(5).Value, DGTarifa.Rows(0).Cells(6).Value, DGTarifa.Rows(0).Cells(7).Value, DGTarifa.Rows(0).Cells(8).Value, DGTarifa.Rows(0).Cells(9).Value, DGTarifa.Rows(0).Cells(10).Value, DGTarifa.Rows(0).Cells(11).Value, DGTarifa.Rows(0).Cells(16).Value, DGTarifa.Rows(0).Cells(17).Value)

            Try
                If DGTarifas.SelectedRows.Count > 0 Then
                    DGTarifas.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try



        Else

            DGTarifasAdmin.Columns(7).DefaultCellStyle.Format = "C0"
            DGTarifasAdmin.Columns(8).DefaultCellStyle.Format = "C0"
            DGTarifasAdmin.Columns(10).DefaultCellStyle.Format = "C0"
            DGTarifasAdmin.Columns(11).DefaultCellStyle.Format = "C0"
            DGTarifasAdmin.Columns(12).DefaultCellStyle.Format = "C0"



            DGTarifasAdmin.Rows.Add(DGTarifa.Rows(0).Cells(1).Value, DGTarifa.Rows(0).Cells(3).Value, DGTarifa.Rows(0).Cells(5).Value, DGTarifa.Rows(0).Cells(6).Value, DGTarifa.Rows(0).Cells(7).Value, DGTarifa.Rows(0).Cells(8).Value, DGTarifa.Rows(0).Cells(9).Value, DGTarifa.Rows(0).Cells(10).Value, DGTarifa.Rows(0).Cells(11).Value, DGTarifa.Rows(0).Cells(12).Value, DGTarifa.Rows(0).Cells(13).Value, DGTarifa.Rows(0).Cells(14).Value, DGTarifa.Rows(0).Cells(15).Value, DGTarifa.Rows(0).Cells(16).Value, DGTarifa.Rows(0).Cells(17).Value)

            Try
                If DGTarifasAdmin.SelectedRows.Count > 0 Then
                    DGTarifasAdmin.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

        End If

        DGTarifa.DataSource = Nothing

    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click

        Try

            If DGTarifas.Visible = True Then

                If DGTarifas.RowCount = 0 Then
                    MsgBox("Nada para Exportar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                    Exit Sub
                End If
            Else
                If DGTarifasAdmin.RowCount = 0 Then
                    MsgBox("Nada para Exportar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                    Exit Sub
                End If

            End If


            SDArchivo.FileName = "CotizacionTarifas"


            If SDArchivo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            If SDArchivo.FileName = "" Then
                MsgBox("Ingrese el Nombre del archivo Excel", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            End If


            Dim FH As Date = FechaHoraServer()

            Dim SL As New SLDocument()

            Dim StyleCabecera As SLStyle = SL.CreateStyle()
            Dim StyleCentrado As SLStyle = SL.CreateStyle()

            StyleCabecera.Font.Bold = True
            StyleCabecera.Font.FontSize = 10
            StyleCabecera.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.Yellow, System.Drawing.Color.White)

            StyleCentrado.Alignment.Horizontal = HorizontalAlignmentValues.Center
            StyleCentrado.Border.RightBorder.BorderStyle = BorderStyleValues.Hair
            StyleCentrado.Border.LeftBorder.BorderStyle = BorderStyleValues.Hair
            StyleCentrado.Border.TopBorder.BorderStyle = BorderStyleValues.Hair

            If DGTarifas.Visible = True Then

                '----- Encabezado de las columnas de la Tabla -------------
                For i = 1 To DGTarifas.ColumnCount
                    SL.SetCellValue(1, i, DGTarifas.Columns(i - 1).HeaderText)
                    SL.SetCellStyle(1, i, StyleCabecera)
                    SL.SetCellStyle(1, i, StyleCentrado)
                Next

                '----- Datos de la Tabla -------------------------------
                For F = 0 To DGTarifas.Rows.Count - 1
                    For C = 1 To DGTarifas.ColumnCount
                        SL.SetCellValue(F + 2, C, Trim(DGTarifas.Rows(F).Cells(C - 1).Value))
                    Next
                Next

            Else
                '----- Encabezado de las columnas de la Tabla -------------
                For i = 1 To DGTarifasAdmin.ColumnCount
                    SL.SetCellValue(1, i, DGTarifasAdmin.Columns(i - 1).HeaderText)
                    SL.SetCellStyle(1, i, StyleCabecera)
                    SL.SetCellStyle(1, i, StyleCentrado)
                Next

                '----- Datos de la Tabla -------------------------------
                For F = 0 To DGTarifasAdmin.Rows.Count - 1
                    For C = 1 To DGTarifasAdmin.ColumnCount
                        SL.SetCellValue(F + 2, C, Trim(DGTarifasAdmin.Rows(F).Cells(C - 1).Value))
                    Next
                Next

            End If


            SL.SaveAs(SDArchivo.FileName + ".xlsx")

            MsgBox("Archivo generado con Exito!", MsgBoxStyle.Information, Gl_NomCompañia)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Private Sub DGTarifas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTarifas.CellClick

        Dim Rta = MsgBox("Desea Eliminar la tarifa seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

        If Rta = MsgBoxResult.Yes Then
            DGTarifas.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("46")

        If Perfil = False Then

            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If


        For_TarifasCrearEditar.BtnEditar.Visible = False
        For_TarifasCrearEditar.BtnCrear.Visible = True

        For_TarifasCrearEditar.ShowDialog()

        CargarCombos()

        CmbOrigen.Text = ""
        CmbDestino.Text = ""
        CmbTipoVehiculo.Text = ""
        CmbCapacidad.Text = ""
        CmbUnidad.Text = ""

    End Sub

    Private Sub DGTarifa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTarifa.CellClick

        Servicio = Trim(DGTarifa.Rows(e.RowIndex).Cells(0).Value)
        DiviOrigen = Trim(DGTarifa.Rows(e.RowIndex).Cells(2).Value)
        Origen = Trim(DGTarifa.Rows(e.RowIndex).Cells(3).Value)
        DiviDestino = Trim(DGTarifa.Rows(e.RowIndex).Cells(4).Value)
        Destino = Trim(DGTarifa.Rows(e.RowIndex).Cells(5).Value)
        kilometros = DGTarifa.Rows(e.RowIndex).Cells(6).Value
        vehiculo = Trim(DGTarifa.Rows(e.RowIndex).Cells(7).Value)
        capacidad = Trim(DGTarifa.Rows(e.RowIndex).Cells(8).Value)
        unidad = Trim(DGTarifa.Rows(e.RowIndex).Cells(9).Value)
        CostoFlete = Trim(DGTarifa.Rows(e.RowIndex).Cells(10).Value)
        CostoTon = Trim(DGTarifa.Rows(e.RowIndex).Cells(11).Value)
        MargenPor = Trim(DGTarifa.Rows(e.RowIndex).Cells(12).Value)
        MargenDinero = Trim(DGTarifa.Rows(e.RowIndex).Cells(13).Value)
        TarifaFlete = Trim(DGTarifa.Rows(e.RowIndex).Cells(14).Value)
        TarifaTon = Trim(DGTarifa.Rows(e.RowIndex).Cells(15).Value)
        id = Trim(DGTarifa.Rows(e.RowIndex).Cells(18).Value)

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("46")

        If Perfil = True Then

            Dim Rta = MsgBox("Deseas editar esta tarifa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

            If Rta = vbYes Then


                With For_TarifasCrearEditar
                    .BtnEditar.Visible = True
                    .BtnCrear.Visible = False

                    If Servicio = 1 Then
                        .RBSpot.Checked = True
                    Else
                        .RBItr.Checked = True
                    End If

                    .TxtMunicipioOrigen.Tag = DiviOrigen
                    .TxtMunicipioOrigen.Text = Origen
                    .TxtMunicipioDestino.Tag = DiviDestino
                    .TxtMunicipioDestino.Text = Destino
                    .TxtKilometros.Text = kilometros
                    .GbVehiculo.Text = "TIPO VEHICULO - (" & vehiculo & ")"
                    .TxtCapacidad.Text = capacidad
                    .GbUnidad.Text = "UNIDAD MEDIDA - (" & UCase(unidad) & ")"
                    .TxtCostoFlete.Tag = Val(CostoFlete)
                    .TxtCostoFlete.Text = FormatCurrency(CostoFlete, 0)
                    .TxtCostoTonelada.Tag = Val(CostoTon)
                    .TxtCostoTonelada.Text = FormatCurrency(CostoTon, 0)
                    .TxtMargenPor.Text = MargenPor
                    .TxtMargenPesos.Tag = Val(MargenDinero)
                    .TxtMargenPesos.Text = FormatCurrency(MargenDinero, 0)
                    .TxtTarifaFlete.Tag = Val(TarifaFlete)
                    .TxtTarifaFlete.Text = FormatCurrency(TarifaFlete, 0)
                    .TxtTarifaTonelada.Tag = Val(TarifaTon)
                    .TxtTarifaTonelada.Text = FormatCurrency(TarifaTon, 0)
                    .LblIdTarifa.Text = id

                    .ShowDialog()

                End With

            End If

            Exit Sub

        End If


        '---------------Solicitar Actualizacion de la Tarifa ------------------


        Perfil = ConsultaPerfil("45")

        If Perfil = True Then

            Dim Rta = MsgBox("Deseas solicitar actualización de esta tarifa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

            If Rta = vbYes Then

                For_TarifasMotivo.LblID.Text = id
                For_TarifasMotivo.ShowDialog()

            End If


        End If

        '----------------------------------------------------------------------


    End Sub
End Class