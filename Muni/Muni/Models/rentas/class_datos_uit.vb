Public Class class_datos_uit
    Private _iduit As Integer
    Private _valor_uit As Decimal
    Private _annio As String

    Public Property id_uit As Integer
        Get
            Return _iduit
        End Get
        Set(value As Integer)
            _iduit = value
        End Set
    End Property

    Public Property val_uit As Decimal
        Get
            Return _valor_uit
        End Get
        Set(value As Decimal)
            _valor_uit = value
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
