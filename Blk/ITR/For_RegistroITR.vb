Imports System.Data.SqlClient

Public Class For_RegistroITR
    Dim OrdenServicioMacro As New ClsOrdenesServicioMacro()

    Sub CargarCombos()
        '-------------- Cargo Las Presentaciones ------------
        Dim dv1 As New DataView

        dv1.Table = Gl_DataSet.Tables("TPresentacion")

        Me.CmbPresentacion.DisplayMember = "DESCRIPCION"
        Me.CmbPresentacion.ValueMember = "ID"
        Me.CmbPresentacion.DataSource = dv1
        Me.CmbPresentacion.Text = ""
        '-----------------------------------------------------
    End Sub

    Sub Colorear()
        For i = 0 To DGOsm.Rows.Count - 1

            Select Case Trim(DGOsm.Rows(i).Cells(7).Value)
                Case 3
                    DGOsm.Rows(i).Cells(8).Style.BackColor = Color.YellowGreen
                Case 1
                    DGOsm.Rows(i).Cells(8).Style.BackColor = Color.Orange
                Case 2
                    DGOsm.Rows(i).Cells(8).Style.BackColor = Color.Yellow
            End Select

            Try
                If DGOsm.SelectedRows.Count > 0 Then
                    DGOsm.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

        Next
    End Sub
    Sub Listar()

        Try
            DGOsm.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim TablaOrdenes As New DataTable

            Consulta = OrdenServicioMacro.ListarOSM(Date.Now, Date.Now, 2)

            TablaOrdenes.Load(Consulta)
            DGOsm.DataSource = TablaOrdenes

            DGOsm.Columns("IDSERVICIO").Visible = False
            DGOsm.Columns("CODCENTRO").Visible = False
            DGOsm.Columns("IDESTADO").Visible = False

            Try
                If DGOsm.SelectedRows.Count > 0 Then
                    DGOsm.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

        Colorear()

    End Sub

    Private Sub For_RegistroITR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Me.PanelPrincipal.Left = (Me.Width / 2) - (TabControl1.Width / 2)

        Listar()
        CargarCombos()

    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

    End Sub

    Private Sub DGOsm_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOsm.CellContentClick
        Try
            LblOSM.Text = DGOsm.Rows(e.RowIndex).Cells(0).Value

        Catch ex As Exception

        End Try



    End Sub

    Private Sub BtnProducto_Click(sender As Object, e As EventArgs) Handles BtnProducto.Click


        For_ProductosBuscar.ShowDialog()

        Me.TxtCodigoProducto.Text = Gl_Producto.Codigo
        Me.LblProducto.Text = Gl_Producto.Descripcion
        Me.LblUnidad.Text = Gl_Producto.Simbolo


        Me.TxtCantidad.Focus()

    End Sub

    Private Sub CmbPresentacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPresentacion.SelectedIndexChanged

        If IsNumeric(TxtCantidad.Text) = True Then

            Dim Resultado As String
            Resultado = CalcularBultos(CmbPresentacion.SelectedValue, TxtCantidad.Text)

            If Resultado = "" Then
                TxtCantidad.Focus()
                CmbPresentacion.Text = ""
                MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación Ingresada!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Else
                TxtBultos.Text = Resultado
                'TxtLote.Focus()
            End If


        Else
            TxtCantidad.Focus()
        End If

        'TxtLote.Focus()
    End Sub
End Class