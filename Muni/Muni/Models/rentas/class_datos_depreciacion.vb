Public Class class_datos_depreciacion
    Private _iddepreciacion As Integer
    Private _cod_clasificacion As Integer
    Private _cod_antiguedad As Integer
    Private _cod_conservacion As Integer
    Private _cod_material As Integer
    Private _valor As Integer
    Private _anno As Integer

    Public Property id_depreciacion As Integer
        Get
            Return _iddepreciacion
        End Get
        Set(value As Integer)
            _iddepreciacion = value
        End Set
    End Property

    Public Property clasificacion_depreciacion As Integer
        Get
            Return _cod_clasificacion
        End Get
        Set(value As Integer)
            _cod_clasificacion = value
        End Set
    End Property
    Public Property antiguedad_depreciacion As Integer
        Get
            Return _cod_antiguedad
        End Get
        Set(value As Integer)
            _cod_antiguedad = value
        End Set
    End Property
    Public Property conservacion_depreciacion As Integer
        Get
            Return _cod_conservacion
        End Get
        Set(value As Integer)
            _cod_conservacion = value
        End Set
    End Property
    Public Property material_depreciacion As Integer
        Get
            Return _cod_material
        End Get
        Set(value As Integer)
            _cod_material = value
        End Set
    End Property
    Public Property valor_depreciacion As Integer
        Get
            Return _valor
        End Get
        Set(value As Integer)
            _valor = value
        End Set
    End Property
    Public Property annio_depreciacion As Integer
        Get
            Return _anno
        End Get
        Set(value As Integer)
            _anno = value
        End Set
    End Property
End Class
