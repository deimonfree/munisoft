Public Class class_datos_provincia
    Private _idprovincia As Integer
    Private _nombre As String
    Private _cod_departamento As Integer

    Public Property id_provincia As Integer
        Get
            Return _idprovincia
        End Get
        Set(value As Integer)
            _idprovincia = value
        End Set
    End Property

    Public Property nombre_provincia As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property cod_departamento As Integer
        Get
            Return _cod_departamento
        End Get
        Set(value As Integer)
            _cod_departamento = value
        End Set
    End Property
End Class
