Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class For_ProductosClienteBuscar

    Dim Despacho As New DespachoMercancia()
    Dim Fila As Integer
    Sub Listar()
        Try
            DGInvProductos.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim TablaProductos As New DataTable

            Consulta = Despacho.ListarInventarioCliente(TxtDeposito.Text)

            TablaProductos.Load(Consulta)
            DGInvProductos.DataSource = TablaProductos

            DGInvProductos.Columns("DEPOSITO").Visible = False
            DGInvProductos.Columns("IDPRESENTACION").Visible = False
            DGInvProductos.Columns("FAMILIA").Visible = False
            DGInvProductos.Columns("ID").Visible = False
            DGInvProductos.Columns("SIMBOLO").Width = 40
            DGInvProductos.Columns("DISPONIBLE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGInvProductos.Columns("SIMBOLO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGInvProductos.Columns("BULTOSDISPONIBLE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGInvProductos.Columns("BULTOSDISPONIBLE").HeaderText = "BULTOS"


            Try
                If DGInvProductos.SelectedRows.Count > 0 Then
                    DGInvProductos.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try

            '----------- ESTA SECCION ES PARA QUITAR LOS PRODUCTOS SIN EXISTENCIAS ------------
            DGInvProductos.MultiSelect = True

            For I = 0 To DGInvProductos.Rows.Count - 1

                If Trim(DGInvProductos.Rows(I).Cells(2).Value) = 0 Then
                    DGInvProductos.Rows(I).Selected = True
                End If

            Next

            '-------------Borro los Seleccionados ------------
            Dim value0 As DataGridViewSelectedRowCollection
            value0 = DGInvProductos.SelectedRows

            For Each vfila As DataGridViewRow In value0
                DGInvProductos.Rows.Remove(vfila)
            Next
            '-------------------------------------------------

            DGInvProductos.MultiSelect = False

            '-----------------------------------------------------------------------------------


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


    End Sub
    Private Sub For_ProductosClienteBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Me.Panel1.Left = (Me.Width / 2) - (Panel1.Width / 2)

    End Sub

    Private Sub For_ProductosClienteBuscar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
    Private Sub DGInvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGInvProductos.CellClick



        Try
            '-------------------- Cargo los Productos -------------
            Dim Tabla As New DataTable
            Dim Consulta As SqlDataReader
            Fila = e.RowIndex

            Consulta = Despacho.ListarLotes(Trim(DGInvProductos.Rows(e.RowIndex).Cells("DEPOSITO").Value), Trim(DGInvProductos.Rows(e.RowIndex).Cells("CODIGO").Value), Trim(DGInvProductos.Rows(e.RowIndex).Cells("IDPRESENTACION").Value))

            Tabla.Load(Consulta)

            DGLotes.DataSource = Tabla
            '-----------------------------------------------------

            DGLotes.Columns("DEPOSITO").Visible = False
            DGLotes.Columns("CODPRODUCTO").Visible = False
            DGLotes.Columns("PRESENTACION").Visible = False
            DGLotes.Columns("LOTE").Width = 232
            DGLotes.Columns("DISPONIBLE").Width = 80
            DGLotes.Columns("BULTOS").Width = 55


            For I = 0 To DGLotes.Rows.Count - 1
                DGLotes.Rows(I).Cells(2).Value = Trim(DGLotes.Rows(I).Cells(2).Value)
            Next

            DGLotes.ClearSelection()

            TxtCantidad.Text = ""
            TxtCantidad.Focus()

        Catch ex As Exception

        End Try

    End Sub
    Private Sub BtnReservar_Click(sender As Object, e As EventArgs) Handles BtnReservar.Click


        If Trim(TxtCantidad.Text) = "" Then
            MsgBox("Digite la Cantidad de producto a retirar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtCantidad.Focus()
            Exit Sub
        End If

        If DGLotes.SelectedRows.Count = 0 Then
            MsgBox("Seleccione el Lote del cual desea realizar el despacho!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        Dim CodigoProducto As String = Trim(DGInvProductos.Rows(Fila).Cells("CODIGO").Value)
        Dim CantidadReservar As Decimal = TxtCantidad.Text
        Dim CantidadDisponible As Decimal = CType(DGLotes.Rows(TxtCantidad.Tag).Cells(3).Value, Decimal)
        Dim PresentacionReservar As String = Trim(DGLotes.Rows(DGLotes.CurrentRow.Index).Cells(5).Value)
        Dim LoteReservar As String = Trim(DGLotes.Rows(DGLotes.CurrentRow.Index).Cells("LOTE").Value)

        If CantidadReservar <= 0 Then
            MsgBox("Indique la Cantidad de Producto que Desea seleccionar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtCantidad.Focus()
            Exit Sub
        End If

        If CantidadReservar > CantidadDisponible Then
            MsgBox("Esta solicitando Una Cantidad de Material Superior al Disponible en el lote seleccionado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        '----------------- Validar que selecciono algun lote para despachar, el error indica que no ------------------
        Try
            If Trim(PresentacionReservar) = "" Then
                MsgBox("Seleccione el Lote del cual desea despachar!", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Seleccione el Lote del cual desea despachar!", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtCantidad.Text = ""
            Exit Sub
        End Try

        '---------------- Verificar que la cantidad ingresada sea multiplo del tipo de presentacion ---------

        Dim BultosMultiplo = CalcularBultos(PresentacionReservar, CantidadReservar)

        If BultosMultiplo = "" Then
            MsgBox("La Cantidad Total ingresada No Corresponde a un valor Exacto para la presentación de este material!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If
        '------------------------------------------------------------------------------------------------------


        '---Verificar que no se haya seleccionado el mismo lote de material antes ----

        For i = 0 To DGDespachar.Rows.Count - 1

            If Trim(DGDespachar.Rows(i).Cells(2).Value) = LoteReservar And CodigoProducto = Trim(DGDespachar.Rows(i).Cells(0).Value) Then
                Dim Rta = MsgBox("Ya se habia realizado una selección previa de material de este lote." + Chr(13) + Chr(13) + "Desea cancelar el material seleccionado anteriormente para este Lote e ingresar la nueva cantidad?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, Gl_NomCompañia)

                Dim CantidadRestar As Decimal

                If Rta = vbYes Then

                    DGDespachar.ClearSelection()


                    For J = 0 To DGDespachar.Rows.Count - 1
                        If Trim(DGDespachar.Rows(J).Cells(2).Value) = Trim(DGLotes.Rows(TxtCantidad.Tag).Cells("LOTE").Value) Then
                            DGDespachar.Rows(J).Selected = True ' Selecciono las filas con el mismo LOTE de producto
                            CantidadRestar += (DGDespachar.Rows(J).Cells(3).Value)
                        End If
                    Next
                Else
                    Exit Sub
                End If

                '-------------Borro los Seleccionados ------------
                Dim value As DataGridViewSelectedRowCollection
                value = DGDespachar.SelectedRows

                For Each vfila As DataGridViewRow In value
                    DGDespachar.Rows.Remove(vfila)
                Next
                '-------------------------------------------------
                TxtTotal.Text = (TxtTotal.Text) - CantidadRestar
                Exit For

            End If


        Next
        '-------------------------------------------------------------------------------


        Dim Cantidad As Decimal = CType(TxtCantidad.Text, Decimal)
        TxtTotal.Text += Cantidad


        '---------------Adiciono la Cantidad a reservar al Datagrid DGDespachar -----------

        DGDespachar.Rows.Add(Trim(DGInvProductos.Rows(Fila).Cells("CODIGO").Value),
                             Trim(DGInvProductos.Rows(Fila).Cells("DESCRIPCION").Value),
                             DGLotes.Rows(TxtCantidad.Tag).Cells("LOTE").Value,
                             Cantidad,
                             Trim(DGInvProductos.Rows(Fila).Cells("SIMBOLO").Value),
                             Trim(DGInvProductos.Rows(Fila).Cells("PRESENTACION").Value),
                             Trim(DGLotes.Rows(TxtCantidad.Tag).Cells("PRESENTACION").Value),
                             CalcularBultos(Trim(DGLotes.Rows(TxtCantidad.Tag).Cells("PRESENTACION").Value), Cantidad))

        '-------------Borro el Lote Seleccionados ------------
        Dim value2 As DataGridViewSelectedRowCollection
        value2 = DGLotes.SelectedRows

        For Each vfila As DataGridViewRow In value2
            DGLotes.Rows.Remove(vfila) ' Remuevo el lote de donde tome los kilos 
        Next
        '-------------------------------------------------


        TxtCantidad.Text = ""
        DGInvProductos.ClearSelection()

    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress

        If Asc(e.KeyChar) = 13 Then
            BtnReservar.Focus()
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
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        If DGDespachar.Rows.Count = 0 Then
            MsgBox("Seleccione el Material del cual desea registrar el Despacho!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        '--- Me aseguro de tener limpio el datagrid del Formulario For_despachoMercancia

        For_DespachoMercancia.DGProductos.Rows.Clear()

        '-------------------------------------------------------------------------------
        With DGDespachar
            '0 Codigo
            '1 Descripcion
            '2 Lote
            '3 Cantidad
            '4 Unidad
            '5 Presentacion
            '6 IdPresentacion
            '7 Bultos
            For I = 0 To .Rows.Count - 1

                For_DespachoMercancia.DGProductos.Rows.Add(Trim(DGDespachar.Rows(I).Cells(0).Value),
                                                           Trim(DGDespachar.Rows(I).Cells(1).Value),
                                                           CType(Trim(DGDespachar.Rows(I).Cells(3).Value), Decimal),
                                                           Trim(DGDespachar.Rows(I).Cells(4).Value),
                                                           Trim(DGDespachar.Rows(I).Cells(5).Value),
                                                           Trim(DGDespachar.Rows(I).Cells(6).Value),
                                                           Val(DGDespachar.Rows(I).Cells(7).Value),
                                                           Trim(DGDespachar.Rows(I).Cells(2).Value),
                                                           0, 0, 0, 0, 0, 0, 0, 0)
            Next
        End With

        For_DespachoMercancia.TxtTotal.Text = TxtTotal.Text

        Me.Dispose()


    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        Dim Rta = MsgBox("Eliminará Toda la selección de Productos Realizada." + Chr(13) + Chr(13) + "Desea Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

        If Rta = vbYes Then
            TxtTotal.Text = 0
            DGDespachar.Rows.Clear()
        End If


    End Sub

    Private Sub DGLotes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGLotes.CellClick

        Try
            TxtCantidad.Text = DGLotes.Rows(e.RowIndex).Cells(3).Value
            TxtCantidad.Tag = e.RowIndex ' Guardo la fila de donde tomo la cantidad 
            TxtCantidad.Focus()
        Catch ex As Exception
            DGLotes.ClearSelection()
        End Try

    End Sub

    Private Sub DGInvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGInvProductos.CellContentClick

    End Sub
End Class