Public Class class_datos_recibo
    Private _idrecibo As Integer
    Private _forma_pago As String
    Private _monto_recibo As Decimal
    Private _fecha_vencimiento As String
    Private _fecha_pago As String
    Private _estado_recibo As String
    Private _automatizacion As Decimal
    Private _cod_autovaluo As Integer
    Private _fecha_creacion As String
    Private _estado_campania As Integer
    Private _estado_moras As Integer

    Public Property id_recibo As Integer
        Get
            Return _idrecibo
        End Get
        Set(value As Integer)
            _idrecibo = value
        End Set
    End Property
    Public Property forma_pago As String
        Get
            Return _forma_pago
        End Get
        Set(value As String)
            _forma_pago = value
        End Set
    End Property
    Public Property monto_autovaluo As Decimal
        Get
            Return _monto_recibo
        End Get
        Set(value As Decimal)
            _monto_recibo = value
        End Set
    End Property
    Public Property fecha_vencimiento As String
        Get
            Return _fecha_vencimiento
        End Get
        Set(value As String)
            _fecha_vencimiento = value
        End Set
    End Property
    Public Property fecha_pago As String
        Get
            Return _fecha_pago
        End Get
        Set(value As String)
            _fecha_pago = value
        End Set
    End Property
    Public Property estado_recibo As String
        Get
            Return _estado_recibo
        End Get
        Set(value As String)
            _estado_recibo = value
        End Set
    End Property
    Public Property automatizacion_recibo As Decimal
        Get
            Return _automatizacion
        End Get
        Set(value As Decimal)
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
    Public Property fecha_creacion As String
        Get
            Return _fecha_creacion
        End Get
        Set(value As String)
            _fecha_creacion = value
        End Set
    End Property
    Public Property estado_campania As Integer
        Get
            Return _estado_campania
        End Get
        Set(value As Integer)
            _estado_campania = value
        End Set
    End Property
    Public Property estado_moras As Integer
        Get
            Return _estado_moras
        End Get
        Set(value As Integer)
            _estado_moras = value
        End Set
    End Property
End Class
