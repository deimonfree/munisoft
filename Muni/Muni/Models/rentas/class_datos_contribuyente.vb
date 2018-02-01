Public Class class_datos_contribuyente
    Private _idcontribuyente As Integer
    Private _numero_doc As String
    Private _ape_pat As String
    Private _ape_mat As String
    Private _nombres As String
    Private _telefono As String
    Private _celular As String
    Private _email As String
    Private _cont_relacion As String
    Private _observacion As String
    Private _ruc As String
    Private _razon_social As String
    Private _cod_tipo_doc As Integer?
    Private _cod_urbanizacion As Integer?
    Private _cod_relacion As Integer?

    Public Property id_contribuyente As Integer
        Get
            Return _idcontribuyente
        End Get
        Set(value As Integer)
            _idcontribuyente = value
        End Set
    End Property

    Public Property numero_doc_cont As String
        Get
            Return _numero_doc
        End Get
        Set(value As String)
            _numero_doc = value
        End Set
    End Property
    Public Property apellido_paterno_cont As String
        Get
            Return _ape_pat
        End Get
        Set(value As String)
            _ape_pat = value
        End Set
    End Property
    Public Property apellido_materno_cont As String
        Get
            Return _ape_mat
        End Get
        Set(value As String)
            _ape_mat = value
        End Set
    End Property
    Public Property nombres_cont As String
        Get
            Return _nombres
        End Get
        Set(value As String)
            _nombres = value
        End Set
    End Property
    Public Property telefono_cont As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
    Public Property celular_cont As String
        Get
            Return _celular
        End Get
        Set(value As String)
            _celular = value
        End Set
    End Property
    Public Property email_contn As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
    Public Property cont_relacion_cont As String
        Get
            Return _cont_relacion
        End Get
        Set(value As String)
            _cont_relacion = value
        End Set
    End Property
    Public Property observacion_cont As String
        Get
            Return _observacion
        End Get
        Set(value As String)
            _observacion = value
        End Set
    End Property
    Public Property cod_tipo_doc As Integer?
        Get
            Return _cod_tipo_doc
        End Get
        Set(value As Integer?)
            _cod_tipo_doc = value
        End Set
    End Property
    Public Property cod_urbanizacion_cont As Integer?
        Get
            Return _cod_urbanizacion
        End Get
        Set(value As Integer?)
            _cod_urbanizacion = value
        End Set
    End Property
    Public Property cod_relacion_cont As Integer?
        Get
            Return _cod_relacion
        End Get
        Set(value As Integer?)
            _cod_relacion = value
        End Set
    End Property
    Public Property ruc_cont As String
        Get
            Return _ruc
        End Get
        Set(value As String)
            _ruc = value
        End Set
    End Property
    Public Property razonSocial_cont As String
        Get
            Return _razon_social
        End Get
        Set(value As String)
            _razon_social = value
        End Set
    End Property
End Class
