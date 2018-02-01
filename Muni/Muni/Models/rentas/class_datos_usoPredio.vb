Public Class class_datos_usoPredio
    Private _iduso_predio As Integer
    Private _denominacion As String
    Public Property id_usoPredio As Integer
        Get
            Return _iduso_predio
        End Get
        Set(value As Integer)
            _iduso_predio = value
        End Set
    End Property
    Public Property denominacion_usoPredio As String
        Get
            Return _denominacion
        End Get
        Set(value As String)
            _denominacion = value
        End Set
    End Property
End Class
