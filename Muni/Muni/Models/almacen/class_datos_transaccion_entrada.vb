Public Class class_datos_transaccion_entrada
    Private _idtransacion_entrada As Integer
    Private _codigo As String
    Private _description As String
    Public Property id_te As Integer
        Get
            Return _idtransacion_entrada
        End Get
        Set(value As Integer)
            _idtransacion_entrada = value
        End Set
    End Property
    Public Property codigo_te As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property
    Public Property description_te As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

End Class
