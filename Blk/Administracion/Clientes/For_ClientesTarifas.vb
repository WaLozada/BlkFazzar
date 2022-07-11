Imports System.Data.SqlClient

Public Class For_ClientesTarifas
    Dim Centro As New Centros()
    Dim Bodega As New Bodegas()
    Dim Cliente As New Clientes()
    Dim Servicio, valor, unidad, ID As Integer


    Sub CargarCombos()

        '-------------------- Cargo los Centros -------------
        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = Centro.ListarCentro()

        Tabla.Load(Consulta)

        Me.CmbCentros.DisplayMember = "NOMBRE"
        Me.CmbCentros.ValueMember = "CODIGO"
        Me.CmbCentros.DataSource = Tabla
        Me.CmbCentros.Text = ""
        '-----------------------------------------------------

        '-------------- Cargo Servicios ------------
        Dim dv1 As New DataView

        dv1.Table = Gl_DataSet.Tables("TServicios")

        Me.CmbServicios.DisplayMember = "TIPO"
        Me.CmbServicios.ValueMember = "ID"
        dv1.RowFilter = String.Format("Visible=1")
        Me.CmbServicios.DataSource = dv1
        Me.CmbServicios.Text = ""
        '-----------------------------------------------------

        '-------------- Cargo Unidad ------------
        Dim dv2 As New DataView

        dv2.Table = Gl_DataSet.Tables("TUnidades")

        Me.CmbUnidad.DisplayMember = "UNIDAD"
        Me.CmbUnidad.ValueMember = "ID"
        Me.CmbUnidad.DataSource = dv2
        Me.CmbUnidad.Text = ""
        '-----------------------------------------------------

    End Sub
    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If Trim(CmbCentros.Text) = "" Then
            ListaErrores.Add("Seleccione un Centro de Distribución")
        End If

        If Trim(CmbBodegas.Text) = "" Then
            ListaErrores.Add("Seleccione una Bodega")
        End If

        If Trim(CmbServicios.Text) = "" Then
            ListaErrores.Add("Seleccione el tipo de Servicio")
        End If

        If Trim(CmbUnidad.Text) = "" Then
            ListaErrores.Add("Seleccione el tipo de Unidad de Medida")
        End If

        Return ListaErrores

    End Function
    Private Sub DGTarifas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTarifas.CellClick

        Try
            Cliente.Codigo = LblCodigo.Text
            Centro.Codigo = DGTarifas.Rows(e.RowIndex).Cells(6).Value
            Bodega.Codigo = DGTarifas.Rows(e.RowIndex).Cells(8).Value
            Servicio = Trim(DGTarifas.Rows(e.RowIndex).Cells(1).Value)
            valor = DGTarifas.Rows(e.RowIndex).Cells(3).Value
            unidad = DGTarifas.Rows(e.RowIndex).Cells(4).Value
            ID = DGTarifas.Rows(e.RowIndex).Cells(10).Value
        Catch ex As Exception

        End Try


    End Sub

    Private Sub For_ClientesTarifas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub For_ClientesTarifas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCombos()

    End Sub

    Private Sub CmbCentros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCentros.SelectedIndexChanged
        '------------ Listo las Bodegas del Centro Seleccionado ---------------
        CmbBodegas.DataSource = Nothing

        Dim Consulta As SqlDataReader
        Dim Tabla As New DataTable

        Consulta = Bodega.ListarBodegas(CmbCentros.SelectedValue)

        Tabla.Load(Consulta)

        Me.CmbBodegas.DisplayMember = "DESCRIPCION"
        Me.CmbBodegas.ValueMember = "CODIGO"
        Me.CmbBodegas.DataSource = Tabla

        Me.CmbBodegas.Text = ""

        Consulta.Close()
        '-------------------------------------------------------------------------

        CmbBodegas.Focus()
    End Sub

    Private Sub CmbCentros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCentros.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbBodegas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBodegas.SelectedIndexChanged
        CmbServicios.Focus()
    End Sub

    Private Sub CmbBodegas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbBodegas.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbServicios.SelectedIndexChanged
        TxtValor.Focus()
    End Sub

    Private Sub CmbServicios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbServicios.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbUnidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUnidad.SelectedIndexChanged
        BtnGuardar.Focus()
    End Sub

    Private Sub CmbUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbUnidad.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("49")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If



        Dim Rta = MsgBox("Desea Eliminar la Tarifa?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Gl_NomCompañia)

        If Rta = vbYes Then


            Dim Respuesta = Cliente.BorrarTarifa(ID)

            If Respuesta = True Then
                MsgBox("Tarifa Eliminada Exitosamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Else
                MsgBox("No fue posible Eliminar el Producto. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            End If

            Me.Dispose()

        End If

    End Sub


    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        CmbCentros.SelectedValue = Centro.Codigo
        CmbBodegas.SelectedValue = Bodega.Codigo
        CmbServicios.SelectedValue = Servicio
        TxtValor.Text = FormatCurrency(valor, 0)
        CmbUnidad.SelectedValue = unidad

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("49")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If



        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If


        For I = 0 To DGTarifas.Rows.Count - 1
            If DGTarifas.Rows(I).Cells("IDSERVICIO").Value = CmbServicios.SelectedValue And DGTarifas.Rows(I).Cells(8).Value = CmbBodegas.SelectedValue Then
                MsgBox("Ya se encuentra una tarifa establecida para este servicio. Si desea cambiarla debe eliminarla e ingresarla de nuevo!", MsgBoxStyle.Critical, Gl_NomCompañia)
                Exit Sub
            End If
        Next

        Cliente.Codigo = LblCodigo.Text

        Try
            Centro.Codigo = CmbCentros.SelectedValue
            Bodega.Codigo = CmbBodegas.SelectedValue
            Servicio = CmbServicios.SelectedValue
            valor = Val(TxtValor.Text)
            unidad = CmbUnidad.SelectedValue
        Catch ex As Exception

        End Try


        Dim Respuesta = Cliente.GuardarTarifa(Servicio, valor, unidad, Centro.Codigo, Bodega.Codigo)

        If Respuesta = True Then
            MsgBox("Tarifa Creada Exitosamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        Else
            MsgBox("No fue posible crear el Cliente. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If


    End Sub

    Private Sub DGTarifas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTarifas.CellContentClick

    End Sub
End Class