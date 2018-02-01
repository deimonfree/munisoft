Public Class class_datos_valorArancelario
    Private _idvalor_arancelario As Integer
    Private _cod_via As Integer
    Private _cod_anno As Integer
    Private _valor As Double
    Private _cuadra As Integer

    Public Property id_valorArancelario As Integer
        Get
            Return _idvalor_arancelario
        End Get
        Set(value As Integer)
            _idvalor_arancelario = value
        End Set
    End Property
    Public Property codVia_valorArancelario As Integer
        Get
            Return _cod_via
        End Get
        Set(value As Integer)
            _cod_via = value
        End Set
    End Property
    Public Property codAnno_valorArancelario As Integer
        Get
            Return _cod_anno
        End Get
        Set(value As Integer)
            _cod_anno = value
        End Set
    End Property
    Public Property valor_valorArancelario As Double
        Get
            Return _valor
        End Get
        Set(value As Double)
            _valor = value
        End Set
    End Property
    Public Property cuadra_valorArancelario As Integer
        Get
            Return _cuadra
        End Get
        Set(value As Integer)
            _cuadra = value
        End Set
    End Property
End Class
