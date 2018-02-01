Public Class class_datos_log_recibo
    Private _id_log_recibos As Integer
    Private _user As String
    Private _namepc As String
    Private _ip As String
    Private _fecha As String
    Private _monto As Decimal
    Private _cod_autovaluo As Integer

    Public Property id_log_recibos As Integer
        Get
            Return _id_log_recibos
        End Get
        Set(value As Integer)
            _id_log_recibos = value
        End Set
    End Property
    Public Property user As String
        Get
            Return _user
        End Get
        Set(value As String)
            _user = value
        End Set
    End Property
    Public Property namepc As String
        Get
            Return _namepc
        End Get
        Set(value As String)
            _namepc = value
        End Set
    End Property
    Public Property ip As String
        Get
            Return _ip
        End Get
        Set(value As String)
            _ip = value
        End Set
    End Property
    Public Property fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property
    Public Property monto As Decimal
        Get
            Return _monto
        End Get
        Set(value As Decimal)
            _monto = value
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
