Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO

Public Class For_FacturasRegistro
    Dim CentroCosto As New CentroCostos()
    Dim FContable As New Contable()
    Dim Aprobador As New Aprobadores()


    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If Trim(TxtFactura.Text) = "" Then
            ListaErrores.Add("- Indique el Numero de Fcatura")
        End If

        If Trim(LblProveedor.Text) = "" Then
            ListaErrores.Add("- Seleccione el Proveedor")
        End If

        If Trim(LblRutafactura.Text) = "" Then
            ListaErrores.Add("- Seleccione la Factura")
        End If

        If Trim(TxtConcepto.Text) = "" Then
            ListaErrores.Add("- Digite el Concepto")
        End If

        Dim FechaExpedicion As String
        Dim FechaRecibido As String
        Dim FechaVencimiento As String

        FechaExpedicion = DTFechaExpedicion.Value
        FechaRecibido = DTFechaRecibido.Value
        FechaVencimiento = DTFechaVence.Value

        If FechaExpedicion > Date.Now Then
            ListaErrores.Add("Fecha de Expedición es mayor a la fecha Actual.")
        End If

        If FechaExpedicion > FechaVencimiento Then
            ListaErrores.Add("Fecha de Expedición es mayor a la fecha de Vencimiento.")
        End If

        If FechaExpedicion > FechaRecibido Then
            ListaErrores.Add("Fecha de Expedición es mayor a la fecha de Recibido.")
        End If

        If Trim(CmbProyecto.Text) = "" Then
            ListaErrores.Add("- Indique el proyecto al que pertenece la factura.")
        End If

        If CType(TxtSubtotal.Text, Decimal) = 0 Then
            ListaErrores.Add("- Digíte el valor del Subtotal.")
        End If

        If CType(TxtTotal.Text, Decimal) = 0 Then
            ListaErrores.Add("- Digíte el valor total.")
        End If

        If Trim(CmbCentroCosto.Text) = "" Then
            ListaErrores.Add("- Seleccione el Centro de Costo.")
        End If

        If CType(TxtValorCC.Text, Decimal) = 0 Then
            ListaErrores.Add("- Digíte el valor de Centro de Costo.")
        End If

        If Trim(CmbAprobador.Text) = "" Then
            ListaErrores.Add("- Seleccione el Responsable de Aprobar la Factura.")
        End If

        Dim SubTotal As Decimal
        Dim SubtotalCalculado As Decimal
        Dim Iva As Decimal
        Dim Total As Decimal
        Dim IvaCalculado As Decimal

        SubtotalCalculado = Math.Round(CType(TxtTotal.Text, Decimal) / 1.19)
        SubTotal = CType(TxtSubtotal.Text, Decimal)
        Iva = CType(TxtIva.Text, Decimal)
        Total = CType(TxtTotal.Text, Decimal)

        IvaCalculado = Math.Round(SubTotal * 0.19)


        If Iva > 0 Then

            If IvaCalculado <> Iva Then
                ListaErrores.Add("- El Valor del IVA ingresado no es correcto." + Chr(13) + "Valor Real : " & FormatCurrency(IvaCalculado, 0))
            End If

            If (SubtotalCalculado + Iva) <> Total Then
                ListaErrores.Add("- El Valor Total ingresado no es correcto.")
            End If

        Else
            If SubTotal <> Total Then
                ListaErrores.Add("- El valor Total ingresado no es correcto.")
            End If


        End If


        Return ListaErrores

    End Function
    Sub CargarCombos()

        '-------------------- Cargo los Proyectos -------------
        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = CentroCosto.ListarProyectos()

        Tabla.Load(Consulta)

        Me.CmbProyecto.DisplayMember = "PROYECTO"
        Me.CmbProyecto.DataSource = Tabla
        Me.CmbProyecto.Text = ""
        '-----------------------------------------------------

        '-------------------- Cargo los Transportadores ------
        Dim Tabla1 As New DataTable
        Dim Consulta1 As SqlDataReader
        Consulta1 = Aprobador.ListarAprobadores()

        Tabla1.Load(Consulta1)

        Me.CmbAprobador.DisplayMember = "NOMBRE"
        Me.CmbAprobador.ValueMember = "DOCUMENTO"
        Me.CmbAprobador.DataSource = Tabla1
        Me.CmbAprobador.Text = ""
        '-----------------------------------------------------

        GL_Proveedor.Cargareldataset()

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
        '************************** Cargar Archivo en el Ftp ***************************************

        'Dim Rta = CargaralFtp("Facturas", Path.GetDirectoryName(LblRutafactura.Text), Path.GetFileName(LblRutafactura.Text))


        'If Rta <> "OK" Then
        '    MsgBox("No fue posible cargar la Factura al Repositorio. Consulte con el Admministrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        '    Exit Sub
        'End If

        '************************** Insertar Información a la Base de Datos ************************

        FContable.NumFac = Trim(TxtFactura.Text)
        FContable.IdProveedor = Trim(LblProveedor.Tag)
        FContable.Concepto = Trim(TxtConcepto.Text)
        FContable.FechaExp = DTFechaExpedicion.Value
        FContable.FechaRec = DTFechaRecibido.Value
        FContable.FechaVen = DTFechaVence.Value
        FContable.Subtotal = CType(TxtSubtotal.Text, Decimal)
        FContable.Iva = CType(TxtIva.Text, Decimal)
        FContable.Total = CType(TxtTotal.Text, Decimal)
        FContable.Proyecto = Trim(CmbProyecto.Text)
        FContable.CentroCosto = Trim(LblCC.Text)
        FContable.ValorCC = CType(TxtValorCC.Text, Decimal)
        FContable.Observaciones = Trim(TxtObservaciones.Text)
        FContable.RutaFactura = Trim(LblRutafactura.Text)
        FContable.UsuarioRegistro = Trim(UsuarioApp.Documento)
        FContable.PcRegistro = Trim(Environment.MachineName)
        FContable.Aprobacion = "PENDIENTE"
        FContable.Aprobador = Trim(CmbAprobador.SelectedValue)

        Dim Respuesta = FContable.GuardarFactura()

        If Respuesta = "OK" Then
            MsgBox("Factura Registrada Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
            Me.Dispose()
        Else
            MsgBox("No fue posible Registrar la Factura. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        '**********************************************************************************************


    End Sub
    Private Sub For_FacturasRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Top = Ventanas.Arriba
        Me.Height = Ventanas.Alto

        CargarCombos()
        GL_Proveedor.LimpiarVariableGlobal()
    End Sub
    Private Sub CmbProyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProyecto.SelectedIndexChanged

        '-------------------- Cargo los Centros de Costo -------------
        Dim Tabla As New DataTable
        Dim Consulta As SqlDataReader
        Consulta = CentroCosto.ListarCentros(2, Trim(CmbProyecto.Text))

        Tabla.Load(Consulta)

        Me.CmbCentroCosto.DisplayMember = "NOMBRE"
        Me.CmbCentroCosto.ValueMember = "SIGLA"
        Me.CmbCentroCosto.DataSource = Tabla
        Me.CmbCentroCosto.Text = ""
        Me.LblCC.Text = ""
        '-----------------------------------------------------

        TxtSubtotal.Focus()


    End Sub
    Private Sub CmbCentroCosto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCentroCosto.SelectedIndexChanged
        LblCC.Text = CmbCentroCosto.SelectedValue
        TxtValorCC.Focus()
    End Sub
    Private Sub CmbCentroCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCentroCosto.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbProyecto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbProyecto.KeyPress
        e.Handled = True
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        For_ProveedoresBuscar.ShowDialog()

        If GL_Proveedor.Codigo <> "" Then
            LblProveedor.Text = GL_Proveedor.Nombre
            LblProveedor.Tag = GL_Proveedor.Codigo
        End If

    End Sub
    Private Sub For_FacturasRegistro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub TxtSubtotal_LostFocus(sender As Object, e As EventArgs) Handles TxtSubtotal.LostFocus

        'Dim Valor As Double = Val(TxtSubtotal.Text)

        'Valor.ToString("#,#", CultureInfo.InvariantCulture)
        'TxtSubtotal.Text = String.Format(CultureInfo.InvariantCulture, "{0:#,#}", Valor)
        Try
            If TxtSubtotal.Text = "" Then
                TxtSubtotal.Text = "$ 0"
            Else
                TxtSubtotal.Text = FormatCurrency(TxtSubtotal.Text, 0)
            End If

        Catch ex As Exception
        End Try


    End Sub

    Private Sub TxtSubtotal_GotFocus(sender As Object, e As EventArgs) Handles TxtSubtotal.GotFocus
        Try
            If TxtSubtotal.Text = "$ 0" Then
                TxtSubtotal.Text = ""
            Else
                TxtSubtotal.Text = CType(TxtSubtotal.Text, Decimal)
            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub TxtIva_LostFocus(sender As Object, e As EventArgs) Handles TxtIva.LostFocus
        Try
            If TxtIva.Text = "" Then
                TxtIva.Text = "$ 0"
            Else
                TxtIva.Text = FormatCurrency(TxtIva.Text, 0)
            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub TxtIva_GotFocus(sender As Object, e As EventArgs) Handles TxtIva.GotFocus

        Try
            If TxtIva.Text = "$ 0" Then
                TxtIva.Text = ""
            Else
                TxtIva.Text = CType(TxtIva.Text, Decimal)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub TxtTotal_LostFocus(sender As Object, e As EventArgs) Handles TxtTotal.LostFocus

        Try
            If TxtTotal.Text = "" Then
                TxtTotal.Text = "$ 0"
            Else
                TxtTotal.Text = FormatCurrency(TxtTotal.Text, 0)
            End If

        Catch ex As Exception
        End Try


    End Sub

    Private Sub TxtTotal_GotFocus(sender As Object, e As EventArgs) Handles TxtTotal.GotFocus
        Try
            If TxtTotal.Text = "$ 0" Then
                TxtTotal.Text = ""
            Else
                TxtTotal.Text = CType(TxtTotal.Text, Decimal)
            End If


        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtValorCC_GotFocus(sender As Object, e As EventArgs) Handles TxtValorCC.GotFocus
        Try
            If TxtValorCC.Text = "$ 0" Then
                TxtValorCC.Text = ""
            Else
                TxtValorCC.Text = CType(TxtValorCC.Text, Decimal)
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtValorCC_LostFocus(sender As Object, e As EventArgs) Handles TxtValorCC.LostFocus
        Try
            If TxtValorCC.Text = "" Then
                TxtValorCC.Text = "$ 0"
            Else
                TxtValorCC.Text = FormatCurrency(TxtValorCC.Text, 0)
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtSubtotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSubtotal.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtIva.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIva.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtTotal.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub
    Private Sub TxtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTotal.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmbCentroCosto.Focus()
        Else
            Dim Rta As Boolean
            Rta = SoloNumeros(e.KeyChar)
            e.Handled = Rta
        End If
    End Sub

    Private Sub BtnAdjuntar_Click(sender As Object, e As EventArgs) Handles BtnAdjuntar.Click

        Try
            LblRutafactura.Text = My.Computer.Clipboard.GetText()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'ODRutaArchivo.FileName = ""
        'ODRutaArchivo.Filter = "Documentos PDF|*.pdf"

        'ODRutaArchivo.ShowDialog()

        'LblRutafactura.Text = ODRutaArchivo.FileName

        'If LblRutafactura.Text = "" Then
        '    'MsgBox("Seleccione el archivo a a cargar!", MsgBoxStyle.Critical, GL_NOMBREESTAB)
        '    Exit Sub
        'End If

    End Sub

    Private Sub CmbAprobador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAprobador.SelectedIndexChanged
        BtnGuardar.Focus()
    End Sub

    Private Sub CmbAprobador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbAprobador.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        LblRutafactura.Text = ""
    End Sub

    Private Sub TxtSubtotal_TextChanged(sender As Object, e As EventArgs) Handles TxtSubtotal.TextChanged

    End Sub
End Class