Public Class class_datos_representanteLegal
    Private _idrepresentante_legal As Integer
    Private _nombre As String
    Private _ape_peterno As String
    Private _ape_materno As String
    Private _cod_identificacion As Integer
    Private _numero_identificacion As String
    Private _cod_tipovia As Integer
    Private _nombre_vias As String
    Private _numero As String
    Private _manzana As String
    Private _lote As String
    Private _nombre_apartamento As String
    Private _numero_apartamento As String
    Private _cod_urbanizacion As String
    Private _nombre_urbanizacion As String
    Private _cod_contribuyente As Integer
    Private _cargo As String
    Private _telefono As String


    Public Property id_representanteLegal As Integer
        Get
            Return _idrepresentante_legal
        End Get
        Set(value As Integer)
            _idrepresentante_legal = value
        End Set
    End Property
    Public Property nombre_representanteLegal As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property apePat_representanteLegal As String
        Get
            Return _ape_peterno
        End Get
        Set(value As String)
            _ape_peterno = value
        End Set
    End Property
    Public Property apeMat_representanteLegal As String
        Get
            Return _ape_materno
        End Get
        Set(value As String)
            _ape_materno = value
        End Set
    End Property
    Public Property codidentificacion_representanteLegal As Integer
        Get
            Return _cod_identificacion
        End Get
        Set(value As Integer)
            _cod_identificacion = value
        End Set
    End Property
    Public Property numeroDoc_representanteLegal As String
        Get
            Return _numero_identificacion
        End Get
        Set(value As String)
            _numero_identificacion = value
        End Set
    End Property
    Public Property codVia_representanteLegal As Integer
        Get
            Return _cod_tipovia
        End Get
        Set(value As Integer)
            _cod_tipovia = value
        End Set
    End Property
    Public Property nomVia_representanteLegal As String
        Get
            Return _nombre_vias
        End Get
        Set(value As String)
            _nombre_vias = value
        End Set
    End Property
    Public Property numero_representanteLegal As String
        Get
            Return _numero
        End Get
        Set(value As String)
            _numero = value
        End Set
    End Property
    Public Property manzana_representanteLegal As String
        Get
            Return _manzana
        End Get
        Set(value As String)
            _manzana = value
        End Set
    End Property

    Public Property lote_representanteLegal As String
        Get
            Return _lote
        End Get
        Set(value As String)
            _lote = value
        End Set
    End Property
    Public Property nomApart_representanteLegal As String
        Get
            Return _nombre_apartamento
        End Get
        Set(value As String)
            _nombre_apartamento = value
        End Set
    End Property
    Public Property numApart_representanteLegal As String
        Get
            Return _numero_apartamento
        End Get
        Set(value As String)
            _numero_apartamento = value
        End Set
    End Property
    Public Property codUrbanizacion_representanteLegal As Integer
        Get
            Return _cod_urbanizacion
        End Get
        Set(value As Integer)
            _cod_urbanizacion = value
        End Set
    End Property
    Public Property nomUrbanizacion_representanteLegal As String
        Get
            Return _nombre_urbanizacion
        End Get
        Set(value As String)
            _nombre_urbanizacion = value
        End Set
    End Property
    Public Property codContribuyente_representanteLegal As Integer
        Get
            Return _cod_contribuyente
        End Get
        Set(value As Integer)
            _cod_contribuyente = value
        End Set
    End Property
    Public Property cargo_representanteLegal As String
        Get
            Return _cargo
        End Get
        Set(value As String)
            _cargo = value
        End Set
    End Property
    Public Property telefono_representanteLegal As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
End Class
