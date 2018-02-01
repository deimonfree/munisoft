Public Class class_datos_registrador
    Private _idregistrador As Integer
    Private _prenombre As String
    Private _ape_paterno As String
    Private _ape_materno As String
    Private _dni As String
    Public Property id_registrador() As Integer
        Get
            Return _idregistrador
        End Get
        Set(value As Integer)
            _idregistrador = value
        End Set
    End Property
    Public Property nombre_registrador() As String
        Get
            Return _prenombre
        End Get
        Set(value As String)
            _prenombre = value
        End Set
    End Property
    Public Property apePaterno_registrador() As String
        Get
            Return _ape_paterno
        End Get
        Set(value As String)
            _ape_paterno = value
        End Set
    End Property
    Public Property apeMaterno_registrador() As String
        Get
            Return _ape_materno
        End Get
        Set(value As String)
            _ape_materno = value
        End Set
    End Property
    Public Property dni_registrador() As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
        End Set
    End Property
End Class
