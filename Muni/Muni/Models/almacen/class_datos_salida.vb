Public Class class_datos_salida
    Private _idsalida As Integer
    Private _fecha As Date
    Private _destino As String
    Private _cod_area As Integer
    Private _cod_almacen As Integer
    Public Property id_salida As Integer
        Get
            Return _idsalida
        End Get
        Set(value As Integer)
            _idsalida = value
        End Set
    End Property
    Public Property fecha_salida As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property destino_salida As String
        Get
            Return _destino
        End Get
        Set(value As String)
            _destino = value
        End Set
    End Property

    Public Property codArea_salida As Integer
        Get
            Return _cod_area
        End Get
        Set(value As Integer)
            _cod_area = value
        End Set
    End Property
    Public Property codAlmacen_salida As Integer
        Get
            Return _cod_almacen
        End Get
        Set(value As Integer)
            _cod_almacen = value
        End Set
    End Property

End Class
