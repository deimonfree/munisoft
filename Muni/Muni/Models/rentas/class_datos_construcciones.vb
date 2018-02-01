Public Class class_datos_construcciones
    Private _idconstruccion As Integer
    Private _piso As Integer
    Private _antiguedad As Integer
    Private _codigo_clasificacion As Integer
    Private _clasificacion As String
    Private _codigo_material As Integer
    Private _material As String
    Private _codigo_estadoconservacion As Integer
    Private _estadoconservacion As String
    Private _categoria As String
    Private _valor_unitario As Double
    Private _inc_5x100 As Double
    Private _x100_dep As Double
    Private _val_dep As Double
    Private _val_unidaddep As Double
    Private _area_construida As Double
    Private _total As Double
    Private _cod_ficha As Integer
    Private _predio As String

    Public Property id_construccion As Integer
        Get
            Return _idconstruccion
        End Get
        Set(value As Integer)
            _idconstruccion = value
        End Set
    End Property
    Public Property piso_construccion As Integer
        Get
            Return _piso
        End Get
        Set(value As Integer)
            _piso = value
        End Set
    End Property
    Public Property antiguedad_construccion As Integer
        Get
            Return _antiguedad
        End Get
        Set(value As Integer)
            _antiguedad = value
        End Set
    End Property
    Public Property codClasificacion_construccion As Integer
        Get
            Return _codigo_clasificacion
        End Get
        Set(value As Integer)
            _codigo_clasificacion = value
        End Set
    End Property

    Public Property clasificacion_construccion As String
        Get
            Return _clasificacion
        End Get
        Set(value As String)
            _clasificacion = value
        End Set
    End Property
    Public Property codMaterial_construccion As Integer
        Get
            Return _codigo_material
        End Get
        Set(value As Integer)
            _codigo_material = value
        End Set
    End Property
    Public Property material_construccion As String
        Get
            Return _material
        End Get
        Set(value As String)
            _material = value
        End Set
    End Property
    Public Property codEstConserv_construccion As Integer
        Get
            Return _codigo_estadoconservacion
        End Get
        Set(value As Integer)
            _codigo_estadoconservacion = value
        End Set
    End Property
    Public Property estConserv_construccion As String
        Get
            Return _estadoconservacion
        End Get
        Set(value As String)
            _estadoconservacion = value
        End Set
    End Property
    Public Property categoria_construccion As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property
    Public Property valorUnitario_construccion As Double
        Get
            Return _valor_unitario
        End Get
        Set(value As Double)
            _valor_unitario = value
        End Set
    End Property
    Public Property inc5x100_construccion As Double
        Get
            Return _inc_5x100
        End Get
        Set(value As Double)
            _inc_5x100 = value
        End Set
    End Property
    Public Property x100_dep_construccion As Double
        Get
            Return _x100_dep
        End Get
        Set(value As Double)
            _x100_dep = value
        End Set
    End Property
    Public Property valDepreciacion_construccion As Double
        Get
            Return _val_dep
        End Get
        Set(value As Double)
            _val_dep = value
        End Set
    End Property
    Public Property valUnitDep_construccion As Double
        Get
            Return _val_unidaddep
        End Get
        Set(value As Double)
            _val_unidaddep = value
        End Set
    End Property
    Public Property areaConst_construccion As Double
        Get
            Return _area_construida
        End Get
        Set(value As Double)
            _area_construida = value
        End Set
    End Property
    Public Property total_construccion As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property
    Public Property cod_ficha_construccion As Integer
        Get
            Return _cod_ficha
        End Get
        Set(value As Integer)
            _cod_ficha = value
        End Set
    End Property
    Public Property predio_construccion As String
        Get
            Return _predio
        End Get
        Set(value As String)
            _predio = value
        End Set
    End Property

End Class
