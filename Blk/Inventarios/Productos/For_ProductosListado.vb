Imports System.Data.SqlClient

Public Class For_ProductosListado

    Dim Producto As New Productos()
    Sub CargaDatasetProductos()

        '----- Cargara los Clientes en el Dataset Global --------------
        Dim Tabla As New DataTable("TProductos")
        Tabla.Load(Producto.ListarProductos)

        If Gl_DataSet.Tables.Contains("TProductos") Then Gl_DataSet.Tables.Remove("TProductos")

        Gl_DataSet.Tables.Add(Tabla)
        '--------------------------------------------------------------
    End Sub

    Sub Listar()
        Try
            DGProductos.DataSource = Nothing

            Dim Centros As New Centros()
            Dim Consulta As SqlDataReader
            Dim Tabla As New DataTable


            Consulta = Producto.ListarProductos()

            Tabla.Load(Consulta)
            DGProductos.DataSource = Tabla
            DGProductos.Columns("IDPRODUCTO").Visible = False
            DGProductos.Columns("ID").Visible = False
            Consulta.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try

        CargaDatasetProductos()

    End Sub
    Private Sub For_ProductosListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----- Centrar la Ventana ---------
        Me.Top = Ventanas.Arriba
        Me.Left = Ventanas.Izquierda
        Me.Height = Ventanas.Alto
        Me.Width = Ventanas.Ancho
        '----------------------------------

        Listar()
    End Sub
    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("20")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        If Producto.IdProducto <> "" Then

            Dim Rta = MsgBox("Desea Eliminar el Producto " + Producto.Descripcion + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

            If Rta = vbYes Then

                Dim Respuesta = Producto.BorrarProducto(Producto.IdProducto)

                If Respuesta = True Then
                    MsgBox("Producto Eliminado Exitosamente!", MsgBoxStyle.Information, Gl_NomCompañia)
                Else
                    MsgBox("No fue posible Eliminar el Producto. Consulte con el Administrador!", MsgBoxStyle.Critical, Gl_NomCompañia)
                    Exit Sub
                End If

                Listar()
            End If

        End If
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("21")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        If Producto.IdProducto <> "" Then
            Dim Rta = MsgBox("Desea Editar los datos de " + Producto.Descripcion + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Gl_NomCompañia)

            If Rta = vbYes Then

                Producto.CargarCombos()

                For_Productos.GBCodigo.Enabled = False
                For_Productos.TxtIdProducto.Text = Producto.IdProducto
                For_Productos.TxtCodigo.Text = Producto.Codigo
                For_Productos.TxtDescripcion.Text = Producto.Descripcion
                For_Productos.CmbFamilia.SelectedIndex = For_Productos.CmbFamilia.FindString(Producto.Familia)
                For_Productos.CmbUnidad.SelectedIndex = For_Productos.CmbUnidad.FindString(Producto.Unidad)
                For_Productos.CmbEmpaque.Text = Producto.Empaque

                For_Productos.BtnActualizar.Visible = True
                For_Productos.BtnAdicionar.Visible = False
                For_Productos.ShowDialog()

                Listar()

            End If
        End If

    End Sub
    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

        Dim Perfil As Boolean
        Perfil = ConsultaPerfil("20")

        If Perfil = False Then
            MsgBox("Acceso NO autorizado!", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = 1 Then Conn.Close()
            Exit Sub
        End If

        Producto.CargarCombos()
        For_Productos.GBCodigoProducto.Visible = False
        For_Productos.BtnActualizar.Visible = False
        For_Productos.BtnAdicionar.Visible = True
        For_Productos.ShowDialog()
        Listar()
    End Sub
    Private Sub DGProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProductos.CellClick
        Try
            Producto.IdProducto = Trim(DGProductos.Rows(e.RowIndex).Cells(0).Value)
            Producto.Codigo = Trim(DGProductos.Rows(e.RowIndex).Cells(1).Value)
            Producto.Descripcion = Trim(DGProductos.Rows(e.RowIndex).Cells(2).Value)
            Producto.Familia = Trim(DGProductos.Rows(e.RowIndex).Cells(3).Value)
            Producto.Unidad = Trim(DGProductos.Rows(e.RowIndex).Cells(4).Value)
            Producto.Empaque = Trim(DGProductos.Rows(e.RowIndex).Cells(5).Value)
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try
    End Sub

    Private Sub BtnAsignar_Click(sender As Object, e As EventArgs) Handles BtnAsignar.Click

        If Producto.IdProducto = "" Then
            MsgBox("Seleccione el Producto que desea Asignar a un Cliente!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            Exit Sub
        End If

        For_ProductosCliente.TxtCodigo.Text = Producto.Codigo
        For_ProductosCliente.TxtDescripcion.Text = Producto.Descripcion
        For_ProductosCliente.TxtIdProducto.Text = Producto.IdProducto
        For_ProductosCliente.ShowDialog()

    End Sub

End Class