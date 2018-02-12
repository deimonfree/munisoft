Public Class class_datos_log_login
    Private _id_log_usuarios As Integer
    Private _user As String
    Private _namepc As String
    Private _fecha As String
    Private _ip As String

    Public Property id_log_usuarios As Integer
        Get
            Return _id_log_usuarios
        End Get
        Set(value As Integer)
            _id_log_usuarios = value
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
    Public Property fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
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

End Class
