Public Class class_datos_estadoPredio
    Private _idestado_predio As Integer
    Private _denominacion As String
    Public Property id_estadoPredio As Integer
        Get
            Return _idestado_predio
        End Get
        Set(value As Integer)
            _idestado_predio = value

        End Set
    End Property
    Public Property denominacion_estadoPredio As String
        Get
            Return _denominacion
        End Get
        Set(value As String)
            _denominacion = value
        End Set
    End Property
End Class
