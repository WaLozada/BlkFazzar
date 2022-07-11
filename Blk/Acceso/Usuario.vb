Imports System.Data.SqlClient

Public Class Usuario
    '----------------- Atributos -----------------
    Private _Codigo As String
    Private _Tdoc As String
    Private _Documento As Integer
    Private _Papellido As String
    Private _Sapellido As String
    Private _Nombre As String
    Private _FechaNac As String
    Private _Direccion As String
    Private _Telefono As String
    Private _Email As String
    Private _Area As String
    Private _Rol As String
    Private _FechaClave As String
    Private _Caducidad As String
    Private _FechaCaducidad As String
    Private _Estado As String
    Private _Paridad As String
    Private _Compañia As String
    Private _Ubicacion As String
    Private _Id As String

    '--------------- Propiedades ------------------
    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
        End Set
    End Property
    Public Property Tdoc As String
        Get
            Return _Tdoc
        End Get
        Set(value As String)
            _Tdoc = value
        End Set
    End Property
    Public Property Documento As String
        Get
            Return _Documento
        End Get
        Set(value As String)
            _Documento = value
        End Set
    End Property
    Public Property Papellido As String
        Get
            Return _Papellido
        End Get
        Set(value As String)
            _Papellido = value
        End Set
    End Property
    Public Property Sapellido As String
        Get
            Return _Sapellido
        End Get
        Set(value As String)
            _Sapellido = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
    Public Property FechaNac As String
        Get
            Return _FechaNac
        End Get
        Set(value As String)
            _FechaNac = value
        End Set
    End Property
    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property
    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property
    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property
    Public Property Area As String
        Get
            Return _Area
        End Get
        Set(value As String)
            _Area = value
        End Set
    End Property
    Public Property Rol As String
        Get
            Return _Rol
        End Get
        Set(value As String)
            _Rol = value
        End Set
    End Property
    Public Property FechaClave As String
        Get
            Return _FechaClave
        End Get
        Set(value As String)
            _FechaClave = value
        End Set
    End Property
    Public Property Caducidad As String
        Get
            Return _Caducidad
        End Get
        Set(value As String)
            _Caducidad = value
        End Set
    End Property
    Public Property FechaCaducidad As String
        Get
            Return _FechaCaducidad
        End Get
        Set(value As String)
            _FechaCaducidad = value
        End Set
    End Property
    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property
    Public Property Paridad As String
        Get
            Return _Paridad
        End Get
        Set(value As String)
            _Paridad = value
        End Set
    End Property
    Public Property Compañia As String
        Get
            Return _Compañia
        End Get
        Set(value As String)
            _Compañia = value
        End Set
    End Property
    Public Property Ubicacion As String
        Get
            Return _Ubicacion
        End Get
        Set(value As String)
            _Ubicacion = value
        End Set
    End Property
    Public Property Id As String
        Get
            Return _Id
        End Get
        Set(value As String)
            _Id = value
        End Set
    End Property

    '-------------------- Metodos ----------------------
    Public Sub Datosusuario(ByVal Usuario)

        Try

            Dim comando As New SqlClient.SqlCommand("sp_Logueo", Conn) With {
                .CommandType = CommandType.StoredProcedure
            }

            comando.Parameters.Add("@Accion", SqlDbType.NChar).Value = 1 ' Datos Totales
            comando.Parameters.Add("@Usuario", SqlDbType.NChar).Value = Trim(Usuario)

            '----- Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------

            Conn.Open()

            Dim Consulta As SqlDataReader
            Consulta = comando.ExecuteReader

            If Consulta.Read() Then
                UsuarioApp.Codigo = Trim(Consulta("CODIGO").ToString())
                UsuarioApp.Tdoc = Trim(Consulta("TDOC").ToString())
                UsuarioApp.Documento = Trim(Consulta("DOCUMENTO").ToString())
                UsuarioApp.Nombre = Trim(Consulta("NOMBRE").ToString())
                UsuarioApp.Papellido = Trim(Consulta("PAPELLIDO").ToString())
                UsuarioApp.Sapellido = Trim(Consulta("SAPELLIDO").ToString())
                UsuarioApp.Nombre = Trim(Consulta("NOMBRE").ToString())
                UsuarioApp.FechaNac = Trim(Consulta("FECHANAC").ToString())
                UsuarioApp.Direccion = Trim(Consulta("DIRECCION").ToString())
                UsuarioApp.Telefono = Trim(Consulta("TELEFONO").ToString())
                UsuarioApp.Email = Trim(Consulta("EMAIL").ToString())
                UsuarioApp.Area = (Trim(Consulta("AREA").ToString()))
                UsuarioApp.Rol = Trim(Consulta("ROL").ToString())
                UsuarioApp.FechaClave = (Trim(Consulta("FECHACLAVE").ToString()))
                UsuarioApp.Caducidad = (Trim(Consulta("CADUCIDAD").ToString()))
                UsuarioApp.FechaCaducidad = (Trim(Consulta("FECHACADUCIDAD").ToString()))
                UsuarioApp.Estado = (Trim(Consulta("ESTADO").ToString()))
                UsuarioApp.Paridad = Trim(Consulta("PARIDAD").ToString)
                UsuarioApp.Compañia = Trim(Consulta("COMPAÑIA").ToString)
                UsuarioApp.Ubicacion = Trim(Consulta("UBICACION").ToString())
                UsuarioApp.Id = Trim(Consulta("ID").ToString())
            End If
            Consulta.Close()

            If Conn.State = ConnectionState.Open Then Conn.Close()

        Catch ex As Exception
            Conn.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Gl_NomCompañia)
        End Try


        '-----------Verificar la no alteracion de clave en sistema --------

        Dim TempParidad As String

        TempParidad = SeguridadBlk.SHA1(UsuarioApp.Nombre & "@" & UsuarioApp.Documento & "@" & UsuarioApp.Papellido & "@" & Gl_Key)

        If TempParidad <> UsuarioApp.Paridad Then
            MsgBox("Acceso NO Autorizado!*", MsgBoxStyle.Critical, Gl_NomCompañia)
            If Conn.State = ConnectionState.Open Then Conn.Close()
            End
        End If
        '------------------------------------------------------------------

        '-----------Verificar si el usuario se encuentra activo --------
        If UsuarioApp.Estado = 0 Then
            MsgBox("EL Usuario " + UsuarioApp.Nombre + " " + UsuarioApp.Papellido + " se encuentra Inactivo en el Sistema. Consulta con el Administrador!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
            Conn.Close()
            End
        End If
        '------------------------------------------------------------------

        '-----------Verificar si la cuenta no caduco en el sistema --------
        If UsuarioApp.Caducidad = 0 Then
            ' Indefinida!
        ElseIf UsuarioApp.Caducidad = 1 Then

            If Date.Now > UsuarioApp.FechaCaducidad Then
                MsgBox("La cuenta del usuario " + UsuarioApp.Nombre + " " + UsuarioApp.Papellido + " caduco el pasado " + Trim(UsuarioApp.FechaCaducidad) + "." + Chr(13) + Chr(13) + "Consulte con el Administrador para la reactivación en caso de ser requerido!", MsgBoxStyle.Exclamation, Gl_NomCompañia)
                Conn.Close()
                End
            End If
        End If
        '------------------------------------------------------------------

        '--------- Verificacion proceso de cambio de clave --------------

        If Date.Now >= UsuarioApp.FechaClave Then   ' CAMBIO DE CLAVE CADA 90 DIAS!
            MsgBox("El tiempo de vigencia de la clave actual se ha terminado." + Chr(13) + Chr(13) + "Realice el cambio para Continuar!", MsgBoxStyle.Exclamation, Gl_NomCompañia)

            Gl_ClaveOK = 0
            For_UsuariosClave.ShowDialog()

            If Gl_ClaveOK = 1 Then
                ' Cambio clave correctamente
            Else
                If Conn.State = 1 Then Conn.Close()
                MsgBox("Acción Cancelada!", MsgBoxStyle.Critical, Gl_NomCompañia)
                End
            End If

        End If
        '-----------------------------------------------------------------

        If Conn.State = ConnectionState.Open Then Conn.Close()

    End Sub


End Class
