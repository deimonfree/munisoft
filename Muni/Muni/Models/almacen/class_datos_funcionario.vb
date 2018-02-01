Public Class class_datos_funcionario
    Private _idfuncionario As Integer
    Private _nombre As String
    Private _ape_pat As String
    Private _ape_mat As String
    Private _sexo As String
    Private _direction As String
    Private _telefono As String
    Private _cod_area As Integer
    Public Property id_funcionario As Integer
        Get
            Return _idfuncionario
        End Get
        Set(value As Integer)
            _idfuncionario = value
        End Set
    End Property
    Public Property nombre_funcionario As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property ape_pat_funcionario As String
        Get
            Return _ape_pat
        End Get
        Set(value As String)
            _ape_pat = value
        End Set
    End Property
    Public Property ape_mat_funcionario As String
        Get
            Return _ape_mat
        End Get
        Set(value As String)
            _ape_mat = value
        End Set
    End Property
    Public Property sexo_funcionario As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
        End Set
    End Property
    Public Property direction As String
        Get
            Return _direction
        End Get
        Set(value As String)
            _direction = value
        End Set
    End Property
    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
    Public Property cod_area_funcionario As Integer
        Get
            Return _cod_area
        End Get
        Set(value As Integer)
            _cod_area = value
        End Set
    End Property
End Class
