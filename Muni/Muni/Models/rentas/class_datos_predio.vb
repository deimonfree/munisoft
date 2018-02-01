Public Class class_datos_predio
    Private _idpredio As Integer
    Private _cod_via As Integer
    Private _numero As String
    Private _ensiso_numeracion As String
    Private _cuadra As String
    Private _nro_lote As String
    Private _cod_contribuyente As Integer
    Private _cod_gc As Integer
    Private _cod_sector As Integer
    Private _estado As String
    Private _col_este As String
    Private _col_oeste As String
    Private _col_norte As String
    Private _col_sur As String

    Public Property id_predio As Integer
        Get
            Return _idpredio
        End Get
        Set(value As Integer)
            _idpredio = value
        End Set
    End Property


    Public Property codVia_predio As Integer
        Get
            Return _cod_via
        End Get
        Set(value As Integer)
            _cod_via = value
        End Set
    End Property
    Public Property numero_predio As String
        Get
            Return _numero
        End Get
        Set(value As String)
            _numero = value
        End Set
    End Property
    Public Property ensisoNum_predio As String
        Get
            Return _ensiso_numeracion
        End Get
        Set(value As String)
            _ensiso_numeracion = value
        End Set
    End Property
    Public Property cuadra_predio As String
        Get
            Return _cuadra
        End Get
        Set(value As String)
            _cuadra = value
        End Set
    End Property
    Public Property nroLote_predio As String
        Get
            Return _nro_lote
        End Get
        Set(value As String)
            _nro_lote = value
        End Set
    End Property
    Public Property cod_contribuyente_predio As Integer
        Get
            Return _cod_contribuyente
        End Get
        Set(value As Integer)
            _cod_contribuyente = value
        End Set
    End Property
    Public Property cod_grupoCatastral_predio As Integer
        Get
            Return _cod_gc
        End Get
        Set(value As Integer)
            _cod_gc = value
        End Set
    End Property
    Public Property codSector_predio As Integer
        Get
            Return _cod_sector
        End Get
        Set(value As Integer)
            _cod_sector = value
        End Set
    End Property
    Public Property estado_predio As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property
    Public Property colindaEste_predio As String
        Get
            Return _col_este
        End Get
        Set(value As String)
            _col_este = value
        End Set
    End Property
    Public Property colindaOeste_predio As String
        Get
            Return _col_oeste
        End Get
        Set(value As String)
            _col_oeste = value
        End Set
    End Property
    Public Property colindaNorte_predio As String
        Get
            Return _col_norte
        End Get
        Set(value As String)
            _col_norte = value
        End Set
    End Property
    Public Property colindaSur_predio As String
        Get
            Return _col_sur
        End Get
        Set(value As String)
            _col_sur = value
        End Set
    End Property
End Class
