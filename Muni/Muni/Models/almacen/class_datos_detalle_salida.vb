Public Class class_datos_detalle_salida
    Private _iddetalle_salida As Integer
    Private _cantidad As Integer
    Private _cod_bien As Integer
    Private _cod_salida As Integer
    Public Property id_ds As Integer
        Get
            Return _iddetalle_salida
        End Get
        Set(value As Integer)
            _iddetalle_salida = value
        End Set
    End Property
    Public Property cantidad_ds As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property
    Public Property codBien_ds As Integer
        Get
            Return _cod_bien
        End Get
        Set(value As Integer)
            _cod_bien = value
        End Set
    End Property
    Public Property codSalida_ds As Integer
        Get
            Return _cod_salida
        End Get
        Set(value As Integer)
            _cod_salida = value
        End Set
    End Property

End Class
