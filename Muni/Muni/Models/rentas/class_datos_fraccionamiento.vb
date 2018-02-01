Public Class class_datos_fraccionamiento
    Private _idfraccionamiento As String
    Private _periodo As String
    Private _fecha_vencimiento As String
    Private _monto_insulto As Decimal
    Private _derecho_emision As Decimal
    Private _monto_total As Decimal
    Private _estado_fraccion As String
    Private _automatizacion As Decimal
    Private _cod_autovaluo As Integer
    Public Property id_fraccionamiento As String
        Get
            Return _idfraccionamiento
        End Get
        Set(value As String)
            _idfraccionamiento = value
        End Set
    End Property
    Public Property periodo_autovaluo As String
        Get
            Return _periodo
        End Get
        Set(value As String)
            _periodo = value
        End Set
    End Property
    Public Property fecha_vencimiento_autovaluo As String
        Get
            Return _fecha_vencimiento
        End Get
        Set(value As String)
            _fecha_vencimiento = value
        End Set
    End Property
    Public Property monto_insoluto_autovaluo As Decimal
        Get
            Return _monto_insulto
        End Get
        Set(value As Decimal)
            _monto_insulto = value
        End Set
    End Property
    Public Property derecho_emision_autovaluo As Decimal
        Get
            Return _derecho_emision
        End Get
        Set(value As Decimal)
            _derecho_emision = value
        End Set
    End Property
    Public Property monto_total_autovaluo As Decimal
        Get
            Return _monto_total
        End Get
        Set(value As Decimal)
            _monto_total = value
        End Set
    End Property
    Public Property estado_autovaluo As String
        Get
            Return _estado_fraccion
        End Get
        Set(value As String)
            _estado_fraccion = value
        End Set
    End Property
    Public Property automatizacion_autovaluo As String
        Get
            Return _automatizacion
        End Get
        Set(value As String)
            _automatizacion = value
        End Set
    End Property

    Public Property cod_autovaluo As Integer
        Get
            Return _cod_autovaluo
        End Get
        Set(value As Integer)
            _cod_autovaluo = value
        End Set
    End Property

End Class
