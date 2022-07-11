Imports System.Data.SqlClient

Public Class For_EquiposMovimiento
    Dim Activos As New ActivosTI()
    Sub CargarCombos()

        '-------------- Cargo Las Areas ---------------------
        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TAreas")

        Me.CmbArea.DisplayMember = "AREA"
        Me.CmbArea.ValueMember = "IDAREA"
        Me.CmbArea.DataSource = dv
        Me.CmbArea.Text = ""
        Me.LblArea.Text = ""
        '-----------------------------------------------------


        '-------------- Cargo Los Lugares ---------------------
        Dim dv1 As New DataView

        dv1.Table = Gl_DataSet.Tables("TLugar")

        Me.CmbLugar.DisplayMember = "LUGAR"
        Me.CmbLugar.ValueMember = "IDLUGAR"
        Me.CmbLugar.DataSource = dv1
        Me.CmbLugar.Text = ""
        Me.LblLugar.Text = ""
        '-----------------------------------------------------

    End Sub
    Private Function Validar() As List(Of String)

        Dim ListaErrores As New List(Of String)

        If DGResultado.Rows.Count = 0 Then
            ListaErrores.Add("- Busque el activo que desea Asignar o Mover ")
        End If

        If Trim(TxtDivipol.Text) = "" Then
            ListaErrores.Add("- Seleccione la Ubicación del Activo")
        End If

        If Trim(TxtResponsable.Text) = "" Then
            ListaErrores.Add("- Seleccione el Responsable del Activo")
        End If

        If Trim(CmbLugar.Text) = "" Then
            ListaErrores.Add("- Seleccione el Lugar de ubicación del Activo")
        End If

        If Trim(CmbArea.Text) = "" Then
            ListaErrores.Add("- Seleccione el Area de Ubicación del Archivo")
        End If


        Return ListaErrores

    End Function
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

        Try
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable

            Consulta = Activos.ListarEquipo(Campo, Valor)

            Tabla.Load(Consulta)
            DGResultado.DataSource = Tabla

            DGResultado.Columns("IDTIPO").Visible = False
            'DGResultado.Columns("ID").Visible = False
            DGResultado.Columns("NOMBRE_POBLADO").HeaderText = "CIUDAD"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

        Try
            If DGResultado.SelectedRows.Count > 0 Then
                DGResultado.CurrentRow.Selected = False
            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub BtnBuscaCiudad_Click(sender As Object, e As EventArgs) Handles BtnBuscaCiudad.Click
        Gl_Divipolitica.Pais = ""
        Gl_Divipolitica.NombreDepto = ""
        Gl_Divipolitica.NombreMunicipio = ""
        Gl_Divipolitica.CodigoPoblado = ""


        For_Divipoliticas.ShowDialog()

        Me.TxtPais.Text = Gl_Divipolitica.Pais
        Me.TxtDepto.Text = Gl_Divipolitica.NombreDepto
        Me.TxtDivipol.Text = Gl_Divipolitica.CodigoPoblado
        Me.TxtMunicipio.Text = Gl_Divipolitica.NombreMunicipio
        Me.CmbLugar.Text = ""
        Me.LblLugar.Text = ""
        BtnBuscaResp.Focus()
    End Sub

    Private Sub BtnBuscaResp_Click(sender As Object, e As EventArgs) Handles BtnBuscaResp.Click
        GL_Empleado.Nombre = ""
        GL_Empleado.Apellido = ""
        GL_Empleado.Area = ""

        GL_Empleado.Cargareldataset()
        For_EmpleadosBuscar.ShowDialog()

        Me.TxtResponsable.Text = Trim(GL_Empleado.Nombre) & " " & Trim(GL_Empleado.Apellido)
        'Me.CmbArea.Text = GL_Empleado.Area
        'Me.LblArea.Text = GL_Empleado.Area

    End Sub

    Private Sub For_EquiposMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cargarcombos()

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Me.Panel1.Left = (Me.Width / 2) - (Panel1.Width / 2)
        Me.Panel1.Top = (Me.Top / 2) - (Panel1.Top / 2)
    End Sub

    Private Sub CmbElemento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbElemento.SelectedIndexChanged
        TxtNumero.Focus()
    End Sub

    Private Sub CmbElemento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbElemento.KeyPress
        e.Handled = True
    End Sub
    Private Sub TxtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnBuscar.Focus()
        End If
    End Sub

    Private Sub CmbLugar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbLugar.SelectedIndexChanged
        LblLugar.Text = Trim(CmbLugar.Text)
        CmbArea.Focus()
    End Sub

    Private Sub CmbLugar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbLugar.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbArea.KeyPress
        e.Handled = True
    End Sub

    Private Sub For_EquiposMovimiento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
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

        '----------- Ingresar Datos -------------------------------

        Activos.Ciudad = TxtDivipol.Text
        Activos.Responsable = GL_Empleado.IdEmpleado  ' codigo del empleado.
        Activos.Lugar = CmbLugar.SelectedValue
        Activos.Area = CmbArea.SelectedValue
        Activos.IdActivo = Trim(DGResultado.Rows(0).Cells(0).Value)

        Dim Respuesta = Activos.GuardarMovimiento()

        If Respuesta = True Then
            MsgBox("Movimiento Registrado Correctamente!", MsgBoxStyle.Information, Gl_NomCompañia)
        Else
            MsgBox("No fue Posible Registrar el Movimiento. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
        End If

        Me.Dispose()

        '-----------------------------------------------------------


    End Sub

    Private Sub CmbArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbArea.SelectedIndexChanged
        LblArea.Text = Trim(CmbArea.Text)
        BtnGuardar.Focus()
    End Sub
End Class