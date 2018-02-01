Public Class class_datos_regimen
    Private _idregimen As Integer
    Private _nombre As Integer

    Public Property id_regimen As Integer
        Get
            Return _idregimen
        End Get
        Set(value As Integer)
            _idregimen = value
        End Set
    End Property

    Public Property nombre_regimen As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
End Class
