Public Class class_datos_autovaluo
    Private _idautovaluo As Integer
    Private _valor_autovaluo As String
    Private _annio As String
    Private _estado As String
    Private _cod_ficha As Integer

    Public Property id_autovaluo As Integer
        Get
            Return _idautovaluo
        End Get
        Set(value As Integer)
            _idautovaluo = value
        End Set
    End Property
    Public Property valor_autovaluo As String
        Get
            Return _valor_autovaluo
        End Get
        Set(value As String)
            _valor_autovaluo = value
        End Set
    End Property
    Public Property annio_autovaluo As String
        Get
            Return _annio
        End Get
        Set(value As String)
            _annio = value
        End Set
    End Property
    Public Property estado_autovaluo As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property
    Public Property cod_ficaha_autovaluo As Integer
        Get
            Return _cod_ficha
        End Get
        Set(value As Integer)
            _cod_ficha = value
        End Set
    End Property
End Class
