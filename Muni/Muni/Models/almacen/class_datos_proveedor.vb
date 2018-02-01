Public Class class_datos_proveedor
    Private _idproveedor As Integer
    Private _ruc As String
    Private _razon_social As String
    Private _direction As String
    Public Property id_proveedor() As Integer
        Get
            Return _idproveedor
        End Get
        Set(value As Integer)
            _idproveedor = value
        End Set
    End Property
    Public Property ruc_proveedor() As String
        Get
            Return _ruc
        End Get
        Set(value As String)
            _ruc = value
        End Set
    End Property
    Public Property razon_social_proveedor() As String
        Get
            Return _razon_social
        End Get
        Set(value As String)
            _razon_social = value
        End Set
    End Property
    Public Property direction_proveedor() As String
        Get
            Return _direction
        End Get
        Set(value As String)
            _direction = value
        End Set
    End Property
End Class
