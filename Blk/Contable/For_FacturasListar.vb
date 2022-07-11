Imports System.Data.SqlClient

Public Class For_FacturasListar
    Dim FContable As New Contable()
    Sub Listar(Desde, Hasta, Aprobacion)
        Try
            DGFacturas.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim TablaClientes As New DataTable

            Consulta = FContable.ListarFacturas(Desde, Hasta, Aprobacion)

            TablaClientes.Load(Consulta)
            DGFacturas.DataSource = TablaClientes

            DGFacturas.Columns("NOMBRE").HeaderText = "PROVEEDOR"
            DGFacturas.Columns("SUBTOTAL").DefaultCellStyle.Format = "C0"
            DGFacturas.Columns("IVA").DefaultCellStyle.Format = "C0"
            DGFacturas.Columns("TOTAL").DefaultCellStyle.Format = "C0"
            DGFacturas.Columns("VALORCC").DefaultCellStyle.Format = "C0"

            DGFacturas.Columns("SUBTOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGFacturas.Columns("IVA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGFacturas.Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGFacturas.Columns("VALORCC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            DGFacturas.Columns("IDFACTURA").Visible = False
            DGFacturas.Columns("RUTAFACTURA").Visible = False
            DGFacturas.Columns("USUARIOREGISTRO").Visible = False
            DGFacturas.Columns("PCREGISTRO").Visible = False
            DGFacturas.Columns("USUARIOCONTABLE").Visible = False
            DGFacturas.Columns("PCCONTABLE").Visible = False
            DGFacturas.Columns("RUTAORDEN").Visible = False
            DGFacturas.Columns("PRESUPUESTO").Visible = False
            DGFacturas.Columns("FECHAAPROBACION").Visible = False
            DGFacturas.Columns("USUARIOAPROBACION").Visible = False
            DGFacturas.Columns("PCAPROBACION").Visible = False
            DGFacturas.Columns("ID").Visible = False

            Try
                If DGFacturas.SelectedRows.Count > 0 Then
                    DGFacturas.CurrentRow.Selected = False
                    DGFacturas.ClearSelection()
                End If

            Catch ex As Exception
            End Try



            DGFacturas.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub
    Private Sub For_FacturaRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        DTFechaDesde.Value = Date.Now.Year & "/" & Date.Now.Month & "/01"
        DTFechaHasta.Value = Date.Now.Year & "/" & Date.Now.Month & "/" & Date.Now.Day

        Listar(DTFechaDesde.Value, DTFechaHasta.Value, "")

    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("30")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        For_FacturasRegistro.ShowDialog()

        Listar(DTFechaDesde.Value, DTFechaHasta.Value, "")

    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click

        If RBTodas.Checked = True Then
            Listar(DTFechaDesde.Value, DTFechaHasta.Value, "")
        End If

        If RBAprobadas.Checked = True Then
            Listar(DTFechaDesde.Value, DTFechaHasta.Value, "APROBADA")
        End If

        If RBPendientes.Checked = True Then
            Listar(DTFechaDesde.Value, DTFechaHasta.Value, "PENDIENTE")
        End If

    End Sub

    Private Sub BtnContabilizar_Click(sender As Object, e As EventArgs) Handles BtnContabilizar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("33")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        If FContable.Concepto = "" Then
            MsgBox("Seleccione la Factura que desea Contabilizar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        If FContable.Aprobacion = "RECHAZADA" Then
            MsgBox("Esta Factura fue Rechazada por el Autorizador!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        With For_FacturaContabilizar

            .LblCodigo.Text = FContable.Codigo
            .LblFactura.Text = FContable.NumFac
            .LblSubtotal.Text = FormatCurrency(FContable.Subtotal, 0)
            .LblIva.Text = FormatCurrency(FContable.Iva, 0)
            .LblTotal.Text = FormatCurrency(FContable.Total, 0)
            .LblValorCC.Text = FormatCurrency(FContable.ValorCC, 0)
            .LblProyecto.Text = FContable.Proyecto
            .LblCentroCosto.Text = FContable.CentroCosto
            .LblProveedor.Text = FContable.Proveedor
            .LblConcepto.Text = FContable.Concepto
            .LblFechaContable.Text = FContable.FechaContable
            .BtnVisor.Tag = FContable.RutaFactura

            If FContable.Contabilizacion <> "" Then
                Dim RTA = MsgBox("Esta Factura ya fue Contabilizada. Desea Editar el registro de Contabilización ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

                If RTA = vbYes Then
                    .TxtWO.Text = FContable.Contabilizacion
                    .TxtComentario.Text = FContable.Comentario
                    .BtnEditar.Visible = True
                    .BtnGuardar.Visible = False
                Else
                    Exit Sub
                End If

            Else
                .BtnEditar.Visible = False
                .BtnGuardar.Visible = True

            End If

            For_FacturaContabilizar.ShowDialog()

        End With


        Listar(DTFechaDesde.Value, DTFechaHasta.Value, "")

    End Sub
    Private Sub DGFacturas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFacturas.CellClick

        Try
            FContable.Codigo = Trim(DGFacturas.Rows(e.RowIndex).Cells(1).Value)
            FContable.NumFac = Trim(DGFacturas.Rows(e.RowIndex).Cells(2).Value)
            FContable.Proveedor = Trim(DGFacturas.Rows(e.RowIndex).Cells(3).Value)
            FContable.Concepto = Trim(DGFacturas.Rows(e.RowIndex).Cells(4).Value)
            FContable.Subtotal = Trim(DGFacturas.Rows(e.RowIndex).Cells(8).Value)
            FContable.Iva = Trim(DGFacturas.Rows(e.RowIndex).Cells(9).Value)
            FContable.Total = Trim(DGFacturas.Rows(e.RowIndex).Cells(10).Value)
            FContable.Proyecto = Trim(DGFacturas.Rows(e.RowIndex).Cells(11).Value)
            FContable.CentroCosto = Trim(DGFacturas.Rows(e.RowIndex).Cells(12).Value)
            FContable.ValorCC = Trim(DGFacturas.Rows(e.RowIndex).Cells(13).Value)
            FContable.Observaciones = Trim(DGFacturas.Rows(e.RowIndex).Cells(14).Value)
            FContable.RutaFactura = Trim(DGFacturas.Rows(e.RowIndex).Cells(15).Value)
            FContable.Contabilizacion = Trim(DGFacturas.Rows(e.RowIndex).Cells(19).Value)
            FContable.Comentario = Trim(DGFacturas.Rows(e.RowIndex).Cells(20).Value)
            FContable.FechaContable = Trim(DGFacturas.Rows(e.RowIndex).Cells(21).Value)
            FContable.Aprobador = Trim(DGFacturas.Rows(e.RowIndex).Cells(26).Value)


            MsgBox("Codigo: " + FContable.Codigo + Chr(13) + "Factura : " + FContable.NumFac + Chr(13) + Chr(13) + "Proveedor : " + Chr(13) + FContable.Proveedor + Chr(13) + Chr(13) + "Concepto : " + Chr(13) + FContable.Concepto + Chr(13) + Chr(13) + "Observaciones : " + Chr(13) + FContable.Observaciones + Chr(13) + Chr(13) + "Comentarios :" + Chr(13) + FContable.Comentario + Chr(13) + Chr(13) + "Aprobador : " + FContable.Aprobador, MsgBoxStyle.Information, Gl_NomCompañia)

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

    End Sub

    Private Sub DGFacturas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGFacturas.CellFormatting

        For I = 0 To DGFacturas.Rows.Count - 1
            If Trim(DGFacturas.Rows(I).Cells("APROBACION").Value) = "PENDIENTE" Then
                DGFacturas.Rows(I).DefaultCellStyle.BackColor = Color.FromArgb(242, 252, 156)
            ElseIf Trim(DGFacturas.Rows(I).Cells("APROBACION").Value) = "APROBADA" Then
                DGFacturas.Rows(I).DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192)
            Else
                DGFacturas.Rows(I).DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192)
            End If
        Next

    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click




    End Sub
End Class