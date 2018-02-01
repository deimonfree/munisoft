Public Class class_datos_valor_minimo
    Private _idvalor_minimo As Integer
    Private _valor_minimo As Decimal
    Private _annio As String

    Public Property id_valor_minimo As Integer
        Get
            Return _idvalor_minimo
        End Get
        Set(value As Integer)
            _idvalor_minimo = value
        End Set
    End Property

    Public Property val_minimo As Decimal
        Get
            Return _valor_minimo
        End Get
        Set(value As Decimal)
            _valor_minimo = value
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
