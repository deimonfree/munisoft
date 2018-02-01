Public Class class_datos_tipoPredio
    Private _idtipo_predio As Integer
    Private _denominacion As String
    Public Property id_tipoPredio As Integer
        Get
            Return _idtipo_predio
        End Get
        Set(value As Integer)
            _idtipo_predio = value
        End Set
    End Property
    Public Property denominacion_tipoPredio As String
        Get
            Return _denominacion
        End Get
        Set(value As String)
            _denominacion = value
        End Set
    End Property

End Class
