Public Class class_datos_direccion
    Private _iddireccion As Integer
    Private _sector As String
    Private _mzna As String
    Private _via As String
    Private _lote As String
    Private _numero As String
    Private _departamento As String
    Private _zona As String
    Private _piso As String
    Private _cod_contribuyente As Integer
    Private _cod_tipovia As Integer
    Private _cod_distrito As Integer

    Public Property id_direccion As Integer
        Get
            Return _iddireccion
        End Get
        Set(value As Integer)
            _iddireccion = value
        End Set
    End Property

    Public Property numero_direccion As String
        Get
            Return _numero
        End Get
        Set(value As String)
            _numero = value
        End Set
    End Property
    Public Property zona_direccion As String
        Get
            Return _zona
        End Get
        Set(value As String)
            _zona = value
        End Set
    End Property
    Public Property mzna_direccion As String
        Get
            Return _mzna
        End Get
        Set(value As String)
            _mzna = value
        End Set
    End Property
    Public Property via_direccion As String
        Get
            Return _via
        End Get
        Set(value As String)
            _via = value
        End Set
    End Property
    Public Property lote_direccion As String
        Get
            Return _lote
        End Get
        Set(value As String)
            _lote = value
        End Set
    End Property
    Public Property sector_direccion As String
        Get
            Return _sector
        End Get
        Set(value As String)
            _sector = value
        End Set
    End Property
    Public Property departamento_direccion As String
        Get
            Return _departamento
        End Get
        Set(value As String)
            _departamento = value
        End Set
    End Property
    Public Property piso_direccion As String
        Get
            Return _piso
        End Get
        Set(value As String)
            _piso = value
        End Set
    End Property
    Public Property codContribuyente_direccion As Integer
        Get
            Return _cod_contribuyente
        End Get
        Set(value As Integer)
            _cod_contribuyente = value
        End Set
    End Property
    Public Property codTipoVia_direccion As Integer
        Get
            Return _cod_tipovia
        End Get
        Set(value As Integer)
            _cod_tipovia = value
        End Set
    End Property
    Public Property codDistrito_direccion As Integer
        Get
            Return _cod_distrito
        End Get
        Set(value As Integer)
            _cod_distrito = value
        End Set
    End Property
End Class
