Public Class Areas

    Private _Codigo As String
    Private _Area As String
    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
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

    Public Function CualArea(Codigo) As String

        CualArea = ""

        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TAreas")
        dv.RowFilter = "IDAREA='" & Codigo & "'"


        Dim fila1 As DataRowView

        For Each fila1 In dv
            Return Trim(fila1("AREA"))
        Next

    End Function
    Public Function CualCodigo(Area) As String

        CualCodigo = ""

        Dim dv As New DataView

        dv.Table = Gl_DataSet.Tables("TAreas")
        dv.RowFilter = "AREA='" & Area & "'"


        Dim fila1 As DataRowView

        For Each fila1 In dv
            Return Trim(fila1("IDAREA"))
        Next

    End Function

End Class
