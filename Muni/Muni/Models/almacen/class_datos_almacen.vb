Public Class class_datos_almacen
    Private _idalmacen As Integer
    Private _tipo As String
    Private _asociado As String
    Private _direction As String
    Private _encargado As String
    Private _capacidad As String
    Public Property id_almacen() As Integer
        Get
            Return _idalmacen
        End Get
        Set(value As Integer)
            _idalmacen = value
        End Set
    End Property
    Public Property tipo_almacen() As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property
    Public Property asociado_almacen() As String
        Get
            Return _asociado
        End Get
        Set(value As String)
            _asociado = value
        End Set
    End Property
    Public Property direction_almacen() As String
        Get
            Return _direction
        End Get
        Set(value As String)
            _direction = value
        End Set
    End Property
    Public Property encargado_almacen() As String
        Get
            Return _encargado
        End Get
        Set(value As String)
            _encargado = value
        End Set
    End Property
    Public Property capacidad() As String
        Get
            Return _capacidad
        End Get
        Set(value As String)
            _capacidad = value
        End Set
    End Property

End Class
