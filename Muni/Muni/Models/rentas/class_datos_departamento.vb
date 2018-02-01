Public Class class_datos_departamento
    Private _iddepartamento As Integer
    Private _nombre As String

    Public Property id_departamento As Integer
        Get
            Return _iddepartamento
        End Get
        Set(value As Integer)
            _iddepartamento = value
        End Set
    End Property

    Public Property nombre_departamento As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
End Class
