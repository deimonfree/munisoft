Public Class class_datos_detalle_entrada
    Private _iddetalle_entrada As Integer
    Private _cantidad As Integer
    Private _costo As Decimal
    Private _cod_bien As Integer
    Private _cod_entrada As Integer
    Public Property id_de As Integer
        Get
            Return _iddetalle_entrada
        End Get
        Set(value As Integer)
            _iddetalle_entrada = value
        End Set
    End Property
    Public Property cantidad_de As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property
    Public Property costo_de As Decimal
        Get
            Return _costo
        End Get
        Set(value As Decimal)
            _costo = value
        End Set
    End Property
    Public Property codBien_de As Integer
        Get
            Return _cod_bien
        End Get
        Set(value As Integer)
            _cod_bien = value
        End Set
    End Property
    Public Property codEntrada As Integer
        Get
            Return _cod_entrada
        End Get
        Set(value As Integer)
            _cod_entrada = value
        End Set
    End Property
End Class
