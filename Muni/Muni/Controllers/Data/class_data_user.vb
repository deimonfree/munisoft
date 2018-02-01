Public Class class_data_user
    Private _iduser As Integer
    Private _usuario As String
    Private _password As String
    Public Property iduser_user As Integer
        Get
            Return _iduser
        End Get
        Set(value As Integer)
            _iduser = value
        End Set
    End Property
    Public Property usuario_user As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property
    Public Property password_user As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property
End Class
