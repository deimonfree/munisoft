Public Class class_datos_conservacion
    Private _idtabla_conservacion As Integer
    Private _denominacion As String
    Public Property id_conservacionVivienda As Integer
        Get
            Return _idtabla_conservacion
        End Get
        Set(value As Integer)
            _idtabla_conservacion = value
        End Set
    End Property
    Public Property denominacion_conservacionVivienda As String
        Get
            Return _denominacion
        End Get
        Set(value As String)
            _denominacion = value
        End Set
    End Property

End Class
