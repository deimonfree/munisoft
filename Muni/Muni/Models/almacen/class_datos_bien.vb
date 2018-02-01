Public Class class_datos_bien
    Private _idbien As Integer
    Private _codigo As String
    Private _nombre As String
    Private _stock_minimo As String
    Private _stock_maximo As String
    Private _existencia_actual As Integer
    Private _cod_unidad As Integer

    Public Property id_bien() As Integer
        Get
            Return _idbien
        End Get
        Set(value As Integer)
            _idbien = value
        End Set
    End Property
    Public Property codigo_bien() As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property stock_minimo_bien() As String
        Get
            Return _stock_minimo
        End Get
        Set(value As String)
            _stock_minimo = value
        End Set
    End Property
    Public Property stock_maximo_bien() As String
        Get
            Return _stock_maximo
        End Get
        Set(value As String)
            _stock_maximo = value
        End Set
    End Property
    Public Property existencia_actual_bien() As Integer
        Get
            Return _existencia_actual
        End Get
        Set(value As Integer)
            _existencia_actual = value
        End Set
    End Property
    Public Property cod_unidad_bien() As Integer
        Get
            Return _cod_unidad
        End Get
        Set(value As Integer)
            _cod_unidad = value
        End Set
    End Property


End Class
