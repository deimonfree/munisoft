Public Class class_datos_distrito
    Private _iddistrito As Integer
    Private _nombre As String
    Private _cod_provincia As Integer

    Public Property id_distrito As Integer
        Get
            Return _iddistrito
        End Get
        Set(value As Integer)
            _iddistrito = value
        End Set
    End Property

    Public Property nombre_distrito As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property cod_provincia As Integer
        Get
            Return _cod_provincia
        End Get
        Set(value As Integer)
            _cod_provincia = value
        End Set
    End Property
End Class
