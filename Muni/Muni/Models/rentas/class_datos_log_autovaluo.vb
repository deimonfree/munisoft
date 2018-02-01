Public Class class_datos_log_autovaluo
    Private _id_log_autovaluo As Integer
    Private _user As String
    Private _namepc As String
    Private _ip As String
    Private _fecha As String
    Private _base As String
    Private _annio As String
    Private _cod_contri As Integer

    Public Property id_log_autovaluo As Integer
        Get
            Return _id_log_autovaluo
        End Get
        Set(value As Integer)
            _id_log_autovaluo = value
        End Set
    End Property
    Public Property user As String
        Get
            Return _user
        End Get
        Set(value As String)
            _user = value
        End Set
    End Property
    Public Property namepc As String
        Get
            Return _namepc
        End Get
        Set(value As String)
            _namepc = value
        End Set
    End Property
    Public Property ip As String
        Get
            Return _ip
        End Get
        Set(value As String)
            _ip = value
        End Set
    End Property
    Public Property fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property
    Public Property base As String
        Get
            Return _base
        End Get
        Set(value As String)
            _base = value
        End Set
    End Property
    Public Property annio As String
        Get
            Return _annio
        End Get
        Set(value As String)
            _annio = value
        End Set
    End Property
    Public Property cod_contri As Integer
        Get
            Return _cod_contri
        End Get
        Set(value As Integer)
            _cod_contri = value
        End Set
    End Property

End Class
