Imports System.Data.SqlClient

Public Class For_TarifasCotizar
    Dim Comercial As New ClsComercial()
    Dim DiviOrigen, Origen, DiviDestino, Destino, vehiculo, unidad, idvehiculo, idUnidad As String
    Dim Capacidad As Double

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("46")

        If Perfil = False Then
            MsgBox("Acceso NO Autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If


        With For_TarifasCrearEditar
                .BtnEditar.Visible = True
                .BtnCrear.Visible = False

            If Servicio = 5 Then
                .RBSpot.Checked = True
            Else
                .RBItr.Checked = True
                End If

                .TxtMunicipioOrigen.Tag = DiviOrigen
                .TxtMunicipioOrigen.Text = Origen
                .TxtMunicipioDestino.Tag = DiviDestino
                .TxtMunicipioDestino.Text = Destino
                .TxtKilometros.Text = Kilometros
                .GbVehiculo.Text = "TIPO VEHICULO - (" & vehiculo & ")"
                .TxtCapacidad.Text = Capacidad
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


    End Sub

    Private Sub DGCotizar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCotizar.CellContentClick

    End Sub

    Dim CostoFlete, CostoTon, MargenPor, MargenDinero, TarifaFlete, TarifaTon As String
    Dim Kilometros, Servicio, id As Integer

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("46")

        If Perfil = False Then

            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        MinimizarVentanas()

        With For_TarifasCrearEditar
            .BtnEditar.Visible = False
            .BtnCrear.Visible = True

            If Servicio = 5 Then
                .RBSpot.Checked = True
            Else
                .RBItr.Checked = True
            End If

            .TxtMunicipioOrigen.Tag = DiviOrigen
            .TxtMunicipioOrigen.Text = Origen
            .TxtMunicipioDestino.Tag = DiviDestino
            .TxtMunicipioDestino.Text = Destino
            .TxtKilometros.Text = 0
            .GbVehiculo.Text = "TIPO VEHICULO - (" & vehiculo & ")"
            .CmbTipoVehiculo.SelectedValue = idvehiculo
            .TxtCapacidad.Text = Capacidad
            .GbUnidad.Text = "UNIDAD MEDIDA - (" & UCase(unidad) & ")"
            .CmbUnidad.SelectedValue = idUnidad

            .LblIdTarifa.Text = id

            .ShowDialog()

        End With


    End Sub

    Sub Listar()


        Try

            DGCotizar.DataSource = Nothing


            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Comercial.ListarCotizar(7)

            Tabla.Load(Consulta)
            DGCotizar.DataSource = Tabla

            If DGCotizar.RowCount = 0 Then
                'MsgBox("No se tienen pendientes rutas por cotizar!", MsgBoxStyle.Information, Gl_NomCompañia)
                Exit Sub
            End If

            DGCotizar.Columns("IDSERVICIO").Visible = False
            DGCotizar.Columns("DIVIORIGEN").Visible = False
            DGCotizar.Columns("DIVIDESTINO").Visible = False
            DGCotizar.Columns("TIPOVEHICULO").Visible = False
            DGCotizar.Columns("UNIDADM").Visible = False
            DGCotizar.Columns("ESTADO").Visible = False


        Catch ex As Exception

        End Try

        Try

            DGActualizar.DataSource = Nothing


            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Comercial.ListarCotizar(8)

            Tabla.Load(Consulta)
            DGActualizar.DataSource = Tabla

            If DGActualizar.RowCount = 0 Then
                'MsgBox("No se tienen pendientes rutas por Actualizar!", MsgBoxStyle.Information, Gl_NomCompañia)
                Exit Sub
            End If

            DGActualizar.Columns("KILOMETROS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGActualizar.Columns("CAPACIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGActualizar.Columns("COSTOFLETE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGActualizar.Columns("COSTOTONELADA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGActualizar.Columns("MARGENPORCENTAJE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGActualizar.Columns("MARGENDINERO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGActualizar.Columns("TARIFAFLETE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGActualizar.Columns("TARIFATONELADA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGActualizar.Columns("COSTOFLETE").DefaultCellStyle.Format = "C0"
            DGActualizar.Columns("COSTOTONELADA").DefaultCellStyle.Format = "C0"
            DGActualizar.Columns("MARGENDINERO").DefaultCellStyle.Format = "C0"
            DGActualizar.Columns("MARGENPORCENTAJE").HeaderText = "MARGEN %"
            DGActualizar.Columns("TARIFAFLETE").DefaultCellStyle.Format = "C0"
            DGActualizar.Columns("TARIFATONELADA").DefaultCellStyle.Format = "C0"
            DGActualizar.Columns("IDSERVICIO").Visible = False
            DGActualizar.Columns("DIVIORIGEN").Visible = False
            DGActualizar.Columns("DIVIDESTINO").Visible = False
            DGActualizar.Columns("ID").Visible = False
            Try
                If DGActualizar.SelectedRows.Count > 0 Then
                    DGActualizar.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try


        Catch ex As Exception

        End Try

    End Sub
    Private Sub For_TarifasCotizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Listar()


    End Sub

    Private Sub DGCotizar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCotizar.CellClick
        Try
            Servicio = Trim(DGCotizar.Rows(e.RowIndex).Cells(0).Value)
            DiviOrigen = Trim(DGCotizar.Rows(e.RowIndex).Cells(2).Value)
            Origen = Trim(DGCotizar.Rows(e.RowIndex).Cells(3).Value)
            DiviDestino = Trim(DGCotizar.Rows(e.RowIndex).Cells(4).Value)
            Destino = Trim(DGCotizar.Rows(e.RowIndex).Cells(5).Value)
            vehiculo = Trim(DGCotizar.Rows(e.RowIndex).Cells(7).Value)
            idvehiculo = Trim(DGCotizar.Rows(e.RowIndex).Cells(6).Value)
            Capacidad = Trim(DGCotizar.Rows(e.RowIndex).Cells(8).Value)
            unidad = Trim(DGCotizar.Rows(e.RowIndex).Cells(10).Value)
            idUnidad = Trim(DGCotizar.Rows(e.RowIndex).Cells(9).Value)
            id = Trim(DGCotizar.Rows(e.RowIndex).Cells(14).Value)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub DGActualizar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGActualizar.CellClick

        MsgBox("SOLICITANTE" + Chr(13) + Trim(DGActualizar.Rows(e.RowIndex).Cells(19).Value) + Chr(13) + Chr(13) + "OBSERVACION: " + Chr(13) + Trim(DGActualizar.Rows(e.RowIndex).Cells(18).Value), MsgBoxStyle.Information, Gl_NomCompañia)

        Try
            Servicio = Trim(DGActualizar.Rows(e.RowIndex).Cells(0).Value)
            DiviOrigen = Trim(DGActualizar.Rows(e.RowIndex).Cells(2).Value)
            Origen = Trim(DGActualizar.Rows(e.RowIndex).Cells(3).Value)
            DiviDestino = Trim(DGActualizar.Rows(e.RowIndex).Cells(4).Value)
            Destino = Trim(DGActualizar.Rows(e.RowIndex).Cells(5).Value)
            Kilometros = DGActualizar.Rows(e.RowIndex).Cells(6).Value
            vehiculo = Trim(DGActualizar.Rows(e.RowIndex).Cells(7).Value)
            Capacidad = Trim(DGActualizar.Rows(e.RowIndex).Cells(8).Value)
            unidad = Trim(DGActualizar.Rows(e.RowIndex).Cells(9).Value)
            CostoFlete = Trim(DGActualizar.Rows(e.RowIndex).Cells(10).Value)
            CostoTon = Trim(DGActualizar.Rows(e.RowIndex).Cells(11).Value)
            MargenPor = Trim(DGActualizar.Rows(e.RowIndex).Cells(12).Value)
            MargenDinero = Trim(DGActualizar.Rows(e.RowIndex).Cells(13).Value)
            TarifaFlete = Trim(DGActualizar.Rows(e.RowIndex).Cells(14).Value)
            TarifaTon = Trim(DGActualizar.Rows(e.RowIndex).Cells(15).Value)
            id = Trim(DGActualizar.Rows(e.RowIndex).Cells(20).Value)

        Catch ax As Exception
        End Try


    End Sub
End Class