Imports System.Data.SqlClient

Public Class Divipoliticas
    '*************** Atributos **************************
    Private _Pais As String
    Private _CodigoDepto As String
    Private _NombreDepto As String
    Private _CodigoMunicipio As String
    Private _NombreMunicipio As String
    Private _CodigoPoblado As String
    Private _NombrePoblado As String
    Private _Tipo As String
    '***************** Propiedades ***********************
    Public Property Pais As String
        Get
            Return _Pais
        End Get
        Set(value As String)
            _Pais = value
        End Set
    End Property
    Public Property CodigoDepto As String
        Get
            Return _CodigoDepto
        End Get
        Set(value As String)
            _CodigoDepto = value
        End Set
    End Property
    Public Property NombreDepto As String
        Get
            Return _NombreDepto
        End Get
        Set(value As String)
            _NombreDepto = value
        End Set
    End Property
    Public Property CodigoMunicipio As String
        Get
            Return _CodigoMunicipio
        End Get
        Set(value As String)
            _CodigoMunicipio = value
        End Set
    End Property
    Public Property NombreMunicipio As String
        Get
            Return _NombreMunicipio
        End Get
        Set(value As String)
            _NombreMunicipio = value
        End Set
    End Property
    Public Property CodigoPoblado As String
        Get
            Return _CodigoPoblado
        End Get
        Set(value As String)
            _CodigoPoblado = value
        End Set
    End Property
    Public Property NombrePoblado As String
        Get
            Return _NombrePoblado
        End Get
        Set(value As String)
            _NombrePoblado = value
        End Set
    End Property
    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
        End Set
    End Property

    '***************** Metodos ***********************
    Public Sub CargarDivipoliticas()

        If Gl_DivipolCargadas = 0 Then ' Asegurarse de solo cargarlas 1 vez en el Dataset

            Dim comando As New SqlClient.SqlCommand("sp_Divipoliticas", Conn)
            comando.CommandType = CommandType.StoredProcedure
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            '------ Variable que recibe el Resultado ----------
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
            comando.Parameters("@Resultado").Direction = ParameterDirection.Output
            '-------------------------------------------------
            Dim Consulta As SqlDataReader

            Consulta = comando.ExecuteReader

            Gl_DataSet.Tables.Add("TDivipol")
            Gl_DataSet.Tables("TDivipol").Load(Consulta)
            Gl_DivipolCargadas = 1

            Conn.Close()

        End If

    End Sub
    Public Function CoincideDivipol(ByRef Nombre) As DataView

        '******* Busqueda de Municipio por coincidencia *************
        Dim dv As New DataView
        CoincideDivipol = New DataView

        dv.Table = Gl_DataSet.Tables("TDivipol")
        dv.RowFilter = "Nombre_municipio like '%" & (Nombre) & "%' and tipo='CM'"  ' Cabeceras Municipales

        CoincideDivipol = dv
        '*************************************************************

    End Function
    Public Function CodigoDivipol(ByVal Lugar, ByVal codigo) As String

        CodigoDivipol = ""

        Try

            Dim Fila As DataRow
            Dim DR() As DataRow

            DR = Gl_DataSet.Tables("TDivipol").Select("MUNICIPIO = '" & (codigo) & "'")

            If DR.Count > 0 Then

                For Each Fila In DR

                    CodigoDivipol = (Fila("NOMBREMUNICIPIO").ToString())
                    Exit For
                Next
            Else
                CodigoDivipol = "N/D"
            End If

        Catch ex As Exception
            MessageBox.Show("Error :" & vbCrLf & ex.Message)
            CodigoDivipol = "N/D"
        End Try


    End Function


End Class
