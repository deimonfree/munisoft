Public Class class_datos_ubigeoDistrito
    Private _id As Integer
    Private _nombre As String
    Private _cod_provincia As Integer
    Public Property id_ubigeoDistrito() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property nombre_ubigeoDistrito() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property codPro_ubigeoDistrito() As Integer
        Get
            Return _cod_provincia
        End Get
        Set(value As Integer)
            _cod_provincia = value
        End Set
    End Property
End Class
