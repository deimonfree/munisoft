Public Class class_datos_zona
    Private _idzona As Integer
    Private _nombre As String

    Public Property id_zona As Integer
        Get
            Return _idzona
        End Get
        Set(value As Integer)
            _idzona = value
        End Set
    End Property

    Public Property nombre_zona As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
End Class
