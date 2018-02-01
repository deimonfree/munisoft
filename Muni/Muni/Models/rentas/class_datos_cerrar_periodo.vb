Public Class class_datos_cerrar_periodo
    Private _idcerrar_periodo As Integer
    Private _modulo As String
    Private _annio As String
    Private _estado As String

    Public Property id_cerrar_periodo As Integer
        Get
            Return _idcerrar_periodo
        End Get
        Set(value As Integer)
            _idcerrar_periodo = value
        End Set
    End Property

    Public Property modulo_cerrar As String
        Get
            Return _modulo
        End Get
        Set(value As String)
            _modulo = value
        End Set
    End Property
    Public Property annio_cerrar As String
        Get
            Return _annio
        End Get
        Set(value As String)
            _annio = value
        End Set
    End Property
    Public Property estado_cerrar As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property
End Class
