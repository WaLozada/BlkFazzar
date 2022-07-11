Imports System.Data.SqlClient

Public Class For_FacturaAprobar
    Dim Fcontable As New Contable()
    Dim Aprobador As New Aprobadores()

    Sub CargarCombos()

        '-------------------- Cargo los Transportadores ------
        Dim Tabla1 As New DataTable
        Dim Consulta1 As SqlDataReader
        Consulta1 = Aprobador.ListarLineaspresupuesto()

        Tabla1.Load(Consulta1)

        Me.CmbPresupuesto.DisplayMember = "LINEA"
        Me.CmbPresupuesto.ValueMember = "CODIGO"
        Me.CmbPresupuesto.DataSource = Tabla1
        Me.CmbPresupuesto.Text = ""
        '-----------------------------------------------------

    End Sub

    Sub Listar()
        Try
            DGFacturas.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim TablaClientes As New DataTable

            Consulta = Fcontable.ListarFacturasAprobador(UsuarioApp.Documento)

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
            DGFacturas.Columns("APROBADOR").Visible = False
            'DGFacturas.Columns("PRESUPUESTO").Visible = False
            'DGFacturas.Columns("FECHAAPROBACION").Visible = False
            DGFacturas.Columns("USUARIOAPROBACION").Visible = False
            DGFacturas.Columns("PCAPROBACION").Visible = False
            DGFacturas.Columns("ID").Visible = False

            Try
                If DGFacturas.SelectedRows.Count > 0 Then
                    DGFacturas.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

            DGFacturas.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try
    End Sub

    Private Sub CmbAprobacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAprobacion.SelectedIndexChanged
        BtnRegistrar.Focus()
    End Sub

    Private Sub CmbAprobacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbAprobacion.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbPresupuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPresupuesto.SelectedIndexChanged
        CmbAprobacion.Focus()
    End Sub

    Private Sub CmbPresupuesto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbPresupuesto.KeyPress
        e.Handled = True
    End Sub

    Private Sub For_FacturaAprobar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Listar()
        CargarCombos()


    End Sub

    Private Sub DGFacturas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFacturas.CellClick

        Try
            Fcontable.Codigo = Trim(DGFacturas.Rows(e.RowIndex).Cells(1).Value)
            Fcontable.NumFac = Trim(DGFacturas.Rows(e.RowIndex).Cells(2).Value)
            Fcontable.Proveedor = Trim(DGFacturas.Rows(e.RowIndex).Cells(3).Value)
            Fcontable.Concepto = Trim(DGFacturas.Rows(e.RowIndex).Cells(4).Value)
            Fcontable.Subtotal = Trim(DGFacturas.Rows(e.RowIndex).Cells(8).Value)
            Fcontable.Iva = Trim(DGFacturas.Rows(e.RowIndex).Cells(9).Value)
            Fcontable.Total = Trim(DGFacturas.Rows(e.RowIndex).Cells(10).Value)
            Fcontable.Proyecto = Trim(DGFacturas.Rows(e.RowIndex).Cells(11).Value)
            Fcontable.CentroCosto = Trim(DGFacturas.Rows(e.RowIndex).Cells(12).Value)
            Fcontable.ValorCC = Trim(DGFacturas.Rows(e.RowIndex).Cells(13).Value)
            Fcontable.Observaciones = Trim(DGFacturas.Rows(e.RowIndex).Cells(14).Value)
            Fcontable.RutaFactura = Trim(DGFacturas.Rows(e.RowIndex).Cells(15).Value)
            Fcontable.Contabilizacion = Trim(DGFacturas.Rows(e.RowIndex).Cells(19).Value)
            Fcontable.Comentario = Trim(DGFacturas.Rows(e.RowIndex).Cells(20).Value)
            Fcontable.FechaContable = Trim(DGFacturas.Rows(e.RowIndex).Cells(21).Value)
            Fcontable.Aprobador = Trim(DGFacturas.Rows(e.RowIndex).Cells(26).Value)


            MsgBox("Codigo: " + Fcontable.Codigo + Chr(13) + "Factura : " + Fcontable.NumFac + Chr(13) + Chr(13) + "Proveedor : " + Chr(13) + Fcontable.Proveedor + Chr(13) + Chr(13) + "Concepto : " + Chr(13) + Fcontable.Concepto + Chr(13) + Chr(13) + "Observaciones : " + Chr(13) + Fcontable.Observaciones + Chr(13) + Chr(13) + "Comentarios :" + Chr(13) + Fcontable.Comentario, MsgBoxStyle.Information, Gl_NomCompañia)

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

    Private Sub BtnVisor_Click(sender As Object, e As EventArgs) Handles BtnVisor.Click

        If Fcontable.RutaFactura = "" Then
            MsgBox("Seleccione la Factura que desea Visualizar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            DGFacturas.ClearSelection()
            Exit Sub
        End If

        Try
            Dim url As String = Fcontable.RutaFactura
            Process.Start("Chrome", url)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        If CmbPresupuesto.Text = "" Then
            MsgBox("Seleccione la Linea de Presupuesto!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbPresupuesto.Focus()
            Exit Sub
        End If

        If CmbAprobacion.Text = "" Then
            MsgBox("Indique el estado de Aprobacion de la Factura!", MsgBoxStyle.Critical, Gl_NomCompañia)
            CmbAprobacion.Focus()
            Exit Sub
        End If

        '************************** Insertar Información a la Base de Datos ************************

        Fcontable.Aprobacion = Trim(CmbAprobacion.Text)
        Fcontable.Presupuesto = Trim(CmbPresupuesto.SelectedValue)
        Fcontable.UsuarioAprobacion = Trim(UsuarioApp.Documento)
        Fcontable.PcAprobacion = Trim(Environment.MachineName)

        Dim Respuesta = Fcontable.GuardarAprobacion()

        If Respuesta = "OK" Then
            MsgBox("La Factura fue Aprobada Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        Else
            MsgBox("No fue posible registrar la Aprobación. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        '**********************************************************************************************


    End Sub

    Private Sub For_FacturaAprobar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class