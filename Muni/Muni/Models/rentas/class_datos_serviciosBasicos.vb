Public Class class_datos_serviciosBasicos
    Private _idservicios_basicos As Integer
    Private _codigo_agua As String
    Private _codigo_luz As String
    Private _codigo_telefono As String
    Private _cod_predio As Integer
    Public Property id_serviciosBasicos As Integer
        Get
            Return _idservicios_basicos
        End Get
        Set(value As Integer)
            _idservicios_basicos = value
        End Set
    End Property
    Public Property codAgua_serviciosBasicos As String
        Get
            Return _codigo_agua
        End Get
        Set(value As String)
            _codigo_agua = value
        End Set
    End Property
    Public Property codLuz_serviciosBasicos As String
        Get
            Return _codigo_luz
        End Get
        Set(value As String)
            _codigo_luz = value
        End Set
    End Property
    Public Property codTelefono_serviciosBasicos As String
        Get
            Return _codigo_telefono
        End Get
        Set(value As String)
            _codigo_telefono = value
        End Set
    End Property
    Public Property codPredio_serviciosBasicos As Integer
        Get
            Return _cod_predio
        End Get
        Set(value As Integer)
            _cod_predio = value
        End Set
    End Property


End Class
