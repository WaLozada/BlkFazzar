Imports System.Data.SqlClient

Public Class For_OrdenesServicioRegistrar
    Dim Centro As New Centros()
    Dim OrdenServicioMacro As New ClsOrdenesServicioMacro()

    Dim NombreCliente As String
    Dim CodDeposito As String = ""
    Sub CargarCombo()

        '-------------------- Cargo los Centros -------------
        Dim Tabla As New DataTable
        Dim Consulta As SqlClient.SqlDataReader
        Consulta = Centro.ListarCentro()

        Tabla.Load(Consulta)

        Me.CmbCentros.DisplayMember = "NOMBRE"
        Me.CmbCentros.ValueMember = "CODIGO"
        Me.CmbCentros.DataSource = Tabla
        Me.CmbCentros.Text = ""
        '-----------------------------------------------------


        '-------------- Cargo Los Tipos de Vehiculos ---------
        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TServiciosMacro")

        Me.CmbServicioMacro.DisplayMember = "SERVICIO"
        Me.CmbServicioMacro.ValueMember = "IDSERVICIO"
        Me.CmbServicioMacro.DataSource = dv
        Me.CmbServicioMacro.Text = ""
        '-----------------------------------------------------


    End Sub

    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If CmbCentros.Text = "" Then
            ListaErrores.Add("Seleccione el Centro de Distribución")
        End If

        If Trim(TxtCodCliente.Text) = "" Then
            ListaErrores.Add("Seleccione el cliente del Servicio")
        End If

        If Trim(CmbServicioMacro.Text) = "" Then
            ListaErrores.Add("Seleccione el Servicio principal que se prestara")
        End If

        If Trim(TxtObservaciones.Text) = "" Then
            ListaErrores.Add("Inidique una corta observación del servicio")
        End If


        Return ListaErrores

    End Function
    Private Sub For_OrdenesServicioRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Gl_Cliente.Cargareldataset() ' Cargo los Clientes Actuales en el Dataset Global
        Gl_Cliente.LimpiarVariableGlobal() ' Limpio la variable Global de Clientes 


        For_ClientesBuscar.ShowDialog()

        If Gl_Cliente.Codigo = "" Then ' Si no selecciona ningun cliente no debe Continuar.
            Exit Sub
        End If

        Me.TxtCodCliente.Text = Gl_Cliente.Codigo
        Me.LblNombreCliente.Text = Gl_Cliente.Cliente


    End Sub
    Private Sub CmbServicioMacro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbServicioMacro.SelectionChangeCommitted

        TxtObservaciones.Focus()

    End Sub

    Private Sub CmbServicioMacro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbServicioMacro.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click


        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        OrdenServicioMacro.Centro = CmbCentros.SelectedValue
        OrdenServicioMacro.Cliente = TxtCodCliente.Text
        OrdenServicioMacro.Servicio = CmbServicioMacro.SelectedValue
        OrdenServicioMacro.Observaciones = Trim(TxtObservaciones.Text)

        Dim Respuesta = OrdenServicioMacro.GuardarOSM()

        If Respuesta = True Then
            MsgBox("Orden Macro Creada exitosamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        Else
            MsgBox("No fue posible la creacion de la OSM, Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If


    End Sub
End Class