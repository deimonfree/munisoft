Public Class class_datos_relacion
    Private _idrelacion As Integer
    Private _nombre As Integer

    Public Property id_relacion As Integer
        Get
            Return _idrelacion
        End Get
        Set(value As Integer)
            _idrelacion = value
        End Set
    End Property

    Public Property nombre_relacion As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
End Class
