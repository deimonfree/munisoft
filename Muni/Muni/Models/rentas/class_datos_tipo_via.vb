Public Class class_datos_tipo_via
    Private _idtipo_via As Integer
    Private _nom_tipovia As String

    Public Property id_tipoVia As Integer
        Get
            Return _idtipo_via
        End Get
        Set(value As Integer)
            _idtipo_via = value
        End Set
    End Property

    Public Property nombre_tipoVia As String
        Get
            Return _nom_tipovia
        End Get
        Set(value As String)
            _nom_tipovia = value
        End Set
    End Property
End Class
