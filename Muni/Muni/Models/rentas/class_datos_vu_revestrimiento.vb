Public Class class_datos_vu_revestrimiento
    Private _idrevestimiento As Integer
    Private _cod_categorias As Integer
    Private _valor As Decimal
    Private _annio As String

    Public Property idrevestimiento As Integer
        Get
            Return _idrevestimiento
        End Get
        Set(value As Integer)
            _idrevestimiento = value
        End Set
    End Property
    'comit'
    Public Property cod_categoria As String
        Get
            Return _cod_categorias
        End Get
        Set(value As String)
            _cod_categorias = value
        End Set
    End Property
    Public Property valor As Decimal
        Get
            Return _valor
        End Get
        Set(value As Decimal)
            _valor = value
        End Set
    End Property
    Public Property annio As String
        Get
            Return _annio
        End Get
        Set(value As String)
            _annio = value
        End Set
    End Property
End Class
