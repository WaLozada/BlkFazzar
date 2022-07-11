Public Class Ventana

    Private _Arriba As Integer = 130
    Private _Izquierda As Integer = 0
    Private _Ancho As Integer
    Private _Alto As Integer

    Public Property Arriba As String
        Get
            Return _Arriba
        End Get
        Set(value As String)
            _Arriba = value
        End Set
    End Property
    Public Property Izquierda As String
        Get
            Return _Izquierda
        End Get
        Set(value As String)
            _Izquierda = value
        End Set
    End Property
    Public Property Ancho As String
        Get
            Return For_Principal.Width - 20
        End Get
        Set(value As String)
            _Ancho = value
        End Set
    End Property
    Public Property Alto As String
        Get
            Return For_Principal.Height - 170
        End Get
        Set(value As String)
            _Alto = value
        End Set
    End Property


End Class
