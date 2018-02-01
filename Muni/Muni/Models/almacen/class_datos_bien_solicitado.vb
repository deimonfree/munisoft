Public Class class_datos_bien_solicitado
    Private _cantidad As Integer
    Private _cod_bien As Integer
    Private _cod_requerimiento As Integer

    Public Property cantidad_bs As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property
    Public Property codBien_bs As Integer
        Get
            Return _cod_bien
        End Get
        Set(value As Integer)
            _cod_bien = value
        End Set
    End Property
    Public Property codRequerimiento As Integer
        Get
            Return _cod_requerimiento
        End Get
        Set(value As Integer)
            _cod_requerimiento = value
        End Set
    End Property
End Class
