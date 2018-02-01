Public Class class_datos_sector
    Private _idsector As Integer
    Private _nombre As String
    Private _cod_zona As Integer

    Public Property id_sector As Integer
        Get
            Return _idsector
        End Get
        Set(value As Integer)
            _idsector = value
        End Set
    End Property

    Public Property nombre_sector As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property codZona_sector As Integer
        Get
            Return _cod_zona
        End Get
        Set(value As Integer)
            _cod_zona = value
        End Set
    End Property

End Class
