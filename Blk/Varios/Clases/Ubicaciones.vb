Public Class Ubicaciones

    Private _Codigo As String
    Private _Ubicacion As String
    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
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

    Public Function CualUbicacion(Codigo) As String

        CualUbicacion = ""

        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TUbicaciones")
        dv.RowFilter = "IDUBICACION='" & Codigo & "'"


        Dim fila1 As DataRowView

        For Each fila1 In dv
            Return Trim(fila1("UBICACION"))
        Next

    End Function
    Public Function CualCodigo(Ubicacion) As String

        CualCodigo = ""

        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TUbicaciones")
        dv.RowFilter = "UBICACION='" & Ubicacion & "'"


        Dim fila1 As DataRowView

        For Each fila1 In dv
            Return Trim(fila1("IDUBICACION"))
        Next

    End Function

End Class
