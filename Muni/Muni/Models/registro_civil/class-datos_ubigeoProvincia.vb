Public Class class_datos_ubigeoProvincia
    Private _id As Integer
    Private _nombre As String
    Private _cod_departamento As Integer
    Public Property id_ubigeoProvincia() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property nombre_ubigeoProvincia() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property codDep_ubigeoProvincia() As Integer
        Get
            Return _cod_departamento
        End Get
        Set(value As Integer)
            _cod_departamento = value
        End Set
    End Property
End Class
