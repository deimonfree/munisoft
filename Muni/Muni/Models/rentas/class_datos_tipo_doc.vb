Public Class class_datos_tipo_doc
    Private _idtipo_doc As Integer
    Private _nombre As String

    Public Property id_tipo_doc As Integer
        Get
            Return _idtipo_doc
        End Get
        Set(value As Integer)
            _idtipo_doc = value
        End Set
    End Property

    Public Property nombre_tipo_doc As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
End Class
