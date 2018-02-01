Public Class class_datos_ClasificacionVivienda
    Private _idtabla_usoVivienda As Integer
    Private _denominacion As String

    Public Property id_clasiVivienda As Integer
        Get
            Return _idtabla_usoVivienda
        End Get
        Set(value As Integer)
            _idtabla_usoVivienda = value
        End Set
    End Property
    Public Property denominacion_clasiVivienda As String
        Get
            Return _denominacion
        End Get
        Set(value As String)
            _denominacion = value
        End Set
    End Property

End Class
