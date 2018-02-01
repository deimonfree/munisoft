Public Class class_datos_zonas
    Private _id As Integer
    Private _nombre As String
    Private _ape_paterno As String
    Private _ape_materno As String
    Private _tipo_doc As String
    Private _dni As String
    Private _nacionalidad As String
    Private _estado_civil As String
    Private _fecha_nac As Date
    Private _centro_poblado As String
    Private _distrito As Integer
    Public Property id_ciudadano() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property nombre_ciudadano As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property apePat_ciudadano As String
        Get
            Return _ape_paterno
        End Get
        Set(value As String)
            _ape_paterno = value
        End Set
    End Property
    Public Property apeMat_ciudadano As String
        Get
            Return _ape_materno
        End Get
        Set(value As String)
            _ape_materno = value
        End Set
    End Property
    Public Property tipoDoc_ciudadano As String
        Get
            Return _tipo_doc
        End Get
        Set(value As String)
            _tipo_doc = value
        End Set
    End Property
    Public Property dni_ciudadano As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
        End Set
    End Property

    Public Property nacionalidad_ciudadano As String
        Get
            Return _nacionalidad
        End Get
        Set(value As String)
            _nacionalidad = value
        End Set
    End Property
    Public Property estadoCivil_ciudadano As String
        Get
            Return _estado_civil
        End Get
        Set(value As String)
            _estado_civil = value
        End Set
    End Property
    Public Property fechaNac_ciudadano As Date
        Get
            Return _fecha_nac
        End Get
        Set(value As Date)
            _fecha_nac = value
        End Set
    End Property
    Public Property centroPobla_ciudadano As String
        Get
            Return _centro_poblado
        End Get
        Set(value As String)
            _centro_poblado = value
        End Set
    End Property
    Public Property distrito_ciudadano As String
        Get
            Return _distrito
        End Get
        Set(value As String)
            _distrito = value
        End Set
    End Property
End Class
