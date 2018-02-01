Public Class class_datos_sociedadConyugal
    Private _idsociedad_conyugal As Integer
    Private _num_identificacion As String
    Private _nombre_completo As String
    Private _cod_contribuyente As Integer
    Public Property id_sociedadConyugal As Integer
        Get
            Return _idsociedad_conyugal
        End Get
        Set(value As Integer)
            _idsociedad_conyugal = value
        End Set
    End Property
    Public Property numIdentificacion_sociedadConyugal As String
        Get
            Return _num_identificacion
        End Get
        Set(value As String)
            _num_identificacion = value
        End Set
    End Property
    Public Property nombreCompleto_sociedadConyugal As String
        Get
            Return _nombre_completo
        End Get
        Set(value As String)
            _nombre_completo = value
        End Set
    End Property
    Public Property codContri_sociedadConyugal As Integer
        Get
            Return _cod_contribuyente
        End Get
        Set(value As Integer)
            _cod_contribuyente = value
        End Set
    End Property


End Class
