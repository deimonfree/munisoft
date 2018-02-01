Public Class class_datos_transaccion_salida
    Private _idtransacion_salida As Integer
    Private _codigo As String
    Private _description As String

    Public Property id_ts() As Integer
        Get
            Return _idtransacion_salida
        End Get
        Set(value As Integer)
            _idtransacion_salida = value
        End Set
    End Property
    Public Property codigo_ts() As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property
    Public Property description_ts() As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

End Class
