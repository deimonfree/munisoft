Public Class class_datos_via
    Private _idvia As Integer
    Private _tipo As Integer
    Private _nombre As String
    Private _cuadra As Integer
    Private _cod_sector As Integer

    Public Property id_via As Integer
        Get
            Return _idvia
        End Get
        Set(value As Integer)
            _idvia = value
        End Set
    End Property

    Public Property tipo_via As Integer
        Get
            Return _tipo
        End Get
        Set(value As Integer)
            _tipo = value
        End Set
    End Property
    Public Property nombre_via As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property cuadra_via As Integer
        Get
            Return _cuadra
        End Get
        Set(value As Integer)
            _cuadra = value
        End Set
    End Property
    Public Property codSector_via As Integer
        Get
            Return _cod_sector
        End Get
        Set(value As Integer)
            _cod_sector = value
        End Set
    End Property

End Class
