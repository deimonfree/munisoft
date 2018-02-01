Public Class class_datos_material
    Private _idtabla_material As Integer
    Private _denominacion As String
    Public Property id_materialVivienda As Integer
        Get
            Return _idtabla_material
        End Get
        Set(value As Integer)
            _idtabla_material = value
        End Set
    End Property
    Public Property denominacion_materialVivienda As String
        Get
            Return _denominacion
        End Get
        Set(value As String)
            _denominacion = value
        End Set
    End Property

End Class
