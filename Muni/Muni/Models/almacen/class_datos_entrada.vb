Public Class class_datos_entrada
    Private _identrada As Integer
    Private _fecha As Date
    Private _gui_fac As String
    Private _glosa As String
    Private _cod_area As Integer
    Private _cod_almacen As Integer
    Private _cod_te As Integer
    Private _cod_proveedor As Integer
    Public Property id_entrada As Integer
        Get
            Return _identrada
        End Get
        Set(value As Integer)
            _identrada = value
        End Set
    End Property
    Public Property fecha_entrada As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property guiFac_entrada As String
        Get
            Return _gui_fac
        End Get
        Set(value As String)
            _gui_fac = value
        End Set
    End Property
    Public Property glosa_entrada As String
        Get
            Return _glosa
        End Get
        Set(value As String)
            _glosa = value
        End Set
    End Property
    Public Property codArea_entrada As Integer
        Get
            Return _cod_area
        End Get
        Set(value As Integer)
            _cod_area = value
        End Set
    End Property
    Public Property codAlmacen_entrada As Integer
        Get
            Return _cod_almacen
        End Get
        Set(value As Integer)
            _cod_almacen = value
        End Set
    End Property
    Public Property codTE_entrada As Integer
        Get
            Return _cod_te
        End Get
        Set(value As Integer)
            _cod_te = value
        End Set
    End Property
    Public Property codProveedor_entrada As Integer
        Get
            Return _cod_proveedor
        End Get
        Set(value As Integer)
            _cod_proveedor = value
        End Set
    End Property
End Class
