Public Class class_datos_ficha
    Private _idficha As Integer
    Private _codigo_ficha As String
    Private _anio_ficha As Integer
    Private _numero_ficha As String
    Private _numero_djj As String
    Private _arancel As Double
    Private _valor As Double
    Private _condicion_titular As String
    Private _mod_adq As String
    Private _fecha_adq As Date
    Private _area_terreno As Double
    Private _area_comun As Double
    Private _area_construida As Double
    Private _area_frentera As Double
    Private _uso_predial As Integer
    Private _distancia_parque As Double
    Private _num_habitantes As Integer
    Private _cod_predio As Integer
    Private _cod_tipoficha As Integer
    Private _valor_terreno As Double
    Private _valor_construccion As Double
    Private _base_imponible As Double
    Private _valor_deduccion As Double
    Private _tipo_deduccion As String
    Private _total_base_imponible As Double
    Private _estado_predial As Integer
    Private _tipo_predial As Integer
    Private _cod_deduccion As Integer
    Public Property id_ficha As Integer
        Get
            Return _idficha
        End Get
        Set(value As Integer)
            _idficha = value
        End Set
    End Property
    Public Property codigo_ficha As String
        Get
            Return _codigo_ficha
        End Get
        Set(value As String)
            _codigo_ficha = value
        End Set
    End Property
    Public Property anno_ficha As Integer
        Get
            Return _anio_ficha
        End Get
        Set(value As Integer)
            _anio_ficha = value
        End Set
    End Property
    Public Property numero_ficha As String
        Get
            Return _numero_ficha
        End Get
        Set(value As String)
            _numero_ficha = value
        End Set
    End Property
    Public Property numero_djj_ficha As String
        Get
            Return _numero_djj
        End Get
        Set(value As String)
            _numero_djj = value
        End Set
    End Property
    Public Property arancel_ficha As Double
        Get
            Return _arancel
        End Get
        Set(value As Double)
            _arancel = value
        End Set
    End Property
    Public Property valor_ficha As Double
        Get
            Return _valor
        End Get
        Set(value As Double)
            _valor = value
        End Set
    End Property
    Public Property condicion_titular_fichas As String
        Get
            Return _condicion_titular
        End Get
        Set(value As String)
            _condicion_titular = value
        End Set
    End Property
    Public Property modo_adquisicion_ficha As String
        Get
            Return _mod_adq
        End Get
        Set(value As String)
            _mod_adq = value
        End Set
    End Property
    Public Property fecha_adquisicion_fichas As Date
        Get
            Return _fecha_adq
        End Get
        Set(value As Date)
            _fecha_adq = value
        End Set
    End Property
    Public Property area_terreno_ficha As Double
        Get
            Return _area_terreno
        End Get
        Set(value As Double)
            _area_terreno = value
        End Set
    End Property
    Public Property area_comun_ficha As Double
        Get
            Return _area_comun
        End Get
        Set(value As Double)
            _area_comun = value
        End Set
    End Property
    Public Property area_construida_fichas As Double
        Get
            Return _area_construida
        End Get
        Set(value As Double)
            _area_construida = value
        End Set
    End Property
    Public Property area_frentera_fichas As Double
        Get
            Return _area_frentera
        End Get
        Set(value As Double)
            _area_frentera = value
        End Set
    End Property
    Public Property uso_predial_ficha As Integer
        Get
            Return _uso_predial
        End Get
        Set(value As Integer)
            _uso_predial = value
        End Set
    End Property
    Public Property distancia_parque_ficha As Double
        Get
            Return _distancia_parque
        End Get
        Set(value As Double)
            _distancia_parque = value
        End Set
    End Property
    Public Property numero_habitante_ficha As Integer
        Get
            Return _num_habitantes
        End Get
        Set(value As Integer)
            _num_habitantes = value
        End Set
    End Property

    Public Property cod_predio As Integer
        Get
            Return _cod_predio
        End Get
        Set(value As Integer)
            _cod_predio = value
        End Set
    End Property
    Public Property cod_tipo_ficha As Integer
        Get
            Return _cod_tipoficha
        End Get
        Set(value As Integer)
            _cod_tipoficha = value
        End Set
    End Property
    Public Property valorTerreno_ficha As Double
        Get
            Return _valor_terreno
        End Get
        Set(value As Double)
            _valor_terreno = value
        End Set
    End Property
    Public Property valorConstruccion_ficha As Double
        Get
            Return _valor_construccion
        End Get
        Set(value As Double)
            _valor_construccion = value
        End Set
    End Property
    Public Property baseImponible_ficha As Double
        Get
            Return _base_imponible
        End Get
        Set(value As Double)
            _base_imponible = value
        End Set
    End Property
    Public Property valorDeduccion_ficha As Double
        Get
            Return _valor_deduccion
        End Get
        Set(value As Double)
            _valor_deduccion = value
        End Set
    End Property
    Public Property tipoDeduccion_ficha As String
        Get
            Return _tipo_deduccion
        End Get
        Set(value As String)
            _tipo_deduccion = value
        End Set
    End Property
    Public Property totalBaseimpDeduccion_ficha As Double
        Get
            Return _total_base_imponible
        End Get
        Set(value As Double)
            _total_base_imponible = value
        End Set
    End Property
    Public Property estadoPredio_ficha As Integer
        Get
            Return _estado_predial
        End Get
        Set(value As Integer)
            _estado_predial = value
        End Set
    End Property
    Public Property tipoPredio_ficha As Integer
        Get
            Return _tipo_predial
        End Get
        Set(value As Integer)
            _tipo_predial = value
        End Set
    End Property
    Public Property codDeduccion_ficha As Integer
        Get
            Return _cod_deduccion
        End Get
        Set(value As Integer)
            _cod_deduccion = value
        End Set
    End Property

End Class
