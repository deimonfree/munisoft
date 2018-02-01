Public Class class_datos_vias_relacionadas
    Private _idvias_relacionadas As Integer
    Private _cod_vias As Integer
    Private _cod_grupo_catastral As Integer

    Public Property idvias_relacionadas As Integer
        Get
            Return _idvias_relacionadas
        End Get
        Set(value As Integer)
            _idvias_relacionadas = value
        End Set
    End Property

    Public Property cod_vias As Integer
        Get
            Return _cod_vias
        End Get
        Set(value As Integer)
            _cod_vias = value
        End Set
    End Property
    Public Property cod_grupo_catastral As Integer
        Get
            Return _cod_grupo_catastral
        End Get
        Set(value As Integer)
            _cod_grupo_catastral = value
        End Set
    End Property

End Class
