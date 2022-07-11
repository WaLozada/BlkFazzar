Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class For_EquiposMantenimiento
    Dim Activos As New ActivosTI()
    Dim FechaMto As DateTime
    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If Trim(LblActivo.Text) = "" Then
            ListaErrores.Add("- Debe indicar el activo al cual se le realizó el mantenimiento.")
        End If

        If RBPreventivo.Checked = False And RBCorrectivo.Checked = False Then
            ListaErrores.Add("- Debe indicar el tipo de mantenimiento realizado.")
        End If

        If RBProveedor.Checked = False And RBColaborador.Checked = False Then
            ListaErrores.Add("- Debe indicar quien realizó el mantenimiento.")
        End If

        If Trim(LblResponsable.Text) = "" Then
            ListaErrores.Add("- Debe indicar el responsable del mantenimiento.")
        End If

        If Trim(TxtObservaciones.Text) = "" Then
            ListaErrores.Add("- Debe indicar una descripción breve de lo realizado en el mantenimiento.")
        End If

        If FechaMto > Date.Now Then
            ListaErrores.Add("- La fecha del mantenimiento es mayor a la fecha actual.")
        End If

        Return ListaErrores

    End Function
    Private Sub For_EquiposMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Me.Panel1.Left = (Me.Width / 2) - (Panel1.Width / 2)

    End Sub

    Private Sub BtnRepuestos_Click(sender As Object, e As EventArgs) Handles BtnRepuestos.Click

        If LblActivo.Text = "" Then
            MsgBox("Debe indicar primero el activo al cual registrará los repuestos usados!", MsgBoxStyle.Critical, Gl_NomCompañia)
            TxtNumero.Focus()
            Exit Sub
        End If

        For_EquiposRepuestos.ShowDialog()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        If TxtNumero.Text = "" Then
            MsgBox("Nada Para Consultar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            Exit Sub
        End If

        Dim Campo As String = Trim(CmbElemento.Text)
        Dim Valor As String = ""

        If Campo = "ACTIVO" Then
            Valor = String.Format("{0:00000}", Val(TxtNumero.Text))
        Else
            Valor = Trim(TxtNumero.Text)
        End If


        '--------- Listar los datos del Activo seleccionado en un DG tempotal ----------------------
        Try
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Activos.ListarEquipo(Campo, Valor)

            Tabla.Load(Consulta)
            DGResultado.DataSource = Tabla 'Dgtemporal

            LblActivo.Text = DGResultado.Rows(0).Cells(0).Value
            LblElemento.Text = DGResultado.Rows(0).Cells(2).Value
            LblMarca.Text = DGResultado.Rows(0).Cells(3).Value
            LblModelo.Text = DGResultado.Rows(0).Cells(4).Value
            LblSerial.Text = DGResultado.Rows(0).Cells(5).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

        Try
            If DGResultado.SelectedRows.Count > 0 Then
                DGResultado.CurrentRow.Selected = False
            End If

        Catch ex As Exception
        End Try
        '-----------------------------------------------------------------------------------

        '----------- Listar los Mantenimientos que se han realizado al activo/serial ingresado
        Try
            Dim Consulta1 As SqlDataReader
            Dim Tabla1 As New DataTable

            Consulta1 = Activos.ListarMantenimientos(LblActivo.Text)

            Tabla1.Load(Consulta1)
            DGHistorico.DataSource = Tabla1

            DGHistorico.Columns("IDACTIVO").Visible = False
            DGHistorico.Columns("NOMBRE").HeaderText = "REALIZADO POR"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

        Try
            If DGHistorico.SelectedRows.Count > 0 Then
                DGHistorico.CurrentRow.Selected = False
            End If

        Catch ex As Exception
        End Try
        '------------------------------------------------------------------------------

        DGHistorico.Sort(DGHistorico.Columns("IDMTO"), ListSortDirection.Ascending)

    End Sub
    Private Sub TxtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnBuscar.Focus()
        End If
    End Sub

    Private Sub CmbElemento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbElemento.SelectedIndexChanged
        TxtNumero.Focus()
    End Sub

    Private Sub CmbElemento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbElemento.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnBuscarProv_Click(sender As Object, e As EventArgs) Handles BtnBuscarProv.Click

        If RBProveedor.Checked = False And RBColaborador.Checked = False Then
            MsgBox("Seleccione proveedor o colaborador según quien realizó el mantenimiento!", MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If

        If RBProveedor.Checked = True Then ' Proveedor

            GL_Proveedor.Cargareldataset()
            For_ProveedoresBuscar.ShowDialog()

            If GL_Proveedor.Codigo <> "" Then
                LblResponsable.Text = GL_Proveedor.Nombre
                LblResponsable.Tag = GL_Proveedor.Codigo
                TxtObservaciones.Focus()
            End If

        Else ' Colaborador

            GL_Empleado.Nombre = ""
            GL_Empleado.Apellido = ""
            GL_Empleado.Area = ""

            GL_Empleado.Cargareldataset()
            For_EmpleadosBuscar.ShowDialog()

            LblResponsable.Text = Trim(GL_Empleado.Nombre) & " " & Trim(GL_Empleado.Apellido)
            LblResponsable.Tag = GL_Empleado.IdEmpleado
            TxtObservaciones.Focus()
        End If

    End Sub

    Private Sub RBProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles RBProveedor.CheckedChanged
        LblResponsable.Text = ""
        LblResponsable.Tag = ""
    End Sub

    Private Sub RBColaborador_CheckedChanged(sender As Object, e As EventArgs) Handles RBColaborador.CheckedChanged
        LblResponsable.Text = ""
        LblResponsable.Tag = ""
    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

        FechaMto = CalendarFechaMto.SelectionRange.Start.Year & "/" & Long.Parse(CalendarFechaMto.SelectionRange.Start.Month).ToString("00") & "/" & Long.Parse(CalendarFechaMto.SelectionRange.Start.Day).ToString("00")

        Dim Resultado = Validar()
        Dim Mostrar As String = ""

        If Resultado.Count > 0 Then

            For Each item As String In Resultado
                Mostrar += item & Chr(13)
            Next

            MsgBox(Mostrar, MsgBoxStyle.Critical, Gl_NomCompañia)
            Exit Sub
        End If


        '----------- Ingresar Datos -------------------------------

        Activos.IdActivo = Trim(LblActivo.Text)

        If RBPreventivo.Checked = True Then
            Activos.TipoMto = 1
        Else
            Activos.TipoMto = 2
        End If

        If RBProveedor.Checked = True Then
            Activos.Realizadopor = 1 ' Proveedor
        Else
            Activos.Realizadopor = 2 ' Colaborador
        End If
        Activos.Responsable = LblResponsable.Tag  ' codigo del Proveedor/Empleado
        Activos.FechaMto = Format(FechaMto, "yyyy-MM-dd")
        Activos.Observaciones = Trim(TxtObservaciones.Text)

        '-- Caracteristicas --
        Activos.Repuestos = DGRepuestos
        '---------------
        Dim Respuesta = Activos.GuardarMantenimiento()

        If Respuesta = True Then
            MsgBox("Mantenimiento Registrado Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
        Else
            MsgBox("No fue Posible Registrar el Mantenimiento. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        Me.Dispose()

        '-----------------------------------------------------------

    End Sub

    Private Sub For_EquiposMantenimiento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub DGHistorico_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGHistorico.CellClick

        If DGHistorico.Rows(e.RowIndex).Cells("REPUESTOS").Value = "NO" Then
            MsgBox("Este mantenimiento no incluyó repuestos adicionales!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            Exit Sub
        Else

            '--------- Listar los datos del Activo seleccionado en un DG tempotal ----------------------
            Try
                Dim Consulta As SqlDataReader
                Dim Tabla As New DataTable

                Consulta = Activos.ListarMantenimientos(DGHistorico.Rows(e.RowIndex).Cells("IDACTIVO").Value, DGHistorico.Rows(e.RowIndex).Cells("IDMTO").Value)

                Tabla.Load(Consulta)
                For_EquiposRepuestosVer.DGRepuestos.DataSource = Tabla
                For_EquiposRepuestosVer.DGRepuestos.Columns("IDACTIVO").Visible = False

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
            End Try

            Try
                If DGResultado.SelectedRows.Count > 0 Then
                    DGResultado.CurrentRow.Selected = False
                End If

            Catch ex As Exception
            End Try
            '-----------------------------------------------------------------------------------

            For_EquiposRepuestosVer.ShowDialog()


        End If

    End Sub
End Class